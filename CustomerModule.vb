Imports MySql.Data.MySqlClient



Public Class CustomerModule
    Private cn As MySqlConnection
    Private cm As MySqlCommand

    Private title As String = "Pet Shop Management System"
    Private check As Boolean = False
    Private customerForm As CustomerForm




    Public Sub New(form As CustomerForm)
        InitializeComponent()


        cn = DbConnection.GetConnection()

        customerForm = form


        BtnSave.Enabled = True
        BtnUpdate.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            CheckField()
            If check Then
                If MessageBox.Show("Are you sure you want to register this customer?",
                                   "Customer Registration",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = DialogResult.Yes Then

                    Using cn As MySqlConnection = GetConnection()
                        cn.Open()
                        Using cm As New MySqlCommand(
                            "INSERT INTO customer(name,address,phone)
                             VALUES(@name,@address,@phone)", cn)

                            cm.Parameters.AddWithValue("@name", TxtName.Text.Trim())
                            cm.Parameters.AddWithValue("@address", TxtAddress.Text.Trim())
                            cm.Parameters.AddWithValue("@phone", TxtPhone.Text.Trim())

                            cm.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Customer successfully registered!", title)
                    Clear()
                    customerForm.LoadCustomer()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If LblCid.Text = "" Then Exit Sub

        Try
            CheckField()
            If check Then
                If MessageBox.Show("Are you sure you want to update this customer?",
                                   "Update Customer",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = DialogResult.Yes Then

                    Using cn As MySqlConnection = GetConnection()
                        cn.Open()
                        Using cm As New MySqlCommand(
                            "UPDATE customer 
                             SET name=@name, address=@address, phone=@phone
                             WHERE id=@id", cn)

                            cm.Parameters.AddWithValue("@id", LblCid.Text)
                            cm.Parameters.AddWithValue("@name", TxtName.Text.Trim())
                            cm.Parameters.AddWithValue("@address", TxtAddress.Text.Trim())
                            cm.Parameters.AddWithValue("@phone", TxtPhone.Text.Trim())

                            cm.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Customer updated successfully!", title)
                    customerForm.LoadCustomer()
                    Me.Dispose()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click


        If LblCid.Text = "" Then Exit Sub

        If MessageBox.Show("Are you sure you want to delete this customer?",
                           "Delete Customer",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then


            Try
                Using cn As MySqlConnection = GetConnection()
                    cn.Open()
                    Using cm As New MySqlCommand("DELETE FROM customer WHERE id=@id", cn)
                        cm.Parameters.AddWithValue("@id", LblCid.Text)
                        cm.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Customer deleted successfully!", title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                customerForm.LoadCustomer()
                Me.Dispose()


            Catch ex As MySqlException

                If ex.Number = 1451 Then
                    MessageBox.Show("Cannot delete this customer because they have past purchase records (Bills) in the system!",
                                    "Deletion Blocked",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning)
                Else

                    MessageBox.Show("Database Error: " & ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception

                MessageBox.Show("An unexpected error occurred: " & ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

#Region "Methods"




    Public Sub Clear()
        TxtName.Clear()
        TxtAddress.Clear()
        TxtPhone.Clear()

        BtnSave.Enabled = True
        BtnUpdate.Enabled = False
        BtnDelete.Enabled = False

        LblCid.Text = ""
        check = False
    End Sub




    Public Sub CheckField()
        If TxtName.Text = "" Or TxtAddress.Text = "" Or TxtPhone.Text = "" Then
            MessageBox.Show("Required data field!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            check = False
            Exit Sub
        End If

        If TxtPhone.Text.Length <> 10 Then
        MessageBox.Show("Phone number must contain exactly 10 digits!",
                        "Invalid Phone Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
        TxtPhone.Focus()
        check = False
        Exit Sub
    End If

    check = True
    End sub

#End Region
End Class