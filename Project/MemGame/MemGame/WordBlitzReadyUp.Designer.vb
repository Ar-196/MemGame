<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordBlitzReadyUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WordBlitzReadyUp))
        Me.gbxWord = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHardBest = New System.Windows.Forms.Label()
        Me.lblMedBest = New System.Windows.Forms.Label()
        Me.lblEasyBest = New System.Windows.Forms.Label()
        Me.WordHardSet = New System.Windows.Forms.RadioButton()
        Me.WordMedSet = New System.Windows.Forms.RadioButton()
        Me.WordEasySet = New System.Windows.Forms.RadioButton()
        Me.WordMatchDesc = New System.Windows.Forms.Label()
        Me.btnWordMatchStart = New System.Windows.Forms.Button()
        Me.btnBacktoMain2 = New System.Windows.Forms.Button()
        Me.HeaderText = New System.Windows.Forms.Label()
        Me.gbxWord.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxWord
        '
        Me.gbxWord.Controls.Add(Me.GroupBox1)
        Me.gbxWord.Controls.Add(Me.btnWordMatchStart)
        Me.gbxWord.Controls.Add(Me.WordMatchDesc)
        Me.gbxWord.Location = New System.Drawing.Point(12, 153)
        Me.gbxWord.Name = "gbxWord"
        Me.gbxWord.Size = New System.Drawing.Size(1255, 639)
        Me.gbxWord.TabIndex = 12
        Me.gbxWord.TabStop = False
        Me.gbxWord.Text = "Word Blitz"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHardBest)
        Me.GroupBox1.Controls.Add(Me.lblMedBest)
        Me.GroupBox1.Controls.Add(Me.lblEasyBest)
        Me.GroupBox1.Controls.Add(Me.WordHardSet)
        Me.GroupBox1.Controls.Add(Me.WordMedSet)
        Me.GroupBox1.Controls.Add(Me.WordEasySet)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1238, 193)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose the dificulty of your game here:"
        '
        'lblHardBest
        '
        Me.lblHardBest.AutoSize = True
        Me.lblHardBest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHardBest.Location = New System.Drawing.Point(303, 128)
        Me.lblHardBest.Name = "lblHardBest"
        Me.lblHardBest.Size = New System.Drawing.Size(441, 41)
        Me.lblHardBest.TabIndex = 14
        Me.lblHardBest.Text = "Best Time : No Time Recorded"
        '
        'lblMedBest
        '
        Me.lblMedBest.AutoSize = True
        Me.lblMedBest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedBest.Location = New System.Drawing.Point(338, 82)
        Me.lblMedBest.Name = "lblMedBest"
        Me.lblMedBest.Size = New System.Drawing.Size(441, 41)
        Me.lblMedBest.TabIndex = 13
        Me.lblMedBest.Text = "Best Time : No Time Recorded"
        '
        'lblEasyBest
        '
        Me.lblEasyBest.AutoSize = True
        Me.lblEasyBest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEasyBest.Location = New System.Drawing.Point(303, 36)
        Me.lblEasyBest.Name = "lblEasyBest"
        Me.lblEasyBest.Size = New System.Drawing.Size(441, 41)
        Me.lblEasyBest.TabIndex = 12
        Me.lblEasyBest.Text = "Best Time : No Time Recorded"
        '
        'WordHardSet
        '
        Me.WordHardSet.AutoSize = True
        Me.WordHardSet.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WordHardSet.Location = New System.Drawing.Point(6, 126)
        Me.WordHardSet.Name = "WordHardSet"
        Me.WordHardSet.Size = New System.Drawing.Size(244, 45)
        Me.WordHardSet.TabIndex = 11
        Me.WordHardSet.TabStop = True
        Me.WordHardSet.Text = "Hard (7 words)"
        Me.WordHardSet.UseVisualStyleBackColor = True
        '
        'WordMedSet
        '
        Me.WordMedSet.AutoSize = True
        Me.WordMedSet.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WordMedSet.Location = New System.Drawing.Point(6, 80)
        Me.WordMedSet.Name = "WordMedSet"
        Me.WordMedSet.Size = New System.Drawing.Size(291, 45)
        Me.WordMedSet.TabIndex = 10
        Me.WordMedSet.TabStop = True
        Me.WordMedSet.Text = "Medium (6 words)"
        Me.WordMedSet.UseVisualStyleBackColor = True
        '
        'WordEasySet
        '
        Me.WordEasySet.AutoSize = True
        Me.WordEasySet.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WordEasySet.Location = New System.Drawing.Point(6, 34)
        Me.WordEasySet.Name = "WordEasySet"
        Me.WordEasySet.Size = New System.Drawing.Size(238, 45)
        Me.WordEasySet.TabIndex = 9
        Me.WordEasySet.TabStop = True
        Me.WordEasySet.Text = "Easy (5 words)"
        Me.WordEasySet.UseVisualStyleBackColor = True
        '
        'WordMatchDesc
        '
        Me.WordMatchDesc.AutoSize = True
        Me.WordMatchDesc.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WordMatchDesc.Location = New System.Drawing.Point(9, 31)
        Me.WordMatchDesc.Name = "WordMatchDesc"
        Me.WordMatchDesc.Size = New System.Drawing.Size(1130, 180)
        Me.WordMatchDesc.TabIndex = 1
        Me.WordMatchDesc.Text = resources.GetString("WordMatchDesc.Text")
        '
        'btnWordMatchStart
        '
        Me.btnWordMatchStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWordMatchStart.Location = New System.Drawing.Point(794, 468)
        Me.btnWordMatchStart.Name = "btnWordMatchStart"
        Me.btnWordMatchStart.Size = New System.Drawing.Size(451, 144)
        Me.btnWordMatchStart.TabIndex = 11
        Me.btnWordMatchStart.Text = "Start Word Blitz"
        Me.btnWordMatchStart.UseVisualStyleBackColor = True
        '
        'btnBacktoMain2
        '
        Me.btnBacktoMain2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBacktoMain2.Location = New System.Drawing.Point(951, 12)
        Me.btnBacktoMain2.Name = "btnBacktoMain2"
        Me.btnBacktoMain2.Size = New System.Drawing.Size(316, 100)
        Me.btnBacktoMain2.TabIndex = 16
        Me.btnBacktoMain2.Text = "Back To Main Menu"
        Me.btnBacktoMain2.UseVisualStyleBackColor = False
        '
        'HeaderText
        '
        Me.HeaderText.AutoSize = True
        Me.HeaderText.BackColor = System.Drawing.Color.Transparent
        Me.HeaderText.Font = New System.Drawing.Font("Segoe UI Symbol", 19.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderText.Location = New System.Drawing.Point(16, 23)
        Me.HeaderText.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.HeaderText.Name = "HeaderText"
        Me.HeaderText.Size = New System.Drawing.Size(594, 76)
        Me.HeaderText.TabIndex = 19
        Me.HeaderText.Text = "Word Blitz - Ready Up"
        '
        'WordBlitzReadyUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1276, 815)
        Me.Controls.Add(Me.HeaderText)
        Me.Controls.Add(Me.btnBacktoMain2)
        Me.Controls.Add(Me.gbxWord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WordBlitzReadyUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.gbxWord.ResumeLayout(False)
        Me.gbxWord.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxWord As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHardBest As System.Windows.Forms.Label
    Friend WithEvents lblMedBest As System.Windows.Forms.Label
    Friend WithEvents lblEasyBest As System.Windows.Forms.Label
    Friend WithEvents WordHardSet As System.Windows.Forms.RadioButton
    Friend WithEvents WordMedSet As System.Windows.Forms.RadioButton
    Friend WithEvents WordEasySet As System.Windows.Forms.RadioButton
    Friend WithEvents WordMatchDesc As System.Windows.Forms.Label
    Friend WithEvents btnWordMatchStart As System.Windows.Forms.Button
    Friend WithEvents btnBacktoMain2 As System.Windows.Forms.Button
    Friend WithEvents HeaderText As System.Windows.Forms.Label
End Class
