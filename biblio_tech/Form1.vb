Imports System.Data.SqlClient
Public Class Form1
    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
    
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim adaptor As New SqlClient.SqlDataAdapter
        Dim dataset As New DataSet

        'connection.ConnectionString = ("Data Source=USER-PC\SQLEXPRESS;Initial Catalog=biblio_tech;User ID=sa;Password=sql123")
        connection.ConnectionString = ("Data Source=VMSEPLAN-0218\SQLEXPRESS;Initial Catalog=biblio_tech;Integrated Security=True")

        command.CommandText = ("SELECT nm_login ,ds_senha FROM tb_func where nm_login ='" & txt_Login.Text & "' and ds_senha='" & txt_Senha.Text & "'")
        connection.Open()


        command.Connection = connection


        adaptor.SelectCommand = command
        adaptor.Fill(dataset, "0")

        Dim count = dataset.Tables(0).Rows.Count

        If count > 0 Then
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Senha ou login incorretos!!!", MsgBoxStyle.Critical)
            txt_Login.Clear()
            txt_Senha.Clear()

        End If

    End Sub
End Class
