Public Class Menus
    Public Sub New(pID As Integer, pID_TIPO As String, pNombre As String, pDescripcion As String, pPrecio As String)

        ID = pID
        ID_TIPO = pID_TIPO
        Nombre = pNombre
        Descripcion = pDescripcion
        Precio = pPrecio
    End Sub

    Public ID As Integer
    Public ID_TIPO As String
    Public Nombre As String
    Public Descripcion As String
    Public Precio As Double
End Class
