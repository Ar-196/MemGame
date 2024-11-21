<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameChoose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameChoose))
        Me.GameDescription = New System.Windows.Forms.Label()
        Me.btnBacktoMain2 = New System.Windows.Forms.Button()
        Me.HeaderText = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.BtnWordGame = New System.Windows.Forms.Button()
        Me.BtnImgMatch = New System.Windows.Forms.Button()
        Me.HeaderBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameDescription
        '
        Me.GameDescription.AutoSize = True
        Me.GameDescription.BackColor = System.Drawing.Color.Transparent
        Me.GameDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameDescription.Location = New System.Drawing.Point(83, 235)
        Me.GameDescription.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.GameDescription.Name = "GameDescription"
        Me.GameDescription.Size = New System.Drawing.Size(885, 48)
        Me.GameDescription.TabIndex = 0
        Me.GameDescription.Text = "Choose the game you want to play from below."
        '
        'btnBacktoMain2
        '
        Me.btnBacktoMain2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBacktoMain2.Location = New System.Drawing.Point(1401, 12)
        Me.btnBacktoMain2.Name = "btnBacktoMain2"
        Me.btnBacktoMain2.Size = New System.Drawing.Size(316, 100)
        Me.btnBacktoMain2.TabIndex = 3
        Me.btnBacktoMain2.Text = "Back To Main Menu"
        Me.btnBacktoMain2.UseVisualStyleBackColor = False
        '
        'HeaderText
        '
        Me.HeaderText.AutoSize = True
        Me.HeaderText.BackColor = System.Drawing.Color.Transparent
        Me.HeaderText.Font = New System.Drawing.Font("Segoe UI Symbol", 19.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderText.Location = New System.Drawing.Point(254, 45)
        Me.HeaderText.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.HeaderText.Name = "HeaderText"
        Me.HeaderText.Size = New System.Drawing.Size(383, 76)
        Me.HeaderText.TabIndex = 18
        Me.HeaderText.Text = "Choose Game"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(16, 1)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(7)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(224, 172)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 17
        Me.PictureBoxLogo.TabStop = False
        '
        'BtnWordGame
        '
        Me.BtnWordGame.BackgroundImage = Global.MemGame.My.Resources.Resources.wblitzRestingGradient
        Me.BtnWordGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnWordGame.Image = Global.MemGame.My.Resources.Resources.Picture3
        Me.BtnWordGame.Location = New System.Drawing.Point(914, 349)
        Me.BtnWordGame.Margin = New System.Windows.Forms.Padding(7)
        Me.BtnWordGame.Name = "BtnWordGame"
        Me.BtnWordGame.Size = New System.Drawing.Size(649, 374)
        Me.BtnWordGame.TabIndex = 2
        Me.BtnWordGame.UseVisualStyleBackColor = True
        '
        'BtnImgMatch
        '
        Me.BtnImgMatch.BackgroundImage = Global.MemGame.My.Resources.Resources.ImageMatchRestingGradient
        Me.BtnImgMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImgMatch.Image = Global.MemGame.My.Resources.Resources.Picture2
        Me.BtnImgMatch.Location = New System.Drawing.Point(147, 349)
        Me.BtnImgMatch.Margin = New System.Windows.Forms.Padding(7)
        Me.BtnImgMatch.Name = "BtnImgMatch"
        Me.BtnImgMatch.Size = New System.Drawing.Size(713, 374)
        Me.BtnImgMatch.TabIndex = 1
        Me.BtnImgMatch.UseVisualStyleBackColor = True
        '
        'HeaderBox
        '
        Me.HeaderBox.BackColor = System.Drawing.Color.SteelBlue
        Me.HeaderBox.Location = New System.Drawing.Point(0, 1)
        Me.HeaderBox.Name = "HeaderBox"
        Me.HeaderBox.Size = New System.Drawing.Size(1727, 172)
        Me.HeaderBox.TabIndex = 15
        Me.HeaderBox.TabStop = False
        '
        'GameChoose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1729, 805)
        Me.Controls.Add(Me.HeaderText)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.btnBacktoMain2)
        Me.Controls.Add(Me.BtnWordGame)
        Me.Controls.Add(Me.BtnImgMatch)
        Me.Controls.Add(Me.GameDescription)
        Me.Controls.Add(Me.HeaderBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "GameChoose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Game"
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GameDescription As System.Windows.Forms.Label
    Friend WithEvents BtnImgMatch As System.Windows.Forms.Button
    Friend WithEvents BtnWordGame As System.Windows.Forms.Button
    Friend WithEvents btnBacktoMain2 As System.Windows.Forms.Button
    Friend WithEvents HeaderBox As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents HeaderText As System.Windows.Forms.Label
End Class
