Imports BO
Imports DAL
Public Class ManagerUser

    Shared ReadOnly Property ListeUser() As List(Of User)
        Get

            Return UserDAO.ListeUser
        End Get
    End Property

    Public Shared Sub Ajouter(ByVal txtid As Integer, ByVal txtnom As String, ByVal txtmotpass As String, ByVal txtconfirme As String, ByVal txtprivile As String, ByVal txtentreprise As Integer, ByVal txtCompte As String)

        Try
            Dim user As New BO.User(txtid, txtnom, txtmotpass, txtconfirme, txtprivile, txtCompte, Nothing)
            user.Entreprises = DAL.EntreprisesDAO.GetEntreprises(New BO.Entreprises(txtentreprise, "", "", "", "", Nothing, "", "", "", "", "")).First
            UserDAO.Ajouter(user)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Public Shared Sub Supprimer(ByVal User As User)

    '    Try
    '        UserDAO.Suppression(User)
    '        MsgBox("Suppression Effectuer Avec Sucess.....", MsgBoxStyle.Information)
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    Public Shared Function Rechercher(ByVal User As User) As List(Of BO.User)
        Try
            Return UserDAO.Rechercher(User)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return Nothing
    End Function


    Public Shared Sub ModifierBLL(ByVal NewUser As User, ByVal User As User)

        Try
            UserDAO.Modifier(NewUser, User)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
