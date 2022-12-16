Imports Bunifu.UI.WinForms
Imports Guna.UI2.WinForms

Module ModifyControls

    Public Sub ShowModifyItem(frmTag As String, cmbx As Guna2ComboBox)
        Dim ModifyForm As New frmModifyItem()
        ModifyForm.Tag = frmTag

        If cmbx.SelectedItem = "User Account Settings" Then
            ModifyForm.pnlEditing.Tag = "User account"
            ModifyForm.ShowDialog()
        ElseIf cmbx.SelectedItem = "Customer Settings" Then
            ModifyForm.pnlEditing.Tag = "Customer list"
            ModifyForm.ShowDialog()
        ElseIf cmbx.SelectedItem = "Customer Type Settings" Then
            ModifyForm.pnlEditing.Tag = "Customer type"
            ModifyForm.ShowDialog()
        ElseIf cmbx.SelectedItem = "Promo Settings" Then
            ModifyForm.pnlEditing.Tag = "Promo"
            ModifyForm.ShowDialog()
        ElseIf cmbx.SelectedItem = "Service Type Settings" Then
            ModifyForm.pnlEditing.Tag = "Service type"
            ModifyForm.ShowDialog()
        ElseIf cmbx.SelectedItem = "Milktea Products Settings" Or cmbx.SelectedItem = "Additional Products Settings" Or cmbx.SelectedItem = "Toppings Settings" Then
            ModifyForm.pnlEditing.Tag = "Product"
            ModifyForm.ShowDialog()
        End If

    End Sub

    Public Sub LoadActionButton(dgvTable As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim delete As DataGridViewColumn = New DataGridViewButtonColumn With {
            .DataPropertyName = "clmnBtnDelete",
            .HeaderText = "Delete",
            .Name = "clmnDel",
            .UseColumnTextForButtonValue = True,
            .Width = 50,
            .Text = "Delete"
            }
        Dim edit As DataGridViewColumn = New DataGridViewButtonColumn With {
            .DataPropertyName = "clmnBtnEdit",
            .HeaderText = "Edit",
            .Name = "clmnEdit",
            .UseColumnTextForButtonValue = True,
            .Width = 50,
            .Text = "Edit"
        }
        dgvTable.Columns.Add(edit)
        dgvTable.Columns.Add(delete)
    End Sub

    Public Sub LoadEditButton(dgvTable As Bunifu.UI.WinForms.BunifuDataGridView)
        Dim edit As DataGridViewColumn = New DataGridViewButtonColumn With {
            .DataPropertyName = "clmnBtnEdit",
            .HeaderText = "Edit",
            .Name = "clmnEdit",
            .UseColumnTextForButtonValue = True,
            .Width = 50,
            .Text = "Edit"
        }
        dgvTable.Columns.Add(edit)
    End Sub

    Public DefaultDuration As Short = 1300
    Public DefaultFontStyle As New Font("Roboto", 9)
    Public DefaultForeColor As Color = Color.FromArgb(17, 17, 17)
    Public DefaultColor As Color = Color.FromArgb(236, 117, 92)
    Public WarningColor As Color = Color.FromArgb(250, 173, 20)
    Public InformationColor As Color = Color.FromArgb(33, 150, 243)
    Public SuccessColor As Color = Color.FromArgb(82, 196, 26)
    Public ErrorColor As Color = Color.FromArgb(254, 77, 79)

    Public Sub displaySnackbar(Target As Form, Message As String, Type As BunifuSnackbar.MessageTypes,
                        Duration As Short, Action As String, Position As BunifuSnackbar.Positions,
                        Host As BunifuSnackbar.Hosts, Control As BunifuSnackbar)

        Dim SnackbarTarget = Target
        Dim SnackbarMessage = Message
        Dim SnackbarType = Type
        Dim SnackbarDuration = Duration
        Dim SnackbarAction = Action
        Dim SnackbarPosition = Position
        Dim SnackbarHost = Host

        Control.Show(SnackbarTarget, SnackbarMessage, SnackbarType, SnackbarDuration, SnackbarAction,
                     SnackbarPosition, SnackbarHost)
    End Sub

End Module
