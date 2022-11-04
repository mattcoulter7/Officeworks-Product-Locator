'Author: Matthew Coulter
'Date: 8/20/2018

'//THIS FORM IS WHERE THE USER ENTERS IN THE PASSWORD

Public Class frmEnterPassword
    'int rowindex is the row in the passwords datatable
    Dim intRowIndex As Integer

    'boolFound is whether a password has been found
    Dim boolFound As Boolean

    'boolErrorOccurred is when the software cannot interpret whether the user has privelages to open databases or not
    Dim boolErrorOccurred As Boolean

    'intNumberOfTrys counts how many incorrect attempts the user has made when entering in their password
    Dim intNumberOfTrys As Integer = 0

    '//WHEN THE USER SUBMITS THEIR PASSWORD

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'starts with the first password in the password database
        intRowIndex = 0

        'for each of the passwords in the database table, it check the input to match any of the passwords
        While Not boolFound And intRowIndex < frmPasswords.dataPasswords.Rows.Count - 1

            'if the password is a match
            If txtEnterPassword.Text = frmPasswords.dataPasswords.Rows(intRowIndex).Cells("EmployeePassword").Value Then

                'the password has been found
                boolFound = True

                'the main for  is shown
                frmMain.Show()

                'the enterpassword form is hidden
                Hide()

                'the login form is hidden
                frmLogin.Hide()

                'if the user has database privelages
                If frmPasswords.dataPasswords.Rows(intRowIndex).Cells("DatabasePrivelages").Value.tolower = "TRUE".ToLower Then

                    'the button to open the database will be visible
                    frmMain.OpenDatabaseToolStripMenuItem.Visible = True

                ElseIf frmPasswords.dataPasswords.Rows(intRowIndex).Cells("DatabasePrivelages").Value.tolower = "FALSE".ToLower Then

                    'the button to open the database won't be visible
                    frmMain.OpenDatabaseToolStripMenuItem.Visible = False

                Else
                    MsgBox("Error checking account privelages. Please contact your administrator.", MessageBoxIcon.Error)
                    'is necessary to avoid duplicate of messages
                    boolErrorOccurred = True
                End If

                'if the user has database privelages
                If frmPasswords.dataPasswords.Rows(intRowIndex).Cells("PasswordPrivelages").Value.tolower = "TRUE".ToLower Then

                    'the button to open the password database will be visible
                    frmMain.EditPasswordsToolStripMenuItem.Visible = True

                ElseIf frmPasswords.dataPasswords.Rows(intRowIndex).Cells("PasswordPrivelages").Value.tolower = "FALSE".ToLower Then

                    'the button to open the password database won't be visible
                    frmMain.EditPasswordsToolStripMenuItem.Visible = False
                Else

                    'to avoid the same message appearing twice, if the first one hasn't appeared then the second one will appear otherwise the second one won't appear
                    If Not boolErrorOccurred Then
                        MsgBox("Error reading password privelages. Please contact your administrator", MessageBoxIcon.Error)
                    End If

                End If
            End If
            'goes to the next password
            intRowIndex += 1

        End While

        'if the password isn't found, they can try 4 more times
        If Not boolFound Then
            If intNumberOfTrys < 5 Then
                MsgBox("Password is incorrect. Please try again.", MessageBoxIcon.Warning)
                txtEnterPassword.Text = ""
                intNumberOfTrys += 1
            Else
                MsgBox("You have had too many incorrect attempts. Please contact your administrator.", MessageBoxIcon.Hand)
                Application.Exit()
            End If
        End If
    End Sub

    '//WHEN THE USER EXITS THE ETNERPASSWORD FORM

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'reenables the startup form
        frmLogin.Enabled = True

        'hides the enter password form
        Hide()
    End Sub
    'Moving the database form by clicking on the frorm was found on: https://stackoverflow.com/questions/24449543/how-to-move-form-without-form-border-visual-studio

    'drag determines whether the user is holding their mouse on the forma nd trying to move it around
    Dim drag As Boolean

    'mousex is the x-coordinate of where the mouse is
    Dim mousex As Integer

    'mousey is the y-coordinate of where the mouse is
    Dim mousey As Integer

    '//WHEN THE USER CLICKS AND HOLDS DOWN ON THE MAIN FORM

    Private Sub frmEnterPassword_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        'Sets the variable drag to true.
        drag = True

        'Sets variable mousex
        mousex = Cursor.Position.X - Left

        'Sets variable mousey
        mousey = Cursor.Position.Y - Top
    End Sub

    '//WHEN THE USER MOVES THEIR MOUSE WHILST STILL HOLDIONG DOWN

    Private Sub frmEnterPassword_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            'because coordinates would orientate the top left of the from the where the mouse is, these calculations needs to be made to avoid that, and move it relative to where the mouse is on the form
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    '//WHEN THE USER RELEASES THEIR FINGER FROM HOLDING DOWN ON THE FORM

    Private Sub frmEnterPassword_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseUp
        'Sets drag to false, so the form does not move according to the code in MouseMove
        drag = False
    End Sub
End Class
