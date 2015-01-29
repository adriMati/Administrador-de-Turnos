Public Class FormTurnos

    Private Sub FormTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTurnos(tbFecha.Text)
    End Sub

    Public Sub CargarTurnos(fecha As DateTime)
        Try
            Consultorio.Instancia.GenerarTurnos(fecha)
            dgTurnos.DataSource = Consultorio.Instancia.Turnos(fecha)
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub tbFecha_ValueChanged(sender As Object, e As EventArgs) Handles tbFecha.ValueChanged
        CargarTurnos(tbFecha.Text)
    End Sub

    Private Sub dgTurnos_DoubleClick(sender As Object, e As EventArgs) Handles dgTurnos.DoubleClick
        If dgTurnos.Item("paciente", dgTurnos.SelectedRows(0).Index).Value() <> "" Then
            FormHistoriaPaciente.tbIdTurno.Text = dgTurnos.Item("idTurno", dgTurnos.SelectedRows(0).Index).Value()
            FormHistoriaPaciente.tbMotivo.Text = dgTurnos.Item("motivo", dgTurnos.SelectedRows(0).Index).Value()
            FormHistoriaPaciente.tbFechaConsulta.Text = tbFecha.Text
            FormHistoriaPaciente.tbIdPaciente.Text = dgTurnos.Item("idPaciente", dgTurnos.SelectedRows(0).Index).Value()
            FormHistoriaPaciente.ShowDialog()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CargarTurnos(tbFecha.Text)
    End Sub
End Class
