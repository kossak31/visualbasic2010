Public Class FrmContaCorrente

    Private Sub FrmContaCorrente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TabelaQuotasTableAdapter.FillByContaCorrente(Me.DatabaseDataSet.TabelaQuotas, socio)

    End Sub
End Class