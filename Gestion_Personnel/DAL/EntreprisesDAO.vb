Imports BO
Public Class EntreprisesDAO
    Private Shared _ListeEntreprises As New List(Of Entreprises)
    Shared ReadOnly Property ListeEntreprises() As List(Of Entreprises)
        Get
            Return _ListeEntreprises
        End Get
    End Property
    Shared Function GetEntreprises(ByVal Entreprises As Entreprises) As List(Of Entreprises)
        Try
            _ListeEntreprises.Clear()
            If Entreprises IsNot Nothing Then
                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                Dim Liste As New List(Of SqlParameter)
                With Liste
                    .Add(New SqlParameter("@IdEntreprise", SqlDbType.VarChar, Entreprises.IdEntreprise))
                    .Add(New SqlParameter("@RaisonSociale", SqlDbType.VarChar, Entreprises.RaisonSociale))
                    .Add(New SqlParameter("@Adresse", SqlDbType.VarChar, Entreprises.Adresse))
                    .Add(New SqlParameter("@Code_Postal", SqlDbType.VarChar, Entreprises.Code_Postal))
                    .Add(New SqlParameter("@Ville", SqlDbType.VarChar, Entreprises.Ville))
                    .Add(New SqlParameter("@Telephone", SqlDbType.VarChar, IIf(Entreprises.Telephone = Nothing, "", Entreprises.Telephone)))
                    .Add(New SqlParameter("@Email", SqlDbType.VarChar, Entreprises.Email))
                    .Add(New SqlParameter("@Site_Internet", SqlDbType.VarChar, Entreprises.Site_Internet))
                    .Add(New SqlParameter("@Forme_Juridique", SqlDbType.VarChar, Entreprises.Forme_Juridique))
                    .Add(New SqlParameter("@Capitale", SqlDbType.VarChar, Entreprises.Capitale))
                    .Add(New SqlParameter("@NomEntreprises", SqlDbType.VarChar, Entreprises.NomEntreprises))
                End With
                Dim Reader = SQL.GetReader("PS_Select_Entreprises", Liste)
                While Reader.Read
                    Dim NewEntreprises As New BO.Entreprises(Reader("IdEntreprise").ToString, _
                                                    Reader("RaisonSociale").ToString, _
                                                    Reader("Adresse").ToString, _
                                                    Reader("Code_Postal").ToString, _
                                                    Reader("Ville").ToString, _
                                                    Reader("Telephone").ToString, _
                                                    Reader("Email").ToString, _
                                                    Reader("Site_Internet").ToString, _
                                                    Reader("Forme_Juridique").ToString, _
                                                    Reader("Capitale").ToString, _
                                                    Reader("NomEntreprises").ToString)
                    _ListeEntreprises.Add(NewEntreprises)
                End While

            Else
                Throw New Exception("Entreprises vide!")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return ListeEntreprises
    End Function
    Shared Function Rechercher(ByVal Entreprises As Entreprises) As List(Of Entreprises)

        Try
            If Entreprises IsNot Nothing Then
                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                Dim Liste As New List(Of SqlParameter)
                With Liste
                    .Add(New SqlParameter("@IdEntreprise", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@RaisonSociale", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Adresse", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Code_Postal", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Ville", SqlDbType.VarChar, Entreprises.Ville))
                    .Add(New SqlParameter("@Telephone", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Email", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Site_Internet", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Forme_Juridique", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@Capitale", SqlDbType.VarChar, ""))
                    .Add(New SqlParameter("@NomEntreprises", SqlDbType.VarChar, ""))
                End With
                Dim Reader = SQL.GetReader("PS_Select_Entreprises", Liste)
                While Reader.Read
                    Dim NewEntreprises As New BO.Entreprises(Reader("IdEntreprise").ToString, _
                                                    Reader("RaisonSociale").ToString, _
                                                    Reader("Adresse").ToString, _
                                                    Reader("Code_Postal").ToString, _
                                                    Reader("Ville").ToString, _
                                                    Reader("Telephone").ToString, _
                                                    Reader("Email").ToString, _
                                                    Reader("Site_Internet").ToString, _
                                                    Reader("Forme_Juridique").ToString, _
                                                    Reader("Capitale").ToString, _
                                                    Reader("NomEntreprises").ToString)
                    'NewEntreprises.Entreprises = DAL.EntreprisesDAO.GetEntreprises(New Entreprises(Reader("IdEntreprise").ToString, "", "", "", "", Nothing, "", "", "", "", "")).First
                    Dim ob As Entreprises = Exists(NewEntreprises)
                    If ob IsNot Nothing Then
                        With ob
                            .IdEntreprise = NewEntreprises.IdEntreprise
                            .NomEntreprises = NewEntreprises.NomEntreprises
                            .Adresse = NewEntreprises.Adresse
                            .Capitale = NewEntreprises.Capitale
                            .Code_Postal = NewEntreprises.Code_Postal
                            .Email = NewEntreprises.Email
                            .Ville = NewEntreprises.Ville
                            .Telephone = NewEntreprises.Telephone
                            .Site_Internet = NewEntreprises.Site_Internet
                            .Forme_Juridique = NewEntreprises.Forme_Juridique
                            .RaisonSociale = NewEntreprises.RaisonSociale
                        End With
                    Else
                        _ListeEntreprises.Add(NewEntreprises)
                    End If
                End While
            Else
                Throw New Exception("Entreprises vide!")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return _ListeEntreprises
    End Function
    Public Shared Function Exists(ByVal Entreprises As Entreprises) As Entreprises
        If Entreprises IsNot Nothing And _ListeEntreprises IsNot Nothing Then
            For Each elt As Entreprises In _ListeEntreprises
                If elt.IdEntreprise = Entreprises.IdEntreprise Then
                    Return elt
                End If
            Next
        End If
        Return Nothing
    End Function
End Class
