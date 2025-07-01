<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.voltar = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.barradeacoes = New System.Windows.Forms.Panel()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.olho_fechado_senha = New System.Windows.Forms.PictureBox()
        Me.olho_aberto_senha = New System.Windows.Forms.PictureBox()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barradeacoes.SuspendLayout()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.olho_fechado_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olho_aberto_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.logo.Location = New System.Drawing.Point(12, 5)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(40, 40)
        Me.logo.TabIndex = 1
        Me.logo.TabStop = False
        '
        'barradeacoes
        '
        Me.barradeacoes.AutoSize = True
        Me.barradeacoes.BackColor = System.Drawing.Color.Transparent
        Me.barradeacoes.Controls.Add(Me.minimizar)
        Me.barradeacoes.Controls.Add(Me.sair)
        Me.barradeacoes.Controls.Add(Me.voltar)
        Me.barradeacoes.Location = New System.Drawing.Point(818, 12)
        Me.barradeacoes.Name = "barradeacoes"
        Me.barradeacoes.Size = New System.Drawing.Size(114, 33)
        Me.barradeacoes.TabIndex = 12
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
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.LinkLabel2)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(290, 456)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(356, 25)
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
        Me.Label3.Size = New System.Drawing.Size(223, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NÃO POSSUI UMA CONTA? "
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
        Me.LinkLabel2.Location = New System.Drawing.Point(237, 2)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(115, 23)
        Me.LinkLabel2.TabIndex = 6
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "CADASTRE-SE"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Open Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(405, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 65)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "ENTRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.SystemColors.Window
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_usuario.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_usuario.Location = New System.Drawing.Point(340, 298)
        Me.txt_usuario.Multiline = True
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_usuario.TabIndex = 85
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.SystemColors.Window
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_senha.Font = New System.Drawing.Font("Open Sans SemiBold", 12.2!, System.Drawing.FontStyle.Bold)
        Me.txt_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txt_senha.Location = New System.Drawing.Point(340, 343)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(100, 28)
        Me.txt_senha.TabIndex = 86
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'lbl_senha
        '
        Me.lbl_senha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_senha.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_senha.Location = New System.Drawing.Point(335, 321)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(228, 31)
        Me.lbl_senha.TabIndex = 88
        Me.lbl_senha.Text = "SENHA"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usuario.Font = New System.Drawing.Font("Open Sans SemiBold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_usuario.Location = New System.Drawing.Point(335, 264)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(228, 31)
        Me.lbl_usuario.TabIndex = 87
        Me.lbl_usuario.Text = "USUÁRIO"
        '
        'olho_fechado_senha
        '
        Me.olho_fechado_senha.BackColor = System.Drawing.Color.Transparent
        Me.olho_fechado_senha.BackgroundImage = Global.SGIR.My.Resources.Resources.olho_fechado
        Me.olho_fechado_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.olho_fechado_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.olho_fechado_senha.Location = New System.Drawing.Point(628, 311)
        Me.olho_fechado_senha.Name = "olho_fechado_senha"
        Me.olho_fechado_senha.Size = New System.Drawing.Size(30, 30)
        Me.olho_fechado_senha.TabIndex = 100
        Me.olho_fechado_senha.TabStop = False
        '
        'olho_aberto_senha
        '
        Me.olho_aberto_senha.BackColor = System.Drawing.Color.Transparent
        Me.olho_aberto_senha.BackgroundImage = Global.SGIR.My.Resources.Resources.olho_aberto
        Me.olho_aberto_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.olho_aberto_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.olho_aberto_senha.Location = New System.Drawing.Point(627, 275)
        Me.olho_aberto_senha.Name = "olho_aberto_senha"
        Me.olho_aberto_senha.Size = New System.Drawing.Size(30, 30)
        Me.olho_aberto_senha.TabIndex = 99
        Me.olho_aberto_senha.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SGIR.My.Resources.Resources.background_azul_login3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(942, 493)
        Me.Controls.Add(Me.olho_fechado_senha)
        Me.Controls.Add(Me.olho_aberto_senha)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.barradeacoes)
        Me.Controls.Add(Me.logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "SGIR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barradeacoes.ResumeLayout(False)
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.olho_fechado_senha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olho_aberto_senha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents voltar As PictureBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents barradeacoes As Panel
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents sair As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents lbl_senha As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents olho_fechado_senha As PictureBox
    Friend WithEvents olho_aberto_senha As PictureBox
End Class
