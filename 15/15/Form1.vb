Public Class Form1

    Private Sub bttCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCalcular.Click
        Dim consumo, valor As Double
        consumo = CDbl(TxtLitros.Text) / CDbl(TxtDistância.Text) * 100
        LbConsumo2.Text = consumo

        valor = CDbl(TxtPreço.Text) * consumo
        LbValor.Text = valor
    End Sub
End Class
