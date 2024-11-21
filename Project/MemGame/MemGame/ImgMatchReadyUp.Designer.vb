<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImgMatchReadyUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImgMatchReadyUp))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHardBest = New System.Windows.Forms.Label()
        Me.lblMedBest = New System.Windows.Forms.Label()
        Me.lblEasyBest = New System.Windows.Forms.Label()
        Me.ImgHardSet = New System.Windows.Forms.RadioButton()
        Me.ImgMedSet = New System.Windows.Forms.RadioButton()
        Me.ImgEasySet = New System.Windows.Forms.RadioButton()
        Me.btnImgMatchStart = New System.Windows.Forms.Button()
        Me.ImgMatchDesc = New System.Windows.Forms.Label()
        Me.HeaderText = New System.Windows.Forms.Label()
        Me.btnBacktoMain2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.btnImgMatchStart)
        Me.GroupBox2.Controls.Add(Me.ImgMatchDesc)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1252, 653)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Image Match"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHardBest)
        Me.GroupBox1.Controls.Add(Me.lblMedBest)
        Me.GroupBox1.Controls.Add(Me.lblEasyBest)
        Me.GroupBox1.Controls.Add(Me.ImgHardSet)
        Me.GroupBox1.Controls.Add(Me.ImgMedSet)
        Me.GroupBox1.Controls.Add(Me.ImgEasySet)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 234)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1240, 193)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose the dificulty of your game here:"
        '
        'lblHardBest
        '
        Me.lblHardBest.AutoSize = True
        Me.lblHardBest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHardBest.Location = New System.Drawing.Point(298, 128)
        Me.lblHardBest.Name = "lblHardBest"
        Me.lblHardBest.Size = New System.Drawing.Size(441, 41)
        Me.lblHardBest.TabIndex = 14
        Me.lblHardBest.Text = "Best Time : No Time Recorded"
        '
        'lblMedBest
        '
        Me.lblMedBest.AutoSize = True
        Me.lblMedBest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedBest.Location = New System.Drawing.Point(345, 82)
        Me.lblMedBest.Name = "lblMedBest"
        Me.lblMedBest.Size = New System.Drawing.Size(441, 41)
        Me.lblMedBest.TabIndex = 13
        Me.lblMedBest.Text = "Best Time : No Time Recorded"
        '
        'lblEasyBest
        '
        Me.lblEasyBest.AutoSize = True
        Me.lblEasyBest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEasyBest.Location = New System.Drawing.Point(298, 36)
        Me.lblEasyBest.Name = "lblEasyBest"
        Me.lblEasyBest.Size = New System.Drawing.Size(441, 41)
        Me.lblEasyBest.TabIndex = 12
        Me.lblEasyBest.Text = "Best Time : No Time Recorded"
        '
        'ImgHardSet
        '
        Me.ImgHardSet.AutoSize = True
        Me.ImgHardSet.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImgHardSet.Location = New System.Drawing.Point(6, 126)
        Me.ImgHardSet.Name = "ImgHardSet"
        Me.ImgHardSet.Size = New System.Drawing.Size(262, 45)
        Me.ImgHardSet.TabIndex = 11
        Me.ImgHardSet.TabStop = True
        Me.ImgHardSet.Text = "Hard (6 x 6 grid)"
        Me.ImgHardSet.UseVisualStyleBackColor = True
        '
        'ImgMedSet
        '
        Me.ImgMedSet.AutoSize = True
        Me.ImgMedSet.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImgMedSet.Location = New System.Drawing.Point(6, 80)
        Me.ImgMedSet.Name = "ImgMedSet"
        Me.ImgMedSet.Size = New System.Drawing.Size(309, 45)
        Me.ImgMedSet.TabIndex = 10
        Me.ImgMedSet.TabStop = True
        Me.ImgMedSet.Text = "Medium (5 x 5 grid)"
        Me.ImgMedSet.UseVisualStyleBackColor = True
        '
        'ImgEasySet
        '
        Me.ImgEasySet.AutoSize = True
        Me.ImgEasySet.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImgEasySet.Location = New System.Drawing.Point(6, 34)
        Me.ImgEasySet.Name = "ImgEasySet"
        Me.ImgEasySet.Size = New System.Drawing.Size(256, 45)
        Me.ImgEasySet.TabIndex = 9
        Me.ImgEasySet.TabStop = True
        Me.ImgEasySet.Text = "Easy (4 x 4 grid)"
        Me.ImgEasySet.UseVisualStyleBackColor = True
        '
        'btnImgMatchStart
        '
        Me.btnImgMatchStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImgMatchStart.Location = New System.Drawing.Point(795, 487)
        Me.btnImgMatchStart.Name = "btnImgMatchStart"
        Me.btnImgMatchStart.Size = New System.Drawing.Size(451, 144)
        Me.btnImgMatchStart.TabIndex = 12
        Me.btnImgMatchStart.Text = "Start Image Match"
        Me.btnImgMatchStart.UseVisualStyleBackColor = True
        '
        'ImgMatchDesc
        '
        Me.ImgMatchDesc.AutoSize = True
        Me.ImgMatchDesc.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImgMatchDesc.Location = New System.Drawing.Point(6, 41)
        Me.ImgMatchDesc.Name = "ImgMatchDesc"
        Me.ImgMatchDesc.Size = New System.Drawing.Size(1102, 180)
        Me.ImgMatchDesc.TabIndex = 11
        Me.ImgMatchDesc.Text = resources.GetString("ImgMatchDesc.Text")
        '
        'HeaderText
        '
        Me.HeaderText.AutoSize = True
        Me.HeaderText.BackColor = System.Drawing.Color.Transparent
        Me.HeaderText.Font = New System.Drawing.Font("Segoe UI Symbol", 19.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderText.Location = New System.Drawing.Point(16, 23)
        Me.HeaderText.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.HeaderText.Name = "HeaderText"
        Me.HeaderText.Size = New System.Drawing.Size(662, 76)
        Me.HeaderText.TabIndex = 21
        Me.HeaderText.Text = "Image Match - Ready Up"
        '
        'btnBacktoMain2
        '
        Me.btnBacktoMain2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBacktoMain2.Location = New System.Drawing.Point(948, 12)
        Me.btnBacktoMain2.Name = "btnBacktoMain2"
        Me.btnBacktoMain2.Size = New System.Drawing.Size(316, 100)
        Me.btnBacktoMain2.TabIndex = 20
        Me.btnBacktoMain2.Text = "Back To Main Menu"
        Me.btnBacktoMain2.UseVisualStyleBackColor = False
        '
        'ImgMatchReadyUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(216.0!, 216.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1276, 815)
        Me.Controls.Add(Me.HeaderText)
        Me.Controls.Add(Me.btnBacktoMain2)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImgMatchReadyUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHardBest As System.Windows.Forms.Label
    Friend WithEvents lblMedBest As System.Windows.Forms.Label
    Friend WithEvents lblEasyBest As System.Windows.Forms.Label
    Friend WithEvents ImgHardSet As System.Windows.Forms.RadioButton
    Friend WithEvents ImgMedSet As System.Windows.Forms.RadioButton
    Friend WithEvents ImgEasySet As System.Windows.Forms.RadioButton
    Friend WithEvents btnImgMatchStart As System.Windows.Forms.Button
    Friend WithEvents ImgMatchDesc As System.Windows.Forms.Label
    Friend WithEvents HeaderText As System.Windows.Forms.Label
    Friend WithEvents btnBacktoMain2 As System.Windows.Forms.Button
End Class
