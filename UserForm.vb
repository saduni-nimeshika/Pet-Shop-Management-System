
Imports MySql.Data.MySqlClient
Public Class UserForm
    Private cn As MySqlConnection
    Private cm As MySqlCommand
    Private dr As MySqlDataReader
    Private title As String = "Pet Shop Management System"

    Public Sub New()
        InitializeComponent()


        cn = DbConnection.GetConnection()
        Dgv.AutoGenerateColumns = True




        AddHandler Me.Shown, Sub(sender, e) LoadUser()
    End Sub



    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim moduleForm As New UserModule(Me)
        moduleForm.ShowDialog()
        LoadUser()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        LoadUser()
    End Sub


    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub

    Private Sub Dgv_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentDoubleClick

    End Sub

    Private Sub Dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim um As New UserModule(Me)


            um.LblUid.Text = Dgv.Rows(e.RowIndex).Cells("id").Value.ToString()
            um.TxtName.Text = Dgv.Rows(e.RowIndex).Cells("name").Value.ToString()
            um.TxtAddress.Text = Dgv.Rows(e.RowIndex).Cells("address").Value.ToString()
            um.TxtPhone.Text = Dgv.Rows(e.RowIndex).Cells("phone").Value.ToString()
            um.CbRole.Text = Dgv.Rows(e.RowIndex).Cells("role").Value.ToString()
            um.DtDob.Value = Convert.ToDateTime(Dgv.Rows(e.RowIndex).Cells("dob").Value)


            um.BtnUpdate.Enabled = True
            um.BtnCancel.Enabled = True
            um.BtnSave.Enabled = False

            um.ShowDialog()
        End If
    End Sub

#Region "Methods"

    Public Sub LoadUser()
        Try
            Dim dt As New DataTable()


            Using cn As MySqlConnection = GetConnection()
                cn.Open()

                Dim query As String = "SELECT id, name, address, phone, role, dob, password FROM user WHERE CONCAT(name,address,phone,dob,role) LIKE @search"
                Using adapter As New MySqlDataAdapter(query, cn)
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & TxtSearch.Text & "%")
                    adapter.Fill(dt)
                End Using
            End Using


            If Not dt.Columns.Contains("No") Then
                dt.Columns.Add("No", GetType(Integer))
            End If
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("No") = i + 1
            Next


            Dgv.DataSource = Nothing
            Dgv.DataSource = dt


            If Dgv.Columns.Contains("id") Then Dgv.Columns("id").Visible = False
            If Dgv.Columns.Contains("password") Then Dgv.Columns("password").Visible = False
            If Dgv.Columns.Contains("No") Then Dgv.Columns("No").DisplayIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Pet Shop Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
#End Region
End Class