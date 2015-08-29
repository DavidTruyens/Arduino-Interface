<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StartStopButton = New System.Windows.Forms.Button()
        Me.JoyStickButton = New System.Windows.Forms.Button()
        Me.PBox = New System.Windows.Forms.TextBox()
        Me.IBox = New System.Windows.Forms.TextBox()
        Me.DBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Plot = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortList = New System.Windows.Forms.ComboBox()
        Me.CheckBoxAngle = New System.Windows.Forms.CheckBox()
        Me.IncrementBox = New System.Windows.Forms.TextBox()
        Me.Increment = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CMDLine = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBoxJoyX = New System.Windows.Forms.CheckBox()
        Me.CheckBoxJoyY = New System.Windows.Forms.CheckBox()
        Me.NeutralAngleBox = New System.Windows.Forms.TextBox()
        Me.NAngle = New System.Windows.Forms.Label()
        Me.SaveValues = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IncreaseScale = New System.Windows.Forms.Label()
        Me.DecreaseScale = New System.Windows.Forms.Label()
        Me.SettingButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KalmanBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PosPropBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PosDifBox = New System.Windows.Forms.TextBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartStopButton
        '
        Me.StartStopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartStopButton.Location = New System.Drawing.Point(450, 27)
        Me.StartStopButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(151, 20)
        Me.StartStopButton.TabIndex = 2
        Me.StartStopButton.Text = "Start"
        Me.StartStopButton.UseVisualStyleBackColor = True
        '
        'JoyStickButton
        '
        Me.JoyStickButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JoyStickButton.Location = New System.Drawing.Point(450, 52)
        Me.JoyStickButton.Margin = New System.Windows.Forms.Padding(2)
        Me.JoyStickButton.Name = "JoyStickButton"
        Me.JoyStickButton.Size = New System.Drawing.Size(150, 20)
        Me.JoyStickButton.TabIndex = 3
        Me.JoyStickButton.Text = "Enable Joystick"
        Me.JoyStickButton.UseVisualStyleBackColor = True
        '
        'PBox
        '
        Me.PBox.Location = New System.Drawing.Point(9, 28)
        Me.PBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PBox.Name = "PBox"
        Me.PBox.Size = New System.Drawing.Size(76, 20)
        Me.PBox.TabIndex = 4
        '
        'IBox
        '
        Me.IBox.Location = New System.Drawing.Point(88, 28)
        Me.IBox.Margin = New System.Windows.Forms.Padding(2)
        Me.IBox.Name = "IBox"
        Me.IBox.Size = New System.Drawing.Size(76, 20)
        Me.IBox.TabIndex = 5
        '
        'DBox
        '
        Me.DBox.Location = New System.Drawing.Point(168, 28)
        Me.DBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DBox.Name = "DBox"
        Me.DBox.Size = New System.Drawing.Size(61, 20)
        Me.DBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "P - Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "I - Value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "D - Value"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.IsStartedFromZero = False
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Red
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.Cross
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(-1, 159)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(2)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(612, 252)
        Me.Chart1.TabIndex = 12
        Me.Chart1.Text = "Chart1"
        '
        'Plot
        '
        Me.Plot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Plot.Location = New System.Drawing.Point(450, 76)
        Me.Plot.Margin = New System.Windows.Forms.Padding(2)
        Me.Plot.Name = "Plot"
        Me.Plot.Size = New System.Drawing.Size(150, 20)
        Me.Plot.TabIndex = 13
        Me.Plot.Text = "Plot"
        Me.Plot.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM8"
        '
        'SerialPortList
        '
        Me.SerialPortList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SerialPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SerialPortList.FormattingEnabled = True
        Me.SerialPortList.Location = New System.Drawing.Point(450, 3)
        Me.SerialPortList.Margin = New System.Windows.Forms.Padding(2)
        Me.SerialPortList.Name = "SerialPortList"
        Me.SerialPortList.Size = New System.Drawing.Size(151, 21)
        Me.SerialPortList.TabIndex = 16
        '
        'CheckBoxAngle
        '
        Me.CheckBoxAngle.AutoSize = True
        Me.CheckBoxAngle.Location = New System.Drawing.Point(12, 55)
        Me.CheckBoxAngle.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxAngle.Name = "CheckBoxAngle"
        Me.CheckBoxAngle.Size = New System.Drawing.Size(53, 17)
        Me.CheckBoxAngle.TabIndex = 17
        Me.CheckBoxAngle.Text = "Angle"
        Me.CheckBoxAngle.UseVisualStyleBackColor = True
        '
        'IncrementBox
        '
        Me.IncrementBox.Location = New System.Drawing.Point(246, 107)
        Me.IncrementBox.Margin = New System.Windows.Forms.Padding(2)
        Me.IncrementBox.Name = "IncrementBox"
        Me.IncrementBox.Size = New System.Drawing.Size(57, 20)
        Me.IncrementBox.TabIndex = 18
        '
        'Increment
        '
        Me.Increment.AutoSize = True
        Me.Increment.Location = New System.Drawing.Point(244, 90)
        Me.Increment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Increment.Name = "Increment"
        Me.Increment.Size = New System.Drawing.Size(54, 13)
        Me.Increment.TabIndex = 19
        Me.Increment.Text = "Increment"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(311, 9)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(135, 146)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'CMDLine
        '
        Me.CMDLine.Location = New System.Drawing.Point(9, 132)
        Me.CMDLine.Name = "CMDLine"
        Me.CMDLine.Size = New System.Drawing.Size(298, 20)
        Me.CMDLine.TabIndex = 21
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'CheckBoxJoyX
        '
        Me.CheckBoxJoyX.AutoSize = True
        Me.CheckBoxJoyX.Location = New System.Drawing.Point(12, 74)
        Me.CheckBoxJoyX.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxJoyX.Name = "CheckBoxJoyX"
        Me.CheckBoxJoyX.Size = New System.Drawing.Size(49, 17)
        Me.CheckBoxJoyX.TabIndex = 22
        Me.CheckBoxJoyX.Text = "JoyX"
        Me.CheckBoxJoyX.UseVisualStyleBackColor = True
        '
        'CheckBoxJoyY
        '
        Me.CheckBoxJoyY.AutoSize = True
        Me.CheckBoxJoyY.Location = New System.Drawing.Point(12, 95)
        Me.CheckBoxJoyY.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxJoyY.Name = "CheckBoxJoyY"
        Me.CheckBoxJoyY.Size = New System.Drawing.Size(49, 17)
        Me.CheckBoxJoyY.TabIndex = 23
        Me.CheckBoxJoyY.Text = "JoyY"
        Me.CheckBoxJoyY.UseVisualStyleBackColor = True
        '
        'NeutralAngleBox
        '
        Me.NeutralAngleBox.Location = New System.Drawing.Point(234, 28)
        Me.NeutralAngleBox.Name = "NeutralAngleBox"
        Me.NeutralAngleBox.Size = New System.Drawing.Size(72, 20)
        Me.NeutralAngleBox.TabIndex = 24
        '
        'NAngle
        '
        Me.NAngle.AutoSize = True
        Me.NAngle.Location = New System.Drawing.Point(232, 11)
        Me.NAngle.Name = "NAngle"
        Me.NAngle.Size = New System.Drawing.Size(71, 13)
        Me.NAngle.TabIndex = 25
        Me.NAngle.Text = "Neutral Angle"
        '
        'SaveValues
        '
        Me.SaveValues.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveValues.Location = New System.Drawing.Point(450, 100)
        Me.SaveValues.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveValues.Name = "SaveValues"
        Me.SaveValues.Size = New System.Drawing.Size(150, 20)
        Me.SaveValues.TabIndex = 28
        Me.SaveValues.Text = "Save PID Val"
        Me.SaveValues.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Latest incomming data line"
        '
        'IncreaseScale
        '
        Me.IncreaseScale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IncreaseScale.AutoSize = True
        Me.IncreaseScale.Location = New System.Drawing.Point(584, 385)
        Me.IncreaseScale.Name = "IncreaseScale"
        Me.IncreaseScale.Size = New System.Drawing.Size(13, 13)
        Me.IncreaseScale.TabIndex = 30
        Me.IncreaseScale.Text = "+"
        '
        'DecreaseScale
        '
        Me.DecreaseScale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DecreaseScale.AutoSize = True
        Me.DecreaseScale.Location = New System.Drawing.Point(564, 385)
        Me.DecreaseScale.Name = "DecreaseScale"
        Me.DecreaseScale.Size = New System.Drawing.Size(10, 13)
        Me.DecreaseScale.TabIndex = 31
        Me.DecreaseScale.Text = "-"
        '
        'SettingButton
        '
        Me.SettingButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingButton.Location = New System.Drawing.Point(450, 124)
        Me.SettingButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.Size = New System.Drawing.Size(150, 28)
        Me.SettingButton.TabIndex = 32
        Me.SettingButton.Text = "Settings"
        Me.SettingButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Marvin_Test.My.MySettings.Default, "ImagePOS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = Global.Marvin_Test.My.MySettings.Default.ImagePOS
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 90)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Kalman-Filter"
        '
        'KalmanBox
        '
        Me.KalmanBox.Location = New System.Drawing.Point(165, 107)
        Me.KalmanBox.Margin = New System.Windows.Forms.Padding(2)
        Me.KalmanBox.Name = "KalmanBox"
        Me.KalmanBox.Size = New System.Drawing.Size(76, 20)
        Me.KalmanBox.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(167, 50)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Pos-Prop"
        '
        'PosPropBox
        '
        Me.PosPropBox.Location = New System.Drawing.Point(168, 65)
        Me.PosPropBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PosPropBox.Name = "PosPropBox"
        Me.PosPropBox.Size = New System.Drawing.Size(61, 20)
        Me.PosPropBox.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(233, 50)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Pos-Dif"
        '
        'PosDifBox
        '
        Me.PosDifBox.Location = New System.Drawing.Point(235, 65)
        Me.PosDifBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PosDifBox.Name = "PosDifBox"
        Me.PosDifBox.Size = New System.Drawing.Size(71, 20)
        Me.PosDifBox.TabIndex = 37
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(610, 409)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PosDifBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PosPropBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.KalmanBox)
        Me.Controls.Add(Me.SettingButton)
        Me.Controls.Add(Me.DecreaseScale)
        Me.Controls.Add(Me.IncreaseScale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SaveValues)
        Me.Controls.Add(Me.NAngle)
        Me.Controls.Add(Me.NeutralAngleBox)
        Me.Controls.Add(Me.CheckBoxJoyY)
        Me.Controls.Add(Me.CheckBoxJoyX)
        Me.Controls.Add(Me.CMDLine)
        Me.Controls.Add(Me.Increment)
        Me.Controls.Add(Me.IncrementBox)
        Me.Controls.Add(Me.CheckBoxAngle)
        Me.Controls.Add(Me.SerialPortList)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Plot)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DBox)
        Me.Controls.Add(Me.IBox)
        Me.Controls.Add(Me.PBox)
        Me.Controls.Add(Me.JoyStickButton)
        Me.Controls.Add(Me.StartStopButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Marvin Launch Pad"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartStopButton As System.Windows.Forms.Button
    Friend WithEvents JoyStickButton As System.Windows.Forms.Button
    Friend WithEvents PBox As System.Windows.Forms.TextBox
    Friend WithEvents IBox As System.Windows.Forms.TextBox
    Friend WithEvents DBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Plot As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPortList As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxAngle As System.Windows.Forms.CheckBox
    Friend WithEvents IncrementBox As System.Windows.Forms.TextBox
    Friend WithEvents Increment As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CMDLine As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CheckBoxJoyX As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxJoyY As System.Windows.Forms.CheckBox
    Friend WithEvents NeutralAngleBox As System.Windows.Forms.TextBox
    Friend WithEvents NAngle As System.Windows.Forms.Label
    Friend WithEvents SaveValues As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IncreaseScale As System.Windows.Forms.Label
    Friend WithEvents DecreaseScale As System.Windows.Forms.Label
    Friend WithEvents SettingButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents KalmanBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PosPropBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PosDifBox As TextBox
End Class
