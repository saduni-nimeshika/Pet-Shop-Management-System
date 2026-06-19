
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient



Public Class CashForm



    Private cn As MySqlConnection
    Private cm As MySqlCommand
    Private dr As MySqlDataReader

    Private title As String = "Pet Shop Management System"
    Private main As MainForm


    Public CustomerId As Integer = 0
    Public Sub New(form As MainForm)
        InitializeComponent()

        cn = DbConnection.GetConnection()


        main = form

        DgvCash.AutoGenerateColumns = True
        DgvCash.AllowUserToAddRows = False


        DgvCash.ReadOnly = False

        GetTransno()
        LoadCash()



    End Sub




    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub



    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim product As New CashProduct(Me)
        product.uname = main.LblUsername.Text
        product.ShowDialog()
    End Sub

    Private Sub BtnCash_Click(sender As Object, e As EventArgs) Handles BtnCash.Click


        If DgvCash.Rows.Count = 0 Then
            MessageBox.Show("Please add products to the cart before cashing!", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim customer As New CashCustomer(Me)
        customer.ShowDialog()


        If CustomerId = 0 Then
            MessageBox.Show("Transaction cancelled! No customer was selected.", "Customer Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cash this product?", "Cashing", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then



            Exit Sub
        End If


        Dim grandTotal As Decimal = 0
        Using cn As MySqlConnection = DbConnection.GetConnection()
            cn.Open()
            For Each row As DataGridViewRow In DgvCash.Rows
                If Not row.IsNewRow Then
                    Dim pcode As Integer = Convert.ToInt32(row.Cells("pcode").Value)
                    Dim qty As Integer = Convert.ToInt32(row.Cells("qty").Value)
                    Dim price As Decimal = Convert.ToDecimal(row.Cells("price").Value)
                    Dim total As Decimal = qty * price
                    grandTotal += total


                    Using cm As New MySqlCommand("UPDATE cash SET cid=@cid, total=@total WHERE transno=@transno AND pcode=@pcode", cn)
                        cm.Parameters.AddWithValue("@cid", CustomerId)
                        cm.Parameters.AddWithValue("@total", total)
                        cm.Parameters.AddWithValue("@transno", LblTransno.Text)
                        cm.Parameters.AddWithValue("@pcode", pcode)
                        cm.ExecuteNonQuery()
                    End Using


                    Using cm As New MySqlCommand("UPDATE product SET qty = qty - @qty WHERE pcode=@pcode", cn)
                        cm.Parameters.AddWithValue("@qty", qty)
                        cm.Parameters.AddWithValue("@pcode", pcode)
                        cm.ExecuteNonQuery()
                    End Using
                End If
            Next
        End Using


        LoadCash()
        GenerateBill(grandTotal)


        DgvCash.DataSource = Nothing
        LblTotal.Text = "0.00"
        CustomerId = 0
        GetTransno()
        main.LoadDailySale()

    End Sub



    Private Sub DgvCash_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCash.CellContentClick

    End Sub

#Region "Methods"

    Public Sub GetTransno()
        Try
            Dim sdate As String = DateTime.Now.ToString("yyyyMMdd")
            Dim transno As String = ""


            Using cn As MySqlConnection = DbConnection.GetConnection()
                cn.Open()
                cm = New MySqlCommand("SELECT transno FROM cash WHERE transno LIKE @sdate ORDER BY cashid DESC LIMIT 1", cn)
                cm.Parameters.AddWithValue("@sdate", sdate & "%")
                dr = cm.ExecuteReader()
                If dr.Read() Then
                    transno = dr("transno").ToString()
                    Dim count As Integer = Convert.ToInt32(transno.Substring(8, 4))
                    LblTransno.Text = sdate & (count + 1).ToString()
                Else
                    LblTransno.Text = sdate & "1001"
                End If
                dr.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, title)
        End Try

    End Sub


    Public Sub LoadCash()
        Try
            Using cn As MySqlConnection = DbConnection.GetConnection()
                cn.Open()
                Dim query As String =
               "SELECT cashid, pcode, pname, qty, price,
                      (qty * price) AS total,
                 c.name AS customer, cashier
                 FROM Cash AS cash
                 LEFT JOIN customer c ON cash.cid = c.id
                WHERE transno = @transno"

                Using cm As New MySqlCommand(query, cn)
                    cm.Parameters.AddWithValue("@transno", LblTransno.Text)

                    Dim da As New MySqlDataAdapter(cm)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    DgvCash.DataSource = dt


                    For Each col As DataGridViewColumn In DgvCash.Columns
                        col.ReadOnly = True
                    Next


                    If DgvCash.Columns.Contains("qty") Then
                        DgvCash.Columns("qty").ReadOnly = False

                        DgvCash.Columns("qty").DefaultCellStyle.BackColor = Color.LightYellow
                    End If



                    Dim totalProducts As Decimal = 0
                    For Each row As DataRow In dt.Rows
                        totalProducts += Convert.ToDecimal(row("total"))
                    Next
                    LblTotal.Text = totalProducts.ToString("#,##0.00")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, title)
        End Try
    End Sub


    Public Function Checkqty(pcode As String) As Integer
        Dim qty As Integer = 0
        Try
            Using cn As MySqlConnection = DbConnection.GetConnection()
                cn.Open()
                cm = New MySqlCommand("SELECT qty FROM product WHERE pcode = @pcode", cn)
                cm.Parameters.AddWithValue("@pcode", pcode)
                qty = Convert.ToInt32(cm.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, title)
        End Try
        Return qty
    End Function


    Public Sub GenerateBill(grandTotal As Decimal)
        Try
            Dim cname As String = "Walk-in Customer"
            Dim cphone As String = "N/A"


            Using cn As MySqlConnection = DbConnection.GetConnection()
                cn.Open()
                Using cm As New MySqlCommand("SELECT name, phone FROM customer WHERE id=@cid", cn)
                    cm.Parameters.AddWithValue("@cid", CustomerId)
                    Using dr As MySqlDataReader = cm.ExecuteReader()
                        If dr.Read() Then
                            cname = dr("name").ToString()
                            cphone = dr("phone").ToString()
                        End If
                    End Using
                End Using
            End Using


            Dim html As String = "<html><head><style>" &
            "body { font-family: Arial, sans-serif; margin: 30px; color: #333; }" &
            ".header { border-bottom: 2px solid #2b2d42; padding-bottom: 10px; margin-bottom: 20px; }" &
            ".title { font-size: 22pt; font-weight: bold; color: #2b2d42; text-transform: uppercase; }" &
            ".meta-table { width: 100%; margin-bottom: 20px; font-size: 11pt; }" &
            ".items-table { width: 100%; border-collapse: collapse; margin-top: 20px; }" &
            ".items-table th { background-color: #2b2d42; color: white; padding: 10px; text-align: left; }" &
            ".items-table td { padding: 10px; border-bottom: 1px solid #ddd; }" &
            ".total-box { float: right; width: 40%; background: #f8f9fa; border: 1px solid #2b2d42; padding: 15px; margin-top: 20px; text-align: right; }" &
            ".total-label { font-size: 12pt; font-weight: bold; }" &
            ".total-amount { font-size: 16pt; font-weight: bold; color: #d90429; margin-top: 5px; }" &
            ".footer { margin-top: 50px; text-align: center; font-size: 10pt; color: #777; border-top: 1px dashed #ccc; padding-top: 10px; }" &
            "</style></head><body>"


            html &= "<div class='header'><div class='title'>Pet Shop Management System</div>" &
                "<div style='color:#666;'>Premium Pet Products & Services</div></div>"


            html &= "<table class='meta-table'><tr>" &
                "<td><strong>BILL TO:</strong><br>Name: " & cname & "<br>Phone: " & cphone & "</td>" &
                "<td style='text-align:right;'><strong>Invoice No:</strong> " & LblTransno.Text & "<br>" &
                "<strong>Date:</strong> " & DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt") & "</td>" &
                "</tr></table>"

            html &= "<table class='items-table'><thead><tr>" &
                "<th>Product Name</th><th style='text-align:center;'>Qty</th><th style='text-align:right;'>Price</th><th style='text-align:right;'>Total</th>" &
                "</tr></thead><tbody>"

            For Each row As DataGridViewRow In DgvCash.Rows
                If Not row.IsNewRow Then
                    Dim pname As String = row.Cells("pname").Value.ToString()
                    Dim qty As Integer = Convert.ToInt32(row.Cells("qty").Value)
                    Dim price As Decimal = Convert.ToDecimal(row.Cells("price").Value)
                    Dim total As Decimal = qty * price

                    html &= "<tr>" &
                        "<td>" & pname & "</td>" &
                        "<td style='text-align:center;'>" & qty & "</td>" &
                        "<td style='text-align:right;'> " & price.ToString("#,##0.00") & "</td>" &
                        "<td style='text-align:right;'> " & total.ToString("#,##0.00") & "</td>" &
                        "</tr>"
                End If
            Next

            html &= "</tbody></table>"


            html &= "<div class='total-box'>" &
                "<div class='total-label'>GRAND TOTAL</div>" &
                "<div class='total-amount'>LKR " & grandTotal.ToString("#,##0.00") & "</div>" &
                "</div><div style='clear:both;'></div>"


            html &= "<div class='footer'><p>Thank you for your business! Come again.</p></div></body></html>"


            Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\PetShop_Invoices\"
            If Not System.IO.Directory.Exists(folderPath) Then
                System.IO.Directory.CreateDirectory(folderPath)
            End If

            Dim pdfPath As String = folderPath & LblTransno.Text & ".pdf"


            Dim tempHtmlPath As String = Path.Combine(Path.GetTempPath(), LblTransno.Text & ".html")
            File.WriteAllText(tempHtmlPath, html)


            Dim p As New Process()

            Dim edgePath As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\Microsoft\Edge\Application\msedge.exe"

            If Not File.Exists(edgePath) Then
                edgePath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\Microsoft\Edge\Application\msedge.exe"
            End If

            p.StartInfo.FileName = edgePath
            p.StartInfo.Arguments = "--headless --disable-gpu --print-to-pdf=""" & pdfPath & """ """ & tempHtmlPath & """"
            p.StartInfo.CreateNoWindow = True
            p.StartInfo.UseShellExecute = False
            p.Start()
            p.WaitForExit()


            MessageBox.Show("Bill Generated and Saved to Documents Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(pdfPath)


            DgvCash.DataSource = Nothing
            LoadCash()
        Catch ex As Exception
            MessageBox.Show("Error generating PDF Bill: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DgvCash_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DgvCash.CellValidating

        If DgvCash.DataSource Is Nothing Then Return

        If DgvCash.Columns(e.ColumnIndex).Name = "qty" Then
            Dim newValue As String = e.FormattedValue.ToString()


            If String.IsNullOrWhiteSpace(newValue) Then Return

            Dim newQty As Integer

            If Not Integer.TryParse(newValue, newQty) OrElse newQty <= 0 Then
                MessageBox.Show("Invalid Quantity! Please enter a valid whole number greater than 0. Letters or symbols are not allowed.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                e.Cancel = True
                Return
            End If
        End If
    End Sub

    Private Sub DgvCash_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCash.CellEndEdit
        If DgvCash.DataSource Is Nothing OrElse e.RowIndex < 0 Then Return

        If DgvCash.Columns(e.ColumnIndex).Name = "qty" Then
            Try
                Dim val As Object = DgvCash.Rows(e.RowIndex).Cells("qty").Value
                If val Is Nothing OrElse String.IsNullOrWhiteSpace(val.ToString()) Then Return

                Dim cashid As String = DgvCash.Rows(e.RowIndex).Cells("cashid").Value.ToString()
                Dim pcode As String = DgvCash.Rows(e.RowIndex).Cells("pcode").Value.ToString()
                Dim newQty As Integer = Convert.ToInt32(val)


                Dim availableStock As Integer = Checkqty(pcode)

                If availableStock >= newQty Then
                    Using cn As MySqlConnection = DbConnection.GetConnection()
                        cn.Open()
                        Using cm As New MySqlCommand("UPDATE cash SET qty = @qty WHERE cashid = @cashid", cn)
                            cm.Parameters.AddWithValue("@qty", newQty)
                            cm.Parameters.AddWithValue("@cashid", cashid)
                            cm.ExecuteNonQuery()
                        End Using
                    End Using
                Else
                    MessageBox.Show("Sorry, insufficient stock! Available stock: " & availableStock, title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, title)
            Finally

                LoadCash()
            End Try
        End If
    End Sub


    Private Sub DgvCash_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DgvCash.EditingControlShowing
        If DgvCash.CurrentCell.OwningColumn.Name = "qty" Then
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                RemoveHandler textBox.KeyPress, AddressOf Qty_KeyPress
                AddHandler textBox.KeyPress, AddressOf Qty_KeyPress
            End If
        End If
    End Sub

    Private Sub Qty_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub




#End Region

    Private Sub DgvCash_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DgvCash.DataError
        e.Cancel = True
    End Sub



End Class
