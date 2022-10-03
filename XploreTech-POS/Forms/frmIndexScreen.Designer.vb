<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndexScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIndexScreen))
        Me.btnInventorySettings = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.shadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.drag = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnlControl = New Bunifu.UI.WinForms.BunifuPanel()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblIndexScreenTitle = New Bunifu.UI.WinForms.BunifuLabel()
        Me.snackbar = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.shape = New Bunifu.UI.WinForms.BunifuShapes()
        Me.lblAccountName = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblAccountUsernameId = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnOtherSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.picLogo = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnPointOfSale = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlChildForm = New Bunifu.UI.WinForms.BunifuPanel()
        Me.pnlControl.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInventorySettings
        '
        Me.btnInventorySettings.Animated = True
        Me.btnInventorySettings.BackColor = System.Drawing.Color.Transparent
        Me.btnInventorySettings.BorderRadius = 6
        Me.btnInventorySettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnInventorySettings.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnInventorySettings.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnInventorySettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnInventorySettings.CheckedState.Parent = Me.btnInventorySettings
        Me.btnInventorySettings.CustomImages.Parent = Me.btnInventorySettings
        Me.btnInventorySettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btnInventorySettings.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventorySettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnInventorySettings.HoverState.Parent = Me.btnInventorySettings
        Me.btnInventorySettings.Image = Global.XploreTech_POS.My.Resources.Resources.button_product
        Me.btnInventorySettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnInventorySettings.ImageOffset = New System.Drawing.Point(21, 0)
        Me.btnInventorySettings.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnInventorySettings.Location = New System.Drawing.Point(25, 407)
        Me.btnInventorySettings.Name = "btnInventorySettings"
        Me.btnInventorySettings.ShadowDecoration.Enabled = True
        Me.btnInventorySettings.ShadowDecoration.Parent = Me.btnInventorySettings
        Me.btnInventorySettings.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnInventorySettings.Size = New System.Drawing.Size(176, 36)
        Me.btnInventorySettings.TabIndex = 10
        Me.btnInventorySettings.Text = "Inventory Settings"
        Me.btnInventorySettings.TextOffset = New System.Drawing.Point(8, 0)
        '
        'btnReports
        '
        Me.btnReports.Animated = True
        Me.btnReports.BackColor = System.Drawing.Color.Transparent
        Me.btnReports.BorderRadius = 6
        Me.btnReports.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnReports.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnReports.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnReports.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnReports.CheckedState.Parent = Me.btnReports
        Me.btnReports.CustomImages.Parent = Me.btnReports
        Me.btnReports.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btnReports.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnReports.HoverState.Parent = Me.btnReports
        Me.btnReports.Image = Global.XploreTech_POS.My.Resources.Resources.button_report
        Me.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReports.ImageOffset = New System.Drawing.Point(45, 0)
        Me.btnReports.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnReports.Location = New System.Drawing.Point(25, 491)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.ShadowDecoration.Enabled = True
        Me.btnReports.ShadowDecoration.Parent = Me.btnReports
        Me.btnReports.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnReports.Size = New System.Drawing.Size(176, 36)
        Me.btnReports.TabIndex = 10
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnLogout
        '
        Me.btnLogout.Animated = True
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BorderRadius = 6
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Location = New System.Drawing.Point(25, 619)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Enabled = True
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnLogout.Size = New System.Drawing.Size(176, 36)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
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
        Me.pnlControl.Controls.Add(Me.lblIndexScreenTitle)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControl.Location = New System.Drawing.Point(0, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.ShowBorders = True
        Me.pnlControl.Size = New System.Drawing.Size(1180, 34)
        Me.pnlControl.TabIndex = 8
        '
        'btnMinimize
        '
        Me.btnMinimize.Animated = True
        Me.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnMinimize.HoverState.Parent = Me.btnMinimize
        Me.btnMinimize.IconColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnMinimize.Location = New System.Drawing.Point(1090, 0)
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
        Me.btnClose.Location = New System.Drawing.Point(1135, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(45, 34)
        Me.btnClose.TabIndex = 1
        '
        'lblIndexScreenTitle
        '
        Me.lblIndexScreenTitle.AllowParentOverrides = False
        Me.lblIndexScreenTitle.AutoEllipsis = False
        Me.lblIndexScreenTitle.CursorType = Nothing
        Me.lblIndexScreenTitle.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndexScreenTitle.Location = New System.Drawing.Point(7, 9)
        Me.lblIndexScreenTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblIndexScreenTitle.Name = "lblIndexScreenTitle"
        Me.lblIndexScreenTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblIndexScreenTitle.Size = New System.Drawing.Size(221, 19)
        Me.lblIndexScreenTitle.TabIndex = 99
        Me.lblIndexScreenTitle.TabStop = False
        Me.lblIndexScreenTitle.Text = "D'Creamy Milktea House | Admin"
        Me.lblIndexScreenTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblIndexScreenTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
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
        'shape
        '
        Me.shape.Angle = 0!
        Me.shape.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.shape.BorderColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.shape.BorderThickness = 2
        Me.shape.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.shape.FillShape = True
        Me.shape.Location = New System.Drawing.Point(45, 79)
        Me.shape.Name = "shape"
        Me.shape.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle
        Me.shape.Sides = 5
        Me.shape.Size = New System.Drawing.Size(136, 136)
        Me.shape.TabIndex = 11
        Me.shape.Text = "BunifuShapes1"
        '
        'lblAccountName
        '
        Me.lblAccountName.AllowParentOverrides = False
        Me.lblAccountName.AutoEllipsis = False
        Me.lblAccountName.AutoSize = False
        Me.lblAccountName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAccountName.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblAccountName.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.Location = New System.Drawing.Point(25, 241)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAccountName.Size = New System.Drawing.Size(176, 14)
        Me.lblAccountName.TabIndex = 0
        Me.lblAccountName.Text = "User account name"
        Me.lblAccountName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAccountName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblAccountUsernameId
        '
        Me.lblAccountUsernameId.AllowParentOverrides = False
        Me.lblAccountUsernameId.AutoEllipsis = False
        Me.lblAccountUsernameId.AutoSize = False
        Me.lblAccountUsernameId.CursorType = Nothing
        Me.lblAccountUsernameId.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountUsernameId.Location = New System.Drawing.Point(25, 261)
        Me.lblAccountUsernameId.Name = "lblAccountUsernameId"
        Me.lblAccountUsernameId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAccountUsernameId.Size = New System.Drawing.Size(176, 14)
        Me.lblAccountUsernameId.TabIndex = 0
        Me.lblAccountUsernameId.Text = "Username - userid"
        Me.lblAccountUsernameId.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAccountUsernameId.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'btnOtherSettings
        '
        Me.btnOtherSettings.Animated = True
        Me.btnOtherSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnOtherSettings.BorderRadius = 6
        Me.btnOtherSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnOtherSettings.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnOtherSettings.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnOtherSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnOtherSettings.CheckedState.Parent = Me.btnOtherSettings
        Me.btnOtherSettings.CustomImages.Parent = Me.btnOtherSettings
        Me.btnOtherSettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btnOtherSettings.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtherSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnOtherSettings.HoverState.Parent = Me.btnOtherSettings
        Me.btnOtherSettings.Image = Global.XploreTech_POS.My.Resources.Resources.button_settings
        Me.btnOtherSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOtherSettings.ImageOffset = New System.Drawing.Point(30, 0)
        Me.btnOtherSettings.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnOtherSettings.Location = New System.Drawing.Point(25, 449)
        Me.btnOtherSettings.Name = "btnOtherSettings"
        Me.btnOtherSettings.ShadowDecoration.Enabled = True
        Me.btnOtherSettings.ShadowDecoration.Parent = Me.btnOtherSettings
        Me.btnOtherSettings.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnOtherSettings.Size = New System.Drawing.Size(176, 36)
        Me.btnOtherSettings.TabIndex = 10
        Me.btnOtherSettings.Text = "Other Settings"
        Me.btnOtherSettings.TextOffset = New System.Drawing.Point(9, 0)
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.XploreTech_POS.My.Resources.Resources.logo_dcreamy_milktea_house
        Me.picLogo.Location = New System.Drawing.Point(50, 84)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.picLogo.ShadowDecoration.Parent = Me.picLogo
        Me.picLogo.Size = New System.Drawing.Size(126, 126)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        Me.picLogo.UseTransparentBackground = True
        '
        'btnPointOfSale
        '
        Me.btnPointOfSale.Animated = True
        Me.btnPointOfSale.BackColor = System.Drawing.Color.Transparent
        Me.btnPointOfSale.BorderRadius = 6
        Me.btnPointOfSale.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnPointOfSale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnPointOfSale.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnPointOfSale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnPointOfSale.CheckedState.Parent = Me.btnPointOfSale
        Me.btnPointOfSale.CustomImages.Parent = Me.btnPointOfSale
        Me.btnPointOfSale.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btnPointOfSale.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPointOfSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnPointOfSale.HoverState.Parent = Me.btnPointOfSale
        Me.btnPointOfSale.Image = Global.XploreTech_POS.My.Resources.Resources.button_point_of_sale
        Me.btnPointOfSale.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPointOfSale.ImageOffset = New System.Drawing.Point(35, 0)
        Me.btnPointOfSale.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnPointOfSale.Location = New System.Drawing.Point(25, 365)
        Me.btnPointOfSale.Name = "btnPointOfSale"
        Me.btnPointOfSale.ShadowDecoration.Enabled = True
        Me.btnPointOfSale.ShadowDecoration.Parent = Me.btnPointOfSale
        Me.btnPointOfSale.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnPointOfSale.Size = New System.Drawing.Size(176, 36)
        Me.btnPointOfSale.TabIndex = 10
        Me.btnPointOfSale.Text = "Point of Sale"
        Me.btnPointOfSale.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnDashboard
        '
        Me.btnDashboard.Animated = True
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BorderRadius = 6
        Me.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnDashboard.Checked = True
        Me.btnDashboard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnDashboard.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnDashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnDashboard.CheckedState.Parent = Me.btnDashboard
        Me.btnDashboard.CustomImages.Parent = Me.btnDashboard
        Me.btnDashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btnDashboard.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Image = Global.XploreTech_POS.My.Resources.Resources.button_dashboard
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageOffset = New System.Drawing.Point(40, 0)
        Me.btnDashboard.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnDashboard.Location = New System.Drawing.Point(25, 323)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.ShadowDecoration.Enabled = True
        Me.btnDashboard.ShadowDecoration.Parent = Me.btnDashboard
        Me.btnDashboard.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnDashboard.Size = New System.Drawing.Size(176, 36)
        Me.btnDashboard.TabIndex = 10
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextOffset = New System.Drawing.Point(10, 0)
        '
        'pnlChildForm
        '
        Me.pnlChildForm.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.pnlChildForm.BackgroundImage = CType(resources.GetObject("pnlChildForm.BackgroundImage"), System.Drawing.Image)
        Me.pnlChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlChildForm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.pnlChildForm.BorderRadius = 0
        Me.pnlChildForm.BorderThickness = 0
        Me.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlChildForm.Location = New System.Drawing.Point(226, 34)
        Me.pnlChildForm.Name = "pnlChildForm"
        Me.pnlChildForm.ShowBorders = True
        Me.pnlChildForm.Size = New System.Drawing.Size(954, 646)
        Me.pnlChildForm.TabIndex = 9
        '
        'frmIndexScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1180, 680)
        Me.Controls.Add(Me.lblAccountUsernameId)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.shape)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnOtherSettings)
        Me.Controls.Add(Me.btnInventorySettings)
        Me.Controls.Add(Me.btnPointOfSale)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.pnlChildForm)
        Me.Controls.Add(Me.pnlControl)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIndexScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlControl As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblIndexScreenTitle As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents pnlChildForm As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPointOfSale As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnInventorySettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents shadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents drag As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents snackbar As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents shape As Bunifu.UI.WinForms.BunifuShapes
    Friend WithEvents picLogo As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblAccountUsernameId As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblAccountName As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnOtherSettings As Guna.UI2.WinForms.Guna2Button
End Class
