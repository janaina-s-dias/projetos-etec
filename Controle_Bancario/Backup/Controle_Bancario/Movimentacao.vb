Imports System.Data.SqlClient
Public Class Movimentacao
    Dim conexao As New SqlConnection("Data Source=VSTUDIO-SQL;Initial Catalog=bdContas;Integrated Security=True")
    Dim comando As New SqlCommand
    Dim dr As SqlDataReader
    Private Sub btnCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click
        comando.Connection = conexao
        conexao.Open()
        comando.CommandText = " INSERT INTO tb_movimentacao(cd_lancamento ,dt_lancamento,ds_historico ,ds_CreditoDebito,vl_movimentacao, cd_ContaCorrente) VALUES('" & txtMovimentacao.Text & "', '" & dtm_Data.Text & "', '" & txtHistorico.Text & "', '" & cmb_creddeb.Text & "', '" & txtValor.Text & "', '" & txtConta.Text & "')"
        conexao.Close()
        txtMovimentacao.Text = ""
        dtm_Data.Text = ""
        txtHistorico.Text = ""
        cmb_creddeb.Text = ""
        txtValor.Text = ""
        txtConta.Text = ""
        MessageBox.Show("Movimentacao cadastrada com sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btn_pesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar.Click
        'comando.Connection = conexao
        'conexao.Open()
        'comando.CommandText = "SELECT [cd_lancamento],[dt_lancamento],[ds_historico],[ds_CreditoDebito],[vl_movimentacao]FROM tb_movimentacao WHERE dt_lancamento = '" & txtDataLançamento.Text & "'"
        'dr = comando.ExecuteReader()
        'While (dr.Read())
        '    txtMovimentacao.Text = dr.GetInt32(0)
        '    txtDataLançamento.Text = dr.GetString(1)
        '    txtHistorico.Text = dr.GetString(2)
        '    cmb_creddeb.Text = dr.GetString(3)
        '    txtValor.Text = dr.GetString(4)
        'End While
        'conexao.Close()

    End Sub
End Class