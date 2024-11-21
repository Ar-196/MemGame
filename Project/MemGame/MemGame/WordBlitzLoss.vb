Public Class WordBlitzLoss
    Private Sub btnBackToMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToMain.Click
        'If sound is on, plays the default button SFX, followed by the main menu soundtrack on a loop
        If My.Settings.SoundConfig = 0 Then
            My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
            If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Training_Room_Menu, AudioPlayMode.BackgroundLoop)
        End If
        'Closes the game and ready up forms, as well as itself before opening up the Main menu form
        Me.Close()
        WordBlitzGame.Close()
        WordBlitzReadyUp.Close()
        MainMenu.Show()
    End Sub

    Private Sub WordBlitzLoss_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If sound is on, plays the loss SFX
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.comical_loss_sfx, AudioPlayMode.Background)
        'Sets the form's background image to the loss background
        Me.BackgroundImage = My.Resources.lossbg
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class