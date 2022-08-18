Public Class frmSplashScreen

    Private TargetDT As Date
    Private CountDownFrom As TimeSpan = TimeSpan.FromSeconds(5)

    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shadow.SetShadowForm(Me)
        TargetDT = Date.Now.Add(CountDownFrom)
        timer.Start()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(Date.Now)

        If ts.TotalMilliseconds < 0 Then
            timer.Stop()

            Try
                If RowCount(Me) = 0 Then
                    Dim CreateAccountForm As New frmCreateNewAccountScreen()
                    CreateAccountForm.Show()
                    Me.Close()
                Else
                    Dim LoginForm As New frmLoginScreen()
                    LoginForm.Show()
                    Me.Close()
                End If
            Catch ex As Exception
                Me.Hide()

                Dim mbxMessage As String = "An error occured in database connection." + vbNewLine + vbNewLine +
                    "Potential fix:" + vbNewLine +
                    "   Check if MySQL connection is open." + vbNewLine +
                    "   Check if you are  using a correct connection string."
                Dim mbxCaption As String = "Database Connection"
                Dim mbxButton As MessageBoxButtons = MessageBoxButtons.OK
                Dim mbxResult As DialogResult = MessageBox.Show(mbxMessage, mbxCaption, mbxButton)

                If mbxResult = DialogResult.OK Then
                    Application.Exit()
                End If
            End Try
        End If
    End Sub
End Class
