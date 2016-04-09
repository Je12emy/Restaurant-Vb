Public Class Depositos



    Public Sub New(pID_Contador As Integer, pID_Producto As String, pDescripcion As String, pCantidad As Integer)

        ID_Contador = pID_Contador
        ID_Producto = pID_Producto
        Descripcion = pDescripcion
        Cantidad = pCantidad


    End Sub

    Public ID_Contador As Integer
    Public ID_Producto As String
    Public Descripcion As String
    Public Cantidad As Integer

End Class
