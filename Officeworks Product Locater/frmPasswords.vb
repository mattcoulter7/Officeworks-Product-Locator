'Author: Matthew Coulter
'Date: 8/20/2018

'//THIS FORM IS THE DATABASE TO EDIT THE PASSWORDS

'must be imported to read files
Imports System.IO

Public Class frmPasswords
    'boolEdited determines whether any cell has been edited
    Dim boolEdited As Boolean = False

    'intRowIndex is the index for the password database
    Dim intRowIndex As Integer = 0

    'strCurrentCell is a string containing data from the current cell before it is edited
    Dim strCurrentCell As String

    '//WHEN THE USER PRESSES SAVE

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '//Code sourced from Mr. Bonfadini
        'This is the directory of the CSV file
        Dim ResourceFilePath As String

        ResourceFilePath = Application.StartupPath & "\..\..\resources\OfficeworksPasswords.csv"

        'Counts the number of lines in the file
        Dim lineCount = File.ReadAllLines(ResourceFilePath).Length

        'Streamreader for opening the file, reading and closing
        Dim objStreamWriter As StreamWriter

        'strline is the array of words for a particular row at intRowIndex
        Dim strLine As String

        'intRowIndex is set to 0 to import every line from the csv file
        intRowIndex = 0

        'The CSV file is opened so it can be read
        objStreamWriter = New StreamWriter(ResourceFilePath)

        'sets the complete state of the progressbar to be at the number of lines in the csv file
        progSaving.Maximum += lineCount

        progSaving.Visible = True

        'The CSV file is cleared and contructed of what is in the dataviewgrid. each cell and row is formatted in the way of a CSV file so it can be re read again.
        While intRowIndex < dataPasswords.RowCount - 1
            'this structures the row
            strLine = dataPasswords.Rows(intRowIndex).Cells("EmployeeName").Value & "," & dataPasswords.Rows(intRowIndex).Cells("EmployeePassword").Value & "," & dataPasswords.Rows(intRowIndex).Cells("DatabasePrivelages").Value & "," & dataPasswords.Rows(intRowIndex).Cells("PasswordPrivelages").Value

            'this writes the line to the csv file
            objStreamWriter.WriteLine(strLine)

            'this goes to the next line in the dataviewgrid to be written
            intRowIndex += 1

            'The progress bar is updated to the new status
            progSaving.Value = intRowIndex
        End While
        'To avoid corruption, the file must be closed again
        objStreamWriter.Close()
        boolEdited = False
        MsgBox("Database Saved.", MessageBoxIcon.Information)
        'the maximum needs to return to zero so it doesn't stack
        progSaving.Maximum = 0

        'hides to progress bar
        progSaving.Visible = False
    End Sub

    'Moving the database form by clicking on the frorm was found on: https://stackoverflow.com/questions/24449543/how-to-move-form-without-form-border-visual-studio

    'drag determines whether the user is holding their mouse on the forma nd trying to move it around
    Dim drag As Boolean

    'mousex is the x-coordinate of where the mouse is
    Dim mousex As Integer

    'mousey is the y-coordinate of where the mouse is
    Dim mousey As Integer

    '//WHEN THE USER CLICKS AND HOLDS DOWN ON THE MAIN FORM

    Private Sub frmPasswords_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        'Sets the variable drag to true.
        drag = True

        'Sets variable mousex
        mousex = Cursor.Position.X - Left

        'Sets variable mousey
        mousey = Cursor.Position.Y - Top
    End Sub

    '//WHEN THE USER MOVES THEIR MOUSE WHILST STILL HOLDIONG DOWN

    Private Sub frmPasswords_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            'because coordinates would orientate the top left of the from the where the mouse is, these calculations needs to be made to avoid that, and move it relative to where the mouse is on the form
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    '//WHEN THE USER RELEASES THEIR FINGER FROM HOLDING DOWN ON THE FORM

    Private Sub frmPasswords_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseUp
        'Sets drag to false, so the form does not move according to the code in MouseMove
        drag = False
    End Sub

    '//WHEN THE USER CLOSES THE PASSWORD DATABASE FORM

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Code sourced from: https://stackoverflow.com/questions/2256909/messagebox-with-yesnocancel-no-cancel-triggers-same-event
        'result is the outcome from the messagebox

        'if the user has edited the form without saving it
        If boolEdited Then
            Dim result As Integer = MsgBox("Are you sure you want to close without saving changes?", MessageBoxButtons.YesNo)
            'if the user selects yes
            If result = DialogResult.Yes Then
                'hide the form
                Hide()
            End If
        Else
            Hide()
        End If
        'must hide the database rather than closing it so it can still be accessed
        Hide()

        'reenable the button that was used to open the database so that they can reopen it again if necessary.
        frmMain.EditPasswordsToolStripMenuItem.Enabled = True

        'the form can be used again as no changes to the databse are being made
        frmMain.Enabled = True
    End Sub

    '//WHEN THE USER CLICKS ON ONE OF THE CELLS

    Private Sub dataPasswords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataPasswords.CellClick
        'the data in the cell that the user clicked is stored so that if a validation error occurs, the cell will return to this value
        strCurrentCell = dataPasswords.CurrentCell.Value
    End Sub

    '//WHEN THE USER FINSHES EDITING ON OF THE CELLS

    Private Sub dataPasswords_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataPasswords.CellEndEdit
        'this prevent the cell from being empty
        If dataPasswords.CurrentCell.Value = "" Then
            MsgBox("Your cell must contain text", MessageBoxIcon.Warning)
            resetcell()
        End If

        'if the cell after editing isn't the same as when it started to be edited, then boolEdited will be true
        If dataPasswords.CurrentCell.Value <> strCurrentCell Then
            boolEdited = True
        End If
    End Sub

    '//SUBROUTINE TO RESET CELL UNDER GIVEN CIRCUMSTANCES

    Sub resetcell()
        'this returns the original cell value back into the cell
        dataPasswords.CurrentCell.Value = strCurrentCell
    End Sub

    Private Sub btnAddRow_Click(sender As Object, e As EventArgs) Handles btnAddRow.Click
        'adds a row to the table
        dataPasswords.Rows.Add()

        'intLastRow is the index of the last added row in the table
        Dim intLastRow As Integer = dataPasswords.RowCount - 2

        'fills the new row with data so the program doesn't crash from null values
        dataPasswords.Rows(intLastRow).Cells("EmployeeName").Value = "uyvbsidufhawiudei"
        dataPasswords.Rows(intLastRow).Cells("EmployeePassword").Value = "asdikuvhaifdbaidukh"
        dataPasswords.Rows(intLastRow).Cells("DatabasePrivelages").Value = "False"
        dataPasswords.Rows(intLastRow).Cells("PasswordPrivelages").Value = "False"

        progSaving.Maximum += 1
    End Sub
End Class