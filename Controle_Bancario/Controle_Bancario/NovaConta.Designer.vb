<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovaConta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.txtNomeBanco = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAgencia = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNomeAgencia = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtConta = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNomeTitular = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.mskCpf = New System.Windows.Forms.MaskedTextBox
        Me.btnCadastrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Banco"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(88, 19)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 0
        '
        'txtNomeBanco
        '
        Me.txtNomeBanco.Location = New System.Drawing.Point(285, 19)
        Me.txtNomeBanco.Name = "txtNomeBanco"
        Me.txtNomeBanco.Size = New System.Drawing.Size(155, 20)
        Me.txtNomeBanco.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome Banco"
        '
        'txtAgencia
        '
        Me.txtAgencia.Location = New System.Drawing.Point(88, 61)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(100, 20)
        Me.txtAgencia.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nº Agência"
        '
        'txtNomeAgencia
        '
        Me.txtNomeAgencia.Location = New System.Drawing.Point(285, 61)
        Me.txtNomeAgencia.Name = "txtNomeAgencia"
        Me.txtNomeAgencia.Size = New System.Drawing.Size(155, 20)
        Me.txtNomeAgencia.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nome da Agência"
        '
        'txtConta
        '
        Me.txtConta.Location = New System.Drawing.Point(88, 107)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(100, 20)
        Me.txtConta.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nº Conta "
        '
        'txtNomeTitular
        '
        Me.txtNomeTitular.Location = New System.Drawing.Point(99, 149)
        Me.txtNomeTitular.Name = "txtNomeTitular"
        Me.txtNomeTitular.Size = New System.Drawing.Size(341, 20)
        Me.txtNomeTitular.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Titular da Conta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CPF Titular"
        '
        'mskCpf
        '
        Me.mskCpf.Location = New System.Drawing.Point(288, 108)
        Me.mskCpf.Mask = "###.###.###-##"
        Me.mskCpf.Name = "mskCpf"
        Me.mskCpf.Size = New System.Drawing.Size(100, 20)
        Me.mskCpf.TabIndex = 5
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(152, 220)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(90, 23)
        Me.btnCadastrar.TabIndex = 13
        Me.btnCadastrar.Text = "CADASTRAR"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'NovaConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 255)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.mskCpf)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNomeTitular)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtConta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNomeAgencia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAgencia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomeBanco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBanco)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NovaConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NovaConta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAgencia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomeAgencia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNomeTitular As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mskCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
End Class
