Imports System.IO
Imports System.IO.StreamWriter

Public Class iptables


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                casa1.Text = "62"
                casa2.Text = "28"
                casa3.Text = "200"
                casa4.Text = "67"

                fim1.Text = "62"
                fim2.Text = "28"
                fim3.Text = "255"
                fim4.Text = "255"
            Case 1
                '5.43.0.0
                '5.43.63.255
                casa1.Text = "5"
                casa2.Text = "43"
                casa3.Text = "0"
                casa4.Text = "0"

                fim1.Text = "5"
                fim2.Text = "43"
                fim3.Text = "63"
                fim4.Text = "255"
            Case 2
                '5.158.0.0
                '5.158.63.255
                casa1.Text = "5"
                casa2.Text = "158"
                casa3.Text = "0"
                casa4.Text = "0"

                fim1.Text = "5"
                fim2.Text = "158"
                fim3.Text = "63"
                fim4.Text = "255"
            Case 3
                '5.249.0.0
                '5.249.127.255
                casa1.Text = "5"
                casa2.Text = "249"
                casa3.Text = "0"
                casa4.Text = "0"

                fim1.Text = "5"
                fim2.Text = "249"
                fim3.Text = "127"
                fim4.Text = "255"
            Case 4
                '37.28.192.0
                '37.28.255.255
                casa1.Text = "37"
                casa2.Text = "28"
                casa3.Text = "192"
                casa4.Text = "0"

                fim1.Text = "37"
                fim2.Text = "28"
                fim3.Text = "255"
                fim4.Text = "255"
            Case 5
                '46.189.128.0
                '46.189.255.255
                casa1.Text = "46"
                casa2.Text = "189"
                casa3.Text = "128"
                casa4.Text = "0"

                fim1.Text = "46"
                fim2.Text = "189"
                fim3.Text = "255"
                fim4.Text = "255"
            Case 6
                '77.54.0.0
                '77.54.255.255
                casa1.Text = "77"
                casa2.Text = "54"
                casa3.Text = "0"
                casa4.Text = "0"

                fim1.Text = "77"
                fim2.Text = "54"
                fim3.Text = "255"
                fim4.Text = "255"
            Case 7
                '78.137.192.0
                '78.137.255.255
                casa1.Text = "78"
                casa2.Text = "137"
                casa3.Text = "192"
                casa4.Text = "0"

                fim1.Text = "78"
                fim2.Text = "137"
                fim3.Text = "255"
                fim4.Text = "255"
            Case 8
                '83.174.0.0
                '83.174.63.255
                casa1.Text = "83"
                casa2.Text = "174"
                casa3.Text = "0"
                casa4.Text = "0"

                fim1.Text = "83"
                fim2.Text = "174"
                fim3.Text = "63"
                fim4.Text = "255"
            Case 9
                '87.103.0.0
                '87.103.127.255
                casa1.Text = "87"
                casa2.Text = "103"
                casa3.Text = "0"
                casa4.Text = "0"

                fim1.Text = "87"
                fim2.Text = "103"
                fim3.Text = "127"
                fim4.Text = "255"
            Case 10
                '93.108.0.0
                '93.108.255.255
                casa1.Text = "93"
                casa2.Text = "108"
                casa3.Text = "0"
                casa4.Text = "0"

                fim1.Text = "93"
                fim2.Text = "108"
                fim3.Text = "255"
                fim4.Text = "255"
            Case 11
                '95.136.0.0
                '136.127.255
                casa1.Text = "95"
                casa2.Text = "136"
                casa3.Text = "0"
                casa4.Text = "0"

                fim1.Text = "136"
                fim2.Text = "127"
                fim3.Text = "255"
                fim4.Text = "255"
            Case 121
                '178.166.0.0
                '178.166.127.255
                casa1.Text = "178"
                casa2.Text = "166"
                casa3.Text = "0"
                casa4.Text = "0"

                fim1.Text = "178"
                fim2.Text = "166"
                fim3.Text = "127"
                fim4.Text = "255"

            Case 13
                '213.30.0.0
                '213.30.127.255
                casa1.Text = "213"
                casa2.Text = "30"
                casa3.Text = "0"
                casa4.Text = "0"

                fim1.Text = "213"
                fim2.Text = "30"
                fim3.Text = "127"
                fim4.Text = "255"
            Case 14
                '212.18.160.0
                '212.18.191.255
                casa1.Text = "212"
                casa2.Text = "18"
                casa3.Text = "160"
                casa4.Text = "0"

                fim1.Text = "212"
                fim2.Text = "18"
                fim3.Text = "191"
                fim4.Text = "255"
            Case 15
                '188.37.0.0
                '188.37.255.255
                casa1.Text = "188"
                casa2.Text = "37"
                casa3.Text = "0"
                casa4.Text = "0"

                fim1.Text = "188"
                fim2.Text = "37"
                fim3.Text = "255"
                fim4.Text = "255"
        End Select
    End Sub

    Private Sub iptables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA1")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA2")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA3")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA4")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA5")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA6")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA7")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA8")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA9")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA10")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA11")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA12")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA13")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA14")
        ComboBox1.Items.Add("Vodafone Telecel, Comunicacoes Pessoais, SA15")
    End Sub

    Private Sub bttiptables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttiptables.Click

        Dim casamin1 As Integer = casa1.Text
        Dim casamin2 As Integer = casa2.Text
        Dim casamin3 As Integer = casa3.Text - 1
        Dim casamin4 As Integer = casa4.Text - 1

        Dim casamax1 As Integer = fim1.Text
        Dim casamax2 As Integer = fim2.Text
        Dim casamax3 As Integer = fim3.Text
        Dim casamax4 As Integer = fim4.Text

        Dim max As Integer = fim3.Text
        Dim min As Integer = casa3.Text - 1


        For ctd = min To max - 1
            casamin1 = casamin1
            casamin2 = casamin2
            casamin3 += 1
            casamin4 += 1

            ListBox1.Items.Add(casamin1 & "." & casamin2 & "." & casamin3 & "." & casamin4)
        Next
    End Sub

    Private Sub bttclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttclean.Click
        ListBox1.Items.Clear()
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
End Class