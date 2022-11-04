'Author: Matthew Coulter
'Date: 8/20/2018

'//THIS FORM IS THE MAIN FORM THAT THE USER OPERATES WITH. THEY CAN SEARCH FOR PRODUCTS, FIND PRODUCTS AND USE IT AS A TUNNEL TO OPEN OTHER FORMS TO COMPLETE MORE TASKS.

'This was automatically generated. I'm assuming it was for another functionality within my software.
Imports System.ComponentModel

'must be imported to read files
Imports System.IO

Public Class frmMain

    'intRowIndex is the index of the product being searched within the data table
    Dim intRowIndex As Integer = 0

    'this counts how many divisions need to be made in the aisle. This each item will have a position between 1 and the maximum amount of positions in that aisle, proportional to eachother.
    Dim FarthestProduct As Integer

    'pen is what is used to draw the line. it must be private so stylistic modifications can be made to it later on.
    Private pen As Pen = New Pen(Color.Red)

    '//WHEN THE USER IS SEARCHING FOR A PRODUCT CATEGORY  

    Private Sub txtbxSearch_KeyUp(sender As Object, e As EventArgs) Handles txtSearch.KeyUp
        'Clears the options to generate new options
        listFound.Items.Clear()

        'starts back at the first row in the database
        intRowIndex = 0

        'input is a variable for the category that the user searched for
        Dim input As String = txtSearch.Text

        'Any category in the database that contains what the user has searched will be added to the list
        Dim found As Boolean = True

        'for every line in the database
        While intRowIndex < frmDatabase.dataProducts.RowCount - 1

            'if the line in the database contains what the user has searched in, it will add the item to the listbox
            'it must be compared as lowercase to remove case sensitivty, not showing items that are spelled the same way
            If frmDatabase.dataProducts.Rows(intRowIndex).Cells("CategoryName").Value.tolower().Contains(input.ToLower()) Then
                listFound.Items.Add(frmDatabase.dataProducts.Rows(intRowIndex).Cells("CategoryName").Value)

                'goes to the next row
                intRowIndex += 1
            Else
                'goes to the next row
                intRowIndex += 1
            End If
        End While
    End Sub

    '//WHEN A USER SELECTS A NEW ITEM IN THE LISTBOX

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listFound.SelectedIndexChanged
        'When a user selects an item, it will find the location of that item
        findLocation(sender)
    End Sub

    '//FINDS THE ROW INDEX IN THE DATABASE OF THE ITEM THAT HAS BEEN CLICKED

    Private Sub findLocation(sender)
        'resets the index for the database back to the first row
        intRowIndex = 0

        'boolFound is for determining whether the category has been found in the database
        Dim boolFound As Boolean = False

        'Searches for the product in the database. Once it is found, intRowIndex can be used to reference that row in the database.This is useful for finding the location of the product
        While intRowIndex <= frmDatabase.dataProducts.RowCount - 1 And Not boolFound
            If frmDatabase.dataProducts.Rows(intRowIndex).Cells("CategoryName").Value = sender.SelectedItem Then
                boolFound = True
            Else
                'goes to the next line
                intRowIndex += 1
            End If
        End While

        'The label at the bottom of the screen will say where the isle is located
        subFindFarthestProductInAisle()
        lblLocation.Text = sender.SelectedItem & " is located in isle: " & frmDatabase.dataProducts.Rows(intRowIndex).Cells("AisleNumber").Value & ", " & Math.Round(frmDatabase.dataProducts.Rows(intRowIndex).Cells("Aisleposition").Value / FarthestProduct * 100) & "% down."

        'The picturebox will be refreshed to draw the new line
        picMap.Refresh()
    End Sub

    '//COUNTS THE NUMBER OF PRODUCTS IN THE AISLE THAT THE PRODUCT IS IN

    Sub subFindFarthestProductInAisle()
        'we need to begin by assuming there are no products in the aisle
        FarthestProduct = 0

        'intProductIndex is the row in the database
        Dim intProductIndex As Integer = 0

        'while the row is still a product in the table
        While intProductIndex < frmDatabase.dataProducts.RowCount - 1

            'if the product as in the aisle and is farther than the farthest product in the aisle, the new farthest product in the aisle will be set the the position of the product at inex intProductIndex
            If frmDatabase.dataProducts.Rows(intProductIndex).Cells("AisleNumber").Value = frmDatabase.dataProducts.Rows(intRowIndex).Cells("AisleNumber").Value And frmDatabase.dataProducts.Rows(intProductIndex).Cells("AislePosition").Value > FarthestProduct Then
                FarthestProduct = frmDatabase.dataProducts.Rows(intProductIndex).Cells("AislePosition").Value
            End If
            'goes to the next row
            intProductIndex += 1

        End While
    End Sub

    '//DRAWING THE LINE ON THE MAP FROM STARTING POINT TO LOCATION OF PRODUCT

    Private Sub picMap_paint(sender As Object, e As PaintEventArgs) Handles picMap.Paint
        'the pen lines becomes a dash to go with the theme of the officeworks logo
        pen.DashStyle = Drawing2D.DashStyle.Dash

        'the thickness of the line is set to the sam,e width of the officeworks logo
        pen.Width = 3.0F

        'x(3) is an array of x-coordinate points used when drawing the lines to the product. Number 3 is chosen as the maximum number of turns is 4.
        Dim x(3) As Integer

        'y(3) is an array of y-coordinate points used when drawing the lines to the product. Number 3 is chosen as the maximum number of turns is 4.
        Dim y(3) As Integer

        'this grabs the farthest product in the aisle
        subFindFarthestProductInAisle()

        'POINT 1 is always at the entrance of the store
        x(0) = 258
        y(0) = 524

        'intHighestIndex is the number of points required
        Dim intHighestIndex As Integer = 0

        'boolAisleDoesExist determines whether the written Aisle in the database exists or not
        Dim boolAisleDoesExist As Boolean = False

        'because the default index is -1, I needed to set it greater or equal to zero otherwise an out of bounds error would occur
        If listFound.SelectedIndex >= 0 Then

            'AisleName is the name of the Aisle as a string. This includes Integers, Characters and Strings. I needed to convert to string as there is an error when using the data type OBJECT. It refuses to accept multiple data types causing the program to crash.
            Dim AisleName As String = frmDatabase.dataProducts.Rows(intRowIndex).Cells("AisleNumber").Value.ToString

            'strNumberAisles is an array of all the NUMBER Aisles
            Dim strNumberAisles As String() = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"}

            'strLetterAisles is an array of all the LETTER Aisles
            Dim strLetterAisles As String() = {"A", "B", "C", "D", "E", "F", "G", "H"}

            'If the AisleName is a NUMBER aisle
            If strNumberAisles.Contains(AisleName) Then

                'As the aisle type exists, boolAisleDoesExist is set to true
                boolAisleDoesExist = True

                'POINT 2
                x(1) = x(0)
                y(1) = frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePixel").Value

                'POINT 3
                'This algorithm positions the final line to the position within the aisle. This is used in later code with different values.
                x(2) = x(1) - (172 / FarthestProduct * frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePosition").Value + 31)
                y(2) = y(1)
                intHighestIndex = 2

                'If the AisleName is a LETTER aisle
            ElseIf strLetterAisles.Contains(AisleName.ToUpper) Then

                'As the aisle type exists, boolAisleDoesExist is set to true
                boolAisleDoesExist = True

                'POINT 2
                x(1) = x(0)
                y(1) = frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePixel").Value

                'POINT 3
                x(2) = x(1) + (172 / FarthestProduct * frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePosition").Value + 25)
                y(2) = y(1)
                intHighestIndex = 2

                'If the AisleName is a called LEFT WALL
            ElseIf AisleName.ToUpper = "Left Wall".ToUpper Then

                'As the aisle type exists, boolAisleDoesExist is set to true
                boolAisleDoesExist = True

                'POINT 2
                x(1) = x(0)
                y(1) = 519

                'POINT 3
                x(2) = frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePixel").Value
                y(2) = y(1)

                'POINT 4
                x(3) = x(2)
                y(3) = 473 / FarthestProduct * frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePosition").Value
                intHighestIndex = 3

                'If the AisleName is a called REAR WALL
            ElseIf AisleName.ToUpper = "Rear Wall".ToUpper Then

                'As the aisle type exists, boolAisleDoesExist is set to true
                boolAisleDoesExist = True

                'POINT 2
                x(1) = x(0)
                y(1) = frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePixel").Value

                'POINT 3
                x(2) = 459 / FarthestProduct * frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePosition").Value
                y(2) = y(1)
                intHighestIndex = 2

                'If the AisleName is a called RIGHT WALL
            ElseIf AisleName.ToUpper = "Right Wall".ToUpper Then

                'As the aisle type exists, boolAisleDoesExist is set to true
                boolAisleDoesExist = True

                'POINT 2
                x(1) = x(0)
                y(1) = 388

                'POINT 3
                x(2) = frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePixel").Value
                y(2) = y(1)

                'POINT 4
                x(3) = x(2)
                y(3) = 443 / FarthestProduct * frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePosition").Value
                intHighestIndex = 3

                'If the AisleName is a called FURNITURE
            ElseIf AisleName.ToUpper = "Furniture".ToUpper Then

                'As the aisle type exists, boolAisleDoesExist is set to true
                boolAisleDoesExist = True

                'POINT 2
                x(1) = x(0)
                y(1) = frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePixel").Value

                'POINT 3
                x(2) = 370
                y(2) = y(1)
                intHighestIndex = 2
            End If
            If boolAisleDoesExist = True Then
                'Draws a line from POINT 1 to POINT 2
                e.Graphics.DrawLine(pen, x(0), y(0), x(1), y(1))

                'Draws a line from POINT 2 to POINT 3
                e.Graphics.DrawLine(pen, x(1), y(1), x(2), y(2))

                If intHighestIndex = 3 Then
                    'Draws a line from POINT 3 to POINT 4 when it exists
                    e.Graphics.DrawLine(pen, x(2), y(2), x(3), y(3))
                End If

                'places the officeworks pin at the destination of the prduct
                picPin.Location = New Point(x(intHighestIndex) - 79 * picPin.Width / 279, y(intHighestIndex) - (picPin.Height - 2))
            End If
            'if the product aisle is not one of the above prerequisities for whatever reason, a messagebox will warn the user that there is an error and the product cannot be located
            If boolAisleDoesExist = False Then
                MsgBox("I'm sorry, this product cannot be located right now. Please contact your administrator.", MessageBoxIcon.Error)
            End If
        End If


    End Sub

    '//WHEN THE MAIN FORM LOADS

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'as no product has been selected, the label does not write anything
        lblLocation.Text = ""

        'configuring color schemes
        menuFrmMain.BackColor = Color.FromArgb(12, 93, 172)
        menuFrmMain.ForeColor = Color.White

        'only lets the pin be seen on the map
        picPin.Parent = picMap
        'removes white color around the pin
        picPin.BackColor = Color.Transparent

        'configuring color schemes
        lblLocation.BackColor = Color.FromArgb(12, 93, 172)
        lblLocation.ForeColor = Color.White

        'Data is imported into the dataTable
        databaseLoad()

        'shows the list of all the products before the user has searched for anything
        importCategories()
    End Sub

    '//LOADS ALL CATEGORIES INTO LISTBOX

    Sub importCategories()
        'clears the listbox to avoid duplicates
        listFound.Items.Clear()

        'The form will load will all of the categories in the in the list box. This way the user can still find things by scrolling without needing to search as they may not know
        intRowIndex = 0

        'for each product in the table, it will be added to the listbox
        While intRowIndex < frmDatabase.dataProducts.RowCount - 1
            listFound.Items.Add(frmDatabase.dataProducts.Rows(intRowIndex).Cells("CategoryName").Value)
            intRowIndex += 1
        End While
    End Sub


    '//IMPORTS CSV DATABASE INTO PRODUCT TABLE WITHIN THE FORM

    Private Sub databaseLoad()
        '//Code sourced from Mr. Bonfadini
        'This is the directory of the CSV file
        Dim ResourceFilePath As String

        ResourceFilePath = Application.StartupPath & "\..\..\resources\OfficeworksData.csv"

        'Counts the number of lines in the file
        Dim lineCount = File.ReadAllLines(ResourceFilePath).Length

        'Streamreader for opening the file, reading and closing
        Dim objStreamReader As StreamReader

        'strline is the array of words for a particular row at intRowIndex
        Dim strLine As String()

        'intRowIndex is set to 0 to import every line from the csv file
        intRowIndex = 0

        'The CSV file is opened so it can be read
        objStreamReader = New StreamReader(ResourceFilePath)

        'For each line in the CSV file
        While frmDatabase.dataProducts.RowCount <= lineCount
            'A row needs to be added for every row of the csv file so that data can be imported into it
            frmDatabase.dataProducts.Rows.Add(1)

            'The row is divided into an array of strings,m seperated by commas
            strLine = objStreamReader.ReadLine.Split(",")

            'This imports the data into the CSV file
            frmDatabase.dataProducts.Rows(intRowIndex).Cells("CategoryName").Value = strLine(0)
            frmDatabase.dataProducts.Rows(intRowIndex).Cells("AisleNumber").Value = strLine(1)
            frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePixel").Value = strLine(2)
            frmDatabase.dataProducts.Rows(intRowIndex).Cells("AislePosition").Value = strLine(3)

            'Goes to the next row
            intRowIndex += 1
        End While
        'To avoid corruption, the file must be closed again
        objStreamReader.Close()

    End Sub

    '//IMPORTS CSV PASSWORDS INTO PASSWORD TABLE WITHIN THE FORM

    Sub frmPasswordsLoad()
        '//Code sourced from Mr. Bonfadini

        'This is the directory of the CSV file
        Dim ResourceFilePath As String

        ResourceFilePath = Application.StartupPath & "\..\..\resources\OfficeworksPasswords.csv"

        'Counts the number of lines in the file
        Dim lineCount = File.ReadAllLines(ResourceFilePath).Length

        'Streamreader for opening the file, reading and closing
        Dim objStreamReader As StreamReader

        'strline is the array of words for a particular row at intRowIndex
        Dim strLine As String()

        'intRowIndex is set to 0 to import every line from the csv file
        intRowIndex = 0

        'The CSV file is opened so it can be read
        objStreamReader = New StreamReader(ResourceFilePath)

        'For each line in the CSV file
        While frmPasswords.dataPasswords.RowCount <= lineCount
            'A row needs to be added for every row of the csv file so that data can be imported into it
            frmPasswords.dataPasswords.Rows.Add(1)

            'The row is divided into an array of strings,m seperated by commas
            strLine = objStreamReader.ReadLine.Split(",")

            'This imports the data from the csv file into the dataviewgrid
            frmPasswords.dataPasswords.Rows(intRowIndex).Cells("EmployeeName").Value = strLine(0)
            frmPasswords.dataPasswords.Rows(intRowIndex).Cells("EmployeePassword").Value = strLine(1)
            frmPasswords.dataPasswords.Rows(intRowIndex).Cells("DatabasePrivelages").Value = strLine(2)
            frmPasswords.dataPasswords.Rows(intRowIndex).Cells("PasswordPrivelages").Value = strLine(3)

            'Goes to the next row
            intRowIndex += 1
        End While
        'To avoid corruption, the file must be closed again
        objStreamReader.Close()
    End Sub


    '//CLOSES ALL OTHER FORMS WHEN THE USER CLOSES THE MAIN FORM

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    '//IMPORTS DATA BACK INTO DATABASE WHEN IT IS REOPENED

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    '//RESTARTS THE PROGRAM

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        'restarts the application, effectively turning back to the login screen and restting all variables etc.
        Application.Restart()
    End Sub

    '//OPENS EDIT PASSWORD FORM

    Private Sub EditPasswordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPasswordsToolStripMenuItem.Click
        frmPasswords.Show()
        frmPasswordsLoad()
        EditPasswordsToolStripMenuItem.Enabled = False
    End Sub

    'OPENS EDIT DATABASE FORM

    Private Sub OpenDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDatabaseToolStripMenuItem.Click
        databaseLoad()
        frmDatabase.Show()
        OpenDatabaseToolStripMenuItem.Enabled = False
    End Sub
End Class

