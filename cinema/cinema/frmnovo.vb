Public Class frmnovo
    Public Sub cleartextboxes()
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                DirectCast(c, TextBox).Clear()
            End If
        Next
    End Sub
    Public Sub Desbloquear(ByVal estado As Boolean)

        'bloquear ou desbloquear os objectos do formulário
        NomeTextBox.Enabled = estado
        CategoriaComboBox.Enabled = estado
        CompanhiaTextBox.Enabled = estado
        DireccaoTextBox.Enabled = estado
        'datas
        DataDateTimePicker.Enabled = estado
        HoraComboBox.Enabled = estado
        'dado bilhete lugares
        LugarletraComboBox.Enabled = estado
        LugarnumeroTextBox.Enabled = estado
        SalaTextBox.Enabled = estado

        'onde estas?
        FestivalTextBox.Enabled = estado
        DireccaoTextBox.Enabled = estado
        PaisTextBox.Enabled = estado
        CidadeTextBox.Enabled = estado
        SpotTextBox.Enabled = estado
        'outros
        UtilizadoridComboBox.Enabled = estado
        NotasTextBox.Enabled = estado
        CriticaNumericUpDown.Enabled = estado
        'dinheiro
        ValorTextBox.Enabled = estado

        'checkbox
        radconvite.Enabled = estado
        radpreco.Enabled = estado
        Radentrada.Enabled = estado



    End Sub


    Private Sub frmnovo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cleartextboxes()
    End Sub

    Private Sub NovoRegistoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoRegistoToolStripMenuItem.Click
        Desbloquear(True)
        Try
            BilheteBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
  
    Private Sub tsbNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNovo.Click
        Desbloquear(True)
        Try
            BilheteBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub radconvite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radconvite.CheckedChanged
        If radconvite.Enabled Then
            Dim convite As String
            convite = "convite"
            ValorTextBox.Text = convite
            ValorTextBox.Enabled = False
        End If
    End Sub
    Private Sub Radentrada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radentrada.CheckedChanged
        If Radentrada.Enabled Then
            Dim livre As String
            livre = "entrada livre"
            ValorTextBox.Text = livre
            ValorTextBox.Enabled = False
        End If
    End Sub

    Private Sub radpreco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radpreco.CheckedChanged
        ValorTextBox.Clear()
        ValorTextBox.Enabled = True
        ValorTextBox.Text = 0
    End Sub

   

    


    Private Sub GuardarToolStripMenuItemx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItemx.Click
        If NomeTextBox.Text = "" Or CompanhiaTextBox.Text = "" Then
            Dim mensagem, titulo
            mensagem = "Os campos Nome, Companhia" & vbNewLine & _
                       "São Obrigatório"
            titulo = "Registo Incompleto"

            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Try
                Me.Validate()
                Me.BilheteBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BdbilhetesbetaDataSet)
                Me.BilheteTableAdapter.Fill(Me.BdbilhetesbetaDataSet.Bilhete)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MsgBox("Registo gravado com sucesso!")
            Me.Close()
        End If
    End Sub
End Class