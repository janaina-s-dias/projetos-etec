Module Sair
    Public Sub sair()
        If MessageBox.Show("Deseja mesmo sair?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
End Module
