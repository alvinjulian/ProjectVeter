Imports System.Text.RegularExpressions

Public Class frm_Login

    Dim id As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Login"
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.txtPassword.PasswordChar = "*"
    End Sub

    Public Sub loginDetails()
        Dim details As String
        details = "admin admin"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim id As String
        If String.IsNullOrEmpty(txtUsername.Text) And String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Username dan password tidak boleh kosong!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            id = txtUsername.Text
            Dim Main As New frmMain(id)
            Main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frm_Login_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Application.Exit()
    End Sub
End Class
