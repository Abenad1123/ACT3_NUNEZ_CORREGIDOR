Public Class whack_a_mole_settings
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
        OpenForm(Of enroll_step1)(Me)
    End Sub

    Private Sub Game5_Load(sender As Object, e As EventArgs) Handles mathchallenge.Click
        OpenForm(Of enroll_step1)(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter a valid time duration.")
            Exit Sub
        End If

        game_var.standard_timeDuration = (TextBox1.Text).ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Whack-A-Mole high score has been reset.")
        game_var.wam_highestPlayerScore = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case ComboBox1.SelectedItem.ToString
            Case "Easy"
                game_var.wam_mole_despawnTime = 1300
            Case "Normal"
                game_var.wam_mole_despawnTime = 1000
            Case "Meduim"
                game_var.wam_mole_despawnTime = 800
            Case "Hard"
                game_var.wam_mole_despawnTime = 700
            Case "Extreme"
                game_var.wam_mole_despawnTime = 400
            Case Else
                MsgBox("Please select a valid difficulty level.")
                Exit Sub
        End Select
    End Sub
End Class