Imports DAL
Public Class FrmAuthentification
    Dim cpteur As Integer = 3
    Dim user As BO.User = Nothing
    
    Public Sub btn_connexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_connexion.Click

        If txt_passe.Text = "" And txt_user.Text = "" Then
            MsgBox("Veillez Renplir Tous Les Champ SVP", MsgBoxStyle.Information, "AUTHENTIFICATION")
        Else
            Try

                Dim list As List(Of BO.User) = DAL.UserDAO.RechercherCompte(New BO.User(Nothing, txt_user.Text, "", "", "", "", "11/02/2013"))
                If list.LongCount = 0 Then
                    MsgBox("Ce login n'existe pas !!!!!", MsgBoxStyle.Information, "Authentification")
                   
                Else

                    If list.First.Compte.Equals("bloquer") Then
                        txt_passe.Enabled = False
                        Variale = txt_user.Text
                        lblinfos.Text = "Compte bloquer le " & vbCrLf & list.First.Dates
                        Exit Sub
                    Else
                        txt_passe.Enabled = True
                    End If

                    If list.First.MotPass <> txt_passe.Text Then
                        cpteur = cpteur - 1
                        lblerror.Text = "Il vous reste :  " & cpteur & " Essaie"
                        If cpteur = 0 Then
                            lblerror.Text = "Compte Lock"
                            lblinfos.Text = "Veillez Consulter le " & vbCrLf & "Super Administrateur pour" & vbCrLf & " Debloquer Votre compte"
                            BLL.ManagerUser.ModifierBLL(New BO.User(Nothing, list.First.NomUser, list.First.MotPass, list.First.confirmer, list.First.Privilege, "bloquer", "11/02/2013"), list.First)
                            MsgBox("Mr " & list.First.NomUser & "   Votre compte est bloquer  " & vbCrLf & "Veillez-Contacté Le Super administrateur")
                            btn_connexion.Enabled = False
                            txt_passe.Enabled = False
                        End If
                    Else
                        If list.First.Privilege = "ADMINISTRATEUR" Then
                            With My.Forms.FrmPersonnel
                                .mwModifier.Enabled = False
                                .mwSupprimer.Enabled = False
                                .Show()
                            End With
                            Me.Close()
                        ElseIf list.First.Privilege = "SUPERADMINISTRATEUR" Then
                            With My.Forms.FrmPersonnel
                                .mwModifier.Enabled = True
                                .mwSupprimer.Enabled = True
                                .Show()
                            End With
                            Me.Close()
                        End If
                    End If


                    'txt_passe.Enabled = False
                    'MsgBox("Mr " & user.NomUser & vbCrLf & " Votre Compte A ete bloque " & vbCrLf & "pour Tentative de violation De votre mot de passe", MsgBoxStyle.Information, "VERIFICATION")
                    'MsgBox("AUCUN UTILISATEUR AUTRE QUE LE SUPER ADMINISTRATEUR" & vbCrLf & " ET L'ADMINISTRATEUR NA LE DROIT D'ACCES " & vbCrLf & "FONCTIONNALITE DU SYSTEME MERCI " & vbCrLf & "DE CONSULTE L'UN ENTRE LES DEUX SITE", MsgBoxStyle.Information, "VERIFICATION")
                End If


            Catch ex As Exception
                Throw New Exception(ex.Message)
                'MsgBox("Authentification error", MsgBoxStyle.Information, "VERIFICATION AUTHENTIFICATION")
            End Try
        End If
       


    End Sub

    
    Dim Variale As String
    Private Sub txt_user_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_user.TextChanged

        If txt_passe.Enabled = False Then

            If txt_user.Text.Trim <> Variale.Trim Then
                txt_passe.Enabled = True
                txt_user.Enabled = True
                lblinfos.Visible = False
            Else
                MsgBox(Variale)
                txt_passe.Enabled = False
                txt_user.Enabled = False
                lblinfos.Visible = True
            End If

        ElseIf txt_passe.Enabled = True And Variale <> "" Then
            If txt_user.Text.Trim <> Variale.Trim Then
                txt_passe.Enabled = True
                txt_user.Enabled = True
                lblinfos.Visible = False
            Else
                txt_passe.Enabled = False
                txt_user.Enabled = True
                lblinfos.Visible = True
            End If
        End If
    End Sub

    Private Sub BtnConnet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("jjjjj")
    End Sub
End Class