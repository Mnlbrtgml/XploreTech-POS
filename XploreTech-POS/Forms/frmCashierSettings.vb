Imports Bunifu.UI.WinForms
Imports Guna.UI2.WinForms

Public Class frmCashierSettings
    Private Sub frmCashierSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        editAccountInformation(False)
    End Sub

    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs) Handles btnEditAccount.Click
        editAccountInformation(True)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        editAccountInformation(False)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        For Each Textbox In pnlAccountInformation.Controls
            If TypeOf Textbox Is Guna2TextBox Then
                If String.IsNullOrWhiteSpace(Textbox.Text) Then
                    If String.IsNullOrWhiteSpace(txtPassword.Text) AndAlso String.IsNullOrWhiteSpace(txtRetypePassword.Text) Then
                        txtPassword.BorderColor = ErrorColor
                        txtPassword.FocusedState.BorderColor = ErrorColor
                        txtRetypePassword.BorderColor = ErrorColor
                        txtRetypePassword.FocusedState.BorderColor = ErrorColor
                        txtPassword.Focus()
                    End If

                    Textbox.BorderColor = ErrorColor
                    Textbox.FocusedState.BorderColor = ErrorColor
                    Textbox.Focus()
                    Textbox.Tag = "Has no text"
                Else
                    If txtPassword.Text <> txtRetypePassword.Text Then
                        txtPassword.BorderColor = ErrorColor
                        txtPassword.FocusedState.BorderColor = ErrorColor
                        txtRetypePassword.BorderColor = ErrorColor
                        txtRetypePassword.FocusedState.BorderColor = ErrorColor
                        txtRetypePassword.Focus()
                        txtRetypePassword.Tag = "Has no text"
                        txtRetypePassword.Tag = "Has no text"
                    Else
                        txtPassword.BorderColor = DefaultColor
                        txtRetypePassword.BorderColor = DefaultColor
                        txtPassword.Tag = "Has text"
                        txtRetypePassword.Tag = "Has text"
                    End If

                    Textbox.BorderColor = DefaultColor
                    Textbox.Tag = "Has text"
                End If
            End If
        Next

        If txtName.Tag = "Has text" AndAlso txtUsername.Tag = "Has text" AndAlso txtPassword.Tag = "Has text" AndAlso txtRetypePassword.Tag = "Has text" Then
            editAccountInformation(False)
        End If
    End Sub

    Private Sub editAccountInformation(bool As Boolean)
        If bool = True Then
            btnEditAccount.Hide()
            pnlQRInformation.Hide()
            lblNumber.Hide()
            lblType.Hide()
            txtNumber.Hide()
            txtType.Hide()
            pnlQRInformation.Size = New Size(420, 336)
            pnlAccountInformation.Location = New Point(254, 130)
            lblName.Location = New Point(10, 10)
            lblUsername.Location = New Point(10, 75)
            lblPassword.Location = New Point(10, 140)
            lblRetypePassword.Location = New Point(10, 205)
            txtName.Location = New Point(10, 34)
            txtUsername.Location = New Point(10, 99)
            txtPassword.Location = New Point(10, 164)
            txtRetypePassword.Location = New Point(10, 229)
            btnCancel.Location = New Point(57, 280)
            btnSave.Location = New Point(213, 280)
            lblRetypePassword.Show()
            txtRetypePassword.Show()
            btnCancel.Show()
            btnSave.Show()
            pnlAccountInformation.Enabled = True
            txtName.Focus()
        Else
            btnEditAccount.Show()
            pnlQRInformation.Show()
            lblNumber.Show()
            lblType.Show()
            txtNumber.Show()
            txtType.Show()
            pnlQRInformation.Size = New Size(420, 466)
            pnlAccountInformation.Location = New Point(113, 128)
            lblName.Location = New Point(10, 75)
            lblUsername.Location = New Point(10, 205)
            lblPassword.Location = New Point(10, 270)
            lblRetypePassword.Location = New Point(10, 335)
            txtName.Location = New Point(10, 99)
            txtUsername.Location = New Point(10, 229)
            txtPassword.Location = New Point(10, 294)
            txtRetypePassword.Location = New Point(10, 359)
            btnCancel.Location = New Point(57, 420)
            btnSave.Location = New Point(213, 420)
            lblRetypePassword.Hide()
            txtRetypePassword.Hide()
            btnCancel.Hide()
            btnSave.Hide()
            pnlAccountInformation.Enabled = False
        End If
    End Sub
End Class