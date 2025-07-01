Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class Form_GestaoDeFuncionarios
    Dim conexao As MySqlConnection
    Dim adaptador As MySqlDataAdapter
    Dim tabela As DataTable
    Dim campoSelecionado As String = "primeiro_nome"
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
    '--------------------------------------------------------------------------------------------
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub sair_Click(sender As Object, e As EventArgs) Handles sair.Click
        resp = MsgBox("Tem certeza que deseja encerrar o programa?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub
    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        telaAnterior.Show()
        telaAnterior = Me
        Me.Hide()
    End Sub
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        cms_menu.Show(menu, New Point(0, menu.Height))
    End Sub
    '--------------------------------------------------------------------------------------------
    Private Sub Form_GestaoDeFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarTodosCadastros()
        MedidasForm_GestaoDeFuncionarios()
        CentralizarControlesNoForm(Me, {Label1, dgv_funcionarios, Panel1}, horizontal:=True, vertical:=False)
        cbo_opcoes.Visible = False
        With dgv_funcionarios
            .Columns("primeiro_nome").HeaderText = "Nome"
            .Columns("sobrenome").HeaderText = "Sobrenome"
            .Columns("cpf").HeaderText = "CPF"
            .Columns("celular").HeaderText = "Celular"
            .Columns("email").HeaderText = "E-mail"
            .Columns("data_de_nascimento").HeaderText = "Data de Nascimento"
            .Columns("setor").HeaderText = "Setor"
            .Columns("cargo").HeaderText = "Cargo"
            .Columns("codigo_de_funcionario").HeaderText = "Código"
            .Columns("usuario").HeaderText = "Usuário"
            .Columns("situacao").HeaderText = "Situação"
        End With
    End Sub
    Private Sub dgv_funcionarios_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_funcionarios.CellFormatting
        If dgv_funcionarios.Columns(e.ColumnIndex).Name = "situacao" Then
            Dim valor As String = dgv_funcionarios.Rows(e.RowIndex).Cells("situacao").Value.ToString()

            If valor.ToLower() = "bloqueado" Then
                dgv_funcionarios.Rows(e.RowIndex).Cells("situacao").Style.BackColor = Color.IndianRed
            End If

            If valor.ToLower() = "ativo" Then
                dgv_funcionarios.Rows(e.RowIndex).Cells("situacao").Style.BackColor = Color.LightGreen
            End If
        End If
    End Sub
    Sub CarregarTodosCadastros()
        Try
            conexao = New MySqlConnection("server=localhost;user id=root;password=usbw;database=casa_machadodb;port=3307")
            conexao.Open()

            Dim sql As String = "SELECT 
                                primeiro_nome, 
                                sobrenome, 
                                cpf, 
                                celular, 
                                email, 
                                data_de_nascimento, 
                                setor, 
                                cargo, 
                                codigo_de_funcionario, 
                                usuario, 
                                situacao 
                                FROM cadastros 
                                ORDER BY primeiro_nome ASC"
            adaptador = New MySqlDataAdapter(sql, conexao)
            tabela = New DataTable()
            adaptador.Fill(tabela)
            dgv_funcionarios.DataSource = tabela

            conexao.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados: " & ex.Message)
        End Try
    End Sub
    Private Sub MedidasForm_GestaoDeFuncionarios()
        titulo.Top = 100
        titulo.Left = 135
        menu.Height = 24
        menu.Width = 24
        barradeacoes.Top = 12
        barradeacoes.Left = (Me.ClientSize.Width - 95)
        menu.Top = 10
        menu.Left = 10
        Label1.Top = 10
        Label2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

        dgv_funcionarios.Width = Me.ClientSize.Width - 280
        Panel1.Width = dgv_funcionarios.Width

        Panel1.Top = 190
        Panel1.Height = 50

        dgv_funcionarios.Top = Panel1.Height + Panel1.Top
        dgv_funcionarios.Height = 380
        btn_salvar_alteracoes.Top = dgv_funcionarios.Top + dgv_funcionarios.Height + 30

        btn_salvar_alteracoes.Left = 140
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub
    Private Sub txt_pesquisar_Click(sender As Object, e As EventArgs) Handles txt_pesquisar.Click
        cms_pesquisa.Show(txt_pesquisar, 0, txt_pesquisar.Height)
    End Sub
    Private Sub cms_pesquisa_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cms_pesquisa.ItemClicked
        Dim opcaoSelecionada As String = e.ClickedItem.Text
        lbl_buscar.Text = "Buscar por: "
        txt_encontrar.Clear()
        txt_encontrar.Enabled = True
        txt_encontrar.Mask = ""

        Select Case opcaoSelecionada
            Case "Celular"
                txt_encontrar.Mask = "(00) 00000-0000"

            Case "Data de Nascimento"
                txt_encontrar.Mask = "00/00/0000"

            Case "CPF"
                txt_encontrar.Mask = "000.000.000-00"

            Case "Setor", "Cargo", "Situação"
                txt_encontrar.Enabled = False
                ExibirOpcoes(opcaoSelecionada)

            Case Else
                txt_encontrar.Mask = ""
        End Select
        If opcaoSelecionada = "Setor" OrElse opcaoSelecionada = "Cargo" OrElse opcaoSelecionada = "Situação" Then
            cbo_opcoes.Visible = True
            txt_encontrar.Visible = False
        Else
            cbo_opcoes.Visible = False
            txt_encontrar.Visible = True
        End If

    End Sub
    Private Sub ExibirOpcoes(categoria As String)
        Dim opcoes As New List(Of String)

        Select Case categoria
            Case "Setor"
                opcoes = New List(Of String) From {"Atendimento", "Cozinha", "Administração"}

            Case "Cargo"
                opcoes = New List(Of String) From {"Maître/Recepcionista", "Garçom", "Cozinheiro", "Chef de cozinha", "Gerente", "Administrador"}

            Case "Situação"
                opcoes = New List(Of String) From {"Ativo", "Bloqueado"}
        End Select
        cbo_opcoes.DataSource = opcoes
        cbo_opcoes.Visible = True
        txt_encontrar.Visible = False
    End Sub

    Private Sub btn_procurar_Click(sender As Object, e As EventArgs) Handles btn_procurar.Click
        ' Verificação de entrada
        Dim pesquisa As String = ""

        If txt_encontrar.Visible Then
            If String.IsNullOrWhiteSpace(txt_encontrar.Text) Then
                MessageBox.Show("Por favor, digite o que deseja encontrar!")
                Exit Sub
            End If

            Select Case campoSelecionado
                Case "data_de_nascimento"
                    Dim data As Date
                    If Date.TryParseExact(txt_encontrar.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, data) Then
                        pesquisa = data.ToString("yyyy-MM-dd")
                    Else
                        MessageBox.Show("Data de nascimento inválida! Use o formato dd/MM/aaaa.")
                        Exit Sub
                    End If
                Case "cpf"
                    Dim cpfLimpo As String = New String(txt_encontrar.Text.Where(AddressOf Char.IsDigit).ToArray())
                    If cpfLimpo.Length = 11 Then
                        pesquisa = String.Format("{0:000\.000\.000\-00}", Convert.ToUInt64(cpfLimpo))
                    Else
                        MessageBox.Show("CPF inválido! Digite os 11 números corretamente.")
                        Exit Sub
                    End If

                Case Else
                    pesquisa = txt_encontrar.Text.Trim()
            End Select

        ElseIf cbo_opcoes.Visible Then
            If cbo_opcoes.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(cbo_opcoes.Text) Then
                MessageBox.Show("Por favor, selecione uma opção!")
                Exit Sub
            End If
            pesquisa = cbo_opcoes.Text.Trim()
        Else
            MessageBox.Show("Por favor, selecione um campo de busca!")
            Exit Sub
        End If

        ' Consulta no banco de dados
        Try
            Using conexao As New MySqlConnection("server=localhost;user id=root;password=usbw;database=casa_machadodb;port=3307")
                conexao.Open()

                Dim sql As String
                If campoSelecionado = "CPF" Or campoSelecionado = "data_de_nascimento" Or campoSelecionado = "celular" Then
                    MsgBox(campoSelecionado)
                    sql = $"SELECT 
                            primeiro_nome, sobrenome, cpf, celular, email, 
                            DATE_FORMAT(NULLIF(data_de_nascimento, '0000-00-00'), '%d/%m/%Y') AS data_de_nascimento,
                            setor, cargo, codigo_de_funcionario, usuario, situacao
                        FROM cadastros 
                        WHERE {campoSelecionado} = @pesquisa 
                        ORDER BY {campoSelecionado} ASC"

                Else
                    sql = $"SELECT 
                            primeiro_nome, sobrenome, cpf, celular, email, 
                            DATE_FORMAT(NULLIF(data_de_nascimento, '0000-00-00'), '%d/%m/%Y') AS data_de_nascimento,
                            setor, cargo, codigo_de_funcionario, usuario, situacao
                        FROM cadastros 
                        WHERE {campoSelecionado} LIKE @pesquisa 
                        ORDER BY {campoSelecionado} ASC"

                End If

                Using adaptador As New MySqlDataAdapter(sql, conexao)
                    If sql.Contains("LIKE") Then
                        adaptador.SelectCommand.Parameters.AddWithValue("@pesquisa", "%" & pesquisa & "%")
                    Else
                        adaptador.SelectCommand.Parameters.AddWithValue("@pesquisa", pesquisa)
                    End If

                    Dim tabela As New DataTable()
                    adaptador.Fill(tabela)

                    If tabela.Rows.Count = 0 Then
                        MessageBox.Show("Nenhum cadastro encontrado com essas informações!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    dgv_funcionarios.DataSource = tabela
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro na pesquisa: " & ex.Message)
        End Try
    End Sub


    ' -----------------------------------------------------------------------------------------------
    Private Sub limpar_filtros_Click(sender As Object, e As EventArgs) Handles limpar_filtros.Click
        campoSelecionado = "primeiro_nome"
        txt_pesquisar.Text = ""
        txt_encontrar.Text = ""
        cbo_opcoes.Text = ""

        CarregarTodosCadastros()
    End Sub
    Private Sub PrimeiroNomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimeiroNomeToolStripMenuItem.Click
        campoSelecionado = "primeiro_nome"
        txt_pesquisar.Text = "Primeiro Nome"
        txt_encontrar.Text = ""
    End Sub
    Private Sub SobrenomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobrenomeToolStripMenuItem.Click
        campoSelecionado = "sobrenome"
        txt_pesquisar.Text = "Sobrenome"
        txt_encontrar.Text = ""
    End Sub
    Private Sub CPFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CPFToolStripMenuItem.Click
        campoSelecionado = "cpf"
        txt_pesquisar.Text = "CPF"
        txt_encontrar.Text = ""
    End Sub
    Private Sub CelularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CelularToolStripMenuItem.Click
        campoSelecionado = "celular"
        txt_pesquisar.Text = "Celular"
        txt_encontrar.Text = ""
    End Sub
    Private Sub EmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailToolStripMenuItem.Click
        campoSelecionado = "email"
        txt_pesquisar.Text = "Email"
        txt_encontrar.Text = ""
    End Sub
    Private Sub DataDeNascimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDeNascimentoToolStripMenuItem.Click
        campoSelecionado = "data_de_nascimento"
        txt_pesquisar.Text = "Data de Nascimento"
        txt_encontrar.Text = ""
    End Sub
    Private Sub SetorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetorToolStripMenuItem.Click
        campoSelecionado = "setor"
        txt_pesquisar.Text = "Setor"
        txt_encontrar.Text = ""
    End Sub
    Private Sub CargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem.Click
        campoSelecionado = "cargo"
        txt_pesquisar.Text = "Cargo"
        txt_encontrar.Text = ""
    End Sub
    Private Sub CódigoDeFuncionárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CódigoDeFuncionárioToolStripMenuItem.Click
        campoSelecionado = "codigo_de_funcionario"
        txt_pesquisar.Text = "Código de Funcionário"
        txt_encontrar.Text = ""
    End Sub
    Private Sub UsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuárioToolStripMenuItem.Click
        campoSelecionado = "usuario"
        txt_pesquisar.Text = "Usuário"
        txt_encontrar.Text = ""
    End Sub
    Private Sub SituaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SituaçãoToolStripMenuItem.Click
        campoSelecionado = "situacao"
        txt_pesquisar.Text = "Situação"
        txt_encontrar.Text = ""
    End Sub
    Private Sub dgv_funcionarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_funcionarios.CellDoubleClick
        If e.RowIndex >= 0 AndAlso dgv_funcionarios.Columns(e.ColumnIndex).Name = "situacao" Then
            Dim celula = dgv_funcionarios.Rows(e.RowIndex).Cells("situacao")
            If celula.Value.ToString().ToLower() = "ativo" Then
                celula.Value = "Bloqueado"
            Else
                celula.Value = "Ativo"
            End If
        End If
    End Sub

    Private Sub btn_salvar_alteracoes_Click_1(sender As Object, e As EventArgs) Handles btn_salvar_alteracoes.Click
        Try
            Using conexao As New MySqlConnection("server=localhost;user id=root;password=usbw;database=casa_machadodb;port=3307")
                conexao.Open()

                For Each row As DataGridViewRow In dgv_funcionarios.Rows
                    If Not row.IsNewRow Then
                        Dim situacao = row.Cells("situacao").Value.ToString()
                        Dim codigo = row.Cells("codigo_de_funcionario").Value.ToString()

                        Dim comando As New MySqlCommand("UPDATE cadastros SET situacao = @situacao WHERE codigo_de_funcionario = @codigo", conexao)
                        comando.Parameters.AddWithValue("@situacao", situacao)
                        comando.Parameters.AddWithValue("@codigo", codigo)

                        comando.ExecuteNonQuery()
                    End If
                Next

                MessageBox.Show("Situações atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

            CarregarTodosCadastros() ' Recarrega os dados atualizados
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar alterações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ControleDeMesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleDeMesasToolStripMenuItem.Click

    End Sub

    Private Sub EncerrarSessãoSAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoSAIRToolStripMenuItem.Click
        resp = MsgBox("Tem certeza que deseja encerrar sessão?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            telaAnterior = Form1
            Form1.Show()
            Me.Close()
        End If
    End Sub
End Class