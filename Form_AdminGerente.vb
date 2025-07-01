Imports Microsoft.VisualBasic.Logging
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form_AdminGerente

    Private periodoSelecionado As String = "Dia"
    Dim pode_voltar As String = "nao"
    Dim loginUsuario = UsuarioLogado
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        cms_menu.Show(menu, New Point(0, menu.Height))
    End Sub
    Private Sub MedidasForm()
        titulo.Top = 100
        titulo.Left = 130
        lbl_periodo.Top = 200
        menu.Height = 24
        menu.Width = 24
        barradeacoes.Top = 12
        barradeacoes.Left = (Me.ClientSize.Width - 95)
        menu.Top = 10
        menu.Left = 10
        Label1.Top = 10


        lbl_periodo.Top = 180
        lbl_periodo.Left = 200

        Chart1.Left = 200
        Chart1.Width = 500
        Chart1.Height = 550

        lbl_periodo.Width = Chart1.Width
        Chart1.Top = lbl_periodo.Top + lbl_periodo.Height + 2


        lbl_vendas_totais2.Left = Chart1.Left + Chart1.Width + 50
        lbl_total_faturado2.Left = Chart1.Left + Chart1.Width + 50
        lbl_total_gasto2.Left = Chart1.Left + Chart1.Width + 50
        lbl_lucro2.Left = Chart1.Left + Chart1.Width + 50

        lbl_vendas_totais.Left = lbl_vendas_totais2.Left + lbl_vendas_totais2.Width + 50
        lbl_total_faturado.Left = lbl_total_faturado2.Left + lbl_vendas_totais2.Width + 50
        lbl_total_gasto.Left = Chart1.Left + Chart1.Width + lbl_total_gasto2.Left + 100
        lbl_lucro.Left = Chart1.Left + Chart1.Width + lbl_lucro2.Left + 100

    End Sub
    Private Sub Form_AdminGerente_Load(sender As Object, e As EventArgs) Handles Me.Load
        periodoSelecionado = "Dia"
        lbl_periodo.Text = "Período: Dia"
        lbl_periodo.ContextMenuStrip = cms_periodo

        CarregarGraficoCaixa()
        AtualizarResumosFinanceiros()
        AtualizarGraficos()

        lbl_periodo.ContextMenuStrip = cms_periodo
        lbl_periodo.Text = "Período: Dia" ' Valor inicial

        MedidasForm()
        CentralizarControlesNoForm(Me, {Label1}, horizontal:=True, vertical:=False)

        Dim rs As Object
        rs = CreateObject("ADODB.Recordset")

        Try
            rs.Open("SELECT primeiro_nome FROM cadastros WHERE usuario = '" & UsuarioLogado & "'", db)

            If Not rs.EOF Then
                Dim primeiroNome As String = rs.Fields("primeiro_nome").Value
                Label1.Text = "Bem-vindo(a), " & primeiroNome & "!"
            Else
                Label1.Text = "Bem-vindo(a), usuário"
            End If

            rs.Close()

        Catch ex As Exception
            MsgBox("Erro ao buscar nome: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub sair_Click(sender As Object, e As EventArgs)
        resp = MsgBox("Tem certeza que deseja encerrar o programa?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
    Private Sub CarregarGraficoCaixa()
        Dim connString As String = "server=localhost;userid=root;password=usbw;database=casa_machadodb;port=3307"
        Dim query As String = "SELECT categoria, SUM(valor) AS total_valor " &
                          "FROM caixa " &
                          "WHERE data = CURDATE() " &
                          "GROUP BY categoria ORDER BY total_valor DESC;"

        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            Try
                conn.Open()
                adapter.Fill(table)

                Chart1.Series.Clear()
                Chart1.ChartAreas(0).AxisX.Title = "Categoria"
                Chart1.ChartAreas(0).AxisY.Title = "Valor (R$)"
                Chart1.Series.Clear()
                Chart1.Series.Add("Caixa")
                Chart1.Series("Caixa").ChartType = SeriesChartType.Column

                For Each row As DataRow In table.Rows
                    Dim categoria As String = row("categoria").ToString()
                    Dim total As Decimal = Convert.ToDecimal(row("total_valor"))
                    Chart1.Series("Caixa").Points.AddXY(categoria, total)
                Next

            Catch ex As Exception
                MessageBox.Show("Erro ao carregar gráfico do caixa: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub AtualizarGraficos()
        Dim connString As String = "server=localhost;userid=root;password=usbw;database=casa_machadodb;port=3307"
        Dim wherePeriodo As String = ObterClausulaWherePorPeriodo()

        Dim query As String = "SELECT categoria, SUM(valor) AS total_valor " &
                          "FROM caixa " &
                          "WHERE tipo = 'entrada' " &
                          If(wherePeriodo <> "", "AND " & Mid(wherePeriodo, 7), "") &
                          " GROUP BY categoria ORDER BY total_valor DESC;"

        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            Try
                conn.Open()
                adapter.Fill(table)

                Chart1.Series.Clear()
                Chart1.ChartAreas(0).AxisX.Title = "Categoria"
                Chart1.ChartAreas(0).AxisY.Title = "Valor (R$)"
                Chart1.Series.Add("Faturamento")
                Chart1.Series("Faturamento").ChartType = SeriesChartType.Column

                For Each row As DataRow In table.Rows
                    Dim categoria As String = row("categoria").ToString()
                    Dim total As Decimal = Convert.ToDecimal(row("total_valor"))
                    Chart1.Series("Faturamento").Points.AddXY(categoria, total)
                Next

            Catch ex As Exception
                MessageBox.Show("Erro ao carregar gráfico: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub AtualizarResumosFinanceiros()
        Dim connString As String = "server=localhost;userid=root;password=usbw;database=casa_machadodb;port=3307"
        Dim wherePeriodo As String = ObterClausulaWherePorPeriodo()

        Dim queryEntradas As String = $"SELECT COUNT(*) AS total_vendas, SUM(valor) AS total_entrada FROM caixa WHERE tipo = 'entrada' {If(wherePeriodo <> "", "AND " & Mid(wherePeriodo, 7), "")}"
        Dim querySaidas As String = $"SELECT SUM(valor) AS total_saida FROM caixa WHERE tipo = 'saida' {If(wherePeriodo <> "", "AND " & Mid(wherePeriodo, 7), "")}"

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                Dim cmdEntradas As New MySqlCommand(queryEntradas, conn)
                Dim readerEntradas = cmdEntradas.ExecuteReader()
                Dim totalVendas As Integer = 0
                Dim totalEntrada As Decimal = 0

                If readerEntradas.Read() Then
                    totalVendas = If(IsDBNull(readerEntradas("total_vendas")), 0, Convert.ToInt32(readerEntradas("total_vendas")))
                    totalEntrada = If(IsDBNull(readerEntradas("total_entrada")), 0D, Convert.ToDecimal(readerEntradas("total_entrada")))
                End If
                readerEntradas.Close()

                Dim cmdSaidas As New MySqlCommand(querySaidas, conn)
                Dim readerSaidas = cmdSaidas.ExecuteReader()
                Dim totalSaida As Decimal = 0

                If readerSaidas.Read() Then
                    totalSaida = If(IsDBNull(readerSaidas("total_saida")), 0D, Convert.ToDecimal(readerSaidas("total_saida")))
                End If
                readerSaidas.Close()

                lbl_vendas_totais.Text = totalVendas.ToString()
                lbl_total_faturado.Text = "R$ " & totalEntrada.ToString("N2")
                lbl_total_gasto.Text = "R$ " & totalSaida.ToString("N2")
                lbl_lucro.Text = "R$ " & (totalEntrada - totalSaida).ToString("N2")

            Catch ex As Exception
                MessageBox.Show("Erro ao atualizar resumo financeiro: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Function ObterClausulaWherePorPeriodo() As String
        Select Case periodoSelecionado
            Case "Dia"
                Return "WHERE data = CURDATE()"
            Case "semana"
                Return "WHERE data BETWEEN DATE_SUB(CURDATE(), INTERVAL (WEEKDAY(CURDATE()) + 1) % 7 DAY) " &
                       "AND DATE_ADD(DATE_SUB(CURDATE(), INTERVAL (WEEKDAY(CURDATE()) + 1) % 7 DAY), INTERVAL 6 DAY)"
            Case "Mês"
                Return "WHERE MONTH(data) = MONTH(CURDATE()) AND YEAR(data) = YEAR(CURDATE())"
            Case "Ano"
                Return "WHERE YEAR(data) = YEAR(CURDATE())"
            Case "Todas"
                Return ""
            Case Else
                Return ""
        End Select
    End Function
    Private Sub lbl_periodo_Click(sender As Object, e As EventArgs) Handles lbl_periodo.Click
        cms_periodo.Show(lbl_periodo, 0, lbl_periodo.Height)
    End Sub
    Private Sub DiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiaToolStripMenuItem.Click
        periodoSelecionado = "Dia"
        lbl_periodo.Text = "Período: Dia"
        AtualizarGraficos()
        AtualizarResumosFinanceiros()
    End Sub
    Private Sub SemanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SemanaToolStripMenuItem.Click
        periodoSelecionado = "Semana"
        lbl_periodo.Text = "Período: Semana"
        AtualizarGraficos()
        AtualizarResumosFinanceiros()
    End Sub
    Private Sub MêsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MêsToolStripMenuItem.Click
        periodoSelecionado = "Mês"
        lbl_periodo.Text = "Período: Mês"
        AtualizarGraficos()
        AtualizarResumosFinanceiros()
    End Sub
    Private Sub AnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnoToolStripMenuItem.Click
        periodoSelecionado = "Ano"
        lbl_periodo.Text = "Período: Ano"
        AtualizarGraficos()
        AtualizarResumosFinanceiros()
    End Sub
    Private Sub TodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodasToolStripMenuItem.Click
        periodoSelecionado = "Todas"
        lbl_periodo.Text = "Período: Todas"
        AtualizarGraficos()
        AtualizarResumosFinanceiros()
    End Sub
    Private Sub EncerrarSessãoSAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoSAIRToolStripMenuItem.Click
        resp = MsgBox("Tem certeza que deseja encerrar sessão?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            telaAnterior = Form1
            Form1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub GestãoDeFuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestãoDeFuncionáriosToolStripMenuItem.Click
        pode_voltar = "sim"
        telaAnterior = Me
        Form_GestaoDeFuncionarios.Show()
        Me.Hide()
    End Sub
    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        If pode_voltar = "sim" Then
            telaAnterior.Show()
            telaAnterior = Me
            Me.Hide()
        End If
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
    Private Sub ControleDeEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleDeEstoqueToolStripMenuItem.Click
        pode_voltar = "sim"
        telaAnterior = Me
        Form_Estoque.Show()
        Me.Hide()
    End Sub
End Class