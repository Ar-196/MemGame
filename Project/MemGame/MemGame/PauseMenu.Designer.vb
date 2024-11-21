<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PauseMenu
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
        Me.lblPause = New System.Windows.Forms.Label()
        Me.btnToGame = New System.Windows.Forms.Button()
        Me.btnToMenuConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPause
        '
        Me.lblPause.AutoSize = True
        Me.lblPause.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.Location = New System.Drawing.Point(120, 77)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(353, 72)
        Me.lblPause.TabIndex = 0
        Me.lblPause.Text = "Game Paused"
        '
        'btnToGame
        '
        Me.btnToGame.Location = New System.Drawing.Point(167, 185)
        Me.btnToGame.Name = "btnToGame"
        Me.btnToGame.Size = New System.Drawing.Size(274, 103)
        Me.btnToGame.TabIndex = 1
        Me.btnToGame.Text = "Resume Game"
        Me.btnToGame.UseVisualStyleBackColor = True
        '
        'btnToMenuConfirm
        '
        Me.btnToMenuConfirm.Location = New System.Drawing.Point(167, 311)
        Me.btnToMenuConfirm.Name = "btnToMenuConfirm"
        Me.btnToMenuConfirm.Size = New System.Drawing.Size(274, 112)
        Me.btnToMenuConfirm.TabIndex = 2
        Me.btnToMenuConfirm.Text = "Go To Main Menu"
        Me.btnToMenuConfirm.UseVisualStyleBackColor = True
        '
        'PauseMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 578)
        Me.Controls.Add(Me.btnToMenuConfirm)
        Me.Controls.Add(Me.btnToGame)
        Me.Controls.Add(Me.lblPause)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PauseMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PauseMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPause As System.Windows.Forms.Label
    Friend WithEvents btnToGame As System.Windows.Forms.Button
    Friend WithEvents btnToMenuConfirm As System.Windows.Forms.Button
End Class
