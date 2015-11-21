Imports System
Imports System.Management
Imports System.IO.Ports
Imports System.Threading
Imports System.Windows.Forms.Form
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1

    Dim started As Boolean = False
    Dim joystick As Boolean = False
    Dim printvalues As Boolean = False
    Dim connected As Boolean
    Dim plotindex As Integer
    Dim plotscale As Integer = 20

    Delegate Sub StringInput(ByVal StringOut As String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Dim BoxPos As Point
        BoxPos.X = 372
        BoxPos.Y = 75
        My.Settings.ImagePOS = BoxPos
        PictureBox1.BackColor = Color.Transparent

        My.Settings.BoxLayout = BoxPos
        IncrementBox.Text = 0.1
        NeutralAngleBox.Text = 0

        SerialPortList.DropDownWidth = 300

        'SearchComPorts()

        'Dim arduino As Boolean = False

        'For Each item As Object In SerialPortList.Items

        '    If item.ToString.Contains("Arduino") Then
        '        SerialPortList.Text = item.ToString
        '        arduino = True
        '        Exit For
        '    ElseIf item.ToString.Contains("Blu") Then
        '        SerialPortList.Text = item.ToString
        '        arduino = True
        '        Exit For
        '    End If
        'Next

        'If Not arduino Then
        '    MsgBox("No Arduino can be found..")
        '    'SerialPortList.Text = SerialPortList.Items.Item(0).ToString
        '    Me.BackColor = Color.Orange

        'End If

        CheckBoxAngle.Checked = True

        Chart1.Series.Item(0).Name = "Angle"
        Chart1.Series.Item("Angle").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series.Add("JoyX")
        Chart1.Series.Item("JoyX").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series.Item("JoyX").Enabled = False
        Chart1.Series.Add("JoyY")
        Chart1.Series.Item("JoyY").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series.Item("JoyY").Enabled = False

    End Sub

    Private Sub SearchComPorts()
        SerialPortList.Items.Clear()
        Try
            Dim searcher As New ManagementObjectSearcher("root\cimv2", "SELECT * FROM Win32_SerialPort")

            For Each SerialPort As ManagementObject In searcher.Get()
                SerialPortList.Items.Add(SerialPort("name"))
            Next

        Catch err As ManagementException
            MessageBox.Show("An error occured while querying for WMI data: " & err.Message)

        End Try
    End Sub

    Private Sub JoyStickButton_Click(sender As Object, e As EventArgs) Handles JoyStickButton.Click
        SerialPort1.Write("y")

        If joystick Then
            Me.JoyStickButton.Text = "Disable Joystick"
            Me.JoyStickButton.BackColor = Color.Red
            joystick = False
        Else
            Me.JoyStickButton.Text = "Enable Joystick"
            Me.JoyStickButton.BackColor = Color.Green
            joystick = True
        End If
    End Sub

    Public Sub serialconnect()
        Dim portname As String
        portname = "COM" & GetPortNumber()

        If Not SerialPort1.IsOpen Then
            Try
                SerialPort1.PortName = portname
                SerialPort1.BaudRate = 115200   'My.Settings.LatestBaudRate
                SerialPort1.Open()
                Me.BackColor = Color.Green

            Catch ex As Exception
                MsgBox("Arduino detected, but no connection could be made")
                Me.BackColor = Color.Red
            End Try
        End If

        If IsNumeric(My.Forms.SettingsForm.RefreshRateSettings.Text) Then
            Timer1.Interval = CInt(My.Forms.SettingsForm.RefreshRateSettings.Text)
        Else
            Timer1.Interval = 100
        End If
        Timer1.Start()

        Try
            SerialPort1.WriteLine("a")
        Catch ex As Exception
            MsgBox("Arduino detected, but no connection could be made")
            Me.BackColor = Color.Red
        End Try

    End Sub

    Private Sub serialclose()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            Timer1.Stop()
            Me.BackColor = Color.Orange
        End If
    End Sub

    Private Function GetPortNumber() As String
        Dim com As String = "COM"
        Dim x As Integer = InStr(SerialPortList.Text, com)
        Dim string_after As String = SerialPortList.Text.Substring(x + com.Length - 1)

        Dim closingbracket As String = ")"
        Dim y As Integer = InStr(string_after, closingbracket)
        Dim portnumber As String = string_after.Substring(0, y - 1)

        Return portnumber
    End Function

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim StringOut As String
        StringOut = SerialPort1.ReadLine

        Invoke(New StringInput(AddressOf CMDCom), StringOut)
    End Sub

    Public Sub CMDCom(ByVal StringOut As String)

        Dim values As Array
        CMDLine.Text = StringOut
        If StringOut.Contains(";") Then
            plotindex = plotindex + 1
            values = Split(StringOut, ";")
            Me.Chart1.Series.Item("Angle").Points.AddXY(plotindex, values(2))
            Me.Chart1.Series.Item("JoyX").Points.AddXY(plotindex, values(0))
            Me.Chart1.Series.Item("JoyY").Points.AddXY(plotindex, values(1))
            JoyStickTarget(values(0), values(1))
        ElseIf StringOut.Contains("P") Then
            StringOut = StringOut.Replace("P", "")
            If IsNumeric(StringOut) Then
                PBox.Text = StringOut
            End If
        ElseIf StringOut.Contains("I") Then
            StringOut = StringOut.Replace("I", "")
            If IsNumeric(StringOut) Then
                IBox.Text = StringOut
            End If
        ElseIf StringOut.Contains("D") Then
            StringOut = StringOut.Replace("D", "")
            If IsNumeric(StringOut) Then
                DBox.Text = StringOut
            End If
        ElseIf StringOut.Contains("C") Then
            StringOut = StringOut.Replace("C", "")
            If IsNumeric(StringOut) Then
                My.Settings.PIDSampleTime = StringOut
            End If
        ElseIf StringOut.Contains("T") Then
            StringOut = StringOut.Replace("T", "")
            If IsNumeric(StringOut) Then
                PosPropBox.Text = StringOut
            End If
        ElseIf StringOut.Contains("U") Then
            StringOut = StringOut.Replace("U", "")
            If IsNumeric(StringOut) Then
                PosDifBox.Text = StringOut
            End If
        ElseIf StringOut.Contains("K") Then
            StringOut = StringOut.Replace("K", "")
            If IsNumeric(StringOut) Then
                KalmanBox.Text = StringOut
            End If
        ElseIf StringOut.Contains("J") Then
            StringOut = StringOut.Replace("J", "")
            If IsNumeric(StringOut) Then
                MaxTargetAngleBox.Text = StringOut
            End If
        ElseIf StringOut.Contains("L") Then
            StringOut = StringOut.Replace("L", "")
            If IsNumeric(StringOut) Then
                AggPropBox.Text = StringOut
            End If
        ElseIf StringOut.Contains("O") Then
            StringOut = StringOut.Replace("O", "")
            If IsNumeric(StringOut) Then
                AggDifBox.Text = StringOut
            End If
        ElseIf StringOut.Contains("R") Then
            StringOut = StringOut.Replace("R", "")
            If IsNumeric(StringOut) Then
                FuzzyTransBox.Text = StringOut
            End If
        ElseIf StringOut.Contains("W") Then
            StringOut = StringOut.Replace("W", "")
            If IsNumeric(StringOut) Then
                FuzzyStartBox.Text = StringOut
            End If
        End If

        If plotindex > plotscale Then
            Chart1.ChartAreas.Item(0).AxisX.IsStartedFromZero = False
            Chart1.ChartAreas.Item(0).AxisX.Minimum = plotindex - plotscale
        End If

    End Sub

    Sub JoyStickTarget(X As Double, Y As Double)
        Dim pos As Point
        Dim Xpos As Integer
        Dim Ypos As Integer
        Xpos = CInt(X)
        Ypos = CInt(Y)
        pos.X = Xpos + 322
        pos.Y = Ypos + 25
        My.Settings.ImagePOS = pos
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If printvalues Then
            MsgBox("Stop plotting before closing the application")
            e.Cancel = True
        Else
            If SerialPort1.IsOpen Then
                serialclose()
            End If

            SaveToFile()
        End If

    End Sub

    Private Sub CheckBoxAngle_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAngle.CheckedChanged
        If CheckBoxAngle.Checked Then
            Chart1.Series.Item(0).Enabled = True
        Else
            Chart1.Series.Item(0).Enabled = False
        End If
    End Sub

    Private Sub CheckBoxJoyX_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxJoyX.CheckedChanged
        If CheckBoxJoyX.Checked Then
            Chart1.Series.Item(1).Enabled = True
        Else
            Chart1.Series.Item(1).Enabled = False
        End If
    End Sub

    Private Sub CheckBoxJoyY_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxJoyY.CheckedChanged
        If CheckBoxJoyY.Checked Then
            Chart1.Series.Item(2).Enabled = True
        Else
            Chart1.Series.Item(2).Enabled = False
        End If
    End Sub

    Private Sub DBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles DBox.MouseWheel

        BoxValueChange("d", DBox, e.Delta)

    End Sub

    Private Sub PBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles PBox.MouseWheel

        BoxValueChange("p", PBox, e.Delta)

    End Sub

    Private Sub IBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles IBox.MouseWheel

        BoxValueChange("i", IBox, e.Delta)

    End Sub

    Private Sub PosPropBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles PosPropBox.MouseWheel

        BoxValueChange("t", PosPropBox, e.Delta)

    End Sub

    Private Sub PosDifBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles PosDifBox.MouseWheel

        BoxValueChange("u", PosDifBox, e.Delta)

    End Sub

    Private Sub KalmanBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles KalmanBox.MouseWheel

        BoxValueChange("k", KalmanBox, e.Delta)

    End Sub

    Private Sub NeutralAngleBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles NeutralAngleBox.MouseWheel

        BoxValueChange("n", NeutralAngleBox, e.Delta)

    End Sub

    Private Sub MaxTargetAngleBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles MaxTargetAngleBox.MouseWheel

        BoxValueChange("j", MaxTargetAngleBox, e.Delta)

    End Sub

    Private Sub AggPropBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles AggPropBox.MouseWheel
        BoxValueChange("l", AggPropBox, e.Delta)
    End Sub

    Private Sub AggDifBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles AggDifBox.MouseWheel
        BoxValueChange("o", AggDifBox, e.Delta)
    End Sub

    Private Sub FuzzyTransBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles FuzzyTransBox.MouseWheel
        BoxValueChange("r", FuzzyTransBox, e.Delta)
    End Sub

    Private Sub FuzzyStartBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles FuzzyStartBox.MouseWheel
        BoxValueChange("w", FuzzyStartBox, e.Delta)
    End Sub

    Private Sub BoxValueChange(ByVal menuletter As String, ByVal boxname As Windows.Forms.TextBox, mousewheel As Integer)
        Dim NValue As Double
        Dim increment As Double

        If IsNumeric(IncrementBox.Text) Then
            increment = CDbl(IncrementBox.Text)
        End If

        NValue = CDbl(boxname.Text)

        If mousewheel > 0 Then
            boxname.Text = NValue + increment
        ElseIf mousewheel < 0 Then
            boxname.Text = NValue - increment
        End If

        SerialPort1.WriteLine(menuletter)
        SerialPort1.WriteLine("(" & boxname.Text & ")")
    End Sub

    Private Sub Plot_Click(sender As Object, e As EventArgs) Handles Plot.Click
        If printvalues Then
            printvalues = False
            Plot.BackColor = Color.Red
        Else
            printvalues = True
            Plot.BackColor = Color.Green
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If printvalues Then
            SerialPort1.WriteLine("x")
        End If
    End Sub

    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click
        SerialPort1.Write("s")
        'If started Then
        '    Me.StartStopButton.Text = "Stop"
        '    started = False
        '    StartStopButton.BackColor = Color.Red
        'Else
        '    Me.StartStopButton.Text = "Start"
        '    started = True
        '    StartStopButton.BackColor = Color.Green
        'End If
    End Sub

    Private Sub SaveValues_Click(sender As Object, e As EventArgs) Handles SaveValues.Click
        SerialPort1.WriteLine("z")
    End Sub

    Private Sub SaveToFile()

        Dim WriteIndex As Integer = 0
        Dim SerieIndex As Integer
        Dim YValue(1) As Double
        Dim FILE_NAME As String ' = "C:\Users\DTS\Desktop\Marvin.txt"
        Dim SerieNumber As Integer
        Dim SaveData As DialogResult

        If plotindex > 0 Then

            SaveData = MsgBox("Would you like to save you data to a txt file?", MsgBoxStyle.YesNo, "Save Data")

            If SaveData = Windows.Forms.DialogResult.Yes Then

                OpenFileDialog1.Title = "Open a Text File"
                OpenFileDialog1.Filter = "Text Files|*.txt"
                OpenFileDialog1.ShowDialog()
                FILE_NAME = OpenFileDialog1.FileName
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                SerieNumber = Chart1.Series.Count

                objWriter.WriteLine("Robot Values")
                objWriter.WriteLine("Timer Interval," & Timer1.Interval.ToString & ",ms")

                objWriter.Write("Xindex,")
                For SerieIndex = 0 To SerieNumber - 1
                    objWriter.Write(Chart1.Series().Item(SerieIndex).Name & ",")
                Next
                objWriter.WriteLine()

                For WriteIndex = 0 To plotindex - 1
                    objWriter.Write(WriteIndex.ToString & ",")
                    For serie = 0 To SerieNumber - 1
                        YValue = Chart1.Series.Item(serie).Points.Item(WriteIndex).YValues.ToArray
                        objWriter.Write(YValue(0).ToString & ",")
                    Next
                    objWriter.WriteLine()
                Next

                objWriter.Close()
                MsgBox("Data Saved!")
            End If
        End If
    End Sub

    Private Sub IncreaseScale_Click(sender As Object, e As EventArgs) Handles IncreaseScale.Click
        plotscale = plotscale + 10
    End Sub

    Private Sub DecreaseScale_Click(sender As Object, e As EventArgs) Handles DecreaseScale.Click
        If plotscale > 10 Then
            plotscale = plotscale - 10
        End If
    End Sub

    Private Sub SettingButton_Click(sender As Object, e As EventArgs) Handles SettingButton.Click
        serialclose()
        My.Forms.SettingsForm.Show()
    End Sub

    Private Sub SerialPortList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SerialPortList.SelectedIndexChanged
        If SerialPort1.IsOpen Then
            serialclose()
        End If
        serialconnect()
    End Sub

    Private Sub SerialPortList_DropDown(sender As Object, e As EventArgs) Handles SerialPortList.DropDown
        serialclose()
        SearchComPorts()
    End Sub

End Class
