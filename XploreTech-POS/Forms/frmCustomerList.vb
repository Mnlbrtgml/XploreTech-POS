Public Class frmCustomerList

    Dim custTypeID As Short = 0
    Private Sub frmCustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get customertypeid from frmplaceorder
        For Each frm In My.Application.OpenForms.OfType(Of frmPlaceOrder)
            custTypeID = GetTableColumnNumber(frm.cmbxCustomerType.Text, "customertype", "Name", "Customer_Type_ID")
        Next
        'load customer table with the same customer type
        LoadFrmCustomerList(dgvCustomerList, custTypeID)
    End Sub

    Private Sub dgvCustomerList_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        btnSelect.Enabled = True
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        For Each frm In My.Application.OpenForms.OfType(Of frmPlaceOrder)
            frm.txtCustomerName.Text = dgvCustomerList.CurrentRow.Cells(0).Value
            frm.txtCustomerNumber.Text = dgvCustomerList.CurrentRow.Cells(1).Value
            frm.txtCustomerAddress.Text = dgvCustomerList.CurrentRow.Cells(2).Value
        Next
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class