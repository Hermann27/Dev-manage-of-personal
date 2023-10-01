Imports BO

Public Class EmployesDAO
    Private Shared _ListeEmployes As New List(Of Employes)
    Shared ReadOnly Property ListeEmployes() As List(Of Employes)
        Get
            Return _ListeEmployes
        End Get
    End Property

    Shared Sub Ajouter(ByVal Employes As Employes)
        Try
            If Employes IsNot Nothing Then
                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                Dim Liste As New List(Of SqlParameter)
                With Liste
                    .Add(New SqlParameter("@Matricule", SqlDbType.VarChar, Employes.Matricule))
                    .Add(New SqlParameter("@Nom", SqlDbType.VarChar, Employes.Nom))
                    .Add(New SqlParameter("@Prenom", SqlDbType.VarChar, Employes.Prenom))
                    .Add(New SqlParameter("@localisation", SqlDbType.VarChar, Employes.localisation))
                    .Add(New SqlParameter("@Date_Naiss", SqlDbType.DateTime, Employes.Date_Naiss))

                    .Add(New SqlParameter("@Date_Entree", SqlDbType.DateTime, Employes.Date_Entree))
                    .Add(New SqlParameter("@Salaire_Mensuel", SqlDbType.Decimal, Employes.Salaire_Mensuel))
                    .Add(New SqlParameter("@Adresse", SqlDbType.VarChar, Employes.Adresse))
                    .Add(New SqlParameter("@IdDepartement", SqlDbType.Int, Employes.Departements.IdDep))
                    .Add(New SqlParameter("@Poste", SqlDbType.VarChar, Employes.Poste))
                    .Add(New SqlParameter("@photo", SqlDbType.VarChar, Employes.photo))
                    .Add(New SqlParameter("@IdEntreprise", SqlDbType.Int, Employes.Entreprises.IdEntreprise))

                    .Add(New SqlParameter("@sex", SqlDbType.VarChar, Employes.sex))
                    .Add(New SqlParameter("@nationalite", SqlDbType.VarChar, Employes.nationalite))
                    .Add(New SqlParameter("@Sit_Familial", SqlDbType.VarChar, Employes.Sit_Familial))
                    .Add(New SqlParameter("@BP", SqlDbType.Decimal, Employes.BP))
                    .Add(New SqlParameter("@PermisConduire", SqlDbType.Char, Employes.PermisConduire))
                    .Add(New SqlParameter("@commentaire", SqlDbType.VarChar, Employes.commentaire))
                    .Add(New SqlParameter("@Email", SqlDbType.VarChar, Employes.Email))
                    .Add(New SqlParameter("@Diplome", SqlDbType.VarChar, Employes.Diplome))
                    .Add(New SqlParameter("@DEF", SqlDbType.VarChar, Employes.DEF))

                End With
                SQL.SetCommand("PS_Insert_Employes", Liste)
                _ListeEmployes.Add(Employes)
                MsgBox("Enregistrement Effectuer avec sucess.......!", MsgBoxStyle.Information, "Nouveau_Personnel")
            Else
                Throw New Exception("Employes N' Existe pas!")
            End If
        Catch ex As Exception
            'Throw New Exception(ex.Message)
            MsgBox("Echec d'Enregistrement veillez verifier vos Informations ", MsgBoxStyle.Information, "Nouveau Employes")
        End Try
    End Sub


    Shared Function ALLRechercher(ByVal Employes As Employes) As List(Of Employes)

        Try
            '_ListeEmployes.Clear()
            If Employes IsNot Nothing Then
                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                'Dim SQL As New SQL("localhost", "sa", "@IUC-PA2", "Gestion_Du_Personnel", "SQLEXPRESS")
                Dim Liste As New List(Of SqlParameter)
                With Liste
                    .Add(New SqlParameter("@Matricule", SqlDbType.VarChar, Employes.Matricule))
                    .Add(New SqlParameter("@Nom", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Prenom", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@localisation", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Date_Naiss", SqlDbType.VarChar, ""))

                    .Add(New SqlParameter("@Date_Entree", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Salaire_Mensuel", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Adresse", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@IdDepartement", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Poste", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@photo", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@IdEntreprise", SqlDbType.VarChar, ""))

                    .Add(New SqlParameter("@sex", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@nationalite", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Sit_Familial", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@BP", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@PermisConduire", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@commentaire", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Email", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Diplome", SqlDbType.VarChar, Employes.Diplome))
                    .Add(New SqlParameter("@DEF", SqlDbType.VarChar, Employes.DEF))
                End With
                Dim Reader = SQL.GetReader("PS_Select_Employes", Liste)
                While Reader.Read
                    Dim NewEmployes As New BO.Employes(Reader("Matricule").ToString, _
                                                    Reader("Nom").ToString, _
                                                    Reader("Prenom").ToString, _
                                                    Reader("localisation").ToString, _
                                                    Reader("Date_Naiss").ToString, _
                                                    Reader("Date_Entree").ToString, _
                                                    Reader("Salaire_Mensuel").ToString, _
                                                    Reader("Adresse").ToString, _
                                                    Reader("Poste").ToString, _
                                                    Reader("photo").ToString, _
                                                    Reader("sex").ToString, _
                                                    Reader("nationalite").ToString, _
                                                    Reader("Sit_Familial").ToString, _
                                                    Reader("BP").ToString, _
                                                    Reader("PermisConduire").ToString, _
                                                    Reader("commentaire").ToString, _
                                                    Reader("Email").ToString, _
                                                    Reader("Diplome").ToString, _
                                                    Reader("DEF").ToString _
                                                    )
                    NewEmployes.Entreprises = DAL.EntreprisesDAO.GetEntreprises(New Entreprises(Reader("IdEntreprise").ToString, "", "", "", "", Nothing, "", "", "", "", "")).First
                    NewEmployes.Departements = DAL.DepartementsDAO.GetDepartements(New Departements(Reader("IdDepartement").ToString, "", "")).First
                    Dim ob As Employes = Exists(NewEmployes)
                    If ob IsNot Nothing Then
                        With ob
                            .Matricule = NewEmployes.Matricule
                            .Nom = NewEmployes.Nom
                            .Prenom = NewEmployes.Prenom
                            .Date_Entree = NewEmployes.Date_Entree
                            .Date_Naiss = NewEmployes.Date_Naiss
                            .Email = NewEmployes.Email
                            .localisation = NewEmployes.localisation
                            .Adresse = NewEmployes.Adresse
                            .Sit_Familial = NewEmployes.Sit_Familial
                            .BP = NewEmployes.BP
                            .Diplome = NewEmployes.Diplome
                            .DEF = NewEmployes.DEF
                            .commentaire = NewEmployes.commentaire
                            .PermisConduire = NewEmployes.PermisConduire
                            .Poste = NewEmployes.Poste
                            .photo = NewEmployes.photo
                        End With
                    Else
                        _ListeEmployes.Add(NewEmployes)
                    End If
                End While
            Else
                Throw New Exception("Employes vide!")
            End If
        Catch ex As Exception
            MsgBox("Rechercher Pas Effectuer verifie vos parametre de recherche svp", MsgBoxStyle.Information, "TouT LA Rechercher")
        End Try
        Return _ListeEmployes
    End Function

    Shared Function Rechercher(ByVal Employes As Employes) As List(Of Employes)
        Dim ListeRecher As New List(Of BO.Employes)
        Try


            If Employes IsNot Nothing Then
                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                Dim Liste As New List(Of SqlParameter)
                With Liste

                    .Add(New SqlParameter("@Matricule", SqlDbType.VarChar, Employes.Matricule))

                    .Add(New SqlParameter("@Nom", SqlDbType.VarChar, Employes.Nom))

                    .Add(New SqlParameter("@IdEntreprise", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Prenom", SqlDbType.VarChar, Employes.Prenom))
                    .Add(New SqlParameter("@localisation", SqlDbType.VarChar, Employes.localisation))
                    .Add(New SqlParameter("@Date_Naiss", SqlDbType.VarChar, ""))

                    .Add(New SqlParameter("@Date_Entree", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Salaire_Mensuel", SqlDbType.VarChar, IIf(Employes.Salaire_Mensuel = Nothing, "", Employes.Salaire_Mensuel)))
                    .Add(New SqlParameter("@Adresse", SqlDbType.VarChar, Employes.Adresse))
                    .Add(New SqlParameter("@IdDepartement", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Poste", SqlDbType.VarChar, Employes.Poste))
                    .Add(New SqlParameter("@photo", SqlDbType.VarChar, Employes.photo))


                    .Add(New SqlParameter("@sex", SqlDbType.VarChar, Employes.sex))
                    .Add(New SqlParameter("@nationalite", SqlDbType.VarChar, Employes.nationalite))
                    .Add(New SqlParameter("@Sit_Familial", SqlDbType.VarChar, Employes.Sit_Familial))
                    .Add(New SqlParameter("@BP", SqlDbType.VarChar, IIf(Employes.BP = Nothing, "", Employes.BP)))
                    .Add(New SqlParameter("@PermisConduire", SqlDbType.VarChar, Employes.PermisConduire))
                    .Add(New SqlParameter("@commentaire", SqlDbType.VarChar, Employes.commentaire))
                    .Add(New SqlParameter("@Email", SqlDbType.VarChar, Employes.Email))
                    .Add(New SqlParameter("@Diplome", SqlDbType.VarChar, Employes.Diplome))
                    .Add(New SqlParameter("@DEF", SqlDbType.VarChar, Employes.DEF))
                End With
                Dim Reader = SQL.GetReader("PS_Select_Employes", Liste)
                While Reader.Read
                    Dim NewEmployes As New BO.Employes(Reader("Matricule").ToString, _
                                                    Reader("Nom").ToString, _
                                                    Reader("Prenom").ToString, _
                                                    Reader("localisation").ToString, _
                                                    Reader("Date_Naiss").ToString, _
                                                    Reader("Date_Entree").ToString, _
                                                    Reader("Salaire_Mensuel").ToString, _
                                                    Reader("Adresse").ToString, _
                                                    Reader("Poste").ToString, _
                                                    Reader("photo").ToString, _
                                                    Reader("sex").ToString, _
                                                    Reader("nationalite").ToString, _
                                                    Reader("Sit_Familial").ToString, _
                                                    Reader("BP").ToString, _
                                                    Reader("PermisConduire").ToString, _
                                                    Reader("commentaire").ToString, _
                                                    Reader("Email").ToString, _
                                                    Reader("Diplome").ToString, _
                                                    Reader("DEF").ToString _
                                                    )
                    NewEmployes.Entreprises = DAL.EntreprisesDAO.GetEntreprises(New Entreprises(Reader("IdEntreprise").ToString, "", "", "", "", Nothing, "", "", "", "", "")).First
                    NewEmployes.Departements = DAL.DepartementsDAO.GetDepartements(New Departements(Reader("IdDepartement").ToString, "", "")).First
                    Dim ob As Employes = Exists(NewEmployes)
                    If ob IsNot Nothing Then
                        With ob
                            .Matricule = NewEmployes.Matricule
                            .Nom = NewEmployes.Nom
                            .Prenom = NewEmployes.Prenom
                            .Date_Entree = NewEmployes.Date_Entree
                            .Date_Naiss = NewEmployes.Date_Naiss
                            .Email = NewEmployes.Email
                            .localisation = NewEmployes.localisation
                            .Adresse = NewEmployes.Adresse
                            .Sit_Familial = NewEmployes.Sit_Familial
                            .BP = NewEmployes.BP
                            .Diplome = NewEmployes.Diplome
                            .DEF = NewEmployes.DEF
                            .commentaire = NewEmployes.commentaire
                            .PermisConduire = NewEmployes.PermisConduire
                            .Poste = NewEmployes.Poste
                            .photo = NewEmployes.photo
                        End With
                        ListeRecher.Add(ob)
                    Else
                        ListeRecher.Add(NewEmployes)

                    End If
                End While
            Else
                Throw New Exception("Employes vide!")
            End If
        Catch ex As Exception
            'Throw New Exception(ex.Message)
            MsgBox("Rechercher Pas Effectuer verifie vos parametre de recherche svp", MsgBoxStyle.Information, "Rechercher")
        End Try
        Return ListeRecher
    End Function

    Shared Sub Suppression(ByVal Employes As Employes)
        Try
            If Employes IsNot Nothing Then

                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                Dim Liste As New List(Of SqlParameter)
                With Liste
                    .Add(New SqlParameter("@Matricule", SqlDbType.VarChar, Employes.Matricule))
                End With

                SQL.SetCommand("PS_Delete_Employes", Liste)
                _ListeEmployes.Remove(Exists(Employes))
            Else
                Throw New Exception("Employes vide!")
            End If
        Catch ex As Exception
            MsgBox("La Suppression n'a pas été effectuer veillez verifier vos parametre SVP..", MsgBoxStyle.Information, "Suppression")
        End Try
    End Sub
    Shared Sub Modifier(ByVal OldEmployes As Employes, ByVal Employes As Employes)

        Try
            If OldEmployes IsNot Nothing And Employes IsNot Nothing Then

                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                Dim Liste As New List(Of SqlParameter)
                With Liste
                    .Add(New SqlParameter("@Matricule", SqlDbType.VarChar, Employes.Matricule))
                    .Add(New SqlParameter("@Nom", SqlDbType.VarChar, Employes.Nom))
                    .Add(New SqlParameter("@Prenom", SqlDbType.VarChar, Employes.Prenom))
                    .Add(New SqlParameter("@localisation", SqlDbType.VarChar, Employes.localisation))
                    .Add(New SqlParameter("@Date_Naiss", SqlDbType.DateTime, Employes.Date_Naiss))

                    .Add(New SqlParameter("@Date_Entree", SqlDbType.DateTime, Employes.Date_Entree))
                    .Add(New SqlParameter("@Salaire_Mensuel", SqlDbType.Decimal, Employes.Salaire_Mensuel))
                    .Add(New SqlParameter("@Adresse", SqlDbType.VarChar, Employes.Adresse))
                    .Add(New SqlParameter("@IdDepartement", SqlDbType.Int, Employes.Departements.IdDep))
                    .Add(New SqlParameter("@Poste", SqlDbType.VarChar, Employes.Poste))
                    .Add(New SqlParameter("@photo", SqlDbType.VarChar, Employes.photo))
                    .Add(New SqlParameter("@IdEntreprise", SqlDbType.Int, Employes.Entreprises.IdEntreprise))

                    .Add(New SqlParameter("@sex", SqlDbType.VarChar, Employes.sex))
                    .Add(New SqlParameter("@nationalite", SqlDbType.VarChar, Employes.nationalite))
                    .Add(New SqlParameter("@Sit_Familial", SqlDbType.VarChar, Employes.Sit_Familial))
                    .Add(New SqlParameter("@BP", SqlDbType.Decimal, Employes.BP))
                    .Add(New SqlParameter("@PermisConduire", SqlDbType.Char, Employes.PermisConduire))

                    .Add(New SqlParameter("@commentaire", SqlDbType.VarChar, Employes.commentaire))
                    .Add(New SqlParameter("@Email", SqlDbType.VarChar, Employes.Email))
                    .Add(New SqlParameter("@Diplome", SqlDbType.VarChar, Employes.Diplome))
                    .Add(New SqlParameter("@DEF", SqlDbType.VarChar, Employes.DEF))
                    .Add(New SqlParameter("@oldMatricule", SqlDbType.VarChar, OldEmployes.Matricule))

                End With
                SQL.SetCommand("PS_Update_Employes", Liste)
                Dim ob As Employes = Exists(OldEmployes)
                If ob IsNot Nothing Then
                    With ob
                        .Matricule = Employes.Matricule
                        .Nom = Employes.Nom
                        .Prenom = Employes.Prenom
                        .Date_Entree = Employes.Date_Entree
                        .Date_Naiss = Employes.Date_Naiss
                        .Email = Employes.Email
                        .localisation = Employes.localisation
                        .Adresse = Employes.Adresse
                        .Sit_Familial = Employes.Sit_Familial
                        .BP = Employes.BP
                        .Diplome = Employes.Diplome
                        .DEF = Employes.DEF
                        .commentaire = Employes.commentaire
                        .PermisConduire = Employes.PermisConduire
                        .Poste = Employes.Poste
                        .photo = Employes.photo
                    End With
                Else
                    _ListeEmployes.Add(Employes)
                End If
            Else
                Throw New Exception("Employes vide!")
            End If
        Catch ex As Exception
            MsgBox("Modification n'a pas été Effectuer ", MsgBoxStyle.Information, "Modification")
        End Try
    End Sub
    Public Shared Function Exists(ByVal Employes As Employes) As Employes
        If Employes IsNot Nothing And _ListeEmployes IsNot Nothing Then
            For Each elt As Employes In _ListeEmployes
                If elt.Matricule = Employes.Matricule Then
                    Return elt
                End If
            Next
        End If
        Return Nothing
    End Function
End Class
