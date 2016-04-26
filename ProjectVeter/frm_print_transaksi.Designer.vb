<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_print_transaksi
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.lblIDCust = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(295, 433)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 20)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Total : "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(357, 433)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(83, 20)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Rp. 00000"
        '
        'btnSelesai
        '
        Me.btnSelesai.Location = New System.Drawing.Point(473, 425)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(115, 38)
        Me.btnSelesai.TabIndex = 3
        Me.btnSelesai.Text = "Selesai Transaksi"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(25, 88)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(576, 301)
        Me.dgv.TabIndex = 4
        '
        'lblIDCust
        '
        Me.lblIDCust.AutoSize = True
        Me.lblIDCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDCust.Location = New System.Drawing.Point(143, 33)
        Me.lblIDCust.Name = "lblIDCust"
        Me.lblIDCust.Size = New System.Drawing.Size(44, 20)
        Me.lblIDCust.TabIndex = 6
        Me.lblIDCust.Text = "xxxxx"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ID Customer : "
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.Location = New System.Drawing.Point(546, 33)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(46, 20)
        Me.lblPay.TabIndex = 8
        Me.lblPay.Text = "Cash"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(407, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Pembayaran : "
        '
        'frm_print_transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 491)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblIDCust)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_print_transaksi"
        Me.Text = "Struk Transaksi"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnSelesai As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents lblIDCust As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPay As Label
    Friend WithEvents Label4 As Label
End Class
