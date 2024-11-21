Public Class SettingsForm

    Private Sub SettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loads previously selected user preferences or default configutation into the form's elements
        Select Case My.Settings.AppBgImg
            Case 0
                bgWhiteTriangle.Checked = True
            Case 1
                bgMountains.Checked = True
            Case 2
                BgRockySunset.Checked = True
            Case 3
                bgTurquoise.Checked = True
            Case 4
                bgCalmWatersSunset.Checked = True
        End Select

        Select Case My.Settings.SoundConfig
            Case 0
                PlayAll.Checked = True
            Case 1
                PlayNone.Checked = True
        End Select
    End Sub

    Private Sub btnBackToMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBacktoMain.Click
        'If sound is on, plays the default button SFX, followed by the main menu soundtrack on loop
        If My.Settings.SoundConfig = 0 Then
            My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.Training_Room_Menu, AudioPlayMode.BackgroundLoop)
        End If
        'Restarts application with newly chosen preferences
        Application.Restart()
    End Sub

    Private Sub PlayAll_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayAll.CheckedChanged
        'If this radio button is checked, changes SoundConfig to 0 (unmuted)
        If PlayAll.Checked = True Then
            My.Settings.SoundConfig = 0
        End If
    End Sub

    Private Sub PlayNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayNone.CheckedChanged
        'If this radio button is checked, changes SoundConfig to 1 (mute)
        If PlayNone.Checked = True Then
            My.Settings.SoundConfig = 1
        End If
    End Sub

    'The system setting AppBgImg is used to determine the background image for the main forms
    '(main menu, game choose form, and game forms)

    Private Sub bgWhiteTriangle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bgWhiteTriangle.CheckedChanged
        'If this radio button is checked, changes the system setting AppBgImg to 0
        If bgWhiteTriangle.Checked = True Then My.Settings.AppBgImg = 0
    End Sub

    Private Sub bgMountains_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bgMountains.CheckedChanged
        'If this radio button is checked, changes the system setting AppBgImg to 1
        If bgMountains.Checked = True Then My.Settings.AppBgImg = 1
    End Sub

    Private Sub BgRockySunset_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BgRockySunset.CheckedChanged
        'If this radio button is checked, changes the system setting AppBgImg to 2
        If BgRockySunset.Checked = True Then My.Settings.AppBgImg = 2
    End Sub

    Private Sub bgTurquoise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bgTurquoise.CheckedChanged
        'If this radio button is checked, changes the system setting AppBgImg to 3
        If bgTurquoise.Checked = True Then My.Settings.AppBgImg = 3
    End Sub

    Private Sub bgCalmWatersSunset_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bgCalmWatersSunset.CheckedChanged
        'If this radio button is checked, changes the system setting AppBgImg to 4
        If bgCalmWatersSunset.Checked = True Then My.Settings.AppBgImg = 4
    End Sub
End Class