Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class Form1
    Shared _continue As Boolean
    Shared _serialPort As SerialPort
    Dim temp As Long
    Dim SerialData As String
    Dim TempString As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TempString = "Nothing Yet"
        'Lbl3.Text = TempString
        Dim ports As String() = SerialPort.GetPortNames()
        cbPort.Items.AddRange(ports)
        SerialPort1.Close()
        SerialPort1.PortName = "Com1"
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
        write_to_serial()

    End Sub
    Private Sub CountdownTimer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub
    Private Sub SetDefaults()
        btnStartStop.Text = "Start"
        counter.Enabled = False
        btnNew.Enabled = True
        btnStartStop.Enabled = True
        btnSetTime.Enabled = True
        lblMin.Enabled = True
        lblSec.Enabled = True
        temp = 0
        write_to_serial()
    End Sub
    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        btnStartStop.Text = "Start"
        counter.Enabled = False
        lblMin.Enabled = True
        lblSec.Enabled = True
        upDark.Text = "00"
        upWhite.Text = "00"
        upPeriod.Value = "1"
        lblMin.Text = "0"
        lblSec.Text = "00"
        temp = 0
        write_to_serial()
    End Sub
    Private Sub SetTime()
        lblMin.Text = (temp Mod 3600) \ 60
        lblSec.Text = temp Mod 3600 Mod 60
        If lblSec.Text.Length = 1 Then
            lblSec.Text = "0" & lblSec.Text
        End If
        'Lbl3.Text = TempString
        write_to_serial()
    End Sub
    Private Sub set_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetTime.Click
        If upMin.Value = 0 And upSec.Value = 0 Then
            MsgBox("Please set a valid Time!")
        Else
            temp = upMin.Value * 60 + upSec.Value
            SetTime()
        End If
    End Sub
    Private Sub oneMinBreak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1MinBreak.Click
        temp = 60
        SetTime()
        btnStartStop.Text = "Stop"
        counter.Enabled = True
        upPeriod.Value = "1" + upPeriod.Value
    End Sub
    Private Sub twoMinBreak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2MinBreak.Click
        temp = 120
        SetTime()
        btnStartStop.Text = "Stop"
        counter.Enabled = True
        upPeriod.Value = "1" + upPeriod.Value
    End Sub
    Private Sub counter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles counter.Tick
        If temp = 0 Then
            SetDefaults()
        Else
            temp = temp - 1
            SetTime()
        End If

    End Sub
    Private Sub btnStartStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartStop.Click
        If btnStartStop.Text = "Start" Then
            counter.Enabled = True
            btnStartStop.Text = "Stop"
        ElseIf btnStartStop.Text = "Stop" Then
            counter.Enabled = False
            btnStartStop.Text = "Start"
        End If
        write_to_serial()
    End Sub
    Private Sub cbPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPort.SelectedIndexChanged
        SerialPort1.PortName = cbPort.Text
        write_to_serial()
    End Sub

    Private Sub write_to_serial()
        If upDark.Text.Length = 1 And upWhite.Text.Length = 1 Then
            SerialData = "0" + upDark.Text + lblMin.Text + lblSec.Text + "0" + upWhite.Text + upPeriod.Text
        ElseIf upDark.Text.Length = 1 Then
            SerialData = "0" + upDark.Text + lblMin.Text + lblSec.Text + upWhite.Text + upPeriod.Text
        ElseIf upWhite.Text.Length = 1 Then
            SerialData = upDark.Text + lblMin.Text + lblSec.Text + "0" + upWhite.Text + upPeriod.Text
        Else
            SerialData = upDark.Text + lblMin.Text + lblSec.Text + upWhite.Text + upPeriod.Text
        End If
        SerialPort1.Open()
        'For w As Integer = 0 To 7
        'SerialPort1.WriteLine(SerialData.Chars(w))
        'Next
        SerialPort1.WriteLine(SerialData)
        SerialPort1.Close()
        Lbl3.Text = SerialData
    End Sub

    Private Sub upDark_ValueChanged(sender As Object, e As EventArgs) Handles upDark.TextChanged
        write_to_serial()
    End Sub

    Private Sub upWhite_ValueChanged(sender As Object, e As EventArgs) Handles upWhite.TextChanged
        write_to_serial()
    End Sub

    Private Sub upPeriod_ValueChanged(sender As Object, e As EventArgs) Handles upPeriod.TextChanged
        write_to_serial()
    End Sub

    'Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
    'TempString = SerialPort1.ReadLine()
    'End Sub
End Class
