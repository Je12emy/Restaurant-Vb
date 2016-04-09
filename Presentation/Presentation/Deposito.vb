Imports LOGICA
Imports CLASES
Imports System.Windows.Forms

Public Class Deposito

    Dim Acceso As AccesoLogica = New AccesoLogica()
    Private Sub Deposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub MostrarDepositos()
        Dim Milista As List(Of Depositos) = New List(Of Depositos)

        Milista = Acceso.ListaDepositos()

        dgvDepositos.Rows.Clear()
        For Each elemento In Milista
            Dim fila As String()
            fila = New String() {elemento.ID_Contador, elemento.ID_Producto, elemento.Descripcion, elemento.Cantidad}
            dgvDepositos.Rows.Add(fila)
        Next
    End Sub
    Private Sub AgregarAlimento()
        Dim id As Integer
        Dim ObjDeposito As Depositos = New Depositos(id, cbMtipo.Text, txtDescripcion.Text, txtCantidad.Text)
        Acceso.InsertarAlimento(ObjDeposito)
        MostrarDepositos()
    End Sub
    Private Sub ModificarAlimento(id As Integer)
        Dim ObjDeposito As Depositos = New Depositos(id, cbMtipo.Text, txtDescripcion.Text, txtCantidad.Text)
        Acceso.ActualizarAlimento(ObjDeposito, id)
        MostrarDepositos()
    End Sub
    Private Sub EliminarAlimento(id As Integer)
        Dim encontrado As Boolean = Acceso.EliminarAlimento(id)
        If encontrado = True Then
            MessageBox.Show("Registro Eliminado")
        Else
            MessageBox.Show("El Registro No pudo ser Eliminado")
        End If
        MostrarDepositos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarAlimento()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim fila As Integer = dgvDepositos.CurrentRow.Index
        Dim id As Integer = dgvDepositos(0, fila).Value
        ModificarAlimento(id)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim fila As Integer = dgvDepositos.CurrentRow.Index
        Dim id As Integer = dgvDepositos(0, fila).Value
        EliminarAlimento(id)
    End Sub
End Class