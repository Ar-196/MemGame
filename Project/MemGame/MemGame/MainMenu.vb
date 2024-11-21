Public Class MainMenu
    'Prevents flickering of elements while loading up the form
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Makes the header elements semi-transparent
        HeaderBox.BackColor = Color.FromArgb(125, Color.White)
        TitleText.BackColor = Color.FromArgb(125, Color.White)
        PictureBoxLogo.BackColor = Color.FromArgb(125, Color.White)
        'Uses the system setting AppBgImg to set a chosen background image for the form
        'Also changes the color of the important labels on the form to white if the background is not the default background
        Select Case My.Settings.AppBgImg
            Case 0
                Me.BackgroundImage = My.Resources.white_background
                lblDesc.ForeColor = Color.Black
            Case 1
                Me.BackgroundImage = My.Resources.Mountain_Peaks
                lblDesc.ForeColor = Color.White
            Case 2
                Me.BackgroundImage = My.Resources.Rocky_Sunset
                lblDesc.ForeColor = Color.White
            Case 3
                Me.BackgroundImage = My.Resources.smooth_turqoise_gradient
                lblDesc.ForeColor = Color.White
            Case 4
                Me.BackgroundImage = My.Resources.Sunset_Calm_Waters
                lblDesc.ForeColor = Color.White
        End Select
        Me.BackgroundImageLayout = ImageLayout.Stretch

        'If sound is on, plays the main menu soundtrack on a loop
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Training_Room_Menu, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        'If sound is on, plays the default button SFX
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
        'Shows the GameChoose window and hides itself if the user clicks Settings
        GameChoose.Show()
        Hide()
    End Sub

    Private Sub BtnStart_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.MouseEnter
        'This code changes the text displayed on the label lblDesc if the user's mouse enters the Play button
        lblDesc.Text = "Click on Play to view the games that are available."
        'Changes the button's image to the hovering version of the button
        BtnStart.BackgroundImage = My.Resources.PlayButtonHovering
        BtnStart.BackgroundImageLayout = ImageLayout.Stretch
        lblDesc.Visible = True
    End Sub

    Private Sub BtnStart_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.MouseLeave
        'This code refreshes the text on lblDesc to show a general statement if the user's mouse leaves the Play button
        lblDesc.Text = "Hover over a button for additional information."
        'Changes the button's image to the default version of the button
        BtnStart.BackgroundImage = My.Resources.PlayButtonResting
        BtnStart.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub BtnSettings_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSettings.MouseEnter
        'This code changes the text displayed on the label lblDesc if the user's mouse enters the Settings button
        lblDesc.Text = "Click on Settings to customise your game experience."
        lblDesc.Visible = True
        'Changes the button's image to the hovering version of the button
        BtnSettings.BackgroundImage = My.Resources.SettingButtonHover
        BtnSettings.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub BtnSettings_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSettings.MouseLeave
        'This code refreshes the text on lblDesc to show a general statement if the user's mouse leaves the Play button
        lblDesc.Text = "Hover over a button for additional information."
        'Changes the button's image to the default version of the button
        BtnSettings.BackgroundImage = My.Resources.SettingButtonResting
        BtnSettings.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub BtnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSettings.Click
        'If sound is on, plays the default button SFX
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
        'Shows the Settings window and hides itself if the user clicks Settings
        SettingsForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnExitGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitGame.Click
        'If sound is on, plays the special button SFX reserved for the exit and return to main menu buttons
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.PauseExitSFX, AudioPlayMode.Background)
        'Show the exit conformation and hides itself if the user clicks Exit
        ExitConfirm.Show()
        Me.Hide()
    End Sub
End Class