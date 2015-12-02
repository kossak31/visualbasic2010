Public Class FrmMonitores
    Dim mensagem, titulo, botões, icone
    Dim resposta As DialogResult

    Private Sub tsbListagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbListagem.Click
        FrmCoordenadores.MdiParent = FrmPrincipal
        FrmCoordenadores.Show()

    End Sub
    Private Sub FrmMonitores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TabelaMonitoresTableAdapter.Fill(Me.DatabaseDataSet.TabelaMonitores)
    End Sub

    Private Sub tsbNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNovo.Click
        Desbloquear(True)
        Me.TabelaMonitoresBindingSource.AddNew()

        dtpData.Text = DateTime.Today.Date
        dtpData.ResetText()
    End Sub
    Private Sub tsbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEditar.Click
        Desbloquear(True)
    End Sub
    Private Sub tsbAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnular.Click
        Desbloquear(False)
        Me.Validate()
        Me.TabelaMonitoresBindingSource.CancelEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        If txtNome.Text = "" Or txtTelefone.Text = "" Then

            mensagem = "Os campos Data, Nome e Telefone " & vbNewLine & _
                       "São de preenchimento obrigatório"
            titulo = "Registo Incompleto"
            botões = MessageBoxButtons.OK
            icone = MessageBoxIcon.Warning

            MessageBox.Show(mensagem, titulo, botões, icone)

        Else

            Try
                Me.Validate()
                Me.TabelaMonitoresBindingSource.EndEdit()
                Me.TabelaMonitoresTableAdapter.Update(Me.DatabaseDataSet.TabelaMonitores)
                Me.TabelaMonitoresTableAdapter.Fill(Me.DatabaseDataSet.TabelaMonitores)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Desbloquear(False)
        End If

    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click

        mensagem = "Deseja eliminar o registo actual"
        titulo = "Confirmação da operação"
        botões = MessageBoxButtons.YesNo
        icone = MessageBoxIcon.Question
        resposta = MessageBox.Show(mensagem, titulo, botões, icone)

        If resposta = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.TabelaMonitoresBindingSource.EndEdit()
            Me.TabelaMonitoresTableAdapter.Delete(CDec(txtIDMonitor.Text))
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            Me.TabelaMonitoresTableAdapter.Fill(Me.DatabaseDataSet.TabelaMonitores)
        End If

    End Sub
    Public Sub Desbloquear(ByVal estado As Boolean)

        'bloquear ou desbloquear os objectos do formulário
        dtpdata.Enabled = estado
        txtNome.Enabled = estado
        txtMorada.Enabled = estado
        txtCPostal.Enabled = estado
        txtLocalidade.Enabled = estado
        txtTelefone.Enabled = estado
        txtEmail.Enabled = estado
  
    End Sub

    Private Sub ToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

    End Sub
End Class