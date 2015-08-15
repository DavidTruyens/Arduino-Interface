Public Class SettingsForm
    Private Sub BaudRatesBox_TextChanged(sender As Object, e As EventArgs) Handles BaudRatesBox.TextChanged
        My.Settings.LatestBaudRate = BaudRatesBox.Text
    End Sub

    Private Sub Settings_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        BaudRatesBox.Items.Add("1200")
        BaudRatesBox.Items.Add("2400")
        BaudRatesBox.Items.Add("4800")
        BaudRatesBox.Items.Add("9600")
        BaudRatesBox.Items.Add("19200")
        BaudRatesBox.Items.Add("38400")
        BaudRatesBox.Items.Add("57600")
        BaudRatesBox.Items.Add("115200")
        BaudRatesBox.Text = My.Settings.LatestBaudRate

    End Sub

    Private Sub Settings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MsgBox("Default BaudRate is set to: " & My.Settings.LatestBaudRate)
        My.Forms.Form1.serialconnect()
    End Sub
End Class