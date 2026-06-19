Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class CashProduct


    Private cn As MySqlConnection
    Private cm As MySqlCommand
    Private dr As MySqlDataReader
    Private title As String = "Pet Shop Management System"
    Public uname As String
    Private cash As CashForm



    Public Sub New(form As CashForm)
        InitializeComponent()

        cn = DbConnection.GetConnection()
        cash = form


        DgvProduct.AutoGenerateColumns = True
        DgvProduct.AllowUserToAddRows = False
        DgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        Dim chk As New DataGridViewCheckBoxColumn()
        chk.Name = "Select"
        chk.HeaderText = ""
        DgvProduct.Columns.Insert(0, chk)

        LoadProduct()

    End Sub



    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        LoadProduct()
    End Sub



    Private Sub BtnCash_Click(sender As Object, e As EventArgs) Handles BtnCash.Click




        For Each row As DataGridViewRow In DgvProduct.Rows
            Dim chkbox As Boolean = Convert.ToBoolean(row.Cells("Select").Value)
            If chkbox Then
                Try
                    Using cn As MySqlConnection = DbConnection.GetConnection()
                        cn.Open()
                        cm = New MySqlCommand("INSERT INTO cash(transno, pcode, pname, qty, price, cashier) " &
                                              "VALUES (@transno, @pcode, @pname, @qty, @price, @cashier)", cn)
                        cm.Parameters.AddWithValue("@transno", cash.LblTransno.Text)
                        cm.Parameters.AddWithValue("@pcode", row.Cells("pcode").Value.ToString())
                        cm.Parameters.AddWithValue("@pname", row.Cells("pname").Value.ToString())
                        cm.Parameters.AddWithValue("@qty", 1)
                        cm.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells("price").Value))
                        cm.Parameters.AddWithValue("@cashier", uname)
                        cm.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message, title)
                End Try
            End If
        Next

        cash.LoadCash()
        Me.Dispose()
    End Sub


#Region "Methods"


    Public Sub LoadProduct()
        Try
            Using cn As MySqlConnection = DbConnection.GetConnection()
                cn.Open()
                Dim query As String = "SELECT pcode, pname, ptype, pcategory, price FROM product " &
                                      "WHERE CONCAT(pname, ptype, pcategory) LIKE @search AND qty > 0"
                cm = New MySqlCommand(query, cn)
                cm.Parameters.AddWithValue("@search", "%" & TxtSearch.Text & "%")
                Dim da As New MySqlDataAdapter(cm)
                Dim dt As New DataTable()
                da.Fill(dt)

                DgvProduct.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, title)
        End Try
    End Sub

#End Region


End Class