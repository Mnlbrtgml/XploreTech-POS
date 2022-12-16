Imports Guna.UI2.WinForms
Imports System.Text.RegularExpressions

Public Class frmPointOfSale
    Private Sub frmPointOfSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbxSugarLevel.SelectedIndex = -1
        LoadMilkteaTable(dgvItemList)
        PopulateCupSize(cmbxCupSize)
        PopulateSugarLevel(cmbxSugarLevel)
    End Sub

    'BTN Events---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim newFrmPlaceHolder As New frmPlaceOrder
        newFrmPlaceHolder.ShowDialog()
    End Sub
    Private Sub btnSelectToppings_Click(sender As Object, e As EventArgs) Handles btnSelectToppings.Click
        Dim newfrmToppingsList As New frmToppingsList
        newfrmToppingsList.ShowDialog()

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ResetLeftPanelControls()
        pnlAddItem.Enabled = False

        pnlSelectItem.Enabled = True
    End Sub
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim toppingsTotalPrice As Decimal = 0
        Dim orderPrice As Decimal = 0
        Dim orderConcat As String = ""
        Dim newRow As String()

        If cmbxSelectProduct.Text = "Milktea Products" Then
            orderPrice = (cmbxCupSize.SelectedValue + GetTableColumnNumber(txtItemName.Text, "milktea", "Name", "Price") * IIf(txtQuantity.Text > 0, txtQuantity.Text, 1))
            orderConcat = txtItemName.Text & IIf(tooltip.GetToolTip(txtToppings) = "", "None", tooltip.GetToolTip(txtToppings)) & cmbxCupSize.Text & cmbxSugarLevel.Text

            'Compute toppings price
            If tooltip.GetToolTip(txtToppings) <> "" And tooltip.GetToolTip(txtToppings) <> "None" Then
                Dim selectedToppings As String = tooltip.GetToolTip(txtToppings)
                Dim toppingsArr As String() = selectedToppings.Split(New Char() {","c})
                For i = 0 To toppingsArr.Count - 1
                    toppingsTotalPrice += GetTableColumnNumber(toppingsArr(i), "add_ons", "Name", "Price")
                Next
            End If

            newRow = New String() {txtItemName.Text, IIf(tooltip.GetToolTip(txtToppings) = "", "None", tooltip.GetToolTip(txtToppings)), IIf(txtQuantity.Text > 0, txtQuantity.Text, 1), cmbxCupSize.Text, cmbxSugarLevel.Text, orderPrice + toppingsTotalPrice}
        Else
            orderPrice = GetTableColumnNumber(txtItemName.Text, "additional_products", "Name", "Price") * IIf(txtQuantity.Text > 0, txtQuantity.Text, 1)
            orderConcat = txtItemName.Text & "None" & "" & ""
            newRow = New String() {txtItemName.Text, "None", IIf(txtQuantity.Text > 0, txtQuantity.Text, 1), "", "", orderPrice}
        End If

        If btnAddProduct.Text = "Add product to list" Then
            'add new row to dgvSelectedItem
            For i = 0 To dgvSelectedItemList.Rows.Count - 1
                Dim dr As DataGridViewRow = dgvSelectedItemList.Rows(i)
                Dim rowConcat As String = dr.Cells(0).Value.ToString & dr.Cells(1).Value.ToString & dr.Cells(3).Value.ToString & dr.Cells(4).Value.ToString
                If orderConcat = rowConcat Then
                    dr.Cells(2).Value += IIf(txtQuantity.Text > 0, Convert.ToInt32(txtQuantity.Text), 1)
                    dr.Cells(5).Value += orderPrice + toppingsTotalPrice

                    pnlSelectedItem.Enabled = True
                    txtItemPrice.Text = GetSubtotal()
                    ResetRightPanelControls()
                    ResetLeftPanelControls()

                    Exit Sub
                End If
            Next

            dgvSelectedItemList.Rows.Add(newRow)
        Else
            'update selected row from dgvSelectedItem
            Dim row As Short = dgvSelectedItemList.CurrentRow.Index
            dgvSelectedItemList.Rows(row).Cells(0).Value = txtItemName.Text
            dgvSelectedItemList.Rows(row).Cells(1).Value = tooltip.GetToolTip(txtToppings)
            dgvSelectedItemList.Rows(row).Cells(2).Value = txtQuantity.Text
            dgvSelectedItemList.Rows(row).Cells(3).Value = cmbxCupSize.Text
            dgvSelectedItemList.Rows(row).Cells(4).Value = cmbxSugarLevel.Text
            dgvSelectedItemList.Rows(row).Cells(5).Value = orderPrice + toppingsTotalPrice
        End If

        pnlSelectedItem.Enabled = True
        ResetLeftPanelControls()

    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        'remove selected rows from dgvSelectedItemList
        For Each row As DataGridViewRow In dgvSelectedItemList.SelectedRows
            dgvSelectedItemList.Rows.Remove(row)
        Next

    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'throws dgvSelectedProductList values to leftpanel controls
        Dim dr As DataGridViewRow = dgvSelectedItemList.Rows(dgvSelectedItemList.CurrentRow.Index)
        If dr.Cells(1).Value <> "" And dr.Cells(1).Value <> "None" Then
            Dim selectedToppings As String = dr.Cells(1).Value
            tooltip.SetToolTip(txtToppings, selectedToppings)

            Dim toppingsArr As String() = selectedToppings.Split(New Char() {","c})
            txtToppings.Text = toppingsArr.Count & " selected toppings"
        End If
        txtItemName.Text = dr.Cells(0).Value
        txtQuantity.Text = dr.Cells(2).Value
        cmbxCupSize.Text = dr.Cells(3).Value
        cmbxSugarLevel.Text = dr.Cells(4).Value
        txtQuantity.Focus()

        'change right panel properties
        pnlSelectedItem.Enabled = False

        'change left panel properties
        EnableLeftPanelControls(True)
        dgvItemList.Enabled = False
        cmbxSelectProduct.Enabled = False
        btnAddProduct.Text = "Update product list"
    End Sub

    'CMBX Events-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub cmbxSelectProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxSelectProduct.SelectedIndexChanged
        If cmbxSelectProduct.Text = "Milktea Products" Then
            LoadMilkteaTable(dgvItemList)

            lblCupSize.Show()
            lblSugarLevel.Show()
            lblToppings.Show()
            cmbxCupSize.Show()
            cmbxSugarLevel.Show()
            txtToppings.Show()
            btnSelectToppings.Show()
            lblItemName.Location = New Point(25, 25)
            lblQuantity.Location = New Point(229, 155)
            txtItemName.Location = New Point(25, 49)
            txtQuantity.Location = New Point(229, 179)
            txtQuantity.Size = New Size(198, 36)
        ElseIf cmbxSelectProduct.Text = "Other Products" Then
            LoadAdditionalProductsTable(dgvItemList)

            lblCupSize.Hide()
            lblSugarLevel.Hide()
            lblToppings.Hide()
            cmbxCupSize.Hide()
            cmbxSugarLevel.Hide()
            txtToppings.Hide()
            btnSelectToppings.Hide()
            lblItemName.Location = New Point(25, 62)
            lblQuantity.Location = New Point(25, 127)
            txtItemName.Location = New Point(25, 86)
            txtQuantity.Location = New Point(25, 151)
            txtQuantity.Size = New Size(402, 36)
        End If

        ResetLeftPanelControls()
    End Sub

    'DGV Events-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub dgvItemList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellDoubleClick
        If dgvItemList.Rows.Count > 0 Then
            If dgvItemList.CurrentRow.Index >= 0 Then
                Dim row As DataGridViewRow
                row = dgvItemList.Rows(dgvItemList.CurrentRow.Index) 'throws dgvSettings value to textboxes
                txtItemName.Text = row.Cells(0).Value
                EnableLeftPanelControls(True)
                cmbxCupSize.SelectedIndex = 0
                cmbxSugarLevel.SelectedIndex = 0
                'dgvItemList.Enabled = False
                'cmbxSelectProduct.Enabled = False
                'pnlSelectedItem.Enabled = False

                pnlSelectItem.Enabled = False
                pnlAddItem.Enabled = True
            End If
        End If
    End Sub
    Private Sub dgvSelectedItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSelectedItemList.CellClick
        btnEdit.Enabled = True
        btnVoid.Enabled = True

    End Sub
    Private Sub dgvSelectedItemList_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvSelectedItemList.RowsAdded
        txtItemPrice.Text = GetSubtotal()
        ResetRightPanelControls()
    End Sub
    Private Sub dgvSelectedItemList_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvSelectedItemList.RowsRemoved
        txtItemPrice.Text = GetSubtotal()
        ResetRightPanelControls()
    End Sub

    'TXT Events-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If cmbxSelectProduct.SelectedItem = "Milktea Products" Then
            FilterMilktea(txtSearch.Text, dgvItemList)
        ElseIf cmbxSelectProduct.SelectedItem = "Other Products" Then
            FilterAdditionalProduct(txtSearch.Text, dgvItemList)
        End If
    End Sub
    Private Sub TxtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtQuantity_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtQuantity.Text = digitsOnly.Replace(txtQuantity.Text, "")
        If txtQuantity.Text = "" Then
            txtQuantity.Text = 0
        End If
    End Sub

    'Private Functions-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Function GetSubtotal()
        Dim rowsCount As Integer = dgvSelectedItemList.Rows.Count
        Dim subTotal As Decimal = 0
        btnDone.Enabled = True

        If rowsCount > 1 Then
            For i = 0 To rowsCount - 1
                subTotal += dgvSelectedItemList.Rows(i).Cells(5).Value
            Next
        ElseIf rowsCount > 0 Then
            subTotal = dgvSelectedItemList.Rows(0).Cells(5).Value
        Else
            btnDone.Enabled = False
        End If

        Return subTotal
    End Function
    Public Sub ResetLeftPanelControls()
        tooltip.RemoveAll()
        EnableLeftPanelControls(False)
        dgvItemList.Enabled = True
        cmbxSelectProduct.Enabled = True
        dgvItemList.ClearSelection()
        txtItemName.Clear()
        txtQuantity.Text = 0
        txtToppings.Text = "No selected toppings"
        btnAddProduct.Text = "Add product to list"
        cmbxCupSize.SelectedIndex = -1
        cmbxSugarLevel.SelectedIndex = -1
        pnlSelectItem.Enabled = True
    End Sub
    Private Sub ResetRightPanelControls()
        dgvSelectedItemList.ClearSelection()
        btnVoid.Enabled = False
        btnEdit.Enabled = False
    End Sub
    Private Sub EnableLeftPanelControls(enable As Boolean)
        cmbxCupSize.Enabled = enable
        cmbxSugarLevel.Enabled = enable
        btnSelectToppings.Enabled = enable
        btnCancel.Enabled = enable
        btnAddProduct.Enabled = enable
    End Sub

End Class