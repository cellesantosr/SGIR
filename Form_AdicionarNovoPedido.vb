Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports MySql.Data.MySqlClient
Public Class Form_AdicionarNovoPedido
    Dim numeroPedido As Integer = 1
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
    Private Sub Form_AdicionarNovoPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedidasForm()
        LimparCampos()
        CentralizarControlesNoForm(Me, {Panel1}, horizontal:=True, vertical:=False)

        AtualizarNumeroPedido()
        PreencherMenuCategoria()
    End Sub
    Private Sub AtualizarNumeroPedido()
        lbl_numero_pedido.Text = "PEDIDO " & numeroPedido & ":"
    End Sub
    Private Sub PreencherMenuCategoria()
        cms_categoria.Items.Clear()

        Dim categorias As String() = {"Entrada", "Principal", "Sobremesa", "Bebida"}

        For Each cat In categorias
            Dim item As New ToolStripMenuItem(cat)
            AddHandler item.Click, AddressOf CategoriaSelecionada
            cms_categoria.Items.Add(item)
        Next
    End Sub
    Private Sub CategoriaSelecionada(sender As Object, e As EventArgs)
        If cms_categoria.Tag IsNot Nothing Then
            Dim categoriaSelecionada As String = CType(sender, ToolStripMenuItem).Text
            Dim txtRef As TextBox = TryCast(cms_categoria.Tag, TextBox)
            If txtRef IsNot Nothing Then
                txtRef.Text = categoriaSelecionada
            End If
        End If
    End Sub
    Private Sub PreencherItensCardapio(categoria As String)
        cms_itens.Items.Clear()

        Try
            Dim rs As Object
            rs = CreateObject("ADODB.Recordset")
            rs.Open("SELECT nome_item FROM cardapio WHERE categoria = '" & categoria & "'", db)

            Do Until rs.EOF
                Dim nome_item As String = rs.Fields("nome_item").Value
                Dim item As New ToolStripMenuItem(nome_item)
                AddHandler item.Click, AddressOf ItemSelecionado
                cms_itens.Items.Add(item)

                rs.MoveNext()
            Loop

            rs.Close()
            rs = Nothing

        Catch ex As Exception
            MsgBox("Erro ao carregar itens do cardápio: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub AdicionarNovoPedido()
        numeroPedido += 1

        Dim novoLabel As New Label()
        novoLabel.Text = "PEDIDO " & numeroPedido & ":"
        novoLabel.Font = New Font("Open Sans", 10, FontStyle.Bold)
        novoLabel.AutoSize = True
        novoLabel.Margin = New Padding(10, 10, 0, 0)
        novoLabel.ForeColor = Color.FromArgb(34, 40, 49)

        Dim txtCategoria As New TextBox()
        txtCategoria.Width = 150


        txtCategoria.ReadOnly = True
        txtCategoria.Margin = New Padding(10, 2, 0, 0)
        AddHandler txtCategoria.Click, Sub()
                                           cms_categoria.Tag = txtCategoria
                                           cms_categoria.Show(txtCategoria, New Point(0, txtCategoria.Height))
                                       End Sub

        Dim txtItem As New TextBox()
        txtItem.Width = 150

        txtItem.ReadOnly = True
        txtItem.Margin = New Padding(10, 2, 0, 0)
        AddHandler txtItem.Click, Sub()
                                      If txtCategoria.Text <> "" Then
                                          PreencherItensCardapio(txtCategoria.Text.ToLower())
                                          cms_itens.Tag = txtItem
                                          cms_itens.Show(txtItem, New Point(0, txtItem.Height))
                                      Else
                                          MsgBox("Escolha uma categoria primeiro.")
                                      End If
                                  End Sub

        FlowLayoutPanel1.Controls.Add(novoLabel)
        FlowLayoutPanel1.Controls.Add(txtCategoria)
        FlowLayoutPanel1.Controls.Add(txtItem)
    End Sub
    Private Sub ItemSelecionado(sender As Object, e As EventArgs)
        If cms_itens.Tag IsNot Nothing Then
            Dim itemSelecionado As String = CType(sender, ToolStripMenuItem).Text
            Dim txtRef As TextBox = TryCast(cms_itens.Tag, TextBox)
            If txtRef IsNot Nothing Then
                txtRef.Text = itemSelecionado
            End If
        End If
    End Sub
    Private Sub MedidasForm()
        menu.Top = 8
        menu.Left = 8

        barradeacoes.Top = 8
        barradeacoes.Left = Me.Width - barradeacoes.Width - 8

        TextBox1.Width = 150
        TextBox2.Width = 150

        Panel1.Top = 100
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
    Private Sub TelaInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TelaInicialToolStripMenuItem.Click
        Form_AtendimentoGarcom.Show()
        telaAnterior = Me
        Me.close()
    End Sub
    Private Sub LimparCampos()

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AdicionarNovoPedido()
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        cms_categoria.Tag = TextBox1
        cms_categoria.Show(TextBox1, New Point(0, TextBox1.Height))
    End Sub
    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        If TextBox1.Text <> "" Then
            PreencherItensCardapio(TextBox1.Text.ToLower())
            cms_itens.Tag = TextBox2
            cms_itens.Show(TextBox2, New Point(0, TextBox2.Height))
        Else
            MsgBox("Escolha uma categoria primeiro.")
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        AdicionarNovoPedido()
    End Sub
    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            Dim numeroMesa As Integer
            If Integer.TryParse(ComboBox1.Text, numeroMesa) = False Then
                MsgBox("Informe o número da mesa antes de concluir.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim ultimoPedidoMesa As Integer = 0
            Dim rsPedidoMesa As Object = CreateObject("ADODB.Recordset")
            rsPedidoMesa.Open("SELECT MAX(numero_pedido) AS max_pedido FROM pedidos WHERE numero_mesa = " & numeroMesa, db)

            If Not rsPedidoMesa.EOF AndAlso Not IsDBNull(rsPedidoMesa("max_pedido").Value) Then
                ultimoPedidoMesa = rsPedidoMesa("max_pedido").Value
            End If

            rsPedidoMesa.Close()
            rsPedidoMesa = Nothing

            Dim contadorPedidos As Integer = ultimoPedidoMesa

            For Each controle As Control In FlowLayoutPanel1.Controls
                If TypeOf controle Is Label Then
                    Dim index As Integer = FlowLayoutPanel1.Controls.GetChildIndex(controle)

                    If index + 2 < FlowLayoutPanel1.Controls.Count Then
                        Dim txtCategoria As TextBox = TryCast(FlowLayoutPanel1.Controls(index + 1), TextBox)
                        Dim txtItem As TextBox = TryCast(FlowLayoutPanel1.Controls(index + 2), TextBox)

                        If txtCategoria IsNot Nothing AndAlso txtItem IsNot Nothing Then
                            contadorPedidos += 1

                            Dim sql As String = "INSERT INTO pedidos (numero_pedido, numero_mesa, categoria, item, data_pedido, status_pedido, situacao_pedido) " &
                                            "VALUES (" & contadorPedidos & ", " & numeroMesa & ", '" &
                                            txtCategoria.Text & "', '" & txtItem.Text &
                                            "', Now(), 'em atendimento', 'pendente')"

                            db.Execute(sql)
                        End If
                    End If
                End If
            Next

            MsgBox("Pedidos registrados com sucesso!", MsgBoxStyle.Information)
            telaAnterior = Me
            Form_AtendimentoGarcom.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox("Erro ao salvar pedidos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class