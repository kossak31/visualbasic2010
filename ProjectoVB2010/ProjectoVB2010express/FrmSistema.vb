Public Class FrmSistema

    Private Sub TabelaTipoSociosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TabelaTipoSociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub FrmSistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TabelaModalidadesTableAdapter.Fill(Me.DatabaseDataSet.TabelaModalidades)
        Me.TabelaTipoSociosTableAdapter.Fill(Me.DatabaseDataSet.TabelaTipoSocios)

    End Sub

    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        Me.Validate()
        Me.TabelaTipoSociosBindingSource.EndEdit()
        Me.TabelaModalidadesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
        Me.Close()
    End Sub

    Private Sub bttSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSair.Click
        Me.Validate()
        Me.TabelaTipoSociosBindingSource.CancelEdit()
        Me.TabelaModalidadesBindingSource.CancelEdit()
        Me.TabelaModalidadesTableAdapter.Fill(Me.DatabaseDataSet.TabelaModalidades)
        Me.TabelaTipoSociosTableAdapter.Fill(Me.DatabaseDataSet.TabelaTipoSocios)
        Me.Close()
    End Sub
End Class