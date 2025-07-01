<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_GestaoDeFuncionarios
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_GestaoDeFuncionarios))
        Me.barradeacoes = New System.Windows.Forms.Panel()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.voltar = New System.Windows.Forms.PictureBox()
        Me.menu = New System.Windows.Forms.PictureBox()
        Me.cms_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestãoDeFuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleDeEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosEmEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarEstoqueManualmenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleDoCardápioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarCardápioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarCardápioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleDeMesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarDisponibilidadeDeMesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasESaídasDoCaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesGeraisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestauranteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoSAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.titulo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cms_pesquisa = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrimeiroNomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobrenomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CPFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CelularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDeNascimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CódigoDeFuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SituaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_buscar = New System.Windows.Forms.Label()
        Me.btn_procurar = New System.Windows.Forms.Button()
        Me.dgv_funcionarios = New System.Windows.Forms.DataGridView()
        Me.txt_pesquisar = New System.Windows.Forms.TextBox()
        Me.lbl_encontrar = New System.Windows.Forms.Label()
        Me.limpar_filtros = New System.Windows.Forms.Label()
        Me.txt_encontrar = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_opcoes = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_salvar_alteracoes = New System.Windows.Forms.Button()
        Me.barradeacoes.SuspendLayout()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_menu.SuspendLayout()
        Me.cms_pesquisa.SuspendLayout()
        CType(Me.dgv_funcionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'barradeacoes
        '
        Me.barradeacoes.AutoSize = True
        Me.barradeacoes.BackColor = System.Drawing.Color.Transparent
        Me.barradeacoes.Controls.Add(Me.minimizar)
        Me.barradeacoes.Controls.Add(Me.sair)
        Me.barradeacoes.Controls.Add(Me.voltar)
        Me.barradeacoes.Location = New System.Drawing.Point(855, 6)
        Me.barradeacoes.Name = "barradeacoes"
        Me.barradeacoes.Size = New System.Drawing.Size(114, 33)
        Me.barradeacoes.TabIndex = 112
        '
        'minimizar
        '
        Me.minimizar.BackColor = System.Drawing.Color.Transparent
        Me.minimizar.BackgroundImage = Global.SGIR.My.Resources.Resources.__
        Me.minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.Location = New System.Drawing.Point(43, 0)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(30, 30)
        Me.minimizar.TabIndex = 10
        Me.minimizar.TabStop = False
        '
        'sair
        '
        Me.sair.BackColor = System.Drawing.Color.Transparent
        Me.sair.BackgroundImage = Global.SGIR.My.Resources.Resources.x
        Me.sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sair.Location = New System.Drawing.Point(81, 0)
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(30, 30)
        Me.sair.TabIndex = 9
        Me.sair.TabStop = False
        '
        'voltar
        '
        Me.voltar.BackColor = System.Drawing.Color.Transparent
        Me.voltar.BackgroundImage = Global.SGIR.My.Resources.Resources.back
        Me.voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.voltar.Location = New System.Drawing.Point(7, 0)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(30, 30)
        Me.voltar.TabIndex = 0
        Me.voltar.TabStop = False
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.Transparent
        Me.menu.BackgroundImage = Global.SGIR.My.Resources.Resources.menu
        Me.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu.Location = New System.Drawing.Point(4, 6)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(33, 33)
        Me.menu.TabIndex = 113
        Me.menu.TabStop = False
        '
        'cms_menu
        '
        Me.cms_menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatóriosToolStripMenuItem, Me.GestãoDeFuncionáriosToolStripMenuItem, Me.ControleDeEstoqueToolStripMenuItem, Me.ControleDoCardápioToolStripMenuItem, Me.ControleDeMesasToolStripMenuItem, Me.CaixaToolStripMenuItem, Me.ConfiguraçõesGeraisToolStripMenuItem, Me.EncerrarSessãoSAIRToolStripMenuItem})
        Me.cms_menu.Name = "cms_menu"
        Me.cms_menu.Size = New System.Drawing.Size(286, 212)
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.relatorio
        Me.RelatóriosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.RelatóriosToolStripMenuItem.Text = "Análise e Relatórios de Vendas"
        '
        'GestãoDeFuncionáriosToolStripMenuItem
        '
        Me.GestãoDeFuncionáriosToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.gear
        Me.GestãoDeFuncionáriosToolStripMenuItem.Name = "GestãoDeFuncionáriosToolStripMenuItem"
        Me.GestãoDeFuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.GestãoDeFuncionáriosToolStripMenuItem.Text = "Gestão de Funcionários"
        '
        'ControleDeEstoqueToolStripMenuItem
        '
        Me.ControleDeEstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosEmEstoqueToolStripMenuItem, Me.EditarEstoqueManualmenteToolStripMenuItem, Me.EntradaESToolStripMenuItem})
        Me.ControleDeEstoqueToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.estoque
        Me.ControleDeEstoqueToolStripMenuItem.Name = "ControleDeEstoqueToolStripMenuItem"
        Me.ControleDeEstoqueToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.ControleDeEstoqueToolStripMenuItem.Text = "Controle de Estoque"
        '
        'ProdutosEmEstoqueToolStripMenuItem
        '
        Me.ProdutosEmEstoqueToolStripMenuItem.Name = "ProdutosEmEstoqueToolStripMenuItem"
        Me.ProdutosEmEstoqueToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.ProdutosEmEstoqueToolStripMenuItem.Text = "Produtos em Estoque"
        '
        'EditarEstoqueManualmenteToolStripMenuItem
        '
        Me.EditarEstoqueManualmenteToolStripMenuItem.Name = "EditarEstoqueManualmenteToolStripMenuItem"
        Me.EditarEstoqueManualmenteToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.EditarEstoqueManualmenteToolStripMenuItem.Text = "Editar Estoque Manualmente"
        '
        'EntradaESToolStripMenuItem
        '
        Me.EntradaESToolStripMenuItem.Name = "EntradaESToolStripMenuItem"
        Me.EntradaESToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.EntradaESToolStripMenuItem.Text = "Entrada e Saída de Insumos"
        '
        'ControleDoCardápioToolStripMenuItem
        '
        Me.ControleDoCardápioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarCardápioToolStripMenuItem, Me.VisualizarCardápioToolStripMenuItem})
        Me.ControleDoCardápioToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.cardapio
        Me.ControleDoCardápioToolStripMenuItem.Name = "ControleDoCardápioToolStripMenuItem"
        Me.ControleDoCardápioToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.ControleDoCardápioToolStripMenuItem.Text = "Controle do Cardápio"
        '
        'EditarCardápioToolStripMenuItem
        '
        Me.EditarCardápioToolStripMenuItem.Name = "EditarCardápioToolStripMenuItem"
        Me.EditarCardápioToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.EditarCardápioToolStripMenuItem.Text = "Editar Cardápio"
        '
        'VisualizarCardápioToolStripMenuItem
        '
        Me.VisualizarCardápioToolStripMenuItem.Name = "VisualizarCardápioToolStripMenuItem"
        Me.VisualizarCardápioToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.VisualizarCardápioToolStripMenuItem.Text = "Visualizar Cardápio"
        '
        'ControleDeMesasToolStripMenuItem
        '
        Me.ControleDeMesasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarDisponibilidadeDeMesasToolStripMenuItem})
        Me.ControleDeMesasToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.table
        Me.ControleDeMesasToolStripMenuItem.Name = "ControleDeMesasToolStripMenuItem"
        Me.ControleDeMesasToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.ControleDeMesasToolStripMenuItem.Text = "Controle de Mesas"
        '
        'EditarDisponibilidadeDeMesasToolStripMenuItem
        '
        Me.EditarDisponibilidadeDeMesasToolStripMenuItem.Name = "EditarDisponibilidadeDeMesasToolStripMenuItem"
        Me.EditarDisponibilidadeDeMesasToolStripMenuItem.Size = New System.Drawing.Size(307, 26)
        Me.EditarDisponibilidadeDeMesasToolStripMenuItem.Text = "Editar Disponibilidade de Mesas"
        '
        'CaixaToolStripMenuItem
        '
        Me.CaixaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradasESaídasDoCaixaToolStripMenuItem})
        Me.CaixaToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.coin
        Me.CaixaToolStripMenuItem.Name = "CaixaToolStripMenuItem"
        Me.CaixaToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.CaixaToolStripMenuItem.Text = "Caixa"
        '
        'EntradasESaídasDoCaixaToolStripMenuItem
        '
        Me.EntradasESaídasDoCaixaToolStripMenuItem.Name = "EntradasESaídasDoCaixaToolStripMenuItem"
        Me.EntradasESaídasDoCaixaToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.EntradasESaídasDoCaixaToolStripMenuItem.Text = "Entradas e Saídas do Caixa"
        '
        'ConfiguraçõesGeraisToolStripMenuItem
        '
        Me.ConfiguraçõesGeraisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestauranteToolStripMenuItem})
        Me.ConfiguraçõesGeraisToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.restaurante
        Me.ConfiguraçõesGeraisToolStripMenuItem.Name = "ConfiguraçõesGeraisToolStripMenuItem"
        Me.ConfiguraçõesGeraisToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.ConfiguraçõesGeraisToolStripMenuItem.Text = "Restaurante"
        '
        'RestauranteToolStripMenuItem
        '
        Me.RestauranteToolStripMenuItem.Name = "RestauranteToolStripMenuItem"
        Me.RestauranteToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.RestauranteToolStripMenuItem.Text = "Configurações Gerais"
        '
        'EncerrarSessãoSAIRToolStripMenuItem
        '
        Me.EncerrarSessãoSAIRToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.sair
        Me.EncerrarSessãoSAIRToolStripMenuItem.Name = "EncerrarSessãoSAIRToolStripMenuItem"
        Me.EncerrarSessãoSAIRToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.EncerrarSessãoSAIRToolStripMenuItem.Text = "Encerrar Sessão (SAIR)"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Open Sans SemiBold", 12.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(179, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(840, 25)
        Me.Label2.TabIndex = 116
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans SemiBold", 12.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(83, -12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(745, 51)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Bem vindo(a), Marcelle!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'titulo
        '
        Me.titulo.BackColor = System.Drawing.Color.Transparent
        Me.titulo.Font = New System.Drawing.Font("Open Sans", 18.2!, System.Drawing.FontStyle.Bold)
        Me.titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.titulo.Location = New System.Drawing.Point(43, 56)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(745, 51)
        Me.titulo.TabIndex = 117
        Me.titulo.Text = "Gestão de Funcionários"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'cms_pesquisa
        '
        Me.cms_pesquisa.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_pesquisa.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrimeiroNomeToolStripMenuItem, Me.SobrenomeToolStripMenuItem, Me.CPFToolStripMenuItem, Me.CelularToolStripMenuItem, Me.EmailToolStripMenuItem, Me.DataDeNascimentoToolStripMenuItem, Me.SetorToolStripMenuItem, Me.CargoToolStripMenuItem, Me.CódigoDeFuncionárioToolStripMenuItem, Me.UsuárioToolStripMenuItem, Me.SituaçãoToolStripMenuItem})
        Me.cms_pesquisa.Name = "cms_pesquisa"
        Me.cms_pesquisa.Size = New System.Drawing.Size(230, 268)
        '
        'PrimeiroNomeToolStripMenuItem
        '
        Me.PrimeiroNomeToolStripMenuItem.Name = "PrimeiroNomeToolStripMenuItem"
        Me.PrimeiroNomeToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.PrimeiroNomeToolStripMenuItem.Text = "Primeiro Nome"
        '
        'SobrenomeToolStripMenuItem
        '
        Me.SobrenomeToolStripMenuItem.Name = "SobrenomeToolStripMenuItem"
        Me.SobrenomeToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.SobrenomeToolStripMenuItem.Text = "Sobrenome"
        '
        'CPFToolStripMenuItem
        '
        Me.CPFToolStripMenuItem.Name = "CPFToolStripMenuItem"
        Me.CPFToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.CPFToolStripMenuItem.Text = "CPF"
        '
        'CelularToolStripMenuItem
        '
        Me.CelularToolStripMenuItem.Name = "CelularToolStripMenuItem"
        Me.CelularToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.CelularToolStripMenuItem.Text = "Celular"
        '
        'EmailToolStripMenuItem
        '
        Me.EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        Me.EmailToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.EmailToolStripMenuItem.Text = "Email"
        '
        'DataDeNascimentoToolStripMenuItem
        '
        Me.DataDeNascimentoToolStripMenuItem.Name = "DataDeNascimentoToolStripMenuItem"
        Me.DataDeNascimentoToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.DataDeNascimentoToolStripMenuItem.Text = "Data de Nascimento"
        '
        'SetorToolStripMenuItem
        '
        Me.SetorToolStripMenuItem.Name = "SetorToolStripMenuItem"
        Me.SetorToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.SetorToolStripMenuItem.Text = "Setor"
        '
        'CargoToolStripMenuItem
        '
        Me.CargoToolStripMenuItem.Name = "CargoToolStripMenuItem"
        Me.CargoToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.CargoToolStripMenuItem.Text = "Cargo"
        '
        'CódigoDeFuncionárioToolStripMenuItem
        '
        Me.CódigoDeFuncionárioToolStripMenuItem.Name = "CódigoDeFuncionárioToolStripMenuItem"
        Me.CódigoDeFuncionárioToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.CódigoDeFuncionárioToolStripMenuItem.Text = "Código de Funcionário"
        '
        'UsuárioToolStripMenuItem
        '
        Me.UsuárioToolStripMenuItem.Name = "UsuárioToolStripMenuItem"
        Me.UsuárioToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.UsuárioToolStripMenuItem.Text = "Usuário"
        '
        'SituaçãoToolStripMenuItem
        '
        Me.SituaçãoToolStripMenuItem.Name = "SituaçãoToolStripMenuItem"
        Me.SituaçãoToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.SituaçãoToolStripMenuItem.Text = "Situação"
        '
        'lbl_buscar
        '
        Me.lbl_buscar.AutoSize = True
        Me.lbl_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbl_buscar.Location = New System.Drawing.Point(38, 11)
        Me.lbl_buscar.Name = "lbl_buscar"
        Me.lbl_buscar.Size = New System.Drawing.Size(102, 22)
        Me.lbl_buscar.TabIndex = 119
        Me.lbl_buscar.Text = "Buscar por:"
        '
        'btn_procurar
        '
        Me.btn_procurar.ForeColor = System.Drawing.Color.Black
        Me.btn_procurar.Location = New System.Drawing.Point(1085, 3)
        Me.btn_procurar.Name = "btn_procurar"
        Me.btn_procurar.Size = New System.Drawing.Size(112, 32)
        Me.btn_procurar.TabIndex = 121
        Me.btn_procurar.Text = "PROCURAR"
        Me.btn_procurar.UseVisualStyleBackColor = True
        '
        'dgv_funcionarios
        '
        Me.dgv_funcionarios.AllowUserToAddRows = False
        Me.dgv_funcionarios.AllowUserToDeleteRows = False
        Me.dgv_funcionarios.AllowUserToResizeColumns = False
        Me.dgv_funcionarios.AllowUserToResizeRows = False
        Me.dgv_funcionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_funcionarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.dgv_funcionarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_funcionarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_funcionarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_funcionarios.Location = New System.Drawing.Point(86, 216)
        Me.dgv_funcionarios.Name = "dgv_funcionarios"
        Me.dgv_funcionarios.RowHeadersWidth = 20
        Me.dgv_funcionarios.RowTemplate.Height = 24
        Me.dgv_funcionarios.Size = New System.Drawing.Size(618, 305)
        Me.dgv_funcionarios.TabIndex = 122
        '
        'txt_pesquisar
        '
        Me.txt_pesquisar.ForeColor = System.Drawing.Color.Black
        Me.txt_pesquisar.Location = New System.Drawing.Point(158, 11)
        Me.txt_pesquisar.Name = "txt_pesquisar"
        Me.txt_pesquisar.Size = New System.Drawing.Size(310, 22)
        Me.txt_pesquisar.TabIndex = 123
        '
        'lbl_encontrar
        '
        Me.lbl_encontrar.AutoSize = True
        Me.lbl_encontrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lbl_encontrar.Location = New System.Drawing.Point(580, 14)
        Me.lbl_encontrar.Name = "lbl_encontrar"
        Me.lbl_encontrar.Size = New System.Drawing.Size(93, 22)
        Me.lbl_encontrar.TabIndex = 125
        Me.lbl_encontrar.Text = "Encontrar:"
        '
        'limpar_filtros
        '
        Me.limpar_filtros.AutoSize = True
        Me.limpar_filtros.BackColor = System.Drawing.Color.Transparent
        Me.limpar_filtros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.limpar_filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpar_filtros.Location = New System.Drawing.Point(1082, 35)
        Me.limpar_filtros.Name = "limpar_filtros"
        Me.limpar_filtros.Size = New System.Drawing.Size(78, 16)
        Me.limpar_filtros.TabIndex = 126
        Me.limpar_filtros.Text = "limpar filtros"
        '
        'txt_encontrar
        '
        Me.txt_encontrar.Location = New System.Drawing.Point(692, 11)
        Me.txt_encontrar.Name = "txt_encontrar"
        Me.txt_encontrar.Size = New System.Drawing.Size(310, 22)
        Me.txt_encontrar.TabIndex = 127
        '
        'cbo_opcoes
        '
        Me.cbo_opcoes.ForeColor = System.Drawing.Color.Black
        Me.cbo_opcoes.FormattingEnabled = True
        Me.cbo_opcoes.Location = New System.Drawing.Point(692, 11)
        Me.cbo_opcoes.Name = "cbo_opcoes"
        Me.cbo_opcoes.Size = New System.Drawing.Size(310, 24)
        Me.cbo_opcoes.TabIndex = 128
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_procurar)
        Me.Panel1.Controls.Add(Me.cbo_opcoes)
        Me.Panel1.Controls.Add(Me.lbl_encontrar)
        Me.Panel1.Controls.Add(Me.limpar_filtros)
        Me.Panel1.Controls.Add(Me.lbl_buscar)
        Me.Panel1.Controls.Add(Me.txt_encontrar)
        Me.Panel1.Controls.Add(Me.txt_pesquisar)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-9, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1202, 100)
        Me.Panel1.TabIndex = 132
        '
        'btn_salvar_alteracoes
        '
        Me.btn_salvar_alteracoes.AutoSize = True
        Me.btn_salvar_alteracoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_salvar_alteracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar_alteracoes.Font = New System.Drawing.Font("Open Sans", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_salvar_alteracoes.ForeColor = System.Drawing.Color.White
        Me.btn_salvar_alteracoes.Location = New System.Drawing.Point(728, 327)
        Me.btn_salvar_alteracoes.Name = "btn_salvar_alteracoes"
        Me.btn_salvar_alteracoes.Size = New System.Drawing.Size(164, 54)
        Me.btn_salvar_alteracoes.TabIndex = 133
        Me.btn_salvar_alteracoes.Text = "SALVAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ALTERAÇÕES"
        Me.btn_salvar_alteracoes.UseVisualStyleBackColor = False
        '
        'Form_GestaoDeFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SGIR.My.Resources.Resources.background_azul_gerente
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1260, 658)
        Me.Controls.Add(Me.btn_salvar_alteracoes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_funcionarios)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.barradeacoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_GestaoDeFuncionarios"
        Me.Text = "SGIR"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.barradeacoes.ResumeLayout(False)
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_menu.ResumeLayout(False)
        Me.cms_pesquisa.ResumeLayout(False)
        CType(Me.dgv_funcionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barradeacoes As Panel
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents sair As PictureBox
    Friend WithEvents voltar As PictureBox
    Friend WithEvents menu As PictureBox
    Friend WithEvents cms_menu As ContextMenuStrip
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestãoDeFuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleDeEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosEmEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarEstoqueManualmenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradaESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleDoCardápioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarCardápioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarCardápioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleDeMesasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarDisponibilidadeDeMesasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaixaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasESaídasDoCaixaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraçõesGeraisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestauranteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoSAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents titulo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cms_pesquisa As ContextMenuStrip
    Friend WithEvents PrimeiroNomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobrenomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CPFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CelularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataDeNascimentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CódigoDeFuncionárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SituaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_buscar As Label
    Friend WithEvents btn_procurar As Button
    Friend WithEvents dgv_funcionarios As DataGridView
    Friend WithEvents txt_pesquisar As TextBox
    Friend WithEvents lbl_encontrar As Label
    Friend WithEvents limpar_filtros As Label
    Friend WithEvents txt_encontrar As MaskedTextBox
    Friend WithEvents cbo_opcoes As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_salvar_alteracoes As Button
End Class
