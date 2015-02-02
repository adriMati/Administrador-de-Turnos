<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFichaMedica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFichaMedica))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbIdPaciente = New System.Windows.Forms.TextBox()
        Me.tbFechaConsulta = New System.Windows.Forms.TextBox()
        Me.tbMotivo = New System.Windows.Forms.TextBox()
        Me.tbEvaluacion = New System.Windows.Forms.RichTextBox()
        Me.tbEstCompl = New System.Windows.Forms.RichTextBox()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Consulta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Observaciones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Motivo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estudios Complementarios"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(37, 25)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.ReadOnly = True
        Me.tbNombre.Size = New System.Drawing.Size(224, 20)
        Me.tbNombre.TabIndex = 7
        Me.tbNombre.TabStop = False
        '
        'tbIdPaciente
        '
        Me.tbIdPaciente.Location = New System.Drawing.Point(304, 12)
        Me.tbIdPaciente.Name = "tbIdPaciente"
        Me.tbIdPaciente.Size = New System.Drawing.Size(37, 20)
        Me.tbIdPaciente.TabIndex = 8
        Me.tbIdPaciente.TabStop = False
        Me.tbIdPaciente.Visible = False
        '
        'tbFechaConsulta
        '
        Me.tbFechaConsulta.Location = New System.Drawing.Point(37, 64)
        Me.tbFechaConsulta.Name = "tbFechaConsulta"
        Me.tbFechaConsulta.Size = New System.Drawing.Size(224, 20)
        Me.tbFechaConsulta.TabIndex = 1
        '
        'tbMotivo
        '
        Me.tbMotivo.Location = New System.Drawing.Point(37, 103)
        Me.tbMotivo.Name = "tbMotivo"
        Me.tbMotivo.Size = New System.Drawing.Size(224, 20)
        Me.tbMotivo.TabIndex = 2
        '
        'tbEvaluacion
        '
        Me.tbEvaluacion.Location = New System.Drawing.Point(37, 151)
        Me.tbEvaluacion.Name = "tbEvaluacion"
        Me.tbEvaluacion.Size = New System.Drawing.Size(224, 78)
        Me.tbEvaluacion.TabIndex = 3
        Me.tbEvaluacion.Text = ""
        '
        'tbEstCompl
        '
        Me.tbEstCompl.Location = New System.Drawing.Point(287, 151)
        Me.tbEstCompl.Name = "tbEstCompl"
        Me.tbEstCompl.Size = New System.Drawing.Size(224, 78)
        Me.tbEstCompl.TabIndex = 4
        Me.tbEstCompl.Text = ""
        '
        'bCancelar
        '
        Me.bCancelar.Image = Global.SistemaMedico.My.Resources.Resources.button_cancel
        Me.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.Location = New System.Drawing.Point(245, 262)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(75, 23)
        Me.bCancelar.TabIndex = 6
        Me.bCancelar.Text = "&Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'bGuardar
        '
        Me.bGuardar.Image = Global.SistemaMedico.My.Resources.Resources.filesave
        Me.bGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.Location = New System.Drawing.Point(120, 262)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(75, 23)
        Me.bGuardar.TabIndex = 5
        Me.bGuardar.Text = "&Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'FormFichaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 309)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.tbEstCompl)
        Me.Controls.Add(Me.tbEvaluacion)
        Me.Controls.Add(Me.tbMotivo)
        Me.Controls.Add(Me.tbFechaConsulta)
        Me.Controls.Add(Me.tbIdPaciente)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormFichaMedica"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha Médica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbIdPaciente As System.Windows.Forms.TextBox
    Friend WithEvents tbFechaConsulta As System.Windows.Forms.TextBox
    Friend WithEvents tbMotivo As System.Windows.Forms.TextBox
    Friend WithEvents tbEvaluacion As System.Windows.Forms.RichTextBox
    Friend WithEvents tbEstCompl As System.Windows.Forms.RichTextBox
    Friend WithEvents bGuardar As System.Windows.Forms.Button
    Friend WithEvents bCancelar As System.Windows.Forms.Button
End Class
