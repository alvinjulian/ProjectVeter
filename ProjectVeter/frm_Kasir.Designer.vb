<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Kasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbBarcode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbPay = New System.Windows.Forms.ComboBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(33, 329)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(726, 160)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbBarcode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 81)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barang"
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(609, 40)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(100, 20)
        Me.txtJumlah.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(606, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Jumlah Barang"
        '
        'cmbBarcode
        '
        Me.cmbBarcode.FormattingEnabled = True
        Me.cmbBarcode.Location = New System.Drawing.Point(18, 40)
        Me.cmbBarcode.Name = "cmbBarcode"
        Me.cmbBarcode.Size = New System.Drawing.Size(121, 21)
        Me.cmbBarcode.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(488, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(491, 40)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(100, 20)
        Me.txtHarga.TabIndex = 16
        '
        'txtNama
        '
        Me.txtNama.AcceptsReturn = True
        Me.txtNama.Enabled = False
        Me.txtNama.Location = New System.Drawing.Point(155, 40)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(318, 20)
        Me.txtNama.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Barcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nama Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbPay)
        Me.GroupBox2.Controls.Add(Me.txtCustomer)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 96)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer"
        '
        'cmbPay
        '
        Me.cmbPay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPay.FormattingEnabled = True
        Me.cmbPay.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cmbPay.Location = New System.Drawing.Point(115, 62)
        Me.cmbPay.Name = "cmbPay"
        Me.cmbPay.Size = New System.Drawing.Size(100, 21)
        Me.cmbPay.TabIndex = 19
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(115, 19)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomer.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Costumer ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Pembayaran"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(28, 238)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(373, 39)
        Me.btnTambah.TabIndex = 19
        Me.btnTambah.Text = "Tambah Barang"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(411, 238)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(348, 39)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(204, 289)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(415, 25)
        Me.btnHapus.TabIndex = 21
        Me.btnHapus.Text = "Hapus Barang"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(580, 502)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(179, 39)
        Me.Btn4.TabIndex = 22
        Me.Btn4.Text = "Print Transaksi"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Lbl1
        '
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(294, 18)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(465, 123)
        Me.Lbl1.TabIndex = 23
        Me.Lbl1.Text = "Transaksi Toko J"
        Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 557)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_Kasir"
        Me.Text = "Kasir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbBarcode As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbPay As ComboBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Lbl1 As Label
End Class
