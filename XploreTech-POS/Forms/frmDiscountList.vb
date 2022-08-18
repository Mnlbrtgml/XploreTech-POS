Imports Guna.UI2.WinForms

Public Class frmDiscountList
    Private Sub frmDiscountList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim promosList As List(Of String) = GetPromos("Name")
        Dim numberOfPromos As Integer = promosList.Count
        Dim selectedPromos As String = ""
        For Each form In Application.OpenForms.OfType(Of frmPlaceOrder)
            selectedPromos = form.tooltip.GetToolTip(form.txtStoreDiscount)
        Next

        Dim selectedPromosArr As String() = selectedPromos.Split(New Char() {","c})
        Dim selectedPromosList As New List(Of String)
        selectedPromosList.AddRange(selectedPromosArr)

        For i = 0 To numberOfPromos - 1
            Dim Checkbox As New Guna2CheckBox()
            Dim CheckboxName As String
            Dim XAxis As Short
            Dim YAxis As Short
            Dim NumberOfCheckboxes As Short

            NumberOfCheckboxes = pnlDiscountList.Controls.Count
            CheckboxName = "chbxToppings" & (NumberOfCheckboxes + 1)
            XAxis = 0

            If NumberOfCheckboxes = 0 Then
                YAxis = 0
            Else
                YAxis = 36 * (NumberOfCheckboxes)
            End If

            If NumberOfCheckboxes > 5 Then
                pnlScrollbarShadow.Show()
            Else
                pnlScrollbarShadow.Hide()
            End If

            'Checkbox customized properties
            With Checkbox
                .Name = CheckboxName
                .Animated = True
                .AutoSize = False
                .BackColor = Color.FromArgb(242, 163, 146)
                .CheckedState.BorderColor = DefaultColor
                .CheckedState.BorderRadius = 2
                .CheckedState.FillColor = DefaultColor
                .CheckMarkColor = DefaultForeColor
                .Font = DefaultFontStyle
                .ForeColor = DefaultForeColor
                .Size = New Size(285, 36)
                .UncheckedState.BorderColor = DefaultColor
                .UncheckedState.FillColor = DefaultColor
                .Text = promosList(i)
                .Location = New Point(XAxis, YAxis)
            End With
            For j = 0 To selectedPromosList.Count - 1
                If selectedPromosList(j) = "None" Then

                ElseIf Checkbox.Text = selectedPromosList(j) Then
                    Checkbox.CheckState = CheckState.Checked
                End If
            Next

            pnlDiscountList.Controls.Add(Checkbox)
        Next
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim promoList As New List(Of String)
        Dim promo As String
        Dim promoRemarks As String

        For Each Control In pnlDiscountList.Controls
            If TypeOf Control Is Guna2CheckBox Then
                If Control.Checked = True Then
                    promoList.Add(Control.Text)
                End If
            End If
        Next

        If promoList.Count = 0 Then
            promoRemarks = "No promo applied"
            promo = "None"
        Else
            promoRemarks = promoList.Count & IIf(promoList.Count > 1, " promos applied", " promo applied")
            promo = String.Join(",", promoList.ToArray)
        End If
        For Each form In Application.OpenForms.OfType(Of frmPlaceOrder)
            form.txtStoreDiscount.Text = promoRemarks
            form.tooltip.SetToolTip(form.txtStoreDiscount, promo)
            form.GetTotal()
        Next
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class