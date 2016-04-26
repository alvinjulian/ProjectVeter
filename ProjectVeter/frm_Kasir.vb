Public Class frm_Kasir
    Private Sub frm_Kasir_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim barcode As String
        Dim nama As String
        Dim jumlah As Integer
        Dim harga As Integer

        barcode = cmbBarcode.Text.ToString.Trim
        nama = txtNama.Text.ToString.Trim
        Dim result As Boolean = Integer.TryParse(txtJumlah.Text.ToString.Trim, jumlah)
        If result Then
            result = Integer.TryParse(txtHarga.Text.ToString.Trim, harga)
            If result Then
                Dim index As Integer = _data.penjualan.GetUpperBound(0)
                _data.penjualan(index, 0) = barcode.ToString.Trim
                _data.penjualan(index, 1) = nama.ToString.Trim
                _data.penjualan(index, 2) = jumlah.ToString.Trim
                _data.penjualan(index, 3) = harga.ToString.Trim

                _data.subtotal = jumlah * harga

                _data.total += _data.subtotal

                Me.dgv.Rows.Add(barcode.ToString.Trim, nama.ToString.Trim, jumlah.ToString.Trim, harga.ToString.Trim)
                MessageBox.Show("Data berhasil diinput!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else

        End If

    End Sub

    Private Sub clearTxt()
        cmbBarcode.Text = ""
        txtNama.Clear()
        txtHarga.Clear()
        txtJumlah.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbBarcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBarcode.SelectedIndexChanged
        Dim index As Integer = cmbBarcode.SelectedIndex + 1 'array mulai dari 0, tp kita ada isi dari 1

        For value As Integer = 0 To _data.barcode.Length
            If cmbBarcode.Text = _data.barcode(index) Then
                txtNama.Text = _data.nama(index).ToString.Trim
                txtHarga.Text = _data.harga_array(index).ToString.Trim
            End If
        Next

    End Sub

    Private Sub frm_Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _data.barcode(1) = 0 Then
            MessageBox.Show("Tidak ada data barang! Silahkan masukan data barang di Form Gudang terlebih dahulu", "Data Kosong!", MessageBoxButtons.OK)


        Else
            'cmbBarcode.MaxDropDownItems = _data.barcode.Length
            'Lbl1.Text = _data.barcode.Count.ToString
            cmbBarcode.Items.Clear()
            For Each value As Integer In _data.barcode
                If value <> 0 Then
                    cmbBarcode.Items.Add((value).ToString)
                End If
                'cmbBarcode.Items.Add(_data.barcode(value).ToString.Trim)
            Next
        End If

    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs)
        _data.cstId = txtCustomer.Text.ToString.Trim
        _data.pmbyran = cmbPay.Text.ToString.Trim
        Dim detail As New frm_print_transaksi
        detail.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Customer ID : " + _data.cstId.ToString.Trim + "\n" + "Pembayaran : " + _data.pmbyran.ToString.Trim + "Total belanja anda : " + "Rp. " + _data.total.ToString.Trim + "\n", "Bayar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Periksa kembali kembalian anda!", "Transaksi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class