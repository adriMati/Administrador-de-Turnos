Public Class FormAdministracionTurnos

    Private Sub FormAdministracionTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip.SetToolTip(dgTurnos, "Doble click en la celda para asignar nuevo turno")
        CargarTurnos(mcFechaTurno.SelectionRange.Start.Date)
    End Sub



    Public Sub CargarTurnos(fecha As DateTime)
        Try
            Consultorio.Instancia.GenerarTurnos(fecha)
            dgTurnos.DataSource = Consultorio.Instancia.Turnos(fecha)
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormPacientes.ShowDialog()
    End Sub

    Private Sub dgTurnos_DoubleClick(sender As Object, e As EventArgs) Handles dgTurnos.DoubleClick
        If dgTurnos.RowCount > 0 And dgTurnos.Item("paciente", dgTurnos.SelectedRows(0).Index).Value() = "" Then
            FormAltaTurno.tbFecha.Text = mcFechaTurno.SelectionRange.Start.ToString()
            FormAltaTurno.tbHora.Text = dgTurnos.Item("hora", dgTurnos.SelectedRows(0).Index).Value()
            FormAltaTurno.ShowDialog()
        End If
    End Sub

    Private Sub mcFechaTurno_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mcFechaTurno.DateChanged
        CargarTurnos(mcFechaTurno.SelectionRange.Start.Date)
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        FormConfiguracion.ShowDialog()
    End Sub

    Private Sub bAnular_Click(sender As Object, e As EventArgs) Handles bAnular.Click
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea anular el turno seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Try
                Consultorio.Instancia.AnularTurno(dgTurnos.Item("idTurno", dgTurnos.SelectedRows(0).Index).Value())
                CargarTurnos(mcFechaTurno.SelectionRange.Start.Date)
                MessageBox.Show("Turno Anulado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As DAOExcepcion
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class