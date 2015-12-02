Public Class Form1
    
    Private Sub bttentrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttentrada.Click
        lbdataentrada.Text = DateAndTime.Today
        lbhoraentrada.Text = DateAndTime.TimeOfDay

        bttsaida.Enabled = True

        lbdatasaida.ResetText()
        lbhorasaida.ResetText()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbdataentrada.Text = DateAndTime.Today
        lbhoraentrada.Text = DateAndTime.TimeOfDay
    End Sub

    Private Sub bttsaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttsaida.Click
        Dim duracao As Double


        If txtvalor.Text <> "" Then
            lbdatasaida.Text = DateAndTime.Today
            lbhorasaida.Text = DateAndTime.TimeOfDay
            duracao = tempo(lbdataentrada.Text, lbdatasaida.Text, lbhoraentrada.Text, lbhorasaida.Text)

            If duracao < 15 Then
                lbpagar.Text = txtvalor.Text
            Else
                lbpagar.Text = Math.Round(duracao / 15 * CDbl(txtvalor.Text), 2)
            End If

        Else
            mensagem = "a"
            titulo = "s"
            botoes = MessageBoxButtons.OK
            Icones = MessageBoxIcon.Stop
            MessageBox.Show(mensagem, titulo, botoes, icones)
        End If
    End Sub
End Class
