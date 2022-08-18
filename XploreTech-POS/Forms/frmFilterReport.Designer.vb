<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilterReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFilterReport))
        Me.elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.formShadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbxReport = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDone = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'elipse
        '
        Me.elipse.ElipseRadius = 6
        Me.elipse.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 6
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.btnDone)
        Me.Guna2Panel1.Controls.Add(Me.txtSearch)
        Me.Guna2Panel1.Controls.Add(Me.Guna2DateTimePicker2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Guna2Panel1.Controls.Add(Me.BunifuLabel2)
        Me.Guna2Panel1.Controls.Add(Me.BunifuLabel4)
        Me.Guna2Panel1.Controls.Add(Me.BunifuLabel5)
        Me.Guna2Panel1.Controls.Add(Me.BunifuLabel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2Panel1.Controls.Add(Me.BunifuLabel1)
        Me.Guna2Panel1.Controls.Add(Me.cmbxReport)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(25, 25)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(456, 301)
        Me.Guna2Panel1.TabIndex = 0
        '
        'cmbxReport
        '
        Me.cmbxReport.BackColor = System.Drawing.Color.Transparent
        Me.cmbxReport.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxReport.BorderRadius = 6
        Me.cmbxReport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbxReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxReport.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxReport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxReport.FocusedState.Parent = Me.cmbxReport
        Me.cmbxReport.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxReport.FormattingEnabled = True
        Me.cmbxReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmbxReport.HoverState.Parent = Me.cmbxReport
        Me.cmbxReport.ItemHeight = 30
        Me.cmbxReport.Items.AddRange(New Object() {"Sample 1", "Sample 2", "Sample 3", "Sample 4", "Sample 5", "Sample 6", "Sample 7", "Sample 8"})
        Me.cmbxReport.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbxReport.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxReport.ItemsAppearance.Parent = Me.cmbxReport
        Me.cmbxReport.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxReport.ItemsAppearance.SelectedFont = New System.Drawing.Font("Roboto", 8.0!)
        Me.cmbxReport.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxReport.Location = New System.Drawing.Point(25, 114)
        Me.cmbxReport.Name = "cmbxReport"
        Me.cmbxReport.ShadowDecoration.Enabled = True
        Me.cmbxReport.ShadowDecoration.Parent = Me.cmbxReport
        Me.cmbxReport.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cmbxReport.Size = New System.Drawing.Size(200, 36)
        Me.cmbxReport.TabIndex = 1
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.AutoSize = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel1.Location = New System.Drawing.Point(25, 25)
        Me.BunifuLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(200, 19)
        Me.BunifuLabel1.TabIndex = 8
        Me.BunifuLabel1.Text = "Filter report from"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Guna2DateTimePicker1.BorderRadius = 6
        Me.Guna2DateTimePicker1.BorderThickness = 1
        Me.Guna2DateTimePicker1.CheckedState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(25, 49)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShadowDecoration.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(200, 36)
        Me.Guna2DateTimePicker1.TabIndex = 9
        Me.Guna2DateTimePicker1.Value = New Date(2022, 6, 8, 20, 15, 43, 979)
        '
        'Guna2DateTimePicker2
        '
        Me.Guna2DateTimePicker2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2DateTimePicker2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Guna2DateTimePicker2.BorderRadius = 6
        Me.Guna2DateTimePicker2.BorderThickness = 1
        Me.Guna2DateTimePicker2.CheckedState.Parent = Me.Guna2DateTimePicker2
        Me.Guna2DateTimePicker2.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker2.HoverState.Parent = Me.Guna2DateTimePicker2
        Me.Guna2DateTimePicker2.Location = New System.Drawing.Point(231, 49)
        Me.Guna2DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.Name = "Guna2DateTimePicker2"
        Me.Guna2DateTimePicker2.ShadowDecoration.Parent = Me.Guna2DateTimePicker2
        Me.Guna2DateTimePicker2.Size = New System.Drawing.Size(200, 36)
        Me.Guna2DateTimePicker2.TabIndex = 9
        Me.Guna2DateTimePicker2.Value = New Date(2022, 6, 8, 20, 15, 43, 979)
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.AutoSize = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel2.Location = New System.Drawing.Point(231, 25)
        Me.BunifuLabel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(200, 19)
        Me.BunifuLabel2.TabIndex = 8
        Me.BunifuLabel2.Text = "To"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.AutoSize = False
        Me.BunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel3.Location = New System.Drawing.Point(25, 90)
        Me.BunifuLabel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(200, 19)
        Me.BunifuLabel3.TabIndex = 8
        Me.BunifuLabel3.Text = "Filter by category"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Guna2ComboBox1.BorderRadius = 6
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Guna2ComboBox1.FormattingEnabled = True
        Me.Guna2ComboBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Guna2ComboBox1.HoverState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"Sample 1", "Sample 2", "Sample 3", "Sample 4", "Sample 5", "Sample 6", "Sample 7", "Sample 8"})
        Me.Guna2ComboBox1.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.Guna2ComboBox1.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Guna2ComboBox1.ItemsAppearance.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Guna2ComboBox1.ItemsAppearance.SelectedFont = New System.Drawing.Font("Roboto", 8.0!)
        Me.Guna2ComboBox1.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(231, 114)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.ShadowDecoration.Enabled = True
        Me.Guna2ComboBox1.ShadowDecoration.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(200, 36)
        Me.Guna2ComboBox1.TabIndex = 1
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.AutoSize = False
        Me.BunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel4.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel4.Location = New System.Drawing.Point(231, 90)
        Me.BunifuLabel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(200, 19)
        Me.BunifuLabel4.TabIndex = 8
        Me.BunifuLabel4.Text = "Filter by keyword"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.AutoSize = False
        Me.BunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel5.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel5.Location = New System.Drawing.Point(25, 155)
        Me.BunifuLabel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(200, 19)
        Me.BunifuLabel5.TabIndex = 8
        Me.BunifuLabel5.Text = "Search for"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtSearch
        '
        Me.txtSearch.Animated = True
        Me.txtSearch.BackColor = System.Drawing.Color.Transparent
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtSearch.BorderRadius = 6
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(25, 179)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Enabled = True
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtSearch.Size = New System.Drawing.Size(406, 36)
        Me.txtSearch.TabIndex = 11
        '
        'btnDone
        '
        Me.btnDone.Animated = True
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.BorderRadius = 6
        Me.btnDone.CheckedState.Parent = Me.btnDone
        Me.btnDone.CustomImages.Parent = Me.btnDone
        Me.btnDone.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnDone.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnDone.HoverState.Parent = Me.btnDone
        Me.btnDone.Location = New System.Drawing.Point(231, 240)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.ShadowDecoration.Enabled = True
        Me.btnDone.ShadowDecoration.Parent = Me.btnDone
        Me.btnDone.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnDone.Size = New System.Drawing.Size(150, 36)
        Me.btnDone.TabIndex = 12
        Me.btnDone.Text = "Done"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 6
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2Button1.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(75, 240)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Button1.Size = New System.Drawing.Size(150, 36)
        Me.Guna2Button1.TabIndex = 12
        Me.Guna2Button1.Text = "Cancel"
        '
        'frmFilterReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(506, 351)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFilterReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents formShadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbxReport As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Guna2DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDone As Guna.UI2.WinForms.Guna2Button
End Class
