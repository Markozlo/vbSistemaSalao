Imports MySql.Data.MySqlClient

Module Conexao

    Public con As New MySqlConnection("server=localhost; userid=root; password=; database=salao; port=;")

    Sub Abrir()
        If con.State = 0 Then
            con.Open()
        End If
    End Sub

    Sub Fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub



    'DECLAÇÃO DE VARIAVEIS GLOBAIS
    Public nomeFuncionario As String
    Public especialidade As String

End Module
