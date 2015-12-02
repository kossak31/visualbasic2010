Public Class FrmCoordenadores

    Private Sub FrmCoordenadores_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TabelaTurmasTableAdapter.Fill(Me.DatabaseDataSet.TabelaTurmas)
    End Sub
End Class