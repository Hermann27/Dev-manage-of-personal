Public Class Entreprises
    Private _IdEntreprise As Integer
    Public Property IdEntreprise() As Integer
        Get
            Return Me._IdEntreprise
        End Get
        Set(ByVal value As Integer)
            Me._IdEntreprise = value
        End Set
    End Property
    Private _RaisonSociale As String
    Public Property RaisonSociale() As String
        Get
            Return Me._RaisonSociale
        End Get
        Set(ByVal value As String)
            Me._RaisonSociale = value
        End Set
    End Property
    Private _Adresse As String
    Public Property Adresse() As String
        Get
            Return Me._Adresse
        End Get
        Set(ByVal value As String)
            Me._Adresse = value
        End Set
    End Property
    Private _Code_Postal As String
    Public Property Code_Postal() As String
        Get
            Return Me._Code_Postal
        End Get
        Set(ByVal value As String)
            Me._Code_Postal = value
        End Set
    End Property

    Private _Ville As String
    Public Property Ville() As String
        Get
            Return Me._Ville
        End Get
        Set(ByVal value As String)
            Me._Ville = value
        End Set
    End Property
    Private _Telephone As Integer
    Public Property Telephone() As Integer
        Get
            Return Me._Telephone
        End Get
        Set(ByVal value As Integer)
            Me._Telephone = value
        End Set
    End Property
    Private _Email As String
    Public Property Email() As String
        Get
            Return Me._Email
        End Get
        Set(ByVal value As String)
            Me._Email = value
        End Set
    End Property
    Private _Site_Internet As String
    Public Property Site_Internet() As String
        Get
            Return Me._Site_Internet
        End Get
        Set(ByVal value As String)
            Me._Site_Internet = value
        End Set
    End Property
    Private _Forme_Juridique As String
    Public Property Forme_Juridique() As String
        Get
            Return Me._Forme_Juridique
        End Get
        Set(ByVal value As String)
            Me._Forme_Juridique = value
        End Set
    End Property
    Private _Capitale As String
    Public Property Capitale() As String
        Get
            Return Me._Capitale
        End Get
        Set(ByVal value As String)
            Me._Capitale = value
        End Set
    End Property
    Private _NomEntreprises As String
    Public Property NomEntreprises() As String
        Get
            Return Me._NomEntreprises
        End Get
        Set(ByVal value As String)
            Me._NomEntreprises = value
        End Set
    End Property
    'creation de la liste des employes dans une entreprise
    Private _List_Employes As New List(Of Employes)
    ReadOnly Property List_Employes() As List(Of Employes)
        Get
            Return _List_Employes
        End Get
    End Property
    'ajouter un employe dans la liste des employes qui sont dans l'entreprise
    Public Sub AddEmployes(ByVal Employes As Employes)
        If Employes IsNot Nothing Then
            If Search(Employes) Is Nothing Then
                If Employes.Entreprises IsNot Nothing Then
                    Employes.Entreprises.Remove(Employes)
                End If
            End If
            Employes.Entreprises = Me
            Me._List_Employes.Add(Employes)

        End If
    End Sub
    'rechercher un employe dans la liste qui ce trouve dans l'entreprise
    Public Function Search(ByVal Employe As Employes) As Employes
        If Me._List_Employes IsNot Nothing Then
            For Each ol As Employes In Me._List_Employes
                If ol.Matricule = Employe.Matricule Then
                    Return ol
                End If
            Next
        End If
        Return Nothing
    End Function
    'retire un employe dans la liste qui ce trouve dans l'entreprise
    Public Sub Remove(ByVal Employe As Employes)
        Me._List_Employes.Remove(Search(Employe))
    End Sub

    'creation de la liste des stagaires dans une entreprise
    Private _List_Stagaire As New List(Of Stagaires)
    ReadOnly Property List_Stagaires() As List(Of Stagaires)
        Get
            Return _List_Stagaire
        End Get
    End Property
    'ajouter un stagaire dans la liste des employes qui sont dans l'entreprise
    Public Sub AddStagaires(ByVal Stagaires As Stagaires)
        If Stagaires IsNot Nothing Then
            If Search(Stagaires) Is Nothing Then
                If Stagaires.Entreprises IsNot Nothing Then
                    Stagaires.Entreprises.Remove(Stagaires)
                End If
            End If
            Stagaires.Entreprises = Me
            Me._List_Stagaire.Add(Stagaires)

        End If
    End Sub
    'rechercher un stagaire dans la liste qui ce trouve dans 'entreprise
    Public Function Search(ByVal Stagaires As Stagaires) As Stagaires
        If Me._List_Stagaire IsNot Nothing Then
            For Each ol As Stagaires In Me._List_Stagaire
                If ol.Id = Stagaires.Id Then
                    Return ol
                End If
            Next
        End If
        Return Nothing
    End Function
    'retire un stagaire dans la liste qui ce trouve dans l'entreprise
    Public Sub Remove(ByVal Stagaires As Stagaires)
        Me._List_Stagaire.Remove(Search(Stagaires))
    End Sub

    'creation de la liste des utilisateurs dans une entreprise
    Private _List_User As New List(Of User)
    ReadOnly Property List_User() As List(Of User)
        Get
            Return _List_User
        End Get
    End Property
    'ajouter un utilisateur dans la liste des employes qui sont dans l'entreprise
    Public Sub AddUser(ByVal User As User)
        If User IsNot Nothing Then
            If Search(User) Is Nothing Then
                If User.Entreprises IsNot Nothing Then
                    User.Entreprises.Remove(User)
                End If
            End If
            User.Entreprises = Me
            Me._List_User.Add(User)

        End If
    End Sub
    'rechercher un utilisateur dans la liste qui ce trouve dans 'entreprise
    Public Function Search(ByVal User As User) As User
        If Me._List_User IsNot Nothing Then
            For Each ol As User In Me._List_User
                If ol.Iduser = User.Iduser Then
                    Return ol
                End If
            Next
        End If
        Return Nothing
    End Function
    'retire un utilisateur dans la liste qui ce trouve dans l'entreprise
    Public Sub Remove(ByVal User As User)
        Me._List_User.Remove(Search(User))
    End Sub
    Public Sub New(ByVal IdEntreprise As Integer, _
                   ByVal RaisonSociale As String, _
                   ByVal Adresse As String, _
                   ByVal Code_Postal As String, _
                   ByVal Ville As String, _
                   ByVal Telephone As Integer, _
                   ByVal Email As String, _
                   ByVal Site_Internet As String, _
                   ByVal Forme_Juridique As String, _
                   ByVal Capitale As String, _
                   ByVal NomEntreprises As String _
                   )
        Me.IdEntreprise = IdEntreprise
        Me.RaisonSociale = RaisonSociale
        Me.Adresse = Adresse
        Me.Code_Postal = Code_Postal
        Me.Ville = Ville
        Me.Telephone = Telephone
        Me.Email = Email
        Me.Site_Internet = Site_Internet
        Me.Forme_Juridique = Forme_Juridique
        Me.Capitale = Capitale
        Me.NomEntreprises = NomEntreprises

    End Sub
End Class
