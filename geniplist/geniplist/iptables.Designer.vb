<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iptables
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.casa1 = New System.Windows.Forms.TextBox()
        Me.casa2 = New System.Windows.Forms.TextBox()
        Me.bttiptables = New System.Windows.Forms.Button()
        Me.casa3 = New System.Windows.Forms.TextBox()
        Me.casa4 = New System.Windows.Forms.TextBox()
        Me.fim4 = New System.Windows.Forms.TextBox()
        Me.fim3 = New System.Windows.Forms.TextBox()
        Me.fim2 = New System.Windows.Forms.TextBox()
        Me.fim1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.bttsave = New System.Windows.Forms.Button()
        Me.bttclean = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(52, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(499, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'casa1
        '
        Me.casa1.Location = New System.Drawing.Point(39, 85)
        Me.casa1.Name = "casa1"
        Me.casa1.Size = New System.Drawing.Size(100, 20)
        Me.casa1.TabIndex = 1
        '
        'casa2
        '
        Me.casa2.Location = New System.Drawing.Point(180, 85)
        Me.casa2.Name = "casa2"
        Me.casa2.Size = New System.Drawing.Size(100, 20)
        Me.casa2.TabIndex = 2
        '
        'bttiptables
        '
        Me.bttiptables.Location = New System.Drawing.Point(88, 285)
        Me.bttiptables.Name = "bttiptables"
        Me.bttiptables.Size = New System.Drawing.Size(75, 23)
        Me.bttiptables.TabIndex = 4
        Me.bttiptables.Text = "Gerar Lista"
        Me.bttiptables.UseVisualStyleBackColor = True
        '
        'casa3
        '
        Me.casa3.Location = New System.Drawing.Point(306, 84)
        Me.casa3.Name = "casa3"
        Me.casa3.Size = New System.Drawing.Size(100, 20)
        Me.casa3.TabIndex = 5
        '
        'casa4
        '
        Me.casa4.Location = New System.Drawing.Point(434, 84)
        Me.casa4.Name = "casa4"
        Me.casa4.Size = New System.Drawing.Size(100, 20)
        Me.casa4.TabIndex = 6
        '
        'fim4
        '
        Me.fim4.Location = New System.Drawing.Point(434, 134)
        Me.fim4.Name = "fim4"
        Me.fim4.Size = New System.Drawing.Size(100, 20)
        Me.fim4.TabIndex = 10
        '
        'fim3
        '
        Me.fim3.Location = New System.Drawing.Point(306, 134)
        Me.fim3.Name = "fim3"
        Me.fim3.Size = New System.Drawing.Size(100, 20)
        Me.fim3.TabIndex = 9
        '
        'fim2
        '
        Me.fim2.Location = New System.Drawing.Point(180, 135)
        Me.fim2.Name = "fim2"
        Me.fim2.Size = New System.Drawing.Size(100, 20)
        Me.fim2.TabIndex = 8
        '
        'fim1
        '
        Me.fim1.Location = New System.Drawing.Point(39, 135)
        Me.fim1.Name = "fim1"
        Me.fim1.Size = New System.Drawing.Size(100, 20)
        Me.fim1.TabIndex = 7
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(236, 191)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(298, 121)
        Me.ListBox1.TabIndex = 11
        '
        'bttsave
        '
        Me.bttsave.Location = New System.Drawing.Point(88, 239)
        Me.bttsave.Name = "bttsave"
        Me.bttsave.Size = New System.Drawing.Size(75, 23)
        Me.bttsave.TabIndex = 12
        Me.bttsave.Text = "Guardar"
        Me.bttsave.UseVisualStyleBackColor = True
        '
        'bttclean
        '
        Me.bttclean.Location = New System.Drawing.Point(88, 191)
        Me.bttclean.Name = "bttclean"
        Me.bttclean.Size = New System.Drawing.Size(75, 23)
        Me.bttclean.TabIndex = 13
        Me.bttclean.Text = "Limpar"
        Me.bttclean.UseVisualStyleBackColor = True
        '
        'iptables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 342)
        Me.Controls.Add(Me.bttclean)
        Me.Controls.Add(Me.bttsave)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.fim4)
        Me.Controls.Add(Me.fim3)
        Me.Controls.Add(Me.fim2)
        Me.Controls.Add(Me.fim1)
        Me.Controls.Add(Me.casa4)
        Me.Controls.Add(Me.casa3)
        Me.Controls.Add(Me.bttiptables)
        Me.Controls.Add(Me.casa2)
        Me.Controls.Add(Me.casa1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "iptables"
        Me.Text = "iptables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents casa1 As System.Windows.Forms.TextBox
    Friend WithEvents casa2 As System.Windows.Forms.TextBox
    Friend WithEvents bttiptables As System.Windows.Forms.Button
    Friend WithEvents casa3 As System.Windows.Forms.TextBox
    Friend WithEvents casa4 As System.Windows.Forms.TextBox
    Friend WithEvents fim4 As System.Windows.Forms.TextBox
    Friend WithEvents fim3 As System.Windows.Forms.TextBox
    Friend WithEvents fim2 As System.Windows.Forms.TextBox
    Friend WithEvents fim1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents bttsave As System.Windows.Forms.Button
    Friend WithEvents bttclean As System.Windows.Forms.Button
End Class
