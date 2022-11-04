'Author: Matthew Coulter
'Date: 8/20/2018

'//THIS FORM IS THE STARTUP FORM WHERE THE USER CHOOSES WHETHER THEY ARE AN EMPLOYEE OR A CUSTOMER TO PROCEED THEM TO THE NEXT SPOT
Public Class frmLogin

    '// WHEN THE USER CHOOSES THEY ARE AN EMPLOYEE

    Private Sub btnEmployee_click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Dim boolFound As Boolean = False
        frmEnterPassword.Show()
        Me.Enabled = False
    End Sub

    '//WHEN THEY CHOOSES THEY ARE A CUSTOMER

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Hide()
        frmMain.Show()
    End Sub

    '//WHEN THE APPLICATION STARTS

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Configures colours
        btnEmployee.BackColor = Color.FromArgb(12, 93, 172)
        btnCustomer.BackColor = Color.FromArgb(12, 93, 172)

        'configures colours
        btnEmployee.ForeColor = Color.White
        btnCustomer.ForeColor = Color.White

        'puts passwords into the password form so the user can login based off of those passwords
        frmMain.frmPasswordsLoad()
    End Sub

    'WHEN THE QUITS THE APPLICATION

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'closes the application
        Close()
    End Sub
    'Moving the database form by clicking on the frorm was found on: https://stackoverflow.com/questions/24449543/how-to-move-form-without-form-border-visual-studio

    'drag determines whether the user is holding their mouse on the forma nd trying to move it around
    Dim drag As Boolean

    'mousex is the x-coordinate of where the mouse is
    Dim mousex As Integer

    'mousey is the y-coordinate of where the mouse is
    Dim mousey As Integer

    '//WHEN THE USER CLICKS AND HOLDS DOWN ON THE MAIN FORM

    Private Sub frmLogin_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        'Sets the variable drag to true.
        drag = True

        'Sets variable mousex
        mousex = Cursor.Position.X - Left

        'Sets variable mousey
        mousey = Cursor.Position.Y - Top
    End Sub

    '//WHEN THE USER MOVES THEIR MOUSE WHILST STILL HOLDIONG DOWN

    Private Sub frmLogin_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            'because coordinates would orientate the top left of the from the where the mouse is, these calculations needs to be made to avoid that, and move it relative to where the mouse is on the form
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    '//WHEN THE USER RELEASES THEIR FINGER FROM HOLDING DOWN ON THE FORM

    Private Sub frmLogin_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseUp
        'Sets drag to false, so the form does not move according to the code in MouseMove
        drag = False
    End Sub
End Class