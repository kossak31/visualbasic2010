<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Valor = New System.Windows.Forms.Label()
        Me.Consumo = New System.Windows.Forms.Label()
        Me.TxtLitros = New System.Windows.Forms.TextBox()
        Me.TxtPreço = New System.Windows.Forms.TextBox()
        Me.TxtDistância = New System.Windows.Forms.TextBox()
        Me.bttCalcular = New System.Windows.Forms.Button()
        Me.LbValor = New System.Windows.Forms.Label()
        Me.LbConsumo2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Litros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Preço litro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Distância"
        '
        'Valor
        '
        Me.Valor.AutoSize = True
        Me.Valor.Location = New System.Drawing.Point(190, 117)
        Me.Valor.Name = "Valor"
        Me.Valor.Size = New System.Drawing.Size(31, 13)
        Me.Valor.TabIndex = 3
        Me.Valor.Text = "Valor"
        '
        'Consumo
        '
        Me.Consumo.AutoSize = True
        Me.Consumo.Location = New System.Drawing.Point(4, 117)
        Me.Consumo.Name = "Consumo"
        Me.Consumo.Size = New System.Drawing.Size(51, 13)
        Me.Consumo.TabIndex = 4
        Me.Consumo.Text = "Consumo"
        '
        'TxtLitros
        '
        Me.TxtLitros.Location = New System.Drawing.Point(61, 24)
        Me.TxtLitros.Name = "TxtLitros"
        Me.TxtLitros.Size = New System.Drawing.Size(100, 20)
        Me.TxtLitros.TabIndex = 5
        '
        'TxtPreço
        '
        Me.TxtPreço.Location = New System.Drawing.Point(61, 53)
        Me.TxtPreço.Name = "TxtPreço"
        Me.TxtPreço.Size = New System.Drawing.Size(100, 20)
        Me.TxtPreço.TabIndex = 6
        '
        'TxtDistância
        '
        Me.TxtDistância.Location = New System.Drawing.Point(61, 79)
        Me.TxtDistância.Name = "TxtDistância"
        Me.TxtDistância.Size = New System.Drawing.Size(100, 20)
        Me.TxtDistância.TabIndex = 7
        '
        'bttCalcular
        '
        Me.bttCalcular.Location = New System.Drawing.Point(247, 37)
        Me.bttCalcular.Name = "bttCalcular"
        Me.bttCalcular.Size = New System.Drawing.Size(71, 36)
        Me.bttCalcular.TabIndex = 8
        Me.bttCalcular.Text = "Calcular"
        Me.bttCalcular.UseVisualStyleBackColor = True
        '
        'LbValor
        '
        Me.LbValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbValor.Location = New System.Drawing.Point(227, 117)
        Me.LbValor.Name = "LbValor"
        Me.LbValor.Size = New System.Drawing.Size(104, 20)
        Me.LbValor.TabIndex = 9
        '
        'LbConsumo2
        '
        Me.LbConsumo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbConsumo2.Location = New System.Drawing.Point(61, 116)
        Me.LbConsumo2.Name = "LbConsumo2"
        Me.LbConsumo2.Size = New System.Drawing.Size(104, 20)
        Me.LbConsumo2.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 202)
        Me.Controls.Add(Me.LbConsumo2)
        Me.Controls.Add(Me.LbValor)
        Me.Controls.Add(Me.bttCalcular)
        Me.Controls.Add(Me.TxtDistância)
        Me.Controls.Add(Me.TxtPreço)
        Me.Controls.Add(Me.TxtLitros)
        Me.Controls.Add(Me.Consumo)
        Me.Controls.Add(Me.Valor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Formula Consumo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Valor As System.Windows.Forms.Label
    Friend WithEvents Consumo As System.Windows.Forms.Label
    Friend WithEvents TxtLitros As System.Windows.Forms.TextBox
    Friend WithEvents TxtPreço As System.Windows.Forms.TextBox
    Friend WithEvents TxtDistância As System.Windows.Forms.TextBox
    Friend WithEvents bttCalcular As System.Windows.Forms.Button
    Friend WithEvents LbValor As System.Windows.Forms.Label
    Friend WithEvents LbConsumo2 As System.Windows.Forms.Label

End Class
