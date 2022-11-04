<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabase
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dataProducts = New System.Windows.Forms.DataGridView()
        Me.CategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AisleNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AislePixel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AislePosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddRow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tipbtnSave = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipbtnRefresh = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipbtnAddRow = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipbtnClose = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipdataProducts = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipfrmPasswords = New System.Windows.Forms.ToolTip(Me.components)
        Me.progSaving = New System.Windows.Forms.ProgressBar()
        CType(Me.dataProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(507, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(161, 61)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save Database"
        Me.tipbtnSave.SetToolTip(Me.btnSave, "Click here to save any changes. Any changes that are made without saving will be " &
        "lost.")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dataProducts
        '
        Me.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryName, Me.AisleNumber, Me.AislePixel, Me.AislePosition})
        Me.dataProducts.Location = New System.Drawing.Point(2, 1)
        Me.dataProducts.Name = "dataProducts"
        Me.dataProducts.Size = New System.Drawing.Size(463, 679)
        Me.dataProducts.TabIndex = 0
        Me.tipdataProducts.SetToolTip(Me.dataProducts, "Double click on a cell to edit it. The cell cannot be empty and needs to follow t" &
        "he format of other cell data in the same column.")
        '
        'CategoryName
        '
        Me.CategoryName.HeaderText = "Category Name"
        Me.CategoryName.Name = "CategoryName"
        '
        'AisleNumber
        '
        Me.AisleNumber.HeaderText = "Aisle Number"
        Me.AisleNumber.Name = "AisleNumber"
        '
        'AislePixel
        '
        Me.AislePixel.HeaderText = "Aisle Pixel"
        Me.AislePixel.Name = "AislePixel"
        '
        'AislePosition
        '
        Me.AislePosition.HeaderText = "AislePosition"
        Me.AislePosition.Name = "AislePosition"
        '
        'btnAddRow
        '
        Me.btnAddRow.Location = New System.Drawing.Point(507, 79)
        Me.btnAddRow.Name = "btnAddRow"
        Me.btnAddRow.Size = New System.Drawing.Size(161, 61)
        Me.btnAddRow.TabIndex = 5
        Me.btnAddRow.Text = "Add Row"
        Me.tipbtnAddRow.SetToolTip(Me.btnAddRow, "Click to add row to table." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnAddRow.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(507, 599)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(161, 61)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.tipbtnClose.SetToolTip(Me.btnClose, "Click to close this window.")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tipbtnSave
        '
        Me.tipbtnSave.ToolTipTitle = "Save"
        '
        'tipbtnRefresh
        '
        Me.tipbtnRefresh.ToolTipTitle = "Refresh"
        '
        'tipbtnAddRow
        '
        Me.tipbtnAddRow.ToolTipTitle = "Add Row"
        '
        'tipbtnClose
        '
        Me.tipbtnClose.ToolTipTitle = "Close"
        '
        'tipdataProducts
        '
        Me.tipdataProducts.ToolTipTitle = "Edit Database"
        '
        'tipfrmPasswords
        '
        Me.tipfrmPasswords.ToolTipTitle = "Drag"
        '
        'progSaving
        '
        Me.progSaving.Location = New System.Drawing.Point(507, 12)
        Me.progSaving.Maximum = 0
        Me.progSaving.Name = "progSaving"
        Me.progSaving.Size = New System.Drawing.Size(161, 61)
        Me.progSaving.TabIndex = 7
        Me.progSaving.Visible = False
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 681)
        Me.Controls.Add(Me.progSaving)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddRow)
        Me.Controls.Add(Me.dataProducts)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatabase"
        Me.Text = "Database"
        Me.tipfrmPasswords.SetToolTip(Me, "Click and hold then drag to move form around.")
        CType(Me.dataProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents dataProducts As DataGridView
    Friend WithEvents CategoryName As DataGridViewTextBoxColumn
    Friend WithEvents AisleNumber As DataGridViewTextBoxColumn
    Friend WithEvents AislePixel As DataGridViewTextBoxColumn
    Friend WithEvents AislePosition As DataGridViewTextBoxColumn
    Friend WithEvents btnAddRow As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents tipbtnSave As ToolTip
    Friend WithEvents tipbtnRefresh As ToolTip
    Friend WithEvents tipdataProducts As ToolTip
    Friend WithEvents tipbtnAddRow As ToolTip
    Friend WithEvents tipbtnClose As ToolTip
    Friend WithEvents tipfrmPasswords As ToolTip
    Friend WithEvents progSaving As ProgressBar
End Class
