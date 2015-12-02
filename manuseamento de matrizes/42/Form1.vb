Public Class Form1
    Dim matriz(4, 5) As Double
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DataGridView1.Rows.Add(6)

        For ctd = 1 To 5
            DataGridView1(0, ctd - 1).Value = "vendedor" & ctd
            combovendedor.Items.Add(ctd)

            If ctd <= 4 Then
                combosemana.Items.Add(ctd)
            End If
        Next
        DataGridView1(0, 5).Value = "total"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim coluna, linha As Integer
        If combosemana.SelectedIndex <> -1 And combovendedor.SelectedIndex <> -1 And IsNumeric(txtvalor.Text) = True Then
            coluna = combosemana.SelectedIndex
            linha = combovendedor.SelectedIndex

            matriz(coluna, linha) = txtvalor.Text

            DataGridView1(coluna + 1, linha).value = matriz(coluna, linha)
            combosemana.SelectedIndex = -1
            combovendedor.SelectedIndex = -1
            txtvalor.ResetText()
            combosemana.Select()
        Else

            MessageBox.Show("msg", "x", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ctdcoluna, ctdlinha As Integer
        Dim totalvendas As Double
        Dim somasemana, somavendedor As Integer

        For ctdcoluna = 0 To 3
            somasemana = 0
            For ctdlinha = 0 To 4
                somasemana += matriz(ctdcoluna, ctdlinha)
            Next
            DataGridView1(ctdcoluna + 1, 5).Value = somasemana
        Next
        For ctdlinha = 0 To 4
            somavendedor = 0
            For ctdcoluna = 0 To 3
                somavendedor += matriz(ctdcoluna, ctdlinha)
            Next
            totalvendas += somavendedor
            DataGridView1(5, ctdlinha).Value = somavendedor
        Next
        DataGridView1(5, 5).Value = totalvendas
    End Sub
End Class
