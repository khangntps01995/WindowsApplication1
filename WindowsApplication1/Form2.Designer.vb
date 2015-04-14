<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DangToolStripMenuItem, Me.QuảnLýSảnPhẩmToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(599, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DangToolStripMenuItem
        '
        Me.DangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngXuấtToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.DangToolStripMenuItem.Name = "DangToolStripMenuItem"
        Me.DangToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.DangToolStripMenuItem.Text = "Hệ Thống"
        '
        'QuảnLýSảnPhẩmToolStripMenuItem
        '
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Name = "QuảnLýSảnPhẩmToolStripMenuItem"
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm"
        '
        'ĐăngXuấtToolStripMenuItem
        '
        Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
        Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ĐăngXuấtToolStripMenuItem.Text = "Đăng xuất "
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 446)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngXuấtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
