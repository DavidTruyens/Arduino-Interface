Imports System
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
        RefreshRateBox.Text = 25
        NeutralAngleBox.Text = 0

        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
        Next
        ComboBox1.Text = ComboBox1.Items(1)
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

    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click

        If (connected = False) Then
            Try
                SerialPort1.PortName = ComboBox1.Text
                SerialPort1.BaudRate = 115200
                SerialPort1.Open()

                If IsNumeric(RefreshRateBox.Text) Then
                    Timer1.Interval = CInt(RefreshRateBox.Text)
                Else
                    Timer1.Interval = 100
                End If
                Timer1.Start()
                connected = True
                Connect.BackColor = Color.Green
                Connect.Text = "Connected!"

                SerialPort1.WriteLine("a")

            Catch ex As Exception
                Connect.BackColor = Color.Red
                Connect.Text = "Error"
                MsgBox("Connection error" & vbNewLine & "Make sure bluetooht is connected")
            End Try
        Else
            SerialPort1.Close()
            connected = False
            Connect.BackColor = Color.WhiteSmoke
            Connect.Text = "Connect"
            Timer1.Stop()
        End If

    End Sub

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
            If connected Then
                SerialPort1.Close()
                connected = False
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
        Dim NewDValue As Double
        Dim increment As Double = 1

        If IsNumeric(IncrementBox.Text) Then
            increment = CDbl(IncrementBox.Text)
        End If

        If e.Delta > 0 Then
            If IsNumeric(DBox.Text) Then
                NewDValue = CDbl(DBox.Text)
                'mousewheelpos = SystemInformation.MouseWheelScrollDelta
                DBox.Text = NewDValue + increment
            End If
        ElseIf e.Delta < 0 Then
            If IsNumeric(DBox.Text) Then
                NewDValue = CDbl(DBox.Text)
                DBox.Text = NewDValue - increment
            End If
        End If

        SerialPort1.WriteLine("d")
        SerialPort1.WriteLine("(" & DBox.Text & ")")

    End Sub

    Private Sub PBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles PBox.MouseWheel
        Dim NewPValue As Double
        Dim increment As Double = 1

        If IsNumeric(IncrementBox.Text) Then
            increment = CDbl(IncrementBox.Text)
        End If

        If e.Delta > 0 Then
            If IsNumeric(PBox.Text) Then
                NewPValue = CDbl(PBox.Text)
                PBox.Text = NewPValue + increment
                SerialPort1.WriteLine("p")
                SerialPort1.WriteLine("(" & PBox.Text & ")")
            End If
        ElseIf e.Delta < 0 Then
            If IsNumeric(PBox.Text) Then
                NewPValue = CDbl(PBox.Text)
                PBox.Text = NewPValue - increment
                SerialPort1.WriteLine("p")
                SerialPort1.WriteLine("(" & PBox.Text & ")")
            End If
        End If
    End Sub

    Private Sub NeutralAngleBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles NeutralAngleBox.MouseWheel
        Dim NValue As Double
        Dim increment As Double

        If IsNumeric(IncrementBox.Text) Then
            increment = CDbl(IncrementBox.Text)
        End If

        If e.Delta > 0 Then
            NValue = CDbl(NeutralAngleBox.Text)
            NeutralAngleBox.Text = NValue + increment
            SerialPort1.WriteLine("n")
            SerialPort1.WriteLine("(" & NeutralAngleBox.Text & ")")
        ElseIf e.Delta < 0 Then
            NValue = CDbl(NeutralAngleBox.Text)
            NeutralAngleBox.Text = NValue - increment
            SerialPort1.WriteLine("n")
            SerialPort1.WriteLine("(" & NeutralAngleBox.Text & ")")
        End If
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
        If started Then
            Me.StartStopButton.Text = "Stop"
            started = False
            StartStopButton.BackColor = Color.Red
        Else
            Me.StartStopButton.Text = "Start"
            started = True
            StartStopButton.BackColor = Color.Green
        End If
    End Sub

    Private Sub SaveValues_Click(sender As Object, e As EventArgs) Handles SaveValues.Click
        SerialPort1.WriteLine("z")
    End Sub

    Private Sub IBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles IBox.MouseWheel
        Dim NewIValue As Double
        Dim increment As Double = 1

        If IsNumeric(IncrementBox.Text) Then
            increment = CDbl(IncrementBox.Text)
        End If

        If e.Delta > 0 Then
            If IsNumeric(IBox.Text) Then
                NewIValue = CDbl(IBox.Text)
                IBox.Text = NewIValue + increment
                SerialPort1.WriteLine("i")
                SerialPort1.WriteLine("(" & IBox.Text & ")")
            End If
        ElseIf e.Delta < 0 Then
            If IsNumeric(IBox.Text) Then
                NewIValue = CDbl(IBox.Text)
                IBox.Text = NewIValue - increment
                SerialPort1.WriteLine("i")
                SerialPort1.WriteLine("(" & IBox.Text & ")")
            End If
        End If
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
End Class
