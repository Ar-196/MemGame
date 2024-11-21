Public Class ImgMatchWin

    Private Sub ImgMatchWin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If sound is on, plays the win SFX
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.win_sfx, AudioPlayMode.Background)
        'Sets the form's background image to the win background
        Me.BackgroundImage = My.Resources.victorybg
        Me.BackgroundImageLayout = ImageLayout.Stretch
        'Imports all the required variables from the Word Blitz game form and displays them on their respective labels
        TimeDisplay.Text = My.Forms.ImgMatchGame.lblTimer.Text
        Dim TimeVar As Double = TimeDisplay.Text
        Dim BTimeDisplay As Double = My.Forms.ImgMatchGame.BestTimeDisplay
        If BTimeDisplay = 0 Then
            BestTimeDisplay.Text = "No time recorded yet"
        Else
            BestTimeDisplay.Text = My.Forms.ImgMatchGame.BestTimeDisplay
        End If
        'This code changes Label3 to display to the user whether or not they beat their previous highscore
        If TimeVar < BTimeDisplay Then
            Label3.Text = "which means that you have a new high score of " + TimeVar.ToString + "!"
        ElseIf BTimeDisplay = 0 Then
            Label3.Text = "which means that you have a new high score of " + TimeVar.ToString + "!"
        Else
            Label3.Text = "which means that you didn't beat your high score this time."
        End If
    End Sub

    Private Sub btnBackToMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToMain.Click
        'If sound is on, plays the default button SFX followed by the main menu soundtrack on a loop
        If My.Settings.SoundConfig = 0 Then
            My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
            If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Training_Room_Menu, AudioPlayMode.BackgroundLoop)
        End If
        'Closes the game and ready up forms, as well as itself before opening up the Main menu form
        MainMenu.Show()
        ImgMatchGame.Close()
        ImgMatchReadyUp.Close()
        Me.Close()
    End Sub
End Class