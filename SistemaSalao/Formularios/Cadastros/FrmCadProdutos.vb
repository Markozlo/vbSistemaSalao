Public Class FrmCadProdutos


    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
    End Sub


    Sub HabilitarCampos()
        txtNome.Enabled = True
        txtDescricao.Enabled = True
        txtValor.Enabled = True
        txtQuant.Enabled = True
        cbFornecedor.Enabled = True
        btnAddImagem.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtDescricao.Enabled = False
        txtValor.Enabled = False
        txtQuant.Enabled = False
        cbFornecedor.Enabled = False
        btnAddImagem.Enabled = False
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click


        If txtNome.Text <> "" Then
            Try
                MsgBox("Salvo com Sucesso!!", MsgBoxStyle.Information, "Dados Salvo")
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
        txtDescricao.Text = ""
        txtValor.Text = ""
        txtQuant.Text = ""
        img.Image = My.Resources.sem_foto
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        HabilitarCampos()
        BtnEditar.Enabled = True
        btnExcluir.Enabled = True
    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If txtNome.Text <> "" Then
            Try
                MsgBox("Editado com Sucesso!!", MsgBoxStyle.Information, "Dados Editado")
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
                MsgBox("Excluido com Sucesso!!", MsgBoxStyle.Information, "Dados Apagados")
                DesabilitarCampos()
                BtnEditar.Enabled = False
                btnExcluir.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao excluir!!" + ex.Message)
            End Try

        End If
    End Sub

    Private Sub BtnAddImagem_Click(sender As Object, e As EventArgs) Handles btnAddImagem.Click
        Dim dlgImagem As FileDialog = New OpenFileDialog
        dlgImagem.Filter = "Arquivo de Imagem(*.jpg; *.bmp; *.png)|*.jpg;*.bmp;*.png"

        If (dlgImagem.ShowDialog) = DialogResult.OK Then
            MsgBox("Escolhi uma imagem")
        Else
            MsgBox("cancelou")
        End If

    End Sub
End Class