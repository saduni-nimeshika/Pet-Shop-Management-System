<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCash = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUser = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PanelChile = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PanelDash = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Progress = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblDailySale = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDash.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1194, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 680)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(6, 680)
        Me.Panel5.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblTitle)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1194, 65)
        Me.Panel2.TabIndex = 1
        '
        'LblTitle
        '
        Me.LblTitle.Font = New System.Drawing.Font("Century", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(207, 10)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(903, 47)
        Me.LblTitle.TabIndex = 3
        Me.LblTitle.Text = "Welcome to Pet Shop Management System"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 30)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "PetCare+"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnClose.FillColor = System.Drawing.Color.Transparent
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(1152, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(30, 34)
        Me.BtnClose.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.BtnLogout)
        Me.Panel3.Controls.Add(Me.BtnCash)
        Me.Panel3.Controls.Add(Me.BtnProduct)
        Me.Panel3.Controls.Add(Me.BtnUser)
        Me.Panel3.Controls.Add(Me.BtnCustomer)
        Me.Panel3.Controls.Add(Me.BtnDashboard)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(194, 615)
        Me.Panel3.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 446)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(6, 112)
        Me.Panel6.TabIndex = 7
        '
        'BtnLogout
        '
        Me.BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLogout.FillColor = System.Drawing.Color.Transparent
        Me.BtnLogout.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.DimGray
        Me.BtnLogout.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnLogout.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), System.Drawing.Image)
        Me.BtnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnLogout.ImageOffset = New System.Drawing.Point(10, 0)
        Me.BtnLogout.Location = New System.Drawing.Point(0, 558)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(194, 57)
        Me.BtnLogout.TabIndex = 6
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnLogout.TextOffset = New System.Drawing.Point(10, 0)
        '
        'BtnCash
        '
        Me.BtnCash.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCash.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCash.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCash.FillColor = System.Drawing.Color.Transparent
        Me.BtnCash.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCash.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCash.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnCash.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnCash.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnCash.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.BtnCash.Image = CType(resources.GetObject("BtnCash.Image"), System.Drawing.Image)
        Me.BtnCash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnCash.ImageOffset = New System.Drawing.Point(10, 0)
        Me.BtnCash.Location = New System.Drawing.Point(0, 389)
        Me.BtnCash.Name = "BtnCash"
        Me.BtnCash.Size = New System.Drawing.Size(194, 57)
        Me.BtnCash.TabIndex = 5
        Me.BtnCash.Text = "Cash"
        Me.BtnCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnCash.TextOffset = New System.Drawing.Point(10, 0)
        '
        'BtnProduct
        '
        Me.BtnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProduct.FillColor = System.Drawing.Color.Transparent
        Me.BtnProduct.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProduct.ForeColor = System.Drawing.Color.DimGray
        Me.BtnProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnProduct.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnProduct.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnProduct.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.BtnProduct.Image = CType(resources.GetObject("BtnProduct.Image"), System.Drawing.Image)
        Me.BtnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnProduct.ImageOffset = New System.Drawing.Point(10, 0)
        Me.BtnProduct.Location = New System.Drawing.Point(0, 332)
        Me.BtnProduct.Name = "BtnProduct"
        Me.BtnProduct.Size = New System.Drawing.Size(194, 57)
        Me.BtnProduct.TabIndex = 4
        Me.BtnProduct.Text = "Product"
        Me.BtnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnProduct.TextOffset = New System.Drawing.Point(10, 0)
        '
        'BtnUser
        '
        Me.BtnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnUser.FillColor = System.Drawing.Color.Transparent
        Me.BtnUser.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUser.ForeColor = System.Drawing.Color.DimGray
        Me.BtnUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnUser.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnUser.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnUser.HoverState.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.BtnUser.Image = CType(resources.GetObject("BtnUser.Image"), System.Drawing.Image)
        Me.BtnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnUser.ImageOffset = New System.Drawing.Point(10, 0)
        Me.BtnUser.Location = New System.Drawing.Point(0, 275)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(194, 57)
        Me.BtnUser.TabIndex = 3
        Me.BtnUser.Text = "User"
        Me.BtnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnUser.TextOffset = New System.Drawing.Point(10, 0)
        '
        'BtnCustomer
        '
        Me.BtnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCustomer.FillColor = System.Drawing.Color.Transparent
        Me.BtnCustomer.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustomer.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnCustomer.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnCustomer.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnCustomer.HoverState.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.BtnCustomer.Image = CType(resources.GetObject("BtnCustomer.Image"), System.Drawing.Image)
        Me.BtnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnCustomer.ImageOffset = New System.Drawing.Point(10, 0)
        Me.BtnCustomer.Location = New System.Drawing.Point(0, 218)
        Me.BtnCustomer.Name = "BtnCustomer"
        Me.BtnCustomer.Size = New System.Drawing.Size(194, 57)
        Me.BtnCustomer.TabIndex = 2
        Me.BtnCustomer.Text = "Customers"
        Me.BtnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnCustomer.TextOffset = New System.Drawing.Point(10, 0)
        '
        'BtnDashboard
        '
        Me.BtnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.BtnDashboard.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.DimGray
        Me.BtnDashboard.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnDashboard.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.HoverState.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.BtnDashboard.Image = CType(resources.GetObject("BtnDashboard.Image"), System.Drawing.Image)
        Me.BtnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnDashboard.ImageOffset = New System.Drawing.Point(10, 0)
        Me.BtnDashboard.Location = New System.Drawing.Point(0, 161)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(194, 57)
        Me.BtnDashboard.TabIndex = 1
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnDashboard.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LblUser)
        Me.Panel4.Controls.Add(Me.LblUsername)
        Me.Panel4.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(194, 161)
        Me.Panel4.TabIndex = 0
        '
        'LblUser
        '
        Me.LblUser.Location = New System.Drawing.Point(21, 123)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(148, 30)
        Me.LblUser.TabIndex = 2
        Me.LblUser.Text = "role"
        Me.LblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUsername
        '
        Me.LblUsername.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(21, 84)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(148, 30)
        Me.LblUsername.TabIndex = 1
        Me.LblUsername.Text = "username"
        Me.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(62, 6)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(73, 66)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'PanelChile
        '
        Me.PanelChile.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelChile.Location = New System.Drawing.Point(194, 65)
        Me.PanelChile.Name = "PanelChile"
        Me.PanelChile.Size = New System.Drawing.Size(1000, 300)
        Me.PanelChile.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(194, 365)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1000, 6)
        Me.Panel8.TabIndex = 5
        '
        'PanelDash
        '
        Me.PanelDash.Controls.Add(Me.Panel11)
        Me.PanelDash.Controls.Add(Me.Panel9)
        Me.PanelDash.Controls.Add(Me.Panel7)
        Me.PanelDash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDash.Location = New System.Drawing.Point(194, 371)
        Me.PanelDash.Name = "PanelDash"
        Me.PanelDash.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelDash.Size = New System.Drawing.Size(1000, 309)
        Me.PanelDash.TabIndex = 6
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.PictureBox3)
        Me.Panel11.Controls.Add(Me.Label7)
        Me.Panel11.Controls.Add(Me.Label5)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(10, 10)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(718, 289)
        Me.Panel11.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(496, 123)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(145, 146)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(156, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(328, 38)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Shop Management Sysem"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(51, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 38)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "PetCare+"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(728, 10)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(6, 289)
        Me.Panel9.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Progress)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(734, 10)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(256, 289)
        Me.Panel7.TabIndex = 0
        '
        'Progress
        '
        Me.Progress.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Progress.FillOffset = 10
        Me.Progress.FillThickness = 10
        Me.Progress.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Progress.ForeColor = System.Drawing.Color.White
        Me.Progress.InnerColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Progress.Location = New System.Drawing.Point(62, 148)
        Me.Progress.Maximum = 59
        Me.Progress.Minimum = 0
        Me.Progress.Name = "Progress"
        Me.Progress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Progress.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Progress.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.Progress.ProgressOffset = 10
        Me.Progress.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.Progress.ProgressThickness = 10
        Me.Progress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Progress.ShowText = True
        Me.Progress.Size = New System.Drawing.Size(136, 136)
        Me.Progress.TabIndex = 22
        Me.Progress.Text = "00:00:00"
        Me.Progress.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom
        Me.Progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Progress.Value = 10
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Daily Report"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel10.Controls.Add(Me.PictureBox2)
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Controls.Add(Me.LblDailySale)
        Me.Panel10.Controls.Add(Me.Label4)
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Location = New System.Drawing.Point(3, 31)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(248, 113)
        Me.Panel10.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(66, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 40)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total daily sales recorded inventory"
        '
        'LblDailySale
        '
        Me.LblDailySale.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDailySale.ForeColor = System.Drawing.Color.White
        Me.LblDailySale.Location = New System.Drawing.Point(171, 10)
        Me.LblDailySale.Name = "LblDailySale"
        Me.LblDailySale.Size = New System.Drawing.Size(65, 21)
        Me.LblDailySale.TabIndex = 7
        Me.LblDailySale.Text = "0.00"
        Me.LblDailySale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(65, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Daliy Sales"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(55, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(4, 100)
        Me.Label3.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1200, 680)
        Me.Controls.Add(Me.PanelDash)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.PanelChile)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDash.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCash As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCustomer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblUser As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PanelChile As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PanelDash As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LblDailySale As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Progress As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
End Class
