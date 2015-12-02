<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim NIBLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim AgenciaLabel As System.Windows.Forms.Label
        Dim DataAberturaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperacoesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EleminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerirBancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍrParaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BDbancoDataSet = New _60.BDbancoDataSet()
        Me.ContasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContasTableAdapter = New _60.BDbancoDataSetTableAdapters.ContasTableAdapter()
        Me.TableAdapterManager = New _60.BDbancoDataSetTableAdapters.TableAdapterManager()
        Me.BancosTableAdapter = New _60.BDbancoDataSetTableAdapters.bancosTableAdapter()
        Me.MovimentosTableAdapter = New _60.BDbancoDataSetTableAdapters.MovimentosTableAdapter()
        Me.ContasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ContasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.NIBTextBox = New System.Windows.Forms.TextBox()
        Me.BancoComboBox = New System.Windows.Forms.ComboBox()
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgenciaTextBox = New System.Windows.Forms.TextBox()
        Me.DataAberturaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MovimentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovimentosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodigoLabel = New System.Windows.Forms.Label()
        NIBLabel = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        AgenciaLabel = New System.Windows.Forms.Label()
        DataAberturaLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BDbancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContasBindingNavigator.SuspendLayout()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(61, 84)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 12
        CodigoLabel.Text = "Codigo:"
        '
        'NIBLabel
        '
        NIBLabel.AutoSize = True
        NIBLabel.Location = New System.Drawing.Point(61, 110)
        NIBLabel.Name = "NIBLabel"
        NIBLabel.Size = New System.Drawing.Size(28, 13)
        NIBLabel.TabIndex = 14
        NIBLabel.Text = "NIB:"
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.Location = New System.Drawing.Point(61, 136)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(41, 13)
        BancoLabel.TabIndex = 16
        BancoLabel.Text = "Banco:"
        '
        'AgenciaLabel
        '
        AgenciaLabel.AutoSize = True
        AgenciaLabel.Location = New System.Drawing.Point(61, 163)
        AgenciaLabel.Name = "AgenciaLabel"
        AgenciaLabel.Size = New System.Drawing.Size(49, 13)
        AgenciaLabel.TabIndex = 18
        AgenciaLabel.Text = "Agencia:"
        '
        'DataAberturaLabel
        '
        DataAberturaLabel.AutoSize = True
        DataAberturaLabel.Location = New System.Drawing.Point(61, 190)
        DataAberturaLabel.Name = "DataAberturaLabel"
        DataAberturaLabel.Size = New System.Drawing.Size(76, 13)
        DataAberturaLabel.TabIndex = 20
        DataAberturaLabel.Text = "Data Abertura:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacoesToolStripMenuItem, Me.ContasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(428, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperacoesToolStripMenuItem
        '
        Me.OperacoesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaContaToolStripMenuItem, Me.ToolStripMenuItem1, Me.GuardarToolStripMenuItem, Me.EleminarToolStripMenuItem, Me.GerirBancosToolStripMenuItem, Me.ToolStripMenuItem2, Me.SairToolStripMenuItem})
        Me.OperacoesToolStripMenuItem.Name = "OperacoesToolStripMenuItem"
        Me.OperacoesToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.OperacoesToolStripMenuItem.Text = "Operacoes"
        '
        'NovaContaToolStripMenuItem
        '
        Me.NovaContaToolStripMenuItem.Name = "NovaContaToolStripMenuItem"
        Me.NovaContaToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.NovaContaToolStripMenuItem.Text = "nova conta"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(141, 6)
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.GuardarToolStripMenuItem.Text = "guardar"
        '
        'EleminarToolStripMenuItem
        '
        Me.EleminarToolStripMenuItem.Name = "EleminarToolStripMenuItem"
        Me.EleminarToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EleminarToolStripMenuItem.Text = "eleminar"
        '
        'GerirBancosToolStripMenuItem
        '
        Me.GerirBancosToolStripMenuItem.Name = "GerirBancosToolStripMenuItem"
        Me.GerirBancosToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.GerirBancosToolStripMenuItem.Text = "gerir bancos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(141, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SairToolStripMenuItem.Text = "sair"
        '
        'ContasToolStripMenuItem
        '
        Me.ContasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÍrParaToolStripMenuItem, Me.SaldoToolStripMenuItem})
        Me.ContasToolStripMenuItem.Name = "ContasToolStripMenuItem"
        Me.ContasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ContasToolStripMenuItem.Text = "Contas"
        '
        'ÍrParaToolStripMenuItem
        '
        Me.ÍrParaToolStripMenuItem.Name = "ÍrParaToolStripMenuItem"
        Me.ÍrParaToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ÍrParaToolStripMenuItem.Text = "Ir para..."
        '
        'SaldoToolStripMenuItem
        '
        Me.SaldoToolStripMenuItem.Name = "SaldoToolStripMenuItem"
        Me.SaldoToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SaldoToolStripMenuItem.Text = "saldo"
        '
        'BDbancoDataSet
        '
        Me.BDbancoDataSet.DataSetName = "BDbancoDataSet"
        Me.BDbancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContasBindingSource
        '
        Me.ContasBindingSource.DataMember = "Contas"
        Me.ContasBindingSource.DataSource = Me.BDbancoDataSet
        '
        'ContasTableAdapter
        '
        Me.ContasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bancosTableAdapter = Me.BancosTableAdapter
        Me.TableAdapterManager.ContasTableAdapter = Me.ContasTableAdapter
        Me.TableAdapterManager.MovimentosTableAdapter = Me.MovimentosTableAdapter
        Me.TableAdapterManager.UpdateOrder = _60.BDbancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BancosTableAdapter
        '
        Me.BancosTableAdapter.ClearBeforeFill = True
        '
        'MovimentosTableAdapter
        '
        Me.MovimentosTableAdapter.ClearBeforeFill = True
        '
        'ContasBindingNavigator
        '
        Me.ContasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ContasBindingNavigator.BindingSource = Me.ContasBindingSource
        Me.ContasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ContasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ContasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ContasBindingNavigatorSaveItem})
        Me.ContasBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.ContasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ContasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ContasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ContasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ContasBindingNavigator.Name = "ContasBindingNavigator"
        Me.ContasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ContasBindingNavigator.Size = New System.Drawing.Size(428, 25)
        Me.ContasBindingNavigator.TabIndex = 12
        Me.ContasBindingNavigator.Text = "BindingNavigator1"
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
        'ContasBindingNavigatorSaveItem
        '
        Me.ContasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ContasBindingNavigatorSaveItem.Image = CType(resources.GetObject("ContasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ContasBindingNavigatorSaveItem.Name = "ContasBindingNavigatorSaveItem"
        Me.ContasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ContasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtcodigo
        '
        Me.txtcodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContasBindingSource, "Codigo", True))
        Me.txtcodigo.Location = New System.Drawing.Point(143, 81)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(200, 20)
        Me.txtcodigo.TabIndex = 13
        '
        'NIBTextBox
        '
        Me.NIBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContasBindingSource, "NIB", True))
        Me.NIBTextBox.Location = New System.Drawing.Point(143, 107)
        Me.NIBTextBox.Name = "NIBTextBox"
        Me.NIBTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NIBTextBox.TabIndex = 15
        '
        'BancoComboBox
        '
        Me.BancoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContasBindingSource, "Banco", True))
        Me.BancoComboBox.DataSource = Me.BancosBindingSource
        Me.BancoComboBox.DisplayMember = "Banco"
        Me.BancoComboBox.FormattingEnabled = True
        Me.BancoComboBox.Location = New System.Drawing.Point(143, 133)
        Me.BancoComboBox.Name = "BancoComboBox"
        Me.BancoComboBox.Size = New System.Drawing.Size(200, 21)
        Me.BancoComboBox.TabIndex = 17
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataMember = "bancos"
        Me.BancosBindingSource.DataSource = Me.BDbancoDataSet
        '
        'AgenciaTextBox
        '
        Me.AgenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContasBindingSource, "Agencia", True))
        Me.AgenciaTextBox.Location = New System.Drawing.Point(143, 160)
        Me.AgenciaTextBox.Name = "AgenciaTextBox"
        Me.AgenciaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AgenciaTextBox.TabIndex = 19
        '
        'DataAberturaDateTimePicker
        '
        Me.DataAberturaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ContasBindingSource, "DataAbertura", True))
        Me.DataAberturaDateTimePicker.Location = New System.Drawing.Point(143, 186)
        Me.DataAberturaDateTimePicker.Name = "DataAberturaDateTimePicker"
        Me.DataAberturaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataAberturaDateTimePicker.TabIndex = 21
        '
        'MovimentosBindingSource
        '
        Me.MovimentosBindingSource.DataMember = "Contas_Movimentos"
        Me.MovimentosBindingSource.DataSource = Me.ContasBindingSource
        '
        'MovimentosDataGridView
        '
        Me.MovimentosDataGridView.AutoGenerateColumns = False
        Me.MovimentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MovimentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.MovimentosDataGridView.DataSource = Me.MovimentosBindingSource
        Me.MovimentosDataGridView.Location = New System.Drawing.Point(64, 244)
        Me.MovimentosDataGridView.Name = "MovimentosDataGridView"
        Me.MovimentosDataGridView.Size = New System.Drawing.Size(349, 220)
        Me.MovimentosDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Data"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descricao"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 518)
        Me.Controls.Add(Me.MovimentosDataGridView)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(NIBLabel)
        Me.Controls.Add(Me.NIBTextBox)
        Me.Controls.Add(BancoLabel)
        Me.Controls.Add(Me.BancoComboBox)
        Me.Controls.Add(AgenciaLabel)
        Me.Controls.Add(Me.AgenciaTextBox)
        Me.Controls.Add(DataAberturaLabel)
        Me.Controls.Add(Me.DataAberturaDateTimePicker)
        Me.Controls.Add(Me.ContasBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "contas & movimentos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BDbancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContasBindingNavigator.ResumeLayout(False)
        Me.ContasBindingNavigator.PerformLayout()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OperacoesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovaContaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EleminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GerirBancosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÍrParaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaldoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BDbancoDataSet As _60.BDbancoDataSet
    Friend WithEvents ContasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContasTableAdapter As _60.BDbancoDataSetTableAdapters.ContasTableAdapter
    Friend WithEvents TableAdapterManager As _60.BDbancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ContasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MovimentosTableAdapter As _60.BDbancoDataSetTableAdapters.MovimentosTableAdapter
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents NIBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BancoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AgenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataAberturaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MovimentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancosTableAdapter As _60.BDbancoDataSetTableAdapters.bancosTableAdapter
    Friend WithEvents MovimentosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancosBindingSource As System.Windows.Forms.BindingSource

End Class
