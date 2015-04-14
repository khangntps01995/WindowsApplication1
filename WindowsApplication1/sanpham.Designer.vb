<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sanpham
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
        Me.lblmasanpham = New System.Windows.Forms.Label()
        Me.lbltensanpham = New System.Windows.Forms.Label()
        Me.lbldongia = New System.Windows.Forms.Label()
        Me.lblchitiet = New System.Windows.Forms.Label()
        Me.txtmasanpham = New System.Windows.Forms.TextBox()
        Me.txttensanpham = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtchitiet = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.btndong = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmasanpham
        '
        Me.lblmasanpham.AutoSize = True
        Me.lblmasanpham.Location = New System.Drawing.Point(665, 45)
        Me.lblmasanpham.Name = "lblmasanpham"
        Me.lblmasanpham.Size = New System.Drawing.Size(80, 13)
        Me.lblmasanpham.TabIndex = 1
        Me.lblmasanpham.Text = "Mã Sản Phẩm :"
        '
        'lbltensanpham
        '
        Me.lbltensanpham.AutoSize = True
        Me.lbltensanpham.Location = New System.Drawing.Point(665, 89)
        Me.lbltensanpham.Name = "lbltensanpham"
        Me.lbltensanpham.Size = New System.Drawing.Size(84, 13)
        Me.lbltensanpham.TabIndex = 1
        Me.lbltensanpham.Text = "Tên Sản Phẩm :"
        '
        'lbldongia
        '
        Me.lbldongia.AutoSize = True
        Me.lbldongia.Location = New System.Drawing.Point(665, 139)
        Me.lbldongia.Name = "lbldongia"
        Me.lbldongia.Size = New System.Drawing.Size(50, 13)
        Me.lbldongia.TabIndex = 1
        Me.lbldongia.Text = "Đơn giá :"
        '
        'lblchitiet
        '
        Me.lblchitiet.AutoSize = True
        Me.lblchitiet.Location = New System.Drawing.Point(665, 187)
        Me.lblchitiet.Name = "lblchitiet"
        Me.lblchitiet.Size = New System.Drawing.Size(94, 13)
        Me.lblchitiet.TabIndex = 1
        Me.lblchitiet.Text = "Chi tiết sản phẩm :"
        '
        'txtmasanpham
        '
        Me.txtmasanpham.Location = New System.Drawing.Point(794, 42)
        Me.txtmasanpham.Name = "txtmasanpham"
        Me.txtmasanpham.Size = New System.Drawing.Size(198, 20)
        Me.txtmasanpham.TabIndex = 2
        '
        'txttensanpham
        '
        Me.txttensanpham.Location = New System.Drawing.Point(794, 86)
        Me.txttensanpham.Name = "txttensanpham"
        Me.txttensanpham.Size = New System.Drawing.Size(195, 20)
        Me.txttensanpham.TabIndex = 2
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(797, 136)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(195, 20)
        Me.txtdongia.TabIndex = 2
        '
        'txtchitiet
        '
        Me.txtchitiet.Location = New System.Drawing.Point(797, 184)
        Me.txtchitiet.Name = "txtchitiet"
        Me.txtchitiet.Size = New System.Drawing.Size(195, 20)
        Me.txtchitiet.TabIndex = 2
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(668, 278)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(115, 23)
        Me.btnthem.TabIndex = 3
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(938, 278)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(115, 23)
        Me.btnsua.TabIndex = 3
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxem
        '
        Me.btnxem.Location = New System.Drawing.Point(739, 337)
        Me.btnxem.Name = "btnxem"
        Me.btnxem.Size = New System.Drawing.Size(115, 23)
        Me.btnxem.TabIndex = 3
        Me.btnxem.Text = "Xem"
        Me.btnxem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(806, 278)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(115, 23)
        Me.btnxoa.TabIndex = 3
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 12)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(636, 367)
        Me.dgv1.TabIndex = 4
        '
        'btndong
        '
        Me.btndong.Location = New System.Drawing.Point(877, 337)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(112, 23)
        Me.btndong.TabIndex = 5
        Me.btndong.Text = "Đóng"
        Me.btndong.UseVisualStyleBackColor = True
        '
        'sanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 405)
        Me.Controls.Add(Me.btndong)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.btnxem)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.txtchitiet)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.txttensanpham)
        Me.Controls.Add(Me.txtmasanpham)
        Me.Controls.Add(Me.lblchitiet)
        Me.Controls.Add(Me.lbldongia)
        Me.Controls.Add(Me.lbltensanpham)
        Me.Controls.Add(Me.lblmasanpham)
        Me.Name = "sanpham"
        Me.Text = "sanpham"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmasanpham As System.Windows.Forms.Label
    Friend WithEvents lbltensanpham As System.Windows.Forms.Label
    Friend WithEvents lbldongia As System.Windows.Forms.Label
    Friend WithEvents lblchitiet As System.Windows.Forms.Label
    Friend WithEvents txtmasanpham As System.Windows.Forms.TextBox
    Friend WithEvents txttensanpham As System.Windows.Forms.TextBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents txtchitiet As System.Windows.Forms.TextBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents btndong As System.Windows.Forms.Button
End Class
