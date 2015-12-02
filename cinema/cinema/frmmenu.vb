Public Class frmmenu

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmlist.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmeditor.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmnovo.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmpesquisa.Show()
    End Sub

  

    Private Sub sobre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sobre.Click
        AboutBox.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim mensagem, titulo, botoes, icone, resposta As Object
        mensagem = "Deseja mesmo sair do programa? Grave sempre as alteraçoes!"
        titulo = "Sair"
        botoes = MessageBoxButtons.YesNo
        icone = MessageBoxIcon.Warning
        resposta = MessageBox.Show(mensagem, titulo, botoes, icone)

        If resposta = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
End Class