Public Class Form1


    Private Sub NimBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NimBindingNavigatorSaveItem.Click
      

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDctcDataSet1.companhia' table. You can move, or remove it, as needed.
        Me.CompanhiaTableAdapter1.Fill(Me.BDctcDataSet1.companhia)
        'TODO: This line of code loads data into the 'BDctcDataSet1.nim' table. You can move, or remove it, as needed.
        Me.NimTableAdapter.Fill(Me.BDctcDataSet1.nim)

    End Sub
End Class
