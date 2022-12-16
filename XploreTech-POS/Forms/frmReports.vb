Public Class frmReports
    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.report.RefreshReport()
        cmbxReport.Items.Clear()
        cmbxReport.Items.Add("Milktea Report")
        cmbxReport.Items.Add("Additional Products Report")
        cmbxReport.Items.Add("Addons Report")
        cmbxReport.Items.Add("User Report")
        cmbxReport.Items.Add("Transactions Report")
        cmbxReport.Items.Add("Activity Log Report")
        cmbxReport.SelectedIndex = 0

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim newFrmFilter = New frmFilterReport
        newFrmFilter.ShowDialog()

    End Sub

    Private Sub cmbxReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxReport.SelectedIndexChanged
        Select Case cmbxReport.SelectedItem
            Case "Milktea Report"
                LoadReport("MilkteaProducts")
            Case "Additional Products Report"
                LoadReport("OtherProducts")
            Case "Addons Report"
                LoadReport("Toppings")
            Case "User Report"
                LoadReport("UserAccounts")
            Case "Transactions Report"
                LoadReport("Transaction")
            Case "Activity Log Report"
                LoadReport("ActivityLog")
        End Select
    End Sub
End Class