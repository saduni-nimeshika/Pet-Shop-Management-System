<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserModule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserModule))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblRole = New System.Windows.Forms.Label()
        Me.LblDob = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Lblpass = New System.Windows.Forms.Label()
        Me.LblUid = New System.Windows.Forms.Label()
        Me.CbRole = New System.Windows.Forms.ComboBox()
        Me.DtDob = New System.Windows.Forms.DateTimePicker()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 16)
        Me.Panel1.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Registration"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(4, 75)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(69, 21)
        Me.LblName.TabIndex = 2
        Me.LblName.Text = "Name:"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(139, 71)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(540, 28)
        Me.TxtName.TabIndex = 3
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(139, 124)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(540, 28)
        Me.TxtAddress.TabIndex = 5
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddress.Location = New System.Drawing.Point(4, 130)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(85, 21)
        Me.LblAddress.TabIndex = 4
        Me.LblAddress.Text = "Address:"
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(139, 177)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(540, 28)
        Me.TxtPhone.TabIndex = 7
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhone.Location = New System.Drawing.Point(4, 185)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(72, 21)
        Me.LblPhone.TabIndex = 6
        Me.LblPhone.Text = "Phone:"
        '
        'LblRole
        '
        Me.LblRole.AutoSize = True
        Me.LblRole.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRole.Location = New System.Drawing.Point(4, 240)
        Me.LblRole.Name = "LblRole"
        Me.LblRole.Size = New System.Drawing.Size(53, 21)
        Me.LblRole.TabIndex = 8
        Me.LblRole.Text = "Role:"
        '
        'LblDob
        '
        Me.LblDob.AutoSize = True
        Me.LblDob.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDob.Location = New System.Drawing.Point(4, 295)
        Me.LblDob.Name = "LblDob"
        Me.LblDob.Size = New System.Drawing.Size(127, 21)
        Me.LblDob.TabIndex = 10
        Me.LblDob.Text = "Date Of Birth:"
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(141, 337)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(540, 28)
        Me.TxtPass.TabIndex = 13
        '
        'Lblpass
        '
        Me.Lblpass.AutoSize = True
        Me.Lblpass.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpass.Location = New System.Drawing.Point(4, 344)
        Me.Lblpass.Name = "Lblpass"
        Me.Lblpass.Size = New System.Drawing.Size(95, 21)
        Me.Lblpass.TabIndex = 12
        Me.Lblpass.Text = "Password:"
        '
        'LblUid
        '
        Me.LblUid.AutoSize = True
        Me.LblUid.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUid.Location = New System.Drawing.Point(12, 395)
        Me.LblUid.Name = "LblUid"
        Me.LblUid.Size = New System.Drawing.Size(36, 21)
        Me.LblUid.TabIndex = 14
        Me.LblUid.Text = "uid"
        Me.LblUid.Visible = False
        '
        'CbRole
        '
        Me.CbRole.FormattingEnabled = True
        Me.CbRole.Items.AddRange(New Object() {"Administrator", "Cashier", "Employee"})
        Me.CbRole.Location = New System.Drawing.Point(139, 230)
        Me.CbRole.Name = "CbRole"
        Me.CbRole.Size = New System.Drawing.Size(540, 29)
        Me.CbRole.TabIndex = 15
        '
        'DtDob
        '
        Me.DtDob.Location = New System.Drawing.Point(140, 284)
        Me.DtDob.Name = "DtDob"
        Me.DtDob.Size = New System.Drawing.Size(540, 28)
        Me.DtDob.TabIndex = 16
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(139, 383)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(168, 45)
        Me.BtnSave.TabIndex = 17
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(324, 383)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(168, 45)
        Me.BtnUpdate.TabIndex = 18
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Silver
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(509, 383)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(168, 45)
        Me.BtnCancel.TabIndex = 19
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
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
        Me.BtnClose.Location = New System.Drawing.Point(666, 10)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(30, 34)
        Me.BtnClose.TabIndex = 20
        '
        'UserModule
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(702, 445)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.DtDob)
        Me.Controls.Add(Me.CbRole)
        Me.Controls.Add(Me.LblUid)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.Lblpass)
        Me.Controls.Add(Me.LblDob)
        Me.Controls.Add(Me.LblRole)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.LblPhone)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserModule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Lblpass As Label
    Friend WithEvents LblDob As Label
    Friend WithEvents LblRole As Label
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents LblPhone As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents LblAddress As Label
    Friend WithEvents DtDob As DateTimePicker
    Friend WithEvents CbRole As ComboBox
    Friend WithEvents LblUid As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
End Class
