Public Class UsuarioDTO
    Private iUsuario As String
    Private iIdUsuario As Integer
    Private iContraseña As String
    Private iPermisoAdministrador As Boolean
    Private iPermisoSecretaria As Boolean

    Public Sub New(pIdUsuario As Integer, pUsuario As String, pContraseña As String, pPermisoAdministrador As Boolean, pPermisoSecretaria As Boolean)
        iUsuario = pUsuario
        iIdUsuario = pIdUsuario
        iContraseña = pContraseña
        iPermisoAdministrador = pPermisoAdministrador
        iPermisoSecretaria = pPermisoSecretaria
    End Sub

    Public Property Usuario As String
        Get
            Return iUsuario
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property IdUsuario As String
        Get
            Return iIdUsuario
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return iContraseña
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property PermisoAdministrador As Boolean
        Get
            Return iPermisoAdministrador
        End Get
        Set(value As Boolean)

        End Set
    End Property

    Public Property PermisoSecretaria As Boolean
        Get
            Return iPermisoSecretaria
        End Get
        Set(value As Boolean)

        End Set
    End Property
End Class
