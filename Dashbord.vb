
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient



Public Class Dashbord

    Private cn As MySqlConnection
    Private cm As MySqlCommand
    Private dr As MySqlDataReader
    Private title As String = "Pet Shop Management System"


    Public Sub New()
        InitializeComponent()
        cn = DbConnection.GetConnection()

    End Sub
    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub LblDog_Click(sender As Object, e As EventArgs) Handles LblDog.Click

    End Sub

#Region "Method"
    Public Function ExtractData(ByVal category As String) As Integer
        Dim data As Integer = 0

        Try
            Using cn As MySqlConnection = DbConnection.GetConnection()
                cn.Open()

                Dim query As String =
                        "SELECT IFNULL(SUM(qty),0) FROM product WHERE pcategory = @pcategory"

                Using cm As New MySqlCommand(query, cn)
                    cm.Parameters.AddWithValue("@pcategory", category)
                    data = Convert.ToInt32(cm.ExecuteScalar())
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return data
    End Function

    Private Sub Dashbord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblDog.Text = ExtractData("Dog").ToString()
        LblCat.Text = ExtractData("Cat").ToString()
        LblBird.Text = ExtractData("Bird").ToString()
        LblFish.Text = ExtractData("Fish").ToString()
    End Sub

#End Region
End Class