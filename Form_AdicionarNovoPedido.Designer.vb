<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_AdicionarNovoPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AdicionarNovoPedido))
        Me.menu = New System.Windows.Forms.PictureBox()
        Me.barradeacoes = New System.Windows.Forms.Panel()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.voltar = New System.Windows.Forms.PictureBox()
        Me.cms_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TelaInicialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarNovoAtendimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoSAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_numero_pedido = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.EntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PratoPriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SOBREMESAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BEBIDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_categoria = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ENTRADAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRATOPRINCIPALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SOBREMESAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BEBIDAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_itens = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barradeacoes.SuspendLayout()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_menu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_categoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.Transparent
        Me.menu.BackgroundImage = Global.SGIR.My.Resources.Resources.menu
        Me.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu.Location = New System.Drawing.Point(12, 12)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(33, 33)
        Me.menu.TabIndex = 18
        Me.menu.TabStop = False
        '
        'barradeacoes
        '
        Me.barradeacoes.AutoSize = True
        Me.barradeacoes.BackColor = System.Drawing.Color.Transparent
        Me.barradeacoes.Controls.Add(Me.minimizar)
        Me.barradeacoes.Controls.Add(Me.sair)
        Me.barradeacoes.Controls.Add(Me.voltar)
        Me.barradeacoes.Location = New System.Drawing.Point(363, 12)
        Me.barradeacoes.Name = "barradeacoes"
        Me.barradeacoes.Size = New System.Drawing.Size(114, 33)
        Me.barradeacoes.TabIndex = 17
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
        'cms_menu
        '
        Me.cms_menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TelaInicialToolStripMenuItem, Me.IniciarNovoAtendimentoToolStripMenuItem, Me.EncerrarSessãoSAIRToolStripMenuItem})
        Me.cms_menu.Name = "cms_menu"
        Me.cms_menu.Size = New System.Drawing.Size(249, 82)
        '
        'TelaInicialToolStripMenuItem
        '
        Me.TelaInicialToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.casa_machado_transparente
        Me.TelaInicialToolStripMenuItem.Name = "TelaInicialToolStripMenuItem"
        Me.TelaInicialToolStripMenuItem.Size = New System.Drawing.Size(248, 26)
        Me.TelaInicialToolStripMenuItem.Text = "Tela Inicial"
        '
        'IniciarNovoAtendimentoToolStripMenuItem
        '
        Me.IniciarNovoAtendimentoToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.adicionar_pedido2
        Me.IniciarNovoAtendimentoToolStripMenuItem.Name = "IniciarNovoAtendimentoToolStripMenuItem"
        Me.IniciarNovoAtendimentoToolStripMenuItem.Size = New System.Drawing.Size(248, 26)
        Me.IniciarNovoAtendimentoToolStripMenuItem.Text = "Iniciar novo atendimento"
        '
        'EncerrarSessãoSAIRToolStripMenuItem
        '
        Me.EncerrarSessãoSAIRToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.sair
        Me.EncerrarSessãoSAIRToolStripMenuItem.Name = "EncerrarSessãoSAIRToolStripMenuItem"
        Me.EncerrarSessãoSAIRToolStripMenuItem.Size = New System.Drawing.Size(248, 26)
        Me.EncerrarSessãoSAIRToolStripMenuItem.Text = "Encerrar Sessão (SAIR)"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btn_confirmar)
        Me.Panel1.Location = New System.Drawing.Point(51, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 500)
        Me.Panel1.TabIndex = 19
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_numero_pedido)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox2)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(64, 87)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(247, 232)
        Me.FlowLayoutPanel1.TabIndex = 30
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'lbl_numero_pedido
        '
        Me.lbl_numero_pedido.AutoSize = True
        Me.lbl_numero_pedido.BackColor = System.Drawing.Color.Transparent
        Me.lbl_numero_pedido.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_numero_pedido.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_numero_pedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lbl_numero_pedido.Location = New System.Drawing.Point(10, 10)
        Me.lbl_numero_pedido.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.lbl_numero_pedido.Name = "lbl_numero_pedido"
        Me.lbl_numero_pedido.Size = New System.Drawing.Size(97, 24)
        Me.lbl_numero_pedido.TabIndex = 27
        Me.lbl_numero_pedido.Text = "PEDIDO X:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 36)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(10, 2, 0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(225, 22)
        Me.TextBox1.TabIndex = 28
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(10, 60)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(10, 2, 0, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(225, 22)
        Me.TextBox2.TabIndex = 29
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(64, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(247, 40)
        Me.Panel3.TabIndex = 26
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.ComboBox1.Location = New System.Drawing.Point(193, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(51, 32)
        Me.ComboBox1.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "PEDIDOS DA MESA:"
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(23, 325)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(311, 63)
        Me.Panel2.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(62, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ADICIONAR OUTRO PEDIDO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.SGIR.My.Resources.Resources.adicionar_pedido2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.AutoSize = True
        Me.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_confirmar.ForeColor = System.Drawing.Color.White
        Me.btn_confirmar.Location = New System.Drawing.Point(94, 394)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(200, 65)
        Me.btn_confirmar.TabIndex = 23
        Me.btn_confirmar.Text = "CONFIRMAR"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'EntradaToolStripMenuItem
        '
        Me.EntradaToolStripMenuItem.Name = "EntradaToolStripMenuItem"
        Me.EntradaToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.EntradaToolStripMenuItem.Text = "ENTRADA"
        '
        'PratoPriToolStripMenuItem
        '
        Me.PratoPriToolStripMenuItem.Name = "PratoPriToolStripMenuItem"
        Me.PratoPriToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.PratoPriToolStripMenuItem.Text = "PRATO PRINCIPAL"
        '
        'SOBREMESAToolStripMenuItem
        '
        Me.SOBREMESAToolStripMenuItem.Name = "SOBREMESAToolStripMenuItem"
        Me.SOBREMESAToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.SOBREMESAToolStripMenuItem.Text = "SOBREMESA"
        '
        'BEBIDAToolStripMenuItem
        '
        Me.BEBIDAToolStripMenuItem.Name = "BEBIDAToolStripMenuItem"
        Me.BEBIDAToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.BEBIDAToolStripMenuItem.Text = "BEBIDA"
        '
        'cms_categoria
        '
        Me.cms_categoria.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_categoria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENTRADAToolStripMenuItem1, Me.PRATOPRINCIPALToolStripMenuItem, Me.SOBREMESAToolStripMenuItem1, Me.BEBIDAToolStripMenuItem1})
        Me.cms_categoria.Name = "ContextMenuStrip1"
        Me.cms_categoria.Size = New System.Drawing.Size(196, 100)
        '
        'ENTRADAToolStripMenuItem1
        '
        Me.ENTRADAToolStripMenuItem1.Name = "ENTRADAToolStripMenuItem1"
        Me.ENTRADAToolStripMenuItem1.Size = New System.Drawing.Size(195, 24)
        Me.ENTRADAToolStripMenuItem1.Text = "ENTRADA"
        '
        'PRATOPRINCIPALToolStripMenuItem
        '
        Me.PRATOPRINCIPALToolStripMenuItem.Name = "PRATOPRINCIPALToolStripMenuItem"
        Me.PRATOPRINCIPALToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.PRATOPRINCIPALToolStripMenuItem.Text = "PRATO PRINCIPAL"
        '
        'SOBREMESAToolStripMenuItem1
        '
        Me.SOBREMESAToolStripMenuItem1.Name = "SOBREMESAToolStripMenuItem1"
        Me.SOBREMESAToolStripMenuItem1.Size = New System.Drawing.Size(195, 24)
        Me.SOBREMESAToolStripMenuItem1.Text = "SOBREMESA"
        '
        'BEBIDAToolStripMenuItem1
        '
        Me.BEBIDAToolStripMenuItem1.Name = "BEBIDAToolStripMenuItem1"
        Me.BEBIDAToolStripMenuItem1.Size = New System.Drawing.Size(195, 24)
        Me.BEBIDAToolStripMenuItem1.Text = "BEBIDA"
        '
        'cms_itens
        '
        Me.cms_itens.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_itens.Name = "ContextMenuStrip1"
        Me.cms_itens.Size = New System.Drawing.Size(61, 4)
        '
        'Form_AdicionarNovoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SGIR.My.Resources.Resources.background_azul_mobile
        Me.ClientSize = New System.Drawing.Size(500, 900)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.barradeacoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_AdicionarNovoPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SGIR"
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barradeacoes.ResumeLayout(False)
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_menu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_categoria.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu As PictureBox
    Friend WithEvents barradeacoes As Panel
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents sair As PictureBox
    Friend WithEvents voltar As PictureBox
    Friend WithEvents cms_menu As ContextMenuStrip
    Friend WithEvents IniciarNovoAtendimentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoSAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TelaInicialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_numero_pedido As Label
    Friend WithEvents EntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PratoPriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SOBREMESAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BEBIDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cms_categoria As ContextMenuStrip
    Friend WithEvents ENTRADAToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PRATOPRINCIPALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SOBREMESAToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BEBIDAToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents cms_itens As ContextMenuStrip
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
