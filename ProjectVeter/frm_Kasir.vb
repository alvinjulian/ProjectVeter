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

        For value As Integer = 0 To _data.barcode.Length
            If cmbBarcode.Text = _data.barcode(index) Then
                txtNama.Text = _data.nama(index).ToString.Trim
                txtHarga.Text = _data.nama(index).ToString.Trim
            End If
        Next

    End Sub

    Private Sub frm_Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _data.barcode.Count < 1 Then
            MessageBox.Show("Tidak ada data barang! Silahkan masukan data barang di Form Gudang terlebih dahulu", "Data Kosong!", MessageBoxButtons.OK)
        Else
            'cmbBarcode.MaxDropDownItems = _data.barcode.Length
            cmbBarcode.Items.Clear()
            For value As Integer = 0 To _data.barcode.Length
                cmbBarcode.Items.Add(_data.barcode(value).ToString.Trim)
            Next
        End If

    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        _data.cstId = txtCustomer.Text.ToString.Trim
        _data.pmbyran = cmbPay.Text.ToString.Trim
    End Sub
End Class