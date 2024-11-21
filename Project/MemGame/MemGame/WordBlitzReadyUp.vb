Public Class WordBlitzReadyUp

    Private Sub WordBlitzReadyUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loads up the difficulty value stored in the system and checks the corresponding radiobuttons
        If My.Settings.WordDiff = 0 Then
            WordEasySet.Checked = True
        ElseIf My.Settings.WordDiff = 1 Then
            WordMedSet.Checked = True
        ElseIf My.Settings.WordDiff = 2 Then
            WordHardSet.Checked = True
        End If

        'Displays all the best times for the corresponding difficulties in the labels next to the radiobuttons
        'If the best time is 0, then it displayes 'No time recorded'
        If My.Settings.WordEasyBest <> 0 Then
            lblEasyBest.Text = "Best Time: " + My.Settings.WordEasyBest.ToString + " seconds"
        Else
            lblEasyBest.Text = "Best Time: No time recorded"
        End If

        If My.Settings.WordMedBest <> 0 Then
            lblMedBest.Text = "Best Time: " + My.Settings.WordMedBest.ToString + " seconds"
        Else
            lblMedBest.Text = "Best Time: No time recorded"
        End If

        If My.Settings.WordHardBest <> 0 Then
            lblHardBest.Text = "Best Time: " + My.Settings.WordHardBest.ToString + " seconds"
        Else
            lblHardBest.Text = "Best Time: No time recorded"
        End If
    End Sub
    'If WordEasySet is checked, it changes the WordDiff setting to 0
    Private Sub WordEasySet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordEasySet.CheckedChanged
        If WordEasySet.Checked = True Then
            My.Settings.WordDiff = 0
        End If
    End Sub
    'If WordMedSet is checked, it changes the WordDiff setting to 1
    Private Sub WordMedSet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordMedSet.CheckedChanged
        If WordMedSet.Checked = True Then
            My.Settings.WordDiff = 1
        End If
    End Sub
    'If WordHardSet is checked, it changes the WordDiff setting to 2
    Private Sub WordHardSet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordHardSet.CheckedChanged
        If WordHardSet.Checked = True Then
            My.Settings.WordDiff = 2
        End If
    End Sub

    'Once the button is clicked, the form WordBlitzGame is closed and this form is closed
    Private Sub btnWordMatchStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWordMatchStart.Click
        'If sound is on, plays the default button SFX
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
        WordBlitzGame.Show()
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