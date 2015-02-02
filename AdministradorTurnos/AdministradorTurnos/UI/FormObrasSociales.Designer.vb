<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormObrasSociales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormObrasSociales))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgObrasSociales = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.rbActiva = New System.Windows.Forms.RadioButton()
        Me.rbAtrasada = New System.Windows.Forms.RadioButton()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbIdOSocial = New System.Windows.Forms.TextBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bAlta = New System.Windows.Forms.Button()
        CType(Me.dgObrasSociales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Estado"
        '
        'dgObrasSociales
        '
        Me.dgObrasSociales.AllowUserToAddRows = False
        Me.dgObrasSociales.AllowUserToDeleteRows = False
        Me.dgObrasSociales.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgObrasSociales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgObrasSociales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.idOSocial, Me.nombre, Me.estado})
        Me.dgObrasSociales.Location = New System.Drawing.Point(23, 61)
        Me.dgObrasSociales.Name = "dgObrasSociales"
        Me.dgObrasSociales.ReadOnly = True
        Me.dgObrasSociales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgObrasSociales.Size = New System.Drawing.Size(439, 143)
        Me.dgObrasSociales.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigoOSocial"
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'idOSocial
        '
        Me.idOSocial.DataPropertyName = "idOSocial"
        Me.idOSocial.HeaderText = "idOSocial"
        Me.idOSocial.Name = "idOSocial"
        Me.idOSocial.ReadOnly = True
        Me.idOSocial.Visible = False
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombreOSocial"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar"
        '
        'tbBusqueda
        '
        Me.tbBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBusqueda.Location = New System.Drawing.Point(66, 26)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(192, 20)
        Me.tbBusqueda.TabIndex = 5
        '
        'rbActiva
        '
        Me.rbActiva.AutoSize = True
        Me.rbActiva.Checked = True
        Me.rbActiva.Location = New System.Drawing.Point(70, 111)
        Me.rbActiva.Name = "rbActiva"
        Me.rbActiva.Size = New System.Drawing.Size(55, 17)
        Me.rbActiva.TabIndex = 6
        Me.rbActiva.TabStop = True
        Me.rbActiva.Text = "Activa"
        Me.rbActiva.UseVisualStyleBackColor = True
        '
        'rbAtrasada
        '
        Me.rbAtrasada.AutoSize = True
        Me.rbAtrasada.Location = New System.Drawing.Point(70, 143)
        Me.rbAtrasada.Name = "rbAtrasada"
        Me.rbAtrasada.Size = New System.Drawing.Size(67, 17)
        Me.rbAtrasada.TabIndex = 7
        Me.rbAtrasada.Text = "Atrasada"
        Me.rbAtrasada.UseVisualStyleBackColor = True
        '
        'tbCodigo
        '
        Me.tbCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCodigo.Location = New System.Drawing.Point(70, 25)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(172, 20)
        Me.tbCodigo.TabIndex = 8
        '
        'tbNombre
        '
        Me.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombre.Location = New System.Drawing.Point(70, 68)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(172, 20)
        Me.tbNombre.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbIdOSocial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbActiva)
        Me.GroupBox1.Controls.Add(Me.rbAtrasada)
        Me.GroupBox1.Controls.Add(Me.tbNombre)
        Me.GroupBox1.Controls.Add(Me.tbCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 173)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Obra Social"
        '
        'tbIdOSocial
        '
        Me.tbIdOSocial.Location = New System.Drawing.Point(335, 28)
        Me.tbIdOSocial.Name = "tbIdOSocial"
        Me.tbIdOSocial.Size = New System.Drawing.Size(38, 20)
        Me.tbIdOSocial.TabIndex = 10
        Me.tbIdOSocial.Visible = False
        '
        'bSalir
        '
        Me.bSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.Image = Global.SistemaMedico.My.Resources.Resources.Salir
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(377, 420)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(85, 35)
        Me.bSalir.TabIndex = 35
        Me.bSalir.Text = "&Salir"
        Me.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bModificar.Image = Global.SistemaMedico.My.Resources.Resources.edit
        Me.bModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bModificar.Location = New System.Drawing.Point(259, 420)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(85, 35)
        Me.bModificar.TabIndex = 34
        Me.bModificar.Text = "&Modificar"
        Me.bModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.Image = Global.SistemaMedico.My.Resources.Resources.button_cancel
        Me.bEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.Location = New System.Drawing.Point(141, 420)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(85, 35)
        Me.bEliminar.TabIndex = 33
        Me.bEliminar.Text = "&Eliminar"
        Me.bEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bAlta
        '
        Me.bAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAlta.Image = Global.SistemaMedico.My.Resources.Resources.apply
        Me.bAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAlta.Location = New System.Drawing.Point(23, 420)
        Me.bAlta.Name = "bAlta"
        Me.bAlta.Size = New System.Drawing.Size(85, 35)
        Me.bAlta.TabIndex = 32
        Me.bAlta.Text = "&Añadir"
        Me.bAlta.UseVisualStyleBackColor = True
        '
        'FormObrasSociales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 477)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bModificar)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.bAlta)
        Me.Controls.Add(Me.tbBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgObrasSociales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormObrasSociales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Obras Sociales"
        CType(Me.dgObrasSociales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgObrasSociales As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents rbActiva As System.Windows.Forms.RadioButton
    Friend WithEvents rbAtrasada As System.Windows.Forms.RadioButton
    Friend WithEvents tbCodigo As System.Windows.Forms.TextBox
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bAlta As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbIdOSocial As System.Windows.Forms.TextBox
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idOSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
