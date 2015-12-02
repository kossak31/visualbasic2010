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
        Me.bttinserir = New System.Windows.Forms.Button()
        Me.bttremover = New System.Windows.Forms.Button()
        Me.lstlista = New System.Windows.Forms.ListBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstQueue = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'bttinserir
        '
        Me.bttinserir.Location = New System.Drawing.Point(65, 69)
        Me.bttinserir.Name = "bttinserir"
        Me.bttinserir.Size = New System.Drawing.Size(75, 23)
        Me.bttinserir.TabIndex = 0
        Me.bttinserir.Text = "Button1"
        Me.bttinserir.UseVisualStyleBackColor = True
        '
        'bttremover
        '
        Me.bttremover.Location = New System.Drawing.Point(191, 68)
        Me.bttremover.Name = "bttremover"
        Me.bttremover.Size = New System.Drawing.Size(75, 23)
        Me.bttremover.TabIndex = 1
        Me.bttremover.Text = "Button2"
        Me.bttremover.UseVisualStyleBackColor = True
        '
        'lstlista
        '
        Me.lstlista.FormattingEnabled = True
        Me.lstlista.Location = New System.Drawing.Point(51, 152)
        Me.lstlista.Name = "lstlista"
        Me.lstlista.Size = New System.Drawing.Size(120, 95)
        Me.lstlista.TabIndex = 2
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(51, 28)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(100, 20)
        Me.txtnome.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(381, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Queue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstQueue
        '
        Me.lstQueue.FormattingEnabled = True
        Me.lstQueue.Location = New System.Drawing.Point(352, 152)
        Me.lstQueue.Name = "lstQueue"
        Me.lstQueue.Size = New System.Drawing.Size(120, 95)
        Me.lstQueue.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 273)
        Me.Controls.Add(Me.lstQueue)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.lstlista)
        Me.Controls.Add(Me.bttremover)
        Me.Controls.Add(Me.bttinserir)
        Me.Name = "Form1"
        Me.Text = "Fila FIFO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttinserir As System.Windows.Forms.Button
    Friend WithEvents bttremover As System.Windows.Forms.Button
    Friend WithEvents lstlista As System.Windows.Forms.ListBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstQueue As System.Windows.Forms.ListBox

End Class
