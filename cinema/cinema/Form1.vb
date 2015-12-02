Public Class Form1

    Private Sub BilheteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BilheteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BilheteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdbilhetesbetaDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdbilhetesbetaDataSet.Bilhete' table. You can move, or remove it, as needed.
        Me.BilheteTableAdapter.Fill(Me.BdbilhetesbetaDataSet.Bilhete)

    End Sub
End Class