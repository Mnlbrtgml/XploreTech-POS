<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifyItem))
        Me.formRadius = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.formShadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.pnlEditing = New Guna.UI2.WinForms.Guna2Panel()
        Me.Checkbox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Combobox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label04 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Textbox03 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label05 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Label06 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Textbox05 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label03 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Textbox02 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label02 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Textbox04 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label01 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Textbox01 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Button02 = New Guna.UI2.WinForms.Guna2Button()
        Me.Button01 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlEditing.SuspendLayout()
        Me.SuspendLayout()
        '
        'formRadius
        '
        Me.formRadius.TargetControl = Me
        '
        'pnlEditing
        '
        Me.pnlEditing.BackColor = System.Drawing.Color.Transparent
        Me.pnlEditing.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlEditing.BorderRadius = 6
        Me.pnlEditing.Controls.Add(Me.Checkbox)
        Me.pnlEditing.Controls.Add(Me.Combobox)
        Me.pnlEditing.Controls.Add(Me.Label04)
        Me.pnlEditing.Controls.Add(Me.Textbox03)
        Me.pnlEditing.Controls.Add(Me.Label05)
        Me.pnlEditing.Controls.Add(Me.Label06)
        Me.pnlEditing.Controls.Add(Me.Textbox05)
        Me.pnlEditing.Controls.Add(Me.Label03)
        Me.pnlEditing.Controls.Add(Me.Textbox02)
        Me.pnlEditing.Controls.Add(Me.Label02)
        Me.pnlEditing.Controls.Add(Me.Textbox04)
        Me.pnlEditing.Controls.Add(Me.Label01)
        Me.pnlEditing.Controls.Add(Me.Textbox01)
        Me.pnlEditing.Controls.Add(Me.Button02)
        Me.pnlEditing.Controls.Add(Me.Button01)
        Me.pnlEditing.Controls.Add(Me.btnSave)
        Me.pnlEditing.Controls.Add(Me.btnCancel)
        Me.pnlEditing.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlEditing.Location = New System.Drawing.Point(25, 25)
        Me.pnlEditing.Name = "pnlEditing"
        Me.pnlEditing.ShadowDecoration.Enabled = True
        Me.pnlEditing.ShadowDecoration.Parent = Me.pnlEditing
        Me.pnlEditing.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlEditing.Size = New System.Drawing.Size(354, 596)
        Me.pnlEditing.TabIndex = 0
        '
        'Checkbox
        '
        Me.Checkbox.Animated = True
        Me.Checkbox.AutoSize = True
        Me.Checkbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Checkbox.Checked = True
        Me.Checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Checkbox.CheckedState.BorderRadius = 2
        Me.Checkbox.CheckedState.BorderThickness = 1
        Me.Checkbox.CheckedState.FillColor = System.Drawing.Color.White
        Me.Checkbox.CheckMarkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Checkbox.Location = New System.Drawing.Point(25, 416)
        Me.Checkbox.Name = "Checkbox"
        Me.Checkbox.Size = New System.Drawing.Size(148, 18)
        Me.Checkbox.TabIndex = 6
        Me.Checkbox.Text = "Sample item checkbox"
        Me.Checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Checkbox.UncheckedState.BorderRadius = 2
        Me.Checkbox.UncheckedState.BorderThickness = 1
        Me.Checkbox.UncheckedState.FillColor = System.Drawing.Color.White
        Me.Checkbox.UseVisualStyleBackColor = False
        Me.Checkbox.Visible = False
        '
        'Combobox
        '
        Me.Combobox.BackColor = System.Drawing.Color.Transparent
        Me.Combobox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Combobox.BorderRadius = 6
        Me.Combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combobox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Combobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Combobox.FocusedState.Parent = Me.Combobox
        Me.Combobox.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combobox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Combobox.FormattingEnabled = True
        Me.Combobox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Combobox.HoverState.Parent = Me.Combobox
        Me.Combobox.ItemHeight = 30
        Me.Combobox.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.Combobox.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Combobox.ItemsAppearance.Parent = Me.Combobox
        Me.Combobox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Combobox.ItemsAppearance.SelectedFont = New System.Drawing.Font("Roboto", 8.0!)
        Me.Combobox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Combobox.Location = New System.Drawing.Point(25, 114)
        Me.Combobox.Name = "Combobox"
        Me.Combobox.ShadowDecoration.Enabled = True
        Me.Combobox.ShadowDecoration.Parent = Me.Combobox
        Me.Combobox.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Combobox.Size = New System.Drawing.Size(304, 36)
        Me.Combobox.TabIndex = 1
        Me.Combobox.TextOffset = New System.Drawing.Point(1, 2)
        Me.Combobox.Visible = False
        '
        'Label04
        '
        Me.Label04.AllowParentOverrides = False
        Me.Label04.AutoEllipsis = False
        Me.Label04.AutoSize = False
        Me.Label04.CursorType = Nothing
        Me.Label04.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label04.Location = New System.Drawing.Point(25, 220)
        Me.Label04.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label04.Name = "Label04"
        Me.Label04.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label04.Size = New System.Drawing.Size(304, 19)
        Me.Label04.TabIndex = 13
        Me.Label04.TabStop = False
        Me.Label04.Text = "Sample item label"
        Me.Label04.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label04.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.Label04.Visible = False
        '
        'Textbox03
        '
        Me.Textbox03.Animated = True
        Me.Textbox03.BackColor = System.Drawing.Color.Transparent
        Me.Textbox03.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Textbox03.BorderRadius = 6
        Me.Textbox03.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox03.DefaultText = ""
        Me.Textbox03.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textbox03.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textbox03.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbox03.DisabledState.Parent = Me.Textbox03
        Me.Textbox03.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbox03.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Textbox03.FocusedState.Parent = Me.Textbox03
        Me.Textbox03.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.Textbox03.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Textbox03.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Textbox03.HoverState.Parent = Me.Textbox03
        Me.Textbox03.Location = New System.Drawing.Point(25, 244)
        Me.Textbox03.Name = "Textbox03"
        Me.Textbox03.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textbox03.PlaceholderText = ""
        Me.Textbox03.ReadOnly = True
        Me.Textbox03.SelectedText = ""
        Me.Textbox03.ShadowDecoration.Enabled = True
        Me.Textbox03.ShadowDecoration.Parent = Me.Textbox03
        Me.Textbox03.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Textbox03.Size = New System.Drawing.Size(304, 36)
        Me.Textbox03.TabIndex = 4
        Me.Textbox03.TabStop = False
        Me.Textbox03.Visible = False
        '
        'Label05
        '
        Me.Label05.AllowParentOverrides = False
        Me.Label05.AutoEllipsis = False
        Me.Label05.AutoSize = False
        Me.Label05.CursorType = Nothing
        Me.Label05.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label05.Location = New System.Drawing.Point(25, 285)
        Me.Label05.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label05.Name = "Label05"
        Me.Label05.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label05.Size = New System.Drawing.Size(304, 19)
        Me.Label05.TabIndex = 14
        Me.Label05.TabStop = False
        Me.Label05.Text = "Sample item label"
        Me.Label05.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label05.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.Label05.Visible = False
        '
        'Label06
        '
        Me.Label06.AllowParentOverrides = False
        Me.Label06.AutoEllipsis = False
        Me.Label06.AutoSize = False
        Me.Label06.CursorType = Nothing
        Me.Label06.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label06.Location = New System.Drawing.Point(25, 350)
        Me.Label06.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label06.Name = "Label06"
        Me.Label06.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label06.Size = New System.Drawing.Size(304, 19)
        Me.Label06.TabIndex = 15
        Me.Label06.TabStop = False
        Me.Label06.Text = "Sample item label"
        Me.Label06.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label06.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.Label06.Visible = False
        '
        'Textbox05
        '
        Me.Textbox05.Animated = True
        Me.Textbox05.BackColor = System.Drawing.Color.Transparent
        Me.Textbox05.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Textbox05.BorderRadius = 6
        Me.Textbox05.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox05.DefaultText = ""
        Me.Textbox05.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textbox05.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textbox05.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbox05.DisabledState.Parent = Me.Textbox05
        Me.Textbox05.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbox05.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Textbox05.FocusedState.Parent = Me.Textbox05
        Me.Textbox05.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.Textbox05.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Textbox05.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Textbox05.HoverState.Parent = Me.Textbox05
        Me.Textbox05.Location = New System.Drawing.Point(25, 374)
        Me.Textbox05.Name = "Textbox05"
        Me.Textbox05.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textbox05.PlaceholderText = ""
        Me.Textbox05.ReadOnly = True
        Me.Textbox05.SelectedText = ""
        Me.Textbox05.ShadowDecoration.Enabled = True
        Me.Textbox05.ShadowDecoration.Parent = Me.Textbox05
        Me.Textbox05.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Textbox05.Size = New System.Drawing.Size(304, 36)
        Me.Textbox05.TabIndex = 2
        Me.Textbox05.TabStop = False
        Me.Textbox05.Visible = False
        '
        'Label03
        '
        Me.Label03.AllowParentOverrides = False
        Me.Label03.AutoEllipsis = False
        Me.Label03.AutoSize = False
        Me.Label03.CursorType = Nothing
        Me.Label03.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label03.Location = New System.Drawing.Point(25, 155)
        Me.Label03.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label03.Name = "Label03"
        Me.Label03.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label03.Size = New System.Drawing.Size(304, 19)
        Me.Label03.TabIndex = 12
        Me.Label03.TabStop = False
        Me.Label03.Text = "Sample item label"
        Me.Label03.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label03.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.Label03.Visible = False
        '
        'Textbox02
        '
        Me.Textbox02.Animated = True
        Me.Textbox02.BackColor = System.Drawing.Color.Transparent
        Me.Textbox02.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Textbox02.BorderRadius = 6
        Me.Textbox02.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox02.DefaultText = ""
        Me.Textbox02.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textbox02.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textbox02.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbox02.DisabledState.Parent = Me.Textbox02
        Me.Textbox02.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbox02.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Textbox02.FocusedState.Parent = Me.Textbox02
        Me.Textbox02.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.Textbox02.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Textbox02.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Textbox02.HoverState.Parent = Me.Textbox02
        Me.Textbox02.Location = New System.Drawing.Point(25, 179)
        Me.Textbox02.Name = "Textbox02"
        Me.Textbox02.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textbox02.PlaceholderText = ""
        Me.Textbox02.ReadOnly = True
        Me.Textbox02.SelectedText = ""
        Me.Textbox02.ShadowDecoration.Enabled = True
        Me.Textbox02.ShadowDecoration.Parent = Me.Textbox02
        Me.Textbox02.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Textbox02.Size = New System.Drawing.Size(304, 36)
        Me.Textbox02.TabIndex = 3
        Me.Textbox02.TabStop = False
        Me.Textbox02.Visible = False
        '
        'Label02
        '
        Me.Label02.AllowParentOverrides = False
        Me.Label02.AutoEllipsis = False
        Me.Label02.AutoSize = False
        Me.Label02.CursorType = Nothing
        Me.Label02.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label02.Location = New System.Drawing.Point(25, 90)
        Me.Label02.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label02.Name = "Label02"
        Me.Label02.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label02.Size = New System.Drawing.Size(304, 19)
        Me.Label02.TabIndex = 11
        Me.Label02.TabStop = False
        Me.Label02.Text = "Sample item label"
        Me.Label02.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label02.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.Label02.Visible = False
        '
        'Textbox04
        '
        Me.Textbox04.Animated = True
        Me.Textbox04.BackColor = System.Drawing.Color.Transparent
        Me.Textbox04.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Textbox04.BorderRadius = 6
        Me.Textbox04.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox04.DefaultText = ""
        Me.Textbox04.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textbox04.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textbox04.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbox04.DisabledState.Parent = Me.Textbox04
        Me.Textbox04.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbox04.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Textbox04.FocusedState.Parent = Me.Textbox04
        Me.Textbox04.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.Textbox04.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Textbox04.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Textbox04.HoverState.Parent = Me.Textbox04
        Me.Textbox04.Location = New System.Drawing.Point(25, 309)
        Me.Textbox04.Name = "Textbox04"
        Me.Textbox04.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textbox04.PlaceholderText = ""
        Me.Textbox04.ReadOnly = True
        Me.Textbox04.SelectedText = ""
        Me.Textbox04.ShadowDecoration.Enabled = True
        Me.Textbox04.ShadowDecoration.Parent = Me.Textbox04
        Me.Textbox04.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Textbox04.Size = New System.Drawing.Size(304, 36)
        Me.Textbox04.TabIndex = 5
        Me.Textbox04.TabStop = False
        Me.Textbox04.Visible = False
        '
        'Label01
        '
        Me.Label01.AllowParentOverrides = False
        Me.Label01.AutoEllipsis = False
        Me.Label01.AutoSize = False
        Me.Label01.CursorType = Nothing
        Me.Label01.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label01.Location = New System.Drawing.Point(25, 25)
        Me.Label01.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label01.Name = "Label01"
        Me.Label01.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label01.Size = New System.Drawing.Size(304, 19)
        Me.Label01.TabIndex = 10
        Me.Label01.TabStop = False
        Me.Label01.Text = "Sample item label"
        Me.Label01.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label01.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.Label01.Visible = False
        '
        'Textbox01
        '
        Me.Textbox01.Animated = True
        Me.Textbox01.BackColor = System.Drawing.Color.Transparent
        Me.Textbox01.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Textbox01.BorderRadius = 6
        Me.Textbox01.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox01.DefaultText = ""
        Me.Textbox01.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Textbox01.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Textbox01.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbox01.DisabledState.Parent = Me.Textbox01
        Me.Textbox01.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Textbox01.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Textbox01.FocusedState.Parent = Me.Textbox01
        Me.Textbox01.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.Textbox01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Textbox01.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Textbox01.HoverState.Parent = Me.Textbox01
        Me.Textbox01.Location = New System.Drawing.Point(25, 49)
        Me.Textbox01.Name = "Textbox01"
        Me.Textbox01.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Textbox01.PlaceholderText = ""
        Me.Textbox01.ReadOnly = True
        Me.Textbox01.SelectedText = ""
        Me.Textbox01.ShadowDecoration.Enabled = True
        Me.Textbox01.ShadowDecoration.Parent = Me.Textbox01
        Me.Textbox01.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Textbox01.Size = New System.Drawing.Size(304, 36)
        Me.Textbox01.TabIndex = 0
        Me.Textbox01.TabStop = False
        Me.Textbox01.Visible = False
        '
        'Button02
        '
        Me.Button02.Animated = True
        Me.Button02.BackColor = System.Drawing.Color.Transparent
        Me.Button02.BorderRadius = 6
        Me.Button02.CheckedState.Parent = Me.Button02
        Me.Button02.CustomImages.Parent = Me.Button02
        Me.Button02.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button02.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button02.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button02.HoverState.Parent = Me.Button02
        Me.Button02.Location = New System.Drawing.Point(25, 495)
        Me.Button02.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button02.Name = "Button02"
        Me.Button02.ShadowDecoration.Enabled = True
        Me.Button02.ShadowDecoration.Parent = Me.Button02
        Me.Button02.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Button02.Size = New System.Drawing.Size(304, 36)
        Me.Button02.TabIndex = 7
        Me.Button02.TabStop = False
        Me.Button02.Visible = False
        '
        'Button01
        '
        Me.Button01.Animated = True
        Me.Button01.BackColor = System.Drawing.Color.Transparent
        Me.Button01.BorderRadius = 6
        Me.Button01.CheckedState.Parent = Me.Button01
        Me.Button01.CustomImages.Parent = Me.Button01
        Me.Button01.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button01.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button01.HoverState.Parent = Me.Button01
        Me.Button01.Location = New System.Drawing.Point(25, 455)
        Me.Button01.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button01.Name = "Button01"
        Me.Button01.ShadowDecoration.Enabled = True
        Me.Button01.ShadowDecoration.Parent = Me.Button01
        Me.Button01.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Button01.Size = New System.Drawing.Size(304, 36)
        Me.Button01.TabIndex = 7
        Me.Button01.TabStop = False
        Me.Button01.Visible = False
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
        Me.btnSave.Location = New System.Drawing.Point(181, 535)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Enabled = True
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnSave.Size = New System.Drawing.Size(150, 36)
        Me.btnSave.TabIndex = 8
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save"
        Me.btnSave.Visible = False
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
        Me.btnCancel.Location = New System.Drawing.Point(25, 535)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnCancel.Size = New System.Drawing.Size(150, 36)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Visible = False
        '
        'frmModifyItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 646)
        Me.Controls.Add(Me.pnlEditing)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModifyItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlEditing.ResumeLayout(False)
        Me.pnlEditing.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents formRadius As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents formShadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents pnlEditing As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label01 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Textbox01 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label04 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Textbox03 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label06 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Textbox05 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label03 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Textbox02 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label02 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Textbox04 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Combobox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label05 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Checkbox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Button01 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button02 As Guna.UI2.WinForms.Guna2Button
End Class
