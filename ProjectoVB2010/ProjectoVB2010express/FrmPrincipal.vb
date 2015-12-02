Public Class FrmPrincipal
    Private Sub tsbSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSocios.Click
        Dim janela As New FrmSocios
        janela.MdiParent = Me
        janela.Show()
    End Sub

    Private Sub tsbMonitores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbMonitores.Click
        Dim janela As New FrmMonitores
        janela.MdiParent = Me
        janela.Show()
    End Sub

    Private Sub tsbSistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSistema.Click
        Dim janela As New FrmSistema
        janela.MdiParent = Me
        janela.Show()
    End Sub

    Private Sub tsbSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSair.Click
        Dim mensagem, titulo, botões, icone
        Dim resposta As DialogResult

        mensagem = "Deseja sair da aplicação"
        titulo = Me.Text
        botões = MessageBoxButtons.YesNo
        icone = MessageBoxIcon.Question
        resposta = MessageBox.Show(mensagem, titulo, botões, icone)

        If resposta = Windows.Forms.DialogResult.Yes Then
            End
        End If

    End Sub
    Private Sub mnuCascata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCascata.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuLado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLado.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuIcones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIcones.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub tsbTurmas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbTurmas.Click
        Dim janela As New FrmTurmas
        janela.MdiParent = Me
        janela.Show()
    End Sub

    Private Sub tsbQuotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbQuotas.Click
        Dim janela As New FrmQuotas
        janela.MdiParent = Me
        janela.Show()
    End Sub
End Class
