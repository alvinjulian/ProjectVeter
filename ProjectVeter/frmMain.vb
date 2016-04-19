Public Class frmMain

    Public Sub New(ByVal sTitle As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strp_login.Text = "Logged in as " + sTitle
    End Sub

    Private Sub frmMain_Load() Handles MyBase.Load
        tmr_login.Enabled = True
        tmr_login.Interval = 1000
        tmr_login.Start()
        tlstriplbl_timer.Text = tmr_login.ToString
    End Sub

    Private Sub frmMain_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Application.Exit()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim frm_login As New frm_Login
        frm_login.Show()
        Me.Close()
    End Sub
End Class