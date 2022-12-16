Imports Newtonsoft
Public Class frmPlaceOrder
    Dim payment As Decimal = 0
    Dim subTotal As Decimal = frmPointOfSale.txtItemPrice.Text
    Dim serviceFee As Decimal = 0
    Dim storeDiscount As Decimal = 0
    Dim discount As Decimal = 0
    Dim change As Decimal = 0
    Dim totalPrice As Decimal = 0

    Dim random As New Random
    Public receiptNo = random.Next(100000, 999999)
    Public transacID = random.Next(100000, 989999)
    Dim itemsUsed As New OrderedItems
    'Dim itemName As List(Of String) = GetItems()

    Private Sub frmPlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formShadow.SetShadowForm(Me)
        PopulateCustomerType(cmbxCustomerType)
        PopulatePaymentType(cmbxPaymentType)
        PopulateServiceType(cmbxServiceType)
        GetTotal()
    End Sub

    'CMBX Events---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub cmbxCustomerType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCustomerType.SelectedIndexChanged
        If IsNumeric(cmbxCustomerType.SelectedValue) Then
            Dim bool As Boolean = IIf(cmbxCustomerType.SelectedIndex > 0, True, False)
            txtAccountDiscount.Text = cmbxCustomerType.SelectedValue * subTotal

            For Each Textbox In pnlCustomerDetails.Controls.OfType(Of Guna.UI2.WinForms.Guna2TextBox)
                Textbox.ReadOnly = bool
                Textbox.Clear()
            Next
            btnShowCustomerList.Enabled = bool
            pnlPayment.Enabled = Not bool
            GetTotal()
        End If
    End Sub

    Private Sub cmbxPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxPaymentType.SelectedIndexChanged
        If cmbxPaymentType.Text = "Cash" Then
            txtPayment.ReadOnly = False
        Else
            txtPayment.ReadOnly = True
            txtPayment.Text = totalPrice
        End If
    End Sub

    Private Sub cmbxServiceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxServiceType.SelectedIndexChanged
        Try
            txtServiceFee.Text = cmbxServiceType.SelectedValue
        Catch ex As Exception
            txtServiceFee.Text = 0
        End Try
        GetTotal()
    End Sub

    'BTN Events---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub btnSelectToppings_Click(sender As Object, e As EventArgs) Handles btnShowCustomerList.Click
        Dim newFrmCustomerList As New frmCustomerList
        newFrmCustomerList.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Dim mbxMessage As String = "Do you want to process this order?"
        Dim mbxCaption As String = "Process Order"
        Dim mbxButton As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim mbxResult As DialogResult = MessageBox.Show(mbxMessage, mbxCaption, mbxButton)

        If mbxResult = DialogResult.Yes Then
            If cmbxCustomerType.SelectedIndex = 0 And txtCustomerName.Text <> "" Or txtCustomerNumber.Text <> "" Or txtCustomerAddress.Text <> "" Then

                'InsertUnregCustomer(txtCustomerName.Text, txtCustomerNumber.Text, txtCustomerAddress.Text)
            End If

            Do While GetTableColumnNumber(receiptNo, "transaction", "Receipt_ID", "Transaction_ID") > 0 'generate receipt number
                receiptNo = CInt(Math.Floor(999999 * Rnd()))
            Loop

            Dim productsOrder As New ProductsOrdered '
            For i = 0 To frmPointOfSale.dgvSelectedItemList.Rows.Count - 1
                Dim product As New Product With {
                    .ID = GetTableColumnNumber(frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(0).Value,
                                               IIf(MilkteaRowCount(frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(0).Value) <> 0,
                                                   "milktea",
                                                   "additional_products"),
                                               "Name",
                                               IIf(MilkteaRowCount(frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(0).Value) <> 0,
                                                   "Milktea_ID",
                                                   "Additional_Products_ID")),
                    .Name = frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(0).Value,
                    .Add_ons = frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(1).Value,
                    .SugarLevelID = IIf(frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(4).Value = "",
                                        Nothing,
                                        GetTableColumnNumber(frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(4).Value,
                                                             "sugar_level",
                                                             "Name",
                                                             "Sugar_Level_ID")),
                    .SizeID = IIf(frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(3).Value = "",
                                  Nothing,
                                  GetTableColumnNumber(frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(3).Value,
                                                       "cup_size",
                                                       "Name",
                                                       "Cup_Size_ID")),
                    .Quantity = frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(2).Value,
                    .Price = frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(5).Value
                }
                productsOrder.product.Add(product)
            Next

            Dim customerType As String = cmbxCustomerType.Text
            Dim newJson As String = ""

            If itemsUsed.Item.Count > 0 Then

                For i = 0 To itemsUsed.Item.Count - 1
                    Dim strtxt = "txtItemQuantity" + i.ToString
                    Dim txt As Bunifu.UI.WinForms.BunifuTextBox = Me.Controls.Find(strtxt, True)(0)
                    If txt.Text <> "" Then
                        If txt.Text < GetTableColumnNumber(itemsUsed.Item(i).Name, "others", "Name", "Stock") Then
                            itemsUsed.Item(i).Quantity = txt.Text
                        Else
                            displaySnackbar(Me, "Insufficient " & itemsUsed.Item(i).Name & " stock", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, DefaultDuration, "",
                                            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomCenter, Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner, snackbar)
                            Exit Sub
                        End If

                    End If
                Next

                newJson = Json.JsonConvert.SerializeObject(itemsUsed)

            End If

            Do While GetTransacID(transacID) = True
                transacID = CInt(Math.Floor(999999 * Rnd()))
            Loop

            For i = 0 To productsOrder.product.Count - 1
                Dim serviceTypeID As String = GetTableColumnNumber(cmbxServiceType.Text, "service_type", "Name", "Service_Type_ID")
                Dim customerID As String = IIf(cmbxCustomerType.Text = "Regular", Nothing, GetTableColumnNumber(txtCustomerName.Text, "customer", "Name", "Customer_ID"))
                'Dim unregCustomerID As String = IIf(cmbxCustomerType.Text = "Regular", GetTableColumnString(txtCustomerName.Text, "unregistered_customer", "Name", "Unregistered_Customer_ID"), 1)
                Dim customerTypeID As String = IIf(customerID = Nothing, Nothing, GetTableColumnNumber(customerID, "customer", "Customer_ID", "Customer_Type_ID"))
                Dim milkteaID As String = IIf(MilkteaRowCount(frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(0).Value) <> 0, productsOrder.product(i).ID, Nothing)
                Dim AdditionalProductID As String = IIf(MilkteaRowCount(frmPointOfSale.dgvSelectedItemList.Rows(i).Cells(0).Value) <> 0, Nothing, productsOrder.product(i).ID)
                Do While GetTransacID(transacID) = True
                    transacID += 1
                Loop
                If cmbxCustomerType.Text <> "Regular" Then
                    UpdateNoOfPurchase(productsOrder.product(i).Quantity, GetTableColumnNumber(txtCustomerName.Text, "customer", "Name", "Customer_ID"))
                End If
                '
                UpdateCupStock(productsOrder.product(i).Quantity, productsOrder.product(i).SizeID)

                InsertOrder(receiptNo, cmbxPaymentType.SelectedValue, serviceTypeID,
                            LoggedUser.ID, customerID, milkteaID,
                            productsOrder.product(i).SizeID, productsOrder.product(i).Add_ons,
                            AdditionalProductID, productsOrder.product(i).Quantity,
                            productsOrder.product(i).Price, lblPayment.Text, discount)

                InsertTransac(transacID, GetTableColumnNumber(receiptNo,
                                                              "receipt",
                                                              "Receipt_ID",
                                                              "ID"),
                              cmbxPaymentType.SelectedValue, serviceTypeID, LoggedUser.ID,
                              customerID, customerTypeID, milkteaID,
                              productsOrder.product(i).SizeID, AdditionalProductID,
                              productsOrder.product(i).SugarLevelID, Nothing,
                              Nothing, productsOrder.product(i).Add_ons)

                If customerID IsNot Nothing Then
                    EditNumberOfPurchase(0, customerID)
                End If
            Next

            LoadReport("Receipt", receiptNo)

            displaySnackbar(frmIndexScreen, "Order processed successfully!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, DefaultDuration, "",
                                            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomCenter, Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner, snackbar)

            ActLog("Place Order")
            frmPointOfSale.ResetLeftPanelControls()
            frmPointOfSale.dgvSelectedItemList.Rows.Clear()

            Try
                cmbxCustomerType.SelectedIndex = 0
                cmbxPaymentType.SelectedIndex = 0
                cmbxServiceType.SelectedIndex = 0
            Catch ex As Exception

            End Try

            txtCustomerAddress.Clear()
            txtCustomerName.Clear()
            txtCustomerNumber.Clear()
            txtPayment.Clear()
            Me.Close()

        End If
        Me.Close()
    End Sub

    'TXT Events---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged
        GetTotal()
    End Sub
    Private Sub txtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged
        Dim bool As Boolean = True
        If cmbxCustomerType.SelectedIndex > 0 Then
            bool = IIf(txtCustomerName.Text <> "", True, False)
        End If

        pnlPayment.Enabled = bool
    End Sub

    'PNL Events---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub pnlPayment_EnabledChanged(sender As Object, e As EventArgs) Handles pnlPayment.EnabledChanged
        For Each Control In pnlPayment.Controls
            If TypeOf Control Is Guna.UI2.WinForms.Guna2TextBox Then
                Control.Text = 0
            ElseIf TypeOf Control Is Guna.UI2.WinForms.Guna2ComboBox Then
                Control.SelectedIndex = 0
            End If
        Next
    End Sub

    'Private Functions---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Public Function GetTotal() As Decimal
        Dim promoName As String() = tooltip.GetToolTip(txtStoreDiscount).Split(","c)

        'reset to zero
        payment = 0
        serviceFee = 0
        discount = 0
        change = 0
        totalPrice = 0
        storeDiscount = 0

        'compute
        Try
            storeDiscount = PromoSum(promoName)
            payment += IIf(txtPayment.Text = "", 0, txtPayment.Text)
            serviceFee += txtServiceFee.Text
            discount += ((cmbxCustomerType.SelectedValue + storeDiscount) * subTotal)
            totalPrice += (subTotal - discount) + serviceFee
            change += (payment - totalPrice)
            lblPayment.Text = payment
            lblSubTotal.Text = subTotal
            lblServiceFee.Text = serviceFee
            lblDiscount.Text = discount
            lblChange.Text = change
            lblTotalPrice.Text = totalPrice
        Catch ex As Exception

        End Try

        Dim bool As Boolean = False

        If change >= 0 Then
            bool = True
        End If

        btnPlaceOrder.Enabled = bool

        If cmbxPaymentType.SelectedIndex > 0 Then
            txtPayment.Text = totalPrice
        End If

        Return totalPrice

    End Function

    Private Sub btnShowDiscountList_Click(sender As Object, e As EventArgs) Handles btnShowDiscountList.Click
        Dim DiscountList As New frmDiscountList
        DiscountList.ShowDialog()
    End Sub

    ''' <summary>
    ''' Get the sum of promoArr Array
    ''' </summary>
    ''' <param name="promoArr">String array of promo names</param>
    ''' <returns>Sum of promoArr discount.</returns>
    Private Function PromoSum(promoArr() As String) As Decimal
        Dim result As Decimal = 0
        For i = 0 To promoArr.Length - 1
            result += IIf(GetTableColumnString(promoArr(i), "promo", "Name", "Discount") = "", 0, GetTableColumnString(promoArr(i), "promo", "Name", "Discount"))
        Next

        Return result
    End Function

    Private Sub txtCustomerNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustomerNumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class