Public Class enroll_receipt
    Private Sub Meload(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(about_btn, My.Resources.about_btn, My.Resources.about_btn_hover)
        Basic.ImgHover(acad_btn, My.Resources.acad_calendar_btn, My.Resources.acad_calendar_btn_hover)
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
    End Sub

    Private Sub go_back_btn_Click(sender As Object, e As EventArgs) Handles go_back_btn.Click
        Dim go_back As New main_menu()
        go_back.Show()
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
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = var.full_name
        Label3.Text = var.gender
        Label4.Text = var.date_of_birth
        Label5.Text = var.address
        Label6.Text = var.place_of_birth
        Label7.Text = var.parent_name
        Label8.Text = var.parent_phone_num
        Label9.Text = var.parent_email_add

        Label20.BackColor = ColorTranslator.FromHtml("#045f33")
        Label21.BackColor = ColorTranslator.FromHtml("#045f33")
        Label14.BackColor = ColorTranslator.FromHtml("#045f33")
        Button1.BackColor = ColorTranslator.FromHtml("#045f33")

        Label24.Text = "₱ " + (var.tuition_total).ToString + ".00"
        Label31.Text = "₱ " + (var.misc_total).ToString + ".00"
        Label32.Text = "₱ " + (var.transport_total).ToString + ".00"
        Label33.Text = "₱ " + (var.regUni_total).ToString + ".00"
        Label34.Text = "₱ " + (var.peUni_total).ToString + ".00"
        Label35.Text = var.enrollment_type
        Label41.Text = (var.regUni_qty).ToString + "pcs"
        Label42.Text = (var.peUni_qty).ToString + " pcs"

        Label43.Text = "₱ " + (var.total_pay).ToString + ".00"
        Label47.Text = "₱ 0.00"

        Label40.Text = var.transport_type

        Select Case var.regUni_size
            Case 0 : Label12.Text = "XS"
            Case 1 : Label12.Text = "S"
            Case 2 : Label12.Text = "M"
            Case 3 : Label12.Text = "L"
            Case 4 : Label12.Text = "XL"
            Case 5 : Label12.Text = "2XL"
        End Select

        Select Case var.regUni_size
            Case 0 : Label13.Text = "XS"
            Case 1 : Label13.Text = "S"
            Case 2 : Label13.Text = "M"
            Case 3 : Label13.Text = "L"
            Case 4 : Label13.Text = "XL"
            Case 5 : Label13.Text = "2XL"
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter an amount")
        ElseIf CInt(TextBox1.Text) < var.total_pay Then
            MessageBox.Show("Please enter an amount greater than the total")
        Else
            Dim changeAmount As Integer = CInt(TextBox1.Text) - var.total_pay
            Label47.Text = "₱ " + (changeAmount).ToString + ".00"
        End If


    End Sub

End Class