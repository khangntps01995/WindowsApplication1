Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class sanpham
    Dim bangtailieu As New DataTable
    Dim tailieu As String = "workstation id=khangnt.mssql.somee.com;packet size=4096;user id=ps01995;pwd=Khanhngoc14328;data source=khangnt.mssql.somee.com;persist security info=False;initial catalog=khangnt"
    Private Sub loadthongtin()
        Dim xem As New SqlConnection(tailieu)
        Dim load As New SqlDataAdapter("select * From sanpham", xem)
        Try
            xem.Open()
            load.Fill(bangtailieu)
        Catch ex As Exception
        End Try
        dgv1.DataSource = bangtailieu
        xem.Close()
    End Sub
    Private Sub btnxem_Click(sender As Object, e As EventArgs) Handles btnxem.Click
        Dim xem As New SqlConnection(tailieu)
        Dim load As New SqlDataAdapter("select * From sanpham", xem)
        Try
            xem.Open()
            load.Fill(bangtailieu)
        Catch ex As Exception
        End Try
        dgv1.DataSource = bangtailieu
        xem.Close()
    End Sub

    Private Sub ltv1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim tailieu As Integer = dgv1.CurrentCell.RowIndex
        txtmasanpham.Text = dgv1.Item(0, tailieu).Value
        txttensanpham.Text = dgv1.Item(1, tailieu).Value
        txtdongia.Text = dgv1.Item(2, tailieu).Value
        txtchitiet.Text = dgv1.Item(3, tailieu).Value
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim chay As New SqlConnection(tailieu)
        Dim plus As New SqlDataAdapter("insert into sanpham values ('" & txtmasanpham.Text & "','" & txttensanpham.Text & "', '" & txtdongia.Text & "', '" & txtchitiet.Text & "')", chay)
        Try
            chay.Open()
            plus.Fill(bangtailieu)

        Catch ex As Exception
            MessageBox.Show("thêm thành công !")
        End Try
        dgv1.DataSource = bangtailieu
        chay.Close()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim xoa As New SqlConnection(tailieu)
        xoa.Open()
        Dim thucthi As String = "delete from sanpham where TenSP = @TenSP"
        Dim com As New SqlCommand(thucthi, xoa)
        Try
            com.Parameters.AddWithValue("TenSP", txttensanpham.Text)
            com.ExecuteNonQuery()
            xoa.Close()
        Catch ex As Exception
            MessageBox.Show("xóa thành công !")

        End Try
        bangtailieu.Clear()
        dgv1.DataSource = bangtailieu
        dgv1.DataSource = Nothing
        loadthongtin()
    End Sub


    

    Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click
        Me.Close()

    End Sub
End Class