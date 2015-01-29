Public Class Turno

    Private iIdTurno As Integer
    Private iFechaTurno As DateTime
    Private iHoraTurno As String
    Private iMotivoTurno As String
    Private iIdPaciente As Integer
    Private iNombrePaciente As String

    Public Sub New(pIdTurno As Integer, pFechaTurno As DateTime, pHoraTurno As String, pMotivoTurno As String, pIdPaciente As Integer, pNombrePaciente As String)
        iIdTurno = pIdTurno
        iFechaTurno = pFechaTurno
        iHoraTurno = pHoraTurno
        iMotivoTurno = pMotivoTurno
        iIdPaciente = pIdPaciente
        iNombrePaciente = pNombrePaciente
    End Sub

    Public Property IdTurno As Integer
        Get
            Return iIdTurno
        End Get
        Set(value As Integer)
            iIdTurno = value
        End Set
    End Property

    Public Property Fecha As DateTime
        Get
            Return iFechaTurno
        End Get
        Set(value As DateTime)
            iFechaTurno = value
        End Set
    End Property

    Public Property Hora As String
        Get
            Return iHoraTurno
        End Get
        Set(value As String)
            iHoraTurno = value
        End Set
    End Property

    Public Property Motivo As String
        Get
            Return iMotivoTurno
        End Get
        Set(value As String)
            iMotivoTurno = value
        End Set
    End Property

    Public Property IdPaciente As Integer
        Get
            Return iIdPaciente
        End Get
        Set(value As Integer)
            iIdPaciente = value
        End Set
    End Property

    Public Property NombrePaciente As String
        Get
            Return iNombrePaciente
        End Get
        Set(value As String)
            iNombrePaciente = value
        End Set
    End Property



End Class
