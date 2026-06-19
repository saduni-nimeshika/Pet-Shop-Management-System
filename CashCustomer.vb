

Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class CashCustomer



    Private cn As MySqlConnection
    Private cm As MySqlCommand
    Private dr As MySqlDataReader
    Private title As String = "Pet Shop Management System"
    Private cash As CashForm

    Public Sub New(form As CashForm)
        InitializeComponent()
        cn = DbConnection.GetConnection()
        cash = form

        DgvCustomer.AutoGenerateColumns = True
        DgvCustomer.AllowUserToAddRows = False
        DgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        If DgvCustomer.Columns.Contains("Select") = False Then
            Dim btn As New DataGridViewButtonColumn()
            btn.Name = "Select"
            btn.HeaderText = ""
            btn.Text = "Select"
            btn.UseColumnTextForButtonValue = True
            btn.Width = 70


            DgvCustomer.Columns.Insert(0, btn)
        End If
        LoadCustomer()
    End Sub


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        LoadCustomer()
    End Sub


    Private Sub DgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCustomer.CellContentClick
        If e.RowIndex < 0 OrElse DgvCustomer.Columns(e.ColumnIndex).Name <> "Select" Then Exit Sub
        cash.CustomerId = Convert.ToInt32(DgvCustomer.Rows(e.RowIndex).Cells("id").Value)
        Me.Close()
    End Sub










#Region "Methods"


    Public Sub LoadCustomer()
        Try
            Using cn As MySqlConnection = DbConnection.GetConnection()
                cn.Open()
                Dim query As String = "SELECT * FROM customer WHERE name LIKE @search"
                cm = New MySqlCommand(query, cn)
                cm.Parameters.AddWithValue("@search", "%" & Guna2TextBox1.Text & "%")

                Dim da As New MySqlDataAdapter(cm)
                Dim dt As New DataTable()
                da.Fill(dt)


                DgvCustomer.DataSource = dt

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, title)
        End Try

    End Sub

#End Region

End Class