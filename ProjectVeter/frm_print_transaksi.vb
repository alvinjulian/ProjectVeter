Public Class frm_print_transaksi
    Private Sub frm_print_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIDCust.Text = _data.cstId.Trim
        lblPay.Text = _data.pmbyran.Trim
        lblTotal.Text = _data.total.ToString.Trim

        Dim index As Integer = _data.penjualan.GetUpperBound(0)

        For value As Integer = 0 To index + 1
            If String.IsNullOrEmpty(_data.penjualan(value, 0)) Then

            Else
                Me.dgv.Rows.Add(_data.penjualan(value, 0), _data.penjualan(value, 1), _data.penjualan(value, 2), _data.penjualan(value, 3))
            End If
        Next

        'Me.dgv.DataSource = _data.penjualan
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
    End Sub
End Class