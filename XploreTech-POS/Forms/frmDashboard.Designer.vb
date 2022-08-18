<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblNumberOfTransaction = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlChartCanvas = New Bunifu.Charts.WinForms.BunifuChartCanvas()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblNumberOfSoldToday = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDailySales = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.scbrPromoList = New Bunifu.UI.WinForms.BunifuVScrollBar()
        Me.pnlPromoList = New Bunifu.UI.WinForms.BunifuPanel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 6
        Me.Guna2Panel1.Controls.Add(Me.lblNumberOfTransaction)
        Me.Guna2Panel1.Controls.Add(Me.BunifuLabel1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel1.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel1.Size = New System.Drawing.Size(213, 285)
        Me.Guna2Panel1.TabIndex = 0
        '
        'lblNumberOfTransaction
        '
        Me.lblNumberOfTransaction.AllowParentOverrides = False
        Me.lblNumberOfTransaction.AutoEllipsis = False
        Me.lblNumberOfTransaction.AutoSize = False
        Me.lblNumberOfTransaction.BackColor = System.Drawing.Color.Empty
        Me.lblNumberOfTransaction.CursorType = Nothing
        Me.lblNumberOfTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumberOfTransaction.Font = New System.Drawing.Font("Roboto", 50.0!)
        Me.lblNumberOfTransaction.Location = New System.Drawing.Point(0, 50)
        Me.lblNumberOfTransaction.Name = "lblNumberOfTransaction"
        Me.lblNumberOfTransaction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumberOfTransaction.Size = New System.Drawing.Size(213, 235)
        Me.lblNumberOfTransaction.TabIndex = 1
        Me.lblNumberOfTransaction.Text = "0"
        Me.lblNumberOfTransaction.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNumberOfTransaction.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.AutoSize = False
        Me.BunifuLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuLabel1.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.BunifuLabel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(213, 50)
        Me.BunifuLabel1.TabIndex = 0
        Me.BunifuLabel1.Text = "Number of Transaction Today"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel2.BorderRadius = 6
        Me.Guna2Panel2.Controls.Add(Me.ctrlChartCanvas)
        Me.Guna2Panel2.Controls.Add(Me.BunifuLabel4)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel2.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 335)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel2.Size = New System.Drawing.Size(451, 286)
        Me.Guna2Panel2.TabIndex = 1
        '
        'ctrlChartCanvas
        '
        Me.ctrlChartCanvas.AnimationDuration = 1000
        Me.ctrlChartCanvas.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart
        Me.ctrlChartCanvas.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.ctrlChartCanvas.CanvasPadding = New System.Windows.Forms.Padding(0)
        Me.ctrlChartCanvas.Labels = New String(-1) {}
        Me.ctrlChartCanvas.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center
        Me.ctrlChartCanvas.LegendDisplay = True
        Me.ctrlChartCanvas.LegendFont = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ctrlChartCanvas.LegendForeColor = System.Drawing.Color.Black
        Me.ctrlChartCanvas.LegendFullWidth = True
        Me.ctrlChartCanvas.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.right
        Me.ctrlChartCanvas.LegendRevese = False
        Me.ctrlChartCanvas.LegendRTL = False
        Me.ctrlChartCanvas.Location = New System.Drawing.Point(0, 75)
        Me.ctrlChartCanvas.Name = "ctrlChartCanvas"
        Me.ctrlChartCanvas.ShowXAxis = True
        Me.ctrlChartCanvas.ShowYAxis = True
        Me.ctrlChartCanvas.Size = New System.Drawing.Size(402, 191)
        Me.ctrlChartCanvas.TabIndex = 2
        Me.ctrlChartCanvas.Title = ""
        Me.ctrlChartCanvas.TitleLineHeight = 1.2R
        Me.ctrlChartCanvas.TitlePadding = 10
        Me.ctrlChartCanvas.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top
        Me.ctrlChartCanvas.TooltipBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctrlChartCanvas.TooltipFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ctrlChartCanvas.TooltipForeColor = System.Drawing.Color.WhiteSmoke
        Me.ctrlChartCanvas.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest
        Me.ctrlChartCanvas.TooltipsEnabled = True
        Me.ctrlChartCanvas.XAxesBeginAtZero = True
        Me.ctrlChartCanvas.XAxesDrawTicks = True
        Me.ctrlChartCanvas.XAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ctrlChartCanvas.XAxesForeColor = System.Drawing.SystemColors.ControlText
        Me.ctrlChartCanvas.XAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctrlChartCanvas.XAxesGridLines = True
        Me.ctrlChartCanvas.XAxesLabel = ""
        Me.ctrlChartCanvas.XAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ctrlChartCanvas.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText
        Me.ctrlChartCanvas.XAxesLineWidth = 1
        Me.ctrlChartCanvas.XAxesStacked = False
        Me.ctrlChartCanvas.XAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctrlChartCanvas.XAxesZeroLineWidth = 1
        Me.ctrlChartCanvas.YAxesBeginAtZero = True
        Me.ctrlChartCanvas.YAxesDrawTicks = True
        Me.ctrlChartCanvas.YAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ctrlChartCanvas.YAxesForeColor = System.Drawing.SystemColors.ControlText
        Me.ctrlChartCanvas.YAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctrlChartCanvas.YAxesGridLines = True
        Me.ctrlChartCanvas.YAxesLabel = ""
        Me.ctrlChartCanvas.YAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ctrlChartCanvas.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText
        Me.ctrlChartCanvas.YAxesLineWidth = 1
        Me.ctrlChartCanvas.YAxesStacked = False
        Me.ctrlChartCanvas.YAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctrlChartCanvas.YAxesZeroLineWidth = 1
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.AutoSize = False
        Me.BunifuLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuLabel4.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.BunifuLabel4.Location = New System.Drawing.Point(0, 0)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(451, 50)
        Me.BunifuLabel4.TabIndex = 1
        Me.BunifuLabel4.Text = "Top Selling Products"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel3.BorderRadius = 6
        Me.Guna2Panel3.Controls.Add(Me.scbrPromoList)
        Me.Guna2Panel3.Controls.Add(Me.pnlPromoList)
        Me.Guna2Panel3.Controls.Add(Me.BunifuLabel5)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel3.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.Guna2Panel3.Location = New System.Drawing.Point(476, 335)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Enabled = True
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel3.Size = New System.Drawing.Size(453, 286)
        Me.Guna2Panel3.TabIndex = 3
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.AutoSize = False
        Me.BunifuLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuLabel5.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.BunifuLabel5.Location = New System.Drawing.Point(0, 0)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(453, 50)
        Me.BunifuLabel5.TabIndex = 1
        Me.BunifuLabel5.Text = "Promo"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel4.BorderRadius = 6
        Me.Guna2Panel4.Controls.Add(Me.lblNumberOfSoldToday)
        Me.Guna2Panel4.Controls.Add(Me.BunifuLabel2)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel4.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.Guna2Panel4.Location = New System.Drawing.Point(238, 25)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Enabled = True
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel4.Size = New System.Drawing.Size(213, 285)
        Me.Guna2Panel4.TabIndex = 2
        '
        'lblNumberOfSoldToday
        '
        Me.lblNumberOfSoldToday.AllowParentOverrides = False
        Me.lblNumberOfSoldToday.AutoEllipsis = False
        Me.lblNumberOfSoldToday.AutoSize = False
        Me.lblNumberOfSoldToday.BackColor = System.Drawing.Color.Empty
        Me.lblNumberOfSoldToday.CursorType = Nothing
        Me.lblNumberOfSoldToday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumberOfSoldToday.Font = New System.Drawing.Font("Roboto", 50.0!)
        Me.lblNumberOfSoldToday.Location = New System.Drawing.Point(0, 50)
        Me.lblNumberOfSoldToday.Name = "lblNumberOfSoldToday"
        Me.lblNumberOfSoldToday.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumberOfSoldToday.Size = New System.Drawing.Size(213, 235)
        Me.lblNumberOfSoldToday.TabIndex = 2
        Me.lblNumberOfSoldToday.Text = "0"
        Me.lblNumberOfSoldToday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNumberOfSoldToday.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.AutoSize = False
        Me.BunifuLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuLabel2.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.BunifuLabel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(213, 50)
        Me.BunifuLabel2.TabIndex = 1
        Me.BunifuLabel2.Text = "Number of Products Sold Today"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel5.BorderRadius = 6
        Me.Guna2Panel5.Controls.Add(Me.lblDailySales)
        Me.Guna2Panel5.Controls.Add(Me.BunifuLabel3)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel5.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.Guna2Panel5.Location = New System.Drawing.Point(476, 25)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Enabled = True
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel5.Size = New System.Drawing.Size(453, 285)
        Me.Guna2Panel5.TabIndex = 3
        '
        'lblDailySales
        '
        Me.lblDailySales.AllowParentOverrides = False
        Me.lblDailySales.AutoEllipsis = False
        Me.lblDailySales.AutoSize = False
        Me.lblDailySales.BackColor = System.Drawing.Color.Empty
        Me.lblDailySales.CursorType = Nothing
        Me.lblDailySales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDailySales.Font = New System.Drawing.Font("Roboto", 50.0!)
        Me.lblDailySales.Location = New System.Drawing.Point(0, 50)
        Me.lblDailySales.Name = "lblDailySales"
        Me.lblDailySales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDailySales.Size = New System.Drawing.Size(453, 235)
        Me.lblDailySales.TabIndex = 2
        Me.lblDailySales.Text = "0"
        Me.lblDailySales.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDailySales.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.AutoSize = False
        Me.BunifuLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuLabel3.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.BunifuLabel3.Location = New System.Drawing.Point(0, 0)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(453, 50)
        Me.BunifuLabel3.TabIndex = 1
        Me.BunifuLabel3.Text = "Daily Sales"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'scbrPromoList
        '
        Me.scbrPromoList.AllowCursorChanges = True
        Me.scbrPromoList.AllowHomeEndKeysDetection = False
        Me.scbrPromoList.AllowIncrementalClickMoves = True
        Me.scbrPromoList.AllowMouseDownEffects = True
        Me.scbrPromoList.AllowMouseHoverEffects = True
        Me.scbrPromoList.AllowScrollingAnimations = True
        Me.scbrPromoList.AllowScrollKeysDetection = True
        Me.scbrPromoList.AllowScrollOptionsMenu = True
        Me.scbrPromoList.AllowShrinkingOnFocusLost = False
        Me.scbrPromoList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.scbrPromoList.BackgroundImage = CType(resources.GetObject("scbrPromoList.BackgroundImage"), System.Drawing.Image)
        Me.scbrPromoList.BindingContainer = Me.pnlPromoList
        Me.scbrPromoList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.scbrPromoList.BorderRadius = 0
        Me.scbrPromoList.BorderThickness = 1
        Me.scbrPromoList.DurationBeforeShrink = 2000
        Me.scbrPromoList.LargeChange = 10
        Me.scbrPromoList.Location = New System.Drawing.Point(440, 53)
        Me.scbrPromoList.Maximum = 100
        Me.scbrPromoList.Minimum = 0
        Me.scbrPromoList.MinimumThumbLength = 18
        Me.scbrPromoList.Name = "scbrPromoList"
        Me.scbrPromoList.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
        Me.scbrPromoList.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
        Me.scbrPromoList.OnDisable.ThumbColor = System.Drawing.Color.Silver
        Me.scbrPromoList.ScrollBarBorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.scbrPromoList.ScrollBarColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.scbrPromoList.ShrinkSizeLimit = 3
        Me.scbrPromoList.Size = New System.Drawing.Size(10, 230)
        Me.scbrPromoList.SmallChange = 1
        Me.scbrPromoList.TabIndex = 11
        Me.scbrPromoList.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.scbrPromoList.ThumbLength = 22
        Me.scbrPromoList.ThumbMargin = 0
        Me.scbrPromoList.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Proportional
        Me.scbrPromoList.Value = 0
        '
        'pnlPromoList
        '
        Me.pnlPromoList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlPromoList.BackgroundImage = CType(resources.GetObject("pnlPromoList.BackgroundImage"), System.Drawing.Image)
        Me.pnlPromoList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlPromoList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlPromoList.BorderRadius = 0
        Me.pnlPromoList.BorderThickness = 0
        Me.pnlPromoList.Location = New System.Drawing.Point(3, 53)
        Me.pnlPromoList.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.pnlPromoList.Name = "pnlPromoList"
        Me.pnlPromoList.ShowBorders = True
        Me.pnlPromoList.Size = New System.Drawing.Size(434, 230)
        Me.pnlPromoList.TabIndex = 10
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 646)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblNumberOfTransaction As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblNumberOfSoldToday As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblDailySales As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents ctrlChartCanvas As Bunifu.Charts.WinForms.BunifuChartCanvas
    Friend WithEvents scbrPromoList As Bunifu.UI.WinForms.BunifuVScrollBar
    Friend WithEvents pnlPromoList As Bunifu.UI.WinForms.BunifuPanel
End Class
