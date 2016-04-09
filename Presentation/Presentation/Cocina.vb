Imports CLASES
Imports LOGICA
Imports System.Windows.Forms

Public Class Cocina
    Dim Acceso As AccesoLogica = New AccesoLogica()
    Dim id As Integer
    Public Sub New(pid As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        id = pid
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub MostrarMenus()
        Dim Milista As List(Of Menus) = New List(Of Menus)

        Milista = Acceso.ListaMenus()

        dgvMenu.Rows.Clear()
        For Each elemento In Milista
            Dim fila As String()
            fila = New String() {elemento.ID, elemento.ID_TIPO, elemento.Nombre, elemento.Descripcion, elemento.Precio}
            dgvMenu.Rows.Add(fila)
        Next
    End Sub
    Private Sub VerificarPermisos(Tipo As Integer)
        If Tipo = 1 Then
            btnAgregarPlato.Enabled = False
            btnModificarPlato.Enabled = False
            btnEliminar.Enabled = False
            txtMdescripcion.Enabled = False
            txtMnombre.Enabled = False
            txtMprecio.Enabled = False
        End If
    End Sub
    Private Sub MostrarMenuExp(id As String)
        Dim Milista As List(Of Menus) = New List(Of Menus)

        Milista = Acceso.ListaMenuExp(id)
        dgvMenu.Rows.Clear()
        For Each elemento In Milista
            Dim fila As String()
            fila = New String() {elemento.ID, elemento.ID_TIPO, elemento.Nombre, elemento.Descripcion, elemento.Precio}
            dgvMenu.Rows.Add(fila)
        Next
    End Sub
    Private Sub cbMtipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMtipo.SelectedIndexChanged
        MostrarMenuExp(cbMtipo.Text)
    End Sub
    Private Sub Cocina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarMenus()
        VerificarPermisos(id)
    End Sub
    Private Sub dgvMenu_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMenu.CellClick
        Try
            Dim fila As Integer = dgvMenu.CurrentRow.Index
            cbMtipo.Text = dgvMenu(1, fila).Value.ToString()
            txtMnombre.Text = dgvMenu(2, fila).Value.ToString()
            txtMdescripcion.Text = dgvMenu(3, fila).Value.ToString()
            txtMprecio.Text = dgvMenu(4, fila).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AgregarMenu()
        Dim id As Integer
        Dim ObjMenu As Menus = New Menus(id, cbMtipo.Text, txtMnombre.Text, txtMdescripcion.Text, txtMprecio.Text)
        Acceso.InsertarMenu(ObjMenu)
        MostrarMenus()
    End Sub
    Private Sub ModificarMenu(id As Integer)
        Dim ObjMenu As Menus = New Menus(id, cbMtipo.Text, txtMnombre.Text, txtMdescripcion.Text, txtMprecio.Text)
        Acceso.ActualizarMenu(ObjMenu, id)
        MostrarMenus()
    End Sub
    Private Sub EliminarMenu(id As Integer)
        Dim encontrado As Boolean = Acceso.EliminarMenu(id)
        If encontrado = True Then
            MessageBox.Show("Registro Eliminado")
        Else
            MessageBox.Show("El Registro No pudo ser Eliminado")
        End If
        MostrarMenus()
    End Sub

    Private Sub btnAgregarPlato_Click(sender As Object, e As EventArgs) Handles btnAgregarPlato.Click
        AgregarMenu()
    End Sub

    Private Sub btnModificarPlato_Click(sender As Object, e As EventArgs) Handles btnModificarPlato.Click
        Dim fila As Integer = dgvMenu.CurrentRow.Index
        Dim id As Integer = dgvMenu(0, fila).Value
        ModificarMenu(id)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim fila As Integer = dgvMenu.CurrentRow.Index
        Dim id As Integer = dgvMenu(0, fila).Value
        EliminarMenu(id)
    End Sub
End Class