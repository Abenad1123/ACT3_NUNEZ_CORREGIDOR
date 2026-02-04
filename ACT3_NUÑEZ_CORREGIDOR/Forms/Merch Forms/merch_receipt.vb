Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class merch_receipt
    ' ---------------- INITIAL DATA & FUNCTIONS ----------------
    Dim SideMenuExpanded As Boolean = False
    Dim StepSize As Integer = 10
    Private Sub Form_Initial(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(enroll_btn, My.Resources.enroll_btn, My.Resources.enroll_btn_hover)
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
        Basic.ImgHover(menu_btn, My.Resources.menu_btn, My.Resources.menu_btn_hover)
        Basic.ImgHover(library_btn, My.Resources.library_btn, My.Resources.library_btn_hover)
        hamburger_menu.Width = 0
        hamburger_menu.BackColor = ColorTranslator.FromHtml("#045f33")
        acad_btn.BackColor = ColorTranslator.FromHtml("#045f33")
        about_btn.BackColor = ColorTranslator.FromHtml("#045f33")
        games_btn.BackColor = ColorTranslator.FromHtml("#045f33")

    End Sub
    Private Sub enroll_btn_Click(sender As Object, e As EventArgs) Handles enroll_btn.Click
        OpenForm(Of enroll_step1)(Me)
    End Sub
    Private Sub store_btn_Click(sender As Object, e As EventArgs) Handles go_back_btn.Click
        OpenForm(Of main_menu)(Me)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles games_btn.Click
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
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns(0).Width = Panel1.ClientSize.Width * 0.5
        ListView1.Columns(1).Width = Panel1.ClientSize.Width * 0.25
        ListView1.Columns(2).Width = Panel1.ClientSize.Width * 0.25

        ListView1.BackColor = ColorTranslator.FromHtml("#f4f4f4")

        Label6.Text = "₱ " + (var.cartTotalPrice).ToString + ".00"
        Label4.Text = "₱ " + (var.cartPaid).ToString + ".00"
        Label5.Text = "₱ " + (var.cartPaid - var.cartTotalPrice).ToString + ".00"

        Update_Final_List()
    End Sub

    Private Sub Update_Final_List()
        ListView1.Items.Clear()
        If var.cartItem.Count > 0 Then
            For i As Integer = var.cartItem.Count - 1 To 0 Step -1
                Dim item As New ListViewItem(var.cartItem(i))
                item.SubItems.Add((var.cartQty(i)).ToString)
                item.SubItems.Add((var.cartTPrice(i)).ToString)

                ListView1.Items.Add(item)
            Next
        End If

        If var.supplyItem.Count > 0 Then
            For i As Integer = var.supplyItem.Count - 1 To 0 Step -1
                Dim item As New ListViewItem(var.supplyItem(i))
                item.SubItems.Add((var.supplyQty(i)).ToString)
                item.SubItems.Add((var.supplyTPrice(i)).ToString)

                ListView1.Items.Add(item)
            Next
        End If
    End Sub


End Class