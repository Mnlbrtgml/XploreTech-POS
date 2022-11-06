Imports QRCoder
Public Class frmGenerateQRCode
    Private Sub frmGenerateQRCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctrlShadowForm.SetShadowForm(Me)

        Dim qrText As String = EncryptPassword(LoggedUser.Username) & LoggedUser.Password
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        pcbQRCode.Image = code.GetGraphic(6)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
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
                Me.Close()
            Else
                Me.Close()
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