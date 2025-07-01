<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ControleMesas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ControleMesas))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.barradeacoes = New System.Windows.Forms.Panel()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.voltar = New System.Windows.Forms.PictureBox()
        Me.menu = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.titulo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cms_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EncerrarSessãoSAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mesa1 = New System.Windows.Forms.Label()
        Me.mesa2 = New System.Windows.Forms.Label()
        Me.mesa3 = New System.Windows.Forms.Label()
        Me.mesa4 = New System.Windows.Forms.Label()
        Me.mesa5 = New System.Windows.Forms.Label()
        Me.mesa7 = New System.Windows.Forms.Label()
        Me.mesa9 = New System.Windows.Forms.Label()
        Me.mesa6 = New System.Windows.Forms.Label()
        Me.mesa8 = New System.Windows.Forms.Label()
        Me.mesa10 = New System.Windows.Forms.Label()
        Me.mesa11 = New System.Windows.Forms.Label()
        Me.mesa12 = New System.Windows.Forms.Label()
        Me.mesa13 = New System.Windows.Forms.Label()
        Me.mesa14 = New System.Windows.Forms.Label()
        Me.mesa15 = New System.Windows.Forms.Label()
        Me.mesa16 = New System.Windows.Forms.Label()
        Me.mesa17 = New System.Windows.Forms.Label()
        Me.mesa18 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.cb_status_mesa = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barradeacoes.SuspendLayout()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SGIR.My.Resources.Resources.mesas_restaurante
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 406)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.barradeacoes.TabIndex = 113
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
        Me.menu.Location = New System.Drawing.Point(12, 2)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(33, 33)
        Me.menu.TabIndex = 114
        Me.menu.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Open Sans SemiBold", 12.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(300, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 32)
        Me.Label2.TabIndex = 116
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'titulo
        '
        Me.titulo.BackColor = System.Drawing.Color.Transparent
        Me.titulo.Font = New System.Drawing.Font("Open Sans", 18.2!, System.Drawing.FontStyle.Bold)
        Me.titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.titulo.Location = New System.Drawing.Point(281, 80)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(745, 43)
        Me.titulo.TabIndex = 117
        Me.titulo.Text = "CONTROLE DE OCUPAÇÃO DE MESAS"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
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
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(591, 114)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "POR FAVOR, SELECIONE UMA MESA PARA EDITAR!"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans SemiBold", 12.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, -13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(745, 51)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Bem vindo(a), Marcelle!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mesa1
        '
        Me.mesa1.BackColor = System.Drawing.Color.Lime
        Me.mesa1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa1.Location = New System.Drawing.Point(24, 59)
        Me.mesa1.Name = "mesa1"
        Me.mesa1.Size = New System.Drawing.Size(21, 51)
        Me.mesa1.TabIndex = 120
        '
        'mesa2
        '
        Me.mesa2.BackColor = System.Drawing.Color.Lime
        Me.mesa2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa2.Location = New System.Drawing.Point(24, 123)
        Me.mesa2.Name = "mesa2"
        Me.mesa2.Size = New System.Drawing.Size(21, 51)
        Me.mesa2.TabIndex = 121
        '
        'mesa3
        '
        Me.mesa3.BackColor = System.Drawing.Color.Lime
        Me.mesa3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa3.Location = New System.Drawing.Point(24, 179)
        Me.mesa3.Name = "mesa3"
        Me.mesa3.Size = New System.Drawing.Size(21, 51)
        Me.mesa3.TabIndex = 122
        '
        'mesa4
        '
        Me.mesa4.BackColor = System.Drawing.Color.Lime
        Me.mesa4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa4.Location = New System.Drawing.Point(24, 234)
        Me.mesa4.Name = "mesa4"
        Me.mesa4.Size = New System.Drawing.Size(21, 51)
        Me.mesa4.TabIndex = 123
        '
        'mesa5
        '
        Me.mesa5.BackColor = System.Drawing.Color.Lime
        Me.mesa5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa5.Location = New System.Drawing.Point(24, 341)
        Me.mesa5.Name = "mesa5"
        Me.mesa5.Size = New System.Drawing.Size(21, 51)
        Me.mesa5.TabIndex = 124
        '
        'mesa7
        '
        Me.mesa7.BackColor = System.Drawing.Color.Lime
        Me.mesa7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa7.Location = New System.Drawing.Point(51, 341)
        Me.mesa7.Name = "mesa7"
        Me.mesa7.Size = New System.Drawing.Size(21, 51)
        Me.mesa7.TabIndex = 125
        '
        'mesa9
        '
        Me.mesa9.BackColor = System.Drawing.Color.Lime
        Me.mesa9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa9.Location = New System.Drawing.Point(97, 341)
        Me.mesa9.Name = "mesa9"
        Me.mesa9.Size = New System.Drawing.Size(21, 51)
        Me.mesa9.TabIndex = 126
        '
        'mesa6
        '
        Me.mesa6.BackColor = System.Drawing.Color.Lime
        Me.mesa6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa6.Location = New System.Drawing.Point(24, 392)
        Me.mesa6.Name = "mesa6"
        Me.mesa6.Size = New System.Drawing.Size(21, 51)
        Me.mesa6.TabIndex = 127
        '
        'mesa8
        '
        Me.mesa8.BackColor = System.Drawing.Color.Lime
        Me.mesa8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa8.Location = New System.Drawing.Point(51, 392)
        Me.mesa8.Name = "mesa8"
        Me.mesa8.Size = New System.Drawing.Size(21, 51)
        Me.mesa8.TabIndex = 128
        '
        'mesa10
        '
        Me.mesa10.BackColor = System.Drawing.Color.Lime
        Me.mesa10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa10.Location = New System.Drawing.Point(97, 390)
        Me.mesa10.Name = "mesa10"
        Me.mesa10.Size = New System.Drawing.Size(21, 51)
        Me.mesa10.TabIndex = 129
        '
        'mesa11
        '
        Me.mesa11.BackColor = System.Drawing.Color.Lime
        Me.mesa11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa11.Location = New System.Drawing.Point(161, 59)
        Me.mesa11.Name = "mesa11"
        Me.mesa11.Size = New System.Drawing.Size(21, 51)
        Me.mesa11.TabIndex = 130
        '
        'mesa12
        '
        Me.mesa12.BackColor = System.Drawing.Color.Lime
        Me.mesa12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa12.Location = New System.Drawing.Point(161, 110)
        Me.mesa12.Name = "mesa12"
        Me.mesa12.Size = New System.Drawing.Size(21, 51)
        Me.mesa12.TabIndex = 131
        '
        'mesa13
        '
        Me.mesa13.BackColor = System.Drawing.Color.Lime
        Me.mesa13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa13.Location = New System.Drawing.Point(161, 208)
        Me.mesa13.Name = "mesa13"
        Me.mesa13.Size = New System.Drawing.Size(21, 51)
        Me.mesa13.TabIndex = 132
        '
        'mesa14
        '
        Me.mesa14.BackColor = System.Drawing.Color.Lime
        Me.mesa14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa14.Location = New System.Drawing.Point(161, 259)
        Me.mesa14.Name = "mesa14"
        Me.mesa14.Size = New System.Drawing.Size(21, 51)
        Me.mesa14.TabIndex = 133
        '
        'mesa15
        '
        Me.mesa15.BackColor = System.Drawing.Color.Lime
        Me.mesa15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa15.Location = New System.Drawing.Point(219, 59)
        Me.mesa15.Name = "mesa15"
        Me.mesa15.Size = New System.Drawing.Size(21, 51)
        Me.mesa15.TabIndex = 134
        '
        'mesa16
        '
        Me.mesa16.BackColor = System.Drawing.Color.Lime
        Me.mesa16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa16.Location = New System.Drawing.Point(219, 110)
        Me.mesa16.Name = "mesa16"
        Me.mesa16.Size = New System.Drawing.Size(21, 51)
        Me.mesa16.TabIndex = 135
        '
        'mesa17
        '
        Me.mesa17.BackColor = System.Drawing.Color.Lime
        Me.mesa17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa17.Location = New System.Drawing.Point(219, 208)
        Me.mesa17.Name = "mesa17"
        Me.mesa17.Size = New System.Drawing.Size(21, 51)
        Me.mesa17.TabIndex = 136
        '
        'mesa18
        '
        Me.mesa18.BackColor = System.Drawing.Color.Lime
        Me.mesa18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesa18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mesa18.Location = New System.Drawing.Point(219, 259)
        Me.mesa18.Name = "mesa18"
        Me.mesa18.Size = New System.Drawing.Size(21, 51)
        Me.mesa18.TabIndex = 137
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(383, 343)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(124, 62)
        Me.btnConfirmar.TabIndex = 138
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'cb_status_mesa
        '
        Me.cb_status_mesa.FormattingEnabled = True
        Me.cb_status_mesa.Location = New System.Drawing.Point(470, 322)
        Me.cb_status_mesa.Name = "cb_status_mesa"
        Me.cb_status_mesa.Size = New System.Drawing.Size(121, 24)
        Me.cb_status_mesa.TabIndex = 139
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(285, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 24)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Editar para:"
        '
        'Form_ControleMesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SGIR.My.Resources.Resources.background_azul_gerente
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cb_status_mesa)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.mesa18)
        Me.Controls.Add(Me.mesa17)
        Me.Controls.Add(Me.mesa16)
        Me.Controls.Add(Me.mesa15)
        Me.Controls.Add(Me.mesa14)
        Me.Controls.Add(Me.mesa13)
        Me.Controls.Add(Me.mesa12)
        Me.Controls.Add(Me.mesa11)
        Me.Controls.Add(Me.mesa10)
        Me.Controls.Add(Me.mesa8)
        Me.Controls.Add(Me.mesa6)
        Me.Controls.Add(Me.mesa9)
        Me.Controls.Add(Me.mesa7)
        Me.Controls.Add(Me.mesa5)
        Me.Controls.Add(Me.mesa4)
        Me.Controls.Add(Me.mesa3)
        Me.Controls.Add(Me.mesa2)
        Me.Controls.Add(Me.mesa1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.barradeacoes)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_ControleMesas"
        Me.Text = "SGIR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barradeacoes.ResumeLayout(False)
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents barradeacoes As Panel
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents sair As PictureBox
    Friend WithEvents voltar As PictureBox
    Friend WithEvents menu As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents titulo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cms_menu As ContextMenuStrip
    Friend WithEvents EncerrarSessãoSAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mesa1 As Label
    Friend WithEvents mesa2 As Label
    Friend WithEvents mesa3 As Label
    Friend WithEvents mesa4 As Label
    Friend WithEvents mesa5 As Label
    Friend WithEvents mesa7 As Label
    Friend WithEvents mesa9 As Label
    Friend WithEvents mesa6 As Label
    Friend WithEvents mesa8 As Label
    Friend WithEvents mesa10 As Label
    Friend WithEvents mesa11 As Label
    Friend WithEvents mesa12 As Label
    Friend WithEvents mesa13 As Label
    Friend WithEvents mesa14 As Label
    Friend WithEvents mesa15 As Label
    Friend WithEvents mesa16 As Label
    Friend WithEvents mesa17 As Label
    Friend WithEvents mesa18 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents cb_status_mesa As ComboBox
    Friend WithEvents Label4 As Label
End Class
