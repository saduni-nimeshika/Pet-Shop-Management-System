Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class LoginForm
    Private cn As MySqlConnection
    Private cm As MySqlCommand
    Private dr As MySqlDataReader
    Private title As String = "Pet Shop Management System"

    Public Sub New()
        InitializeComponent()

        cn = DbConnection.GetConnection()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        If MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If TxtUser.Text.Trim() = "" AndAlso TxtPass.Text.Trim() = "" Then
            MessageBox.Show("Please enter both Username and Password!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUser.Focus()
            Exit Sub
        ElseIf TxtUser.Text.Trim() = "" Then
            MessageBox.Show("Please enter your Username!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUser.Focus()
            Exit Sub
        ElseIf TxtPass.Text.Trim() = "" Then
            MessageBox.Show("Please enter your Password!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPass.Focus()
            Exit Sub
        End If






        Try
            Dim _name As String = ""
            Dim _role As String = ""


            If cn.State = ConnectionState.Closed Then cn.Open()


            cm = New MySqlCommand("SELECT name, role FROM user WHERE name=@name AND password=@password", cn)
            cm.Parameters.AddWithValue("@name", TxtUser.Text.Trim())
            cm.Parameters.AddWithValue("@password", TxtPass.Text.Trim())

            dr = cm.ExecuteReader()

            If dr.Read() Then

                _name = dr("name").ToString()
                _role = dr("role").ToString().Trim()


                If _role.ToLower() = "employee" Then

                    MessageBox.Show("Employees cannot access this system!",
                        "ACCESS DENIED",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)

                    dr.Close()
                    cn.Close()
                    Exit Sub

                End If





                Dim main As New MainForm()
                main.LblUsername.Text = _name
                main.LblUser.Text = _role


                If _role.ToLower() = "cashier" Then
                    main.BtnUser.Visible = False
                End If



                If _role = "Administrator" Then
                    main.BtnUser.Enabled = True
                End If

                Me.Hide()
                main.ShowDialog()
                Me.Show()

            Else
                MessageBox.Show("Invalid username or password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            dr.Close()
            cn.Close()

        Catch ex As Exception
            If dr IsNot Nothing Then dr.Close()
            If cn.State = ConnectionState.Open Then cn.Close()
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnForget_Click(sender As Object, e As EventArgs) Handles BtnForget.Click
        MessageBox.Show("Please contact your BOSS!", "FORGET PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class