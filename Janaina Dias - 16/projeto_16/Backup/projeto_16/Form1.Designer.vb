<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnAgendar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCompromisso = New System.Windows.Forms.TextBox
        Me.mskHorario = New System.Windows.Forms.MaskedTextBox
        Me.lstCompromissos = New System.Windows.Forms.ListBox
        Me.dtmData = New System.Windows.Forms.DateTimePicker
        Me.lstHora = New System.Windows.Forms.ListBox
        Me.lstData = New System.Windows.Forms.ListBox
        Me.btnNovo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnAgendar
        '
        Me.btnAgendar.Location = New System.Drawing.Point(21, 238)
        Me.btnAgendar.Name = "btnAgendar"
        Me.btnAgendar.Size = New System.Drawing.Size(87, 23)
        Me.btnAgendar.TabIndex = 0
        Me.btnAgendar.Text = "Agendar"
        Me.btnAgendar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(354, 238)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(87, 23)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(188, 238)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(87, 23)
        Me.btnAlterar.TabIndex = 2
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Compromisso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Horário:"
        '
        'txtCompromisso
        '
        Me.txtCompromisso.Location = New System.Drawing.Point(104, 20)
        Me.txtCompromisso.Name = "txtCompromisso"
        Me.txtCompromisso.Size = New System.Drawing.Size(509, 21)
        Me.txtCompromisso.TabIndex = 7
        '
        'mskHorario
        '
        Me.mskHorario.Location = New System.Drawing.Point(188, 57)
        Me.mskHorario.Mask = "##:##h"
        Me.mskHorario.Name = "mskHorario"
        Me.mskHorario.Size = New System.Drawing.Size(75, 21)
        Me.mskHorario.TabIndex = 8
        '
        'lstCompromissos
        '
        Me.lstCompromissos.FormattingEnabled = True
        Me.lstCompromissos.Location = New System.Drawing.Point(21, 97)
        Me.lstCompromissos.Name = "lstCompromissos"
        Me.lstCompromissos.Size = New System.Drawing.Size(242, 121)
        Me.lstCompromissos.TabIndex = 9
        '
        'dtmData
        '
        Me.dtmData.Location = New System.Drawing.Point(383, 57)
        Me.dtmData.Name = "dtmData"
        Me.dtmData.Size = New System.Drawing.Size(233, 21)
        Me.dtmData.TabIndex = 10
        '
        'lstHora
        '
        Me.lstHora.FormattingEnabled = True
        Me.lstHora.Location = New System.Drawing.Point(269, 97)
        Me.lstHora.Name = "lstHora"
        Me.lstHora.Size = New System.Drawing.Size(79, 121)
        Me.lstHora.TabIndex = 11
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(354, 97)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(259, 121)
        Me.lstData.TabIndex = 12
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(526, 238)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(87, 23)
        Me.btnNovo.TabIndex = 13
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 268)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.lstHora)
        Me.Controls.Add(Me.dtmData)
        Me.Controls.Add(Me.lstCompromissos)
        Me.Controls.Add(Me.mskHorario)
        Me.Controls.Add(Me.txtCompromisso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAgendar)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "AGENDAR COMPROMISSOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgendar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCompromisso As System.Windows.Forms.TextBox
    Friend WithEvents mskHorario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lstCompromissos As System.Windows.Forms.ListBox
    Friend WithEvents dtmData As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstHora As System.Windows.Forms.ListBox
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents btnNovo As System.Windows.Forms.Button

End Class
