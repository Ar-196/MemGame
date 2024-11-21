<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackToMainConfirm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackToMainConfirm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnToMain = New System.Windows.Forms.Button()
        Me.btnToPause = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(837, 120)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Are you sure you want to return to the main menu? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you click ""Yes"", all the p" & _
            "rogress on your current " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "game will be lost."
        '
        'btnToMain
        '
        Me.btnToMain.Location = New System.Drawing.Point(585, 281)
        Me.btnToMain.Name = "btnToMain"
        Me.btnToMain.Size = New System.Drawing.Size(286, 82)
        Me.btnToMain.TabIndex = 2
        Me.btnToMain.Text = "Return To Main Menu"
        Me.btnToMain.UseVisualStyleBackColor = True
        '
        'btnToPause
        '
        Me.btnToPause.Location = New System.Drawing.Point(877, 281)
        Me.btnToPause.Name = "btnToPause"
        Me.btnToPause.Size = New System.Drawing.Size(341, 82)
        Me.btnToPause.TabIndex = 3
        Me.btnToPause.Text = "Return To Pause Menu"
        Me.btnToPause.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(78, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BackToMainConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 411)
        Me.Controls.Add(Me.btnToPause)
        Me.Controls.Add(Me.btnToMain)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BackToMainConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackToMainConfirm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnToMain As System.Windows.Forms.Button
    Friend WithEvents btnToPause As System.Windows.Forms.Button
End Class
