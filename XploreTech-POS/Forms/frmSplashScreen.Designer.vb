<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.shadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblBrandName = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.picQRCode = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'elipse
        '
        Me.elipse.ElipseRadius = 6
        Me.elipse.TargetControl = Me
        '
        'timer
        '
        Me.timer.Interval = 50
        '
        'lblBrandName
        '
        Me.lblBrandName.AllowParentOverrides = False
        Me.lblBrandName.AutoEllipsis = False
        Me.lblBrandName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBrandName.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblBrandName.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandName.Location = New System.Drawing.Point(12, 394)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBrandName.Size = New System.Drawing.Size(273, 14)
        Me.lblBrandName.TabIndex = 2
        Me.lblBrandName.Text = "Xplore-Tech. D'Creamy Milktea House. 2021 - 2022"
        Me.lblBrandName.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblBrandName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BorderRadius = 6
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.White
        Me.Guna2PictureBox1.Image = Global.XploreTech_POS.My.Resources.Resources.dcreamy_logo
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(344, 103)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(276, 203)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 12
        Me.Guna2PictureBox1.TabStop = False
        '
        'picQRCode
        '
        Me.picQRCode.BackColor = System.Drawing.Color.Transparent
        Me.picQRCode.BorderRadius = 6
        Me.picQRCode.FillColor = System.Drawing.Color.White
        Me.picQRCode.Image = Global.XploreTech_POS.My.Resources.Resources.logo_xplore_tech
        Me.picQRCode.Location = New System.Drawing.Point(62, 103)
        Me.picQRCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.ShadowDecoration.Parent = Me.picQRCode
        Me.picQRCode.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.picQRCode.Size = New System.Drawing.Size(276, 203)
        Me.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQRCode.TabIndex = 12
        Me.picQRCode.TabStop = False
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 420)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.picQRCode)
        Me.Controls.Add(Me.lblBrandName)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents shadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents timer As Timer
    Friend WithEvents lblBrandName As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents picQRCode As Guna.UI2.WinForms.Guna2PictureBox
End Class
