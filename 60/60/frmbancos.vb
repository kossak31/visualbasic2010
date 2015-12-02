Public Class frmbancos

    Private Sub BancosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BancosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BancosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDbancoDataSet)

    End Sub

    Private Sub frmbancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDbancoDataSet.bancos' table. You can move, or remove it, as needed.
        Me.BancosTableAdapter.Fill(Me.BDbancoDataSet.bancos)

    End Sub
End Class