Public Class evade_a_missile_main

    Dim playerPosition As Integer = 2
    Dim gameStart As Boolean = False
    Dim playerScore As Integer = 0
    Dim playerHighScore As Integer = 0
    Dim rnd As New Random()

    Dim inactiveBlocks As List(Of Control)
    Dim activeBlocks As New List(Of Control)
    Dim isDead As Boolean = False
    Private Sub go_back_click(sender As Object, e As EventArgs) Handles go_back.Click
        OpenForm(Of main_menu)(Me)
    End Sub
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
        OpenForm(Of reactiontime_main)(Me)
    End Sub

    Private Sub Game5_Load(sender As Object, e As EventArgs) Handles mathchallenge.Click
        OpenForm(Of mathchallenge_main)(Me)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetBlocks()
        MsgBox("Welcome to Falling Block! Use A and D to move.")
    End Sub

    Private Sub FitSize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim blocks() As Control = {PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
        For Each block As Control In blocks
            block.Width = block.Parent.ClientSize.Width * 0.3
        Next
    End Sub

    Private Sub Key_Control(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Not gameStart Then
            gameStart = True
            isDead = False
            StartGame()
            RandomBlock()
            Score()
        End If

        Select Case e.KeyCode
            Case Keys.A : If playerPosition > 0 Then playerPosition -= 1
            Case Keys.D : If playerPosition < 4 Then playerPosition += 1
        End Select

        UpdateUserPosition()
    End Sub

    Private Sub UpdateUserPosition()
        TableLayoutPanel1.SetColumn(PictureBox1, playerPosition)
    End Sub

    Private Async Sub RandomBlock()
        While gameStart
            Await Task.Delay(1000)

            If inactiveBlocks.Count = 0 Then Continue While

            Dim index As Integer = rnd.Next(inactiveBlocks.Count)
            Dim block As Control = inactiveBlocks(index)

            inactiveBlocks.RemoveAt(index)
            activeBlocks.Add(block)

            block.Top = 0
            block.Visible = True
        End While
    End Sub

    Private Sub MoveBlocks()
        If isDead Then Exit Sub

        For Each block As Control In activeBlocks
            block.Top += 2
        Next

        CheckPlayer()

        For Each block As Control In activeBlocks.ToList()
            If block.Bottom >= block.Parent.ClientSize.Height Then
                inactiveBlocks.Add(block)
                activeBlocks.Remove(block)
                block.Top = 0
                block.Visible = False
            End If
        Next
    End Sub


    Private Async Sub StartGame()
        While gameStart
            Await Task.Delay(10)
            MoveBlocks()
        End While
    End Sub

    Private Async Sub Score()
        While gameStart
            Await Task.Delay(1000)
            playerScore += 1
            Label1.Text = "Score : " & playerScore
            If playerScore > playerHighScore Then
                playerHighScore = playerScore
                Label2.Text = "High Score : " & playerHighScore
            End If
        End While
    End Sub

    Private Sub CheckPlayer()
        If isDead Then Exit Sub

        Dim hit As Boolean =
        (PictureBox6.Bottom >= Panel1.ClientSize.Height AndAlso playerPosition = 0) OrElse
        (PictureBox5.Bottom >= Panel2.ClientSize.Height AndAlso playerPosition = 1) OrElse
        (PictureBox2.Bottom >= Panel5.ClientSize.Height AndAlso playerPosition = 2) OrElse
        (PictureBox3.Bottom >= Panel6.ClientSize.Height AndAlso playerPosition = 3) OrElse
        (PictureBox4.Bottom >= Panel4.ClientSize.Height AndAlso playerPosition = 4)

        If hit Then
            isDead = True
            gameStart = False
            PictureBox1.Image = My.Resources.char1_exploded
            Task.Delay(300).Wait()
            MsgBox("You died")
            ResetBlocks()
        End If
    End Sub


    Private Sub ResetBlocks()
        inactiveBlocks = New List(Of Control) From {PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
        activeBlocks.Clear()

        gameStart = False
        isDead = False
        playerPosition = 2
        playerScore = 0

        UpdateUserPosition()

        Label1.Text = "Score : 0"
        Label2.Text = "High Score : " & playerHighScore
        PictureBox1.Image = My.Resources.char1_basic

        For Each block As Control In inactiveBlocks
            block.Top = 0
            block.Visible = False
        Next
    End Sub
End Class