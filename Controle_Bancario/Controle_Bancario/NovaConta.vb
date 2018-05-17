Imports System.Data.SqlClient
Public Class NovaConta
    'Dim conexao As New SqlConnection("Data Source=VSTUDIO-SQL;Initial Catalog=bdContas;Integrated Security=True")
    Dim conexao As New SqlConnection("Data Source=VMSEPLAN-0218\SQLEXPRESS;Initial Catalog=bdContas;Integrated Security=True")
    'Dim conexao As New SqlConnection("Data Source=USER-PC\SQLEXPRESS;Initial Catalog=bdContas;User ID=sa;Password=sql123")

    Dim comando As New SqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click
        comando.Connection = conexao
        conexao.Open()
        comando.CommandText = "INSERT INTO tb_conta(cd_agencia,nm_agencia,cd_ContaCorrente,cd_cpfTitular,nm_titular,cd_banco,nm_banco)VALUES('" & txtAgencia.Text & "', '" & txtNomeAgencia.Text & "','" & txtConta.Text & "', '" & mskCpf.Text & "', '" & txtNomeTitular.Text & "', '" & txtBanco.Text & "', '" & txtNomeBanco.Text & "')"
        comando.ExecuteNonQuery()
        conexao.Close()
        txtAgencia.Text = ""
        txtNomeAgencia.Text = ""
        txtConta.Text = ""
        mskCpf.Text = ""
        txtNomeTitular.Text = ""
        txtBanco.Text = ""
        txtNomeBanco.Text = ""
        MessageBox.Show("Conta cadastrada com sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)



    End Sub
End Class