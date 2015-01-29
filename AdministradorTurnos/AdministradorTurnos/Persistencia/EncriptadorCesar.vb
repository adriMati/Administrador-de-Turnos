
''' <summary>
''' Representa un Encriptador Cesar que se basa en desplazamientos
''' </summary>
''' <remarks></remarks>
Public Class EncriptadorCesar
    Private iDesplazamiento As Integer


    Public Sub New(pDesplazamiento As Integer)
        iDesplazamiento = pDesplazamiento
    End Sub

    Public Function Encriptar(pCadena As String) As String
        Dim cadenaCifrada As String = ""
        Dim letra As Char
        Dim codigo As Integer
        For indice As Integer = 0 To pCadena.Length - 1
            letra = pCadena(indice)
            codigo = Asc(letra)
            codigo += iDesplazamiento
            cadenaCifrada += Convert.ToChar(codigo)
        Next
        Return cadenaCifrada
    End Function

    Public Function Desencriptar(pCadena As String)
        Dim cadenaDescifrada As String = ""
        Dim letra As Char
        Dim codigo As Integer
        'itera toda la cadena, tratando cada caracter para poder desencriptar la
        For indice As Integer = 0 To pCadena.Length - 1
            'Obtengo la letra correspondiente para poder desencriptarla
            letra = pCadena(indice)
            'Obtengo el codigo ASCII de dicha letra
            codigo = Asc(letra)
            'Como estoy desencriptando, el desplazamiento tiene que ser
            'a la izquierda por lo que tengo que restarle el desplazamiento
            'al codigo ASCII de dicha letra
            codigo -= iDesplazamiento
            'concateno letra desencriptada
            cadenaDescifrada += Convert.ToChar(codigo)
        Next
        Return cadenaDescifrada
    End Function
End Class
    

        
        