Public Class rock_paper_scissors_main
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
    Private Sub RockPaperScissorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Image = My.Resources.glove_idle_left
        PictureBox2.Image = My.Resources.glove_idle_right

        MsgBox("Welcome to Rock-Paper-Scissors! Choose your weapon and try to beat the AI. Good luck!")
        playerScore = 0
        aiScore = 0

        playerFace = 0
        aiFace = 0
    End Sub

    Dim playerScore As Integer = 0
    Dim aiScore As Integer = 0

    Dim playerFace As Integer = 0
    Dim aiFace As Integer = 0

    Dim pause As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not pause Then PictureBox1.Image = My.Resources.rock_left
        CheckTurn(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not pause Then PictureBox1.Image = My.Resources.paper_left
        CheckTurn(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not pause Then PictureBox1.Image = My.Resources.scissor_left
        CheckTurn(3)
    End Sub

    Private Sub CheckTurn(playerChoice As Integer)
        If pause Then Exit Sub

        If playerChoice <> playerFace Then
            Select Case playerChoice
                Case 1 : Label4.Text = "You chose rock!"
                Case 2 : Label4.Text = "You chose paper!"
                Case 3 : Label4.Text = "You chose scissor!"
            End Select
        End If

        If playerChoice = playerFace Then
            Select Case playerChoice
                Case 1 : Label4.Text = "You chose rock again!"
                Case 2 : Label4.Text = "You chose paper again!"
                Case 3 : Label4.Text = "You chose scissor again!"
            End Select
        End If

        Turn(playerChoice)
    End Sub

    Private Async Sub Turn(playerChoice As Integer)
        Await Task.Delay(1000)
        Label4.Text = "The bot is choosing..."
        pause = True
        Await Task.Delay(1000)
        playerFace = playerChoice
        Dim rnd As New Random()
        Dim number As Integer = rnd.Next(1, 4)

        Select Case number
            Case 1
                PictureBox2.Image = My.Resources.rock_right
                Label4.Text = "AI chose rock!"
                aiFace = 1
            Case 2
                PictureBox2.Image = My.Resources.paper_right
                Label4.Text = "AI chose paper!"
                aiFace = 2
            Case 3
                PictureBox2.Image = My.Resources.scissor_right
                Label4.Text = "AI chose scissor!"
                aiFace = 3
        End Select
        CalcScore()
        pause = False
    End Sub

    Private Async Sub CalcScore()
        If playerFace = aiFace Then
            Label4.Text &= vbCrLf & "Draw"
        ElseIf (playerFace = 1 And aiFace = 2) Or (playerFace = 2 And aiFace = 3) Or (playerFace = 3 And aiFace = 1) Then
            Label4.Text &= vbCrLf & "AI Won"
            aiScore += 1
        ElseIf (playerFace = 2 And aiFace = 1) Or (playerFace = 3 And aiFace = 2) Or (playerFace = 1 And aiFace = 3) Then
            Label4.Text &= vbCrLf & "Player Won"
            playerScore += 1
        End If
        Await Task.Delay(1300)
        ScoreUpd()
    End Sub

    Private Sub ScoreUpd()
        Label2.Text = (playerScore).ToString
        Label3.Text = (aiScore).ToString
        Label4.Text = "Pick your weapon!"
        PictureBox1.Image = My.Resources.glove_idle_left
        PictureBox2.Image = My.Resources.glove_idle_right
    End Sub


End Class