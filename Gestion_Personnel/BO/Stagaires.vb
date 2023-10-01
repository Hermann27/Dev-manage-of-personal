Public Class Stagaires
    Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return Me._Id
        End Get
        Set(ByVal value As Integer)
            Me._Id = value
        End Set
    End Property
    Private _NomStagaire As String
    Public Property NomStagaire() As String
        Get
            Return Me._NomStagaire
        End Get
        Set(ByVal value As String)
            Me._NomStagaire = value
        End Set
    End Property
    Private _PrenomStagaire As String
    Public Property PrenomStagaire() As String
        Get
            Return Me._PrenomStagaire
        End Get
        Set(ByVal value As String)
            Me._PrenomStagaire = value
        End Set
    End Property
    Private _FonctionStagaire As String
    Public Property FonctionStagaire() As String
        Get
            Return Me._FonctionStagaire
        End Get
        Set(ByVal value As String)
            Me._FonctionStagaire = value
        End Set
    End Property
    Private _Date_Debut_Stage As Date
    Public Property Date_Debut_Stage() As Date
        Get
            Return Me._Date_Debut_Stage
        End Get
        Set(ByVal value As Date)
            Me._Date_Debut_Stage = value

        End Set
    End Property
    Private _Date_Fin_Stage As Date
    Public Property Date_Fin_Stage() As Date
        Get
            Return Me._Date_Fin_Stage
        End Get
        Set(ByVal value As Date)
            Me._Date_Fin_Stage = value
        End Set
    End Property
    Private _MatriculeStagaire As String
    Public Property MatriculeStagaire() As String
        Get
            Return Me._MatriculeStagaire
        End Get
        Set(ByVal value As String)
            Me._MatriculeStagaire = value
        End Set
    End Property
    Private _EtablicementStagaire As String
    Public Property EtablicementStagaire() As String
        Get
            Return Me._EtablicementStagaire
        End Get
        Set(ByVal value As String)
            Me._EtablicementStagaire = value
        End Set
    End Property
    '------------------------------------------------Departements-----------------------------
    Private _Departement As Departements
    Public Property Departement() As Departements
        Get
            Return Me._Departement
        End Get
        Set(ByVal value As Departements)
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

    Private _Email As String
    Public Property Email() As String
        Get
            Return Me._Email
        End Get
        Set(ByVal value As String)
            Me._Email = value
        End Set
    End Property

    Private _Sex As String
    Public Property Sex() As String
        Get
            Return Me._Sex
        End Get
        Set(ByVal value As String)
            Me._Sex = value
        End Set
    End Property
    Private _TypeStage As String
    Public Property TypeStage() As String
        Get
            Return Me._TypeStage
        End Get
        Set(ByVal value As String)
            Me._TypeStage = value
        End Set
    End Property
    Public Sub New(ByVal Id As Integer, _
                   ByVal NomStagaire As String, _
                   ByVal PrenomStagaire As String, _
        ByVal FonctionStagaire As String, _
        ByVal Date_Debut_Stage As Date, _
        ByVal Date_Fin_Stage As Date, _
        ByVal MatriculeStagaire As String, _
        ByVal EtablicementStagaire As String, _
        ByVal photo As String, _
        ByVal Email As String, _
        ByVal Sex As String, _
        ByVal TypeStage As String)
        Me.Id = Id
        Me.NomStagaire = NomStagaire
        Me.PrenomStagaire = PrenomStagaire
        Me.FonctionStagaire = FonctionStagaire
        Me.Date_Debut_Stage = Date_Debut_Stage
        Me.Date_Fin_Stage = Date_Fin_Stage
        Me.MatriculeStagaire = MatriculeStagaire
        Me.EtablicementStagaire = EtablicementStagaire
        Me.photo = photo
        Me.Email = Email
        Me.Sex = Sex
        Me.TypeStage = TypeStage
    End Sub
End Class
