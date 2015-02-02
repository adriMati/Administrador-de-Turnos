<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaTurno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAltaTurno))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbMotivo = New System.Windows.Forms.TextBox()
        Me.tbPaciente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.tbHora = New System.Windows.Forms.TextBox()
        Me.tbIdPaciente = New System.Windows.Forms.TextBox()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bAsignar = New System.Windows.Forms.Button()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Motivo"
        '
        'tbMotivo
        '
        Me.tbMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMotivo.Location = New System.Drawing.Point(83, 114)
        Me.tbMotivo.Name = "tbMotivo"
        Me.tbMotivo.Size = New System.Drawing.Size(255, 20)
        Me.tbMotivo.TabIndex = 2
        '
        'tbPaciente
        '
        Me.tbPaciente.Location = New System.Drawing.Point(83, 66)
        Me.tbPaciente.Name = "tbPaciente"
        Me.tbPaciente.ReadOnly = True
        Me.tbPaciente.Size = New System.Drawing.Size(221, 20)
        Me.tbPaciente.TabIndex = 4
        Me.tbPaciente.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha"
        '
        'tbFecha
        '
        Me.tbFecha.Location = New System.Drawing.Point(83, 18)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.ReadOnly = True
        Me.tbFecha.Size = New System.Drawing.Size(106, 20)
        Me.tbFecha.TabIndex = 7
        Me.tbFecha.TabStop = False
        Me.tbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbHora
        '
        Me.tbHora.Location = New System.Drawing.Point(232, 18)
        Me.tbHora.Name = "tbHora"
        Me.tbHora.ReadOnly = True
        Me.tbHora.Size = New System.Drawing.Size(106, 20)
        Me.tbHora.TabIndex = 8
        Me.tbHora.TabStop = False
        Me.tbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbIdPaciente
        '
        Me.tbIdPaciente.Location = New System.Drawing.Point(279, 40)
        Me.tbIdPaciente.Name = "tbIdPaciente"
        Me.tbIdPaciente.Size = New System.Drawing.Size(42, 20)
        Me.tbIdPaciente.TabIndex = 12
        Me.tbIdPaciente.TabStop = False
        Me.tbIdPaciente.Visible = False
        '
        'bCancelar
        '
        Me.bCancelar.Image = Global.SistemaMedico.My.Resources.Resources.button_cancel
        Me.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.Location = New System.Drawing.Point(191, 154)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(75, 23)
        Me.bCancelar.TabIndex = 4
        Me.bCancelar.Text = "&Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'bAsignar
        '
        Me.bAsignar.Image = Global.SistemaMedico.My.Resources.Resources.apply1
        Me.bAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAsignar.Location = New System.Drawing.Point(83, 154)
        Me.bAsignar.Name = "bAsignar"
        Me.bAsignar.Size = New System.Drawing.Size(75, 23)
        Me.bAsignar.TabIndex = 3
        Me.bAsignar.Text = "&Asignar"
        Me.bAsignar.UseVisualStyleBackColor = True
        '
        'bBuscar
        '
        Me.bBuscar.Image = Global.SistemaMedico.My.Resources.Resources.search
        Me.bBuscar.Location = New System.Drawing.Point(310, 64)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(28, 22)
        Me.bBuscar.TabIndex = 1
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'FormAltaTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 198)
        Me.Controls.Add(Me.tbIdPaciente)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bAsignar)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.tbHora)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbPaciente)
        Me.Controls.Add(Me.tbMotivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormAltaTurno"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Turno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbMotivo As System.Windows.Forms.TextBox
    Friend WithEvents tbPaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbFecha As System.Windows.Forms.TextBox
    Friend WithEvents tbHora As System.Windows.Forms.TextBox
    Friend WithEvents bBuscar As System.Windows.Forms.Button
    Friend WithEvents bAsignar As System.Windows.Forms.Button
    Friend WithEvents bCancelar As System.Windows.Forms.Button
    Friend WithEvents tbIdPaciente As System.Windows.Forms.TextBox
End Class
