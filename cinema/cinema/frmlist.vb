Public Class frmlist

    Private Sub BilheteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdbilhetesbetaDataSet1.Bilhete' table. You can move, or remove it, as needed.
        Me.BilheteTableAdapter1.Fill(Me.BdbilhetesbetaDataSet1.Bilhete)


    End Sub

    Private Sub BilheteBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BilheteBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BilheteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BilheteBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.BdbilhetesbetaDataSet1)

    End Sub
End Class