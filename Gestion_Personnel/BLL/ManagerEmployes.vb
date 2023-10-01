Imports BO
Imports DAL
Public Class ManagerEmployes
    Shared ReadOnly Property ListeEmployes() As List(Of Employes)
        Get
            Return EmployesDAO.ListeEmployes
        End Get
    End Property

    Public Shared Sub Ajouter(ByVal Matricule As String, _
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
                              ByVal BP As String, _
                              ByVal PermisConduire As Char, _
                              ByVal commentaire As String, _
                              ByVal Email As String, _
                              ByVal IdEntreprises As Integer, _
                              ByVal IdDepartements As Integer, _
                              ByVal Diplome As String, _
                              ByVal DEF As String _
                              )

        Try
            Dim Employes As New BO.Employes(Matricule, _
                                            Nom, _
                                            Prenom, _
                                            localisation, _
                                            CType(Date_Naiss, Date), _
                                            CType(Date_Entree, Date), _
                                            Salaire_Mensuel, _
                                            Adresse, _
                                            Poste, _
                                            photo, _
                                            sex, _
                                            nationalite, _
                                            Sit_Familial, _
                                            BP, _
                                            PermisConduire, _
                                            commentaire, _
                                            Email, _
                                            Diplome, _
                                            DEF _
                                            )
            Employes.Entreprises = DAL.EntreprisesDAO.GetEntreprises(New BO.Entreprises(IdEntreprises, "", "", "", "", Nothing, "", "", "", "", "")).First
            Employes.Departements = DAL.DepartementsDAO.GetDepartements(New BO.Departements(IdDepartements, "", "")).First
            EmployesDAO.Ajouter(Employes)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub ModifierBLL(ByVal NewEmployes As Employes, ByVal Employes As Employes, ByVal IdEntreprises As Integer, ByVal IdDepartements As Integer)

        Try
            Employes.Entreprises = DAL.EntreprisesDAO.GetEntreprises(New BO.Entreprises(IdEntreprises, "", "", "", "", Nothing, "", "", "", "", "")).First
            Employes.Departements = DAL.DepartementsDAO.GetDepartements(New BO.Departements(IdDepartements, "", "")).First
            EmployesDAO.Modifier(NewEmployes, Employes)
            MsgBox("Modification Effectuer Avec Sucess.....", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Shared Sub Supprimer(ByVal Employes As Employes)

        Try
            EmployesDAO.Suppression(Employes)
            MsgBox("Suppression Effectuer Avec Sucess.....", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Shared Function Rechercher(ByVal Employes As Employes) As List(Of BO.Employes)
        Try
            'Employes.Addconger_employes(Employes.Conger_Employes)
            Return EmployesDAO.Rechercher(Employes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function
End Class
