<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductModule))
        Me.BtnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.CbCategory = New System.Windows.Forms.ComboBox()
        Me.LblPcode = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.LblQty = New System.Windows.Forms.Label()
        Me.TxtQty = New System.Windows.Forms.TextBox()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.TxtType = New System.Windows.Forms.TextBox()
        Me.LblType = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
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
        Me.BtnClose.Location = New System.Drawing.Point(664, 18)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(30, 34)
        Me.BtnClose.TabIndex = 39
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Maroon
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(495, 353)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(168, 45)
        Me.BtnDelete.TabIndex = 38
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(317, 353)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(168, 45)
        Me.BtnUpdate.TabIndex = 37
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(139, 353)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(168, 45)
        Me.BtnSave.TabIndex = 36
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'CbCategory
        '
        Me.CbCategory.FormattingEnabled = True
        Me.CbCategory.Items.AddRange(New Object() {"Dog", "Cat", "Bird", "Fish", "Food"})
        Me.CbCategory.Location = New System.Drawing.Point(139, 187)
        Me.CbCategory.Name = "CbCategory"
        Me.CbCategory.Size = New System.Drawing.Size(540, 29)
        Me.CbCategory.TabIndex = 34
        '
        'LblPcode
        '
        Me.LblPcode.AutoSize = True
        Me.LblPcode.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPcode.Location = New System.Drawing.Point(14, 362)
        Me.LblPcode.Name = "LblPcode"
        Me.LblPcode.Size = New System.Drawing.Size(70, 21)
        Me.LblPcode.TabIndex = 33
        Me.LblPcode.Text = "pcode"
        Me.LblPcode.Visible = False
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.Location = New System.Drawing.Point(4, 303)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(58, 21)
        Me.LblPrice.TabIndex = 30
        Me.LblPrice.Text = "Price:"
        '
        'LblQty
        '
        Me.LblQty.AutoSize = True
        Me.LblQty.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQty.Location = New System.Drawing.Point(4, 248)
        Me.LblQty.Name = "LblQty"
        Me.LblQty.Size = New System.Drawing.Size(49, 21)
        Me.LblQty.TabIndex = 29
        Me.LblQty.Text = "Qty:"
        '
        'TxtQty
        '
        Me.TxtQty.Location = New System.Drawing.Point(140, 240)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(540, 30)
        Me.TxtQty.TabIndex = 28
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategory.Location = New System.Drawing.Point(4, 193)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(101, 21)
        Me.LblCategory.TabIndex = 27
        Me.LblCategory.Text = "Category:"
        '
        'TxtType
        '
        Me.TxtType.Location = New System.Drawing.Point(139, 133)
        Me.TxtType.Name = "TxtType"
        Me.TxtType.Size = New System.Drawing.Size(540, 30)
        Me.TxtType.TabIndex = 26
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblType.Location = New System.Drawing.Point(4, 138)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(58, 21)
        Me.LblType.TabIndex = 25
        Me.LblType.Text = "Type:"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(139, 79)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(540, 30)
        Me.TxtName.TabIndex = 24
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(4, 83)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(69, 21)
        Me.LblName.TabIndex = 23
        Me.LblName.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 34)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Product Registration"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 16)
        Me.Panel1.TabIndex = 21
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(145, 294)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(540, 30)
        Me.TxtPrice.TabIndex = 40
        '
        'ProductModule
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(697, 413)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.CbCategory)
        Me.Controls.Add(Me.LblPcode)
        Me.Controls.Add(Me.LblPrice)
        Me.Controls.Add(Me.LblQty)
        Me.Controls.Add(Me.TxtQty)
        Me.Controls.Add(Me.LblCategory)
        Me.Controls.Add(Me.TxtType)
        Me.Controls.Add(Me.LblType)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductModule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents CbCategory As ComboBox
    Friend WithEvents LblPcode As Label
    Friend WithEvents LblPrice As Label
    Friend WithEvents LblQty As Label
    Friend WithEvents TxtQty As TextBox
    Friend WithEvents LblCategory As Label
    Friend WithEvents TxtType As TextBox
    Friend WithEvents LblType As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtPrice As TextBox
End Class
