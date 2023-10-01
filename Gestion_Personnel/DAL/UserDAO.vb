Imports BO
Public Class UserDAO
    Private Shared _ListeUser As New List(Of User)
    Shared ReadOnly Property ListeUser() As List(Of User)
        Get

            Return _ListeUser
            
        End Get
    End Property
    Shared Sub Ajouter(ByVal User As User)
        Try

            If User IsNot Nothing Then
                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                Dim Liste As New List(Of SqlParameter)
                With Liste
                    .Add(New SqlParameter("@Iduser", SqlDbType.Int, User.Iduser))
                    .Add(New SqlParameter("@NomUser", SqlDbType.VarChar, User.NomUser))
                    If User.MotPass <> User.confirmer Then

                    Else
                        .Add(New SqlParameter("@MotPass", SqlDbType.VarChar, User.MotPass))
                        .Add(New SqlParameter("@confirmer", SqlDbType.VarChar, User.confirmer))
                    End If
                    .Add(New SqlParameter("@Privilege", SqlDbType.VarChar, User.Privilege))
                    .Add(New SqlParameter("@IdEntreprise", SqlDbType.Int, User.Entreprises.IdEntreprise))
                    .Add(New SqlParameter("@Compte", SqlDbType.VarChar, User.Compte))
                End With
                SQL.SetCommand("PS_Insert_User", Liste)
                _ListeUser.Add(User)
                MsgBox("Utilisateur a été creer", MsgBoxStyle.Information, "Create_User")
            Else
                Throw New Exception("Utilisateur Existe pas!")
            End If
        Catch ex As Exception
            MsgBox("Mot de passe Incorret veillez La Confirme normalement !!!", MsgBoxStyle.Information)
        End Try
    End Sub

    Shared Function Rechercher(ByVal User As User) As List(Of User)

        Try
            If User IsNot Nothing Then
                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                Dim Liste As New List(Of SqlParameter)
                With Liste
                    .Add(New SqlParameter("@Iduser", SqlDbType.VarChar, User.Iduser))
                    .Add(New SqlParameter("@NomUser", SqlDbType.VarChar, User.NomUser))
                    .Add(New SqlParameter("@MotPass", SqlDbType.VarChar, User.MotPass))
                    .Add(New SqlParameter("@confirmer", SqlDbType.VarChar, User.confirmer))
                    .Add(New SqlParameter("@Privilege", SqlDbType.VarChar, User.Privilege))
                    .Add(New SqlParameter("@IdEntreprise", SqlDbType.VarChar, User.Entreprises.IdEntreprise))
                    .Add(New SqlParameter("@Compte", SqlDbType.VarChar, User.Compte))
                End With
                Dim Reader = SQL.GetReader("PS_Selete_User", Liste)
                While Reader.Read
                    Dim NewUser As New User(Reader("Iduser").ToString, _
                                            Reader("NomUser").ToString, _
                                            Reader("MotPass").ToString, _
                                            Reader("confirmer").ToString, _
                                            Reader("Privilege").ToString, _
                                            Reader("Compte").ToString, _
                                            Reader("Dates").ToString _
                                            )
                    NewUser.Entreprises = DAL.EntreprisesDAO.GetEntreprises(New Entreprises(Reader("IdEntreprise").ToString, "", "", "", "", Nothing, "", "", "", "", "")).First
                    Dim ob As User = Exists(NewUser)
                    If ob IsNot Nothing Then
                        With ob
                            .Iduser = NewUser.Iduser
                            .NomUser = NewUser.NomUser
                            .MotPass = NewUser.MotPass
                            .confirmer = NewUser.confirmer
                            .Privilege = NewUser.Privilege
                            .Compte = NewUser.Compte
                            .Entreprises.IdEntreprise = NewUser.Entreprises.IdEntreprise
                        End With
                    Else
                        _ListeUser.Add(NewUser)
                    End If
                End While
            Else
                Throw New Exception("Utilisateur vide!")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return _ListeUser
    End Function

    Shared Function RechercherCompte(ByVal User As User) As List(Of User)
        _ListeUser.Clear()
        Try
            If User IsNot Nothing Then
                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                Dim Liste As New List(Of SqlParameter)
                With Liste
                    .Add(New SqlParameter("@Iduser", SqlDbType.VarChar, IIf(User.Iduser = Nothing, "", User.Iduser)))
                    .Add(New SqlParameter("@NomUser", SqlDbType.VarChar, User.NomUser))
                    .Add(New SqlParameter("@MotPass", SqlDbType.VarChar, User.MotPass))
                    .Add(New SqlParameter("@confirmer", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Compte", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Privilege", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@IdEntreprise", SqlDbType.VarChar, ""))
                End With
                Dim Reader = SQL.GetReader("PS_Selete_User", Liste)
                While Reader.Read

                    Dim NewUser As New User(Reader("Iduser").ToString, _
                                                 Reader("NomUser").ToString, _
                                                 Reader("MotPass").ToString, _
                                                 Reader("confirmer").ToString, _
                                                 Reader("Privilege").ToString, _
                                                 Reader("Compte").ToString, _
                                                 Reader("Dates").ToString _
                                                 )

                    NewUser.Entreprises = DAL.EntreprisesDAO.GetEntreprises(New Entreprises(Reader("IdEntreprise").ToString, "", "", "", "", Nothing, "", "", "", "", "")).First
                    Dim ob As User = Exists(NewUser)
                    If ob IsNot Nothing Then
                        With ob
                            .Iduser = NewUser.Iduser
                            .NomUser = NewUser.NomUser
                            .MotPass = NewUser.MotPass
                            .confirmer = NewUser.confirmer
                            .Privilege = NewUser.Privilege
                            .Compte = NewUser.Compte
                            .Entreprises.IdEntreprise = NewUser.Entreprises.IdEntreprise
                        End With
                    Else
                        _ListeUser.Add(NewUser)
                    End If
                End While
            Else
                Throw New Exception("Utilisateur vide!")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return _ListeUser
    End Function

    Shared Sub Modifier(ByVal OldUser As User, ByVal User As User)

        Try
            If OldUser IsNot Nothing And User IsNot Nothing Then
                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                'Dim SQL As New SQL("localhost", "sa", "@IUC-PA2", "Gestion_Du_Personnel", "SQLEXPRESS")
                Dim Liste As New List(Of SqlParameter)
                With Liste
                    .Add(New SqlParameter("@NomUser", SqlDbType.VarChar, OldUser.NomUser))
                    .Add(New SqlParameter("@MotPass", SqlDbType.VarChar, User.MotPass))
                    .Add(New SqlParameter("@confirmer", SqlDbType.VarChar, User.confirmer))
                    .Add(New SqlParameter("@Privilege", SqlDbType.VarChar, User.Privilege))
                    .Add(New SqlParameter("@IdEntreprise", SqlDbType.Int, User.Entreprises.IdEntreprise))
                    .Add(New SqlParameter("@Compte", SqlDbType.VarChar, OldUser.Compte))
                    .Add(New SqlParameter("@olNomUser", SqlDbType.VarChar, User.NomUser))
                End With
                SQL.SetCommand("PS_Update_User", Liste)
                Dim ob As User = Exists(OldUser)
                If ob IsNot Nothing Then
                    With ob
                        .Iduser = OldUser.Iduser
                        .NomUser = OldUser.NomUser
                        .Privilege = OldUser.Privilege
                        .MotPass = OldUser.MotPass
                        .Compte = OldUser.Compte
                        .confirmer = OldUser.confirmer
                        .Entreprises.IdEntreprise = OldUser.Entreprises.IdEntreprise
                    End With
                Else
                    _ListeUser.Add(OldUser)
                End If
            Else
                Throw New Exception("User vide!")
            End If
        Catch ex As Exception
            'MsgBox("Modification n'a pas été Effectuer ", MsgBoxStyle.Information, "Modification")
        End Try
    End Sub
    Public Shared Function Exists(ByVal User As User) As User
        If User IsNot Nothing And _ListeUser IsNot Nothing Then
            For Each elt As User In _ListeUser
                If elt.NomUser = User.NomUser Then
                    Return elt
                End If
            Next
        End If
        Return Nothing
    End Function
End Class
