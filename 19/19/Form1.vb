Imports System.IO
Imports System.IO.StreamWriter


Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For ctd = 1 To 10
            ComboBox1.Items.Add(ctd)
        Next




    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim numero As Integer
        numero = Val(ComboBox1.Text)
        ListBox1.Items.Clear()
        For ctd = 1 To 10
            DataGridView1.Rows.Add(numero & "x" & ctd & " = " & numero * ctd)
        Next

        Dim numeros As Integer
        numeros = Val(ComboBox1.Text)
        ListBox1.Items.Clear()
        For ctd = 1 To 10
            ListBox1.Items.Add(numeros & "tabua" & ctd & " = " & numeros * ctd)
        Next
    End Sub

    Private Sub guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar.Click
        
        Dim FSFicheiro As New FileStream("C:\iplist.txt", FileMode.Open, FileAccess.Write)
        Dim rec As New StreamWriter(FSFicheiro)
        Dim i As Integer
        For i = 0 To ListBox2.Items.Count - 1
            rec.WriteLine(ListBox2.Items.Item(i))
        Next
        rec.Close()
    End Sub

    Private Sub gerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gerar.Click
        Dim num1 As Integer = txt1.Text
        Dim num2 As Integer = txt2.Text
        Dim num3 As Integer = txt3.Text
        Dim num4 As Integer = txt4.Text

        For ctd = 1 To 10
            num1 = num1 + 1
            num2 = num2 + 1
            num3 = num3 + 1
            num4 = num4 + 1
            ListBox2.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
        Next

    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub
End Class
