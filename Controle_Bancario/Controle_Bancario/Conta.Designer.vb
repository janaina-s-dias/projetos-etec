<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conta
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
        Me.mskCpf = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNomeTitular = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtConta = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNomeAgencia = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAgencia = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNomeBanco = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_pesquisar = New System.Windows.Forms.Button
        Me.txtPesquisar = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'mskCpf
        '
        Me.mskCpf.Location = New System.Drawing.Point(307, 183)
        Me.mskCpf.Mask = "###.###.###-##"
        Me.mskCpf.Name = "mskCpf"
        Me.mskCpf.Size = New System.Drawing.Size(100, 20)
        Me.mskCpf.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(242, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "CPF Titular"
        '
        'txtNomeTitular
        '
        Me.txtNomeTitular.Location = New System.Drawing.Point(121, 225)
        Me.txtNomeTitular.Name = "txtNomeTitular"
        Me.txtNomeTitular.Size = New System.Drawing.Size(341, 20)
        Me.txtNomeTitular.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Titular da Conta"
        '
        'txtConta
        '
        Me.txtConta.Location = New System.Drawing.Point(110, 183)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(100, 20)
        Me.txtConta.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Nº Conta "
        '
        'txtNomeAgencia
        '
        Me.txtNomeAgencia.Location = New System.Drawing.Point(307, 137)
        Me.txtNomeAgencia.Name = "txtNomeAgencia"
        Me.txtNomeAgencia.Size = New System.Drawing.Size(155, 20)
        Me.txtNomeAgencia.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Nome da Agência"
        '
        'txtAgencia
        '
        Me.txtAgencia.Location = New System.Drawing.Point(110, 140)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(100, 20)
        Me.txtAgencia.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nº Agência"
        '
        'txtNomeBanco
        '
        Me.txtNomeBanco.Location = New System.Drawing.Point(307, 95)
        Me.txtNomeBanco.Name = "txtNomeBanco"
        Me.txtNomeBanco.Size = New System.Drawing.Size(155, 20)
        Me.txtNomeBanco.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nome Banco"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(110, 95)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nº Banco"
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Location = New System.Drawing.Point(310, 26)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(124, 25)
        Me.btn_pesquisar.TabIndex = 27
        Me.btn_pesquisar.Text = "PESQUISAR"
        Me.btn_pesquisar.UseVisualStyleBackColor = True
        '
        'txtPesquisar
        '
        Me.txtPesquisar.Location = New System.Drawing.Point(110, 26)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(100, 20)
        Me.txtPesquisar.TabIndex = 28
        '
        'Conta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 313)
        Me.Controls.Add(Me.txtPesquisar)
        Me.Controls.Add(Me.btn_pesquisar)
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
        Me.Name = "Conta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mskCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNomeTitular As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtConta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNomeAgencia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAgencia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomeBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_pesquisar As System.Windows.Forms.Button
    Friend WithEvents txtPesquisar As System.Windows.Forms.TextBox
End Class
