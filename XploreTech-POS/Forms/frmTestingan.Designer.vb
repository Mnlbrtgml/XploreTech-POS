<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestingan
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
        Me.report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'report
        '
        Me.report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.report.Location = New System.Drawing.Point(0, 0)
        Me.report.Name = "report"
        Me.report.ServerReport.BearerToken = Nothing
        Me.report.Size = New System.Drawing.Size(574, 450)
        Me.report.TabIndex = 0
        '
        'frmTestingan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 450)
        Me.Controls.Add(Me.report)
        Me.Name = "frmTestingan"
        Me.Text = "Receipt"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents report As Microsoft.Reporting.WinForms.ReportViewer
End Class
