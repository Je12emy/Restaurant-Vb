Imports CLASES
Imports LOGICA
Imports System.Windows.Forms
Public Class Login

    Dim Acceso As New AccesoLogica()
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim tipouser As Integer = Acceso.VerificarUsuario(txtUser.Text, txtPass.Text)
        Dim id As String = "N/A"
        If tipouser = 0 Then
            MessageBox.Show("Credenciales Incorrectas")
        Else
            id = obtenerid(txtUser.Text)
            Dim MDIForm As New Principal(id, tipouser)
            Dim MDIForm2 As New Login
            'MDIForm.MdiParent = Me
            MDIForm.Show()
            txtUser.Text = ""
            txtPass.Text = ""
            MDIForm2.Close()
        End If
    End Sub

    Function obtenerid(user As String) As String
        Dim id As String = Acceso.ObtenerId(user)
        Return id
    End Function




End Class