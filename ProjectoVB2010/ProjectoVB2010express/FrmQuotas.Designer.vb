<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuotas
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
        Dim IDQuotaLabel As System.Windows.Forms.Label
        Dim IDSocioLabel As System.Windows.Forms.Label
        Dim DataPagamentoLabel As System.Windows.Forms.Label
        Dim MesQuotaLabel As System.Windows.Forms.Label
        Dim AnoQuotaLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQuotas))
        Me.DatabaseDataSet = New WindowsApplication1.DatabaseDataSet()
        Me.TabelaQuotasBindingSource = New System.Windows.Forms.BindingSource()
        Me.TabelaQuotasTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaQuotasTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TabelaSociosTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaSociosTableAdapter()
        Me.txtIDQuota = New System.Windows.Forms.TextBox()
        Me.comboIDSocio = New System.Windows.Forms.ComboBox()
        Me.TabelaSociosBindingSource = New System.Windows.Forms.BindingSource()
        Me.dtpDataPagamento = New System.Windows.Forms.DateTimePicker()
        Me.comboMes = New System.Windows.Forms.ComboBox()
        Me.comboAno = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsbNovo = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnular = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbListagem = New System.Windows.Forms.ToolStripButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        IDQuotaLabel = New System.Windows.Forms.Label()
        IDSocioLabel = New System.Windows.Forms.Label()
        DataPagamentoLabel = New System.Windows.Forms.Label()
        MesQuotaLabel = New System.Windows.Forms.Label()
        AnoQuotaLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDQuotaLabel
        '
        IDQuotaLabel.AutoSize = True
        IDQuotaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDQuotaLabel.Location = New System.Drawing.Point(22, 90)
        IDQuotaLabel.Name = "IDQuotaLabel"
        IDQuotaLabel.Size = New System.Drawing.Size(55, 15)
        IDQuotaLabel.TabIndex = 1
        IDQuotaLabel.Text = "IDQuota:"
        '
        'IDSocioLabel
        '
        IDSocioLabel.AutoSize = True
        IDSocioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDSocioLabel.Location = New System.Drawing.Point(22, 116)
        IDSocioLabel.Name = "IDSocioLabel"
        IDSocioLabel.Size = New System.Drawing.Size(56, 15)
        IDSocioLabel.TabIndex = 3
        IDSocioLabel.Text = "ID Sócio:"
        '
        'DataPagamentoLabel
        '
        DataPagamentoLabel.AutoSize = True
        DataPagamentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataPagamentoLabel.Location = New System.Drawing.Point(22, 144)
        DataPagamentoLabel.Name = "DataPagamentoLabel"
        DataPagamentoLabel.Size = New System.Drawing.Size(120, 15)
        DataPagamentoLabel.TabIndex = 5
        DataPagamentoLabel.Text = "Data do Pagamento:"
        '
        'MesQuotaLabel
        '
        MesQuotaLabel.AutoSize = True
        MesQuotaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MesQuotaLabel.Location = New System.Drawing.Point(22, 169)
        MesQuotaLabel.Name = "MesQuotaLabel"
        MesQuotaLabel.Size = New System.Drawing.Size(87, 15)
        MesQuotaLabel.TabIndex = 7
        MesQuotaLabel.Text = "Mês da Quota:"
        '
        'AnoQuotaLabel
        '
        AnoQuotaLabel.AutoSize = True
        AnoQuotaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AnoQuotaLabel.Location = New System.Drawing.Point(22, 196)
        AnoQuotaLabel.Name = "AnoQuotaLabel"
        AnoQuotaLabel.Size = New System.Drawing.Size(84, 15)
        AnoQuotaLabel.TabIndex = 9
        AnoQuotaLabel.Text = "Ano da Quota:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorLabel.Location = New System.Drawing.Point(22, 223)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(38, 15)
        ValorLabel.TabIndex = 11
        ValorLabel.Text = "Valor:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabelaQuotasBindingSource
        '
        Me.TabelaQuotasBindingSource.DataMember = "TabelaQuotas"
        Me.TabelaQuotasBindingSource.DataSource = Me.DatabaseDataSet
        '
        'TabelaQuotasTableAdapter
        '
        Me.TabelaQuotasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TabelaModalidadesTableAdapter = Nothing
        Me.TableAdapterManager.TabelaMonitoresTableAdapter = Nothing
        Me.TableAdapterManager.TabelaQuotasTableAdapter = Me.TabelaQuotasTableAdapter
        Me.TableAdapterManager.TabelaSociosTableAdapter = Me.TabelaSociosTableAdapter
        Me.TableAdapterManager.TabelaTipoSociosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTurmaAlunosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TabelaSociosTableAdapter
        '
        Me.TabelaSociosTableAdapter.ClearBeforeFill = True
        '
        'txtIDQuota
        '
        Me.txtIDQuota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaQuotasBindingSource, "IDQuota", True))
        Me.txtIDQuota.Enabled = False
        Me.txtIDQuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDQuota.Location = New System.Drawing.Point(147, 87)
        Me.txtIDQuota.Name = "txtIDQuota"
        Me.txtIDQuota.Size = New System.Drawing.Size(65, 21)
        Me.txtIDQuota.TabIndex = 2
        '
        'comboIDSocio
        '
        Me.comboIDSocio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaQuotasBindingSource, "IDSocio", True))
        Me.comboIDSocio.DataSource = Me.TabelaSociosBindingSource
        Me.comboIDSocio.DisplayMember = "IDSocio"
        Me.comboIDSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboIDSocio.Enabled = False
        Me.comboIDSocio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboIDSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboIDSocio.FormattingEnabled = True
        Me.comboIDSocio.Location = New System.Drawing.Point(147, 113)
        Me.comboIDSocio.Name = "comboIDSocio"
        Me.comboIDSocio.Size = New System.Drawing.Size(65, 23)
        Me.comboIDSocio.TabIndex = 4
        '
        'TabelaSociosBindingSource
        '
        Me.TabelaSociosBindingSource.DataMember = "TabelaSocios"
        Me.TabelaSociosBindingSource.DataSource = Me.DatabaseDataSet
        '
        'dtpDataPagamento
        '
        Me.dtpDataPagamento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TabelaQuotasBindingSource, "DataPagamento", True))
        Me.dtpDataPagamento.Enabled = False
        Me.dtpDataPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataPagamento.Location = New System.Drawing.Point(147, 140)
        Me.dtpDataPagamento.Name = "dtpDataPagamento"
        Me.dtpDataPagamento.Size = New System.Drawing.Size(115, 21)
        Me.dtpDataPagamento.TabIndex = 6
        Me.dtpDataPagamento.Value = New Date(2010, 5, 31, 0, 0, 0, 0)
        '
        'comboMes
        '
        Me.comboMes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaQuotasBindingSource, "MesQuota", True))
        Me.comboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMes.Enabled = False
        Me.comboMes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMes.FormattingEnabled = True
        Me.comboMes.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.comboMes.Location = New System.Drawing.Point(147, 166)
        Me.comboMes.Name = "comboMes"
        Me.comboMes.Size = New System.Drawing.Size(115, 23)
        Me.comboMes.TabIndex = 8
        '
        'comboAno
        '
        Me.comboAno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaQuotasBindingSource, "AnoQuota", True))
        Me.comboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAno.Enabled = False
        Me.comboAno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboAno.FormattingEnabled = True
        Me.comboAno.Location = New System.Drawing.Point(147, 193)
        Me.comboAno.Name = "comboAno"
        Me.comboAno.Size = New System.Drawing.Size(78, 23)
        Me.comboAno.TabIndex = 10
        '
        'txtValor
        '
        Me.txtValor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaQuotasBindingSource, "Valor", True))
        Me.txtValor.Enabled = False
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(147, 220)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(78, 21)
        Me.txtValor.TabIndex = 12
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.White
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNovo, Me.tsbEditar, Me.tsbAnular, Me.tsbGuardar, Me.tsbEliminar, Me.ToolStripSeparator1, Me.tsbListagem})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(439, 62)
        Me.ToolStrip.TabIndex = 22
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'tsbNovo
        '
        Me.tsbNovo.Image = CType(resources.GetObject("tsbNovo.Image"), System.Drawing.Image)
        Me.tsbNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNovo.Name = "tsbNovo"
        Me.tsbNovo.Size = New System.Drawing.Size(40, 59)
        Me.tsbNovo.Text = "Novo"
        Me.tsbNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbEditar
        '
        Me.tsbEditar.Image = CType(resources.GetObject("tsbEditar.Image"), System.Drawing.Image)
        Me.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(44, 59)
        Me.tsbEditar.Text = "Editar"
        Me.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbAnular
        '
        Me.tsbAnular.Image = CType(resources.GetObject("tsbAnular.Image"), System.Drawing.Image)
        Me.tsbAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnular.Name = "tsbAnular"
        Me.tsbAnular.Size = New System.Drawing.Size(46, 59)
        Me.tsbAnular.Text = "Anular"
        Me.tsbAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(53, 59)
        Me.tsbGuardar.Text = "Guardar"
        Me.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(54, 59)
        Me.tsbEliminar.Text = "Eliminar"
        Me.tsbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 62)
        '
        'tsbListagem
        '
        Me.tsbListagem.Image = CType(resources.GetObject("tsbListagem.Image"), System.Drawing.Image)
        Me.tsbListagem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbListagem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbListagem.Name = "tsbListagem"
        Me.tsbListagem.Size = New System.Drawing.Size(59, 59)
        Me.tsbListagem.Text = "Listagem"
        Me.tsbListagem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.TabelaQuotasBindingSource
        Me.ListBox1.DisplayMember = "IDQuota"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(303, 100)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(98, 147)
        Me.ListBox1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Lista das Quotas"
        '
        'FrmQuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 272)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(IDQuotaLabel)
        Me.Controls.Add(Me.txtIDQuota)
        Me.Controls.Add(IDSocioLabel)
        Me.Controls.Add(Me.comboIDSocio)
        Me.Controls.Add(DataPagamentoLabel)
        Me.Controls.Add(Me.dtpDataPagamento)
        Me.Controls.Add(MesQuotaLabel)
        Me.Controls.Add(Me.comboMes)
        Me.Controls.Add(AnoQuotaLabel)
        Me.Controls.Add(Me.comboAno)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.txtValor)
        Me.Name = "FrmQuotas"
        Me.Text = "Quotas"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As WindowsApplication1.DatabaseDataSet
    Friend WithEvents TabelaQuotasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabelaQuotasTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaQuotasTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtIDQuota As System.Windows.Forms.TextBox
    Friend WithEvents comboIDSocio As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDataPagamento As System.Windows.Forms.DateTimePicker
    Friend WithEvents comboMes As System.Windows.Forms.ComboBox
    Friend WithEvents comboAno As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbListagem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabelaSociosTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaSociosTableAdapter
    Friend WithEvents TabelaSociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
