Public Class FrmActividadesSocio

    Private Sub TabelaTurmasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TabelaTurmasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub FrmActividadesSocio_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TabelaTurmasTableAdapter.FillBysocio(Me.DatabaseDataSet.TabelaTurmas, socio)
    End Sub

    Private Sub FrmActividadesSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.TabelaTurmas' table. You can move, or remove it, as needed.


    End Sub
End Class