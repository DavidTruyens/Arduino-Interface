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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBoxAngle = New System.Windows.Forms.CheckBox()
        Me.Connect = New System.Windows.Forms.Button()
        Me.IncrementBox = New System.Windows.Forms.TextBox()
        Me.Increment = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CMDLine = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBoxJoyX = New System.Windows.Forms.CheckBox()
        Me.CheckBoxJoyY = New System.Windows.Forms.CheckBox()
        Me.NeutralAngleBox = New System.Windows.Forms.TextBox()
        Me.NAngle = New System.Windows.Forms.Label()
        Me.RefreshRate = New System.Windows.Forms.Label()
        Me.RefreshRateBox = New System.Windows.Forms.TextBox()
        Me.SaveValues = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartStopButton
        '
        Me.StartStopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartStopButton.Location = New System.Drawing.Point(454, 52)
        Me.StartStopButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(91, 20)
        Me.StartStopButton.TabIndex = 2
        Me.StartStopButton.Text = "Start"
        Me.StartStopButton.UseVisualStyleBackColor = True
        '
        'JoyStickButton
        '
        Me.JoyStickButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JoyStickButton.Location = New System.Drawing.Point(453, 77)
        Me.JoyStickButton.Margin = New System.Windows.Forms.Padding(2)
        Me.JoyStickButton.Name = "JoyStickButton"
        Me.JoyStickButton.Size = New System.Drawing.Size(91, 20)
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
        ChartArea2.AxisX.IsStartedFromZero = False
        ChartArea2.BackSecondaryColor = System.Drawing.Color.Red
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.Cross
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(-1, 159)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(2)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(556, 252)
        Me.Chart1.TabIndex = 12
        Me.Chart1.Text = "Chart1"
        '
        'Plot
        '
        Me.Plot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Plot.Location = New System.Drawing.Point(453, 101)
        Me.Plot.Margin = New System.Windows.Forms.Padding(2)
        Me.Plot.Name = "Plot"
        Me.Plot.Size = New System.Drawing.Size(91, 20)
        Me.Plot.TabIndex = 13
        Me.Plot.Text = "Plot"
        Me.Plot.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM8"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(454, 3)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 16
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
        'Connect
        '
        Me.Connect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Connect.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Connect.Location = New System.Drawing.Point(454, 28)
        Me.Connect.Margin = New System.Windows.Forms.Padding(2)
        Me.Connect.Name = "Connect"
        Me.Connect.Size = New System.Drawing.Size(91, 20)
        Me.Connect.TabIndex = 11
        Me.Connect.Text = "Connect"
        Me.Connect.UseVisualStyleBackColor = False
        '
        'IncrementBox
        '
        Me.IncrementBox.Location = New System.Drawing.Point(246, 94)
        Me.IncrementBox.Margin = New System.Windows.Forms.Padding(2)
        Me.IncrementBox.Name = "IncrementBox"
        Me.IncrementBox.Size = New System.Drawing.Size(57, 20)
        Me.IncrementBox.TabIndex = 18
        '
        'Increment
        '
        Me.Increment.AutoSize = True
        Me.Increment.Location = New System.Drawing.Point(244, 77)
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
        'RefreshRate
        '
        Me.RefreshRate.AutoSize = True
        Me.RefreshRate.Location = New System.Drawing.Point(166, 77)
        Me.RefreshRate.Name = "RefreshRate"
        Me.RefreshRate.Size = New System.Drawing.Size(70, 13)
        Me.RefreshRate.TabIndex = 26
        Me.RefreshRate.Text = "Refresh Rate"
        '
        'RefreshRateBox
        '
        Me.RefreshRateBox.Location = New System.Drawing.Point(169, 94)
        Me.RefreshRateBox.Name = "RefreshRateBox"
        Me.RefreshRateBox.Size = New System.Drawing.Size(69, 20)
        Me.RefreshRateBox.TabIndex = 27
        '
        'SaveValues
        '
        Me.SaveValues.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveValues.Location = New System.Drawing.Point(453, 125)
        Me.SaveValues.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveValues.Name = "SaveValues"
        Me.SaveValues.Size = New System.Drawing.Size(91, 20)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(554, 409)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SaveValues)
        Me.Controls.Add(Me.RefreshRateBox)
        Me.Controls.Add(Me.RefreshRate)
        Me.Controls.Add(Me.NAngle)
        Me.Controls.Add(Me.NeutralAngleBox)
        Me.Controls.Add(Me.CheckBoxJoyY)
        Me.Controls.Add(Me.CheckBoxJoyX)
        Me.Controls.Add(Me.CMDLine)
        Me.Controls.Add(Me.Increment)
        Me.Controls.Add(Me.IncrementBox)
        Me.Controls.Add(Me.CheckBoxAngle)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Plot)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Connect)
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
    Friend WithEvents Connect As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Plot As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
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
    Friend WithEvents RefreshRate As System.Windows.Forms.Label
    Friend WithEvents RefreshRateBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveValues As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
