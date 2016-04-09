Public Class Mesas
    Public Sub New(pID As Integer, pStatusMesa As String, pCantidad_Personas As String, pOrdenes As String, pMesonero As String)

        ID = pID
        StatusMesa = pStatusMesa
        Cantidad_Personas = pCantidad_Personas
        Ordenes = pOrdenes
        ID_Mesonero = pMesonero

    End Sub

    Public ID As Integer
    Public StatusMesa As String
    Public Cantidad_Personas As String
    Public Ordenes As String
    Public ID_Mesonero As String




    'Mesa:

    'PK ID MESA
    '- STATUS MESA
    '- CANTIDAD DE PERSONAS
    'FK ORDENES/PLATILLOS
    '- MESONERO


End Class
