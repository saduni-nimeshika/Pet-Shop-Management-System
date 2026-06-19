
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class Form1
    Dim startPoint As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        startPoint += 2
        Guna2ProgressBar1.Value = startPoint

        If Guna2ProgressBar1.Value = 100 Then
            Guna2ProgressBar1.Value = 0
            Timer1.Stop()

            Dim login As New LoginForm()
            login.ShowDialog()
            Me.Hide()
        End If
    End Sub


End Class
