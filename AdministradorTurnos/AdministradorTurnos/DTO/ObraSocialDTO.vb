Public Class ObraSocialDTO
    Private iIdOSocial As Integer
    Private iCodigo As String
    Private iNombre As String
    Private iEstado As String

    Public Sub New(pIdOSocial As Integer, pCodigo As String, pNombre As String, pEstado As String)
        iIdOSocial = pIdOSocial
        iCodigo = pCodigo
        iNombre = pNombre
        iEstado = pEstado
    End Sub

    Public Property Nombre As String
        Get
            Return iNombre
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property IdOSocial As Integer
        Get
            Return iIdOSocial
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property Codigo As String
        Get
            Return iCodigo
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Estado As String
        Get
            Return iEstado
        End Get
        Set(value As String)

        End Set
    End Property
End Class
