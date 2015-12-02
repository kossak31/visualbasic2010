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
        Me.lbdataentrada = New System.Windows.Forms.Label()
        Me.lbdatasaida = New System.Windows.Forms.Label()
        Me.lbhoraentrada = New System.Windows.Forms.Label()
        Me.lbhorasaida = New System.Windows.Forms.Label()
        Me.lbpagar = New System.Windows.Forms.Label()
        Me.bttentrada = New System.Windows.Forms.Button()
        Me.bttsaida = New System.Windows.Forms.Button()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbdataentrada
        '
        Me.lbdataentrada.AutoSize = True
        Me.lbdataentrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbdataentrada.Location = New System.Drawing.Point(118, 69)
        Me.lbdataentrada.Name = "lbdataentrada"
        Me.lbdataentrada.Size = New System.Drawing.Size(41, 15)
        Me.lbdataentrada.TabIndex = 0
        Me.lbdataentrada.Text = "Label1"
        '
        'lbdatasaida
        '
        Me.lbdatasaida.AutoSize = True
        Me.lbdatasaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbdatasaida.Location = New System.Drawing.Point(114, 99)
        Me.lbdatasaida.Name = "lbdatasaida"
        Me.lbdatasaida.Size = New System.Drawing.Size(41, 15)
        Me.lbdatasaida.TabIndex = 1
        Me.lbdatasaida.Text = "Label2"
        '
        'lbhoraentrada
        '
        Me.lbhoraentrada.AutoSize = True
        Me.lbhoraentrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbhoraentrada.Location = New System.Drawing.Point(189, 74)
        Me.lbhoraentrada.Name = "lbhoraentrada"
        Me.lbhoraentrada.Size = New System.Drawing.Size(41, 15)
        Me.lbhoraentrada.TabIndex = 2
        Me.lbhoraentrada.Text = "Label3"
        '
        'lbhorasaida
        '
        Me.lbhorasaida.AutoSize = True
        Me.lbhorasaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbhorasaida.Location = New System.Drawing.Point(192, 99)
        Me.lbhorasaida.Name = "lbhorasaida"
        Me.lbhorasaida.Size = New System.Drawing.Size(41, 15)
        Me.lbhorasaida.TabIndex = 3
        Me.lbhorasaida.Text = "Label4"
        '
        'lbpagar
        '
        Me.lbpagar.AutoSize = True
        Me.lbpagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbpagar.Location = New System.Drawing.Point(231, 166)
        Me.lbpagar.Name = "lbpagar"
        Me.lbpagar.Size = New System.Drawing.Size(33, 15)
        Me.lbpagar.TabIndex = 4
        Me.lbpagar.Text = "Valor"
        '
        'bttentrada
        '
        Me.bttentrada.Location = New System.Drawing.Point(13, 64)
        Me.bttentrada.Name = "bttentrada"
        Me.bttentrada.Size = New System.Drawing.Size(75, 23)
        Me.bttentrada.TabIndex = 5
        Me.bttentrada.Text = "Entrada"
        Me.bttentrada.UseVisualStyleBackColor = True
        '
        'bttsaida
        '
        Me.bttsaida.Enabled = False
        Me.bttsaida.Location = New System.Drawing.Point(13, 94)
        Me.bttsaida.Name = "bttsaida"
        Me.bttsaida.Size = New System.Drawing.Size(75, 23)
        Me.bttsaida.TabIndex = 6
        Me.bttsaida.Text = "Saida"
        Me.bttsaida.UseVisualStyleBackColor = True
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(39, 166)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 286)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.bttsaida)
        Me.Controls.Add(Me.bttentrada)
        Me.Controls.Add(Me.lbpagar)
        Me.Controls.Add(Me.lbhorasaida)
        Me.Controls.Add(Me.lbhoraentrada)
        Me.Controls.Add(Me.lbdatasaida)
        Me.Controls.Add(Me.lbdataentrada)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbdataentrada As System.Windows.Forms.Label
    Friend WithEvents lbdatasaida As System.Windows.Forms.Label
    Friend WithEvents lbhoraentrada As System.Windows.Forms.Label
    Friend WithEvents lbhorasaida As System.Windows.Forms.Label
    Friend WithEvents lbpagar As System.Windows.Forms.Label
    Friend WithEvents bttentrada As System.Windows.Forms.Button
    Friend WithEvents bttsaida As System.Windows.Forms.Button
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox

End Class
