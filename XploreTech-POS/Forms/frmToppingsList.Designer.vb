<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmToppingsList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmToppingsList))
        Me.shadowForm = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.elipseForm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlTopping = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlScrollbarShadow = New Guna.UI2.WinForms.Guna2Panel()
        Me.scbrToppingList = New Bunifu.UI.WinForms.BunifuVScrollBar()
        Me.pnlToppingList = New Bunifu.UI.WinForms.BunifuPanel()
        Me.btnDone = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlTopping.SuspendLayout()
        Me.pnlScrollbarShadow.SuspendLayout()
        Me.SuspendLayout()
        '
        'elipseForm
        '
        Me.elipseForm.ElipseRadius = 6
        Me.elipseForm.TargetControl = Me
        '
        'pnlTopping
        '
        Me.pnlTopping.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlTopping.BorderRadius = 6
        Me.pnlTopping.Controls.Add(Me.pnlScrollbarShadow)
        Me.pnlTopping.Controls.Add(Me.btnDone)
        Me.pnlTopping.Controls.Add(Me.pnlToppingList)
        Me.pnlTopping.Controls.Add(Me.btnCancel)
        Me.pnlTopping.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlTopping.Location = New System.Drawing.Point(25, 25)
        Me.pnlTopping.Name = "pnlTopping"
        Me.pnlTopping.ShadowDecoration.Parent = Me.pnlTopping
        Me.pnlTopping.Size = New System.Drawing.Size(356, 344)
        Me.pnlTopping.TabIndex = 0
        '
        'pnlScrollbarShadow
        '
        Me.pnlScrollbarShadow.BackColor = System.Drawing.Color.Transparent
        Me.pnlScrollbarShadow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlScrollbarShadow.BorderRadius = 6
        Me.pnlScrollbarShadow.Controls.Add(Me.scbrToppingList)
        Me.pnlScrollbarShadow.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlScrollbarShadow.Location = New System.Drawing.Point(321, 25)
        Me.pnlScrollbarShadow.Name = "pnlScrollbarShadow"
        Me.pnlScrollbarShadow.ShadowDecoration.Enabled = True
        Me.pnlScrollbarShadow.ShadowDecoration.Parent = Me.pnlScrollbarShadow
        Me.pnlScrollbarShadow.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlScrollbarShadow.Size = New System.Drawing.Size(10, 233)
        Me.pnlScrollbarShadow.TabIndex = 10
        '
        'scbrToppingList
        '
        Me.scbrToppingList.AllowCursorChanges = True
        Me.scbrToppingList.AllowHomeEndKeysDetection = False
        Me.scbrToppingList.AllowIncrementalClickMoves = True
        Me.scbrToppingList.AllowMouseDownEffects = True
        Me.scbrToppingList.AllowMouseHoverEffects = True
        Me.scbrToppingList.AllowScrollingAnimations = True
        Me.scbrToppingList.AllowScrollKeysDetection = True
        Me.scbrToppingList.AllowScrollOptionsMenu = True
        Me.scbrToppingList.AllowShrinkingOnFocusLost = False
        Me.scbrToppingList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.scbrToppingList.BackgroundImage = CType(resources.GetObject("scbrToppingList.BackgroundImage"), System.Drawing.Image)
        Me.scbrToppingList.BindingContainer = Me.pnlToppingList
        Me.scbrToppingList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.scbrToppingList.BorderRadius = 0
        Me.scbrToppingList.BorderThickness = 1
        Me.scbrToppingList.DurationBeforeShrink = 2000
        Me.scbrToppingList.LargeChange = 10
        Me.scbrToppingList.Location = New System.Drawing.Point(1, 1)
        Me.scbrToppingList.Maximum = 100
        Me.scbrToppingList.Minimum = 0
        Me.scbrToppingList.MinimumThumbLength = 18
        Me.scbrToppingList.Name = "scbrToppingList"
        Me.scbrToppingList.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
        Me.scbrToppingList.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
        Me.scbrToppingList.OnDisable.ThumbColor = System.Drawing.Color.Silver
        Me.scbrToppingList.ScrollBarBorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.scbrToppingList.ScrollBarColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.scbrToppingList.ShrinkSizeLimit = 3
        Me.scbrToppingList.Size = New System.Drawing.Size(9, 232)
        Me.scbrToppingList.SmallChange = 1
        Me.scbrToppingList.TabIndex = 9
        Me.scbrToppingList.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.scbrToppingList.ThumbLength = 22
        Me.scbrToppingList.ThumbMargin = 0
        Me.scbrToppingList.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Proportional
        Me.scbrToppingList.Value = 0
        '
        'pnlToppingList
        '
        Me.pnlToppingList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlToppingList.BackgroundImage = CType(resources.GetObject("pnlToppingList.BackgroundImage"), System.Drawing.Image)
        Me.pnlToppingList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlToppingList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlToppingList.BorderRadius = 0
        Me.pnlToppingList.BorderThickness = 0
        Me.pnlToppingList.Location = New System.Drawing.Point(25, 25)
        Me.pnlToppingList.Name = "pnlToppingList"
        Me.pnlToppingList.ShowBorders = True
        Me.pnlToppingList.Size = New System.Drawing.Size(285, 233)
        Me.pnlToppingList.TabIndex = 1
        '
        'btnDone
        '
        Me.btnDone.Animated = True
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.BorderRadius = 6
        Me.btnDone.CheckedState.Parent = Me.btnDone
        Me.btnDone.CustomImages.Parent = Me.btnDone
        Me.btnDone.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnDone.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnDone.HoverState.Parent = Me.btnDone
        Me.btnDone.Location = New System.Drawing.Point(181, 283)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.ShadowDecoration.Enabled = True
        Me.btnDone.ShadowDecoration.Parent = Me.btnDone
        Me.btnDone.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnDone.Size = New System.Drawing.Size(150, 36)
        Me.btnDone.TabIndex = 6
        Me.btnDone.Text = "Done"
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
        Me.btnCancel.Location = New System.Drawing.Point(25, 283)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnCancel.Size = New System.Drawing.Size(150, 36)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'frmToppingsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(406, 394)
        Me.Controls.Add(Me.pnlTopping)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmToppingsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTopping.ResumeLayout(False)
        Me.pnlScrollbarShadow.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents shadowForm As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents elipseForm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlTopping As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnDone As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlToppingList As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents scbrToppingList As Bunifu.UI.WinForms.BunifuVScrollBar
    Friend WithEvents pnlScrollbarShadow As Guna.UI2.WinForms.Guna2Panel
End Class
