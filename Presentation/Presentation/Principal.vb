Public Class Principal


    Dim tipouser As Integer
    Dim id As String
    Public Sub New(pid As String, ptipouser As Integer) ' pasar los parametros

        ' This call is required by the designer.
        InitializeComponent()
        tipouser = ptipouser
        id = pid
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerificarPermisos(tipouser)
    End Sub
    Private Sub VerificarPermisos(Tipo As Integer)

        If Tipo = 1 Then 'ADMIN

            DepositoToolStripMenuItem.Enabled = False
            ReservacionesToolStripMenuItem.Enabled = False
        Else
            If Tipo = 2 Then 'COCINA
                GestionRRHHToolStripMenuItem.Enabled = False
                DepositoToolStripMenuItem.Enabled = False
                ReservacionesToolStripMenuItem.Enabled = False
            Else
                If Tipo = 3 Then 'MESER
                    GestionRRHHToolStripMenuItem.Enabled = False
                    CocinaToolStripMenuItem.Enabled = False
                    DepositoToolStripMenuItem.Enabled = False
                Else
                    If Tipo = 4 Then 'BODEGA
                        GestionRRHHToolStripMenuItem.Enabled = False
                        CocinaToolStripMenuItem.Enabled = False
                        ReservacionesToolStripMenuItem.Enabled = False
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub ReservacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservacionesToolStripMenuItem.Click
        Dim MDIForm As New Reservaciones(id)
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub GestionRRHHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionRRHHToolStripMenuItem.Click
        Dim MDIForm As New GestionRRHH
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub CocinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CocinaToolStripMenuItem.Click
        Dim MDIForm As New Cocina(tipouser)
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub

    Private Sub DepositoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositoToolStripMenuItem.Click
        Dim MDIForm As New Deposito
        MDIForm.MdiParent = Me
        MDIForm.Show()
    End Sub
End Class