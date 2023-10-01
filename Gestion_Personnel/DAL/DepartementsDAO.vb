Imports BO
Public Class DepartementsDAO
    Private Shared _ListeDepartements As New List(Of Departements)
    Shared ReadOnly Property ListeDepartements() As List(Of Departements)
        Get
            Return _ListeDepartements
        End Get
    End Property
    Shared Function GetDepartements(ByVal Departements As Departements) As List(Of Departements)
        Try
            _ListeDepartements.Clear()
            If Departements IsNot Nothing Then
                Dim SQL As New SQL("DJOUMDJEU-PC\SERVER2008", "sa", "@IUC-PA2", "Gestion_Du_Personnel") ', "SERVER2008")
                Dim Liste As New List(Of SqlParameter)
                With Liste
                    .Add(New SqlParameter("@IdDep", SqlDbType.Int, Departements.IdDep))
                    .Add(New SqlParameter("@NomDepartement", SqlDbType.VarChar, Departements.NomDepartement))
                    .Add(New SqlParameter("@NomManager", SqlDbType.VarChar, Departements.NomManager))

                End With
                Dim Reader = SQL.GetReader("PS_Select_Depart", Liste)
                While Reader.Read
                    Dim NewDepartements As New BO.Departements(Reader("IdDep").ToString, _
                                                    Reader("NomDepartement").ToString, _
                                                    Reader("NomManager").ToString)
                    _ListeDepartements.Add(NewDepartements)
                End While

            Else
                Throw New Exception("Departements vide!")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return ListeDepartements
    End Function

End Class
