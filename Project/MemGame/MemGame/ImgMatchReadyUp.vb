Public Class ImgMatchReadyUp
    'Public Property ImgDiff As Integer = Nothing

    Private Sub ImgMatchReadyUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loads up the difficulty value stored in the system and checks the corresponding radiobuttons
        If My.Settings.ImgDiff = 0 Then
            ImgEasySet.Checked = True
        ElseIf My.Settings.ImgDiff = 1 Then
            ImgMedSet.Checked = True
        ElseIf My.Settings.ImgDiff = 2 Then
            ImgHardSet.Checked = True
        End If

        'Displays all the best times for the corresponding difficulties in the labels next to the radiobuttons
        'If the best time is 0, then it displayes 'No time recorded'
        If My.Settings.ImgEasyBest <> 0 Then
            lblEasyBest.Text = "Best Time: " + My.Settings.ImgEasyBest.ToString + " seconds"
        Else
            lblEasyBest.Text = "Best Time: No time recorded"
        End If

        If My.Settings.ImgMedBest <> 0 Then
            lblMedBest.Text = "Best Time: " + My.Settings.ImgMedBest.ToString + " seconds"
        Else
            lblMedBest.Text = "Best Time: No time recorded"
        End If

        If My.Settings.ImgHardBest <> 0 Then
            lblHardBest.Text = "Best Time: " + My.Settings.ImgHardBest.ToString + " seconds"
        Else
            lblHardBest.Text = "Best Time: No time recorded"
        End If

    End Sub

    'If ImgEasySet is checked, it changes the ImgDiff setting to 0
    Private Sub ImgEasySet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgEasySet.CheckedChanged
        If ImgEasySet.Checked = True Then
            My.Settings.ImgDiff = 0
        End If
    End Sub

    'If ImgMedSet is checked, it changes the ImgDiff setting to 1
    Private Sub ImgMedSet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgMedSet.CheckedChanged
        If ImgMedSet.Checked = True Then
            My.Settings.ImgDiff = 1
        End If
    End Sub

    'If ImgHardSet is checked, it changes the ImgDiff setting to 2
    Private Sub ImgHardSet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgHardSet.CheckedChanged
        If ImgHardSet.Checked = True Then
            My.Settings.ImgDiff = 2
        End If
    End Sub

    'Once the button is clicked, the form ImgMatchGame is opened and this form is closed
    Private Sub btnImgMatchStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImgMatchStart.Click
        'If sound is on, plays the default button SFX
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
        ImgMatchGame.Show()
        Me.Close()
    End Sub

    'Once this button is clicked, it opens up the main menu form and this form is closed
    Private Sub btnBacktoMain2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBacktoMain2.Click
        'If sound is on, plays the default button SFX, followed by the main menu soundtrack on a loop
        If My.Settings.SoundConfig = 0 Then
            My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
            My.Computer.Audio.Play(My.Resources.Training_Room_Menu, AudioPlayMode.BackgroundLoop)
        End If
        MainMenu.Show()
        Me.Close()
    End Sub
End Class