Imports Guna.UI2.WinForms
Imports QRCoder

Public Class frmCreateNewAccountScreen

    Private Sub frmCreateNewAccountScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shadow.SetShadowForm(Me)
        AcceptButton = btnNext
        page.SelectedTab = tpgInputInformation
        txtInputName.Focus()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnNext.Text = "Next" Then
            For Each Textbox In pnlInput.Controls
                If TypeOf Textbox Is Guna2TextBox Then
                    If String.IsNullOrWhiteSpace(Textbox.Text) Then
                        If String.IsNullOrWhiteSpace(txtInputPassword.Text) AndAlso String.IsNullOrWhiteSpace(txtInputRetypePassword.Text) Then
                            txtInputPassword.BorderColor = ErrorColor
                            txtInputPassword.FocusedState.BorderColor = ErrorColor
                            txtInputRetypePassword.BorderColor = ErrorColor
                            txtInputRetypePassword.FocusedState.BorderColor = ErrorColor
                            txtInputPassword.Focus()
                        End If

                        Textbox.BorderColor = ErrorColor
                        Textbox.FocusedState.BorderColor = ErrorColor
                        Textbox.Focus()
                    Else
                        If txtInputPassword.Text <> txtInputRetypePassword.Text Then
                            lblPasswordWarning.Show()
                            txtInputPassword.BorderColor = ErrorColor
                            txtInputPassword.FocusedState.BorderColor = ErrorColor
                            txtInputRetypePassword.BorderColor = ErrorColor
                            txtInputRetypePassword.FocusedState.BorderColor = ErrorColor
                            txtInputPassword.Focus()
                            txtInputPassword.Tag = "Invalid"
                            txtInputRetypePassword.Tag = "Invalid"
                        Else
                            lblPasswordWarning.Hide()
                            txtInputPassword.BorderColor = DefaultColor
                            txtInputRetypePassword.BorderColor = DefaultColor
                            txtInputPassword.Tag = "Valid"
                            txtInputRetypePassword.Tag = "Valid"
                        End If

                        Textbox.BorderColor = DefaultColor
                        Textbox.Tag = "Valid"
                    End If
                End If
            Next

            If Not ValidPassword(txtInputPassword.Text) Then
                BunifuLabel7.ForeColor = Color.Red
                txtInputPassword.BorderColor = ErrorColor
                txtInputPassword.FocusedState.BorderColor = ErrorColor
                txtInputRetypePassword.BorderColor = ErrorColor
                txtInputRetypePassword.FocusedState.BorderColor = ErrorColor
                txtInputPassword.Focus()
                txtInputPassword.Tag = "Invalid"
                txtInputRetypePassword.Tag = "Invalid"
            Else
                BunifuLabel7.ForeColor = Color.FromArgb(96, 96, 96)
            End If

            If Not ValidUser(txtInputUsername.Text) Then
                BunifuLabel6.ForeColor = Color.Red
                txtInputUsername.BorderColor = ErrorColor
                txtInputUsername.FocusedState.BorderColor = ErrorColor
                txtInputUsername.Focus()
                txtInputUsername.Tag = "Invalid"
            Else
                BunifuLabel6.ForeColor = Color.FromArgb(96, 96, 96)
            End If

            If txtInputName.Tag = "Valid" AndAlso txtInputUsername.Tag = "Valid" AndAlso txtInputPassword.Tag = "Valid" AndAlso txtInputRetypePassword.Tag = "Valid" Then
                txtNumber.Text = txtInputNumber.Text
                txtName.Text = txtInputName.Text
                txtType.Text = txtInputType.Text
                txtUsername.Text = txtInputUsername.Text
                txtPassword.Text = txtInputRetypePassword.Text

                btnNext.Text = "Done"
                page.SelectedTab = tpgReviewInformation
                btnBack.Show()
                btnBack.Location = New Point(644, 454)
                btnCancel.Location = New Point(488, 454)

                Dim qrStr As String = EncryptPassword(txtUsername.Text) & EncryptPassword(Trim(txtPassword.Text))
                Dim gen As New QRCodeGenerator
                Dim data = gen.CreateQrCode(qrStr, QRCodeGenerator.ECCLevel.Q)
                Dim code As New QRCode(data)
                picQRCode.Image = code.GetGraphic(6)
            End If

        Else
            Dim userid As Integer = IIf(GetTableColumnNumber(txtName.Text, "user", "Full_Name", "User_ID") = 0, GetTableColumnNumber(txtUsername.Text, "user", "Username", "User_ID"), GetTableColumnNumber(txtName.Text, "user", "Full_Name", "User_ID"))
            If userid = 0 Then
                InsertUser(Trim(txtName.Text), "Admin", Trim(txtUsername.Text), EncryptPassword(Trim(txtPassword.Text)))
            Else
                DeleteUser(False, userid)
                EditUser(txtName.Text, txtType.Text, txtUsername.Text, EncryptPassword(txtPassword.Text), userid)
            End If

            btnNext.Text = "Next"
            page.SelectedTab = tpgSaveInformation
            btnBack.Hide()
            btnCancel.Hide()
            btnNext.Hide()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If page.SelectedTab Is tpgInputInformation Then
            Dim message As String = "Do you want to cancel creating a new account?"
            Dim caption As String = "Create Account"
            Dim button As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim result As DialogResult = MessageBox.Show(message, caption, button)

            If result = DialogResult.Yes Then
                Me.Close()
            End If
        Else
            Dim message As String = "You are one click away from creating account." & vbNewLine & "Do you still want to cancel creating a new account?"
            Dim caption As String = "Create Account"
            Dim button As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim result As DialogResult = MessageBox.Show(message, caption, button)

            If result = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        For Each control In pnlInput.Controls
            If TypeOf control Is Guna2TextBox Then
                control.Tag = "Invalid"
            End If
        Next

        btnNext.Text = "Next"
        page.SelectedTab = tpgInputInformation
        btnBack.Location = New Point(488, 454)
        btnCancel.Location = New Point(644, 454)
        btnBack.Hide()
    End Sub

    Private Sub btnLoginNow_Click(sender As Object, e As EventArgs) Handles btnLoginNow.Click
        Dim LoginScreen As New frmLoginScreen()
        LoginScreen.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim savePic As New SaveFileDialog
        Dim Path As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Public\QRCodes\")

        If Not System.IO.Directory.Exists(Path) Then
            System.IO.Directory.CreateDirectory(Path)
        End If
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
                .FileName = txtName.Text & ".jpg"
                .ValidateNames = True
                .OverwritePrompt = True
                .InitialDirectory = Dir
                .RestoreDirectory = True

                If .ShowDialog = DialogResult.OK Then
                    If .FilterIndex = 1 Then
                        picQRCode.Image.Save(savePic.FileName, Imaging.ImageFormat.Jpeg)
                    ElseIf .FilterIndex = 2 Then
                        picQRCode.Image.Save(savePic.FileName, Imaging.ImageFormat.Png)
                    ElseIf .FilterIndex = 3 Then
                        picQRCode.Image.Save(savePic.FileName, Imaging.ImageFormat.Bmp)
                    End If
                Else
                    Return
                End If
            End With

            Dim r As DialogResult
            Dim msg As String = "Image saved successfully."

            r = MessageBox.Show(msg, title, MessageBoxButtons.OK, ico)

        Catch ex As Exception

            MessageBox.Show("Error Saving Image: " & ex.Message.ToString)
            Me.Close()
        Finally
            savePic.Dispose()
        End Try
    End Sub
End Class