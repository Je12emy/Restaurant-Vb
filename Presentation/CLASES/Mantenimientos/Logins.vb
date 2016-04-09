Public Class Logins


    Public Sub New(pID_usuario As String, pUsername As String, pPass As String, pTipo_User As Integer)

        ID_usuario = pID_usuario
        Username = pUsername
        Pass = pPass
        Tipo_User = pTipo_User

    End Sub

    Public ID_usuario As String
    Public Username As String
    Public Pass As String
    Public Tipo_User As Integer
End Class
