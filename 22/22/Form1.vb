Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For ctd = 1 To 20
            ComboBox1.Items.Add(ctd)
            ComboBox2.Items.Add(ctd)
            ComboBox3.Items.Add(ctd)
        Next

    End Sub

    Dim aluno As Integer
    Dim mediaturma As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim media As Double
        DataGridView1.Rows.Add()
        DataGridView1.Item(0, aluno).Value = TextBox1.Text
        DataGridView1.Item(1, aluno).Value = ComboBox1.Text
        DataGridView1.Item(2, aluno).Value = ComboBox2.Text
        DataGridView1.Item(3, aluno).Value = ComboBox3.Text

        media = (Val(ComboBox1.Text) + Val(ComboBox2.Text) + Val(ComboBox3.Text)) / 3

        DataGridView1.Item(4, aluno).Value = media
        If media > 10 Then
            DataGridView1.Item(5, aluno).Value = "aprovado"
        Else
            DataGridView1.Item(5, aluno).Value = "reprovado"
        End If
        aluno += 1
        Label1.Text = aluno
        mediaturma += media
        Label2.Text = mediaturma / aluno

        TextBox1.ResetText()
    End Sub
End Class
