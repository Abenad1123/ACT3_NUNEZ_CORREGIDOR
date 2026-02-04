Public Class enroll_step2
    ' ---------------- INITIAL DATA & FUNCTIONS ----------------
    Dim SideMenuExpanded As Boolean = False
    Dim StepSize As Integer = 10
    Private Sub Form_Initial(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
        Basic.ImgHover(store_btn, My.Resources.store_btn, My.Resources.store_btn_hover)
        Basic.ImgHover(menu_btn, My.Resources.menu_btn, My.Resources.menu_btn_hover)
        Basic.ImgHover(library_btn, My.Resources.library_btn, My.Resources.library_btn_hover)
        hamburger_menu.Width = 0
        hamburger_menu.BackColor = ColorTranslator.FromHtml("#045f33")
        acad_btn.BackColor = ColorTranslator.FromHtml("#045f33")
        about_btn.BackColor = ColorTranslator.FromHtml("#045f33")
        games_btn.BackColor = ColorTranslator.FromHtml("#045f33")

    End Sub
    Private Sub enroll_btn_Click(sender As Object, e As EventArgs) Handles go_back_btn.Click
        OpenForm(Of main_menu)(Me)
    End Sub
    Private Sub store_btn_Click(sender As Object, e As EventArgs) Handles store_btn.Click
        OpenForm(Of merch_welcome)(Me)
    End Sub

    Private Sub library_btn_Click(sender As Object, e As EventArgs) Handles library_btn.Click
        OpenForm(Of library_welcome)(Me)
    End Sub

    Private Sub acad_btn_Click(sender As Object, e As EventArgs) Handles acad_btn.Click
        OpenForm(Of acad_calendar)(Me)
    End Sub

    Private Sub about_btn_Click(sender As Object, e As EventArgs) Handles about_btn.Click
        OpenForm(Of about)(Me)
    End Sub

    Private Sub games_btn_click(sender As Object, e As EventArgs) Handles games_btn.Click
        OpenForm(Of game_welcome)(Me)
    End Sub

    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles menu_btn.Click, close_hamburger_btn.Click
        hambuger_menu_timer.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles hambuger_menu_timer.Tick
        If Not SideMenuExpanded Then
            hamburger_menu.Visible = True
            hamburger_menu.Width += StepSize
            If hamburger_menu.Width >= 300 Then
                hambuger_menu_timer.Stop()
                SideMenuExpanded = True
            End If
        Else
            hamburger_menu.Width -= StepSize
            If hamburger_menu.Width <= 0 Then
                hamburger_menu.Visible = False
                hambuger_menu_timer.Stop()
                SideMenuExpanded = False
            End If
        End If
    End Sub

    ' ---------------- END OF INITIAL DATA & FUNCTIONS ----------------

    Private Sub Form_update(sender As Object, e As EventArgs) Handles MyBase.Resize
        Basic.AlignX(continue_btn, Panel1)
    End Sub

    Private Sub continue_btn_Click(sender As Object, e As EventArgs) Handles continue_btn.Click
        var.full_name = TextBox1.Text
        var.last_name = TextBox2.Text

        If CheckBox1.Checked Then
            var.gender = "Male"
        ElseIf CheckBox2.Checked Then
            var.gender = "Female"
        End If


        var.date_of_birth = TextBox3.Text + "/" + TextBox6.Text + "/" + TextBox7.Text
        var.address = TextBox4.Text
        var.place_of_birth = TextBox5.Text
        var.parent_name = TextBox8.Text
        var.parent_phone_num = TextBox9.Text
        var.parent_email_add = TextBox10.Text

        OpenForm(Of enroll_step3)(Me)
    End Sub

End Class