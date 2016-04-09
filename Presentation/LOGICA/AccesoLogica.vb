
Imports CLASES
Imports DATOS


Public Class AccesoLogica
    Dim Accesodatos As Conexiones = New Conexiones()


    '-------------------------------Metodos de Logins-------------------------------
    Public Function ListaLogins() As List(Of Logins)
        Return Accesodatos.ListaLogin()
    End Function
    Public Sub InsertarUser(ObjLogin As Logins)
        Accesodatos.InsertarUser(ObjLogin)
    End Sub


    Public Sub ActualizarUser(ObjLogin As Logins, id As String)
        Accesodatos.ActualizarUser(ObjLogin, id)
    End Sub

    Public Function EliminarUser(id As String) As Boolean
        Dim encontrado As Boolean = Accesodatos.EliminarUser(id)
        Return encontrado
    End Function

    Public Function VerificarUsuario(user As String, pass As String) As Integer
        Dim tipouser As Integer = Accesodatos.VerificarUsuario(user, pass)
        Return tipouser
    End Function
    Public Function ObtenerId(user As String) As String
        Dim id As String = Accesodatos.Obtenerid(user)
        Return id
    End Function

    '-------------------------------Metodos de Bodega-------------------------------

    Public Function ListaDepositos() As List(Of Depositos)
        Return Accesodatos.ListaDepositos()
    End Function

    Public Sub InsertarAlimento(ObjDeposito As Depositos)
        Accesodatos.InsertarAlimento(ObjDeposito)
    End Sub
    Public Sub ActualizarAlimento(ObjDeposito As Depositos, id As Integer)
        Accesodatos.ActualizarAlimento(ObjDeposito, id)
    End Sub
    Public Function EliminarAlimento(id As Integer) As Boolean
        Dim encontrado As Boolean = Accesodatos.EliminarAlimento(id)
        Return encontrado
    End Function


    '------------------------------Metodos de Los Empleados-------------------------
    Public Function ListaEmpleados() As List(Of Empleados)
        Return Accesodatos.ListaEmpleados()
    End Function
    Public Sub InsertarEmpleado(ObjEmpleado As Empleados)
        Accesodatos.InsertarEmpleado(ObjEmpleado)
    End Sub

    Public Sub ActualizarEmpleado(ObjEmpleado As Empleados, id As Integer)
        Accesodatos.ActualizarEmpleado(ObjEmpleado, id)
    End Sub

    Public Function EliminarEmpleado(id As Integer) As Boolean
        Dim encontrado As Boolean = Accesodatos.EliminarEmpleado(id)
        Return encontrado
    End Function
    '------------------------------Metodos de Las Cajas-----------------------------
    Public Function ListaCajaExp(ID As String) As List(Of Cajas)
        Return Accesodatos.ListaCajasExp(ID)
    End Function

    Public Sub InsertarOrden(ObjMenus As Cajas)
        Accesodatos.InsertarOrden(ObjMenus)
    End Sub

    Public Function EliminarOrden(id As Integer) As Boolean
        Dim encontrado As Boolean = Accesodatos.EliminarOrden(id)
        Return encontrado
    End Function

    '------------------------------Metodos de Las Menus-----------------------------
    Public Function ListaMenus() As List(Of Menus)
        Return Accesodatos.ListaMenus()
    End Function

    Public Sub InsertarMenu(ObjMenus As Menus)
        Accesodatos.InsertarMenu(ObjMenus)
    End Sub

    Public Sub ActualizarMenu(ObjMenu As Menus, id As Integer)
        Accesodatos.ActualizarMenu(ObjMenu, id)
    End Sub
    Public Function ListaMenuExp(ID As String) As List(Of Menus)
        Return Accesodatos.ListaMenuExp(ID)
    End Function
    Public Function EliminarMenu(id As Integer) As Boolean
        Dim encontrado As Boolean = Accesodatos.EliminarMenu(id)
        Return encontrado
    End Function
    '------------------------------Metodos de Las Mesas-----------------------------
    Public Function ListaMesas() As List(Of Mesas)
        Return Accesodatos.ListaMesas()
    End Function

    Public Sub InsertarMesa(ObjMesa As Mesas)
        Accesodatos.InsertarMesa(ObjMesa)
    End Sub

    Public Sub ActualizarMesas(ObjMesa As Mesas, id As Integer)
        Accesodatos.ActualizarMesa(ObjMesa, id)
    End Sub


End Class
