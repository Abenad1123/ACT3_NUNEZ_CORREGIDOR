<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mathchallenge
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
        Me.reactiontime = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GamesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GamesToolStripMenuItem
        '
        Me.GamesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rockpaperscissors, Me.fallingblock, Me.whackamole, Me.reactiontime, Me.ToolStripMenuItem1})
        Me.GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
        Me.GamesToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
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
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(226, 26)
        Me.ToolStripMenuItem1.Text = "Math Challenge"
        '
        'mathchallenge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "mathchallenge"
        Me.Text = "mathchallenge"
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
    Friend WithEvents reactiontime As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
