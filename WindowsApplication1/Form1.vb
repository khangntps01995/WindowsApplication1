Imports System.Data.SqlClient


Public Class frmdangnhap

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim chuoiketnoi As String = "workstation id=khangnt.mssql.somee.com;packet size=4096;user id=ps01995;pwd=Khanhngoc14328;data source=khangnt.mssql.somee.com;persist security info=False;initial catalog=khangnt"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from nhanvien where manhanvien='" & txttendangnhap.Text & "' and matkhau='" & txtmatkhau.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show(" Đăng nhập thành công")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tai Khoan hoac Mat Khau Không Đúng")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub
End Class
