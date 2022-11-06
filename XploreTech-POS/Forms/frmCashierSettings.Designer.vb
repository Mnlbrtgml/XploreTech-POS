<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCashierSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashierSettings))
        Me.pnlGroupA = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlQRInformation = New Bunifu.UI.WinForms.BunifuPanel()
        Me.pcbQRCode = New System.Windows.Forms.PictureBox()
        Me.lblQRCodeWarning = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnDownload = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlAccountInformation = New Bunifu.UI.WinForms.BunifuPanel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.lblNumber = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.lblName = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblType = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblUsername = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblPassword = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtRetypePassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblRetypePassword = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.snackbar = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.pnlGroupA.SuspendLayout()
        Me.pnlQRInformation.SuspendLayout()
        CType(Me.pcbQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccountInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGroupA
        '
        Me.pnlGroupA.BackColor = System.Drawing.Color.Transparent
        Me.pnlGroupA.BorderRadius = 6
        Me.pnlGroupA.Controls.Add(Me.pnlQRInformation)
        Me.pnlGroupA.Controls.Add(Me.btnEditAccount)
        Me.pnlGroupA.Controls.Add(Me.pnlAccountInformation)
        Me.pnlGroupA.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlGroupA.Location = New System.Drawing.Point(0, 25)
        Me.pnlGroupA.Name = "pnlGroupA"
        Me.pnlGroupA.ShadowDecoration.Enabled = True
        Me.pnlGroupA.ShadowDecoration.Parent = Me.pnlGroupA
        Me.pnlGroupA.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlGroupA.Size = New System.Drawing.Size(929, 596)
        Me.pnlGroupA.TabIndex = 0
        '
        'pnlQRInformation
        '
        Me.pnlQRInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlQRInformation.BackgroundImage = CType(resources.GetObject("pnlQRInformation.BackgroundImage"), System.Drawing.Image)
        Me.pnlQRInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlQRInformation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlQRInformation.BorderRadius = 0
        Me.pnlQRInformation.BorderThickness = 0
        Me.pnlQRInformation.Controls.Add(Me.lblQRCodeWarning)
        Me.pnlQRInformation.Controls.Add(Me.pcbQRCode)
        Me.pnlQRInformation.Controls.Add(Me.btnDownload)
        Me.pnlQRInformation.Location = New System.Drawing.Point(529, 128)
        Me.pnlQRInformation.Name = "pnlQRInformation"
        Me.pnlQRInformation.ShowBorders = True
        Me.pnlQRInformation.Size = New System.Drawing.Size(296, 340)
        Me.pnlQRInformation.TabIndex = 2
        '
        'pcbQRCode
        '
        Me.pcbQRCode.Location = New System.Drawing.Point(10, 0)
        Me.pcbQRCode.Name = "pcbQRCode"
        Me.pcbQRCode.Size = New System.Drawing.Size(276, 276)
        Me.pcbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbQRCode.TabIndex = 2
        Me.pcbQRCode.TabStop = False
        '
        'lblQRCodeWarning
        '
        Me.lblQRCodeWarning.AllowParentOverrides = False
        Me.lblQRCodeWarning.AutoEllipsis = False
        Me.lblQRCodeWarning.AutoSize = False
        Me.lblQRCodeWarning.BackColor = System.Drawing.Color.White
        Me.lblQRCodeWarning.CursorType = Nothing
        Me.lblQRCodeWarning.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQRCodeWarning.Location = New System.Drawing.Point(43, 121)
        Me.lblQRCodeWarning.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblQRCodeWarning.Name = "lblQRCodeWarning"
        Me.lblQRCodeWarning.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQRCodeWarning.Size = New System.Drawing.Size(207, 40)
        Me.lblQRCodeWarning.TabIndex = 1
        Me.lblQRCodeWarning.TabStop = False
        Me.lblQRCodeWarning.Text = "There is problem generating qr code"
        Me.lblQRCodeWarning.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblQRCodeWarning.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.lblQRCodeWarning.Visible = False
        '
        'btnDownload
        '
        Me.btnDownload.Animated = True
        Me.btnDownload.BackColor = System.Drawing.Color.Transparent
        Me.btnDownload.BorderRadius = 6
        Me.btnDownload.CheckedState.Parent = Me.btnDownload
        Me.btnDownload.CustomImages.Parent = Me.btnDownload
        Me.btnDownload.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnDownload.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.btnDownload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnDownload.HoverState.Parent = Me.btnDownload
        Me.btnDownload.Location = New System.Drawing.Point(10, 294)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.ShadowDecoration.Enabled = True
        Me.btnDownload.ShadowDecoration.Parent = Me.btnDownload
        Me.btnDownload.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnDownload.Size = New System.Drawing.Size(276, 36)
        Me.btnDownload.TabIndex = 0
        Me.btnDownload.TabStop = False
        Me.btnDownload.Text = "Download"
        '
        'btnEditAccount
        '
        Me.btnEditAccount.Animated = True
        Me.btnEditAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnEditAccount.BorderRadius = 6
        Me.btnEditAccount.CheckedState.Parent = Me.btnEditAccount
        Me.btnEditAccount.CustomImages.Parent = Me.btnEditAccount
        Me.btnEditAccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEditAccount.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnEditAccount.HoverState.Parent = Me.btnEditAccount
        Me.btnEditAccount.Location = New System.Drawing.Point(754, 25)
        Me.btnEditAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditAccount.Name = "btnEditAccount"
        Me.btnEditAccount.ShadowDecoration.Enabled = True
        Me.btnEditAccount.ShadowDecoration.Parent = Me.btnEditAccount
        Me.btnEditAccount.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnEditAccount.Size = New System.Drawing.Size(150, 36)
        Me.btnEditAccount.TabIndex = 0
        Me.btnEditAccount.TabStop = False
        Me.btnEditAccount.Text = "Edit account"
        '
        'pnlAccountInformation
        '
        Me.pnlAccountInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlAccountInformation.BackgroundImage = CType(resources.GetObject("pnlAccountInformation.BackgroundImage"), System.Drawing.Image)
        Me.pnlAccountInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlAccountInformation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlAccountInformation.BorderRadius = 0
        Me.pnlAccountInformation.BorderThickness = 0
        Me.pnlAccountInformation.Controls.Add(Me.btnSave)
        Me.pnlAccountInformation.Controls.Add(Me.lblNumber)
        Me.pnlAccountInformation.Controls.Add(Me.btnCancel)
        Me.pnlAccountInformation.Controls.Add(Me.lblName)
        Me.pnlAccountInformation.Controls.Add(Me.lblType)
        Me.pnlAccountInformation.Controls.Add(Me.lblUsername)
        Me.pnlAccountInformation.Controls.Add(Me.lblPassword)
        Me.pnlAccountInformation.Controls.Add(Me.txtRetypePassword)
        Me.pnlAccountInformation.Controls.Add(Me.lblRetypePassword)
        Me.pnlAccountInformation.Controls.Add(Me.txtPassword)
        Me.pnlAccountInformation.Controls.Add(Me.txtName)
        Me.pnlAccountInformation.Controls.Add(Me.txtNumber)
        Me.pnlAccountInformation.Controls.Add(Me.txtUsername)
        Me.pnlAccountInformation.Controls.Add(Me.txtType)
        Me.pnlAccountInformation.Location = New System.Drawing.Point(104, 65)
        Me.pnlAccountInformation.Name = "pnlAccountInformation"
        Me.pnlAccountInformation.ShowBorders = True
        Me.pnlAccountInformation.Size = New System.Drawing.Size(420, 466)
        Me.pnlAccountInformation.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 6
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(213, 420)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Enabled = True
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnSave.Size = New System.Drawing.Size(150, 36)
        Me.btnSave.TabIndex = 4
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save"
        Me.btnSave.Visible = False
        '
        'lblNumber
        '
        Me.lblNumber.AllowParentOverrides = False
        Me.lblNumber.AutoEllipsis = False
        Me.lblNumber.AutoSize = False
        Me.lblNumber.CursorType = Nothing
        Me.lblNumber.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(10, 10)
        Me.lblNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumber.Size = New System.Drawing.Size(205, 19)
        Me.lblNumber.TabIndex = 6
        Me.lblNumber.TabStop = False
        Me.lblNumber.Text = "My account number"
        Me.lblNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNumber.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
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
        Me.btnCancel.Location = New System.Drawing.Point(57, 420)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnCancel.Size = New System.Drawing.Size(150, 36)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Visible = False
        '
        'lblName
        '
        Me.lblName.AllowParentOverrides = False
        Me.lblName.AutoEllipsis = False
        Me.lblName.AutoSize = False
        Me.lblName.CursorType = Nothing
        Me.lblName.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(10, 75)
        Me.lblName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblName.Name = "lblName"
        Me.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblName.Size = New System.Drawing.Size(205, 19)
        Me.lblName.TabIndex = 7
        Me.lblName.TabStop = False
        Me.lblName.Text = "My account name"
        Me.lblName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblType
        '
        Me.lblType.AllowParentOverrides = False
        Me.lblType.AutoEllipsis = False
        Me.lblType.AutoSize = False
        Me.lblType.CursorType = Nothing
        Me.lblType.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(10, 140)
        Me.lblType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblType.Name = "lblType"
        Me.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblType.Size = New System.Drawing.Size(205, 19)
        Me.lblType.TabIndex = 8
        Me.lblType.TabStop = False
        Me.lblType.Text = "My account type"
        Me.lblType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblType.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblUsername
        '
        Me.lblUsername.AllowParentOverrides = False
        Me.lblUsername.AutoEllipsis = False
        Me.lblUsername.AutoSize = False
        Me.lblUsername.CursorType = Nothing
        Me.lblUsername.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(10, 205)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUsername.Size = New System.Drawing.Size(205, 19)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.TabStop = False
        Me.lblUsername.Text = "My username"
        Me.lblUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsername.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblPassword
        '
        Me.lblPassword.AllowParentOverrides = False
        Me.lblPassword.AutoEllipsis = False
        Me.lblPassword.AutoSize = False
        Me.lblPassword.CursorType = Nothing
        Me.lblPassword.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(10, 270)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPassword.Size = New System.Drawing.Size(205, 19)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.TabStop = False
        Me.lblPassword.Text = "My password"
        Me.lblPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPassword.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtRetypePassword
        '
        Me.txtRetypePassword.Animated = True
        Me.txtRetypePassword.BackColor = System.Drawing.Color.Transparent
        Me.txtRetypePassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtRetypePassword.BorderRadius = 6
        Me.txtRetypePassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRetypePassword.DefaultText = ""
        Me.txtRetypePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRetypePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRetypePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRetypePassword.DisabledState.Parent = Me.txtRetypePassword
        Me.txtRetypePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRetypePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtRetypePassword.FocusedState.Parent = Me.txtRetypePassword
        Me.txtRetypePassword.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.txtRetypePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtRetypePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtRetypePassword.HoverState.Parent = Me.txtRetypePassword
        Me.txtRetypePassword.Location = New System.Drawing.Point(10, 359)
        Me.txtRetypePassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRetypePassword.Name = "txtRetypePassword"
        Me.txtRetypePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRetypePassword.PlaceholderText = "Password"
        Me.txtRetypePassword.SelectedText = ""
        Me.txtRetypePassword.ShadowDecoration.Enabled = True
        Me.txtRetypePassword.ShadowDecoration.Parent = Me.txtRetypePassword
        Me.txtRetypePassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtRetypePassword.Size = New System.Drawing.Size(400, 36)
        Me.txtRetypePassword.TabIndex = 3
        Me.txtRetypePassword.TabStop = False
        Me.txtRetypePassword.Visible = False
        '
        'lblRetypePassword
        '
        Me.lblRetypePassword.AllowParentOverrides = False
        Me.lblRetypePassword.AutoEllipsis = False
        Me.lblRetypePassword.AutoSize = False
        Me.lblRetypePassword.CursorType = Nothing
        Me.lblRetypePassword.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetypePassword.Location = New System.Drawing.Point(10, 335)
        Me.lblRetypePassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblRetypePassword.Name = "lblRetypePassword"
        Me.lblRetypePassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRetypePassword.Size = New System.Drawing.Size(205, 19)
        Me.lblRetypePassword.TabIndex = 11
        Me.lblRetypePassword.TabStop = False
        Me.lblRetypePassword.Text = "Re-type password"
        Me.lblRetypePassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRetypePassword.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.lblRetypePassword.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtPassword.BorderRadius = 6
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(10, 294)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Enabled = True
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtPassword.Size = New System.Drawing.Size(400, 36)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TabStop = False
        '
        'txtName
        '
        Me.txtName.Animated = True
        Me.txtName.BackColor = System.Drawing.Color.Transparent
        Me.txtName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtName.BorderRadius = 6
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.Parent = Me.txtName
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtName.FocusedState.Parent = Me.txtName
        Me.txtName.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtName.HoverState.Parent = Me.txtName
        Me.txtName.Location = New System.Drawing.Point(10, 99)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = "Account name"
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Enabled = True
        Me.txtName.ShadowDecoration.Parent = Me.txtName
        Me.txtName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtName.Size = New System.Drawing.Size(400, 36)
        Me.txtName.TabIndex = 0
        Me.txtName.TabStop = False
        '
        'txtNumber
        '
        Me.txtNumber.Animated = True
        Me.txtNumber.BackColor = System.Drawing.Color.Transparent
        Me.txtNumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtNumber.BorderRadius = 6
        Me.txtNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumber.DefaultText = ""
        Me.txtNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumber.DisabledState.Parent = Me.txtNumber
        Me.txtNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtNumber.FocusedState.Parent = Me.txtNumber
        Me.txtNumber.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.txtNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtNumber.HoverState.Parent = Me.txtNumber
        Me.txtNumber.Location = New System.Drawing.Point(10, 34)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumber.PlaceholderText = "Account number"
        Me.txtNumber.SelectedText = ""
        Me.txtNumber.ShadowDecoration.Enabled = True
        Me.txtNumber.ShadowDecoration.Parent = Me.txtNumber
        Me.txtNumber.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtNumber.Size = New System.Drawing.Size(400, 36)
        Me.txtNumber.TabIndex = 12
        Me.txtNumber.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtUsername.BorderRadius = 6
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(10, 229)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Enabled = True
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtUsername.Size = New System.Drawing.Size(400, 36)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TabStop = False
        '
        'txtType
        '
        Me.txtType.Animated = True
        Me.txtType.BackColor = System.Drawing.Color.Transparent
        Me.txtType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtType.BorderRadius = 6
        Me.txtType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtType.DefaultText = ""
        Me.txtType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtType.DisabledState.Parent = Me.txtType
        Me.txtType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtType.FocusedState.Parent = Me.txtType
        Me.txtType.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.txtType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtType.HoverState.Parent = Me.txtType
        Me.txtType.Location = New System.Drawing.Point(10, 164)
        Me.txtType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtType.Name = "txtType"
        Me.txtType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtType.PlaceholderText = "Account type"
        Me.txtType.SelectedText = ""
        Me.txtType.ShadowDecoration.Enabled = True
        Me.txtType.ShadowDecoration.Parent = Me.txtType
        Me.txtType.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtType.Size = New System.Drawing.Size(400, 36)
        Me.txtType.TabIndex = 13
        Me.txtType.TabStop = False
        '
        'snackbar
        '
        Me.snackbar.AllowDragging = False
        Me.snackbar.AllowMultipleViews = True
        Me.snackbar.ClickToClose = True
        Me.snackbar.DoubleClickToClose = True
        Me.snackbar.DurationAfterIdle = 3000
        Me.snackbar.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar.ErrorOptions.ActionBorderRadius = 1
        Me.snackbar.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.snackbar.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.snackbar.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.snackbar.ErrorOptions.IconLeftMargin = 12
        Me.snackbar.FadeCloseIcon = False
        Me.snackbar.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.snackbar.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar.InformationOptions.ActionBorderRadius = 1
        Me.snackbar.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar.InformationOptions.BackColor = System.Drawing.Color.White
        Me.snackbar.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.snackbar.InformationOptions.IconLeftMargin = 12
        Me.snackbar.Margin = 10
        Me.snackbar.MaximumSize = New System.Drawing.Size(0, 0)
        Me.snackbar.MaximumViews = 7
        Me.snackbar.MessageRightMargin = 15
        Me.snackbar.MinimumSize = New System.Drawing.Size(0, 0)
        Me.snackbar.ShowBorders = False
        Me.snackbar.ShowCloseIcon = False
        Me.snackbar.ShowIcon = True
        Me.snackbar.ShowShadows = True
        Me.snackbar.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar.SuccessOptions.ActionBorderRadius = 1
        Me.snackbar.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.snackbar.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.snackbar.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.snackbar.SuccessOptions.IconLeftMargin = 12
        Me.snackbar.ViewsMargin = 7
        Me.snackbar.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar.WarningOptions.ActionBorderRadius = 1
        Me.snackbar.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar.WarningOptions.BackColor = System.Drawing.Color.White
        Me.snackbar.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.snackbar.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.snackbar.WarningOptions.IconLeftMargin = 12
        Me.snackbar.ZoomCloseIcon = True
        '
        'frmCashierSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 646)
        Me.Controls.Add(Me.pnlGroupA)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCashierSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlGroupA.ResumeLayout(False)
        Me.pnlQRInformation.ResumeLayout(False)
        CType(Me.pcbQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccountInformation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlGroupA As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblQRCodeWarning As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDownload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPassword As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblUsername As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblType As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblNumber As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblName As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents pnlAccountInformation As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents txtRetypePassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblRetypePassword As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlQRInformation As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents txtType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents snackbar As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents pcbQRCode As PictureBox
End Class
