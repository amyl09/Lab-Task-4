<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class author
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(author))
        Me.AuthorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SRSDataSet4 = New SoftwareRespositorySystem.SRSDataSet4()
        Me.AuthorTableAdapter = New SoftwareRespositorySystem.SRSDataSet4TableAdapters.authorTableAdapter()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridViewAuthor = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtAuthorName = New System.Windows.Forms.TextBox()
        Me.txtAuthorId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CRUDSoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnInnerJoin = New System.Windows.Forms.Button()
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRSDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewAuthor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuthorBindingSource
        '
        Me.AuthorBindingSource.DataMember = "author"
        Me.AuthorBindingSource.DataSource = Me.SRSDataSet4
        '
        'SRSDataSet4
        '
        Me.SRSDataSet4.DataSetName = "SRSDataSet4"
        Me.SRSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuthorTableAdapter
        '
        Me.AuthorTableAdapter.ClearBeforeFill = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnAdd.Location = New System.Drawing.Point(610, 43)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 38)
        Me.btnAdd.TabIndex = 63
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'DataGridViewAuthor
        '
        Me.DataGridViewAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAuthor.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewAuthor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAuthor.Location = New System.Drawing.Point(330, 87)
        Me.DataGridViewAuthor.Name = "DataGridViewAuthor"
        Me.DataGridViewAuthor.Size = New System.Drawing.Size(488, 161)
        Me.DataGridViewAuthor.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(108, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 25)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Software Details"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSearch.Location = New System.Drawing.Point(503, 43)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(101, 38)
        Me.btnSearch.TabIndex = 59
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtAuthorName
        '
        Me.txtAuthorName.Location = New System.Drawing.Point(176, 201)
        Me.txtAuthorName.Name = "txtAuthorName"
        Me.txtAuthorName.Size = New System.Drawing.Size(100, 20)
        Me.txtAuthorName.TabIndex = 58
        '
        'txtAuthorId
        '
        Me.txtAuthorId.Location = New System.Drawing.Point(176, 142)
        Me.txtAuthorId.Name = "txtAuthorId"
        Me.txtAuthorId.Size = New System.Drawing.Size(100, 20)
        Me.txtAuthorId.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(66, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Author Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(94, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Author ID"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(121, 9)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(360, 35)
        Me.TextBox1.TabIndex = 53
        Me.TextBox1.Text = "System Repository System"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(58, 24)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CRUDSoftwareToolStripMenuItem, Me.AboutToolStripMenuItem1, Me.HomeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'CRUDSoftwareToolStripMenuItem
        '
        Me.CRUDSoftwareToolStripMenuItem.Name = "CRUDSoftwareToolStripMenuItem"
        Me.CRUDSoftwareToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CRUDSoftwareToolStripMenuItem.Text = "CRUD Software"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnInnerJoin
        '
        Me.btnInnerJoin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnInnerJoin.ForeColor = System.Drawing.Color.Magenta
        Me.btnInnerJoin.Location = New System.Drawing.Point(717, 43)
        Me.btnInnerJoin.Name = "btnInnerJoin"
        Me.btnInnerJoin.Size = New System.Drawing.Size(101, 38)
        Me.btnInnerJoin.TabIndex = 66
        Me.btnInnerJoin.Text = "INNER JOIN"
        Me.btnInnerJoin.UseVisualStyleBackColor = False
        '
        'author
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SoftwareRespositorySystem.My.Resources.Resources.a9a0e85906b1b1f61baaf273d8a5cc62
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(847, 322)
        Me.Controls.Add(Me.btnInnerJoin)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridViewAuthor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtAuthorName)
        Me.Controls.Add(Me.txtAuthorId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "author"
        Me.Text = "author"
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRSDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewAuthor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SRSDataSet4 As SRSDataSet4
    Friend WithEvents AuthorBindingSource As BindingSource
    Friend WithEvents AuthorTableAdapter As SRSDataSet4TableAdapters.authorTableAdapter
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridViewAuthor As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtAuthorName As TextBox
    Friend WithEvents txtAuthorId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnInnerJoin As Button
    Friend WithEvents CRUDSoftwareToolStripMenuItem As ToolStripMenuItem
End Class
