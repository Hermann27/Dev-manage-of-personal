
Imports System
Imports System.Security.Cryptography
Imports System.Text
Public Class MyMD5
    Private _input As String
    Private _hash As String

    Public Property input() As String
        Get
            Return Me._input
        End Get
        Set(ByVal value As String)
            Me._input = value
        End Set
    End Property

    Public Property hash() As String
        Get
            Return Me._hash
        End Get
        Set(ByVal value As String)
            Me._hash = value
        End Set
    End Property
    ' _hash une chaine d'entree et retourne
    ' une chaine de 32 caracteres hexadecimaux
    Function getMD5hash() As String
        ' creer une nouvelle instance d'un objet MD5
        Dim MD5hasher As MD5 = MD5.Create()
        ' convertie le string _input en tableau de bytes et calcul le _hashage
        Dim data As Byte() = MD5hasher.ComputeHash(Encoding.Default.GetBytes(_input))

        ' creer un stringbuilder pour collecter les bytes et former un string
        Dim sBuilder As New StringBuilder()
        ' convertie chaque bytes en string hexadecimal
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next
        Return sBuilder.ToString
    End Function

    Function verifieMD5hash() As Boolean
        ' hashe le _input
        Dim hashOfinput As String = getMD5hash()
        ' cree un string comparer et compare les hashages
        Dim comparer As StringComparer = StringComparer.Ordinal
        If comparer.Compare(hashOfinput, _hash) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub New(ByVal input As String)
        Me._input = input
    End Sub

    Public Sub New(ByVal input As String, ByVal hash As String)
        Me._input = input
        Me._hash = hash
    End Sub

End Class
