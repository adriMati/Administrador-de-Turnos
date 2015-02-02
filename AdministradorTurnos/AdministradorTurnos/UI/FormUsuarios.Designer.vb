<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbContraseña = New System.Windows.Forms.TextBox()
        Me.gbPermisos = New System.Windows.Forms.GroupBox()
        Me.rbSecretaria = New System.Windows.Forms.RadioButton()
        Me.rbAdministrador = New System.Windows.Forms.RadioButton()
        Me.gbUsuario = New System.Windows.Forms.GroupBox()
        Me.tbIdUsuario = New System.Windows.Forms.TextBox()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.permisoAdministrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.permisoSecretaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbPermisos.SuspendLayout()
        Me.gbUsuario.SuspendLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(73, 21)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(139, 20)
        Me.tbUsuario.TabIndex = 1
        '
        'tbContraseña
        '
        Me.tbContraseña.Location = New System.Drawing.Point(73, 58)
        Me.tbContraseña.Name = "tbContraseña"
        Me.tbContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbContraseña.Size = New System.Drawing.Size(139, 20)
        Me.tbContraseña.TabIndex = 2
        '
        'gbPermisos
        '
        Me.gbPermisos.Controls.Add(Me.rbSecretaria)
        Me.gbPermisos.Controls.Add(Me.rbAdministrador)
        Me.gbPermisos.Location = New System.Drawing.Point(9, 101)
        Me.gbPermisos.Name = "gbPermisos"
        Me.gbPermisos.Size = New System.Drawing.Size(157, 82)
        Me.gbPermisos.TabIndex = 8
        Me.gbPermisos.TabStop = False
        Me.gbPermisos.Text = "Permisos"
        '
        'rbSecretaria
        '
        Me.rbSecretaria.AutoSize = True
        Me.rbSecretaria.Location = New System.Drawing.Point(10, 42)
        Me.rbSecretaria.Name = "rbSecretaria"
        Me.rbSecretaria.Size = New System.Drawing.Size(73, 17)
        Me.rbSecretaria.TabIndex = 4
        Me.rbSecretaria.Text = "Secretaria"
        Me.rbSecretaria.UseVisualStyleBackColor = True
        '
        'rbAdministrador
        '
        Me.rbAdministrador.AutoSize = True
        Me.rbAdministrador.Checked = True
        Me.rbAdministrador.Location = New System.Drawing.Point(10, 19)
        Me.rbAdministrador.Name = "rbAdministrador"
        Me.rbAdministrador.Size = New System.Drawing.Size(88, 17)
        Me.rbAdministrador.TabIndex = 3
        Me.rbAdministrador.TabStop = True
        Me.rbAdministrador.Text = "Administrador"
        Me.rbAdministrador.UseVisualStyleBackColor = True
        '
        'gbUsuario
        '
        Me.gbUsuario.Controls.Add(Me.tbIdUsuario)
        Me.gbUsuario.Controls.Add(Me.Label2)
        Me.gbUsuario.Controls.Add(Me.Label1)
        Me.gbUsuario.Controls.Add(Me.tbUsuario)
        Me.gbUsuario.Controls.Add(Me.gbPermisos)
        Me.gbUsuario.Controls.Add(Me.tbContraseña)
        Me.gbUsuario.Location = New System.Drawing.Point(12, 181)
        Me.gbUsuario.Name = "gbUsuario"
        Me.gbUsuario.Size = New System.Drawing.Size(225, 208)
        Me.gbUsuario.TabIndex = 11
        Me.gbUsuario.TabStop = False
        Me.gbUsuario.Text = "Usuario"
        '
        'tbIdUsuario
        '
        Me.tbIdUsuario.Location = New System.Drawing.Point(156, 84)
        Me.tbIdUsuario.Name = "tbIdUsuario"
        Me.tbIdUsuario.Size = New System.Drawing.Size(40, 20)
        Me.tbIdUsuario.TabIndex = 16
        Me.tbIdUsuario.TabStop = False
        Me.tbIdUsuario.Visible = False
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.usuario, Me.permisoAdministrador, Me.permisoSecretaria, Me.contraseña, Me.idUsuario})
        Me.dgUsuarios.Location = New System.Drawing.Point(19, 19)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUsuarios.Size = New System.Drawing.Size(287, 129)
        Me.dgUsuarios.TabIndex = 12
        Me.dgUsuarios.TabStop = False
        '
        'usuario
        '
        Me.usuario.DataPropertyName = "nombreUsuario"
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'permisoAdministrador
        '
        Me.permisoAdministrador.DataPropertyName = "permisoAdministrador"
        Me.permisoAdministrador.HeaderText = "permisoAdministrador"
        Me.permisoAdministrador.Name = "permisoAdministrador"
        Me.permisoAdministrador.ReadOnly = True
        Me.permisoAdministrador.Visible = False
        '
        'permisoSecretaria
        '
        Me.permisoSecretaria.DataPropertyName = "permisoSecretaria"
        Me.permisoSecretaria.HeaderText = "permisoSecretaria"
        Me.permisoSecretaria.Name = "permisoSecretaria"
        Me.permisoSecretaria.ReadOnly = True
        Me.permisoSecretaria.Visible = False
        '
        'contraseña
        '
        Me.contraseña.DataPropertyName = "contraseña"
        Me.contraseña.HeaderText = "Contraseña"
        Me.contraseña.Name = "contraseña"
        Me.contraseña.ReadOnly = True
        Me.contraseña.Visible = False
        '
        'idUsuario
        '
        Me.idUsuario.DataPropertyName = "idUsuario"
        Me.idUsuario.HeaderText = "idUsuario"
        Me.idUsuario.Name = "idUsuario"
        Me.idUsuario.ReadOnly = True
        Me.idUsuario.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgUsuarios)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 163)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'bEliminar
        '
        Me.bEliminar.Image = Global.SistemaMedico.My.Resources.Resources.button_cancel
        Me.bEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.Location = New System.Drawing.Point(243, 295)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(75, 40)
        Me.bEliminar.TabIndex = 7
        Me.bEliminar.Text = "&Eliminar"
        Me.bEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Image = Global.SistemaMedico.My.Resources.Resources.edit
        Me.bModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bModificar.Location = New System.Drawing.Point(243, 240)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(75, 37)
        Me.bModificar.TabIndex = 6
        Me.bModificar.Text = "&Modificar"
        Me.bModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bCancelar
        '
        Me.bCancelar.Image = Global.SistemaMedico.My.Resources.Resources._exit
        Me.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCancelar.Location = New System.Drawing.Point(243, 353)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(75, 34)
        Me.bCancelar.TabIndex = 8
        Me.bCancelar.Text = "&Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'bGuardar
        '
        Me.bGuardar.Image = Global.SistemaMedico.My.Resources.Resources.filesave
        Me.bGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGuardar.Location = New System.Drawing.Point(243, 188)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(75, 34)
        Me.bGuardar.TabIndex = 5
        Me.bGuardar.Text = "&Guardar"
        Me.bGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 401)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.bModificar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.gbUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.gbPermisos.ResumeLayout(False)
        Me.gbPermisos.PerformLayout()
        Me.gbUsuario.ResumeLayout(False)
        Me.gbUsuario.PerformLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tbContraseña As System.Windows.Forms.TextBox
    Friend WithEvents gbPermisos As System.Windows.Forms.GroupBox
    Friend WithEvents gbUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents bGuardar As System.Windows.Forms.Button
    Friend WithEvents bCancelar As System.Windows.Forms.Button
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents rbSecretaria As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdministrador As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents tbIdUsuario As System.Windows.Forms.TextBox
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents permisoAdministrador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents permisoSecretaria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contraseña As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
