<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateNewAccountScreen
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
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateNewAccountScreen))
        Me.shadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.drag = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnlControl = New Bunifu.UI.WinForms.BunifuPanel()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BunifuLabel15 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.pnlBackground = New Guna.UI2.WinForms.Guna2Panel()
        Me.page = New Bunifu.UI.WinForms.BunifuPages()
        Me.tpgInputInformation = New System.Windows.Forms.TabPage()
        Me.pnlInput = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel8 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtUserAccountNumber = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblPasswordWarning = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtInputType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel7 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel6 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtInputRetypePassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtInputPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtInputUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtInputNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtInputName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tpgReviewInformation = New System.Windows.Forms.TabPage()
        Me.lblQRCodeWarning = New Bunifu.UI.WinForms.BunifuLabel()
        Me.picQRCode = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDownload = New Guna.UI2.WinForms.Guna2Button()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BunifuLabel9 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel10 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel11 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel16 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel12 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.tpgSaveInformation = New System.Windows.Forms.TabPage()
        Me.BunifuLabel14 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel13 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnLoginNow = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlControl.SuspendLayout()
        Me.pnlBackground.SuspendLayout()
        Me.page.SuspendLayout()
        Me.tpgInputInformation.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.tpgReviewInformation.SuspendLayout()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgSaveInformation.SuspendLayout()
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
        Me.pnlControl.TabIndex = 1
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
        Me.btnMinimize.TabIndex = 8
        Me.btnMinimize.TabStop = False
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
        Me.btnClose.TabIndex = 7
        Me.btnClose.TabStop = False
        '
        'BunifuLabel15
        '
        Me.BunifuLabel15.AllowParentOverrides = False
        Me.BunifuLabel15.AutoEllipsis = False
        Me.BunifuLabel15.CursorType = Nothing
        Me.BunifuLabel15.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel15.Location = New System.Drawing.Point(7, 9)
        Me.BunifuLabel15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel15.Name = "BunifuLabel15"
        Me.BunifuLabel15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel15.Size = New System.Drawing.Size(249, 15)
        Me.BunifuLabel15.TabIndex = 5
        Me.BunifuLabel15.Text = "D'Creamy Milktea House | Create New Account"
        Me.BunifuLabel15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel15.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'pnlBackground
        '
        Me.pnlBackground.BackColor = System.Drawing.Color.Transparent
        Me.pnlBackground.BorderRadius = 6
        Me.pnlBackground.Controls.Add(Me.page)
        Me.pnlBackground.Controls.Add(Me.btnCancel)
        Me.pnlBackground.Controls.Add(Me.btnBack)
        Me.pnlBackground.Controls.Add(Me.btnNext)
        Me.pnlBackground.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlBackground.Location = New System.Drawing.Point(25, 59)
        Me.pnlBackground.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlBackground.Name = "pnlBackground"
        Me.pnlBackground.ShadowDecoration.Enabled = True
        Me.pnlBackground.ShadowDecoration.Parent = Me.pnlBackground
        Me.pnlBackground.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlBackground.Size = New System.Drawing.Size(975, 514)
        Me.pnlBackground.TabIndex = 2
        '
        'page
        '
        Me.page.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.page.AllowTransitions = False
        Me.page.Controls.Add(Me.tpgInputInformation)
        Me.page.Controls.Add(Me.tpgReviewInformation)
        Me.page.Controls.Add(Me.tpgSaveInformation)
        Me.page.Location = New System.Drawing.Point(25, 25)
        Me.page.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.page.Multiline = True
        Me.page.Name = "page"
        Me.page.Page = Me.tpgReviewInformation
        Me.page.PageIndex = 1
        Me.page.PageName = "tpgReviewInformation"
        Me.page.PageTitle = "Review Information"
        Me.page.SelectedIndex = 0
        Me.page.Size = New System.Drawing.Size(925, 402)
        Me.page.TabIndex = 0
        Animation1.AnimateOnlyDifferences = False
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.page.Transition = Animation1
        Me.page.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom
        '
        'tpgInputInformation
        '
        Me.tpgInputInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.tpgInputInformation.Controls.Add(Me.pnlInput)
        Me.tpgInputInformation.Location = New System.Drawing.Point(4, 4)
        Me.tpgInputInformation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpgInputInformation.Name = "tpgInputInformation"
        Me.tpgInputInformation.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpgInputInformation.Size = New System.Drawing.Size(917, 375)
        Me.tpgInputInformation.TabIndex = 0
        Me.tpgInputInformation.Text = "Input Information"
        '
        'pnlInput
        '
        Me.pnlInput.BackgroundColor = System.Drawing.Color.Transparent
        Me.pnlInput.BackgroundImage = CType(resources.GetObject("pnlInput.BackgroundImage"), System.Drawing.Image)
        Me.pnlInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlInput.BorderColor = System.Drawing.Color.Transparent
        Me.pnlInput.BorderRadius = 0
        Me.pnlInput.BorderThickness = 0
        Me.pnlInput.Controls.Add(Me.BunifuLabel1)
        Me.pnlInput.Controls.Add(Me.BunifuLabel8)
        Me.pnlInput.Controls.Add(Me.txtUserAccountNumber)
        Me.pnlInput.Controls.Add(Me.lblPasswordWarning)
        Me.pnlInput.Controls.Add(Me.BunifuLabel2)
        Me.pnlInput.Controls.Add(Me.txtInputType)
        Me.pnlInput.Controls.Add(Me.BunifuLabel7)
        Me.pnlInput.Controls.Add(Me.BunifuLabel6)
        Me.pnlInput.Controls.Add(Me.txtInputRetypePassword)
        Me.pnlInput.Controls.Add(Me.BunifuLabel3)
        Me.pnlInput.Controls.Add(Me.txtInputPassword)
        Me.pnlInput.Controls.Add(Me.BunifuLabel4)
        Me.pnlInput.Controls.Add(Me.txtInputUsername)
        Me.pnlInput.Controls.Add(Me.txtInputNumber)
        Me.pnlInput.Controls.Add(Me.BunifuLabel5)
        Me.pnlInput.Controls.Add(Me.txtInputName)
        Me.pnlInput.Location = New System.Drawing.Point(25, 25)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.ShowBorders = True
        Me.pnlInput.Size = New System.Drawing.Size(867, 325)
        Me.pnlInput.TabIndex = 0
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.AutoSize = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel1.Location = New System.Drawing.Point(25, 239)
        Me.BunifuLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(205, 19)
        Me.BunifuLabel1.TabIndex = 0
        Me.BunifuLabel1.TabStop = False
        Me.BunifuLabel1.Text = "User account name"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel8
        '
        Me.BunifuLabel8.AllowParentOverrides = False
        Me.BunifuLabel8.AutoEllipsis = False
        Me.BunifuLabel8.AutoSize = False
        Me.BunifuLabel8.CursorType = Nothing
        Me.BunifuLabel8.Font = New System.Drawing.Font("Roboto", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BunifuLabel8.Location = New System.Drawing.Point(25, 197)
        Me.BunifuLabel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel8.Name = "BunifuLabel8"
        Me.BunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel8.Size = New System.Drawing.Size(396, 19)
        Me.BunifuLabel8.TabIndex = 0
        Me.BunifuLabel8.Text = "Admin is the default user type for new accounts"
        Me.BunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtUserAccountNumber
        '
        Me.txtUserAccountNumber.AllowParentOverrides = False
        Me.txtUserAccountNumber.AutoEllipsis = False
        Me.txtUserAccountNumber.AutoSize = False
        Me.txtUserAccountNumber.CursorType = Nothing
        Me.txtUserAccountNumber.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.txtUserAccountNumber.Location = New System.Drawing.Point(25, 25)
        Me.txtUserAccountNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUserAccountNumber.Name = "txtUserAccountNumber"
        Me.txtUserAccountNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserAccountNumber.Size = New System.Drawing.Size(205, 19)
        Me.txtUserAccountNumber.TabIndex = 0
        Me.txtUserAccountNumber.TabStop = False
        Me.txtUserAccountNumber.Text = "User account number"
        Me.txtUserAccountNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtUserAccountNumber.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblPasswordWarning
        '
        Me.lblPasswordWarning.AllowParentOverrides = False
        Me.lblPasswordWarning.AutoEllipsis = False
        Me.lblPasswordWarning.AutoSize = False
        Me.lblPasswordWarning.CursorType = Nothing
        Me.lblPasswordWarning.Font = New System.Drawing.Font("Roboto", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordWarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblPasswordWarning.Location = New System.Drawing.Point(446, 304)
        Me.lblPasswordWarning.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblPasswordWarning.Name = "lblPasswordWarning"
        Me.lblPasswordWarning.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPasswordWarning.Size = New System.Drawing.Size(396, 19)
        Me.lblPasswordWarning.TabIndex = 0
        Me.lblPasswordWarning.TabStop = False
        Me.lblPasswordWarning.Text = "Password do not match"
        Me.lblPasswordWarning.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPasswordWarning.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.lblPasswordWarning.Visible = False
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.AutoSize = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel2.Location = New System.Drawing.Point(25, 132)
        Me.BunifuLabel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(205, 19)
        Me.BunifuLabel2.TabIndex = 0
        Me.BunifuLabel2.TabStop = False
        Me.BunifuLabel2.Text = "User account type"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtInputType
        '
        Me.txtInputType.Animated = True
        Me.txtInputType.BackColor = System.Drawing.Color.Transparent
        Me.txtInputType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtInputType.BorderRadius = 6
        Me.txtInputType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInputType.DefaultText = "Admin"
        Me.txtInputType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtInputType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtInputType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputType.DisabledState.Parent = Me.txtInputType
        Me.txtInputType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtInputType.FocusedState.Parent = Me.txtInputType
        Me.txtInputType.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtInputType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtInputType.HoverState.Parent = Me.txtInputType
        Me.txtInputType.Location = New System.Drawing.Point(25, 156)
        Me.txtInputType.Name = "txtInputType"
        Me.txtInputType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInputType.PlaceholderText = "Enter account type here"
        Me.txtInputType.ReadOnly = True
        Me.txtInputType.SelectedText = ""
        Me.txtInputType.SelectionStart = 5
        Me.txtInputType.ShadowDecoration.Enabled = True
        Me.txtInputType.ShadowDecoration.Parent = Me.txtInputType
        Me.txtInputType.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtInputType.Size = New System.Drawing.Size(396, 36)
        Me.txtInputType.TabIndex = 1
        Me.txtInputType.TabStop = False
        Me.txtInputType.Tag = "Invalid"
        '
        'BunifuLabel7
        '
        Me.BunifuLabel7.AllowParentOverrides = False
        Me.BunifuLabel7.AutoEllipsis = False
        Me.BunifuLabel7.AutoSize = False
        Me.BunifuLabel7.CursorType = Nothing
        Me.BunifuLabel7.Font = New System.Drawing.Font("Roboto", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BunifuLabel7.Location = New System.Drawing.Point(446, 197)
        Me.BunifuLabel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel7.Name = "BunifuLabel7"
        Me.BunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel7.Size = New System.Drawing.Size(418, 19)
        Me.BunifuLabel7.TabIndex = 0
        Me.BunifuLabel7.Text = "Password must be at least 8 characters and consist of small and capital letter(s)" &
    " and number(s)"
        Me.BunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AllowParentOverrides = False
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.AutoSize = False
        Me.BunifuLabel6.CursorType = Nothing
        Me.BunifuLabel6.Font = New System.Drawing.Font("Roboto", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BunifuLabel6.Location = New System.Drawing.Point(446, 90)
        Me.BunifuLabel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel6.Name = "BunifuLabel6"
        Me.BunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel6.Size = New System.Drawing.Size(248, 19)
        Me.BunifuLabel6.TabIndex = 0
        Me.BunifuLabel6.TabStop = False
        Me.BunifuLabel6.Text = "Username must consist of at least 8 characters"
        Me.BunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtInputRetypePassword
        '
        Me.txtInputRetypePassword.Animated = True
        Me.txtInputRetypePassword.BackColor = System.Drawing.Color.Transparent
        Me.txtInputRetypePassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtInputRetypePassword.BorderRadius = 6
        Me.txtInputRetypePassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInputRetypePassword.DefaultText = ""
        Me.txtInputRetypePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtInputRetypePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtInputRetypePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputRetypePassword.DisabledState.Parent = Me.txtInputRetypePassword
        Me.txtInputRetypePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputRetypePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtInputRetypePassword.FocusedState.Parent = Me.txtInputRetypePassword
        Me.txtInputRetypePassword.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputRetypePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtInputRetypePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtInputRetypePassword.HoverState.Parent = Me.txtInputRetypePassword
        Me.txtInputRetypePassword.Location = New System.Drawing.Point(446, 263)
        Me.txtInputRetypePassword.Name = "txtInputRetypePassword"
        Me.txtInputRetypePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtInputRetypePassword.PlaceholderText = "Re-type password here"
        Me.txtInputRetypePassword.SelectedText = ""
        Me.txtInputRetypePassword.ShadowDecoration.Enabled = True
        Me.txtInputRetypePassword.ShadowDecoration.Parent = Me.txtInputRetypePassword
        Me.txtInputRetypePassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtInputRetypePassword.Size = New System.Drawing.Size(396, 36)
        Me.txtInputRetypePassword.TabIndex = 3
        Me.txtInputRetypePassword.Tag = "Invalid"
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.AutoSize = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel3.Location = New System.Drawing.Point(446, 25)
        Me.BunifuLabel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(205, 19)
        Me.BunifuLabel3.TabIndex = 0
        Me.BunifuLabel3.TabStop = False
        Me.BunifuLabel3.Text = "Username"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtInputPassword
        '
        Me.txtInputPassword.Animated = True
        Me.txtInputPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtInputPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtInputPassword.BorderRadius = 6
        Me.txtInputPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInputPassword.DefaultText = ""
        Me.txtInputPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtInputPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtInputPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputPassword.DisabledState.Parent = Me.txtInputPassword
        Me.txtInputPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtInputPassword.FocusedState.Parent = Me.txtInputPassword
        Me.txtInputPassword.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtInputPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtInputPassword.HoverState.Parent = Me.txtInputPassword
        Me.txtInputPassword.Location = New System.Drawing.Point(446, 156)
        Me.txtInputPassword.Name = "txtInputPassword"
        Me.txtInputPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtInputPassword.PlaceholderText = "Enter password here"
        Me.txtInputPassword.SelectedText = ""
        Me.txtInputPassword.ShadowDecoration.Enabled = True
        Me.txtInputPassword.ShadowDecoration.Parent = Me.txtInputPassword
        Me.txtInputPassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtInputPassword.Size = New System.Drawing.Size(396, 36)
        Me.txtInputPassword.TabIndex = 2
        Me.txtInputPassword.Tag = "Invalid"
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.AutoSize = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel4.Location = New System.Drawing.Point(446, 132)
        Me.BunifuLabel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(205, 19)
        Me.BunifuLabel4.TabIndex = 0
        Me.BunifuLabel4.TabStop = False
        Me.BunifuLabel4.Text = "Password"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtInputUsername
        '
        Me.txtInputUsername.Animated = True
        Me.txtInputUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtInputUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtInputUsername.BorderRadius = 6
        Me.txtInputUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInputUsername.DefaultText = ""
        Me.txtInputUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtInputUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtInputUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputUsername.DisabledState.Parent = Me.txtInputUsername
        Me.txtInputUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtInputUsername.FocusedState.Parent = Me.txtInputUsername
        Me.txtInputUsername.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtInputUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtInputUsername.HoverState.Parent = Me.txtInputUsername
        Me.txtInputUsername.Location = New System.Drawing.Point(446, 49)
        Me.txtInputUsername.Name = "txtInputUsername"
        Me.txtInputUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInputUsername.PlaceholderText = "Enter username here"
        Me.txtInputUsername.SelectedText = ""
        Me.txtInputUsername.ShadowDecoration.Enabled = True
        Me.txtInputUsername.ShadowDecoration.Parent = Me.txtInputUsername
        Me.txtInputUsername.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtInputUsername.Size = New System.Drawing.Size(396, 36)
        Me.txtInputUsername.TabIndex = 1
        Me.txtInputUsername.Tag = "Invalid"
        '
        'txtInputNumber
        '
        Me.txtInputNumber.Animated = True
        Me.txtInputNumber.BackColor = System.Drawing.Color.Transparent
        Me.txtInputNumber.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtInputNumber.BorderRadius = 6
        Me.txtInputNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInputNumber.DefaultText = "0000000001"
        Me.txtInputNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtInputNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtInputNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputNumber.DisabledState.Parent = Me.txtInputNumber
        Me.txtInputNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtInputNumber.FocusedState.Parent = Me.txtInputNumber
        Me.txtInputNumber.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtInputNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtInputNumber.HoverState.Parent = Me.txtInputNumber
        Me.txtInputNumber.Location = New System.Drawing.Point(25, 49)
        Me.txtInputNumber.Name = "txtInputNumber"
        Me.txtInputNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInputNumber.PlaceholderText = "Enter account type here"
        Me.txtInputNumber.ReadOnly = True
        Me.txtInputNumber.SelectedText = ""
        Me.txtInputNumber.SelectionStart = 10
        Me.txtInputNumber.ShadowDecoration.Enabled = True
        Me.txtInputNumber.ShadowDecoration.Parent = Me.txtInputNumber
        Me.txtInputNumber.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtInputNumber.Size = New System.Drawing.Size(396, 36)
        Me.txtInputNumber.TabIndex = 1
        Me.txtInputNumber.TabStop = False
        Me.txtInputNumber.Tag = "Invalid"
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.AutoSize = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel5.Location = New System.Drawing.Point(446, 239)
        Me.BunifuLabel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(205, 19)
        Me.BunifuLabel5.TabIndex = 0
        Me.BunifuLabel5.TabStop = False
        Me.BunifuLabel5.Text = "Re-type password"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtInputName
        '
        Me.txtInputName.Animated = True
        Me.txtInputName.BackColor = System.Drawing.Color.Transparent
        Me.txtInputName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtInputName.BorderRadius = 6
        Me.txtInputName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInputName.DefaultText = ""
        Me.txtInputName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtInputName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtInputName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputName.DisabledState.Parent = Me.txtInputName
        Me.txtInputName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInputName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtInputName.FocusedState.Parent = Me.txtInputName
        Me.txtInputName.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.txtInputName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.txtInputName.HoverState.Parent = Me.txtInputName
        Me.txtInputName.Location = New System.Drawing.Point(25, 263)
        Me.txtInputName.Name = "txtInputName"
        Me.txtInputName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInputName.PlaceholderText = "Enter full name here"
        Me.txtInputName.SelectedText = ""
        Me.txtInputName.ShadowDecoration.Enabled = True
        Me.txtInputName.ShadowDecoration.Parent = Me.txtInputName
        Me.txtInputName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtInputName.Size = New System.Drawing.Size(396, 36)
        Me.txtInputName.TabIndex = 0
        Me.txtInputName.Tag = "Invalid"
        '
        'tpgReviewInformation
        '
        Me.tpgReviewInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.tpgReviewInformation.Controls.Add(Me.lblQRCodeWarning)
        Me.tpgReviewInformation.Controls.Add(Me.picQRCode)
        Me.tpgReviewInformation.Controls.Add(Me.txtPassword)
        Me.tpgReviewInformation.Controls.Add(Me.btnDownload)
        Me.tpgReviewInformation.Controls.Add(Me.txtUsername)
        Me.tpgReviewInformation.Controls.Add(Me.txtType)
        Me.tpgReviewInformation.Controls.Add(Me.txtNumber)
        Me.tpgReviewInformation.Controls.Add(Me.txtName)
        Me.tpgReviewInformation.Controls.Add(Me.BunifuLabel9)
        Me.tpgReviewInformation.Controls.Add(Me.BunifuLabel10)
        Me.tpgReviewInformation.Controls.Add(Me.BunifuLabel11)
        Me.tpgReviewInformation.Controls.Add(Me.BunifuLabel16)
        Me.tpgReviewInformation.Controls.Add(Me.BunifuLabel12)
        Me.tpgReviewInformation.Location = New System.Drawing.Point(4, 4)
        Me.tpgReviewInformation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpgReviewInformation.Name = "tpgReviewInformation"
        Me.tpgReviewInformation.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpgReviewInformation.Size = New System.Drawing.Size(917, 375)
        Me.tpgReviewInformation.TabIndex = 1
        Me.tpgReviewInformation.Text = "Review Information"
        '
        'lblQRCodeWarning
        '
        Me.lblQRCodeWarning.AllowParentOverrides = False
        Me.lblQRCodeWarning.AutoEllipsis = False
        Me.lblQRCodeWarning.AutoSize = False
        Me.lblQRCodeWarning.BackColor = System.Drawing.Color.White
        Me.lblQRCodeWarning.CursorType = Nothing
        Me.lblQRCodeWarning.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQRCodeWarning.Location = New System.Drawing.Point(569, 167)
        Me.lblQRCodeWarning.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblQRCodeWarning.Name = "lblQRCodeWarning"
        Me.lblQRCodeWarning.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQRCodeWarning.Size = New System.Drawing.Size(205, 19)
        Me.lblQRCodeWarning.TabIndex = 5
        Me.lblQRCodeWarning.TabStop = False
        Me.lblQRCodeWarning.Text = "There is problem generating qr code"
        Me.lblQRCodeWarning.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblQRCodeWarning.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.lblQRCodeWarning.Visible = False
        '
        'picQRCode
        '
        Me.picQRCode.BackColor = System.Drawing.Color.Transparent
        Me.picQRCode.BorderRadius = 6
        Me.picQRCode.FillColor = System.Drawing.Color.White
        Me.picQRCode.Location = New System.Drawing.Point(533, 38)
        Me.picQRCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.ShadowDecoration.Enabled = True
        Me.picQRCode.ShadowDecoration.Parent = Me.picQRCode
        Me.picQRCode.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.picQRCode.Size = New System.Drawing.Size(276, 276)
        Me.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQRCode.TabIndex = 11
        Me.picQRCode.TabStop = False
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
        Me.txtPassword.Location = New System.Drawing.Point(108, 322)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Enabled = True
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtPassword.Size = New System.Drawing.Size(400, 36)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.TabStop = False
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
        Me.btnDownload.Location = New System.Drawing.Point(533, 322)
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
        Me.txtUsername.Location = New System.Drawing.Point(108, 257)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Enabled = True
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtUsername.Size = New System.Drawing.Size(400, 36)
        Me.txtUsername.TabIndex = 8
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
        Me.txtType.Location = New System.Drawing.Point(108, 192)
        Me.txtType.Name = "txtType"
        Me.txtType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtType.PlaceholderText = "Account type"
        Me.txtType.ReadOnly = True
        Me.txtType.SelectedText = ""
        Me.txtType.ShadowDecoration.Enabled = True
        Me.txtType.ShadowDecoration.Parent = Me.txtType
        Me.txtType.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtType.Size = New System.Drawing.Size(400, 36)
        Me.txtType.TabIndex = 9
        Me.txtType.TabStop = False
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
        Me.txtNumber.Location = New System.Drawing.Point(108, 62)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumber.PlaceholderText = "Account number"
        Me.txtNumber.ReadOnly = True
        Me.txtNumber.SelectedText = ""
        Me.txtNumber.ShadowDecoration.Enabled = True
        Me.txtNumber.ShadowDecoration.Parent = Me.txtNumber
        Me.txtNumber.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtNumber.Size = New System.Drawing.Size(400, 36)
        Me.txtNumber.TabIndex = 9
        Me.txtNumber.TabStop = False
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
        Me.txtName.Location = New System.Drawing.Point(108, 127)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = "Account name"
        Me.txtName.ReadOnly = True
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Enabled = True
        Me.txtName.ShadowDecoration.Parent = Me.txtName
        Me.txtName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txtName.Size = New System.Drawing.Size(400, 36)
        Me.txtName.TabIndex = 9
        Me.txtName.TabStop = False
        '
        'BunifuLabel9
        '
        Me.BunifuLabel9.AllowParentOverrides = False
        Me.BunifuLabel9.AutoEllipsis = False
        Me.BunifuLabel9.AutoSize = False
        Me.BunifuLabel9.CursorType = Nothing
        Me.BunifuLabel9.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel9.Location = New System.Drawing.Point(108, 298)
        Me.BunifuLabel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel9.Name = "BunifuLabel9"
        Me.BunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel9.Size = New System.Drawing.Size(205, 19)
        Me.BunifuLabel9.TabIndex = 3
        Me.BunifuLabel9.TabStop = False
        Me.BunifuLabel9.Text = "Password"
        Me.BunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel10
        '
        Me.BunifuLabel10.AllowParentOverrides = False
        Me.BunifuLabel10.AutoEllipsis = False
        Me.BunifuLabel10.AutoSize = False
        Me.BunifuLabel10.CursorType = Nothing
        Me.BunifuLabel10.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel10.Location = New System.Drawing.Point(108, 233)
        Me.BunifuLabel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel10.Name = "BunifuLabel10"
        Me.BunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel10.Size = New System.Drawing.Size(205, 19)
        Me.BunifuLabel10.TabIndex = 4
        Me.BunifuLabel10.TabStop = False
        Me.BunifuLabel10.Text = "Username"
        Me.BunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel11
        '
        Me.BunifuLabel11.AllowParentOverrides = False
        Me.BunifuLabel11.AutoEllipsis = False
        Me.BunifuLabel11.AutoSize = False
        Me.BunifuLabel11.CursorType = Nothing
        Me.BunifuLabel11.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel11.Location = New System.Drawing.Point(108, 168)
        Me.BunifuLabel11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel11.Name = "BunifuLabel11"
        Me.BunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel11.Size = New System.Drawing.Size(205, 19)
        Me.BunifuLabel11.TabIndex = 5
        Me.BunifuLabel11.TabStop = False
        Me.BunifuLabel11.Text = "User account type"
        Me.BunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel16
        '
        Me.BunifuLabel16.AllowParentOverrides = False
        Me.BunifuLabel16.AutoEllipsis = False
        Me.BunifuLabel16.AutoSize = False
        Me.BunifuLabel16.CursorType = Nothing
        Me.BunifuLabel16.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel16.Location = New System.Drawing.Point(108, 38)
        Me.BunifuLabel16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel16.Name = "BunifuLabel16"
        Me.BunifuLabel16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel16.Size = New System.Drawing.Size(205, 19)
        Me.BunifuLabel16.TabIndex = 6
        Me.BunifuLabel16.TabStop = False
        Me.BunifuLabel16.Text = "User account number"
        Me.BunifuLabel16.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel16.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel12
        '
        Me.BunifuLabel12.AllowParentOverrides = False
        Me.BunifuLabel12.AutoEllipsis = False
        Me.BunifuLabel12.AutoSize = False
        Me.BunifuLabel12.CursorType = Nothing
        Me.BunifuLabel12.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel12.Location = New System.Drawing.Point(108, 103)
        Me.BunifuLabel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel12.Name = "BunifuLabel12"
        Me.BunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel12.Size = New System.Drawing.Size(205, 19)
        Me.BunifuLabel12.TabIndex = 6
        Me.BunifuLabel12.TabStop = False
        Me.BunifuLabel12.Text = "User account name"
        Me.BunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'tpgSaveInformation
        '
        Me.tpgSaveInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.tpgSaveInformation.Controls.Add(Me.BunifuLabel14)
        Me.tpgSaveInformation.Controls.Add(Me.BunifuLabel13)
        Me.tpgSaveInformation.Controls.Add(Me.btnLoginNow)
        Me.tpgSaveInformation.Location = New System.Drawing.Point(4, 4)
        Me.tpgSaveInformation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpgSaveInformation.Name = "tpgSaveInformation"
        Me.tpgSaveInformation.Size = New System.Drawing.Size(917, 375)
        Me.tpgSaveInformation.TabIndex = 2
        Me.tpgSaveInformation.Text = "Save Information"
        '
        'BunifuLabel14
        '
        Me.BunifuLabel14.AllowParentOverrides = False
        Me.BunifuLabel14.AutoEllipsis = False
        Me.BunifuLabel14.AutoSize = False
        Me.BunifuLabel14.CursorType = Nothing
        Me.BunifuLabel14.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel14.Location = New System.Drawing.Point(204, 197)
        Me.BunifuLabel14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel14.Name = "BunifuLabel14"
        Me.BunifuLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel14.Size = New System.Drawing.Size(517, 41)
        Me.BunifuLabel14.TabIndex = 5
        Me.BunifuLabel14.TabStop = False
        Me.BunifuLabel14.Text = "You have successfully create your new account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the button below to login."
        Me.BunifuLabel14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel14.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel13
        '
        Me.BunifuLabel13.AllowParentOverrides = False
        Me.BunifuLabel13.AutoEllipsis = False
        Me.BunifuLabel13.AutoSize = False
        Me.BunifuLabel13.CursorType = Nothing
        Me.BunifuLabel13.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.BunifuLabel13.Location = New System.Drawing.Point(204, 175)
        Me.BunifuLabel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuLabel13.Name = "BunifuLabel13"
        Me.BunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel13.Size = New System.Drawing.Size(517, 18)
        Me.BunifuLabel13.TabIndex = 5
        Me.BunifuLabel13.TabStop = False
        Me.BunifuLabel13.Text = "Congratulations!"
        Me.BunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'btnLoginNow
        '
        Me.btnLoginNow.Animated = True
        Me.btnLoginNow.BackColor = System.Drawing.Color.Transparent
        Me.btnLoginNow.BorderRadius = 6
        Me.btnLoginNow.CheckedState.Parent = Me.btnLoginNow
        Me.btnLoginNow.CustomImages.Parent = Me.btnLoginNow
        Me.btnLoginNow.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnLoginNow.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.btnLoginNow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnLoginNow.HoverState.Parent = Me.btnLoginNow
        Me.btnLoginNow.Location = New System.Drawing.Point(387, 242)
        Me.btnLoginNow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginNow.Name = "btnLoginNow"
        Me.btnLoginNow.ShadowDecoration.Enabled = True
        Me.btnLoginNow.ShadowDecoration.Parent = Me.btnLoginNow
        Me.btnLoginNow.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnLoginNow.Size = New System.Drawing.Size(150, 36)
        Me.btnLoginNow.TabIndex = 0
        Me.btnLoginNow.TabStop = False
        Me.btnLoginNow.Text = "Login now"
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
        Me.btnCancel.Location = New System.Drawing.Point(644, 453)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnCancel.Size = New System.Drawing.Size(150, 36)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        '
        'btnBack
        '
        Me.btnBack.Animated = True
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BorderRadius = 6
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(488, 453)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Enabled = True
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnBack.Size = New System.Drawing.Size(150, 36)
        Me.btnBack.TabIndex = 6
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "Back"
        Me.btnBack.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Animated = True
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BorderRadius = 6
        Me.btnNext.CheckedState.Parent = Me.btnNext
        Me.btnNext.CustomImages.Parent = Me.btnNext
        Me.btnNext.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnNext.HoverState.Parent = Me.btnNext
        Me.btnNext.Location = New System.Drawing.Point(800, 453)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.ShadowDecoration.Enabled = True
        Me.btnNext.ShadowDecoration.Parent = Me.btnNext
        Me.btnNext.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnNext.Size = New System.Drawing.Size(150, 36)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        '
        'frmCreateNewAccountScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1025, 598)
        Me.Controls.Add(Me.pnlBackground)
        Me.Controls.Add(Me.pnlControl)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCreateNewAccountScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        Me.pnlBackground.ResumeLayout(False)
        Me.page.ResumeLayout(False)
        Me.tpgInputInformation.ResumeLayout(False)
        Me.pnlInput.ResumeLayout(False)
        Me.tpgReviewInformation.ResumeLayout(False)
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgSaveInformation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents shadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents drag As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pnlBackground As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlControl As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents page As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents tpgInputInformation As TabPage
    Friend WithEvents tpgReviewInformation As TabPage
    Friend WithEvents tpgSaveInformation As TabPage
    Friend WithEvents txtInputName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtInputRetypePassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtInputPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtInputUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents picQRCode As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDownload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuLabel9 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel10 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel11 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel12 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel14 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel13 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnLoginNow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BunifuLabel15 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BunifuLabel7 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel8 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel6 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents pnlInput As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents txtInputType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblQRCodeWarning As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblPasswordWarning As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtUserAccountNumber As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtInputNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BunifuLabel16 As Bunifu.UI.WinForms.BunifuLabel
End Class
