<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerList))
        Me.formShadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnSelect = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlItemListShadow = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvCustomerList = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.dgvRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlItemListShadow.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dgvCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'elipse
        '
        Me.elipse.ElipseRadius = 6
        Me.elipse.TargetControl = Me
        '
        'btnSelect
        '
        Me.btnSelect.Animated = True
        Me.btnSelect.BackColor = System.Drawing.Color.Transparent
        Me.btnSelect.BorderRadius = 6
        Me.btnSelect.CheckedState.Parent = Me.btnSelect
        Me.btnSelect.CustomImages.Parent = Me.btnSelect
        Me.btnSelect.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnSelect.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnSelect.HoverState.Parent = Me.btnSelect
        Me.btnSelect.Location = New System.Drawing.Point(228, 389)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.ShadowDecoration.Enabled = True
        Me.btnSelect.ShadowDecoration.Parent = Me.btnSelect
        Me.btnSelect.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnSelect.Size = New System.Drawing.Size(150, 36)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select"
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
        Me.btnCancel.Location = New System.Drawing.Point(72, 389)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnCancel.Size = New System.Drawing.Size(150, 36)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        '
        'pnlItemListShadow
        '
        Me.pnlItemListShadow.BorderColor = System.Drawing.Color.White
        Me.pnlItemListShadow.BorderRadius = 6
        Me.pnlItemListShadow.Controls.Add(Me.dgvCustomerList)
        Me.pnlItemListShadow.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.pnlItemListShadow.Location = New System.Drawing.Point(25, 25)
        Me.pnlItemListShadow.Name = "pnlItemListShadow"
        Me.pnlItemListShadow.ShadowDecoration.Enabled = True
        Me.pnlItemListShadow.ShadowDecoration.Parent = Me.pnlItemListShadow
        Me.pnlItemListShadow.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlItemListShadow.Size = New System.Drawing.Size(400, 339)
        Me.pnlItemListShadow.TabIndex = 13
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 6
        Me.Guna2Panel1.Controls.Add(Me.pnlItemListShadow)
        Me.Guna2Panel1.Controls.Add(Me.btnSelect)
        Me.Guna2Panel1.Controls.Add(Me.btnCancel)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(25, 25)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel1.Size = New System.Drawing.Size(450, 450)
        Me.Guna2Panel1.TabIndex = 14
        '
        'dgvCustomerList
        '
        Me.dgvCustomerList.AllowCustomTheming = True
        Me.dgvCustomerList.AllowUserToAddRows = False
        Me.dgvCustomerList.AllowUserToDeleteRows = False
        Me.dgvCustomerList.AllowUserToResizeColumns = False
        Me.dgvCustomerList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvCustomerList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomerList.BackgroundColor = System.Drawing.Color.White
        Me.dgvCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCustomerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCustomerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomerList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCustomerList.ColumnHeadersHeight = 36
        Me.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCustomerList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCustomerList.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.dgvCustomerList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvCustomerList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvCustomerList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvCustomerList.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.dgvCustomerList.CurrentTheme.GridColor = System.Drawing.Color.White
        Me.dgvCustomerList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvCustomerList.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.dgvCustomerList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvCustomerList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvCustomerList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvCustomerList.CurrentTheme.Name = Nothing
        Me.dgvCustomerList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCustomerList.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.dgvCustomerList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvCustomerList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvCustomerList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomerList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCustomerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCustomerList.EnableHeadersVisualStyles = False
        Me.dgvCustomerList.GridColor = System.Drawing.Color.White
        Me.dgvCustomerList.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.dgvCustomerList.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgvCustomerList.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.dgvCustomerList.Location = New System.Drawing.Point(1, 1)
        Me.dgvCustomerList.MultiSelect = False
        Me.dgvCustomerList.Name = "dgvCustomerList"
        Me.dgvCustomerList.ReadOnly = True
        Me.dgvCustomerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomerList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCustomerList.RowHeadersVisible = False
        Me.dgvCustomerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvCustomerList.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCustomerList.RowTemplate.Height = 28
        Me.dgvCustomerList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomerList.ShowEditingIcon = False
        Me.dgvCustomerList.Size = New System.Drawing.Size(399, 338)
        Me.dgvCustomerList.TabIndex = 6
        Me.dgvCustomerList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'dgvRadius
        '
        Me.dgvRadius.ElipseRadius = 6
        Me.dgvRadius.TargetControl = Me.dgvCustomerList
        '
        'frmCustomerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomerList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlItemListShadow.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.dgvCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents formShadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlItemListShadow As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvCustomerList As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents dgvRadius As Bunifu.Framework.UI.BunifuElipse
End Class
