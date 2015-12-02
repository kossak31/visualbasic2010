<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnovo
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
        Dim UtilizadoridLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CompanhiaLabel As System.Windows.Forms.Label
        Dim FestivalLabel As System.Windows.Forms.Label
        Dim HoraLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim DireccaoLabel As System.Windows.Forms.Label
        Dim SpotLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim LugarnumeroLabel As System.Windows.Forms.Label
        Dim LugarletraLabel As System.Windows.Forms.Label
        Dim CriticaLabel As System.Windows.Forms.Label
        Dim SalaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmnovo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DireccaoTextBox = New System.Windows.Forms.TextBox()
        Me.BilheteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdbilhetesbetaDataSet = New cinema.bdbilhetesbetaDataSet()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HoraComboBox = New System.Windows.Forms.ComboBox()
        Me.FestivalTextBox = New System.Windows.Forms.TextBox()
        Me.CompanhiaTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radpreco = New System.Windows.Forms.RadioButton()
        Me.radconvite = New System.Windows.Forms.RadioButton()
        Me.Radentrada = New System.Windows.Forms.RadioButton()
        Me.SalaTextBox = New System.Windows.Forms.TextBox()
        Me.LugarletraComboBox = New System.Windows.Forms.ComboBox()
        Me.LugarnumeroTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.SpotTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoRegistoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilheteTableAdapter = New cinema.bdbilhetesbetaDataSetTableAdapters.BilheteTableAdapter()
        Me.TableAdapterManager = New cinema.bdbilhetesbetaDataSetTableAdapters.TableAdapterManager()
        Me.BilheteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.tsbNovo = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripMenuItemx = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.UtilizadoridComboBox = New System.Windows.Forms.ComboBox()
        Me.NotasTextBox = New System.Windows.Forms.TextBox()
        Me.CriticaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        UtilizadoridLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CompanhiaLabel = New System.Windows.Forms.Label()
        FestivalLabel = New System.Windows.Forms.Label()
        HoraLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        DireccaoLabel = New System.Windows.Forms.Label()
        SpotLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        LugarnumeroLabel = New System.Windows.Forms.Label()
        LugarletraLabel = New System.Windows.Forms.Label()
        CriticaLabel = New System.Windows.Forms.Label()
        SalaLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdbilhetesbetaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BilheteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BilheteBindingNavigator.SuspendLayout()
        CType(Me.CriticaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UtilizadoridLabel
        '
        UtilizadoridLabel.AutoSize = True
        UtilizadoridLabel.Location = New System.Drawing.Point(568, 92)
        UtilizadoridLabel.Name = "UtilizadoridLabel"
        UtilizadoridLabel.Size = New System.Drawing.Size(77, 13)
        UtilizadoridLabel.TabIndex = 11
        UtilizadoridLabel.Text = "Registado Por:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(24, 35)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 12
        CategoriaLabel.Text = "Categoria:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(238, 35)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 13
        NomeLabel.Text = "Nome:"
        '
        'CompanhiaLabel
        '
        CompanhiaLabel.AutoSize = True
        CompanhiaLabel.Location = New System.Drawing.Point(212, 75)
        CompanhiaLabel.Name = "CompanhiaLabel"
        CompanhiaLabel.Size = New System.Drawing.Size(63, 13)
        CompanhiaLabel.TabIndex = 14
        CompanhiaLabel.Text = "Companhia:"
        '
        'FestivalLabel
        '
        FestivalLabel.AutoSize = True
        FestivalLabel.Location = New System.Drawing.Point(35, 75)
        FestivalLabel.Name = "FestivalLabel"
        FestivalLabel.Size = New System.Drawing.Size(46, 13)
        FestivalLabel.TabIndex = 15
        FestivalLabel.Text = "Festival:"
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.Location = New System.Drawing.Point(583, 155)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(33, 13)
        HoraLabel.TabIndex = 16
        HoraLabel.Text = "Hora:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(47, 157)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(85, 13)
        DataLabel.TabIndex = 17
        DataLabel.Text = "Data do Evento:"
        '
        'DireccaoLabel
        '
        DireccaoLabel.AutoSize = True
        DireccaoLabel.Location = New System.Drawing.Point(27, 112)
        DireccaoLabel.Name = "DireccaoLabel"
        DireccaoLabel.Size = New System.Drawing.Size(108, 13)
        DireccaoLabel.TabIndex = 18
        DireccaoLabel.Text = "Direcção - Produção:"
        '
        'SpotLabel
        '
        SpotLabel.AutoSize = True
        SpotLabel.Location = New System.Drawing.Point(28, 36)
        SpotLabel.Name = "SpotLabel"
        SpotLabel.Size = New System.Drawing.Size(36, 13)
        SpotLabel.TabIndex = 0
        SpotLabel.Text = "Local:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(28, 61)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 2
        CidadeLabel.Text = "Cidade:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(28, 91)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(32, 13)
        PaisLabel.TabIndex = 4
        PaisLabel.Text = "País:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(288, 109)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(31, 13)
        ValorLabel.TabIndex = 5
        ValorLabel.Text = "Tipo:"
        '
        'LugarnumeroLabel
        '
        LugarnumeroLabel.AutoSize = True
        LugarnumeroLabel.Location = New System.Drawing.Point(10, 109)
        LugarnumeroLabel.Name = "LugarnumeroLabel"
        LugarnumeroLabel.Size = New System.Drawing.Size(77, 13)
        LugarnumeroLabel.TabIndex = 6
        LugarnumeroLabel.Text = "Lugar Número:"
        '
        'LugarletraLabel
        '
        LugarletraLabel.AutoSize = True
        LugarletraLabel.Location = New System.Drawing.Point(10, 79)
        LugarletraLabel.Name = "LugarletraLabel"
        LugarletraLabel.Size = New System.Drawing.Size(64, 13)
        LugarletraLabel.TabIndex = 7
        LugarletraLabel.Text = "Lugar Letra:"
        '
        'CriticaLabel
        '
        CriticaLabel.AutoSize = True
        CriticaLabel.Location = New System.Drawing.Point(44, 482)
        CriticaLabel.Name = "CriticaLabel"
        CriticaLabel.Size = New System.Drawing.Size(61, 13)
        CriticaLabel.TabIndex = 13
        CriticaLabel.Text = "Nota Geral:"
        '
        'SalaLabel
        '
        SalaLabel.AutoSize = True
        SalaLabel.Location = New System.Drawing.Point(15, 32)
        SalaLabel.Name = "SalaLabel"
        SalaLabel.Size = New System.Drawing.Size(31, 13)
        SalaLabel.TabIndex = 8
        SalaLabel.Text = "Sala:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(DireccaoLabel)
        Me.GroupBox1.Controls.Add(Me.DireccaoTextBox)
        Me.GroupBox1.Controls.Add(DataLabel)
        Me.GroupBox1.Controls.Add(Me.DataDateTimePicker)
        Me.GroupBox1.Controls.Add(HoraLabel)
        Me.GroupBox1.Controls.Add(Me.HoraComboBox)
        Me.GroupBox1.Controls.Add(FestivalLabel)
        Me.GroupBox1.Controls.Add(Me.FestivalTextBox)
        Me.GroupBox1.Controls.Add(CompanhiaLabel)
        Me.GroupBox1.Controls.Add(Me.CompanhiaTextBox)
        Me.GroupBox1.Controls.Add(NomeLabel)
        Me.GroupBox1.Controls.Add(Me.NomeTextBox)
        Me.GroupBox1.Controls.Add(CategoriaLabel)
        Me.GroupBox1.Controls.Add(Me.CategoriaComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(747, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Gerais"
        '
        'DireccaoTextBox
        '
        Me.DireccaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "direccao", True))
        Me.DireccaoTextBox.Enabled = False
        Me.DireccaoTextBox.Location = New System.Drawing.Point(138, 109)
        Me.DireccaoTextBox.Name = "DireccaoTextBox"
        Me.DireccaoTextBox.Size = New System.Drawing.Size(603, 20)
        Me.DireccaoTextBox.TabIndex = 19
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
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BilheteBindingSource, "data", True))
        Me.DataDateTimePicker.Enabled = False
        Me.DataDateTimePicker.Location = New System.Drawing.Point(135, 155)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(227, 20)
        Me.DataDateTimePicker.TabIndex = 18
        '
        'HoraComboBox
        '
        Me.HoraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "hora", True))
        Me.HoraComboBox.Enabled = False
        Me.HoraComboBox.FormattingEnabled = True
        Me.HoraComboBox.Items.AddRange(New Object() {"0:00", "0:30", "1:00", "1:30", "2:00", "2:30", "3:00", "3:30", "4:00", "4:30", "5:00", "5:30", "6:00", "6:30", "7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.HoraComboBox.Location = New System.Drawing.Point(620, 152)
        Me.HoraComboBox.Name = "HoraComboBox"
        Me.HoraComboBox.Size = New System.Drawing.Size(121, 21)
        Me.HoraComboBox.TabIndex = 17
        '
        'FestivalTextBox
        '
        Me.FestivalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "festival", True))
        Me.FestivalTextBox.Enabled = False
        Me.FestivalTextBox.Location = New System.Drawing.Point(84, 72)
        Me.FestivalTextBox.Name = "FestivalTextBox"
        Me.FestivalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FestivalTextBox.TabIndex = 16
        '
        'CompanhiaTextBox
        '
        Me.CompanhiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "companhia", True))
        Me.CompanhiaTextBox.Enabled = False
        Me.CompanhiaTextBox.Location = New System.Drawing.Point(280, 72)
        Me.CompanhiaTextBox.Name = "CompanhiaTextBox"
        Me.CompanhiaTextBox.Size = New System.Drawing.Size(461, 20)
        Me.CompanhiaTextBox.TabIndex = 15
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(280, 32)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(461, 20)
        Me.NomeTextBox.TabIndex = 14
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "categoria", True))
        Me.CategoriaComboBox.Enabled = False
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Items.AddRange(New Object() {"Dança", "Teatro", "Cinema", "Performance", "Exposição", "Circo", "Concerto", "Opera", "Outro"})
        Me.CategoriaComboBox.Location = New System.Drawing.Point(84, 32)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoriaComboBox.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radpreco)
        Me.GroupBox2.Controls.Add(Me.radconvite)
        Me.GroupBox2.Controls.Add(Me.Radentrada)
        Me.GroupBox2.Controls.Add(SalaLabel)
        Me.GroupBox2.Controls.Add(Me.SalaTextBox)
        Me.GroupBox2.Controls.Add(LugarletraLabel)
        Me.GroupBox2.Controls.Add(Me.LugarletraComboBox)
        Me.GroupBox2.Controls.Add(LugarnumeroLabel)
        Me.GroupBox2.Controls.Add(Me.LugarnumeroTextBox)
        Me.GroupBox2.Controls.Add(ValorLabel)
        Me.GroupBox2.Controls.Add(Me.ValorTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 316)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 143)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lugar/Preço"
        '
        'radpreco
        '
        Me.radpreco.AutoSize = True
        Me.radpreco.Enabled = False
        Me.radpreco.Location = New System.Drawing.Point(339, 65)
        Me.radpreco.Name = "radpreco"
        Me.radpreco.Size = New System.Drawing.Size(53, 17)
        Me.radpreco.TabIndex = 12
        Me.radpreco.TabStop = True
        Me.radpreco.Text = "Preço"
        Me.radpreco.UseVisualStyleBackColor = True
        '
        'radconvite
        '
        Me.radconvite.AutoSize = True
        Me.radconvite.Enabled = False
        Me.radconvite.Location = New System.Drawing.Point(339, 42)
        Me.radconvite.Name = "radconvite"
        Me.radconvite.Size = New System.Drawing.Size(61, 17)
        Me.radconvite.TabIndex = 11
        Me.radconvite.TabStop = True
        Me.radconvite.Text = "Convite"
        Me.radconvite.UseVisualStyleBackColor = True
        '
        'Radentrada
        '
        Me.Radentrada.AutoSize = True
        Me.Radentrada.Enabled = False
        Me.Radentrada.Location = New System.Drawing.Point(339, 19)
        Me.Radentrada.Name = "Radentrada"
        Me.Radentrada.Size = New System.Drawing.Size(88, 17)
        Me.Radentrada.TabIndex = 10
        Me.Radentrada.TabStop = True
        Me.Radentrada.Text = "Entrada Livre"
        Me.Radentrada.UseVisualStyleBackColor = True
        '
        'SalaTextBox
        '
        Me.SalaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "sala", True))
        Me.SalaTextBox.Enabled = False
        Me.SalaTextBox.Location = New System.Drawing.Point(50, 29)
        Me.SalaTextBox.Name = "SalaTextBox"
        Me.SalaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalaTextBox.TabIndex = 9
        '
        'LugarletraComboBox
        '
        Me.LugarletraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "lugarletra", True))
        Me.LugarletraComboBox.Enabled = False
        Me.LugarletraComboBox.FormattingEnabled = True
        Me.LugarletraComboBox.Location = New System.Drawing.Point(84, 76)
        Me.LugarletraComboBox.Name = "LugarletraComboBox"
        Me.LugarletraComboBox.Size = New System.Drawing.Size(121, 21)
        Me.LugarletraComboBox.TabIndex = 8
        '
        'LugarnumeroTextBox
        '
        Me.LugarnumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "lugarnumero", True))
        Me.LugarnumeroTextBox.Enabled = False
        Me.LugarnumeroTextBox.Location = New System.Drawing.Point(93, 106)
        Me.LugarnumeroTextBox.Name = "LugarnumeroTextBox"
        Me.LugarnumeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LugarnumeroTextBox.TabIndex = 7
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "valor", True))
        Me.ValorTextBox.Enabled = False
        Me.ValorTextBox.Location = New System.Drawing.Point(327, 106)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ValorTextBox.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(PaisLabel)
        Me.GroupBox3.Controls.Add(Me.PaisTextBox)
        Me.GroupBox3.Controls.Add(CidadeLabel)
        Me.GroupBox3.Controls.Add(Me.CidadeTextBox)
        Me.GroupBox3.Controls.Add(SpotLabel)
        Me.GroupBox3.Controls.Add(Me.SpotTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(532, 316)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(246, 135)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Localização"
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "pais", True))
        Me.PaisTextBox.Enabled = False
        Me.PaisTextBox.Location = New System.Drawing.Point(76, 88)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(153, 20)
        Me.PaisTextBox.TabIndex = 5
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "cidade", True))
        Me.CidadeTextBox.Enabled = False
        Me.CidadeTextBox.Location = New System.Drawing.Point(76, 58)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(153, 20)
        Me.CidadeTextBox.TabIndex = 3
        '
        'SpotTextBox
        '
        Me.SpotTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "spot", True))
        Me.SpotTextBox.Enabled = False
        Me.SpotTextBox.Location = New System.Drawing.Point(76, 32)
        Me.SpotTextBox.Name = "SpotTextBox"
        Me.SpotTextBox.Size = New System.Drawing.Size(153, 20)
        Me.SpotTextBox.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(798, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoRegistoToolStripMenuItem, Me.GuardarToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NovoRegistoToolStripMenuItem
        '
        Me.NovoRegistoToolStripMenuItem.Name = "NovoRegistoToolStripMenuItem"
        Me.NovoRegistoToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NovoRegistoToolStripMenuItem.Text = "Novo Registo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
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
        Me.BilheteBindingNavigator.AddNewItem = Nothing
        Me.BilheteBindingNavigator.BindingSource = Me.BilheteBindingSource
        Me.BilheteBindingNavigator.CountItem = Nothing
        Me.BilheteBindingNavigator.DeleteItem = Nothing
        Me.BilheteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNovo, Me.GuardarToolStripMenuItemx, Me.ToolStripButton1, Me.BindingNavigatorSeparator2, Me.ToolStripButton2})
        Me.BilheteBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.BilheteBindingNavigator.MoveFirstItem = Nothing
        Me.BilheteBindingNavigator.MoveLastItem = Nothing
        Me.BilheteBindingNavigator.MoveNextItem = Nothing
        Me.BilheteBindingNavigator.MovePreviousItem = Nothing
        Me.BilheteBindingNavigator.Name = "BilheteBindingNavigator"
        Me.BilheteBindingNavigator.PositionItem = Nothing
        Me.BilheteBindingNavigator.Size = New System.Drawing.Size(798, 68)
        Me.BilheteBindingNavigator.TabIndex = 11
        Me.BilheteBindingNavigator.Text = "BindingNavigator1"
        '
        'tsbNovo
        '
        Me.tsbNovo.Image = CType(resources.GetObject("tsbNovo.Image"), System.Drawing.Image)
        Me.tsbNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNovo.Name = "tsbNovo"
        Me.tsbNovo.Size = New System.Drawing.Size(52, 65)
        Me.tsbNovo.Text = "Novo"
        Me.tsbNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GuardarToolStripMenuItemx
        '
        Me.GuardarToolStripMenuItemx.Image = CType(resources.GetObject("GuardarToolStripMenuItemx.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItemx.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GuardarToolStripMenuItemx.Name = "GuardarToolStripMenuItemx"
        Me.GuardarToolStripMenuItemx.Size = New System.Drawing.Size(52, 65)
        Me.GuardarToolStripMenuItemx.Text = "Guardar"
        Me.GuardarToolStripMenuItemx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(58, 65)
        Me.ToolStripButton1.Text = "Actualizar"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 68)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(53, 65)
        Me.ToolStripButton2.Text = "Cancelar"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UtilizadoridComboBox
        '
        Me.UtilizadoridComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "utilizadorid", True))
        Me.UtilizadoridComboBox.Enabled = False
        Me.UtilizadoridComboBox.FormattingEnabled = True
        Me.UtilizadoridComboBox.Items.AddRange(New Object() {"Raquel", "Tiago"})
        Me.UtilizadoridComboBox.Location = New System.Drawing.Point(651, 89)
        Me.UtilizadoridComboBox.Name = "UtilizadoridComboBox"
        Me.UtilizadoridComboBox.Size = New System.Drawing.Size(121, 21)
        Me.UtilizadoridComboBox.TabIndex = 12
        '
        'NotasTextBox
        '
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BilheteBindingSource, "notas", True))
        Me.NotasTextBox.Enabled = False
        Me.NotasTextBox.Location = New System.Drawing.Point(31, 511)
        Me.NotasTextBox.Multiline = True
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(747, 96)
        Me.NotasTextBox.TabIndex = 13
        Me.NotasTextBox.Text = "notas info sobre..."
        '
        'CriticaNumericUpDown
        '
        Me.CriticaNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BilheteBindingSource, "critica", True))
        Me.CriticaNumericUpDown.Enabled = False
        Me.CriticaNumericUpDown.Location = New System.Drawing.Point(111, 480)
        Me.CriticaNumericUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.CriticaNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CriticaNumericUpDown.Name = "CriticaNumericUpDown"
        Me.CriticaNumericUpDown.Size = New System.Drawing.Size(38, 20)
        Me.CriticaNumericUpDown.TabIndex = 14
        Me.CriticaNumericUpDown.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'frmnovo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 619)
        Me.Controls.Add(CriticaLabel)
        Me.Controls.Add(Me.CriticaNumericUpDown)
        Me.Controls.Add(Me.NotasTextBox)
        Me.Controls.Add(UtilizadoridLabel)
        Me.Controls.Add(Me.UtilizadoridComboBox)
        Me.Controls.Add(Me.BilheteBindingNavigator)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmnovo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Novo Registo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BilheteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdbilhetesbetaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BilheteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BilheteBindingNavigator.ResumeLayout(False)
        Me.BilheteBindingNavigator.PerformLayout()
        CType(Me.CriticaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoRegistoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BdbilhetesbetaDataSet As cinema.bdbilhetesbetaDataSet
    Friend WithEvents BilheteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BilheteTableAdapter As cinema.bdbilhetesbetaDataSetTableAdapters.BilheteTableAdapter
    Friend WithEvents TableAdapterManager As cinema.bdbilhetesbetaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BilheteBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarToolStripMenuItemx As System.Windows.Forms.ToolStripButton
    Friend WithEvents DireccaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HoraComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FestivalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanhiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LugarletraComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LugarnumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpotTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UtilizadoridComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NotasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CriticaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SalaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents radpreco As System.Windows.Forms.RadioButton
    Friend WithEvents radconvite As System.Windows.Forms.RadioButton
    Friend WithEvents Radentrada As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNovo As System.Windows.Forms.ToolStripButton
End Class
