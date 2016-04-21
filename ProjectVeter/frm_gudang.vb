Public Class frm_gudang


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lstView1.GridLines = True

    End Sub

    Private Sub frm_gudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'data.dt.Columns.Add("Barcode")
        'data.dt.Columns.Add("Nama Barang")
        'data.dt.Columns.Add("Harga")
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim barcode As String
        Dim nama As String
        Dim harga As Integer

        Dim temp As String

        temp = txtHarga.Text.ToString

        Dim result As Boolean = Integer.TryParse(txtHarga.Text.ToString.Trim, harga)
        If result Then
            Dim dr As DataRow
            dr = _data.dt.NewRow
            dr("Barcode") = txtBarcode.Text.Trim
            dr("Nama Barang") = txtNama.Text.Trim
            dr("Harga") = harga

            _data.dt.Rows.Add(dr)

            dgv.DataSource = _data.dt
            dgv.Refresh()

            MessageBox.Show("Data berhasil dimasukan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clearTxt()
        Else
            MessageBox.Show("Harga Tidak Valid!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If





        barcode = txtBarcode.Text.Trim

        'Dim lv As ListViewItem
        'lv.Text = txtBarcode.Text.Trim
        'lv.Items.AddRange(New ListViewItem(New String() {txtBarcode.Text.Trim, txtNama.Text.Trim, txtHarga.Text.Trim}))
        'lstView1.Items.Add(New ListViewItem(New String() {txtBarcode.Text.Trim, txtNama.Text.Trim, txtHarga.Text.Trim}))


    End Sub

    Private Sub clearTxt()
        txtBarcode.Clear()
        txtNama.Clear()
        txtHarga.Clear()
    End Sub

    Private Sub lockTxt(status As Boolean)
        txtBarcode.Enabled = status
        txtNama.Enabled = status
        txtHarga.Enabled = status
    End Sub
End Class