Public Class enroll_step2

    Private Sub Form_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
        Basic.ImgHover(continue_btn, My.Resources.cont_btn, My.Resources.cont_btn_hover)
    End Sub

    Private Sub Form_update(sender As Object, e As EventArgs) Handles MyBase.Resize
        Basic.AlignX(continue_btn, Panel1)
    End Sub

    Private Sub go_back_btn_Click(sender As Object, e As EventArgs) Handles go_back_btn.Click
        Dim go_back As New main_menu()
        go_back.Show()
        Me.Close()
    End Sub

    Private Sub acad_btn_Click(sender As Object, e As EventArgs)
        Dim acad As New acad_calendar()
        acad.Show()
        Me.Close()
    End Sub

    Private Sub about_btn_Click(sender As Object, e As EventArgs)
        Dim about As New about()
        about.Show()
        Me.Close()
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

        Dim go As New enroll_step3()
        go.Show()
        Me.Close()
    End Sub

End Class