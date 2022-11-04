<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.webOfficeworksWebsite = New System.Windows.Forms.WebBrowser()
        Me.listFound = New System.Windows.Forms.ListBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.menuFrmMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPasswordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.picPin = New System.Windows.Forms.PictureBox()
        Me.picMap = New System.Windows.Forms.PictureBox()
        Me.picHeader = New System.Windows.Forms.PictureBox()
        Me.tiptxtSearch = New System.Windows.Forms.ToolTip(Me.components)
        Me.tiplistFound = New System.Windows.Forms.ToolTip(Me.components)
        Me.tippicMap = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipBrowser = New System.Windows.Forms.ToolTip(Me.components)
        Me.tiplblLocation = New System.Windows.Forms.ToolTip(Me.components)
        Me.menuFrmMain.SuspendLayout()
        CType(Me.picPin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSearch.Location = New System.Drawing.Point(31, 75)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(732, 40)
        Me.txtSearch.TabIndex = 0
        Me.tiptxtSearch.SetToolTip(Me.txtSearch, "Here you can search for different categories at Officeworks, and find what you ar" &
        "e looking for")
        '
        'webOfficeworksWebsite
        '
        Me.webOfficeworksWebsite.Location = New System.Drawing.Point(749, 149)
        Me.webOfficeworksWebsite.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webOfficeworksWebsite.Name = "webOfficeworksWebsite"
        Me.webOfficeworksWebsite.ScriptErrorsSuppressed = True
        Me.webOfficeworksWebsite.Size = New System.Drawing.Size(514, 524)
        Me.webOfficeworksWebsite.TabIndex = 1
        Me.tipBrowser.SetToolTip(Me.webOfficeworksWebsite, resources.GetString("webOfficeworksWebsite.ToolTip"))
        Me.webOfficeworksWebsite.Url = New System.Uri("https://www.officeworks.com.au/", System.UriKind.Absolute)
        '
        'listFound
        '
        Me.listFound.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.listFound.FormattingEnabled = True
        Me.listFound.ItemHeight = 20
        Me.listFound.Location = New System.Drawing.Point(1, 149)
        Me.listFound.Name = "listFound"
        Me.listFound.Size = New System.Drawing.Size(212, 524)
        Me.listFound.TabIndex = 5
        Me.tiplistFound.SetToolTip(Me.listFound, "Click from the following to display the location of where it is on the map")
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(26, 117)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(86, 29)
        Me.lblLocation.TabIndex = 0
        Me.lblLocation.Text = "Label1"
        Me.tiplblLocation.SetToolTip(Me.lblLocation, "Here is a written version of where the product category is")
        '
        'menuFrmMain
        '
        Me.menuFrmMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.menuFrmMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.menuFrmMain.Location = New System.Drawing.Point(0, 0)
        Me.menuFrmMain.Name = "menuFrmMain"
        Me.menuFrmMain.Size = New System.Drawing.Size(1264, 24)
        Me.menuFrmMain.TabIndex = 12
        Me.menuFrmMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditPasswordsToolStripMenuItem, Me.OpenDatabaseToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EditPasswordsToolStripMenuItem
        '
        Me.EditPasswordsToolStripMenuItem.Name = "EditPasswordsToolStripMenuItem"
        Me.EditPasswordsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.EditPasswordsToolStripMenuItem.Text = "Edit Passwords"
        Me.EditPasswordsToolStripMenuItem.Visible = False
        '
        'OpenDatabaseToolStripMenuItem
        '
        Me.OpenDatabaseToolStripMenuItem.Name = "OpenDatabaseToolStripMenuItem"
        Me.OpenDatabaseToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.OpenDatabaseToolStripMenuItem.Text = "Open Database"
        Me.OpenDatabaseToolStripMenuItem.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Officeworks Pin.png")
        '
        'picPin
        '
        Me.picPin.Image = Global.Officeworks_Product_Locater.My.Resources.Resources.Officeworks_Pin
        Me.picPin.Location = New System.Drawing.Point(773, 63)
        Me.picPin.Margin = New System.Windows.Forms.Padding(2)
        Me.picPin.Name = "picPin"
        Me.picPin.Size = New System.Drawing.Size(45, 75)
        Me.picPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPin.TabIndex = 14
        Me.picPin.TabStop = False
        '
        'picMap
        '
        Me.picMap.Image = Global.Officeworks_Product_Locater.My.Resources.Resources.StoreMap
        Me.picMap.Location = New System.Drawing.Point(213, 149)
        Me.picMap.Name = "picMap"
        Me.picMap.Size = New System.Drawing.Size(537, 524)
        Me.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMap.TabIndex = 0
        Me.picMap.TabStop = False
        Me.tippicMap.SetToolTip(Me.picMap, "This displays where the location is within the store. The red dotted line is the " &
        "path to get to there from the enterance of the store. The pin is the destination" &
        ".")
        '
        'picHeader
        '
        Me.picHeader.Image = Global.Officeworks_Product_Locater.My.Resources.Resources.Header1
        Me.picHeader.Location = New System.Drawing.Point(0, 22)
        Me.picHeader.Name = "picHeader"
        Me.picHeader.Size = New System.Drawing.Size(1263, 130)
        Me.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeader.TabIndex = 11
        Me.picHeader.TabStop = False
        '
        'tiptxtSearch
        '
        Me.tiptxtSearch.ToolTipTitle = "Search"
        '
        'tiplistFound
        '
        Me.tiplistFound.ToolTipTitle = "Found Categories"
        '
        'tippicMap
        '
        Me.tippicMap.ToolTipTitle = "Map"
        '
        'tipBrowser
        '
        Me.tipBrowser.ToolTipTitle = "Browse"
        '
        'tiplblLocation
        '
        Me.tiplblLocation.ToolTipTitle = "Written Location"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 674)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.picPin)
        Me.Controls.Add(Me.picMap)
        Me.Controls.Add(Me.webOfficeworksWebsite)
        Me.Controls.Add(Me.listFound)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.menuFrmMain)
        Me.Controls.Add(Me.picHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.menuFrmMain
        Me.Name = "frmMain"
        Me.Text = "Officeworks Product Locater"
        Me.menuFrmMain.ResumeLayout(False)
        Me.menuFrmMain.PerformLayout()
        CType(Me.picPin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents listFound As ListBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents webOfficeworksWebsite As WebBrowser
    Friend WithEvents picHeader As PictureBox
    Friend WithEvents menuFrmMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picMap As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents picPin As PictureBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPasswordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tiptxtSearch As ToolTip
    Friend WithEvents tipBrowser As ToolTip
    Friend WithEvents tiplistFound As ToolTip
    Friend WithEvents tiplblLocation As ToolTip
    Friend WithEvents tippicMap As ToolTip
End Class
