<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSistema
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabelaTipoSociosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabelaTipoSociosBindingSource = New System.Windows.Forms.BindingSource()
        Me.DatabaseDataSet = New WindowsApplication1.DatabaseDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabelaModalidadesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabelaModalidadesBindingSource = New System.Windows.Forms.BindingSource()
        Me.TabelaTipoSociosTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaTipoSociosTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TabelaModalidadesTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaModalidadesTableAdapter()
        Me.bttSair = New System.Windows.Forms.Button()
        Me.bttGuardar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(639, 371)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabelaTipoSociosDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(631, 345)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tipo de Sócios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabelaTipoSociosDataGridView
        '
        Me.TabelaTipoSociosDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabelaTipoSociosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TabelaTipoSociosDataGridView.AutoGenerateColumns = False
        Me.TabelaTipoSociosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.TabelaTipoSociosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelaTipoSociosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TabelaTipoSociosDataGridView.DataSource = Me.TabelaTipoSociosBindingSource
        Me.TabelaTipoSociosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabelaTipoSociosDataGridView.EnableHeadersVisualStyles = False
        Me.TabelaTipoSociosDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.TabelaTipoSociosDataGridView.Name = "TabelaTipoSociosDataGridView"
        Me.TabelaTipoSociosDataGridView.Size = New System.Drawing.Size(625, 339)
        Me.TabelaTipoSociosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDTipoSocio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDTipoSocio"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 5
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TipoSocio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descrição do Tipo de Sócio"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Quota"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Valor da Quota"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 5
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'TabelaTipoSociosBindingSource
        '
        Me.TabelaTipoSociosBindingSource.DataMember = "TabelaTipoSocios"
        Me.TabelaTipoSociosBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabelaModalidadesDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(631, 345)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modalidades"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabelaModalidadesDataGridView
        '
        Me.TabelaModalidadesDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        Me.TabelaModalidadesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.TabelaModalidadesDataGridView.AutoGenerateColumns = False
        Me.TabelaModalidadesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.TabelaModalidadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelaModalidadesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TabelaModalidadesDataGridView.DataSource = Me.TabelaModalidadesBindingSource
        Me.TabelaModalidadesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabelaModalidadesDataGridView.EnableHeadersVisualStyles = False
        Me.TabelaModalidadesDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.TabelaModalidadesDataGridView.Name = "TabelaModalidadesDataGridView"
        Me.TabelaModalidadesDataGridView.Size = New System.Drawing.Size(625, 339)
        Me.TabelaModalidadesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDModalidade"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IDModalidade"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 5
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Modalidade"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descrição da Modalidade"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 300
        '
        'TabelaModalidadesBindingSource
        '
        Me.TabelaModalidadesBindingSource.DataMember = "TabelaModalidades"
        Me.TabelaModalidadesBindingSource.DataSource = Me.DatabaseDataSet
        '
        'TabelaTipoSociosTableAdapter
        '
        Me.TabelaTipoSociosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TabelaModalidadesTableAdapter = Me.TabelaModalidadesTableAdapter
        Me.TableAdapterManager.TabelaMonitoresTableAdapter = Nothing
        Me.TableAdapterManager.TabelaQuotasTableAdapter = Nothing
        Me.TableAdapterManager.TabelaSociosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTipoSociosTableAdapter = Me.TabelaTipoSociosTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TabelaModalidadesTableAdapter
        '
        Me.TabelaModalidadesTableAdapter.ClearBeforeFill = True
        '
        'bttSair
        '
        Me.bttSair.Image = Global.WindowsApplication1.My.Resources.Resources.NaoConfirmar
        Me.bttSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttSair.Location = New System.Drawing.Point(508, 389)
        Me.bttSair.Name = "bttSair"
        Me.bttSair.Size = New System.Drawing.Size(138, 35)
        Me.bttSair.TabIndex = 2
        Me.bttSair.Text = "Sair sem Guardar"
        Me.bttSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttSair.UseVisualStyleBackColor = True
        '
        'bttGuardar
        '
        Me.bttGuardar.Image = Global.WindowsApplication1.My.Resources.Resources.confirmar
        Me.bttGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttGuardar.Location = New System.Drawing.Point(382, 389)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(120, 35)
        Me.bttGuardar.TabIndex = 1
        Me.bttGuardar.Text = "Gravar e Sair"
        Me.bttGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttGuardar.UseVisualStyleBackColor = True
        '
        'FrmSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 436)
        Me.Controls.Add(Me.bttSair)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmSistema"
        Me.Text = "Sistema"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DatabaseDataSet As WindowsApplication1.DatabaseDataSet
    Friend WithEvents TabelaTipoSociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabelaTipoSociosTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaTipoSociosTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabelaTipoSociosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabelaModalidadesTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaModalidadesTableAdapter
    Friend WithEvents TabelaModalidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabelaModalidadesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents bttGuardar As System.Windows.Forms.Button
    Friend WithEvents bttSair As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
