Public Class frmeditor

 
    Private Sub editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
      
        'TODO: This line of code loads data into the 'BdbilhetesbetaDataSet.Bilhete' table. You can move, or remove it, as needed.
        Me.BilheteTableAdapter.Fill(Me.BdbilhetesbetaDataSet.Bilhete)
        'TODO: This line of code loads data into the 'BdbilhetesbetaDataSet.Utilizador' table. You can move, or remove it, as needed.


    End Sub

    
    Private Sub FillByTeatroToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByTeatroToolStripButton.Click
        Try
            Me.BilheteTableAdapter.FillByTeatro(Me.BdbilhetesbetaDataSet.Bilhete)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataDateTimePicker.ValueChanged

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
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

        End If
    End Sub

End Class