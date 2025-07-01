Public Class Form3
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar_campos()
        txt_senha.UseSystemPasswordChar = True
        txt_confirmar_senha.UseSystemPasswordChar = True
        MedidasForm()
        CentralizarControlesNoForm(Me, {Button1, Label4, Panel3}, horizontal:=True, vertical:=False)
    End Sub
    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
    Private Sub MedidasForm()
        lbl_primeiro_nome.Top = 320
        lbl_primeiro_nome.Left = 300

        txt_primeiro_nome.Size = New Size(287, 39)
        txt_primeiro_nome.Top = 345
        txt_primeiro_nome.Left = 301

        lbl_sobrenome.Top = 320
        lbl_sobrenome.Left = 624

        txt_sobrenome.Size = New Size(287, 39)
        txt_sobrenome.Top = 345
        txt_sobrenome.Left = 624

        lbl_cpf.Top = 320
        lbl_cpf.Left = 948

        txt_cpf.Size = New Size(287, 39)
        txt_cpf.Top = 345
        txt_cpf.Left = 948

        '--------------------------

        lbl_celular.Top = 400
        lbl_celular.Left = 300

        txt_celular.Size = New Size(287, 39)
        txt_celular.Top = 425
        txt_celular.Left = 301

        lbl_email.Top = 400
        lbl_email.Left = 625

        txt_email.Size = New Size(287, 39)
        txt_email.Top = 425
        txt_email.Left = 625

        lbl_data_de_nascimento.Top = 400
        lbl_data_de_nascimento.Left = 950

        txt_data_de_nascimento.Size = New Size(287, 39)
        txt_data_de_nascimento.Top = 425
        txt_data_de_nascimento.Left = 950

        '--------------------------

        lbl_setor.Top = 506
        lbl_setor.Left = 300

        txt_setor.Size = New Size(287, 39)
        txt_setor.Top = 531
        txt_setor.Left = 301

        lbl_cargo.Top = 506
        lbl_cargo.Left = 625

        txt_cargo.Size = New Size(287, 39)
        txt_cargo.Top = 531
        txt_cargo.Left = 625

        lbl_codigo_de_funcionario.Top = 506
        lbl_codigo_de_funcionario.Left = 950

        txt_codigo_de_funcionario.Size = New Size(287, 39)
        txt_codigo_de_funcionario.Top = 531
        txt_codigo_de_funcionario.Left = 950

        '--------------------------

        lbl_usuario.Top = 606
        lbl_usuario.Left = 300

        txt_usuario.Size = New Size(287, 39)
        txt_usuario.Top = 637
        txt_usuario.Left = 301

        lbl_senha.Top = 606
        lbl_senha.Left = 625

        olho_fechado_senha.Top = 606
        olho_fechado_senha.Left = 890
        olho_aberto_senha.Top = 606
        olho_aberto_senha.Left = 890

        txt_senha.Size = New Size(287, 39)
        txt_senha.Top = 637
        txt_senha.Left = 625

        lbl_confirmar_senha.Top = 606
        lbl_confirmar_senha.Left = 950

        olho_fechado_confirmar_senha.Top = 606
        olho_fechado_confirmar_senha.Left = 1215
        olho_aberto_confirmar_senha.Top = 606
        olho_aberto_confirmar_senha.Left = 1215

        txt_confirmar_senha.Size = New Size(287, 39)
        txt_confirmar_senha.Top = 637
        txt_confirmar_senha.Left = 950

        '--------------------------

        Label1.Top = 180
        Label2.Top = 230
        Label1.Left = 285
        Label2.Left = 295

        Button1.Top = 705
        Label4.Top = 790

        Panel3.Top = 805

        barradeacoes.Top = 12
        barradeacoes.Left = (Me.ClientSize.Width - 95)
        logo.Top = 8
        logo.Left = 10

    End Sub
    Private Sub sair_Click(sender As Object, e As EventArgs) Handles sair.Click
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
    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        limpar_campos()
        Form1.Show()
        telaAnterior = Me
        Me.Hide()
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        limpar_campos()
        telaAnterior = Me
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub ApenasNumeros_KeyPress(sender As Object, e As KeyPressEventArgs)


        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Function AplicarMascara(valor As String, mascara As String) As String
        Dim apenasNumeros = New String(valor.Where(Function(c) Char.IsDigit(c)).ToArray())
        Dim resultado As String = ""
        Dim indice As Integer = 0

        For Each c As Char In mascara
            If c = "0"c Then
                If indice < apenasNumeros.Length Then
                    resultado &= apenasNumeros(indice)
                    indice += 1
                Else
                    Exit For
                End If
            Else
                If indice < apenasNumeros.Length Then
                    resultado &= c
                Else
                    Exit For
                End If
            End If
        Next

        Return resultado
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_primeiro_nome.Text = "" Or txt_sobrenome.Text = "" Or txt_cpf.Text = "" Or
    txt_celular.Text = "" Or txt_email.Text = "" Or txt_data_de_nascimento.Text = "" Or
    txt_setor.Text = "" Or txt_cargo.Text = "" Or txt_codigo_de_funcionario.Text = "" Or
    txt_usuario.Text = "" Or txt_senha.Text = "" Or txt_confirmar_senha.Text = "" Then
            MsgBox("Por favor, preencha todos os campos!", MsgBoxStyle.Exclamation, "Atenção")
            Exit Sub
        End If

        If txt_senha.Text <> txt_confirmar_senha.Text Then
            MsgBox("As senhas não coincidem!", MsgBoxStyle.Critical, "Erro")
            txt_senha.Text = ""
            txt_confirmar_senha.Text = ""
            Exit Sub
        End If

        Dim camposUnicos() As String = {"cpf", "celular", "email", "codigo_de_funcionario"}
        Dim valoresUnicos() As String = {txt_cpf.Text, txt_celular.Text, txt_email.Text, txt_codigo_de_funcionario.Text}

        For i As Integer = 0 To camposUnicos.Length - 1
            SQL = $"SELECT * FROM cadastros WHERE {camposUnicos(i)} = '{valoresUnicos(i)}'"
            rs = db.Execute(SQL)
            If Not rs.EOF Then
                MsgBox($"Já existe um cadastro com o(a) {camposUnicos(i).Replace("_", " ").ToUpper()} informado(a).", MsgBoxStyle.Exclamation, "Atenção")
                limpar_campos()
                Exit Sub
            End If
        Next

        SQL = $"SELECT * FROM cadastros WHERE usuario = '{txt_usuario.Text}'"
        rs = db.Execute(SQL)
        If Not rs.EOF Then
            MsgBox("Nome de usuário já está em uso. Escolha outro.", MsgBoxStyle.Exclamation, "Atenção")
            txt_usuario.Text = ""
            Exit Sub
        End If

        Dim dataNascimento As Date
        If Not Date.TryParseExact(txt_data_de_nascimento.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dataNascimento) Then
            MsgBox("Data de nascimento inválida! Use o formato dd/MM/aaaa.", MsgBoxStyle.Critical, "Erro")
            Exit Sub
        End If

        Dim dataMySQL As String = dataNascimento.ToString("yyyy-MM-dd")

        SQL = "INSERT INTO cadastros (primeiro_nome, sobrenome, cpf, celular, email, data_de_nascimento, setor, cargo, codigo_de_funcionario, usuario, senha, situacao) " &
      "VALUES ('" & txt_primeiro_nome.Text & "', '" & txt_sobrenome.Text & "', '" & txt_cpf.Text & "', '" & txt_celular.Text & "', " &
      "'" & txt_email.Text & "', '" & dataMySQL & "', '" & txt_setor.Text & "', '" & txt_cargo.Text & "', " &
      "'" & txt_codigo_de_funcionario.Text & "', '" & txt_usuario.Text & "', '" & txt_senha.Text & "', 'bloqueado')"

        db.Execute(SQL)

        MsgBox("Cadastro solicitado com sucesso! Aguarde a liberação do gestor.", MsgBoxStyle.Information, "Sucesso")
        limpar_campos()
    End Sub
    Private Sub txt_cpf_TextChanged_1(sender As Object, e As EventArgs) Handles txt_cpf.TextChanged
        txt_cpf.Text = AplicarMascara(txt_cpf.Text, "000.000.000-00")
        txt_cpf.SelectionStart = txt_cpf.Text.Length
    End Sub
    Private Sub txt_celular_TextChanged(sender As Object, e As EventArgs) Handles txt_celular.TextChanged
        txt_celular.Text = AplicarMascara(txt_celular.Text, "(00) 00000-0000")
        txt_celular.SelectionStart = txt_celular.Text.Length
    End Sub
    Private Sub txt_data_de_nascimento_TextChanged(sender As Object, e As EventArgs) Handles txt_data_de_nascimento.TextChanged
        txt_data_de_nascimento.Text = AplicarMascara(txt_data_de_nascimento.Text, "00/00/0000")
        txt_data_de_nascimento.SelectionStart = txt_data_de_nascimento.Text.Length
    End Sub
    Private Sub cms_setor_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cms_setor.ItemClicked
        txt_setor.Text = e.ClickedItem.Text
    End Sub
    Private Sub txt_setor_Click(sender As Object, e As EventArgs) Handles txt_setor.Click
        cms_setor.Show(txt_setor, 0, txt_setor.Height)
    End Sub
    Private Sub cms_cargo_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cms_cargo.ItemClicked
        txt_cargo.Text = e.ClickedItem.Text
    End Sub
    Private Sub txt_cargo_Click(sender As Object, e As EventArgs) Handles txt_cargo.Click
        cms_cargo.Show(txt_cargo, 0, txt_cargo.Height)
    End Sub
    Private Sub olho_fechado_senha_Click(sender As Object, e As EventArgs) Handles olho_fechado_senha.Click
        txt_senha.UseSystemPasswordChar = False
        txt_confirmar_senha.UseSystemPasswordChar = False

        olho_fechado_senha.Visible = False
        olho_aberto_senha.Visible = True

        olho_fechado_confirmar_senha.Visible = False
        olho_aberto_confirmar_senha.Visible = True
    End Sub
    Private Sub olho_aberto_senha_Click(sender As Object, e As EventArgs) Handles olho_aberto_senha.Click
        txt_senha.UseSystemPasswordChar = True
        txt_confirmar_senha.UseSystemPasswordChar = True

        olho_aberto_senha.Visible = False
        olho_fechado_senha.Visible = True

        olho_aberto_confirmar_senha.Visible = False
        olho_fechado_confirmar_senha.Visible = True
    End Sub
    Private Sub olho_fechado_confirmar_senha_Click(sender As Object, e As EventArgs) Handles olho_fechado_confirmar_senha.Click
        txt_senha.UseSystemPasswordChar = False
        txt_confirmar_senha.UseSystemPasswordChar = False

        olho_fechado_senha.Visible = False
        olho_aberto_senha.Visible = True

        olho_fechado_confirmar_senha.Visible = False
        olho_aberto_confirmar_senha.Visible = True
    End Sub
    Private Sub olho_aberto_confirmar_senha_Click(sender As Object, e As EventArgs) Handles olho_aberto_confirmar_senha.Click
        txt_senha.UseSystemPasswordChar = True
        txt_confirmar_senha.UseSystemPasswordChar = True

        olho_aberto_senha.Visible = False
        olho_fechado_senha.Visible = True

        olho_aberto_confirmar_senha.Visible = False
        olho_fechado_confirmar_senha.Visible = True
    End Sub
    Private Sub limpar_campos()
        txt_primeiro_nome.Text = ""
        txt_sobrenome.Text = ""
        txt_cpf.Text = ""

        txt_celular.Text = ""
        txt_email.Text = ""
        txt_data_de_nascimento.Text = ""

        txt_setor.Text = ""
        txt_cargo.Text = ""
        txt_codigo_de_funcionario.Text = ""

        txt_usuario.Text = ""
        txt_senha.Text = ""
        txt_confirmar_senha.Text = ""
    End Sub
End Class