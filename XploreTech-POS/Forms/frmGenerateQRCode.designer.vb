<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerateQRCode
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
        Me.pcbQRCode = New System.Windows.Forms.PictureBox()
        Me.ctrlShadowForm = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.pnlQR = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnDownload = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.pcbQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQR.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbQRCode
        '
        Me.pcbQRCode.BackColor = System.Drawing.Color.White
        Me.pcbQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbQRCode.Location = New System.Drawing.Point(25, 25)
        Me.pcbQRCode.Margin = New System.Windows.Forms.Padding(2)
        Me.pcbQRCode.Name = "pcbQRCode"
        Me.pcbQRCode.Padding = New System.Windows.Forms.Padding(3)
        Me.pcbQRCode.Size = New System.Drawing.Size(284, 269)
        Me.pcbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbQRCode.TabIndex = 0
        Me.pcbQRCode.TabStop = False
        '
        'ActivitylogTableAdapter
        '
        '
        'pnlQR
        '
        Me.pnlQR.BackColor = System.Drawing.Color.Transparent
        Me.pnlQR.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlQR.BorderRadius = 6
        Me.pnlQR.Controls.Add(Me.pcbQRCode)
        Me.pnlQR.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlQR.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.pnlQR.Location = New System.Drawing.Point(25, 25)
        Me.pnlQR.Name = "pnlQR"
        Me.pnlQR.ShadowDecoration.Enabled = True
        Me.pnlQR.ShadowDecoration.Parent = Me.pnlQR
        Me.pnlQR.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlQR.Size = New System.Drawing.Size(334, 319)
        Me.pnlQR.TabIndex = 35
        '
        'ctrlElipse
        '
        Me.ctrlElipse.ElipseRadius = 6
        Me.ctrlElipse.TargetControl = Me
        '
        'btnDownload
        '
        Me.btnDownload.Animated = True
        Me.btnDownload.BackColor = System.Drawing.Color.Transparent
        Me.btnDownload.BorderRadius = 6
        Me.btnDownload.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnDownload.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnDownload.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnDownload.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnDownload.CheckedState.Parent = Me.btnDownload
        Me.btnDownload.CustomImages.Parent = Me.btnDownload
        Me.btnDownload.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnDownload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDownload.ForeColor = System.Drawing.Color.Black
        Me.btnDownload.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnDownload.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnDownload.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnDownload.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnDownload.HoverState.Parent = Me.btnDownload
        Me.btnDownload.Location = New System.Drawing.Point(195, 369)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.ShadowDecoration.Enabled = True
        Me.btnDownload.ShadowDecoration.Parent = Me.btnDownload
        Me.btnDownload.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnDownload.Size = New System.Drawing.Size(164, 40)
        Me.btnDownload.TabIndex = 41
        Me.btnDownload.Text = "Download"
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 6
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(25, 369)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnCancel.Size = New System.Drawing.Size(164, 40)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        '
        'frmGenerateQRCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 432)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pnlQR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGenerateQRCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.pcbQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQR.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbQRCode As PictureBox
    Friend WithEvents ctrlShadowForm As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents pnlQR As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ctrlElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnDownload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
End Class
