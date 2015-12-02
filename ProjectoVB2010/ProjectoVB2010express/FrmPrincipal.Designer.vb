<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbSocios = New System.Windows.Forms.ToolStripButton()
        Me.tsbMonitores = New System.Windows.Forms.ToolStripButton()
        Me.tsbTurmas = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuotas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSistema = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbJanelas = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuCascata = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIcones = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSair = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSocios, Me.tsbMonitores, Me.tsbTurmas, Me.tsbQuotas, Me.ToolStripSeparator1, Me.tsbSistema, Me.ToolStripSeparator2, Me.tsbJanelas, Me.ToolStripSeparator3, Me.tsbSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(66, 544)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbSocios
        '
        Me.tsbSocios.Image = CType(resources.GetObject("tsbSocios.Image"), System.Drawing.Image)
        Me.tsbSocios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSocios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSocios.Name = "tsbSocios"
        Me.tsbSocios.Size = New System.Drawing.Size(63, 67)
        Me.tsbSocios.Text = "Sócios"
        Me.tsbSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbMonitores
        '
        Me.tsbMonitores.Image = CType(resources.GetObject("tsbMonitores.Image"), System.Drawing.Image)
        Me.tsbMonitores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbMonitores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMonitores.Name = "tsbMonitores"
        Me.tsbMonitores.Size = New System.Drawing.Size(63, 67)
        Me.tsbMonitores.Text = "Monitores"
        Me.tsbMonitores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbMonitores.ToolTipText = "Monitores"
        '
        'tsbTurmas
        '
        Me.tsbTurmas.Image = CType(resources.GetObject("tsbTurmas.Image"), System.Drawing.Image)
        Me.tsbTurmas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbTurmas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTurmas.Name = "tsbTurmas"
        Me.tsbTurmas.Size = New System.Drawing.Size(63, 67)
        Me.tsbTurmas.Text = "Turmas"
        Me.tsbTurmas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbQuotas
        '
        Me.tsbQuotas.Image = CType(resources.GetObject("tsbQuotas.Image"), System.Drawing.Image)
        Me.tsbQuotas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbQuotas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuotas.Name = "tsbQuotas"
        Me.tsbQuotas.Size = New System.Drawing.Size(63, 67)
        Me.tsbQuotas.Text = "Quotas"
        Me.tsbQuotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(63, 6)
        '
        'tsbSistema
        '
        Me.tsbSistema.Image = CType(resources.GetObject("tsbSistema.Image"), System.Drawing.Image)
        Me.tsbSistema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSistema.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSistema.Name = "tsbSistema"
        Me.tsbSistema.Size = New System.Drawing.Size(63, 67)
        Me.tsbSistema.Text = "Sistema"
        Me.tsbSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(63, 6)
        '
        'tsbJanelas
        '
        Me.tsbJanelas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCascata, Me.mnuLado, Me.mnuIcones})
        Me.tsbJanelas.Image = CType(resources.GetObject("tsbJanelas.Image"), System.Drawing.Image)
        Me.tsbJanelas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbJanelas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbJanelas.Name = "tsbJanelas"
        Me.tsbJanelas.Size = New System.Drawing.Size(63, 67)
        Me.tsbJanelas.Text = "Janelas"
        Me.tsbJanelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnuCascata
        '
        Me.mnuCascata.Name = "mnuCascata"
        Me.mnuCascata.Size = New System.Drawing.Size(162, 22)
        Me.mnuCascata.Text = "Cascata"
        '
        'mnuLado
        '
        Me.mnuLado.Name = "mnuLado"
        Me.mnuLado.Size = New System.Drawing.Size(162, 22)
        Me.mnuLado.Text = "Lado a Lado"
        '
        'mnuIcones
        '
        Me.mnuIcones.Name = "mnuIcones"
        Me.mnuIcones.Size = New System.Drawing.Size(162, 22)
        Me.mnuIcones.Text = "Organizar icones"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(63, 6)
        '
        'tsbSair
        '
        Me.tsbSair.Image = CType(resources.GetObject("tsbSair.Image"), System.Drawing.Image)
        Me.tsbSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSair.Name = "tsbSair"
        Me.tsbSair.Size = New System.Drawing.Size(63, 67)
        Me.tsbSair.Text = "Sair"
        Me.tsbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(622, 544)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.Name = "FrmPrincipal"
        Me.Text = "Clube Desportivo Quinta do Corgo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSocios As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbMonitores As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbTurmas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSistema As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuotas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbJanelas As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents mnuCascata As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIcones As System.Windows.Forms.ToolStripMenuItem

End Class
