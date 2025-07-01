<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_AdminGerente
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AdminGerente))
        Me.menu = New System.Windows.Forms.PictureBox()
        Me.cms_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestãoDeFuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleDeEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lbl_vendas_totais = New System.Windows.Forms.Label()
        Me.lbl_total_faturado = New System.Windows.Forms.Label()
        Me.lbl_total_gasto = New System.Windows.Forms.Label()
        Me.lbl_lucro = New System.Windows.Forms.Label()
        Me.cms_periodo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MêsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_periodo = New System.Windows.Forms.TextBox()
        Me.titulo = New System.Windows.Forms.Label()
        Me.barradeacoes = New System.Windows.Forms.Panel()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.voltar = New System.Windows.Forms.PictureBox()
        Me.lbl_lucro2 = New System.Windows.Forms.Label()
        Me.lbl_total_gasto2 = New System.Windows.Forms.Label()
        Me.lbl_total_faturado2 = New System.Windows.Forms.Label()
        Me.lbl_vendas_totais2 = New System.Windows.Forms.Label()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_menu.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_periodo.SuspendLayout()
        Me.barradeacoes.SuspendLayout()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.Transparent
        Me.menu.BackgroundImage = Global.SGIR.My.Resources.Resources.menu
        Me.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu.Location = New System.Drawing.Point(12, 2)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(33, 33)
        Me.menu.TabIndex = 14
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
        Me.ControleDeEstoqueToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.estoque
        Me.ControleDeEstoqueToolStripMenuItem.Name = "ControleDeEstoqueToolStripMenuItem"
        Me.ControleDeEstoqueToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.ControleDeEstoqueToolStripMenuItem.Text = "Controle de Estoque"
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans SemiBold", 12.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, -9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(745, 51)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Bem vindo(a), Marcelle!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Chart1
        '
        ChartArea1.Name = "Caixa"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(190, 132)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "Caixa"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Name = "Caixa"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 103
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Caixa"
        Me.Chart1.Titles.Add(Title1)
        '
        'lbl_vendas_totais
        '
        Me.lbl_vendas_totais.AutoSize = True
        Me.lbl_vendas_totais.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vendas_totais.Location = New System.Drawing.Point(805, 283)
        Me.lbl_vendas_totais.Name = "lbl_vendas_totais"
        Me.lbl_vendas_totais.Size = New System.Drawing.Size(77, 28)
        Me.lbl_vendas_totais.TabIndex = 104
        Me.lbl_vendas_totais.Text = "Label3"
        '
        'lbl_total_faturado
        '
        Me.lbl_total_faturado.AutoSize = True
        Me.lbl_total_faturado.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_faturado.Location = New System.Drawing.Point(805, 325)
        Me.lbl_total_faturado.Name = "lbl_total_faturado"
        Me.lbl_total_faturado.Size = New System.Drawing.Size(77, 28)
        Me.lbl_total_faturado.TabIndex = 105
        Me.lbl_total_faturado.Text = "Label4"
        '
        'lbl_total_gasto
        '
        Me.lbl_total_gasto.AutoSize = True
        Me.lbl_total_gasto.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_gasto.Location = New System.Drawing.Point(805, 374)
        Me.lbl_total_gasto.Name = "lbl_total_gasto"
        Me.lbl_total_gasto.Size = New System.Drawing.Size(77, 28)
        Me.lbl_total_gasto.TabIndex = 106
        Me.lbl_total_gasto.Text = "Label4"
        Me.lbl_total_gasto.Visible = False
        '
        'lbl_lucro
        '
        Me.lbl_lucro.AutoSize = True
        Me.lbl_lucro.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lucro.Location = New System.Drawing.Point(805, 415)
        Me.lbl_lucro.Name = "lbl_lucro"
        Me.lbl_lucro.Size = New System.Drawing.Size(77, 28)
        Me.lbl_lucro.TabIndex = 107
        Me.lbl_lucro.Text = "Label4"
        Me.lbl_lucro.Visible = False
        '
        'cms_periodo
        '
        Me.cms_periodo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_periodo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiaToolStripMenuItem, Me.SemanaToolStripMenuItem, Me.MêsToolStripMenuItem, Me.AnoToolStripMenuItem, Me.TodasToolStripMenuItem})
        Me.cms_periodo.Name = "cms_periodo"
        Me.cms_periodo.Size = New System.Drawing.Size(132, 124)
        '
        'DiaToolStripMenuItem
        '
        Me.DiaToolStripMenuItem.Name = "DiaToolStripMenuItem"
        Me.DiaToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.DiaToolStripMenuItem.Text = "Dia"
        '
        'SemanaToolStripMenuItem
        '
        Me.SemanaToolStripMenuItem.Name = "SemanaToolStripMenuItem"
        Me.SemanaToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.SemanaToolStripMenuItem.Text = "Semana"
        '
        'MêsToolStripMenuItem
        '
        Me.MêsToolStripMenuItem.Name = "MêsToolStripMenuItem"
        Me.MêsToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.MêsToolStripMenuItem.Text = "Mês"
        '
        'AnoToolStripMenuItem
        '
        Me.AnoToolStripMenuItem.Name = "AnoToolStripMenuItem"
        Me.AnoToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.AnoToolStripMenuItem.Text = "Ano"
        '
        'TodasToolStripMenuItem
        '
        Me.TodasToolStripMenuItem.Name = "TodasToolStripMenuItem"
        Me.TodasToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.TodasToolStripMenuItem.Text = "Todas"
        '
        'lbl_periodo
        '
        Me.lbl_periodo.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_periodo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_periodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_periodo.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_periodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lbl_periodo.Location = New System.Drawing.Point(179, 66)
        Me.lbl_periodo.Multiline = True
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(222, 35)
        Me.lbl_periodo.TabIndex = 109
        Me.lbl_periodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'titulo
        '
        Me.titulo.BackColor = System.Drawing.Color.Transparent
        Me.titulo.Font = New System.Drawing.Font("Open Sans", 18.2!, System.Drawing.FontStyle.Bold)
        Me.titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.titulo.Location = New System.Drawing.Point(108, 38)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(745, 51)
        Me.titulo.TabIndex = 110
        Me.titulo.Text = "Análise e Relatórios de Vendas"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'barradeacoes
        '
        Me.barradeacoes.AutoSize = True
        Me.barradeacoes.BackColor = System.Drawing.Color.Transparent
        Me.barradeacoes.Controls.Add(Me.minimizar)
        Me.barradeacoes.Controls.Add(Me.sair)
        Me.barradeacoes.Controls.Add(Me.voltar)
        Me.barradeacoes.Location = New System.Drawing.Point(816, 9)
        Me.barradeacoes.Name = "barradeacoes"
        Me.barradeacoes.Size = New System.Drawing.Size(114, 33)
        Me.barradeacoes.TabIndex = 111
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
        'lbl_lucro2
        '
        Me.lbl_lucro2.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lucro2.Location = New System.Drawing.Point(588, 415)
        Me.lbl_lucro2.Name = "lbl_lucro2"
        Me.lbl_lucro2.Size = New System.Drawing.Size(110, 30)
        Me.lbl_lucro2.TabIndex = 115
        Me.lbl_lucro2.Text = "Lucro total:"
        Me.lbl_lucro2.Visible = False
        '
        'lbl_total_gasto2
        '
        Me.lbl_total_gasto2.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_gasto2.Location = New System.Drawing.Point(588, 374)
        Me.lbl_total_gasto2.Name = "lbl_total_gasto2"
        Me.lbl_total_gasto2.Size = New System.Drawing.Size(110, 30)
        Me.lbl_total_gasto2.TabIndex = 114
        Me.lbl_total_gasto2.Text = "Total gasto:"
        Me.lbl_total_gasto2.Visible = False
        '
        'lbl_total_faturado2
        '
        Me.lbl_total_faturado2.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_faturado2.Location = New System.Drawing.Point(588, 325)
        Me.lbl_total_faturado2.Name = "lbl_total_faturado2"
        Me.lbl_total_faturado2.Size = New System.Drawing.Size(180, 30)
        Me.lbl_total_faturado2.TabIndex = 113
        Me.lbl_total_faturado2.Text = "Total faturado:"
        '
        'lbl_vendas_totais2
        '
        Me.lbl_vendas_totais2.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vendas_totais2.Location = New System.Drawing.Point(588, 283)
        Me.lbl_vendas_totais2.Name = "lbl_vendas_totais2"
        Me.lbl_vendas_totais2.Size = New System.Drawing.Size(180, 30)
        Me.lbl_vendas_totais2.TabIndex = 112
        Me.lbl_vendas_totais2.Text = "Vendas totais:"
        '
        'Form_AdminGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SGIR.My.Resources.Resources.background_azul_gerente
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(942, 493)
        Me.Controls.Add(Me.lbl_lucro2)
        Me.Controls.Add(Me.lbl_total_gasto2)
        Me.Controls.Add(Me.lbl_total_faturado2)
        Me.Controls.Add(Me.lbl_vendas_totais2)
        Me.Controls.Add(Me.barradeacoes)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.lbl_periodo)
        Me.Controls.Add(Me.lbl_lucro)
        Me.Controls.Add(Me.lbl_total_gasto)
        Me.Controls.Add(Me.lbl_total_faturado)
        Me.Controls.Add(Me.lbl_vendas_totais)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_AdminGerente"
        Me.Text = "SGIR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_menu.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_periodo.ResumeLayout(False)
        Me.barradeacoes.ResumeLayout(False)
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menu As PictureBox
    Friend WithEvents cms_menu As ContextMenuStrip
    Friend WithEvents GestãoDeFuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleDeEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleDoCardápioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleDeMesasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaixaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraçõesGeraisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarCardápioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarCardápioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarDisponibilidadeDeMesasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasESaídasDoCaixaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestauranteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents EncerrarSessãoSAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents lbl_vendas_totais As Label
    Friend WithEvents lbl_total_faturado As Label
    Friend WithEvents lbl_total_gasto As Label
    Friend WithEvents lbl_lucro As Label
    Friend WithEvents cms_periodo As ContextMenuStrip
    Friend WithEvents DiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MêsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_periodo As TextBox
    Friend WithEvents titulo As Label
    Friend WithEvents barradeacoes As Panel
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents sair As PictureBox
    Friend WithEvents voltar As PictureBox
    Friend WithEvents lbl_lucro2 As Label
    Friend WithEvents lbl_total_gasto2 As Label
    Friend WithEvents lbl_total_faturado2 As Label
    Friend WithEvents lbl_vendas_totais2 As Label
End Class
