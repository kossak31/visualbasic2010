Public Class FrmTodosSocios

    Private Sub TabelaSociosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TabelaSociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub FrmTodosSocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.TabelaSocios' table. You can move, or remove it, as needed.
        Me.TabelaSociosTableAdapter.Fill(Me.DatabaseDataSet.TabelaSocios)

    End Sub
End Class