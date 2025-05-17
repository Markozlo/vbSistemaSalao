Imports MySql.Data.MySqlClient

Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.BackColor = Color.FromArgb(117, 207, 182)
        txtSenha.BackColor = Color.FromArgb(117, 207, 182)
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String
        Dim senha As String
        usuario = txtUsuario.Text
        senha = txtSenha.Text

        If usuario <> "" And senha <> "" Then
            Try
                Abrir()
                Dim cmd As MySqlCommand
                Dim reader As MySqlDataReader
                Dim sql As String

                sql = "SELECT * FROM funcionarios where usuario = '" & txtUsuario.Text & "' and senha = '" & txtSenha.Text & "'  "
                cmd = New MySqlCommand(sql, con)
                reader = cmd.ExecuteReader




                If reader.Read = True Then

                    'RECUPERANDO O NOME DO FUNCIONÁRIO LOGADO
                    Dim esp As String
                    Dim nome As String
                    nome = reader(1)
                    esp = reader(5)

                    nomeFuncionario = nome
                    especialidade = esp

                    reader.Close()
                    MsgBox("Bem Vindo " + nome, MsgBoxStyle.Information, "Entrando no Sistema")
                    Dim form = New FrmTelaPrincipal
                    Me.Hide()
                    form.ShowDialog()

                Else
                    MsgBox("Os dados estão incorretos!", MsgBoxStyle.Information, "Login")
                    txtUsuario.Focus()
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox("Erro ao Efetuar o Login! ", +ex.Message)
            End Try

        Else
            MsgBox("Preencha os Campos!", MsgBoxStyle.Information, "Login")
            txtUsuario.Focus()
        End If

    End Sub


End Class
