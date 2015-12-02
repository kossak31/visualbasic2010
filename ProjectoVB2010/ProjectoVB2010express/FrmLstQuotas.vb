Public Class FrmLstQuotas

    Private Sub TabelaQuotasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TabelaQuotasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub FrmLstQuotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'DatabaseDataSet.TabelaQuotas' table. You can move, or remove it, as needed.
        Me.TabelaQuotasTableAdapter.Fill(Me.DatabaseDataSet.TabelaQuotas)

    End Sub
End Class