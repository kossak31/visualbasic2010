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
        Dim IdLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim NimLabel As System.Windows.Forms.Label
        Dim Companhia_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CompanhiaLabel As System.Windows.Forms.Label
        Me.BDctcDataSet1 = New ctc.BDctcDataSet()
        Me.NimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NimTableAdapter = New ctc.BDctcDataSetTableAdapters.nimTableAdapter()
        Me.TableAdapterManager1 = New ctc.BDctcDataSetTableAdapters.TableAdapterManager()
        Me.CompanhiaTableAdapter1 = New ctc.BDctcDataSetTableAdapters.companhiaTableAdapter()
        Me.NimBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NimBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.NimTextBox = New System.Windows.Forms.TextBox()
        Me.CompanhiaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NimDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NimcompanhiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Companhia_idTextBox = New System.Windows.Forms.TextBox()
        Me.NimcompanhiaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NimcompanhiaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanhiaComboBox = New System.Windows.Forms.ComboBox()
        Me.NimcompanhiaBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NimBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        IdLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        NimLabel = New System.Windows.Forms.Label()
        Companhia_idLabel = New System.Windows.Forms.Label()
        CompanhiaLabel = New System.Windows.Forms.Label()
        CType(Me.BDctcDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NimBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NimBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NimBindingNavigator.SuspendLayout()
        CType(Me.CompanhiaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NimDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NimcompanhiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NimcompanhiaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NimcompanhiaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NimcompanhiaBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NimBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(151, 94)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(151, 120)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(36, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "nome:"
        '
        'NimLabel
        '
        NimLabel.AutoSize = True
        NimLabel.Location = New System.Drawing.Point(151, 146)
        NimLabel.Name = "NimLabel"
        NimLabel.Size = New System.Drawing.Size(26, 13)
        NimLabel.TabIndex = 5
        NimLabel.Text = "nim:"
        '
        'Companhia_idLabel
        '
        Companhia_idLabel.AutoSize = True
        Companhia_idLabel.Location = New System.Drawing.Point(139, 208)
        Companhia_idLabel.Name = "Companhia_idLabel"
        Companhia_idLabel.Size = New System.Drawing.Size(73, 13)
        Companhia_idLabel.TabIndex = 10
        Companhia_idLabel.Text = "companhia id:"
        '
        'BDctcDataSet1
        '
        Me.BDctcDataSet1.DataSetName = "BDctcDataSet"
        Me.BDctcDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NimBindingSource
        '
        Me.NimBindingSource.DataMember = "nim"
        Me.NimBindingSource.DataSource = Me.BDctcDataSet1
        '
        'NimTableAdapter
        '
        Me.NimTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.companhiaTableAdapter = Me.CompanhiaTableAdapter1
        Me.TableAdapterManager1.nimTableAdapter = Me.NimTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ctc.BDctcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompanhiaTableAdapter1
        '
        Me.CompanhiaTableAdapter1.ClearBeforeFill = True
        '
        'NimBindingNavigator
        '
        Me.NimBindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.NimBindingNavigator.BindingSource = Me.NimBindingSource
        Me.NimBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.NimBindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.NimBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.NimBindingNavigatorSaveItem})
        Me.NimBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NimBindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.NimBindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.NimBindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.NimBindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.NimBindingNavigator.Name = "NimBindingNavigator"
        Me.NimBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.NimBindingNavigator.Size = New System.Drawing.Size(527, 25)
        Me.NimBindingNavigator.TabIndex = 0
        Me.NimBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Add new"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Delete"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'NimBindingNavigatorSaveItem
        '
        Me.NimBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NimBindingNavigatorSaveItem.Image = CType(resources.GetObject("NimBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NimBindingNavigatorSaveItem.Name = "NimBindingNavigatorSaveItem"
        Me.NimBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.NimBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NimBindingSource, "id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(230, 91)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox1.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NimBindingSource, "nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(230, 117)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'NimTextBox
        '
        Me.NimTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NimBindingSource, "nim", True))
        Me.NimTextBox.Location = New System.Drawing.Point(230, 143)
        Me.NimTextBox.Name = "NimTextBox"
        Me.NimTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NimTextBox.TabIndex = 6
        '
        'CompanhiaBindingSource1
        '
        Me.CompanhiaBindingSource1.DataMember = "companhia"
        Me.CompanhiaBindingSource1.DataSource = Me.BDctcDataSet1
        '
        'NimDataGridView
        '
        Me.NimDataGridView.AutoGenerateColumns = False
        Me.NimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NimDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.NimDataGridView.DataSource = Me.NimBindingSource
        Me.NimDataGridView.Location = New System.Drawing.Point(91, 231)
        Me.NimDataGridView.Name = "NimDataGridView"
        Me.NimDataGridView.Size = New System.Drawing.Size(416, 220)
        Me.NimDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn6.HeaderText = "nome"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "nim"
        Me.DataGridViewTextBoxColumn7.HeaderText = "nim"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "companhia_id"
        Me.DataGridViewTextBoxColumn8.HeaderText = "companhia_id"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'NimcompanhiaBindingSource
        '
        Me.NimcompanhiaBindingSource.DataMember = "nim_companhia"
        Me.NimcompanhiaBindingSource.DataSource = Me.NimBindingSource
        '
        'Companhia_idTextBox
        '
        Me.Companhia_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NimBindingSource, "companhia_id", True))
        Me.Companhia_idTextBox.Location = New System.Drawing.Point(218, 205)
        Me.Companhia_idTextBox.Name = "Companhia_idTextBox"
        Me.Companhia_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Companhia_idTextBox.TabIndex = 11
        '
        'NimcompanhiaBindingSource1
        '
        Me.NimcompanhiaBindingSource1.DataMember = "nim_companhia"
        Me.NimcompanhiaBindingSource1.DataSource = Me.NimBindingSource
        '
        'NimcompanhiaBindingSource2
        '
        Me.NimcompanhiaBindingSource2.DataMember = "nim_companhia"
        Me.NimcompanhiaBindingSource2.DataSource = Me.NimBindingSource
        '
        'CompanhiaLabel
        '
        CompanhiaLabel.AutoSize = True
        CompanhiaLabel.Location = New System.Drawing.Point(141, 181)
        CompanhiaLabel.Name = "CompanhiaLabel"
        CompanhiaLabel.Size = New System.Drawing.Size(62, 13)
        CompanhiaLabel.TabIndex = 11
        CompanhiaLabel.Text = "companhia:"
        '
        'CompanhiaComboBox
        '
        Me.CompanhiaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompanhiaBindingSource1, "companhia", True))
        Me.CompanhiaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NimcompanhiaBindingSource, "tipo", True))
        Me.CompanhiaComboBox.DataSource = Me.NimBindingSource1
        Me.CompanhiaComboBox.DisplayMember = "companhia_id"
        Me.CompanhiaComboBox.FormattingEnabled = True
        Me.CompanhiaComboBox.Location = New System.Drawing.Point(209, 178)
        Me.CompanhiaComboBox.Name = "CompanhiaComboBox"
        Me.CompanhiaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CompanhiaComboBox.TabIndex = 12
        '
        'NimcompanhiaBindingSource3
        '
        Me.NimcompanhiaBindingSource3.DataMember = "nim_companhia"
        Me.NimcompanhiaBindingSource3.DataSource = Me.NimBindingSource
        '
        'NimBindingSource1
        '
        Me.NimBindingSource1.DataMember = "nim"
        Me.NimBindingSource1.DataSource = Me.BDctcDataSet1
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(527, 471)
        Me.Controls.Add(CompanhiaLabel)
        Me.Controls.Add(Me.CompanhiaComboBox)
        Me.Controls.Add(Companhia_idLabel)
        Me.Controls.Add(Me.Companhia_idTextBox)
        Me.Controls.Add(Me.NimDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(NimLabel)
        Me.Controls.Add(Me.NimTextBox)
        Me.Controls.Add(Me.NimBindingNavigator)
        Me.Name = "Form1"
        CType(Me.BDctcDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NimBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NimBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NimBindingNavigator.ResumeLayout(False)
        Me.NimBindingNavigator.PerformLayout()
        CType(Me.CompanhiaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NimDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NimcompanhiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NimcompanhiaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NimcompanhiaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NimcompanhiaBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NimBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BDctcDataSet As ctc.BDctcDataSet
    Friend WithEvents CompanhiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanhiaTableAdapter As ctc.BDctcDataSetTableAdapters.companhiaTableAdapter
    Friend WithEvents TableAdapterManager As ctc.BDctcDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CompanhiaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CompanhiaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanhiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanhiaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDctcDataSet1 As ctc.BDctcDataSet
    Friend WithEvents NimBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NimTableAdapter As ctc.BDctcDataSetTableAdapters.nimTableAdapter
    Friend WithEvents TableAdapterManager1 As ctc.BDctcDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NimBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NimBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CompanhiaTableAdapter1 As ctc.BDctcDataSetTableAdapters.companhiaTableAdapter
    Friend WithEvents IdTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NimTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanhiaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NimDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NimcompanhiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Companhia_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NimcompanhiaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NimcompanhiaBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CompanhiaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NimBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NimcompanhiaBindingSource3 As System.Windows.Forms.BindingSource

End Class
