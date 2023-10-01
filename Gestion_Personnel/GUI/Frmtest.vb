Imports System.Data.SqlClient
Imports DAL
Public Class Frmtest

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim stagaire As New BO.Stagaires(1, "djoumdjeu", "hermann")
        'Dim stagaire2 As New BO.Stagaires(2, "djoumdjeu2", "hermann2")
        'stagaire2.Departement = New BO.Departements(1, "Mecanique", "Tcheudeu")
        'Dim Departement As BO.Departements = New BO.Departements(1, "Informatique", "Pougoue")
        'With Departement.List_Stagaires
        '    .Add(stagaire)
        '    .Add(stagaire2)
        'End With
        'ListBox1.Items.Add(Departement.NomDepartement & " a " & Departement.List_Stagaires.Count & " stagaires " & Departement.NomManager)

        'For Each elt As BO.Stagaires In Departement.List_Stagaires
        '    'MsgBox(Departement.NomDepartement & " a " & Departement.List_Stagaires.Count & " stagaires " & vbCrLf & elt.NomStagaire)
        '    ListBox1.Items.Add(elt.NomStagaire)
        'Next
        'MsgBox(stagaire.NomStagaire & "  " & " travaille dans le departement de : " & stagaire.Departement.NomDepartement & " a pour chef manager :" & stagaire.Departement.NomManager)
        'MsgBox(stagaire2.NomStagaire & "  " & " travaille dans le departement de : " & stagaire2.Departement.NomDepartement & " a pour chef manager :" & stagaire2.Departement.NomManager)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            'Dim User As New BO.User(txtid.Text, txtnom.Text, txtmotpass.Text, txtconfirme.Text, txtprivile.Text)
            BLL.ManagerUser.Ajouter(txtid.Text, txtnom.Text, txtmotpass.Text, txtconfirme.Text, txtprivile.Text, txtentreprise.Text, txtmotpass.Text)
            'DGV.Columns("Compte").Visible = False
            'DGV.DataSource = DAL.ClientsDAO.RechercherL
            'DGV.Refresh()
            Form1_Load(sender, e)
        Catch ex As Exception
            MsgBox("Veillez verifier votre Enregistrement SVP!!!", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim list As List(Of BO.User) = DAL.UserDAO.Rechercher(New BO.User(Nothing, "", "", "", "", "", "10/02/2013"))
        DGV.DataSource = list
        DGV.Columns("Entreprises").Visible = False
        For Each elt As BO.User In list

            ListBox1.Items.Add(elt)
        Next
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox(ListBox2.SelectedItem)
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        Dim listeUser As New List(Of BO.User)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Clear()
        ListBox2.Items.Add(ListBox1.SelectedItem.Entreprises.NomEntreprises)

    End Sub
End Class
