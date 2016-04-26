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
                Dim index As Integer = _data.penjualan.GetUpperBound(1)
                _data.penjualan(0, index) = barcode.ToString.Trim
                _data.penjualan(1, index) = nama.ToString.Trim
                _data.penjualan(2, index) = jumlah.ToString.Trim
                _data.penjualan(3, index) = harga.ToString.Trim

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

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        _data.cstId = txtCustomer.Text.ToString.Trim
        _data.pmbyran = cmbPay.Text.ToString.Trim
        Dim detail As New frm_print_transaksi
        detail.Show()
        Me.Close()
    End Sub
End Class