<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImgMatchWin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBackToMain = New System.Windows.Forms.Button()
        Me.TimeDisplay = New System.Windows.Forms.Label()
        Me.BestTimeDisplay = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblImgWin
        '
        Me.lblImgWin.AutoSize = True
        Me.lblImgWin.BackColor = System.Drawing.Color.Transparent
        Me.lblImgWin.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImgWin.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblImgWin.Location = New System.Drawing.Point(8, 13)
        Me.lblImgWin.Name = "lblImgWin"
        Me.lblImgWin.Size = New System.Drawing.Size(202, 57)
        Me.lblImgWin.TabIndex = 0
        Me.lblImgWin.Text = "You Win! "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(8, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Your time was:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(8, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(652, 57)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "And your best recorded time was:"
        '
        'btnBackToMain
        '
        Me.btnBackToMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBackToMain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBackToMain.Location = New System.Drawing.Point(18, 414)
        Me.btnBackToMain.Name = "btnBackToMain"
        Me.btnBackToMain.Size = New System.Drawing.Size(1497, 85)
        Me.btnBackToMain.TabIndex = 3
        Me.btnBackToMain.Text = "Back To Main Menu"
        Me.btnBackToMain.UseVisualStyleBackColor = False
        '
        'TimeDisplay
        '
        Me.TimeDisplay.AutoSize = True
        Me.TimeDisplay.BackColor = System.Drawing.Color.Transparent
        Me.TimeDisplay.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeDisplay.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TimeDisplay.Location = New System.Drawing.Point(306, 84)
        Me.TimeDisplay.Name = "TimeDisplay"
        Me.TimeDisplay.Size = New System.Drawing.Size(115, 57)
        Me.TimeDisplay.TabIndex = 4
        Me.TimeDisplay.Text = "Time"
        '
        'BestTimeDisplay
        '
        Me.BestTimeDisplay.AutoSize = True
        Me.BestTimeDisplay.BackColor = System.Drawing.Color.Transparent
        Me.BestTimeDisplay.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BestTimeDisplay.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BestTimeDisplay.Location = New System.Drawing.Point(666, 159)
        Me.BestTimeDisplay.Name = "BestTimeDisplay"
        Me.BestTimeDisplay.Size = New System.Drawing.Size(103, 57)
        Me.BestTimeDisplay.TabIndex = 5
        Me.BestTimeDisplay.Text = "Best"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(12, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 57)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'ImgMatchWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1535, 518)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BestTimeDisplay)
        Me.Controls.Add(Me.TimeDisplay)
        Me.Controls.Add(Me.btnBackToMain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblImgWin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImgMatchWin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImgMatchWin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblImgWin As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBackToMain As System.Windows.Forms.Button
    Friend WithEvents TimeDisplay As System.Windows.Forms.Label
    Friend WithEvents BestTimeDisplay As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
