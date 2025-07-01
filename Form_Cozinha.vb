Public Class Form_Cozinha
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
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

        btnPendentes.Top = 100
        btnEmAndamento.Top = 100
        btnPendentes.Left = 50
        btnEmAndamento.Left = btnPendentes.Left + btnPendentes.Width

        FlowLayoutPanel_Pendentes.Size = New Size(Me.Width - 100, Me.Height - 200)
        FlowLayoutPanel_EmAndamento.Size = New Size(Me.Width - 100, Me.Height - 200)
        FlowLayoutPanel_Pendentes.Top = btnPendentes.Height + btnPendentes.Top
        FlowLayoutPanel_EmAndamento.Top = btnEmAndamento.Height + btnEmAndamento.Top
        FlowLayoutPanel_Pendentes.Left = btnPendentes.Left
        FlowLayoutPanel_EmAndamento.Left = btnPendentes.Left
    End Sub
    Private Sub CarregarPedidosPainel(flowPanel As FlowLayoutPanel, situacao As String, status As String)
        Dim situacaoAtual As String = situacao.ToLower()
        flowPanel.Controls.Clear()

        Dim rs As Object = CreateObject("ADODB.Recordset")
        Dim sql As String = "SELECT numero_pedido, numero_mesa, categoria, item, data_pedido FROM pedidos WHERE situacao_pedido = '" & situacao & "' AND status_pedido = '" & status & "' ORDER BY data_pedido DESC"
        rs.Open(sql, db)

        Do Until rs.EOF
            Dim pedidoPanel As New Panel()
            pedidoPanel.Size = New Size(300, 180)
            pedidoPanel.BorderStyle = BorderStyle.FixedSingle
            pedidoPanel.Padding = New Padding(10)
            pedidoPanel.BackColor = Color.LightGray

            Dim dataPedido As Date = rs("data_pedido").Value
            Dim tempoEspera As TimeSpan = Now - dataPedido
            Dim textoTempoEspera As String = String.Format("{0:D2}m {1:D2}s", tempoEspera.Minutes, tempoEspera.Seconds)

            Dim lblMesa As New Label() With {
            .Font = New Font("Open Sans", 12, FontStyle.Bold),
            .Text = "Mesa: " & rs("numero_mesa").Value
        }

            Dim lblData As New Label() With {
            .Font = New Font("Open Sans", 10),
            .Text = "Feito em: " & dataPedido.ToString("dd/MM/yyyy HH:mm")
        }

            Dim lblItem As New Label() With {
            .Font = New Font("Open Sans", 10),
            .Text = "Item: " & rs("item").Value
        }

            Dim lblCategoria As New Label() With {
            .Font = New Font("Open Sans", 10),
            .Text = "Categoria: " & rs("categoria").Value
        }

            Dim lblTempoEspera As New Label() With {
            .Font = New Font("Open Sans", 10, FontStyle.Italic),
            .ForeColor = Color.DarkRed,
            .Text = "Esperando: " & textoTempoEspera
        }

            If situacaoAtual = "pendente" Then
                ' Botão Iniciar Preparo
                Dim btnIniciar As New Button() With {
                    .Text = "Iniciar Preparo",
                    .BackColor = Color.LightGreen,
                    .Font = New Font("Open Sans", 9, FontStyle.Bold),
                    .Tag = New With {Key .Pedido = rs("numero_pedido").Value, .Mesa = rs("numero_mesa").Value}
                }
                AddHandler btnIniciar.Click, AddressOf IniciarPreparo_Click
                pedidoPanel.Controls.Add(btnIniciar)

            ElseIf situacaoAtual = "em andamento" Then
                ' Botão Finalizar Preparo
                Dim btnFinalizar As New Button() With {
                    .Text = "Finalizar Preparo",
                    .BackColor = Color.LightBlue,
                    .Font = New Font("Open Sans", 9, FontStyle.Bold),
                    .Tag = New With {Key .Pedido = rs("numero_pedido").Value, .Mesa = rs("numero_mesa").Value}
                }
                AddHandler btnFinalizar.Click, AddressOf FinalizarPreparo_Click
                pedidoPanel.Controls.Add(btnFinalizar)

                ' Botão Cancelar Pedido
                Dim btnCancelar As New Button() With {
                    .Text = "Cancelar Pedido",
                    .BackColor = Color.IndianRed,
                    .ForeColor = Color.White,
                    .Font = New Font("Open Sans", 9, FontStyle.Bold),
                    .Tag = New With {Key .Pedido = rs("numero_pedido").Value, .Mesa = rs("numero_mesa").Value}
                }
                AddHandler btnCancelar.Click, AddressOf CancelarPedido_Click
                pedidoPanel.Controls.Add(btnCancelar)
            End If

            pedidoPanel.Controls.Add(lblMesa)
            pedidoPanel.Controls.Add(lblData)
            pedidoPanel.Controls.Add(lblItem)
            pedidoPanel.Controls.Add(lblCategoria)
            pedidoPanel.Controls.Add(lblTempoEspera)

            Dim yOffset As Integer = 10
            For Each ctrl As Control In pedidoPanel.Controls
                ctrl.AutoSize = True
                ctrl.Left = 10
                ctrl.Top = yOffset
                yOffset += ctrl.Height + 5
            Next

            flowPanel.Controls.Add(pedidoPanel)
            rs.MoveNext()
        Loop

        rs.Close()
        rs = Nothing
    End Sub
    Private Sub FinalizarPreparo_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim dados = CType(btn.Tag, Object)
        Dim pedidoId As Integer = dados.Pedido
        Dim mesaId As Integer = dados.Mesa

        If MsgBox("Finalizar o preparo do pedido " & pedidoId & " da mesa " & mesaId & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar") = vbYes Then
            Try
                Dim sql = "UPDATE pedidos SET situacao_pedido = 'finalizado' WHERE numero_pedido = " & pedidoId & " AND numero_mesa = " & mesaId

                db.Execute(sql)

                CarregarPedidosPainel(FlowLayoutPanel_Pendentes, "pendente", "em atendimento")
                CarregarPedidosPainel(FlowLayoutPanel_EmAndamento, "em andamento", "em atendimento")
                AtualizarEstoquePorPedido(pedidoId, mesaId)
            Catch ex As Exception
                MsgBox("Erro ao finalizar pedido: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub AtualizarEstoquePorPedido(pedidoId As Integer, mesaId As Integer)
        Try
            Dim rsItens As Object = CreateObject("ADODB.Recordset")
            Dim rsIngredientes As Object = CreateObject("ADODB.Recordset")

            ' Buscar todos os itens do pedido (caso haja múltiplos)
            Dim sqlItens = "SELECT item FROM pedidos WHERE numero_pedido = " & pedidoId & " AND numero_mesa = " & mesaId
            rsItens.Open(sqlItens, db)

            Do Until rsItens.EOF
                Dim nomeItem As String = rsItens("item").Value

                ' Buscar os ingredientes associados a esse item
                Dim sqlIngredientes = "SELECT ingrediente_id, nome_ingrediente, quantidade_utilizada FROM receita_ingredientes WHERE item = '" & nomeItem & "'"
                rsIngredientes.Open(sqlIngredientes, db)

                Do Until rsIngredientes.EOF
                    Dim ingredienteId As Integer = rsIngredientes("ingrediente_id").Value
                    Dim nomeIngrediente As String = rsIngredientes("nome_ingrediente").Value
                    Dim quantidadeUsada As Double = rsIngredientes("quantidade_utilizada").Value

                    ' Atualizar estoque
                    Dim sqlAtualiza = "UPDATE estoque SET quantidade_em_estoque = quantidade_em_estoque - " & Replace(quantidadeUsada, ",", ".") & ",
                                   ultima_atualizacao = NOW()
                                   WHERE id_ingrediente = " & ingredienteId
                    db.Execute(sqlAtualiza)

                    ' (Opcional) Registrar em movimentação
                    Dim sqlLog = "INSERT INTO movimentacao_estoque (ingrediente_id, tipo, quantidade, observacao)
                              VALUES (" & ingredienteId & ", 'saida', " & Replace(quantidadeUsada, ",", ".") & ", 'Baixa automática: " & nomeItem & "')"
                    db.Execute(sqlLog)

                    rsIngredientes.MoveNext()
                Loop

                rsIngredientes.Close()
                rsItens.MoveNext()
            Loop

            rsItens.Close()
        Catch ex As Exception
            MsgBox("Erro ao atualizar estoque: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CancelarPedido_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim dados = CType(btn.Tag, Object)
        Dim pedidoId As Integer = dados.Pedido
        Dim mesaId As Integer = dados.Mesa

        If MsgBox("Cancelar o pedido " & pedidoId & " da mesa " & mesaId & "? Essa ação não pode ser desfeita.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Cancelar Pedido") = vbYes Then
            Try
                Dim sql = "DELETE FROM pedidos WHERE numero_pedido = " & pedidoId & " AND numero_mesa = " & mesaId
                db.Execute(sql)

                CarregarPedidosPainel(FlowLayoutPanel_Pendentes, "pendente", "em atendimento")
                CarregarPedidosPainel(FlowLayoutPanel_EmAndamento, "em andamento", "em atendimento")
            Catch ex As Exception
                MsgBox("Erro ao cancelar pedido: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub IniciarPreparo_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim dados = CType(btn.Tag, Object)
        Dim pedidoId As Integer = dados.Pedido
        Dim mesaId As Integer = dados.Mesa

        Dim resposta = MsgBox("Deseja realmente iniciar o preparo do pedido " & pedidoId & " da mesa " & mesaId & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar")

        If resposta = vbYes Then
            Try
                Dim sql = "UPDATE pedidos SET situacao_pedido = 'em andamento' WHERE numero_pedido = " & pedidoId & " AND numero_mesa = " & mesaId
                db.Execute(sql)

                CarregarPedidosPainel(FlowLayoutPanel_Pendentes, "pendente", "em atendimento")
                CarregarPedidosPainel(FlowLayoutPanel_EmAndamento, "em andamento", "em atendimento")
            Catch ex As Exception
                MsgBox("Erro ao atualizar pedido: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub btnPendentes_Click(sender As Object, e As EventArgs) Handles btnPendentes.Click
        FlowLayoutPanel_Pendentes.Visible = True
        FlowLayoutPanel_EmAndamento.Visible = False
        btnPendentes.BackColor = Color.White
        btnEmAndamento.BackColor = Color.LightGray
        CarregarPedidosPainel(FlowLayoutPanel_Pendentes, "pendente", "em atendimento")
    End Sub
    Private Sub btnEmAndamento_Click(sender As Object, e As EventArgs) Handles btnEmAndamento.Click
        FlowLayoutPanel_Pendentes.Visible = False
        FlowLayoutPanel_EmAndamento.Visible = True
        btnEmAndamento.BackColor = Color.White
        btnPendentes.BackColor = Color.LightGray
        CarregarPedidosPainel(FlowLayoutPanel_EmAndamento, "em andamento", "em atendimento")
    End Sub
    Private Sub Form_Cozinha_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        MedidasForm()
        btnPendentes.BackColor = Color.White
        btnEmAndamento.BackColor = Color.LightGray
        FlowLayoutPanel_Pendentes.Visible = True
        FlowLayoutPanel_EmAndamento.Visible = False
        CarregarPedidosPainel(FlowLayoutPanel_Pendentes, "pendente", "em atendimento")
        CarregarPedidosPainel(FlowLayoutPanel_EmAndamento, "em andamento", "em atendimento")
    End Sub
    Private Sub Timer_TempoEspera_Tick(sender As Object, e As EventArgs) Handles Timer_TempoEspera.Tick
        AtualizarTemposEspera(FlowLayoutPanel_Pendentes)
        AtualizarTemposEspera(FlowLayoutPanel_EmAndamento)
    End Sub
    Private Sub AtualizarTemposEspera(flowPanel As FlowLayoutPanel)
        For Each painel As Panel In flowPanel.Controls
            Dim dataPedido As DateTime = Nothing
            Dim lblData As Label = Nothing
            Dim lblTempo As Label = Nothing

            For Each ctrl As Control In painel.Controls
                If TypeOf ctrl Is Label AndAlso ctrl.Text.StartsWith("Feito em:") Then
                    lblData = CType(ctrl, Label)
                    DateTime.TryParse(lblData.Text.Replace("Feito em: ", "").Trim(), dataPedido)
                ElseIf TypeOf ctrl Is Label AndAlso ctrl.Text.StartsWith("Esperando:") Then
                    lblTempo = CType(ctrl, Label)
                End If
            Next

            If dataPedido <> Nothing AndAlso lblTempo IsNot Nothing Then
                Dim tempo = Now - dataPedido
                lblTempo.Text = "Esperando: " & String.Format("{0:D2}h {1:D2}m {2:D2}s", tempo.Hours, tempo.Minutes, tempo.Seconds)
            End If
        Next
    End Sub
End Class