<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImgMatchGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImgMatchGame))
        Me.ImgGrid = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDiffDisplay = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalPairs = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.ImgTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.ImgTimeDelay = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblBestTime = New System.Windows.Forms.Label()
        Me.HeaderText = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.HeaderBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImgGrid
        '
        Me.ImgGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ImgGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgGrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.ImgGrid.ColumnCount = 6
        Me.ImgGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.Location = New System.Drawing.Point(109, 289)
        Me.ImgGrid.Name = "ImgGrid"
        Me.ImgGrid.RowCount = 6
        Me.ImgGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.ImgGrid.Size = New System.Drawing.Size(1005, 914)
        Me.ImgGrid.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1295, 919)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 94)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Difficulty"
        '
        'lblDiffDisplay
        '
        Me.lblDiffDisplay.AutoSize = True
        Me.lblDiffDisplay.BackColor = System.Drawing.Color.Transparent
        Me.lblDiffDisplay.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiffDisplay.Location = New System.Drawing.Point(1342, 1013)
        Me.lblDiffDisplay.Name = "lblDiffDisplay"
        Me.lblDiffDisplay.Size = New System.Drawing.Size(160, 65)
        Me.lblDiffDisplay.TabIndex = 7
        Me.lblDiffDisplay.Text = "xxxxxx"
        Me.lblDiffDisplay.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(868, 1034)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 29)
        Me.Label2.TabIndex = 8
        '
        'lblTotalPairs
        '
        Me.lblTotalPairs.AutoSize = True
        Me.lblTotalPairs.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPairs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPairs.Location = New System.Drawing.Point(1288, 751)
        Me.lblTotalPairs.Name = "lblTotalPairs"
        Me.lblTotalPairs.Size = New System.Drawing.Size(327, 48)
        Me.lblTotalPairs.TabIndex = 9
        Me.lblTotalPairs.Text = "of xx pairs revealed"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(1400, 634)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(87, 104)
        Me.lblScore.TabIndex = 10
        Me.lblScore.Text = "0"
        '
        'ImgTimer
        '
        Me.ImgTimer.Interval = 94
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(1360, 401)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(142, 72)
        Me.lblTimer.TabIndex = 11
        Me.lblTimer.Text = "xx.xx"
        '
        'ImgTimeDelay
        '
        Me.ImgTimeDelay.Interval = 300
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1296, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 65)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Time Taken"
        '
        'lblBestTime
        '
        Me.lblBestTime.AutoSize = True
        Me.lblBestTime.BackColor = System.Drawing.Color.Transparent
        Me.lblBestTime.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestTime.Location = New System.Drawing.Point(1257, 504)
        Me.lblBestTime.Name = "lblBestTime"
        Me.lblBestTime.Size = New System.Drawing.Size(395, 41)
        Me.lblBestTime.TabIndex = 13
        Me.lblBestTime.Text = "Best Time: No games played"
        Me.lblBestTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HeaderText
        '
        Me.HeaderText.AutoSize = True
        Me.HeaderText.BackColor = System.Drawing.Color.Transparent
        Me.HeaderText.Font = New System.Drawing.Font("Segoe UI Symbol", 19.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderText.Location = New System.Drawing.Point(275, 46)
        Me.HeaderText.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.HeaderText.Name = "HeaderText"
        Me.HeaderText.Size = New System.Drawing.Size(363, 76)
        Me.HeaderText.TabIndex = 19
        Me.HeaderText.Text = "Image Match"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(896, 1228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 29)
        Me.Label4.TabIndex = 21
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.BackgroundImage = Global.MemGame.My.Resources.Resources.ImageMatchRestingGradient
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Image = Global.MemGame.My.Resources.Resources.Picture2
        Me.PictureBoxLogo.Location = New System.Drawing.Point(0, 3)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(7)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(252, 172)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 20
        Me.PictureBoxLogo.TabStop = False
        '
        'btnPause
        '
        Me.btnPause.BackgroundImage = CType(resources.GetObject("btnPause.BackgroundImage"), System.Drawing.Image)
        Me.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPause.Location = New System.Drawing.Point(1675, 12)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(121, 110)
        Me.btnPause.TabIndex = 14
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'HeaderBox
        '
        Me.HeaderBox.BackColor = System.Drawing.Color.SteelBlue
        Me.HeaderBox.Location = New System.Drawing.Point(-26, 3)
        Me.HeaderBox.Name = "HeaderBox"
        Me.HeaderBox.Size = New System.Drawing.Size(1833, 172)
        Me.HeaderBox.TabIndex = 15
        Me.HeaderBox.TabStop = False
        '
        'ImgMatchGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1808, 1266)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.HeaderText)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.lblBestTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTotalPairs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDiffDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImgGrid)
        Me.Controls.Add(Me.HeaderBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImgMatchGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImgGrid As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDiffDisplay As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPairs As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents ImgTimer As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents ImgTimeDelay As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBestTime As System.Windows.Forms.Label
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents HeaderBox As System.Windows.Forms.PictureBox
    Friend WithEvents HeaderText As System.Windows.Forms.Label
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
