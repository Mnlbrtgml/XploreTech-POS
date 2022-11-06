<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPointOfSale
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPointOfSale))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlSelectItem = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlItemListShadow = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvItemList = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.cmbxSelectProduct = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlSelectedItem = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtItemPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.pnlSelectedItemListShadow = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvSelectedItemList = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVoid = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDone = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlAddItem = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbxSugarLevel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbxCupSize = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSelectToppings = New Guna.UI2.WinForms.Guna2Button()
        Me.txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtToppings = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSugarLevel = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblCupSize = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblToppings = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblQuantity = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblItemName = New Bunifu.UI.WinForms.BunifuLabel()
        Me.elipseItemListTable = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.elipseSelectedItemListTable = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tooltip = New Bunifu.UI.WinForms.BunifuToolTip(Me.components)
        Me.pnlSelectItem.SuspendLayout()
        Me.pnlItemListShadow.SuspendLayout()
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSelectedItem.SuspendLayout()
        Me.pnlSelectedItemListShadow.SuspendLayout()
        CType(Me.dgvSelectedItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSelectItem
        '
        Me.pnlSelectItem.BackColor = System.Drawing.Color.Transparent
        Me.pnlSelectItem.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlSelectItem.BorderRadius = 6
        Me.pnlSelectItem.Controls.Add(Me.pnlItemListShadow)
        Me.pnlSelectItem.Controls.Add(Me.cmbxSelectProduct)
        Me.pnlSelectItem.Controls.Add(Me.txtSearch)
        Me.pnlSelectItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlSelectItem.Location = New System.Drawing.Point(0, 25)
        Me.pnlSelectItem.Name = "pnlSelectItem"
        Me.pnlSelectItem.ShadowDecoration.Enabled = True
        Me.pnlSelectItem.ShadowDecoration.Parent = Me.pnlSelectItem
        Me.pnlSelectItem.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlSelectItem.Size = New System.Drawing.Size(452, 270)
        Me.pnlSelectItem.TabIndex = 0
        Me.tooltip.SetToolTip(Me.pnlSelectItem, "")
        Me.tooltip.SetToolTipIcon(Me.pnlSelectItem, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlSelectItem, "")
        '
        'pnlItemListShadow
        '
        Me.pnlItemListShadow.BackColor = System.Drawing.Color.Transparent
        Me.pnlItemListShadow.BorderColor = System.Drawing.Color.White
        Me.pnlItemListShadow.BorderRadius = 6
        Me.pnlItemListShadow.Controls.Add(Me.dgvItemList)
        Me.pnlItemListShadow.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.pnlItemListShadow.Location = New System.Drawing.Point(25, 86)
        Me.pnlItemListShadow.Name = "pnlItemListShadow"
        Me.pnlItemListShadow.ShadowDecoration.Enabled = True
        Me.pnlItemListShadow.ShadowDecoration.Parent = Me.pnlItemListShadow
        Me.pnlItemListShadow.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlItemListShadow.Size = New System.Drawing.Size(402, 159)
        Me.pnlItemListShadow.TabIndex = 12
        Me.tooltip.SetToolTip(Me.pnlItemListShadow, "")
        Me.tooltip.SetToolTipIcon(Me.pnlItemListShadow, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlItemListShadow, "")
        '
        'dgvItemList
        '
        Me.dgvItemList.AllowCustomTheming = True
        Me.dgvItemList.AllowUserToAddRows = False
        Me.dgvItemList.AllowUserToDeleteRows = False
        Me.dgvItemList.AllowUserToResizeColumns = False
        Me.dgvItemList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvItemList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemList.BackgroundColor = System.Drawing.Color.White
        Me.dgvItemList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItemList.ColumnHeadersHeight = 36
        Me.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvItemList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvItemList.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dgvItemList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvItemList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvItemList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvItemList.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.dgvItemList.CurrentTheme.GridColor = System.Drawing.Color.White
        Me.dgvItemList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvItemList.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.dgvItemList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvItemList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvItemList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvItemList.CurrentTheme.Name = Nothing
        Me.dgvItemList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvItemList.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dgvItemList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvItemList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvItemList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvItemList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItemList.EnableHeadersVisualStyles = False
        Me.dgvItemList.GridColor = System.Drawing.Color.White
        Me.dgvItemList.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvItemList.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgvItemList.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvItemList.Location = New System.Drawing.Point(1, 1)
        Me.dgvItemList.MultiSelect = False
        Me.dgvItemList.Name = "dgvItemList"
        Me.dgvItemList.ReadOnly = True
        Me.dgvItemList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvItemList.RowHeadersVisible = False
        Me.dgvItemList.RowHeadersWidth = 51
        Me.dgvItemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvItemList.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvItemList.RowTemplate.Height = 28
        Me.dgvItemList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemList.ShowEditingIcon = False
        Me.dgvItemList.Size = New System.Drawing.Size(401, 158)
        Me.dgvItemList.TabIndex = 6
        Me.dgvItemList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        Me.tooltip.SetToolTip(Me.dgvItemList, "")
        Me.tooltip.SetToolTipIcon(Me.dgvItemList, Nothing)
        Me.tooltip.SetToolTipTitle(Me.dgvItemList, "")
        '
        'cmbxSelectProduct
        '
        Me.cmbxSelectProduct.BackColor = System.Drawing.Color.Transparent
        Me.cmbxSelectProduct.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxSelectProduct.BorderRadius = 6
        Me.cmbxSelectProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbxSelectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSelectProduct.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxSelectProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxSelectProduct.FocusedState.Parent = Me.cmbxSelectProduct
        Me.cmbxSelectProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxSelectProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSelectProduct.FormattingEnabled = True
        Me.cmbxSelectProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmbxSelectProduct.HoverState.Parent = Me.cmbxSelectProduct
        Me.cmbxSelectProduct.ItemHeight = 30
        Me.cmbxSelectProduct.Items.AddRange(New Object() {"Milktea Products", "Other Products"})
        Me.cmbxSelectProduct.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbxSelectProduct.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSelectProduct.ItemsAppearance.Parent = Me.cmbxSelectProduct
        Me.cmbxSelectProduct.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxSelectProduct.ItemsAppearance.SelectedFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmbxSelectProduct.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSelectProduct.Location = New System.Drawing.Point(25, 25)
        Me.cmbxSelectProduct.Name = "cmbxSelectProduct"
        Me.cmbxSelectProduct.ShadowDecoration.Enabled = True
        Me.cmbxSelectProduct.ShadowDecoration.Parent = Me.cmbxSelectProduct
        Me.cmbxSelectProduct.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cmbxSelectProduct.Size = New System.Drawing.Size(198, 36)
        Me.cmbxSelectProduct.StartIndex = 0
        Me.cmbxSelectProduct.TabIndex = 11
        Me.cmbxSelectProduct.TextOffset = New System.Drawing.Point(1, 3)
        Me.tooltip.SetToolTip(Me.cmbxSelectProduct, "")
        Me.tooltip.SetToolTipIcon(Me.cmbxSelectProduct, Nothing)
        Me.tooltip.SetToolTipTitle(Me.cmbxSelectProduct, "")
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
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(229, 26)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Enabled = True
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtSearch.Size = New System.Drawing.Size(198, 36)
        Me.txtSearch.TabIndex = 10
        Me.tooltip.SetToolTip(Me.txtSearch, "")
        Me.tooltip.SetToolTipIcon(Me.txtSearch, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtSearch, "")
        '
        'pnlSelectedItem
        '
        Me.pnlSelectedItem.BackColor = System.Drawing.Color.Transparent
        Me.pnlSelectedItem.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlSelectedItem.BorderRadius = 6
        Me.pnlSelectedItem.Controls.Add(Me.txtItemPrice)
        Me.pnlSelectedItem.Controls.Add(Me.BunifuLabel2)
        Me.pnlSelectedItem.Controls.Add(Me.pnlSelectedItemListShadow)
        Me.pnlSelectedItem.Controls.Add(Me.btnEdit)
        Me.pnlSelectedItem.Controls.Add(Me.btnVoid)
        Me.pnlSelectedItem.Controls.Add(Me.btnDone)
        Me.pnlSelectedItem.Enabled = False
        Me.pnlSelectedItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlSelectedItem.Location = New System.Drawing.Point(477, 25)
        Me.pnlSelectedItem.Name = "pnlSelectedItem"
        Me.pnlSelectedItem.ShadowDecoration.Enabled = True
        Me.pnlSelectedItem.ShadowDecoration.Parent = Me.pnlSelectedItem
        Me.pnlSelectedItem.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlSelectedItem.Size = New System.Drawing.Size(452, 596)
        Me.pnlSelectedItem.TabIndex = 0
        Me.tooltip.SetToolTip(Me.pnlSelectedItem, "")
        Me.tooltip.SetToolTipIcon(Me.pnlSelectedItem, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlSelectedItem, "")
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Animated = True
        Me.txtItemPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtItemPrice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtItemPrice.BorderRadius = 6
        Me.txtItemPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemPrice.DefaultText = ""
        Me.txtItemPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemPrice.DisabledState.Parent = Me.txtItemPrice
        Me.txtItemPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtItemPrice.FocusedState.Parent = Me.txtItemPrice
        Me.txtItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtItemPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtItemPrice.HoverState.Parent = Me.txtItemPrice
        Me.txtItemPrice.Location = New System.Drawing.Point(277, 474)
        Me.txtItemPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemPrice.PlaceholderText = ""
        Me.txtItemPrice.SelectedText = ""
        Me.txtItemPrice.ShadowDecoration.Enabled = True
        Me.txtItemPrice.ShadowDecoration.Parent = Me.txtItemPrice
        Me.txtItemPrice.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtItemPrice.Size = New System.Drawing.Size(150, 36)
        Me.txtItemPrice.TabIndex = 8
        Me.tooltip.SetToolTip(Me.txtItemPrice, "")
        Me.tooltip.SetToolTipIcon(Me.txtItemPrice, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtItemPrice, "")
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.AutoSize = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BunifuLabel2.Location = New System.Drawing.Point(201, 483)
        Me.BunifuLabel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(70, 19)
        Me.BunifuLabel2.TabIndex = 7
        Me.BunifuLabel2.Text = "Subtotal"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel2, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel2, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel2, "")
        '
        'pnlSelectedItemListShadow
        '
        Me.pnlSelectedItemListShadow.BackColor = System.Drawing.Color.Transparent
        Me.pnlSelectedItemListShadow.BorderColor = System.Drawing.Color.White
        Me.pnlSelectedItemListShadow.BorderRadius = 6
        Me.pnlSelectedItemListShadow.Controls.Add(Me.dgvSelectedItemList)
        Me.pnlSelectedItemListShadow.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.pnlSelectedItemListShadow.Location = New System.Drawing.Point(25, 25)
        Me.pnlSelectedItemListShadow.Name = "pnlSelectedItemListShadow"
        Me.pnlSelectedItemListShadow.ShadowDecoration.Enabled = True
        Me.pnlSelectedItemListShadow.ShadowDecoration.Parent = Me.pnlSelectedItemListShadow
        Me.pnlSelectedItemListShadow.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlSelectedItemListShadow.Size = New System.Drawing.Size(402, 424)
        Me.pnlSelectedItemListShadow.TabIndex = 6
        Me.tooltip.SetToolTip(Me.pnlSelectedItemListShadow, "")
        Me.tooltip.SetToolTipIcon(Me.pnlSelectedItemListShadow, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlSelectedItemListShadow, "")
        '
        'dgvSelectedItemList
        '
        Me.dgvSelectedItemList.AllowCustomTheming = True
        Me.dgvSelectedItemList.AllowUserToAddRows = False
        Me.dgvSelectedItemList.AllowUserToDeleteRows = False
        Me.dgvSelectedItemList.AllowUserToResizeColumns = False
        Me.dgvSelectedItemList.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvSelectedItemList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSelectedItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSelectedItemList.BackgroundColor = System.Drawing.Color.White
        Me.dgvSelectedItemList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSelectedItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSelectedItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSelectedItemList.ColumnHeadersHeight = 36
        Me.dgvSelectedItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSelectedItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvSelectedItemList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSelectedItemList.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dgvSelectedItemList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvSelectedItemList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvSelectedItemList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvSelectedItemList.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.dgvSelectedItemList.CurrentTheme.GridColor = System.Drawing.Color.White
        Me.dgvSelectedItemList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvSelectedItemList.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.dgvSelectedItemList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvSelectedItemList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvSelectedItemList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvSelectedItemList.CurrentTheme.Name = Nothing
        Me.dgvSelectedItemList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSelectedItemList.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dgvSelectedItemList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvSelectedItemList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvSelectedItemList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSelectedItemList.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSelectedItemList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSelectedItemList.EnableHeadersVisualStyles = False
        Me.dgvSelectedItemList.GridColor = System.Drawing.Color.White
        Me.dgvSelectedItemList.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvSelectedItemList.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgvSelectedItemList.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvSelectedItemList.Location = New System.Drawing.Point(1, 1)
        Me.dgvSelectedItemList.MultiSelect = False
        Me.dgvSelectedItemList.Name = "dgvSelectedItemList"
        Me.dgvSelectedItemList.ReadOnly = True
        Me.dgvSelectedItemList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedItemList.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSelectedItemList.RowHeadersVisible = False
        Me.dgvSelectedItemList.RowHeadersWidth = 51
        Me.dgvSelectedItemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvSelectedItemList.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvSelectedItemList.RowTemplate.Height = 28
        Me.dgvSelectedItemList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSelectedItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSelectedItemList.ShowEditingIcon = False
        Me.dgvSelectedItemList.Size = New System.Drawing.Size(401, 423)
        Me.dgvSelectedItemList.TabIndex = 6
        Me.dgvSelectedItemList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        Me.tooltip.SetToolTip(Me.dgvSelectedItemList, "")
        Me.tooltip.SetToolTipIcon(Me.dgvSelectedItemList, Nothing)
        Me.tooltip.SetToolTipTitle(Me.dgvSelectedItemList, "")
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Add-ons"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Size"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sugar"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Price"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'btnEdit
        '
        Me.btnEdit.Animated = True
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BorderRadius = 6
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(25, 535)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Enabled = True
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnEdit.Size = New System.Drawing.Size(130, 36)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.tooltip.SetToolTip(Me.btnEdit, "")
        Me.tooltip.SetToolTipIcon(Me.btnEdit, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnEdit, "")
        '
        'btnVoid
        '
        Me.btnVoid.Animated = True
        Me.btnVoid.BackColor = System.Drawing.Color.Transparent
        Me.btnVoid.BorderRadius = 6
        Me.btnVoid.CheckedState.Parent = Me.btnVoid
        Me.btnVoid.CustomImages.Parent = Me.btnVoid
        Me.btnVoid.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnVoid.HoverState.Parent = Me.btnVoid
        Me.btnVoid.Location = New System.Drawing.Point(161, 535)
        Me.btnVoid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.ShadowDecoration.Enabled = True
        Me.btnVoid.ShadowDecoration.Parent = Me.btnVoid
        Me.btnVoid.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnVoid.Size = New System.Drawing.Size(130, 36)
        Me.btnVoid.TabIndex = 2
        Me.btnVoid.Text = "Void"
        Me.tooltip.SetToolTip(Me.btnVoid, "")
        Me.tooltip.SetToolTipIcon(Me.btnVoid, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnVoid, "")
        '
        'btnDone
        '
        Me.btnDone.Animated = True
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.BorderRadius = 6
        Me.btnDone.CheckedState.Parent = Me.btnDone
        Me.btnDone.CustomImages.Parent = Me.btnDone
        Me.btnDone.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnDone.HoverState.Parent = Me.btnDone
        Me.btnDone.Location = New System.Drawing.Point(297, 535)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.ShadowDecoration.Enabled = True
        Me.btnDone.ShadowDecoration.Parent = Me.btnDone
        Me.btnDone.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnDone.Size = New System.Drawing.Size(130, 36)
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "Done"
        Me.tooltip.SetToolTip(Me.btnDone, "")
        Me.tooltip.SetToolTipIcon(Me.btnDone, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnDone, "")
        '
        'pnlAddItem
        '
        Me.pnlAddItem.BackColor = System.Drawing.Color.Transparent
        Me.pnlAddItem.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlAddItem.BorderRadius = 6
        Me.pnlAddItem.Controls.Add(Me.cmbxSugarLevel)
        Me.pnlAddItem.Controls.Add(Me.cmbxCupSize)
        Me.pnlAddItem.Controls.Add(Me.btnCancel)
        Me.pnlAddItem.Controls.Add(Me.btnAddProduct)
        Me.pnlAddItem.Controls.Add(Me.btnSelectToppings)
        Me.pnlAddItem.Controls.Add(Me.txtQuantity)
        Me.pnlAddItem.Controls.Add(Me.txtToppings)
        Me.pnlAddItem.Controls.Add(Me.txtItemName)
        Me.pnlAddItem.Controls.Add(Me.lblSugarLevel)
        Me.pnlAddItem.Controls.Add(Me.lblCupSize)
        Me.pnlAddItem.Controls.Add(Me.lblToppings)
        Me.pnlAddItem.Controls.Add(Me.lblQuantity)
        Me.pnlAddItem.Controls.Add(Me.lblItemName)
        Me.pnlAddItem.Enabled = False
        Me.pnlAddItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlAddItem.Location = New System.Drawing.Point(0, 320)
        Me.pnlAddItem.Name = "pnlAddItem"
        Me.pnlAddItem.ShadowDecoration.Enabled = True
        Me.pnlAddItem.ShadowDecoration.Parent = Me.pnlAddItem
        Me.pnlAddItem.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlAddItem.Size = New System.Drawing.Size(452, 301)
        Me.pnlAddItem.TabIndex = 0
        Me.tooltip.SetToolTip(Me.pnlAddItem, "")
        Me.tooltip.SetToolTipIcon(Me.pnlAddItem, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlAddItem, "")
        '
        'cmbxSugarLevel
        '
        Me.cmbxSugarLevel.BackColor = System.Drawing.Color.Transparent
        Me.cmbxSugarLevel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxSugarLevel.BorderRadius = 6
        Me.cmbxSugarLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbxSugarLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSugarLevel.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxSugarLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxSugarLevel.FocusedState.Parent = Me.cmbxSugarLevel
        Me.cmbxSugarLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxSugarLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSugarLevel.FormattingEnabled = True
        Me.cmbxSugarLevel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmbxSugarLevel.HoverState.Parent = Me.cmbxSugarLevel
        Me.cmbxSugarLevel.ItemHeight = 30
        Me.cmbxSugarLevel.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cmbxSugarLevel.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbxSugarLevel.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSugarLevel.ItemsAppearance.Parent = Me.cmbxSugarLevel
        Me.cmbxSugarLevel.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxSugarLevel.ItemsAppearance.SelectedFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmbxSugarLevel.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSugarLevel.Location = New System.Drawing.Point(25, 179)
        Me.cmbxSugarLevel.Name = "cmbxSugarLevel"
        Me.cmbxSugarLevel.ShadowDecoration.Enabled = True
        Me.cmbxSugarLevel.ShadowDecoration.Parent = Me.cmbxSugarLevel
        Me.cmbxSugarLevel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cmbxSugarLevel.Size = New System.Drawing.Size(198, 36)
        Me.cmbxSugarLevel.TabIndex = 9
        Me.cmbxSugarLevel.TextOffset = New System.Drawing.Point(1, 2)
        Me.tooltip.SetToolTip(Me.cmbxSugarLevel, "")
        Me.tooltip.SetToolTipIcon(Me.cmbxSugarLevel, Nothing)
        Me.tooltip.SetToolTipTitle(Me.cmbxSugarLevel, "")
        '
        'cmbxCupSize
        '
        Me.cmbxCupSize.BackColor = System.Drawing.Color.Transparent
        Me.cmbxCupSize.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxCupSize.BorderRadius = 6
        Me.cmbxCupSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbxCupSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxCupSize.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxCupSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxCupSize.FocusedState.Parent = Me.cmbxCupSize
        Me.cmbxCupSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxCupSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxCupSize.FormattingEnabled = True
        Me.cmbxCupSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmbxCupSize.HoverState.Parent = Me.cmbxCupSize
        Me.cmbxCupSize.ItemHeight = 30
        Me.cmbxCupSize.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cmbxCupSize.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbxCupSize.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxCupSize.ItemsAppearance.Parent = Me.cmbxCupSize
        Me.cmbxCupSize.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxCupSize.ItemsAppearance.SelectedFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmbxCupSize.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxCupSize.Location = New System.Drawing.Point(25, 114)
        Me.cmbxCupSize.Name = "cmbxCupSize"
        Me.cmbxCupSize.ShadowDecoration.Enabled = True
        Me.cmbxCupSize.ShadowDecoration.Parent = Me.cmbxCupSize
        Me.cmbxCupSize.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cmbxCupSize.Size = New System.Drawing.Size(198, 36)
        Me.cmbxCupSize.TabIndex = 9
        Me.cmbxCupSize.TextOffset = New System.Drawing.Point(1, 2)
        Me.tooltip.SetToolTip(Me.cmbxCupSize, "")
        Me.tooltip.SetToolTipIcon(Me.cmbxCupSize, Nothing)
        Me.tooltip.SetToolTipTitle(Me.cmbxCupSize, "")
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 6
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(25, 240)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnCancel.Size = New System.Drawing.Size(198, 36)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.tooltip.SetToolTip(Me.btnCancel, "")
        Me.tooltip.SetToolTipIcon(Me.btnCancel, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnCancel, "")
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Animated = True
        Me.btnAddProduct.BackColor = System.Drawing.Color.Transparent
        Me.btnAddProduct.BorderRadius = 6
        Me.btnAddProduct.CheckedState.Parent = Me.btnAddProduct
        Me.btnAddProduct.CustomImages.Parent = Me.btnAddProduct
        Me.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnAddProduct.HoverState.Parent = Me.btnAddProduct
        Me.btnAddProduct.Location = New System.Drawing.Point(229, 240)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.ShadowDecoration.Enabled = True
        Me.btnAddProduct.ShadowDecoration.Parent = Me.btnAddProduct
        Me.btnAddProduct.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnAddProduct.Size = New System.Drawing.Size(198, 36)
        Me.btnAddProduct.TabIndex = 2
        Me.btnAddProduct.Text = "Add product to list"
        Me.tooltip.SetToolTip(Me.btnAddProduct, "")
        Me.tooltip.SetToolTipIcon(Me.btnAddProduct, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnAddProduct, "")
        '
        'btnSelectToppings
        '
        Me.btnSelectToppings.Animated = True
        Me.btnSelectToppings.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectToppings.BorderRadius = 6
        Me.btnSelectToppings.CheckedState.Parent = Me.btnSelectToppings
        Me.btnSelectToppings.CustomImages.Parent = Me.btnSelectToppings
        Me.btnSelectToppings.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnSelectToppings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectToppings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnSelectToppings.HoverState.Parent = Me.btnSelectToppings
        Me.btnSelectToppings.Location = New System.Drawing.Point(391, 114)
        Me.btnSelectToppings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSelectToppings.Name = "btnSelectToppings"
        Me.btnSelectToppings.ShadowDecoration.Enabled = True
        Me.btnSelectToppings.ShadowDecoration.Parent = Me.btnSelectToppings
        Me.btnSelectToppings.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnSelectToppings.Size = New System.Drawing.Size(36, 36)
        Me.btnSelectToppings.TabIndex = 2
        Me.btnSelectToppings.Text = "..."
        Me.tooltip.SetToolTip(Me.btnSelectToppings, "")
        Me.tooltip.SetToolTipIcon(Me.btnSelectToppings, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnSelectToppings, "")
        '
        'txtQuantity
        '
        Me.txtQuantity.Animated = True
        Me.txtQuantity.BackColor = System.Drawing.Color.Transparent
        Me.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtQuantity.BorderRadius = 6
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.DefaultText = "0"
        Me.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.DisabledState.Parent = Me.txtQuantity
        Me.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtQuantity.FocusedState.Parent = Me.txtQuantity
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtQuantity.HoverState.Parent = Me.txtQuantity
        Me.txtQuantity.Location = New System.Drawing.Point(229, 179)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantity.PlaceholderText = ""
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.SelectionStart = 1
        Me.txtQuantity.ShadowDecoration.Enabled = True
        Me.txtQuantity.ShadowDecoration.Parent = Me.txtQuantity
        Me.txtQuantity.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtQuantity.Size = New System.Drawing.Size(198, 36)
        Me.txtQuantity.TabIndex = 8
        Me.tooltip.SetToolTip(Me.txtQuantity, "")
        Me.tooltip.SetToolTipIcon(Me.txtQuantity, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtQuantity, "")
        '
        'txtToppings
        '
        Me.txtToppings.Animated = True
        Me.txtToppings.BackColor = System.Drawing.Color.Transparent
        Me.txtToppings.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtToppings.BorderRadius = 6
        Me.txtToppings.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToppings.DefaultText = "No selected toppings"
        Me.txtToppings.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtToppings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtToppings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtToppings.DisabledState.Parent = Me.txtToppings
        Me.txtToppings.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtToppings.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtToppings.FocusedState.Parent = Me.txtToppings
        Me.txtToppings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToppings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtToppings.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtToppings.HoverState.Parent = Me.txtToppings
        Me.txtToppings.Location = New System.Drawing.Point(229, 114)
        Me.txtToppings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtToppings.Name = "txtToppings"
        Me.txtToppings.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtToppings.PlaceholderText = ""
        Me.txtToppings.ReadOnly = True
        Me.txtToppings.SelectedText = ""
        Me.txtToppings.SelectionStart = 20
        Me.txtToppings.ShadowDecoration.Enabled = True
        Me.txtToppings.ShadowDecoration.Parent = Me.txtToppings
        Me.txtToppings.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtToppings.Size = New System.Drawing.Size(156, 36)
        Me.txtToppings.TabIndex = 8
        Me.tooltip.SetToolTip(Me.txtToppings, "")
        Me.tooltip.SetToolTipIcon(Me.txtToppings, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtToppings, "")
        '
        'txtItemName
        '
        Me.txtItemName.Animated = True
        Me.txtItemName.BackColor = System.Drawing.Color.Transparent
        Me.txtItemName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtItemName.BorderRadius = 6
        Me.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemName.DefaultText = ""
        Me.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.DisabledState.Parent = Me.txtItemName
        Me.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtItemName.FocusedState.Parent = Me.txtItemName
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtItemName.HoverState.Parent = Me.txtItemName
        Me.txtItemName.Location = New System.Drawing.Point(25, 49)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.PlaceholderText = ""
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.ShadowDecoration.Enabled = True
        Me.txtItemName.ShadowDecoration.Parent = Me.txtItemName
        Me.txtItemName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtItemName.Size = New System.Drawing.Size(402, 36)
        Me.txtItemName.TabIndex = 8
        Me.tooltip.SetToolTip(Me.txtItemName, "")
        Me.tooltip.SetToolTipIcon(Me.txtItemName, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtItemName, "")
        '
        'lblSugarLevel
        '
        Me.lblSugarLevel.AllowParentOverrides = False
        Me.lblSugarLevel.AutoEllipsis = False
        Me.lblSugarLevel.AutoSize = False
        Me.lblSugarLevel.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSugarLevel.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblSugarLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblSugarLevel.Location = New System.Drawing.Point(25, 155)
        Me.lblSugarLevel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblSugarLevel.Name = "lblSugarLevel"
        Me.lblSugarLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSugarLevel.Size = New System.Drawing.Size(70, 19)
        Me.lblSugarLevel.TabIndex = 7
        Me.lblSugarLevel.Text = "Sugar level"
        Me.lblSugarLevel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSugarLevel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblSugarLevel, "")
        Me.tooltip.SetToolTipIcon(Me.lblSugarLevel, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblSugarLevel, "")
        '
        'lblCupSize
        '
        Me.lblCupSize.AllowParentOverrides = False
        Me.lblCupSize.AutoEllipsis = False
        Me.lblCupSize.AutoSize = False
        Me.lblCupSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCupSize.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblCupSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblCupSize.Location = New System.Drawing.Point(25, 90)
        Me.lblCupSize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblCupSize.Name = "lblCupSize"
        Me.lblCupSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCupSize.Size = New System.Drawing.Size(70, 19)
        Me.lblCupSize.TabIndex = 7
        Me.lblCupSize.Text = "Cup size"
        Me.lblCupSize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCupSize.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblCupSize, "")
        Me.tooltip.SetToolTipIcon(Me.lblCupSize, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblCupSize, "")
        '
        'lblToppings
        '
        Me.lblToppings.AllowParentOverrides = False
        Me.lblToppings.AutoEllipsis = False
        Me.lblToppings.AutoSize = False
        Me.lblToppings.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblToppings.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblToppings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblToppings.Location = New System.Drawing.Point(229, 90)
        Me.lblToppings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblToppings.Name = "lblToppings"
        Me.lblToppings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblToppings.Size = New System.Drawing.Size(70, 19)
        Me.lblToppings.TabIndex = 7
        Me.lblToppings.Text = "Toppings"
        Me.lblToppings.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblToppings.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblToppings, "")
        Me.tooltip.SetToolTipIcon(Me.lblToppings, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblToppings, "")
        '
        'lblQuantity
        '
        Me.lblQuantity.AllowParentOverrides = False
        Me.lblQuantity.AutoEllipsis = False
        Me.lblQuantity.AutoSize = False
        Me.lblQuantity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblQuantity.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblQuantity.Location = New System.Drawing.Point(229, 155)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQuantity.Size = New System.Drawing.Size(70, 19)
        Me.lblQuantity.TabIndex = 7
        Me.lblQuantity.Text = "Quantity"
        Me.lblQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblQuantity.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblQuantity, "")
        Me.tooltip.SetToolTipIcon(Me.lblQuantity, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblQuantity, "")
        '
        'lblItemName
        '
        Me.lblItemName.AllowParentOverrides = False
        Me.lblItemName.AutoEllipsis = False
        Me.lblItemName.AutoSize = False
        Me.lblItemName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblItemName.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblItemName.Location = New System.Drawing.Point(25, 25)
        Me.lblItemName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblItemName.Size = New System.Drawing.Size(70, 19)
        Me.lblItemName.TabIndex = 7
        Me.lblItemName.Text = "Item name"
        Me.lblItemName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblItemName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblItemName, "")
        Me.tooltip.SetToolTipIcon(Me.lblItemName, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblItemName, "")
        '
        'elipseItemListTable
        '
        Me.elipseItemListTable.ElipseRadius = 6
        Me.elipseItemListTable.TargetControl = Me.dgvItemList
        '
        'elipseSelectedItemListTable
        '
        Me.elipseSelectedItemListTable.ElipseRadius = 6
        Me.elipseSelectedItemListTable.TargetControl = Me.dgvSelectedItemList
        '
        'tooltip
        '
        Me.tooltip.Active = True
        Me.tooltip.AlignTextWithTitle = False
        Me.tooltip.AllowAutoClose = False
        Me.tooltip.AllowFading = True
        Me.tooltip.AutoCloseDuration = 5000
        Me.tooltip.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.tooltip.BorderColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.tooltip.ClickToShowDisplayControl = False
        Me.tooltip.ConvertNewlinesToBreakTags = True
        Me.tooltip.DisplayControl = Nothing
        Me.tooltip.EntryAnimationSpeed = 350
        Me.tooltip.ExitAnimationSpeed = 200
        Me.tooltip.GenerateAutoCloseDuration = False
        Me.tooltip.IconMargin = 6
        Me.tooltip.InitialDelay = 0
        Me.tooltip.Name = "tooltip"
        Me.tooltip.Opacity = 1.0R
        Me.tooltip.OverrideToolTipTitles = False
        Me.tooltip.Padding = New System.Windows.Forms.Padding(10)
        Me.tooltip.ReshowDelay = 100
        Me.tooltip.ShowAlways = True
        Me.tooltip.ShowBorders = True
        Me.tooltip.ShowIcons = True
        Me.tooltip.ShowShadows = True
        Me.tooltip.Tag = Nothing
        Me.tooltip.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tooltip.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.tooltip.TextMargin = 2
        Me.tooltip.TitleFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tooltip.TitleForeColor = System.Drawing.Color.Black
        Me.tooltip.ToolTipPosition = New System.Drawing.Point(0, 0)
        Me.tooltip.ToolTipTitle = Nothing
        '
        'frmPointOfSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 646)
        Me.Controls.Add(Me.pnlAddItem)
        Me.Controls.Add(Me.pnlSelectedItem)
        Me.Controls.Add(Me.pnlSelectItem)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPointOfSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlSelectItem.ResumeLayout(False)
        Me.pnlItemListShadow.ResumeLayout(False)
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSelectedItem.ResumeLayout(False)
        Me.pnlSelectedItemListShadow.ResumeLayout(False)
        CType(Me.dgvSelectedItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddItem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSelectItem As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlSelectedItem As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlAddItem As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVoid As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDone As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlSelectedItemListShadow As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents elipseItemListTable As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtItemPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCupSize As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblQuantity As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblToppings As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblItemName As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSugarLevel As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents cmbxSugarLevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbxCupSize As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnAddProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbxSelectProduct As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pnlItemListShadow As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents elipseSelectedItemListTable As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtToppings As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSelectToppings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tooltip As Bunifu.UI.WinForms.BunifuToolTip
    Friend WithEvents dgvItemList As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents dgvSelectedItemList As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
