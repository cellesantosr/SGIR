Public Class Form1
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedidasForm()
        CentralizarControlesNoForm(Me, {PictureBox2, Button1, Panel1, Panel2}, horizontal:=True, vertical:=False)
        ConectarBanco()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        telaAnterior = Me
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        telaAnterior = Me
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
    Private Sub MedidasForm()
        barradeacoes.Top = 12
        barradeacoes.Left = (Me.ClientSize.Width - 95)

        PictureBox1.Width = 60
        PictureBox1.Height = 60
        PictureBox2.Width = 300
        PictureBox2.Height = 300
        Button1.Width = 150
        Button1.Height = 50

        Panel1.Top = 70
        PictureBox2.Top = (Me.ClientSize.Height - PictureBox2.Height - 110) \ 2
        Button1.Top = (Me.ClientSize.Height - Button1.Height + 515) \ 2
        Panel2.Top = (Me.ClientSize.Height - Panel2.Height + 615) \ 2
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        telaAnterior = Me
        Form_ControleMesas.Show()
        Me.Hide()
    End Sub
End Class