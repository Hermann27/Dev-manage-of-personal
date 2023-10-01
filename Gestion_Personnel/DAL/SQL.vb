Imports System.Data.SqlClient
Imports System.Data.Odbc
Public Class SQL
    Private _SourceDeDonnees As String = Nothing
    Private _Utilisateur As String = Nothing
    Private _MotDePasse As String = Nothing
    Private _Bd As String = Nothing
    Private Shared _ConStr As String = Nothing
    ' Private _Instance As String = Nothing

    Shared ReadOnly Property Chaine() As String
        Get
            Return _ConStr
        End Get
    End Property

    Sub New(ByVal serveur As String, ByVal utilisateur As String, ByVal MotDePasse As String, ByVal Base As String) ', ByVal Instance As String)
        If MotDePasse Is Nothing Then
            If serveur Is Nothing Or Base Is Nothing Then ' Or Instance Is Nothing Then
                Throw New Exception("une des valeur  n'existe pas!")
            Else
                _ConStr = "server=" & serveur & "; uid=" & utilisateur & "; Initial catalog=" & Base
            End If
        Else
            If serveur Is Nothing Or Base Is Nothing Then ' Or Instance Is Nothing Then
                Throw New Exception("une des valeur  n'est pas exacte!")
            Else
                _ConStr = "server= " & serveur & ";uid= " & utilisateur & ";password= " & MotDePasse & ";database=" & Base
                ' _ConStr = "server=" & serveur & "\" & Instance & "; uid=" & utilisateur & "; database=" & Base & "; Password=" & MotDePasse
            End If
        End If
    End Sub

    Sub New()
        If _ConStr Is Nothing Then
            Throw New Exception("Chaine de connexion vide")
        End If
    End Sub

    Public Shared Function GetConnexion() As SqlConnection
        Dim connec As New SqlConnection(Chaine)
        Try
            connec.Open()
            Return connec
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
    Public Shared Function testConnexion() As Boolean
        Dim conn As SqlConnection = Nothing

        Try
            conn = GetConnexion()

            Return True
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
        End Try

    End Function

    Public Shared Sub SetCommand(ByVal Query As String)
        Dim con As SqlConnection = Nothing
        Try
            con = GetConnexion()
            Dim Cmd As SqlCommand
            Cmd = New SqlCommand(Query, con)
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Function GetReader(ByVal Query As String) As SqlDataReader
        Dim Reader As SqlDataReader = Nothing
        Try
            Dim con As SqlConnection = GetConnexion()
            Dim Cmd As New SqlCommand(Query, con)
            Reader = Cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Reader

    End Function

    Public Shared Function AddSlashe(ByVal chaine As String) As String
        If chaine IsNot Nothing Then
            chaine = chaine.Replace("'", "''").Replace("\", "\\")
        End If
        Return chaine

    End Function

    Private Function StoreProcedure(ByVal NomProcedure As String, ByVal ListeParametres As List(Of SqlParameter), ByVal con As SqlConnection) As SqlCommand


        Dim cmd = New SqlCommand(NomProcedure, con)
        cmd.CommandType = CommandType.StoredProcedure

        If ListeParametres IsNot Nothing AndAlso ListeParametres.Count > 0 Then
            For Each parameter As SqlParameter In ListeParametres
                cmd.Parameters.Add(parameter.Parameter, parameter.Type).Value = parameter.Value

            Next

        End If
        Return cmd
    End Function

    Public Sub SetCommand(ByVal NomProcedure As String, ByVal ListeParametres As List(Of SqlParameter))
        Dim con As SqlConnection = Nothing

        Try
            con = GetConnexion()
            Dim cmd = StoreProcedure(NomProcedure, ListeParametres, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

            Throw New Exception(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function GetReader(ByVal NomProcedure As String, ByVal ListeParametres As List(Of SqlParameter)) As SqlDataReader
        Dim Reader As SqlDataReader = Nothing
        Try
            Dim con = GetConnexion()
            Dim cmd = StoreProcedure(NomProcedure, ListeParametres, con)
            Reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Reader
    End Function
End Class


Public Class SqlParameter
    Private _Parameter As String
    Property Parameter() As String
        Get
            Return Me._Parameter
        End Get
        Set(ByVal value As String)
            Me._Parameter = value
        End Set
    End Property

    Private _Type As SqlDbType
    Property Type() As SqlDbType
        Get
            Return Me._Type
        End Get
        Set(ByVal value As SqlDbType)
            Me._Type = value
        End Set
    End Property

    Private _Value As Object
    Property Value() As Object
        Get
            Return Me._Value
        End Get
        Set(ByVal value As Object)
            Me._Value = value
        End Set
    End Property

    Public Sub New(ByVal Parameter As String, ByVal Type As SqlDbType, ByVal Value As Object)
        Me.Parameter = Parameter
        Me.Type = Type
        Me.Value = Value
    End Sub



End Class



