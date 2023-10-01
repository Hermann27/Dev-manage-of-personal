Imports System.IO
Imports DAL
Imports BO
Public Class FrmPersonnel
   
    Public Sub FrmPersonnel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Interval = 1000
        Timer1.Start()
        With cboListePolices
            .Items.Add("arial")
            .Items.Add("Verdana")
            .Items.Add("algerion")
            .Items.Add("Courrier new")
        End With
        lst_Recher.Visible = False
        With lblmessage
            .Font = New Font(cboListePolices.Text, 36)
        End With
        With lblmessage
            .Font = New Font("Courrier new", lblmessage.Font.Size, FontStyle.Italic)
        End With
        chkDefilement_CheckedChanged(sender, e)
        trkvitesse.Enabled = False
        Dim AffEmployes As List(Of BO.Employes) = DAL.EmployesDAO.ALLRechercher(New BO.Employes("", "", "", "", Nothing, Nothing, Nothing, "", "", "", "", "", "", Nothing, "", "", "", "", ""))
        DGV.ForeColor = Color.DarkRed
        With lst_Recher
            .Text = Nothing
            .DataSource = AffEmployes
            .DisplayMember = "Matricule"
        End With
        lblCount.Text = AffEmployes.Count
        DGV.DataSource = AffEmployes
        DGV.DataSource = lst_Recher.DataSource
        cacher()
        
    End Sub

    Sub cacher()
        DGV.Columns("Departements").Visible = False
        DGV.Columns("Entreprises").Visible = False
        DGV.Columns("photo").Visible = False
        DGV.Columns("Departemente").Visible = False
        DGV.Columns("IdDepartementes").Visible = False
        DGV.Columns("Entrep").Visible = False
        DGV.Columns("IdEntreprises").Visible = False
        DGV.Columns("photo").Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblheure.Text = Now.ToLongTimeString

    End Sub
    Private Sub chkDefilement_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefilement.CheckedChanged
        Timer2.Enabled = chkDefilement.Checked
        Timer2.Interval = 30 - trkvitesse.Value
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If lblmessage.Left < panSupport.Width Then
            lblmessage.Left += 5
        Else
            lblmessage.Left = -lblmessage.Width
        End If
    End Sub

    Private Sub panSupport_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panSupport.Paint

    End Sub

    Private Sub new_membre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles new_membre.Click
        With My.Forms.FrmSynchronisation
            .Text = "Enregistrement"
            .lblE.Visible = False
            .lst_employers.Visible = False
            .Show()
        End With

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        With My.Forms.FrmAuthentification
            .txt_passe.Text = Nothing
            .txt_user.Text = Nothing
            '.btn_connexion_Click(sender, e)
            .Show()
        End With
        Me.Close()
    End Sub

    Private Sub DGV_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.RowCount + 1 > 1 Then
            ProfilImage.ImageLocation = DGV.CurrentRow.Cells("photo").Value
        End If
    End Sub

    Private Sub mod_employer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mod_employer.Click
        With My.Forms.FrmSynchronisation
            .Text = "Modifier"
            .btn_valider.Text = "Modifier"
            .lblFsynchro.Text = "Modifier un Employer"
            .lblE.Visible = False
            .Show()
        End With
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        With My.Forms.FrmSynchronisation
            .Text = "Supprimer"
            .btn_valider.Text = "Supprimer"
            .lblFsynchro.Text = "Supprimer un Employer"
            .btnCapture.Visible = False
            .Show()
        End With
    End Sub

    Private Sub InformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationToolStripMenuItem.Click
        Information.Show()
    End Sub

  
    Private Sub txtRechercher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRechercher.TextChanged
        Select Case CbRecher.SelectedItem
            Case "Matricule"

                If CbSpecifier.SelectedItem = "Employes" Then
                    Dim ListeEmployes As List(Of BO.Employes) = BLL.ManagerEmployes.Rechercher(New BO.Employes(txtRechercher.Text, "", "", "", Nothing, Nothing, Nothing, "", "", "", "", "", "", Nothing, "", "", "", "", ""))
                    For i As Integer = 0 To DGV.Rows.Count - 1
                        If ListeEmployes.Count > 0 Then

                            If DGV.Rows(i).Cells("Matricule").Value = ListeEmployes.First.Matricule Then
                                DGV.CurrentCell = DGV.Rows(DGV.Rows(i).Index).Cells(0)
                                DGV.Rows(i).Selected = True
                            End If
                        End If

                    Next
                End If

            Case "Nom"

                If CbSpecifier.SelectedItem = "Employes" Then
                    Dim ListeEmployes As List(Of BO.Employes) = BLL.ManagerEmployes.Rechercher(New BO.Employes("", txtRechercher.Text, "", "", Nothing, Nothing, Nothing, "", "", "", "", "", "", Nothing, "", "", "", "", ""))
                    For i As Integer = 0 To DGV.Rows.Count - 1
                        If ListeEmployes.Count > 0 Then
                            If DGV.Rows(i).Cells("Nom").Value = ListeEmployes.First.Nom Then
                                DGV.CurrentCell = DGV.Rows(DGV.Rows(i).Index).Cells(0)
                                DGV.Rows(i).Selected = True
                            End If
                        End If

                    Next
                End If

            Case "Identifiant"

        End Select
    End Sub

    Private Sub CbRecher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbRecher.SelectedIndexChanged
        If CbRecher.SelectedItem = "Matricule" Then
            CbSpecifier.Items.Clear()
            CbSpecifier.Items.Add("Employes")
        End If
    End Sub

    Private Sub new_conger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles new_conger.Click
        FrmCongers.Show()
    End Sub

    Private Sub mewEntreprises_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mewEntreprises.Click
        FrmEntreprises.Show()
    End Sub

    Private Sub UtilisateursToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilisateursToolStripMenuItem.Click
        FormUtilisateur.Show()
    End Sub

    Private Sub DepartementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartementsToolStripMenuItem.Click
        FormUtilisateur.Show()
    End Sub
End Class