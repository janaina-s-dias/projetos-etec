Imports System.Data.SqlClient
Public Class Conta
    Private Sub btn_pesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar.Click
        'Dim conexao As New SqlConnection("Data Source=VSTUDIO-SQL;Initial Catalog=bdContas;Integrated Security=True")
        Dim conexao As New SqlConnection("Data Source=VMSEPLAN-0218\SQLEXPRESS;Initial Catalog=bdContas;Integrated Security=True")
        Dim comando As New SqlCommand
        Dim dr As SqlDataReader
        comando.Connection = conexao
        conexao.Open()
        comando.CommandText = "select cd_agencia,nm_agencia,cd_ContaCorrente,cd_cpfTitular,nm_titular,cd_banco,nm_banco from tb_conta where cd_ContaCorrente = '" & txtPesquisar.Text & "' "
        comando.ExecuteNonQuery()
        dr = comando.ExecuteReader
        While (dr.Read())
            txtAgencia.Text = dr.GetInt32(0)
            txtNomeAgencia.Text = dr.GetString(1)
            txtConta.Text = dr.GetInt32(2)
            mskCpf.Text = dr.GetString(3)
            txtNomeTitular.Text = dr.GetString(4)
            txtBanco.Text = dr.GetInt32(5)
            txtNomeBanco.Text = dr.GetString(6)
        End While
        conexao.Close()
    End Sub
End Class