Public Class FormUtilisateur

    Private Sub btn_creer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_creer.Click
        Try

            BLL.ManagerUser.Ajouter(txtIdUser.Text, txt_creer_login.Text, txt_creer_passe1.Text, txt_creer_passe2.Text, txt_creer_privilege.Text, 1, txtCompte.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class