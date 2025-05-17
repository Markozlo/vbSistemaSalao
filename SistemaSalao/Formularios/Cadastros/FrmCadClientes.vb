Imports MySql.Data.MySqlClient

Public Class FrmCadClientes

    Dim cpf As String

    Private Sub FrmCadClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()

    End Sub

    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM clientes order by nome asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt

            If grid.Rows.Count > 0 Then
                FormatarGrid()
            End If



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Private Sub FormatarGrid()
        'grid.Columns(0).Visible = False
        grid.Columns(0).HeaderText = "Id"
        grid.Columns(1).HeaderText = "Nome"
        grid.Columns(2).HeaderText = "CPF"
        grid.Columns(3).HeaderText = "Endereço"
        grid.Columns(4).HeaderText = "Telefone"

        grid.Columns(3).Width = 130

    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
    End Sub

    Private Sub RbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscarCPF.Visible = False
        txtBuscarNome.Visible = True
        txtBuscarNome.Focus()
    End Sub

    Private Sub RbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        txtBuscarCPF.Visible = True
        txtBuscarNome.Visible = False
        txtBuscarCPF.Focus()
    End Sub


    Sub HabilitarCampos()
        txtNome.Enabled = True
        txtCPF.Enabled = True
        txtEndereco.Enabled = True
        txtTelefone.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtCPF.Enabled = False
        txtEndereco.Enabled = False
        txtTelefone.Enabled = False
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click


        If txtNome.Text <> "" And txtCPF.Text <> "   .   .   -" Then
            Try
                'ABRINDO A CONEXÃO
                Abrir()

                'VERIFICAR SE O CPF DO CLIENTE JÁ EXISTE
                Dim cmdCPF As MySqlCommand
                Dim readerCPF As MySqlDataReader
                Dim sqlCPF As String

                sqlCPF = "SELECT * FROM clientes WHERE cpf = '" & txtCPF.Text & "' "
                cmdCPF = New MySqlCommand(sqlCPF, con)
                readerCPF = cmdCPF.ExecuteReader

                'VERIFICAR SE ALGO FOI ENCONTRADO A PARTIR DA CONSULTA
                If readerCPF.Read = True Then
                    readerCPF.Close()
                    MsgBox("Este CPF já está cadastrado!!", MsgBoxStyle.Information, "CPF Já Cadastrado")
                    txtCPF.Focus()
                    Exit Sub
                End If

                readerCPF.Close()

                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "INSERT INTO clientes (nome, cpf, endereco, telefone) VALUES ('" & txtNome.Text & "', '" & txtCPF.Text & "', '" & txtEndereco.Text & "', '" & txtTelefone.Text & "')"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Salvo com Sucesso!!", MsgBoxStyle.Information, "Dados Salvo")
                Listar()
                DesabilitarCampos()
                btnSalvar.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao Salvar!!" + ex.Message)
            End Try

        Else
            MsgBox("Preencha os Campos!!", MsgBoxStyle.Information, "Prencha os Dados")
            txtNome.Focus()
        End If





    End Sub


    Sub Limpar()
        txtNome.Text = ""
        txtCPF.Text = ""
        txtEndereco.Text = ""
        txtTelefone.Text = ""
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        HabilitarCampos()
        BtnEditar.Enabled = True
        btnExcluir.Enabled = True

        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        txtNome.Text = grid.CurrentRow.Cells(1).Value
        txtCPF.Text = grid.CurrentRow.Cells(2).Value
        txtEndereco.Text = grid.CurrentRow.Cells(3).Value
        txtTelefone.Text = grid.CurrentRow.Cells(4).Value

        cpf = grid.CurrentRow.Cells(2).Value

    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If txtNome.Text <> "" And txtCPF.Text <> "   .   .   -" Then
            Try

                'ABRINDO A CONEXÃO
                Abrir()

                'VERIFICAR SE O CPF DO CLIENTE JÁ EXISTE
                Dim cmdCPF As MySqlCommand
                Dim readerCPF As MySqlDataReader
                Dim sqlCPF As String

                sqlCPF = "SELECT * FROM clientes WHERE cpf = '" & txtCPF.Text & "' "
                cmdCPF = New MySqlCommand(sqlCPF, con)
                readerCPF = cmdCPF.ExecuteReader

                'VERIFICAR SE ALGO FOI ENCONTRADO A PARTIR DA CONSULTA
                If readerCPF.Read = True And txtCPF.Text <> cpf Then
                    readerCPF.Close()
                    MsgBox("Este CPF já está cadastrado!!", MsgBoxStyle.Information, "CPF Já Cadastrado")
                    txtCPF.Focus()
                    Exit Sub
                End If

                readerCPF.Close()

                'PROGRAMANDO EDIÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE clientes SET nome = '" & txtNome.Text & "', cpf = '" & txtCPF.Text & "', endereco = '" & txtEndereco.Text & "', telefone = '" & txtTelefone.Text & "' where id = '" & txtCodigo.Text & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Editado com Sucesso!!", MsgBoxStyle.Information, "Dados Editado")
                Listar()
                DesabilitarCampos()
                BtnEditar.Enabled = False
                btnExcluir.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao editar!!" + ex.Message)
            End Try

        Else
            MsgBox("Preencha os Campos!!", MsgBoxStyle.Information, "Prencha os Dados")
            txtNome.Focus()
        End If

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If MsgBox("Deseja excluir o registro?", vbYesNo, "Escolha a Opção") = vbYes Then

            Try
                Abrir()
                'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "DELETE FROM clientes where id = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Excluido com Sucesso!!", MsgBoxStyle.Information, "Dados Apagados")
                Listar()
                DesabilitarCampos()
                BtnEditar.Enabled = False
                btnExcluir.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao excluir!!" + ex.Message)
            End Try

        End If
    End Sub

    Private Sub TxtBuscarNome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNome.TextChanged
        BuscarNome
    End Sub

    Sub BuscarNome()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM clientes where nome LIKE '" & txtBuscarNome.Text & "%' order by nome asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt


            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub


    Sub BuscarCPF()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM clientes where cpf = '" & txtBuscarCPF.Text & "' order by nome asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt


            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub TxtBuscarCPF_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCPF.TextChanged
        If txtBuscarCPF.Text <> "   .   .   -" Then
            BuscarCPF()
        Else
            Listar()
        End If

    End Sub


End Class