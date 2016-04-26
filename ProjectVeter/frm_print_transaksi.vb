Public Class frm_print_transaksi
    Private Sub frm_print_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIDCust.Text = _data.cstId.Trim
        lblPay.Text = _data.pmbyran.Trim
        lblTotal.Text = _data.total.ToString.Trim

        Dim index As Integer = _data.penjualan.GetUpperBound(1)

        For value As Integer = 0 To index
            If String.IsNullOrEmpty(_data.penjualan(0, value)) Then

            Else
                Me.dgv.Rows.Add(_data.penjualan(0, value), _data.penjualan(1, value), _data.penjualan(2, value), _data.penjualan(3, value))
            End If
        Next

        'Me.dgv.DataSource = _data.penjualan
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
    End Sub
End Class