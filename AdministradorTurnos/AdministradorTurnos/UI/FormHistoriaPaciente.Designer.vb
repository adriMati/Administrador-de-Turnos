<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHistoriaPaciente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbOSocial = New System.Windows.Forms.TextBox()
        Me.tbFechaNac = New System.Windows.Forms.TextBox()
        Me.tbDni = New System.Windows.Forms.TextBox()
        Me.tbNumAfiliado = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbIdPaciente = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgFichasMedicas = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFichaMedica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estudiosCompl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.evaluacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbFichaMedica = New System.Windows.Forms.GroupBox()
        Me.tbEstCompl = New System.Windows.Forms.RichTextBox()
        Me.tbObservacion = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbMotivo = New System.Windows.Forms.TextBox()
        Me.tbIdTurno = New System.Windows.Forms.TextBox()
        Me.tbFechaConsulta = New System.Windows.Forms.TextBox()
        Me.bNuevaFicha = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgFichasMedicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFichaMedica.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "D.N.I"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Obra Social"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Num Afiliado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Nacimiento"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(101, 21)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.ReadOnly = True
        Me.tbNombre.Size = New System.Drawing.Size(178, 20)
        Me.tbNombre.TabIndex = 1
        '
        'tbOSocial
        '
        Me.tbOSocial.Location = New System.Drawing.Point(101, 77)
        Me.tbOSocial.Name = "tbOSocial"
        Me.tbOSocial.ReadOnly = True
        Me.tbOSocial.Size = New System.Drawing.Size(178, 20)
        Me.tbOSocial.TabIndex = 4
        '
        'tbFechaNac
        '
        Me.tbFechaNac.Location = New System.Drawing.Point(101, 47)
        Me.tbFechaNac.Name = "tbFechaNac"
        Me.tbFechaNac.ReadOnly = True
        Me.tbFechaNac.Size = New System.Drawing.Size(178, 20)
        Me.tbFechaNac.TabIndex = 3
        '
        'tbDni
        '
        Me.tbDni.Location = New System.Drawing.Point(323, 18)
        Me.tbDni.Name = "tbDni"
        Me.tbDni.ReadOnly = True
        Me.tbDni.Size = New System.Drawing.Size(136, 20)
        Me.tbDni.TabIndex = 2
        '
        'tbNumAfiliado
        '
        Me.tbNumAfiliado.Location = New System.Drawing.Point(357, 77)
        Me.tbNumAfiliado.Name = "tbNumAfiliado"
        Me.tbNumAfiliado.ReadOnly = True
        Me.tbNumAfiliado.Size = New System.Drawing.Size(97, 20)
        Me.tbNumAfiliado.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbIdPaciente)
        Me.GroupBox1.Controls.Add(Me.tbFechaNac)
        Me.GroupBox1.Controls.Add(Me.tbNumAfiliado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbDni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbOSocial)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 121)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paciente"
        '
        'tbIdPaciente
        '
        Me.tbIdPaciente.Location = New System.Drawing.Point(362, 46)
        Me.tbIdPaciente.Name = "tbIdPaciente"
        Me.tbIdPaciente.Size = New System.Drawing.Size(37, 20)
        Me.tbIdPaciente.TabIndex = 10
        Me.tbIdPaciente.TabStop = False
        Me.tbIdPaciente.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgFichasMedicas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 165)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historia"
        '
        'dgFichasMedicas
        '
        Me.dgFichasMedicas.AllowUserToAddRows = False
        Me.dgFichasMedicas.AllowUserToDeleteRows = False
        Me.dgFichasMedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFichasMedicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.idPaciente, Me.idFichaMedica, Me.estudiosCompl, Me.evaluacion, Me.motivo})
        Me.dgFichasMedicas.Location = New System.Drawing.Point(21, 28)
        Me.dgFichasMedicas.Name = "dgFichasMedicas"
        Me.dgFichasMedicas.ReadOnly = True
        Me.dgFichasMedicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFichasMedicas.Size = New System.Drawing.Size(330, 126)
        Me.dgFichasMedicas.TabIndex = 0
        Me.dgFichasMedicas.TabStop = False
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "FechaConsulta"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'idPaciente
        '
        Me.idPaciente.DataPropertyName = "IdPaciente"
        Me.idPaciente.HeaderText = "idPaciente"
        Me.idPaciente.Name = "idPaciente"
        Me.idPaciente.ReadOnly = True
        Me.idPaciente.Visible = False
        '
        'idFichaMedica
        '
        Me.idFichaMedica.DataPropertyName = "IdFichaMedica"
        Me.idFichaMedica.HeaderText = "idFichaMedica"
        Me.idFichaMedica.Name = "idFichaMedica"
        Me.idFichaMedica.ReadOnly = True
        Me.idFichaMedica.Visible = False
        '
        'estudiosCompl
        '
        Me.estudiosCompl.DataPropertyName = "EstudiosComplementarios"
        Me.estudiosCompl.HeaderText = "estudiosCompl"
        Me.estudiosCompl.Name = "estudiosCompl"
        Me.estudiosCompl.ReadOnly = True
        Me.estudiosCompl.Visible = False
        '
        'evaluacion
        '
        Me.evaluacion.DataPropertyName = "Evaluacion"
        Me.evaluacion.HeaderText = "evaluacion"
        Me.evaluacion.Name = "evaluacion"
        Me.evaluacion.ReadOnly = True
        Me.evaluacion.Visible = False
        '
        'motivo
        '
        Me.motivo.DataPropertyName = "Motivo"
        Me.motivo.HeaderText = "Motivo"
        Me.motivo.Name = "motivo"
        Me.motivo.ReadOnly = True
        Me.motivo.Width = 150
        '
        'gbFichaMedica
        '
        Me.gbFichaMedica.Controls.Add(Me.tbEstCompl)
        Me.gbFichaMedica.Controls.Add(Me.tbObservacion)
        Me.gbFichaMedica.Controls.Add(Me.Label7)
        Me.gbFichaMedica.Controls.Add(Me.Label6)
        Me.gbFichaMedica.Location = New System.Drawing.Point(12, 321)
        Me.gbFichaMedica.Name = "gbFichaMedica"
        Me.gbFichaMedica.Size = New System.Drawing.Size(516, 177)
        Me.gbFichaMedica.TabIndex = 12
        Me.gbFichaMedica.TabStop = False
        Me.gbFichaMedica.Text = "Ficha"
        '
        'tbEstCompl
        '
        Me.tbEstCompl.Location = New System.Drawing.Point(263, 41)
        Me.tbEstCompl.Name = "tbEstCompl"
        Me.tbEstCompl.ReadOnly = True
        Me.tbEstCompl.Size = New System.Drawing.Size(236, 112)
        Me.tbEstCompl.TabIndex = 3
        Me.tbEstCompl.Text = ""
        '
        'tbObservacion
        '
        Me.tbObservacion.Location = New System.Drawing.Point(9, 41)
        Me.tbObservacion.Name = "tbObservacion"
        Me.tbObservacion.ReadOnly = True
        Me.tbObservacion.Size = New System.Drawing.Size(236, 112)
        Me.tbObservacion.TabIndex = 2
        Me.tbObservacion.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(269, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Estudios Complementarios"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Observación"
        '
        'tbMotivo
        '
        Me.tbMotivo.Location = New System.Drawing.Point(411, 227)
        Me.tbMotivo.Name = "tbMotivo"
        Me.tbMotivo.Size = New System.Drawing.Size(43, 20)
        Me.tbMotivo.TabIndex = 15
        Me.tbMotivo.TabStop = False
        Me.tbMotivo.Visible = False
        '
        'tbIdTurno
        '
        Me.tbIdTurno.Location = New System.Drawing.Point(418, 253)
        Me.tbIdTurno.Name = "tbIdTurno"
        Me.tbIdTurno.Size = New System.Drawing.Size(36, 20)
        Me.tbIdTurno.TabIndex = 16
        Me.tbIdTurno.TabStop = False
        Me.tbIdTurno.Visible = False
        '
        'tbFechaConsulta
        '
        Me.tbFechaConsulta.Location = New System.Drawing.Point(466, 233)
        Me.tbFechaConsulta.Name = "tbFechaConsulta"
        Me.tbFechaConsulta.Size = New System.Drawing.Size(28, 20)
        Me.tbFechaConsulta.TabIndex = 17
        Me.tbFechaConsulta.TabStop = False
        Me.tbFechaConsulta.Visible = False
        '
        'bNuevaFicha
        '
        Me.bNuevaFicha.Image = Global.AdministradorTurnos.My.Resources.Resources.historiaMedica1
        Me.bNuevaFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bNuevaFicha.Location = New System.Drawing.Point(386, 154)
        Me.bNuevaFicha.Name = "bNuevaFicha"
        Me.bNuevaFicha.Size = New System.Drawing.Size(110, 40)
        Me.bNuevaFicha.TabIndex = 7
        Me.bNuevaFicha.Text = "&Nueva Ficha"
        Me.bNuevaFicha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bNuevaFicha.UseVisualStyleBackColor = True
        '
        'FormHistoriaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(544, 511)
        Me.Controls.Add(Me.tbFechaConsulta)
        Me.Controls.Add(Me.tbIdTurno)
        Me.Controls.Add(Me.tbMotivo)
        Me.Controls.Add(Me.bNuevaFicha)
        Me.Controls.Add(Me.gbFichaMedica)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormHistoriaPaciente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Paciente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgFichasMedicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFichaMedica.ResumeLayout(False)
        Me.gbFichaMedica.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbOSocial As System.Windows.Forms.TextBox
    Friend WithEvents tbFechaNac As System.Windows.Forms.TextBox
    Friend WithEvents tbDni As System.Windows.Forms.TextBox
    Friend WithEvents tbNumAfiliado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgFichasMedicas As System.Windows.Forms.DataGridView
    Friend WithEvents gbFichaMedica As System.Windows.Forms.GroupBox
    Friend WithEvents bNuevaFicha As System.Windows.Forms.Button
    Friend WithEvents tbEstCompl As System.Windows.Forms.RichTextBox
    Friend WithEvents tbObservacion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbMotivo As System.Windows.Forms.TextBox
    Friend WithEvents tbIdTurno As System.Windows.Forms.TextBox
    Friend WithEvents tbIdPaciente As System.Windows.Forms.TextBox
    Friend WithEvents tbFechaConsulta As System.Windows.Forms.TextBox
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPaciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idFichaMedica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estudiosCompl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents evaluacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents motivo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
