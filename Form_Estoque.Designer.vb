<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Estoque
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Estoque))
        Me.barradeacoes = New System.Windows.Forms.Panel()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.voltar = New System.Windows.Forms.PictureBox()
        Me.menu = New System.Windows.Forms.PictureBox()
        Me.cms_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EncerrarSessãoSAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvEstoque = New System.Windows.Forms.DataGridView()
        Me.dgvMovimentacoes = New System.Windows.Forms.DataGridView()
        Me.btnAtualizarEstoque = New System.Windows.Forms.Button()
        Me.btnEntradaManual = New System.Windows.Forms.Button()
        Me.titulo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRetirarManual = New System.Windows.Forms.Button()
        Me.barradeacoes.SuspendLayout()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_menu.SuspendLayout()
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMovimentacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barradeacoes
        '
        Me.barradeacoes.AutoSize = True
        Me.barradeacoes.BackColor = System.Drawing.Color.Transparent
        Me.barradeacoes.Controls.Add(Me.minimizar)
        Me.barradeacoes.Controls.Add(Me.sair)
        Me.barradeacoes.Controls.Add(Me.voltar)
        Me.barradeacoes.Location = New System.Drawing.Point(674, 1)
        Me.barradeacoes.Name = "barradeacoes"
        Me.barradeacoes.Size = New System.Drawing.Size(114, 33)
        Me.barradeacoes.TabIndex = 114
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
        Me.menu.Location = New System.Drawing.Point(2, 1)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(33, 33)
        Me.menu.TabIndex = 113
        Me.menu.TabStop = False
        '
        'cms_menu
        '
        Me.cms_menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarSessãoSAIRToolStripMenuItem})
        Me.cms_menu.Name = "cms_menu"
        Me.cms_menu.Size = New System.Drawing.Size(231, 30)
        '
        'EncerrarSessãoSAIRToolStripMenuItem
        '
        Me.EncerrarSessãoSAIRToolStripMenuItem.Image = Global.SGIR.My.Resources.Resources.sair
        Me.EncerrarSessãoSAIRToolStripMenuItem.Name = "EncerrarSessãoSAIRToolStripMenuItem"
        Me.EncerrarSessãoSAIRToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.EncerrarSessãoSAIRToolStripMenuItem.Text = "Encerrar Sessão (SAIR)"
        '
        'dgvEstoque
        '
        Me.dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEstoque.BackgroundColor = System.Drawing.Color.White
        Me.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstoque.Location = New System.Drawing.Point(84, 183)
        Me.dgvEstoque.Name = "dgvEstoque"
        Me.dgvEstoque.RowHeadersWidth = 51
        Me.dgvEstoque.RowTemplate.Height = 24
        Me.dgvEstoque.Size = New System.Drawing.Size(240, 150)
        Me.dgvEstoque.TabIndex = 116
        '
        'dgvMovimentacoes
        '
        Me.dgvMovimentacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovimentacoes.BackgroundColor = System.Drawing.Color.White
        Me.dgvMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimentacoes.Location = New System.Drawing.Point(403, 183)
        Me.dgvMovimentacoes.Name = "dgvMovimentacoes"
        Me.dgvMovimentacoes.RowHeadersWidth = 51
        Me.dgvMovimentacoes.RowTemplate.Height = 24
        Me.dgvMovimentacoes.Size = New System.Drawing.Size(240, 150)
        Me.dgvMovimentacoes.TabIndex = 117
        '
        'btnAtualizarEstoque
        '
        Me.btnAtualizarEstoque.Location = New System.Drawing.Point(136, 374)
        Me.btnAtualizarEstoque.Name = "btnAtualizarEstoque"
        Me.btnAtualizarEstoque.Size = New System.Drawing.Size(162, 49)
        Me.btnAtualizarEstoque.TabIndex = 118
        Me.btnAtualizarEstoque.Text = "ATUALIZAR ESTOQUE"
        Me.btnAtualizarEstoque.UseVisualStyleBackColor = True
        '
        'btnEntradaManual
        '
        Me.btnEntradaManual.Location = New System.Drawing.Point(322, 374)
        Me.btnEntradaManual.Name = "btnEntradaManual"
        Me.btnEntradaManual.Size = New System.Drawing.Size(162, 49)
        Me.btnEntradaManual.TabIndex = 119
        Me.btnEntradaManual.Text = "ADICIONAR AO ESTOQUE"
        Me.btnEntradaManual.UseVisualStyleBackColor = True
        '
        'titulo
        '
        Me.titulo.BackColor = System.Drawing.Color.Transparent
        Me.titulo.Font = New System.Drawing.Font("Open Sans", 18.2!, System.Drawing.FontStyle.Bold)
        Me.titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.titulo.Location = New System.Drawing.Point(40, 45)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(745, 51)
        Me.titulo.TabIndex = 120
        Me.titulo.Text = "CONTROLE DE ESTOQUE"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 40)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "ESTOQUE ATUAL"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(399, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(230, 40)
        Me.Label8.TabIndex = 122
        Me.Label8.Text = "TRANSAÇÕES "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRetirarManual
        '
        Me.btnRetirarManual.Location = New System.Drawing.Point(530, 374)
        Me.btnRetirarManual.Name = "btnRetirarManual"
        Me.btnRetirarManual.Size = New System.Drawing.Size(162, 49)
        Me.btnRetirarManual.TabIndex = 123
        Me.btnRetirarManual.Text = "RETIRAR DO ESTOQUE"
        Me.btnRetirarManual.UseVisualStyleBackColor = True
        '
        'Form_Estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SGIR.My.Resources.Resources.background_azul_cozinha
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRetirarManual)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.btnEntradaManual)
        Me.Controls.Add(Me.btnAtualizarEstoque)
        Me.Controls.Add(Me.dgvMovimentacoes)
        Me.Controls.Add(Me.dgvEstoque)
        Me.Controls.Add(Me.barradeacoes)
        Me.Controls.Add(Me.menu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Estoque"
        Me.Text = "SGIR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.barradeacoes.ResumeLayout(False)
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_menu.ResumeLayout(False)
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMovimentacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barradeacoes As Panel
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents sair As PictureBox
    Friend WithEvents voltar As PictureBox
    Friend WithEvents menu As PictureBox
    Friend WithEvents cms_menu As ContextMenuStrip
    Friend WithEvents EncerrarSessãoSAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvEstoque As DataGridView
    Friend WithEvents dgvMovimentacoes As DataGridView
    Friend WithEvents btnAtualizarEstoque As Button
    Friend WithEvents btnEntradaManual As Button
    Friend WithEvents titulo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnRetirarManual As Button
End Class
