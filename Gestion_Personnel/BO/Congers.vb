Public Class Congers
    Private _IdConger As Integer

    Public Property IdConger() As Integer
        Get
            Return Me._IdConger
        End Get
        Set(ByVal value As Integer)
            Me._IdConger = value
        End Set
    End Property
    Private _Matricule As String
    Public Property Matricule() As String
        Get
            Return Me._Matricule
        End Get
        Set(ByVal value As String)
            Me._Matricule = value
        End Set
    End Property
    
    Private _Typeconger As String
    Public Property Typeconger() As String
        Get
            Return Me._Typeconger
        End Get
        Set(ByVal value As String)
            Me._Typeconger = value
        End Set
    End Property
    Private _montant As Double
    Public Property montant() As Double
        Get
            Return Me._montant
        End Get
        Set(ByVal value As Double)
            Me._montant = value
        End Set
    End Property
    'creation de la liste des conger_employes dans un conger
    Private _List_conger_employes As New List(Of Conger_Employes)
    ReadOnly Property List_conger_employes() As List(Of Conger_Employes)
        Get
            Return _List_conger_employes
        End Get
    End Property
    'ajouter un conger_employes dans la liste des conger_employes qui sont dans un conger
    Public Sub Addconger_employes(ByVal conger_employes As Conger_Employes)
        If conger_employes IsNot Nothing Then
            If Search(conger_employes) Is Nothing Then
                If conger_employes.Conger IsNot Nothing Then
                    conger_employes.Conger.Remove(conger_employes)
                End If
            End If
            conger_employes.Conger = Me
            Me._List_conger_employes.Add(conger_employes)

        End If
    End Sub
    'rechercher un conger_employes dans la liste qui ce trouve dans un conger
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
    'retire un conger_employes dans la liste qui ce trouve dans un conger
    Public Sub Remove(ByVal conger_employes As Conger_Employes)
        Me._List_conger_employes.Remove(Search(conger_employes))
    End Sub
    Public Sub New(ByVal IdConger As Integer, ByVal Matricule As String, ByVal Typeconger As String, ByVal montant As Double)
        Me.IdConger = IdConger
        Me.Matricule = Matricule
        Me.Typeconger = Typeconger
        Me.montant = montant
    End Sub


End Class
