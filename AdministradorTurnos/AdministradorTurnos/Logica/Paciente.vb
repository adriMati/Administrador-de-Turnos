''' <summary>
''' Representa un paciente del consultorio
''' </summary>
''' <remarks></remarks>
Public Class Paciente

    Private iIdPaciente As Integer
    Private iNombre As String
    Private iDni As String
    Private iDomicilio As String
    Private iFechaNacimiento As DateTime
    Private iIdLocalidad As Integer
    Private iIdProvincia As Integer
    Private iTelefono As String
    Private iEmail As String
    Private iIdObraSocial As Integer
    Private iNumAfiliado As String
    Private iSexo As String
    Private iListaFichas As IList(Of FormFichaMedica)

    Sub New(pIdPaciente As Integer, pNombre As String, pDni As String, pDomicilio As String, pFechaNacimiento As DateTime, pIdLocalidad As Integer, pIdProvincia As Integer, pTelefono As String, pEmail As String, pIdObraSocial As Integer, pNumAfiliado As String, pSexo As String)
        iIdPaciente = pIdPaciente
        iNombre = pNombre
        iDni = pDni
        iDomicilio = pDomicilio
        iFechaNacimiento = pFechaNacimiento
        iIdLocalidad = pIdLocalidad
        iIdProvincia = pIdProvincia
        iTelefono = pTelefono
        iEmail = pEmail
        iIdObraSocial = pIdObraSocial
        iNumAfiliado = pNumAfiliado
        iSexo = pSexo
        iListaFichas = New List(Of FormFichaMedica)
    End Sub

    Public Property Nombre As String
        Get
            Return iNombre
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return iDomicilio
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Dni As String
        Get
            Return iDni
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property IdPaciente As Integer
        Get
            Return iIdPaciente
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property IdLocalidad As Integer
        Get
            Return iIdLocalidad
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property IdProvincia As Integer
        Get
            Return iIdProvincia
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property Sexo As String
        Get
            Return iSexo
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property FechaNacimiento As DateTime
        Get
            Return iFechaNacimiento
        End Get
        Set(value As DateTime)

        End Set
    End Property


    Public Property Telefono As String
        Get
            Return iTelefono
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Email As String
        Get
            Return iEmail
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property IdObraSocial As Integer
        Get
            Return iIdObraSocial
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property NumAfiliado As String
        Get
            Return iNumAfiliado
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Fichas As IList(Of FormFichaMedica)
        Get
            Return iListaFichas
        End Get
        Set(value As IList(Of FormFichaMedica))

        End Set
    End Property


    ''' <summary>
    ''' Agrega una nueva ficha Medica al paciente
    ''' </summary>
    ''' <param name="pFicha"></param>
    ''' <remarks></remarks>
    Public Sub NuevaFichaMedica(pFicha As FormFichaMedica)
        If Not iListaFichas.Contains(pFicha) Then
            iListaFichas.Add(pFicha)
        End If
    End Sub




End Class
