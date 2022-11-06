Imports Bunifu.UI.WinForms

Public Class frmIndexScreen

    Private currentChildForm As Form

    Private Sub displayForm(childForm As Form)
        If currentChildForm Is childForm Then
            Exit Sub
        End If

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlChildForm.Controls.Add(childForm)
        pnlChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub frmIndexScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shadow.SetShadowForm(Me)
        displayForm(frmDashboard)

        displaySnackbar(Me, "Login successfully!", BunifuSnackbar.MessageTypes.Success, DefaultDuration, "",
                        BunifuSnackbar.Positions.BottomCenter, BunifuSnackbar.Hosts.FormOwner, snackbar)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        displayForm(frmDashboard)
    End Sub

    Private Sub btnPointOfSale_Click(sender As Object, e As EventArgs) Handles btnPointOfSale.Click
        displayForm(frmPointOfSale)
    End Sub

    Private Sub btnInventorySettings_Click(sender As Object, e As EventArgs) Handles btnInventorySettings.Click
        displayForm(frmInventorySettings)
    End Sub

    Private Sub btnOtherSettings_Click(sender As Object, e As EventArgs) Handles btnOtherSettings.Click
        displayForm(IIf(LoggedUser.UserType = "Admin", frmOtherSettings, frmCashierSettings))
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        displayForm(frmReports)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim mbxMessage As String = "Do you really want to log out your account?"
        Dim mbxCaption As String = "Log out Account"
        Dim mbxButton As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim mbxResult As DialogResult = MessageBox.Show(mbxMessage, mbxCaption, mbxButton)

        If mbxResult = DialogResult.Yes Then

            InsertActivityLog(LoggedUser.ID, LoggedUser.FullName, "Logout")
            Dim newFrmLoginScreen As New frmLoginScreen
            newFrmLoginScreen.Show()
            Me.Close()
        End If
    End Sub
End Class