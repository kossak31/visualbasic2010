Public Class Form1
    Dim registos() As String
    Dim elementos As Integer
    Dim fila As New Queue
    Dim tamanho As Integer

    Private Sub bttinserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttinserir.Click
        ReDim Preserve registos(elementos)
        registos(elementos) = txtnome.Text
        lstlista.Items.Clear()
        For ctd = 0 To elementos
            lstlista.Items.Add(registos(ctd))
        Next
        elementos += 1
        txtnome.ResetText()
        txtnome.Select()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fila.Enqueue(txtnome.Text)

        tamanho = fila.Count
        lstlista.Items.Clear()
        For ctd = 0 To tamanho - 1
            lstlista.Items.Add(fila(ctd))
        Next
        txtnome.ResetText()
        txtnome.Select()
    End Sub
End Class
