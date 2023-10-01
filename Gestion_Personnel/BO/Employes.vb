Public Class Employes
    Private _Matricule As String
    Public Property Matricule() As String
        Get
            Return Me._Matricule
        End Get
        Set(ByVal value As String)
            Me._Matricule = value
        End Set
    End Property
    Private _Nom As String
    Public Property Nom() As String
        Get
            Return Me._Nom
        End Get
        Set(ByVal value As String)
            Me._Nom = value
        End Set
    End Property
    Private _Diplome As String
    Public Property Diplome() As String
        Get
            Return Me._Diplome
        End Get
        Set(ByVal value As String)
            Me._Diplome = value
        End Set
    End Property
    Private _DEF As String
    Public Property DEF() As String
        Get
            Return Me._DEF
        End Get
        Set(ByVal value As String)
            Me._DEF = value
        End Set
    End Property
    Private _Prenom As String
    Public Property Prenom() As String
        Get
            Return Me._Prenom
        End Get
        Set(ByVal value As String)
            Me._Prenom = value
        End Set
    End Property
    Private _localisation As String
    Public Property localisation() As String
        Get
            Return Me._localisation
        End Get
        Set(ByVal value As String)
            Me._localisation = value
        End Set
    End Property
    Private _Date_Naiss As Date
    Public Property Date_Naiss() As Date
        Get
            Return Me._Date_Naiss
        End Get
        Set(ByVal value As Date)
            Me._Date_Naiss = value
        End Set
    End Property
    Private _Date_Entree As Date
    Public Property Date_Entree() As Date
        Get
            Return Me._Date_Entree
        End Get
        Set(ByVal value As Date)
            Me._Date_Entree = value
        End Set
    End Property
    Private _Salaire_Mensuel As Double
    Public Property Salaire_Mensuel() As Double
        Get
            Return Me._Salaire_Mensuel
        End Get
        Set(ByVal value As Double)
            Me._Salaire_Mensuel = value
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
    
    Private _Poste As String
    Public Property Poste() As String
        Get
            Return Me._Poste
        End Get
        Set(ByVal value As String)
            Me._Poste = value
        End Set
    End Property
    Private _photo As String
    Public Property photo() As String
        Get
            Return Me._photo
        End Get
        Set(ByVal value As String)
            Me._photo = value
        End Set
    End Property
    Private _sex As String
    Public Property sex() As String
        Get
            Return Me._sex
        End Get
        Set(ByVal value As String)
            Me._sex = value
        End Set
    End Property
    Private _nationalite As String
    Public Property nationalite() As String
        Get
            Return Me._nationalite
        End Get
        Set(ByVal value As String)
            Me._nationalite = value
        End Set
    End Property
    Private _Sit_Familial As String
    Public Property Sit_Familial() As String
        Get
            Return Me._Sit_Familial
        End Get
        Set(ByVal value As String)
            Me._Sit_Familial = value
        End Set
    End Property
    Private _BP As Decimal
    Public Property BP() As Decimal
        Get
            Return Me._BP
        End Get
        Set(ByVal value As Decimal)
            Me._BP = value
        End Set
    End Property
    Private _PermisConduire As String
    Public Property PermisConduire() As String
        Get
            Return Me._PermisConduire
        End Get
        Set(ByVal value As String)
            Me._PermisConduire = value
        End Set
    End Property
    Private _commentaire As String
    Public Property commentaire() As String
        Get
            Return Me._commentaire
        End Get
        Set(ByVal value As String)
            Me._commentaire = value
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
    '------------------------------------------------Departements-----------------------------
    Private _Departements As Departements
    Public Property Departements() As Departements
        Get
            Return Me._Departements
        End Get
        Set(ByVal value As Departements)
            Me._Departements = value
            NomDepartement = value.NomDepartement
        End Set
    End Property
    Private _Departement As String
    Property NomDepartement() As String
        Get
            Return Me._Departements.NomDepartement
        End Get
        Set(ByVal value As String)
            Me._Departement = value
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
    '------------------------------------------------Departements-----------------------------
    Private _Departemente As Departements
    Public Property Departemente() As Departements
        Get
            Return Me._Departemente
        End Get
        Set(ByVal value As Departements)
            Me._Departemente = value
            IdDepartementes = value.IdDep
        End Set
    End Property
    Private _Departementes As Integer
    Property IdDepartementes() As Integer
        Get
            Return Me._Departements.IdDep
        End Get
        Set(ByVal value As Integer)
            Me._Departementes = value
        End Set
    End Property
    '---------------------------------------------------------------------------------------------------------------------
    Private _Entrep As Entreprises
    Public Property Entrep() As Entreprises
        Get
            Return Me._Entrep
        End Get
        Set(ByVal value As Entreprises)
            Me._Entrep = value
            IdEntreprises = value.IdEntreprise
        End Set
    End Property
    Private _Entreps As Integer
    Property IdEntreprises() As Integer
        Get
            Return Me._Entreprises.IdEntreprise
        End Get
        Set(ByVal value As Integer)
            Me._Entreps = value
        End Set
    End Property
    '---------------------------------------------------------------------------------------------------------------------
    'creation de la liste des conger_employes dans la table employes
    Private _List_conger_employes As New List(Of Conger_Employes)
    ReadOnly Property List_conger_employes() As List(Of Conger_Employes)
        Get
            Return _List_conger_employes
        End Get
    End Property

    'ajouter un conger_employes dans la liste des conger_employes qui sont dans la table employes
    Public Sub Addconger_employes(ByVal conger_employes As Conger_Employes)
        If conger_employes IsNot Nothing Then
            If Search(conger_employes) Is Nothing Then
                If conger_employes.Employes IsNot Nothing Then
                    conger_employes.Employes.Remove(conger_employes)
                End If
            End If
            conger_employes.Employes = Me
            Me._List_conger_employes.Add(conger_employes)

        End If
    End Sub

    'rechercher un conger_employes dans la liste qui ce trouve dans la table employes
    Public Function Search(ByVal conger_employes As Conger_Employes) As Conger_Employes
        If Me._List_conger_employes IsNot Nothing Then
            For Each ol As Conger_Employes In Me._List_conger_employes
                If ol.Date_Debut = conger_employes.Date_Debut Then
                    Return ol
                End If
            Next
        End If
        Return Nothing
    End Function
    'retire un conger_employes dans la liste qui ce trouve dans la table employes
    Public Sub Remove(ByVal conger_employes As Conger_Employes)
        Me._List_conger_employes.Remove(Search(conger_employes))
    End Sub
    Public Sub New(ByVal Matricule As String, _
                                     ByVal Nom As String, _
                                     ByVal Prenom As String, _
                                     ByVal localisation As String, _
                                     ByVal Date_Naiss As Date, _
                                     ByVal Date_Entree As Date, _
                                     ByVal Salaire_Mensuel As Double, _
                                     ByVal Adresse As String, _
                                     ByVal Poste As String, _
                                     ByVal photo As String, _
                                     ByVal sex As String, _
                                     ByVal nationalite As String, _
                                     ByVal Sit_Familial As String, _
                                     ByVal BP As Decimal, _
                                     ByVal PermisConduire As String, _
                                     ByVal commentaire As String, _
                                     ByVal Email As String, _
                                     ByVal Diplome As String, _
                                     ByVal DEF As String _
                                     )
        Me.Matricule = Matricule
        Me.Nom = Nom
        Me.Prenom = Prenom
        Me.localisation = localisation
        Me.Date_Naiss = Date_Naiss
        Me.Date_Entree = Date_Entree
        Me.Salaire_Mensuel = Salaire_Mensuel
        Me.Adresse = Adresse
        Me.Poste = Poste
        Me.photo = photo
        Me.sex = sex
        Me.nationalite = nationalite
        Me.Sit_Familial = Sit_Familial
        Me.BP = BP
        Me.PermisConduire = PermisConduire
        Me.commentaire = commentaire
        Me.Email = Email
        Me.Diplome = Diplome
        Me.DEF = DEF
    End Sub
End Class
