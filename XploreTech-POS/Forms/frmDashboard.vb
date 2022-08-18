Imports Guna.UI2.WinForms

Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNumberOfTransaction.Text = IIf(LoggedUser.UserType = "Admin", GetTodayTransac(), GetTodayTransacCashier(LoggedUser.ID))
        lblNumberOfSoldToday.Text = IIf(LoggedUser.UserType = "Admin", GetTodayProductSold(), GetTodayProductSoldCashier(LoggedUser.ID))
        lblDailySales.Text = Single.Parse(IIf(LoggedUser.UserType = "Admin", GetDailySales(), GetCashierDailySales(LoggedUser.ID)))


        Dim promoName As List(Of String) = GetPromos("Name")
        Dim promoDescription As List(Of String) = GetPromos("Description")
        Dim NumberOfPromos As Short = promoName.Count - 1
        Dim PromosInList As Short
        PromosInList = 0

        ' Loop for adding new promo in promo list
        For index = 0 To NumberOfPromos
            Dim PromoPanel As New Guna2Panel()
            Dim PromoHeader As New Guna2HtmlLabel()
            Dim lblPromoDescription As New Guna2HtmlLabel()

            Dim PanelYAxis As Short

            If PromosInList = 0 Then
                PanelYAxis = 0
            Else
                If PromosInList >= 3 Then
                    scbrPromoList.Show()
                Else
                    scbrPromoList.Hide()
                End If

                PanelYAxis = (54 * (PromosInList)) + (6 * (PromosInList))
            End If

            With PromoPanel
                .Size = New Size(428, 54)
                .BackColor = Color.FromArgb(242, 163, 146)
                .Location = New Point(3, PanelYAxis)
            End With

            With PromoHeader
                .AutoSize = False
                .Font = New Font("Roboto", 15)
                .Size = New Size(422, 26)
                .Text = promoName(index)
                .Location = New Point(3, 3)
            End With

            With lblPromoDescription
                .AutoSize = False
                .Font = New Font("Roboto", 9)
                .Size = New Size(404, 16)
                .ForeColor = Color.FromArgb(64, 64, 64)
                .Text = promoDescription(index)
                .Location = New Point(24, 32)
            End With

            PromosInList += 1
            pnlPromoList.Controls.Add(PromoPanel)
            PromoPanel.Controls.Add(PromoHeader)
            PromoPanel.Controls.Add(lblPromoDescription)
        Next
    End Sub
End Class