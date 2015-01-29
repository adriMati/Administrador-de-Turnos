<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarPaciente))
        Me.dgPacientes = New System.Windows.Forms.DataGridView()
        Me.idPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nroAfiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Label()
        CType(Me.dgPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPacientes
        '
        Me.dgPacientes.AllowUserToAddRows = False
        Me.dgPacientes.AllowUserToDeleteRows = False
        Me.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPaciente, Me.idOSocial, Me.sexo, Me.nroAfiliado, Me.telefono, Me.idLocalidad, Me.domicilio, Me.email, Me.fechaNac, Me.idProvincia, Me.dni, Me.nombre})
        Me.dgPacientes.Location = New System.Drawing.Point(31, 59)
        Me.dgPacientes.Name = "dgPacientes"
        Me.dgPacientes.ReadOnly = True
        Me.dgPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPacientes.Size = New System.Drawing.Size(419, 246)
        Me.dgPacientes.TabIndex = 0
        Me.dgPacientes.TabStop = False
        '
        'idPaciente
        '
        Me.idPaciente.DataPropertyName = "idPaciente"
        Me.idPaciente.HeaderText = "idPaciente"
        Me.idPaciente.Name = "idPaciente"
        Me.idPaciente.ReadOnly = True
        Me.idPaciente.Visible = False
        '
        'idOSocial
        '
        Me.idOSocial.DataPropertyName = "idOSocial"
        Me.idOSocial.HeaderText = "idOSocial"
        Me.idOSocial.Name = "idOSocial"
        Me.idOSocial.ReadOnly = True
        Me.idOSocial.Visible = False
        '
        'sexo
        '
        Me.sexo.DataPropertyName = "sexo"
        Me.sexo.HeaderText = "sexo"
        Me.sexo.Name = "sexo"
        Me.sexo.ReadOnly = True
        Me.sexo.Visible = False
        '
        'nroAfiliado
        '
        Me.nroAfiliado.DataPropertyName = "nroAfiliado"
        Me.nroAfiliado.HeaderText = "nroAfiliado"
        Me.nroAfiliado.Name = "nroAfiliado"
        Me.nroAfiliado.ReadOnly = True
        Me.nroAfiliado.Visible = False
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Visible = False
        '
        'idLocalidad
        '
        Me.idLocalidad.DataPropertyName = "idLocalidad"
        Me.idLocalidad.HeaderText = "idLocalidad"
        Me.idLocalidad.Name = "idLocalidad"
        Me.idLocalidad.ReadOnly = True
        Me.idLocalidad.Visible = False
        '
        'domicilio
        '
        Me.domicilio.DataPropertyName = "domicilio"
        Me.domicilio.HeaderText = "domicilio"
        Me.domicilio.Name = "domicilio"
        Me.domicilio.ReadOnly = True
        Me.domicilio.Visible = False
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Visible = False
        '
        'fechaNac
        '
        Me.fechaNac.DataPropertyName = "fechaNacimiento"
        Me.fechaNac.HeaderText = "fechaNac"
        Me.fechaNac.Name = "fechaNac"
        Me.fechaNac.ReadOnly = True
        Me.fechaNac.Visible = False
        '
        'idProvincia
        '
        Me.idProvincia.DataPropertyName = "idProvincia"
        Me.idProvincia.HeaderText = "idProvincia"
        Me.idProvincia.Name = "idProvincia"
        Me.idProvincia.ReadOnly = True
        Me.idProvincia.Visible = False
        '
        'dni
        '
        Me.dni.DataPropertyName = "dni"
        Me.dni.HeaderText = "Dni"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "apellidoNombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'bCancelar
        '
        Me.bCancelar.Image = Global.AdministradorTurnos.My.Resources.Resources.button_cancel
        Me.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.Location = New System.Drawing.Point(200, 329)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(75, 23)
        Me.bCancelar.TabIndex = 2
        Me.bCancelar.Text = "&Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'tbBusqueda
        '
        Me.tbBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBusqueda.Location = New System.Drawing.Point(76, 20)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(231, 20)
        Me.tbBusqueda.TabIndex = 1
        '
        'Buscar
        '
        Me.Buscar.AutoSize = True
        Me.Buscar.Location = New System.Drawing.Point(30, 23)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(40, 13)
        Me.Buscar.TabIndex = 3
        Me.Buscar.Text = "Buscar"
        '
        'FormBuscarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 374)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.tbBusqueda)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.dgPacientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormBuscarPaciente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Paciente"
        CType(Me.dgPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents bCancelar As System.Windows.Forms.Button
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Buscar As System.Windows.Forms.Label
    Friend WithEvents idPaciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idOSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nroAfiliado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaNac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProvincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
