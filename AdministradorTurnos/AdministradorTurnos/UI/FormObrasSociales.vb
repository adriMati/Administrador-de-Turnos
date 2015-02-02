Public Class FormObrasSociales

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
        Limpiar()
    End Sub

    Private Sub Limpiar()
        rbActiva.Checked = True
        tbCodigo.Text = ""
        tbNombre.Text = ""
        tbIdOSocial.Text = ""
    End Sub

    Private Sub FormObrasSociales_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Limpiar()
    End Sub

    Private Sub CargarObrasSociales()
        Try
            dgObrasSociales.DataSource = New SQLServerFactory().ListaObrasSociales()
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bAlta_Click(sender As Object, e As EventArgs) Handles bAlta.Click
        Try
            If tbNombre.Text = "" Then
                MessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim estado As String = "Activa"
            If rbAtrasada.Checked Then
                estado = "Atrasada"
            End If
            Dim obraSocial As New ObraSocialDTO(0, tbCodigo.Text, tbNombre.Text, estado)
            Dim sql As New SQLServerFactory()
            sql.NuevaObraSocial(obraSocial)
            CargarObrasSociales()
            FormPacientes.CargarObraSocial()
            Limpiar()
            MessageBox.Show("Obra Social agregada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Try
            Dim estado As String = "Activa"
            If rbAtrasada.Checked Then
                estado = "Atrasada"
            End If
            Dim obraSocial As New ObraSocialDTO(tbIdOSocial.Text, tbCodigo.Text, tbNombre.Text, estado)
            Dim sql As New SQLServerFactory()
            sql.ModificarObraSocial(obraSocial)
            CargarObrasSociales()
            FormPacientes.CargarObraSocial()
            Limpiar()
            MessageBox.Show("Datos modificados", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If tbIdOSocial.Text = "" Then
            MessageBox.Show("Seleccione una Obra Social para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar dicha Obra Social?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Try
                Dim sql As New SQLServerFactory()
                sql.EliminarObraSocial(tbIdOSocial.Text)
                CargarObrasSociales()
                FormPacientes.CargarObraSocial()
                Limpiar()
                MessageBox.Show("ObraSocial eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As DAOExcepcion
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub FormObrasSociales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarObrasSociales()
    End Sub

    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Try
            dgObrasSociales.DataSource = New SQLServerFactory().BuscarPorAproxObrasSociales(tbBusqueda.Text)
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgObrasSociales_Click(sender As Object, e As EventArgs) Handles dgObrasSociales.Click, dgObrasSociales.KeyUp, dgObrasSociales.KeyDown
        If dgObrasSociales.Rows.Count > 0 Then
            tbIdOSocial.Text = dgObrasSociales.Item("idOSocial", dgObrasSociales.SelectedRows(0).Index).Value()
            tbCodigo.Text = dgObrasSociales.Item("codigo", dgObrasSociales.SelectedRows(0).Index).Value()
            tbNombre.Text = dgObrasSociales.Item("nombre", dgObrasSociales.SelectedRows(0).Index).Value()
            If dgObrasSociales.Item("estado", dgObrasSociales.SelectedRows(0).Index).Value() = "Activa" Then
                rbActiva.Checked = True
            Else
                rbAtrasada.Checked = True
            End If
        End If
    End Sub
End Class