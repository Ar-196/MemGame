Public Class BackToMainConfirm

    Private Sub btnToMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToMain.Click
        'Shows the main menu screen
        My.Forms.MainMenu.Show()
        'If sound is on, plays the default button SFX, followed by the main menu soundtrack
        If My.Settings.SoundConfig = 0 Then
            My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.Training_Room_Menu, AudioPlayMode.BackgroundLoop)
        End If
        'Closes any open game forms, and then hides itself
        My.Forms.ImgMatchGame.Close()
        My.Forms.WordBlitzGame.Close()
        Me.Hide()
    End Sub

    Private Sub btnToPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToPause.Click
        'If sound is on, plays the default button SFX
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
        'Hides itself and shows the pause menu
        Me.Hide()
        My.Forms.PauseMenu.Show()
    End Sub
End Class