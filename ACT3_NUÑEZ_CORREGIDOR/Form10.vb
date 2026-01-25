Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form10
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(enroll_btn, My.Resources.enroll_btn, My.Resources.enroll_btn_hover)
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
        Basic.ImgHover(acad_btn, My.Resources.acad_calendar_btn, My.Resources.acad_calendar_btn_hover)
        Basic.ImgHover(about_btn, My.Resources.about_btn, My.Resources.about_btn_hover)

        ListView1.Columns(0).Width = Panel1.ClientSize.Width * 0.5
        ListView1.Columns(1).Width = Panel1.ClientSize.Width * 0.25
        ListView1.Columns(2).Width = Panel1.ClientSize.Width * 0.25

        ListView1.BackColor = ColorTranslator.FromHtml("#f4f4f4")

        Label6.Text = "₱ " + (var.cartTotalPrice).ToString + ".00"
        Label4.Text = "₱ " + (var.cartPaid).ToString + ".00"
        Label5.Text = "₱ " + (var.cartPaid - var.cartTotalPrice).ToString + ".00"

        Update_Final_List()
    End Sub

    Private Sub enroll_btn_Click(sender As Object, e As EventArgs) Handles enroll_btn.Click
        Dim enroll As New Form2()
        enroll.Show()
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