Imports System.Reflection.Emit

Public Class sc_main_menu
    ' ---------------- INITIAL DATA & FUNCTIONS ----------------
    Dim SideMenuExpanded As Boolean = False
    Dim StepSize As Integer = 10
    Private Sub Form_Initial(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(enroll_btn, My.Resources.enroll_btn, My.Resources.enroll_btn_hover)
        Basic.ImgHover(store_btn, My.Resources.store_btn, My.Resources.store_btn_hover)
        Basic.ImgHover(menu_btn, My.Resources.menu_btn, My.Resources.menu_btn_hover)
        Basic.ImgHover(library_btn, My.Resources.library_btn, My.Resources.library_btn_hover)
        hamburger_menu.Width = 0
        hamburger_menu.BackColor = ColorTranslator.FromHtml("#045f33")
        acad_btn.BackColor = ColorTranslator.FromHtml("#045f33")
        about_btn.BackColor = ColorTranslator.FromHtml("#045f33")
        go_back.BackColor = ColorTranslator.FromHtml("#045f33")

    End Sub
    Private Sub enroll_btn_Click(sender As Object, e As EventArgs) Handles enroll_btn.Click
        OpenForm(Of enroll_step1)(Me)
    End Sub
    Private Sub store_btn_Click(sender As Object, e As EventArgs) Handles store_btn.Click
        OpenForm(Of merch_welcome)(Me)
    End Sub

    Private Sub library_btn_Click(sender As Object, e As EventArgs) Handles library_btn.Click
        OpenForm(Of library_welcome)(Me)
    End Sub

    Private Sub acad_btn_Click(sender As Object, e As EventArgs)
        OpenForm(Of acad_calendar)(Me)
    End Sub

    Private Sub about_btn_Click(sender As Object, e As EventArgs)
        OpenForm(Of about)(Me)
    End Sub

    Private Sub special_class_Click(sender As Object, e As EventArgs)
        OpenForm(Of main_menu)(Me)
    End Sub

    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles menu_btn.Click
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
    Private Performing_Arts() As TableLayoutPanel
    Private Music() As TableLayoutPanel
    Private Sports_N_Martial_Arts() As TableLayoutPanel
    Private Visual_Arts() As TableLayoutPanel
    Private Buttons_Control() As PictureBox

    Private pictures() As Image
    Private activity_price() As Integer = {5000, 5000, 4200, 5000, 5000, 5000, 5000, 5500, 5500, 5500, 4500, 4500}

    Dim activities() As String = {"Ballet", "Swimming", "Karate", "Piano", "Guitar", "Violin", "Singing", "Theater", "Acting", "Painting", "Drawing"}

    Dim descriptions() As String = {
            "Learn classical ballet techniques, posture, flexibility, and basic choreography through guided practice and performance exercises.",
            "Develop proper swimming techniques, water safety skills, and confidence in the water through structured training sessions.",
            "Build discipline, strength, and self-defense skills while learning fundamental martial arts movements and techniques.",
            "Learn piano basics including proper hand positioning, note reading, and rhythm through guided practice sessions.",
            "Develop guitar skills by learning chords, strumming patterns, and basic music reading for performance and practice.",
            "Learn violin fundamentals such as bow control, finger placement, and tone production through structured lessons.",
            "Improve vocal strength, pitch accuracy, and confidence through breathing techniques and guided singing exercises.",
            "Explore stage performance, script interpretation, and theatrical expression through guided theater workshops.",
            "Develop acting skills such as expression, improvisation, and character portrayal through interactive performance activities.",
            "Learn basic painting techniques, color blending, and visual composition using various art materials.",
            "Develop drawing skills by practicing line work, shading, and creative visual expression through guided exercises."
        }
    Private Sub MeLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        Performing_Arts = {TableLayoutPanel2, TableLayoutPanel17, TableLayoutPanel19}
        Music = {TableLayoutPanel9, TableLayoutPanel11, TableLayoutPanel13, TableLayoutPanel15}
        Sports_N_Martial_Arts = {TableLayoutPanel5, TableLayoutPanel7}
        Visual_Arts = {TableLayoutPanel21, TableLayoutPanel23}

        Dim buttons() As PictureBox = {PictureBox3, PictureBox6, PictureBox8, PictureBox10, PictureBox12, PictureBox14, PictureBox16, PictureBox18, PictureBox20, PictureBox22, PictureBox24}
        Dim pictureBoxes() As PictureBox = {PictureBox2, PictureBox5, PictureBox7, PictureBox9, PictureBox11, PictureBox13, PictureBox15, PictureBox17, PictureBox19, PictureBox21, PictureBox23}
        pictures = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11}
        Dim Labels() As System.Windows.Forms.Label = {Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11}

        For Each btn In buttons
            Basic.ImgHover(btn, My.Resources.view_detail_btn, My.Resources.view_detail_btn_hover)
        Next

        For index As Integer = 0 To 10
            pictureBoxes(index).Image = pictures(index)
            Labels(index).Text = descriptions(index)
        Next
        ComboBox1.SelectedIndex = 0
        Basic.ImgWidthWrap(FlowLayoutPanel1, Panel1)

        Buttons_Control = {PictureBox3, PictureBox6, PictureBox8, PictureBox10, PictureBox12,
                        PictureBox14, PictureBox16, PictureBox18, PictureBox20, PictureBox22, PictureBox24}

        For Each pb In Buttons_Control
            AddHandler pb.Click, AddressOf PictureBox_Click
        Next

        TableLayoutPanel25.Visible = False
    End Sub

    Private Sub MeResize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Basic.ImgWidthWrap(FlowLayoutPanel1, Panel1)
    End Sub

    Private Sub Filter_Caterogies(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim boxes() As Array = {Performing_Arts, Music, Sports_N_Martial_Arts, Visual_Arts}

        If ComboBox1.SelectedItem IsNot "All" Then
            For Each array In boxes
                For Each box In array
                    box.Visible = False
                Next
            Next
        End If

        Select Case ComboBox1.SelectedItem
            Case "All"
                For Each array In boxes
                    For Each box In array
                        box.Visible = True
                    Next
                Next
            Case "Performing Arts"
                For Each box In Performing_Arts : box.Visible = True
                Next
            Case "Music"
                For Each box In Music : box.Visible = True
                Next
            Case "Sports & Martial Arts"
                For Each box In Sports_N_Martial_Arts : box.Visible = True
                Next
            Case "Visual Arts"
                For Each box In Performing_Arts : box.Visible = True
                Next
        End Select
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        Dim selected As Integer
        Dim pb As PictureBox = CType(sender, PictureBox)

        For i = 0 To Buttons_Control.Count - 1
            If Buttons_Control(i) Is pb Then selected = i + 1
        Next

        For i = 0 To activities.Count - 1
            If i + 1 = selected Then
                var.chosen_activity = activities(i)

                PictureBox25.Image = pictures(i)
                Label17.Text = var.chosen_activity & " Lesson"
                Label18.Text = descriptions(i)
                Label19.Text = "Php " & activity_price(i).ToString() & ".00 / Year"
                TableLayoutPanel25.Visible = True
            End If
        Next
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub
End Class