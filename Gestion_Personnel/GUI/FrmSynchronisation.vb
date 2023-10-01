Imports System.IO
Public Class FrmSynchronisation
    Dim OldEmployes As BO.Employes = Nothing
    Private Sub txt_bp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_bp.LostFocus
        If txt_bp.Text = "" Then
            Label30.Text = "Error"
        Else
            Label30.Text = "Valide"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture.Click
        'FrmWebcam.Show()
    End Sub
    Dim lits As List(Of BO.Employes) = Nothing
    Private Sub lst_employers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_employers.SelectedIndexChanged
        If lst_employers.DataSource IsNot Nothing Then

            olMat = lst_employers.SelectedItem.Matricule
            OldEmployes = lst_employers.SelectedItem

            txt_nom.Text = lst_employers.SelectedItem.Nom
            lstpermis.Text = lst_employers.SelectedItem.PermisConduire
            txt_commentaire.Text = lst_employers.SelectedItem.commentaire
            txt_email.Text = lst_employers.SelectedItem.Email
            ImgProFil.ImageLocation = lst_employers.SelectedItem.photo
            date_naissance.Value = lst_employers.SelectedItem.Date_Naiss
            txtSalaire.Text = lst_employers.SelectedItem.Salaire_Mensuel
            txt_adresse.Text = lst_employers.SelectedItem.Adresse
            txt_matricule.Text = lst_employers.SelectedItem.Matricule
            txtposte.Text = lst_employers.SelectedItem.Poste
            txtDEF.Text = lst_employers.SelectedItem.DEF
            txtDiplome.Text = lst_employers.SelectedItem.Diplome
            lst_sexe.SelectedItem = lst_employers.SelectedItem.sex
            lst_sitFamiliale.SelectedItem = lst_employers.SelectedItem.Sit_Familial
            txt_bp.Text = lst_employers.SelectedItem.BP
            DateEntre.Value = lst_employers.SelectedItem.Date_Entree
            txt_Prenom.Text = lst_employers.SelectedItem.Prenom
            CbNational.SelectedItem = lst_employers.SelectedItem.nationalite
            lst_ville.SelectedItem = lst_employers.SelectedItem.localisation
            img_portrait.ImageLocation = lst_employers.SelectedItem.photo
            txt_url_portrait.Text = lst_employers.SelectedItem.photo
            txt_Entreprises.Text = lst_employers.SelectedItem.IdEntreprises
            txt_Depart.Text = lst_employers.SelectedItem.IdDepartementes
        End If
    End Sub
    Dim olMat As String
    Dim NewMat As String = Nothing
    Private Sub btn_valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_valider.Click
        Dim lists As List(Of BO.Employes) = DAL.EmployesDAO.ALLRechercher(New BO.Employes("", "", "", "", Nothing, Nothing, Nothing, Nothing, "", "", "", "", "", Nothing, "", "", "", "", ""))
        NewMat = txt_matricule.Text
        If Me.Text = "Modifier" Then
            Try

                Dim Employes As New BO.Employes(txt_matricule.Text, _
                                            txt_nom.Text, _
                                            txt_Prenom.Text, _
                                            lst_ville.SelectedItem, _
                                            CType(date_naissance.Value, Date), _
                                            CType(DateEntre.Value, Date), _
                                            txtSalaire.Text, _
                                            txt_adresse.Text, _
                                            txtposte.Text, _
                                            txt_url_portrait.Text, _
                                            lst_sexe.SelectedItem, _
                                            CbNational.SelectedItem, _
                                            lst_sitFamiliale.SelectedItem, _
                                            txt_bp.Text, _
                                            lstpermis.SelectedItem, _
                                            txt_commentaire.Text, _
                                            txt_email.Text, _
                                            txtDiplome.Text, _
                                            txtDEF.Text _
                                            )
                BLL.ManagerEmployes.ModifierBLL(OldEmployes, Employes, txt_Entreprises.Text, txt_Depart.Text)
                With My.Forms.FrmPersonnel
                    .DGV.DataSource = Nothing
                    .FrmPersonnel_Load(sender, e)
                End With
                btn_vider_Click(sender, e)
                FrmSynchronisation_Load(sender, e)
            Catch ex As Exception
                'Throw New Exception(ex.Message)
                MsgBox("La Modificationn' a Pas  Effectuée veillez verifier les champ!", MsgBoxStyle.Information)
            End Try
        ElseIf Me.Text = "Supprimer" Then
            Dim Employes As New BO.Employes(txt_matricule.Text, txt_nom.Text, txt_Prenom.Text, lst_ville.SelectedItem, CType(date_naissance.Value, Date), CType(DateEntre.Value, Date), txtSalaire.Text, txt_adresse.Text, txtposte.Text, "Photo\" & IO.Path.GetFileName(OpenFileDialog1.FileName), lst_sexe.SelectedItem, CbNational.SelectedItem, lst_sitFamiliale.SelectedItem, txt_bp.Text, lstpermis.SelectedItem, txt_commentaire.Text, txt_email.Text, txtDiplome.Text, txtDEF.Text)
            BLL.ManagerEmployes.Supprimer(Employes)
            With My.Forms.FrmPersonnel
                .DGV.DataSource = Nothing
                .FrmPersonnel_Load(sender, e)
            End With
            btn_vider_Click(sender, e)
            FrmSynchronisation_Load(sender, e)
        Else
            Try

                BLL.ManagerEmployes.Ajouter(txt_matricule.Text, _
                                            txt_nom.Text, _
                                            txt_Prenom.Text, _
                                            lst_ville.SelectedItem, _
                                            CType(date_naissance.Value, Date), _
                                            CType(DateEntre.Value, Date), _
                                            txtSalaire.Text, _
                                            txt_adresse.Text, _
                                            txtposte.Text, _
                                            "Photo\" & IO.Path.GetFileName(OpenFileDialog1.FileName), _
                                            lst_sexe.SelectedItem, _
                                            CbNational.SelectedItem, _
                                            lst_sitFamiliale.SelectedItem, _
                                            txt_bp.Text, _
                                            lstpermis.SelectedItem, _
                                            txt_commentaire.Text, _
                                            txt_email.Text, _
                                            txt_Entreprises.Text, _
                                            txt_Depart.Text, _
                                            txtDiplome.Text, _
                                            txtDEF.Text _
                                            )
                With My.Forms.FrmPersonnel
                    .DGV.DataSource = Nothing
                    .FrmPersonnel_Load(sender, e)
                End With
                btn_vider_Click(sender, e)
            Catch ex As Exception
                MsgBox("Veillez bien Fournir vos Information SVP...!", MsgBoxStyle.Information, "Enregistrement")
                'Throw New Exception(ex.Message)
            End Try

        End If

    End Sub

    Private Sub btn_img_portrait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_img_portrait.Click
        Dim result As New DialogResult
        result = OpenFileDialog1.ShowDialog
        If result = Windows.Forms.DialogResult.Cancel Then
            MsgBox("veillez selectionner une image svp")
        Else

            txt_url_portrait.Text = "Photo\" & IO.Path.GetFileName(OpenFileDialog1.FileName)
            FileCopy(OpenFileDialog1.FileName, My.Application.Info.DirectoryPath & "\Photo\" & IO.Path.GetFileName(OpenFileDialog1.FileName))
            img_portrait.ImageLocation = txt_url_portrait.Text
            ImgProFil.ImageLocation = txt_url_portrait.Text
        End If
    End Sub

    Private Sub FrmSynchronisation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lists As List(Of BO.Employes) = DAL.EmployesDAO.ALLRechercher(New BO.Employes("", "", "", "", Nothing, Nothing, Nothing, Nothing, "", "", "", "", "", Nothing, "", "", "", "", ""))
        lits = DAL.EmployesDAO.ALLRechercher(New BO.Employes("", "", "", "", Nothing, Nothing, Nothing, Nothing, "", "", "", "", "", Nothing, "", "", "", "", ""))
        With lst_employers
            .DataSource = Nothing
            .DataSource = lists
            .DisplayMember = "Matricule"
        End With
        Initialiser()
    End Sub
    

    Private Sub btn_vider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vider.Click
        Initialiser()
    End Sub

    Sub Initialiser()
        txt_nom.Text = ""
        lstpermis.SelectedItem = ""
        txt_commentaire.Text = ""
        txt_email.Text = ""
        ImgProFil.ImageLocation = ""
        txtSalaire.Text = ""
        txt_adresse.Text = ""
        txt_matricule.Text = ""
        txtposte.Text = ""
        lst_sexe.SelectedItem = ""
        lst_sitFamiliale.SelectedItem = ""
        txt_bp.Text = ""
        txt_Prenom.Text = ""
        CbNational.SelectedItem = ""
        lst_ville.SelectedItem = ""
        img_portrait.ImageLocation = ""
        txt_url_portrait.Text = ""
        txt_Entreprises.Text = ""
        txt_Depart.Text = ""
        txtDEF.Text = ""
        txtDiplome.Text = ""
        lstpermis.Text = ""
    End Sub
End Class