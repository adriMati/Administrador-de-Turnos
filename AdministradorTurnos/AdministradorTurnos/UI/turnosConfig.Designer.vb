﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.18408
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")>  _
Partial Friend NotInheritable Class turnosConfig
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As turnosConfig = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New turnosConfig()),turnosConfig)
    
    Public Shared ReadOnly Property [Default]() As turnosConfig
        Get
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("08:00")>  _
    Public Property horaComienzo() As String
        Get
            Return CType(Me("horaComienzo"),String)
        End Get
        Set
            Me("horaComienzo") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("20:00")>  _
    Public Property horaFin() As String
        Get
            Return CType(Me("horaFin"),String)
        End Get
        Set
            Me("horaFin") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
    Public Property intervaloTurno() As String
        Get
            Return CType(Me("intervaloTurno"),String)
        End Get
        Set
            Me("intervaloTurno") = value
        End Set
    End Property
End Class
