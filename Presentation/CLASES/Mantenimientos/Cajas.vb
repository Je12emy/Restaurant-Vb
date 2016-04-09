Public Class Cajas

    Public Sub New(pID_Factura As Integer, pID_Mesa As String, pProducto As String, pCantidad As Integer, pPrecio As Double, pTotal As Double)

        ID_Factura = pID_Factura
        ID_Mesa = pID_Mesa
        Producto = pProducto
        Cantidad = pCantidad
        Precio = pPrecio
        Total = pTotal

    End Sub


    Public ID_Factura As Integer
    Public ID_Mesa As Integer
    Public Producto As String
    Public Cantidad As Integer
    Public Precio As Double
    Public Total As Double


End Class
