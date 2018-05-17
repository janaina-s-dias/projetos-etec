<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btn_ok = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_assunto = New System.Windows.Forms.TextBox
        Me.txt_editora = New System.Windows.Forms.TextBox
        Me.txt_autor = New System.Windows.Forms.TextBox
        Me.txt_titulo = New System.Windows.Forms.TextBox
        Me.btn_sair = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(106, 73)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(57, 23)
        Me.btn_ok.TabIndex = 0
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CÓDIGO"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(80, 30)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_assunto)
        Me.GroupBox1.Controls.Add(Me.txt_editora)
        Me.GroupBox1.Controls.Add(Me.txt_autor)
        Me.GroupBox1.Controls.Add(Me.txt_titulo)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.btn_ok)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 242)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PESQUISA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ASSUNTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "EDITORA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "AUTOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TÍTULO"
        '
        'txt_assunto
        '
        Me.txt_assunto.Location = New System.Drawing.Point(387, 163)
        Me.txt_assunto.Name = "txt_assunto"
        Me.txt_assunto.Size = New System.Drawing.Size(197, 20)
        Me.txt_assunto.TabIndex = 6
        '
        'txt_editora
        '
        Me.txt_editora.Location = New System.Drawing.Point(389, 122)
        Me.txt_editora.Name = "txt_editora"
        Me.txt_editora.Size = New System.Drawing.Size(195, 20)
        Me.txt_editora.TabIndex = 5
        '
        'txt_autor
        '
        Me.txt_autor.Location = New System.Drawing.Point(387, 86)
        Me.txt_autor.Name = "txt_autor"
        Me.txt_autor.Size = New System.Drawing.Size(197, 20)
        Me.txt_autor.TabIndex = 4
        '
        'txt_titulo
        '
        Me.txt_titulo.Location = New System.Drawing.Point(387, 43)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(197, 20)
        Me.txt_titulo.TabIndex = 3
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(39, 270)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(65, 23)
        Me.btn_sair.TabIndex = 12
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 305)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.Text = "BIBLIO TECH"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_assunto As System.Windows.Forms.TextBox
    Friend WithEvents txt_editora As System.Windows.Forms.TextBox
    Friend WithEvents txt_autor As System.Windows.Forms.TextBox
    Friend WithEvents txt_titulo As System.Windows.Forms.TextBox
    Friend WithEvents btn_sair As System.Windows.Forms.Button
End Class
