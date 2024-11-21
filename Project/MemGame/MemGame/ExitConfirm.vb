Public Class ExitConfirm

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Exits the game
        Application.Exit()
    End Sub

    Private Sub btnToMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToMain.Click
        'Shows the main menu and hides itself
        MainMenu.Show()
        Hide()
        'If sound is on, plays the default button SFX, followed by the main menu soundtrack
        If My.Settings.SoundConfig = 0 Then
            My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.Training_Room_Menu, AudioPlayMode.Background)
        End If
    End Sub
End Class