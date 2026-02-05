<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mathchallenge_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mathchallenge_main))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.go_back = New System.Windows.Forms.ToolStripMenuItem()
		Me.GamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.rockpaperscissors = New System.Windows.Forms.ToolStripMenuItem()
		Me.fallingblock = New System.Windows.Forms.ToolStripMenuItem()
		Me.whackamole = New System.Windows.Forms.ToolStripMenuItem()
		Me.reactiontime = New System.Windows.Forms.ToolStripMenuItem()
		Me.self = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.go_back, Me.GamesToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(858, 28)
		Me.MenuStrip1.TabIndex = 16
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'go_back
		'
		Me.go_back.Image = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources.home_icon
		Me.go_back.Name = "go_back"
		Me.go_back.Size = New System.Drawing.Size(97, 24)
		Me.go_back.Text = "Go back"
		'
		'GamesToolStripMenuItem
		'
		Me.GamesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rockpaperscissors, Me.fallingblock, Me.whackamole, Me.reactiontime, Me.self})
		Me.GamesToolStripMenuItem.Image = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources.game_icon
		Me.GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
		Me.GamesToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
		Me.GamesToolStripMenuItem.Text = "Games"
		'
		'rockpaperscissors
		'
		Me.rockpaperscissors.Name = "rockpaperscissors"
		Me.rockpaperscissors.Size = New System.Drawing.Size(226, 26)
		Me.rockpaperscissors.Text = "Rock, Paper, Scissors"
		'
		'fallingblock
		'
		Me.fallingblock.Name = "fallingblock"
		Me.fallingblock.Size = New System.Drawing.Size(226, 26)
		Me.fallingblock.Text = "Evade the Missle"
		'
		'whackamole
		'
		Me.whackamole.Name = "whackamole"
		Me.whackamole.Size = New System.Drawing.Size(226, 26)
		Me.whackamole.Text = "Whack a Mole"
		'
		'reactiontime
		'
		Me.reactiontime.Name = "reactiontime"
		Me.reactiontime.Size = New System.Drawing.Size(226, 26)
		Me.reactiontime.Text = "Reaction Time"
		'
		'self
		'
		Me.self.Name = "self"
		Me.self.Size = New System.Drawing.Size(226, 26)
		Me.self.Text = "Math Challenge"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Label1.Location = New System.Drawing.Point(360, 385)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(107, 30)
		Me.Label1.TabIndex = 18
		Me.Label1.Text = "Question"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Button1.Location = New System.Drawing.Point(40, 428)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(142, 40)
		Me.Button1.TabIndex = 19
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Button2.Location = New System.Drawing.Point(248, 428)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(142, 40)
		Me.Button2.TabIndex = 20
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Button3.Location = New System.Drawing.Point(452, 428)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(142, 40)
		Me.Button3.TabIndex = 21
		Me.Button3.Text = "Button3"
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Button4.Location = New System.Drawing.Point(660, 428)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(142, 40)
		Me.Button4.TabIndex = 22
		Me.Button4.Text = "Button4"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources._12
		Me.PictureBox1.Location = New System.Drawing.Point(40, 31)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(762, 351)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 17
		Me.PictureBox1.TabStop = False
		'
		'mathchallenge_main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(858, 480)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "mathchallenge_main"
		Me.Text = "De La Salle Santiago Zobel"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rockpaperscissors As ToolStripMenuItem
    Friend WithEvents fallingblock As ToolStripMenuItem
    Friend WithEvents whackamole As ToolStripMenuItem
    Friend WithEvents reactiontime As ToolStripMenuItem
    Friend WithEvents self As ToolStripMenuItem
    Friend WithEvents go_back As ToolStripMenuItem
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
End Class
