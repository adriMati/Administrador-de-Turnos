Public Class FormPacientes

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
        LimpiarPantalla()
    End Sub

    Private Sub FormPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ToolTip.SetToolTip(Me.tbBusqueda, "Escriba Nombre o Dni")
            CargarObraSocial()
            CargarProvinciasYLocalidades()
            CargarClientes()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error interno, Consulte con Servicio Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarClientes()
        dgPacientes.DataSource = New SQLServerFactory().ListaPacientes()
    End Sub
    Private Sub CargarObraSocial()
        cbObraSocial.DataSource = New SQLServerFactory().ListaObrasSociales()
        cbObraSocial.ValueMember = "idOSocial"
        cbObraSocial.DisplayMember = "nombreOSocial"
    End Sub

    Private Sub CargarProvinciasYLocalidades()
        cbProvincia.DataSource = New SQLServerFactory().ListaProvincias()
        cbProvincia.ValueMember = "idProvincia"
        cbProvincia.DisplayMember = "nombreProvincia"
        cbLocalidad.DataSource = New SQLServerFactory().ListaLocalidades(cbProvincia.SelectedValue)
        cbLocalidad.ValueMember = "idLocalidad"
        cbLocalidad.DisplayMember = "nombreLocalidad"
    End Sub

    Private Sub bAlta_Click(sender As Object, e As EventArgs) Handles bAlta.Click
        Try
            Dim sexo As String = "Femenino"
            If rbMasculino.Checked Then
                sexo = "Masculino"
            End If
            Dim paciente As New Paciente(0, tbNombre.Text, tbDni.Text, tbDomicilio.Text, tbFechaNac.Text, cbLocalidad.SelectedValue, cbProvincia.SelectedValue, tbTelefono.Text, tbEmail.Text, cbObraSocial.SelectedValue, tbNumAfiliado.Text, sexo)
            Consultorio.Instancia.NuevoPaciente(paciente)
            CargarClientes()
            LimpiarPantalla()
            MessageBox.Show("Paciente agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbProvincia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbProvincia.SelectionChangeCommitted
        cbLocalidad.DataSource = New SQLServerFactory().ListaLocalidades(cbProvincia.SelectedValue)
        cbLocalidad.ValueMember = "idLocalidad"
        cbLocalidad.DisplayMember = "nombreLocalidad"
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Try
            Dim sexo As String = "Femenino"
            If rbMasculino.Checked Then
                sexo = "Masculino"
            End If
            Dim paciente As New Paciente(tbIdPaciente.Text, tbNombre.Text, tbDni.Text, tbDomicilio.Text, tbFechaNac.Text, cbLocalidad.SelectedValue, cbProvincia.SelectedValue, tbTelefono.Text, tbEmail.Text, cbObraSocial.SelectedValue, tbNumAfiliado.Text, sexo)
            Consultorio.Instancia.ModificarPaciente(paciente)
            CargarClientes()
            LimpiarPantalla()
            MessageBox.Show("Datos modificados", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If tbIdPaciente.Text = "" Then
            MessageBox.Show("Seleccione un Paciente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar dicho Paciente?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Try
                Dim sexo As String = "Femenino"
                If rbMasculino.Checked Then
                    sexo = "Masculino"
                End If
                Dim paciente As New Paciente(tbIdPaciente.Text, tbNombre.Text, tbDni.Text, tbDomicilio.Text, tbFechaNac.Text, cbLocalidad.SelectedValue, cbProvincia.SelectedValue, tbTelefono.Text, tbEmail.Text, cbObraSocial.SelectedValue, tbNumAfiliado.Text, sexo)
                Consultorio.Instancia.EliminarPaciente(paciente)
                CargarClientes()
                LimpiarPantalla()
                MessageBox.Show("Paciente eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As DAOExcepcion
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dgPacientes_Click(sender As Object, e As EventArgs) Handles dgPacientes.Click
        If dgPacientes.RowCount > 0 Then
            tbIdPaciente.Text = dgPacientes.Item("idPaciente", dgPacientes.SelectedRows(0).Index).Value()
            tbNombre.Text = dgPacientes.Item("nombre", dgPacientes.SelectedRows(0).Index).Value()
            tbDni.Text = dgPacientes.Item("dni", dgPacientes.SelectedRows(0).Index).Value()
            tbDomicilio.Text = dgPacientes.Item("domicilio", dgPacientes.SelectedRows(0).Index).Value()
            tbEmail.Text = dgPacientes.Item("email", dgPacientes.SelectedRows(0).Index).Value()
            tbFechaNac.Text = dgPacientes.Item("fechaNacimiento", dgPacientes.SelectedRows(0).Index).Value()
            tbNumAfiliado.Text = dgPacientes.Item("numAfiliado", dgPacientes.SelectedRows(0).Index).Value()
            tbTelefono.Text = dgPacientes.Item("telefono", dgPacientes.SelectedRows(0).Index).Value()
            If dgPacientes.Item("sexo", dgPacientes.SelectedRows(0).Index).Value() = "Masculino" Then
                rbMasculino.Checked = True
            Else
                rbFemenino.Checked = True
            End If
            cbObraSocial.SelectedValue = dgPacientes.Item("idOSocial", dgPacientes.SelectedRows(0).Index).Value()
            cbProvincia.SelectedValue = dgPacientes.Item("idProvincia", dgPacientes.SelectedRows(0).Index).Value()
            cbLocalidad.DataSource = New SQLServerFactory().ListaLocalidades(cbProvincia.SelectedValue)
            cbLocalidad.SelectedValue = dgPacientes.Item("idLocalidad", dgPacientes.SelectedRows(0).Index).Value()
            bModificar.Enabled = True
            bEliminar.Enabled = True
        End If
    End Sub

    Private Sub LimpiarPantalla()
        tbIdPaciente.Text = ""
        tbNombre.Text = ""
        tbDomicilio.Text = ""
        tbEmail.Text = ""
        tbFechaNac.Text = ""
        tbNumAfiliado.Text = ""
        tbTelefono.Text = ""
        tbDni.Text = ""
    End Sub

  
    Private Sub bHistoria_Click(sender As Object, e As EventArgs) Handles bHistoria.Click        
        FormHistoriaPaciente.tbIdPaciente.Text = dgPacientes.Item("idPaciente", dgPacientes.SelectedRows(0).Index).Value()
        FormHistoriaPaciente.ShowDialog()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Try
            dgPacientes.DataSource = New SQLServerFactory().BuscarPorAprox(tbBusqueda.Text)
        Catch ex As DAOExcepcion
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class