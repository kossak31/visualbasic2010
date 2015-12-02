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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LbControloBI = New System.Windows.Forms.Label()
        Me.bttCalcBI = New System.Windows.Forms.Button()
        Me.MtxtBI = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LbContribuinte = New System.Windows.Forms.Label()
        Me.LbDigitoCont = New System.Windows.Forms.Label()
        Me.bttCalcContr = New System.Windows.Forms.Button()
        Me.MtxtContribuinte = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbBI = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.TabControl1.Size = New System.Drawing.Size(313, 235)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.LbBI)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.LbControloBI)
        Me.TabPage1.Controls.Add(Me.bttCalcBI)
        Me.TabPage1.Controls.Add(Me.MtxtBI)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(305, 209)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "BI"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LbControloBI
        '
        Me.LbControloBI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbControloBI.Location = New System.Drawing.Point(87, 94)
        Me.LbControloBI.Name = "LbControloBI"
        Me.LbControloBI.Size = New System.Drawing.Size(100, 23)
        Me.LbControloBI.TabIndex = 2
        '
        'bttCalcBI
        '
        Me.bttCalcBI.Location = New System.Drawing.Point(218, 20)
        Me.bttCalcBI.Name = "bttCalcBI"
        Me.bttCalcBI.Size = New System.Drawing.Size(75, 181)
        Me.bttCalcBI.TabIndex = 1
        Me.bttCalcBI.Text = "Calcular"
        Me.bttCalcBI.UseVisualStyleBackColor = True
        '
        'MtxtBI
        '
        Me.MtxtBI.Location = New System.Drawing.Point(87, 38)
        Me.MtxtBI.Mask = "00000000"
        Me.MtxtBI.Name = "MtxtBI"
        Me.MtxtBI.Size = New System.Drawing.Size(100, 20)
        Me.MtxtBI.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.LbContribuinte)
        Me.TabPage2.Controls.Add(Me.LbDigitoCont)
        Me.TabPage2.Controls.Add(Me.bttCalcContr)
        Me.TabPage2.Controls.Add(Me.MtxtContribuinte)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(305, 209)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contribuinte"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LbContribuinte
        '
        Me.LbContribuinte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbContribuinte.Location = New System.Drawing.Point(107, 122)
        Me.LbContribuinte.Name = "LbContribuinte"
        Me.LbContribuinte.Size = New System.Drawing.Size(104, 20)
        Me.LbContribuinte.TabIndex = 3
        '
        'LbDigitoCont
        '
        Me.LbDigitoCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbDigitoCont.Location = New System.Drawing.Point(107, 75)
        Me.LbDigitoCont.Name = "LbDigitoCont"
        Me.LbDigitoCont.Size = New System.Drawing.Size(100, 23)
        Me.LbDigitoCont.TabIndex = 2
        '
        'bttCalcContr
        '
        Me.bttCalcContr.Location = New System.Drawing.Point(217, 17)
        Me.bttCalcContr.Name = "bttCalcContr"
        Me.bttCalcContr.Size = New System.Drawing.Size(75, 186)
        Me.bttCalcContr.TabIndex = 1
        Me.bttCalcContr.Text = "Calcular"
        Me.bttCalcContr.UseVisualStyleBackColor = True
        '
        'MtxtContribuinte
        '
        Me.MtxtContribuinte.Location = New System.Drawing.Point(107, 27)
        Me.MtxtContribuinte.Mask = "00000000"
        Me.MtxtContribuinte.Name = "MtxtContribuinte"
        Me.MtxtContribuinte.Size = New System.Drawing.Size(100, 20)
        Me.MtxtContribuinte.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Limpar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "nº bi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "nº arquivo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "nº contribuinte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "nº arquivo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "nº completo"
        '
        'LbBI
        '
        Me.LbBI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbBI.Location = New System.Drawing.Point(87, 164)
        Me.LbBI.Name = "LbBI"
        Me.LbBI.Size = New System.Drawing.Size(100, 23)
        Me.LbBI.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "nº completo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 279)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "bi/contribuinte"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LbControloBI As System.Windows.Forms.Label
    Friend WithEvents bttCalcBI As System.Windows.Forms.Button
    Friend WithEvents MtxtBI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LbContribuinte As System.Windows.Forms.Label
    Friend WithEvents LbDigitoCont As System.Windows.Forms.Label
    Friend WithEvents bttCalcContr As System.Windows.Forms.Button
    Friend WithEvents MtxtContribuinte As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LbBI As System.Windows.Forms.Label
End Class
