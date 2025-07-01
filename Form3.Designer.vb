<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.barradeacoes = New System.Windows.Forms.Panel()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.voltar = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_sobrenome = New System.Windows.Forms.Label()
        Me.lbl_primeiro_nome = New System.Windows.Forms.Label()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.lbl_celular = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_data_de_nascimento = New System.Windows.Forms.Label()
        Me.lbl_codigo_de_funcionario = New System.Windows.Forms.Label()
        Me.lbl_cargo = New System.Windows.Forms.Label()
        Me.lbl_setor = New System.Windows.Forms.Label()
        Me.lbl_confirmar_senha = New System.Windows.Forms.Label()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_primeiro_nome = New System.Windows.Forms.TextBox()
        Me.txt_sobrenome = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_setor = New System.Windows.Forms.TextBox()
        Me.txt_data_de_nascimento = New System.Windows.Forms.TextBox()
        Me.txt_cargo = New System.Windows.Forms.TextBox()
        Me.txt_codigo_de_funcionario = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_confirmar_senha = New System.Windows.Forms.TextBox()
        Me.cms_setor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AtendimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CozinhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_cargo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MaîtreRecepcionistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GarçomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CozinheiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChefDeCozinhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.olho_aberto_confirmar_senha = New System.Windows.Forms.PictureBox()
        Me.olho_fechado_confirmar_senha = New System.Windows.Forms.PictureBox()
        Me.olho_fechado_senha = New System.Windows.Forms.PictureBox()
        Me.olho_aberto_senha = New System.Windows.Forms.PictureBox()
        Me.barradeacoes.SuspendLayout()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.cms_setor.SuspendLayout()
        Me.cms_cargo.SuspendLayout()
        CType(Me.olho_aberto_confirmar_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olho_fechado_confirmar_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olho_fechado_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olho_aberto_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barradeacoes
        '
        Me.barradeacoes.AutoSize = True
        Me.barradeacoes.BackColor = System.Drawing.Color.Transparent
        Me.barradeacoes.Controls.Add(Me.minimizar)
        Me.barradeacoes.Controls.Add(Me.sair)
        Me.barradeacoes.Controls.Add(Me.voltar)
        Me.barradeacoes.Location = New System.Drawing.Point(816, 3)
        Me.barradeacoes.Name = "barradeacoes"
        Me.barradeacoes.Size = New System.Drawing.Size(114, 47)
        Me.barradeacoes.TabIndex = 13
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
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.BackgroundImage = Global.SGIR.My.Resources.Resources.logo_transparente
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logo.Location = New System.Drawing.Point(12, 3)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(40, 40)
        Me.logo.TabIndex = 11
        Me.logo.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.LinkLabel2)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(333, 458)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(288, 289)
        Me.Panel3.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 9.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "JÁ POSSUI UMA CONTA?"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.LinkLabel2.Font = New System.Drawing.Font("Open Sans", 9.2!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(211, 2)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(74, 23)
        Me.LinkLabel2.TabIndex = 14
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "ENTRAR"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Open Sans SemiBold", 16.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(117, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1001, 39)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "no Sistema de Gerenciamento Integrado para Restaurantes!"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 9.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(124, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(817, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "VOCÊ DEVE AGUARDAR O GESTOR LIBERAR SEU CADASTRO PARA ACESSAR SUA CONTA!"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(380, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 80)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "SOLICITAR ACESSO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 35.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(116, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(699, 68)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "CADASTRE-SE"
        '
        'lbl_sobrenome
        '
        Me.lbl_sobrenome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sobrenome.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_sobrenome.Location = New System.Drawing.Point(352, 166)
        Me.lbl_sobrenome.Name = "lbl_sobrenome"
        Me.lbl_sobrenome.Size = New System.Drawing.Size(228, 35)
        Me.lbl_sobrenome.TabIndex = 73
        Me.lbl_sobrenome.Text = "SOBRENOME"
        '
        'lbl_primeiro_nome
        '
        Me.lbl_primeiro_nome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_primeiro_nome.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_primeiro_nome.Location = New System.Drawing.Point(119, 166)
        Me.lbl_primeiro_nome.Name = "lbl_primeiro_nome"
        Me.lbl_primeiro_nome.Size = New System.Drawing.Size(228, 35)
        Me.lbl_primeiro_nome.TabIndex = 72
        Me.lbl_primeiro_nome.Text = "PRIMEIRO NOME"
        '
        'lbl_cpf
        '
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_cpf.Location = New System.Drawing.Point(586, 166)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(228, 35)
        Me.lbl_cpf.TabIndex = 74
        Me.lbl_cpf.Text = "CPF"
        '
        'lbl_celular
        '
        Me.lbl_celular.BackColor = System.Drawing.Color.Transparent
        Me.lbl_celular.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_celular.Location = New System.Drawing.Point(124, 237)
        Me.lbl_celular.Name = "lbl_celular"
        Me.lbl_celular.Size = New System.Drawing.Size(228, 26)
        Me.lbl_celular.TabIndex = 75
        Me.lbl_celular.Text = "CELULAR"
        '
        'lbl_email
        '
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_email.Location = New System.Drawing.Point(357, 237)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(228, 26)
        Me.lbl_email.TabIndex = 76
        Me.lbl_email.Text = "EMAIL"
        '
        'lbl_data_de_nascimento
        '
        Me.lbl_data_de_nascimento.BackColor = System.Drawing.Color.Transparent
        Me.lbl_data_de_nascimento.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_data_de_nascimento.Location = New System.Drawing.Point(591, 237)
        Me.lbl_data_de_nascimento.Name = "lbl_data_de_nascimento"
        Me.lbl_data_de_nascimento.Size = New System.Drawing.Size(313, 26)
        Me.lbl_data_de_nascimento.TabIndex = 77
        Me.lbl_data_de_nascimento.Text = "DATA DE NASCIMENTO"
        '
        'lbl_codigo_de_funcionario
        '
        Me.lbl_codigo_de_funcionario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_codigo_de_funcionario.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_codigo_de_funcionario.Location = New System.Drawing.Point(591, 289)
        Me.lbl_codigo_de_funcionario.Name = "lbl_codigo_de_funcionario"
        Me.lbl_codigo_de_funcionario.Size = New System.Drawing.Size(384, 27)
        Me.lbl_codigo_de_funcionario.TabIndex = 80
        Me.lbl_codigo_de_funcionario.Text = "CÓDIGO DE FUNCIONÁRIO"
        '
        'lbl_cargo
        '
        Me.lbl_cargo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cargo.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_cargo.Location = New System.Drawing.Point(357, 289)
        Me.lbl_cargo.Name = "lbl_cargo"
        Me.lbl_cargo.Size = New System.Drawing.Size(228, 27)
        Me.lbl_cargo.TabIndex = 79
        Me.lbl_cargo.Text = "CARGO"
        '
        'lbl_setor
        '
        Me.lbl_setor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_setor.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_setor.Location = New System.Drawing.Point(124, 289)
        Me.lbl_setor.Name = "lbl_setor"
        Me.lbl_setor.Size = New System.Drawing.Size(228, 27)
        Me.lbl_setor.TabIndex = 78
        Me.lbl_setor.Text = "SETOR"
        '
        'lbl_confirmar_senha
        '
        Me.lbl_confirmar_senha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_confirmar_senha.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_confirmar_senha.Location = New System.Drawing.Point(592, 351)
        Me.lbl_confirmar_senha.Name = "lbl_confirmar_senha"
        Me.lbl_confirmar_senha.Size = New System.Drawing.Size(228, 31)
        Me.lbl_confirmar_senha.TabIndex = 83
        Me.lbl_confirmar_senha.Text = "CONFIRMAR SENHA"
        '
        'lbl_senha
        '
        Me.lbl_senha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_senha.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_senha.Location = New System.Drawing.Point(358, 351)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(228, 31)
        Me.lbl_senha.TabIndex = 82
        Me.lbl_senha.Text = "SENHA"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usuario.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_usuario.Location = New System.Drawing.Point(125, 351)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(228, 31)
        Me.lbl_usuario.TabIndex = 81
        Me.lbl_usuario.Text = "USUÁRIO"
        '
        'txt_primeiro_nome
        '
        Me.txt_primeiro_nome.BackColor = System.Drawing.SystemColors.Window
        Me.txt_primeiro_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_primeiro_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_primeiro_nome.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_primeiro_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_primeiro_nome.Location = New System.Drawing.Point(172, 193)
        Me.txt_primeiro_nome.Multiline = True
        Me.txt_primeiro_nome.Name = "txt_primeiro_nome"
        Me.txt_primeiro_nome.Size = New System.Drawing.Size(100, 20)
        Me.txt_primeiro_nome.TabIndex = 84
        '
        'txt_sobrenome
        '
        Me.txt_sobrenome.BackColor = System.Drawing.SystemColors.Window
        Me.txt_sobrenome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sobrenome.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_sobrenome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_sobrenome.Location = New System.Drawing.Point(380, 193)
        Me.txt_sobrenome.Multiline = True
        Me.txt_sobrenome.Name = "txt_sobrenome"
        Me.txt_sobrenome.Size = New System.Drawing.Size(100, 20)
        Me.txt_sobrenome.TabIndex = 85
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cpf.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_cpf.Location = New System.Drawing.Point(597, 193)
        Me.txt_cpf.Multiline = True
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpf.TabIndex = 86
        '
        'txt_celular
        '
        Me.txt_celular.BackColor = System.Drawing.SystemColors.Window
        Me.txt_celular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_celular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_celular.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_celular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_celular.Location = New System.Drawing.Point(172, 266)
        Me.txt_celular.Multiline = True
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(100, 20)
        Me.txt_celular.TabIndex = 87
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.SystemColors.Window
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_email.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_email.Location = New System.Drawing.Point(380, 266)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(100, 20)
        Me.txt_email.TabIndex = 88
        '
        'txt_setor
        '
        Me.txt_setor.BackColor = System.Drawing.SystemColors.Window
        Me.txt_setor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_setor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_setor.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_setor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_setor.Location = New System.Drawing.Point(172, 328)
        Me.txt_setor.Multiline = True
        Me.txt_setor.Name = "txt_setor"
        Me.txt_setor.Size = New System.Drawing.Size(100, 20)
        Me.txt_setor.TabIndex = 89
        '
        'txt_data_de_nascimento
        '
        Me.txt_data_de_nascimento.BackColor = System.Drawing.SystemColors.Window
        Me.txt_data_de_nascimento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_data_de_nascimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_data_de_nascimento.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_data_de_nascimento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_data_de_nascimento.Location = New System.Drawing.Point(591, 287)
        Me.txt_data_de_nascimento.Multiline = True
        Me.txt_data_de_nascimento.Name = "txt_data_de_nascimento"
        Me.txt_data_de_nascimento.Size = New System.Drawing.Size(100, 20)
        Me.txt_data_de_nascimento.TabIndex = 89
        '
        'txt_cargo
        '
        Me.txt_cargo.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cargo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cargo.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_cargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_cargo.Location = New System.Drawing.Point(380, 328)
        Me.txt_cargo.Multiline = True
        Me.txt_cargo.Name = "txt_cargo"
        Me.txt_cargo.Size = New System.Drawing.Size(100, 20)
        Me.txt_cargo.TabIndex = 90
        '
        'txt_codigo_de_funcionario
        '
        Me.txt_codigo_de_funcionario.BackColor = System.Drawing.SystemColors.Window
        Me.txt_codigo_de_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_codigo_de_funcionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codigo_de_funcionario.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_codigo_de_funcionario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_codigo_de_funcionario.Location = New System.Drawing.Point(591, 328)
        Me.txt_codigo_de_funcionario.Multiline = True
        Me.txt_codigo_de_funcionario.Name = "txt_codigo_de_funcionario"
        Me.txt_codigo_de_funcionario.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo_de_funcionario.TabIndex = 91
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.SystemColors.Window
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_usuario.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_usuario.Location = New System.Drawing.Point(172, 385)
        Me.txt_usuario.Multiline = True
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_usuario.TabIndex = 92
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.SystemColors.Window
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_senha.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_senha.Location = New System.Drawing.Point(380, 385)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(100, 28)
        Me.txt_senha.TabIndex = 93
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.BackColor = System.Drawing.SystemColors.Window
        Me.txt_confirmar_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_confirmar_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_confirmar_senha.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_confirmar_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(591, 385)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(100, 28)
        Me.txt_confirmar_senha.TabIndex = 94
        Me.txt_confirmar_senha.UseSystemPasswordChar = True
        '
        'cms_setor
        '
        Me.cms_setor.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_setor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtendimentoToolStripMenuItem, Me.CozinhaToolStripMenuItem, Me.AdministraçãoToolStripMenuItem})
        Me.cms_setor.Name = "cms_setor"
        Me.cms_setor.Size = New System.Drawing.Size(175, 76)
        '
        'AtendimentoToolStripMenuItem
        '
        Me.AtendimentoToolStripMenuItem.Name = "AtendimentoToolStripMenuItem"
        Me.AtendimentoToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.AtendimentoToolStripMenuItem.Text = "Atendimento"
        '
        'CozinhaToolStripMenuItem
        '
        Me.CozinhaToolStripMenuItem.Name = "CozinhaToolStripMenuItem"
        Me.CozinhaToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.CozinhaToolStripMenuItem.Text = "Cozinha"
        '
        'AdministraçãoToolStripMenuItem
        '
        Me.AdministraçãoToolStripMenuItem.Name = "AdministraçãoToolStripMenuItem"
        Me.AdministraçãoToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.AdministraçãoToolStripMenuItem.Text = "Administração"
        '
        'cms_cargo
        '
        Me.cms_cargo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_cargo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaîtreRecepcionistaToolStripMenuItem, Me.GarçomToolStripMenuItem, Me.CozinheiroToolStripMenuItem, Me.ChefDeCozinhaToolStripMenuItem, Me.GerenteToolStripMenuItem, Me.AdministradorToolStripMenuItem})
        Me.cms_cargo.Name = "cms_cargo"
        Me.cms_cargo.Size = New System.Drawing.Size(220, 148)
        '
        'MaîtreRecepcionistaToolStripMenuItem
        '
        Me.MaîtreRecepcionistaToolStripMenuItem.Name = "MaîtreRecepcionistaToolStripMenuItem"
        Me.MaîtreRecepcionistaToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.MaîtreRecepcionistaToolStripMenuItem.Text = "Maître/Recepcionista"
        '
        'GarçomToolStripMenuItem
        '
        Me.GarçomToolStripMenuItem.Name = "GarçomToolStripMenuItem"
        Me.GarçomToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.GarçomToolStripMenuItem.Text = "Garçom"
        '
        'CozinheiroToolStripMenuItem
        '
        Me.CozinheiroToolStripMenuItem.Name = "CozinheiroToolStripMenuItem"
        Me.CozinheiroToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.CozinheiroToolStripMenuItem.Text = "Cozinheiro"
        '
        'ChefDeCozinhaToolStripMenuItem
        '
        Me.ChefDeCozinhaToolStripMenuItem.Name = "ChefDeCozinhaToolStripMenuItem"
        Me.ChefDeCozinhaToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.ChefDeCozinhaToolStripMenuItem.Text = "Chef de Cozinha"
        '
        'GerenteToolStripMenuItem
        '
        Me.GerenteToolStripMenuItem.Name = "GerenteToolStripMenuItem"
        Me.GerenteToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.GerenteToolStripMenuItem.Text = "Gerente"
        '
        'AdministradorToolStripMenuItem
        '
        Me.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        Me.AdministradorToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.AdministradorToolStripMenuItem.Text = "Administrador"
        '
        'olho_aberto_confirmar_senha
        '
        Me.olho_aberto_confirmar_senha.BackColor = System.Drawing.Color.Transparent
        Me.olho_aberto_confirmar_senha.BackgroundImage = Global.SGIR.My.Resources.Resources.olho_aberto
        Me.olho_aberto_confirmar_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.olho_aberto_confirmar_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.olho_aberto_confirmar_senha.Location = New System.Drawing.Point(784, 328)
        Me.olho_aberto_confirmar_senha.Name = "olho_aberto_confirmar_senha"
        Me.olho_aberto_confirmar_senha.Size = New System.Drawing.Size(30, 30)
        Me.olho_aberto_confirmar_senha.TabIndex = 95
        Me.olho_aberto_confirmar_senha.TabStop = False
        '
        'olho_fechado_confirmar_senha
        '
        Me.olho_fechado_confirmar_senha.BackColor = System.Drawing.Color.Transparent
        Me.olho_fechado_confirmar_senha.BackgroundImage = Global.SGIR.My.Resources.Resources.olho_fechado
        Me.olho_fechado_confirmar_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.olho_fechado_confirmar_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.olho_fechado_confirmar_senha.Location = New System.Drawing.Point(785, 364)
        Me.olho_fechado_confirmar_senha.Name = "olho_fechado_confirmar_senha"
        Me.olho_fechado_confirmar_senha.Size = New System.Drawing.Size(30, 30)
        Me.olho_fechado_confirmar_senha.TabIndex = 96
        Me.olho_fechado_confirmar_senha.TabStop = False
        '
        'olho_fechado_senha
        '
        Me.olho_fechado_senha.BackColor = System.Drawing.Color.Transparent
        Me.olho_fechado_senha.BackgroundImage = Global.SGIR.My.Resources.Resources.olho_fechado
        Me.olho_fechado_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.olho_fechado_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.olho_fechado_senha.Location = New System.Drawing.Point(750, 364)
        Me.olho_fechado_senha.Name = "olho_fechado_senha"
        Me.olho_fechado_senha.Size = New System.Drawing.Size(30, 30)
        Me.olho_fechado_senha.TabIndex = 98
        Me.olho_fechado_senha.TabStop = False
        '
        'olho_aberto_senha
        '
        Me.olho_aberto_senha.BackColor = System.Drawing.Color.Transparent
        Me.olho_aberto_senha.BackgroundImage = Global.SGIR.My.Resources.Resources.olho_aberto
        Me.olho_aberto_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.olho_aberto_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.olho_aberto_senha.Location = New System.Drawing.Point(749, 328)
        Me.olho_aberto_senha.Name = "olho_aberto_senha"
        Me.olho_aberto_senha.Size = New System.Drawing.Size(30, 30)
        Me.olho_aberto_senha.TabIndex = 97
        Me.olho_aberto_senha.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.SGIR.My.Resources.Resources.background_azul_cadastro2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(942, 500)
        Me.Controls.Add(Me.olho_fechado_senha)
        Me.Controls.Add(Me.olho_aberto_senha)
        Me.Controls.Add(Me.olho_fechado_confirmar_senha)
        Me.Controls.Add(Me.olho_aberto_confirmar_senha)
        Me.Controls.Add(Me.txt_confirmar_senha)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_codigo_de_funcionario)
        Me.Controls.Add(Me.txt_cargo)
        Me.Controls.Add(Me.txt_data_de_nascimento)
        Me.Controls.Add(Me.txt_setor)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_sobrenome)
        Me.Controls.Add(Me.txt_primeiro_nome)
        Me.Controls.Add(Me.lbl_confirmar_senha)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.lbl_codigo_de_funcionario)
        Me.Controls.Add(Me.lbl_cargo)
        Me.Controls.Add(Me.lbl_setor)
        Me.Controls.Add(Me.lbl_celular)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_data_de_nascimento)
        Me.Controls.Add(Me.lbl_sobrenome)
        Me.Controls.Add(Me.lbl_primeiro_nome)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.barradeacoes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "SGIR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.barradeacoes.ResumeLayout(False)
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.cms_setor.ResumeLayout(False)
        Me.cms_cargo.ResumeLayout(False)
        CType(Me.olho_aberto_confirmar_senha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olho_fechado_confirmar_senha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olho_fechado_senha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olho_aberto_senha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barradeacoes As Panel
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents sair As PictureBox
    Friend WithEvents voltar As PictureBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_sobrenome As Label
    Friend WithEvents lbl_primeiro_nome As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents lbl_celular As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_data_de_nascimento As Label
    Friend WithEvents lbl_codigo_de_funcionario As Label
    Friend WithEvents lbl_cargo As Label
    Friend WithEvents lbl_setor As Label
    Friend WithEvents lbl_confirmar_senha As Label
    Friend WithEvents lbl_senha As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents txt_primeiro_nome As TextBox
    Friend WithEvents txt_sobrenome As TextBox
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents txt_celular As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_setor As TextBox
    Friend WithEvents txt_data_de_nascimento As TextBox
    Friend WithEvents txt_cargo As TextBox
    Friend WithEvents txt_codigo_de_funcionario As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_confirmar_senha As TextBox
    Friend WithEvents cms_setor As ContextMenuStrip
    Friend WithEvents AtendimentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CozinhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministraçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cms_cargo As ContextMenuStrip
    Friend WithEvents MaîtreRecepcionistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GarçomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CozinheiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChefDeCozinhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministradorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents olho_aberto_confirmar_senha As PictureBox
    Friend WithEvents olho_fechado_confirmar_senha As PictureBox
    Friend WithEvents olho_fechado_senha As PictureBox
    Friend WithEvents olho_aberto_senha As PictureBox
End Class
