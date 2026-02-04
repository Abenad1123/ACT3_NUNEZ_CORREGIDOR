<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reactiontime_main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rockpaperscissors = New System.Windows.Forms.ToolStripMenuItem()
        Me.fallingblock = New System.Windows.Forms.ToolStripMenuItem()
        Me.whackamole = New System.Windows.Forms.ToolStripMenuItem()
        Me.self = New System.Windows.Forms.ToolStripMenuItem()
        Me.mathchallenge = New System.Windows.Forms.ToolStripMenuItem()
        Me.go_back = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.go_back, Me.GamesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GamesToolStripMenuItem
        '
        Me.GamesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rockpaperscissors, Me.fallingblock, Me.whackamole, Me.self, Me.mathchallenge})
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
        'self
        '
        Me.self.Name = "self"
        Me.self.Size = New System.Drawing.Size(226, 26)
        Me.self.Text = "Reaction Time"
        '
        'mathchallenge
        '
        Me.mathchallenge.Name = "mathchallenge"
        Me.mathchallenge.Size = New System.Drawing.Size(226, 26)
        Me.mathchallenge.Text = "Math Challenge"
        '
        'go_back
        '
        Me.go_back.Image = Global.ACT3_NUÑEZ_CORREGIDOR.My.Resources.Resources.home_icon
        Me.go_back.Name = "go_back"
        Me.go_back.Size = New System.Drawing.Size(97, 24)
        Me.go_back.Text = "Go back"
        '
        'reactiontime_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "reactiontime_main"
        Me.Text = "reactiontime"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rockpaperscissors As ToolStripMenuItem
    Friend WithEvents fallingblock As ToolStripMenuItem
    Friend WithEvents whackamole As ToolStripMenuItem
    Friend WithEvents self As ToolStripMenuItem
    Friend WithEvents mathchallenge As ToolStripMenuItem
    Friend WithEvents go_back As ToolStripMenuItem
End Class
