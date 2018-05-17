Imports System.Data.SqlClient
Public Class Form1
    Dim conexao As New SqlConnection("Data Source=VMSEPLAN-0218\SQLEXPRESS;Initial Catalog=projeto_16;)
    Dim comando As New SqlCommand
    Dim dr As SqlDataReader
    Private Sub Agenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comando.Connection = conexao
        loadlistbox()
    End Sub
    Private Sub btnAgendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgendar.Click
        comando.Connection = conexao
        conexao.Open()
        comando.CommandText = "INSERT INTO tb_evento(ds_evento,dt_evento,hr_evento)VALUES('" & txtCompromisso.Text & "', '" & dtmData.Text & "', '" & mskHorario.Text & "')"
        comando.ExecuteNonQuery()
        conexao.Close()
        txtCompromisso.Text = ""
        dtmData.Text = ""
        mskHorario.Text = ""
        loadlistbox()
        MessageBox.Show("Evento cadastrado com Sucesso!", "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub loadlistbox()
        lstCompromissos.Items.Clear()
        lstData.Items.Clear()
        lstHora.Items.Clear()
        txtCompromisso.Text = ""
        mskHorario.Text = ""
        conexao.Open()
        comando.CommandText = "select ds_evento, dt_evento, hr_evento from tb_evento  "
        dr = comando.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read())
                lstCompromissos.Items.Add(dr("ds_evento"))
                lstData.Items.Add(dr(1))
                lstHora.Items.Add(dr(2))
            End While
        End If
        conexao.Close()
    End Sub

    Private Sub lstCompromissos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCompromissos.SelectedIndexChanged
        Dim lb As New ListBox
        lb = sender
        If lb.SelectedIndex <> -1 Then
            lstCompromissos.SelectedIndex = lb.SelectedIndex
            lstData.SelectedIndex = lb.SelectedIndex
            lstHora.SelectedIndex = lb.SelectedIndex
            txtCompromisso.Text = lstCompromissos.SelectedItem
            dtmData.Text = lstData.SelectedItem
            mskHorario.Text = lstHora.SelectedItem
        Else
            MessageBox.Show("Não existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If txtCompromisso.Text <> "" And dtmData.Text <> "" And mskHorario.Text <> "" Then
            conexao.Open()
            comando.CommandText = "update tb_evento set ds_evento = '" & txtCompromisso.Text & "', dt_evento = '" & dtmData.Text & "', hr_evento = '" & mskHorario.Text & "' where ds_evento = '" & lstCompromissos.SelectedItem & "'"
            comando.ExecuteNonQuery()
            conexao.Close()
            txtCompromisso.Text = ""
            mskHorario.Text = ""
            loadlistbox()
            MessageBox.Show("Dados Atualizados!", "ATUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Arquivo não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If txtCompromisso.Text <> "" And dtmData.Text <> "" And mskHorario.Text <> "" Then
            conexao.Open()
            If (MessageBox.Show("Apagar evento?", "APAGAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                comando.CommandText = "delete from tb_evento where ds_evento = '" & txtCompromisso.Text & "' "
                MessageBox.Show("Apagado com Sucesso!", "APAGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            comando.ExecuteNonQuery()
            conexao.Close()
            txtCompromisso.Text = ""
            mskHorario.Text = ""
            loadlistbox()
        Else
            MessageBox.Show("Arquivo não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        txtCompromisso.Text = ""
        dtmData.Text = ""
        mskHorario.Text = ""
    End Sub



    Private Sub mskHorario_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskHorario.MaskInputRejected
        If mskHorario.Text <> "" Then
            If Not IsNumeric(mskHorario.Text) Then
                MessageBox.Show("Digite apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mskHorario.Text = ""
            End If
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
