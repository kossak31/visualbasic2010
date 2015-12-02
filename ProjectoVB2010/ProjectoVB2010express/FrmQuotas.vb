Public Class FrmQuotas
    Dim mensagem, titulo, botões, icone
    Dim resposta As DialogResult

    Private Sub FrmQuotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TabelaSociosTableAdapter.Fill(Me.DatabaseDataSet.TabelaSocios)
        Me.TabelaQuotasTableAdapter.Fill(Me.DatabaseDataSet.TabelaQuotas)

        For ano = DateAndTime.Now.Year To 1990 Step -1
            comboAno.Items.Add(ano)
        Next
    End Sub

    Private Sub tsbListagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbListagem.Click
        FrmLstQuotas.MdiParent = FrmPrincipal
        FrmLstQuotas.Show()
    End Sub

    Private Sub tsbNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNovo.Click
        Desbloquear(True)
        Me.TabelaQuotasBindingSource.AddNew()

        dtpDataPagamento.Text = DateTime.Today.Date
        dtpDataPagamento.ResetText()
        comboIDSocio.SelectedIndex = -1
        comboMes.SelectedIndex = -1
        comboAno.SelectedIndex = -1
    End Sub
    Private Sub tsbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEditar.Click
        Desbloquear(True)
    End Sub
    Private Sub tsbAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnular.Click
        Desbloquear(False)
        Me.Validate()
        Me.TabelaQuotasBindingSource.CancelEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        If comboIDSocio.SelectedIndex = -1 Or comboMes.SelectedIndex = -1 Or _
           comboAno.SelectedIndex = -1 Or txtValor.Text = "" Then

            mensagem = "Todos os campos são de preenchimento obrigatório"
            titulo = "Registo Incompleto"
            botões = MessageBoxButtons.OK
            icone = MessageBoxIcon.Warning

            MessageBox.Show(mensagem, titulo, botões, icone)

        Else

            Try
                Me.Validate()
                Me.TabelaQuotasBindingSource.EndEdit()
                Me.TabelaQuotasTableAdapter.Update(Me.DatabaseDataSet.TabelaQuotas)
                Me.TabelaQuotasTableAdapter.Fill(Me.DatabaseDataSet.TabelaQuotas)

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
            Me.TabelaQuotasBindingSource.EndEdit()
            Me.TabelaQuotasTableAdapter.Delete(CDec(txtIDQuota.Text))
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            Me.TabelaQuotasTableAdapter.Fill(Me.DatabaseDataSet.TabelaQuotas)
        End If

    End Sub
    Public Sub Desbloquear(ByVal estado As Boolean)

        'bloquear ou desbloquear os objectos do formulário
        comboIDSocio.Enabled = estado
        dtpDataPagamento.Enabled = estado
        comboMes.Enabled = estado
        comboAno.Enabled = estado
        txtValor.Enabled = estado

    End Sub
End Class