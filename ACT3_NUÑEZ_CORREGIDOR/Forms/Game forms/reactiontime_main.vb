Public Class reactiontime_main
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

    Private Sub Game4_Load(sender As Object, e As EventArgs) Handles self.Click
        OpenForm(Of reactiontime_main)(Me)
    End Sub

    Private Sub Game5_Load(sender As Object, e As EventArgs) Handles mathchallenge.Click
        OpenForm(Of mathchallenge_main)(Me)
    End Sub
End Class