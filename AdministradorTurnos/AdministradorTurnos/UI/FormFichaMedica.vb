Public Class FormFichaMedica

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Try
            Dim ficha As FichaMedica = New FichaMedica(0, tbFechaConsulta.Text, tbMotivo.Text, tbEstCompl.Text, tbEvaluacion.Text, tbIdPaciente.Text)
            Consultorio.Instancia.GuardarFichaMedica(ficha)
            FormHistoriaPaciente.CargarFichasMedicas()
            MessageBox.Show("Ficha Guardada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarPantalla()
            Me.Close()
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarPantalla()
        tbEvaluacion.Text = ""
        tbEstCompl.Text = ""
    End Sub
End Class