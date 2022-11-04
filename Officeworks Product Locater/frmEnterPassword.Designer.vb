<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmEnterPassword
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
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtEnterPassword As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtEnterPassword = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.tiptxtEnterPassword = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipOK = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipCancel = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipfrmEnterPassword = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(11, 12)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEnterPassword
        '
        Me.txtEnterPassword.Location = New System.Drawing.Point(13, 32)
        Me.txtEnterPassword.Name = "txtEnterPassword"
        Me.txtEnterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEnterPassword.Size = New System.Drawing.Size(220, 20)
        Me.txtEnterPassword.TabIndex = 3
        Me.tiptxtEnterPassword.SetToolTip(Me.txtEnterPassword, "Enter your password within this box. If you don't know your password, you probabl" &
        "y don't work here, or you forgot it. If that is the case, please contact your ad" &
        "ministrator.")
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(24, 58)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        Me.tipOK.SetToolTip(Me.OK, "Click here to login after you have entered your password")
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(127, 58)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        Me.tipfrmEnterPassword.SetToolTip(Me.Cancel, "Cancel entering your password")
        '
        'tiptxtEnterPassword
        '
        Me.tiptxtEnterPassword.Tag = "Enter Password Here"
        Me.tiptxtEnterPassword.ToolTipTitle = "Enter Password"
        '
        'tipOK
        '
        Me.tipOK.ToolTipTitle = "OK"
        '
        'tipCancel
        '
        Me.tipCancel.ToolTipTitle = "Cencel"
        '
        'tipfrmEnterPassword
        '
        Me.tipfrmEnterPassword.ToolTipTitle = "Drag"
        '
        'frmEnterPassword
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(248, 101)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtEnterPassword)
        Me.Controls.Add(Me.PasswordLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEnterPassword"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LoginForm1"
        Me.tipfrmEnterPassword.SetToolTip(Me, "Click and hold then drag to move form around.")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tiptxtEnterPassword As ToolTip
    Friend WithEvents tipOK As ToolTip
    Friend WithEvents tipCancel As ToolTip
    Friend WithEvents tipfrmEnterPassword As ToolTip
End Class
