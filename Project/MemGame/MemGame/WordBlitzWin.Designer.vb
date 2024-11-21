<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordBlitzWin
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BestTimeDisplay = New System.Windows.Forms.Label()
        Me.TimeDisplay = New System.Windows.Forms.Label()
        Me.btnBackToMain = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWordWin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 57)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Label3"
        '
        'BestTimeDisplay
        '
        Me.BestTimeDisplay.AutoSize = True
        Me.BestTimeDisplay.BackColor = System.Drawing.Color.Transparent
        Me.BestTimeDisplay.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BestTimeDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BestTimeDisplay.Location = New System.Drawing.Point(694, 152)
        Me.BestTimeDisplay.Name = "BestTimeDisplay"
        Me.BestTimeDisplay.Size = New System.Drawing.Size(103, 57)
        Me.BestTimeDisplay.TabIndex = 12
        Me.BestTimeDisplay.Text = "Best"
        '
        'TimeDisplay
        '
        Me.TimeDisplay.AutoSize = True
        Me.TimeDisplay.BackColor = System.Drawing.Color.Transparent
        Me.TimeDisplay.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TimeDisplay.Location = New System.Drawing.Point(310, 80)
        Me.TimeDisplay.Name = "TimeDisplay"
        Me.TimeDisplay.Size = New System.Drawing.Size(115, 57)
        Me.TimeDisplay.TabIndex = 11
        Me.TimeDisplay.Text = "Time"
        '
        'btnBackToMain
        '
        Me.btnBackToMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBackToMain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBackToMain.Location = New System.Drawing.Point(12, 381)
        Me.btnBackToMain.Name = "btnBackToMain"
        Me.btnBackToMain.Size = New System.Drawing.Size(1529, 85)
        Me.btnBackToMain.TabIndex = 10
        Me.btnBackToMain.Text = "Back To Main Menu"
        Me.btnBackToMain.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(652, 57)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "And your best recorded time was:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 57)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Your time was:"
        '
        'lblWordWin
        '
        Me.lblWordWin.AutoSize = True
        Me.lblWordWin.BackColor = System.Drawing.Color.Transparent
        Me.lblWordWin.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWordWin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWordWin.Location = New System.Drawing.Point(12, 9)
        Me.lblWordWin.Name = "lblWordWin"
        Me.lblWordWin.Size = New System.Drawing.Size(190, 57)
        Me.lblWordWin.TabIndex = 7
        Me.lblWordWin.Text = "You Win!"
        '
        'WordBlitzWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1553, 478)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BestTimeDisplay)
        Me.Controls.Add(Me.TimeDisplay)
        Me.Controls.Add(Me.btnBackToMain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWordWin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WordBlitzWin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WordBlitzWin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BestTimeDisplay As System.Windows.Forms.Label
    Friend WithEvents TimeDisplay As System.Windows.Forms.Label
    Friend WithEvents btnBackToMain As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblWordWin As System.Windows.Forms.Label
End Class
