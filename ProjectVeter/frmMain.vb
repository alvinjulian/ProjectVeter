Public Class frmMain
    Public Shared waktu As Integer

    Public Shared buka As Boolean = False

    Public Sub New(ByVal sTitle As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strp_login.Text = "Logged in as " + sTitle

        Me.IsMdiContainer = True

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub frmMain_Load() Handles MyBase.Load
        tlstriplbl_timer.Text = "00:00"
        tmr_login.Enabled = True
        tmr_login.Interval = 1000
        waktu = 1000 'set waktu disini' 'untuk bisa diload ke form lain'
        tmr_login.Start()
    End Sub

    Private Sub frmMain_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Application.Exit()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim frm_login As New frm_Login
        frm_login.Show()
        Me.Close()
    End Sub
    Public Function GetTime(waktu As Integer) As String
        Dim menit As Integer
        Dim detik As Integer

        detik = waktu Mod 60

        menit = ((waktu - detik) / 60) Mod 60

        Return Format(menit, "00") & ":" & Format(detik, "00")
    End Function
    Private Sub tmr_login_Tick(sender As Object, e As EventArgs) Handles tmr_login.Tick
        tlstriplbl_timer.Text = GetTime(waktu)
        If waktu > 0 Then
            waktu -= 1
        Else

            tmr_login.Stop()

            'close all form'

            Dim frm_login As New frm_Login
            frm_login.Show()
            Me.Close()

        End If
    End Sub

    Private Sub KasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasirToolStripMenuItem.Click
        Dim frm_Kasir As New frm_Kasir
        frm_Kasir.MdiParent = Me
        frm_Kasir.Show()
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '
        ''buka = True
        ''If (buka = True) Then
        'Dim frmLogin = New frm_Login
        ''  buka = False
        'frmLogin.Show()
        'Me.Close()
        '    frmLogin = Nothing
        '    Me.Close()
        'End If
        'Application.Run(New frm_Login)
    End Sub

    Private Sub GudangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GudangToolStripMenuItem.Click
        Dim frm_Gudang As New frm_gudang
        frm_Gudang.MdiParent = Me
        frm_Gudang.Show()
    End Sub
End Class