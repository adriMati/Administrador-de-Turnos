<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPacientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPacientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbDomicilio = New System.Windows.Forms.TextBox()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.cbLocalidad = New System.Windows.Forms.ComboBox()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.cbObraSocial = New System.Windows.Forms.ComboBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbNumAfiliado = New System.Windows.Forms.TextBox()
        Me.dgPacientes = New System.Windows.Forms.DataGridView()
        Me.idPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numAfiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbIdPaciente = New System.Windows.Forms.TextBox()
        Me.tbDni = New System.Windows.Forms.MaskedTextBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bAlta = New System.Windows.Forms.Button()
        Me.bHistoria = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellido y Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "D.N.I"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Localidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Provincia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(338, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(338, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Numero Afiliado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(338, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Obra Social"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(339, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Sexo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Teléfono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Domicilio"
        '
        'tbNombre
        '
        Me.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombre.Location = New System.Drawing.Point(6, 41)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(310, 20)
        Me.tbNombre.TabIndex = 1
        '
        'tbDomicilio
        '
        Me.tbDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDomicilio.Location = New System.Drawing.Point(6, 119)
        Me.tbDomicilio.Name = "tbDomicilio"
        Me.tbDomicilio.Size = New System.Drawing.Size(310, 20)
        Me.tbDomicilio.TabIndex = 6
        '
        'cbProvincia
        '
        Me.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(6, 158)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(151, 21)
        Me.cbProvincia.TabIndex = 8
        '
        'cbLocalidad
        '
        Me.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLocalidad.FormattingEnabled = True
        Me.cbLocalidad.Location = New System.Drawing.Point(170, 158)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(146, 21)
        Me.cbLocalidad.TabIndex = 9
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Checked = True
        Me.rbMasculino.Location = New System.Drawing.Point(341, 80)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbMasculino.TabIndex = 4
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "Masculino"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(459, 80)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbFemenino.TabIndex = 5
        Me.rbFemenino.Text = "Femenino"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(338, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Fecha Nacimiento"
        '
        'tbFechaNac
        '
        Me.tbFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaNac.Location = New System.Drawing.Point(339, 41)
        Me.tbFechaNac.Name = "tbFechaNac"
        Me.tbFechaNac.Size = New System.Drawing.Size(111, 20)
        Me.tbFechaNac.TabIndex = 3
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(6, 198)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(310, 20)
        Me.tbTelefono.TabIndex = 11
        '
        'cbObraSocial
        '
        Me.cbObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbObraSocial.FormattingEnabled = True
        Me.cbObraSocial.Location = New System.Drawing.Point(338, 119)
        Me.cbObraSocial.Name = "cbObraSocial"
        Me.cbObraSocial.Size = New System.Drawing.Size(151, 21)
        Me.cbObraSocial.TabIndex = 7
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(338, 198)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(310, 20)
        Me.tbEmail.TabIndex = 12
        '
        'tbNumAfiliado
        '
        Me.tbNumAfiliado.Location = New System.Drawing.Point(338, 159)
        Me.tbNumAfiliado.Name = "tbNumAfiliado"
        Me.tbNumAfiliado.Size = New System.Drawing.Size(310, 20)
        Me.tbNumAfiliado.TabIndex = 10
        '
        'dgPacientes
        '
        Me.dgPacientes.AllowUserToAddRows = False
        Me.dgPacientes.AllowUserToDeleteRows = False
        Me.dgPacientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPaciente, Me.localidad, Me.idProvincia, Me.nombre, Me.dni, Me.domicilio, Me.telefono, Me.idOSocial, Me.numAfiliado, Me.email, Me.idLocalidad, Me.fechaNacimiento, Me.sexo})
        Me.dgPacientes.Location = New System.Drawing.Point(12, 270)
        Me.dgPacientes.Name = "dgPacientes"
        Me.dgPacientes.ReadOnly = True
        Me.dgPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPacientes.Size = New System.Drawing.Size(653, 220)
        Me.dgPacientes.TabIndex = 26
        '
        'idPaciente
        '
        Me.idPaciente.DataPropertyName = "idPaciente"
        Me.idPaciente.HeaderText = "idPaciente"
        Me.idPaciente.Name = "idPaciente"
        Me.idPaciente.ReadOnly = True
        Me.idPaciente.Visible = False
        '
        'localidad
        '
        Me.localidad.DataPropertyName = "nombreLocalidad"
        Me.localidad.HeaderText = "localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        Me.localidad.Visible = False
        '
        'idProvincia
        '
        Me.idProvincia.DataPropertyName = "idProvincia"
        Me.idProvincia.HeaderText = "idProvincia"
        Me.idProvincia.Name = "idProvincia"
        Me.idProvincia.ReadOnly = True
        Me.idProvincia.Visible = False
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "apellidoNombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'dni
        '
        Me.dni.DataPropertyName = "dni"
        Me.dni.HeaderText = "Dni"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        '
        'domicilio
        '
        Me.domicilio.DataPropertyName = "domicilio"
        Me.domicilio.HeaderText = "Domicilio"
        Me.domicilio.Name = "domicilio"
        Me.domicilio.ReadOnly = True
        Me.domicilio.Width = 200
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Visible = False
        '
        'idOSocial
        '
        Me.idOSocial.DataPropertyName = "idOSocial"
        Me.idOSocial.HeaderText = "idOSocial"
        Me.idOSocial.Name = "idOSocial"
        Me.idOSocial.ReadOnly = True
        Me.idOSocial.Visible = False
        '
        'numAfiliado
        '
        Me.numAfiliado.DataPropertyName = "nroAfiliado"
        Me.numAfiliado.HeaderText = "numAfiliado"
        Me.numAfiliado.Name = "numAfiliado"
        Me.numAfiliado.ReadOnly = True
        Me.numAfiliado.Visible = False
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Visible = False
        '
        'idLocalidad
        '
        Me.idLocalidad.DataPropertyName = "idLocalidad"
        Me.idLocalidad.HeaderText = "idLocalidad"
        Me.idLocalidad.Name = "idLocalidad"
        Me.idLocalidad.ReadOnly = True
        Me.idLocalidad.Visible = False
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.DataPropertyName = "fechaNacimiento"
        Me.fechaNacimiento.HeaderText = "fechaNacimiento"
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.ReadOnly = True
        Me.fechaNacimiento.Visible = False
        '
        'sexo
        '
        Me.sexo.DataPropertyName = "sexo"
        Me.sexo.HeaderText = "sexo"
        Me.sexo.Name = "sexo"
        Me.sexo.ReadOnly = True
        Me.sexo.Visible = False
        '
        'tbIdPaciente
        '
        Me.tbIdPaciente.Location = New System.Drawing.Point(525, 40)
        Me.tbIdPaciente.Name = "tbIdPaciente"
        Me.tbIdPaciente.Size = New System.Drawing.Size(63, 20)
        Me.tbIdPaciente.TabIndex = 29
        Me.tbIdPaciente.Visible = False
        '
        'tbDni
        '
        Me.tbDni.Location = New System.Drawing.Point(6, 77)
        Me.tbDni.Mask = "99999999"
        Me.tbDni.Name = "tbDni"
        Me.tbDni.Size = New System.Drawing.Size(310, 20)
        Me.tbDni.TabIndex = 2
        '
        'bSalir
        '
        Me.bSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.Image = Global.AdministradorTurnos.My.Resources.Resources.Salir
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(524, 508)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(85, 35)
        Me.bSalir.TabIndex = 16
        Me.bSalir.Text = "&Salir"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bModificar.Image = Global.AdministradorTurnos.My.Resources.Resources.edit
        Me.bModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bModificar.Location = New System.Drawing.Point(283, 508)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(85, 35)
        Me.bModificar.TabIndex = 15
        Me.bModificar.Text = "&Modificar"
        Me.bModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.Image = Global.AdministradorTurnos.My.Resources.Resources.button_cancel
        Me.bEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.Location = New System.Drawing.Point(167, 508)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(85, 35)
        Me.bEliminar.TabIndex = 14
        Me.bEliminar.Text = "&Eliminar"
        Me.bEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bAlta
        '
        Me.bAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAlta.Image = Global.AdministradorTurnos.My.Resources.Resources.apply
        Me.bAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAlta.Location = New System.Drawing.Point(51, 508)
        Me.bAlta.Name = "bAlta"
        Me.bAlta.Size = New System.Drawing.Size(85, 35)
        Me.bAlta.TabIndex = 13
        Me.bAlta.Text = "&Añadir"
        Me.bAlta.UseVisualStyleBackColor = True
        '
        'bHistoria
        '
        Me.bHistoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bHistoria.Image = Global.AdministradorTurnos.My.Resources.Resources.historiaMedica1
        Me.bHistoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bHistoria.Location = New System.Drawing.Point(399, 508)
        Me.bHistoria.Name = "bHistoria"
        Me.bHistoria.Size = New System.Drawing.Size(94, 35)
        Me.bHistoria.TabIndex = 31
        Me.bHistoria.Text = "&Historia"
        Me.bHistoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bHistoria.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbDni)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbIdPaciente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tbNumAfiliado)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbEmail)
        Me.GroupBox1.Controls.Add(Me.tbNombre)
        Me.GroupBox1.Controls.Add(Me.cbObraSocial)
        Me.GroupBox1.Controls.Add(Me.tbDomicilio)
        Me.GroupBox1.Controls.Add(Me.tbTelefono)
        Me.GroupBox1.Controls.Add(Me.cbProvincia)
        Me.GroupBox1.Controls.Add(Me.tbFechaNac)
        Me.GroupBox1.Controls.Add(Me.cbLocalidad)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.rbMasculino)
        Me.GroupBox1.Controls.Add(Me.rbFemenino)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 225)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Paciente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Buscar"
        '
        'tbBusqueda
        '
        Me.tbBusqueda.Location = New System.Drawing.Point(75, 240)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(219, 20)
        Me.tbBusqueda.TabIndex = 34
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 5000
        Me.ToolTip.InitialDelay = 100
        Me.ToolTip.ReshowDelay = 50
        '
        'FormPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 555)
        Me.Controls.Add(Me.tbBusqueda)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bHistoria)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bModificar)
        Me.Controls.Add(Me.dgPacientes)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.bAlta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormPacientes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        CType(Me.dgPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bAlta As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents cbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents cbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents rbMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents rbFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbTelefono As System.Windows.Forms.TextBox
    Friend WithEvents cbObraSocial As System.Windows.Forms.ComboBox
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents tbNumAfiliado As System.Windows.Forms.TextBox
    Friend WithEvents dgPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents tbIdPaciente As System.Windows.Forms.TextBox
    Friend WithEvents idPaciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProvincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idOSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numAfiliado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaNacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbDni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents bHistoria As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
