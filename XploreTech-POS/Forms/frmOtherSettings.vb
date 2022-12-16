Public Class frmOtherSettings
    'Private Function

    Private Sub frmOtherSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbxSettings.SelectedItem = "User Account Settings"
        dgvTable.Columns.Clear()
        LoadAccountTable(dgvTable)
        LoadActionButton(dgvTable)
        txtSearch.Focus()
        btnGenerateMyQR.Show()
    End Sub

    Private Sub cmbxSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxSettings.SelectedIndexChanged
        dgvTable.Columns.Clear()
        btnGenerateMyQR.Hide()
        If cmbxSettings.SelectedItem = "User Account Settings" Then
            LoadAccountTable(dgvTable)
            btnAdd.Text = "Add new account"
            btnAdd.Show()
            btnGenerateMyQR.Show()
        ElseIf cmbxSettings.SelectedItem = "Customer Settings" Then
            LoadCustomerListTable(dgvTable)
            btnAdd.Text = "Add new customer"
            btnAdd.Show()
        ElseIf cmbxSettings.SelectedItem = "Customer Type Settings" Then
            LoadCustomerTypeTable(dgvTable)
            btnAdd.Text = "Add new customer type"
            btnAdd.Show()
        ElseIf cmbxSettings.SelectedItem = "Promo Settings" Then
            LoadPromoTable(dgvTable)
            btnAdd.Text = "Add new promo"
            btnAdd.Show()
        ElseIf cmbxSettings.SelectedItem = "Service Type Settings" Then
            LoadServiceTypeTable(dgvTable)
            btnAdd.Text = ""
            btnAdd.Hide()
        End If

        If Not cmbxSettings.SelectedItem = "Service Type Settings" Then
            LoadActionButton(dgvTable)
        Else
            LoadEditButton(dgvTable)
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ShowModifyItem("Add", cmbxSettings)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvTable.Columns.Clear()

        If cmbxSettings.SelectedItem = "User Account Settings" Then
            FilterUser(txtSearch.Text, dgvTable)
        ElseIf cmbxSettings.SelectedItem = "Customer Settings" Then
            FilterCustomer(txtSearch.Text, dgvTable)
        ElseIf cmbxSettings.SelectedItem = "Customer Type Settings" Then
            FilterCustomerType(txtSearch.Text, dgvTable)
        ElseIf cmbxSettings.SelectedItem = "Promo Settings" Then
            FilterwithPromoName(txtSearch.Text, dgvTable)
        ElseIf cmbxSettings.SelectedItem = "Service Type Settings" Then
            FilterServiceType(txtSearch.Text, dgvTable)
        End If
        LoadActionButton(dgvTable)
    End Sub

    Private Sub dgvTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTable.CellContentClick
        Try
            Dim dr As DataGridViewRow = dgvTable.Rows(e.RowIndex)

            If dgvTable.Columns(e.ColumnIndex).Name = "clmnEdit" Then
                ShowModifyItem("Edit", cmbxSettings)

            ElseIf dgvTable.Columns(e.ColumnIndex).Name = "clmnDel" Then
                If cmbxSettings.SelectedItem = "User Account Settings" Then

                    Dim userid As String = GetTableColumnNumber(Trim(dr.Cells("Account Name").Value.ToString), "user", "Full_Name", "User_ID")
                    If userid = LoggedUser.ID Then
                        Dim result As DialogResult = MessageBox.Show("You will be forced to log-out after deleting your account. Do you wish to proceed?", "Delete Logged User", MessageBoxButtons.YesNo)
                        If (result = DialogResult.Yes) Then
                            DeleteUser(True, userid)
                            ActLog("Delete User & Forced Logout: " & userid)
                            LoggedUser = Nothing
                            Dim LoginForm As New frmLoginScreen()
                            LoginForm.Show()
                            For Each OFORM In Application.OpenForms.OfType(Of frmIndexScreen)
                                OFORM.Close()
                            Next
                            Me.Close()
                        End If
                    End If
                    DeleteUser(True, userid)
                    LoadAccountTable(dgvTable)
                    ActLog("Delete User: " & userid)
                ElseIf cmbxSettings.SelectedItem = "Customer Settings" Then
                    Dim cstmrName As String = Trim(dr.Cells("Customer Name").Value.ToString)
                    DeleteCustomer(cstmrName)
                    LoadCustomerListTable(dgvTable)
                    ActLog("Delete Customer: " & cstmrName)
                ElseIf cmbxSettings.SelectedItem = "Customer Type Settings" Then
                    Dim cstmrType As String = IIf(Trim(dr.Cells("Name").Value.ToString) = "Regular", "", Trim(dr.Cells("Name").Value.ToString))
                    DeleteCustomerType(cstmrType)
                    LoadCustomerTypeTable(dgvTable)
                    If cstmrType <> "" Then
                        ActLog("Delete Customer Type: " & cstmrType)
                    End If

                ElseIf cmbxSettings.SelectedItem = "Promo Settings" Then
                    Dim prmName As String = Trim(dr.Cells("Promo Name").Value.ToString)
                    DeletePromo(prmName)
                    LoadPromoTable(dgvTable)
                    ActLog("Delete Promo: " & prmName)
                ElseIf cmbxSettings.SelectedItem = "Service Type Settings" Then

                    Dim name As String = Trim(dr.Cells("Name").Value.ToString)
                    If name = "Take-out" Or name = "Dine-in" Then
                        name = ""
                    End If

                    DeleteServiceType(name)
                    LoadServiceTypeTable(dgvTable)
                    If name <> "" Then
                        ActLog("Delete Service Type: " & name)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGenerateMyQR_Click(sender As Object, e As EventArgs) Handles btnGenerateMyQR.Click
        Dim frmQR As New frmGenerateQRCode
        frmQR.ShowDialog()
    End Sub
End Class