Imports System.Windows.Forms

Public Class merch_main
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(enroll_btn, My.Resources.enroll_btn, My.Resources.enroll_btn_hover)
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
        Basic.ImgHover(acad_btn, My.Resources.acad_calendar_btn, My.Resources.acad_calendar_btn_hover)
        Basic.ImgHover(about_btn, My.Resources.about_btn, My.Resources.about_btn_hover)

        If ListView1.Columns.Count >= 3 Then
            ListView1.Columns(0).Width = Panel2.ClientSize.Width * 0.5
            ListView1.Columns(1).Width = Panel2.ClientSize.Width * 0.25
            ListView1.Columns(2).Width = Panel2.ClientSize.Width * 0.25
        End If

        If ListView2.Columns.Count >= 3 Then
            ListView2.Columns(0).Width = Panel3.ClientSize.Width * 0.5
            ListView2.Columns(1).Width = Panel3.ClientSize.Width * 0.2425
            ListView2.Columns(2).Width = Panel3.ClientSize.Width * 0.2425
        End If

        If ListView3.Columns.Count >= 3 Then
            ListView3.Columns(0).Width = Panel4.ClientSize.Width * 0.5
            ListView3.Columns(1).Width = Panel4.ClientSize.Width * 0.2425
            ListView3.Columns(2).Width = Panel4.ClientSize.Width * 0.2425
        End If

        Button1.BackColor = ColorTranslator.FromHtml("#166532")
        ListView1.BackColor = ColorTranslator.FromHtml("#045f33")
        ListView2.BackColor = ColorTranslator.FromHtml("#045f33")
        ListView3.BackColor = ColorTranslator.FromHtml("#045f33")
        Button3.BackColor = ColorTranslator.FromHtml("#045f33")
        clear_supply_btn.BackColor = ColorTranslator.FromHtml("#045f33")
        remove_supply.BackColor = ColorTranslator.FromHtml("#045f33")
        clear_cart_btn.BackColor = ColorTranslator.FromHtml("#045f33")
        add_to_cart.BackColor = ColorTranslator.FromHtml("#045f33")
        remove_item.BackColor = ColorTranslator.FromHtml("#045f33")

        UpdateList()
    End Sub

    Private Sub UpdateList()
        ListView1.Items.Clear()
        ListView3.Items.Clear()

        For i As Integer = var.cartItem.Count - 1 To 0 Step -1
            Dim item As New ListViewItem(var.cartItem(i))
            item.SubItems.Add(var.cartQty(i).ToString)
            item.SubItems.Add(var.cartTPrice(i).ToString)
            ListView1.Items.Add(item)
        Next

        For i As Integer = var.supplyItem.Count - 1 To 0 Step -1
            Dim item As New ListViewItem(var.supplyItem(i))
            item.SubItems.Add(var.supplyQty(i).ToString)
            item.SubItems.Add(var.supplyTPrice(i).ToString)
            ListView3.Items.Add(item)
        Next
    End Sub

    Private Sub Update_Final_List()
        ListView2.Items.Clear()

        For i As Integer = var.cartItem.Count - 1 To 0 Step -1
            Dim item As New ListViewItem(var.cartItem(i))
            item.SubItems.Add(var.cartQty(i).ToString)
            item.SubItems.Add(var.cartTPrice(i).ToString)
            ListView2.Items.Add(item)
        Next

        For i As Integer = var.supplyItem.Count - 1 To 0 Step -1
            Dim item As New ListViewItem(var.supplyItem(i))
            item.SubItems.Add(var.supplyQty(i).ToString)
            item.SubItems.Add(var.supplyTPrice(i).ToString)
            ListView2.Items.Add(item)
        Next
    End Sub

    Private Sub AddItem(x As Integer, z As Integer)
        Dim there As Boolean = False

        For i As Integer = var.cartItem.Count - 1 To 0 Step -1
            If var.cartItem(i) = var.itemList(x).Name Then
                var.cartQty(i) += z
                var.cartTPrice(i) = var.cartQty(i) * var.cartPrice(i)
                there = True
                Exit For
            End If
        Next

        If Not there Then
            var.cartItem.Add(var.itemList(x).Name)
            var.cartPrice.Add(var.itemList(x).Price)
            var.cartQty.Add(z)
            var.cartTPrice.Add(var.itemList(x).Price * z)
        End If

        UpdateList()
    End Sub

    Private Sub clear_cart_btn_click(sender As Object, e As EventArgs) Handles clear_cart_btn.Click
        var.cartItem.Clear()
        var.cartPrice.Clear()
        var.cartQty.Clear()
        var.cartTPrice.Clear()
        UpdateList()
    End Sub

    Private Sub remove_selcted_item(sender As Object, e As EventArgs) Handles remove_item.Click
        If ListView1.SelectedItems.Count = 0 Then Exit Sub

        For i As Integer = var.cartItem.Count - 1 To 0 Step -1
            If ListView1.SelectedItems(0).Text = var.cartItem(i) Then
                var.cartItem.RemoveAt(i)
                var.cartPrice.RemoveAt(i)
                var.cartQty.RemoveAt(i)
                var.cartTPrice.RemoveAt(i)
                Exit For
            End If
        Next

        UpdateList()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem Is Nothing Then Exit Sub

        Select Case ListBox1.SelectedItem.ToString
            Case "Cap - ₱ 300.00" : AddItem(0, 1)
            Case "Tumbler - ₱ 900.00" : AddItem(1, 1)
            Case "T-Shirt - ₱ 890.00" : AddItem(2, 1)
            Case "Sweatshirt - ₱ 890.00" : AddItem(3, 1)
            Case "Lanyard - ₱ 200.00" : AddItem(4, 1)
            Case "Tote Bag - ₱ 300.00" : AddItem(5, 1)
            Case "Mug - ₱ 300.00" : AddItem(6, 1)
        End Select
    End Sub

    Private Sub SupplyAdd(x As Integer, z As Integer)
        Dim there As Boolean = False

        For i As Integer = var.supplyItem.Count - 1 To 0 Step -1
            If var.supplyItem(i) = var.itemList(x).Name Then
                var.supplyQty(i) += z
                var.supplyTPrice(i) = var.supplyQty(i) * var.supplyPrice(i)
                there = True
                Exit For
            End If
        Next

        If Not there Then
            var.supplyItem.Add(var.itemList(x).Name)
            var.supplyPrice.Add(var.itemList(x).Price)
            var.supplyQty.Add(z)
            var.supplyTPrice.Add(var.itemList(x).Price * z)
        End If

        UpdateList()
    End Sub

    Private Sub clear_supply_btn_click(sender As Object, e As EventArgs) Handles clear_supply_btn.Click
        var.supplyItem.Clear()
        var.supplyPrice.Clear()
        var.supplyQty.Clear()
        var.supplyTPrice.Clear()
        UpdateList()
    End Sub

    Private Sub remove_selcted_supply(sender As Object, e As EventArgs) Handles remove_supply.Click
        If ListView3.SelectedItems.Count = 0 Then Exit Sub

        For i As Integer = var.supplyItem.Count - 1 To 0 Step -1
            If ListView3.SelectedItems(0).Text = var.supplyItem(i) Then
                var.supplyItem.RemoveAt(i)
                var.supplyPrice.RemoveAt(i)
                var.supplyQty.RemoveAt(i)
                var.supplyTPrice.RemoveAt(i)
                Exit For
            End If
        Next

        UpdateList()
    End Sub

    Private Sub School_Supplies_Add(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedItem Is Nothing Then Exit Sub

        Select Case ListBox2.SelectedItem.ToString
            Case "Ballpen - ₱ 40.00" : SupplyAdd(7, 1)
            Case "Pencil - ₱ 25.00" : SupplyAdd(8, 1)
            Case "Notebook - ₱ 80.00" : SupplyAdd(9, 1)
            Case "Crayons - ₱ 120.00" : SupplyAdd(10, 1)
            Case "Colored pencils - ₱ 150.00" : SupplyAdd(11, 1)
            Case "Ruler - ₱ 30.00" : SupplyAdd(12, 1)
            Case "Scissors - ₱ 100.00" : SupplyAdd(13, 1)
            Case "Cartolina - ₱ 25.00" : SupplyAdd(14, 1)
            Case "Folder - ₱ 30.00" : SupplyAdd(15, 1)
            Case "Sharpener - ₱ 25.00" : SupplyAdd(16, 1)
            Case "Marker (permanent) - ₱ 50.00" : SupplyAdd(17, 1)
            Case "Marker (whiteboard) - ₱ 50.00" : SupplyAdd(18, 1)
            Case "Drawing book(A4) - ₱ 100.00" : SupplyAdd(19, 1)
            Case "Glue - ₱ 10.00" : SupplyAdd(20, 1)
        End Select
    End Sub

    Private Sub Reg_Uni_Add(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        If ListBox3.SelectedItem Is Nothing Then Exit Sub

        Select Case ListBox3.SelectedItem.ToString
            Case "XS - ₱ 800.00" : SupplyAdd(21, 1)
            Case "S - ₱ 900.00" : SupplyAdd(22, 1)
            Case "M - ₱ 1040.00" : SupplyAdd(23, 1)
            Case "L - ₱ 1160.00" : SupplyAdd(24, 1)
            Case "XL - ₱ 1300.00" : SupplyAdd(25, 1)
            Case "2XL - ₱ 1500.00" : SupplyAdd(26, 1)
        End Select
    End Sub

    Private Sub PE_Uni_Add(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        If ListBox4.SelectedItem Is Nothing Then Exit Sub

        Select Case ListBox4.SelectedItem.ToString
            Case "XS - ₱ 800.00" : SupplyAdd(27, 1)
            Case "S - ₱ 900.00" : SupplyAdd(28, 1)
            Case "M - ₱ 1040.00" : SupplyAdd(29, 1)
            Case "L - ₱ 1160.00" : SupplyAdd(30, 1)
            Case "XL - ₱ 1300.00" : SupplyAdd(31, 1)
            Case "2XL - ₱ 1500.00" : SupplyAdd(32, 1)
        End Select
    End Sub

    Private Sub add_to_cart_Click(sender As Object, e As EventArgs) Handles add_to_cart.Click, Button3.Click
        Update_Final_List()

        var.cartTotalPrice = 0

        For i As Integer = var.cartTPrice.Count - 1 To 0 Step -1
            var.cartTotalPrice += var.cartTPrice(i)
        Next

        For i As Integer = var.supplyTPrice.Count - 1 To 0 Step -1
            var.cartTotalPrice += var.supplyTPrice(i)
        Next

        Label5.Text = "₱ " & var.cartTotalPrice.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim paid As Integer
        If Not Integer.TryParse(TextBox1.Text, paid) Then Exit Sub
        If paid < var.cartTotalPrice Then Exit Sub

        var.cartPaid = paid
        Dim receipt As New merch_receipt()
        receipt.Show()
        Me.Close()
    End Sub
End Class
