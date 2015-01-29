Public Class FormConfiguracion

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub

    Private Sub FormConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbHoraComienzo.Text = turnosConfig.Default.horaComienzo
        tbHoraFin.Text = turnosConfig.Default.horaFin
        tbDuracionTurno.Text = turnosConfig.Default.intervaloTurno
    End Sub

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        turnosConfig.Default.horaComienzo = tbHoraComienzo.Text
        turnosConfig.Default.horaFin = tbHoraFin.Text
        turnosConfig.Default.intervaloTurno = tbDuracionTurno.Text
        turnosConfig.Default.Save()
        MessageBox.Show("Configuración establecida", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FormAdministracionTurnos.CargarTurnos(FormAdministracionTurnos.mcFechaTurno.SelectionRange.Start)
        Me.Close()
    End Sub
End Class