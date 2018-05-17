<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimentacao
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMovimentacao = New System.Windows.Forms.TextBox
        Me.txtHistorico = New System.Windows.Forms.TextBox
        Me.txtValor = New System.Windows.Forms.TextBox
        Me.btnCadastrar = New System.Windows.Forms.Button
        Me.cmb_creddeb = New System.Windows.Forms.ComboBox
        Me.btn_pesquisar = New System.Windows.Forms.Button
        Me.dtm_Data = New System.Windows.Forms.DateTimePicker
        Me.txtConta = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Núm. Movimentação"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(305, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data lançamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Histórico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(434, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Credito ou Débito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 116)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Valor Movimentação"
        '
        'txtMovimentacao
        '
        Me.txtMovimentacao.Location = New System.Drawing.Point(152, 21)
        Me.txtMovimentacao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMovimentacao.Name = "txtMovimentacao"
        Me.txtMovimentacao.Size = New System.Drawing.Size(66, 22)
        Me.txtMovimentacao.TabIndex = 5
        '
        'txtHistorico
        '
        Me.txtHistorico.Location = New System.Drawing.Point(152, 64)
        Me.txtHistorico.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHistorico.Name = "txtHistorico"
        Me.txtHistorico.Size = New System.Drawing.Size(267, 22)
        Me.txtHistorico.TabIndex = 7
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(152, 113)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(132, 22)
        Me.txtValor.TabIndex = 9
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(514, 156)
        Me.btnCadastrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(108, 28)
        Me.btnCadastrar.TabIndex = 10
        Me.btnCadastrar.Text = "CADASTRAR"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'cmb_creddeb
        '
        Me.cmb_creddeb.FormattingEnabled = True
        Me.cmb_creddeb.Items.AddRange(New Object() {"C", "D"})
        Me.cmb_creddeb.Location = New System.Drawing.Point(553, 64)
        Me.cmb_creddeb.Name = "cmb_creddeb"
        Me.cmb_creddeb.Size = New System.Drawing.Size(69, 24)
        Me.cmb_creddeb.TabIndex = 11
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Location = New System.Drawing.Point(36, 156)
        Me.btn_pesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(108, 28)
        Me.btn_pesquisar.TabIndex = 12
        Me.btn_pesquisar.Text = "PESQUISAR"
        Me.btn_pesquisar.UseVisualStyleBackColor = True
        '
        'dtm_Data
        '
        Me.dtm_Data.Location = New System.Drawing.Point(422, 18)
        Me.dtm_Data.Name = "dtm_Data"
        Me.dtm_Data.Size = New System.Drawing.Size(200, 22)
        Me.dtm_Data.TabIndex = 13
        '
        'txtConta
        '
        Me.txtConta.Location = New System.Drawing.Point(389, 113)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(100, 22)
        Me.txtConta.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Nº Conta "
        '
        'Movimentacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 197)
        Me.Controls.Add(Me.txtConta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtm_Data)
        Me.Controls.Add(Me.btn_pesquisar)
        Me.Controls.Add(Me.cmb_creddeb)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtHistorico)
        Me.Controls.Add(Me.txtMovimentacao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Movimentacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimentacao"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMovimentacao As System.Windows.Forms.TextBox
    Friend WithEvents txtHistorico As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents cmb_creddeb As System.Windows.Forms.ComboBox
    Friend WithEvents btn_pesquisar As System.Windows.Forms.Button
    Friend WithEvents dtm_Data As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtConta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
