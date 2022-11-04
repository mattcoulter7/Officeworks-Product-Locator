'Author: Matthew Coulter
'Date: 8/20/2018

'//THIS FORM IS THE MAIN FORM THAT THE USER OPERATES WITH. THEY CAN SEARCH FOR PRODUCTS, FIND PRODUCTS AND USE IT AS A TUNNEL TO OPEN OTHER FORMS TO COMPLETE MORE TASKS.

'must be imported to read files
Imports System.IO
Public Class frmDatabase
    'intRowIndex is the row index for the Products Database
    Dim intRowIndex As Integer

    'stores the data in a cell before it is edited
    Dim strCurrentCell As String

    'boolEdited determines whether any cell has been edited
    Dim boolEdited As Boolean = False

    '//WHEN THE USER CLICKS THE ADD ROW BUTTON

    Private Sub btnAddRow_Click(sender As Object, e As EventArgs) Handles btnAddRow.Click
        'adds another row to the database
        dataProducts.Rows.Add()

        'intLastRow is the index of the last added row in the table
        Dim intLastRow As Integer = dataProducts.RowCount - 2

        'fills the new row with data so the program doesn't crash from null values
        dataProducts.Rows(intLastRow).Cells("CategoryName").Value = "0"
        dataProducts.Rows(intLastRow).Cells("AisleNumber").Value = "0"
        dataProducts.Rows(intLastRow).Cells("AislePixel").Value = "0"
        dataProducts.Rows(intLastRow).Cells("AislePosition").Value = "0"

        progSaving.Maximum += 1
    End Sub

    '//WHEN THE SUER SAVES THE DATABASE

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '//Code sourced from Mr. Bonfadini
        'This is the directory of the CSV file
        Dim ResourceFilePath As String

        ResourceFilePath = Application.StartupPath & "\..\..\resources\OfficeworksData.csv"


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

        'For each line in the CSV file
        While intRowIndex < dataProducts.RowCount - 1
            'this structures the row
            strLine = dataProducts.Rows(intRowIndex).Cells("CategoryName").Value & "," & dataProducts.Rows(intRowIndex).Cells("AisleNumber").Value & "," & dataProducts.Rows(intRowIndex).Cells("AislePixel").Value & "," & dataProducts.Rows(intRowIndex).Cells("AislePosition").Value

            'this writes the line to the csv file
            objStreamWriter.WriteLine(strLine)

            'this goes to the next line in the dataviewgrid to be written
            intRowIndex += 1

            'The progress bar is updated to the new status
            progSaving.Value = intRowIndex

        End While
        'To avoid corruption, the file must be closed again
        objStreamWriter.Close()

        'reenable the form
        frmMain.Enabled = True

        'update everything in the main form to sync it with the table
        frmMain.Refresh()

        'as the file is synced with the table again, nothing has been edited
        boolEdited = False

        MsgBox("Database Saved.", MessageBoxIcon.Information)

        'the maximum needs to return to zero so it doesn't stack
        progSaving.Maximum = 0

        'hides to progress bar
        progSaving.Visible = False
    End Sub

    'WHEN THE USER BEGINS TO EDIT A CELL

    Private Sub dataProducts_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dataProducts.CellBeginEdit
        'disable the main form to avoid corruption, errors and crashes
        frmMain.Enabled = False
    End Sub

    'Moving the database form by clicking on the frorm was found on: https://stackoverflow.com/questions/24449543/how-to-move-form-without-form-border-visual-studio

    'drag determines whether the user is holding their mouse on the forma nd trying to move it around
    Dim drag As Boolean

    'mousex is the x-coordinate of where the mouse is
    Dim mousex As Integer

    'mousey is the y-coordinate of where the mouse is
    Dim mousey As Integer

    '//WHEN THE USER CLICKS AND HOLDS DOWN ON THE MAIN FORM

    Private Sub frmDatabase_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        'Sets the variable drag to true.
        drag = True

        'Sets variable mousex
        mousex = Cursor.Position.X - Left

        'Sets variable mousey
        mousey = Cursor.Position.Y - Top
    End Sub

    '//WHEN THE USER MOVES THEIR MOUSE WHILST STILL HOLDIONG DOWN

    Private Sub frmDatabase_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            'because coordinates would orientate the top left of the from the where the mouse is, these calculations needs to be made to avoid that, and move it relative to where the mouse is on the form
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    '//WHEN THE USER RELEASES THEIR FINGER FROM HOLDING DOWN ON THE FORM

    Private Sub frmDatabase_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseUp
        'Sets drag to false, so the form does not move according to the code in MouseMove
        drag = False
    End Sub

    '//WHEN THE USER CLICKS THE CLOSE BUTTON

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

        'reenable the ability to open this form
        frmMain.OpenDatabaseToolStripMenuItem.Enabled = True

        'make the main form useable again
        frmMain.Enabled = True
    End Sub

    '//WHEN THE USER CLICKS A CELL

    Private Sub dataProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataProducts.CellClick
        'the data in the cell that the user clicked is stored so that if a validation error occurs, the cell will return to this value
        strCurrentCell = dataProducts.CurrentCell.Value
    End Sub

    '//WHEN THE USER FINSHES EDITING ON OF THE CELLS

    Private Sub dataProducts_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataProducts.CellEndEdit
        'this prevent the cell from being empty
        If dataProducts.CurrentCell.Value = "" Then
            MsgBox("Your cell must contain text", MessageBoxIcon.Warning)
            resetcell()
        End If

        'if the cell after editing isn't the same as when it started to be edited, then boolEdited will be true
        If dataProducts.CurrentCell.Value <> strCurrentCell Then
            boolEdited = True
        End If
    End Sub

    '//SUBROUTINE TO RESET CELL UNDER GIVEN CIRCUMSTANCES

    Sub resetcell()
        'this returns the original cell value back into the cell
        dataProducts.CurrentCell.Value = strCurrentCell
    End Sub
End Class