Public Class FormUsuarios

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Try
            Dim usuario As UsuarioDTO
            If rbAdministrador.Checked Then
                usuario = New UsuarioDTO(0, tbUsuario.Text, tbContraseña.Text, True, False)
            Else
                usuario = New UsuarioDTO(0, tbUsuario.Text, tbContraseña.Text, False, True)
            End If
            Dim sql As SQLServerFactory = New SQLServerFactory()
            sql.NuevoUsuario(usuario)
            CargarUsuarios()
            MessageBox.Show("Usuario agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar()
        tbUsuario.Text = ""
        tbContraseña.Text = ""
        tbIdUsuario.Text = ""
    End Sub

    Private Sub FormUsuarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Limpiar()
    End Sub


    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()
        Dim sql As New SQLServerFactory()
        dgUsuarios.DataSource = sql.ListaUsuarios()
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Try
            Dim usuario As UsuarioDTO
            If rbAdministrador.Checked Then
                usuario = New UsuarioDTO(tbIdUsuario.Text, tbUsuario.Text, tbContraseña.Text, True, False)
            Else
                usuario = New UsuarioDTO(tbIdUsuario.Text, tbUsuario.Text, tbContraseña.Text, False, True)
            End If
            Dim sql As SQLServerFactory = New SQLServerFactory()
            sql.ModificarUsuario(usuario)
            CargarUsuarios()
            MessageBox.Show("Datos modificados", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Try
            Dim sql As SQLServerFactory = New SQLServerFactory()
            sql.EliminarUsuario(Convert.ToInt32(tbIdUsuario.Text))
            CargarUsuarios()
            MessageBox.Show("Usuario eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgUsuarios_Click(sender As Object, e As EventArgs) Handles dgUsuarios.Click
        If dgUsuarios.Rows.Count > 0 Then
            tbIdUsuario.Text = dgUsuarios.Item("idUsuario", dgUsuarios.SelectedRows(0).Index).Value()
            tbUsuario.Text = dgUsuarios.Item("usuario", dgUsuarios.SelectedRows(0).Index).Value()
            tbContraseña.Text = dgUsuarios.Item("contraseña", dgUsuarios.SelectedRows(0).Index).Value()
            If dgUsuarios.Item("permisoAdministrador", dgUsuarios.SelectedRows(0).Index).Value() = True Then
                rbAdministrador.Checked = True
            Else
                rbSecretaria.Checked = True
            End If
        End If
    End Sub
End Class