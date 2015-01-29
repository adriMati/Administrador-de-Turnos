<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfiguracion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbHoraComienzo = New System.Windows.Forms.MaskedTextBox()
        Me.tbHoraFin = New System.Windows.Forms.MaskedTextBox()
        Me.tbDuracionTurno = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora de comienzo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hora de fin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Duración de cada turno"
        '
        'tbHoraComienzo
        '
        Me.tbHoraComienzo.Location = New System.Drawing.Point(143, 21)
        Me.tbHoraComienzo.Mask = "00:00"
        Me.tbHoraComienzo.Name = "tbHoraComienzo"
        Me.tbHoraComienzo.Size = New System.Drawing.Size(50, 20)
        Me.tbHoraComienzo.TabIndex = 3
        Me.tbHoraComienzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbHoraComienzo.ValidatingType = GetType(Date)
        '
        'tbHoraFin
        '
        Me.tbHoraFin.Location = New System.Drawing.Point(143, 72)
        Me.tbHoraFin.Mask = "00:00"
        Me.tbHoraFin.Name = "tbHoraFin"
        Me.tbHoraFin.Size = New System.Drawing.Size(50, 20)
        Me.tbHoraFin.TabIndex = 4
        Me.tbHoraFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbHoraFin.ValidatingType = GetType(Date)
        '
        'tbDuracionTurno
        '
        Me.tbDuracionTurno.Location = New System.Drawing.Point(143, 123)
        Me.tbDuracionTurno.Mask = "99"
        Me.tbDuracionTurno.Name = "tbDuracionTurno"
        Me.tbDuracionTurno.Size = New System.Drawing.Size(50, 20)
        Me.tbDuracionTurno.TabIndex = 5
        Me.tbDuracionTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "min"
        '
        'bAceptar
        '
        Me.bAceptar.Image = Global.AdministradorTurnos.My.Resources.Resources.apply
        Me.bAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAceptar.Location = New System.Drawing.Point(40, 190)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(75, 23)
        Me.bAceptar.TabIndex = 7
        Me.bAceptar.Text = "&Aceptar"
        Me.bAceptar.UseVisualStyleBackColor = True
        '
        'bCancelar
        '
        Me.bCancelar.Image = Global.AdministradorTurnos.My.Resources.Resources.button_cancel
        Me.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.Location = New System.Drawing.Point(148, 190)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(75, 23)
        Me.bCancelar.TabIndex = 8
        Me.bCancelar.Text = "&Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'FormConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 258)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbDuracionTurno)
        Me.Controls.Add(Me.tbHoraFin)
        Me.Controls.Add(Me.tbHoraComienzo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormConfiguracion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Turnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbHoraComienzo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tbHoraFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tbDuracionTurno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bAceptar As System.Windows.Forms.Button
    Friend WithEvents bCancelar As System.Windows.Forms.Button
End Class
