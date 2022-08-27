Imports MySql.Data.MySqlClient

Module DatabaseOperation
    'Populate Checkbox******************************************************************************************************************************************************************************
    Public Function GetAddonsName()
        Dim toppingsList As New List(Of String)
        Using con As MySqlConnection = Conn()
            stmt = "SELECT `Name` FROM `add_ons` WHERE Add_Ons_ID > 1 AND `Status` = 'Available'"
            cmd = Command(stmt, con)
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read
                toppingsList.Add(rd("Name").ToString())
            End While
            Return toppingsList
        End Using
    End Function

    'Populate Combobox******************************************************************************************************************************************************************************
    Public Sub PopulateServiceType(cbx As Guna.UI2.WinForms.Guna2ComboBox)

        cbx.DataSource = Nothing
        cbx.Items.Clear()
        Dim data As New DataSet
        Using con As MySqlConnection = Conn()

            stmt = "SELECT * FROM service_type"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            data.Clear()
            Try
                adapter.Fill(data, "List")
            Catch ex As Exception
            End Try

            cbx.DataSource = data
            cbx.DisplayMember = "List.Name"
            cbx.ValueMember = "List.Fee"
            If cbx.Items.Count = 0 Then
                cbx.DataSource = Nothing
                cbx.Items.Add("No Item")
            End If
            cbx.SelectedIndex = 0

        End Using

    End Sub

    Public Sub PopulatePaymentType(cbx As Guna.UI2.WinForms.Guna2ComboBox)

        cbx.DataSource = Nothing
        cbx.Items.Clear()
        Dim data As New DataSet
        Using con As MySqlConnection = Conn()

            stmt = "SELECT * FROM payment_type"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            data.Clear()
            Try
                adapter.Fill(data, "List")
            Catch ex As Exception
            End Try

            cbx.DataSource = data
            cbx.DisplayMember = "List.Name"
            cbx.ValueMember = "List.Payment_Type_ID"
            If cbx.Items.Count = 0 Then
                cbx.DataSource = Nothing
                cbx.Items.Add("No Item")
            End If
            cbx.SelectedIndex = 0

        End Using

    End Sub

    Public Sub PopulateCustomerType(cbx As Guna.UI2.WinForms.Guna2ComboBox)

        cbx.DataSource = Nothing
        cbx.Items.Clear()
        Dim data As New DataSet
        Using con As MySqlConnection = Conn()

            stmt = "SELECT * FROM customertype"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            data.Clear()
            Try
                adapter.Fill(data, "List")
            Catch ex As Exception
            End Try

            cbx.DataSource = data
            cbx.DisplayMember = "List.Name"
            cbx.ValueMember = "List.Discount"
            If cbx.Items.Count = 0 Then
                cbx.DataSource = Nothing
                cbx.Items.Add("No Item")
            End If
            cbx.SelectedIndex = 0
        End Using

    End Sub


    Public Sub PopulateSugarLevel(cbx As Guna.UI2.WinForms.Guna2ComboBox)

        cbx.DataSource = Nothing
        cbx.Items.Clear()
        Dim data As New DataSet
        Using con As MySqlConnection = Conn()

            stmt = "SELECT * FROM sugar_level"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            data.Clear()
            Try
                adapter.Fill(data, "List")
            Catch ex As Exception
            End Try

            cbx.DataSource = data
            cbx.DisplayMember = "List.Name"
            cbx.ValueMember = "List.Sugar_Level_ID"
            If cbx.Items.Count = 0 Then
                cbx.DataSource = Nothing
                cbx.Items.Add("No Item")
            End If
            cbx.SelectedIndex = 0

        End Using

    End Sub
    Public Sub PopulateCupSize(cbx As Guna.UI2.WinForms.Guna2ComboBox)
        cbx.DataSource = Nothing
        cbx.Items.Clear()
        Dim data As New DataSet
        Using con As MySqlConnection = Conn()

            stmt = "SELECT * FROM cup_size WHERE Stocks > 0"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            data.Clear()
            Try
                adapter.Fill(data, "List")
            Catch ex As Exception
            End Try

            cbx.DataSource = data
            cbx.DisplayMember = "List.Name"
            cbx.ValueMember = "List.Price"
            If cbx.Items.Count = 0 Then
                cbx.DataSource = Nothing
                cbx.Items.Add("No Item")
            End If
            cbx.SelectedIndex = -1
        End Using

    End Sub

    'Populate Combobox******************************************************************************************************************************************************************************
    ''' <summary>
    ''' Load Report Data
    ''' </summary>
    ''' <param name="ReportFileName">Don't include the filename extension</param>
    Sub LoadReport(ReportFileName As String, Optional ReceiptNumber As String = "")
        Dim ds As New dbpointofsaleDataSet
        Dim table As New DataTable

        Using con As MySqlConnection = Conn()

            If ReportFileName = "Receipt" Then

                stmt = "SELECT re.Receipt_ID AS `Receipt_Number`, 
                        u.Full_Name AS `Processed_By`, 
                        re.Date_Processed, 
                        IF(cus.Name is null, ucus.Name, cus.Name) AS `Customer_Name`,
                        IF(cus.Address is null, ucus.Address, cus.Address) AS `Customer_Add`,
                        ptype.Name AS `Payment_Method`,
                        stype.Name AS `Service_Method`,
                        group_concat(IF(mi.Name is null, ap.Name, CONCAT(mi.Name,' | ',re.Add_Ons)) separator '\n') AS `Item`,
                        group_concat(cup.name separator '\n') AS `Size`,
                        group_concat(re.Quantity separator '\n') AS `Quantity`,
                        group_concat(re.Price separator '\n')  AS `Price`,
                        re.Payment,
                        re.Discount,
                        sum(re.Price) AS `Subtotal`,
                        re.Payment - (sum(re.Price) - re.Discount) AS `Change`,
                        sum(re.Price) - re.Discount AS `Total`
                        FROM     receipt re
				                          INNER JOIN payment_type ptype on re.Payment_Type_ID = ptype.Payment_Type_ID
				                          INNER JOIN service_type stype on re.Service_Type_ID = stype.Service_Type_ID
				                          INNER JOIN user u on re.User_ID = u.User_ID
				                          LEFT JOIN customer cus on re.Customer_ID = cus.Customer_ID
                                          LEFT JOIN unregistered_customer ucus on re.Unregistered_Customer_ID = ucus.Unregistered_Customer_ID
				                          LEFT JOIN milktea mi on re.Milktea_ID = mi.Milktea_ID
				                          LEFT JOIN cup_size cup on re.Cup_Size_ID = cup.Cup_Size_ID
				                          LEFT JOIN additional_products ap on re.Additional_Products_ID = ap.Additional_Products_ID
                        WHERE re.Receipt_ID = @ReceiptNumber"
            End If

            Using cmd = Command(stmt, con)
                cmd.Parameters.AddWithValue("@ReceiptNumber", ReceiptNumber)
                con.Open()
                Dim adapter As New MySqlDataAdapter(cmd)

                table = ds.Tables("Report" & ReportFileName)
                table.Clear()
                adapter.Fill(table)
                With frmTestingan.report.LocalReport
                    .ReportPath = ReportFileName & ".rdlc"
                    .DataSources.Clear()
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("reportDataSet", table))
                End With
            End Using

            frmTestingan.ShowDialog()
            frmTestingan.report.RefreshReport()
        End Using
    End Sub

    'Load Tables************************************************************************************************************************************************************************************
    Sub LoadFrmCustomerList(dgv As Bunifu.UI.WinForms.BunifuDataGridView, customerTypeID As String)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            With cmd
                .CommandText = "Select Name, Contact_Number AS `Number`, Address FROM customer WHERE Customer_Type_ID = @customerTypeID"
                .Connection = con
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@customerTypeID", customerTypeID)
            End With
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using
    End Sub

    Sub LoadAccountTable(dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select Full_Name AS 'Account Name', User_Type AS 'Account Type', Username FROM user WHERE `is_archive` = 0"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using
    End Sub

    Sub LoadMilkteaTable(dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select Name AS 'Product Name', Price AS 'Product Price', Status AS 'Product Status' FROM milktea"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using
    End Sub

    Sub LoadAddonsTable(dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select Name AS 'Add-ons Name', Price AS 'Add-ons Price', Status FROM add_ons WHERE Add_Ons_ID > 1"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using
    End Sub

    Sub LoadAdditionalProductsTable(dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select Name AS 'Product Name', Price AS 'Product Price', Status AS 'Product Status' FROM additional_products"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using
    End Sub

    Sub LoadOthersTable(dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select * FROM others"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            table.Columns.RemoveAt(4)
            table.Columns.RemoveAt(0)

            For i = 0 To table.Columns.Count - 1
                Select Case i
                    Case 0
                        table.Columns(i).ColumnName = "Item Name"
                    Case 1
                        table.Columns(i).ColumnName = "Item Stock"
                    Case 2
                        table.Columns(i).ColumnName = "Display Item"
                End Select
            Next
            dgv.DataSource = table
        End Using
    End Sub

    Sub LoadCupSizeTable(dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select Name AS 'Size Name', Price AS 'Size Additional Price', Stock FROM cup_size"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using
    End Sub

    Sub LoadCustomerListTable(dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select customer.Name AS 'Customer Name', customertype.Name AS 'Customer Type', " _
            & "customer.Contact_Number AS 'Customer Number', customer.Address AS 'Customer Address', " _
            & "customer.Number_of_Purchase AS 'Number of Purchased' FROM customer JOIN customertype ON " _
            & "customer.Customer_Type_ID=customertype.Customer_Type_ID"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using
    End Sub

    Sub LoadCustomerTypeTable(dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select Name, Discount FROM customertype"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using
    End Sub

    Sub LoadPromoTable(dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select `Name` AS 'Promo Name', `Discount`, `Description`, `Enable` AS 'Available' FROM promo WHERE Promo_ID > 1"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using
    End Sub

    Sub LoadServiceTypeTable(dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select Name, Fee FROM service_type"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using
    End Sub

    Sub LoadPaymentTypeTable(dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select * FROM payment_type"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            table.Columns.RemoveAt(0)
            dgv.DataSource = table
        End Using
    End Sub

    'Check if records exist*****************************************************************************
    Public Function RowCount(Form As Form, Optional Username As String = Nothing,
                              Optional Password As String = Nothing) As Byte

        Dim Count As Byte

        If Form Is frmSplashScreen Then
            Using con As MySqlConnection = Conn()
                cmd = Command("SELECT * FROM user WHERE User_Type = 'Admin' AND is_archive = false", con)
                con.Open()
                Count = cmd.ExecuteScalar()
                cmd = Nothing
            End Using

            Return Count
        Else
            Using con As MySqlConnection = Conn()
                With cmd
                    .Connection = con
                    .CommandText =
                        "SELECT COUNT(*) FROM user_account " _
                        & "WHERE user_account_username = @username " _
                        & "AND user_account_password = @password"
                    .Parameters.AddWithValue("@username", Username)
                    .Parameters.AddWithValue("@password", Password)
                End With

                Try
                    con.Open()
                    Count = cmd.ExecuteScalar()
                    cmd.Parameters.Clear()
                Catch ex As Exception
                    Debug.WriteLine("Error: " & ex.Message)
                Finally
                    con.Close()
                End Try
            End Using

            Return Count
        End If
    End Function
    Public Function MilkteaRowCount(Name As String) As Byte

        Dim Count As Byte

        Using con As MySqlConnection = Conn()
            With cmd
                .Connection = con
                .CommandText =
                        "SELECT COUNT(*) FROM milktea " _
                        & "WHERE Name = @name"
                .Parameters.AddWithValue("@name", Name)
            End With

            Try
                con.Open()
                Count = cmd.ExecuteScalar()
                cmd.Parameters.Clear()
            Catch ex As Exception
                Debug.WriteLine("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        End Using
        Return Count
    End Function

    'Insert functions******************************************************************************************************************************************************************************************
    Public Function InsertUnregCustomer(Name As String, Contact As String, Address As String)
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "INSERT INTO `unregistered_customer` (`Name`, `Contact_Number`, `Address`) VALUES (@name, @contact, @address)"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@name", Name)
                    .Parameters.AddWithValue("@contact", Contact)
                    .Parameters.AddWithValue("@address", Address)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function InsertActivityLog(userid As Integer, name As String, activity As String)
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "INSERT INTO `activitylog` (`User_ID`, `Name`, `Activity`, `Created_At`) VALUES (@userid, @name, @activity, Default)"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@userid", userid)
                    .Parameters.AddWithValue("@name", name)
                    .Parameters.AddWithValue("@activity", activity)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function InsertCupSize(name As String, stocks As String, price As String)
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "INSERT INTO `cup_size` (`Name`, `Stocks`, `Price`) VALUES (@name, @stocks, @price)"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@name", name)
                    .Parameters.AddWithValue("@stocks", stocks)
                    .Parameters.AddWithValue("@price", price)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function
    Public Sub InsertOrder(receiptID As String, paymentTypeID As String, serviceTypeID As String, userID As String, customerID As String, unregCustomerID As String, milkteaID As String,
                           cupSizeID As String, addOns As String, additionalProductsID As String, quantity As String, price As String, payment As String, discount As String)
        MsgBox("Receipt:" & receiptID & " paymenttype:" & paymentTypeID & " serviceType:" & serviceTypeID & " userid:" & userID & " customerid:" & customerID & " unregid:" & unregCustomerID &
               " milktea:" & milkteaID & " cupsize:" & cupSizeID & " addons:" & addOns & " additional:" & additionalProductsID & " qty:" & quantity & " price:" & price & " payment:" & payment & " discount:" & discount)
        Using con As MySqlConnection = Conn()
            stmt = "INSERT INTO `receipt` VALUES(Default, @receiptID, @paymentTypeID, @serviceTypeID, @userID, @customerID, @unregCustomerID, @milkteaID, @cupSizeID, " _
                   & "@addOns, @additionalProductsID, @quantity, @price, @payment, @discount, Default)"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .Clear()
                .AddWithValue("receiptID", receiptID)
                .AddWithValue("paymentTypeID", paymentTypeID)
                .AddWithValue("serviceTypeID", serviceTypeID)
                .AddWithValue("userID", userID)
                .AddWithValue("customerID", customerID)
                .AddWithValue("unregCustomerID", unregCustomerID)
                .AddWithValue("milkteaID", milkteaID)
                .AddWithValue("cupSizeID", cupSizeID)
                .AddWithValue("addOns", addOns)
                .AddWithValue("additionalProductsID", additionalProductsID)
                .AddWithValue("quantity", quantity)
                .AddWithValue("price", price)
                .AddWithValue("payment", payment)
                .AddWithValue("discount", discount)
            End With
            con.Open()

            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Sub InsertUser(name As String, type As String, username As String, password As String)


        Using con As MySqlConnection = Conn()
            stmt = "INSERT INTO `user` VALUES(Default, @p1, @p2, @p3, @p4, Default, Default)"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .Clear()
                .AddWithValue("p1", name)
                .AddWithValue("p2", type)
                .AddWithValue("p3", username)
                .AddWithValue("p4", password)
            End With
            con.Open()

            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Sub InsertPromo(name As String, description As String, discount As Decimal, display As Boolean)


        Using con As MySqlConnection = Conn()
            stmt = "INSERT INTO `promo` VALUES(Default, @p1, @p2, @p3, @p4)"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .Clear()
                .AddWithValue("p1", name)
                .AddWithValue("p2", description)
                .AddWithValue("p3", discount)
                .AddWithValue("p4", display)
            End With
            con.Open()
            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Sub InsertMilktea(name As String, price As Decimal, status As String)


        Using con As MySqlConnection = Conn()
            stmt = "INSERT INTO `milktea` VALUES(Default, @p1, @p2, @p3, Default)"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .Clear()
                .AddWithValue("p1", name)
                .AddWithValue("p2", price)
                .AddWithValue("p3", status)
            End With
            con.Open()
            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Sub InsertAdditional(name As String, price As Decimal, status As String)

        Using con As MySqlConnection = Conn()
            stmt = "INSERT INTO `additional_products` VALUES(Default, @p1, @p2, @p3, Default)"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .Clear()
                .AddWithValue("p1", name)
                .AddWithValue("p2", price)
                .AddWithValue("p3", status)
            End With
            con.Open()
            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Sub InsertAdd_Ons(name As String, price As Decimal, status As String)

        Using con As MySqlConnection = Conn()
            stmt = "INSERT INTO `add_ons` VALUES(Default, @p1, @p2, @p3, Default)"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .Clear()
                .AddWithValue("p1", name)
                .AddWithValue("p2", price)
                .AddWithValue("p3", status)
            End With
            con.Open()
            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Sub InsertCustomer(type As Integer, name As String, number As String, address As String)
        Using con As MySqlConnection = Conn()
            stmt = "INSERT INTO `customer` VALUES(Default, @p1, @p2, @p3, @p4, 0, Default)"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .Clear()
                .AddWithValue("p1", type)
                .AddWithValue("p2", name)
                .AddWithValue("p3", number)
                .AddWithValue("p4", address)
            End With
            con.Open()
            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Sub InsertCustomerType(name As String, discount As Decimal)
        Using con As MySqlConnection = Conn()
            stmt = "INSERT INTO `customertype` VALUES(Default, @p1, @p2)"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .Clear()
                .AddWithValue("p1", name)
                .AddWithValue("p2", discount)
            End With
            con.Open()
            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Sub InsertPaymentMethod(name As String)
        Using con As MySqlConnection = Conn()
            stmt = "INSERT INTO `payment_type` VALUES(Default, @p1)"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .Clear()
                .AddWithValue("p1", name)
            End With
            con.Open()
            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Sub InsertServiceType(name As String, fee As Decimal)
        Using con As MySqlConnection = Conn()
            stmt = "INSERT INTO `service_type` VALUES(Default, @p1, @p2)"
            cmd = Command(stmt, con)
            With cmd.Parameters
                .Clear()
                .AddWithValue("p1", name)
                .AddWithValue("p2", fee)
            End With
            con.Open()
            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Function InsertTransac(transacID As String, receiptID As String, paymentTypeID As String, serviceTypeID As String,
                                userID As String, customerID As String, customerTypeID As String, milkteaID As String, cupsizeID As String,
                                additionalProductsID As String, sugarLevelID As String, promoID As String, otherItems As String, addOns As String)
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "INSERT INTO transaction VALUES(@transacID, @receiptID, @paymentTypeID, @serviceTypeID, @userID, " _
                                 & "@customerID, @customerTypeID, @milkteaID, @cupSizeID, @additionalProductsID, @sugarLevelID, " _
                                 & "@promoID, @otherItems, @addOns, Default);"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@transacID", transacID)
                    .Parameters.AddWithValue("@receiptID", receiptID)
                    .Parameters.AddWithValue("@paymentTypeID", paymentTypeID)
                    .Parameters.AddWithValue("@serviceTypeID", serviceTypeID)
                    .Parameters.AddWithValue("@userID", userID)
                    .Parameters.AddWithValue("@customerID", customerID)
                    .Parameters.AddWithValue("@customerTypeID", customerTypeID)
                    .Parameters.AddWithValue("@milkteaID", milkteaID)
                    .Parameters.AddWithValue("@cupSizeID", cupsizeID)
                    .Parameters.AddWithValue("@additionalProductsID", additionalProductsID)
                    .Parameters.AddWithValue("@sugarLevelID", sugarLevelID)
                    .Parameters.AddWithValue("@promoID", promoID)
                    .Parameters.AddWithValue("@otherItems", otherItems)
                    .Parameters.AddWithValue("@addOns", addOns)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function InsertOthers(name As String, IsDisplayed As Boolean)
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "INSERT INTO `others` (`Stock`, `Updated`, `Name`, `is_displayed`) VALUES (Default, Default, @Name, @IsDisplayed)"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@Name", name)
                    .Parameters.AddWithValue("@IsDisplayed", IsDisplayed)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function



    '    'UPDATE `cup_size` SET `Stocks` = @DecreasedStock WHERE `Name` = @CupSizeName

    Public Function UpdateCupStock(Stock As String, Where As Short)
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `cup_size` SET `Stocks` = `Stocks` - @DecreasedStock WHERE `Cup_Size_ID` = @CupSizeID"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@DecreasedStock", Stock)
                    .Parameters.AddWithValue("@CupSizeID", Where)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    '       '    Public Sub PopulatefrmAdminTransaction(dataToppings As dbpointofsaleDataSet.toppingsDataTable, cmbToppings As Bunifu.UI.WinForms.BunifuDropdown,
    '                                           dataCupSize As dbpointofsaleDataSet.cup_sizeDataTable, cmbCupSize As Bunifu.UI.WinForms.BunifuDropdown)

    '        cmbToppings.DataSource = Nothing
    '        cmbCupSize.DataSource = Nothing

    '        cmbToppings.Items.Clear()
    '        cmbCupSize.Items.Clear()

    '        Using con As MySqlConnection = Conn()

    '            stmt = "SELECT * FROM toppings"
    '            cmd = Command(stmt, con)
    '            con.Open()
    '            Dim adapter As New MySqlDataAdapter(cmd)
    '            dataToppings.Clear()
    '            adapter.Fill(dataToppings)
    '            cmbToppings.DataSource = dataToppings
    '            cmbToppings.DisplayMember = "Name"
    '            cmbToppings.ValueMember = "Price"
    '            If cmbToppings.Items.Count > 0 Then
    '                cmbToppings.SelectedIndex = 0
    '            Else
    '                cmbToppings.DataSource = Nothing
    '                cmbToppings.Items.Add("No Item")
    '                cmbToppings.SelectedIndex = 0
    '            End If

    '        End Using

    '        Using con As MySqlConnection = Conn()

    '            stmt = "SELECT * FROM cup_size"
    '            cmd = Command(stmt, con)
    '            con.Open()
    '            Dim adapter As New MySqlDataAdapter(cmd)
    '            dataCupSize.Clear()
    '            adapter.Fill(dataCupSize)
    '            cmbCupSize.DataSource = dataCupSize
    '            cmbCupSize.DisplayMember = "Name"
    '            cmbCupSize.ValueMember = "Price"
    '            If cmbCupSize.Items.Count > 0 Then
    '                cmbCupSize.SelectedIndex = 0
    '            Else
    '                cmbCupSize.DataSource = Nothing
    '                cmbCupSize.Items.Add("No Item")
    '                cmbCupSize.SelectedIndex = 0
    '            End If

    '        End Using

    '    End Sub

    Public Function GetPromos(columnName As String) As List(Of String)

        Dim res As New List(Of String)
        Using con As MySqlConnection = Conn()
            Dim stmt =
                    "SELECT " & columnName & " FROM promo WHERE Promo_ID > 1 AND `Enable` = True"
            Dim cmd = Command(stmt, con)
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read()
                Dim colNameArr() As String = columnName.Split(","c)
                For Each col In colNameArr
                    res.Add(rd(col).ToString())
                Next
            End While
            rd.Close()
        End Using
        Return res

    End Function

    '    Public Function GetItems()

    '        Dim res As New List(Of String)
    '        Using con As MySqlConnection = Conn()
    '            Dim stmt =
    '                    "SELECT Name FROM `others` WHERE `is_displayed` = true"
    '            Dim cmd = Command(stmt, con)
    '            con.Open()
    '            Dim rd As MySqlDataReader = cmd.ExecuteReader

    '            While rd.Read()
    '                res.Add(rd("Name").ToString())
    '            End While
    '            rd.Close()
    '        End Using
    '        Return res

    '    End Function

    Public Function GetPromoDescription()

        Dim res As New List(Of String)
        Using con As MySqlConnection = Conn()
            Dim stmt =
                    "SELECT Description FROM promo WHERE Promo_ID > 1"
            Dim cmd = Command(stmt, con)
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read()
                res.Add(rd("Description").ToString())
            End While
            rd.Close()
        End Using
        Return res

    End Function

    Public Function GetTodayTransac()
        Dim rowCount As Integer = 0
        Dim res As New List(Of String)
        Using con As MySqlConnection = Conn()
            Dim stmt =
                    "SELECT DATE_FORMAT(Date_Processed, '%m/%d/%Y'), Receipt_ID FROM `transaction` WHERE DATE_FORMAT(Date_Processed, '%m/%d/%Y') = DATE_FORMAT(Now(), '%m/%d/%Y')"
            Dim cmd = Command(stmt, con)
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read()
                If res.Count > 1 Then
                    For i = 0 To res.Count - 1
                        If res(i) = rd("Receipt_ID").ToString() Then
                            Exit For
                        ElseIf i = res.Count - 1 Then
                            res.Add(rd("Receipt_ID").ToString())
                        End If
                    Next
                ElseIf res.Count > 0 Then
                    If res(0) <> rd("Receipt_ID").ToString() Then
                        res.Add(rd("Receipt_ID").ToString())
                    End If
                Else
                    res.Add(rd("Receipt_ID").ToString())
                End If
            End While

            If res.Count > 0 Then
                rowCount = res.Count
            End If
            rd.Close()
        End Using
        Return rowCount

    End Function

    Public Function GetTodayTransacCashier(loggedUserID As String)

        Dim rowCount As Integer = 0
        Dim res As New List(Of String)
        Using con As MySqlConnection = Conn()
            Dim stmt =
                    "SELECT DATE_FORMAT(Date_Processed, '%m/%d/%Y'), Receipt_ID FROM `transaction` WHERE DATE_FORMAT(Date_Processed, '%m/%d/%Y') = DATE_FORMAT(Now(), '%m/%d/%Y') AND User_ID = @loggeduser"
            Dim cmd = Command(stmt, con)
            cmd.Parameters.AddWithValue("loggeduser", loggedUserID)
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read()
                If res.Count > 1 Then
                    For i = 0 To res.Count - 1
                        If res(i) = rd("Receipt_ID").ToString() Then
                            Exit For
                        ElseIf i = res.Count - 1 Then
                            res.Add(rd("Receipt_ID").ToString())
                        End If
                    Next
                ElseIf res.Count > 0 Then
                    If res(0) <> rd("Receipt_ID").ToString() Then
                        res.Add(rd("Receipt_ID").ToString())
                    End If
                Else
                    res.Add(rd("Receipt_ID").ToString())
                End If
            End While

            If res.Count > 0 Then
                rowCount = res.Count
            End If
            rd.Close()
        End Using
        Return rowCount

    End Function

    Public Function GetIsDisplayedItem()

        Dim res As New List(Of String)
        Using con As MySqlConnection = Conn()
            Dim stmt =
                    "SELECT * FROM `others` WHERE `is_displayed` = true"
            Dim cmd = Command(stmt, con)
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read()
                res.Add(rd("Name").ToString())

            End While

            rd.Close()
        End Using

        Return res

    End Function

    Public Function GetTodayProductSold()

        Dim res As Integer = 0
        'Dim productsOrderedList As New List(Of ProductsOrdered)
        Using con As MySqlConnection = Conn()
            Dim stmt = "SELECT DATE_FORMAT(tr.Date_Processed, '%m/%d/%Y') AS Date_Processed, re.Quantity AS `Quantity` 
                        FROM transaction tr 
                        JOIN receipt re ON tr.Receipt_ID = re.ID
                        WHERE DATE_FORMAT(tr.Date_Processed, '%m/%d/%Y') = DATE_FORMAT(Now(), '%m/%d/%Y');"
            Dim cmd = Command(stmt, con)
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read()
                res += rd("Quantity")
            End While

            rd.Close()
        End Using

        Return res

    End Function

    Public Function GetTodayProductSoldCashier(loggedUserID As String)

        Dim res As Integer = 0
        'Dim productsOrderedList As New List(Of ProductsOrdered)
        Using con As MySqlConnection = Conn()
            Dim stmt = "SELECT DATE_FORMAT(tr.Date_Processed, '%m/%d/%Y') AS Date_Processed, re.Quantity AS `Quantity` 
                        FROM transaction tr 
                        JOIN receipt re ON tr.Receipt_ID = re.ID
                        WHERE DATE_FORMAT(tr.Date_Processed, '%m/%d/%Y') = DATE_FORMAT(Now(), '%m/%d/%Y') AND tr.User_ID = @loggeduser"
            Dim cmd = Command(stmt, con)
            cmd.Parameters.AddWithValue("loggeduser", loggedUserID)
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read()
                res += rd("Quantity")
            End While

            rd.Close()
        End Using

        Return res

    End Function

    Public Function GetDailySales()

        Dim res As Double = 0
        Using con As MySqlConnection = Conn()
            Dim stmt = "SELECT DATE_FORMAT(tr.Date_Processed, '%m/%d/%Y') AS Date_Processed, re.Price AS `Price` 
                        FROM transaction tr 
                        JOIN receipt re ON tr.Receipt_ID = re.ID
                        WHERE DATE_FORMAT(tr.Date_Processed, '%m/%d/%Y') = DATE_FORMAT(Now(), '%m/%d/%Y')"
            Dim cmd = Command(stmt, con)
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read()
                res += rd("Price")
            End While
            rd.Close()
        End Using

        Return res

    End Function

    Public Function GetCashierDailySales(loggedUserID As String)

        Dim res As Double = 0
        Using con As MySqlConnection = Conn()
            Dim stmt = "SELECT DATE_FORMAT(tr.Date_Processed, '%m/%d/%Y') AS Date_Processed, re.Price AS `Price` 
                        FROM transaction tr 
                        JOIN receipt re ON tr.Receipt_ID = re.ID
                        WHERE DATE_FORMAT(tr.Date_Processed, '%m/%d/%Y') = DATE_FORMAT(Now(), '%m/%d/%Y')  AND tr.User_ID = @loggeduser"
            Dim cmd = Command(stmt, con)
            cmd.Parameters.AddWithValue("loggeduser", loggedUserID)
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read()
                res += rd("Price")
            End While
            rd.Close()
        End Using

        Return res

    End Function

    Public Function GetTopSelling()

        'Dim productsOrderedList As New List(Of ProductsOrdered)
        Dim topSellingProdducts As New List(Of Item)
        Using con As MySqlConnection = Conn()
            Dim stmt = "SELECT milktea.Name AS milktea, Quantity FROM `transaction` JOIN milktea ON transaction.Milktea_ID=milktea.Milktea_ID"
            Dim cmd = Command(stmt, con)
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader

            While rd.Read()
                Dim item As New Item
                item.name = rd("milktea").ToString
                item.quantity = rd("Quantity")
                If topSellingProdducts.Count > 1 Then
                    For i = 0 To topSellingProdducts.Count - 1
                        If topSellingProdducts(i).name = item.name Then
                            topSellingProdducts(i).quantity += item.quantity
                            Exit For
                        ElseIf i = topSellingProdducts.Count - 1 Then
                            topSellingProdducts.Add(item)
                        End If
                    Next
                ElseIf topSellingProdducts.Count > 0 Then
                    If topSellingProdducts(0).name <> item.name Then
                        topSellingProdducts.Add(item)
                    Else
                        topSellingProdducts(0).quantity += item.quantity
                    End If
                Else
                    topSellingProdducts.Add(item)
                End If
            End While

            topSellingProdducts.Sort(Function(x, y) y.quantity.CompareTo(x.quantity))
            If topSellingProdducts.Count > 5 Then
                topSellingProdducts.RemoveRange(5, topSellingProdducts.Count - 5)
            End If

            'If productsOrderedList.Count > 0 Then
            '    For i = 0 To productsOrderedList.Count - 1
            '        For j = 0 To productsOrderedList(i).product.Count - 1
            '            Dim product As New TopSellingProduct
            '            product.sold = productsOrderedList(i).product(j).quantity
            '            product.name = productsOrderedList(i).product(j).name
            '            Debug.Print("ADD PRODUCT          " + product.name + product.sold.ToString)
            '            topSellingProdducts.Add(product)
            '            For k = 0 To topSellingProdducts.Count - 1
            '                If topSellingProdducts(k).name = topSellingProdducts(topSellingProdducts.Count - 1).name Then
            '                    topSellingProdducts(k).sold = topSellingProdducts(topSellingProdducts.Count - 1).sold + topSellingProdducts(k).sold
            '                    topSellingProdducts(topSellingProdducts.Count - 1).sold = 0
            '                End If
            '            Next
            '        Next
            '    Next
            'End If

            rd.Close()
        End Using

        'topSellingProdducts.Sort(Function(x, y) y.sold.CompareTo(x.sold))
        'If topSellingProdducts.Count > 5 Then
        '    topSellingProdducts.RemoveRange(5, topSellingProdducts.Count - 5)
        'End If

        'For index = 0 To topSellingProdducts.Count - 1
        '    If topSellingProdducts(index).sold > 0 Then
        '        topSellingProdducts(index).sold += 1
        '    End If
        '    'Debug.Print("PRoduct " & index & ": " & topSellingProdducts(index).name & " " & topSellingProdducts(index).sold)
        'Next

        Return topSellingProdducts

    End Function

    '    Public Function GetReceiptNo(ByVal transacID As String)

    '        Dim transacExist As Boolean = False

    '        Using con As MySqlConnection = Conn()
    '            stmt = "SELECT * FROM `transaction` WHERE CONCAT(Receipt_ID) = @transacID"
    '            cmd = Command(stmt, con)
    '            cmd.Parameters.AddWithValue("transacID", transacID)
    '            con.Open()

    '            Dim dr As MySqlDataReader = cmd.ExecuteReader
    '            dr.Read()

    '            If dr.HasRows Then
    '                transacExist = True
    '            Else
    '                transacExist = False
    '            End If
    '        End Using

    '        Return transacExist

    '    End Function

    Public Function GetTransacID(ByVal transacID As String)

        Dim transacExist As Boolean = False

        Using con As MySqlConnection = Conn()
            stmt = "SELECT * FROM `transaction` WHERE CONCAT(Transaction_ID) = @transacID"
            cmd = Command(stmt, con)
            cmd.Parameters.AddWithValue("transacID", transacID)
            con.Open()

            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                transacExist = True
            Else
                transacExist = False
            End If
        End Using

        Return transacExist

    End Function

    Public Function UpdateNoOfPurchase(NoOfPurchase As String, Where As String)
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `customer` SET `Number_of_Purchase` = `Number_of_Purchase` + @NumberOfPurchase WHERE `Customer_ID` = @CustomerID"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@NumberOfPurchase", NoOfPurchase)
                    .Parameters.AddWithValue("@CustomerID", Where)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    '    'Public Function GetColumnNames(table As String)

    '    '    Dim result As New List(Of String)

    '    '    Select Case table
    '    '        Case "milktea"
    '    '            Using con As MySqlConnection = Conn()

    '    '                stmt = "Select COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'milktea'"
    '    '                cmd = Command(stmt, con)
    '    '                con.Open()
    '    '                Dim rd As MySqlDataReader = cmd.ExecuteReader

    '    '                While rd.Read()
    '    '                    If rd("COLUMN_NAME").ToString() = "Milktea_ID" Or rd("COLUMN_NAME").ToString() = "Status" Or rd("COLUMN_NAME").ToString() = "Name" Then
    '    '                        'MsgBox(rd("COLUMN_NAME").ToString())
    '    '                        result.Add(rd("COLUMN_NAME").ToString())
    '    '                    End If

    '    '                End While
    '    '                rd.Close()

    '    '            End Using
    '    '        Case "additional_products"
    '    '            Using con As MySqlConnection = Conn()

    '    '                stmt = "Select COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'additional_products'"
    '    '                cmd = Command(stmt, con)
    '    '                con.Open()
    '    '                Dim rd As MySqlDataReader = cmd.ExecuteReader

    '    '                While rd.Read()
    '    '                    If rd("COLUMN_NAME").ToString() <> "is_archive" Then
    '    '                        result.Add(rd("COLUMN_NAME").ToString())
    '    '                    End If

    '    '                End While
    '    '                rd.Close()

    '    '            End Using
    '    '        Case "others"
    '    '            Using con As MySqlConnection = Conn()

    '    '                stmt = "Select COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'others'"
    '    '                cmd = Command(stmt, con)
    '    '                con.Open()
    '    '                Dim rd As MySqlDataReader = cmd.ExecuteReader

    '    '                While rd.Read()
    '    '                    If rd("COLUMN_NAME").ToString() <> "is_archive" Then
    '    '                        result.Add(rd("COLUMN_NAME").ToString())
    '    '                    End If

    '    '                End While
    '    '                rd.Close()

    '    '            End Using
    '    '        Case "customer"
    '    '            Using con As MySqlConnection = Conn()

    '    '                stmt = "Select COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'customer'"
    '    '                cmd = Command(stmt, con)
    '    '                con.Open()
    '    '                Dim rd As MySqlDataReader = cmd.ExecuteReader

    '    '                While rd.Read()
    '    '                    If rd("COLUMN_NAME").ToString() <> "is_archive" Then
    '    '                        result.Add(rd("COLUMN_NAME").ToString())
    '    '                    End If

    '    '                End While
    '    '                rd.Close()

    '    '            End Using
    '    '        Case "user"
    '    '            Using con As MySqlConnection = Conn()

    '    '                stmt = "Select COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbpointofsale' AND TABLE_NAME = 'user'"
    '    '                cmd = Command(stmt, con)
    '    '                con.Open()
    '    '                Dim rd As MySqlDataReader = cmd.ExecuteReader

    '    '                While rd.Read()
    '    '                    If rd("COLUMN_NAME").ToString() <> "is_archive" And rd("COLUMN_NAME").ToString() <> "Password" And rd("COLUMN_NAME").ToString() <> "Updated" And rd("COLUMN_NAME").ToString() <> "User_ID" Then
    '    '                        result.Add(rd("COLUMN_NAME").ToString())
    '    '                    End If

    '    '                End While
    '    '                rd.Close()

    '    '            End Using
    '    '            'result.Add("User_ID")
    '    '            'result.Add("Full_Name")
    '    '            'result.Add("User_Type")
    '    '            'result.Add("Username")
    '    '            'result.Add("Updated")
    '    '        Case "order"
    '    '            Using con As MySqlConnection = Conn()

    '    '                stmt = "Select COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'order'"
    '    '                cmd = Command(stmt, con)
    '    '                con.Open()
    '    '                Dim rd As MySqlDataReader = cmd.ExecuteReader

    '    '                While rd.Read()
    '    '                    If rd("COLUMN_NAME").ToString() <> "is_archive" Or rd("COLUMN_NAME").ToString() <> "Password" Then
    '    '                        result.Add(rd("COLUMN_NAME").ToString())
    '    '                    End If

    '    '                End While
    '    '                rd.Close()

    '    '            End Using

    '    '        Case "activitylog"
    '    '            Using con As MySqlConnection = Conn()

    '    '                stmt = "Select COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'activitylog'"
    '    '                cmd = Command(stmt, con)
    '    '                con.Open()
    '    '                Dim rd As MySqlDataReader = cmd.ExecuteReader

    '    '                While rd.Read()
    '    '                    If rd("COLUMN_NAME").ToString() <> "is_archive" Or rd("COLUMN_NAME").ToString() <> "User_ID" Or rd("COLUMN_NAME").ToString() <> "Created_At" Then
    '    '                        result.Add(rd("COLUMN_NAME").ToString())
    '    '                    End If

    '    '                End While
    '    '                rd.Close()

    '    '            End Using
    '    '    End Select


    '    'Return result
    '    'End Function

    '    Public Sub PopulatePlaceOrder(dataCustomerType As dbpointofsaleDataSet.customertypeDataTable, cbxCustomerType As Bunifu.UI.WinForms.BunifuDropdown,
    '                                  dataServiceType As dbpointofsaleDataSet.service_typeDataTable, cbxServiceType As Bunifu.UI.WinForms.BunifuDropdown,
    '                                  dataPaymentType As dbpointofsaleDataSet.payment_typeDataTable, cbxPaymentType As Bunifu.UI.WinForms.BunifuDropdown,
    '                                  dataPromo As dbpointofsaleDataSet.promoDataTable, cbxPromo As Bunifu.UI.WinForms.BunifuDropdown)

    '        cbxCustomerType.DataSource = Nothing
    '        cbxServiceType.DataSource = Nothing
    '        cbxPaymentType.DataSource = Nothing

    '        cbxCustomerType.Items.Clear()
    '        cbxServiceType.Items.Clear()
    '        cbxPaymentType.Items.Clear()

    '        Using con As MySqlConnection = Conn()

    '            stmt = "SELECT * FROM service_type"
    '            cmd = Command(stmt, con)
    '            con.Open()
    '            Dim adapter As New MySqlDataAdapter(cmd)
    '            dataServiceType.Clear()
    '            adapter.Fill(dataServiceType)
    '            cbxServiceType.DataSource = dataServiceType
    '            cbxServiceType.DisplayMember = "Name"
    '            cbxServiceType.ValueMember = "Service_Type_ID"
    '            If cbxServiceType.Items.Count > 0 Then
    '                cbxServiceType.SelectedIndex = 0
    '            Else
    '                cbxServiceType.DataSource = Nothing
    '                cbxServiceType.Items.Add("No Item")
    '                cbxServiceType.SelectedIndex = 0
    '            End If


    '        End Using

    '        Using con As MySqlConnection = Conn()

    '            stmt = "SELECT * FROM payment_type"
    '            cmd = Command(stmt, con)
    '            con.Open()
    '            Dim adapter As New MySqlDataAdapter(cmd)
    '            dataPaymentType.Clear()
    '            adapter.Fill(dataPaymentType)
    '            cbxPaymentType.DataSource = dataPaymentType
    '            cbxPaymentType.DisplayMember = "Name"
    '            cbxPaymentType.ValueMember = "Payment_Type_ID"
    '            If cbxPaymentType.Items.Count > 0 Then
    '                cbxPaymentType.SelectedIndex = 0
    '            Else
    '                cbxPaymentType.DataSource = Nothing
    '                cbxPaymentType.Items.Add("No Item")
    '                cbxPaymentType.SelectedIndex = 0
    '            End If

    '        End Using

    '        Using con As MySqlConnection = Conn()

    '            stmt = "SELECT * FROM customertype"
    '            cmd = Command(stmt, con)
    '            con.Open()
    '            Dim adapter As New MySqlDataAdapter(cmd)
    '            dataCustomerType.Clear()
    '            adapter.Fill(dataCustomerType)
    '            cbxCustomerType.DataSource = dataCustomerType
    '            cbxCustomerType.DisplayMember = "Name"
    '            cbxCustomerType.ValueMember = "Discount"
    '            If cbxCustomerType.Items.Count > 0 Then
    '                cbxCustomerType.SelectedIndex = 0
    '            Else
    '                cbxCustomerType.DataSource = Nothing
    '                cbxCustomerType.Items.Add("No Item")
    '                cbxCustomerType.SelectedIndex = 0
    '            End If


    '        End Using

    '        Using con As MySqlConnection = Conn()

    '            stmt = "SELECT * FROM promo"
    '            cmd = Command(stmt, con)
    '            con.Open()
    '            Dim adapter As New MySqlDataAdapter(cmd)
    '            dataPromo.Clear()
    '            adapter.Fill(dataPromo)
    '            cbxPromo.DataSource = dataPromo
    '            cbxPromo.DisplayMember = "Name"
    '            cbxPromo.ValueMember = "Discount"
    '            If cbxPromo.Items.Count > 0 Then
    '                cbxPromo.SelectedIndex = 0
    '            Else
    '                cbxPromo.DataSource = Nothing
    '                cbxPromo.Items.Add("No Item")
    '                cbxPromo.SelectedIndex = 0
    '            End If
    '        End Using
    '    End Sub


    '    '    Public Function PopulatefrmPlaceOrder(data As dbpointofsaleDataSet.tblcustomertypeDataTable, cmb As Guna.UI2.WinForms.Guna2ComboBox,
    '    '                                                data1 As dbpointofsaleDataSet.tblservicetypeDataTable, cmb1 As Guna.UI2.WinForms.Guna2ComboBox,
    '    '        data2 As dbpointofsaleDataSet.tblpayment_typeDataTable, cmb2 As Guna.UI2.WinForms.Guna2ComboBox)

    '    '        Dim x As Integer = 0

    '    '        Using con As MySqlConnection = Conn()

    '    '            stmt = "Select * FROM tblcustomertype"
    '    '            cmd = Command(stmt, con)
    '    '            con.Open()
    '    '            Dim adapter As New MySqlDataAdapter(cmd)
    '    '            data.Clear()
    '    '            adapter.Fill(data)
    '    '            cmb.DataSource = data
    '    '            cmb.ValueMember = "Customer_Type_Discount"
    '    '            cmb.DisplayMember = "Customer_Type_Description"
    '    '            cmb.SelectedIndex = -1

    '    '        End Using

    '    '        Using con As MySqlConnection = Conn()
    '    '            stmt = "Select * FROM tblservicetype"
    '    '            cmd = Command(stmt, con)
    '    '            con.Open()
    '    '            Dim adapter As New MySqlDataAdapter(cmd)
    '    '            data1.Clear()
    '    '            adapter.Fill(data1)
    '    '            cmb1.DataSource = data1
    '    '            cmb1.DisplayMember = "Service_Type_Description"
    '    '            cmb1.SelectedIndex = -1
    '    '        End Using

    '    '        Using con As MySqlConnection = Conn()
    '    '            stmt = "Select * FROM tblpayment_type"
    '    '            cmd = Command(stmt, con)
    '    '            con.Open()
    '    '            Dim adapter As New MySqlDataAdapter(cmd)
    '    '            data2.Clear()
    '    '            adapter.Fill(data2)
    '    '            cmb2.DataSource = data2
    '    '            cmb2.ValueMember = "Payment_Type_ID"
    '    '            cmb2.DisplayMember = "Payment_Type_Description"
    '    '            cmb2.SelectedIndex = -1

    '    '        End Using

    '    '        Return x

    '    '    End Function



    'Search Function**************************************************************************************************************************************************************************************
    Public Sub FilterUser(ByVal search As String, dgv As Bunifu.UI.WinForms.BunifuDataGridView)

        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select * FROM user WHERE CONCAT(`Full_Name`, `Username`) " _
                & "Like '%" & search & "%'"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            table.Columns.RemoveAt(5)
            table.Columns.RemoveAt(4)
            table.Columns.RemoveAt(0)

            For i = 0 To table.Columns.Count - 1
                Select Case i
                    Case 0
                        table.Columns(i).ColumnName = "Account Name"
                    Case 1
                        table.Columns(i).ColumnName = "Account Type"
                End Select
            Next
            dgv.DataSource = table
        End Using

    End Sub

    Public Sub FilterToppings(ByVal search As String, dgv As Bunifu.UI.WinForms.BunifuDataGridView)

        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "SELECT * FROM add_ons WHERE CONCAT(`Name`) " _
                & "LIKE '%" & search & "%' AND Add_Ons_ID > 1"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            table.Columns.RemoveAt(4)
            table.Columns.RemoveAt(0)

            For i = 0 To table.Columns.Count - 1
                Select Case i
                    Case 0
                        table.Columns(i).ColumnName = "Add-ons Name"
                    Case 1
                        table.Columns(i).ColumnName = "Add-ons Price"
                    Case 2
                        table.Columns(i).ColumnName = "Add-ons Status"
                End Select
            Next
            dgv.DataSource = table
        End Using

    End Sub

    Public Sub FilterOthers(ByVal search As String, ByVal dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "SELECT * FROM others WHERE CONCAT(`Name`) " _
                & "LIKE '%" & search & "%'"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            table.Columns.RemoveAt(4)
            table.Columns.RemoveAt(0)

            For i = 0 To table.Columns.Count - 1
                Select Case i
                    Case 0
                        table.Columns(i).ColumnName = "Item Name"
                    Case 1
                        table.Columns(i).ColumnName = "Item Stock"
                    Case 2
                        table.Columns(i).ColumnName = "Display Item"
                End Select
            Next
            dgv.DataSource = table
        End Using

    End Sub

    Public Sub FilterCustomer(ByVal search As String, dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select customer.Name AS Name, customertype.Name AS Type, customer.Contact_Number, customer.Address, customer.Number_of_Purchase FROM customer JOIN customertype ON customer.Customer_Type_ID=customertype.Customer_Type_ID WHERE CONCAT(customer.Name) " _
                & "LIKE '%" & search & "%'"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)

            For i = 0 To table.Columns.Count - 1
                Select Case i
                    Case 0
                        table.Columns(i).ColumnName = "Customer Name"
                    Case 1
                        table.Columns(i).ColumnName = "Customer Type"
                    Case 2
                        table.Columns(i).ColumnName = "Customer Number"
                    Case 3
                        table.Columns(i).ColumnName = "Customer Address"
                    Case 4
                        table.Columns(i).ColumnName = "Number of Purchased"
                End Select
            Next
            dgv.DataSource = table
        End Using

    End Sub

    Public Sub FilterCustomerType(search As String, dgv As Bunifu.UI.WinForms.BunifuDataGridView)

        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select Name, Discount FROM customertype WHERE CONCAT(`Name`) " _
                & "LIKE '%" & search & "%'"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            dgv.DataSource = table
        End Using

    End Sub

    Public Sub FilterMilktea(ByVal search As String, dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "SELECT * FROM milktea WHERE Name " _
                & "LIKE '%" & search & "%'"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            table.Columns.RemoveAt(4)
            table.Columns.RemoveAt(0)

            For i = 0 To table.Columns.Count - 1
                Select Case i
                    Case 0
                        table.Columns(i).ColumnName = "Product Name"
                    Case 1
                        table.Columns(i).ColumnName = "Product Price"
                    Case 2
                        table.Columns(i).ColumnName = "Product Status"
                End Select
            Next
            dgv.DataSource = table
        End Using
    End Sub

    Public Sub FilterwithPromoName(ByVal search As String, dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "SELECT * FROM promo WHERE Name " _
                & "LIKE '%" & search & "%' AND Promo_ID > 1"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            table.Columns.RemoveAt(0)

            table.Columns(3).ColumnName = "Available"
            dgv.DataSource = table
        End Using

    End Sub

    Public Sub FilterAdditionalProduct(ByVal search As String, dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "SELECT * FROM additional_products WHERE `Name` " _
                & "LIKE '%" & search & "%'"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            table.Columns.RemoveAt(4)
            table.Columns.RemoveAt(0)

            For i = 0 To table.Columns.Count - 1
                Select Case i
                    Case 0
                        table.Columns(i).ColumnName = "Product Name"
                    Case 1
                        table.Columns(i).ColumnName = "Product Price"
                    Case 2
                        table.Columns(i).ColumnName = "Product Status"
                End Select
            Next
            dgv.DataSource = table
        End Using

    End Sub

    Public Sub FilterServiceType(ByVal search As String, dgv As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim table As New DataTable
        Using con As MySqlConnection = Conn()
            stmt = "Select * FROM service_type WHERE `Name` " _
                & "LIKE '%" & search & "%'"
            cmd = Command(stmt, con)
            con.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            table.Clear()
            adapter.Fill(table)
            table.Columns.RemoveAt(0)
            dgv.DataSource = table
        End Using
    End Sub

    'check if users exists
    Public Function CheckUser()

        Dim userExist As Boolean = False

        Using con As MySqlConnection = Conn()
            stmt = "SELECT * FROM user"
            cmd = Command(stmt, con)
            con.Open()

            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                userExist = True
            Else
                userExist = False
            End If
        End Using

        Return userExist

    End Function

    '    '    Public Function CheckCustomer(ByVal customer As String)

    '    '        Dim userExist As Boolean = False

    '    '        Using con As MySqlConnection = Conn()
    '    '            stmt = "SELECT * FROM tblcustomer WHERE CONCAT(Customer_ID) = @customer"
    '    '            cmd = Command(stmt, con)
    '    '            cmd.Parameters.AddWithValue("customer", customer)
    '    '            con.Open()

    '    '            Dim dr As MySqlDataReader = cmd.ExecuteReader
    '    '            dr.Read()

    '    '            If dr.HasRows Then
    '    '                userExist = True
    '    '            Else
    '    '                userExist = False
    '    '            End If
    '    '        End Using

    '    '        Return userExist

    '    '    End Function

    '    '    'Get value from dbpointofsale*************
    '    '    Public Function NewUserID()
    '    '        Dim id As Integer = 0

    '    '        Using con As MySqlConnection = Conn()
    '    '            stmt = "SELECT MAX(User_ID) FROM tbluser"
    '    '            cmd = Command(stmt, con)

    '    '            con.Open()
    '    '            Dim userid = Convert.ToInt32(cmd.ExecuteScalar())
    '    '            id = userid + 1
    '    '        End Using

    '    '        Return id

    '    '    End Function

    '    '    Public Function NewProductID()
    '    '        Dim id As Integer = 0

    '    '        Using con As MySqlConnection = Conn()
    '    '            stmt = "SELECT MAX(Product_ID) FROM tblproduct"
    '    '            cmd = Command(stmt, con)

    '    '            con.Open()
    '    '            Dim productid = Convert.ToInt32(cmd.ExecuteScalar())
    '    '            id = productid + 1
    '    '        End Using

    '    '        Return id

    '    '    End Function

    '    '    Public Function NewToppingsID()
    '    '        Dim id As Integer = 0

    '    '        Using con As MySqlConnection = Conn()
    '    '            stmt = "SELECT MAX(Toppings_ID) FROM tbltoppings"
    '    '            cmd = Command(stmt, con)

    '    '            con.Open()
    '    '            Dim toppingsid = Convert.ToInt32(cmd.ExecuteScalar())
    '    '            id = toppingsid + 1
    '    '        End Using

    '    '        Return id

    '    '    End Function

    '    '    Public Function NewSizeID()
    '    '        Dim id As Integer = 0

    '    '        Using con As MySqlConnection = Conn()
    '    '            stmt = "SELECT MAX(Size_ID) FROM tblsize"
    '    '            cmd = Command(stmt, con)

    '    '            con.Open()
    '    '            Dim sizeid = Convert.ToInt32(cmd.ExecuteScalar())
    '    '            id = sizeid + 1
    '    '        End Using

    '    '        Return id

    '    '    End Function

    '    '    Public Function GetPaymentType(ByVal paydescription As String)
    '    '        Dim x As Integer
    '    '        Using con As MySqlConnection = Conn()
    '    '            stmt = "SELECT * FROM tblpaymenttype WHERE Payment_Type_Description = @pd"
    '    '            cmd = Command(stmt, con)
    '    '            cmd.Parameters.AddWithValue("pd", paydescription)
    '    '            con.Open()
    '    '            Dim dr As MySqlDataReader = cmd.ExecuteReader
    '    '            dr.Read()
    '    '            If dr.HasRows Then
    '    '                PaymentType = New PaymentType()
    '    '                PaymentType.ID = dr.GetValue(dr.GetOrdinal("Payment_Type_ID"))
    '    '            End If
    '    '        End Using
    '    '        Return x
    '    '    End Function

    '    '    Public Function GetCustomerType(ByVal customerType As String)
    '    '        Dim x As Integer = 0
    '    '        Using con As MySqlConnection = Conn()
    '    '            stmt = "SELECT * FROM tblcustomertype WHERE CONCAT(Customer_Type_Description) = @customerType"
    '    '            cmd = Command(stmt, con)
    '    '            cmd.Parameters.AddWithValue("customerType", customerType)
    '    '            con.Open()
    '    '            Dim dr As MySqlDataReader = cmd.ExecuteReader
    '    '            dr.Read()

    '    '            CustType = New CustomerType With {
    '    '                .ID = dr.GetValue(dr.GetOrdinal("Customer_Type_ID"))
    '    '            }
    '    '        End Using

    '    '        Return x
    '    '    End Function

    '    '    Public Function GetCustomerDetails(ByVal customerName As String)
    '    '        Dim x As Integer = 0
    '    '        Using con As MySqlConnection = Conn()
    '    '            stmt = "SELECT * FROM tblcustomer WHERE Customer_Last_Name = @customername"
    '    '            cmd = Command(stmt, con)
    '    '            cmd.Parameters.AddWithValue("customername", customerName)
    '    '            con.Open()
    '    '            Dim dr As MySqlDataReader = cmd.ExecuteReader
    '    '            dr.Read()
    '    '            If dr.HasRows Then
    '    '                ReadCustomer = New Customer With {
    '    '                .ID = dr.GetValue(dr.GetOrdinal("Customer_ID")),
    '    '                .Type = dr.GetValue(dr.GetOrdinal("Customer_Type_ID")),
    '    '                .FName = dr.GetValue(dr.GetOrdinal("Customer_First_Name")),
    '    '                .LName = dr.GetValue(dr.GetOrdinal("Customer_Last_Name")),
    '    '                .Contact = dr.GetValue(dr.GetOrdinal("Customer_Contact_Number")),
    '    '                .Address = dr.GetValue(dr.GetOrdinal("Customer_Address")),
    '    '                .NumberOfPurchase = dr.GetValue(dr.GetOrdinal("Customer_Number_of_Purchase")),
    '    '                .Archive = dr.GetValue(dr.GetOrdinal("is_archive"))
    '    '                }
    '    '            End If

    '    '        End Using

    '    '        Return x
    '    '    End Function

    '    '    Public Function CustomerValue(ByVal id As String)
    '    '        Dim value As Double = 0
    '    '        Using con As MySqlConnection = Conn()
    '    '            stmt = "SELECT * FROM tblcustomertype WHERE Customer_Type_ID = @id"
    '    '            cmd = Command(stmt, con)
    '    '            cmd.Parameters.AddWithValue("id", id)
    '    '            con.Open()
    '    '            Dim dr As MySqlDataReader = cmd.ExecuteReader
    '    '            dr.Read()
    '    '            value = dr.GetValue(dr.GetOrdinal("Customer_Type_Discount"))
    '    '        End Using

    '    '        Return value
    '    '    End Function

    Public Function GetTableColumnNumber(searchFor As String, fromTableName As String, whereColumnName As String, fetchValue As String) As Integer
        Dim x As Integer = 0

        Using con As MySqlConnection = Conn()

            stmt = "SELECT * FROM " + fromTableName + " WHERE " + whereColumnName + " = @prodName"
            cmd = Command(stmt, con)
            cmd.Parameters.AddWithValue("prodName", searchFor)
            con.Open()

            Dim dr As MySqlDataReader = cmd.ExecuteReader

            While dr.Read()
                x = dr.GetValue(dr.GetOrdinal(fetchValue))
            End While


        End Using

        Return x
    End Function

    Public Function GetTableColumnString(searchFor As String, fromTableName As String, whereColumnName As String, fetchValueFrom As String) As String
        Dim x As String = ""

        Using con As MySqlConnection = Conn()

            stmt = "SELECT * FROM " + fromTableName + " WHERE " + whereColumnName + " = @prodName"
            cmd = Command(stmt, con)
            cmd.Parameters.AddWithValue("prodName", searchFor)
            con.Open()

            Dim dr As MySqlDataReader = cmd.ExecuteReader

            While dr.Read()
                x = dr.GetValue(dr.GetOrdinal(fetchValueFrom))
            End While


        End Using

        Return x
    End Function

    'Update functions
    Public Function EditNumberOfPurchase(numberOfPurchase As Integer, id As String) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `customer` SET `Number_of_Purchase` = `Number_of_Purchase` + @nop WHERE `Customer_ID` = @id"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@nop", numberOfPurchase)
                    .Parameters.AddWithValue("@id", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function EditCustomer(type As Integer, name As String, number As String, address As String, id As Integer) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `customer` SET `Customer_Type_ID` = @p1, `Name` = @p2, `Contact_Number` = @p3, `Address` = @p4 WHERE `Customer_ID` = @p5"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", type)
                    .Parameters.AddWithValue("@p2", name)
                    .Parameters.AddWithValue("@p3", number)
                    .Parameters.AddWithValue("@p4", address)
                    .Parameters.AddWithValue("@p5", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function EditCustomerType(name As String, discount As Decimal, id As Integer) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `customertype` SET `Name` = @p1, `Discount` = @p2 WHERE `Customer_Type_ID` = @p3"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", name)
                    .Parameters.AddWithValue("@p2", discount)
                    .Parameters.AddWithValue("@p3", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function EditUser(fullname As String, type As String, username As String, password As String, id As Integer) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `user` SET `User_Type` = @p1, `Username` = @p2, `Password` = @p3, `Full_Name` = @p4 WHERE `User_ID` = @p5"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", type)
                    .Parameters.AddWithValue("@p2", username)
                    .Parameters.AddWithValue("@p3", password)
                    .Parameters.AddWithValue("@p4", fullname)
                    .Parameters.AddWithValue("@p5", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function EditPaymentMethod(name As String, id As Integer) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `payment_type` SET `Name` = @p1 WHERE `Payment_Type_ID` = @p2"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", name)
                    .Parameters.AddWithValue("@p2", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function EditAdd_Ons(name As String, price As Decimal, status As String, id As Integer) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `add_ons` SET `Name` = @p1, `Price` = @p2, `Status` = @p3, `Updated` = Default WHERE `Add_Ons_ID` = @p4"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", name)
                    .Parameters.AddWithValue("@p2", price)
                    .Parameters.AddWithValue("@p3", status)
                    .Parameters.AddWithValue("@p4", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function EditAdditional(name As String, price As Decimal, status As String, id As Integer) As Boolean

        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `additional_products` SET `Name` = @p1, `Price` = @p2, `Status` = @p3, `Updated` = Default WHERE `Additional_Products_ID` = @p4"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", name)
                    .Parameters.AddWithValue("@p2", price)
                    .Parameters.AddWithValue("@p3", status)
                    .Parameters.AddWithValue("@p4", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function EditMilktea(name As String, price As Decimal, status As String, id As Integer) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `milktea` SET `Name` = @p1, `Price` = @p2, `Status` = @p3, `Updated` = Default WHERE `Milktea_ID` = @p4"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", name)
                    .Parameters.AddWithValue("@p2", price)
                    .Parameters.AddWithValue("@p3", status)
                    .Parameters.AddWithValue("@p4", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function EditCupSize(name As String, price As Decimal, stocks As Integer, id As Integer) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `cup_size` SET `Name` = @p1, `Price` = @p2, `Stocks` = @p3, `Updated` = Default WHERE `Cup_Size_ID` = @p4"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", name)
                    .Parameters.AddWithValue("@p2", price)
                    .Parameters.AddWithValue("@p3", stocks)
                    .Parameters.AddWithValue("@p4", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function EditOthers(name As String, stock As Integer, isdisplayed As Boolean, id As Integer) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `others` SET `Name` = @p1, `Stock` = @p2, `is_displayed` = @p3, `Updated` = Default WHERE `Others_ID` = @p4"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", name)
                    .Parameters.AddWithValue("@p2", stock)
                    .Parameters.AddWithValue("@p3", isdisplayed)
                    .Parameters.AddWithValue("@p4", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Sub EditPromo(name As String, desc As String, disc As Decimal, enable As Boolean, id As String)
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `promo` SET `Name` = @p1, `Description` = @p2, `Discount` = @p3, `Enable` = @p4 WHERE `Promo_ID` = @p5"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("p1", name)
                    .Parameters.AddWithValue("p2", desc)
                    .Parameters.AddWithValue("p3", disc)
                    .Parameters.AddWithValue("p4", enable)
                    .Parameters.AddWithValue("p5", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Public Function EditServiceType(name As String, fee As Decimal, id As Integer) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `service_type` SET `Name` = @p1, `Fee` = @p2 WHERE `Service_Type_ID` = @p3"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", name)
                    .Parameters.AddWithValue("@p2", fee)
                    .Parameters.AddWithValue("@p3", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    'Restore functions

    'Delete functions
    Public Function DeletePromo(Name As String) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "DELETE FROM `promo` WHERE `Name`= @p1"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", Name)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function DeleteCustomer(CustName As String) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "DELETE FROM `customer` WHERE `Name`= @p1"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", CustName)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function DeleteCustomerType(Name As String) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "DELETE FROM `customertype` WHERE `Name`= @p1"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", Name)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function DeleteUser(isArchive As Boolean, userID As String) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "UPDATE `user` SET `is_archive` = @p1 WHERE `User_ID` = @p2"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", isArchive)
                    .Parameters.AddWithValue("@p2", userID)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function DeletePaymentMethod(Name As String) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "DELETE FROM `payment_type` WHERE `Name`= @p1"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", Name)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function DeleteAdd_Ons(Name As String) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "DELETE FROM `add_ons` WHERE `Name`= @p1"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", Name)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function DeleteAdditional(Name As String) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "DELETE FROM `additional_products` WHERE `Name`= @p1"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", Name)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function DeleteMilktea(Name As String) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "DELETE FROM `milktea` WHERE `Name`= @p1"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", Name)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function DeleteCupSize(id As String) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "DELETE FROM `cup_size` WHERE `Name`= @p1"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function DeleteOthers(id As Integer) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "DELETE FROM `others` WHERE `Others_ID`= @p1"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", id)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    Public Function DeleteServiceType(Name As String) As Boolean
        Dim result As Boolean
        Using con As MySqlConnection = Conn()
            Using cmd As New MySqlCommand()
                With cmd
                    .CommandText = "DELETE FROM `service_type` WHERE `Name`= @p1"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@p1", Name)
                End With
                con.Open()
                Try
                    cmd.ExecuteNonQuery()
                    result = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    result = False
                End Try
            End Using
        End Using
        Return result
    End Function

    'Check user row count


End Module

Public Class ProductsOrdered
    Public product As New List(Of Product)
End Class

Public Class Product

    Private _id As String
    Public Property ID() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _add_ons As String
    Public Property Add_ons() As String
        Get
            Return _add_ons
        End Get
        Set(ByVal value As String)
            _add_ons = value
        End Set
    End Property

    Private _sugarLevelID As String
    Public Property SugarLevelID() As String
        Get
            Return _sugarLevelID
        End Get
        Set(ByVal value As String)
            _sugarLevelID = value
        End Set
    End Property

    Private _sizeID As String
    Public Property SizeID() As String
        Get
            Return _sizeID
        End Get
        Set(ByVal value As String)
            _sizeID = value
        End Set
    End Property

    Private _quantity As Integer
    Public Property Quantity() As String
        Get
            Return _quantity
        End Get
        Set(ByVal value As String)
            _quantity = value
        End Set
    End Property

    Private _price As Decimal
    Public Property Price() As String
        Get
            Return _price
        End Get
        Set(ByVal value As String)
            _price = value
        End Set
    End Property
End Class

Public Class OrderedItems
    Private _item As New List(Of Item)
    Public Property Item() As List(Of Item)
        Get
            Return _item
        End Get
        Set(ByVal value As List(Of Item))
            _item = value
        End Set
    End Property
End Class

Public Class Item
    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _quantity As Integer = 0
    Public Property Quantity() As Integer
        Get
            Return _quantity
        End Get
        Set(ByVal value As Integer)
            _quantity = value
        End Set
    End Property

End Class

Public Class TopSellingProduct
    Public name As String
    Public sold As Integer
End Class
