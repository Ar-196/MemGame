<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordBlitzGame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WordBlitzGame))
        Me.lblWordFlash = New System.Windows.Forms.Label()
        Me.btnWordSpawn = New System.Windows.Forms.Button()
        Me.lblWordReadyDesc = New System.Windows.Forms.Label()
        Me.lblDiffDisplay = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBestTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.TxtBoxLabelGrid = New System.Windows.Forms.TableLayoutPanel()
        Me.WordDisplayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WordTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TickCrossGrid = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderText = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.HeaderBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWordFlash
        '
        Me.lblWordFlash.AutoSize = True
        Me.lblWordFlash.BackColor = System.Drawing.Color.Transparent
        Me.lblWordFlash.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWordFlash.Location = New System.Drawing.Point(813, 699)
        Me.lblWordFlash.Name = "lblWordFlash"
        Me.lblWordFlash.Size = New System.Drawing.Size(222, 81)
        Me.lblWordFlash.TabIndex = 16
        Me.lblWordFlash.Text = "Ready?"
        Me.lblWordFlash.Visible = False
        '
        'btnWordSpawn
        '
        Me.btnWordSpawn.BackColor = System.Drawing.Color.Transparent
        Me.btnWordSpawn.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnWordSpawn.Location = New System.Drawing.Point(541, 388)
        Me.btnWordSpawn.Name = "btnWordSpawn"
        Me.btnWordSpawn.Size = New System.Drawing.Size(713, 127)
        Me.btnWordSpawn.TabIndex = 17
        Me.btnWordSpawn.Text = "Show Words"
        Me.btnWordSpawn.UseVisualStyleBackColor = False
        '
        'lblWordReadyDesc
        '
        Me.lblWordReadyDesc.AutoSize = True
        Me.lblWordReadyDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblWordReadyDesc.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblWordReadyDesc.Location = New System.Drawing.Point(138, 256)
        Me.lblWordReadyDesc.Name = "lblWordReadyDesc"
        Me.lblWordReadyDesc.Size = New System.Drawing.Size(1240, 114)
        Me.lblWordReadyDesc.TabIndex = 18
        Me.lblWordReadyDesc.Text = "Welcome to Word Blitz! To display the words and start the game, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "press the butto" & _
            "n below."
        '
        'lblDiffDisplay
        '
        Me.lblDiffDisplay.AutoSize = True
        Me.lblDiffDisplay.BackColor = System.Drawing.Color.Transparent
        Me.lblDiffDisplay.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiffDisplay.Location = New System.Drawing.Point(1427, 1005)
        Me.lblDiffDisplay.Name = "lblDiffDisplay"
        Me.lblDiffDisplay.Size = New System.Drawing.Size(218, 88)
        Me.lblDiffDisplay.TabIndex = 20
        Me.lblDiffDisplay.Text = "xxxxxx"
        Me.lblDiffDisplay.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1386, 914)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 91)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Difficulty"
        '
        'lblBestTime
        '
        Me.lblBestTime.AutoSize = True
        Me.lblBestTime.BackColor = System.Drawing.Color.Transparent
        Me.lblBestTime.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBestTime.Location = New System.Drawing.Point(1344, 742)
        Me.lblBestTime.Name = "lblBestTime"
        Me.lblBestTime.Size = New System.Drawing.Size(395, 41)
        Me.lblBestTime.TabIndex = 23
        Me.lblBestTime.Text = "Best Time: No games played"
        Me.lblBestTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBestTime.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(1390, 596)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 65)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Time Taken"
        Me.Label3.Visible = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.lblTimer.Location = New System.Drawing.Point(1459, 661)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(130, 72)
        Me.lblTimer.TabIndex = 21
        Me.lblTimer.Text = "--.--"
        Me.lblTimer.Visible = False
        '
        'TxtBoxLabelGrid
        '
        Me.TxtBoxLabelGrid.BackColor = System.Drawing.Color.Transparent
        Me.TxtBoxLabelGrid.ColumnCount = 1
        Me.TxtBoxLabelGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TxtBoxLabelGrid.Location = New System.Drawing.Point(529, 579)
        Me.TxtBoxLabelGrid.Name = "TxtBoxLabelGrid"
        Me.TxtBoxLabelGrid.RowCount = 7
        Me.TxtBoxLabelGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TxtBoxLabelGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TxtBoxLabelGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TxtBoxLabelGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TxtBoxLabelGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TxtBoxLabelGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TxtBoxLabelGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TxtBoxLabelGrid.Size = New System.Drawing.Size(606, 639)
        Me.TxtBoxLabelGrid.TabIndex = 24
        Me.TxtBoxLabelGrid.Visible = False
        '
        'WordDisplayTimer
        '
        Me.WordDisplayTimer.Interval = 350
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(879, 1206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 29)
        Me.Label2.TabIndex = 25
        '
        'WordTimer
        '
        Me.WordTimer.Interval = 94
        '
        'TickCrossGrid
        '
        Me.TickCrossGrid.BackColor = System.Drawing.Color.Transparent
        Me.TickCrossGrid.ColumnCount = 1
        Me.TickCrossGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TickCrossGrid.Location = New System.Drawing.Point(1115, 579)
        Me.TickCrossGrid.Name = "TickCrossGrid"
        Me.TickCrossGrid.RowCount = 7
        Me.TickCrossGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TickCrossGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TickCrossGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TickCrossGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TickCrossGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TickCrossGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TickCrossGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TickCrossGrid.Size = New System.Drawing.Size(138, 639)
        Me.TickCrossGrid.TabIndex = 26
        Me.TickCrossGrid.Visible = False
        '
        'HeaderText
        '
        Me.HeaderText.AutoSize = True
        Me.HeaderText.BackColor = System.Drawing.Color.Transparent
        Me.HeaderText.Font = New System.Drawing.Font("Segoe UI Symbol", 19.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderText.Location = New System.Drawing.Point(321, 46)
        Me.HeaderText.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.HeaderText.Name = "HeaderText"
        Me.HeaderText.Size = New System.Drawing.Size(295, 76)
        Me.HeaderText.TabIndex = 29
        Me.HeaderText.Text = "Word Blitz"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.BackgroundImage = Global.MemGame.My.Resources.Resources.wblitzRestingGradient
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Image = Global.MemGame.My.Resources.Resources.Picture3
        Me.PictureBoxLogo.Location = New System.Drawing.Point(-1, -6)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(7)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(279, 172)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 30
        Me.PictureBoxLogo.TabStop = False
        '
        'btnPause
        '
        Me.btnPause.BackgroundImage = CType(resources.GetObject("btnPause.BackgroundImage"), System.Drawing.Image)
        Me.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPause.Location = New System.Drawing.Point(1685, 12)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(121, 110)
        Me.btnPause.TabIndex = 15
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'HeaderBox
        '
        Me.HeaderBox.BackColor = System.Drawing.Color.SteelBlue
        Me.HeaderBox.Location = New System.Drawing.Point(-52, -6)
        Me.HeaderBox.Name = "HeaderBox"
        Me.HeaderBox.Size = New System.Drawing.Size(1871, 172)
        Me.HeaderBox.TabIndex = 28
        Me.HeaderBox.TabStop = False
        '
        'WordBlitzGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1818, 1354)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.HeaderText)
        Me.Controls.Add(Me.TickCrossGrid)
        Me.Controls.Add(Me.lblWordFlash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBoxLabelGrid)
        Me.Controls.Add(Me.lblBestTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblDiffDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWordReadyDesc)
        Me.Controls.Add(Me.btnWordSpawn)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.HeaderBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WordBlitzGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tes"
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents lblWordFlash As System.Windows.Forms.Label
    Friend WithEvents btnWordSpawn As System.Windows.Forms.Button
    Friend WithEvents lblWordReadyDesc As System.Windows.Forms.Label
    Friend WithEvents lblDiffDisplay As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBestTime As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents TxtBoxLabelGrid As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents WordDisplayTimer As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WordTimer As System.Windows.Forms.Timer
    Friend WithEvents TickCrossGrid As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents HeaderText As System.Windows.Forms.Label
    Friend WithEvents HeaderBox As System.Windows.Forms.PictureBox
End Class
