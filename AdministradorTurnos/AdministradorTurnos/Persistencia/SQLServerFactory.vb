Imports System.Data.SqlClient
Public Class SQLServerFactory
    Private iConexion As SqlConnection
    Private iTransaccion As SqlTransaction
    Private conexion As String = "Data Source=" + bdConfig.Default.equipo + "; INITIAL Catalog=Turnos; Persist Security Info=True;User ID=" + bdConfig.Default.usuario + ";Password=" + bdConfig.Default.contraseña

    Public Sub New()
    End Sub

    Private ReadOnly Property ObtenerConexion As SqlConnection
        Get
            If iConexion.State = System.Data.ConnectionState.Closed Then
                Try
                    iConexion.Open()
                Catch ex As SqlException
                    Throw New DAOExcepcion("No se pudo realizar la conexión a la base de datos, reintente mas tarde")
                End Try
            End If
            Return iConexion
        End Get
    End Property

    Private Sub ComenzarTransaccion()
        iTransaccion = iConexion.BeginTransaction()
    End Sub


    Private Sub Commit()
        iTransaccion.Commit()
    End Sub


    Private Sub IniciarConexion()
        If IsNothing(iConexion) Then
            iConexion = New SqlConnection(conexion)
        End If
        iConexion = ObtenerConexion
    End Sub

    Private Sub FinalizarConexion()
        If Not IsDBNull(iConexion) Then
            iConexion.Close()
        End If
    End Sub

    Private Sub RollBack()
        iTransaccion.Rollback()
    End Sub

    Public Sub NuevoTurno(pTurno As Turno)
        Try
            IniciarConexion()
            ComenzarTransaccion()
            Dim insertar As New SqlCommand("insert into Turnos values ('" & pTurno.Fecha & "','" & pTurno.Hora & "','" & pTurno.IdPaciente & "','" & pTurno.Motivo & "')", iConexion, iTransaccion)
            insertar.ExecuteNonQuery()
            Commit()
            FinalizarConexion()
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Sub NuevaObraSocial(pObraSocial As ObraSocialDTO)
        Try
            IniciarConexion()
            ComenzarTransaccion()
            Dim insertar As New SqlCommand("insert into ObrasSociales values ('" & pObraSocial.Codigo & "','" & pObraSocial.Nombre & "','" & pObraSocial.Estado & "')", iConexion, iTransaccion)
            insertar.ExecuteNonQuery()
            Commit()
            FinalizarConexion()
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Sub EliminarTurno(pIdTurno As Integer)
        Try
            IniciarConexion()
            ComenzarTransaccion()
            Dim insertar As New SqlCommand("delete Turnos where idTurno = '" & pIdTurno & "'", iConexion, iTransaccion)
            insertar.ExecuteNonQuery()
            Commit()
            FinalizarConexion()
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Sub EliminarObraSocial(pIdOSocial As Integer)
        Try
            IniciarConexion()
            ComenzarTransaccion()
            Dim insertar As New SqlCommand("delete ObrasSociales where idOSocial = '" & pIdOSocial & "'", iConexion, iTransaccion)
            insertar.ExecuteNonQuery()
            Commit()
            FinalizarConexion()
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Sub NuevaFichaMedica(pFichaMedica As FichaMedica)
        Try
            IniciarConexion()
            ComenzarTransaccion()
            Dim insertar As New SqlCommand("insert into FichasMedicas values ('" & pFichaMedica.FechaConsulta & "','" & pFichaMedica.Motivo & "','" & pFichaMedica.EstudiosComplementarios & "','" & pFichaMedica.Evaluacion & "','" & pFichaMedica.IdPaciente & "')", iConexion, iTransaccion)
            insertar.ExecuteNonQuery()
            Commit()
            FinalizarConexion()
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Sub NuevoPaciente(pPaciente As Paciente)
        Try
            IniciarConexion()
            ComenzarTransaccion()
            Dim insertar As New SqlCommand("insert into Pacientes values ('" & pPaciente.Nombre & "','" & pPaciente.Domicilio & "','" & pPaciente.IdLocalidad & "','" & pPaciente.Telefono & "','" & pPaciente.Email & "','" & pPaciente.FechaNacimiento & "','" & pPaciente.IdObraSocial & "','" & pPaciente.NumAfiliado & "','" & pPaciente.Sexo & "','" & pPaciente.Dni & "')", iConexion, iTransaccion)
            insertar.ExecuteNonQuery()
            Commit()
            FinalizarConexion()
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Sub ModificarPaciente(pPaciente As Paciente)
        Try
            IniciarConexion()
            ComenzarTransaccion()
            Dim insertar As New SqlCommand("update Pacientes set apellidoNombre ='" & pPaciente.Nombre & "', domicilio = '" & pPaciente.Domicilio & "',idLocalidad = '" & pPaciente.IdLocalidad & "',telefono = '" & pPaciente.Telefono & "',email= '" & pPaciente.Email & "',fechaNacimiento = '" & pPaciente.FechaNacimiento & "',idOSocial = '" & pPaciente.IdObraSocial & "',nroAfiliado = '" & pPaciente.NumAfiliado & "',sexo= '" & pPaciente.Sexo & "',dni = '" & pPaciente.Dni & "' where idPaciente = '" & pPaciente.IdPaciente & "'", iConexion, iTransaccion)
            insertar.ExecuteNonQuery()
            Commit()
            FinalizarConexion()
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Sub ModificarObraSocial(pObraSocial As ObraSocialDTO)
        Try
            IniciarConexion()
            ComenzarTransaccion()
            Dim insertar As New SqlCommand("update ObrasSociales set codigoOSocial ='" & pObraSocial.Codigo & "', nombreOSocial = '" & pObraSocial.Nombre & "', estado = '" & pObraSocial.Estado & "' where idOSocial = '" & pObraSocial.IdOSocial & "'", iConexion, iTransaccion)
            insertar.ExecuteNonQuery()
            Commit()
            FinalizarConexion()
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Sub ModificarUsuario(pUsuario As UsuarioDTO)
        Try
            If ValidarUsuario(pUsuario) Then
                IniciarConexion()
                ComenzarTransaccion()
                Dim encriptar As New EncriptadorCesar(4)
                Dim insertar As New SqlCommand("update Usuarios set nombreUsuario= '" & pUsuario.Usuario & "',contraseña = '" & encriptar.Encriptar(pUsuario.Contraseña) & "',permisoAdministrador = '" & pUsuario.PermisoAdministrador & "', permisoSecretaria = '" & pUsuario.PermisoSecretaria & "' where idUsuario = '" & pUsuario.IdUsuario & "'", iConexion, iTransaccion)
                insertar.ExecuteNonQuery()
                Commit()
                FinalizarConexion()
            Else
                Throw New DAOExcepcion("Ya existe un usuario con dicho nombre, ingrese otro")
            End If            
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Sub ModificarFichaMedica(pFichaMedica As FichaMedica)
        Try
                IniciarConexion()
                ComenzarTransaccion()
            Dim insertar As New SqlCommand("update FichasMedicas set evaluacion= '" & pFichaMedica.Evaluacion & "',estudiosComplementarios = '" & pFichaMedica.EstudiosComplementarios & "' where idFichaMedica = '" & pFichaMedica.IdFichaMedica & "'", iConexion, iTransaccion)
                insertar.ExecuteNonQuery()
                Commit()
                FinalizarConexion()
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Sub EliminarPaciente(pPaciente As Paciente)
        Try
            IniciarConexion()
            ComenzarTransaccion()
            Dim insertar As New SqlCommand("delete Pacientes where idPaciente = '" & pPaciente.IdPaciente & "'", iConexion, iTransaccion)
            insertar.ExecuteNonQuery()
            Commit()
            FinalizarConexion()           
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Sub EliminarUsuario(pIdUsuario As Integer)
        Try
            IniciarConexion()
            ComenzarTransaccion()
            Dim insertar As New SqlCommand("delete Usuarios where idUsuario = '" & pIdUsuario & "'", iConexion, iTransaccion)
            insertar.ExecuteNonQuery()
            Commit()
            FinalizarConexion()
        Catch ex As SqlException
            RollBack()
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    Public Function ListaLocalidades(idProvincia As Integer) As DataTable
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select idLocalidad,NombreLocalidad from Localidades where idProvincia = '" & idProvincia & "' order by nombreLocalidad", iConexion)
            Dim lista As New DataTable
            Dim adapter As New SqlDataAdapter(consulta)
            adapter.Fill(lista)
            FinalizarConexion()
            Return lista
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Function

    Public Function ListaProvincias() As DataTable
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select idProvincia,nombreProvincia from Provincias order by nombreProvincia", iConexion)
            Dim lista As New DataTable
            Dim adapter As New SqlDataAdapter(consulta)
            adapter.Fill(lista)
            FinalizarConexion()
            Return lista
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Function

    Public Function ListaObrasSociales() As DataTable
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select * from ObrasSociales order by nombreOSocial", iConexion)
            Dim lista As New DataTable
            Dim adapter As New SqlDataAdapter(consulta)
            adapter.Fill(lista)
            FinalizarConexion()
            Return lista
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Function

    Public Function ListaPacientes() As DataTable
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select idPaciente,apellidoNombre,domicilio,p.idLocalidad,telefono,email,fechaNacimiento,idOSocial,nroAfiliado,sexo,dni,idProvincia from Pacientes p, Localidades l where p.idLocalidad = l.idLocalidad order by apellidoNombre", iConexion)
            Dim lista As New DataTable
            Dim adapter As New SqlDataAdapter(consulta)
            adapter.Fill(lista)
            FinalizarConexion()
            Return lista
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Function

    Public Function ListaFichasMedicas(pIdPaciente As Integer) As DataTable
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select * from FichasMedicas f where f.idPaciente = '" & pIdPaciente & "' order by fechaConsulta", iConexion)
            Dim lista As New DataTable
            Dim adapter As New SqlDataAdapter(consulta)
            adapter.Fill(lista)
            FinalizarConexion()
            Return lista
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Function

    Public Function BuscarPorAprox(cadena As String) As DataTable
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select idPaciente,apellidoNombre,domicilio,p.idLocalidad,telefono,email,fechaNacimiento,idOSocial,nroAfiliado,sexo,dni,idProvincia from Pacientes p, Localidades l where p.idLocalidad = l.idLocalidad  and (apellidoNombre like '" & cadena & "%' or dni like '" & cadena & "%') order by apellidoNombre", iConexion)
            Dim lista As New DataTable
            Dim adapter As New SqlDataAdapter(consulta)
            adapter.Fill(lista)
            FinalizarConexion()
            Return lista
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Function

    Public Function BuscarPorAproxObrasSociales(cadena As String) As DataTable
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select * from ObrasSociales where codigoOSocial like '" & cadena & "%' or nombreOSocial like '" & cadena & "%' order by nombreOSocial", iConexion)
            Dim lista As New DataTable
            Dim adapter As New SqlDataAdapter(consulta)
            adapter.Fill(lista)
            FinalizarConexion()
            Return lista
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Function

    Public Function ListaTurnos(fecha As String) As DataTable
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select idTurno,p.idPaciente, apellidoNombre as paciente, horaTurno as hora,motivoTurno from Turnos t,Pacientes p where t.idPaciente = p.idPaciente and fechaTurno = '" & fecha & "' order by horaTurno", iConexion)
            Dim lista As New DataTable
            Dim adapter As New SqlDataAdapter(consulta)
            adapter.Fill(lista)
            FinalizarConexion()
            Return lista
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Function

    Public Function ListaUsuarios() As DataTable
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select * from Usuarios order by nombreUsuario", iConexion)
            Dim lista As New DataTable
            Dim adapter As New SqlDataAdapter(consulta)
            adapter.Fill(lista)
            FinalizarConexion()
            Dim encriptador As EncriptadorCesar = New EncriptadorCesar(4)
            For Each usuario As DataRow In lista.Rows
                usuario("contraseña") = encriptador.Desencriptar(usuario("contraseña"))
            Next
            Return lista
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Function

    Public Function BuscarPaciente(idPaciente As Integer) As PacienteDTO
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select * from Pacientes p,Localidades l,Provincias pr,ObrasSociales o where p.idPaciente = '" & idPaciente & "' and p.idLocalidad = l.idLocalidad and l.idProvincia = pr.idProvincia and p.idOSocial = o.idOSocial ", iConexion)
            Dim lista As New DataTable
            Dim adapter As New SqlDataAdapter(consulta)
            adapter.Fill(lista)
            FinalizarConexion()
            Return New PacienteDTO(lista(0)("idPaciente"), lista(0)("apellidoNombre"), lista(0)("dni"), lista(0)("domicilio"), lista(0)("fechaNacimiento"), lista(0)("nombreLocalidad"), lista(0)("nombreProvincia"), lista(0)("telefono"), lista(0)("email"), lista(0)("nombreOSocial"), lista(0)("nroAfiliado"), lista(0)("sexo"))
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        Catch ex As NullReferenceException
            Throw New DAOExcepcion("No se encontró el paciente buscado")
        End Try
    End Function

    Public Function BuscarUsuario(pUsuario As String) As UsuarioDTO
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select * from Usuarios u where u.nombreUsuario = '" & pUsuario & "'", iConexion)
            Dim lista As New DataTable
            Dim adapter As New SqlDataAdapter(consulta)
            adapter.Fill(lista)
            FinalizarConexion()
            Dim encriptador As EncriptadorCesar = New EncriptadorCesar(4)
            Return New UsuarioDTO(lista(0)("idUsuario"), lista(0)("nombreUsuario"), encriptador.Desencriptar(lista(0)("contraseña")), lista(0)("permisoAdministrador"), lista(0)("permisoSecretaria"))
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        Catch ex As NullReferenceException
            Throw New DAOExcepcion("Dicho usuario no está registrado en el sistema")
        End Try
    End Function

    Public Function CantidadUsuarios() As Integer
        Try
            IniciarConexion()
            Dim consulta As New SqlCommand("select count(*) from Usuarios ", iConexion)
            Dim resultado As Integer = consulta.ExecuteScalar()
            FinalizarConexion()
            Return resultado
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        Catch ex As NullReferenceException
            Throw New DAOExcepcion("Dicho usuario no está registrado en el sistema")
        End Try
    End Function

    Public Sub NuevoUsuario(pUsuario As UsuarioDTO)
        Try
            If ValidarUsuario(pUsuario) Then
                IniciarConexion()
                ComenzarTransaccion()
                Dim encriptador As EncriptadorCesar = New EncriptadorCesar(4)
                Dim insertar As New SqlCommand("insert into Usuarios values ('" & pUsuario.Usuario & "','" & encriptador.Encriptar(pUsuario.Contraseña) & "','" & pUsuario.PermisoAdministrador & "', '" & pUsuario.PermisoSecretaria & "')", iConexion, iTransaccion)
                insertar.ExecuteNonQuery()
                Commit()
                FinalizarConexion()
            Else
                Throw New DAOExcepcion("Ya existe un usuario con dicho nombre, ingrese otro")
            End If            
        Catch ex As SqlException
            Throw New DAOExcepcion("Ocurrió un error interno, Consulte con servicio técnico")
        End Try
    End Sub

    ''' <summary>
    ''' Verifica que no existan 2 usuarios con el mismo nombre
    ''' </summary>
    ''' <param name="pUsuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidarUsuario(pUsuario As UsuarioDTO) As Boolean
        IniciarConexion()
        Dim consulta As New SqlCommand("select * from Usuarios u where u.nombreUsuario = '" & pUsuario.Usuario & "' and u.idUsuario <> '" & pUsuario.IdUsuario & "'", iConexion)
        Dim lista As New DataTable
        Dim adapter As New SqlDataAdapter(consulta)
        adapter.Fill(lista)
        FinalizarConexion()
        If lista.Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
