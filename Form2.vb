Public Class Form2
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar_campos()
        MedidasForm()
        CentralizarControlesNoForm(Me, {Button1, Panel3, txt_senha, txt_usuario, lbl_senha, lbl_usuario}, horizontal:=True, vertical:=False)
    End Sub
    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub sair_Click(sender As Object, e As EventArgs) Handles sair.Click
        limpar_campos()
        resp = MsgBox("Tem certeza que deseja encerrar o programa?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        limpar_campos()
        telaAnterior.Show()
        telaAnterior = Me
        Me.Hide()
    End Sub
    Private Sub MedidasForm()
        lbl_usuario.Size = New Size(424, 20)
        lbl_usuario.Top = 495

        txt_usuario.Size = New Size(424, 40)
        txt_usuario.Top = 520

        lbl_senha.Size = New Size(424, 20)
        lbl_senha.Top = 583

        txt_senha.Size = New Size(424, 40)
        txt_senha.Top = 608

        olho_fechado_senha.Top = 580
        olho_fechado_senha.Left = 960
        olho_aberto_senha.Top = 580
        olho_aberto_senha.Left = 960

        Button1.Top = 690
        Panel3.Top = 750

        barradeacoes.Top = 12
        barradeacoes.Left = (Me.ClientSize.Width - 95)
        logo.Top = 8
        logo.Left = 10

    End Sub
    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        limpar_campos()
        Form1.Show()
        telaAnterior = Me
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        limpar_campos()
        telaAnterior = Me
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_usuario.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Informe o usuário e a senha!", MsgBoxStyle.Exclamation, "Atenção")
            limpar_campos()
            Exit Sub
        End If

        SQL = $"SELECT * FROM cadastros WHERE usuario = '{txt_usuario.Text}' AND senha = '{txt_senha.Text}'"
        rs = db.Execute(SQL)

        If rs.EOF Then
            MsgBox("Usuário ou senha incorretos!", MsgBoxStyle.Critical, "Erro")
            limpar_campos()
            Exit Sub
        End If

        If rs.Fields("situacao").Value.ToString().ToLower() <> "ativo" Then
            MsgBox("Seu acesso ainda não foi liberado pelo gestor.", MsgBoxStyle.Exclamation, "Conta bloqueada")
            limpar_campos()
            Exit Sub
        End If

        UsuarioLogado = txt_usuario.Text.Trim()

        Dim cargo As String = rs.Fields("cargo").Value.ToString()
        Dim setor As String = rs.Fields("setor").Value.ToString()

        Select Case True
            Case setor = "Atendimento" And cargo = "Maître/Recepcionista"
                Form_ControleMesas.Show()
            Case setor = "Atendimento" And cargo = "Garçom"
                Form_AtendimentoGarcom.Show()


            Case setor = "Cozinha" And cargo = "Cozinheiro"
                Form_Cozinha.Show()
            Case setor = "Cozinha" And cargo = "Chef de cozinha"
                Form_Estoque.Show()


            Case setor = "Administração" And cargo = "Gerente"
                Form_AdminGerente.Show()
            Case setor = "Administração" And cargo = "Administrador"
                Form_AdminGerente.Show()


            Case Else
                MsgBox("Setor ou cargo não reconhecidos. Acesso negado.", MsgBoxStyle.Critical, "Erro")
                limpar_campos()
                Exit Sub
        End Select
        limpar_campos()
        telaAnterior = Me
        Me.Hide()
    End Sub

    Private Sub olho_aberto_senha_Click(sender As Object, e As EventArgs) Handles olho_aberto_senha.Click
        txt_senha.UseSystemPasswordChar = True

        olho_aberto_senha.Visible = False
        olho_fechado_senha.Visible = True
    End Sub
    Private Sub olho_fechado_senha_Click(sender As Object, e As EventArgs) Handles olho_fechado_senha.Click
        txt_senha.UseSystemPasswordChar = False

        olho_fechado_senha.Visible = False
        olho_aberto_senha.Visible = True
    End Sub
    Private Sub limpar_campos()
        txt_usuario.Text = ""
        txt_senha.Text = ""
    End Sub
End Class
