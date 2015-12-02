Public Class frmpesquisa

    
    Private Sub frmpesquisa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdbilhetesbetaDataSet.Bilhete' table. You can move, or remove it, as needed.
        Me.BilheteTableAdapter.Fill(Me.BdbilhetesbetaDataSet.Bilhete)


        Me.cboField.SelectedIndex = 0

    End Sub


    Private Sub bttprocurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttprocurar.Click
        Select Case Me.cboField.SelectedIndex
            Case 0 'Procura por nome
                lb1.Text = "Nome"

                Me.BilheteTableAdapter.FillByNome(Me.BdbilhetesbetaDataSet.Bilhete, txtprocura.Text)
          
        End Select

        If txtprocura.Text = "" Then
            Me.BilheteTableAdapter.Fill(Me.BdbilhetesbetaDataSet.Bilhete)
        End If
    End Sub

    'box id
    Private Sub chkID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkID.CheckedChanged
        If chkID.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn1
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn1
            band.Visible = False
        End If
    End Sub
    'Checkbox nome
    Private Sub chknome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknome.CheckedChanged
        If chknome.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn3
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn3
            band.Visible = False
        End If
    End Sub
    'categoria
    Private Sub chkcategoria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcategoria.CheckedChanged
        If chkcategoria.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn2
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn2
            band.Visible = False
        End If
    End Sub
    'companhia
    Private Sub chkcompanhia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcompanhia.CheckedChanged
        If chkcompanhia.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn4
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn4
            band.Visible = False
        End If
    End Sub
    'festival
    Private Sub chkfestival_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfestival.CheckedChanged
        If chkfestival.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn11
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn11
            band.Visible = False
        End If
    End Sub
    'direccao
    Private Sub chkdireccao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdireccao.CheckedChanged
        If chkdireccao.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn14
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn14
            band.Visible = False
        End If
    End Sub

    Private Sub chkdata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdata.CheckedChanged
        If chkdata.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn5
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn5
            band.Visible = False
        End If
    End Sub

    Private Sub chkhora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkhora.CheckedChanged
        If chkhora.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn6
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn6
            band.Visible = False
        End If
    End Sub

    Private Sub chksala_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksala.CheckedChanged
        If chksala.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn8
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn8
            band.Visible = False
        End If
    End Sub

    Private Sub chklugarnum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklugarnum.CheckedChanged
        If chklugarnum.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn9
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn9
            band.Visible = False
        End If
    End Sub

    Private Sub chklugarletra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklugarletra.CheckedChanged
        If chklugarletra.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn18
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn18
            band.Visible = False
        End If
    End Sub

    Private Sub chkentrada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkentrada.CheckedChanged
        If chkentrada.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn10
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn10
            band.Visible = False
        End If
    End Sub

    Private Sub chkvalor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkvalor.CheckedChanged
        If chkvalor.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn17
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn17
            band.Visible = False
        End If
    End Sub

    Private Sub chkcritica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcritica.CheckedChanged
        If chkcritica.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn19
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn19
            band.Visible = False
        End If
    End Sub

    Private Sub chknotas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknotas.CheckedChanged
        If chknotas.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn16
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn16
            band.Visible = False
        End If
    End Sub

    Private Sub chkuser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkuser.CheckedChanged
        If chkuser.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn15
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn15
            band.Visible = False
        End If
    End Sub

    Private Sub chkpais_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpais.CheckedChanged
        If chkpais.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn7
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn7
            band.Visible = False
        End If
    End Sub

    Private Sub chkcidade_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcidade.CheckedChanged
        If chkcidade.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn12
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn12
            band.Visible = False
        End If
    End Sub

    Private Sub chkspot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkspot.CheckedChanged
        If chkspot.CheckState = False Then
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn13
            band.Visible = True
        Else
            Dim band As DataGridViewBand = DataGridViewTextBoxColumn13
            band.Visible = False
        End If
    End Sub

    Private Sub ConviteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConviteToolStripMenuItem.Click

    End Sub



    Private Sub TotalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalToolStripMenuItem.Click

    End Sub

  
    Private Sub FillBytotalderegistosToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.BilheteTableAdapter.FillBytotalderegistos(Me.BdbilhetesbetaDataSet.Bilhete)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

   

   
    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.DataTable1TableAdapter.Fill(Me.BdbilhetesbetaDataSet.DataTable1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByteatroToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByteatroToolStripButton.Click
        Try
            Me.DataTable1TableAdapter.FillByteatroxx(Me.BdbilhetesbetaDataSet.DataTable1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class