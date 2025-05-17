Public Class FrmTelaPrincipal


    Private Sub FrmTelaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuPrincipal.BackColor = Color.FromArgb(209, 251, 241)
        btnAddCliente.BackColor = Color.FromArgb(230, 252, 247)
        btnAgendamento.BackColor = Color.FromArgb(230, 252, 247)
        btnVenda.BackColor = Color.FromArgb(230, 252, 247)
        btnHorarios.BackColor = Color.FromArgb(230, 252, 247)
        lblUsuario.Text = nomeFuncionario
        lblEsp.Text = especialidade


        'verificar niveis de permissão de usuários
        If especialidade = "Gerente" Then
            menuFunc.Enabled = True
        End If


    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New FrmCadClientes
        form.ShowDialog()
    End Sub

    Private Sub CadastroDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeProdutosToolStripMenuItem.Click
        Dim form = New FrmCadProdutos
        form.ShowDialog()
    End Sub

    Private Sub EspecialidadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecialidadeToolStripMenuItem.Click
        Dim form = New FrmCadEspecialidades
        form.ShowDialog()
    End Sub

    Private Sub BtnAddCliente_Click(sender As Object, e As EventArgs) Handles btnAddCliente.Click
        Dim form = New FrmCadClientes
        form.ShowDialog()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuFunc.Click
        Dim form = New FrmCadFuncionarios
        form.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim form = New FrmLogin
        Me.Hide()
        form.ShowDialog()
    End Sub

    Private Sub FrmTelaPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class