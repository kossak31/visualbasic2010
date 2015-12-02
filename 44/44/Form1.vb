Public Class Form1
    Dim ctdnumero As Integer
    Dim ctdestrela As Integer
    Dim linhaboletim As Integer
    Dim boletim(6, 9) As Integer
    Dim sorteionumeros(4) As Integer
    Dim sorteioestrelas(1) As Integer
    Dim aposta(4) As Integer
    Dim estrelas(1) As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim numero As Integer

        Gnumeros.Rows.Add(10)
        GEstrelas.Rows.Add(3)
        GBoletim.Rows.Add(10)
        GSorteio.Rows.Add(1)

        For linha = 0 To 9
            For coluna = 0 To 4
                numero += 1
                Gnumeros.Item(coluna, linha).Value = numero
                Gnumeros.Item(coluna, linha).Selected = False
            Next

        Next
        numero = 0
        For linha = 0 To 2
            For coluna = 0 To 2
                numero += 1
                GEstrelas.Item(coluna, linha).Value = numero
                GEstrelas.Item(coluna, linha).Selected = False
            Next
        Next
    End Sub

    Private Sub GEstrelas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GEstrelas.CellContentClick
        If GEstrelas.CurrentCell.Style.BackColor <> Color.Aqua Then
            If ctdestrela <= 1 Then
                estrelas(ctdestrela) = GEstrelas.CurrentCell.Value
                ctdestrela += 1
                GEstrelas.CurrentCell.Selected = False
                GEstrelas.CurrentCell.Style.BackColor = Color.Aqua

                If ctdestrela = 2 Then
                    GEstrelas.Enabled = False
                    Array.Sort(estrelas)
                End If

            End If
        Else
            MsgBox("yo")
        End If
    End Sub
End Class
