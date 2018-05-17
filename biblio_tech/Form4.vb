Imports System.Data.SqlClient
Public Class Form4
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        If txt_codigo.Text <> "" Then
            If Not IsNumeric(txt_codigo.Text) Then
                MessageBox.Show("Digite apenas números!")
                txt_codigo.Clear()
                txt_codigo.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        'Dim conexao As New SqlConnection("Data Source=SQLEXPRESS;Initial Catalog=bibio_tech;User ID=sa; Password=sql123")
        Dim conexao As New SqlConnection("Data Source=VMSEPLAN-0218\SQLEXPRESS;Initial Catalog=bibio_tech;Integrated Security=True")
        Dim sql_pesquisa As String
        sql_pesquisa = "SELECT  nm_livro ,nm_autor ,nm_editora ,ds_assunto FROM tb_livro where cd_livro= '" & txt_codigo.Text & "'"
        Dim comando_pesquisa As New SqlCommand(sql_pesquisa, conexao)
        Dim dr As SqlDataReader
        conexao.Open()
        dr = comando_pesquisa.ExecuteReader
        While (dr.Read())

            txt_titulo.Text = dr.GetString(1)
            txt_autor.Text = dr.GetString(2)
            txt_editora.Text = dr.GetString(3)
            txt_assunto.Text = dr.GetString(4)
        End While
        conexao.Close()
    End Sub

End Class