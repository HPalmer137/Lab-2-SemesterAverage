<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCourseOne = New System.Windows.Forms.Label()
        Me.txtCourseOne = New System.Windows.Forms.TextBox()
        Me.lblCourseOneLetter = New System.Windows.Forms.Label()
        Me.lblCourseTwoLetter = New System.Windows.Forms.Label()
        Me.txtCourseTwo = New System.Windows.Forms.TextBox()
        Me.lblCourseTwo = New System.Windows.Forms.Label()
        Me.lblCourseThreeLetter = New System.Windows.Forms.Label()
        Me.txtCourseThree = New System.Windows.Forms.TextBox()
        Me.lblCourseThree = New System.Windows.Forms.Label()
        Me.lblCourseFourLetter = New System.Windows.Forms.Label()
        Me.txtCourseFour = New System.Windows.Forms.TextBox()
        Me.lblCourseFour = New System.Windows.Forms.Label()
        Me.lblCourseFiveLetter = New System.Windows.Forms.Label()
        Me.txtCourseFive = New System.Windows.Forms.TextBox()
        Me.lblCourseFive = New System.Windows.Forms.Label()
        Me.lblCourseSixLetter = New System.Windows.Forms.Label()
        Me.txtCourseSix = New System.Windows.Forms.TextBox()
        Me.lblCourseSix = New System.Windows.Forms.Label()
        Me.lblSemesterLetter = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblSemesterAverage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblErrorOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCourseOne
        '
        Me.lblCourseOne.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseOne.AutoSize = True
        Me.lblCourseOne.Location = New System.Drawing.Point(33, 25)
        Me.lblCourseOne.Name = "lblCourseOne"
        Me.lblCourseOne.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseOne.TabIndex = 0
        Me.lblCourseOne.Text = "Course &1:"
        '
        'txtCourseOne
        '
        Me.txtCourseOne.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCourseOne.Location = New System.Drawing.Point(108, 22)
        Me.txtCourseOne.Name = "txtCourseOne"
        Me.txtCourseOne.Size = New System.Drawing.Size(121, 22)
        Me.txtCourseOne.TabIndex = 1
        Me.txtCourseOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCourseOneLetter
        '
        Me.lblCourseOneLetter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseOneLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseOneLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCourseOneLetter.Location = New System.Drawing.Point(253, 22)
        Me.lblCourseOneLetter.Name = "lblCourseOneLetter"
        Me.lblCourseOneLetter.Size = New System.Drawing.Size(100, 22)
        Me.lblCourseOneLetter.TabIndex = 2
        Me.lblCourseOneLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseTwoLetter
        '
        Me.lblCourseTwoLetter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseTwoLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseTwoLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCourseTwoLetter.Location = New System.Drawing.Point(253, 61)
        Me.lblCourseTwoLetter.Name = "lblCourseTwoLetter"
        Me.lblCourseTwoLetter.Size = New System.Drawing.Size(100, 22)
        Me.lblCourseTwoLetter.TabIndex = 5
        Me.lblCourseTwoLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCourseTwo
        '
        Me.txtCourseTwo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCourseTwo.Location = New System.Drawing.Point(108, 62)
        Me.txtCourseTwo.Name = "txtCourseTwo"
        Me.txtCourseTwo.Size = New System.Drawing.Size(121, 22)
        Me.txtCourseTwo.TabIndex = 4
        Me.txtCourseTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCourseTwo
        '
        Me.lblCourseTwo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseTwo.AutoSize = True
        Me.lblCourseTwo.Location = New System.Drawing.Point(33, 64)
        Me.lblCourseTwo.Name = "lblCourseTwo"
        Me.lblCourseTwo.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseTwo.TabIndex = 3
        Me.lblCourseTwo.Text = "Course &2:"
        '
        'lblCourseThreeLetter
        '
        Me.lblCourseThreeLetter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseThreeLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseThreeLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCourseThreeLetter.Location = New System.Drawing.Point(253, 100)
        Me.lblCourseThreeLetter.Name = "lblCourseThreeLetter"
        Me.lblCourseThreeLetter.Size = New System.Drawing.Size(100, 22)
        Me.lblCourseThreeLetter.TabIndex = 8
        Me.lblCourseThreeLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCourseThree
        '
        Me.txtCourseThree.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCourseThree.Location = New System.Drawing.Point(108, 102)
        Me.txtCourseThree.Name = "txtCourseThree"
        Me.txtCourseThree.Size = New System.Drawing.Size(121, 22)
        Me.txtCourseThree.TabIndex = 6
        Me.txtCourseThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCourseThree
        '
        Me.lblCourseThree.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseThree.AutoSize = True
        Me.lblCourseThree.Location = New System.Drawing.Point(33, 103)
        Me.lblCourseThree.Name = "lblCourseThree"
        Me.lblCourseThree.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseThree.TabIndex = 5
        Me.lblCourseThree.Text = "Course &3:"
        '
        'lblCourseFourLetter
        '
        Me.lblCourseFourLetter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseFourLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseFourLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCourseFourLetter.Location = New System.Drawing.Point(253, 139)
        Me.lblCourseFourLetter.Name = "lblCourseFourLetter"
        Me.lblCourseFourLetter.Size = New System.Drawing.Size(100, 22)
        Me.lblCourseFourLetter.TabIndex = 11
        Me.lblCourseFourLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCourseFour
        '
        Me.txtCourseFour.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCourseFour.Location = New System.Drawing.Point(108, 142)
        Me.txtCourseFour.Name = "txtCourseFour"
        Me.txtCourseFour.Size = New System.Drawing.Size(121, 22)
        Me.txtCourseFour.TabIndex = 8
        Me.txtCourseFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCourseFour
        '
        Me.lblCourseFour.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseFour.AutoSize = True
        Me.lblCourseFour.Location = New System.Drawing.Point(33, 142)
        Me.lblCourseFour.Name = "lblCourseFour"
        Me.lblCourseFour.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseFour.TabIndex = 7
        Me.lblCourseFour.Text = "Course &4:"
        '
        'lblCourseFiveLetter
        '
        Me.lblCourseFiveLetter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseFiveLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseFiveLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCourseFiveLetter.Location = New System.Drawing.Point(253, 178)
        Me.lblCourseFiveLetter.Name = "lblCourseFiveLetter"
        Me.lblCourseFiveLetter.Size = New System.Drawing.Size(100, 22)
        Me.lblCourseFiveLetter.TabIndex = 14
        Me.lblCourseFiveLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCourseFive
        '
        Me.txtCourseFive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCourseFive.Location = New System.Drawing.Point(108, 182)
        Me.txtCourseFive.Name = "txtCourseFive"
        Me.txtCourseFive.Size = New System.Drawing.Size(121, 22)
        Me.txtCourseFive.TabIndex = 10
        Me.txtCourseFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCourseFive
        '
        Me.lblCourseFive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseFive.AutoSize = True
        Me.lblCourseFive.Location = New System.Drawing.Point(33, 181)
        Me.lblCourseFive.Name = "lblCourseFive"
        Me.lblCourseFive.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseFive.TabIndex = 9
        Me.lblCourseFive.Text = "Course &5:"
        '
        'lblCourseSixLetter
        '
        Me.lblCourseSixLetter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseSixLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseSixLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCourseSixLetter.Location = New System.Drawing.Point(253, 217)
        Me.lblCourseSixLetter.Name = "lblCourseSixLetter"
        Me.lblCourseSixLetter.Size = New System.Drawing.Size(100, 22)
        Me.lblCourseSixLetter.TabIndex = 17
        Me.lblCourseSixLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCourseSix
        '
        Me.txtCourseSix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCourseSix.Location = New System.Drawing.Point(108, 222)
        Me.txtCourseSix.Name = "txtCourseSix"
        Me.txtCourseSix.Size = New System.Drawing.Size(121, 22)
        Me.txtCourseSix.TabIndex = 12
        Me.txtCourseSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCourseSix
        '
        Me.lblCourseSix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCourseSix.AutoSize = True
        Me.lblCourseSix.Location = New System.Drawing.Point(33, 220)
        Me.lblCourseSix.Name = "lblCourseSix"
        Me.lblCourseSix.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseSix.TabIndex = 11
        Me.lblCourseSix.Text = "Course &6:"
        '
        'lblSemesterLetter
        '
        Me.lblSemesterLetter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSemesterLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSemesterLetter.Location = New System.Drawing.Point(253, 256)
        Me.lblSemesterLetter.Name = "lblSemesterLetter"
        Me.lblSemesterLetter.Size = New System.Drawing.Size(100, 22)
        Me.lblSemesterLetter.TabIndex = 20
        Me.lblSemesterLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSemester
        '
        Me.lblSemester.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(33, 259)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(72, 17)
        Me.lblSemester.TabIndex = 18
        Me.lblSemester.Text = "Semester:"
        '
        'lblSemesterAverage
        '
        Me.lblSemesterAverage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSemesterAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSemesterAverage.Location = New System.Drawing.Point(108, 262)
        Me.lblSemesterAverage.Name = "lblSemesterAverage"
        Me.lblSemesterAverage.Size = New System.Drawing.Size(121, 22)
        Me.lblSemesterAverage.TabIndex = 21
        Me.lblSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCalculate.Location = New System.Drawing.Point(61, 472)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(93, 34)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(175, 472)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(93, 34)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(289, 472)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 34)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblErrorOutput
        '
        Me.lblErrorOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorOutput.Location = New System.Drawing.Point(12, 284)
        Me.lblErrorOutput.Name = "lblErrorOutput"
        Me.lblErrorOutput.Size = New System.Drawing.Size(370, 172)
        Me.lblErrorOutput.TabIndex = 22
        '
        'frmSemesterAverage
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(392, 505)
        Me.Controls.Add(Me.lblErrorOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSemesterAverage)
        Me.Controls.Add(Me.lblSemesterLetter)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblCourseSixLetter)
        Me.Controls.Add(Me.txtCourseSix)
        Me.Controls.Add(Me.lblCourseSix)
        Me.Controls.Add(Me.lblCourseFiveLetter)
        Me.Controls.Add(Me.txtCourseFive)
        Me.Controls.Add(Me.lblCourseFive)
        Me.Controls.Add(Me.lblCourseFourLetter)
        Me.Controls.Add(Me.txtCourseFour)
        Me.Controls.Add(Me.lblCourseFour)
        Me.Controls.Add(Me.lblCourseThreeLetter)
        Me.Controls.Add(Me.txtCourseThree)
        Me.Controls.Add(Me.lblCourseThree)
        Me.Controls.Add(Me.lblCourseTwoLetter)
        Me.Controls.Add(Me.txtCourseTwo)
        Me.Controls.Add(Me.lblCourseTwo)
        Me.Controls.Add(Me.lblCourseOneLetter)
        Me.Controls.Add(Me.txtCourseOne)
        Me.Controls.Add(Me.lblCourseOne)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(410, 552)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(410, 552)
        Me.Name = "frmSemesterAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourseOne As Label
    Friend WithEvents txtCourseOne As TextBox
    Friend WithEvents lblCourseOneLetter As Label
    Friend WithEvents lblCourseTwoLetter As Label
    Friend WithEvents txtCourseTwo As TextBox
    Friend WithEvents lblCourseTwo As Label
    Friend WithEvents lblCourseThreeLetter As Label
    Friend WithEvents txtCourseThree As TextBox
    Friend WithEvents lblCourseThree As Label
    Friend WithEvents lblCourseFourLetter As Label
    Friend WithEvents txtCourseFour As TextBox
    Friend WithEvents lblCourseFour As Label
    Friend WithEvents lblCourseFiveLetter As Label
    Friend WithEvents txtCourseFive As TextBox
    Friend WithEvents lblCourseFive As Label
    Friend WithEvents lblCourseSixLetter As Label
    Friend WithEvents txtCourseSix As TextBox
    Friend WithEvents lblCourseSix As Label
    Friend WithEvents lblSemesterLetter As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblSemesterAverage As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblErrorOutput As Label
End Class
