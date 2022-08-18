<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginScreen))
        Me.shadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.drag = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnlControl = New Bunifu.UI.WinForms.BunifuPanel()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BunifuLabel15 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPassword = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblUsername = New Bunifu.UI.WinForms.BunifuLabel()
        Me.snackbar = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.cbxShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.btnScanQRCode = New Guna.UI2.WinForms.Guna2Button()
        Me.lnkCreateNewAccount = New System.Windows.Forms.LinkLabel()
        Me.lblHeader1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblHeader2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.pnlScanQRCode = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblWarningNoCamera = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblScanAttemptTimer = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblWarningMessage = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.pbxCamera = New System.Windows.Forms.PictureBox()
        Me.tmrLoginRetry = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScanner = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScannerCounter = New System.Windows.Forms.Timer(Me.components)
        Me.CameraRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlControl.SuspendLayout()
        Me.pnlScanQRCode.SuspendLayout()
        CType(Me.pbxCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'elipse
        '
        Me.elipse.ElipseRadius = 6
        Me.elipse.TargetControl = Me
        '
        'drag
        '
        Me.drag.Fixed = True
        Me.drag.Horizontal = True
        Me.drag.TargetControl = Me.pnlControl
        Me.drag.Vertical = True
        '
        'pnlControl
        '
        Me.pnlControl.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.pnlControl.BackgroundImage = CType(resources.GetObject("pnlControl.BackgroundImage"), System.Drawing.Image)
        Me.pnlControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlControl.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.pnlControl.BorderRadius = 0
        Me.pnlControl.BorderThickness = 0
        Me.pnlControl.Controls.Add(Me.btnMinimize)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Controls.Add(Me.BunifuLabel15)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControl.Location = New System.Drawing.Point(0, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.ShowBorders = True
        Me.pnlControl.Size = New System.Drawing.Size(1025, 34)
        Me.pnlControl.TabIndex = 7
        '
        'btnMinimize
        '
        Me.btnMinimize.Animated = True
        Me.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnMinimize.HoverState.Parent = Me.btnMinimize
        Me.btnMinimize.IconColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnMinimize.Location = New System.Drawing.Point(935, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.ShadowDecoration.Parent = Me.btnMinimize
        Me.btnMinimize.Size = New System.Drawing.Size(45, 34)
        Me.btnMinimize.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.IconColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(980, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(45, 34)
        Me.btnClose.TabIndex = 1
        '
        'BunifuLabel15
        '
        Me.BunifuLabel15.AllowParentOverrides = False
        Me.BunifuLabel15.AutoEllipsis = False
        Me.BunifuLabel15.CursorType = Nothing
        Me.BunifuLabel15.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel15.Location = New System.Drawing.Point(7, 9)
        Me.BunifuLabel15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel15.Name = "BunifuLabel15"
        Me.BunifuLabel15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel15.Size = New System.Drawing.Size(171, 15)
        Me.BunifuLabel15.TabIndex = 99
        Me.BunifuLabel15.TabStop = False
        Me.BunifuLabel15.Text = "D'Creamy Milktea House | Login"
        Me.BunifuLabel15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel15.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
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
        Me.txtPassword.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(76, 316)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Enabled = True
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtPassword.Size = New System.Drawing.Size(250, 36)
        Me.txtPassword.TabIndex = 1
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
        Me.txtUsername.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(76, 251)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Enabled = True
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtUsername.Size = New System.Drawing.Size(250, 36)
        Me.txtUsername.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.AllowParentOverrides = False
        Me.lblPassword.AutoEllipsis = False
        Me.lblPassword.AutoSize = False
        Me.lblPassword.CursorType = Nothing
        Me.lblPassword.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(76, 292)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPassword.Size = New System.Drawing.Size(205, 19)
        Me.lblPassword.TabIndex = 99
        Me.lblPassword.TabStop = False
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPassword.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblUsername
        '
        Me.lblUsername.AllowParentOverrides = False
        Me.lblUsername.AutoEllipsis = False
        Me.lblUsername.AutoSize = False
        Me.lblUsername.CursorType = Nothing
        Me.lblUsername.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(76, 227)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUsername.Size = New System.Drawing.Size(205, 19)
        Me.lblUsername.TabIndex = 99
        Me.lblUsername.TabStop = False
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsername.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
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
        'cbxShowPassword
        '
        Me.cbxShowPassword.AutoSize = True
        Me.cbxShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cbxShowPassword.CheckedState.BorderRadius = 2
        Me.cbxShowPassword.CheckedState.BorderThickness = 0
        Me.cbxShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cbxShowPassword.CheckMarkColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cbxShowPassword.Location = New System.Drawing.Point(76, 358)
        Me.cbxShowPassword.Name = "cbxShowPassword"
        Me.cbxShowPassword.Size = New System.Drawing.Size(112, 18)
        Me.cbxShowPassword.TabIndex = 2
        Me.cbxShowPassword.Text = "Show password"
        Me.cbxShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cbxShowPassword.UncheckedState.BorderRadius = 2
        Me.cbxShowPassword.UncheckedState.BorderThickness = 1
        Me.cbxShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cbxShowPassword.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderRadius = 6
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(76, 424)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Enabled = True
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnLogin.Size = New System.Drawing.Size(250, 36)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        '
        'btnScanQRCode
        '
        Me.btnScanQRCode.BackColor = System.Drawing.Color.Transparent
        Me.btnScanQRCode.BorderRadius = 6
        Me.btnScanQRCode.CheckedState.Parent = Me.btnScanQRCode
        Me.btnScanQRCode.CustomImages.Parent = Me.btnScanQRCode
        Me.btnScanQRCode.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnScanQRCode.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScanQRCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnScanQRCode.HoverState.Parent = Me.btnScanQRCode
        Me.btnScanQRCode.Location = New System.Drawing.Point(76, 466)
        Me.btnScanQRCode.Name = "btnScanQRCode"
        Me.btnScanQRCode.ShadowDecoration.Enabled = True
        Me.btnScanQRCode.ShadowDecoration.Parent = Me.btnScanQRCode
        Me.btnScanQRCode.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnScanQRCode.Size = New System.Drawing.Size(250, 36)
        Me.btnScanQRCode.TabIndex = 4
        Me.btnScanQRCode.Text = "Scan QR Code"
        '
        'lnkCreateNewAccount
        '
        Me.lnkCreateNewAccount.AutoSize = True
        Me.lnkCreateNewAccount.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCreateNewAccount.LinkColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.lnkCreateNewAccount.Location = New System.Drawing.Point(148, 514)
        Me.lnkCreateNewAccount.Name = "lnkCreateNewAccount"
        Me.lnkCreateNewAccount.Size = New System.Drawing.Size(106, 13)
        Me.lnkCreateNewAccount.TabIndex = 5
        Me.lnkCreateNewAccount.TabStop = True
        Me.lnkCreateNewAccount.Text = "Create new account"
        Me.lnkCreateNewAccount.Visible = False
        '
        'lblHeader1
        '
        Me.lblHeader1.AllowParentOverrides = False
        Me.lblHeader1.AutoEllipsis = False
        Me.lblHeader1.AutoSize = False
        Me.lblHeader1.CursorType = Nothing
        Me.lblHeader1.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader1.Location = New System.Drawing.Point(76, 93)
        Me.lblHeader1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblHeader1.Name = "lblHeader1"
        Me.lblHeader1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHeader1.Size = New System.Drawing.Size(205, 19)
        Me.lblHeader1.TabIndex = 10
        Me.lblHeader1.TabStop = False
        Me.lblHeader1.Text = "Welcome to"
        Me.lblHeader1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHeader1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblHeader2
        '
        Me.lblHeader2.AllowParentOverrides = False
        Me.lblHeader2.AutoEllipsis = False
        Me.lblHeader2.AutoSize = False
        Me.lblHeader2.CursorType = Nothing
        Me.lblHeader2.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader2.Location = New System.Drawing.Point(76, 116)
        Me.lblHeader2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblHeader2.Name = "lblHeader2"
        Me.lblHeader2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHeader2.Size = New System.Drawing.Size(250, 84)
        Me.lblHeader2.TabIndex = 99
        Me.lblHeader2.TabStop = False
        Me.lblHeader2.Text = "D'Creamy Milktea House"
        Me.lblHeader2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHeader2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'pnlScanQRCode
        '
        Me.pnlScanQRCode.BackColor = System.Drawing.Color.Transparent
        Me.pnlScanQRCode.BorderRadius = 6
        Me.pnlScanQRCode.Controls.Add(Me.lblWarningNoCamera)
        Me.pnlScanQRCode.Controls.Add(Me.lblScanAttemptTimer)
        Me.pnlScanQRCode.Controls.Add(Me.lblWarningMessage)
        Me.pnlScanQRCode.Controls.Add(Me.BunifuLabel3)
        Me.pnlScanQRCode.Controls.Add(Me.btnCancel)
        Me.pnlScanQRCode.Controls.Add(Me.pbxCamera)
        Me.pnlScanQRCode.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlScanQRCode.Location = New System.Drawing.Point(538, 59)
        Me.pnlScanQRCode.Name = "pnlScanQRCode"
        Me.pnlScanQRCode.ShadowDecoration.Enabled = True
        Me.pnlScanQRCode.ShadowDecoration.Parent = Me.pnlScanQRCode
        Me.pnlScanQRCode.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlScanQRCode.Size = New System.Drawing.Size(462, 514)
        Me.pnlScanQRCode.TabIndex = 6
        Me.pnlScanQRCode.Visible = False
        '
        'lblWarningNoCamera
        '
        Me.lblWarningNoCamera.AllowParentOverrides = False
        Me.lblWarningNoCamera.AutoEllipsis = False
        Me.lblWarningNoCamera.AutoSize = False
        Me.lblWarningNoCamera.BackColor = System.Drawing.SystemColors.Control
        Me.lblWarningNoCamera.CursorType = Nothing
        Me.lblWarningNoCamera.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarningNoCamera.Location = New System.Drawing.Point(112, 136)
        Me.lblWarningNoCamera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblWarningNoCamera.Name = "lblWarningNoCamera"
        Me.lblWarningNoCamera.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWarningNoCamera.Size = New System.Drawing.Size(242, 154)
        Me.lblWarningNoCamera.TabIndex = 99
        Me.lblWarningNoCamera.TabStop = False
        Me.lblWarningNoCamera.Text = "No camera detected"
        Me.lblWarningNoCamera.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWarningNoCamera.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.lblWarningNoCamera.Visible = False
        '
        'lblScanAttemptTimer
        '
        Me.lblScanAttemptTimer.AllowParentOverrides = False
        Me.lblScanAttemptTimer.AutoEllipsis = False
        Me.lblScanAttemptTimer.AutoSize = False
        Me.lblScanAttemptTimer.CursorType = Nothing
        Me.lblScanAttemptTimer.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScanAttemptTimer.Location = New System.Drawing.Point(30, 406)
        Me.lblScanAttemptTimer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblScanAttemptTimer.Name = "lblScanAttemptTimer"
        Me.lblScanAttemptTimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblScanAttemptTimer.Size = New System.Drawing.Size(412, 19)
        Me.lblScanAttemptTimer.TabIndex = 99
        Me.lblScanAttemptTimer.TabStop = False
        Me.lblScanAttemptTimer.Text = "You can try again in [timer] seconds"
        Me.lblScanAttemptTimer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblScanAttemptTimer.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.lblScanAttemptTimer.Visible = False
        '
        'lblWarningMessage
        '
        Me.lblWarningMessage.AllowParentOverrides = False
        Me.lblWarningMessage.AutoEllipsis = False
        Me.lblWarningMessage.AutoSize = False
        Me.lblWarningMessage.CursorType = Nothing
        Me.lblWarningMessage.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarningMessage.Location = New System.Drawing.Point(30, 383)
        Me.lblWarningMessage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblWarningMessage.Name = "lblWarningMessage"
        Me.lblWarningMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWarningMessage.Size = New System.Drawing.Size(412, 19)
        Me.lblWarningMessage.TabIndex = 99
        Me.lblWarningMessage.TabStop = False
        Me.lblWarningMessage.Text = "You have reached your maximum number of attempt"
        Me.lblWarningMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWarningMessage.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.lblWarningMessage.Visible = False
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.AutoSize = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.Location = New System.Drawing.Point(25, 25)
        Me.BunifuLabel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(412, 19)
        Me.BunifuLabel3.TabIndex = 99
        Me.BunifuLabel3.TabStop = False
        Me.BunifuLabel3.Text = "Place your QR Code at the center of the camera to scan properly"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 6
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(158, 453)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnCancel.Size = New System.Drawing.Size(150, 36)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'pbxCamera
        '
        Me.pbxCamera.BackColor = System.Drawing.SystemColors.Control
        Me.pbxCamera.Location = New System.Drawing.Point(25, 69)
        Me.pbxCamera.Name = "pbxCamera"
        Me.pbxCamera.Size = New System.Drawing.Size(412, 289)
        Me.pbxCamera.TabIndex = 101
        Me.pbxCamera.TabStop = False
        '
        'tmrLoginRetry
        '
        Me.tmrLoginRetry.Interval = 1000
        '
        'tmrScanner
        '
        Me.tmrScanner.Interval = 1000
        '
        'tmrScannerCounter
        '
        Me.tmrScannerCounter.Interval = 1000
        '
        'CameraRadius
        '
        Me.CameraRadius.ElipseRadius = 6
        Me.CameraRadius.TargetControl = Me.pbxCamera
        '
        'frmLoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.XploreTech_POS.My.Resources.Resources.background_login
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1025, 598)
        Me.Controls.Add(Me.pnlScanQRCode)
        Me.Controls.Add(Me.lnkCreateNewAccount)
        Me.Controls.Add(Me.btnScanQRCode)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.cbxShowPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblHeader2)
        Me.Controls.Add(Me.lblHeader1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pnlControl)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoginScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        Me.pnlScanQRCode.ResumeLayout(False)
        CType(Me.pbxCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents shadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents drag As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pnlControl As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BunifuLabel15 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPassword As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblUsername As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents snackbar As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents cbxShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnScanQRCode As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lnkCreateNewAccount As LinkLabel
    Friend WithEvents lblHeader2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblHeader1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents pnlScanQRCode As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblScanAttemptTimer As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblWarningMessage As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblWarningNoCamera As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents tmrLoginRetry As Timer
    Friend WithEvents tmrScanner As Timer
    Friend WithEvents tmrScannerCounter As Timer
    Friend WithEvents pbxCamera As PictureBox
    Friend WithEvents CameraRadius As Bunifu.Framework.UI.BunifuElipse
End Class
