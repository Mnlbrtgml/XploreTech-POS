Public Class frmInventorySettings
    Private Sub frmInventorySettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbxSettings.SelectedItem = "Milktea Products Settings"
        dgvTable.Columns.Clear()
        LoadMilkteaTable(dgvTable)
        LoadActionButton(dgvTable)
        txtSearch.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ShowModifyItem("Add", cmbxSettings)

    End Sub

    Private Sub cmbxSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxSettings.SelectedIndexChanged
        dgvTable.Columns.Clear()

        If cmbxSettings.SelectedItem = "Milktea Products Settings" Then
            LoadMilkteaTable(dgvTable)
        ElseIf cmbxSettings.SelectedItem = "Additional Products Settings" Then
            LoadAdditionalProductsTable(dgvTable)
        ElseIf cmbxSettings.SelectedItem = "Toppings Settings" Then
            LoadAddonsTable(dgvTable)
        End If

        LoadActionButton(dgvTable)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvTable.Columns.Clear()

        If cmbxSettings.SelectedItem = "Milktea Products Settings" Then
            FilterMilktea(txtSearch.Text, dgvTable)
        ElseIf cmbxSettings.SelectedItem = "Additional Products Settings" Then
            FilterAdditionalProduct(txtSearch.Text, dgvTable)
        ElseIf cmbxSettings.SelectedItem = "Toppings Settings" Then
            FilterToppings(txtSearch.Text, dgvTable)
        End If

        LoadActionButton(dgvTable)
    End Sub

    Private Sub dgvTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTable.CellContentClick
        Try
            Dim dr As DataGridViewRow = dgvTable.Rows(e.RowIndex)

            If dgvTable.Columns(e.ColumnIndex).Name = "clmnEdit" Then
                ShowModifyItem("Edit", cmbxSettings)

            ElseIf dgvTable.Columns(e.ColumnIndex).Name = "clmnDel" Then
                If cmbxSettings.SelectedItem = "Milktea Products Settings" Then
                    Dim mlktName As String = dr.Cells("Product Name").Value
                    DeleteMilktea(mlktName)
                    LoadMilkteaTable(dgvTable)
                    ActLog("Delete Milktea: " & mlktName)
                ElseIf cmbxSettings.SelectedItem = "Additional Products Settings" Then
                    Dim addtnlProdName As String = dr.Cells("Product Name").Value
                    DeleteAdditional(addtnlProdName)
                    LoadAdditionalProductsTable(dgvTable)
                    ActLog("Delete Additional Products: " & addtnlProdName)
                ElseIf cmbxSettings.SelectedItem = "Toppings Settings" Then
                    Dim addnsName As String = dr.Cells("Add-ons Name").Value
                    DeleteAdd_Ons(addnsName)
                    LoadAddonsTable(dgvTable)
                    ActLog("Delete Add-ons: " & addnsName)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class