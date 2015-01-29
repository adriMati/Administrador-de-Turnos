Public Class DAOExcepcion
    Inherits Exception

    Public Sub New(pMensaje As String)
        MyBase.New(pMensaje)
    End Sub
End Class
