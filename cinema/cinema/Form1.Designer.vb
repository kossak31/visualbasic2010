<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim NomeLabel As System.Windows.Forms.Label
        Me.BdbilhetesbetaDataSet = New cinema.bdbilhetesbetaDataSet()
        Me.BilheteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BilheteTableAdapter = New cinema.bdbilhetesbetaDataSetTableAdapters.BilheteTableAdapter()
        Me.TableAdapterManager = New cinema.bdbilhetesbetaDataSetTableAdapters.TableAdapterManager()
        Me.BilheteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BilheteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NomeListBox = New System.Windows.Forms.ListBox()
        NomeLabel = New System.Windows.Forms.Label()
        CType(Me.BdbilhetesbetaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilheteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BilheteBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BdbilhetesbetaDataSet
        '
        Me.BdbilhetesbetaDataSet.DataSetName = "bdbilhetesbetaDataSet"
        Me.BdbilhetesbetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BilheteBindingSource
        '
        Me.BilheteBindingSource.DataMember = "Bilhete"
        Me.BilheteBindingSource.DataSource = Me.BdbilhetesbetaDataSet
        '
        'BilheteTableAdapter
        '
        Me.BilheteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BilheteTableAdapter = Me.BilheteTableAdapter
        Me.TableAdapterManager.UpdateOrder = cinema.bdbilhetesbetaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilizadorTableAdapter = Nothing
        '
        'BilheteBindingNavigator
        '
        Me.BilheteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BilheteBindingNavigator.BindingSource = Me.BilheteBindingSource
        Me.BilheteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BilheteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BilheteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BilheteBindingNavigatorSaveItem})
        Me.BilheteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BilheteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BilheteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BilheteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BilheteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BilheteBindingNavigator.Name = "BilheteBindingNavigator"
        Me.BilheteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BilheteBindingNavigator.Size = New System.Drawing.Size(604, 25)
        Me.BilheteBindingNavigator.TabIndex = 0
        Me.BilheteBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BilheteBindingNavigatorSaveItem
        '
        Me.BilheteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BilheteBindingNavigatorSaveItem.Image = CType(resources.GetObject("BilheteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BilheteBindingNavigatorSaveItem.Name = "BilheteBindingNavigatorSaveItem"
        Me.BilheteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.BilheteBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(422, 102)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(36, 13)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "nome:"
        '
        'NomeListBox
        '
        Me.NomeListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BilheteBindingSource, "nome", True))
        Me.NomeListBox.DataSource = Me.BilheteBindingSource
        Me.NomeListBox.DisplayMember = "nome"
        Me.NomeListBox.FormattingEnabled = True
        Me.NomeListBox.Location = New System.Drawing.Point(464, 102)
        Me.NomeListBox.Name = "NomeListBox"
        Me.NomeListBox.Size = New System.Drawing.Size(120, 95)
        Me.NomeListBox.TabIndex = 2
        Me.NomeListBox.ValueMember = "ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 328)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeListBox)
        Me.Controls.Add(Me.BilheteBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BdbilhetesbetaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilheteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BilheteBindingNavigator.ResumeLayout(False)
        Me.BilheteBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BdbilhetesbetaDataSet As cinema.bdbilhetesbetaDataSet
    Friend WithEvents BilheteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BilheteTableAdapter As cinema.bdbilhetesbetaDataSetTableAdapters.BilheteTableAdapter
    Friend WithEvents TableAdapterManager As cinema.bdbilhetesbetaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BilheteBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BilheteBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NomeListBox As System.Windows.Forms.ListBox
End Class
