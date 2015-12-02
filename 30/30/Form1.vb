Public Class Form1

   
 
    Private Sub bttCalcBI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttCalcBI.Click
        Dim numero As String = MtxtBI.Text()

        If Len(MtxtBI.Text) < 6 Then
            MessageBox.Show("numero incompleto", "digite controlo", MessageBoxButtons.OK, MessageBoxIcon.Error)

            MtxtContribuinte.Select()

        Else
            If Len(MtxtBI.Text) < 8 Then
                MtxtBI.Text = "0" & numero
            ElseIf Len(MtxtBI.Text) < 7 Then
                MtxtBI.Text = "00" & numero
            End If
            LbControloBI.Text = digitoC(MtxtBI.Text)
            LbBI.Text = MtxtBI.Text & LbDigitoCont.Text
        End If
    End Sub

    Private Sub bttCalcContr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCalcContr.Click


        If Len(MtxtContribuinte.Text) <> 8 Then

            MessageBox.Show("numero incompleto", "bi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MtxtContribuinte.Select()
        Else
            LbDigitoCont.Text = digitoC(MtxtContribuinte.Text)
            LbContribuinte.Text = MtxtContribuinte.Text & LbDigitoCont.Text
        End If

    End Sub

    Public Function digitoC(ByVal numero As String) As Integer

        Dim valor As String = numero
        Dim soma As Double = 0
        Dim resto As Integer
        Dim ctd As Integer

        For ctd = 0 To 7
            soma += ((9 - ctd) * Val(valor(ctd)))
        Next

        resto = soma Mod 11

        If resto = 0 Or resto = 1 Then
            digitoC = 0
        Else
            digitoC = 11 - resto
        End If
    End Function

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            MtxtBI.Text = ""
            LbControloBI.ResetText()
            LbBI.ResetText()
        MtxtBI.Select()
            MtxtContribuinte.Text = ""
            LbDigitoCont.ResetText()
            LbContribuinte.ResetText()
            MtxtContribuinte.ResetText()
    End Sub
End Class