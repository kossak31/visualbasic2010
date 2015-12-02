<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpesquisa
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeatroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DançaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilheteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConviteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaLivreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstatisticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalDeRegistosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilheteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalDeConviteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalDeEntradaLivreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotaldeDinheiroGastoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LugaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalDeVezesSentadoNaLetraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalDeVezesSentadoNoNúmeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.cboField = New System.Windows.Forms.ComboBox()
        Me.bttprocurar = New System.Windows.Forms.Button()
        Me.txtprocura = New System.Windows.Forms.TextBox()
        Me.BilheteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BilheteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdbilhetesbetaDataSet = New cinema.bdbilhetesbetaDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkspot = New System.Windows.Forms.CheckBox()
        Me.chkcidade = New System.Windows.Forms.CheckBox()
        Me.chkpais = New System.Windows.Forms.CheckBox()
        Me.chkuser = New System.Windows.Forms.CheckBox()
        Me.chknotas = New System.Windows.Forms.CheckBox()
        Me.chkcritica = New System.Windows.Forms.CheckBox()
        Me.chkvalor = New System.Windows.Forms.CheckBox()
        Me.chkentrada = New System.Windows.Forms.CheckBox()
        Me.chklugarletra = New System.Windows.Forms.CheckBox()
        Me.chklugarnum = New System.Windows.Forms.CheckBox()
        Me.chksala = New System.Windows.Forms.CheckBox()
        Me.chkhora = New System.Windows.Forms.CheckBox()
        Me.chkdata = New System.Windows.Forms.CheckBox()
        Me.chkdireccao = New System.Windows.Forms.CheckBox()
        Me.chkfestival = New System.Windows.Forms.CheckBox()
        Me.chkcompanhia = New System.Windows.Forms.CheckBox()
        Me.chkcategoria = New System.Windows.Forms.CheckBox()
        Me.chknome = New System.Windows.Forms.CheckBox()
        Me.chkID = New System.Windows.Forms.CheckBox()
        Me.BilheteTableAdapter = New cinema.bdbilhetesbetaDataSetTableAdapters.BilheteTableAdapter()
        Me.TableAdapterManager = New cinema.bdbilhetesbetaDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataTable1TableAdapter = New cinema.bdbilhetesbetaDataSetTableAdapters.DataTable1TableAdapter()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByteatroToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByteatroToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BilheteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdbilhetesbetaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByteatroToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem1, Me.ProcurarToolStripMenuItem, Me.EstatisticaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1223, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'XToolStripMenuItem1
        '
        Me.XToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem})
        Me.XToolStripMenuItem1.Name = "XToolStripMenuItem1"
        Me.XToolStripMenuItem1.Size = New System.Drawing.Size(56, 20)
        Me.XToolStripMenuItem1.Text = "Ficheiro"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ProcurarToolStripMenuItem
        '
        Me.ProcurarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.BilheteToolStripMenuItem})
        Me.ProcurarToolStripMenuItem.Name = "ProcurarToolStripMenuItem"
        Me.ProcurarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ProcurarToolStripMenuItem.Text = "Listar Por"
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeatroToolStripMenuItem, Me.DançaToolStripMenuItem1})
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.XToolStripMenuItem.Text = "Categoria"
        '
        'TeatroToolStripMenuItem
        '
        Me.TeatroToolStripMenuItem.Name = "TeatroToolStripMenuItem"
        Me.TeatroToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.TeatroToolStripMenuItem.Text = "Teatro"
        '
        'DançaToolStripMenuItem1
        '
        Me.DançaToolStripMenuItem1.Name = "DançaToolStripMenuItem1"
        Me.DançaToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.DançaToolStripMenuItem1.Text = "Dança"
        '
        'BilheteToolStripMenuItem
        '
        Me.BilheteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConviteToolStripMenuItem, Me.EntradaLivreToolStripMenuItem, Me.ValorToolStripMenuItem})
        Me.BilheteToolStripMenuItem.Name = "BilheteToolStripMenuItem"
        Me.BilheteToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.BilheteToolStripMenuItem.Text = "Bilhete"
        '
        'ConviteToolStripMenuItem
        '
        Me.ConviteToolStripMenuItem.Name = "ConviteToolStripMenuItem"
        Me.ConviteToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ConviteToolStripMenuItem.Text = "Convite"
        '
        'EntradaLivreToolStripMenuItem
        '
        Me.EntradaLivreToolStripMenuItem.Name = "EntradaLivreToolStripMenuItem"
        Me.EntradaLivreToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.EntradaLivreToolStripMenuItem.Text = "Entrada Livre"
        '
        'ValorToolStripMenuItem
        '
        Me.ValorToolStripMenuItem.Name = "ValorToolStripMenuItem"
        Me.ValorToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ValorToolStripMenuItem.Text = "Valor"
        '
        'EstatisticaToolStripMenuItem
        '
        Me.EstatisticaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalDeRegistosToolStripMenuItem, Me.BilheteToolStripMenuItem1, Me.LugaresToolStripMenuItem, Me.TotalToolStripMenuItem})
        Me.EstatisticaToolStripMenuItem.Name = "EstatisticaToolStripMenuItem"
        Me.EstatisticaToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.EstatisticaToolStripMenuItem.Text = "Estatistica"
        '
        'TotalDeRegistosToolStripMenuItem
        '
        Me.TotalDeRegistosToolStripMenuItem.Name = "TotalDeRegistosToolStripMenuItem"
        Me.TotalDeRegistosToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.TotalDeRegistosToolStripMenuItem.Text = "Total de Registos"
        '
        'BilheteToolStripMenuItem1
        '
        Me.BilheteToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalDeConviteToolStripMenuItem, Me.TotalDeEntradaLivreToolStripMenuItem, Me.TotaldeDinheiroGastoToolStripMenuItem})
        Me.BilheteToolStripMenuItem1.Name = "BilheteToolStripMenuItem1"
        Me.BilheteToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.BilheteToolStripMenuItem1.Text = "Bilhete"
        '
        'TotalDeConviteToolStripMenuItem
        '
        Me.TotalDeConviteToolStripMenuItem.Name = "TotalDeConviteToolStripMenuItem"
        Me.TotalDeConviteToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.TotalDeConviteToolStripMenuItem.Text = "Total de Convite"
        '
        'TotalDeEntradaLivreToolStripMenuItem
        '
        Me.TotalDeEntradaLivreToolStripMenuItem.Name = "TotalDeEntradaLivreToolStripMenuItem"
        Me.TotalDeEntradaLivreToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.TotalDeEntradaLivreToolStripMenuItem.Text = "Total de Entrada Livre"
        '
        'TotaldeDinheiroGastoToolStripMenuItem
        '
        Me.TotaldeDinheiroGastoToolStripMenuItem.Name = "TotaldeDinheiroGastoToolStripMenuItem"
        Me.TotaldeDinheiroGastoToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.TotaldeDinheiroGastoToolStripMenuItem.Text = "Total de Dinheiro Gasto"
        '
        'LugaresToolStripMenuItem
        '
        Me.LugaresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalDeVezesSentadoNaLetraToolStripMenuItem, Me.TotalDeVezesSentadoNoNúmeroToolStripMenuItem})
        Me.LugaresToolStripMenuItem.Name = "LugaresToolStripMenuItem"
        Me.LugaresToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LugaresToolStripMenuItem.Text = "Lugares"
        '
        'TotalDeVezesSentadoNaLetraToolStripMenuItem
        '
        Me.TotalDeVezesSentadoNaLetraToolStripMenuItem.Name = "TotalDeVezesSentadoNaLetraToolStripMenuItem"
        Me.TotalDeVezesSentadoNaLetraToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.TotalDeVezesSentadoNaLetraToolStripMenuItem.Text = "Total de Vezes Sentado na Letra ..."
        '
        'TotalDeVezesSentadoNoNúmeroToolStripMenuItem
        '
        Me.TotalDeVezesSentadoNoNúmeroToolStripMenuItem.Name = "TotalDeVezesSentadoNoNúmeroToolStripMenuItem"
        Me.TotalDeVezesSentadoNoNúmeroToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.TotalDeVezesSentadoNoNúmeroToolStripMenuItem.Text = "Total de Vezes Sentado no Número"
        '
        'TotalToolStripMenuItem
        '
        Me.TotalToolStripMenuItem.Name = "TotalToolStripMenuItem"
        Me.TotalToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.TotalToolStripMenuItem.Text = "Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb1)
        Me.GroupBox1.Controls.Add(Me.cboField)
        Me.GroupBox1.Controls.Add(Me.bttprocurar)
        Me.GroupBox1.Controls.Add(Me.txtprocura)
        Me.GroupBox1.Location = New System.Drawing.Point(349, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 140)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Procurar Por Coluna"
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Location = New System.Drawing.Point(26, 20)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(162, 13)
        Me.lb1.TabIndex = 3
        Me.lb1.Text = "Selecionar Coluna para pesquisa"
        '
        'cboField
        '
        Me.cboField.FormattingEnabled = True
        Me.cboField.Items.AddRange(New Object() {"Nome", "Dança"})
        Me.cboField.Location = New System.Drawing.Point(26, 44)
        Me.cboField.Name = "cboField"
        Me.cboField.Size = New System.Drawing.Size(121, 21)
        Me.cboField.TabIndex = 2
        '
        'bttprocurar
        '
        Me.bttprocurar.Location = New System.Drawing.Point(162, 94)
        Me.bttprocurar.Name = "bttprocurar"
        Me.bttprocurar.Size = New System.Drawing.Size(75, 23)
        Me.bttprocurar.TabIndex = 1
        Me.bttprocurar.Text = "Procurar"
        Me.bttprocurar.UseVisualStyleBackColor = True
        '
        'txtprocura
        '
        Me.txtprocura.Location = New System.Drawing.Point(162, 45)
        Me.txtprocura.Name = "txtprocura"
        Me.txtprocura.Size = New System.Drawing.Size(274, 20)
        Me.txtprocura.TabIndex = 0
        '
        'BilheteDataGridView
        '
        Me.BilheteDataGridView.AllowUserToAddRows = False
        Me.BilheteDataGridView.AllowUserToDeleteRows = False
        Me.BilheteDataGridView.AllowUserToOrderColumns = True
        Me.BilheteDataGridView.AutoGenerateColumns = False
        Me.BilheteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BilheteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn15})
        Me.BilheteDataGridView.DataSource = Me.BilheteBindingSource
        Me.BilheteDataGridView.Location = New System.Drawing.Point(0, 226)
        Me.BilheteDataGridView.Name = "BilheteDataGridView"
        Me.BilheteDataGridView.ReadOnly = True
        Me.BilheteDataGridView.Size = New System.Drawing.Size(992, 220)
        Me.BilheteDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "categoria"
        Me.DataGridViewTextBoxColumn2.HeaderText = "categoria"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "companhia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "companhia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "festival"
        Me.DataGridViewTextBoxColumn11.HeaderText = "festival"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "direccao"
        Me.DataGridViewTextBoxColumn14.HeaderText = "direccao"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn5.HeaderText = "data"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "hora"
        Me.DataGridViewTextBoxColumn6.HeaderText = "hora"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "pais"
        Me.DataGridViewTextBoxColumn7.HeaderText = "pais"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "cidade"
        Me.DataGridViewTextBoxColumn12.HeaderText = "cidade"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "spot"
        Me.DataGridViewTextBoxColumn13.HeaderText = "spot"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "sala"
        Me.DataGridViewTextBoxColumn8.HeaderText = "sala"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "lugarnumero"
        Me.DataGridViewTextBoxColumn9.HeaderText = "lugarnumero"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "lugarletra"
        Me.DataGridViewTextBoxColumn18.HeaderText = "lugarletra"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "entrada"
        Me.DataGridViewTextBoxColumn10.HeaderText = "entrada"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn17.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "notas"
        Me.DataGridViewTextBoxColumn16.HeaderText = "notas"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "critica"
        Me.DataGridViewTextBoxColumn19.HeaderText = "critica"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "utilizadorid"
        Me.DataGridViewTextBoxColumn15.HeaderText = "utilizadorid"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'BilheteBindingSource
        '
        Me.BilheteBindingSource.DataMember = "Bilhete"
        Me.BilheteBindingSource.DataSource = Me.BdbilhetesbetaDataSet
        '
        'BdbilhetesbetaDataSet
        '
        Me.BdbilhetesbetaDataSet.DataSetName = "bdbilhetesbetaDataSet"
        Me.BdbilhetesbetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkspot)
        Me.GroupBox2.Controls.Add(Me.chkcidade)
        Me.GroupBox2.Controls.Add(Me.chkpais)
        Me.GroupBox2.Controls.Add(Me.chkuser)
        Me.GroupBox2.Controls.Add(Me.chknotas)
        Me.GroupBox2.Controls.Add(Me.chkcritica)
        Me.GroupBox2.Controls.Add(Me.chkvalor)
        Me.GroupBox2.Controls.Add(Me.chkentrada)
        Me.GroupBox2.Controls.Add(Me.chklugarletra)
        Me.GroupBox2.Controls.Add(Me.chklugarnum)
        Me.GroupBox2.Controls.Add(Me.chksala)
        Me.GroupBox2.Controls.Add(Me.chkhora)
        Me.GroupBox2.Controls.Add(Me.chkdata)
        Me.GroupBox2.Controls.Add(Me.chkdireccao)
        Me.GroupBox2.Controls.Add(Me.chkfestival)
        Me.GroupBox2.Controls.Add(Me.chkcompanhia)
        Me.GroupBox2.Controls.Add(Me.chkcategoria)
        Me.GroupBox2.Controls.Add(Me.chknome)
        Me.GroupBox2.Controls.Add(Me.chkID)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 140)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Esconder Colunas"
        '
        'chkspot
        '
        Me.chkspot.AutoSize = True
        Me.chkspot.Location = New System.Drawing.Point(171, 114)
        Me.chkspot.Name = "chkspot"
        Me.chkspot.Size = New System.Drawing.Size(52, 17)
        Me.chkspot.TabIndex = 18
        Me.chkspot.Text = "Local"
        Me.chkspot.UseVisualStyleBackColor = True
        '
        'chkcidade
        '
        Me.chkcidade.AutoSize = True
        Me.chkcidade.Location = New System.Drawing.Point(93, 114)
        Me.chkcidade.Name = "chkcidade"
        Me.chkcidade.Size = New System.Drawing.Size(59, 17)
        Me.chkcidade.TabIndex = 17
        Me.chkcidade.Text = "Cidade"
        Me.chkcidade.UseVisualStyleBackColor = True
        '
        'chkpais
        '
        Me.chkpais.AutoSize = True
        Me.chkpais.Location = New System.Drawing.Point(6, 113)
        Me.chkpais.Name = "chkpais"
        Me.chkpais.Size = New System.Drawing.Size(48, 17)
        Me.chkpais.TabIndex = 16
        Me.chkpais.Text = "País"
        Me.chkpais.UseVisualStyleBackColor = True
        '
        'chkuser
        '
        Me.chkuser.AutoSize = True
        Me.chkuser.Location = New System.Drawing.Point(258, 94)
        Me.chkuser.Name = "chkuser"
        Me.chkuser.Size = New System.Drawing.Size(48, 17)
        Me.chkuser.TabIndex = 15
        Me.chkuser.Text = "User"
        Me.chkuser.UseVisualStyleBackColor = True
        '
        'chknotas
        '
        Me.chknotas.AutoSize = True
        Me.chknotas.Location = New System.Drawing.Point(258, 68)
        Me.chknotas.Name = "chknotas"
        Me.chknotas.Size = New System.Drawing.Size(54, 17)
        Me.chknotas.TabIndex = 14
        Me.chknotas.Text = "Notas"
        Me.chknotas.UseVisualStyleBackColor = True
        '
        'chkcritica
        '
        Me.chkcritica.AutoSize = True
        Me.chkcritica.Location = New System.Drawing.Point(258, 45)
        Me.chkcritica.Name = "chkcritica"
        Me.chkcritica.Size = New System.Drawing.Size(55, 17)
        Me.chkcritica.TabIndex = 13
        Me.chkcritica.Text = "Critica"
        Me.chkcritica.UseVisualStyleBackColor = True
        '
        'chkvalor
        '
        Me.chkvalor.AutoSize = True
        Me.chkvalor.Location = New System.Drawing.Point(256, 19)
        Me.chkvalor.Name = "chkvalor"
        Me.chkvalor.Size = New System.Drawing.Size(50, 17)
        Me.chkvalor.TabIndex = 12
        Me.chkvalor.Text = "Valor"
        Me.chkvalor.UseVisualStyleBackColor = True
        '
        'chkentrada
        '
        Me.chkentrada.AutoSize = True
        Me.chkentrada.Location = New System.Drawing.Point(171, 90)
        Me.chkentrada.Name = "chkentrada"
        Me.chkentrada.Size = New System.Drawing.Size(63, 17)
        Me.chkentrada.TabIndex = 11
        Me.chkentrada.Text = "Entrada"
        Me.chkentrada.UseVisualStyleBackColor = True
        '
        'chklugarletra
        '
        Me.chklugarletra.AutoSize = True
        Me.chklugarletra.Location = New System.Drawing.Point(171, 67)
        Me.chklugarletra.Name = "chklugarletra"
        Me.chklugarletra.Size = New System.Drawing.Size(80, 17)
        Me.chklugarletra.TabIndex = 10
        Me.chklugarletra.Text = "Lugar Letra"
        Me.chklugarletra.UseVisualStyleBackColor = True
        '
        'chklugarnum
        '
        Me.chklugarnum.AutoSize = True
        Me.chklugarnum.Location = New System.Drawing.Point(171, 42)
        Me.chklugarnum.Name = "chklugarnum"
        Me.chklugarnum.Size = New System.Drawing.Size(78, 17)
        Me.chklugarnum.TabIndex = 9
        Me.chklugarnum.Text = "Lugar Num"
        Me.chklugarnum.UseVisualStyleBackColor = True
        '
        'chksala
        '
        Me.chksala.AutoSize = True
        Me.chksala.Location = New System.Drawing.Point(171, 20)
        Me.chksala.Name = "chksala"
        Me.chksala.Size = New System.Drawing.Size(47, 17)
        Me.chksala.TabIndex = 8
        Me.chksala.Text = "Sala"
        Me.chksala.UseVisualStyleBackColor = True
        '
        'chkhora
        '
        Me.chkhora.AutoSize = True
        Me.chkhora.Location = New System.Drawing.Point(93, 90)
        Me.chkhora.Name = "chkhora"
        Me.chkhora.Size = New System.Drawing.Size(49, 17)
        Me.chkhora.TabIndex = 7
        Me.chkhora.Text = "Hora"
        Me.chkhora.UseVisualStyleBackColor = True
        '
        'chkdata
        '
        Me.chkdata.AutoSize = True
        Me.chkdata.Location = New System.Drawing.Point(93, 66)
        Me.chkdata.Name = "chkdata"
        Me.chkdata.Size = New System.Drawing.Size(49, 17)
        Me.chkdata.TabIndex = 6
        Me.chkdata.Text = "Data"
        Me.chkdata.UseVisualStyleBackColor = True
        '
        'chkdireccao
        '
        Me.chkdireccao.AutoSize = True
        Me.chkdireccao.Location = New System.Drawing.Point(93, 43)
        Me.chkdireccao.Name = "chkdireccao"
        Me.chkdireccao.Size = New System.Drawing.Size(69, 17)
        Me.chkdireccao.TabIndex = 5
        Me.chkdireccao.Text = "Direcção"
        Me.chkdireccao.UseVisualStyleBackColor = True
        '
        'chkfestival
        '
        Me.chkfestival.AutoSize = True
        Me.chkfestival.Location = New System.Drawing.Point(93, 20)
        Me.chkfestival.Name = "chkfestival"
        Me.chkfestival.Size = New System.Drawing.Size(62, 17)
        Me.chkfestival.TabIndex = 4
        Me.chkfestival.Text = "Festival"
        Me.chkfestival.UseVisualStyleBackColor = True
        '
        'chkcompanhia
        '
        Me.chkcompanhia.AutoSize = True
        Me.chkcompanhia.Location = New System.Drawing.Point(6, 89)
        Me.chkcompanhia.Name = "chkcompanhia"
        Me.chkcompanhia.Size = New System.Drawing.Size(79, 17)
        Me.chkcompanhia.TabIndex = 3
        Me.chkcompanhia.Text = "Companhia"
        Me.chkcompanhia.UseVisualStyleBackColor = True
        '
        'chkcategoria
        '
        Me.chkcategoria.AutoSize = True
        Me.chkcategoria.Location = New System.Drawing.Point(6, 65)
        Me.chkcategoria.Name = "chkcategoria"
        Me.chkcategoria.Size = New System.Drawing.Size(71, 17)
        Me.chkcategoria.TabIndex = 2
        Me.chkcategoria.Text = "Categoria"
        Me.chkcategoria.UseVisualStyleBackColor = True
        '
        'chknome
        '
        Me.chknome.AutoSize = True
        Me.chknome.Location = New System.Drawing.Point(6, 42)
        Me.chknome.Name = "chknome"
        Me.chknome.Size = New System.Drawing.Size(54, 17)
        Me.chknome.TabIndex = 1
        Me.chknome.Text = "Nome"
        Me.chknome.UseVisualStyleBackColor = True
        '
        'chkID
        '
        Me.chkID.AutoSize = True
        Me.chkID.Location = New System.Drawing.Point(6, 19)
        Me.chkID.Name = "chkID"
        Me.chkID.Size = New System.Drawing.Size(37, 17)
        Me.chkID.TabIndex = 0
        Me.chkID.Text = "ID"
        Me.chkID.UseVisualStyleBackColor = True
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataTable1DataGridView)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(818, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 352)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(1223, 25)
        Me.FillToolStrip.TabIndex = 7
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.BdbilhetesbetaDataSet
        '
        'DataTable1DataGridView
        '
        Me.DataTable1DataGridView.AutoGenerateColumns = False
        Me.DataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTable1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20})
        Me.DataTable1DataGridView.DataSource = Me.DataTable1BindingSource
        Me.DataTable1DataGridView.Location = New System.Drawing.Point(32, 101)
        Me.DataTable1DataGridView.Name = "DataTable1DataGridView"
        Me.DataTable1DataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DataTable1DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Expr1"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'FillByteatroToolStrip
        '
        Me.FillByteatroToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByteatroToolStripButton})
        Me.FillByteatroToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByteatroToolStrip.Name = "FillByteatroToolStrip"
        Me.FillByteatroToolStrip.Size = New System.Drawing.Size(109, 25)
        Me.FillByteatroToolStrip.TabIndex = 8
        Me.FillByteatroToolStrip.Text = "FillByteatroToolStrip"
        '
        'FillByteatroToolStripButton
        '
        Me.FillByteatroToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByteatroToolStripButton.Name = "FillByteatroToolStripButton"
        Me.FillByteatroToolStripButton.Size = New System.Drawing.Size(65, 22)
        Me.FillByteatroToolStripButton.Text = "FillByteatro"
        '
        'frmpesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 466)
        Me.Controls.Add(Me.FillByteatroToolStrip)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BilheteDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmpesquisa"
        Me.Text = "Pesquisar"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BilheteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdbilhetesbetaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByteatroToolStrip.ResumeLayout(False)
        Me.FillByteatroToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProcurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bttprocurar As System.Windows.Forms.Button
    Friend WithEvents txtprocura As System.Windows.Forms.TextBox
    Friend WithEvents BdbilhetesbetaDataSet As cinema.bdbilhetesbetaDataSet
    Friend WithEvents BilheteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BilheteTableAdapter As cinema.bdbilhetesbetaDataSetTableAdapters.BilheteTableAdapter
    Friend WithEvents TableAdapterManager As cinema.bdbilhetesbetaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BilheteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents XToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboField As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkcompanhia As System.Windows.Forms.CheckBox
    Friend WithEvents chkcategoria As System.Windows.Forms.CheckBox
    Friend WithEvents chknome As System.Windows.Forms.CheckBox
    Friend WithEvents chkID As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents chkuser As System.Windows.Forms.CheckBox
    Friend WithEvents chknotas As System.Windows.Forms.CheckBox
    Friend WithEvents chkcritica As System.Windows.Forms.CheckBox
    Friend WithEvents chkvalor As System.Windows.Forms.CheckBox
    Friend WithEvents chkentrada As System.Windows.Forms.CheckBox
    Friend WithEvents chklugarletra As System.Windows.Forms.CheckBox
    Friend WithEvents chklugarnum As System.Windows.Forms.CheckBox
    Friend WithEvents chksala As System.Windows.Forms.CheckBox
    Friend WithEvents chkhora As System.Windows.Forms.CheckBox
    Friend WithEvents chkdata As System.Windows.Forms.CheckBox
    Friend WithEvents chkdireccao As System.Windows.Forms.CheckBox
    Friend WithEvents chkfestival As System.Windows.Forms.CheckBox
    Friend WithEvents TeatroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DançaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BilheteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConviteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradaLivreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstatisticaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalDeRegistosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BilheteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalDeConviteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalDeEntradaLivreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotaldeDinheiroGastoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LugaresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalDeVezesSentadoNaLetraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalDeVezesSentadoNoNúmeroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkspot As System.Windows.Forms.CheckBox
    Friend WithEvents chkcidade As System.Windows.Forms.CheckBox
    Friend WithEvents chkpais As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataTable1TableAdapter As cinema.bdbilhetesbetaDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataTable1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FillByteatroToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByteatroToolStripButton As System.Windows.Forms.ToolStripButton
End Class
