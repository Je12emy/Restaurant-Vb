Imports LOGICA
Imports CLASES
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing

Public Class Reservaciones

    Dim Acceso As AccesoLogica = New AccesoLogica()
    Dim persona As Integer
    Dim ID_M As String
    Public Sub New(pid As String)

        ' This call is required by the designer.
        InitializeComponent()
        ID_M = pid
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Reservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MostrarMesas()
        MostrarMenus()
        txtmesa.Enabled = False
        txtCapacidad.Enabled = False
        txtId_Mesonero.Enabled = False
        txtId_Mesonero.Text = ID_M
        'MessageBox.Show("")


    End Sub
    '----------------------------------------------Metodos Mesas--------------------------------
    Private Sub dgvMesas_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMesas.CellClick
        Try
            Dim fila As Integer = dgvMesas.CurrentRow.Index
            txtmesa.Text = dgvMesas(0, fila).Value.ToString()
            txtMmesa.Text = txtmesa.Text 'Le pasa el valor al txt del Grupo Menú
            txtCmesa.Text = txtmesa.Text 'Le pasa el valor al txt del Grupo Caja
            cbStatus.Text = dgvMesas(1, fila).Value.ToString()
            txtCapacidad.Text = dgvMesas(2, fila).Value.ToString()
            txtOrdenes.Text = dgvMesas(3, fila).Value.ToString()
            'txtId_Mesonero.Text = dgvMesas(3, fila).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Dim ObjMesas As Mesas = New Mesas(txtmesa.Text, cbStatus.Text, txtCapacidad.Text, txtOrdenes.Text, txtId_Mesonero.Text)
        Acceso.ActualizarMesas(ObjMesas, txtmesa.Text)
        MostrarMesas()
    End Sub
    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged

        If cbStatus.Text = "DISPONIBLE" Then
            cbStatus.ForeColor = Drawing.Color.Green
        Else
            cbStatus.ForeColor = Drawing.Color.Red
        End If

    End Sub
    Private Sub MostrarMesas()
        Dim Milista As List(Of Mesas) = New List(Of Mesas)

        Milista = Acceso.ListaMesas()

        dgvMesas.Rows.Clear()
        For Each elemento In Milista
            Dim fila As String()
            fila = New String() {elemento.ID, elemento.StatusMesa, elemento.Cantidad_Personas, elemento.Ordenes, elemento.ID_Mesonero}
            dgvMesas.Rows.Add(fila)
        Next

    End Sub
    '----------------------------------------------Metodos Menus--------------------------------
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
    Private Sub cbMtipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMtipo.SelectedIndexChanged
        MostrarMenuExp(cbMtipo.Text)
    End Sub

    '----------------------------------------------Metodos Cajas--------------------------------
    Private Sub btnCargarOrden_Click(sender As Object, e As EventArgs) Handles btnCargarOrden.Click
        Dim Total As Double = txtMprecio.Text * mtMcantidad.Text
        Dim contador As Integer
        Dim ObjCaja As Cajas = New Cajas(contador, txtMmesa.Text, txtMnombre.Text, mtMcantidad.Text, txtMprecio.Text, Total)
        Acceso.InsertarOrden(ObjCaja)
        MostrarCajasExp(txtCmesa.Text)
    End Sub
    Private Sub dgvCaja_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCaja.CellClick
        Try
            Dim fila As Integer = dgvCaja.CurrentRow.Index
            txtCtotal.Text = CalcularTotal().ToString()
        Catch ex As Exception

        End Try
    End Sub
    Function CalcularTotal() As Decimal
        Dim total As Decimal = 0

        For indice = 0 To dgvCaja.Rows.Count - 1 Step 1 'CORRE CADA FILA DEL DATA GRID
            total += dgvCaja(4, indice).Value
        Next
        Return total
    End Function
    Private Sub MostrarCajasExp(id As String)
        Dim Milista As List(Of Cajas) = New List(Of Cajas)

        Milista = Acceso.ListaCajaExp(id)
        dgvCaja.Rows.Clear()
        For Each elemento In Milista
            Dim fila As String()
            fila = New String() {elemento.ID_Factura, elemento.ID_Mesa, elemento.Producto, elemento.Cantidad, elemento.Precio, elemento.Total}
            dgvCaja.Rows.Add(fila)
        Next
    End Sub
    Private Sub txtCmesa_TextChanged(sender As Object, e As EventArgs) Handles txtCmesa.TextChanged
        MostrarCajasExp(txtCmesa.Text)
    End Sub

    Private Sub btnceliminar_Click(sender As Object, e As EventArgs) Handles btnceliminar.Click
        Dim fila As Integer = dgvCaja.CurrentRow.Index
        Dim id As Integer = dgvCaja(0, fila).Value
        Acceso.EliminarOrden(id)
        Dim encontrado As Boolean = Acceso.EliminarOrden(id)

        If encontrado = True Then
            MessageBox.Show("Orden Eliminada")
        Else
            MessageBox.Show("La Orden No pudo ser Eliminada")
        End If
        MostrarCajasExp(txtCmesa.Text)
    End Sub



    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        'Dim listadesgloce As New List(Of String) 'Desgloce
        'Dim listacantidad As New List(Of String) 'Cantidad
        'Dim listaproducto As New List(Of String) 'Producto
        'Dim listaprecio As New List(Of String) 'Precio


        'Dim total As Decimal = 0

        'For indice = 0 To dgvCaja.Rows.Count - 1 Step 1 'CORRE CADA FILA DEL DATA GRID
        '    total += dgvCaja(4, indice).Value
        '    listaprecio.Add(dgvCaja(4, indice).Value.ToString())
        '    listadesgloce.Add(dgvCaja(3, indice).Value.ToString())
        '    listacantidad.Add(dgvCaja(2, indice).Value.ToString())
        '    listaproducto.Add(dgvCaja(1, indice).Value.ToString())
        'Next

        Dim id As Integer = txtCmesa.Text
        Dim MDIForm As New Factura(id)
        MDIForm.Show()
    End Sub


End Class