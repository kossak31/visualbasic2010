<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbancos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CodigoBancoLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbancos))
        Me.BDbancoDataSet = New _60.BDbancoDataSet()
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancosTableAdapter = New _60.BDbancoDataSetTableAdapters.bancosTableAdapter()
        Me.TableAdapterManager = New _60.BDbancoDataSetTableAdapters.TableAdapterManager()
        Me.BancosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BancosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.BancoTextBox = New System.Windows.Forms.TextBox()
        CodigoBancoLabel = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        CType(Me.BDbancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BancosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoBancoLabel
        '
        CodigoBancoLabel.AutoSize = True
        CodigoBancoLabel.Location = New System.Drawing.Point(33, 65)
        CodigoBancoLabel.Name = "CodigoBancoLabel"
        CodigoBancoLabel.Size = New System.Drawing.Size(77, 13)
        CodigoBancoLabel.TabIndex = 1
        CodigoBancoLabel.Text = "Codigo Banco:"
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.Location = New System.Drawing.Point(33, 91)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(41, 13)
        BancoLabel.TabIndex = 3
        BancoLabel.Text = "Banco:"
        '
        'BDbancoDataSet
        '
        Me.BDbancoDataSet.DataSetName = "BDbancoDataSet"
        Me.BDbancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataMember = "bancos"
        Me.BancosBindingSource.DataSource = Me.BDbancoDataSet
        '
        'BancosTableAdapter
        '
        Me.BancosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bancosTableAdapter = Me.BancosTableAdapter
        Me.TableAdapterManager.ContasTableAdapter = Nothing
        Me.TableAdapterManager.MovimentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _60.BDbancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BancosBindingNavigator
        '
        Me.BancosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BancosBindingNavigator.BindingSource = Me.BancosBindingSource
        Me.BancosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BancosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BancosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BancosBindingNavigatorSaveItem})
        Me.BancosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BancosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BancosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BancosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BancosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BancosBindingNavigator.Name = "BancosBindingNavigator"
        Me.BancosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BancosBindingNavigator.Size = New System.Drawing.Size(381, 25)
        Me.BancosBindingNavigator.TabIndex = 0
        Me.BancosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BancosBindingNavigatorSaveItem
        '
        Me.BancosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BancosBindingNavigatorSaveItem.Image = CType(resources.GetObject("BancosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BancosBindingNavigatorSaveItem.Name = "BancosBindingNavigatorSaveItem"
        Me.BancosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BancosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtcodigo
        '
        Me.txtcodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancosBindingSource, "CodigoBanco", True))
        Me.txtcodigo.Location = New System.Drawing.Point(116, 62)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 2
        '
        'BancoTextBox
        '
        Me.BancoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancosBindingSource, "Banco", True))
        Me.BancoTextBox.Location = New System.Drawing.Point(116, 88)
        Me.BancoTextBox.Name = "BancoTextBox"
        Me.BancoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BancoTextBox.TabIndex = 4
        '
        'frmbancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 165)
        Me.Controls.Add(CodigoBancoLabel)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(BancoLabel)
        Me.Controls.Add(Me.BancoTextBox)
        Me.Controls.Add(Me.BancosBindingNavigator)
        Me.Name = "frmbancos"
        Me.Text = "bancos"
        CType(Me.BDbancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BancosBindingNavigator.ResumeLayout(False)
        Me.BancosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BDbancoDataSet As _60.BDbancoDataSet
    Friend WithEvents BancosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancosTableAdapter As _60.BDbancoDataSetTableAdapters.bancosTableAdapter
    Friend WithEvents TableAdapterManager As _60.BDbancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BancosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BancosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents BancoTextBox As System.Windows.Forms.TextBox
End Class
