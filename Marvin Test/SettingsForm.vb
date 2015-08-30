Public Class SettingsForm

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

        RefreshRateSettings.Text = My.Settings.RefreshRate
        SampleTimeBox.Text = My.Settings.PIDSampleTime

    End Sub

    Private Sub Settings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'MsgBox("Default BaudRate is set to: " & My.Settings.LatestBaudRate)
        My.Forms.Form1.serialconnect()
    End Sub

    Private Sub BaudRatesBox_TextChanged(sender As Object, e As EventArgs) Handles BaudRatesBox.TextChanged
        My.Settings.LatestBaudRate = BaudRatesBox.Text
    End Sub

    Private Sub RefreshRateSettings_TextChanged(sender As Object, e As EventArgs) Handles RefreshRateSettings.TextChanged
        If Not RefreshRateSettings.Text = My.Settings.RefreshRate Then
            If IsNumeric(RefreshRateSettings.Text) Then
                My.Settings.RefreshRate = RefreshRateSettings.Text
            End If
        End If
    End Sub

    Private Sub SampleTimeBox_TextChanged(sender As Object, e As EventArgs) Handles SampleTimeBox.TextChanged
        If Not SampleTimeBox.Text = My.Settings.PIDSampleTime Then
            If IsNumeric(SampleTimeBox.Text) Then
                My.Forms.Form1.SerialPort1.WriteLine("c")
                My.Forms.Form1.SerialPort1.WriteLine("(" & RefreshRateSettings.Text & ")")
                My.Settings.PIDSampleTime = SampleTimeBox.Text
            End If
        End If
    End Sub

    Private Sub MotorCalibButton_Click(sender As Object, e As EventArgs) Handles MotorCalibButton.Click
        MessageBox.Show("To calibrate the motors make sure the wheels can spin freely. Press Ok when ready", "Motor calibration", MessageBoxButtons.OKCancel)
        If MsgBoxResult.Ok Then
            My.Forms.Form1.SerialPort1.WriteLine("c")
        End If
    End Sub
End Class