Public Class FormLogin

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim sql As New SQLServerFactory()
            If sql.CantidadUsuarios() = 0 Then
                If tbUsuario.Text = "admin" And tbContraseña.Text = "admin" Then
                    FormPrincipal.ShowDialog()
                    Me.Close()
                Else
                    MessageBox.Show("Datos incorrectos, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If                           
            Else
                If Consultorio.Instancia.ValidarDatosUsuario(New UsuarioDTO(0, tbUsuario.Text, tbContraseña.Text, True, True)) Then
                    If sql.BuscarUsuario(tbUsuario.Text).PermisoSecretaria Then
                        FormPrincipal.UsuariosToolStripMenuItem.Visible = False
                        FormPrincipal.VerTurnosToolStripMenuItem.Visible = False
                        FormPacientes.bHistoria.Enabled = False
                    End If
                    FormPrincipal.ShowDialog()
                    Me.Close()
                Else
                    MessageBox.Show("Contraseña invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
