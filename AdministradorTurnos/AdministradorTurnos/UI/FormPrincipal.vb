Public Class FormPrincipal

    Private Sub AdministracionDeTurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministracionDeTurnosToolStripMenuItem.Click
        FormAdministracionTurnos.ShowDialog()
    End Sub

    Private Sub VerTurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTurnosToolStripMenuItem.Click
        FormTurnos.ShowDialog()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        FormUsuarios.ShowDialog()
    End Sub

    Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem.Click
        FormPacientes.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
