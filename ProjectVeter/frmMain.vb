Public Class frmMain
    Public Shared waktu As Integer = 90 'set waktu disini' 'untuk bisa diload ke form lain'

    Public Sub New(ByVal sTitle As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strp_login.Text = "Logged in as " + sTitle

    End Sub

    Private Sub frmMain_Load() Handles MyBase.Load
        tlstriplbl_timer.Text = "01:30"
        tmr_login.Enabled = True
        tmr_login.Interval = 1000
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
            Dim sukses_exit As Boolean
            Do
                sukses_exit = True
                Try
                    For Each f As Form In My.Application.OpenForms
                        If f.Name < "frmMain" Then f.Close()
                    Next f
                Catch ex As Exception
                    sukses_exit = False
                End Try
            Loop Until sukses_exit

            Dim frm_login As New frm_Login
            frm_login.Show()
            waktu = 90
            Me.Close()

        End If
    End Sub

    Private Sub KasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasirToolStripMenuItem.Click
        Dim frm_Kasir As New frm_Kasir
        frm_Kasir.Show()
        Me.Hide()
    End Sub
End Class