Public Class FormBuscarPaciente

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub

    Private Sub FormBuscarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPacientes()
    End Sub

    Private Sub CargarPacientes()
        dgPacientes.DataSource = New SQLServerFactory().ListaPacientes()
    End Sub


    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Try
            dgPacientes.DataSource = New SQLServerFactory().BuscarPorAprox(tbBusqueda.Text)
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgPacientes_DoubleClick(sender As Object, e As EventArgs) Handles dgPacientes.DoubleClick
        FormAltaTurno.tbIdPaciente.Text = dgPacientes.Item("idPaciente", dgPacientes.SelectedRows(0).Index).Value()
        FormAltaTurno.tbPaciente.Text = dgPacientes.Item("nombre", dgPacientes.SelectedRows(0).Index).Value()
        Me.Close()
    End Sub
End Class