<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.btnBacktoMain = New System.Windows.Forms.Button()
        Me.gbxSettings = New System.Windows.Forms.GroupBox()
        Me.gbxBackground = New System.Windows.Forms.GroupBox()
        Me.bgWhiteTriangle = New System.Windows.Forms.RadioButton()
        Me.bgCalmWatersSunset = New System.Windows.Forms.RadioButton()
        Me.bgTurquoise = New System.Windows.Forms.RadioButton()
        Me.BgRockySunset = New System.Windows.Forms.RadioButton()
        Me.bgMountains = New System.Windows.Forms.RadioButton()
        Me.gbxSound = New System.Windows.Forms.GroupBox()
        Me.PlayNone = New System.Windows.Forms.RadioButton()
        Me.PlayAll = New System.Windows.Forms.RadioButton()
        Me.gbxSettings.SuspendLayout()
        Me.gbxBackground.SuspendLayout()
        Me.gbxSound.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBacktoMain
        '
        Me.btnBacktoMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBacktoMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBacktoMain.Location = New System.Drawing.Point(751, 2)
        Me.btnBacktoMain.Name = "btnBacktoMain"
        Me.btnBacktoMain.Size = New System.Drawing.Size(263, 94)
        Me.btnBacktoMain.TabIndex = 0
        Me.btnBacktoMain.Text = "Save and Restart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnBacktoMain.UseVisualStyleBackColor = False
        '
        'gbxSettings
        '
        Me.gbxSettings.Controls.Add(Me.gbxBackground)
        Me.gbxSettings.Controls.Add(Me.gbxSound)
        Me.gbxSettings.Controls.Add(Me.btnBacktoMain)
        Me.gbxSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.gbxSettings.Location = New System.Drawing.Point(13, 35)
        Me.gbxSettings.Name = "gbxSettings"
        Me.gbxSettings.Size = New System.Drawing.Size(1020, 790)
        Me.gbxSettings.TabIndex = 8
        Me.gbxSettings.TabStop = False
        Me.gbxSettings.Text = "Settings"
        '
        'gbxBackground
        '
        Me.gbxBackground.Controls.Add(Me.bgWhiteTriangle)
        Me.gbxBackground.Controls.Add(Me.bgCalmWatersSunset)
        Me.gbxBackground.Controls.Add(Me.bgTurquoise)
        Me.gbxBackground.Controls.Add(Me.BgRockySunset)
        Me.gbxBackground.Controls.Add(Me.bgMountains)
        Me.gbxBackground.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.gbxBackground.Location = New System.Drawing.Point(5, 289)
        Me.gbxBackground.Name = "gbxBackground"
        Me.gbxBackground.Size = New System.Drawing.Size(1009, 275)
        Me.gbxBackground.TabIndex = 9
        Me.gbxBackground.TabStop = False
        Me.gbxBackground.Text = "Background Modifiers"
        '
        'bgWhiteTriangle
        '
        Me.bgWhiteTriangle.AutoSize = True
        Me.bgWhiteTriangle.Location = New System.Drawing.Point(33, 47)
        Me.bgWhiteTriangle.Name = "bgWhiteTriangle"
        Me.bgWhiteTriangle.Size = New System.Drawing.Size(433, 33)
        Me.bgWhiteTriangle.TabIndex = 11
        Me.bgWhiteTriangle.TabStop = True
        Me.bgWhiteTriangle.Text = "White Triangle Background (Default)"
        Me.bgWhiteTriangle.UseVisualStyleBackColor = True
        '
        'bgCalmWatersSunset
        '
        Me.bgCalmWatersSunset.AutoSize = True
        Me.bgCalmWatersSunset.Location = New System.Drawing.Point(33, 203)
        Me.bgCalmWatersSunset.Name = "bgCalmWatersSunset"
        Me.bgCalmWatersSunset.Size = New System.Drawing.Size(319, 33)
        Me.bgCalmWatersSunset.TabIndex = 10
        Me.bgCalmWatersSunset.TabStop = True
        Me.bgCalmWatersSunset.Text = "Sunset Over Calm Waters"
        Me.bgCalmWatersSunset.UseVisualStyleBackColor = True
        '
        'bgTurquoise
        '
        Me.bgTurquoise.AutoSize = True
        Me.bgTurquoise.Location = New System.Drawing.Point(32, 164)
        Me.bgTurquoise.Name = "bgTurquoise"
        Me.bgTurquoise.Size = New System.Drawing.Size(252, 33)
        Me.bgTurquoise.TabIndex = 9
        Me.bgTurquoise.TabStop = True
        Me.bgTurquoise.Text = "Turquoise Gradient"
        Me.bgTurquoise.UseVisualStyleBackColor = True
        '
        'BgRockySunset
        '
        Me.BgRockySunset.AutoSize = True
        Me.BgRockySunset.Location = New System.Drawing.Point(32, 125)
        Me.BgRockySunset.Name = "BgRockySunset"
        Me.BgRockySunset.Size = New System.Drawing.Size(190, 33)
        Me.BgRockySunset.TabIndex = 8
        Me.BgRockySunset.TabStop = True
        Me.BgRockySunset.Text = "Rocky Sunset"
        Me.BgRockySunset.UseVisualStyleBackColor = True
        '
        'bgMountains
        '
        Me.bgMountains.AutoSize = True
        Me.bgMountains.Location = New System.Drawing.Point(32, 86)
        Me.bgMountains.Name = "bgMountains"
        Me.bgMountains.Size = New System.Drawing.Size(215, 33)
        Me.bgMountains.TabIndex = 6
        Me.bgMountains.TabStop = True
        Me.bgMountains.Text = "Mountain Peaks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bgMountains.UseVisualStyleBackColor = True
        '
        'gbxSound
        '
        Me.gbxSound.Controls.Add(Me.PlayNone)
        Me.gbxSound.Controls.Add(Me.PlayAll)
        Me.gbxSound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.gbxSound.Location = New System.Drawing.Point(6, 102)
        Me.gbxSound.Name = "gbxSound"
        Me.gbxSound.Size = New System.Drawing.Size(1008, 181)
        Me.gbxSound.TabIndex = 8
        Me.gbxSound.TabStop = False
        Me.gbxSound.Text = "Sound Options"
        '
        'PlayNone
        '
        Me.PlayNone.AutoSize = True
        Me.PlayNone.Location = New System.Drawing.Point(31, 96)
        Me.PlayNone.Name = "PlayNone"
        Me.PlayNone.Size = New System.Drawing.Size(200, 33)
        Me.PlayNone.TabIndex = 8
        Me.PlayNone.TabStop = True
        Me.PlayNone.Text = "Mute all sound"
        Me.PlayNone.UseVisualStyleBackColor = True
        '
        'PlayAll
        '
        Me.PlayAll.AutoSize = True
        Me.PlayAll.Location = New System.Drawing.Point(31, 57)
        Me.PlayAll.Name = "PlayAll"
        Me.PlayAll.Size = New System.Drawing.Size(460, 33)
        Me.PlayAll.TabIndex = 6
        Me.PlayAll.TabStop = True
        Me.PlayAll.Text = "Play background music + SFX (default)"
        Me.PlayAll.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1045, 837)
        Me.Controls.Add(Me.gbxSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "B"
        Me.gbxSettings.ResumeLayout(False)
        Me.gbxBackground.ResumeLayout(False)
        Me.gbxBackground.PerformLayout()
        Me.gbxSound.ResumeLayout(False)
        Me.gbxSound.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBacktoMain As System.Windows.Forms.Button
    Friend WithEvents gbxSettings As System.Windows.Forms.GroupBox
    Friend WithEvents gbxBackground As System.Windows.Forms.GroupBox
    Friend WithEvents bgWhiteTriangle As System.Windows.Forms.RadioButton
    Friend WithEvents bgCalmWatersSunset As System.Windows.Forms.RadioButton
    Friend WithEvents bgTurquoise As System.Windows.Forms.RadioButton
    Friend WithEvents BgRockySunset As System.Windows.Forms.RadioButton
    Friend WithEvents bgMountains As System.Windows.Forms.RadioButton
    Friend WithEvents gbxSound As System.Windows.Forms.GroupBox
    Friend WithEvents PlayNone As System.Windows.Forms.RadioButton
    Friend WithEvents PlayAll As System.Windows.Forms.RadioButton
End Class
