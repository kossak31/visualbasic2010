Imports System.IO
Imports System.IO.StreamWriter

Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bttsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttsave.Click
        Dim FSFicheiro As New FileStream("C:\iplist.txt", FileMode.OpenOrCreate, FileAccess.Write)
        Dim rec As New StreamWriter(FSFicheiro)
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            rec.WriteLine(ListBox1.Items.Item(i))
        Next
        rec.Close()
    End Sub

    Private Sub bttlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttlist.Click
        Dim num1 As Integer = txt1.Text
        Dim num2 As Integer = txt2.Text
        Dim num3 As Integer = txt3.Text
        Dim num4 As Integer = txt4.Text
        Dim x As Integer = 255

        'TODOS MARCADOS
        If CheckBox1.CheckState = 1 And CheckBox2.CheckState = 1 And CheckBox3.CheckState = 1 And CheckBox4.CheckState = 1 Then
            ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
        End If
        else
        'TODOS DINAMICOS
        If CheckBox1.CheckState = 0 And CheckBox2.CheckState = 0 And CheckBox3.CheckState = 0 And CheckBox4.CheckState = 0 Then
            For ctd = num4 To 255
                num1 += 1
                num2 += 1
                num3 += 1
                num4 += 1

                ListBox1.Items.Add(num1 - 1 & "." & num2 - 1 & "." & num3 - 1 & "." & num4 - 1)
            Next
        End If

        If CheckBox1.CheckState = 1 And CheckBox2.CheckState = 0 And CheckBox3.CheckState = 0 And CheckBox4.CheckState = 0 Then
            Do
                num1 = num1
                num2 += 1
                num3 += 1
                num4 += 1
                ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
            Loop Until num4 = 255
        End If
        else
        If CheckBox1.CheckState = 1 And CheckBox2.CheckState = 1 And CheckBox3.CheckState = 0 And CheckBox4.CheckState = 0 Then
            Do
                num1 = num1
                num2 = num2
                num3 += 1
                num4 += 1
                ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
            Loop Until num4 = 255
        End If

        If CheckBox1.CheckState = 1 And CheckBox2.CheckState = 1 And CheckBox3.CheckState = 1 And CheckBox4.CheckState = 0 Then
            Do
                num1 = num1
                num2 = num2
                num3 = num3
                num4 += 1
                ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
            Loop Until num4 = 255
        End If

        If CheckBox1.CheckState = 0 And CheckBox2.CheckState = 0 And CheckBox3.CheckState = 0 And CheckBox4.CheckState = 1 Then
            Do
                num1 += 1
                num2 += 1
                num3 += 1
                num4 = num4
                ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
            Loop Until num1 = 255
        End If

        If CheckBox1.CheckState = 0 And CheckBox2.CheckState = 0 And CheckBox3.CheckState = 1 And CheckBox4.CheckState = 1 Then
            Do
                num1 += 1
                num2 += 1
                num3 = num3
                num4 = num4
                ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
            Loop Until num1 = 255
        End If

        If CheckBox1.CheckState = 0 And CheckBox2.CheckState = 1 And CheckBox3.CheckState = 1 And CheckBox4.CheckState = 1 Then
            Do
                num1 += 1
                num2 = num2
                num3 = num3
                num4 = num4
                ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
            Loop Until num1 = 255
        End If

        If CheckBox1.CheckState = 0 And CheckBox2.CheckState = 1 And CheckBox3.CheckState = 0 And CheckBox4.CheckState = 0 Then
            Do
                num1 += 1
                num2 = num2
                num3 += 1
                num4 += 1
                ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
            Loop Until num4 = 255
        End If
        else
        If CheckBox1.CheckState = 0 And CheckBox2.CheckState = 0 And CheckBox3.CheckState = 1 And CheckBox4.CheckState = 0 Then
            Do
                num1 += 1
                num2 += 1
                num3 = num3
                num4 += 1
                ListBox1.Items.Add(num3 & "." & num4)
            Loop Until num4 = 255
        End If
        else
        If CheckBox1.CheckState = 1 And CheckBox2.CheckState = 0 And CheckBox3.CheckState = 1 And CheckBox4.CheckState = 0 Then
            Do
                num1 = num1
                num2 += 1
                num3 = num3
                num4 += 1
                ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
            Loop Until num4 = 255
        End If
        else
        If CheckBox1.CheckState = 0 And CheckBox2.CheckState = 1 And CheckBox3.CheckState = 0 And CheckBox4.CheckState = 1 Then
            Do
                num1 += 1
                num2 = num2
                num3 += 1
                num4 = num4
                ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
            Loop Until num1 = 255
        End If

        If CheckBox1.CheckState = 1 And CheckBox2.CheckState = 0 And CheckBox3.CheckState = 0 And CheckBox4.CheckState = 1 Then
            Do
                num1 = num1
                num2 += 1
                num3 = num3
                num4 += 1
                ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
            Loop Until num4 = 255
        End If
        else
        If CheckBox1.CheckState = 0 And CheckBox2.CheckState = 1 And CheckBox3.CheckState = 1 And CheckBox4.CheckState = 0 Then
            Do
                num1 = num1
                num2 += 1
                num3 += 1
                num4 = num4
                ListBox1.Items.Add(num1 & "." & num2 & "." & num3 & "." & num4)
            Loop Until num3 = 255
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged, CheckBox5.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Enabled = False
        Else
            CheckBox1.Checked = False
            TextBox1.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged, CheckBox6.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox2.Enabled = False
        Else
            CheckBox2.Checked = False
            TextBox2.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged, CheckBox7.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox3.Enabled = False
        Else
            CheckBox3.Checked = False
            TextBox3.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged, CheckBox8.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox4.Enabled = False
        Else
            CheckBox4.Checked = False
            TextBox4.Enabled = True
        End If
    End Sub

    Private Sub bttclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttclean.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub bttiptables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttiptables.Click
        iptables.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
