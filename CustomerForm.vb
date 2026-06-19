Imports MySql.Data.MySqlClient

Public Class CustomerForm
    Private cn As MySqlConnection
    Private cm As MySqlCommand
    Private dr As MySqlDataReader
    Private title As String = "Pet Shop Management System"

    Public Sub New()
        InitializeComponent()


        cn = DbConnection.GetConnection()
        DgvCustomer.AutoGenerateColumns = True




        AddHandler Me.Shown, Sub(sender, e) LoadCustomer()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        LoadCustomer()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim moduleForm As New CustomerModule(Me)
        moduleForm.ShowDialog()
        LoadCustomer()
    End Sub

    Private Sub DgvCustomer_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCustomer.CellDoubleClick
        If e.RowIndex >= 0 Then

            Dim moduleForm As New CustomerModule(Me)


            With DgvCustomer.Rows(e.RowIndex)
                moduleForm.LblCid.Text = .Cells("id").Value.ToString()
                moduleForm.TxtName.Text = .Cells("name").Value.ToString()
                moduleForm.TxtAddress.Text = .Cells("address").Value.ToString()
                moduleForm.TxtPhone.Text = .Cells("phone").Value.ToString()
            End With


            moduleForm.BtnSave.Enabled = False
            moduleForm.BtnUpdate.Enabled = True
            moduleForm.BtnDelete.Enabled = True

            moduleForm.ShowDialog()
        End If
    End Sub

#Region "Methods"

    Public Sub LoadCustomer()
        Try
            Dim dt As New DataTable()

            Using cn As MySqlConnection = GetConnection()
                cn.Open()

                Dim query As String =
                    "SELECT id, name, address, phone 
                     FROM customer
                     WHERE CONCAT(name,address,phone) LIKE @search"

                Using da As New MySqlDataAdapter(query, cn)
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" & TxtSearch.Text & "%")
                    da.Fill(dt)
                End Using
            End Using


            DgvCustomer.DataSource = Nothing
            DgvCustomer.AutoGenerateColumns = True
            DgvCustomer.DataSource = dt

            DgvCustomer.ReadOnly = True
            DgvCustomer.AllowUserToAddRows = False
            DgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Catch ex As Exception
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
End Class