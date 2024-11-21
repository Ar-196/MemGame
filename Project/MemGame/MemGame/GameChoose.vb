Public Class GameChoose
    'Prevents flickering of elements while loading up the form
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Uses the system setting AppBgImg to set a chosen background image for the form
        PictureBoxLogo.BackColor = Color.FromArgb(125, Color.White)
        HeaderBox.BackColor = Color.FromArgb(125, Color.White)
        HeaderText.BackColor = Color.FromArgb(125, Color.White)
        'Uses the system setting AppBgImg to set a chosen background image for the form
        'Also changes the color of the important labels on the form to white if the background is not the default background
        Select Case My.Settings.AppBgImg
            Case 0
                Me.BackgroundImage = My.Resources.white_background
                GameDescription.ForeColor = Color.Black
            Case 1
                Me.BackgroundImage = My.Resources.Mountain_Peaks
                GameDescription.ForeColor = Color.White
            Case 2
                Me.BackgroundImage = My.Resources.Rocky_Sunset
                GameDescription.ForeColor = Color.White
            Case 3
                Me.BackgroundImage = My.Resources.smooth_turqoise_gradient
                GameDescription.ForeColor = Color.White
            Case 4
                Me.BackgroundImage = My.Resources.Sunset_Calm_Waters
                GameDescription.ForeColor = Color.White
        End Select
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    'Once this button is clicked, it opens the main menu form and this form is closed
    Private Sub btnBacktoMain2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBacktoMain2.Click
        If My.Settings.SoundConfig = 0 Then
            My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.Training_Room_Menu, AudioPlayMode.BackgroundLoop)
        End If
        MainMenu.Show()
        Me.Hide()
    End Sub

    'Once this button is clicked, the Image Match ReadyUp form is opened and this form is closed
    Private Sub BtnImgMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImgMatch.Click
        'If sound is on, plays the default button SFX
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
        ImgMatchReadyUp.Show()
        Close()
    End Sub
    Private Sub BtnImgMatch_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImgMatch.MouseEnter
        'Changes the button's image to the hovering version of the button
        BtnImgMatch.BackgroundImage = My.Resources.ImageMatchHoveringGradient
        BtnImgMatch.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub BtnImgMatch_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImgMatch.MouseLeave
        'Changes the button's image to the default version of the button
        BtnImgMatch.BackgroundImage = My.Resources.ImageMatchRestingGradient
        BtnImgMatch.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    'Once this button is clicked, the Word Blitz ReadyUp form is opened and this form is closed
    Private Sub BtnWordBlitz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWordGame.Click
        'If sound is on, plays the default button SFX
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
        WordBlitzReadyUp.Show()
        Close()
    End Sub

    Private Sub BtnWordGame_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWordGame.MouseEnter
        'Changes the button's image to the hovering version of the button
        BtnWordGame.BackgroundImage = My.Resources.wblitzHoverGradient
        BtnWordGame.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub BtnWordGame_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWordGame.MouseLeave
        'Changes the button's image to the default version of the button
        BtnWordGame.BackgroundImage = My.Resources.wblitzRestingGradient
        BtnWordGame.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class