Imports LOGICA
Imports CLASES
Public Class Factura
    Dim Acceso As New AccesoLogica
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCajasExp(id)
        txtCmesa.Text = id
        txtCtotal.Text = CalcularTotal()
        Timer1.Start()
    End Sub
    Dim id As Integer
    Public Sub New(pid As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        id = pid
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintDocument1.Print()
        Timer1.Stop()
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
End Class