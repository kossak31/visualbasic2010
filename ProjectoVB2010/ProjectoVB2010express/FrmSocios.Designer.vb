<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSocios
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
        Dim IDSocioLabel As System.Windows.Forms.Label
        Dim DataEntradaLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim MoradaLabel As System.Windows.Forms.Label
        Dim CPostalLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TipoSocioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSocios))
        Me.txtIDSocio = New System.Windows.Forms.TextBox()
        Me.TabelaSociosBindingSource = New System.Windows.Forms.BindingSource()
        Me.DatabaseDataSet = New WindowsApplication1.DatabaseDataSet()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtMorada = New System.Windows.Forms.TextBox()
        Me.txtCPostal = New System.Windows.Forms.TextBox()
        Me.txtLocalidade = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.comboTipoSocio = New System.Windows.Forms.ComboBox()
        Me.TabelaTipoSociosBindingSource = New System.Windows.Forms.BindingSource()
        Me.lstNomes = New System.Windows.Forms.ListBox()
        Me.TabelaSociosTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaSociosTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsbNovo = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnular = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbListagem = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuTodosSocios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContaCorrente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuActividades = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabelaTipoSociosTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaTipoSociosTableAdapter()
        Me.dtpdata = New System.Windows.Forms.DateTimePicker()
        IDSocioLabel = New System.Windows.Forms.Label()
        DataEntradaLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        MoradaLabel = New System.Windows.Forms.Label()
        CPostalLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TipoSocioLabel = New System.Windows.Forms.Label()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDSocioLabel
        '
        IDSocioLabel.AutoSize = True
        IDSocioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDSocioLabel.Location = New System.Drawing.Point(16, 89)
        IDSocioLabel.Name = "IDSocioLabel"
        IDSocioLabel.Size = New System.Drawing.Size(56, 15)
        IDSocioLabel.TabIndex = 1
        IDSocioLabel.Text = "ID Sócio:"
        '
        'DataEntradaLabel
        '
        DataEntradaLabel.AutoSize = True
        DataEntradaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataEntradaLabel.Location = New System.Drawing.Point(16, 116)
        DataEntradaLabel.Name = "DataEntradaLabel"
        DataEntradaLabel.Size = New System.Drawing.Size(82, 15)
        DataEntradaLabel.TabIndex = 3
        DataEntradaLabel.Text = "Data Entrada:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(16, 141)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(44, 15)
        NomeLabel.TabIndex = 5
        NomeLabel.Text = "Nome:"
        '
        'MoradaLabel
        '
        MoradaLabel.AutoSize = True
        MoradaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MoradaLabel.Location = New System.Drawing.Point(16, 167)
        MoradaLabel.Name = "MoradaLabel"
        MoradaLabel.Size = New System.Drawing.Size(53, 15)
        MoradaLabel.TabIndex = 7
        MoradaLabel.Text = "Morada:"
        '
        'CPostalLabel
        '
        CPostalLabel.AutoSize = True
        CPostalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPostalLabel.Location = New System.Drawing.Point(16, 193)
        CPostalLabel.Name = "CPostalLabel"
        CPostalLabel.Size = New System.Drawing.Size(86, 15)
        CPostalLabel.TabIndex = 9
        CPostalLabel.Text = "Código Postal:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(16, 220)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(58, 15)
        TelefoneLabel.TabIndex = 13
        TelefoneLabel.Text = "Telefone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(16, 246)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(42, 15)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email:"
        '
        'TipoSocioLabel
        '
        TipoSocioLabel.AutoSize = True
        TipoSocioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoSocioLabel.Location = New System.Drawing.Point(16, 272)
        TipoSocioLabel.Name = "TipoSocioLabel"
        TipoSocioLabel.Size = New System.Drawing.Size(68, 15)
        TipoSocioLabel.TabIndex = 17
        TipoSocioLabel.Text = "Tipo Sócio:"
        '
        'txtIDSocio
        '
        Me.txtIDSocio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaSociosBindingSource, "IDSocio", True))
        Me.txtIDSocio.Enabled = False
        Me.txtIDSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDSocio.Location = New System.Drawing.Point(132, 85)
        Me.txtIDSocio.MaxLength = 5
        Me.txtIDSocio.Name = "txtIDSocio"
        Me.txtIDSocio.Size = New System.Drawing.Size(38, 21)
        Me.txtIDSocio.TabIndex = 2
        '
        'TabelaSociosBindingSource
        '
        Me.TabelaSociosBindingSource.DataMember = "TabelaSocios"
        Me.TabelaSociosBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNome
        '
        Me.txtNome.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaSociosBindingSource, "Nome", True))
        Me.txtNome.Enabled = False
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(132, 137)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(275, 21)
        Me.txtNome.TabIndex = 6
        '
        'txtMorada
        '
        Me.txtMorada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaSociosBindingSource, "Morada", True))
        Me.txtMorada.Enabled = False
        Me.txtMorada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMorada.Location = New System.Drawing.Point(132, 163)
        Me.txtMorada.MaxLength = 100
        Me.txtMorada.Name = "txtMorada"
        Me.txtMorada.Size = New System.Drawing.Size(275, 21)
        Me.txtMorada.TabIndex = 8
        '
        'txtCPostal
        '
        Me.txtCPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaSociosBindingSource, "CPostal", True))
        Me.txtCPostal.Enabled = False
        Me.txtCPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPostal.Location = New System.Drawing.Point(132, 189)
        Me.txtCPostal.MaxLength = 8
        Me.txtCPostal.Name = "txtCPostal"
        Me.txtCPostal.Size = New System.Drawing.Size(69, 21)
        Me.txtCPostal.TabIndex = 10
        '
        'txtLocalidade
        '
        Me.txtLocalidade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaSociosBindingSource, "Localidade", True))
        Me.txtLocalidade.Enabled = False
        Me.txtLocalidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidade.Location = New System.Drawing.Point(207, 189)
        Me.txtLocalidade.MaxLength = 50
        Me.txtLocalidade.Name = "txtLocalidade"
        Me.txtLocalidade.Size = New System.Drawing.Size(200, 21)
        Me.txtLocalidade.TabIndex = 12
        '
        'txtTelefone
        '
        Me.txtTelefone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaSociosBindingSource, "Telefone", True))
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone.Location = New System.Drawing.Point(132, 216)
        Me.txtTelefone.MaxLength = 9
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(100, 21)
        Me.txtTelefone.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaSociosBindingSource, "Email", True))
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(132, 242)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(275, 21)
        Me.txtEmail.TabIndex = 16
        '
        'comboTipoSocio
        '
        Me.comboTipoSocio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaSociosBindingSource, "TipoSocio", True))
        Me.comboTipoSocio.DataSource = Me.TabelaTipoSociosBindingSource
        Me.comboTipoSocio.DisplayMember = "IDTipoSocio"
        Me.comboTipoSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTipoSocio.Enabled = False
        Me.comboTipoSocio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.comboTipoSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboTipoSocio.FormattingEnabled = True
        Me.comboTipoSocio.Location = New System.Drawing.Point(132, 268)
        Me.comboTipoSocio.Name = "comboTipoSocio"
        Me.comboTipoSocio.Size = New System.Drawing.Size(38, 23)
        Me.comboTipoSocio.TabIndex = 18
        '
        'TabelaTipoSociosBindingSource
        '
        Me.TabelaTipoSociosBindingSource.DataMember = "TabelaTipoSocios"
        Me.TabelaTipoSociosBindingSource.DataSource = Me.DatabaseDataSet
        '
        'lstNomes
        '
        Me.lstNomes.DataSource = Me.TabelaSociosBindingSource
        Me.lstNomes.DisplayMember = "Nome"
        Me.lstNomes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNomes.FormattingEnabled = True
        Me.lstNomes.ItemHeight = 15
        Me.lstNomes.Location = New System.Drawing.Point(413, 103)
        Me.lstNomes.Name = "lstNomes"
        Me.lstNomes.Size = New System.Drawing.Size(217, 184)
        Me.lstNomes.TabIndex = 19
        '
        'TabelaSociosTableAdapter
        '
        Me.TabelaSociosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TabelaModalidadesTableAdapter = Nothing
        Me.TableAdapterManager.TabelaMonitoresTableAdapter = Nothing
        Me.TableAdapterManager.TabelaQuotasTableAdapter = Nothing
        Me.TableAdapterManager.TabelaSociosTableAdapter = Me.TabelaSociosTableAdapter
        Me.TableAdapterManager.TabelaTipoSociosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTurmaAlunosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.White
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNovo, Me.tsbEditar, Me.tsbAnular, Me.tsbGuardar, Me.tsbEliminar, Me.ToolStripSeparator1, Me.tsbListagem})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(650, 62)
        Me.ToolStrip.TabIndex = 20
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
        Me.tsbListagem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTodosSocios, Me.mnuContaCorrente, Me.mnuActividades})
        Me.tsbListagem.Image = CType(resources.GetObject("tsbListagem.Image"), System.Drawing.Image)
        Me.tsbListagem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbListagem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbListagem.Name = "tsbListagem"
        Me.tsbListagem.Size = New System.Drawing.Size(72, 59)
        Me.tsbListagem.Text = "Listagens"
        Me.tsbListagem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'mnuTodosSocios
        '
        Me.mnuTodosSocios.Name = "mnuTodosSocios"
        Me.mnuTodosSocios.Size = New System.Drawing.Size(159, 22)
        Me.mnuTodosSocios.Text = "Todos os Sócios"
        '
        'mnuContaCorrente
        '
        Me.mnuContaCorrente.Name = "mnuContaCorrente"
        Me.mnuContaCorrente.Size = New System.Drawing.Size(159, 22)
        Me.mnuContaCorrente.Text = "Conta Corrente"
        '
        'mnuActividades
        '
        Me.mnuActividades.Name = "mnuActividades"
        Me.mnuActividades.Size = New System.Drawing.Size(159, 22)
        Me.mnuActividades.Text = "Actividades"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(413, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Lista de Sócios"
        '
        'TabelaTipoSociosTableAdapter
        '
        Me.TabelaTipoSociosTableAdapter.ClearBeforeFill = True
        '
        'dtpdata
        '
        Me.dtpdata.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaSociosBindingSource, "DataEntrada", True))
        Me.dtpdata.Enabled = False
        Me.dtpdata.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdata.Location = New System.Drawing.Point(132, 112)
        Me.dtpdata.Name = "dtpdata"
        Me.dtpdata.Size = New System.Drawing.Size(99, 20)
        Me.dtpdata.TabIndex = 22
        Me.dtpdata.Value = New Date(2010, 5, 24, 0, 0, 0, 0)
        '
        'FrmSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 311)
        Me.Controls.Add(Me.dtpdata)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.lstNomes)
        Me.Controls.Add(IDSocioLabel)
        Me.Controls.Add(Me.txtIDSocio)
        Me.Controls.Add(DataEntradaLabel)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(MoradaLabel)
        Me.Controls.Add(Me.txtMorada)
        Me.Controls.Add(CPostalLabel)
        Me.Controls.Add(Me.txtCPostal)
        Me.Controls.Add(Me.txtLocalidade)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(TipoSocioLabel)
        Me.Controls.Add(Me.comboTipoSocio)
        Me.Name = "FrmSocios"
        Me.Text = "Sócios"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As WindowsApplication1.DatabaseDataSet
    Friend WithEvents TabelaSociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabelaSociosTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaSociosTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtIDSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtMorada As System.Windows.Forms.TextBox
    Friend WithEvents txtCPostal As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidade As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents comboTipoSocio As System.Windows.Forms.ComboBox
    Friend WithEvents lstNomes As System.Windows.Forms.ListBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabelaTipoSociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabelaTipoSociosTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaTipoSociosTableAdapter
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtpdata As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsbListagem As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents mnuTodosSocios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuContaCorrente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuActividades As System.Windows.Forms.ToolStripMenuItem
End Class
