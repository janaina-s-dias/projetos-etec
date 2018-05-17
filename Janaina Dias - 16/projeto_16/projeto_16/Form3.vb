Imports System.Data.SqlClient
Public Class Form3
    'Dim conexao As New SqlConnection("Data Source=VSTUDIO-SQL;Initial Catalog=projeto_16;;User ID=sa;Password=sql123")
    Dim conexao As New SqlConnection("Data Source=VMSEPLAN-0218\SQLEXPRESS;Initial Catalog=projeto_16;Integrated Security=True")
    Dim comando As New SqlCommand
    Dim dr As SqlDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        comando.Connection = conexao
        conexao.Open()
        comando.CommandText = "INSERT INTO tb_login(ds_login, ds_senha) VALUES('" & txtLogin.Text & "','" & txtSenha.Text & "')"
        comando.ExecuteNonQuery()
        txtlogin.Text = ""
        txtsenha.Text = ""
        conexao.Close()
        MessageBox.Show("Login cadastrado com Sucesso!", "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class