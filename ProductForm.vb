
Imports MySql.Data.MySqlClient
Public Class ProductForm
    Private cn As MySqlConnection
    Private cm As MySqlCommand
    Private dr As MySqlDataReader
    Private title As String = "Pet Shop Management System"

    Public Sub New()
        InitializeComponent()


        cn = DbConnection.GetConnection()


        DgvProduct.AutoGenerateColumns = True




        AddHandler Me.Shown, Sub(sender, e) LoadProduct()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim moduleForm As New ProductModule(Me)
        moduleForm.ShowDialog()
        LoadProduct()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        LoadProduct()
    End Sub

    Private Sub DgvProduct_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProduct.CellDoubleClick
        If e.RowIndex >= 0 Then

            Dim moduleForm As New ProductModule(Me)


            With DgvProduct.Rows(e.RowIndex)
                moduleForm.LblPcode.Text = .Cells("pcode").Value.ToString()
                moduleForm.TxtName.Text = .Cells("pname").Value.ToString()
                moduleForm.TxtType.Text = .Cells("ptype").Value.ToString()
                moduleForm.CbCategory.Text = .Cells("pcategory").Value.ToString()
                moduleForm.TxtQty.Text = .Cells("qty").Value.ToString()
                moduleForm.TxtPrice.Text = .Cells("price").Value.ToString()
            End With


            moduleForm.BtnSave.Enabled = False
            moduleForm.BtnUpdate.Enabled = True
            moduleForm.BtnDelete.Enabled = True

            moduleForm.ShowDialog()
        End If

    End Sub
#Region "Methods"

    Public Sub LoadProduct()
        Try
            Dim dt As New DataTable()


            Using cn As MySqlConnection = GetConnection()
                cn.Open()

                Dim query As String =
                    "SELECT pcode, pname, ptype, pcategory, qty, price 
                 FROM product
                 WHERE CONCAT(pname,ptype,pcategory) LIKE @search"

                Using da As New MySqlDataAdapter(query, cn)
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" & TxtSearch.Text & "%")
                    da.Fill(dt)
                End Using
            End Using

            DgvProduct.DataSource = Nothing
            DgvProduct.AutoGenerateColumns = True
            DgvProduct.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

End Class