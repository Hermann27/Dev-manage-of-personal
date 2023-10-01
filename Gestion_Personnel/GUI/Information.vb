Imports System.IO
Public Class Information
    Public lien1 As String = Directory.GetCurrentDirectory & "\data\Textes\"
    Public lien2 As String = Directory.GetCurrentDirectory & "\data\Photos\"
    Dim test As Boolean = True
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Salut man ceci estun test", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rtextEntreprise.Text = "L' ENTREPRIESES VOUS INFORMER UNE NOUVELLE NISE EN OEUVRE A SUIVRE"
        rtConcepteur.Text = " Cette application a été conçue  " & vbCrLf & " et developpée par les étudiants" & vbCrLf & " de PAPI 2011 et permet la gestionoptimal " & vbCrLf & "du personnel (ajout,modification, suppréssion des données, rédacton des rapports,création des entreprise et bien dautre merci " & vbCrLf & "de la par de DJOUMDJEU POUGOUE HERMANN JUNIOR."
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        If test Then
            Try
                img.Image = Image.FromFile(lien2 & "entreprise.jpg")
                img.BackgroundImageLayout = ImageLayout.Stretch
            Catch ex As Exception

            End Try
            Try
                img2.Image = Image.FromFile(lien2 & "conception.jpg")
                img2.BackgroundImageLayout = ImageLayout.Stretch
            Catch ex As Exception

            End Try
            Try
                rtextEntreprise.Text = System.IO.File.ReadAllText(lien1 & "Informations.txt")
            Catch ex As Exception
            End Try
            Try
                rtConcepteur.Text = System.IO.File.ReadAllText(lien1 & "concection.txt")
            Catch ex As Exception

            End Try
        End If
        test = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Panel2.Visible = False
            Panel2.Enabled = False
            Panel3.Location = New Point(Panel3.Location.X, ligne1.Location.Y + 10)
        Else
            Panel2.Visible = True
            Panel2.Enabled = True
            Panel3.Location = New Point(Panel3.Location.X, Panel2.Location.Y + Panel2.Height + 10)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Panel5.Hide()
        Else
            Panel5.Show()
        End If
    End Sub
End Class