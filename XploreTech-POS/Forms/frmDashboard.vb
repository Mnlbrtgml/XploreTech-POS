Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNumberOfTransaction.Text = IIf(LoggedUser.UserType = "Admin", GetTodayTransac(), GetTodayTransacCashier(LoggedUser.ID))
        lblNumberOfSoldToday.Text = IIf(LoggedUser.UserType = "Admin", GetTodayProductSold(), GetTodayProductSoldCashier(LoggedUser.ID))
        lblDailySales.Text = Single.Parse(IIf(LoggedUser.UserType = "Admin", GetDailySales(), GetCashierDailySales(LoggedUser.ID)))
    End Sub
End Class