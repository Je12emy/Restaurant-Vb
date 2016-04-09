Public Class Empleados


    Public Sub New(pID_Contador As Integer, pID_Empleado As String, pID_Dpto As String, pNombre As String, pApellido As String, pTelefono As String, pEdad As String, pCorreo As String, pDireccion As String)
        ID_Contador = pID_Contador
        ID_Empleado = pID_Empleado
        ID_Dpto = pID_Dpto
        Nombre = pNombre
        Apellido = pApellido
        Telefono = pTelefono
        Edad = pEdad
        Correo = pCorreo
        Direccion = pDireccion
    End Sub


    Public ID_Contador As Integer
    Public ID_Empleado As String
    Public ID_Dpto As String
    Public Nombre As String
    Public Apellido As String
    Public Telefono As String
    Public Edad As String
    Public Correo As String
    Public Direccion As String

End Class
