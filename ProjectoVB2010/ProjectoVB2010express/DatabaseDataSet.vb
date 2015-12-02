




Partial Public Class DatabaseDataSet
    Partial Class TabelaTurmasDataTable

        Private Sub TabelaTurmasDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.HoraInicioColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
