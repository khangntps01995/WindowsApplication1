<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Me.lbltendangnhap = New System.Windows.Forms.Label()
        Me.lblmatkhau = New System.Windows.Forms.Label()
        Me.txttendangnhap = New System.Windows.Forms.TextBox()
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbltendangnhap
        '
        Me.lbltendangnhap.AutoSize = True
        Me.lbltendangnhap.Location = New System.Drawing.Point(63, 64)
        Me.lbltendangnhap.Name = "lbltendangnhap"
        Me.lbltendangnhap.Size = New System.Drawing.Size(87, 13)
        Me.lbltendangnhap.TabIndex = 0
        Me.lbltendangnhap.Text = "Tên đăng nhập :"
        '
        'lblmatkhau
        '
        Me.lblmatkhau.AutoSize = True
        Me.lblmatkhau.Location = New System.Drawing.Point(63, 110)
        Me.lblmatkhau.Name = "lblmatkhau"
        Me.lblmatkhau.Size = New System.Drawing.Size(58, 13)
        Me.lblmatkhau.TabIndex = 0
        Me.lblmatkhau.Text = "Mật khẩu :"
        '
        'txttendangnhap
        '
        Me.txttendangnhap.Location = New System.Drawing.Point(181, 61)
        Me.txttendangnhap.Name = "txttendangnhap"
        Me.txttendangnhap.Size = New System.Drawing.Size(233, 20)
        Me.txttendangnhap.TabIndex = 1
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Location = New System.Drawing.Point(181, 107)
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmatkhau.Size = New System.Drawing.Size(233, 20)
        Me.txtmatkhau.TabIndex = 1
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.Location = New System.Drawing.Point(220, 9)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(76, 25)
        Me.lbllogin.TabIndex = 0
        Me.lbllogin.Text = "LOGIN"
        Me.lbllogin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btndangnhap
        '
        Me.btndangnhap.Location = New System.Drawing.Point(119, 189)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(75, 23)
        Me.btndangnhap.TabIndex = 2
        Me.btndangnhap.Text = "Đăng Nhập"
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Location = New System.Drawing.Point(321, 189)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(75, 23)
        Me.btnhuy.TabIndex = 2
        Me.btnhuy.Text = "Hủy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 262)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.txtmatkhau)
        Me.Controls.Add(Me.txttendangnhap)
        Me.Controls.Add(Me.lblmatkhau)
        Me.Controls.Add(Me.lbllogin)
        Me.Controls.Add(Me.lbltendangnhap)
        Me.Name = "frmdangnhap"
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltendangnhap As System.Windows.Forms.Label
    Friend WithEvents lblmatkhau As System.Windows.Forms.Label
    Friend WithEvents txttendangnhap As System.Windows.Forms.TextBox
    Friend WithEvents txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents lbllogin As System.Windows.Forms.Label
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button

End Class
