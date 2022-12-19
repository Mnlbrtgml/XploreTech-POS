Imports Bunifu.UI.WinForms
Imports Guna.UI2.WinForms

Public Class frmModifyItem

    Dim CurrentStatus As String = ""

    Private Sub frmEditItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim drOthers As DataGridViewRow = frmOtherSettings.dgvTable.CurrentRow
        Dim drInventory As DataGridViewRow = frmInventorySettings.dgvTable.CurrentRow

        formShadow.SetShadowForm(Me)
        FormatControls()
        ActiveControl = Textbox01
        Combobox.Items.Clear()

        If pnlEditing.Tag = "User account" Then
            ChangeFormProperty(404, 504, 354, 454)
            btnCancel.Location = New Point(25, 393)
            btnSave.Location = New Point(181, 393)
            CurrentStatus = "this user account"
            Label01.Text = "Account name"
            Label02.Text = "Account type"
            Label03.Text = "Account username"
            Label04.Text = "Account password"
            Textbox03.PasswordChar = "*"
            Combobox.Items.Add("Admin")
            Combobox.Items.Add("Cashier")
            Label01.Show()
            Label02.Show()
            Label03.Show()
            Label04.Show()
            Textbox01.Show()
            Textbox02.Show()
            Textbox03.Show()
            Combobox.Show()

            If Me.Tag = "Edit" Then
                Button01.Location = New Point(25, 309)
                Button01.Text = "Change password"
                Button01.Show()
                Textbox01.Text = drOthers.Cells("Account Name").Value.ToString
                Textbox02.Text = drOthers.Cells("Username").Value.ToString
                Textbox03.Text = DecryptPassword(GetTableColumnString(drOthers.Cells("Account Name").Value.ToString, "user", "Full_Name", "Password"))
                Textbox03.ReadOnly = True
                Combobox.SelectedItem = drOthers.Cells("Account Type").Value.ToString
            Else
                Label05.Text = "Re-type password"
                Label05.Show()
                Textbox04.PasswordChar = "*"
                Textbox04.Show()
            End If
        ElseIf pnlEditing.Tag = "Customer list" Then
            PopulateCustomerType(Combobox)
            ChangeFormProperty(404, 504, 354, 454)
            btnCancel.Location = New Point(25, 393)
            btnSave.Location = New Point(181, 393)
            CurrentStatus = "this customer account"
            Label01.Text = "Customer name"
            Label02.Text = "Customer type"
            Label03.Text = "Customer number"
            Label04.Text = "Customer address"
            Label01.Show()
            Label02.Show()
            Label03.Show()
            Label04.Show()
            Label05.Show()
            Textbox01.Show()
            Textbox02.Show()
            Textbox03.Show()
            Combobox.Show()

            If Me.Tag = "Edit" Then
                Textbox01.Text = drOthers.Cells("Customer Name").Value.ToString
                Textbox02.Text = drOthers.Cells("Customer Number").Value.ToString
                Textbox03.Text = drOthers.Cells("Customer Address").Value.ToString
                Textbox04.Text = drOthers.Cells("Number of Purchased").Value.ToString
                Combobox.Text = drOthers.Cells("Customer Type").Value.ToString
            Else

            End If
        ElseIf pnlEditing.Tag = "Customer type" Then
            ChangeFormProperty(404, 309, 354, 259)
            Textbox02.Location = New Point(25, 114)
            btnCancel.Location = New Point(25, 198)
            btnSave.Location = New Point(181, 198)
            CurrentStatus = "this customer type"
            Label01.Text = "Customer type name"
            Label02.Text = "Customer type discount"
            Label01.Show()
            Label02.Show()
            Textbox01.Show()
            Textbox02.Show()

            If Me.Tag = "Edit" Then
                Textbox01.Text = drOthers.Cells("Name").Value.ToString
                Textbox02.Text = drOthers.Cells("Discount").Value.ToString
            Else

            End If
        ElseIf pnlEditing.Tag = "Product" Then
            ChangeFormProperty(404, 376, 354, 326)
            Textbox02.Location = New Point(25, 114)
            Combobox.Location = New Point(25, 179)
            btnCancel.Location = New Point(25, 263)
            btnSave.Location = New Point(181, 263)
            CurrentStatus = "this product"
            Label01.Text = "Product name"
            Label02.Text = "Product price"
            Label03.Text = "Product Status"
            Combobox.Items.Add("Available")
            Combobox.Items.Add("Not-Available")
            Label01.Show()
            Label02.Show()
            Label03.Show()
            Textbox01.Show()
            Textbox02.Show()
            Combobox.Show()

            If Me.Tag = "Edit" Then
                If frmInventorySettings.cmbxSettings.SelectedItem = "Milktea Products Settings" Or frmInventorySettings.cmbxSettings.SelectedItem = "Additional Products Settings" Then
                    Textbox01.Text = drInventory.Cells("Product Name").Value.ToString
                    Textbox02.Text = drInventory.Cells("Product Price").Value.ToString
                    Combobox.SelectedItem = drInventory.Cells("Product Status").Value.ToString
                ElseIf frmInventorySettings.cmbxSettings.SelectedItem = "Toppings Settings" Then
                    Textbox01.Text = drInventory.Cells("Add-ons Name").Value.ToString
                    Textbox02.Text = drInventory.Cells("Add-ons Price").Value.ToString
                    Combobox.SelectedItem = drInventory.Cells("Status").Value.ToString
                End If
            Else

            End If
        ElseIf pnlEditing.Tag = "Promo" Then
            ChangeFormProperty(403, 421, 353, 371)
            btnCancel.Location = New Point(25, 310)
            btnSave.Location = New Point(181, 310)
            Textbox02.Location = New Point(25, 114)
            Textbox03.Location = New Point(25, 179)
            Checkbox.Location = New Point(25, 226)
            CurrentStatus = "this promo"
            Label01.Text = "Promo name"
            Label02.Text = "Promo description"
            Label03.Text = "Promo discount"
            Checkbox.Text = "Display promo"
            Label01.Show()
            Label02.Show()
            Label03.Show()
            Textbox01.Show()
            Textbox02.Show()
            Textbox03.Show()
            Checkbox.Show()

            If Me.Tag = "Edit" Then
                Textbox01.Text = drOthers.Cells("Promo Name").Value.ToString
                Textbox02.Text = drOthers.Cells("Description").Value.ToString
                Textbox03.Text = drOthers.Cells("Discount").Value.ToString
                Checkbox.CheckState = IIf(drOthers.Cells("Available").Value.ToString = "True", 1, 0)
            Else

            End If

        ElseIf pnlEditing.Tag = "Service type" Then
            ChangeFormProperty(404, 309, 354, 259)
            Textbox02.Location = New Point(25, 114)
            btnCancel.Location = New Point(25, 198)
            btnSave.Location = New Point(181, 198)
            CurrentStatus = "this service type"
            Label01.Text = "Service name"
            Label02.Text = "Service fee"
            Label01.Show()
            Label02.Show()
            Textbox01.Show()
            Textbox01.Enabled = False
            Textbox02.Show()

            If Me.Tag = "Edit" Then
                Textbox01.Text = drOthers.Cells("Name").Value.ToString
                Textbox02.Text = drOthers.Cells("Fee").Value.ToString
            Else

            End If
        End If

        If Combobox.Items.Count > 0 And Me.Tag = "Add" Then
            Combobox.SelectedIndex = 0
        End If
    End Sub

    Private Sub ChangePass(Optional password As String = "")
        FormatControls()

        Dim drOthers As DataGridViewRow = frmOtherSettings.dgvTable.CurrentRow
        Textbox01.Text = drOthers.Cells("Account Name").Value.ToString
        Textbox02.Text = drOthers.Cells("Username").Value.ToString
        Textbox03.Text = IIf(password = "", DecryptPassword(GetTableColumnString(drOthers.Cells("Account Name").Value.ToString, "user", "Full_Name", "Password")), password)
        Combobox.SelectedItem = drOthers.Cells("Account Type").Value.ToString
        Textbox03.ReadOnly = True
        Textbox01.Enabled = True
        Textbox02.Enabled = True
        Textbox03.Enabled = True

        Button01.Location = New Point(25, 309)
        Label01.Text = "Account name"
        Label02.Text = "Account type"
        Label03.Text = "Account username"
        Label04.Text = "Account password"
        Button01.Text = "Change password"
        Textbox03.PasswordChar = "*"
        Label01.Show()
        Label02.Show()
        Label03.Show()
        Label04.Show()
        Textbox01.Show()
        Textbox02.Show()
        Textbox03.Show()
        Combobox.Show()
        Button01.Show()
        Textbox01.Focus()
    End Sub

    Private Sub Button01_Click(sender As Object, e As EventArgs) Handles Button01.Click
        If Button01.Text = "Change password" Then

            FormatControls()
            btnSave.Tag = "ChangePass"
            Button01.Location = New Point(25, 244)
            Textbox02.Location = New Point(25, 114)
            Textbox03.Location = New Point(25, 179)
            Textbox02.Enabled = False
            Textbox03.Enabled = False
            Label01.Text = "Old password"
            Label02.Text = "New password"
            Label03.Text = "Re-type password"
            Button01.Text = "Cancel"
            Textbox01.PasswordChar = "*"
            Textbox02.PasswordChar = "*"
            Textbox03.PasswordChar = "*"
            Label01.Show()
            Label02.Show()
            Label03.Show()
            Textbox01.Show()
            Textbox02.Show()
            Textbox03.Show()
            Button01.Show()
            Textbox01.Focus()
        Else
            btnSave.Tag = Nothing
            ChangePass()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If Tag = "Edit" Then
            Dim message As String = "Do you really want to cancel editing " & CurrentStatus & "?"
            Dim caption As String = "Create Account"
            Dim button As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim result As DialogResult = MessageBox.Show(message, caption, button)

            If result = DialogResult.Yes Then
                Me.Hide()
            End If
        Else
            Dim message As String = "Do you really want to cancel adding " & CurrentStatus & "?"
            Dim caption As String = "Create Account"
            Dim button As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim result As DialogResult = MessageBox.Show(message, caption, button)

            If result = DialogResult.Yes Then
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim res As String = ErrorChecker()
        If btnSave.Tag = "ChangePass" Then
            If Textbox02.Text = Textbox03.Text Then
                If ValidPassword(Textbox03.Text) Then
                    ChangePass(Textbox03.Text)
                    btnSave.Tag = Nothing
                Else
                    MsgBox("Password must have minimum length of 8 characters with atleast one numeric, lower, upper character.",
                                vbOKOnly, "Error Saving Password")
                End If
            Else
                MsgBox("Password and Retype Password must be the same.",
                                vbOKOnly, "Error Saving Password")
            End If
            Exit Sub
        End If
        If res = "" Then

            Dim message As String = "Do you really want to save " & CurrentStatus & "?"
            Dim caption As String = "Create Account"
            Dim button As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim result As DialogResult = MessageBox.Show(message, caption, button)

            If result = DialogResult.Yes Then
                If Me.Tag = "Add" Then
                    'Add
                    If pnlEditing.Tag = "User account" Then
                        If GetTableColumnString(Trim(Textbox01.Text), "user", "Full_Name", "User_ID") = "" And GetTableColumnString(Trim(Textbox02.Text), "user", "Username", "User_ID") = "" Then
                            InsertUser(Trim(Textbox01.Text), Trim(Combobox.Text), Trim(Textbox02.Text), EncryptPassword(Trim(Textbox03.Text)))
                            ActLog("Add new user: " & Textbox01.Text)
                        Else
                            MsgBox("Account Name/ Username already registered", vbOKOnly, "Error Saving Account")
                        End If
                        LoadAccountTable(frmOtherSettings.dgvTable)

                    ElseIf pnlEditing.Tag = "Customer list" Then
                        If GetTableColumnString(Trim(Textbox01.Text), "customer", "Name", "Customer_ID") = "" Then
                            InsertCustomer(Trim(GetTableColumnNumber(Combobox.Text, "customertype", "Name", "Customer_Type_ID")), Trim(Textbox01.Text), Trim(Textbox02.Text), Trim(Textbox03.Text))
                            ActLog("Add new customer: " & Textbox01.Text)
                        Else
                            MsgBox("Customer Name already registered", vbOKOnly, "Error Saving Customer")
                        End If
                        LoadCustomerListTable(frmOtherSettings.dgvTable)

                    ElseIf pnlEditing.Tag = "Customer type" Then
                        If GetTableColumnString(Trim(Textbox01.Text), "customertype", "Name", "Customer_Type_ID") = "" Then
                            InsertCustomerType(Trim(Textbox01.Text), Trim(Textbox02.Text))
                            ActLog("Add new customer type: " & Textbox01.Text)
                        Else
                            MsgBox("Customer Type already exist", vbOKOnly, "Error Saving Customer Type")
                        End If
                        LoadCustomerTypeTable(frmOtherSettings.dgvTable)

                    ElseIf pnlEditing.Tag = "Product" Then
                        If frmInventorySettings.cmbxSettings.SelectedItem = "Milktea Products Settings" Then
                            If GetTableColumnString(Trim(Textbox01.Text), "milktea", "Name", "Milktea_ID") = "" Then
                                InsertMilktea(Trim(Textbox01.Text), Trim(Textbox02.Text), Trim(Combobox.Text))
                                ActLog("Add new milktea: " & Textbox01.Text)
                            Else
                                MsgBox("Product already exist", vbOKOnly, "Error Saving Product")
                            End If
                            LoadMilkteaTable(frmInventorySettings.dgvTable)
                        ElseIf frmInventorySettings.cmbxSettings.SelectedItem = "Additional Products Settings" Then
                            If GetTableColumnString(Trim(Textbox01.Text), "additional_products", "Name", "Additional_Products_ID") = "" Then
                                InsertAdditional(Trim(Textbox01.Text), Trim(Textbox02.Text), Trim(Combobox.Text))
                                ActLog("Add new additional product: " & Textbox01.Text)
                            Else
                                MsgBox("Product already exist", vbOKOnly, "Error Saving Product")
                            End If
                            LoadAdditionalProductsTable(frmInventorySettings.dgvTable)
                        ElseIf frmInventorySettings.cmbxSettings.SelectedItem = "Toppings Settings" Then
                            If GetTableColumnString(Trim(Textbox01.Text), "add_ons", "Name", "Add_Ons_ID") = "" Then
                                InsertAdd_Ons(Trim(Textbox01.Text), Trim(Textbox02.Text), Trim(Combobox.Text))
                                ActLog("Add new add-ons: " & Textbox01.Text)
                            Else
                                MsgBox("Product already exist", vbOKOnly, "Error Saving Product")
                            End If
                            LoadAddonsTable(frmInventorySettings.dgvTable)
                        End If
                    ElseIf pnlEditing.Tag = "Promo" Then
                        If GetTableColumnString(Trim(Textbox01.Text), "promo", "Name", "Promo_ID") = "" Then
                            InsertPromo(Trim(Textbox01.Text), Trim(Textbox02.Text), Trim(Textbox03.Text), Checkbox.CheckState)
                            ActLog("Add new promo: " & Textbox01.Text)
                        Else
                            MsgBox("Promo already exist", vbOKOnly, "Error Saving Promo")
                        End If
                        LoadPromoTable(frmOtherSettings.dgvTable)
                    ElseIf pnlEditing.Tag = "Service type" Then

                    End If
                Else
                    'Edit
                    Dim drOthers As DataGridViewRow = frmOtherSettings.dgvTable.CurrentRow
                    Dim drInventory As DataGridViewRow = frmInventorySettings.dgvTable.CurrentRow

                    If pnlEditing.Tag = "User account" Then
                        If ValidUser(Textbox02.Text) Then
                            EditUser(Trim(Textbox01.Text), Trim(Combobox.Text), Trim(Textbox02.Text), EncryptPassword(Trim(Textbox03.Text)),
                                 GetTableColumnNumber(drOthers.Cells("Account Name").Value, "user", "Full_Name", "User_ID"))
                            LoadAccountTable(frmOtherSettings.dgvTable)
                            ActLog("Edit User: " & Textbox01.Text)
                        Else
                            MsgBox("Account username must have atleast 8 characters length.", vbOKOnly, "Invalid User")
                            Textbox02.Focus()
                            Exit Sub
                        End If

                    ElseIf pnlEditing.Tag = "Customer list" Then

                        EditCustomer(Trim(GetTableColumnNumber(Combobox.Text, "customertype", "Name", "Customer_Type_ID")), Trim(Textbox01.Text), Trim(Textbox02.Text), Trim(Textbox03.Text),
                                GetTableColumnNumber(drOthers.Cells("Customer Name").Value, "customer", "Name", "Customer_ID"))
                        LoadCustomerListTable(frmOtherSettings.dgvTable)
                        ActLog("Edit Customer: " & Textbox01.Text)
                    ElseIf pnlEditing.Tag = "Customer type" Then
                        EditCustomerType(Trim(Textbox01.Text), Trim(Textbox02.Text),
                                         GetTableColumnNumber(drOthers.Cells("Name").Value, "customertype", "Name", "Customer_Type_ID"))
                        LoadCustomerTypeTable(frmOtherSettings.dgvTable)
                        ActLog("Edit Customer Type: " & Textbox01.Text)
                    ElseIf pnlEditing.Tag = "Product" Then
                        If frmInventorySettings.cmbxSettings.SelectedItem = "Milktea Products Settings" Then
                            EditMilktea(Trim(Textbox01.Text), Trim(Textbox02.Text), Trim(Combobox.Text),
                                        GetTableColumnNumber(drInventory.Cells("Product Name").Value, "milktea", "Name", "Milktea_ID"))
                            LoadMilkteaTable(frmInventorySettings.dgvTable)
                            ActLog("Edit Milktea: " & Textbox01.Text)
                        ElseIf frmInventorySettings.cmbxSettings.SelectedItem = "Additional Products Settings" Then
                            EditAdditional(Trim(Textbox01.Text), Trim(Textbox02.Text), Trim(Combobox.Text),
                                           GetTableColumnNumber(drInventory.Cells("Product Name").Value, "additional_products", "Name", "Additional_Products_ID"))
                            LoadAdditionalProductsTable(frmInventorySettings.dgvTable)
                            ActLog("Edit Additional Products: " & Textbox01.Text)
                        ElseIf frmInventorySettings.cmbxSettings.SelectedItem = "Toppings Settings" Then
                            EditAdd_Ons(Trim(Textbox01.Text), Trim(Textbox02.Text), Trim(Combobox.Text),
                                        GetTableColumnNumber(drInventory.Cells("Add-ons Name").Value, "add_ons", "Name", "Add_Ons_ID"))
                            LoadAddonsTable(frmInventorySettings.dgvTable)
                            ActLog("Edit Add-ons: " & Textbox01.Text)
                        End If
                    ElseIf pnlEditing.Tag = "Promo" Then
                        EditPromo(Trim(Textbox01.Text), Trim(Textbox02.Text), Trim(Textbox03.Text), Checkbox.CheckState, GetTableColumnNumber(drOthers.Cells("Promo Name").Value, "promo", "Name", "Promo_ID"))
                        LoadPromoTable(frmOtherSettings.dgvTable)
                        ActLog("Edit Promo: " & Textbox01.Text)
                    ElseIf pnlEditing.Tag = "Service type" Then
                        EditServiceType(Trim(Textbox01.Text), Trim(Textbox02.Text), GetTableColumnNumber(drOthers.Cells("Name").Value, "service_type", "Name", "Service_Type_ID"))
                        LoadServiceTypeTable(frmOtherSettings.dgvTable)
                        ActLog("Edit Service Type: " & Textbox01.Text)
                    End If
                End If

                Me.Hide()
            End If
        Else
            MsgBox(res)
        End If

    End Sub

    Private Sub FormatControls()
        For Each PanelControls In pnlEditing.Controls
            PanelControls.Hide()
            If TypeOf PanelControls Is BunifuLabel Then
                PanelControls.Text = ""
            ElseIf TypeOf PanelControls Is Guna2TextBox Then
                PanelControls.Text = ""
                PanelControls.PasswordChar = ""
                PanelControls.ReadOnly = False
                PanelControls.Enabled = True
            ElseIf TypeOf PanelControls Is Guna2CheckBox Then
                PanelControls.Text = ""
                PanelControls.Checked = False
            End If
        Next

        Label01.Location = New Point(25, 25)
        Label02.Location = New Point(25, 90)
        Label03.Location = New Point(25, 155)
        Label04.Location = New Point(25, 220)
        Label05.Location = New Point(25, 285)
        Label06.Location = New Point(25, 350)
        Textbox01.Location = New Point(25, 49)
        Textbox02.Location = New Point(25, 179)
        Textbox03.Location = New Point(25, 244)
        Textbox04.Location = New Point(25, 309)
        Textbox05.Location = New Point(25, 374)
        Combobox.Location = New Point(25, 114)
        Checkbox.Location = New Point(25, 416)
        Button01.Location = New Point(25, 455)
        Button01.Location = New Point(25, 495)
        Button01.Text = ""
        Button02.Text = ""
        btnCancel.Show()
        btnSave.Show()
    End Sub

    Private Sub ChangeFormProperty(FormWidth As Short, FormHeight As Short,
                                   PanelWidth As Short, PanelHeight As Short)

        Dim ScreenWidth As Short = Screen.PrimaryScreen.Bounds.Width
        Dim ScreenHeight As Short = Screen.PrimaryScreen.Bounds.Height
        Dim XAxis As Short = (ScreenWidth / 2) - Math.Round(FormWidth / 2)
        Dim YAxis As Short = (ScreenHeight / 2) - Math.Round(FormHeight / 2)

        Debug.WriteLine("Screen size: " & ScreenWidth & ", " & ScreenHeight)

        Size = New Size(FormWidth, FormHeight)
        pnlEditing.Size = New Size(PanelWidth, PanelHeight)
        Location = New Point(XAxis, YAxis)
    End Sub

    Private Function ErrorChecker() As String
        Dim result As String = ""

        For Each PanelControls In pnlEditing.Controls
            If PanelControls.GetType.ToString() = "Guna.UI2.WinForms.Guna2TextBox" Or PanelControls.GetType.ToString() = "Guna.UI2.WinForms.Guna2ComboBox" Then
                If PanelControls.Visible = True Then
                    If PanelControls.Text = "" Then
                        PanelControls.Focus()
                        Return "Complete all the fields!"
                    End If
                End If
            End If
        Next

        Return result
    End Function

    Private Sub Textbox02_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox02.KeyPress
        If pnlEditing.Tag = "Product" Or pnlEditing.Tag = "Customer type" Or pnlEditing.Tag = "Service type" Then
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
                e.Handled = True
            End If
        ElseIf pnlEditing.Tag = "Customer list" Then
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Textbox03_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox03.KeyPress
        If pnlEditing.Tag = "Promo" Then
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Textbox04_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox04.KeyPress
        If pnlEditing.Tag = "Customer list" Then
            If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Textbox01_TextChanged(sender As Object, e As EventArgs) Handles Textbox01.TextChanged
        If btnSave.Tag = "ChangePass" Then
            Dim drOthers As DataGridViewRow = frmOtherSettings.dgvTable.CurrentRow
            If Textbox01.Text = DecryptPassword(GetTableColumnString(drOthers.Cells("Account Name").Value.ToString, "user", "Full_Name", "Password")) Then
                Textbox02.Enabled = True
                Textbox03.Enabled = True
                Textbox01.Enabled = False
                Textbox02.Focus()
            End If
        End If
    End Sub
End Class