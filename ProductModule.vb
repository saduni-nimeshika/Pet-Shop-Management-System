
Imports MySql.Data.MySqlClient
Public Class ProductModule
    Private cn As MySqlConnection
    Private cm As MySqlCommand

    Private title As String = "Pet Shop Management System"
    Private check As Boolean = False
    Private productForm As ProductForm


    Public Sub New(form As ProductForm)
        InitializeComponent()


        cn = DbConnection.GetConnection()


        productForm = form


        CbCategory.SelectedIndex = 0


        BtnSave.Enabled = True
        BtnUpdate.Enabled = False
        BtnDelete.Enabled = False
    End Sub
    Private Sub DtDob_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            CheckField()
            If check Then
                If MessageBox.Show("Are you sure you want to register this product?",
                                   "Product Registration",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = DialogResult.Yes Then


                    Using cn As MySqlConnection = GetConnection()
                        cn.Open()
                        Using cm As New MySqlCommand(
                            "INSERT INTO product(pname,ptype,pcategory,qty,price)
                             VALUES(@pname,@ptype,@pcategory,@qty,@price)", cn)

                            cm.Parameters.AddWithValue("@pname", TxtName.Text.Trim())
                            cm.Parameters.AddWithValue("@ptype", TxtType.Text.Trim())
                            cm.Parameters.AddWithValue("@pcategory", CbCategory.Text)
                            cm.Parameters.AddWithValue("@qty", Integer.Parse(TxtQty.Text))
                            cm.Parameters.AddWithValue("@price", Double.Parse(TxtPrice.Text))

                            cm.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Product successfully registered!", title)
                    Clear()
                    productForm.LoadProduct()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If LblPcode.Text = "" Then Exit Sub

        Try
            CheckField()
            If check Then
                If MessageBox.Show("Are you sure you want to update this product?",
                                   "Update Product",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = DialogResult.Yes Then

                    Using cn As MySqlConnection = GetConnection()
                        cn.Open()
                        Using cm As New MySqlCommand(
                            "UPDATE product 
                             SET pname=@pname, ptype=@ptype, pcategory=@pcategory, qty=@qty, price=@price
                             WHERE pcode=@pcode", cn)

                            cm.Parameters.AddWithValue("@pcode", LblPcode.Text)
                            cm.Parameters.AddWithValue("@pname", TxtName.Text.Trim())
                            cm.Parameters.AddWithValue("@ptype", TxtType.Text.Trim())
                            cm.Parameters.AddWithValue("@pcategory", CbCategory.Text)
                            cm.Parameters.AddWithValue("@qty", Integer.Parse(TxtQty.Text))
                            cm.Parameters.AddWithValue("@price", Double.Parse(TxtPrice.Text))

                            cm.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Product updated successfully!", title)
                    productForm.LoadProduct()
                    Me.Dispose()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If LblPcode.Text = "" Then Exit Sub

        If MessageBox.Show("Are you sure you want to delete this product?",
                           "Delete Product",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then

            Using cn As MySqlConnection = GetConnection()
                cn.Open()
                Using cm As New MySqlCommand(
                    "DELETE FROM product WHERE pcode=@pcode", cn)

                    cm.Parameters.AddWithValue("@pcode", LblPcode.Text)
                    cm.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Product deleted successfully!", title)
            productForm.LoadProduct()
            Me.Dispose()
        End If
    End Sub

    Private Sub TxtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQty.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrice.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso
                  Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso TxtPrice.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

#Region "Methods"

    Public Sub Clear()
        TxtName.Clear()
        TxtType.Clear()
        TxtQty.Clear()
        TxtPrice.Clear()
        CbCategory.SelectedIndex = 0


        BtnSave.Enabled = True
        BtnUpdate.Enabled = False
        BtnDelete.Enabled = False

        LblPcode.Text = ""
        check = False
    End Sub

    Public Sub CheckField()
        If TxtName.Text = "" Or TxtType.Text = "" Or TxtQty.Text = "" Or TxtPrice.Text = "" Then
            MessageBox.Show("Required data field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            check = False
            Exit Sub
        End If
        check = True
    End Sub

#End Region
End Class