Public Class FrmSocios
    Dim mensagem, titulo, botões, icone
    Dim resposta As DialogResult
    Private Sub TabelaSociosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TabelaSociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub
    Private Sub TabelaSociosBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TabelaSociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub
    Private Sub FrmSocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TabelaTipoSociosTableAdapter.Fill(Me.DatabaseDataSet.TabelaTipoSocios)
        Me.TabelaSociosTableAdapter.Fill(Me.DatabaseDataSet.TabelaSocios)
    End Sub
    Private Sub tsbNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNovo.Click
        Desbloquear(True)
        Me.TabelaSociosBindingSource.AddNew()

        dtpdata.Text = DateTime.Today.Date
        dtpdata.ResetText()

        comboTipoSocio.SelectedIndex = -1
    End Sub
    Private Sub tsbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEditar.Click
        Desbloquear(True)
    End Sub
    Private Sub tsbAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnular.Click
        Desbloquear(False)
        Me.Validate()
        Me.TabelaSociosBindingSource.CancelEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        If txtNome.Text = "" Or txtTelefone.Text = "" Or comboTipoSocio.SelectedIndex = -1 Then

            mensagem = "Os campos Data, Nome, Telefone e Tipo de Sócio" & vbNewLine & _
                       "São de preenchimento obrigatório"
            titulo = "Registo Incompleto"
            botões = MessageBoxButtons.OK
            icone = MessageBoxIcon.Warning

            MessageBox.Show(mensagem, titulo, botões, icone)

        Else

            Try
                Me.Validate()
                Me.TabelaSociosBindingSource.EndEdit()
                Me.TabelaSociosTableAdapter.Update(Me.DatabaseDataSet.TabelaSocios)
                Me.TabelaSociosTableAdapter.Fill(Me.DatabaseDataSet.TabelaSocios)

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
            Me.TabelaSociosBindingSource.EndEdit()
            Me.TabelaSociosTableAdapter.Delete(CDec(txtIDSocio.Text))
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            Me.TabelaSociosTableAdapter.Fill(Me.DatabaseDataSet.TabelaSocios)
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
        comboTipoSocio.Enabled = estado

    End Sub
    Private Sub tsbListagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbListagem.Click
        FrmTodosSocios.MdiParent = FrmPrincipal
        FrmTodosSocios.Show()
    End Sub
    Private Sub txtTelefone_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefone.LostFocus
        If IsNumeric(txtTelefone.Text) = False Or txtTelefone.TextLength <> 9 Then
            MessageBox.Show("Telefone incompleto")
        End If
    End Sub


    Private Sub mnuContaCorrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuContaCorrente.Click
        FrmContaCorrente.MdiParent = FrmPrincipal
        socio = CDec(txtIDSocio.Text)
        FrmContaCorrente.Show()

    End Sub

    Private Sub mnuTodosSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTodosSocios.Click
        FrmTodosSocios.MdiParent = FrmPrincipal
        FrmTodosSocios.Show()
    End Sub


    Private Sub mnuActividades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActividades.Click
        socio = CDec(txtIDSocio.Text)
        FrmActividadesSocio.MdiParent = FrmPrincipal
        FrmActividadesSocio.Show()


    End Sub
End Class
