Public Class FichaMedica

    Private iIdFichaMedica As Integer
    Private iFechaConsulta As DateTime
    Private iMotivo As String
    Private iEstudiosComplementarios As String
    Private iEvaluacion As String
    Private iIdPaciente As Integer

    Public Sub New(pIdFichaMedica As Integer, pFechaConsulta As DateTime, pMotivo As String, pEstCompl As String, pEvaluacion As String, pIdPaciente As Integer)
        iIdFichaMedica = pIdFichaMedica
        iFechaConsulta = pFechaConsulta
        iMotivo = pMotivo
        iEstudiosComplementarios = pEstCompl
        iEvaluacion = pEvaluacion
        iIdPaciente = pIdPaciente
    End Sub

    Public Property IdFichaMedica As Integer
        Get
            Return iIdFichaMedica
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property FechaConsulta As DateTime
        Get
            Return iFechaConsulta
        End Get
        Set(value As DateTime)

        End Set
    End Property

    Public Property Motivo As String
        Get
            Return iMotivo
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property EstudiosComplementarios As String
        Get
            Return iEstudiosComplementarios
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Evaluacion As String
        Get
            Return iEvaluacion
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

End Class
