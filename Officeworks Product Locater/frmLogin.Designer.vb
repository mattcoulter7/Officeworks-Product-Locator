<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.tipCustomer = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipEmployee = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipfrmLogin = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEmployee
        '
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployee.Font = New System.Drawing.Font("qtquickcontrols", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.Location = New System.Drawing.Point(174, 255)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(330, 43)
        Me.btnEmployee.TabIndex = 1
        Me.btnEmployee.Text = "I am an Employee"
        Me.tipEmployee.SetToolTip(Me.btnEmployee, "Click here if you work here")
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Officeworks_Product_Locater.My.Resources.Resources.BrandLogo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(704, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(704, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        Me.FileToolStripMenuItem.ToolTipText = "Click here for a drop down of menus. Here you will be able to quite your program." &
    " Look out for other features that may be addded here in the future."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnCustomer
        '
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("qtquickcontrols", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.Location = New System.Drawing.Point(174, 191)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(330, 43)
        Me.btnCustomer.TabIndex = 2
        Me.btnCustomer.Text = "I am a Customer"
        Me.tipCustomer.SetToolTip(Me.btnCustomer, "Click here if you are a customer")
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'tipCustomer
        '
        Me.tipCustomer.ToolTipTitle = "I am a Customer"
        '
        'tipEmployee
        '
        Me.tipEmployee.ToolTipTitle = "I am an Employee"
        '
        'tipfrmLogin
        '
        Me.tipfrmLogin.ToolTipTitle = "Drag"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 358)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.tipfrmLogin.SetToolTip(Me, "Click and hold then drag to move form around.")
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEmployee As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCustomer As Button
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tipEmployee As ToolTip
    Friend WithEvents tipCustomer As ToolTip
    Friend WithEvents tipfrmLogin As ToolTip
End Class
