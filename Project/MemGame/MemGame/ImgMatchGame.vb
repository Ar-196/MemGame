Imports System.IO

Public Class ImgMatchGame
    'This variable is used to store the size of the grid (number of units on one side of grid)
    Private GridSize As Integer = 0
    'This variable is used to store the number of image pairs to be loaded and used
    Private ImgCount As Integer = 0
    'This array will be used to store the images that will be used in the game.
    Private UniqueImage(0) As String
    'This array will be used to store data about all the images in the grid once they have been spawned
    Private ImageCollection(0, 0) As String
    'This array will be used to store data about all the pictureboxes held in the grid once they have been spawned
    Private PictureBoxes(0, 0) As PictureBox
    'The next two variables will be used to store the two images clicked by the user
    Private FirstChoice As String = Nothing
    Private SecondChoice As String = Nothing
    'The next three elements are elements that are used for time keeping and recording purposes
    Private time_ms As Integer = 0
    Private time_s As Integer = 0
    Private timeTaken As Double = 0
    'This variable is used to store the amount of same-image pairs revealed by the user
    Private Score As Integer = 0
    'This variable is used to store the relevant best time (for easy reference)
    Public BestTimeDisplay As Double = 0
    'This variable is used by the game to identify when the game is paused, and when the pause menu is open
    Public Pause As Boolean = False
    'Prevents flickering of elements while loading up the form
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub ImgMatchGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Makes the header elements semi-transparent
        PictureBoxLogo.BackColor = Color.FromArgb(125, Color.White)
        HeaderBox.BackColor = Color.FromArgb(125, Color.White)
        HeaderText.BackColor = Color.FromArgb(125, Color.White)

        'If sound is on, plays the game soundtrack on a loop
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Volcano, AudioPlayMode.BackgroundLoop)
        'Uses the system setting AppBgImg to set a chosen background image for the form
        'Also changes the color of the important labels on the form to white if the background is not the default background
        Select Case My.Settings.AppBgImg
            Case 0
                Me.BackgroundImage = My.Resources.white_background
                lblTimer.ForeColor = Color.Black
                lblScore.ForeColor = Color.Black
                lblBestTime.ForeColor = Color.Black
                lblTotalPairs.ForeColor = Color.Black
                lblDiffDisplay.ForeColor = Color.Black
                Label1.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
            Case 1
                Me.BackgroundImage = My.Resources.Mountain_Peaks
                lblTimer.ForeColor = Color.White
                lblScore.ForeColor = Color.White
                lblBestTime.ForeColor = Color.White
                lblTotalPairs.ForeColor = Color.White
                lblDiffDisplay.ForeColor = Color.White
                Label1.ForeColor = Color.White
                Label3.ForeColor = Color.White
            Case 2
                Me.BackgroundImage = My.Resources.Rocky_Sunset
                lblTimer.ForeColor = Color.White
                lblScore.ForeColor = Color.White
                lblBestTime.ForeColor = Color.White
                lblTotalPairs.ForeColor = Color.White
                lblDiffDisplay.ForeColor = Color.White
                Label1.ForeColor = Color.White
                Label3.ForeColor = Color.White
            Case 3
                Me.BackgroundImage = My.Resources.smooth_turqoise_gradient
                lblTimer.ForeColor = Color.White
                lblScore.ForeColor = Color.White
                lblBestTime.ForeColor = Color.White
                lblTotalPairs.ForeColor = Color.White
                lblDiffDisplay.ForeColor = Color.White
                Label1.ForeColor = Color.White
                Label3.ForeColor = Color.White
            Case 4
                Me.BackgroundImage = My.Resources.Sunset_Calm_Waters
                lblTimer.ForeColor = Color.White
                lblScore.ForeColor = Color.White
                lblBestTime.ForeColor = Color.White
                lblTotalPairs.ForeColor = Color.White
                lblDiffDisplay.ForeColor = Color.White
                Label1.ForeColor = Color.White
                Label3.ForeColor = Color.White
        End Select
        Me.BackgroundImageLayout = ImageLayout.Stretch

        'Changes the number of images to be loaded and the size of the grid, and changes lblDiffDisplay to display the chosen difficulty in a different color
        'Also stores the best time for the chosen difficulty in BestTimeDisplay (for easy reference.)
        Select Case My.Settings.ImgDiff
            Case 0
                GridSize = 4
                ImgCount = 8
                lblDiffDisplay.Text = "Easy"
                BestTimeDisplay = My.Settings.ImgEasyBest
            Case 1
                GridSize = 5
                ImgCount = 12
                lblDiffDisplay.Text = "Medium"
                BestTimeDisplay = My.Settings.ImgMedBest
            Case 2
                GridSize = 6
                ImgCount = 18
                lblDiffDisplay.Text = "Hard"
                BestTimeDisplay = My.Settings.ImgHardBest
        End Select

        'Redifines the arrays ImageCollection, PictureBoxes and UniqueImage to the correct size
        ReDim ImageCollection(GridSize - 1, GridSize - 1)
        ReDim PictureBoxes(GridSize - 1, GridSize - 1)
        'The UniqueImage array's length is double the number of image pairs needed 
        ReDim UniqueImage((ImgCount * 2) - 1)

        'Makes lblTotalPairs display the number of total pairs that the user needs to reveal
        lblTotalPairs.Text = "of " + ImgCount.ToString + " pairs revealed"
        'Makes lblScore display the user's score
        lblScore.Text = Score.ToString
        'Clause to change the text displayed by lblBestTime to no games played yet if the best time is 0
        'as a best score of 0 indicates that the user has not gotten a best time on this difficulty
        If BestTimeDisplay <> 0 Then
            lblBestTime.Text = "Best Time:" + BestTimeDisplay.ToString + " seconds"
        Else
            lblBestTime.Text = "Best Time: No games played yet"
        End If
        'Starts the ImgTimer
        ImgTimer.Start()
        'Executes the sub responsible for generating the grid
        GenerateGrid()

    End Sub

    Public Sub GenerateGrid()
        'Creates a new array files() and fills it with all the file paths of the images that are available in the folder below
        Dim files() As String = Directory.GetFiles("Windows_Icons", "*.png")
        'Creates a new variable with a Random() function attributed to it
        Dim random As Random = New Random()
        'Creates another variable, and then executes the 'random' function declared above with the required inputs
        'The output is a random integer with minimum value 10 and maximum value being the length of wordBank() - 20
        'This output is attributed to FileStartNumber
        Dim FileStartNumber As Integer = random.Next(10, files.Length - 20)

        'Redefines the rowCount and colCount of wordUse to be the length of ImgCount, as the game only needs a grid of this size
        ImgGrid.Controls.Clear()
        ImgGrid.RowCount = GridSize
        ImgGrid.ColumnCount = GridSize

        'The loop selects the unique Images to be used and puts them in UniqueImage() two times
        For unqImage As Integer = 0 To ImgCount - 1
            FileStartNumber += 1
            UniqueImage(unqImage) = files(FileStartNumber)
            UniqueImage(unqImage + ImgCount) = files(FileStartNumber)
        Next
        'Executes the sub responsible for jumbling up the order of elements in UniqueImages
        RandomizeArray(UniqueImage)

        'Creates a general-use counter, mainly to be used in for loops
        Dim counter As Integer = 0

        'This code puts in a picture box in each cell of the table layout panel and names it "open"
        'Nested loop with row and col counters, to generate the pictureboxes
        For row As Integer = 0 To GridSize - 1
            For col As Integer = 0 To GridSize - 1
                Dim Box As New PictureBox
                'Boxes are generated in default state with name "open"
                Box.Name = "Open"
                Box.Width = 60
                Box.Height = 60
                Box.Visible = True
                Box.Dock = DockStyle.Fill
                'Adds each box to the grid 
                ImgGrid.Controls.Add(Box, col, row)

                'Adds each box into a 2-dimensional array for easy reference
                PictureBoxes(col, row) = Box
                'Attributes an image from another array to the created picturebox (not directly)
                ImageCollection(col, row) = UniqueImage(counter)

                'Extra code to make the center box a null picturebox and to skip the rest of the loop if the difficulty is medium, as 
                'the game makes the table a 5 x 5 grid in that case. This ensures that an even number of images are
                'put in the grid, by making the center cell a 'null' cell
                If My.Settings.ImgDiff = 1 And row = 2 And col = 2 Then
                    Box.Name = "null"
                    Continue For
                End If

                'Adds a click functionality to each picturebox, and the program executes updateImage() upon a picturebox being clicked
                AddHandler Box.Click, AddressOf updateImage

                'Makes the box display the initial default image upon loading
                Box.BackgroundImage = My.Resources._Default
                Box.BackgroundImageLayout = ImageLayout.Stretch

                'Increments the counter value, so that the next picturebox is given the next image in the array UniqueImage
                counter += 1
            Next
        Next
    End Sub

    Private Sub updateImage(ByVal sender As Object, ByVal e As EventArgs)
        'First line takes the value of the box that was clicked and puts it into the variable "box"
        Dim box As PictureBox = sender

        'Takes the row and column values of the box and stores them in the variables
        Dim row As Integer = ImgGrid.GetCellPosition(box).Row
        Dim col As Integer = ImgGrid.GetCellPosition(box).Column
        'If box.Name is "Matched", then it has already been matched - ignore it
        If box.Name = "Matched" Then Exit Sub
        'If box.Name is "FChoice", then it is already stored in FirstChoice - ignore it
        If box.Name = "FChoice" Then Exit Sub
        'If Pause is True, then the program executes ClickeWhilePause(), which handles clicks on pictureboxes while the game is paused
        'and then exits the sub
        If Pause = True Then
            ClickeWhilePause()
            Exit Sub
        End If
        'If box.Name is "null", then it is the center cell in the 5 x 5 grid - ignore it
        If box.Name = "null" Then Exit Sub

        'Takes what was clicked and puts it in FirstChoice - if FirstChoice already holds something, then it moves onto SecondChoice
        'Also names boxes "FChoice" or "SChoice" for easy reference
        'After both FirstChoice and SecondChoice contain values, it takes these two values and uses them as inputs for the sub compare()
        If FirstChoice Is Nothing Then
            box.BackgroundImage = Image.FromFile(ImageCollection(col, row))
            FirstChoice = ImageCollection(col, row)
            box.Name = "FChoice"
        Else
            box.BackgroundImage = Image.FromFile(ImageCollection(col, row))
            SecondChoice = ImageCollection(col, row)
            box.Name = "SChoice"
            compare(FirstChoice, SecondChoice)
        End If
    End Sub

    Private Sub compare(ByVal Img1 As String, ByVal Img2 As String)
        'Compares the filepaths as strings for the images 'held' by both pictureboxes
        'If they are both equal then:

        If Img1 = Img2 Then
            'Score is Incremented
            Score += 1
            'lblScore is updated
            lblScore.Text = Score.ToString
            'The for loop loops through all the boxes, and changes the names of the boxes chosen to "Matched"
            For Each box As PictureBox In PictureBoxes
                If box.Name = "null" Then Continue For
                If box.Name = "FChoice" Or box.Name = "SChoice" Then
                    box.Name = "Matched"
                End If
            Next
            'Resets FirstChoice And SecondChoice
            FirstChoice = Nothing
            SecondChoice = Nothing
            'Executes the sub responsible for checking whether the user has won
            WinCheck()
        Else
            'If the two filepaths are not equal, then it starts ImgTimeDelay(), which hides both boxes after a short delay
            ImgTimeDelay.Start()
        End If
    End Sub

    Private Sub RandomizeArray(ByVal items() As String)
        Dim max_index As Integer = items.Length - 1
        Dim rnd As New Random
        For i As Integer = 0 To max_index - 1
            ' Pick an item for position i.
            Dim j As Integer = rnd.Next(i, max_index + 1)

            ' Swap them.
            Dim temp As String = items(i)
            items(i) = items(j)
            items(j) = temp
        Next i
    End Sub

    'This is the timer that records the time taken by users to complete the game
    Private Sub ImgTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgTimer.Tick
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

    'This timer is responsible for hiding the two images chosen by the user if they do not match
    Private Sub ImgTimeDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgTimeDelay.Tick
        'Stops the actual timer
        ImgTimer.Stop()
        'Loops through the pictureboxes to find the boxes named "FChoice" and "SChoice" and then:
        For Each box As PictureBox In PictureBoxes
            If box.Name = "null" Then Continue For
            If box.Name = "FChoice" Or box.Name = "SChoice" Then
                'It makes the boxes display the Default Image, effectively hiding them
                box.BackgroundImage = My.Resources._Default
                'Resets FirstChoice and SecondChoice
                FirstChoice = Nothing
                SecondChoice = Nothing
                'Resets the name of the picturebox to "Open"
                box.Name = "Open"
            End If
        Next
        'Starts the actual timer again
        ImgTimer.Start()
        'Stops the ImgTimeDelay timer
        ImgTimeDelay.Stop()
    End Sub

    'This sub is responsible for checking whether the user has won
    Private Sub WinCheck()
        'The sub first checks the number of revealed pairs (score) against the total number of pairs (ImgCount)
        'If they are both equal, that means that the user has revealed all the pairs - and has won.
        If Score = ImgCount Then
            'The timeTaken variable is used to store the time in decimal format
            timeTaken = time_s + time_ms / 10
            'The timer is stopped
            ImgTimer.Stop()
            'The win screen is shown
            ImgMatchWin.Show()

            'The case statement is only used to detetmine which best time should be used in the if statements
            'It uses the difficulty chosen by the user to decide which best time to retrieve 
            Select Case My.Settings.ImgDiff
                'The if statements are used to determine whether the current time should be the best time
                'If it is less than the recorded best time for the chosen difficulty, then the best time for
                'the chosen difficulty is overwritten with the time in timeTaken variable
                'Similarly, if the best time is 0 that means that there is no best time for this difficulty
                'so it overwrites the best time with TimeTaken.
                Case 0
                    If timeTaken < My.Settings.ImgEasyBest Then
                        My.Settings.ImgEasyBest = timeTaken
                    ElseIf My.Settings.ImgEasyBest = 0 Then
                        My.Settings.ImgEasyBest = timeTaken
                    End If
                Case 1
                    If timeTaken < My.Settings.ImgMedBest Then
                        My.Settings.ImgMedBest = timeTaken
                    ElseIf My.Settings.ImgMedBest = 0 Then
                        My.Settings.ImgMedBest = timeTaken
                    End If
                Case 2
                    If timeTaken < My.Settings.ImgHardBest Then
                        My.Settings.ImgHardBest = timeTaken
                    ElseIf My.Settings.ImgHardBest = 0 Then
                        My.Settings.ImgHardBest = timeTaken
                    End If
            End Select
        End If
    End Sub


    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        'If sound is on, plays the general button SFX
        If My.Settings.SoundConfig = 0 Then My.Computer.Audio.Play(My.Resources.Tiny_button_Push, AudioPlayMode.Background)
        'Upon clicking the pause button, it shows the pause menu and stops the timer
        ImgTimer.Stop()
        PauseMenu.Show()
        My.Forms.PauseMenu.FormSender = 0
        'Also sets the pause variable to 'true', indicating that the game is now paused
        Pause = True
        'Sets the Formsender attribute to identify that this form is the sender
        PauseMenu.FormSender = 0
    End Sub

    'Custom sub that handles events where the picturebox is clicked while the game is 'paused'
    Private Sub ClickeWhilePause()
        'If the user clicks the textbox while the game is 'paused', it tells the user to unpause the game to manipulate objects
        'And then refreshes the PauseMenu screen to bring it to the front
        MessageBox.Show("Please resume the game to manipulate objects.")
        PauseMenu.Hide()
        PauseMenu.Show()
    End Sub
End Class