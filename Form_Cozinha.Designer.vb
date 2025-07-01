<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Cozinha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Cozinha))
        Me.menu = New System.Windows.Forms.PictureBox()
        Me.barradeacoes = New System.Windows.Forms.Panel()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.voltar = New System.Windows.Forms.PictureBox()
        Me.cms_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EncerrarSessãoSAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPendentes = New System.Windows.Forms.Label()
        Me.btnEmAndamento = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel_Pendentes = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel_EmAndamento = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer_TempoEspera = New System.Windows.Forms.Timer(Me.components)
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barradeacoes.SuspendLayout()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.Transparent
        Me.menu.BackgroundImage = Global.SGIR.My.Resources.Resources.menu
        Me.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu.Location = New System.Drawing.Point(2, 2)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(33, 33)
        Me.menu.TabIndex = 15
        Me.menu.TabStop = False
        '
        'barradeacoes
        '
        Me.barradeacoes.AutoSize = True
        Me.barradeacoes.BackColor = System.Drawing.Color.Transparent
        Me.barradeacoes.Controls.Add(Me.minimizar)
        Me.barradeacoes.Controls.Add(Me.sair)
        Me.barradeacoes.Controls.Add(Me.voltar)
        Me.barradeacoes.Location = New System.Drawing.Point(674, 2)
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
        'btnPendentes
        '
        Me.btnPendentes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPendentes.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendentes.Location = New System.Drawing.Point(74, 55)
        Me.btnPendentes.Name = "btnPendentes"
        Me.btnPendentes.Size = New System.Drawing.Size(230, 40)
        Me.btnPendentes.TabIndex = 113
        Me.btnPendentes.Text = "PEDIDOS PENDENTES"
        Me.btnPendentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEmAndamento
        '
        Me.btnEmAndamento.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEmAndamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmAndamento.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnEmAndamento.Location = New System.Drawing.Point(304, 55)
        Me.btnEmAndamento.Name = "btnEmAndamento"
        Me.btnEmAndamento.Size = New System.Drawing.Size(230, 40)
        Me.btnEmAndamento.TabIndex = 114
        Me.btnEmAndamento.Text = "PEDIDOS EM PREPARO"
        Me.btnEmAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel_Pendentes
        '
        Me.FlowLayoutPanel_Pendentes.AutoScroll = True
        Me.FlowLayoutPanel_Pendentes.Location = New System.Drawing.Point(153, 178)
        Me.FlowLayoutPanel_Pendentes.Name = "FlowLayoutPanel_Pendentes"
        Me.FlowLayoutPanel_Pendentes.Size = New System.Drawing.Size(381, 213)
        Me.FlowLayoutPanel_Pendentes.TabIndex = 115
        '
        'FlowLayoutPanel_EmAndamento
        '
        Me.FlowLayoutPanel_EmAndamento.AutoScroll = True
        Me.FlowLayoutPanel_EmAndamento.Location = New System.Drawing.Point(504, 278)
        Me.FlowLayoutPanel_EmAndamento.Name = "FlowLayoutPanel_EmAndamento"
        Me.FlowLayoutPanel_EmAndamento.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanel_EmAndamento.TabIndex = 116
        '
        'Timer_TempoEspera
        '
        Me.Timer_TempoEspera.Enabled = True
        Me.Timer_TempoEspera.Interval = 1000
        '
        'Form_Cozinha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SGIR.My.Resources.Resources.background_azul_cozinha
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FlowLayoutPanel_EmAndamento)
        Me.Controls.Add(Me.FlowLayoutPanel_Pendentes)
        Me.Controls.Add(Me.btnEmAndamento)
        Me.Controls.Add(Me.btnPendentes)
        Me.Controls.Add(Me.barradeacoes)
        Me.Controls.Add(Me.menu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Cozinha"
        Me.Text = "SGIR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barradeacoes.ResumeLayout(False)
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu As PictureBox
    Friend WithEvents barradeacoes As Panel
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents sair As PictureBox
    Friend WithEvents voltar As PictureBox
    Friend WithEvents cms_menu As ContextMenuStrip
    Friend WithEvents EncerrarSessãoSAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPendentes As Label
    Friend WithEvents btnEmAndamento As Label
    Friend WithEvents FlowLayoutPanel_Pendentes As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel_EmAndamento As FlowLayoutPanel
    Friend WithEvents Timer_TempoEspera As Timer
End Class
