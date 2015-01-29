<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministracionTurnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdministracionTurnos))
        Me.bAnular = New System.Windows.Forms.Button()
        Me.dgTurnos = New System.Windows.Forms.DataGridView()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcFechaTurno = New System.Windows.Forms.MonthCalendar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bAnular
        '
        Me.bAnular.Image = Global.AdministradorTurnos.My.Resources.Resources.button_cancel
        Me.bAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAnular.Location = New System.Drawing.Point(158, 232)
        Me.bAnular.Name = "bAnular"
        Me.bAnular.Size = New System.Drawing.Size(75, 23)
        Me.bAnular.TabIndex = 8
        Me.bAnular.Text = "&Anular"
        Me.bAnular.UseVisualStyleBackColor = True
        '
        'dgTurnos
        '
        Me.dgTurnos.AllowUserToAddRows = False
        Me.dgTurnos.AllowUserToDeleteRows = False
        Me.dgTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTurnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hora, Me.paciente, Me.motivo, Me.idPaciente, Me.idTurno, Me.fecha})
        Me.dgTurnos.Location = New System.Drawing.Point(245, 33)
        Me.dgTurnos.Name = "dgTurnos"
        Me.dgTurnos.ReadOnly = True
        Me.dgTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTurnos.Size = New System.Drawing.Size(432, 415)
        Me.dgTurnos.TabIndex = 7
        '
        'hora
        '
        Me.hora.DataPropertyName = "hora"
        Me.hora.HeaderText = "Hora"
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        '
        'paciente
        '
        Me.paciente.DataPropertyName = "NombrePaciente"
        Me.paciente.HeaderText = "Paciente"
        Me.paciente.Name = "paciente"
        Me.paciente.ReadOnly = True
        Me.paciente.Width = 250
        '
        'motivo
        '
        Me.motivo.DataPropertyName = "motivo"
        Me.motivo.HeaderText = "motivo"
        Me.motivo.Name = "motivo"
        Me.motivo.ReadOnly = True
        Me.motivo.Visible = False
        '
        'idPaciente
        '
        Me.idPaciente.DataPropertyName = "idPaciente"
        Me.idPaciente.HeaderText = "idPaciente"
        Me.idPaciente.Name = "idPaciente"
        Me.idPaciente.ReadOnly = True
        Me.idPaciente.Visible = False
        '
        'idTurno
        '
        Me.idTurno.DataPropertyName = "IdTurno"
        Me.idTurno.HeaderText = "idTurno"
        Me.idTurno.Name = "idTurno"
        Me.idTurno.ReadOnly = True
        Me.idTurno.Visible = False
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "Fecha"
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Visible = False
        '
        'mcFechaTurno
        '
        Me.mcFechaTurno.Location = New System.Drawing.Point(6, 33)
        Me.mcFechaTurno.Name = "mcFechaTurno"
        Me.mcFechaTurno.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Image = Global.AdministradorTurnos.My.Resources.Resources.configuracion
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "&Configuración"
        '
        'FormAdministracionTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 456)
        Me.Controls.Add(Me.bAnular)
        Me.Controls.Add(Me.dgTurnos)
        Me.Controls.Add(Me.mcFechaTurno)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormAdministracionTurnos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Turnos"
        CType(Me.dgTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bAnular As System.Windows.Forms.Button
    Friend WithEvents dgTurnos As System.Windows.Forms.DataGridView
    Friend WithEvents mcFechaTurno As System.Windows.Forms.MonthCalendar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents motivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPaciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idTurno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
