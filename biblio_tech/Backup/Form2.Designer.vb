<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btn_pesquisar = New System.Windows.Forms.Button
        Me.btn_cadastrar = New System.Windows.Forms.Button
        Me.btn_sair = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Location = New System.Drawing.Point(195, 118)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(100, 23)
        Me.btn_pesquisar.TabIndex = 0
        Me.btn_pesquisar.Text = "PESQUISAR"
        Me.btn_pesquisar.UseVisualStyleBackColor = True
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Location = New System.Drawing.Point(197, 83)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(98, 23)
        Me.btn_cadastrar.TabIndex = 1
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(197, 156)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(100, 23)
        Me.btn_sair.TabIndex = 2
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(487, 232)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.btn_pesquisar)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.Text = "BIBLIO TECH - MENU "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_pesquisar As System.Windows.Forms.Button
    Friend WithEvents btn_cadastrar As System.Windows.Forms.Button
    Friend WithEvents btn_sair As System.Windows.Forms.Button
End Class
