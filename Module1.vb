Module Module1
    Public diretorio, SQL, aux_cpf, resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public status = 0, cont As Integer
    Public telaAnterior As Form
    Public UsuarioLogado As String = ""

    Sub ConectarBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver}; SERVER=localhost; DATABASE=casa_machadodb; UID=root; PWD=usbw; port=3307; option=3;s")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Application.Exit()
        End Try
    End Sub

    Public Sub CentralizarControlesNoForm(formulario As Form, controles() As Control, Optional horizontal As Boolean = True, Optional vertical As Boolean = True)
        For Each ctrl As Control In controles
            If horizontal Then
                ctrl.Left = (formulario.ClientSize.Width - ctrl.Width) \ 2
            End If
        Next
    End Sub
End Module
