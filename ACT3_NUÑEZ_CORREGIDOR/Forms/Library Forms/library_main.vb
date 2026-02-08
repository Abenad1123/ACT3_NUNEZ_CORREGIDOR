Public Class library_main
    ' ---------------- INITIAL DATA & FUNCTIONS ----------------
    Dim SideMenuExpanded As Boolean = False
    Dim StepSize As Integer = 10
    Private Sub Form_Initial(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(enroll_btn, My.Resources.enroll_btn, My.Resources.enroll_btn_hover)
        Basic.ImgHover(store_btn, My.Resources.store_btn, My.Resources.store_btn_hover)
        Basic.ImgHover(menu_btn, My.Resources.menu_btn, My.Resources.menu_btn_hover)
        Basic.ImgHover(go_back_btn, My.Resources.go_back_btn, My.Resources.go_back_btn_hover)
        hamburger_menu.Width = 0
        hamburger_menu.BackColor = ColorTranslator.FromHtml("#045f33")
        acad_btn.BackColor = ColorTranslator.FromHtml("#045f33")
        about_btn.BackColor = ColorTranslator.FromHtml("#045f33")
        sc_btn.BackColor = ColorTranslator.FromHtml("#045f33")

    End Sub
    Private Sub enroll_btn_Click(sender As Object, e As EventArgs) Handles enroll_btn.Click
        OpenForm(Of enroll_step1)(Me)
    End Sub
    Private Sub store_btn_Click(sender As Object, e As EventArgs) Handles store_btn.Click
        OpenForm(Of merch_welcome)(Me)
    End Sub

    Private Sub library_btn_Click(sender As Object, e As EventArgs) Handles go_back_btn.Click
        OpenForm(Of main_menu)(Me)
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

    Private Sub MeLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("All")
        ComboBox1.Items.Add("Fiction")
        ComboBox1.Items.Add("Non-fiction")
        ComboBox1.Items.Add("Fantasy")
        ComboBox1.Items.Add("Mystery")
        ComboBox1.Items.Add("Science Fiction")
        ComboBox1.Items.Add("Math")
        ComboBox1.Items.Add("English")
        ComboBox1.Items.Add("Science")
        ComboBox1.Items.Add("Social Studies")
        ComboBox1.Items.Add("Religion / Values Education")
        ComboBox1.Items.Add("Technology & ICT")
        ComboBox1.Items.Add("Romance")

        ComboBox1.SelectedIndex = 0
        DataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#0cb563")
        Button4.Visible = False
    End Sub

    Private Sub CategoryChoose(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CheckedListBox1.Items.Clear()

        If ComboBox1.SelectedItem = "All" Then
            Dim allCategories() As Array = {var.Fiction, var.NonFiction, var.Fantasy, var.Mystery, var.ScienceFiction, var.Math,
                var.English, var.Science, var.SocialStudies, var.Religion, var.TechnologyICT, var.Romance}

            For Each book In allCategories
                For Each title In book
                    CheckedListBox1.Items.Add(title)
                Next
            Next
            Exit Sub
        End If

        Select Case ComboBox1.SelectedItem
            Case "Fiction" : ChangeItems(var.Fiction)
            Case "Non-fiction" : ChangeItems(var.NonFiction)
            Case "Fantasy" : ChangeItems(var.Fantasy)
            Case "Mystery" : ChangeItems(var.Mystery)
            Case "Science Fiction" : ChangeItems(var.ScienceFiction)
            Case "Romance" : ChangeItems(var.Romance)
            Case "Math" : ChangeItems(var.Math)
            Case "English" : ChangeItems(var.English)
            Case "Science" : ChangeItems(var.Science)
            Case "Social Studies" : ChangeItems(var.SocialStudies)
            Case "Religion / Values Education" : ChangeItems(var.Religion)
            Case "Technology & ICT" : ChangeItems(var.TechnologyICT)
        End Select
    End Sub

    Sub ChangeItems(category As Array)
        CheckedListBox1.Items.Clear()
        For Each book In category
            CheckedListBox1.Items.Add(book)
        Next
    End Sub

    Private Sub AddBook(sender As Object, e As EventArgs) Handles Button1.Click
        If NumericUpDown1.Value < 1 Then
            MessageBox.Show("Please enter a duration greater than 0")
            Exit Sub
        ElseIf NumericUpDown2.Value < 1 Then
            MessageBox.Show("Please enter a quantity greater than 0")
            Exit Sub
        End If

        Dim result As DialogResult
        result = MessageBox.Show("Are you finished borrowing a book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Go to the library to receive the book and the book pass.", "Next Step", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Exit Sub
        End If

        Dim dueDate As Date = Date.Today.AddDays(NumericUpDown1.Value)
        Dim dateBorrowed As Date = Date.Today()
        Dim day As String

        For Each book In CheckedListBox1.CheckedItems
            If NumericUpDown1.Value > 1 Then
                day = NumericUpDown1.Value & " days"
            Else
                day = NumericUpDown1.Value & " day"
            End If

            DataGridView1.Rows.Add(GenerateCode(), book, NumericUpDown2.Value.ToString(), day, dateBorrowed.ToShortDateString(), dueDate.ToShortDateString())
        Next
    End Sub

    Private Sub RemoveBook(sender As Object, e As EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            If Not row.IsNewRow Then
                DataGridView1.Rows.Remove(row)
            End If
        Next
    End Sub

    Function GenerateCode(Optional length As Integer = 8) As String
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim rnd As New Random()
        Dim result As String = ""

        For i As Integer = 1 To length
            result &= chars(rnd.Next(chars.Length))
        Next

        Return result
    End Function

    Private Sub txtSearchID_TextChanged(sender As Object, e As EventArgs) Handles Button3.Click
        Dim searchID As String = TextBox1.Text.Trim()
        Dim Isthere As Boolean

        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("There's nothing to search")
        End If

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                If searchID = "" OrElse row.Cells(0).Value.ToString() = searchID Then
                    Isthere = True
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            End If
        Next

        If Isthere = True Then
            Button4.Visible = True
        Else
            MessageBox.Show($"ID : {TextBox1.Text} cannot be found")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Visible = True
        Next
        Button4.Visible = False
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
