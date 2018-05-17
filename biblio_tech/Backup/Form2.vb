Imports System.Data.SqlClient
Public Class Form2
    Private Sub btn_cadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cadastrar.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btn_pesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
    End Sub
End Class