<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.upWhite = New System.Windows.Forms.NumericUpDown()
        Me.upDark = New System.Windows.Forms.NumericUpDown()
        Me.lblDark = New System.Windows.Forms.Label()
        Me.lblWhite = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblColon = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSetTime = New System.Windows.Forms.Button()
        Me.upSec = New System.Windows.Forms.NumericUpDown()
        Me.upMin = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.counter = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.upPeriod = New System.Windows.Forms.NumericUpDown()
        Me.btn1MinBreak = New System.Windows.Forms.Button()
        Me.btn2MinBreak = New System.Windows.Forms.Button()
        Me.cbPort = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Lbl3 = New System.Windows.Forms.Label()
        CType(Me.upWhite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upDark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.upSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.AutoSize = True
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNew.Location = New System.Drawing.Point(0, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(764, 23)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New Game"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'upWhite
        '
        Me.upWhite.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.upWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upWhite.ForeColor = System.Drawing.SystemColors.Info
        Me.upWhite.Location = New System.Drawing.Point(521, 240)
        Me.upWhite.Name = "upWhite"
        Me.upWhite.Size = New System.Drawing.Size(80, 53)
        Me.upWhite.TabIndex = 2
        Me.upWhite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'upDark
        '
        Me.upDark.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.upDark.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upDark.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.upDark.Location = New System.Drawing.Point(153, 240)
        Me.upDark.Name = "upDark"
        Me.upDark.Size = New System.Drawing.Size(80, 53)
        Me.upDark.TabIndex = 3
        Me.upDark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDark
        '
        Me.lblDark.AutoSize = True
        Me.lblDark.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDark.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblDark.Location = New System.Drawing.Point(142, 204)
        Me.lblDark.Name = "lblDark"
        Me.lblDark.Size = New System.Drawing.Size(97, 33)
        Me.lblDark.TabIndex = 4
        Me.lblDark.Text = "DARK"
        '
        'lblWhite
        '
        Me.lblWhite.AutoSize = True
        Me.lblWhite.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhite.ForeColor = System.Drawing.SystemColors.Info
        Me.lblWhite.Location = New System.Drawing.Point(504, 204)
        Me.lblWhite.Name = "lblWhite"
        Me.lblWhite.Size = New System.Drawing.Size(110, 33)
        Me.lblWhite.TabIndex = 5
        Me.lblWhite.Text = "WHITE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMin)
        Me.GroupBox1.Controls.Add(Me.lblSec)
        Me.GroupBox1.Controls.Add(Me.lblColon)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(304, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 77)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.Color.Red
        Me.lblMin.Location = New System.Drawing.Point(41, 25)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(39, 42)
        Me.lblMin.TabIndex = 0
        Me.lblMin.Text = "0"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.ForeColor = System.Drawing.Color.Red
        Me.lblSec.Location = New System.Drawing.Point(86, 25)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(60, 42)
        Me.lblSec.TabIndex = 1
        Me.lblSec.Text = "00"
        '
        'lblColon
        '
        Me.lblColon.AutoSize = True
        Me.lblColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColon.ForeColor = System.Drawing.Color.Red
        Me.lblColon.Location = New System.Drawing.Point(70, 25)
        Me.lblColon.Name = "lblColon"
        Me.lblColon.Size = New System.Drawing.Size(28, 42)
        Me.lblColon.TabIndex = 2
        Me.lblColon.Text = ":"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSetTime)
        Me.GroupBox2.Controls.Add(Me.upSec)
        Me.GroupBox2.Controls.Add(Me.upMin)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(539, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 49)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Set Time"
        '
        'btnSetTime
        '
        Me.btnSetTime.Location = New System.Drawing.Point(120, 20)
        Me.btnSetTime.Name = "btnSetTime"
        Me.btnSetTime.Size = New System.Drawing.Size(75, 20)
        Me.btnSetTime.TabIndex = 3
        Me.btnSetTime.Text = "Set Time"
        Me.btnSetTime.UseVisualStyleBackColor = True
        '
        'upSec
        '
        Me.upSec.Location = New System.Drawing.Point(60, 20)
        Me.upSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.upSec.Name = "upSec"
        Me.upSec.Size = New System.Drawing.Size(45, 20)
        Me.upSec.TabIndex = 2
        '
        'upMin
        '
        Me.upMin.Location = New System.Drawing.Point(7, 20)
        Me.upMin.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.upMin.Name = "upMin"
        Me.upMin.Size = New System.Drawing.Size(40, 20)
        Me.upMin.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":"
        '
        'btnStartStop
        '
        Me.btnStartStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartStop.Location = New System.Drawing.Point(330, 161)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(120, 40)
        Me.btnStartStop.TabIndex = 8
        Me.btnStartStop.Text = "Start"
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'counter
        '
        Me.counter.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(327, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Period"
        '
        'upPeriod
        '
        Me.upPeriod.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.upPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upPeriod.ForeColor = System.Drawing.Color.Red
        Me.upPeriod.Location = New System.Drawing.Point(357, 240)
        Me.upPeriod.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.upPeriod.Name = "upPeriod"
        Me.upPeriod.Size = New System.Drawing.Size(60, 53)
        Me.upPeriod.TabIndex = 9
        Me.upPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.upPeriod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn1MinBreak
        '
        Me.btn1MinBreak.Location = New System.Drawing.Point(659, 84)
        Me.btn1MinBreak.Name = "btn1MinBreak"
        Me.btn1MinBreak.Size = New System.Drawing.Size(75, 20)
        Me.btn1MinBreak.TabIndex = 4
        Me.btn1MinBreak.Text = "1 min Break"
        Me.btn1MinBreak.UseVisualStyleBackColor = True
        '
        'btn2MinBreak
        '
        Me.btn2MinBreak.Location = New System.Drawing.Point(659, 116)
        Me.btn2MinBreak.Name = "btn2MinBreak"
        Me.btn2MinBreak.Size = New System.Drawing.Size(75, 20)
        Me.btn2MinBreak.TabIndex = 11
        Me.btn2MinBreak.Text = "2 min Break"
        Me.btn2MinBreak.UseVisualStyleBackColor = True
        '
        'cbPort
        '
        Me.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPort.FormattingEnabled = True
        Me.cbPort.Location = New System.Drawing.Point(13, 29)
        Me.cbPort.Name = "cbPort"
        Me.cbPort.Size = New System.Drawing.Size(121, 21)
        Me.cbPort.TabIndex = 12
        '
        'SerialPort1
        '
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Location = New System.Drawing.Point(25, 329)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(39, 13)
        Me.Lbl3.TabIndex = 13
        Me.Lbl3.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(764, 367)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.cbPort)
        Me.Controls.Add(Me.btn2MinBreak)
        Me.Controls.Add(Me.btn1MinBreak)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.upPeriod)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblWhite)
        Me.Controls.Add(Me.lblDark)
        Me.Controls.Add(Me.upDark)
        Me.Controls.Add(Me.upWhite)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "Form1"
        Me.Text = "Scoreboard"
        CType(Me.upWhite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upDark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.upSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents upWhite As NumericUpDown
    Friend WithEvents upDark As NumericUpDown
    Friend WithEvents lblDark As Label
    Friend WithEvents lblWhite As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblMin As Label
    Friend WithEvents lblSec As Label
    Friend WithEvents lblColon As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents upMin As NumericUpDown
    Friend WithEvents btnSetTime As Button
    Friend WithEvents upSec As NumericUpDown
    Friend WithEvents btnStartStop As Button
    Friend WithEvents counter As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents upPeriod As NumericUpDown
    Friend WithEvents btn1MinBreak As Button
    Friend WithEvents btn2MinBreak As Button
    Friend WithEvents cbPort As ComboBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Lbl3 As Label
End Class
