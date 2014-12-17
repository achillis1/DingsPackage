Public Class Form1

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Call Connect()

    End Sub

    Private Sub Connect()
        Call Tws1.connect("", "7496", "0")
        If Tws1.serverVersion > 0 Then
            Dim msg As String
            msg = "Connected to TWS server version" & Tws1.serverVersion() & " at " & Tws1.TwsConnectionTime
            lblTWSConnection.Text = msg
            btnConnect.enabled = False
            btnDisconnect.enabled = true

        End If

    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        Call Tws1.disconnect()
        lblTWSConnection.Text = "Tws server disconnected"
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False


    End Sub

    Private Sub Disconnect()
        Call Tws1.disconnect()

    End Sub

End Class
