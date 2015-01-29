<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VerTurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionDeTurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerTurnosToolStripMenuItem, Me.AdministracionDeTurnosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.PacientesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(700, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "menu"
        '
        'VerTurnosToolStripMenuItem
        '
        Me.VerTurnosToolStripMenuItem.Name = "VerTurnosToolStripMenuItem"
        Me.VerTurnosToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.VerTurnosToolStripMenuItem.Text = "&Turnos"
        '
        'AdministracionDeTurnosToolStripMenuItem
        '
        Me.AdministracionDeTurnosToolStripMenuItem.Name = "AdministracionDeTurnosToolStripMenuItem"
        Me.AdministracionDeTurnosToolStripMenuItem.Size = New System.Drawing.Size(156, 20)
        Me.AdministracionDeTurnosToolStripMenuItem.Text = "&Administración de Turnos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = Global.AdministradorTurnos.My.Resources.Resources.Cliente
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.UsuariosToolStripMenuItem.Text = "&Usuarios"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.Image = Global.AdministradorTurnos.My.Resources.Resources.Age_Child_Male_Dark_icon
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.PacientesToolStripMenuItem.Text = "&Pacientes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(700, 419)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Médico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VerTurnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministracionDeTurnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
