Public Class User
    Private _Iduser As Integer
    Public Property Iduser() As Integer
        Get
            Return Me._Iduser
        End Get
        Set(ByVal value As Integer)
            Me._Iduser = value
        End Set
    End Property
    Private _NomUser As String
    Public Property NomUser() As String
        Get
            Return Me._NomUser
        End Get
        Set(ByVal value As String)
            Me._NomUser = value
        End Set
    End Property
    Private _MotPass As String
    Public Property MotPass() As String
        Get
            Return Me._MotPass
        End Get
        Set(ByVal value As String)
            Me._MotPass = value
        End Set
    End Property
    Private _confirmer As String
    Public Property confirmer() As String
        Get
            Return Me._confirmer
        End Get
        Set(ByVal value As String)
            Me._confirmer = value
        End Set
    End Property
    Private _Privilege As String
    Public Property Privilege() As String
        Get
            Return Me._Privilege
        End Get
        Set(ByVal value As String)
            Me._Privilege = value
        End Set
    End Property
    Private _Compte As String
    Public Property Compte() As String
        Get
            Return Me._Compte
        End Get
        Set(ByVal value As String)
            Me._Compte = value
        End Set
    End Property
    '-------------------------------Entreprises-------------------------------------------------
    Private _Entreprises As Entreprises
    Property Entreprises() As Entreprises
        Get
            Return Me._Entreprises
        End Get
        Set(ByVal value As Entreprises)
            Me._Entreprises = value
            NomEntreprise = value.NomEntreprises
        End Set
    End Property
    Private _Entreprise As String
    Property NomEntreprise() As String
        Get
            Return Me._Entreprises.NomEntreprises
        End Get
        Set(ByVal value As String)
            Me._Entreprise = value
        End Set
    End Property
    Private _Dates As Date
    Property Dates() As Date
        Get
            Return Me._Dates
        End Get
        Set(ByVal value As Date)
            Me._Dates = value
        End Set
    End Property
    Public Sub AddEntreprise(ByVal Entreprises As Entreprises)
        If Entreprises IsNot Nothing Then
            If Entreprises.Search(Me) Is Nothing Then
                If Me.Entreprises IsNot Nothing Then
                    Me.Entreprises.Remove(Me)
                End If
                Me.Entreprises = Entreprises
                Me._Entreprises.List_User.Add(Me)
            End If
        End If
    End Sub
    Public Sub New(ByVal Iduser As Integer, _
                   ByVal NomUser As String, _
                   ByVal MotPass As String, _
                   ByVal confirmer As String, _
                   ByVal Privilege As String, _
                   ByVal Compte As String, _
                   ByVal Dates As Date _
                   )
        Me.Iduser = Iduser
        Me.NomUser = NomUser
        Me.MotPass = MotPass
        Me.confirmer = confirmer
        Me.Privilege = Privilege
        Me.Compte = Compte
        Me.Dates = Dates
    End Sub
End Class
