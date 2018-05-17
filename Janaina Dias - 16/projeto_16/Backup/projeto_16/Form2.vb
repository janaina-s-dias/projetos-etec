Imports System.Data.SqlClient
Public Class Form2
    Dim conexao As New SqlConnection("Data Source=VSTUDIO-SQL;Initial Catalog=projeto_16;;User ID=sa;Password=sql123")
    Dim comando As New SqlCommand
    Dim dr As SqlDataReader
    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim sql As String
        Dim usuarioBanco As String = ""
        Dim senhaBanco As String = ""
        sql = "SELECT ds_login, ds_senha FROM tb_login WHERE ds_login ='" & txtLogin.Text & "' and ds_senha = '" & txtSenha.Text & "'"
        Dim comando As New SqlCommand(sql, conexao)
        Dim dr As SqlDataReader
        conexao.Open()
        dr = comando.ExecuteReader()
        While (dr.Read())
            usuarioBanco = dr.GetString(0)
            senhaBanco = dr.GetString(1)
        End While
        conexao.Close()
        If usuarioBanco.Trim() = txtLogin.Text.Trim() And senhaBanco.Trim() = txtSenha.Text.Trim() And txtLogin.Text.Trim() <> "" And txtSenha.Text.Trim() <> "" Then
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Acesso Negado!", "ERRO")
            txtLogin.Clear()
            txtSenha.Clear()
            txtLogin.Focus()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
End Class