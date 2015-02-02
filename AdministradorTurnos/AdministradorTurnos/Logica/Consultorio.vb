Public Class Consultorio

    Private iListaPacientes As IList(Of Paciente)
    Private iListaTurnos As IList(Of Turno)
    Private Shared iInstancia As Consultorio


    Private Sub New()
        iListaPacientes = New List(Of Paciente)
        iListaTurnos = New List(Of Turno)
    End Sub


    Public Shared Function Instancia() As Consultorio
        If IsNothing(iInstancia) Then
            iInstancia = New Consultorio()
        End If
        Return iInstancia
    End Function

    Public Sub CrearTurno(pTurno As Turno)
        If IsNothing(pTurno) Then
            Throw New NullReferenceException
        End If
        Dim turno As Turno = (From t In iListaTurnos Where t.Fecha = pTurno.Fecha And t.Hora = pTurno.Hora Select t).ToList().FirstOrDefault()
        If IsNothing(turno) Then
            iListaTurnos.Add(pTurno)
        Else
            turno.IdTurno = pTurno.IdTurno
            turno.IdPaciente = pTurno.IdPaciente
            turno.Motivo = pTurno.Motivo
            turno.NombrePaciente = pTurno.NombrePaciente
        End If
    End Sub

    ''' <summary>
    ''' Permite guardar un nuevo turno en base de datos
    ''' </summary>
    ''' <param name="pTurno"></param>
    ''' <remarks></remarks>
    Public Sub GuardarTurno(pTurno As Turno)
        Dim sqlserver As SQLServerFactory = New SQLServerFactory()
        sqlserver.NuevoTurno(pTurno)
    End Sub

    Public Sub AnularTurno(pIdTurno As Integer)
        Dim sqlserver As SQLServerFactory = New SQLServerFactory()
        sqlserver.EliminarTurno(pIdTurno)
    End Sub

    Public Sub GuardarFichaMedica(pFichaMedica As FichaMedica)
        Dim sqlserver As SQLServerFactory = New SQLServerFactory()
        sqlserver.NuevaFichaMedica(pFichaMedica)
    End Sub

    Public Sub NuevoPaciente(pPaciente As Paciente)
        Dim sqlserver As SQLServerFactory = New SQLServerFactory()
        sqlserver.NuevoPaciente(pPaciente)
    End Sub

    Public Sub ModificarPaciente(pPaciente As Paciente)
        Dim sqlserver As SQLServerFactory = New SQLServerFactory()
        sqlserver.ModificarPaciente(pPaciente)
    End Sub

    Public Sub EliminarPaciente(pPaciente As Paciente)
        Dim sqlserver As SQLServerFactory = New SQLServerFactory()
        sqlserver.EliminarPaciente(pPaciente)
    End Sub

    Public Function Turnos(fecha As Date) As IList(Of Turno)
        Return (From t In iListaTurnos Where t.Fecha = fecha Select t).ToList()
    End Function

    Public Sub GenerarTurnos(fecha As DateTime)
        Dim hora As DateTime = turnosConfig.Default.horaComienzo
            Dim horaFin As DateTime = turnosConfig.Default.horaFin
            Dim turnos As DataTable = New SQLServerFactory().ListaTurnos(fecha)
        While hora <= horaFin
            Dim turno As New Turno(0, fecha, hora, "", 0, "")
            For Each row As DataRow In turnos.Rows
                Dim horaTurno As DateTime = row.Item("hora")
                If hora = horaTurno Then
                    turno.IdTurno = CStr(row("idTurno"))
                    turno.NombrePaciente = CStr(row("paciente"))
                    turno.Motivo = CStr(row("motivoTurno"))
                    turno.IdPaciente = CStr(row("idPaciente"))
                End If
            Next
            Consultorio.Instancia.CrearTurno(turno)
            hora = hora.AddMinutes(turnosConfig.Default.intervaloTurno)
        End While
    End Sub

    Public Function BuscarPaciente(idPaciente As Integer) As PacienteDTO
        Dim sql As New SQLServerFactory()
        Return sql.BuscarPaciente(idPaciente)
    End Function

    Public Function FichasMedicasDe(pIdPaciente As Integer) As DataTable
        Dim sql As New SQLServerFactory()
        Return sql.ListaFichasMedicas(pIdPaciente)
    End Function

    Public Sub ModificarFichaMedica(pFichaMedica As FichaMedica)
        Dim sql As New SQLServerFactory()
        sql.ModificarFichaMedica(pFichaMedica)
    End Sub

    Public Function ValidarDatosUsuario(pUsuario As UsuarioDTO) As Boolean
        Dim Sql As New SQLServerFactory()
        Dim usuario As UsuarioDTO = Sql.BuscarUsuario(pUsuario.Usuario)
        If usuario.Contraseña = pUsuario.Contraseña Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
