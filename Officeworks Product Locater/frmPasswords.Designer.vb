<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPasswords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dataPasswords = New System.Windows.Forms.DataGridView()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatabasePrivelages = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordPrivelages = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddRow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tipbtnSaveDatabase = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipbtnRefreshDatabase = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipbtnAddRow = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipbtnClose = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipfrmPasswords = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipdataPasswords = New System.Windows.Forms.ToolTip(Me.components)
        Me.progSaving = New System.Windows.Forms.ProgressBar()
        CType(Me.dataPasswords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataPasswords
        '
        Me.dataPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataPasswords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeName, Me.EmployeePassword, Me.DatabasePrivelages, Me.PasswordPrivelages})
        Me.dataPasswords.Location = New System.Drawing.Point(1, 1)
        Me.dataPasswords.Name = "dataPasswords"
        Me.dataPasswords.Size = New System.Drawing.Size(463, 679)
        Me.dataPasswords.TabIndex = 6
        Me.tipdataPasswords.SetToolTip(Me.dataPasswords, "Double click on a cell to edit it. The cell cannot be empty and needs to follow t" &
        "he format of other cell data in the same column.")
        '
        'EmployeeName
        '
        Me.EmployeeName.HeaderText = "Employee Name"
        Me.EmployeeName.Name = "EmployeeName"
        '
        'EmployeePassword
        '
        Me.EmployeePassword.HeaderText = "Employee Password"
        Me.EmployeePassword.Name = "EmployeePassword"
        '
        'DatabasePrivelages
        '
        Me.DatabasePrivelages.HeaderText = "Database Privelages"
        Me.DatabasePrivelages.Name = "DatabasePrivelages"
        '
        'PasswordPrivelages
        '
        Me.PasswordPrivelages.HeaderText = "Password Privelages"
        Me.PasswordPrivelages.Name = "PasswordPrivelages"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(506, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(161, 61)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save Database"
        Me.tipbtnSaveDatabase.SetToolTip(Me.btnSave, "Click here to save any changes. Any changes that are made without saving will be " &
        "lost.")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddRow
        '
        Me.btnAddRow.Location = New System.Drawing.Point(506, 79)
        Me.btnAddRow.Name = "btnAddRow"
        Me.btnAddRow.Size = New System.Drawing.Size(161, 61)
        Me.btnAddRow.TabIndex = 10
        Me.btnAddRow.Text = "Add Row"
        Me.tipbtnAddRow.SetToolTip(Me.btnAddRow, "Click to add row to table.")
        Me.btnAddRow.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(506, 608)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(161, 61)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.tipbtnClose.SetToolTip(Me.btnClose, "Click to close this window.")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tipbtnSaveDatabase
        '
        Me.tipbtnSaveDatabase.ToolTipTitle = "Save Database"
        '
        'tipbtnRefreshDatabase
        '
        Me.tipbtnRefreshDatabase.ToolTipTitle = "Refresh Database"
        '
        'tipbtnAddRow
        '
        Me.tipbtnAddRow.ToolTipTitle = "Add Row"
        '
        'tipbtnClose
        '
        Me.tipbtnClose.ToolTipTitle = "Close the form"
        '
        'tipfrmPasswords
        '
        Me.tipfrmPasswords.ToolTipTitle = "Drag"
        '
        'tipdataPasswords
        '
        Me.tipdataPasswords.ToolTipTitle = "Edit cells"
        '
        'progSaving
        '
        Me.progSaving.Location = New System.Drawing.Point(506, 12)
        Me.progSaving.Maximum = 0
        Me.progSaving.Name = "progSaving"
        Me.progSaving.Size = New System.Drawing.Size(161, 61)
        Me.progSaving.TabIndex = 12
        Me.progSaving.Visible = False
        '
        'frmPasswords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 681)
        Me.Controls.Add(Me.progSaving)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dataPasswords)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddRow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPasswords"
        Me.Text = "frmPasswords"
        Me.tipfrmPasswords.SetToolTip(Me, "Click and hold then drag to move form around.")
        CType(Me.dataPasswords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dataPasswords As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAddRow As Button
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents EmployeePassword As DataGridViewTextBoxColumn
    Friend WithEvents DatabasePrivelages As DataGridViewTextBoxColumn
    Friend WithEvents PasswordPrivelages As DataGridViewTextBoxColumn
    Friend WithEvents btnClose As Button
    Friend WithEvents tipbtnSaveDatabase As ToolTip
    Friend WithEvents tipbtnRefreshDatabase As ToolTip
    Friend WithEvents tipbtnAddRow As ToolTip
    Friend WithEvents tipbtnClose As ToolTip
    Friend WithEvents tipfrmPasswords As ToolTip
    Friend WithEvents tipdataPasswords As ToolTip
    Friend WithEvents progSaving As ProgressBar
End Class
