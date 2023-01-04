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
        renderPieChart()
    End Sub

    Private Sub renderPieChart()

        ' 
        '  For this example we will use random numbers
        ' 
        Dim r = New Random()

        ' 
        '  Add your data from your source - accepts double list
        '  Below is an example from a random number
        ' 
        Dim data As List(Of Double) = New List(Of Double)()
        Dim canvasLabel As List(Of String) = New List(Of String)()
        Dim products As List(Of Item) = GetTopSelling()
        For i As Integer = 0 To IIf(products.Count > 5, 4, products.Count - 1)
            data.Add(products(i).Quantity)
            canvasLabel.Add(products(i).Name)
        Next

        ' 
        '  Set your data             
        ' 
        bunifuPieChart.Data = data

        ' 
        '  Specify the target canvas
        ' 
        bunifuPieChart.TargetCanvas = ctrlChartCanvas

        ' 
        '  Hide grid lines
        ' 
        ctrlChartCanvas.XAxesGridLines = False
        ctrlChartCanvas.YAxesGridLines = False

        ' 
        '  Add labels to your canvas
        '  Label count should correspond to data count for charts like Bar charts
        ' 
        ctrlChartCanvas.Labels = canvasLabel.ToArray
        For i As Integer = 0 To IIf(products.Count > 5, 4, products.Count - 1)
            Dim textbox = CType(Me.Guna2Panel2.Controls("legend" & i), Bunifu.UI.WinForms.BunifuLabel)
            textbox.Text = ctrlChartCanvas.Labels(i)
        Next
    End Sub

End Class