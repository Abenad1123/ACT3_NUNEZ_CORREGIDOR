Public Class mathchallenge_main

    Dim currentQuestion As Integer = 0

    Private Sub go_back_click(sender As Object, e As EventArgs) Handles go_back.Click
        OpenForm(Of main_menu)(Me)
    End Sub

    Private Sub Game1_Load(sender As Object, e As EventArgs) Handles rockpaperscissors.Click
        OpenForm(Of rock_paper_scissors_main)(Me)
    End Sub

    Private Sub Game2_Load(sender As Object, e As EventArgs) Handles fallingblock.Click
        OpenForm(Of evade_a_missile_main)(Me)
    End Sub

    Private Sub Game3_Load(sender As Object, e As EventArgs) Handles whackamole.Click
        OpenForm(Of whack_a_mole_main)(Me)
    End Sub

    Private Sub Game4_Load(sender As Object, e As EventArgs) Handles reactiontime.Click
        OpenForm(Of reactiontime_main)(Me)
    End Sub

    Private Sub Game5_Load(sender As Object, e As EventArgs) Handles self.Click
        OpenForm(Of mathchallenge_main)(Me)
    End Sub

    Private Sub mathchallenge_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuestion()
    End Sub

    Private Sub LoadQuestion()
        Select Case currentQuestion

            Case 0 ' START
                Label1.Text = "Click any answer button to start"
                PictureBox1.Image = Image.FromFile("C:\Users\Cedric Hanz D. Nunez\Downloads\abedadi\12.png")
                Button1.Text = "Start"
                Button2.Text = "Start"
                Button3.Text = "Start"
                Button4.Text = "Start"

            Case 1
                Label1.Text = "What is 8 × 7?"
                PictureBox1.Image = Image.FromFile("C:\Users\Cedric Hanz D. Nunez\Downloads\abedadi\13.png")
                Button1.Text = "54"
                Button2.Text = "56"
                Button3.Text = "64"
                Button4.Text = "58"

            Case 2
                Label1.Text = "Solve: 3² + 4²"
                PictureBox1.Image = Image.FromFile("C:\Users\Cedric Hanz D. Nunez\Downloads\abedadi\14.png")
                Button1.Text = "25"
                Button2.Text = "14"
                Button3.Text = "13"
                Button4.Text = "21"

            Case 3
                Label1.Text = "What is √144?"
                PictureBox1.Image = Image.FromFile("C:\Users\Cedric Hanz D. Nunez\Downloads\abedadi\15.png")
                Button1.Text = "10"
                Button2.Text = "11"
                Button3.Text = "12"
                Button4.Text = "14"

            Case 4
                Label1.Text = "Solve: 5x = 45"
                PictureBox1.Image = Image.FromFile("C:\Users\Cedric Hanz D. Nunez\Downloads\abedadi\16.png")
                Button1.Text = "7"
                Button2.Text = "8"
                Button3.Text = "9"
                Button4.Text = "10"

            Case 5
                Label1.Text = "What is 15% of 200?"
                PictureBox1.Image = Image.FromFile("C:\Users\Cedric Hanz D. Nunez\Downloads\abedadi\17.png")
                Button1.Text = "20"
                Button2.Text = "25"
                Button3.Text = "30"
                Button4.Text = "35"

            Case 6
                Label1.Text = "Who created the Cartesian plane?"
                PictureBox1.Image = Image.FromFile("C:\Users\Cedric Hanz D. Nunez\Downloads\abedadi\18.png")
                Button1.Text = "Isaac Newton"
                Button2.Text = "René Descartes"
                Button3.Text = "Maracris Lappay"
                Button4.Text = "Albert Einstein"


            Case 7
            Case 7
                Label1.Text = "Solve using PEMDAS: 8 + 12 ÷ 3 × (4 − 2)²"
                PictureBox1.Image = Image.FromFile("C:\Users\Cedric Hanz D. Nunez\Downloads\abedadi\19.png")
                Button1.Text = "16"
                Button2.Text = "20"
                Button3.Text = "24"   ' ✅ correct
                Button4.Text = "32"


            Case 8 ' FINISH
                Label1.Text = "Congratulations! You finished!"
                PictureBox1.Image = Image.FromFile("C:\Users\Cedric Hanz D. Nunez\Downloads\abedadi\20.png")
                Button1.Text = "Restart"
                Button2.Text = "Restart"
                Button3.Text = "Restart"
                Button4.Text = "Restart"
        End Select
    End Sub

    Private Sub checkanswerEvent(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        Dim btn As Button = CType(sender, Button)

        If currentQuestion = 0 Or currentQuestion = 8 Then
            currentQuestion = 1
            LoadQuestion()
            Exit Sub
        End If

        Dim correct As Boolean = False

        Select Case currentQuestion
            Case 1 : correct = (btn.Text = "56")
            Case 2 : correct = (btn.Text = "25")
            Case 3 : correct = (btn.Text = "12")
            Case 4 : correct = (btn.Text = "9")
            Case 5 : correct = (btn.Text = "30")
            Case 6 : correct = (btn.Text = "René Descartes")
            Case 7 : correct = (btn.Text = "24")
        End Select

        If correct Then
            MessageBox.Show("Correct!")
            currentQuestion += 1
            LoadQuestion()
        Else
            MessageBox.Show("Wrong answer. Try again.")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

End Class
