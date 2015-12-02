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
        Me.calendario = New System.Windows.Forms.DateTimePicker()
        Me.LbSigno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calendario
        '
        Me.calendario.Location = New System.Drawing.Point(12, 2)
        Me.calendario.Name = "calendario"
        Me.calendario.Size = New System.Drawing.Size(256, 20)
        Me.calendario.TabIndex = 0
        '
        'LbSigno
        '
        Me.LbSigno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbSigno.Location = New System.Drawing.Point(274, 2)
        Me.LbSigno.Name = "LbSigno"
        Me.LbSigno.Size = New System.Drawing.Size(143, 26)
        Me.LbSigno.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 35)
        Me.Controls.Add(Me.LbSigno)
        Me.Controls.Add(Me.calendario)
        Me.Name = "Form1"
        Me.Text = "zodiaco"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents calendario As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbSigno As System.Windows.Forms.Label
End Class
