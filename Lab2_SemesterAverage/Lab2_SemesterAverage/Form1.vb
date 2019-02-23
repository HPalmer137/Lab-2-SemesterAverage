'Program name: Semester Average
'Date: Feb 6, 2019
'Author: Harry Palmer
'Student #: 100558528
'Description: Takes user inputted grades for six semesters, double or integer numbers between 0 - 100. Outputs error messages for wrong input. After
'             all 6 grades are inputted properly, the average for all grades is calculated and outputted. For each grade includig the average, the 
'             corresponding letter grade is outputted next to it. The user can also reset the entire form and exit the program with buttons.
'
Option Strict On

Public Class frmSemesterAverage

    'CONSTANT DECLARATION
    Dim MAXIMUX_GRADE As Integer = 100
    Dim MINIMUM_GRADE As Integer = 0

    'VARIABLE DECLARATION
    Dim average As Double = 0.0
    Dim userGrade As Double

    Dim count As Integer = 1
    Dim arrayCounter As Integer

    Dim userInput As String
    Dim letter As String

    Dim gradeArray(5) As Double

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()  'Exit the form
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'RESET BUTTON

        'Reset data for course one
        txtCourseOne.Clear()
        lblCourseOneLetter.ResetText()

        'Reset data for course two
        txtCourseTwo.Clear()
        lblCourseTwoLetter.ResetText()

        'Reset data for course three
        txtCourseThree.Clear()
        lblCourseThreeLetter.ResetText()

        'Reset data for course four
        txtCourseFour.Clear()
        lblCourseFourLetter.ResetText()

        'Reset data for course five
        txtCourseFive.Clear()
        lblCourseFiveLetter.ResetText()

        'Reset data for course six
        txtCourseSix.Clear()
        lblCourseSixLetter.ResetText()

        'Reset data for semester average
        lblSemesterAverage.ResetText()
        lblSemesterLetter.ResetText()

        'Reset data for output
        lblErrorOutput.ResetText()
        txtCourseOne.Focus()

        'Reset data for average
        average = 0.0
    End Sub


    'NUMERIC VALIDATE FUNCTION
    Function NumericValidate(ByVal userInput As String) As Double
        'Is the data entered a double?
        If Double.TryParse(userInput, userGrade) Then
            'Is it within range?
            If userGrade >= 0 Or userGrade <= 100 Then
                'Assign to array
                gradeArray(count - 1) = userGrade
            Else
                'Out of range error
                lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
                'Sentinel value sent out
                userGrade = -1
            End If

        Else
            'Inproper enrty error
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            'Sentinel value sent out
            userGrade = -1
        End If
        Return userGrade
    End Function


    'LETTER GRADE Function
    Function LetterGrade(ByVal userGrade As Double) As String
        'If the grade is within a certain range, output the appropriate letter
        If (userGrade <= 49) Then
            letter = "F"
        ElseIf (userGrade <= 52) Then
            letter = "D-"
        ElseIf (userGrade <= 56) Then
            letter = "D"
        ElseIf (userGrade <= 59) Then
            letter = "D+"
        ElseIf (userGrade <= 62) Then
            letter = "C-"
        ElseIf (userGrade <= 66) Then
            letter = "C"
        ElseIf (userGrade <= 69) Then
            letter = "C+"
        ElseIf (userGrade <= 72) Then
            letter = "B-"
        ElseIf (userGrade <= 76) Then
            letter = "B"
        ElseIf (userGrade <= 79) Then
            letter = "B+"
        ElseIf (userGrade <= 84) Then
            letter = "A-"
        ElseIf (userGrade <= 89) Then
            letter = "A"
        ElseIf (userGrade <= 100) Then
            letter = "A+"
        Else
            'Out of range error
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
        End If
        'Return new letter for output
        Return letter
    End Function

    'Course One
    Private Sub txtCourseOne_Lostfocus(sender As Object, e As EventArgs) Handles txtCourseOne.LostFocus
        count = 1
        userInput = txtCourseOne.Text 'Take user input
        NumericValidate(userInput) 'Checks for numeric input
        LetterGrade(userGrade) 'Assigns letter
        lblCourseOneLetter.Text = letter   'outputs letter

        'If a sentinel is sent
        If userGrade = -1 Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseOne.Focus()
        Else
            lblErrorOutput.ResetText()
            userGrade += gradeArray(count - 1)
        End If
    End Sub

    'Course Two
    Private Sub txtCourseTwo_Lostfocus(sender As Object, e As EventArgs) Handles txtCourseTwo.LostFocus
        count = 2
        userInput = txtCourseTwo.Text 'Take user input
        NumericValidate(userInput) 'Checks for numeric input
        LetterGrade(userGrade) 'assigns letter
        lblCourseTwoLetter.Text = letter 'outputs letter

        'If a sentinel is sent
        If userGrade = -1 Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseTwo.Focus()
        Else
            lblErrorOutput.ResetText()
            userGrade += gradeArray(count - 1)
        End If
    End Sub

    'Course three
    Private Sub txtCourseThree_LostFocus(sender As Object, e As EventArgs) Handles txtCourseThree.LostFocus
        count = 3
        userInput = txtCourseThree.Text 'Take user input
        NumericValidate(userInput) 'Checks for numeric input
        LetterGrade(userGrade) 'Assigns letter
        lblCourseThreeLetter.Text = letter 'Output letter

        'If a sentinel is sent
        If userGrade = -1 Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseThree.Focus()
        Else
            userGrade += gradeArray(count - 1)
        End If
    End Sub

    'Course Four
    Private Sub txtCourseFour_LostFocus(sender As Object, e As EventArgs) Handles txtCourseFour.LostFocus
        count = 4
        userInput = txtCourseFour.Text 'Take user input
        NumericValidate(userInput) 'Checks for numeric input
        LetterGrade(userGrade) 'Assigns letter
        lblCourseFourLetter.Text = letter 'Output letter

        'If a sentinel is sent
        If userGrade = -1 Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseFour.Focus()
        Else
            lblErrorOutput.ResetText()
            userGrade += gradeArray(count - 1)
        End If
    End Sub

    'Course Five
    Private Sub txtCourseFive_LostFocus(sender As Object, e As EventArgs) Handles txtCourseFive.LostFocus
        count = 5
        userInput = txtCourseFive.Text 'Take user input
        NumericValidate(userInput) 'Checks for numeric input
        LetterGrade(userGrade) 'Assigns letter
        lblCourseFiveLetter.Text = letter 'Output letter

        'If a sentinel is sent
        If userGrade = -1 Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseFive.Focus()
        Else
            lblErrorOutput.ResetText()
            userGrade += gradeArray(count - 1)
        End If
    End Sub


    'Course Six
    Private Sub txtCourseSix_LostFocus(sender As Object, e As EventArgs) Handles txtCourseSix.LostFocus
        count = 6
        userInput = txtCourseSix.Text 'Take yser input
        NumericValidate(userInput) 'Checks for numeric input
        LetterGrade(userGrade) 'Assigns letter
        lblCourseSixLetter.Text = letter 'Output letter

        'If a sentinel is sent
        If userGrade = -1 Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseSix.Focus()
        Else
            lblErrorOutput.ResetText()
            userGrade += gradeArray(count - 1)
        End If
    End Sub

    'CALCULATE button
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'If any textbox is empty, output an error and focus that textbox
        If txtCourseOne.Text = "" Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseOne.Focus()
        ElseIf txtCourseTwo.Text = "" Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseTwo.Focus()
        ElseIf txtCourseThree.Text = "" Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseThree.Focus()
        ElseIf txtCourseOne.Text = "" Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseFour.Focus()
        ElseIf txtCourseFive.Text = "" Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseFive.Focus()
        ElseIf txtCourseSix.Text = "" Then
            lblErrorOutput.Text += "Please ensure that what you input in Course " & count.ToString() & " is a number between " & MINIMUM_GRADE.ToString() & " and " + MAXIMUX_GRADE.ToString() & "! " & vbCrLf
            txtCourseSix.Focus()
        Else
            'If all textboxes have appropriate data
            'Cycle through array finding averae
            For arrayCounter = 1 To gradeArray.Length
                average += gradeArray(arrayCounter - 1)
            Next arrayCounter
            'Calculate average
            average = average / gradeArray.Length
        End If
        'Output average, semester average, and semester letter grade
        LetterGrade(average)
        lblSemesterAverage.Text = average.ToString()
        lblSemesterLetter.Text = letter
    End Sub
End Class
