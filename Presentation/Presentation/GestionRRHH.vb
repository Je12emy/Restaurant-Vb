Imports LOGICA
Imports CLASES
Imports System.Windows.Forms
Public Class GestionRRHH
    Dim Acceso As AccesoLogica = New AccesoLogica()



    Private Sub GestionRRHH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarEmpleados()
        MostrarLogins()
    End Sub

    '---------------------------------------Metodos Login----------------------------------------------
    Private Sub BtnLagregar_Click(sender As Object, e As EventArgs) Handles BtnLagregar.Click
        Dim ObjLogin As Logins = New Logins(txtLid_user.Text, txtLusername.Text, txtLpass.Text, VerificarTipo(cbLtipouser.Text))
        Acceso.InsertarUser(ObjLogin)
        MostrarLogins()
    End Sub

    Private Sub btnLmodificar_Click(sender As Object, e As EventArgs) Handles btnLmodificar.Click

        Dim ObjLogin As Logins = New Logins(txtLid_user.Text, txtLusername.Text, txtLpass.Text, VerificarTipo(cbLtipouser.Text))
        Acceso.ActualizarUser(ObjLogin, txtLid_user.Text)
        MostrarLogins()
    End Sub

    Private Sub btnLeliminar_Click(sender As Object, e As EventArgs) Handles btnLeliminar.Click
        Dim encontrado As Boolean = Acceso.EliminarUser(txtLid_user.Text)
        If encontrado = True Then
            MessageBox.Show("Registro Eliminado")
        Else
            MessageBox.Show("El Registro No pudo ser Eliminado")
        End If
        MostrarLogins()
    End Sub

    Function VerificarTipo(Tipo As String) As Integer
        Dim id As Integer = 0
        If Tipo = "ADMIN" Then
            id = 1
        Else
            If Tipo = "COCIN" Then
                id = 2
            Else
                If Tipo = "MESER" Then
                    id = 3
                Else
                    If Tipo = "BODEG" Then
                        id = 4
                    End If
                End If
            End If
        End If
        Return id
    End Function



    Private Sub MostrarLogins()
        Dim Milista As List(Of Logins) = New List(Of Logins)

        Milista = Acceso.ListaLogins()

        dgvLogin.Rows.Clear()
        For Each elemento In Milista
            Dim fila As String()
            fila = New String() {elemento.ID_usuario, elemento.Username, elemento.Pass}
            dgvLogin.Rows.Add(fila)
        Next
    End Sub
    Private Sub dgvLogin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogin.CellClick
        Dim fila As Integer = dgvLogin.CurrentRow.Index
        txtLid_user.Text = dgvLogin(0, fila).Value.ToString()
        txtLusername.Text = dgvLogin(1, fila).Value.ToString()
        txtLpass.Text = dgvLogin(2, fila).Value.ToString()
    End Sub

    '---------------------------------------Metodos Empleados------------------------------------------
    Private Sub dgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick

        Try
            Dim fila As Integer = dgvEmpleados.CurrentRow.Index
            cbID_DPTO.Text = dgvEmpleados(2, fila).Value.ToString()
            txtEnombre.Text = dgvEmpleados(3, fila).Value.ToString()
            txtEapellido.Text = dgvEmpleados(4, fila).Value.ToString()
            mtEtelefono.Text = dgvEmpleados(5, fila).Value.ToString()
            mtEdad.Text = dgvEmpleados(6, fila).Value.ToString()
            txtEcorreo.Text = dgvEmpleados(7, fila).Value.ToString()
            txtEdireccion.Text = dgvEmpleados(8, fila).Value.ToString()
            txtLid_user.Text = dgvEmpleados(1, fila).Value.ToString()
            txtLusername.Text = txtEcorreo.Text
            txtLpass.Text = txtEnombre.Text
            cbID_DPTO.Text = cbLtipouser.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEAgregar_Click(sender As Object, e As EventArgs) Handles btnEAgregar.Click
        Dim Cod As String = cbID_DPTO.Text + mtID_EM.Text
        Dim id As Integer
        Dim ObjEmpleado As Empleados = New Empleados(id, Cod, cbID_DPTO.Text, txtEnombre.Text, txtEapellido.Text, mtEtelefono.Text, mtEdad.Text, txtEcorreo.Text, txtEdireccion.Text)
        Acceso.InsertarEmpleado(ObjEmpleado)
        MostrarEmpleados()
    End Sub
    Private Sub MostrarEmpleados()
        Dim Milista As List(Of Empleados) = New List(Of Empleados)

        Milista = Acceso.ListaEmpleados()

        dgvEmpleados.Rows.Clear()
        For Each elemento In Milista
            Dim fila As String()
            fila = New String() {elemento.ID_Contador, elemento.ID_Empleado, elemento.ID_Dpto, elemento.Nombre, elemento.Apellido, elemento.Telefono, elemento.Edad, elemento.Correo, elemento.Direccion}
            dgvEmpleados.Rows.Add(fila)
        Next
    End Sub
    Private Sub btnEModificar_Click(sender As Object, e As EventArgs) Handles btnEModificar.Click
        Dim fila As Integer = dgvEmpleados.CurrentRow.Index
        Dim Cod As String = cbID_DPTO.Text + mtID_EM.Text

        Dim id As Integer = dgvEmpleados(0, fila).Value
        Dim ObjEmpleado As Empleados = New Empleados(id, Cod, cbID_DPTO.Text, txtEnombre.Text, txtEapellido.Text, mtEtelefono.Text, mtEdad.Text, txtEcorreo.Text, txtEdireccion.Text)
        Acceso.ActualizarEmpleado(ObjEmpleado, id)
        MostrarEmpleados()
    End Sub

    Private Sub btnEeliminar_Click(sender As Object, e As EventArgs) Handles btnEeliminar.Click

        Dim fila As Integer = dgvEmpleados.CurrentRow.Index
        Dim id As Integer = dgvEmpleados(0, fila).Value

        Dim encontrado As Boolean = Acceso.EliminarEmpleado(id)
        If encontrado = True Then
            MessageBox.Show("Registro Eliminado")
        Else
            MessageBox.Show("El Registro No pudo ser Eliminado")
        End If
        MostrarEmpleados()
    End Sub


End Class