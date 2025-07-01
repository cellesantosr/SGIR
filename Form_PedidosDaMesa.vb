Public Class Form_PedidosDaMesa
    Public numeroMesa As Integer
    Dim total As Decimal = 0
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
    Private Sub MedidasForm()
        flpMesa.Width = Panel1.Width - 20
        menu.Top = 8
        menu.Left = 8

        barradeacoes.Top = 8
        barradeacoes.Left = Me.Width - barradeacoes.Width - 8
    End Sub

    Private Sub Form_PedidosDaMesa_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabelTitulo.Text = "PEDIDOS DA MESA " & numeroMesa
        LabelTitulo.Font = New Font("Open Sans", 12, FontStyle.Bold)
        LabelTitulo.ForeColor = Color.FromArgb(34, 40, 49)
        LabelTitulo.AutoSize = True
        CarregarPedidosDaMesa()
        MedidasForm()
        CentralizarControlesNoForm(Me, {Panel1}, horizontal:=True, vertical:=False)
    End Sub
    Private Sub CarregarPedidosDaMesa()
        Try
            flpMesa.Controls.Clear()

            Dim sql As String = "SELECT numero_pedido, categoria, item, situacao_pedido FROM pedidos WHERE numero_mesa = " & numeroMesa & " AND status_pedido = 'em atendimento' AND situacao_pedido IN ('pendente', 'em andamento', 'finalizado') ORDER BY numero_pedido"
            Dim rs As Object = CreateObject("ADODB.Recordset")
            rs.Open(sql, db)

            While Not rs.EOF
                Dim numeroPedido As Integer = rs("numero_pedido").Value
                Dim categoria As String = rs("categoria").Value
                Dim item As String = rs("item").Value
                Dim situacao As String = rs("situacao_pedido").Value

                Dim precoCmd As Object = CreateObject("ADODB.Recordset")
                Dim sqlPreco As String = "SELECT preco FROM cardapio WHERE categoria = '" & categoria & "' AND nome_item = '" & item.Replace("'", "''") & "'"
                precoCmd.Open(sqlPreco, db)

                If Not precoCmd.EOF Then
                    Dim preco As Decimal = precoCmd("preco").Value
                    total += preco
                End If
                precoCmd.Close()
                precoCmd = Nothing

                Dim painelPedido As New Panel()
                painelPedido.Width = flpMesa.Width - 40
                painelPedido.Height = 90
                painelPedido.BackColor = Color.White
                painelPedido.BorderStyle = BorderStyle.FixedSingle
                painelPedido.Margin = New Padding(5)

                Dim lblTitulo As New Label()
                lblTitulo.Text = "PEDIDO " & numeroPedido & ":"
                lblTitulo.Font = New Font("Open Sans", 12, FontStyle.Bold)
                lblTitulo.AutoSize = True
                lblTitulo.Location = New Point(10, 10)

                Dim lblItem As New Label()
                lblItem.Text = categoria & " - " & item
                lblItem.Font = New Font("Open Sans", 10)
                lblItem.AutoSize = True
                lblItem.Location = New Point(10, 30)
                lblItem.MaximumSize = New Size(painelPedido.Width - 20, 0) ' largura máxima
                lblItem.AutoSize = True

                Dim lblSituacao As New Label()
                lblSituacao.Text = situacao.ToUpper()
                lblSituacao.Font = New Font("Open Sans", 9, FontStyle.Italic)
                lblSituacao.AutoSize = True
                lblSituacao.Location = New Point(painelPedido.Width - lblSituacao.Width - 20, 15)

                painelPedido.Controls.Add(lblTitulo)
                painelPedido.Controls.Add(lblItem)
                painelPedido.Controls.Add(lblSituacao)

                flpMesa.Controls.Add(painelPedido)

                rs.MoveNext()
            End While
            lblTotal.Text = "TOTAL DO PEDIDO: R$ " & total.ToString("F2")
            rs.Close()
            rs = Nothing

        Catch ex As Exception
            MsgBox("Erro ao carregar pedidos da mesa: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        cms_menu.Show(menu, New Point(0, menu.Height))
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
        Form_AtendimentoGarcom.Show()
        telaAnterior = Me
        Me.Close()
    End Sub
    Private Sub EncerrarSessãoSAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoSAIRToolStripMenuItem.Click
        resp = MsgBox("Tem certeza que deseja encerrar sessão?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            telaAnterior = Form1
            Form1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub IniciarNovoAtendimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarNovoAtendimentoToolStripMenuItem.Click
        telaAnterior = Me
        Form_AdicionarNovoPedido.Show()
        Me.Close()
    End Sub
    Private Sub TelaInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TelaInicialToolStripMenuItem.Click
        telaAnterior = Me
        Form_AtendimentoGarcom.Show()
        Me.Close()
    End Sub
    Private Sub btn_imprimir_conta_Click(sender As Object, e As EventArgs) Handles btn_imprimir_conta.Click
        MsgBox("As informações de pagamento no valor de: " & total.ToString("F2") & " reais, foram enviados para a impressora do restaurante!", MsgBoxStyle.OkOnly)
    End Sub
    Private Sub btn_finalizar_atendimento_Click(sender As Object, e As EventArgs) Handles btn_finalizar_atendimento.Click
        Dim dataVenda As String = Date.Today.ToString("yyyy-MM-dd")
        Dim horaVenda As String = Date.Now.ToString("HH:mm:ss")
        Dim categoriaCaixa As String = "pagamento cliente"
        Dim formaPagamento As String = "cartao"
        Dim valorVenda As Decimal = total
        Dim descricao As String = "Mesa:" & numeroMesa
        Dim observacoes As String = ""
        Dim statusCaixa As String = "confirmado"
        Dim horaAtual As Integer = Now.Hour
        Dim minutoAtual As Integer = Now.Minute
        Dim turnoAtual As String = ""
        Dim resposta = MsgBox("O pagamento no valor de: " & total.ToString("F2") & " reais, foi realizado? Deseja encerrar o atendimento da mesa " & numeroMesa & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Finalizar Atendimento")
        Dim primeiroNome As String = ""
        If horaAtual >= 6 And horaAtual < 12 Then
            turnoAtual = "manha"
        ElseIf horaAtual >= 12 And horaAtual < 18 Then
            turnoAtual = "tarde"
        Else
            turnoAtual = "noite"
        End If

        Dim rs As Object
        rs = CreateObject("ADODB.Recordset")

        Try
            rs.Open("SELECT primeiro_nome FROM cadastros WHERE usuario = '" & UsuarioLogado & "'", db)

            If Not rs.EOF Then
                primeiroNome = rs.Fields("primeiro_nome").Value

            Else
            End If


            rs.Close()

        Catch ex As Exception
            MsgBox("Erro ao buscar nome: " & ex.Message, MsgBoxStyle.Critical)
        End Try

        Dim pagador As String = "Cliente mesa " & numeroMesa
        Dim responsavel As String = primeiroNome
        If resposta = vbYes Then
            Try
                Dim sql As String = "UPDATE pedidos SET status_pedido = 'concluído', situacao_pedido = 'entregue' WHERE numero_mesa = " & numeroMesa & " AND status_pedido = 'em atendimento'"
                db.Execute(sql)

                MsgBox("Atendimento da mesa " & numeroMesa & " finalizado com sucesso!", MsgBoxStyle.Information)

                Dim sqlCaixa As String = "INSERT INTO caixa (data, hora, categoria, forma_de_pagamento, valor, descricao, observacoes, status, turno, responsavel, pagador) " &
                         "VALUES ('" & dataVenda & "', '" & horaVenda & "', '" & categoriaCaixa & "', '" & formaPagamento & "', " &
                         Replace(valorVenda.ToString("F2"), ",", ".") & ", '" & descricao & "', '" & observacoes & "', '" & statusCaixa & "', '" &
                         turnoAtual & "', '" & responsavel & "', '" & pagador & "')"

                db.Execute(sqlCaixa)

                Form_AtendimentoGarcom.Close()
                Form_AtendimentoGarcom.Show()
                telaAnterior = Me
                Me.Close()

            Catch ex As Exception
                MsgBox("Erro ao finalizar atendimento: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
End Class