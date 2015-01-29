Public Class FormAltaTurno

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
        LimpiarPantalla()
    End Sub

    Private Sub LimpiarPantalla()
        tbIdPaciente.Text = ""
        tbMotivo.Text = ""
        tbPaciente.Text = ""
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        FormBuscarPaciente.ShowDialog()
    End Sub

    Private Sub bAsignar_Click(sender As Object, e As EventArgs) Handles bAsignar.Click
        Try
            If tbIdPaciente.Text = "" Then
                MessageBox.Show("Seleccione un Paciente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim turno As Turno = New Turno(0, tbFecha.Text, tbHora.Text, tbMotivo.Text, tbIdPaciente.Text, "")
            Consultorio.Instancia.GuardarTurno(turno)
            Me.Close()
            FormAdministracionTurnos.CargarTurnos(FormAdministracionTurnos.mcFechaTurno.SelectionRange.Start)
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormAltaTurno_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarPantalla()
    End Sub
End Class