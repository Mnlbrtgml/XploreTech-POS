<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.cmbxReport = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnFilter = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlReports = New Guna.UI2.WinForms.Guna2Panel()
        Me.report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmbxSubReport = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlReportShadow = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlReports.SuspendLayout()
        Me.pnlReportShadow.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmbxReport.Location = New System.Drawing.Point(25, 25)
        Me.cmbxReport.Name = "cmbxReport"
        Me.cmbxReport.ShadowDecoration.Enabled = True
        Me.cmbxReport.ShadowDecoration.Parent = Me.cmbxReport
        Me.cmbxReport.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cmbxReport.Size = New System.Drawing.Size(200, 36)
        Me.cmbxReport.TabIndex = 0
        '
        'btnFilter
        '
        Me.btnFilter.Animated = True
        Me.btnFilter.BackColor = System.Drawing.Color.Transparent
        Me.btnFilter.BorderRadius = 6
        Me.btnFilter.CheckedState.Parent = Me.btnFilter
        Me.btnFilter.CustomImages.Parent = Me.btnFilter
        Me.btnFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnFilter.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnFilter.HoverState.Parent = Me.btnFilter
        Me.btnFilter.Location = New System.Drawing.Point(754, 25)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.ShadowDecoration.Enabled = True
        Me.btnFilter.ShadowDecoration.Parent = Me.btnFilter
        Me.btnFilter.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnFilter.Size = New System.Drawing.Size(150, 36)
        Me.btnFilter.TabIndex = 1
        Me.btnFilter.Text = "Filter"
        '
        'pnlReports
        '
        Me.pnlReports.BackColor = System.Drawing.Color.Transparent
        Me.pnlReports.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlReports.BorderRadius = 6
        Me.pnlReports.Controls.Add(Me.pnlReportShadow)
        Me.pnlReports.Controls.Add(Me.cmbxSubReport)
        Me.pnlReports.Controls.Add(Me.cmbxReport)
        Me.pnlReports.Controls.Add(Me.btnReset)
        Me.pnlReports.Controls.Add(Me.btnFilter)
        Me.pnlReports.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlReports.Location = New System.Drawing.Point(0, 25)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.ShadowDecoration.Enabled = True
        Me.pnlReports.ShadowDecoration.Parent = Me.pnlReports
        Me.pnlReports.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlReports.Size = New System.Drawing.Size(929, 596)
        Me.pnlReports.TabIndex = 4
        '
        'report
        '
        Me.report.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.report.DocumentMapWidth = 16
        Me.report.Location = New System.Drawing.Point(2, 2)
        Me.report.Name = "report"
        Me.report.ServerReport.BearerToken = Nothing
        Me.report.Size = New System.Drawing.Size(875, 481)
        Me.report.TabIndex = 2
        '
        'cmbxSubReport
        '
        Me.cmbxSubReport.BackColor = System.Drawing.Color.Transparent
        Me.cmbxSubReport.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxSubReport.BorderRadius = 6
        Me.cmbxSubReport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbxSubReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSubReport.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxSubReport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbxSubReport.FocusedState.Parent = Me.cmbxSubReport
        Me.cmbxSubReport.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxSubReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSubReport.FormattingEnabled = True
        Me.cmbxSubReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmbxSubReport.HoverState.Parent = Me.cmbxSubReport
        Me.cmbxSubReport.ItemHeight = 30
        Me.cmbxSubReport.Items.AddRange(New Object() {"Sample 1", "Sample 2", "Sample 3", "Sample 4", "Sample 5", "Sample 6", "Sample 7", "Sample 8"})
        Me.cmbxSubReport.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbxSubReport.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSubReport.ItemsAppearance.Parent = Me.cmbxSubReport
        Me.cmbxSubReport.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.cmbxSubReport.ItemsAppearance.SelectedFont = New System.Drawing.Font("Roboto", 8.0!)
        Me.cmbxSubReport.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.cmbxSubReport.Location = New System.Drawing.Point(231, 25)
        Me.cmbxSubReport.Name = "cmbxSubReport"
        Me.cmbxSubReport.ShadowDecoration.Enabled = True
        Me.cmbxSubReport.ShadowDecoration.Parent = Me.cmbxSubReport
        Me.cmbxSubReport.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cmbxSubReport.Size = New System.Drawing.Size(200, 36)
        Me.cmbxSubReport.TabIndex = 0
        Me.cmbxSubReport.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Animated = True
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.BorderRadius = 6
        Me.btnReset.CheckedState.Parent = Me.btnReset
        Me.btnReset.CustomImages.Parent = Me.btnReset
        Me.btnReset.FillColor = System.Drawing.SystemColors.Control
        Me.btnReset.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnReset.HoverState.Parent = Me.btnReset
        Me.btnReset.Location = New System.Drawing.Point(598, 25)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.ShadowDecoration.Enabled = True
        Me.btnReset.ShadowDecoration.Parent = Me.btnReset
        Me.btnReset.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnReset.Size = New System.Drawing.Size(150, 36)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.Visible = False
        '
        'elipse
        '
        Me.elipse.ElipseRadius = 6
        Me.elipse.TargetControl = Me.report
        '
        'pnlReportShadow
        '
        Me.pnlReportShadow.BackColor = System.Drawing.Color.Transparent
        Me.pnlReportShadow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlReportShadow.BorderRadius = 6
        Me.pnlReportShadow.Controls.Add(Me.report)
        Me.pnlReportShadow.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlReportShadow.Location = New System.Drawing.Point(25, 86)
        Me.pnlReportShadow.Name = "pnlReportShadow"
        Me.pnlReportShadow.ShadowDecoration.Enabled = True
        Me.pnlReportShadow.ShadowDecoration.Parent = Me.pnlReportShadow
        Me.pnlReportShadow.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlReportShadow.Size = New System.Drawing.Size(879, 485)
        Me.pnlReportShadow.TabIndex = 3
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 646)
        Me.Controls.Add(Me.pnlReports)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlReports.ResumeLayout(False)
        Me.pnlReportShadow.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbxReport As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnFilter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlReports As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents report As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmbxSubReport As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents pnlReportShadow As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents elipse As Bunifu.Framework.UI.BunifuElipse
End Class
