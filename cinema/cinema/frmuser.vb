Public Class frmuser

    Private Sub UtilizadorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilizadorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UtilizadorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdbilhetesbetaDataSet)

    End Sub

    Private Sub frmuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdbilhetesbetaDataSet.Utilizador' table. You can move, or remove it, as needed.
        Me.UtilizadorTableAdapter.Fill(Me.BdbilhetesbetaDataSet.Utilizador)

    End Sub
End Class