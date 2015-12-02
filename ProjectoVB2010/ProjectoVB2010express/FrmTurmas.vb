Public Class FrmTurmas
    Dim mensagem, titulo, botões, icone
    Dim resposta As DialogResult
    Private Sub TabelaTurmasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TabelaTurmasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub

    Private Sub FrmTurmas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.TabelaMonitores' table. You can move, or remove it, as needed.
        Me.TabelaMonitoresTableAdapter.Fill(Me.DatabaseDataSet.TabelaMonitores)
        'TODO: This line of code loads data into the 'DatabaseDataSet.TabelaModalidades' table. You can move, or remove it, as needed.
        Me.TabelaModalidadesTableAdapter.Fill(Me.DatabaseDataSet.TabelaModalidades)

        Me.TabelaSociosTableAdapter.Fill(Me.DatabaseDataSet.TabelaSocios)
        Me.TabelaTurmaAlunosTableAdapter.Fill(Me.DatabaseDataSet.TabelaTurmaAlunos)
        Me.TabelaTurmasTableAdapter.Fill(Me.DatabaseDataSet.TabelaTurmas)

        For hora = 8 To 20
            comboHoraInicio.Items.Add(hora & ":00")
            comboHoraFim.Items.Add(hora & ":00")
        Next
    End Sub
    Private Sub tsbNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNovo.Click
        Desbloquear(True)
        Me.TabelaTurmasBindingSource.AddNew()

        comboCoordenador.SelectedIndex = -1
        comboDia.SelectedIndex = -1
        comboHoraInicio.SelectedIndex = -1
        comboHoraFim.SelectedIndex = -1
        txtDesignacao.Focus()
        grelhaPraticantes.Enabled = True
    End Sub
    Private Sub tsbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEditar.Click
        Desbloquear(True)
        grelhaPraticantes.Enabled = True
    End Sub
    Private Sub tsbAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnular.Click
        Desbloquear(False)
        Me.Validate()
        Me.TabelaTurmasBindingSource.CancelEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        If txtDesignacao.Text = "" Or comboCoordenador.Text = "" Or comboDia.Text = "" _
            Or comboHoraInicio.Text = "" Or comboHoraFim.Text = "" Or txtValor.Text = "" Then

            mensagem = "Todos os campos são de preenchimento obrigatório"
            titulo = "Registo Incompleto"
            botões = MessageBoxButtons.OK
            icone = MessageBoxIcon.Warning

            MessageBox.Show(mensagem, titulo, botões, icone)

        Else

            Try
                Me.Validate()
                Me.TabelaTurmasBindingSource.EndEdit()
                Me.TabelaTurmaAlunosBindingSource.EndEdit()
                Me.TabelaTurmaAlunosTableAdapter.Update(Me.DatabaseDataSet.TabelaTurmaAlunos)
                Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
                Me.TabelaTurmasTableAdapter.Fill(Me.DatabaseDataSet.TabelaTurmas)
                Me.TabelaTurmaAlunosTableAdapter.Fill(Me.DatabaseDataSet.TabelaTurmaAlunos)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Desbloquear(False)
            grelhaPraticantes.Enabled = False
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
            Me.TabelaTurmasBindingSource.EndEdit()
            Me.TabelaTurmasTableAdapter.Delete(CDec(txtIdTurma.Text))
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            Me.TabelaTurmasTableAdapter.Fill(Me.DatabaseDataSet.TabelaTurmas)
        End If

    End Sub
    Public Sub Desbloquear(ByVal estado As Boolean)

        'bloquear ou desbloquear os objectos do formulário
        txtDesignacao.Enabled = estado
        comboModalidade.Enabled = estado
        comboCoordenador.Enabled = estado
        comboDia.Enabled = estado
        comboHoraInicio.Enabled = estado
        comboHoraFim.Enabled = estado
        txtValor.Enabled = estado

    End Sub

    Private Sub comboHoraInicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboHoraInicio.SelectedIndexChanged

    End Sub
End Class