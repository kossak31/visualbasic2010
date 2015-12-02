Public Class Form1

    Private Sub calendario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calendario.ValueChanged
        Dim dia As Integer
        Dim mes As Integer

        dia = calendario.Value.Day
        mes = calendario.Value.Month
        LbSigno.Text = signo(dia, mes)
    End Sub
    Function signo(ByVal dia As Integer, ByVal mes As Integer) As String
        Select Case mes
            Case 1
                If dia < 20 Then
                    signo = "capri"
                Else
                    signo = "aquario"
                End If
            Case 2
                If dia < 19 Then
                    signo = "aquario"
                Else
                    signo = "peixes"
                End If
            Case 3
                If dia < 20 Then
                    signo = "peixes"
                Else
                    signo = "carneiro"
                End If
            Case 4
                If dia < 21 Then
                    signo = "carneiro"
                Else
                    signo = "touro"
                End If
            Case 5
                If dia < 20 Then
                    signo = "touro"
                Else
                    signo = "gemeos"
                End If
            Case 6
                If dia < 20 Then
                    signo = "gemeos"
                Else
                    signo = "caraguejo"
                End If
            Case 7
                If dia < 21 Then
                    signo = "caraguejo"
                Else
                    signo = "leao"
                End If
            Case 8
                If dia < 22 Then
                    signo = "leao"
                Else
                    signo = "virgem"
                End If
            Case 9
                If dia < 23 Then
                    signo = "virgem"
                Else
                    signo = "balança"

                End If
            Case 10
                If dia < 22 Then
                    signo = "balança"
                Else
                    signo = "escorpiao"
                End If
            Case 11
                If dia < 21 Then
                    signo = "escorpiao"
                Else
                    signo = "sagitario"
                End If
            Case 12
                If dia < 21 Then
                    signo = "Sagitario"
                Else
                    signo = "capricornio"
                End If
        End Select
    End Function
End Class