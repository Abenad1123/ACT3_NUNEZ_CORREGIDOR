Public Class Form3

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(enroll_btn, My.Resources.enroll_btn, My.Resources.enroll_btn_hover)
        Basic.ImgHover(store_btn, My.Resources.store_btn, My.Resources.store_btn_hover)
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
        Basic.ImgHover(about_btn, My.Resources.about_btn, My.Resources.about_btn_hover)
        Basic.ImgHover(library_btn, My.Resources.library_btn, My.Resources.library_btn_hover)

        PictureBox2.Height = 1650
        Basic.ImgWidthWrap(PictureBox2, FlowLayoutPanel2)
    End Sub

    Private Sub Form_Update(sender As Object, e As EventArgs) Handles Me.Resize
        Basic.ImgWidthWrap(PictureBox2, FlowLayoutPanel2)
    End Sub

    Private Sub go_back_btn_Click(sender As Object, e As EventArgs) Handles go_back_btn.Click
        Dim main_menu As New Form1()
        main_menu.Show()
        Me.Close()
    End Sub

    Private Sub library_btn_Click(sender As Object, e As EventArgs) Handles library_btn.Click
        Dim library As New Form11()
        library.Show()
        Me.Close()
    End Sub

    Private Sub enroll_btn_Click(sender As Object, e As EventArgs) Handles enroll_btn.Click
        Dim enroll As New Form2()
        enroll.Show()
        Me.Close()
    End Sub

    Private Sub about_btn_Click(sender As Object, e As EventArgs) Handles about_btn.Click
        Dim about As New Form4()
        about.Show()
        Me.Close()
    End Sub

    Private Sub store_btn_Click(sender As Object, e As EventArgs) Handles store_btn.Click
        Dim store As New Form8()
        store.Show()
        Me.Close()
    End Sub

End Class