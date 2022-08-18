<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlaceOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlaceOrder))
        Me.elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.formShadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.pnlCustomerDetails = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnShowCustomerList = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbxCustomerType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtCustomerNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCustomerAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCustomerName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.pnlPayment = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtServiceFee = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbxServiceType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbxPaymentType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BunifuLabel8 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel7 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel6 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BunifuSeparator1 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.BunifuLabel16 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblProductQuantity = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel14 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel13 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel20 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel11 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel12 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblTotalPrice = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblServiceFee = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblChange = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblDiscount = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel26 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel25 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel24 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel23 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel22 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel21 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblPayment = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblSubTotal = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel10 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel9 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPlaceOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.snackbar = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.pnlDiscounts = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtStoreDiscount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnShowDiscountList = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAccountDiscount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel15 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel17 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.tooltip = New Bunifu.UI.WinForms.BunifuToolTip(Me.components)
        Me.pnlCustomerDetails.SuspendLayout()
        Me.pnlPayment.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.pnlDiscounts.SuspendLayout()
        Me.SuspendLayout()
        '
        'elipse
        '
        Me.elipse.ElipseRadius = 6
        Me.elipse.TargetControl = Me
        '
        'pnlCustomerDetails
        '
        Me.pnlCustomerDetails.BackColor = System.Drawing.Color.Transparent
        Me.pnlCustomerDetails.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlCustomerDetails.BorderRadius = 6
        Me.pnlCustomerDetails.Controls.Add(Me.btnShowCustomerList)
        Me.pnlCustomerDetails.Controls.Add(Me.cmbxCustomerType)
        Me.pnlCustomerDetails.Controls.Add(Me.txtCustomerNumber)
        Me.pnlCustomerDetails.Controls.Add(Me.txtCustomerAddress)
        Me.pnlCustomerDetails.Controls.Add(Me.txtCustomerName)
        Me.pnlCustomerDetails.Controls.Add(Me.BunifuLabel4)
        Me.pnlCustomerDetails.Controls.Add(Me.BunifuLabel3)
        Me.pnlCustomerDetails.Controls.Add(Me.BunifuLabel2)
        Me.pnlCustomerDetails.Controls.Add(Me.BunifuLabel1)
        Me.pnlCustomerDetails.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlCustomerDetails.Location = New System.Drawing.Point(25, 25)
        Me.pnlCustomerDetails.Name = "pnlCustomerDetails"
        Me.pnlCustomerDetails.ShadowDecoration.Enabled = True
        Me.pnlCustomerDetails.ShadowDecoration.Parent = Me.pnlCustomerDetails
        Me.pnlCustomerDetails.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlCustomerDetails.Size = New System.Drawing.Size(300, 305)
        Me.pnlCustomerDetails.TabIndex = 0
        Me.tooltip.SetToolTip(Me.pnlCustomerDetails, "")
        Me.tooltip.SetToolTipIcon(Me.pnlCustomerDetails, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlCustomerDetails, "")
        '
        'btnShowCustomerList
        '
        Me.btnShowCustomerList.Animated = True
        Me.btnShowCustomerList.BackColor = System.Drawing.Color.Transparent
        Me.btnShowCustomerList.BorderRadius = 6
        Me.btnShowCustomerList.CheckedState.Parent = Me.btnShowCustomerList
        Me.btnShowCustomerList.CustomImages.Parent = Me.btnShowCustomerList
        Me.btnShowCustomerList.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnShowCustomerList.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowCustomerList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnShowCustomerList.HoverState.Parent = Me.btnShowCustomerList
        Me.btnShowCustomerList.Location = New System.Drawing.Point(239, 115)
        Me.btnShowCustomerList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShowCustomerList.Name = "btnShowCustomerList"
        Me.btnShowCustomerList.ShadowDecoration.Enabled = True
        Me.btnShowCustomerList.ShadowDecoration.Parent = Me.btnShowCustomerList
        Me.btnShowCustomerList.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnShowCustomerList.Size = New System.Drawing.Size(36, 36)
        Me.btnShowCustomerList.TabIndex = 3
        Me.btnShowCustomerList.Text = "..."
        Me.tooltip.SetToolTip(Me.btnShowCustomerList, "")
        Me.tooltip.SetToolTipIcon(Me.btnShowCustomerList, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnShowCustomerList, "")
        '
        'cmbxCustomerType
        '
        Me.cmbxCustomerType.BackColor = System.Drawing.Color.Transparent
        Me.cmbxCustomerType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxCustomerType.BorderRadius = 6
        Me.cmbxCustomerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxCustomerType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxCustomerType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxCustomerType.FocusedState.Parent = Me.cmbxCustomerType
        Me.cmbxCustomerType.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxCustomerType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxCustomerType.FormattingEnabled = True
        Me.cmbxCustomerType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmbxCustomerType.HoverState.Parent = Me.cmbxCustomerType
        Me.cmbxCustomerType.ItemHeight = 30
        Me.cmbxCustomerType.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbxCustomerType.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxCustomerType.ItemsAppearance.Parent = Me.cmbxCustomerType
        Me.cmbxCustomerType.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxCustomerType.ItemsAppearance.SelectedFont = New System.Drawing.Font("Roboto", 8.0!)
        Me.cmbxCustomerType.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxCustomerType.Location = New System.Drawing.Point(25, 49)
        Me.cmbxCustomerType.Name = "cmbxCustomerType"
        Me.cmbxCustomerType.ShadowDecoration.Enabled = True
        Me.cmbxCustomerType.ShadowDecoration.Parent = Me.cmbxCustomerType
        Me.cmbxCustomerType.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cmbxCustomerType.Size = New System.Drawing.Size(250, 36)
        Me.cmbxCustomerType.TabIndex = 12
        Me.cmbxCustomerType.TextOffset = New System.Drawing.Point(1, 2)
        Me.tooltip.SetToolTip(Me.cmbxCustomerType, "")
        Me.tooltip.SetToolTipIcon(Me.cmbxCustomerType, Nothing)
        Me.tooltip.SetToolTipTitle(Me.cmbxCustomerType, "")
        '
        'txtCustomerNumber
        '
        Me.txtCustomerNumber.Animated = True
        Me.txtCustomerNumber.BackColor = System.Drawing.Color.Transparent
        Me.txtCustomerNumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtCustomerNumber.BorderRadius = 6
        Me.txtCustomerNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerNumber.DefaultText = ""
        Me.txtCustomerNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomerNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomerNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerNumber.DisabledState.Parent = Me.txtCustomerNumber
        Me.txtCustomerNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtCustomerNumber.FocusedState.Parent = Me.txtCustomerNumber
        Me.txtCustomerNumber.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtCustomerNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtCustomerNumber.HoverState.Parent = Me.txtCustomerNumber
        Me.txtCustomerNumber.Location = New System.Drawing.Point(25, 244)
        Me.txtCustomerNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustomerNumber.Name = "txtCustomerNumber"
        Me.txtCustomerNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomerNumber.PlaceholderText = ""
        Me.txtCustomerNumber.SelectedText = ""
        Me.txtCustomerNumber.ShadowDecoration.Enabled = True
        Me.txtCustomerNumber.ShadowDecoration.Parent = Me.txtCustomerNumber
        Me.txtCustomerNumber.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtCustomerNumber.Size = New System.Drawing.Size(250, 36)
        Me.txtCustomerNumber.TabIndex = 10
        Me.tooltip.SetToolTip(Me.txtCustomerNumber, "")
        Me.tooltip.SetToolTipIcon(Me.txtCustomerNumber, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtCustomerNumber, "")
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Animated = True
        Me.txtCustomerAddress.BackColor = System.Drawing.Color.Transparent
        Me.txtCustomerAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtCustomerAddress.BorderRadius = 6
        Me.txtCustomerAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerAddress.DefaultText = ""
        Me.txtCustomerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerAddress.DisabledState.Parent = Me.txtCustomerAddress
        Me.txtCustomerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtCustomerAddress.FocusedState.Parent = Me.txtCustomerAddress
        Me.txtCustomerAddress.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtCustomerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtCustomerAddress.HoverState.Parent = Me.txtCustomerAddress
        Me.txtCustomerAddress.Location = New System.Drawing.Point(25, 179)
        Me.txtCustomerAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomerAddress.PlaceholderText = ""
        Me.txtCustomerAddress.SelectedText = ""
        Me.txtCustomerAddress.ShadowDecoration.Enabled = True
        Me.txtCustomerAddress.ShadowDecoration.Parent = Me.txtCustomerAddress
        Me.txtCustomerAddress.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtCustomerAddress.Size = New System.Drawing.Size(250, 36)
        Me.txtCustomerAddress.TabIndex = 10
        Me.tooltip.SetToolTip(Me.txtCustomerAddress, "")
        Me.tooltip.SetToolTipIcon(Me.txtCustomerAddress, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtCustomerAddress, "")
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Animated = True
        Me.txtCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.txtCustomerName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtCustomerName.BorderRadius = 6
        Me.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerName.DefaultText = ""
        Me.txtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerName.DisabledState.Parent = Me.txtCustomerName
        Me.txtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtCustomerName.FocusedState.Parent = Me.txtCustomerName
        Me.txtCustomerName.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtCustomerName.HoverState.Parent = Me.txtCustomerName
        Me.txtCustomerName.Location = New System.Drawing.Point(25, 114)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomerName.PlaceholderText = ""
        Me.txtCustomerName.SelectedText = ""
        Me.txtCustomerName.ShadowDecoration.Enabled = True
        Me.txtCustomerName.ShadowDecoration.Parent = Me.txtCustomerName
        Me.txtCustomerName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtCustomerName.Size = New System.Drawing.Size(208, 36)
        Me.txtCustomerName.TabIndex = 10
        Me.tooltip.SetToolTip(Me.txtCustomerName, "")
        Me.tooltip.SetToolTipIcon(Me.txtCustomerName, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtCustomerName, "")
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.AutoSize = False
        Me.BunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel4.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel4.Location = New System.Drawing.Point(25, 220)
        Me.BunifuLabel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(250, 19)
        Me.BunifuLabel4.TabIndex = 9
        Me.BunifuLabel4.Text = "Customer number"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel4, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel4, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel4, "")
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.AutoSize = False
        Me.BunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel3.Location = New System.Drawing.Point(25, 155)
        Me.BunifuLabel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(250, 19)
        Me.BunifuLabel3.TabIndex = 9
        Me.BunifuLabel3.Text = "Customer address"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel3, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel3, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel3, "")
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.AutoSize = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel2.Location = New System.Drawing.Point(25, 90)
        Me.BunifuLabel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(250, 19)
        Me.BunifuLabel2.TabIndex = 9
        Me.BunifuLabel2.Text = "Customer name"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel2, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel2, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel2, "")
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
        Me.BunifuLabel1.Size = New System.Drawing.Size(250, 19)
        Me.BunifuLabel1.TabIndex = 9
        Me.BunifuLabel1.Text = "Customer type"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel1, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel1, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel1, "")
        '
        'pnlPayment
        '
        Me.pnlPayment.BackColor = System.Drawing.Color.Transparent
        Me.pnlPayment.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlPayment.BorderRadius = 6
        Me.pnlPayment.Controls.Add(Me.txtServiceFee)
        Me.pnlPayment.Controls.Add(Me.txtPayment)
        Me.pnlPayment.Controls.Add(Me.cmbxServiceType)
        Me.pnlPayment.Controls.Add(Me.cmbxPaymentType)
        Me.pnlPayment.Controls.Add(Me.BunifuLabel8)
        Me.pnlPayment.Controls.Add(Me.BunifuLabel7)
        Me.pnlPayment.Controls.Add(Me.BunifuLabel6)
        Me.pnlPayment.Controls.Add(Me.BunifuLabel5)
        Me.pnlPayment.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlPayment.Location = New System.Drawing.Point(350, 25)
        Me.pnlPayment.Name = "pnlPayment"
        Me.pnlPayment.ShadowDecoration.Enabled = True
        Me.pnlPayment.ShadowDecoration.Parent = Me.pnlPayment
        Me.pnlPayment.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlPayment.Size = New System.Drawing.Size(300, 305)
        Me.pnlPayment.TabIndex = 0
        Me.tooltip.SetToolTip(Me.pnlPayment, "")
        Me.tooltip.SetToolTipIcon(Me.pnlPayment, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlPayment, "")
        '
        'txtServiceFee
        '
        Me.txtServiceFee.Animated = True
        Me.txtServiceFee.BackColor = System.Drawing.Color.Transparent
        Me.txtServiceFee.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtServiceFee.BorderRadius = 6
        Me.txtServiceFee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtServiceFee.DefaultText = ""
        Me.txtServiceFee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtServiceFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtServiceFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServiceFee.DisabledState.Parent = Me.txtServiceFee
        Me.txtServiceFee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServiceFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtServiceFee.FocusedState.Parent = Me.txtServiceFee
        Me.txtServiceFee.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtServiceFee.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtServiceFee.HoverState.Parent = Me.txtServiceFee
        Me.txtServiceFee.Location = New System.Drawing.Point(25, 244)
        Me.txtServiceFee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtServiceFee.Name = "txtServiceFee"
        Me.txtServiceFee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServiceFee.PlaceholderText = ""
        Me.txtServiceFee.SelectedText = ""
        Me.txtServiceFee.ShadowDecoration.Enabled = True
        Me.txtServiceFee.ShadowDecoration.Parent = Me.txtServiceFee
        Me.txtServiceFee.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtServiceFee.Size = New System.Drawing.Size(250, 36)
        Me.txtServiceFee.TabIndex = 10
        Me.tooltip.SetToolTip(Me.txtServiceFee, "")
        Me.tooltip.SetToolTipIcon(Me.txtServiceFee, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtServiceFee, "")
        '
        'txtPayment
        '
        Me.txtPayment.Animated = True
        Me.txtPayment.BackColor = System.Drawing.Color.Transparent
        Me.txtPayment.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtPayment.BorderRadius = 6
        Me.txtPayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPayment.DefaultText = ""
        Me.txtPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPayment.DisabledState.Parent = Me.txtPayment
        Me.txtPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtPayment.FocusedState.Parent = Me.txtPayment
        Me.txtPayment.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtPayment.HoverState.Parent = Me.txtPayment
        Me.txtPayment.Location = New System.Drawing.Point(25, 114)
        Me.txtPayment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPayment.PlaceholderText = ""
        Me.txtPayment.SelectedText = ""
        Me.txtPayment.ShadowDecoration.Enabled = True
        Me.txtPayment.ShadowDecoration.Parent = Me.txtPayment
        Me.txtPayment.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtPayment.Size = New System.Drawing.Size(250, 36)
        Me.txtPayment.TabIndex = 10
        Me.tooltip.SetToolTip(Me.txtPayment, "")
        Me.tooltip.SetToolTipIcon(Me.txtPayment, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtPayment, "")
        '
        'cmbxServiceType
        '
        Me.cmbxServiceType.BackColor = System.Drawing.Color.Transparent
        Me.cmbxServiceType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxServiceType.BorderRadius = 6
        Me.cmbxServiceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbxServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxServiceType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxServiceType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxServiceType.FocusedState.Parent = Me.cmbxServiceType
        Me.cmbxServiceType.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxServiceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxServiceType.FormattingEnabled = True
        Me.cmbxServiceType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmbxServiceType.HoverState.Parent = Me.cmbxServiceType
        Me.cmbxServiceType.ItemHeight = 30
        Me.cmbxServiceType.Items.AddRange(New Object() {"Deliver", "Dine in", "Take out"})
        Me.cmbxServiceType.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbxServiceType.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxServiceType.ItemsAppearance.Parent = Me.cmbxServiceType
        Me.cmbxServiceType.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxServiceType.ItemsAppearance.SelectedFont = New System.Drawing.Font("Roboto", 8.0!)
        Me.cmbxServiceType.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxServiceType.Location = New System.Drawing.Point(25, 179)
        Me.cmbxServiceType.Name = "cmbxServiceType"
        Me.cmbxServiceType.ShadowDecoration.Enabled = True
        Me.cmbxServiceType.ShadowDecoration.Parent = Me.cmbxServiceType
        Me.cmbxServiceType.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cmbxServiceType.Size = New System.Drawing.Size(250, 36)
        Me.cmbxServiceType.StartIndex = 0
        Me.cmbxServiceType.TabIndex = 12
        Me.cmbxServiceType.TextOffset = New System.Drawing.Point(1, 2)
        Me.tooltip.SetToolTip(Me.cmbxServiceType, "")
        Me.tooltip.SetToolTipIcon(Me.cmbxServiceType, Nothing)
        Me.tooltip.SetToolTipTitle(Me.cmbxServiceType, "")
        '
        'cmbxPaymentType
        '
        Me.cmbxPaymentType.BackColor = System.Drawing.Color.Transparent
        Me.cmbxPaymentType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxPaymentType.BorderRadius = 6
        Me.cmbxPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxPaymentType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxPaymentType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxPaymentType.FocusedState.Parent = Me.cmbxPaymentType
        Me.cmbxPaymentType.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxPaymentType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxPaymentType.FormattingEnabled = True
        Me.cmbxPaymentType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmbxPaymentType.HoverState.Parent = Me.cmbxPaymentType
        Me.cmbxPaymentType.ItemHeight = 30
        Me.cmbxPaymentType.Items.AddRange(New Object() {"Cash"})
        Me.cmbxPaymentType.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbxPaymentType.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxPaymentType.ItemsAppearance.Parent = Me.cmbxPaymentType
        Me.cmbxPaymentType.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxPaymentType.ItemsAppearance.SelectedFont = New System.Drawing.Font("Roboto", 8.0!)
        Me.cmbxPaymentType.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxPaymentType.Location = New System.Drawing.Point(25, 49)
        Me.cmbxPaymentType.Name = "cmbxPaymentType"
        Me.cmbxPaymentType.ShadowDecoration.Enabled = True
        Me.cmbxPaymentType.ShadowDecoration.Parent = Me.cmbxPaymentType
        Me.cmbxPaymentType.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cmbxPaymentType.Size = New System.Drawing.Size(250, 36)
        Me.cmbxPaymentType.StartIndex = 0
        Me.cmbxPaymentType.TabIndex = 12
        Me.cmbxPaymentType.TextOffset = New System.Drawing.Point(1, 2)
        Me.tooltip.SetToolTip(Me.cmbxPaymentType, "")
        Me.tooltip.SetToolTipIcon(Me.cmbxPaymentType, Nothing)
        Me.tooltip.SetToolTipTitle(Me.cmbxPaymentType, "")
        '
        'BunifuLabel8
        '
        Me.BunifuLabel8.AllowParentOverrides = False
        Me.BunifuLabel8.AutoEllipsis = False
        Me.BunifuLabel8.AutoSize = False
        Me.BunifuLabel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel8.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel8.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel8.Location = New System.Drawing.Point(25, 220)
        Me.BunifuLabel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel8.Name = "BunifuLabel8"
        Me.BunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel8.Size = New System.Drawing.Size(250, 19)
        Me.BunifuLabel8.TabIndex = 9
        Me.BunifuLabel8.Text = "Service fee"
        Me.BunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel8, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel8, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel8, "")
        '
        'BunifuLabel7
        '
        Me.BunifuLabel7.AllowParentOverrides = False
        Me.BunifuLabel7.AutoEllipsis = False
        Me.BunifuLabel7.AutoSize = False
        Me.BunifuLabel7.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel7.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel7.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel7.Location = New System.Drawing.Point(25, 90)
        Me.BunifuLabel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel7.Name = "BunifuLabel7"
        Me.BunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel7.Size = New System.Drawing.Size(250, 19)
        Me.BunifuLabel7.TabIndex = 9
        Me.BunifuLabel7.Text = "Payment"
        Me.BunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel7, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel7, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel7, "")
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AllowParentOverrides = False
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.AutoSize = False
        Me.BunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel6.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel6.Location = New System.Drawing.Point(25, 155)
        Me.BunifuLabel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel6.Name = "BunifuLabel6"
        Me.BunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel6.Size = New System.Drawing.Size(250, 19)
        Me.BunifuLabel6.TabIndex = 9
        Me.BunifuLabel6.Text = "Service type"
        Me.BunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel6, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel6, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel6, "")
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.AutoSize = False
        Me.BunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel5.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel5.Location = New System.Drawing.Point(25, 25)
        Me.BunifuLabel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(250, 19)
        Me.BunifuLabel5.TabIndex = 9
        Me.BunifuLabel5.Text = "Payment type"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel5, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel5, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel5, "")
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel3.BorderRadius = 6
        Me.Guna2Panel3.Controls.Add(Me.BunifuSeparator1)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel16)
        Me.Guna2Panel3.Controls.Add(Me.lblProductQuantity)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel14)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel13)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel20)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel11)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel12)
        Me.Guna2Panel3.Controls.Add(Me.lblTotalPrice)
        Me.Guna2Panel3.Controls.Add(Me.lblServiceFee)
        Me.Guna2Panel3.Controls.Add(Me.lblChange)
        Me.Guna2Panel3.Controls.Add(Me.lblDiscount)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel26)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel25)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel24)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel23)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel22)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel21)
        Me.Guna2Panel3.Controls.Add(Me.lblPayment)
        Me.Guna2Panel3.Controls.Add(Me.lblSubTotal)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel10)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel9)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(675, 25)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Enabled = True
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel3.Size = New System.Drawing.Size(300, 382)
        Me.Guna2Panel3.TabIndex = 0
        Me.tooltip.SetToolTip(Me.Guna2Panel3, "")
        Me.tooltip.SetToolTipIcon(Me.Guna2Panel3, Nothing)
        Me.tooltip.SetToolTipTitle(Me.Guna2Panel3, "")
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.BackgroundImage = CType(resources.GetObject("BunifuSeparator1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.BunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(38, 49)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator1.Size = New System.Drawing.Size(225, 14)
        Me.BunifuSeparator1.TabIndex = 12
        Me.tooltip.SetToolTip(Me.BunifuSeparator1, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuSeparator1, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuSeparator1, "")
        '
        'BunifuLabel16
        '
        Me.BunifuLabel16.AllowParentOverrides = False
        Me.BunifuLabel16.AutoEllipsis = False
        Me.BunifuLabel16.AutoSize = False
        Me.BunifuLabel16.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel16.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel16.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel16.Location = New System.Drawing.Point(25, 25)
        Me.BunifuLabel16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel16.Name = "BunifuLabel16"
        Me.BunifuLabel16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel16.Size = New System.Drawing.Size(250, 19)
        Me.BunifuLabel16.TabIndex = 11
        Me.BunifuLabel16.Text = "ITEM PREVIEW"
        Me.BunifuLabel16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel16.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel16, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel16, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel16, "")
        '
        'lblProductQuantity
        '
        Me.lblProductQuantity.AllowParentOverrides = False
        Me.lblProductQuantity.AutoEllipsis = False
        Me.lblProductQuantity.AutoSize = False
        Me.lblProductQuantity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblProductQuantity.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblProductQuantity.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.lblProductQuantity.Location = New System.Drawing.Point(165, 74)
        Me.lblProductQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblProductQuantity.Name = "lblProductQuantity"
        Me.lblProductQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblProductQuantity.Size = New System.Drawing.Size(110, 19)
        Me.lblProductQuantity.TabIndex = 10
        Me.lblProductQuantity.Text = "#########"
        Me.lblProductQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.lblProductQuantity.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblProductQuantity, "")
        Me.tooltip.SetToolTipIcon(Me.lblProductQuantity, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblProductQuantity, "")
        '
        'BunifuLabel14
        '
        Me.BunifuLabel14.AllowParentOverrides = False
        Me.BunifuLabel14.AutoEllipsis = False
        Me.BunifuLabel14.AutoSize = False
        Me.BunifuLabel14.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel14.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel14.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel14.Location = New System.Drawing.Point(25, 74)
        Me.BunifuLabel14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel14.Name = "BunifuLabel14"
        Me.BunifuLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel14.Size = New System.Drawing.Size(102, 19)
        Me.BunifuLabel14.TabIndex = 10
        Me.BunifuLabel14.Text = "Product quantity"
        Me.BunifuLabel14.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel14.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel14, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel14, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel14, "")
        '
        'BunifuLabel13
        '
        Me.BunifuLabel13.AllowParentOverrides = False
        Me.BunifuLabel13.AutoEllipsis = False
        Me.BunifuLabel13.AutoSize = False
        Me.BunifuLabel13.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel13.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel13.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel13.Location = New System.Drawing.Point(25, 338)
        Me.BunifuLabel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel13.Name = "BunifuLabel13"
        Me.BunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel13.Size = New System.Drawing.Size(70, 19)
        Me.BunifuLabel13.TabIndex = 9
        Me.BunifuLabel13.Text = "Total price"
        Me.BunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel13, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel13, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel13, "")
        '
        'BunifuLabel20
        '
        Me.BunifuLabel20.AllowParentOverrides = False
        Me.BunifuLabel20.AutoEllipsis = False
        Me.BunifuLabel20.AutoSize = False
        Me.BunifuLabel20.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel20.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel20.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel20.Location = New System.Drawing.Point(25, 206)
        Me.BunifuLabel20.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel20.Name = "BunifuLabel20"
        Me.BunifuLabel20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel20.Size = New System.Drawing.Size(70, 19)
        Me.BunifuLabel20.TabIndex = 9
        Me.BunifuLabel20.Text = "Service fee"
        Me.BunifuLabel20.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel20.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel20, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel20, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel20, "")
        '
        'BunifuLabel11
        '
        Me.BunifuLabel11.AllowParentOverrides = False
        Me.BunifuLabel11.AutoEllipsis = False
        Me.BunifuLabel11.AutoSize = False
        Me.BunifuLabel11.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel11.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel11.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel11.Location = New System.Drawing.Point(25, 250)
        Me.BunifuLabel11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel11.Name = "BunifuLabel11"
        Me.BunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel11.Size = New System.Drawing.Size(70, 19)
        Me.BunifuLabel11.TabIndex = 9
        Me.BunifuLabel11.Text = "Discount"
        Me.BunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel11, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel11, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel11, "")
        '
        'BunifuLabel12
        '
        Me.BunifuLabel12.AllowParentOverrides = False
        Me.BunifuLabel12.AutoEllipsis = False
        Me.BunifuLabel12.AutoSize = False
        Me.BunifuLabel12.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel12.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel12.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel12.Location = New System.Drawing.Point(25, 294)
        Me.BunifuLabel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel12.Name = "BunifuLabel12"
        Me.BunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel12.Size = New System.Drawing.Size(70, 19)
        Me.BunifuLabel12.TabIndex = 9
        Me.BunifuLabel12.Text = "Change"
        Me.BunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel12, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel12, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel12, "")
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AllowParentOverrides = False
        Me.lblTotalPrice.AutoEllipsis = False
        Me.lblTotalPrice.AutoSize = False
        Me.lblTotalPrice.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalPrice.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblTotalPrice.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPrice.Location = New System.Drawing.Point(185, 338)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalPrice.Size = New System.Drawing.Size(90, 19)
        Me.lblTotalPrice.TabIndex = 9
        Me.lblTotalPrice.Text = "#,###,###.##"
        Me.lblTotalPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblTotalPrice, "")
        Me.tooltip.SetToolTipIcon(Me.lblTotalPrice, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblTotalPrice, "")
        '
        'lblServiceFee
        '
        Me.lblServiceFee.AllowParentOverrides = False
        Me.lblServiceFee.AutoEllipsis = False
        Me.lblServiceFee.AutoSize = False
        Me.lblServiceFee.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblServiceFee.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblServiceFee.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.lblServiceFee.Location = New System.Drawing.Point(185, 206)
        Me.lblServiceFee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblServiceFee.Name = "lblServiceFee"
        Me.lblServiceFee.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblServiceFee.Size = New System.Drawing.Size(90, 19)
        Me.lblServiceFee.TabIndex = 9
        Me.lblServiceFee.Text = "#,###,###.##"
        Me.lblServiceFee.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.lblServiceFee.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblServiceFee, "")
        Me.tooltip.SetToolTipIcon(Me.lblServiceFee, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblServiceFee, "")
        '
        'lblChange
        '
        Me.lblChange.AllowParentOverrides = False
        Me.lblChange.AutoEllipsis = False
        Me.lblChange.AutoSize = False
        Me.lblChange.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChange.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblChange.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.lblChange.Location = New System.Drawing.Point(185, 294)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChange.Size = New System.Drawing.Size(90, 19)
        Me.lblChange.TabIndex = 9
        Me.lblChange.Text = "#,###,###.##"
        Me.lblChange.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.lblChange.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblChange, "")
        Me.tooltip.SetToolTipIcon(Me.lblChange, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblChange, "")
        '
        'lblDiscount
        '
        Me.lblDiscount.AllowParentOverrides = False
        Me.lblDiscount.AutoEllipsis = False
        Me.lblDiscount.AutoSize = False
        Me.lblDiscount.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDiscount.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblDiscount.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.lblDiscount.Location = New System.Drawing.Point(185, 250)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDiscount.Size = New System.Drawing.Size(90, 19)
        Me.lblDiscount.TabIndex = 9
        Me.lblDiscount.Text = "#,###,###.##"
        Me.lblDiscount.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDiscount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblDiscount, "")
        Me.tooltip.SetToolTipIcon(Me.lblDiscount, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblDiscount, "")
        '
        'BunifuLabel26
        '
        Me.BunifuLabel26.AllowParentOverrides = False
        Me.BunifuLabel26.AutoEllipsis = False
        Me.BunifuLabel26.AutoSize = False
        Me.BunifuLabel26.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel26.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel26.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel26.Location = New System.Drawing.Point(165, 338)
        Me.BunifuLabel26.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel26.Name = "BunifuLabel26"
        Me.BunifuLabel26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel26.Size = New System.Drawing.Size(14, 19)
        Me.BunifuLabel26.TabIndex = 9
        Me.BunifuLabel26.Text = "₱"
        Me.BunifuLabel26.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuLabel26.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel26, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel26, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel26, "")
        '
        'BunifuLabel25
        '
        Me.BunifuLabel25.AllowParentOverrides = False
        Me.BunifuLabel25.AutoEllipsis = False
        Me.BunifuLabel25.AutoSize = False
        Me.BunifuLabel25.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel25.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel25.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel25.Location = New System.Drawing.Point(165, 294)
        Me.BunifuLabel25.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel25.Name = "BunifuLabel25"
        Me.BunifuLabel25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel25.Size = New System.Drawing.Size(14, 19)
        Me.BunifuLabel25.TabIndex = 9
        Me.BunifuLabel25.Text = "₱"
        Me.BunifuLabel25.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuLabel25.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel25, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel25, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel25, "")
        '
        'BunifuLabel24
        '
        Me.BunifuLabel24.AllowParentOverrides = False
        Me.BunifuLabel24.AutoEllipsis = False
        Me.BunifuLabel24.AutoSize = False
        Me.BunifuLabel24.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel24.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel24.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel24.Location = New System.Drawing.Point(165, 250)
        Me.BunifuLabel24.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel24.Name = "BunifuLabel24"
        Me.BunifuLabel24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel24.Size = New System.Drawing.Size(14, 19)
        Me.BunifuLabel24.TabIndex = 9
        Me.BunifuLabel24.Text = "₱"
        Me.BunifuLabel24.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuLabel24.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel24, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel24, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel24, "")
        '
        'BunifuLabel23
        '
        Me.BunifuLabel23.AllowParentOverrides = False
        Me.BunifuLabel23.AutoEllipsis = False
        Me.BunifuLabel23.AutoSize = False
        Me.BunifuLabel23.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel23.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel23.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel23.Location = New System.Drawing.Point(165, 206)
        Me.BunifuLabel23.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel23.Name = "BunifuLabel23"
        Me.BunifuLabel23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel23.Size = New System.Drawing.Size(14, 19)
        Me.BunifuLabel23.TabIndex = 9
        Me.BunifuLabel23.Text = "₱"
        Me.BunifuLabel23.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuLabel23.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel23, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel23, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel23, "")
        '
        'BunifuLabel22
        '
        Me.BunifuLabel22.AllowParentOverrides = False
        Me.BunifuLabel22.AutoEllipsis = False
        Me.BunifuLabel22.AutoSize = False
        Me.BunifuLabel22.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel22.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel22.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel22.Location = New System.Drawing.Point(165, 162)
        Me.BunifuLabel22.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel22.Name = "BunifuLabel22"
        Me.BunifuLabel22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel22.Size = New System.Drawing.Size(14, 19)
        Me.BunifuLabel22.TabIndex = 9
        Me.BunifuLabel22.Text = "₱"
        Me.BunifuLabel22.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuLabel22.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel22, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel22, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel22, "")
        '
        'BunifuLabel21
        '
        Me.BunifuLabel21.AllowParentOverrides = False
        Me.BunifuLabel21.AutoEllipsis = False
        Me.BunifuLabel21.AutoSize = False
        Me.BunifuLabel21.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel21.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel21.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel21.Location = New System.Drawing.Point(165, 118)
        Me.BunifuLabel21.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel21.Name = "BunifuLabel21"
        Me.BunifuLabel21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel21.Size = New System.Drawing.Size(14, 19)
        Me.BunifuLabel21.TabIndex = 9
        Me.BunifuLabel21.Text = "₱"
        Me.BunifuLabel21.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuLabel21.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel21, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel21, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel21, "")
        '
        'lblPayment
        '
        Me.lblPayment.AllowParentOverrides = False
        Me.lblPayment.AutoEllipsis = False
        Me.lblPayment.AutoSize = False
        Me.lblPayment.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPayment.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblPayment.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.lblPayment.Location = New System.Drawing.Point(185, 118)
        Me.lblPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPayment.Size = New System.Drawing.Size(90, 19)
        Me.lblPayment.TabIndex = 9
        Me.lblPayment.Text = "#,###,###.##"
        Me.lblPayment.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPayment.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblPayment, "")
        Me.tooltip.SetToolTipIcon(Me.lblPayment, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblPayment, "")
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AllowParentOverrides = False
        Me.lblSubTotal.AutoEllipsis = False
        Me.lblSubTotal.AutoSize = False
        Me.lblSubTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSubTotal.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblSubTotal.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.lblSubTotal.Location = New System.Drawing.Point(185, 162)
        Me.lblSubTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSubTotal.Size = New System.Drawing.Size(90, 19)
        Me.lblSubTotal.TabIndex = 9
        Me.lblSubTotal.Text = "#,###,###.##"
        Me.lblSubTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSubTotal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.lblSubTotal, "")
        Me.tooltip.SetToolTipIcon(Me.lblSubTotal, Nothing)
        Me.tooltip.SetToolTipTitle(Me.lblSubTotal, "")
        '
        'BunifuLabel10
        '
        Me.BunifuLabel10.AllowParentOverrides = False
        Me.BunifuLabel10.AutoEllipsis = False
        Me.BunifuLabel10.AutoSize = False
        Me.BunifuLabel10.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel10.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel10.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel10.Location = New System.Drawing.Point(25, 162)
        Me.BunifuLabel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel10.Name = "BunifuLabel10"
        Me.BunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel10.Size = New System.Drawing.Size(70, 19)
        Me.BunifuLabel10.TabIndex = 9
        Me.BunifuLabel10.Text = "Subtotal"
        Me.BunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel10, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel10, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel10, "")
        '
        'BunifuLabel9
        '
        Me.BunifuLabel9.AllowParentOverrides = False
        Me.BunifuLabel9.AutoEllipsis = False
        Me.BunifuLabel9.AutoSize = False
        Me.BunifuLabel9.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel9.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel9.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel9.Location = New System.Drawing.Point(25, 118)
        Me.BunifuLabel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel9.Name = "BunifuLabel9"
        Me.BunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel9.Size = New System.Drawing.Size(70, 19)
        Me.BunifuLabel9.TabIndex = 9
        Me.BunifuLabel9.Text = "Payment"
        Me.BunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel9, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel9, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel9, "")
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 6
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(675, 432)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnCancel.Size = New System.Drawing.Size(147, 36)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.tooltip.SetToolTip(Me.btnCancel, "")
        Me.tooltip.SetToolTipIcon(Me.btnCancel, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnCancel, "")
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Animated = True
        Me.btnPlaceOrder.BackColor = System.Drawing.Color.Transparent
        Me.btnPlaceOrder.BorderRadius = 6
        Me.btnPlaceOrder.CheckedState.Parent = Me.btnPlaceOrder
        Me.btnPlaceOrder.CustomImages.Parent = Me.btnPlaceOrder
        Me.btnPlaceOrder.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnPlaceOrder.HoverState.Parent = Me.btnPlaceOrder
        Me.btnPlaceOrder.Location = New System.Drawing.Point(828, 432)
        Me.btnPlaceOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.ShadowDecoration.Enabled = True
        Me.btnPlaceOrder.ShadowDecoration.Parent = Me.btnPlaceOrder
        Me.btnPlaceOrder.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnPlaceOrder.Size = New System.Drawing.Size(147, 36)
        Me.btnPlaceOrder.TabIndex = 3
        Me.btnPlaceOrder.Text = "Place order"
        Me.tooltip.SetToolTip(Me.btnPlaceOrder, "")
        Me.tooltip.SetToolTipIcon(Me.btnPlaceOrder, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnPlaceOrder, "")
        '
        'snackbar
        '
        Me.snackbar.AllowDragging = False
        Me.snackbar.AllowMultipleViews = False
        Me.snackbar.ClickToClose = True
        Me.snackbar.DoubleClickToClose = True
        Me.snackbar.DurationAfterIdle = 3000
        Me.snackbar.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.snackbar.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.snackbar.ErrorOptions.ActionBorderRadius = 6
        Me.snackbar.ErrorOptions.ActionFont = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.snackbar.ErrorOptions.ActionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.snackbar.ErrorOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.snackbar.ErrorOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.snackbar.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.snackbar.ErrorOptions.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.snackbar.ErrorOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.snackbar.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.snackbar.ErrorOptions.IconLeftMargin = 12
        Me.snackbar.FadeCloseIcon = False
        Me.snackbar.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.snackbar.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.snackbar.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.snackbar.InformationOptions.ActionBorderRadius = 6
        Me.snackbar.InformationOptions.ActionFont = New System.Drawing.Font("Roboto", 8.0!)
        Me.snackbar.InformationOptions.ActionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.snackbar.InformationOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.snackbar.InformationOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.snackbar.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.snackbar.InformationOptions.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.snackbar.InformationOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.snackbar.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.snackbar.InformationOptions.IconLeftMargin = 12
        Me.snackbar.Margin = 10
        Me.snackbar.MaximumSize = New System.Drawing.Size(0, 0)
        Me.snackbar.MaximumViews = 1
        Me.snackbar.MessageRightMargin = 15
        Me.snackbar.MinimumSize = New System.Drawing.Size(0, 0)
        Me.snackbar.ShowBorders = True
        Me.snackbar.ShowCloseIcon = False
        Me.snackbar.ShowIcon = True
        Me.snackbar.ShowShadows = False
        Me.snackbar.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.snackbar.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.snackbar.SuccessOptions.ActionBorderRadius = 6
        Me.snackbar.SuccessOptions.ActionFont = New System.Drawing.Font("Roboto", 8.0!)
        Me.snackbar.SuccessOptions.ActionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.snackbar.SuccessOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.snackbar.SuccessOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.snackbar.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.snackbar.SuccessOptions.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.snackbar.SuccessOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.snackbar.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.snackbar.SuccessOptions.IconLeftMargin = 12
        Me.snackbar.ViewsMargin = 7
        Me.snackbar.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.snackbar.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.snackbar.WarningOptions.ActionBorderRadius = 6
        Me.snackbar.WarningOptions.ActionFont = New System.Drawing.Font("Roboto", 8.0!)
        Me.snackbar.WarningOptions.ActionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.snackbar.WarningOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.snackbar.WarningOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.snackbar.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.snackbar.WarningOptions.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.snackbar.WarningOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.snackbar.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.snackbar.WarningOptions.IconLeftMargin = 12
        Me.snackbar.ZoomCloseIcon = True
        '
        'pnlDiscounts
        '
        Me.pnlDiscounts.BackColor = System.Drawing.Color.Transparent
        Me.pnlDiscounts.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlDiscounts.BorderRadius = 6
        Me.pnlDiscounts.Controls.Add(Me.txtStoreDiscount)
        Me.pnlDiscounts.Controls.Add(Me.btnShowDiscountList)
        Me.pnlDiscounts.Controls.Add(Me.txtAccountDiscount)
        Me.pnlDiscounts.Controls.Add(Me.BunifuLabel15)
        Me.pnlDiscounts.Controls.Add(Me.BunifuLabel17)
        Me.pnlDiscounts.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlDiscounts.Location = New System.Drawing.Point(25, 357)
        Me.pnlDiscounts.Name = "pnlDiscounts"
        Me.pnlDiscounts.ShadowDecoration.Enabled = True
        Me.pnlDiscounts.ShadowDecoration.Parent = Me.pnlDiscounts
        Me.pnlDiscounts.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlDiscounts.Size = New System.Drawing.Size(625, 111)
        Me.pnlDiscounts.TabIndex = 13
        Me.tooltip.SetToolTip(Me.pnlDiscounts, "")
        Me.tooltip.SetToolTipIcon(Me.pnlDiscounts, Nothing)
        Me.tooltip.SetToolTipTitle(Me.pnlDiscounts, "")
        '
        'txtStoreDiscount
        '
        Me.txtStoreDiscount.Animated = True
        Me.txtStoreDiscount.BackColor = System.Drawing.Color.Transparent
        Me.txtStoreDiscount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtStoreDiscount.BorderRadius = 6
        Me.txtStoreDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStoreDiscount.DefaultText = ""
        Me.txtStoreDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStoreDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStoreDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStoreDiscount.DisabledState.Parent = Me.txtStoreDiscount
        Me.txtStoreDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStoreDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtStoreDiscount.FocusedState.Parent = Me.txtStoreDiscount
        Me.txtStoreDiscount.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoreDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtStoreDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtStoreDiscount.HoverState.Parent = Me.txtStoreDiscount
        Me.txtStoreDiscount.Location = New System.Drawing.Point(25, 49)
        Me.txtStoreDiscount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStoreDiscount.Name = "txtStoreDiscount"
        Me.txtStoreDiscount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStoreDiscount.PlaceholderText = ""
        Me.txtStoreDiscount.SelectedText = ""
        Me.txtStoreDiscount.ShadowDecoration.Enabled = True
        Me.txtStoreDiscount.ShadowDecoration.Parent = Me.txtStoreDiscount
        Me.txtStoreDiscount.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtStoreDiscount.Size = New System.Drawing.Size(250, 36)
        Me.txtStoreDiscount.TabIndex = 13
        Me.tooltip.SetToolTip(Me.txtStoreDiscount, "")
        Me.tooltip.SetToolTipIcon(Me.txtStoreDiscount, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtStoreDiscount, "")
        '
        'btnShowDiscountList
        '
        Me.btnShowDiscountList.Animated = True
        Me.btnShowDiscountList.BackColor = System.Drawing.Color.Transparent
        Me.btnShowDiscountList.BorderRadius = 6
        Me.btnShowDiscountList.CheckedState.Parent = Me.btnShowDiscountList
        Me.btnShowDiscountList.CustomImages.Parent = Me.btnShowDiscountList
        Me.btnShowDiscountList.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnShowDiscountList.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowDiscountList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnShowDiscountList.HoverState.Parent = Me.btnShowDiscountList
        Me.btnShowDiscountList.Location = New System.Drawing.Point(294, 49)
        Me.btnShowDiscountList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShowDiscountList.Name = "btnShowDiscountList"
        Me.btnShowDiscountList.ShadowDecoration.Enabled = True
        Me.btnShowDiscountList.ShadowDecoration.Parent = Me.btnShowDiscountList
        Me.btnShowDiscountList.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnShowDiscountList.Size = New System.Drawing.Size(36, 36)
        Me.btnShowDiscountList.TabIndex = 13
        Me.btnShowDiscountList.Text = "..."
        Me.tooltip.SetToolTip(Me.btnShowDiscountList, "")
        Me.tooltip.SetToolTipIcon(Me.btnShowDiscountList, Nothing)
        Me.tooltip.SetToolTipTitle(Me.btnShowDiscountList, "")
        '
        'txtAccountDiscount
        '
        Me.txtAccountDiscount.Animated = True
        Me.txtAccountDiscount.BackColor = System.Drawing.Color.Transparent
        Me.txtAccountDiscount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtAccountDiscount.BorderRadius = 6
        Me.txtAccountDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAccountDiscount.DefaultText = ""
        Me.txtAccountDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAccountDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAccountDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAccountDiscount.DisabledState.Parent = Me.txtAccountDiscount
        Me.txtAccountDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAccountDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtAccountDiscount.FocusedState.Parent = Me.txtAccountDiscount
        Me.txtAccountDiscount.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtAccountDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtAccountDiscount.HoverState.Parent = Me.txtAccountDiscount
        Me.txtAccountDiscount.Location = New System.Drawing.Point(350, 49)
        Me.txtAccountDiscount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAccountDiscount.Name = "txtAccountDiscount"
        Me.txtAccountDiscount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccountDiscount.PlaceholderText = ""
        Me.txtAccountDiscount.SelectedText = ""
        Me.txtAccountDiscount.ShadowDecoration.Enabled = True
        Me.txtAccountDiscount.ShadowDecoration.Parent = Me.txtAccountDiscount
        Me.txtAccountDiscount.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtAccountDiscount.Size = New System.Drawing.Size(250, 36)
        Me.txtAccountDiscount.TabIndex = 10
        Me.tooltip.SetToolTip(Me.txtAccountDiscount, "")
        Me.tooltip.SetToolTipIcon(Me.txtAccountDiscount, Nothing)
        Me.tooltip.SetToolTipTitle(Me.txtAccountDiscount, "")
        '
        'BunifuLabel15
        '
        Me.BunifuLabel15.AllowParentOverrides = False
        Me.BunifuLabel15.AutoEllipsis = False
        Me.BunifuLabel15.AutoSize = False
        Me.BunifuLabel15.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel15.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel15.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel15.Location = New System.Drawing.Point(350, 25)
        Me.BunifuLabel15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel15.Name = "BunifuLabel15"
        Me.BunifuLabel15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel15.Size = New System.Drawing.Size(250, 19)
        Me.BunifuLabel15.TabIndex = 9
        Me.BunifuLabel15.Text = "Applied customer's account discount"
        Me.BunifuLabel15.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel15.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel15, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel15, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel15, "")
        '
        'BunifuLabel17
        '
        Me.BunifuLabel17.AllowParentOverrides = False
        Me.BunifuLabel17.AutoEllipsis = False
        Me.BunifuLabel17.AutoSize = False
        Me.BunifuLabel17.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel17.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel17.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel17.Location = New System.Drawing.Point(25, 25)
        Me.BunifuLabel17.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel17.Name = "BunifuLabel17"
        Me.BunifuLabel17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel17.Size = New System.Drawing.Size(250, 19)
        Me.BunifuLabel17.TabIndex = 9
        Me.BunifuLabel17.Text = "Active store discount"
        Me.BunifuLabel17.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel17.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.tooltip.SetToolTip(Me.BunifuLabel17, "")
        Me.tooltip.SetToolTipIcon(Me.BunifuLabel17, Nothing)
        Me.tooltip.SetToolTipTitle(Me.BunifuLabel17, "")
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
        'frmPlaceOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 493)
        Me.Controls.Add(Me.pnlDiscounts)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.pnlPayment)
        Me.Controls.Add(Me.pnlCustomerDetails)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPlaceOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlCustomerDetails.ResumeLayout(False)
        Me.pnlPayment.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.pnlDiscounts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents formShadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents pnlCustomerDetails As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlPayment As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtCustomerName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents cmbxCustomerType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtCustomerNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCustomerAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnShowCustomerList As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbxPaymentType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BunifuLabel7 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtServiceFee As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbxServiceType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BunifuLabel8 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel6 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnPlaceOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BunifuLabel13 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel11 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel12 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblTotalPrice As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblChange As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblDiscount As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblPayment As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblSubTotal As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel10 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel9 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel20 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblServiceFee As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel26 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel25 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel24 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel23 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel22 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel21 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents snackbar As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents pnlDiscounts As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtAccountDiscount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuLabel15 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel17 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnShowDiscountList As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BunifuLabel16 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel14 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents lblProductQuantity As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtStoreDiscount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tooltip As Bunifu.UI.WinForms.BunifuToolTip
End Class
