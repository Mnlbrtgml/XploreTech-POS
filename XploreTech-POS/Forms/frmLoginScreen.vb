Imports Bunifu.UI.WinForms
Imports Guna.UI2.WinForms
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing

Public Class frmLoginScreen
    'GLOBAL VARIABLES-------------------------------------------------------------------------------------------------------------------------------
    Dim loginAttempt As Integer = 0
    Dim scanAttempt As Integer = 0
    Dim scanCounter As Integer = 0
    Dim reader As IBarcodeReader
    Dim res As Result
    Private filterInfoCollection As FilterInfoCollection
    Private WithEvents captureDevice As VideoCaptureDevice

    'Private Functions--------------------------------------------------------------------------------------------------------------------------------------
    Private Sub LoginEnable(enable As Boolean) 'Enable/Disable controls
        For Each Textbox In Me.Controls
            If TypeOf Textbox Is Guna2TextBox Then
                Textbox.Clear()
                Textbox.Enabled = enable
            End If
        Next

        If enable = True Then
            txtUsername.Focus()
            btnLogin.Text = "Login"
        Else
            btnLogin.Text = 30
        End If
        btnLogin.Enabled = enable
    End Sub

    Private Sub InitializeScanner()
        filterInfoCollection = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If filterInfoCollection.Count > 0 Then
            lblWarningNoCamera.Visible = False
            For index = 0 To filterInfoCollection.Count - 1
                captureDevice = New VideoCaptureDevice(filterInfoCollection(index).MonikerString)
                captureDevice.Start()
                tmrScanner.Enabled = True
                tmrScanner.Start()
                If pbxCamera.Image IsNot Nothing Then
                    Exit For
                End If
            Next
        Else
            lblWarningNoCamera.Visible = True
        End If
    End Sub

    'Initialize Components--------------------------------------------------------------------------------------------------------------------------------------
    Private Sub frmLoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shadow.SetShadowForm(Me)
        txtUsername.ShadowDecoration.Enabled = False
        txtPassword.ShadowDecoration.Enabled = False
        btnLogin.ShadowDecoration.Enabled = False
        btnScanQRCode.ShadowDecoration.Enabled = False
        txtUsername.ShadowDecoration.Enabled = True
        txtPassword.ShadowDecoration.Enabled = True
        btnLogin.ShadowDecoration.Enabled = True
        btnScanQRCode.ShadowDecoration.Enabled = True
        AcceptButton = btnLogin
        txtUsername.Focus()
        If RowCount(frmSplashScreen) = 0 Then
            lnkCreateNewAccount.Show()
        End If
    End Sub

    'CheckedChanged Events--------------------------------------------------------------------------------------------------------------------------------------
    Private Sub cbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword.CheckedChanged
        If cbxShowPassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    'Click Events--------------------------------------------------------------------------------------------------------------------------------------
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnScanQRCode_Click(sender As Object, e As EventArgs) Handles btnScanQRCode.Click
        pnlScanQRCode.Location = New Point(281, 59)
        lblHeader1.Hide()
        lblHeader2.Hide()
        lblUsername.Hide()
        lblPassword.Hide()
        txtUsername.Hide()
        txtPassword.Hide()
        cbxShowPassword.Hide()
        btnLogin.Hide()
        btnScanQRCode.Hide()
        pnlScanQRCode.Show()
        InitializeScanner()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        pnlScanQRCode.Location = New Point(538, 59)
        pnlScanQRCode.Hide()
        lblHeader1.Show()
        lblHeader2.Show()
        lblUsername.Show()
        lblPassword.Show()
        txtUsername.Show()
        txtPassword.Show()
        cbxShowPassword.Show()
        btnLogin.Show()
        btnScanQRCode.Show()
        txtUsername.Clear()
        txtPassword.Clear()
        cbxShowPassword.Checked = False
        txtUsername.Focus()
        tmrScanner.Enabled = False
        tmrScanner.Stop()
        captureDevice.Stop()
    End Sub

    Private Sub lnkCreateNewAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCreateNewAccount.LinkClicked
        Dim CreateNewAccount As New frmCreateNewAccountScreen()
        CreateNewAccount.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        For Each Textbox In Me.Controls
            If TypeOf Textbox Is Guna2TextBox Then
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

        If txtUsername.Tag = "Has text" AndAlso txtPassword.Tag = "Has text" Then

            Dim userAuth As New UserAuthentication()
            Dim msg As String = userAuth.AuthenticateUser(txtUsername.Text, txtPassword.Text)

            If msg = "" Then
                txtUsername.Clear()
                txtPassword.Clear()
                Dim IndexForm As New frmIndexScreen()
                IndexForm.lblAccountName.Text = LoggedUser.FullName
                IndexForm.lblAccountUsernameId.Text = LoggedUser.Username
                If LoggedUser.UserType = "Cashier" Then
                    IndexForm.btnInventorySettings.Hide()
                    IndexForm.btnOtherSettings.Location = New Point(25, 407)
                    IndexForm.btnReports.Location = New Point(25, 449)
                End If
                IndexForm.Show()
                ActLog("Login")
                Me.Close()
            Else
                If loginAttempt < 4 Then
                    loginAttempt += 1
                    displaySnackbar(Me, msg, BunifuSnackbar.MessageTypes.Error, DefaultDuration,
                                "", BunifuSnackbar.Positions.BottomCenter, BunifuSnackbar.Hosts.FormOwner, snackbar)
                    txtUsername.Clear()
                    txtPassword.Clear()
                    txtUsername.Focus()
                Else
                    LoginEnable(False)
                    tmrLoginRetry.Enabled = True
                    tmrLoginRetry.Start()
                End If
            End If
        End If
    End Sub

    'TIMER Events--------------------------------------------------------------------------------------------------------------------------------------
    Private Sub loginRetryTimer_Tick(sender As Object, e As EventArgs) Handles tmrLoginRetry.Tick
        If btnLogin.Text > 0 Then
            btnLogin.Text -= 1
        Else
            loginAttempt = 0
            LoginEnable(True)
            tmrLoginRetry.Stop()
            tmrLoginRetry.Enabled = False

        End If
    End Sub

    Private Sub ScannerTimer_Tick(sender As Object, e As EventArgs) Handles tmrScanner.Tick
        lblWarningMessage.Visible = False

        If Not pbxCamera.BackgroundImage Is Nothing Then
            reader = New BarcodeReader

            Dim bitMap As New Bitmap(pbxCamera.BackgroundImage)

            res = reader.Decode(bitMap)

            If res IsNot Nothing Then
                captureDevice.Stop()
                tmrScanner.Stop()
                Dim subst As String = DecryptPassword(res.ToString.Substring(0, 24)) + res.ToString.Substring(24)
                Dim msg As String = AuthenticateQR(subst)
                If msg = "" Then
                    txtUsername.Clear()
                    txtPassword.Clear()
                    Dim IndexForm As New frmIndexScreen()
                    IndexForm.lblAccountName.Text = LoggedUser.FullName
                    IndexForm.lblAccountUsernameId.Text = LoggedUser.Username
                    If LoggedUser.UserType = "Cashier" Then
                        IndexForm.btnInventorySettings.Hide()
                        IndexForm.btnOtherSettings.Location = New Point(25, 407)
                        IndexForm.btnReports.Location = New Point(25, 449)
                    End If
                    IndexForm.Show()
                    ActLog("Login")
                    Me.Close()
                Else
                    If scanAttempt < 4 Then
                        scanAttempt += 1
                        displaySnackbar(Me, msg, BunifuSnackbar.MessageTypes.Error, DefaultDuration,
                                    "", BunifuSnackbar.Positions.BottomCenter, BunifuSnackbar.Hosts.FormOwner, snackbar)
                        captureDevice.Start()
                        tmrScanner.Start()
                    Else
                        lblWarningMessage.Visible = True
                        scanCounter = 30
                        lblScanAttemptTimer.Text = "You can try again in " & scanCounter & " seconds"
                        lblScanAttemptTimer.Visible = True
                        tmrScannerCounter.Enabled = True
                        tmrScannerCounter.Start()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub ScannerCounter_Tick(sender As Object, e As EventArgs) Handles tmrScannerCounter.Tick
        lblScanAttemptTimer.Text = "You can try again in " & scanCounter & " seconds"
        scanCounter -= 1
        If scanCounter = 0 Then
            scanAttempt = 0
            tmrScanner.Enabled = True
            tmrScanner.Start()
            tmrScannerCounter.Stop()
            tmrScannerCounter.Enabled = False
            lblScanAttemptTimer.Visible = False
            lblWarningMessage.Visible = False
        End If
    End Sub

    Private Sub CaptureDevice_NewFrame(sender As Object, e As NewFrameEventArgs) Handles captureDevice.NewFrame
        pbxCamera.BackgroundImage = e.Frame.Clone
    End Sub
End Class