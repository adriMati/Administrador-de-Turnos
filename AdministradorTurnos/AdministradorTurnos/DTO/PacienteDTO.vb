Public Class PacienteDTO

        Private iIdPaciente As Integer
        Private iNombre As String
        Private iDni As String
        Private iDomicilio As String
        Private iFechaNacimiento As DateTime
        Private iLocalidad As String
        Private iProvincia As String
        Private iTelefono As String
        Private iEmail As String
    Private iObraSocial As String
        Private iNumAfiliado As String
        Private iSexo As String

    Sub New(pIdPaciente As Integer, pNombre As String, pDni As String, pDomicilio As String, pFechaNacimiento As DateTime, pLocalidad As String, pProvincia As String, pTelefono As String, pEmail As String, pObraSocial As String, pNumAfiliado As String, pSexo As String)
        iIdPaciente = pIdPaciente
        iNombre = pNombre
        iDni = pDni
        iDomicilio = pDomicilio
        iFechaNacimiento = pFechaNacimiento
        iLocalidad = pLocalidad
        iProvincia = pProvincia
        iTelefono = pTelefono
        iEmail = pEmail
        iObraSocial = pObraSocial
        iNumAfiliado = pNumAfiliado
        iSexo = pSexo
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

    Public Property Localidad As String
        Get
            Return iLocalidad
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Provincia As String
        Get
            Return iProvincia
        End Get
        Set(value As String)

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

    Public Property ObraSocial As String
        Get
            Return iObraSocial
        End Get
        Set(value As String)

        End Set
    End Property

        Public Property NumAfiliado As String
            Get
                Return iNumAfiliado
            End Get
            Set(value As String)

            End Set
        End Property
    End Class
