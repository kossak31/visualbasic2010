<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonitores
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
        Dim IDMonitorLabel As System.Windows.Forms.Label
        Dim DataEntradaLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim MoradaLabel As System.Windows.Forms.Label
        Dim CPostalLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMonitores))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsbNovo = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnular = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbListagem = New System.Windows.Forms.ToolStripButton()
        Me.DatabaseDataSet = New WindowsApplication1.DatabaseDataSet()
        Me.TabelaMonitoresBindingSource = New System.Windows.Forms.BindingSource()
        Me.TabelaMonitoresTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaMonitoresTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.txtIDMonitor = New System.Windows.Forms.TextBox()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtMorada = New System.Windows.Forms.TextBox()
        Me.txtCPostal = New System.Windows.Forms.TextBox()
        Me.txtLocalidade = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lstMonitores = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        IDMonitorLabel = New System.Windows.Forms.Label()
        DataEntradaLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        MoradaLabel = New System.Windows.Forms.Label()
        CPostalLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDMonitorLabel
        '
        IDMonitorLabel.AutoSize = True
        IDMonitorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDMonitorLabel.Location = New System.Drawing.Point(12, 87)
        IDMonitorLabel.Name = "IDMonitorLabel"
        IDMonitorLabel.Size = New System.Drawing.Size(67, 15)
        IDMonitorLabel.TabIndex = 22
        IDMonitorLabel.Text = "ID Monitor:"
        '
        'DataEntradaLabel
        '
        DataEntradaLabel.AutoSize = True
        DataEntradaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataEntradaLabel.Location = New System.Drawing.Point(12, 114)
        DataEntradaLabel.Name = "DataEntradaLabel"
        DataEntradaLabel.Size = New System.Drawing.Size(82, 15)
        DataEntradaLabel.TabIndex = 24
        DataEntradaLabel.Text = "Data Entrada:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(12, 139)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(44, 15)
        NomeLabel.TabIndex = 26
        NomeLabel.Text = "Nome:"
        '
        'MoradaLabel
        '
        MoradaLabel.AutoSize = True
        MoradaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MoradaLabel.Location = New System.Drawing.Point(12, 165)
        MoradaLabel.Name = "MoradaLabel"
        MoradaLabel.Size = New System.Drawing.Size(53, 15)
        MoradaLabel.TabIndex = 28
        MoradaLabel.Text = "Morada:"
        '
        'CPostalLabel
        '
        CPostalLabel.AutoSize = True
        CPostalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPostalLabel.Location = New System.Drawing.Point(12, 191)
        CPostalLabel.Name = "CPostalLabel"
        CPostalLabel.Size = New System.Drawing.Size(86, 15)
        CPostalLabel.TabIndex = 30
        CPostalLabel.Text = "Código Postal:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(12, 217)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(58, 15)
        TelefoneLabel.TabIndex = 34
        TelefoneLabel.Text = "Telefone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(12, 243)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(42, 15)
        EmailLabel.TabIndex = 36
        EmailLabel.Text = "Email:"
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.White
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNovo, Me.tsbEditar, Me.tsbAnular, Me.tsbGuardar, Me.tsbEliminar, Me.ToolStripSeparator1, Me.tsbListagem})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(627, 62)
        Me.ToolStrip.TabIndex = 21
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
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabelaMonitoresBindingSource
        '
        Me.TabelaMonitoresBindingSource.DataMember = "TabelaMonitores"
        Me.TabelaMonitoresBindingSource.DataSource = Me.DatabaseDataSet
        '
        'TabelaMonitoresTableAdapter
        '
        Me.TabelaMonitoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TabelaModalidadesTableAdapter = Nothing
        Me.TableAdapterManager.TabelaMonitoresTableAdapter = Me.TabelaMonitoresTableAdapter
        Me.TableAdapterManager.TabelaQuotasTableAdapter = Nothing
        Me.TableAdapterManager.TabelaSociosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTipoSociosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTurmaAlunosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtIDMonitor
        '
        Me.txtIDMonitor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaMonitoresBindingSource, "IDMonitor", True))
        Me.txtIDMonitor.Enabled = False
        Me.txtIDMonitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDMonitor.Location = New System.Drawing.Point(108, 84)
        Me.txtIDMonitor.MaxLength = 5
        Me.txtIDMonitor.Name = "txtIDMonitor"
        Me.txtIDMonitor.Size = New System.Drawing.Size(49, 21)
        Me.txtIDMonitor.TabIndex = 23
        '
        'dtpData
        '
        Me.dtpData.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TabelaMonitoresBindingSource, "DataEntrada", True))
        Me.dtpData.Enabled = False
        Me.dtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(108, 110)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(95, 21)
        Me.dtpData.TabIndex = 25
        Me.dtpData.Value = New Date(2010, 5, 25, 0, 0, 0, 0)
        '
        'txtNome
        '
        Me.txtNome.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaMonitoresBindingSource, "Nome", True))
        Me.txtNome.Enabled = False
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(108, 136)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(266, 21)
        Me.txtNome.TabIndex = 27
        '
        'txtMorada
        '
        Me.txtMorada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaMonitoresBindingSource, "Morada", True))
        Me.txtMorada.Enabled = False
        Me.txtMorada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMorada.Location = New System.Drawing.Point(108, 162)
        Me.txtMorada.MaxLength = 100
        Me.txtMorada.Name = "txtMorada"
        Me.txtMorada.Size = New System.Drawing.Size(266, 21)
        Me.txtMorada.TabIndex = 29
        '
        'txtCPostal
        '
        Me.txtCPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaMonitoresBindingSource, "CPostal", True))
        Me.txtCPostal.Enabled = False
        Me.txtCPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPostal.Location = New System.Drawing.Point(108, 188)
        Me.txtCPostal.MaxLength = 8
        Me.txtCPostal.Name = "txtCPostal"
        Me.txtCPostal.Size = New System.Drawing.Size(60, 21)
        Me.txtCPostal.TabIndex = 31
        '
        'txtLocalidade
        '
        Me.txtLocalidade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaMonitoresBindingSource, "Localidade", True))
        Me.txtLocalidade.Enabled = False
        Me.txtLocalidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidade.Location = New System.Drawing.Point(174, 188)
        Me.txtLocalidade.MaxLength = 50
        Me.txtLocalidade.Name = "txtLocalidade"
        Me.txtLocalidade.Size = New System.Drawing.Size(200, 21)
        Me.txtLocalidade.TabIndex = 33
        '
        'txtTelefone
        '
        Me.txtTelefone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaMonitoresBindingSource, "Telefone", True))
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone.Location = New System.Drawing.Point(108, 214)
        Me.txtTelefone.MaxLength = 9
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(95, 21)
        Me.txtTelefone.TabIndex = 35
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabelaMonitoresBindingSource, "Email", True))
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(108, 240)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(266, 21)
        Me.txtEmail.TabIndex = 37
        '
        'lstMonitores
        '
        Me.lstMonitores.DataSource = Me.TabelaMonitoresBindingSource
        Me.lstMonitores.DisplayMember = "Nome"
        Me.lstMonitores.FormattingEnabled = True
        Me.lstMonitores.Location = New System.Drawing.Point(380, 101)
        Me.lstMonitores.Name = "lstMonitores"
        Me.lstMonitores.Size = New System.Drawing.Size(235, 160)
        Me.lstMonitores.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Lista de Monitores"
        '
        'FrmMonitores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 279)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstMonitores)
        Me.Controls.Add(IDMonitorLabel)
        Me.Controls.Add(Me.txtIDMonitor)
        Me.Controls.Add(DataEntradaLabel)
        Me.Controls.Add(Me.dtpData)
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
        Me.Controls.Add(Me.ToolStrip)
        Me.Name = "FrmMonitores"
        Me.Text = "Monitores"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbListagem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DatabaseDataSet As WindowsApplication1.DatabaseDataSet
    Friend WithEvents TabelaMonitoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabelaMonitoresTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaMonitoresTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtIDMonitor As System.Windows.Forms.TextBox
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtMorada As System.Windows.Forms.TextBox
    Friend WithEvents txtCPostal As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidade As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lstMonitores As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
