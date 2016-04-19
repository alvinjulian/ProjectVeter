<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tlstriplbl_timer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.strp_login = New System.Windows.Forms.ToolStripStatusLabel()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GudangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmr_login = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.KasirToolStripMenuItem, Me.GudangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfilToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ProfilToolStripMenuItem
        '
        Me.ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem"
        Me.ProfilToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProfilToolStripMenuItem.Text = "Profil"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Logout"
        '
        'Lbl1
        '
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(159, 39)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(177, 60)
        Me.Lbl1.TabIndex = 1
        Me.Lbl1.Text = "TOKO J"
        Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstriplbl_timer, Me.strp_login})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 403)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(631, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tlstriplbl_timer
        '
        Me.tlstriplbl_timer.Name = "tlstriplbl_timer"
        Me.tlstriplbl_timer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tlstriplbl_timer.Size = New System.Drawing.Size(120, 17)
        Me.tlstriplbl_timer.Text = "ToolStripStatusLabel1"
        '
        'strp_login
        '
        Me.strp_login.Name = "strp_login"
        Me.strp_login.Size = New System.Drawing.Size(120, 17)
        Me.strp_login.Text = "ToolStripStatusLabel1"
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.KasirToolStripMenuItem.Text = "&Kasir"
        '
        'GudangToolStripMenuItem
        '
        Me.GudangToolStripMenuItem.Name = "GudangToolStripMenuItem"
        Me.GudangToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GudangToolStripMenuItem.Text = "&Gudang"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 425)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lbl1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tlstriplbl_timer As ToolStripStatusLabel
    Friend WithEvents KasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GudangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents strp_login As ToolStripStatusLabel
    Friend WithEvents tmr_login As Timer
End Class
