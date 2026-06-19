
Imports MySql.Data.MySqlClient


Public Class MainForm
    Private cn As MySqlConnection
    Private cm As MySqlCommand



    Private WithEvents uiTimer As New Timer()
    Public Sub New()


        InitializeComponent()



        cn = DbConnection.GetConnection()


        uiTimer.Interval = 1000
        uiTimer.Start()

        BtnDashboard.PerformClick()
        LoadDailySale()



    End Sub
    Private Sub PanelDash_Paint(sender As Object, e As PaintEventArgs) Handles PanelDash.Paint

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        If MessageBox.Show("Exit Application?",
                          "Confirm",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        openChildForm(New UserForm())
    End Sub



    Private Sub BtnProduct_Click(sender As Object, e As EventArgs) Handles BtnProduct.Click
        openChildForm(New ProductForm())
    End Sub

    Private Sub BtnCash_Click(sender As Object, e As EventArgs) Handles BtnCash.Click
        openChildForm(New CashForm(Me))
    End Sub

    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles BtnCustomer.Click
        openChildForm(New CustomerForm())
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        openChildForm(New Dashbord())
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If MessageBox.Show("Logout Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim login As New LoginForm()
            Me.Dispose()
            login.ShowDialog()
        End If
    End Sub


    Private Sub uiTimer_Tick(sender As Object, e As EventArgs) Handles uiTimer.Tick

        Progress.Text = DateTime.Now.ToString("hh:mm:ss")
        Progress.Value = DateTime.Now.Second
    End Sub



#Region "METHODS"


    Private activeForm As Form = Nothing

    Public Sub openChildForm(childForm As Form)
        If activeForm IsNot Nothing Then
            activeForm.Close()
        End If

        activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        LblTitle.Text = childForm.Text

        PanelChile.Controls.Clear()
        PanelChile.Controls.Add(childForm)
        PanelChile.Tag = childForm

        childForm.BringToFront()
        childForm.Show()
    End Sub



    Public Sub LoadDailySale()
        Dim sdate As String = DateTime.Now.ToString("yyyyMMdd")

        Try
            Using cn As MySqlConnection = DbConnection.GetConnection()
                cn.Open()

                Dim query As String =
                    "SELECT IFNULL(SUM(total),0) FROM cash WHERE transno LIKE @sdate"

                Using cm As New MySqlCommand(query, cn)
                    cm.Parameters.AddWithValue("@sdate", sdate & "%")
                    LblDailySale.Text =
                        Convert.ToDouble(cm.ExecuteScalar()).ToString("#,##0.00")
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


#End Region
End Class