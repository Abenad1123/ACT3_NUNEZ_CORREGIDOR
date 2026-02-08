Public Class enroll_receipt
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
        sc_btn.BackColor = ColorTranslator.FromHtml("#045f33")

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

    Private Sub games_btn_click(sender As Object, e As EventArgs) Handles sc_btn.Click
        OpenForm(Of sc_welcome)(Me)
    End Sub

    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles close_hamburger_btn.Click, menu_btn.Click
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

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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