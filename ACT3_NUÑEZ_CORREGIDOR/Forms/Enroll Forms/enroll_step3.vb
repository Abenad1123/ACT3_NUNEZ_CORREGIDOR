Public Class enroll_step3

    Private Sub Meload(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(about_btn, My.Resources.about_btn, My.Resources.about_btn_hover)
        Basic.ImgHover(acad_btn, My.Resources.acad_calendar_btn, My.Resources.acad_calendar_btn_hover)
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
        Basic.ImgHover(continue_btn, My.Resources.cont_btn, My.Resources.cont_btn_hover)
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

    Private Sub DataUpdate_LM(sender As Object, e As EventArgs) Handles learningMode.SelectedIndexChanged
        If learningMode.CheckedItems.Count = 1 Then
            Select Case learningMode.CheckedItems(0)
                Case "Full Face to Face Learning"
                    var.tuition_total = var.tuition_fee(0)
                    var.misc_total = var.miscellaneous_fee(0)
                    var.enrollment_type = "Full Face to Face Learning"
                Case "Hybrid Learning"
                    var.tuition_total = var.tuition_fee(1)
                    var.misc_total = var.miscellaneous_fee(1)
                    var.enrollment_type = "Hybrid Learning"
                Case "Full Online Learning"
                    var.tuition_total = var.tuition_fee(2)
                    var.misc_total = var.miscellaneous_fee(2)
                    var.enrollment_type = "Full Online Learning"
            End Select
        Else
            var.tuition_total = 0
            var.misc_total = 0
            var.enrollment_type = ""
        End If
        Calc_ini()
    End Sub

    Private Sub DataUpdate_CKL1(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged, regUni.SelectedIndexChanged
        var.regUni_qty = CInt(NumericUpDown1.Value)

        If regUni.CheckedItems.Count = 1 Then
            Select Case regUni.CheckedItems(0)
                Case "XS - ₱ 800" : var.regUni_size = 0
                Case "S - ₱ 900" : var.regUni_size = 1
                Case "M - ₱ 1040" : var.regUni_size = 2
                Case "L - ₱ 1160" : var.regUni_size = 3
                Case "XL - ₱ 1300" : var.regUni_size = 4
                Case "2XL - ₱ 1500" : var.regUni_size = 5
            End Select
            var.regUni_total = var.regUni_qty * var.regUni_fullSet(var.regUni_size)
        Else
            var.regUni_total = 0
        End If
        Calc_ini()
    End Sub

    Private Sub DataUpdate_CKL2(sender As Object, e As EventArgs) Handles peUni.SelectedIndexChanged, NumericUpDown2.ValueChanged
        var.peUni_qty = CInt(NumericUpDown2.Value)

        If peUni.CheckedItems.Count = 1 Then
            Select Case peUni.CheckedItems(0)
                Case "XS - ₱ 800" : var.peUni_size = 0
                Case "S - ₱ 900" : var.peUni_size = 1
                Case "M - ₱ 1040" : var.peUni_size = 2
                Case "L - ₱ 1160" : var.peUni_size = 3
                Case "XL - ₱ 1300" : var.peUni_size = 4
                Case "2XL - ₱ 1500" : var.peUni_size = 5
            End Select
            var.peUni_total = var.peUni_qty * var.peUni_fullSet(var.peUni_size)
        Else
            var.peUni_total = 0
        End If

        Calc_ini()
    End Sub

    Private Sub DataUpdate_SHTL(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            var.transport_total += var.shuttle_fee_yearly
            var.transport_type = "Shuttle"
        Else
            var.transport_total = 0
            var.transport_type = ""
        End If
        Calc_ini()
    End Sub

    Private Sub DataUpdate_BUS(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            var.transport_total += var.school_bus_fee_yearly
            var.transport_type = "School Bus"
        Else
            var.transport_total = 0
            var.transport_type = ""
        End If
        Calc_ini()
    End Sub

    Private Sub DataUpdate_BOK(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            var.book_total += var.books_fee
        Else : var.book_total = 0
        End If
        Calc_ini()
    End Sub

    Private Sub DataUpdate_DISC(sender As Object, e As EventArgs) Handles discounts.SelectedIndexChanged
        If discounts.CheckedItems.Count = 1 Then
            Select Case discounts.CheckedItems(0)
                Case "PWD - 10%"
                    var.discount_percent = 0.1
                    var.discount_type = "PWD"
                Case "Family Discount - 3%"
                    var.discount_percent = 0.03
                    var.discount_type = "Family Discount"
            End Select
        Else
            var.discount_percent = 0
            var.discount_type = "None"
        End If
        Calc_ini()
    End Sub

    Private Sub Calc_ini()
        var.intial_pay = var.regUni_total + var.peUni_total + var.transport_total + var.tuition_total + var.misc_total + var.book_total

        Label1.Text = "Initial : ₱" + (var.intial_pay).ToString + ".00"
        Calc_final()
    End Sub

    Private Sub Calc_final()
        Dim tuition As Integer = (var.tuition_total + var.misc_total) * (1 - var.discount_percent)
        var.total_pay = tuition + var.regUni_total + var.peUni_total + var.transport_total + var.book_total

        Label2.Text = "Total : ₱" + (var.total_pay).ToString + ".00"
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub continue_btn_Click(sender As Object, e As EventArgs) Handles continue_btn.Click
        Dim receipt As New enroll_receipt()
        receipt.Show()
        Me.Close()
    End Sub
End Class