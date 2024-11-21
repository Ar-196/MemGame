Public Class WordBlitzGame
    'This variable is used to store the number of words that need to be loaded and used
    Private WordCount As Integer = 0
    'This variable is used to store the relevant best time (for easy reference)
    Public BestTimeDisplay As Double = 0
    'This variable is just a general global counter to be used mainly in for loops
    Private counter As Integer = 0
    'This array is used to store the words that are actually to be used in the game
    Private wordUse(0) As String
    'This array simply stores all the words.
    Private wordBank(0) As String
    'This variable is used to record whether the button has been clicke before or not
    Public btnUse As Integer = 0
    'This array is used to store and refer to data about the textboxes that will be spawned later in the game
    Public TextBoxes(0) As TextBox
    'This array is used to store all the user's inputs
    Private UserInputs(0) As String
    'This variable is used by the game to identify when the game is paused, and when the pause menu is open
    Public Pause As Boolean = False
    'The next three elements are elements that are used for time keeping and recording purposes
    Private time_ms As Integer = 0
    Private time_s As Integer = 0
    Private timeTaken As Double = 0
    'This array will be used to record which words the user got right and which words they got wrong
    Private Results(0) As String

    'Prevents flickering of elements while loading up the form
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Public Sub WordBlitzGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If sound is on, plays the game soundtrack on a loop
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Volcano, AudioPlayMode.BackgroundLoop)
        'Makes the header elements semi-transparent
        PictureBoxLogo.BackColor = Color.FromArgb(125, Color.White)
        HeaderBox.BackColor = Color.FromArgb(125, Color.White)
        HeaderText.BackColor = Color.FromArgb(125, Color.White)
        'Uses the system setting AppBgImg to set a chosen background image for the form
        'Also changes the color of the important labels on the form to white if the background is not the default background
        Select Case My.Settings.AppBgImg
            Case 0
                Me.BackgroundImage = My.Resources.white_background
                lblTimer.ForeColor = Color.Black
                lblBestTime.ForeColor = Color.Black
                lblWordReadyDesc.ForeColor = Color.Black
                lblDiffDisplay.ForeColor = Color.Black
                Label1.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
                lblWordFlash.ForeColor = Color.Black
            Case 1
                Me.BackgroundImage = My.Resources.Mountain_Peaks
                lblTimer.ForeColor = Color.White
                lblBestTime.ForeColor = Color.White
                lblWordReadyDesc.ForeColor = Color.White
                lblDiffDisplay.ForeColor = Color.White
                Label1.ForeColor = Color.White
                Label3.ForeColor = Color.White
                lblWordFlash.ForeColor = Color.White
            Case 2
                Me.BackgroundImage = My.Resources.Rocky_Sunset
                lblTimer.ForeColor = Color.White
                lblBestTime.ForeColor = Color.White
                lblWordReadyDesc.ForeColor = Color.White
                lblDiffDisplay.ForeColor = Color.White
                Label1.ForeColor = Color.White
                Label3.ForeColor = Color.White
                lblWordFlash.ForeColor = Color.White
            Case 3
                Me.BackgroundImage = My.Resources.smooth_turqoise_gradient
                lblTimer.ForeColor = Color.White
                lblBestTime.ForeColor = Color.White
                lblWordReadyDesc.ForeColor = Color.White
                lblDiffDisplay.ForeColor = Color.White
                Label1.ForeColor = Color.White
                Label3.ForeColor = Color.White
                lblWordFlash.ForeColor = Color.White
            Case 4
                Me.BackgroundImage = My.Resources.Sunset_Calm_Waters
                lblTimer.ForeColor = Color.White
                lblBestTime.ForeColor = Color.White
                lblWordReadyDesc.ForeColor = Color.White
                lblDiffDisplay.ForeColor = Color.White
                Label1.ForeColor = Color.White
                Label3.ForeColor = Color.White
                lblWordFlash.ForeColor = Color.White
        End Select
        Me.BackgroundImageLayout = ImageLayout.Stretch

        'Changes the number of words to be loaded, and also changes lblDiffDisplay to display the chosen difficulty
        'Also stores the best time for the chosen difficulty in BestTimeDisplay (for easy reference.)
        Select Case My.Settings.WordDiff
            Case 0
                WordCount = 5
                lblDiffDisplay.Text = "Easy"
                BestTimeDisplay = My.Settings.WordEasyBest
            Case 1
                WordCount = 6
                lblDiffDisplay.Text = "Medium"
                BestTimeDisplay = My.Settings.WordMedBest
            Case 2
                WordCount = 7
                lblDiffDisplay.Text = "Hard"
                BestTimeDisplay = My.Settings.WordHardBest
        End Select
        'Creates an array with all the words
        ReDim wordBank(79)
        wordBank(0) = "adequate"
        wordBank(1) = "attention"
        wordBank(2) = "curious"
        wordBank(3) = "easily"
        wordBank(4) = "everything"
        wordBank(5) = "day"
        wordBank(6) = "thing"
        wordBank(7) = "man"
        wordBank(8) = "world"
        wordBank(9) = "life"
        wordBank(10) = "hand"
        wordBank(11) = "part"
        wordBank(12) = "child"
        wordBank(13) = "eye"
        wordBank(14) = "woman"
        wordBank(15) = "place"
        wordBank(16) = "work"
        wordBank(17) = "week"
        wordBank(18) = "ordinary"
        wordBank(19) = "government"
        wordBank(20) = "company"
        wordBank(21) = "number"
        wordBank(22) = "group"
        wordBank(23) = "problem"
        wordBank(24) = "fact"
        wordBank(25) = "new"
        wordBank(26) = "first"
        wordBank(27) = "last"
        wordBank(28) = "long"
        wordBank(29) = "great"
        wordBank(30) = "little"
        wordBank(31) = "own"
        wordBank(32) = "other"
        wordBank(33) = "old"
        wordBank(34) = "right"
        wordBank(35) = "big"
        wordBank(36) = "high"
        wordBank(37) = "different"
        wordBank(38) = "small"
        wordBank(39) = "large"
        wordBank(40) = "next"
        wordBank(41) = "early"
        wordBank(42) = "young"
        wordBank(43) = "important"
        wordBank(44) = "few"
        wordBank(45) = "public"
        wordBank(46) = "bad"
        wordBank(47) = "same"
        wordBank(48) = "able"
        wordBank(49) = "be"
        wordBank(50) = "have"
        wordBank(51) = "do"
        wordBank(52) = "say"
        wordBank(53) = "get"
        wordBank(54) = "make"
        wordBank(55) = "go"
        wordBank(56) = "look"
        wordBank(57) = "take"
        wordBank(58) = "see"
        wordBank(59) = "come"
        wordBank(60) = "think"
        wordBank(61) = "know"
        wordBank(62) = "want"
        wordBank(63) = "give"
        wordBank(64) = "use"
        wordBank(65) = "find"
        wordBank(66) = "tell"
        wordBank(67) = "ask"
        wordBank(68) = "work"
        wordBank(69) = "seem"
        wordBank(70) = "feel"
        wordBank(71) = "try"
        wordBank(72) = "leave"
        wordBank(73) = "call"
        wordBank(74) = "ponder"
        wordBank(75) = "stuff"
        wordBank(76) = "antique"
        wordBank(77) = "energy"
        wordBank(78) = "demand"
        wordBank(79) = "lantern"
        'Initialises the randomising function with wordBank() to jumble up the order of the elements in the array
        RandomizeArray(wordBank)

        'Clause to change the text displayed by lblBestTime to no games played yet if the best time is 0
        'as a best score of 0 indicates that the user has not gotten a best time on this difficulty
        If BestTimeDisplay <> 0 Then
            lblBestTime.Text = "Best time: " + BestTimeDisplay.ToString
        Else
            lblBestTime.Text = "Best time: No games played yet"
        End If
    End Sub

    Private Sub btnWordSpawn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWordSpawn.Click
        'Makes button unresponsive if the pause variable is set to true 
        If Pause = True Then Exit Sub
        'Creates a new variable with a Random() function attributed to it
        Dim random As Random = New Random()
        'Creates another variable, and then executes the 'random' function declared above with the required inputs
        'The output is a random integer with minimum value 10 and maximum value being the length of wordBank() - 20
        'This output is attributed to FileStartNumber
        Dim FileStartNumber As Integer = random.Next(10, wordBank.Length - 20)

        'If the button has not been clicked before, the statements within the if branch are executed
        'If it has been clicked before, then it executes the statements within the else branch
        If btnUse = 0 Then
            'Redefines the length of wordUse to be the length of WordCount, as the game only needs those many words
            ReDim wordUse(WordCount - 1)

            'The for loop uses filestartnumber as an array index, and loops through wordUse() and 
            'sequentially takes the required number of elements from a random point in wordBank()
            'and puts them in wordUse()
            For i As Integer = 0 To WordCount - 1
                FileStartNumber += 1
                wordUse(i) = wordBank(FileStartNumber)
            Next

            'Starts the timer that is responsible for flashing the words on the screen
            WordDisplayTimer.Start()
            'Makes the label with the flashing words visible
            lblWordFlash.Visible = True
            'Increments btnUse so that the next time it is clicked, it executes everything in the else branch
            'It records that the button has been clicked once
            btnUse = 1
            'Exits sub so that the display timer is the only sub being executed
            Exit Sub
        Else
            'Group of statements to be executed if this button has already been clicked once
            'Ideally , the textboxes have already been spawned and user has entered their inputs in each of them
            'and they clicked this button to confirm their inputs

            ''Redefines the length of UserInputs() and Result() to the correct length
            ReDim UserInputs(WordCount - 1)
            ReDim Results(WordCount - 1)
            'Stops the timer
            WordTimer.Stop()
            'Resets the counter
            counter = 0
            'Loops through the textboxes and takes the text in each textbox and stores it into UserInputs (for easy reference)
            'Stores it in lowercase to make the comparision process case insensitive
            For Each box As TextBox In TextBoxes
                If counter = WordCount Then Exit For
                UserInputs(counter) = box.Text.ToLower
                counter += 1
            Next
            'Resets the counter
            counter = 0
            'Loops through the collected user inputs in UserInputs() and compares them with the words that were loaded into wordUse()
            'Then it records whether the user got each word rong or right in Results()
            For Each Input As String In UserInputs
                If Input = wordUse(counter) Then
                    Results(counter) = "right"
                Else
                    Results(counter) = "wrong"
                End If
                counter += 1
            Next
            'Resets the counter
            counter = 0
            'Clears all the textboxes in the main table as they are no longer required
            TxtBoxLabelGrid.Controls.Clear()
            'This loop loops through the table and creates labels with specified attributes for each cell
            For row As Integer = 0 To WordCount - 1
                Dim label As New Label
                label.BackColor = Color.Transparent
                'Each label then displays an element from wordUse(), so that the labels display the correct answers to the game
                label.Text = wordUse(row)
                label.TextAlign = ContentAlignment.MiddleCenter
                label.Font = New Font("Arial", 18)
                label.AutoSize = True
                'Also makes the label's text white if the background image is not the default image
                If My.Settings.AppBgImg <> 0 Then label.ForeColor = Color.White
                TxtBoxLabelGrid.Controls.Add(label, 0, row)
            Next
            'Makes the smaller table visible
            TickCrossGrid.Visible = True
            'Resizes the table to the correct length
            TickCrossGrid.RowCount = WordCount
            'Loops through the smaller table and creates the picturebox displaying a tick or cross next to the created labels to show the users which words they got right or wrong.
            For row As Integer = 0 To WordCount - 1
                Dim box As New PictureBox
                box.Visible = True
                'Refers to Results() to check if user got the answer right. 
                'If they did, picturebox displays a tick
                'If they got it wrong, it displays a cross
                If Results(row) = "right" Then
                    box.BackgroundImage = My.Resources.tick
                Else
                    box.BackgroundImage = My.Resources.cross
                End If
                box.BackgroundImageLayout = ImageLayout.Stretch
                TickCrossGrid.Controls.Add(box, 0, row)
            Next
            TickCrossGrid.Visible = True
            'For loop that loops through Results() to determine if user wins or not
            'If the user got the word wrong, then the loop executes BlitzLoss() and exits the sub
            'If the user got the word right, it continues onto the next iteration
            For i As Integer = 0 To WordCount - 1
                If Results(i) = "wrong" Then
                    BlitzLoss()
                    Exit Sub
                ElseIf Results(i) = "right" Then
                    Continue For
                End If
            Next
            'If the loop is completed without any interruptions, that means the user got all the words right
            'Program then executes BlitzWin()
            BlitzWin()
        End If
    End Sub

    Private Sub WordDisplayTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordDisplayTimer.Tick
        'If clause to stop the display timer from running and executing statements if it has already shown all the words from wordUse()
        If counter = WordCount Then
            lblWordFlash.Visible = False
            WordDisplayTimer.Stop()
            counter = 0
            'Executes the sub responsible for spawning in textboxes for user input
            SpawnTextBox()
            'Starts the actual timer
            WordTimer.Start()
            'Shows the Timer and best time components on screen
            lblBestTime.Visible = True
            lblTimer.Visible = True
            Label3.Visible = True
        End If
        'Displays the word on the label lblWordFlash
        lblWordFlash.Text = wordUse(counter)
        'increments the counter used as the index for referring to wordUse()
        counter += 1
    End Sub

    Private Sub SpawnTextBox()
        'Makes the main table visible
        TxtBoxLabelGrid.Visible = True
        'Redefines the length of TextBoxes to the correct length
        ReDim TextBoxes(WordCount - 1)
        'Modifies the table to have the same number of rows as the number of words that need to be loaded and used
        TxtBoxLabelGrid.RowCount = WordCount
        'Changes the text displayed by the label above the button
        lblWordReadyDesc.Text = "To check your answers and finish the game, click the button below"
        'This loop loops through the table and creates a textbox with specified attributes for each cell
        For row As Integer = 0 To WordCount - 1
            Dim box As New TextBox
            box.Width = 570
            box.Font = New Font("Arial", 20)
            box.Name = row.ToString
            box.TextAlign = HorizontalAlignment.Center
            TxtBoxLabelGrid.Controls.Add(box, 0, row)
            'Adds a click handler for the box, but this will only be useful when the game is paused
            AddHandler box.Click, AddressOf textClickwhilePause
            'Stores the data of each boxes into the Textboxes() array
            TextBoxes(row) = box
        Next
        'Changes the text on the button to 'check answers'
        btnWordSpawn.Text = "Check Answers"
    End Sub

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        'If sound is on, plays the general button SFX
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
        'Upon clicking the pause button, it shows the pause menu and stops the timer
        PauseMenu.Show()
        WordTimer.Stop()
        'Also sets the pause variable to 'true', indicating that the game is now paused
        Pause = True
        'If the textboxes have already been spawned, then they are now uneditable
        If btnUse <> 0 Then
            For Each box In TextBoxes
                box.ReadOnly = True
            Next
            'Sets the Formsender attribute to identify that this form is the sender
            PauseMenu.FormSender = 1
        End If
    End Sub

    'Previously created click handler for spawned textboxes
    Private Sub textClickwhilePause(ByVal sender As Object, ByVal e As EventArgs)
        'If the user clicks the textbox while the game is 'paused', it tells the user to unpause the game to manipulate objects
        'And then refreshes the PauseMenu screen to bring it to the front
        If Pause = True Then
            MessageBox.Show("Please resume the game to manipulate objects")
            PauseMenu.Close()
            PauseMenu.Show()
            Exit Sub
        End If
        Exit Sub
    End Sub
    'Custom function that is responsible for jumbling up the order of elements in wordBank()
    Private Sub RandomizeArray(ByVal items() As String)
        Dim max_index As Integer = items.Length - 1
        Dim rnd As New Random
        For i As Integer = 0 To max_index - 1
            ' Picks an item for position i.
            Dim j As Integer = rnd.Next(i, max_index + 1)

            ' Swaps the position of items(i) and items(j).
            Dim temp As String = items(i)
            items(i) = items(j)
            items(j) = temp
        Next i
    End Sub

    'This is the timer that records the time taken by users to complete the game
    Private Sub WordTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordTimer.Tick
        'Increments the value of time_ms each tick
        time_ms += 1
        'If time_ms is more than 9, it is set to 0 and time_s is incremented by one
        If time_ms > 9 Then
            time_s += 1
            time_ms = 0
        End If
        'Displays the time in the label in the format xx.x
        'Refreshes the label each tick
        lblTimer.Text = time_s.ToString + "." + time_ms.ToString
    End Sub

    'Sub to be executed when the user 'loses' the game
    Private Sub BlitzLoss()
        My.Forms.WordBlitzLoss.Show()
        lblWordReadyDesc.Text = "The correct words, in the correct order are shown below"
    End Sub

    'Sub to be executed when the user 'wins' the game
    Private Sub BlitzWin()
        'The timeTaken variable is used to store the time in decimal format
        timeTaken = time_s + time_ms / 10
        'The timer is stopped
        WordTimer.Stop()
        'The win screen is shown
        WordBlitzWin.Show()

        'The case statement is only used to detetmine which best time should be used in the if statements
        'It uses the difficulty chosen by the user to decide which best time to retrieve 
        Select Case My.Settings.WordDiff
            'The if statements are used to determine whether the current time should be the best time
            'If it is less than the recorded best time for the chosen difficulty, then the best time for
            'the chosen difficulty is overwritten with the time in timeTaken variable
            'Similarly, if the best time is 0 that means that there is no best time for this difficulty
            'so it overwrites the best time with TimeTaken.
            Case 0
                If timeTaken < My.Settings.WordEasyBest Then
                    My.Settings.WordEasyBest = timeTaken
                ElseIf My.Settings.WordEasyBest = 0 Then
                    My.Settings.WordEasyBest = timeTaken
                Else
                    Exit Select
                End If
            Case 1
                If timeTaken < My.Settings.WordMedBest Then
                    My.Settings.WordMedBest = timeTaken
                ElseIf My.Settings.WordMedBest = 0 Then
                    My.Settings.WordMedBest = timeTaken
                Else
                    Exit Select
                End If

            Case 2
                If timeTaken < My.Settings.WordHardBest Then
                    My.Settings.WordHardBest = timeTaken
                ElseIf My.Settings.WordHardBest = 0 Then
                    My.Settings.WordHardBest = timeTaken
                Else
                    Exit Select
                End If
        End Select
    End Sub
End Class