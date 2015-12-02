<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTurmas
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
        Dim IDTurmaLabel As System.Windows.Forms.Label
        Dim DesignacaoLabel As System.Windows.Forms.Label
        Dim ModalidadeLabel As System.Windows.Forms.Label
        Dim CoordenadorLabel As System.Windows.Forms.Label
        Dim DiaSemanaLabel As System.Windows.Forms.Label
        Dim HoraInicioLabel As System.Windows.Forms.Label
        Dim HoraFimLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTurmas))
        Me.DatabaseDataSet = New WindowsApplication1.DatabaseDataSet()
        Me.TabelaTurmasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabelaTurmasTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaTurmasTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TabelaSociosTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaSociosTableAdapter()
        Me.TabelaTurmaAlunosTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaTurmaAlunosTableAdapter()
        Me.txtIdTurma = New System.Windows.Forms.TextBox()
        Me.txtDesignacao = New System.Windows.Forms.TextBox()
        Me.comboModalidade = New System.Windows.Forms.ComboBox()
        Me.TabelaModalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comboCoordenador = New System.Windows.Forms.ComboBox()
        Me.TabelaMonitoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comboDia = New System.Windows.Forms.ComboBox()
        Me.comboHoraInicio = New System.Windows.Forms.ComboBox()
        Me.comboHoraFim = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.TabelaTurmaAlunosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grelhaPraticantes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TabelaSociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsbNovo = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnular = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.lstTurmas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabelaModalidadesTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaModalidadesTableAdapter()
        Me.TabelaMonitoresTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaMonitoresTableAdapter()
        IDTurmaLabel = New System.Windows.Forms.Label()
        DesignacaoLabel = New System.Windows.Forms.Label()
        ModalidadeLabel = New System.Windows.Forms.Label()
        CoordenadorLabel = New System.Windows.Forms.Label()
        DiaSemanaLabel = New System.Windows.Forms.Label()
        HoraInicioLabel = New System.Windows.Forms.Label()
        HoraFimLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelaTurmasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelaModalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelaMonitoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelaTurmaAlunosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grelhaPraticantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelaSociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDTurmaLabel
        '
        IDTurmaLabel.AutoSize = True
        IDTurmaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDTurmaLabel.Location = New System.Drawing.Point(24, 76)
        IDTurmaLabel.Name = "IDTurmaLabel"
        IDTurmaLabel.Size = New System.Drawing.Size(58, 15)
        IDTurmaLabel.TabIndex = 1
        IDTurmaLabel.Text = "IDTurma:"
        '
        'DesignacaoLabel
        '
        DesignacaoLabel.AutoSize = True
        DesignacaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesignacaoLabel.Location = New System.Drawing.Point(24, 102)
        DesignacaoLabel.Name = "DesignacaoLabel"
        DesignacaoLabel.Size = New System.Drawing.Size(76, 15)
        DesignacaoLabel.TabIndex = 3
        DesignacaoLabel.Text = "Designação:"
        '
        'ModalidadeLabel
        '
        ModalidadeLabel.AutoSize = True
        ModalidadeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModalidadeLabel.Location = New System.Drawing.Point(24, 128)
        ModalidadeLabel.Name = "ModalidadeLabel"
        ModalidadeLabel.Size = New System.Drawing.Size(76, 15)
        ModalidadeLabel.TabIndex = 5
        ModalidadeLabel.Text = "Modalidade:"
        '
        'CoordenadorLabel
        '
        CoordenadorLabel.AutoSize = True
        CoordenadorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CoordenadorLabel.Location = New System.Drawing.Point(24, 157)
        CoordenadorLabel.Name = "CoordenadorLabel"
        CoordenadorLabel.Size = New System.Drawing.Size(82, 15)
        CoordenadorLabel.TabIndex = 7
        CoordenadorLabel.Text = "Coordenador:"
        '
        'DiaSemanaLabel
        '
        DiaSemanaLabel.AutoSize = True
        DiaSemanaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DiaSemanaLabel.Location = New System.Drawing.Point(24, 187)
        DiaSemanaLabel.Name = "DiaSemanaLabel"
        DiaSemanaLabel.Size = New System.Drawing.Size(79, 15)
        DiaSemanaLabel.TabIndex = 9
        DiaSemanaLabel.Text = "Dia Semana:"
        '
        'HoraInicioLabel
        '
        HoraInicioLabel.AutoSize = True
        HoraInicioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HoraInicioLabel.Location = New System.Drawing.Point(24, 217)
        HoraInicioLabel.Name = "HoraInicioLabel"
        HoraInicioLabel.Size = New System.Drawing.Size(69, 15)
        HoraInicioLabel.TabIndex = 11
        HoraInicioLabel.Text = "Hora Inicio:"
        '
        'HoraFimLabel
        '
        HoraFimLabel.AutoSize = True
        HoraFimLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HoraFimLabel.Location = New System.Drawing.Point(188, 217)
        HoraFimLabel.Name = "HoraFimLabel"
        HoraFimLabel.Size = New System.Drawing.Size(61, 15)
        HoraFimLabel.TabIndex = 13
        HoraFimLabel.Text = "Hora Fim:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorLabel.Location = New System.Drawing.Point(24, 244)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(38, 15)
        ValorLabel.TabIndex = 15
        ValorLabel.Text = "Valor:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabelaTurmasBindingSource
        '
        Me.TabelaTurmasBindingSource.DataMember = "TabelaTurmas"
        Me.TabelaTurmasBindingSource.DataSource = Me.DatabaseDataSet
        '
        'TabelaTurmasTableAdapter
        '
        Me.TabelaTurmasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TabelaModalidadesTableAdapter = Nothing
        Me.TableAdapterManager.TabelaMonitoresTableAdapter = Nothing
        Me.TableAdapterManager.TabelaQuotasTableAdapter = Nothing
        Me.TableAdapterManager.TabelaSociosTableAdapter = Me.TabelaSociosTableAdapter
        Me.TableAdapterManager.TabelaTipoSociosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTurmaAlunosTableAdapter = Me.TabelaTurmaAlunosTableAdapter
        Me.TableAdapterManager.TabelaTurmasTableAdapter = Me.TabelaTurmasTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TabelaSociosTableAdapter
        '
        Me.TabelaSociosTableAdapter.ClearBeforeFill = True
        '
        'TabelaTurmaAlunosTableAdapter
        '
        Me.TabelaTurmaAlunosTableAdapter.ClearBeforeFill = True
        '
        'txtIdTurma
        '
        Me.txtIdTurma.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaTurmasBindingSource, "IDTurma", True))
        Me.txtIdTurma.Enabled = False
        Me.txtIdTurma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdTurma.Location = New System.Drawing.Point(112, 73)
        Me.txtIdTurma.Name = "txtIdTurma"
        Me.txtIdTurma.Size = New System.Drawing.Size(70, 21)
        Me.txtIdTurma.TabIndex = 2
        '
        'txtDesignacao
        '
        Me.txtDesignacao.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaTurmasBindingSource, "Designacao", True))
        Me.txtDesignacao.Enabled = False
        Me.txtDesignacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignacao.Location = New System.Drawing.Point(112, 99)
        Me.txtDesignacao.Name = "txtDesignacao"
        Me.txtDesignacao.Size = New System.Drawing.Size(222, 21)
        Me.txtDesignacao.TabIndex = 4
        '
        'comboModalidade
        '
        Me.comboModalidade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaTurmasBindingSource, "Modalidade", True))
        Me.comboModalidade.DataSource = Me.TabelaModalidadesBindingSource
        Me.comboModalidade.DisplayMember = "Modalidade"
        Me.comboModalidade.Enabled = False
        Me.comboModalidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboModalidade.FormattingEnabled = True
        Me.comboModalidade.Location = New System.Drawing.Point(112, 125)
        Me.comboModalidade.Name = "comboModalidade"
        Me.comboModalidade.Size = New System.Drawing.Size(121, 23)
        Me.comboModalidade.TabIndex = 6
        '
        'TabelaModalidadesBindingSource
        '
        Me.TabelaModalidadesBindingSource.DataMember = "TabelaModalidades"
        Me.TabelaModalidadesBindingSource.DataSource = Me.DatabaseDataSet
        '
        'comboCoordenador
        '
        Me.comboCoordenador.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaTurmasBindingSource, "Coordenador", True))
        Me.comboCoordenador.DataSource = Me.TabelaMonitoresBindingSource
        Me.comboCoordenador.DisplayMember = "Nome"
        Me.comboCoordenador.Enabled = False
        Me.comboCoordenador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCoordenador.FormattingEnabled = True
        Me.comboCoordenador.Location = New System.Drawing.Point(112, 154)
        Me.comboCoordenador.Name = "comboCoordenador"
        Me.comboCoordenador.Size = New System.Drawing.Size(121, 23)
        Me.comboCoordenador.TabIndex = 8
        '
        'TabelaMonitoresBindingSource
        '
        Me.TabelaMonitoresBindingSource.DataMember = "TabelaMonitores"
        Me.TabelaMonitoresBindingSource.DataSource = Me.DatabaseDataSet
        '
        'comboDia
        '
        Me.comboDia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaTurmasBindingSource, "DiaSemana", True))
        Me.comboDia.Enabled = False
        Me.comboDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboDia.FormattingEnabled = True
        Me.comboDia.Items.AddRange(New Object() {"Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo"})
        Me.comboDia.Location = New System.Drawing.Point(112, 184)
        Me.comboDia.Name = "comboDia"
        Me.comboDia.Size = New System.Drawing.Size(98, 23)
        Me.comboDia.TabIndex = 10
        '
        'comboHoraInicio
        '
        Me.comboHoraInicio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaTurmasBindingSource, "HoraInicio", True))
        Me.comboHoraInicio.Enabled = False
        Me.comboHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboHoraInicio.FormattingEnabled = True
        Me.comboHoraInicio.Location = New System.Drawing.Point(112, 214)
        Me.comboHoraInicio.Name = "comboHoraInicio"
        Me.comboHoraInicio.Size = New System.Drawing.Size(70, 23)
        Me.comboHoraInicio.TabIndex = 12
        '
        'comboHoraFim
        '
        Me.comboHoraFim.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaTurmasBindingSource, "HoraFim", True))
        Me.comboHoraFim.Enabled = False
        Me.comboHoraFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboHoraFim.FormattingEnabled = True
        Me.comboHoraFim.Location = New System.Drawing.Point(265, 214)
        Me.comboHoraFim.Name = "comboHoraFim"
        Me.comboHoraFim.Size = New System.Drawing.Size(69, 23)
        Me.comboHoraFim.TabIndex = 14
        '
        'txtValor
        '
        Me.txtValor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaTurmasBindingSource, "Valor", True))
        Me.txtValor.Enabled = False
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(112, 241)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(70, 21)
        Me.txtValor.TabIndex = 16
        '
        'TabelaTurmaAlunosBindingSource
        '
        Me.TabelaTurmaAlunosBindingSource.DataMember = "TabelaTurmas_TabelaTurmaAlunos"
        Me.TabelaTurmaAlunosBindingSource.DataSource = Me.TabelaTurmasBindingSource
        '
        'grelhaPraticantes
        '
        Me.grelhaPraticantes.AutoGenerateColumns = False
        Me.grelhaPraticantes.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grelhaPraticantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grelhaPraticantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.grelhaPraticantes.DataSource = Me.TabelaTurmaAlunosBindingSource
        Me.grelhaPraticantes.Enabled = False
        Me.grelhaPraticantes.Location = New System.Drawing.Point(27, 298)
        Me.grelhaPraticantes.Name = "grelhaPraticantes"
        Me.grelhaPraticantes.Size = New System.Drawing.Size(171, 152)
        Me.grelhaPraticantes.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDTurma"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDTurma"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDSocio"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.TabelaSociosBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "IDSocio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDSocio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TabelaSociosBindingSource
        '
        Me.TabelaSociosBindingSource.DataMember = "TabelaSocios"
        Me.TabelaSociosBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.White
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNovo, Me.tsbEditar, Me.tsbAnular, Me.tsbGuardar, Me.tsbEliminar})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(649, 60)
        Me.ToolStrip.TabIndex = 22
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'tsbNovo
        '
        Me.tsbNovo.Image = CType(resources.GetObject("tsbNovo.Image"), System.Drawing.Image)
        Me.tsbNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNovo.Name = "tsbNovo"
        Me.tsbNovo.Size = New System.Drawing.Size(36, 57)
        Me.tsbNovo.Text = "Novo"
        Me.tsbNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbEditar
        '
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(44, 57)
        Me.tsbEditar.Text = "Editar"
        Me.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbAnular
        '
        Me.tsbAnular.Image = CType(resources.GetObject("tsbAnular.Image"), System.Drawing.Image)
        Me.tsbAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnular.Name = "tsbAnular"
        Me.tsbAnular.Size = New System.Drawing.Size(43, 57)
        Me.tsbAnular.Text = "Anular"
        Me.tsbAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(50, 57)
        Me.tsbGuardar.Text = "Guardar"
        Me.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(47, 57)
        Me.tsbEliminar.Text = "Eliminar"
        Me.tsbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'lstTurmas
        '
        Me.lstTurmas.DataSource = Me.TabelaTurmasBindingSource
        Me.lstTurmas.DisplayMember = "Designacao"
        Me.lstTurmas.FormattingEnabled = True
        Me.lstTurmas.Location = New System.Drawing.Point(365, 99)
        Me.lstTurmas.Name = "lstTurmas"
        Me.lstTurmas.Size = New System.Drawing.Size(247, 355)
        Me.lstTurmas.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(365, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Turmas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Praticantes"
        '
        'TabelaModalidadesTableAdapter
        '
        Me.TabelaModalidadesTableAdapter.ClearBeforeFill = True
        '
        'TabelaMonitoresTableAdapter
        '
        Me.TabelaMonitoresTableAdapter.ClearBeforeFill = True
        '
        'FrmTurmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 459)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTurmas)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.grelhaPraticantes)
        Me.Controls.Add(IDTurmaLabel)
        Me.Controls.Add(Me.txtIdTurma)
        Me.Controls.Add(DesignacaoLabel)
        Me.Controls.Add(Me.txtDesignacao)
        Me.Controls.Add(ModalidadeLabel)
        Me.Controls.Add(Me.comboModalidade)
        Me.Controls.Add(CoordenadorLabel)
        Me.Controls.Add(Me.comboCoordenador)
        Me.Controls.Add(DiaSemanaLabel)
        Me.Controls.Add(Me.comboDia)
        Me.Controls.Add(HoraInicioLabel)
        Me.Controls.Add(Me.comboHoraInicio)
        Me.Controls.Add(HoraFimLabel)
        Me.Controls.Add(Me.comboHoraFim)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.txtValor)
        Me.Name = "FrmTurmas"
        Me.Text = "Turmas"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelaTurmasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelaModalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelaMonitoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelaTurmaAlunosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grelhaPraticantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelaSociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As WindowsApplication1.DatabaseDataSet
    Friend WithEvents TabelaTurmasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabelaTurmasTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaTurmasTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtIdTurma As System.Windows.Forms.TextBox
    Friend WithEvents txtDesignacao As System.Windows.Forms.TextBox
    Friend WithEvents comboModalidade As System.Windows.Forms.ComboBox
    Friend WithEvents comboCoordenador As System.Windows.Forms.ComboBox
    Friend WithEvents comboDia As System.Windows.Forms.ComboBox
    Friend WithEvents comboHoraInicio As System.Windows.Forms.ComboBox
    Friend WithEvents comboHoraFim As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents TabelaTurmaAlunosTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaTurmaAlunosTableAdapter
    Friend WithEvents TabelaTurmaAlunosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grelhaPraticantes As System.Windows.Forms.DataGridView
    Friend WithEvents TabelaSociosTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaSociosTableAdapter
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabelaSociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents lstTurmas As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabelaModalidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabelaModalidadesTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaModalidadesTableAdapter
    Friend WithEvents TabelaMonitoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabelaMonitoresTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaMonitoresTableAdapter
End Class
