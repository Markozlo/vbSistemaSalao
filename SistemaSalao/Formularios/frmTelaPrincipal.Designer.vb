<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTelaPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTelaPrincipal))
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFunc = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadroDeHoráriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddCliente = New System.Windows.Forms.Button()
        Me.btnAgendamento = New System.Windows.Forms.Button()
        Me.btnHorarios = New System.Windows.Forms.Button()
        Me.btnVenda = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEsp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.menuPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuPrincipal
        '
        Me.menuPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.MovimentaçõesToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(1009, 24)
        Me.menuPrincipal.TabIndex = 0
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.menuFunc, Me.ServiçosToolStripMenuItem1, Me.EspecialidadeToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Image = CType(resources.GetObject("CadastrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'menuFunc
        '
        Me.menuFunc.Enabled = False
        Me.menuFunc.Name = "menuFunc"
        Me.menuFunc.Size = New System.Drawing.Size(180, 22)
        Me.menuFunc.Text = "Funcionários"
        '
        'ServiçosToolStripMenuItem1
        '
        Me.ServiçosToolStripMenuItem1.Name = "ServiçosToolStripMenuItem1"
        Me.ServiçosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ServiçosToolStripMenuItem1.Text = "Serviços"
        '
        'EspecialidadeToolStripMenuItem
        '
        Me.EspecialidadeToolStripMenuItem.Name = "EspecialidadeToolStripMenuItem"
        Me.EspecialidadeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EspecialidadeToolStripMenuItem.Text = "Especialidade"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeProdutosToolStripMenuItem, Me.EntradasToolStripMenuItem})
        Me.ProdutosToolStripMenuItem.Image = CType(resources.GetObject("ProdutosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'CadastroDeProdutosToolStripMenuItem
        '
        Me.CadastroDeProdutosToolStripMenuItem.Name = "CadastroDeProdutosToolStripMenuItem"
        Me.CadastroDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendamentoToolStripMenuItem, Me.QuadroDeHoráriosToolStripMenuItem})
        Me.ServiçosToolStripMenuItem.Image = CType(resources.GetObject("ServiçosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'AgendamentoToolStripMenuItem
        '
        Me.AgendamentoToolStripMenuItem.Name = "AgendamentoToolStripMenuItem"
        Me.AgendamentoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AgendamentoToolStripMenuItem.Text = "Agendamento"
        '
        'QuadroDeHoráriosToolStripMenuItem
        '
        Me.QuadroDeHoráriosToolStripMenuItem.Name = "QuadroDeHoráriosToolStripMenuItem"
        Me.QuadroDeHoráriosToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.QuadroDeHoráriosToolStripMenuItem.Text = "Quadro de Horários"
        '
        'MovimentaçõesToolStripMenuItem
        '
        Me.MovimentaçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaVendaToolStripMenuItem, Me.GastosToolStripMenuItem, Me.PagamentosToolStripMenuItem})
        Me.MovimentaçõesToolStripMenuItem.Image = CType(resources.GetObject("MovimentaçõesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MovimentaçõesToolStripMenuItem.Name = "MovimentaçõesToolStripMenuItem"
        Me.MovimentaçõesToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.MovimentaçõesToolStripMenuItem.Text = "Movimentações"
        '
        'NovaVendaToolStripMenuItem
        '
        Me.NovaVendaToolStripMenuItem.Name = "NovaVendaToolStripMenuItem"
        Me.NovaVendaToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.NovaVendaToolStripMenuItem.Text = "Nova Venda"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'PagamentosToolStripMenuItem
        '
        Me.PagamentosToolStripMenuItem.Name = "PagamentosToolStripMenuItem"
        Me.PagamentosToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PagamentosToolStripMenuItem.Text = "Pagamentos"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Image = CType(resources.GetObject("RelatóriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'btnAddCliente
        '
        Me.btnAddCliente.BackColor = System.Drawing.Color.Transparent
        Me.btnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCliente.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnAddCliente.FlatAppearance.BorderSize = 0
        Me.btnAddCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew
        Me.btnAddCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCliente.Image = CType(resources.GetObject("btnAddCliente.Image"), System.Drawing.Image)
        Me.btnAddCliente.Location = New System.Drawing.Point(15, 28)
        Me.btnAddCliente.Name = "btnAddCliente"
        Me.btnAddCliente.Size = New System.Drawing.Size(65, 65)
        Me.btnAddCliente.TabIndex = 2
        Me.btnAddCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddCliente.UseVisualStyleBackColor = False
        '
        'btnAgendamento
        '
        Me.btnAgendamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgendamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgendamento.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnAgendamento.FlatAppearance.BorderSize = 0
        Me.btnAgendamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew
        Me.btnAgendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendamento.Image = CType(resources.GetObject("btnAgendamento.Image"), System.Drawing.Image)
        Me.btnAgendamento.Location = New System.Drawing.Point(91, 27)
        Me.btnAgendamento.Name = "btnAgendamento"
        Me.btnAgendamento.Size = New System.Drawing.Size(65, 65)
        Me.btnAgendamento.TabIndex = 3
        Me.btnAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgendamento.UseVisualStyleBackColor = False
        '
        'btnHorarios
        '
        Me.btnHorarios.BackColor = System.Drawing.Color.Transparent
        Me.btnHorarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHorarios.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnHorarios.FlatAppearance.BorderSize = 0
        Me.btnHorarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew
        Me.btnHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHorarios.Image = CType(resources.GetObject("btnHorarios.Image"), System.Drawing.Image)
        Me.btnHorarios.Location = New System.Drawing.Point(167, 28)
        Me.btnHorarios.Name = "btnHorarios"
        Me.btnHorarios.Size = New System.Drawing.Size(65, 65)
        Me.btnHorarios.TabIndex = 4
        Me.btnHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHorarios.UseVisualStyleBackColor = False
        '
        'btnVenda
        '
        Me.btnVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVenda.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnVenda.FlatAppearance.BorderSize = 0
        Me.btnVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew
        Me.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenda.Image = CType(resources.GetObject("btnVenda.Image"), System.Drawing.Image)
        Me.btnVenda.Location = New System.Drawing.Point(243, 28)
        Me.btnVenda.Name = "btnVenda"
        Me.btnVenda.Size = New System.Drawing.Size(65, 65)
        Me.btnVenda.TabIndex = 5
        Me.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVenda.UseVisualStyleBackColor = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Location = New System.Drawing.Point(50, 27)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblUsuario.TabIndex = 6
        Me.lblUsuario.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblEsp)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(839, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 79)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Funcionário"
        '
        'lblEsp
        '
        Me.lblEsp.AutoSize = True
        Me.lblEsp.BackColor = System.Drawing.Color.Transparent
        Me.lblEsp.Location = New System.Drawing.Point(50, 52)
        Me.lblEsp.Name = "lblEsp"
        Me.lblEsp.Size = New System.Drawing.Size(39, 13)
        Me.lblEsp.TabIndex = 7
        Me.lblEsp.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Função:"
        '
        'FrmTelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1009, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVenda)
        Me.Controls.Add(Me.btnHorarios)
        Me.Controls.Add(Me.btnAgendamento)
        Me.Controls.Add(Me.btnAddCliente)
        Me.Controls.Add(Me.menuPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menuPrincipal
        Me.Name = "FrmTelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuPrincipal As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimentaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuFunc As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EspecialidadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuadroDeHoráriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAddCliente As Button
    Friend WithEvents btnAgendamento As Button
    Friend WithEvents btnHorarios As Button
    Friend WithEvents btnVenda As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEsp As Label
End Class
