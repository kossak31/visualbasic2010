Public Class frmMain
    Dim mensagem, titulo, botoes, icone
    Dim resposta As DialogResult


    Private Sub GerirBancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerirBancosToolStripMenuItem.Click
        frmbancos.Show()
    End Sub

    Private Sub ÍrParaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÍrParaToolStripMenuItem.Click
        Dim numero As Decimal
        numero = Val(InputBox("indique o codigo da conta"))
        If numero >= 1 Then
            ContasTableAdapter.FillByCodigo(BDbancoDataSet.Contas, numero)
        End If
    End Sub

    Private Sub SaldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldoToolStripMenuItem.Click
        Dim numero As Decimal = Val(txtcodigo.Text)
        Dim valor As Decimal
        valor = MovimentosTableAdapter.saldoQuery(numero)
        mensagem = "o saldo da conta = " & valor & "€"
        titulo = Me.Text
        botoes = MessageBoxButtons.OK
        icone = MessageBoxIcon.Information
        MessageBox.Show(mensagem, titulo, botoes, icone)
    End Sub

    Private Sub EleminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EleminarToolStripMenuItem.Click
        ContasBindingSource.EndEdit()
        ContasTableAdapter.Delete(txtcodigo.Text)
        TableAdapterManager.UpdateAll(BDbancoDataSet)
        ContasTableAdapter.Fill(BDbancoDataSet.Contas)
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Validate()
        ContasBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(BDbancoDataSet)
        ContasTableAdapter.Fill(BDbancoDataSet.Contas)
    End Sub

    Private Sub NovaContaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaContaToolStripMenuItem.Click
        Validate()
        ContasBindingSource.EndEdit()
        ContasBindingSource.AddNew()
        NovaContaToolStripMenuItem.Checked = True
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Validate()
        ContasBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(BDbancoDataSet)
        End
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BancosTableAdapter.Fill(BDbancoDataSet.bancos)
        MovimentosTableAdapter.Fill(BDbancoDataSet.Movimentos)
        ContasTableAdapter.Fill(BDbancoDataSet.Contas)
    End Sub

   
End Class
