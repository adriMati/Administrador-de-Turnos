Public Class FormHistoriaPaciente

    Private Sub bNuevaFicha_Click(sender As Object, e As EventArgs) Handles bNuevaFicha.Click
        FormFichaMedica.tbIdPaciente.Text = tbIdPaciente.Text
        FormFichaMedica.tbMotivo.Text = tbMotivo.Text
        FormFichaMedica.tbNombre.Text = tbNombre.Text
        FormFichaMedica.tbFechaConsulta.Text = tbFechaConsulta.Text
        FormFichaMedica.ShowDialog()
    End Sub

    Private Sub FormHistoriaPaciente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Size = New Drawing.Size(New Point(568, 350))
        Limpiar()
    End Sub

    Private Sub FormHistoriaPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim paciente As PacienteDTO = Consultorio.Instancia.BuscarPaciente(tbIdPaciente.Text)
            tbNombre.Text = paciente.Nombre
            tbDni.Text = paciente.Dni
            tbFechaNac.Text = paciente.FechaNacimiento
            tbNumAfiliado.Text = paciente.NumAfiliado
            tbOSocial.Text = paciente.ObraSocial
            CargarFichasMedicas()
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CargarFichasMedicas()
        dgFichasMedicas.DataSource = Consultorio.Instancia.FichasMedicasDe(tbIdPaciente.Text)
    End Sub

    Private Sub Limpiar()
        tbEstCompl.Text = ""
        tbObservacion.Text = ""
    End Sub

    Private Sub dgFichasMedicas_Click(sender As Object, e As EventArgs) Handles dgFichasMedicas.Click
        If dgFichasMedicas.Rows.Count > 0 Then
            tbEstCompl.Text = dgFichasMedicas.Item("estudiosCompl", dgFichasMedicas.SelectedRows(0).Index).Value()
            tbObservacion.Text = dgFichasMedicas.Item("evaluacion", dgFichasMedicas.SelectedRows(0).Index).Value()
        End If       
    End Sub

    Private Sub dgFichasMedicas_KeyDown(sender As Object, e As KeyEventArgs) Handles dgFichasMedicas.KeyDown
        If dgFichasMedicas.Rows.Count > 0 Then
            tbEstCompl.Text = dgFichasMedicas.Item("estudiosCompl", dgFichasMedicas.SelectedRows(0).Index).Value()
            tbObservacion.Text = dgFichasMedicas.Item("evaluacion", dgFichasMedicas.SelectedRows(0).Index).Value()
        End If
    End Sub

    Private Sub dgFichasMedicas_KeyUp(sender As Object, e As KeyEventArgs) Handles dgFichasMedicas.KeyUp
        If dgFichasMedicas.Rows.Count > 0 Then
            tbEstCompl.Text = dgFichasMedicas.Item("estudiosCompl", dgFichasMedicas.SelectedRows(0).Index).Value()
            tbObservacion.Text = dgFichasMedicas.Item("evaluacion", dgFichasMedicas.SelectedRows(0).Index).Value()
        End If
    End Sub
End Class