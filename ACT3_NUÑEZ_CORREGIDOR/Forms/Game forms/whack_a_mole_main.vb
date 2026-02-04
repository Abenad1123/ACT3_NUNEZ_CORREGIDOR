Public Class whack_a_mole_main
    Dim standard_timeDuration As Integer

    Dim timeDuration As Integer
    Dim playerScore As Integer
    Dim highestPlayerScore As Integer
    Dim inactiveMoles As New List(Of PictureBox)
    Dim activeMoles As New List(Of PictureBox)

    Dim rnd As New Random()

    Dim hammer_click As New Cursor(New IO.MemoryStream(My.Resources.hammer_click))
    Dim hammer_idle As New Cursor(New IO.MemoryStream(My.Resources.hammer_idle))

    Dim GameRunning As Boolean = False

    Private Sub Game1_Load(sender As Object, e As EventArgs) Handles rockpaperscissors.Click
        OpenForm(Of rock_paper_scissors_main)(Me)
    End Sub

    Private Sub Game2_Load(sender As Object, e As EventArgs) Handles fallingblock.Click
        OpenForm(Of evade_a_missile_main)(Me)
    End Sub

    Private Sub Game3_Load(sender As Object, e As EventArgs) Handles whackamole.Click
        OpenForm(Of whack_a_mole_main)(Me)
    End Sub

    Private Sub Game4_Load(sender As Object, e As EventArgs) Handles reactiontime.Click
        OpenForm(Of reactiontime)(Me)
    End Sub

    Private Sub Game5_Load(sender As Object, e As EventArgs) Handles mathchallenge.Click
        OpenForm(Of mathchallenge)(Me)
    End Sub


    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        OpenForm(Of whack_a_mole_settings)(Me)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Cursor = hammer_idle
        InitialData()
        MsgBox("Welcome to Whack-A-Mole! Click on the moles as they appear to score points. You have 60 seconds. Good luck!")
    End Sub

    Private Sub Start_Game(sender As Object, e As EventArgs) Handles Button7.Click
        If GameRunning = False Then
            GameRunning = True
            TimerTick()
            SpawnMoles()
        End If
    End Sub
    Private Async Sub TimerTick()
        Label2.Text = "TIME LEFT : " & timeDuration & "s"
        While GameRunning
            Await Task.Delay(1000)
            timeDuration -= 1
            Label2.Text = "TIME LEFT : " & timeDuration & "s"
            If timeDuration <= 0 Then
                GameRunning = False
                If playerScore > highestPlayerScore Then
                    MessageBox.Show("Time's up! Your score: " & playerScore & ". Wow! you achieved the highest score")
                Else
                    MessageBox.Show("Time's up! Your score: " & playerScore)
                End If

                InitialData()
            End If
        End While
    End Sub

    Private Async Sub SpawnMoles()
        While GameRunning
            If inactiveMoles.Count > 0 Then
                Await Task.Delay(rnd.Next(900, 1500))
                Dim index As Integer = rnd.Next(0, inactiveMoles.Count)
                Dim block As PictureBox = inactiveMoles(index)

                inactiveMoles.RemoveAt(index)
                activeMoles.Add(block)

                block.Image = My.Resources.mole_show
                IndivMoleDespawn(block)
            End If

        End While
    End Sub

    Private Async Sub IndivMoleDespawn(mole As PictureBox)
        If activeMoles.Contains(mole) Then
            Await Task.Delay(rnd.Next(2000, 4000))
            activeMoles.Remove(mole)
            inactiveMoles.Add(mole)
            mole.Image = My.Resources.mole_empty
        End If
    End Sub

    Private Sub InitialData()
        inactiveMoles = New List(Of PictureBox) From {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
        timeDuration = standard_timeDuration
        playerScore = 0
        Label1.Text = "SCORE : " & playerScore
        Label3.Text = "HIGHEST SCORE : " & highestPlayerScore
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ScoreAdd(PictureBox1)
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ScoreAdd(PictureBox2)
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ScoreAdd(PictureBox3)
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ScoreAdd(PictureBox4)
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ScoreAdd(PictureBox5)
    End Sub

    Private Sub Bt6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        ScoreAdd(PictureBox6)
    End Sub
    Private Sub Mouse_Relase(sender As Object, e As EventArgs) Handles PictureBox1.MouseUp, PictureBox2.MouseUp, PictureBox3.MouseUp, PictureBox4.MouseUp, PictureBox5.MouseUp, PictureBox6.MouseUp
        Me.Cursor = hammer_idle
    End Sub

    Private Sub Mouse_Click(sender As Object, e As EventArgs) Handles PictureBox1.MouseDown, PictureBox2.MouseDown, PictureBox3.MouseDown, PictureBox4.MouseDown, PictureBox5.MouseDown, PictureBox6.MouseDown
        Me.Cursor = hammer_click
    End Sub


    Private Sub ScoreAdd(mole As PictureBox)
        If activeMoles.Contains(mole) Then
            playerScore += 1
            Label1.Text = "SCORE : " & playerScore
            If playerScore > highestPlayerScore Then
                highestPlayerScore = playerScore
                Label3.Text = "HIGHEST SCORE : " & highestPlayerScore
            End If
            MoleAnimate(mole)

            activeMoles.Remove(mole)
            inactiveMoles.Add(mole)
        End If
    End Sub

    Private Async Sub MoleAnimate(mole As PictureBox)
        mole.Image = My.Resources.mole_hit
        Await Task.Delay(40)
        mole.Image = My.Resources.mole_hit_2
        Await Task.Delay(50)
        mole.Image = My.Resources.mole_hit_3
        Await Task.Delay(60)
        mole.Image = My.Resources.mole_empty
    End Sub
End Class