Public Class Form13
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
        Basic.ImgHover(enroll_btn, My.Resources.enroll_btn, My.Resources.enroll_btn_hover)
        Basic.ImgHover(acad_btn, My.Resources.acad_calendar_btn, My.Resources.acad_calendar_btn_hover)
        Basic.ImgHover(store_btn, My.Resources.store_btn, My.Resources.store_btn_hover)
        Basic.ImgHover(about_btn, My.Resources.about_btn, My.Resources.about_btn_hover)
        Basic.ImgHover(continue_btn, My.Resources.cont_btn, My.Resources.cont_btn_hover)
    End Sub

    Private Sub store_btn_Click(sender As Object, e As EventArgs) Handles store_btn.Click
        Dim store As New Form8()
        store.Show()
        Me.Close()
    End Sub

    Private Sub continue_btn_Click(sender As Object, e As EventArgs) Handles continue_btn.Click
        Dim cont As New Form12()
        cont.Show()
        Me.Close()
    End Sub

    Private Sub go_back_btn_Click(sender As Object, e As EventArgs) Handles go_back_btn.Click
        Dim go_back As New Form1()
        go_back.Show()
        Me.Close()
    End Sub

    Private Sub acad_btn_Click(sender As Object, e As EventArgs) Handles acad_btn.Click
        Dim acad As New Form3()
        acad.Show()
        Me.Close()
    End Sub
    Private Sub about_btn_Click(sender As Object, e As EventArgs) Handles about_btn.Click
        Dim about As New Form4()
        about.Show()
        Me.Close()
    End Sub

    Private Sub enroll_btn_Click(sender As Object, e As EventArgs) Handles enroll_btn.Click
        Dim enroll As New Form2()
        enroll.Show()
        Me.Close()
    End Sub
End Class