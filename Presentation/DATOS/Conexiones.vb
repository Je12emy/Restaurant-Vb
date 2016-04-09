Imports CLASES


Public Class Conexiones


    '-------------------------------Metodos de Login ----------------------------------
    Public Function ListaLogin() As List(Of Logins)

        Dim MiLista As List(Of Logins) = New List(Of Logins)

        Dim Contexto As ContextoDataContext = New ContextoDataContext()

        Dim Consulta = (From tabla In Contexto.Logins Select tabla).ToList


        For Each elemento In Consulta
            Dim Objeto As Logins = New Logins(elemento.ID_USER, elemento.USERNAME, elemento.PASS, elemento.TIPO_USER)
            MiLista.Add(Objeto)
        Next
        Return MiLista
    End Function

    Public Sub InsertarUser(ObjLogin As Logins)
        Dim nuevo As Login = New Login()
        nuevo.ID_USER = ObjLogin.ID_usuario
        nuevo.USERNAME = ObjLogin.Username
        nuevo.PASS = ObjLogin.Pass
        nuevo.TIPO_USER = ObjLogin.Tipo_User
        Dim Contexto As ContextoDataContext = New ContextoDataContext()
        Contexto.Logins.InsertOnSubmit(nuevo)
        Contexto.SubmitChanges()
    End Sub

    Public Sub ActualizarUser(ObjLogin As Logins, id As String)
        Dim contexto As ContextoDataContext = New ContextoDataContext()
        Dim consulta = (From tabla In contexto.Logins Where tabla.ID_USER = id Select tabla)
        For Each actualizar In consulta
            actualizar.ID_USER = ObjLogin.ID_usuario
            actualizar.USERNAME = ObjLogin.Username
            actualizar.PASS = ObjLogin.Pass
            actualizar.TIPO_USER = ObjLogin.Tipo_User
        Next
        contexto.SubmitChanges()
    End Sub

    Function VerificarUsuario(user As String, pass As String) As Integer
        Dim contexto As New ContextoDataContext()
        Dim consulta = (From tabla In contexto.Logins Where tabla.USERNAME = user And tabla.PASS = pass Select tabla).ToList()

        Dim tipouser As Integer = 0
        For Each elemento In consulta
            tipouser = elemento.TIPO_USER

        Next
        Return tipouser
    End Function
    Function Obtenerid(user As String) As String
        Dim contexto As New ContextoDataContext()
        Dim consulta = (From tabla In contexto.Logins Where tabla.USERNAME = user Select tabla).ToList()

        Dim id As String = "N/A"
        For Each elemento In consulta
            id = elemento.ID_USER
        Next
        Return id
    End Function

    Public Function EliminarUser(id As String) As Boolean
        Try
            Dim Contexto As ContextoDataContext = New ContextoDataContext()
            Dim consulta = (From tabla In Contexto.Logins Where tabla.ID_USER = id Select tabla)
            For Each eliminar As Login In consulta
                Contexto.Logins.DeleteOnSubmit(eliminar)
            Next
            Contexto.SubmitChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    '-------------------------------Metodos de Bodega ----------------------------------
    Public Function ListaDepositos() As List(Of Depositos)

        Dim MiLista As List(Of Depositos) = New List(Of Depositos)

        Dim Contexto As ContextoDataContext = New ContextoDataContext()

        Dim Consulta = (From tabla In Contexto.Depositos Select tabla).ToList


        For Each elemento In Consulta
            Dim Objeto As Depositos = New Depositos(elemento.ID_CTR, elemento.ID_PRODUCTO, elemento.DESCRIPCION, elemento.CANTIDAD)
            MiLista.Add(Objeto)
        Next
        Return MiLista
    End Function

    Public Sub InsertarAlimento(ObjDepositos As Depositos)
        Dim nuevo As Deposito = New Deposito()
        nuevo.ID_PRODUCTO = ObjDepositos.ID_Producto
        nuevo.DESCRIPCION = ObjDepositos.Descripcion
        nuevo.CANTIDAD = ObjDepositos.Cantidad
        Dim Contexto As ContextoDataContext = New ContextoDataContext()
        Contexto.Depositos.InsertOnSubmit(nuevo)
        Contexto.SubmitChanges()
    End Sub

    Public Sub ActualizarAlimento(ObjDepositos As Depositos, id As Integer)
        Dim contexto As ContextoDataContext = New ContextoDataContext()
        Dim consulta = (From tabla In contexto.Depositos Where tabla.ID_CTR = id Select tabla)

        For Each actualizar In consulta
            actualizar.ID_PRODUCTO = ObjDepositos.ID_Producto
            actualizar.DESCRIPCION = ObjDepositos.Descripcion
            actualizar.CANTIDAD = ObjDepositos.Cantidad

        Next
        contexto.SubmitChanges()

    End Sub

    Public Function EliminarAlimento(id As Integer) As Boolean
        Try
            Dim Contexto As ContextoDataContext = New ContextoDataContext()
            Dim consulta = (From tabla In Contexto.Depositos Where tabla.ID_CTR = id Select tabla)
            For Each eliminar As Deposito In consulta
                Contexto.Depositos.DeleteOnSubmit(eliminar)
            Next
            Contexto.SubmitChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '------------------------------Metodos de Las Empleados-----------------------------
    Public Function ListaEmpleados() As List(Of Empleados)

        Dim MiLista As List(Of Empleados) = New List(Of Empleados)

        Dim Contexto As ContextoDataContext = New ContextoDataContext()

        Dim Consulta = (From tabla In Contexto.Empleados Select tabla).ToList


        For Each elemento In Consulta
            Dim Objeto As Empleados = New Empleados(elemento.ID_CTR, elemento.ID_EMPLEADO, elemento.ID_DPTO, elemento.NOMBRE, elemento.APELLIDO, elemento.TELEFONO, elemento.EDAD, elemento.CORREO, elemento.DIRECCION)
            MiLista.Add(Objeto)
        Next
        Return MiLista
    End Function
    Public Sub InsertarEmpleado(ObjEmpleado As Empleados)

        Dim nuevo As Empleado = New Empleado()
        nuevo.ID_EMPLEADO = ObjEmpleado.ID_Empleado
        nuevo.ID_DPTO = ObjEmpleado.ID_Dpto
        nuevo.NOMBRE = ObjEmpleado.Nombre
        nuevo.APELLIDO = ObjEmpleado.Apellido
        nuevo.TELEFONO = ObjEmpleado.Telefono
        nuevo.EDAD = ObjEmpleado.Edad
        nuevo.CORREO = ObjEmpleado.Correo
        nuevo.DIRECCION = ObjEmpleado.Direccion
        Dim Contexto As ContextoDataContext = New ContextoDataContext()
        Contexto.Empleados.InsertOnSubmit(nuevo)
        Contexto.SubmitChanges()
    End Sub

    Public Sub ActualizarEmpleado(ObjEmpleado As Empleados, id As Integer)
        Dim contexto As ContextoDataContext = New ContextoDataContext()
        Dim consulta = (From tabla In contexto.Empleados Where tabla.ID_CTR = id Select tabla)

        For Each actualizar In consulta
            actualizar.ID_EMPLEADO = ObjEmpleado.ID_Empleado
            actualizar.ID_DPTO = ObjEmpleado.ID_Dpto
            actualizar.NOMBRE = ObjEmpleado.Nombre
            actualizar.APELLIDO = ObjEmpleado.Apellido
            actualizar.EDAD = ObjEmpleado.Edad
            actualizar.CORREO = ObjEmpleado.Correo
            actualizar.DIRECCION = ObjEmpleado.Direccion

        Next
        contexto.SubmitChanges()

    End Sub

    Public Function EliminarEmpleado(id As Integer) As Boolean
        Try
            Dim Contexto As ContextoDataContext = New ContextoDataContext()
            Dim consulta = (From tabla In Contexto.Empleados Where tabla.ID_CTR = id Select tabla)
            For Each eliminar As Empleado In consulta
                Contexto.Empleados.DeleteOnSubmit(eliminar)
            Next
            Contexto.SubmitChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    '------------------------------Metodos de Las Cajas-----------------------------
    Public Function ListaCajasExp(id As String) As List(Of Cajas)

        Dim MiLista As List(Of Cajas) = New List(Of Cajas)

        Dim Contexto As ContextoDataContext = New ContextoDataContext()

        Dim Consulta = (From tabla In Contexto.Cajas Where tabla.ID_MESA = id Select tabla).ToList


        For Each elemento In Consulta
            Dim Objeto As Cajas = New Cajas(elemento.ID_FACTURA, elemento.ID_MESA, elemento.PRODUCTO, elemento.CANTIDAD, elemento.PRECIO, elemento.TOTAL)
            MiLista.Add(Objeto)
        Next
        Return MiLista
    End Function

    Public Sub InsertarOrden(ObjCaja As Cajas)

        Dim nuevo As Caja = New Caja()
        nuevo.ID_MESA = ObjCaja.ID_Mesa
        nuevo.PRODUCTO = ObjCaja.Producto
        nuevo.CANTIDAD = ObjCaja.Cantidad
        nuevo.PRECIO = ObjCaja.Precio
        nuevo.TOTAL = ObjCaja.Total
        Dim Contexto As ContextoDataContext = New ContextoDataContext()
        Contexto.Cajas.InsertOnSubmit(nuevo)
        Contexto.SubmitChanges()
    End Sub

    Public Function EliminarOrden(id As Integer) As Boolean
        Try
            Dim Contexto As ContextoDataContext = New ContextoDataContext()
            Dim consulta = (From tabla In Contexto.Cajas Where tabla.ID_FACTURA = id Select tabla)
            For Each eliminar As Caja In consulta
                Contexto.Cajas.DeleteOnSubmit(eliminar)
            Next
            Contexto.SubmitChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub ActualizarOrdenM(ObjCaja As Cajas, id As Integer, pProducto As String)
        Dim contexto As ContextoDataContext = New ContextoDataContext()
        Dim consulta = (From tabla In contexto.Cajas Where tabla.ID_MESA = id And tabla.PRODUCTO Select tabla)

        For Each actualizar In consulta
            actualizar.ID_MESA = ObjCaja.ID_Mesa
            actualizar.PRODUCTO = ObjCaja.Producto
            actualizar.CANTIDAD = ObjCaja.Cantidad
        Next
        contexto.SubmitChanges()

    End Sub


    '------------------------------Metodos de Las Menus-----------------------------
    Public Function ListaMenus() As List(Of Menus)
        Dim MiLista As List(Of Menus) = New List(Of Menus)

        Dim Contexto As ContextoDataContext = New ContextoDataContext()

        Dim Consulta = (From tabla In Contexto.Menus Select tabla).ToList

        For Each elemento In Consulta
            Dim Objeto As Menus = New Menus(elemento.ID_PLATO, elemento.ID_TIPO, elemento.NOMBRE, elemento.DESCRIPCION, elemento.PRECIO)
            MiLista.Add(Objeto)
        Next
        Return MiLista
    End Function


    Public Function ListaMenuExp(id As String) As List(Of Menus)

        Dim MiLista As List(Of Menus) = New List(Of Menus)

        Dim Contexto As ContextoDataContext = New ContextoDataContext()

        Dim Consulta = (From tabla In Contexto.Menus Where tabla.ID_TIPO = id Select tabla).ToList


        For Each elemento In Consulta
            Dim Objeto As Menus = New Menus(elemento.ID_PLATO, elemento.ID_TIPO, elemento.NOMBRE, elemento.DESCRIPCION, elemento.PRECIO)
            MiLista.Add(Objeto)
        Next
        Return MiLista
    End Function

    Public Sub InsertarMenu(ObjMenu As Menus)

        Dim nuevo As Menu = New Menu()

        nuevo.ID_TIPO = ObjMenu.ID_TIPO
        nuevo.NOMBRE = ObjMenu.Nombre
        nuevo.DESCRIPCION = ObjMenu.Descripcion
        nuevo.PRECIO = ObjMenu.Precio
        Dim Contexto As ContextoDataContext = New ContextoDataContext()
        Contexto.Menus.InsertOnSubmit(nuevo)
        Contexto.SubmitChanges()
    End Sub

    Public Sub ActualizarMenu(ObjMenu As Menus, id As Integer)
        Dim contexto As ContextoDataContext = New ContextoDataContext()
        Dim consulta = (From tabla In contexto.Menus Where tabla.ID_PLATO = id Select tabla)

        For Each actualizar In consulta
            actualizar.ID_TIPO = ObjMenu.ID_TIPO
            actualizar.NOMBRE = ObjMenu.Nombre
            actualizar.DESCRIPCION = ObjMenu.Descripcion
            actualizar.PRECIO = ObjMenu.Precio
        Next
        contexto.SubmitChanges()

    End Sub
    Public Function EliminarMenu(id As Integer) As Boolean
        Try
            Dim Contexto As ContextoDataContext = New ContextoDataContext()
            Dim consulta = (From tabla In Contexto.Menus Where tabla.ID_PLATO = id Select tabla)
            For Each eliminar As Menu In consulta
                Contexto.Menus.DeleteOnSubmit(eliminar)
            Next
            Contexto.SubmitChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '------------------------------Metodos de Las Mesas-----------------------------
    Public Function ListaMesas() As List(Of Mesas)
        Dim MiLista As List(Of Mesas) = New List(Of Mesas)

        Dim Contexto As ContextoDataContext = New ContextoDataContext()

        Dim Consulta = (From tabla In Contexto.Mesas Select tabla).ToList

        For Each elemento In Consulta
            Dim Objeto As Mesas = New Mesas(elemento.ID_MESA, elemento.ESTADO, elemento.CAPACIDAD, elemento.ORDENES, elemento.ID_MESONERO)
            MiLista.Add(Objeto)
        Next
        Return MiLista
    End Function
    Public Sub InsertarMesa(ObjMesa As Mesas)

        Dim nuevo As Mesa = New Mesa()

        nuevo.ESTADO = ObjMesa.StatusMesa
        nuevo.ORDENES = ObjMesa.Ordenes
        nuevo.CAPACIDAD = ObjMesa.Cantidad_Personas
        nuevo.ID_MESONERO = ObjMesa.ID_Mesonero
        Dim Contexto As ContextoDataContext = New ContextoDataContext()
        Contexto.Mesas.InsertOnSubmit(nuevo)
        Contexto.SubmitChanges()

    End Sub
    Public Sub ActualizarMesa(ObjMesa As Mesas, id As Integer)
        Dim contexto As ContextoDataContext = New ContextoDataContext()
        Dim consulta = (From tabla In contexto.Mesas Where tabla.ID_MESA = id Select tabla)

        For Each actualizar In consulta
            actualizar.ESTADO = ObjMesa.StatusMesa
            actualizar.CAPACIDAD = ObjMesa.Cantidad_Personas
            actualizar.ORDENES = ObjMesa.Ordenes
            actualizar.ID_MESONERO = ObjMesa.ID_Mesonero
        Next
        contexto.SubmitChanges()

    End Sub


End Class
