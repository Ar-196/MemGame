<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordBlitzLoss
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
        Me.lblImgWin = New System.Windows.Forms.Label()
        Me.btnBackToMain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblImgWin
        '
        Me.lblImgWin.AutoSize = True
        Me.lblImgWin.BackColor = System.Drawing.Color.Transparent
        Me.lblImgWin.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImgWin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblImgWin.Location = New System.Drawing.Point(12, 9)
        Me.lblImgWin.Name = "lblImgWin"
        Me.lblImgWin.Size = New System.Drawing.Size(1372, 228)
        Me.lblImgWin.TabIndex = 14
        Me.lblImgWin.Text = "Bad Luck! You Lose!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The correct words have been revealed on the previous screen." & _
            " Move this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "screen to reveal them." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnBackToMain
        '
        Me.btnBackToMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBackToMain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBackToMain.Location = New System.Drawing.Point(12, 302)
        Me.btnBackToMain.Name = "btnBackToMain"
        Me.btnBackToMain.Size = New System.Drawing.Size(1529, 85)
        Me.btnBackToMain.TabIndex = 15
        Me.btnBackToMain.Text = "Back To Main Menu"
        Me.btnBackToMain.UseVisualStyleBackColor = False
        '
        'WordBlitzLoss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1549, 399)
        Me.Controls.Add(Me.btnBackToMain)
        Me.Controls.Add(Me.lblImgWin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WordBlitzLoss"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WordBlitzLoss"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblImgWin As System.Windows.Forms.Label
    Friend WithEvents btnBackToMain As System.Windows.Forms.Button
End Class
