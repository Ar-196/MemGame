<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExitGame = New System.Windows.Forms.Button()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.HeaderBox = New System.Windows.Forms.PictureBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(96, 244)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(699, 90)
        Me.lblDesc.TabIndex = 5
        Me.lblDesc.Text = "Hello and welcome to Brain Games!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hover over a button for additional information" & _
            "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1518, 702)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 29)
        Me.Label2.TabIndex = 13
        '
        'btnExitGame
        '
        Me.btnExitGame.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExitGame.Location = New System.Drawing.Point(1388, 12)
        Me.btnExitGame.Name = "btnExitGame"
        Me.btnExitGame.Size = New System.Drawing.Size(201, 57)
        Me.btnExitGame.TabIndex = 17
        Me.btnExitGame.Text = "Exit"
        Me.btnExitGame.UseVisualStyleBackColor = False
        '
        'TitleText
        '
        Me.TitleText.AutoSize = True
        Me.TitleText.BackColor = System.Drawing.Color.Transparent
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI Symbol", 19.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(208, 45)
        Me.TitleText.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(348, 76)
        Me.TitleText.TabIndex = 15
        Me.TitleText.Text = "Brain Games"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(871, 876)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 29)
        Me.Label1.TabIndex = 18
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(16, 0)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(7)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(178, 172)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 16
        Me.PictureBoxLogo.TabStop = False
        '
        'HeaderBox
        '
        Me.HeaderBox.BackColor = System.Drawing.Color.SteelBlue
        Me.HeaderBox.Location = New System.Drawing.Point(1, 0)
        Me.HeaderBox.Name = "HeaderBox"
        Me.HeaderBox.Size = New System.Drawing.Size(1604, 172)
        Me.HeaderBox.TabIndex = 14
        Me.HeaderBox.TabStop = False
        '
        'BtnStart
        '
        Me.BtnStart.BackgroundImage = Global.MemGame.My.Resources.Resources.PlayButtonResting
        Me.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStart.Location = New System.Drawing.Point(96, 435)
        Me.BtnStart.Margin = New System.Windows.Forms.Padding(7)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(699, 362)
        Me.BtnStart.TabIndex = 2
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnSettings
        '
        Me.BtnSettings.BackgroundImage = Global.MemGame.My.Resources.Resources.SettingButtonResting
        Me.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSettings.Location = New System.Drawing.Point(814, 435)
        Me.BtnSettings.Margin = New System.Windows.Forms.Padding(7)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(699, 362)
        Me.BtnSettings.TabIndex = 1
        Me.BtnSettings.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1604, 914)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExitGame)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.TitleText)
        Me.Controls.Add(Me.HeaderBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.BtnSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brain Games"
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSettings As System.Windows.Forms.Button
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HeaderBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnExitGame As System.Windows.Forms.Button
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents TitleText As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
