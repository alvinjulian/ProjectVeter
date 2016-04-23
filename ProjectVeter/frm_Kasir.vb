Public Class frm_Kasir
    Private Sub frm_Kasir_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

    End Sub

    Private Sub clearTxt()
        cmbBarcode.Text = ""
        txtNama.Clear()
        txtHarga.Clear()
        txtJumlah.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

    End Sub

    Private Sub cmbBarcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBarcode.SelectedIndexChanged
        Dim index As Integer = cmbBarcode.SelectedIndex

    End Sub

    Private Sub frm_Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbBarcode.MaxDropDownItems = _data.barcode.Length
        cmbBarcode.Items.Clear()
        For Each dtaBar As String In _data.barcode
            cmbBarcode.Items.Add(dtaBar)
        Next
    End Sub
End Class