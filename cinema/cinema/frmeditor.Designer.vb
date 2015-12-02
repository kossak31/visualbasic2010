<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmeditor
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CompanhiaLabel As System.Windows.Forms.Label
        Dim HoraLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim SalaLabel As System.Windows.Forms.Label
        Dim LugarnumeroLabel As System.Windows.Forms.Label
        Dim EntradaLabel As System.Windows.Forms.Label
        Dim FestivalLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim SpotLabel As System.Windows.Forms.Label
        Dim DireccaoLabel As System.Windows.Forms.Label
        Dim UtilizadoridLabel As System.Windows.Forms.Label
        Dim NotasLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim LugarletraLabel As System.Windows.Forms.Label
        Dim CriticaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmeditor))
        Dim NomeLabel1 As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim CriticaLabel1 As System.Windows.Forms.Label
        Dim DataLabel1 As System.Windows.Forms.Label
        Me.BdbilhetesbetaDataSet = New cinema.bdbilhetesbetaDataSet()
        Me.BilheteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BilheteTableAdapter = New cinema.bdbilhetesbetaDataSetTableAdapters.BilheteTableAdapter()
        Me.TableAdapterManager = New cinema.bdbilhetesbetaDataSetTableAdapters.TableAdapterManager()
        Me.BilheteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BilheteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.CompanhiaTextBox = New System.Windows.Forms.TextBox()
        Me.HoraComboBox = New System.Windows.Forms.ComboBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.SalaTextBox = New System.Windows.Forms.TextBox()
        Me.LugarnumeroTextBox = New System.Windows.Forms.TextBox()
        Me.EntradaTextBox = New System.Windows.Forms.TextBox()
        Me.FestivalTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.SpotTextBox = New System.Windows.Forms.TextBox()
        Me.DireccaoTextBox = New System.Windows.Forms.TextBox()
        Me.UtilizadoridComboBox = New System.Windows.Forms.ComboBox()
        Me.NotasTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.LugarletraComboBox = New System.Windows.Forms.ComboBox()
        Me.CriticaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.NomeListBox = New System.Windows.Forms.ListBox()
        Me.FillByTeatroToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByTeatroToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CriticaTextBox = New System.Windows.Forms.TextBox()
        Me.DataTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CompanhiaLabel = New System.Windows.Forms.Label()
        HoraLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        SalaLabel = New System.Windows.Forms.Label()
        LugarnumeroLabel = New System.Windows.Forms.Label()
        EntradaLabel = New System.Windows.Forms.Label()
        FestivalLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        SpotLabel = New System.Windows.Forms.Label()
        DireccaoLabel = New System.Windows.Forms.Label()
        UtilizadoridLabel = New System.Windows.Forms.Label()
        NotasLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        LugarletraLabel = New System.Windows.Forms.Label()
        CriticaLabel = New System.Windows.Forms.Label()
        NomeLabel1 = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        CriticaLabel1 = New System.Windows.Forms.Label()
        DataLabel1 = New System.Windows.Forms.Label()
        CType(Me.BdbilhetesbetaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilheteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BilheteBindingNavigator.SuspendLayout()
        CType(Me.CriticaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.FillByTeatroToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(27, 55)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(25, 25)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(54, 13)
        CategoriaLabel.TabIndex = 3
        CategoriaLabel.Text = "categoria:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(25, 52)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(36, 13)
        NomeLabel.TabIndex = 5
        NomeLabel.Text = "nome:"
        '
        'CompanhiaLabel
        '
        CompanhiaLabel.AutoSize = True
        CompanhiaLabel.Location = New System.Drawing.Point(25, 78)
        CompanhiaLabel.Name = "CompanhiaLabel"
        CompanhiaLabel.Size = New System.Drawing.Size(62, 13)
        CompanhiaLabel.TabIndex = 7
        CompanhiaLabel.Text = "companhia:"
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.Location = New System.Drawing.Point(25, 130)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(31, 13)
        HoraLabel.TabIndex = 11
        HoraLabel.Text = "hora:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(6, 22)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(29, 13)
        PaisLabel.TabIndex = 13
        PaisLabel.Text = "pais:"
        '
        'SalaLabel
        '
        SalaLabel.AutoSize = True
        SalaLabel.Location = New System.Drawing.Point(14, 23)
        SalaLabel.Name = "SalaLabel"
        SalaLabel.Size = New System.Drawing.Size(29, 13)
        SalaLabel.TabIndex = 15
        SalaLabel.Text = "sala:"
        '
        'LugarnumeroLabel
        '
        LugarnumeroLabel.AutoSize = True
        LugarnumeroLabel.Location = New System.Drawing.Point(14, 49)
        LugarnumeroLabel.Name = "LugarnumeroLabel"
        LugarnumeroLabel.Size = New System.Drawing.Size(68, 13)
        LugarnumeroLabel.TabIndex = 17
        LugarnumeroLabel.Text = "lugarnumero:"
        '
        'EntradaLabel
        '
        EntradaLabel.AutoSize = True
        EntradaLabel.Location = New System.Drawing.Point(14, 75)
        EntradaLabel.Name = "EntradaLabel"
        EntradaLabel.Size = New System.Drawing.Size(46, 13)
        EntradaLabel.TabIndex = 19
        EntradaLabel.Text = "entrada:"
        '
        'FestivalLabel
        '
        FestivalLabel.AutoSize = True
        FestivalLabel.Location = New System.Drawing.Point(25, 157)
        FestivalLabel.Name = "FestivalLabel"
        FestivalLabel.Size = New System.Drawing.Size(43, 13)
        FestivalLabel.TabIndex = 21
        FestivalLabel.Text = "festival:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(6, 48)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(42, 13)
        CidadeLabel.TabIndex = 23
        CidadeLabel.Text = "cidade:"
        '
        'SpotLabel
        '
        SpotLabel.AutoSize = True
        SpotLabel.Location = New System.Drawing.Point(6, 74)
        SpotLabel.Name = "SpotLabel"
        SpotLabel.Size = New System.Drawing.Size(30, 13)
        SpotLabel.TabIndex = 25
        SpotLabel.Text = "spot:"
        '
        'DireccaoLabel
        '
        DireccaoLabel.AutoSize = True
        DireccaoLabel.Location = New System.Drawing.Point(327, 22)
        DireccaoLabel.Name = "DireccaoLabel"
        DireccaoLabel.Size = New System.Drawing.Size(51, 13)
        DireccaoLabel.TabIndex = 27
        DireccaoLabel.Text = "direccao:"
        '
        'UtilizadoridLabel
        '
        UtilizadoridLabel.AutoSize = True
        UtilizadoridLabel.Location = New System.Drawing.Point(390, 52)
        UtilizadoridLabel.Name = "UtilizadoridLabel"
        UtilizadoridLabel.Size = New System.Drawing.Size(59, 13)
        UtilizadoridLabel.TabIndex = 29
        UtilizadoridLabel.Text = "utilizadorid:"
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.Location = New System.Drawing.Point(6, 29)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(36, 13)
        NotasLabel.TabIndex = 31
        NotasLabel.Text = "notas:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(15, 107)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(33, 13)
        ValorLabel.TabIndex = 33
        ValorLabel.Text = "valor:"
        '
        'LugarletraLabel
        '
        LugarletraLabel.AutoSize = True
        LugarletraLabel.Location = New System.Drawing.Point(15, 133)
        LugarletraLabel.Name = "LugarletraLabel"
        LugarletraLabel.Size = New System.Drawing.Size(53, 13)
        LugarletraLabel.TabIndex = 35
        LugarletraLabel.Text = "lugarletra:"
        '
        'CriticaLabel
        '
        CriticaLabel.AutoSize = True
        CriticaLabel.Location = New System.Drawing.Point(6, 66)
        CriticaLabel.Name = "CriticaLabel"
        CriticaLabel.Size = New System.Drawing.Size(38, 13)
        CriticaLabel.TabIndex = 37
        CriticaLabel.Text = "critica:"
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
        Me.BilheteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BilheteBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.BilheteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BilheteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BilheteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BilheteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BilheteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BilheteBindingNavigator.Name = "BilheteBindingNavigator"
        Me.BilheteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BilheteBindingNavigator.Size = New System.Drawing.Size(1057, 25)
        Me.BilheteBindingNavigator.TabIndex = 0
        Me.BilheteBindingNavigator.Text = "BindingNavigator1"
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
        'BilheteBindingNavigatorSaveItem
        '
        Me.BilheteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BilheteBindingNavigatorSaveItem.Image = CType(resources.GetObject("BilheteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BilheteBindingNavigatorSaveItem.Name = "BilheteBindingNavigatorSaveItem"
        Me.BilheteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BilheteBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(101, 52)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "categoria", True))
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(99, 22)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CategoriaComboBox.TabIndex = 4
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(99, 49)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomeTextBox.TabIndex = 6
        '
        'CompanhiaTextBox
        '
        Me.CompanhiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "companhia", True))
        Me.CompanhiaTextBox.Location = New System.Drawing.Point(99, 75)
        Me.CompanhiaTextBox.Name = "CompanhiaTextBox"
        Me.CompanhiaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CompanhiaTextBox.TabIndex = 8
        '
        'HoraComboBox
        '
        Me.HoraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "hora", True))
        Me.HoraComboBox.FormattingEnabled = True
        Me.HoraComboBox.Location = New System.Drawing.Point(99, 127)
        Me.HoraComboBox.Name = "HoraComboBox"
        Me.HoraComboBox.Size = New System.Drawing.Size(200, 21)
        Me.HoraComboBox.TabIndex = 12
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(80, 19)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PaisTextBox.TabIndex = 14
        '
        'SalaTextBox
        '
        Me.SalaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "sala", True))
        Me.SalaTextBox.Location = New System.Drawing.Point(88, 20)
        Me.SalaTextBox.Name = "SalaTextBox"
        Me.SalaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalaTextBox.TabIndex = 16
        '
        'LugarnumeroTextBox
        '
        Me.LugarnumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "lugarnumero", True))
        Me.LugarnumeroTextBox.Location = New System.Drawing.Point(88, 46)
        Me.LugarnumeroTextBox.Name = "LugarnumeroTextBox"
        Me.LugarnumeroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LugarnumeroTextBox.TabIndex = 18
        '
        'EntradaTextBox
        '
        Me.EntradaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "entrada", True))
        Me.EntradaTextBox.Location = New System.Drawing.Point(88, 72)
        Me.EntradaTextBox.Name = "EntradaTextBox"
        Me.EntradaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EntradaTextBox.TabIndex = 20
        '
        'FestivalTextBox
        '
        Me.FestivalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "festival", True))
        Me.FestivalTextBox.Location = New System.Drawing.Point(99, 154)
        Me.FestivalTextBox.Name = "FestivalTextBox"
        Me.FestivalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FestivalTextBox.TabIndex = 22
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(80, 45)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CidadeTextBox.TabIndex = 24
        '
        'SpotTextBox
        '
        Me.SpotTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "spot", True))
        Me.SpotTextBox.Location = New System.Drawing.Point(80, 71)
        Me.SpotTextBox.Name = "SpotTextBox"
        Me.SpotTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SpotTextBox.TabIndex = 26
        '
        'DireccaoTextBox
        '
        Me.DireccaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "direccao", True))
        Me.DireccaoTextBox.Location = New System.Drawing.Point(401, 19)
        Me.DireccaoTextBox.Name = "DireccaoTextBox"
        Me.DireccaoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DireccaoTextBox.TabIndex = 28
        '
        'UtilizadoridComboBox
        '
        Me.UtilizadoridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "utilizadorid", True))
        Me.UtilizadoridComboBox.FormattingEnabled = True
        Me.UtilizadoridComboBox.Location = New System.Drawing.Point(464, 49)
        Me.UtilizadoridComboBox.Name = "UtilizadoridComboBox"
        Me.UtilizadoridComboBox.Size = New System.Drawing.Size(200, 21)
        Me.UtilizadoridComboBox.TabIndex = 30
        '
        'NotasTextBox
        '
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "notas", True))
        Me.NotasTextBox.Location = New System.Drawing.Point(80, 26)
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NotasTextBox.TabIndex = 32
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(89, 104)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ValorTextBox.TabIndex = 34
        '
        'LugarletraComboBox
        '
        Me.LugarletraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "lugarletra", True))
        Me.LugarletraComboBox.FormattingEnabled = True
        Me.LugarletraComboBox.Location = New System.Drawing.Point(89, 130)
        Me.LugarletraComboBox.Name = "LugarletraComboBox"
        Me.LugarletraComboBox.Size = New System.Drawing.Size(200, 21)
        Me.LugarletraComboBox.TabIndex = 36
        '
        'CriticaNumericUpDown
        '
        Me.CriticaNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BilheteBindingSource, "critica", True))
        Me.CriticaNumericUpDown.Location = New System.Drawing.Point(80, 66)
        Me.CriticaNumericUpDown.Name = "CriticaNumericUpDown"
        Me.CriticaNumericUpDown.Size = New System.Drawing.Size(200, 20)
        Me.CriticaNumericUpDown.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(DataLabel1)
        Me.GroupBox1.Controls.Add(Me.DataTextBox)
        Me.GroupBox1.Controls.Add(DataLabel)
        Me.GroupBox1.Controls.Add(Me.DataDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.HoraComboBox)
        Me.GroupBox1.Controls.Add(HoraLabel)
        Me.GroupBox1.Controls.Add(Me.CompanhiaTextBox)
        Me.GroupBox1.Controls.Add(DireccaoLabel)
        Me.GroupBox1.Controls.Add(FestivalLabel)
        Me.GroupBox1.Controls.Add(Me.DireccaoTextBox)
        Me.GroupBox1.Controls.Add(CategoriaLabel)
        Me.GroupBox1.Controls.Add(Me.FestivalTextBox)
        Me.GroupBox1.Controls.Add(CompanhiaLabel)
        Me.GroupBox1.Controls.Add(Me.CategoriaComboBox)
        Me.GroupBox1.Controls.Add(Me.NomeTextBox)
        Me.GroupBox1.Controls.Add(NomeLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 215)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.EntradaTextBox)
        Me.GroupBox2.Controls.Add(EntradaLabel)
        Me.GroupBox2.Controls.Add(Me.LugarnumeroTextBox)
        Me.GroupBox2.Controls.Add(LugarnumeroLabel)
        Me.GroupBox2.Controls.Add(Me.SalaTextBox)
        Me.GroupBox2.Controls.Add(SalaLabel)
        Me.GroupBox2.Controls.Add(Me.LugarletraComboBox)
        Me.GroupBox2.Controls.Add(LugarletraLabel)
        Me.GroupBox2.Controls.Add(Me.ValorTextBox)
        Me.GroupBox2.Controls.Add(ValorLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 276)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 163)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CidadeTextBox)
        Me.GroupBox3.Controls.Add(CidadeLabel)
        Me.GroupBox3.Controls.Add(Me.PaisTextBox)
        Me.GroupBox3.Controls.Add(PaisLabel)
        Me.GroupBox3.Controls.Add(Me.SpotTextBox)
        Me.GroupBox3.Controls.Add(SpotLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(353, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 163)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(CriticaLabel1)
        Me.GroupBox4.Controls.Add(Me.CriticaTextBox)
        Me.GroupBox4.Controls.Add(NotasLabel)
        Me.GroupBox4.Controls.Add(Me.NotasTextBox)
        Me.GroupBox4.Controls.Add(CriticaLabel)
        Me.GroupBox4.Controls.Add(Me.CriticaNumericUpDown)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 445)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(690, 111)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'NomeLabel1
        '
        NomeLabel1.AutoSize = True
        NomeLabel1.Location = New System.Drawing.Point(799, 71)
        NomeLabel1.Name = "NomeLabel1"
        NomeLabel1.Size = New System.Drawing.Size(36, 13)
        NomeLabel1.TabIndex = 42
        NomeLabel1.Text = "nome:"
        '
        'NomeListBox
        '
        Me.NomeListBox.DataSource = Me.BilheteBindingSource
        Me.NomeListBox.DisplayMember = "nome"
        Me.NomeListBox.FormattingEnabled = True
        Me.NomeListBox.Location = New System.Drawing.Point(841, 71)
        Me.NomeListBox.Name = "NomeListBox"
        Me.NomeListBox.Size = New System.Drawing.Size(120, 95)
        Me.NomeListBox.TabIndex = 43
        Me.NomeListBox.ValueMember = "ID"
        '
        'FillByTeatroToolStrip
        '
        Me.FillByTeatroToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByTeatroToolStripButton})
        Me.FillByTeatroToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByTeatroToolStrip.Name = "FillByTeatroToolStrip"
        Me.FillByTeatroToolStrip.Size = New System.Drawing.Size(1057, 25)
        Me.FillByTeatroToolStrip.TabIndex = 44
        Me.FillByTeatroToolStrip.Text = "FillByTeatroToolStrip"
        '
        'FillByTeatroToolStripButton
        '
        Me.FillByTeatroToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByTeatroToolStripButton.Name = "FillByTeatroToolStripButton"
        Me.FillByTeatroToolStripButton.Size = New System.Drawing.Size(67, 22)
        Me.FillByTeatroToolStripButton.Text = "FillByTeatro"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(43, 105)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(31, 13)
        DataLabel.TabIndex = 28
        DataLabel.Text = "data:"
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BilheteBindingSource, "data", True))
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BilheteBindingSource, "data", True))
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "data", True))
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BilheteBindingSource, "data", True, System.Windows.Forms.DataSourceUpdateMode.Never, Nothing, "d"))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(80, 101)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePicker.TabIndex = 29
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'CriticaLabel1
        '
        CriticaLabel1.AutoSize = True
        CriticaLabel1.Location = New System.Drawing.Point(305, 74)
        CriticaLabel1.Name = "CriticaLabel1"
        CriticaLabel1.Size = New System.Drawing.Size(38, 13)
        CriticaLabel1.TabIndex = 38
        CriticaLabel1.Text = "critica:"
        '
        'CriticaTextBox
        '
        Me.CriticaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "critica", True))
        Me.CriticaTextBox.Location = New System.Drawing.Point(349, 71)
        Me.CriticaTextBox.Name = "CriticaTextBox"
        Me.CriticaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CriticaTextBox.TabIndex = 39
        '
        'DataLabel1
        '
        DataLabel1.AutoSize = True
        DataLabel1.Location = New System.Drawing.Point(378, 101)
        DataLabel1.Name = "DataLabel1"
        DataLabel1.Size = New System.Drawing.Size(31, 13)
        DataLabel1.TabIndex = 29
        DataLabel1.Text = "data:"
        '
        'DataTextBox
        '
        Me.DataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "data", True))
        Me.DataTextBox.Location = New System.Drawing.Point(415, 98)
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DataTextBox.TabIndex = 30
        '
        'frmeditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 565)
        Me.Controls.Add(Me.FillByTeatroToolStrip)
        Me.Controls.Add(NomeLabel1)
        Me.Controls.Add(Me.NomeListBox)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(UtilizadoridLabel)
        Me.Controls.Add(Me.UtilizadoridComboBox)
        Me.Controls.Add(Me.BilheteBindingNavigator)
        Me.Name = "frmeditor"
        Me.Text = "editor"
        CType(Me.BdbilhetesbetaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilheteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BilheteBindingNavigator.ResumeLayout(False)
        Me.BilheteBindingNavigator.PerformLayout()
        CType(Me.CriticaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.FillByTeatroToolStrip.ResumeLayout(False)
        Me.FillByTeatroToolStrip.PerformLayout()
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
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanhiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoraComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LugarnumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EntradaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FestivalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpotTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UtilizadoridComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NotasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LugarletraComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CriticaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents NomeListBox As System.Windows.Forms.ListBox
    Friend WithEvents FillByTeatroToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByTeatroToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CriticaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataTextBox As System.Windows.Forms.TextBox
End Class
