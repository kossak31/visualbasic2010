Public Class Form1

    Private Sub SuporteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuporteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SuporteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TipoSuporteTableAdapter.Fill(Me.BdDataSet.TipoSuporte)
        Me.TipoConteudoTableAdapter.Fill(Me.BdDataSet.TipoConteudo)
        Me.ConteudoTableAdapter.Fill(Me.BdDataSet.Conteudo)
        Me.SuporteTableAdapter.Fill(Me.BdDataSet.suporte)
    End Sub


    Private Sub TodosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodosToolStripMenuItem.Click
        Me.SuporteBindingSource.EndEdit()
        Me.SuporteTableAdapter.Fill(Me.BdDataSet.suporte)
    End Sub

    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        Me.SuporteBindingSource.EndEdit()
        Me.SuporteBindingSource.AddNew()
        DataEntradaDateTimePicker.Focus()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Me.Validate()
        Me.SuporteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdDataSet)
        Me.SuporteTableAdapter.Fill(BdDataSet.suporte)
    End Sub

    Private Sub MostrarListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarListaToolStripMenuItem.Click
        If MostrarListaToolStripMenuItem.Checked = True Then
            MostrarListaToolStripMenuItem.Checked = False
            Me.Width = 340
        Else
            MostrarListaToolStripMenuItem.Checked = True
            Me.Width = 530
        End If
    End Sub

    Private Sub GeneroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneroToolStripMenuItem.Click
        Dim criterio As String
        Me.SuporteBindingSource.EndEdit()
        criterio = InputBox("escrevca")
        Me.SuporteTableAdapter.FillByGenero(Me.BdDataSet.suporte, criterio)
    End Sub
End Class
