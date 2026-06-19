Imports System.Windows.Forms
Imports MySql.Data.MySqlClient



Public Class UserModule


    Private cn As MySqlConnection
    Private cm As MySqlCommand
    Private title As String = "Pet Shop Management System"
    Private check As Boolean = False
    Private userForm As UserForm

    Public Sub New(parent As UserForm)
        InitializeComponent()

        cn = DbConnection.GetConnection()
        userForm = parent
        CbRole.SelectedIndex = 0

        BtnSave.Enabled = True
        BtnUpdate.Enabled = False
        BtnCancel.Enabled = False


    End Sub
    Private Sub UserModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Lblpass.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged

    End Sub

    Private Sub LblUid_Click(sender As Object, e As EventArgs) Handles LblUid.Click

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            CheckField()
            If check = True Then
                If MessageBox.Show("Are you sure you want to register this user?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


                    Using cn As MySqlConnection = GetConnection()
                        cn.Open()
                        Using cm As New MySqlCommand("INSERT INTO user(name,address,phone,role,dob,password) VALUES(@name,@address,@phone,@role,@dob,@password)", cn)
                            cm.Parameters.AddWithValue("@name", TxtName.Text.Trim())
                            cm.Parameters.AddWithValue("@address", TxtAddress.Text.Trim())
                            cm.Parameters.AddWithValue("@phone", TxtPhone.Text.Trim())
                            cm.Parameters.AddWithValue("@role", CbRole.Text)
                            cm.Parameters.AddWithValue("@dob", DtDob.Value)
                            cm.Parameters.AddWithValue("@password", TxtPass.Text)
                            cm.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("User registered successfully!", title)
                    Clear()
                    userForm.LoadUser()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If LblUid.Text = "" Then Exit Sub
        Try
            CheckField()
            If check Then
                If MessageBox.Show("Are you sure to update this user?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Using cn As MySqlConnection = GetConnection()
                        cn.Open()
                        Using cm As New MySqlCommand("UPDATE user SET name=@name,address=@address,phone=@phone,role=@role,dob=@dob,password=@password WHERE id=@id", cn)
                            cm.Parameters.AddWithValue("@id", LblUid.Text)
                            cm.Parameters.AddWithValue("@name", TxtName.Text.Trim())
                            cm.Parameters.AddWithValue("@address", TxtAddress.Text.Trim())
                            cm.Parameters.AddWithValue("@phone", TxtPhone.Text.Trim())
                            cm.Parameters.AddWithValue("@role", CbRole.Text)
                            cm.Parameters.AddWithValue("@dob", DtDob.Value)
                            cm.Parameters.AddWithValue("@password", TxtPass.Text)
                            cm.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("User updated successfully!", title)
                    Clear()
                    userForm.LoadUser()
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If LblUid.Text = "" Then Exit Sub
        If MessageBox.Show("Are you sure to delete this user?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Using cn As MySqlConnection = GetConnection()
                cn.Open()
                Using cm As New MySqlCommand("DELETE FROM user WHERE id=@id", cn)
                    cm.Parameters.AddWithValue("@id", LblUid.Text)
                    cm.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("User deleted successfully!", title)
            Clear()
            userForm.LoadUser()
            Me.Dispose()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
    End Sub

    Private Sub CbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbRole.SelectedIndexChanged
        If CbRole.Text = "Employee" Then
            Lblpass.Visible = False
            TxtPass.Visible = False
            Me.Height = 427
        Else
            Lblpass.Visible = True
            TxtPass.Visible = True
            Me.Height = 453
        End If

    End Sub

#Region "Methods"


    Public Sub Clear()
        TxtName.Clear()
        TxtAddress.Clear()
        TxtPhone.Clear()
        TxtPass.Clear()
        CbRole.SelectedIndex = 0
        DtDob.Value = DateTime.Now

        BtnSave.Enabled = True
        BtnUpdate.Enabled = False
        BtnCancel.Enabled = False
        LblUid.Text = ""

    End Sub


    Public Sub CheckField()
        If TxtName.Text = "" Or TxtAddress.Text = "" Then
            MessageBox.Show("Required data field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            check = False
            Exit Sub
        End If


        If CheckAge(DtDob.Value) < 18 Then
            MessageBox.Show("User is under 18 years old!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            check = False
            Exit Sub
        End If

        check = True
    End Sub


    Private Function CheckAge(dob As DateTime) As Integer
        Dim age As Integer = DateTime.Now.Year - dob.Year
        If DateTime.Now.DayOfYear < dob.DayOfYear Then age -= 1
        Return age
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LblName_Click(sender As Object, e As EventArgs) Handles LblName.Click

    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged

    End Sub

    Private Sub LblAddress_Click(sender As Object, e As EventArgs) Handles LblAddress.Click

    End Sub

    Private Sub TxtAddress_TextChanged(sender As Object, e As EventArgs) Handles TxtAddress.TextChanged

    End Sub

    Private Sub LblPhone_Click(sender As Object, e As EventArgs) Handles LblPhone.Click

    End Sub

    Private Sub TxtPhone_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone.TextChanged

    End Sub

    Private Sub LblRole_Click(sender As Object, e As EventArgs) Handles LblRole.Click

    End Sub

    Private Sub LblDob_Click(sender As Object, e As EventArgs) Handles LblDob.Click

    End Sub

    Private Sub DtDob_ValueChanged(sender As Object, e As EventArgs) Handles DtDob.ValueChanged

    End Sub

#End Region
End Class