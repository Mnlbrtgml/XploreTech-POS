<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtherSettings
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOtherSettings))
        Me.pnlOtherSettings = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlTableShadow = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbxSettings = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.dgvTable = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.pnlOtherSettings.SuspendLayout()
        Me.pnlTableShadow.SuspendLayout()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlOtherSettings
        '
        Me.pnlOtherSettings.BackColor = System.Drawing.Color.Transparent
        Me.pnlOtherSettings.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlOtherSettings.BorderRadius = 6
        Me.pnlOtherSettings.Controls.Add(Me.btnAdd)
        Me.pnlOtherSettings.Controls.Add(Me.pnlTableShadow)
        Me.pnlOtherSettings.Controls.Add(Me.cmbxSettings)
        Me.pnlOtherSettings.Controls.Add(Me.txtSearch)
        Me.pnlOtherSettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlOtherSettings.Location = New System.Drawing.Point(0, 25)
        Me.pnlOtherSettings.Name = "pnlOtherSettings"
        Me.pnlOtherSettings.ShadowDecoration.Enabled = True
        Me.pnlOtherSettings.ShadowDecoration.Parent = Me.pnlOtherSettings
        Me.pnlOtherSettings.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlOtherSettings.Size = New System.Drawing.Size(929, 596)
        Me.pnlOtherSettings.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderRadius = 6
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(754, 25)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Enabled = True
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnAdd.Size = New System.Drawing.Size(150, 36)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add new account"
        '
        'pnlTableShadow
        '
        Me.pnlTableShadow.BackColor = System.Drawing.Color.Transparent
        Me.pnlTableShadow.BorderColor = System.Drawing.Color.White
        Me.pnlTableShadow.BorderRadius = 6
        Me.pnlTableShadow.Controls.Add(Me.dgvTable)
        Me.pnlTableShadow.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.pnlTableShadow.Location = New System.Drawing.Point(25, 86)
        Me.pnlTableShadow.Name = "pnlTableShadow"
        Me.pnlTableShadow.ShadowDecoration.Enabled = True
        Me.pnlTableShadow.ShadowDecoration.Parent = Me.pnlTableShadow
        Me.pnlTableShadow.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlTableShadow.Size = New System.Drawing.Size(879, 485)
        Me.pnlTableShadow.TabIndex = 5
        '
        'cmbxSettings
        '
        Me.cmbxSettings.BackColor = System.Drawing.Color.Transparent
        Me.cmbxSettings.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxSettings.BorderRadius = 6
        Me.cmbxSettings.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbxSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSettings.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxSettings.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxSettings.FocusedState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmbxSettings.FocusedState.Parent = Me.cmbxSettings
        Me.cmbxSettings.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.cmbxSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSettings.FormattingEnabled = True
        Me.cmbxSettings.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmbxSettings.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmbxSettings.HoverState.Parent = Me.cmbxSettings
        Me.cmbxSettings.ItemHeight = 30
        Me.cmbxSettings.Items.AddRange(New Object() {"User Account Settings", "Customer Settings", "Customer Type Settings", "Promo Settings", "Service Type Settings"})
        Me.cmbxSettings.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbxSettings.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSettings.ItemsAppearance.Parent = Me.cmbxSettings
        Me.cmbxSettings.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxSettings.ItemsAppearance.SelectedFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmbxSettings.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSettings.Location = New System.Drawing.Point(331, 25)
        Me.cmbxSettings.Name = "cmbxSettings"
        Me.cmbxSettings.ShadowDecoration.Enabled = True
        Me.cmbxSettings.ShadowDecoration.Parent = Me.cmbxSettings
        Me.cmbxSettings.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cmbxSettings.Size = New System.Drawing.Size(200, 36)
        Me.cmbxSettings.StartIndex = 0
        Me.cmbxSettings.TabIndex = 3
        Me.cmbxSettings.TextOffset = New System.Drawing.Point(1, 2)
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
        Me.txtSearch.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(25, 25)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Enabled = True
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtSearch.Size = New System.Drawing.Size(300, 36)
        Me.txtSearch.TabIndex = 2
        '
        'elipse
        '
        Me.elipse.ElipseRadius = 5
        Me.elipse.TargetControl = Me
        '
        'dgvTable
        '
        Me.dgvTable.AllowCustomTheming = True
        Me.dgvTable.AllowUserToAddRows = False
        Me.dgvTable.AllowUserToDeleteRows = False
        Me.dgvTable.AllowUserToResizeColumns = False
        Me.dgvTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTable.BackgroundColor = System.Drawing.Color.White
        Me.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTable.ColumnHeadersHeight = 36
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTable.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTable.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.dgvTable.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvTable.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvTable.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvTable.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.dgvTable.CurrentTheme.GridColor = System.Drawing.Color.White
        Me.dgvTable.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvTable.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.dgvTable.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvTable.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvTable.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvTable.CurrentTheme.Name = Nothing
        Me.dgvTable.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTable.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.dgvTable.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvTable.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvTable.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTable.EnableHeadersVisualStyles = False
        Me.dgvTable.GridColor = System.Drawing.Color.White
        Me.dgvTable.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvTable.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgvTable.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvTable.Location = New System.Drawing.Point(1, 1)
        Me.dgvTable.MultiSelect = False
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.ReadOnly = True
        Me.dgvTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTable.RowHeadersVisible = False
        Me.dgvTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTable.RowTemplate.Height = 28
        Me.dgvTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTable.ShowEditingIcon = False
        Me.dgvTable.Size = New System.Drawing.Size(878, 484)
        Me.dgvTable.TabIndex = 7
        Me.dgvTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'frmOtherSettings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 646)
        Me.Controls.Add(Me.pnlOtherSettings)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOtherSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlOtherSettings.ResumeLayout(False)
        Me.pnlTableShadow.ResumeLayout(False)
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOtherSettings As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlTableShadow As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbxSettings As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvTable As Bunifu.UI.WinForms.BunifuDataGridView
End Class
