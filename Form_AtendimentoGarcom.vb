Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form_AtendimentoGarcom
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
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
        Form_AdicionarNovoPedido.Show()
        telaAnterior = Me
        Me.Close()
    End Sub
    Private Sub Form_AtendimentoGarcom_Load(sender As Object, e As EventArgs) Handles Me.Load
        MedidasForm()
        CarregarPainelDePedidos()
        CentralizarControlesNoForm(Me, {Panel1, flpPedidosAndamento, Label2}, horizontal:=True, vertical:=False)
    End Sub
    Private Function ObterSituacaoMaisRecente(numeroMesa As Integer) As String
        Try
            Dim rs As Object = CreateObject("ADODB.Recordset")
            rs.Open("SELECT situacao_pedido FROM pedidos WHERE numero_mesa = " & numeroMesa & " AND status_pedido = 'em atendimento' ORDER BY data_pedido DESC LIMIT 1", db)

            If Not rs.EOF Then
                Return rs("situacao_pedido").Value.ToString()
            End If

            rs.Close()
            rs = Nothing
        Catch

        End Try

        Return "Sem dados"
    End Function
    Public Sub CarregarPainelDePedidos()
        Try
            flpPedidosAndamento.Controls.Clear()

            Dim sql As String = "SELECT DISTINCT numero_mesa FROM pedidos WHERE status_pedido = 'em atendimento' AND situacao_pedido IN ('pendente', 'em preparo', 'finalizado') ORDER BY numero_mesa"
            Dim rsMesas As Object = CreateObject("ADODB.Recordset")
            rsMesas.Open(sql, db)

            If rsMesas.EOF Then
                flpPedidosAndamento.Visible = False
                Label2.Visible = False
                rsMesas.Close()
                rsMesas = Nothing
                Exit Sub
            End If

            flpPedidosAndamento.Visible = True
            Label2.Visible = True

            While Not rsMesas.EOF
                Dim numeroMesa As Integer = rsMesas("numero_mesa").Value

                Dim painelMesa As New Panel()
                painelMesa.Width = flpPedidosAndamento.Width - 30
                painelMesa.Height = 90
                painelMesa.BackColor = Color.White
                painelMesa.BorderStyle = BorderStyle.FixedSingle
                painelMesa.Margin = New Padding(5)

                Dim lblTitulo As New Label()
                lblTitulo.Text = "PEDIDOS DA MESA " & numeroMesa
                lblTitulo.Font = New Font("Open Sans", 12, FontStyle.Bold)
                lblTitulo.ForeColor = Color.FromArgb(34, 40, 49)
                lblTitulo.AutoSize = True

                Dim lblAcessar As New Label()
                lblAcessar.Text = "ACESSAR"
                lblAcessar.Font = New Font("Open Sans", 10, FontStyle.Underline)
                lblAcessar.Cursor = Cursors.Hand
                lblAcessar.ForeColor = Color.FromArgb(34, 40, 49)
                lblAcessar.AutoSize = True

                AddHandler lblAcessar.Click, Sub()
                                                 Dim telaPedidoMesa As New Form_PedidosDaMesa()
                                                 telaPedidoMesa.numeroMesa = numeroMesa
                                                 telaPedidoMesa.Show()
                                                 Me.Hide()
                                             End Sub

                Dim lblSituacao As New Label()
                lblSituacao.Text = ObterSituacaoMaisRecente(numeroMesa).ToUpper()
                lblSituacao.Font = New Font("Open Sans", 10, FontStyle.Bold)
                lblSituacao.ForeColor = Color.FromArgb(34, 40, 49)
                lblSituacao.AutoSize = True

                painelMesa.Controls.Add(lblTitulo)
                painelMesa.Controls.Add(lblAcessar)
                painelMesa.Controls.Add(lblSituacao)

                flpPedidosAndamento.Controls.Add(painelMesa)

                lblTitulo.Left = (painelMesa.Width - lblTitulo.Width) \ 2
                lblTitulo.Top = 6

                lblAcessar.Left = (painelMesa.Width - lblAcessar.Width) \ 2
                lblAcessar.Top = lblTitulo.Bottom + 2

                lblSituacao.Left = (painelMesa.Width - lblSituacao.Width) \ 2
                lblSituacao.Top = lblAcessar.Bottom + 2

                rsMesas.MoveNext()
            End While

            rsMesas.Close()
            rsMesas = Nothing

        Catch ex As Exception
            MsgBox("Erro ao carregar os atendimentos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub MedidasForm()
        menu.Top = 8
        menu.Left = 8

        barradeacoes.Top = 8
        barradeacoes.Left = Me.Width - barradeacoes.Width - 8

        Panel1.Top = 75
        flpPedidosAndamento.Height = Me.Height - 250
        flpPedidosAndamento.Top = 220
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
    Private Sub IniciarNovoAtendimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarNovoAtendimentoToolStripMenuItem.Click
        telaAnterior = Me
        Form_AdicionarNovoPedido.Show()
        Me.Close()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        telaAnterior = Me
        Form_AdicionarNovoPedido.Show()
        Me.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        telaAnterior = Me
        Form_AdicionarNovoPedido.Show()
        Me.Close()
    End Sub
End Class