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
        Dim IDSuporteLabel As System.Windows.Forms.Label
        Dim DataEntradaLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim SuporteLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim NotaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BdDataSet = New _61.bdDataSet()
        Me.SuporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuporteTableAdapter = New _61.bdDataSetTableAdapters.suporteTableAdapter()
        Me.TableAdapterManager = New _61.bdDataSetTableAdapters.TableAdapterManager()
        Me.TipoConteudoTableAdapter = New _61.bdDataSetTableAdapters.TipoConteudoTableAdapter()
        Me.TipoSuporteTableAdapter = New _61.bdDataSetTableAdapters.TipoSuporteTableAdapter()
        Me.SuporteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SuporteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDSuporteTextBox = New System.Windows.Forms.TextBox()
        Me.DataEntradaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.SuporteComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoSuporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneroComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoConteudoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotaTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EleminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConteudoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConteudoTableAdapter = New _61.bdDataSetTableAdapters.ConteudoTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuporteConteudoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConteudoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuporteConteudoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        IDSuporteLabel = New System.Windows.Forms.Label()
        DataEntradaLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        SuporteLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        NotaLabel = New System.Windows.Forms.Label()
        CType(Me.BdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuporteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuporteBindingNavigator.SuspendLayout()
        CType(Me.TipoSuporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoConteudoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ConteudoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuporteConteudoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConteudoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuporteConteudoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDSuporteLabel
        '
        IDSuporteLabel.AutoSize = True
        IDSuporteLabel.Location = New System.Drawing.Point(21, 63)
        IDSuporteLabel.Name = "IDSuporteLabel"
        IDSuporteLabel.Size = New System.Drawing.Size(58, 13)
        IDSuporteLabel.TabIndex = 1
        IDSuporteLabel.Text = "IDSuporte:"
        '
        'DataEntradaLabel
        '
        DataEntradaLabel.AutoSize = True
        DataEntradaLabel.Location = New System.Drawing.Point(21, 90)
        DataEntradaLabel.Name = "DataEntradaLabel"
        DataEntradaLabel.Size = New System.Drawing.Size(73, 13)
        DataEntradaLabel.TabIndex = 3
        DataEntradaLabel.Text = "Data Entrada:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(21, 115)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(58, 13)
        DescricaoLabel.TabIndex = 5
        DescricaoLabel.Text = "Descricao:"
        '
        'SuporteLabel
        '
        SuporteLabel.AutoSize = True
        SuporteLabel.Location = New System.Drawing.Point(21, 141)
        SuporteLabel.Name = "SuporteLabel"
        SuporteLabel.Size = New System.Drawing.Size(47, 13)
        SuporteLabel.TabIndex = 7
        SuporteLabel.Text = "Suporte:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(21, 168)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(45, 13)
        GeneroLabel.TabIndex = 9
        GeneroLabel.Text = "Genero:"
        '
        'NotaLabel
        '
        NotaLabel.AutoSize = True
        NotaLabel.Location = New System.Drawing.Point(21, 195)
        NotaLabel.Name = "NotaLabel"
        NotaLabel.Size = New System.Drawing.Size(31, 13)
        NotaLabel.TabIndex = 11
        NotaLabel.Text = "nota:"
        '
        'BdDataSet
        '
        Me.BdDataSet.DataSetName = "bdDataSet"
        Me.BdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuporteBindingSource
        '
        Me.SuporteBindingSource.DataMember = "suporte"
        Me.SuporteBindingSource.DataSource = Me.BdDataSet
        '
        'SuporteTableAdapter
        '
        Me.SuporteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConteudoTableAdapter = Nothing
        Me.TableAdapterManager.suporteTableAdapter = Me.SuporteTableAdapter
        Me.TableAdapterManager.TipoConteudoTableAdapter = Me.TipoConteudoTableAdapter
        Me.TableAdapterManager.TipoSuporteTableAdapter = Me.TipoSuporteTableAdapter
        Me.TableAdapterManager.UpdateOrder = _61.bdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TipoConteudoTableAdapter
        '
        Me.TipoConteudoTableAdapter.ClearBeforeFill = True
        '
        'TipoSuporteTableAdapter
        '
        Me.TipoSuporteTableAdapter.ClearBeforeFill = True
        '
        'SuporteBindingNavigator
        '
        Me.SuporteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SuporteBindingNavigator.BindingSource = Me.SuporteBindingSource
        Me.SuporteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SuporteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SuporteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SuporteBindingNavigatorSaveItem})
        Me.SuporteBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.SuporteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SuporteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SuporteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SuporteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SuporteBindingNavigator.Name = "SuporteBindingNavigator"
        Me.SuporteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SuporteBindingNavigator.Size = New System.Drawing.Size(520, 25)
        Me.SuporteBindingNavigator.TabIndex = 0
        Me.SuporteBindingNavigator.Text = "BindingNavigator1"
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
        'SuporteBindingNavigatorSaveItem
        '
        Me.SuporteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SuporteBindingNavigatorSaveItem.Image = CType(resources.GetObject("SuporteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SuporteBindingNavigatorSaveItem.Name = "SuporteBindingNavigatorSaveItem"
        Me.SuporteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SuporteBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDSuporteTextBox
        '
        Me.IDSuporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuporteBindingSource, "IDSuporte", True))
        Me.IDSuporteTextBox.Location = New System.Drawing.Point(100, 60)
        Me.IDSuporteTextBox.Name = "IDSuporteTextBox"
        Me.IDSuporteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDSuporteTextBox.TabIndex = 2
        '
        'DataEntradaDateTimePicker
        '
        Me.DataEntradaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SuporteBindingSource, "DataEntrada", True))
        Me.DataEntradaDateTimePicker.Location = New System.Drawing.Point(100, 86)
        Me.DataEntradaDateTimePicker.Name = "DataEntradaDateTimePicker"
        Me.DataEntradaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataEntradaDateTimePicker.TabIndex = 4
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuporteBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(100, 112)
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescricaoTextBox.TabIndex = 6
        '
        'SuporteComboBox
        '
        Me.SuporteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuporteBindingSource, "Suporte", True))
        Me.SuporteComboBox.DataSource = Me.TipoSuporteBindingSource
        Me.SuporteComboBox.DisplayMember = "TipoSuporte"
        Me.SuporteComboBox.FormattingEnabled = True
        Me.SuporteComboBox.Location = New System.Drawing.Point(100, 138)
        Me.SuporteComboBox.Name = "SuporteComboBox"
        Me.SuporteComboBox.Size = New System.Drawing.Size(200, 21)
        Me.SuporteComboBox.TabIndex = 8
        '
        'TipoSuporteBindingSource
        '
        Me.TipoSuporteBindingSource.DataMember = "TipoSuporte"
        Me.TipoSuporteBindingSource.DataSource = Me.BdDataSet
        '
        'GeneroComboBox
        '
        Me.GeneroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuporteBindingSource, "Genero", True))
        Me.GeneroComboBox.DataSource = Me.TipoConteudoBindingSource
        Me.GeneroComboBox.DisplayMember = "TipoConteudo"
        Me.GeneroComboBox.FormattingEnabled = True
        Me.GeneroComboBox.Location = New System.Drawing.Point(100, 165)
        Me.GeneroComboBox.Name = "GeneroComboBox"
        Me.GeneroComboBox.Size = New System.Drawing.Size(200, 21)
        Me.GeneroComboBox.TabIndex = 10
        '
        'TipoConteudoBindingSource
        '
        Me.TipoConteudoBindingSource.DataMember = "TipoConteudo"
        Me.TipoConteudoBindingSource.DataSource = Me.BdDataSet
        '
        'NotaTextBox
        '
        Me.NotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuporteBindingSource, "nota", True))
        Me.NotaTextBox.Location = New System.Drawing.Point(100, 192)
        Me.NotaTextBox.Name = "NotaTextBox"
        Me.NotaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NotaTextBox.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ProcurarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(520, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.AnularToolStripMenuItem, Me.EleminarToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NovoToolStripMenuItem.Text = "novo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.GuardarToolStripMenuItem.Text = "guardar"
        '
        'AnularToolStripMenuItem
        '
        Me.AnularToolStripMenuItem.Name = "AnularToolStripMenuItem"
        Me.AnularToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AnularToolStripMenuItem.Text = "anular"
        '
        'EleminarToolStripMenuItem
        '
        Me.EleminarToolStripMenuItem.Name = "EleminarToolStripMenuItem"
        Me.EleminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EleminarToolStripMenuItem.Text = "eleminar"
        '
        'ProcurarToolStripMenuItem
        '
        Me.ProcurarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodosToolStripMenuItem, Me.SuporteToolStripMenuItem, Me.GeneroToolStripMenuItem, Me.MostrarListaToolStripMenuItem})
        Me.ProcurarToolStripMenuItem.Name = "ProcurarToolStripMenuItem"
        Me.ProcurarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ProcurarToolStripMenuItem.Text = "Procurar"
        '
        'TodosToolStripMenuItem
        '
        Me.TodosToolStripMenuItem.Name = "TodosToolStripMenuItem"
        Me.TodosToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.TodosToolStripMenuItem.Text = "Todos"
        '
        'SuporteToolStripMenuItem
        '
        Me.SuporteToolStripMenuItem.Name = "SuporteToolStripMenuItem"
        Me.SuporteToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SuporteToolStripMenuItem.Text = "Suporte"
        '
        'GeneroToolStripMenuItem
        '
        Me.GeneroToolStripMenuItem.Name = "GeneroToolStripMenuItem"
        Me.GeneroToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.GeneroToolStripMenuItem.Text = "Genero"
        '
        'MostrarListaToolStripMenuItem
        '
        Me.MostrarListaToolStripMenuItem.Name = "MostrarListaToolStripMenuItem"
        Me.MostrarListaToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.MostrarListaToolStripMenuItem.Text = "Mostrar Lista"
        '
        'ConteudoBindingSource
        '
        Me.ConteudoBindingSource.DataMember = "suporte_Conteudo"
        Me.ConteudoBindingSource.DataSource = Me.SuporteBindingSource
        '
        'ConteudoTableAdapter
        '
        Me.ConteudoTableAdapter.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.SuporteBindingSource
        Me.ListBox1.DisplayMember = "Descricao"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(350, 59)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(150, 407)
        Me.ListBox1.TabIndex = 15
        '
        'SuporteConteudoBindingSource
        '
        Me.SuporteConteudoBindingSource.DataMember = "suporte_Conteudo"
        Me.SuporteConteudoBindingSource.DataSource = Me.SuporteBindingSource
        '
        'ConteudoDataGridView
        '
        Me.ConteudoDataGridView.AutoGenerateColumns = False
        Me.ConteudoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConteudoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ConteudoDataGridView.DataSource = Me.SuporteConteudoBindingSource1
        Me.ConteudoDataGridView.Location = New System.Drawing.Point(12, 246)
        Me.ConteudoDataGridView.Name = "ConteudoDataGridView"
        Me.ConteudoDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ConteudoDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDSuporte"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDSuporte"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descricao"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'SuporteConteudoBindingSource1
        '
        Me.SuporteConteudoBindingSource1.DataMember = "suporte_Conteudo"
        Me.SuporteConteudoBindingSource1.DataSource = Me.SuporteBindingSource
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 549)
        Me.Controls.Add(Me.ConteudoDataGridView)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(IDSuporteLabel)
        Me.Controls.Add(Me.IDSuporteTextBox)
        Me.Controls.Add(DataEntradaLabel)
        Me.Controls.Add(Me.DataEntradaDateTimePicker)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(SuporteLabel)
        Me.Controls.Add(Me.SuporteComboBox)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(Me.GeneroComboBox)
        Me.Controls.Add(NotaLabel)
        Me.Controls.Add(Me.NotaTextBox)
        Me.Controls.Add(Me.SuporteBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuporteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuporteBindingNavigator.ResumeLayout(False)
        Me.SuporteBindingNavigator.PerformLayout()
        CType(Me.TipoSuporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoConteudoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ConteudoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuporteConteudoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConteudoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuporteConteudoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BdDataSet As _61.bdDataSet
    Friend WithEvents SuporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuporteTableAdapter As _61.bdDataSetTableAdapters.suporteTableAdapter
    Friend WithEvents TableAdapterManager As _61.bdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SuporteBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SuporteBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDSuporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataEntradaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DescricaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SuporteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GeneroComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoSuporteTableAdapter As _61.bdDataSetTableAdapters.TipoSuporteTableAdapter
    Friend WithEvents TipoSuporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoConteudoTableAdapter As _61.bdDataSetTableAdapters.TipoConteudoTableAdapter
    Friend WithEvents TipoConteudoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EleminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MostrarListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConteudoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConteudoTableAdapter As _61.bdDataSetTableAdapters.ConteudoTableAdapter
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents SuporteConteudoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConteudoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuporteConteudoBindingSource1 As System.Windows.Forms.BindingSource

End Class
