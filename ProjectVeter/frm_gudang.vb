Public Class frm_gudang
    'array public bisa diakses form mana pun,,'


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frm_gudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim harga As Integer
        Dim index As Integer
        Dim result As Boolean = Integer.TryParse(txtHarga.Text.ToString.Trim, harga)
        If result Then
            Me.dgv.Rows.Add(txtBarcode.Text, txtNama.Text, harga)
            index = Integer.Parse(txtBarcode.Text)

            'masukin ke array untuk bisa di load di kasir nanti'
            _data.barcode(index) = txtBarcode.Text
            _data.nama(index) = txtNama.Text
            _data.harga_array(index) = txtHarga.Text
            'naekin value barcode otomatis'
            txtBarcode.Text = Val(txtBarcode.Text) + 1


            'Dim dr As DataRow
            'dr = _data.dt.NewRow
            'dr("Barcode") = txtBarcode.Text.Trim
            'dr("Nama Barang") = txtNama.Text.Trim
            'dr("Harga") = harga
            '
            '_data.dt.Rows.Add(dr)
            '
            'dgv.DataSource = _data.dt
            'dgv.Refresh()
            '
            'Dim index As Integer = _data.arrdata.Length()

            'Dim index_i As Integer = _data.arrdata.GetUpperBound(0)
            ''Dim index_j As Integer = _data.arrdata.GetUpperBound(1)
            ''Dim index_k As Integer = _data.arrdata.GetUpperBound(2)

            'barcode = txtBarcode.Text.Trim
            'nama = txtNama.Text.Trim

            '_data.arrdata(0, index_i) = barcode.ToString.Trim
            '_data.arrdata(1, index_i) = nama.ToString.Trim
            '_data.arrdata(2, index_i) = result.ToString.Trim

            ''MessageBox.Show(index)

            'dgv.DataSource = _data.arrdata
            'dgv.Refresh()

            MessageBox.Show("Data berhasil dimasukan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clearTxt()
        Else
            MessageBox.Show("Harga Tidak Valid!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Dim lv As ListViewItem
        'lv.Text = txtBarcode.Text.Trim
        'lv.Items.AddRange(New ListViewItem(New String() {txtBarcode.Text.Trim, txtNama.Text.Trim, txtHarga.Text.Trim}))
        'lstView1.Items.Add(New ListViewItem(New String() {txtBarcode.Text.Trim, txtNama.Text.Trim, txtHarga.Text.Trim}))


    End Sub

    Private Sub clearTxt()

        txtNama.Clear()
        txtHarga.Clear()
    End Sub

    Private Sub lockTxt(status As Boolean)
        txtBarcode.Enabled = status
        txtNama.Enabled = status
        txtHarga.Enabled = status
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Call clearTxt()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class