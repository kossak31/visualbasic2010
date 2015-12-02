<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLstQuotas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DatabaseDataSet = New WindowsApplication1.DatabaseDataSet()
        Me.TabelaQuotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabelaQuotasTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.TabelaQuotasTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TabelaQuotasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelaQuotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelaQuotasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.TabelaSociosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTipoSociosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTurmaAlunosTableAdapter = Nothing
        Me.TableAdapterManager.TabelaTurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TabelaQuotasDataGridView
        '
        Me.TabelaQuotasDataGridView.AllowUserToAddRows = False
        Me.TabelaQuotasDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabelaQuotasDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TabelaQuotasDataGridView.AutoGenerateColumns = False
        Me.TabelaQuotasDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.TabelaQuotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelaQuotasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TabelaQuotasDataGridView.DataSource = Me.TabelaQuotasBindingSource
        Me.TabelaQuotasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabelaQuotasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TabelaQuotasDataGridView.Name = "TabelaQuotasDataGridView"
        Me.TabelaQuotasDataGridView.ReadOnly = True
        Me.TabelaQuotasDataGridView.RowHeadersVisible = False
        Me.TabelaQuotasDataGridView.Size = New System.Drawing.Size(611, 321)
        Me.TabelaQuotasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDQuota"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDQuota"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDSocio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDSocio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DataPagamento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DataPagamento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MesQuota"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MesQuota"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AnoQuota"
        Me.DataGridViewTextBoxColumn5.HeaderText = "AnoQuota"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Valor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'FrmLstQuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 321)
        Me.Controls.Add(Me.TabelaQuotasDataGridView)
        Me.Name = "FrmLstQuotas"
        Me.Text = "Listagem da Quotas"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelaQuotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelaQuotasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatabaseDataSet As WindowsApplication1.DatabaseDataSet
    Friend WithEvents TabelaQuotasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabelaQuotasTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.TabelaQuotasTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabelaQuotasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
