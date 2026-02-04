Public Class enroll_step1

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
        Basic.ImgHover(store_btn, My.Resources.store_btn, My.Resources.store_btn_hover)
        Basic.ImgHover(acad_btn, My.Resources.acad_calendar_btn, My.Resources.acad_calendar_btn_hover)
        Basic.ImgHover(about_btn, My.Resources.about_btn, My.Resources.about_btn_hover)
        Basic.ImgHover(apply_btn, My.Resources.apply_btn, My.Resources.apply_btn_hover)
        Basic.ImgHover(library_btn, My.Resources.library_btn, My.Resources.library_btn_hover)

        PictureBox2.Height = 1222
        Basic.ImgWidthWrap(PictureBox2, Panel1)
        Basic.AlignX(apply_btn, Panel1)
    End Sub

    Private Sub Form_Update(sender As Object, e As EventArgs) Handles Me.Resize
        Basic.ImgWidthWrap(PictureBox2, Panel1)
        Basic.AlignX(apply_btn, Panel1)
    End Sub

    Private Sub go_back_btn_Click(sender As Object, e As EventArgs) Handles go_back_btn.Click
        Dim go_back As New main_menu()
        go_back.Show()
        Me.Close()
    End Sub

    Private Sub library_btn_Click(sender As Object, e As EventArgs) Handles library_btn.Click
        Dim library As New library_welcome()
        library.Show()
        Me.Close()
    End Sub

    Private Sub acad_btn_Click(sender As Object, e As EventArgs) Handles acad_btn.Click
        Dim acad As New acad_calendar()
        acad.Show()
        Me.Close()
    End Sub

    Private Sub about_btn_Click(sender As Object, e As EventArgs) Handles about_btn.Click
        Dim about As New about()
        about.Show()
        Me.Close()
    End Sub

    Private Sub apply_btn_Click(sender As Object, e As EventArgs) Handles apply_btn.Click
        Dim frm As New enroll_step2()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub store_btn_Click(sender As Object, e As EventArgs) Handles store_btn.Click
        Dim store As New merch_welcome()
        store.Show()
        Me.Close()
    End Sub

End Class