Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.VisualBasic.Logging

Public Class Form_ControleMesas
    Dim loginUsuario = UsuarioLogado
    Dim mesaSelecionada As Label = Nothing ' Label atualmente selecionada
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
    Private Sub Form_ControleMesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedidasForm()
        MedidasMesas()

        Label3.Visible = True

        For i As Integer = 1 To 18
            Dim lbl As Label = CType(Me.Controls("mesa" & i.ToString()), Label)
            AddHandler lbl.Click, AddressOf LabelMesa_Click
        Next
        cb_status_mesa.Items.Add("Livre")
        cb_status_mesa.Items.Add("Reservado")
        cb_status_mesa.Items.Add("Ocupado")
        cb_status_mesa.SelectedIndex = 0

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
        CentralizarControlesNoForm(Me, {Label1}, horizontal:=True, vertical:=False)
    End Sub

    Private Sub LabelMesa_Click(sender As Object, e As EventArgs)

        For i As Integer = 1 To 18
            Dim lbl As Label = CType(Me.Controls("mesa" & i.ToString()), Label)
            AddHandler lbl.Click, AddressOf LabelMesa_Click

        Next
        cb_status_mesa.SelectedIndex = 0

        If mesaSelecionada IsNot Nothing Then
            ' Restaura a cor com base no status atual da mesa
            Select Case mesaSelecionada.Tag
                Case "Livre"
                    mesaSelecionada.BackColor = Color.Lime
                Case "Reservado"
                    mesaSelecionada.BackColor = Color.Gray
                Case "Ocupado"
                    mesaSelecionada.BackColor = Color.Red
            End Select
        End If

        ' Define a nova mesa selecionada
        mesaSelecionada = CType(sender, Label)

        ' Destaca a nova mesa selecionada
        mesaSelecionada.BackColor = Color.Yellow
    End Sub

    Private Sub Form_ControleMesas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
    Private Sub voltar_Click(sender As Object, e As EventArgs) Handles voltar.Click
        telaAnterior.Show()
        telaAnterior = Me
        Me.Hide()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub sair_Click(sender As Object, e As EventArgs) Handles sair.Click
        resp = MsgBox("Tem certeza que deseja encerrar o programa?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        cms_menu.Show(menu, New Point(0, menu.Height))
    End Sub

    Private Sub MedidasForm()
        menu.Height = 24
        menu.Width = 24
        barradeacoes.Top = 12
        barradeacoes.Left = (Me.ClientSize.Width - 95)
        menu.Top = 10
        menu.Left = 10
        Label2.Text = DateTime.Now.ToString("Dia: dd/MM/yyyy | \Hora: HH:mm:ss")
        PictureBox1.Height = Me.Height - 102
        PictureBox1.Width = 570
        PictureBox1.Top = 56
        PictureBox1.Left = 77
        titulo.Top = 100
        titulo.Left = PictureBox1.Width + PictureBox1.Left + 50
        Label1.Top = 10
        Label2.Left = titulo.Left + 3
        Label2.Top = titulo.Top + titulo.Height
        Label3.Left = (Me.Width - Label3.Width + PictureBox1.Width) / 2
        Label3.Top = (Me.Height - Label2.Height) / 2 - 100
    End Sub
    Private Sub MedidasMesas()
        mesa1.Height = 85
        mesa1.Width = 35
        mesa1.Left = PictureBox1.Left + 54
        mesa1.Top = PictureBox1.Top + 34

        mesa2.Height = 85
        mesa2.Width = 35
        mesa2.Left = PictureBox1.Left + 54
        mesa2.Top = mesa1.Top + mesa1.Height + 29

        mesa3.Height = 85
        mesa3.Width = 35
        mesa3.Left = PictureBox1.Left + 54
        mesa3.Top = mesa2.Top + mesa2.Height + 27

        mesa4.Height = 85
        mesa4.Width = 35
        mesa4.Left = PictureBox1.Left + 54
        mesa4.Top = mesa3.Top + mesa3.Height + 28

        '---------------------------------------------------

        mesa5.Height = 70
        mesa5.Width = 36
        mesa5.Left = PictureBox1.Left + 55
        mesa5.Top = mesa4.Top + mesa4.Height + 117

        mesa6.Height = 70
        mesa6.Width = 36
        mesa6.Left = PictureBox1.Left + 55
        mesa6.Top = mesa5.Top + mesa5.Height + 26

        mesa7.Height = 70
        mesa7.Width = 36
        mesa7.Left = mesa5.Left + 74
        mesa7.Top = mesa4.Top + mesa4.Height + 117

        mesa8.Height = 70
        mesa8.Width = 36
        mesa8.Left = mesa6.Left + 74
        mesa8.Top = mesa5.Top + mesa5.Height + 26

        mesa9.Height = 70
        mesa9.Width = 36
        mesa9.Left = mesa7.Left + 73
        mesa9.Top = mesa4.Top + mesa4.Height + 118

        mesa10.Height = 70
        mesa10.Width = 36
        mesa10.Left = mesa8.Left + 73
        mesa10.Top = mesa5.Top + mesa5.Height + 26

        '----------------------------------------------------

        mesa11.Height = 35
        mesa11.Width = 80
        mesa11.Left = 405
        mesa11.Top = 114

        mesa15.Height = 35
        mesa15.Width = 80
        mesa15.Left = 526
        mesa15.Top = 114

        mesa14.Height = 35
        mesa14.Width = 80
        mesa14.Left = 401
        mesa14.Top = 493

        mesa18.Height = 35
        mesa18.Width = 80
        mesa18.Left = 521
        mesa18.Top = 493

        '-----------------------------------------------------

        mesa12.Height = 85
        mesa12.Width = 37
        mesa12.Left = 414
        mesa12.Top = 185

        mesa13.Height = 85
        mesa13.Width = 37
        mesa13.Left = 414
        mesa13.Top = mesa12.Top + mesa12.Height + 95

        mesa16.Height = 87
        mesa16.Width = 37
        mesa16.Left = 555
        mesa16.Top = 183

        mesa17.Height = 85
        mesa17.Width = 37
        mesa17.Left = 555
        mesa17.Top = mesa12.Top + mesa12.Height + 96


        Label4.Top = 500
        Label4.Left = 900
        cb_status_mesa.Top = 500
        cb_status_mesa.Left = 1000
        btnConfirmar.Top = 485
        btnConfirmar.Left = 1100
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = DateTime.Now.ToString("Dia: dd/MM/yyyy | \Hora: HH:mm:ss")
    End Sub
    Private Sub EncerrarSessãoSAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoSAIRToolStripMenuItem.Click
        resp = MsgBox("Tem certeza que deseja encerrar sessão?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            telaAnterior = Form1
            Form1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If mesaSelecionada Is Nothing Then
            MessageBox.Show("Selecione uma mesa primeiro.")
            Exit Sub
        End If

        Select Case cb_status_mesa.Text
            Case "Reservado"
                mesaSelecionada.BackColor = Color.Gray
            Case "Ocupado"
                mesaSelecionada.BackColor = Color.Red
            Case "Livre"
                mesaSelecionada.BackColor = Color.Green
            Case Else
                MessageBox.Show("Selecione um status válido.")
        End Select

        mesaSelecionada = Nothing
    End Sub
End Class