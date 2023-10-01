Public Class Departements
    Private _IdDep As Integer
    Public Property IdDep() As Integer
        Get
            Return Me._IdDep
        End Get
        Set(ByVal value As Integer)
            Me._IdDep = value
        End Set
    End Property

    Private _NomDepartement As String
    Public Property NomDepartement() As String
        Get
            Return Me._NomDepartement
        End Get
        Set(ByVal value As String)
            Me._NomDepartement = value
        End Set
    End Property
    Private _NomManager As String
    Public Property NomManager() As String
        Get
            Return Me._NomManager
        End Get
        Set(ByVal value As String)
            Me._NomManager = value
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
                If Employes.Departements IsNot Nothing Then
                    Employes.Departements.Remove(Employes)
                End If
            End If
            Employes.Departements = Me
            Me._List_Employes.Add(Employes)

        End If
    End Sub
    'rechercher un employe dans la liste qui ce trouve dans 'entreprise
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
                If Stagaires.Departement IsNot Nothing Then
                    Stagaires.Departement.Remove(Stagaires)
                End If
            End If
            Stagaires.Departement = Me
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


    Public Sub New(ByVal IdDep As Integer, ByVal NomDepartement As String, ByVal NomManager As String)
        Me.IdDep = IdDep
        Me.NomDepartement = NomDepartement
        Me.NomManager = NomManager
    End Sub
End Class
