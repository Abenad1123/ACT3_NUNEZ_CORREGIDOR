Public Class Form4

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(enroll_btn, My.Resources.enroll_btn, My.Resources.enroll_btn_hover)
        Basic.ImgHover(store_btn, My.Resources.store_btn, My.Resources.store_btn_hover)
        Basic.ImgHover(acad_btn, My.Resources.acad_calendar_btn, My.Resources.acad_calendar_btn_hover)
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
        Basic.ImgHover(library_btn, My.Resources.library_btn, My.Resources.library_btn_hover)
    End Sub
    Private Sub go_back_btn_Click(sender As Object, e As EventArgs) Handles go_back_btn.Click
        Dim go_back As New Form1()
        go_back.Show()
        Me.Close()
    End Sub
    Private Sub enroll_btn_Click(sender As Object, e As EventArgs) Handles enroll_btn.Click
        Dim enroll As New Form2()
        enroll.Show()
        Me.Close()
    End Sub

    Private Sub library_btn_Click(sender As Object, e As EventArgs) Handles library_btn.Click
        Dim library As New Form11()
        library.Show()
        Me.Close()
    End Sub
    Private Sub acad_btn_Click(sender As Object, e As EventArgs) Handles acad_btn.Click
        Dim acad As New Form3()
        acad.Show()
        Me.Close()
    End Sub

    Private Sub store_btn_Click(sender As Object, e As EventArgs) Handles store_btn.Click
        Dim store As New Form8()
        store.Show()
        Me.Close()
    End Sub

End Class