<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_PedidosDaMesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_PedidosDaMesa))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.btn_finalizar_atendimento = New System.Windows.Forms.Button()
        Me.btn_imprimir_conta = New System.Windows.Forms.Button()
        Me.flpMesa = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_numero_pedido = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.menu = New System.Windows.Forms.PictureBox()
        Me.barradeacoes = New System.Windows.Forms.Panel()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.voltar = New System.Windows.Forms.PictureBox()
        Me.cms_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TelaInicialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarNovoAtendimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoSAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.flpMesa.SuspendLayout()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barradeacoes.SuspendLayout()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.LabelTitulo)
        Me.Panel1.Controls.Add(Me.btn_finalizar_atendimento)
        Me.Panel1.Controls.Add(Me.btn_imprimir_conta)
        Me.Panel1.Controls.Add(Me.flpMesa)
        Me.Panel1.Location = New System.Drawing.Point(48, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 500)
        Me.Panel1.TabIndex = 22
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelTitulo.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LabelTitulo.Location = New System.Drawing.Point(75, 20)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(200, 28)
        Me.LabelTitulo.TabIndex = 16
        Me.LabelTitulo.Text = "PEDIDOS DA MESA:"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_finalizar_atendimento
        '
        Me.btn_finalizar_atendimento.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_finalizar_atendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_finalizar_atendimento.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_finalizar_atendimento.ForeColor = System.Drawing.Color.White
        Me.btn_finalizar_atendimento.Location = New System.Drawing.Point(90, 415)
        Me.btn_finalizar_atendimento.Name = "btn_finalizar_atendimento"
        Me.btn_finalizar_atendimento.Size = New System.Drawing.Size(200, 65)
        Me.btn_finalizar_atendimento.TabIndex = 32
        Me.btn_finalizar_atendimento.Text = "FINALIZAR ATENDIMENTO"
        Me.btn_finalizar_atendimento.UseVisualStyleBackColor = False
        '
        'btn_imprimir_conta
        '
        Me.btn_imprimir_conta.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_imprimir_conta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir_conta.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_imprimir_conta.ForeColor = System.Drawing.Color.White
        Me.btn_imprimir_conta.Location = New System.Drawing.Point(90, 344)
        Me.btn_imprimir_conta.Name = "btn_imprimir_conta"
        Me.btn_imprimir_conta.Size = New System.Drawing.Size(200, 65)
        Me.btn_imprimir_conta.TabIndex = 31
        Me.btn_imprimir_conta.Text = "IMPRIMIR CONTA"
        Me.btn_imprimir_conta.UseVisualStyleBackColor = False
        '
        'flpMesa
        '
        Me.flpMesa.AutoScroll = True
        Me.flpMesa.Controls.Add(Me.lbl_numero_pedido)
        Me.flpMesa.Controls.Add(Me.TextBox1)
        Me.flpMesa.Controls.Add(Me.TextBox2)
        Me.flpMesa.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMesa.Location = New System.Drawing.Point(10, 57)
        Me.flpMesa.Name = "flpMesa"
        Me.flpMesa.Size = New System.Drawing.Size(360, 252)
        Me.flpMesa.TabIndex = 30
        Me.flpMesa.WrapContents = False
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
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.Transparent
        Me.menu.BackgroundImage = Global.SGIR.My.Resources.Resources.menu
        Me.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu.Location = New System.Drawing.Point(9, 5)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(33, 33)
        Me.menu.TabIndex = 21
        Me.menu.TabStop = False
        '
        'barradeacoes
        '
        Me.barradeacoes.AutoSize = True
        Me.barradeacoes.BackColor = System.Drawing.Color.Transparent
        Me.barradeacoes.Controls.Add(Me.minimizar)
        Me.barradeacoes.Controls.Add(Me.sair)
        Me.barradeacoes.Controls.Add(Me.voltar)
        Me.barradeacoes.Location = New System.Drawing.Point(360, 5)
        Me.barradeacoes.Name = "barradeacoes"
        Me.barradeacoes.Size = New System.Drawing.Size(114, 33)
        Me.barradeacoes.TabIndex = 20
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
        'lblTotal
        '
        Me.lblTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Open Sans", 8.2!)
        Me.lblTotal.Location = New System.Drawing.Point(14, 311)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(53, 20)
        Me.lblTotal.TabIndex = 33
        Me.lblTotal.Text = "Label1"
        '
        'Form_PedidosDaMesa
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
        Me.Name = "Form_PedidosDaMesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SGIR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.flpMesa.ResumeLayout(False)
        Me.flpMesa.PerformLayout()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barradeacoes.ResumeLayout(False)
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents flpMesa As FlowLayoutPanel
    Friend WithEvents lbl_numero_pedido As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents menu As PictureBox
    Friend WithEvents barradeacoes As Panel
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents sair As PictureBox
    Friend WithEvents voltar As PictureBox
    Friend WithEvents cms_menu As ContextMenuStrip
    Friend WithEvents TelaInicialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IniciarNovoAtendimentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoSAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_finalizar_atendimento As Button
    Friend WithEvents btn_imprimir_conta As Button
    Friend WithEvents lblTotal As Label
End Class
