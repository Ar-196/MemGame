Public Class PauseMenu
    'This variable is used to identify which form the pause menu is opened from
    Public FormSender As Integer = 0
    Private Sub btnToMenuConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToMenuConfirm.Click
        'If sound is on, plays the special button SFX reserved for the exit and return to main menu buttons
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.PauseExitSFX, AudioPlayMode.Background)
        'Hides itself and shows the back to main menu confirmation screen
        Me.Hide()
        My.Forms.BackToMainConfirm.Show()
    End Sub

    Private Sub btnToGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToGame.Click
        'Hides itself
        Me.Hide()
        'Opens up the appropriate screens and modifies the appropriate settings, depening on which form opened it
        If FormSender = 0 Then
            My.Forms.ImgMatchGame.Pause = False
            My.Forms.ImgMatchGame.ImgTimer.Start()
        Else
            My.Forms.WordBlitzGame.WordTimer.Start()
            My.Forms.WordBlitzGame.Pause = False
            If My.Forms.WordBlitzGame.btnUse <> 0 Then
                For Each box In My.Forms.WordBlitzGame.TextBoxes
                    box.ReadOnly = False
                Next
            End If
        End If
        'If sound is on, plays the default button SFX, followed by the game soundtrack
        If My.Settings.SoundConfig = 0 Then
            My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
            If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Volcano, AudioPlayMode.BackgroundLoop)
        End If

    End Sub
End Class