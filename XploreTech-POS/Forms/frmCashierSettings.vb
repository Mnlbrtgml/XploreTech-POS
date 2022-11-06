Imports Bunifu.UI.WinForms
Imports Guna.UI2.WinForms
Imports QRCoder

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
            If TypeOf (Textbox) Is Guna2TextBox Then
                If String.IsNullOrWhiteSpace(Textbox.Text) Then
                    Textbox.BorderColor = ErrorColor
                    Textbox.FocusedState.BorderColor = ErrorColor
                    Textbox.Focus()
                    Textbox.Tag = "Has no text"
                Else
                    Textbox.BorderColor = DefaultColor
                    Textbox.Tag = "Has text"
                End If
            End If
        Next

        For Each Textbox In pnlAccountInformation.Controls
            If TypeOf (Textbox) Is Guna2TextBox Then
                If Textbox.Tag = "Has no text" Then
                    displaySnackbar(Me, "Complete all the fields!", BunifuSnackbar.MessageTypes.Error, 3000,
                                "", BunifuSnackbar.Positions.BottomRight, BunifuSnackbar.Hosts.FormOwner, snackbar)
                    Exit Sub
                End If
            End If
        Next

        If Not ValidUser(txtUsername.Text) Then
            txtUsername.BorderColor = ErrorColor
            txtUsername.FocusedState.BorderColor = ErrorColor
            txtUsername.Focus()
            txtUsername.Tag = "Has no text"
            displaySnackbar(Me, "Username must be atleast 8 character!", BunifuSnackbar.MessageTypes.Error, 3000,
                                "", BunifuSnackbar.Positions.BottomRight, BunifuSnackbar.Hosts.FormOwner, snackbar)
            Exit Sub
        End If

        If txtPassword.Text <> txtRetypePassword.Text Then
            txtPassword.BorderColor = ErrorColor
            txtPassword.FocusedState.BorderColor = ErrorColor
            txtRetypePassword.BorderColor = ErrorColor
            txtRetypePassword.FocusedState.BorderColor = ErrorColor
            txtRetypePassword.Focus()
            txtRetypePassword.Tag = "Has no text"
            txtRetypePassword.Tag = "Has no text"
            displaySnackbar(Me, "Password did not match!", BunifuSnackbar.MessageTypes.Error, 3000,
                                "", BunifuSnackbar.Positions.BottomRight, BunifuSnackbar.Hosts.FormOwner, snackbar)
            Exit Sub
        Else
            txtPassword.BorderColor = DefaultColor
            txtRetypePassword.BorderColor = DefaultColor
            txtPassword.Tag = "Has text"
            txtRetypePassword.Tag = "Has text"
        End If

        If Not ValidPassword(txtPassword.Text) Then
            txtPassword.BorderColor = ErrorColor
            txtPassword.FocusedState.BorderColor = ErrorColor
            txtRetypePassword.BorderColor = ErrorColor
            txtRetypePassword.FocusedState.BorderColor = ErrorColor
            txtRetypePassword.Focus()
            txtRetypePassword.Tag = "Has no text"
            txtRetypePassword.Tag = "Has no text"
            displaySnackbar(Me, "Password is weak!", BunifuSnackbar.MessageTypes.Error, 3000,
                                "", BunifuSnackbar.Positions.BottomRight, BunifuSnackbar.Hosts.FormOwner, snackbar)
            Exit Sub
        End If

        If EditUser(txtName.Text, txtType.Text, txtUsername.Text, EncryptPassword(txtPassword.Text), txtNumber.Text) Then
            editAccountInformation(False)
            LoggedUser.FullName = txtName.Text
            LoggedUser.UserType = txtType.Text
            LoggedUser.Username = txtUsername.Text
            LoggedUser.Password = txtPassword.Text
            displaySnackbar(Me, "Account Updated Successfully", BunifuSnackbar.MessageTypes.Success, DefaultDuration,
                                "", BunifuSnackbar.Positions.BottomRight, BunifuSnackbar.Hosts.FormOwner, snackbar)
        Else
            displaySnackbar(Me, "There's an error updating your account! Contact administrator", BunifuSnackbar.MessageTypes.Error, 3000,
                                "", BunifuSnackbar.Positions.BottomRight, BunifuSnackbar.Hosts.FormOwner, snackbar)
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
            txtPassword.Clear()
        Else
            Dim qrText As String = EncryptPassword(LoggedUser.Username) & LoggedUser.Password
            Dim gen As New QRCodeGenerator
            Dim data = gen.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCode(data)
            pcbQRCode.Image = code.GetGraphic(6)
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
            txtName.Text = LoggedUser.FullName
            txtNumber.Text = LoggedUser.ID
            txtPassword.Text = LoggedUser.Password
            txtUsername.Text = LoggedUser.Username
            txtType.Text = LoggedUser.UserType
            txtRetypePassword.Clear()
        End If
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim savePic As New SaveFileDialog
        Dim Path As String = "D:\QRCodes\"
        Dim Dir As String = System.IO.Path.GetDirectoryName(Path)

        Dim title As String = "Xplore-Tech QRCode"
        Dim btn = MessageBoxButtons.YesNo
        Dim ico = MessageBoxIcon.Information

        Try
            If Not System.IO.Directory.Exists(Dir) Then
                System.IO.Directory.CreateDirectory(Dir)
            End If

            With savePic
                .Title = "Save Image As"
                .Filter = "Jpg, Jpeg Images|*.jpg;*.jpeg|PNG Image|*.png|BMP Image|*.bmp"
                .AddExtension = True
                .FileName = "XploreTech-POS.jpg"
                .ValidateNames = True
                .OverwritePrompt = True
                .InitialDirectory = Dir
                .RestoreDirectory = True

                If .ShowDialog = DialogResult.OK Then
                    If .FilterIndex = 1 Then
                        pcbQRCode.Image.Save(savePic.FileName, Imaging.ImageFormat.Jpeg)
                    ElseIf .FilterIndex = 2 Then
                        pcbQRCode.Image.Save(savePic.FileName, Imaging.ImageFormat.Png)
                    ElseIf .FilterIndex = 3 Then
                        pcbQRCode.Image.Save(savePic.FileName, Imaging.ImageFormat.Bmp)
                    End If
                Else
                    Return
                End If
            End With

            Dim r As DialogResult
            ActLog("Download QRCode Image")
            Dim msg As String = "Image saved successfully." & vbNewLine
            msg &= "Open it now?"

            r = MessageBox.Show(msg, title, btn, ico)

            If r = System.Windows.Forms.DialogResult.Yes Then
                Dim startinfo As New ProcessStartInfo("mspaint.exe")
                startinfo.WindowStyle = ProcessWindowStyle.Maximized
                startinfo.Arguments = Chr(34) & Dir & Chr(34) & "\" & System.IO.Path.GetFileName(savePic.FileName).ToString
                Process.Start(startinfo)
            Else
                Return
            End If

        Catch ex As Exception

            MessageBox.Show("Error Saving Image: " & ex.Message.ToString)
            Me.Close()
        Finally
            savePic.Dispose()
        End Try
    End Sub

End Class