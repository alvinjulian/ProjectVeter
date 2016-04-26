Public Class frm_print_transaksi
    Private Sub frm_print_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIDCust.Text = _data.cstId.Trim
        lblPay.Text = _data.pmbyran.Trim
        dgv.DataSource = New 
End Class