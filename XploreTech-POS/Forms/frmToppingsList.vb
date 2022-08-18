Imports Guna.UI2.WinForms

Public Class frmToppingsList

    Private Sub frmToppingsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toppingsList As List(Of String) = GetAddonsName()
        Dim NumberOfToppings As Integer = toppingsList.Count
        Dim selectedToppings As String = frmPointOfSale.tooltip.GetToolTip(frmPointOfSale.txtToppings)
        Dim selectedToppingsArr As String()
        selectedToppingsArr = selectedToppings.Split(New Char() {","c})
        Dim selectedToppingsList As New List(Of String)
        selectedToppingsList.AddRange(selectedToppingsArr)

        shadowForm.SetShadowForm(Me)

        For i = 0 To NumberOfToppings - 1
            Dim Checkbox As New Guna2CheckBox()
            Dim CheckboxName As String
            Dim XAxis As Short
            Dim YAxis As Short
            Dim NumberOfCheckboxes As Short

            NumberOfCheckboxes = pnlToppingList.Controls.Count
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
                .Text = toppingsList(i)
                .Location = New Point(XAxis, YAxis)
            End With
            For j = 0 To selectedToppingsList.Count - 1
                If selectedToppingsList(j) = "None" Then

                ElseIf Checkbox.Text = selectedToppingsList(j) Then
                    Checkbox.CheckState = CheckState.Checked
                End If
            Next

            pnlToppingList.Controls.Add(Checkbox)
        Next

        '**********************************************************
        'For index = 1 To NumberOfToppings
        '    Dim Checkbox As New Guna2CheckBox()
        '    Dim CheckboxName As String
        '    Dim XAxis As Short
        '    Dim YAxis As Short
        '    Dim NumberOfCheckboxes As Short

        '    NumberOfCheckboxes = pnlToppingList.Controls.Count
        '    CheckboxName = "chbxToppings" & (NumberOfCheckboxes + 1)
        '    XAxis = 0

        '    If NumberOfCheckboxes = 0 Then
        '        YAxis = 0
        '    Else
        '        YAxis = 36 * (NumberOfCheckboxes)
        '    End If

        '    If NumberOfCheckboxes > 5 Then
        '        pnlScrollbarShadow.Show()
        '    Else
        '        pnlScrollbarShadow.Hide()
        '    End If

        '    'Checkbox customized properties
        '    With Checkbox
        '        .Name = CheckboxName
        '        .Animated = True
        '        .AutoSize = False
        '        .BackColor = Color.FromArgb(242, 163, 146)
        '        .CheckedState.BorderColor = DefaultColor
        '        .CheckedState.BorderRadius = 2
        '        .CheckedState.FillColor = DefaultColor
        '        .CheckMarkColor = DefaultForeColor
        '        .Font = DefaultFontStyle
        '        .ForeColor = DefaultForeColor
        '        .Size = New Size(285, 36)
        '        .UncheckedState.BorderColor = DefaultColor
        '        .UncheckedState.FillColor = DefaultColor
        '        .Text = CheckboxName
        '        .Location = New Point(XAxis, YAxis)
        '    End With

        '    pnlToppingList.Controls.Add(Checkbox)
        'Next
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim ToppingList As New List(Of String)
        Dim Topping As String
        Dim ToppingRemarks As String

        For Each Control In pnlToppingList.Controls
            If TypeOf Control Is Guna2CheckBox Then
                If Control.Checked = True Then
                    ToppingList.Add(Control.Text)
                End If
            End If
        Next

        If ToppingList.Count = 0 Then
            ToppingRemarks = "No selected toppings"
            Topping = "None"
        Else
            ToppingRemarks = ToppingList.Count & " selected toppings"
            Topping = String.Join(",", ToppingList.ToArray)
        End If

        frmPointOfSale.txtToppings.Text = ToppingRemarks
        frmPointOfSale.tooltip.SetToolTip(frmPointOfSale.txtToppings, Topping)

        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class