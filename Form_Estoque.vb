Public Class Form_Estoque
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
    Private Sub Form_Estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarEstoque()
        CarregarMovimentacoes()
        CentralizarControlesNoForm(Me, {btnEntradaManual}, horizontal:=True, vertical:=False)
        MedidasForm()
    End Sub
    Private Sub CarregarEstoque()
        dgvEstoque.Rows.Clear()
        dgvEstoque.Columns.Clear()

        dgvEstoque.Columns.Add("ingrediente", "Ingrediente")
        dgvEstoque.Columns.Add("quantidade", "Qtd Atual")
        dgvEstoque.Columns.Add("unidade", "Unidade")
        dgvEstoque.Columns.Add("minimo", "Estoque Mín.")
        dgvEstoque.Columns.Add("data", "Última Atualização")

        Dim rs As Object = CreateObject("ADODB.Recordset")
        Dim sql As String = "SELECT nome, quantidade_em_estoque, unidade, min_estoque, ultima_atualizacao FROM estoque ORDER BY nome"
        rs.Open(sql, db)

        Do Until rs.EOF
            Dim qtd As Double = rs("quantidade_em_estoque").Value
            Dim min As Double = rs("min_estoque").Value
            Dim index As Integer = dgvEstoque.Rows.Add(rs("nome").Value, qtd, rs("unidade").Value, min, rs("ultima_atualizacao").Value)

            If qtd < min Then
                dgvEstoque.Rows(index).DefaultCellStyle.BackColor = Color.LightCoral
            End If

            rs.MoveNext()
        Loop

        rs.Close()
    End Sub

    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        telaAnterior.Show()
        telaAnterior = Me
        Me.Hide()
    End Sub
    Private Sub sair_Click_1(sender As Object, e As EventArgs) Handles sair.Click
        resp = MsgBox("Tem certeza que deseja encerrar o programa?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub
    Private Sub minimizar_Click_1(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        cms_menu.Show(menu, New Point(0, menu.Height))
    End Sub
    Private Sub EncerrarSessãoSAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoSAIRToolStripMenuItem.Click
        resp = MsgBox("Tem certeza que deseja encerrar sessão?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            telaAnterior = Form1
            Form1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub MedidasForm()
        menu.Height = 24
        menu.Width = 24
        barradeacoes.Top = 12
        barradeacoes.Left = (Me.ClientSize.Width - 95)
        menu.Top = 10
        menu.Left = 10

        titulo.Top = 88
        titulo.Left = 75

        dgvEstoque.Width = Me.Width / 2 - 100
        dgvMovimentacoes.Width = Me.Width / 2 - 100

        dgvEstoque.Height = 580
        dgvMovimentacoes.Height = 580

        Label7.Top = 150
        Label8.Top = 150

        dgvEstoque.Top = Label7.Top + Label7.Height
        dgvMovimentacoes.Top = Label7.Top + Label7.Height
        dgvEstoque.Left = 80
        dgvMovimentacoes.Left = dgvEstoque.Left + dgvEstoque.Width + 50

        btnAtualizarEstoque.Top = dgvEstoque.Height + dgvEstoque.Top + 25
        btnEntradaManual.Top = dgvEstoque.Height + dgvEstoque.Top + 25
        btnRetirarManual.Top = dgvEstoque.Height + dgvEstoque.Top + 25

        btnAtualizarEstoque.Left = btnEntradaManual.Left - btnEntradaManual.Width - btnAtualizarEstoque.Width
        btnRetirarManual.Left = btnEntradaManual.Left + btnEntradaManual.Width + btnAtualizarEstoque.Width

        Label7.Width = dgvEstoque.Width
        Label8.Width = dgvMovimentacoes.Width
        Label7.Left = dgvEstoque.Left
        Label8.Left = dgvMovimentacoes.Left
    End Sub
    Private Sub btnAtualizarEstoque_Click(sender As Object, e As EventArgs) Handles btnAtualizarEstoque.Click
        CarregarEstoque()
        CarregarMovimentacoes()
    End Sub
    Private Sub CarregarMovimentacoes()
        dgvMovimentacoes.Rows.Clear()
        dgvMovimentacoes.Columns.Clear()

        dgvMovimentacoes.Columns.Add("ingrediente", "Ingrediente")
        dgvMovimentacoes.Columns.Add("tipo", "Tipo")
        dgvMovimentacoes.Columns.Add("quantidade", "Quantidade")
        dgvMovimentacoes.Columns.Add("data", "Data")
        dgvMovimentacoes.Columns.Add("obs", "Observação")

        Dim rs As Object = CreateObject("ADODB.Recordset")
        Dim sql As String = "
        SELECT e.nome AS ingrediente, m.tipo, m.quantidade, m.data_movimento, m.observacao
        FROM movimentacao_estoque m
        JOIN estoque e ON m.ingrediente_id = e.id_ingrediente
        ORDER BY m.data_movimento DESC"
        rs.Open(sql, db)

        Do Until rs.EOF
            dgvMovimentacoes.Rows.Add(rs("ingrediente").Value, rs("tipo").Value, rs("quantidade").Value, rs("data_movimento").Value, rs("observacao").Value)
            rs.MoveNext()
        Loop

        rs.Close()
    End Sub

    Private Sub btnEntradaManual_Click(sender As Object, e As EventArgs) Handles btnEntradaManual.Click

        Dim nomeIngrediente As String = InputBox("Digite o nome do ingrediente:", "Entrada Manual")
        If String.IsNullOrWhiteSpace(nomeIngrediente) Then Exit Sub

        Dim quantidadeStr As String = InputBox("Digite a quantidade a adicionar:", "Entrada Manual")
        If Not Double.TryParse(quantidadeStr.Replace(",", "."), Nothing) Then
            MsgBox("Quantidade inválida", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim quantidade As Double = Double.Parse(quantidadeStr.Replace(",", "."), Globalization.CultureInfo.InvariantCulture)

        Dim sqlAtualiza As String = $"UPDATE estoque SET quantidade_em_estoque = quantidade_em_estoque + {quantidade}, ultima_atualizacao = NOW() WHERE nome = '{nomeIngrediente}'"
        Dim sqlLog As String = $"INSERT INTO movimentacao_estoque (ingrediente_id, tipo, quantidade, observacao) SELECT id_ingrediente, 'entrada', {quantidade}, 'Entrada manual' FROM estoque WHERE nome = '{nomeIngrediente}'"

        Try
            db.Execute(sqlAtualiza)
            db.Execute(sqlLog)
            MsgBox("Entrada registrada com sucesso!", MsgBoxStyle.Information)
            CarregarEstoque()
        Catch ex As Exception
            MsgBox("Erro ao atualizar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnRetirarManual_Click(sender As Object, e As EventArgs) Handles btnRetirarManual.Click
        Dim nomeIngrediente As String = InputBox("Digite o nome do ingrediente a retirar:", "Retirada Manual")
        If String.IsNullOrWhiteSpace(nomeIngrediente) Then Exit Sub

        Dim quantidadeStr As String = InputBox("Digite a quantidade a retirar:", "Retirada Manual")
        If Not Double.TryParse(quantidadeStr.Replace(",", "."), Nothing) Then
            MsgBox("Quantidade inválida", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim quantidade As Double = Double.Parse(quantidadeStr.Replace(",", "."), Globalization.CultureInfo.InvariantCulture)

        Dim rs As Object = CreateObject("ADODB.Recordset")
        rs.Open("SELECT id_ingrediente, quantidade_em_estoque FROM estoque WHERE nome = '" & nomeIngrediente & "'", db)

        If rs.EOF Then
            MsgBox("Ingrediente não encontrado!", MsgBoxStyle.Exclamation)
            rs.Close()
            Exit Sub
        End If

        Dim id As Integer = rs("id_ingrediente").Value
        Dim atual As Double = rs("quantidade_em_estoque").Value
        rs.Close()

        If atual < quantidade Then
            MsgBox("Estoque insuficiente para retirada!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim sqlAtualiza As String = $"UPDATE estoque SET quantidade_em_estoque = quantidade_em_estoque - {quantidade}, ultima_atualizacao = NOW() WHERE id_ingrediente = {id}"
        Dim sqlLog As String = $"INSERT INTO movimentacao_estoque (ingrediente_id, tipo, quantidade, observacao) VALUES ({id}, 'saida', {quantidade}, 'Retirada manual')"

        Try
            db.Execute(sqlAtualiza)
            db.Execute(sqlLog)
            MsgBox("Retirada registrada com sucesso!", MsgBoxStyle.Information)
            CarregarEstoque()
            CarregarMovimentacoes()
        Catch ex As Exception
            MsgBox("Erro ao retirar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class