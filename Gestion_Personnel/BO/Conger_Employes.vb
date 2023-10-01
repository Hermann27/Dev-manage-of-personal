Public Class Conger_Employes
    Private _Date_Debut As Date
    Public Property Date_Debut() As Date
        Get
            Return Me._Date_Debut
        End Get
        Set(ByVal value As Date)
            Me._Date_Debut = value
        End Set
    End Property
    Private _Date_Fin As Date
    Public Property Date_Fin() As Date
        Get
            Return Me._Date_Fin
        End Get
        Set(ByVal value As Date)
            Me._Date_Fin = value
        End Set
    End Property
    '--------------------------------attribut congers-------------------------------
    Private _Conger As Congers
    Public Property Conger() As Congers
        Get
            Return Me._Conger
        End Get
        Set(ByVal value As Congers)
            Me._Conger = value
        End Set
    End Property
    '----------------------------------attribut employes---------------------------
    Private _Employes As Employes
    Public Property Employes() As Employes
        Get
            Return Me._Employes
        End Get
        Set(ByVal value As Employes)
            Me._Employes = value
        End Set
    End Property
    Private _Duree As String
    Public Property Duree() As String
        Get
            Return Me._Duree
        End Get
        Set(ByVal value As String)
            Me._Duree = value
        End Set
    End Property
    Public Sub New(ByVal Date_Debut As Date, ByVal Date_Fin As Date, ByVal Duree As String)
        Me.Date_Debut = Date_Debut
        Me.Date_Fin = Date_Fin
        Me.Duree = Duree
    End Sub

End Class
