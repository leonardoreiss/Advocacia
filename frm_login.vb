Public Class frm_login
    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            sql = "select * from tb_login where usuario= '" & txt_usuario.Text & "' and senha= '" & txt_senha.Text & "'"
            rs = db.Execute(sql)
            aux = rs.Fields(4).Value
            If rs.EOF = False Then
                If aux = "I" Then
                    If rs.Fields(5).Value = "ATIVADA" Then
                        MsgBox("Login nível I" + vbCrLf +
                           "Redirecionando para:" + vbCrLf +
                           "Cadastro de clientes", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO")
                        limpar_menu()
                        frm_cadastro.Show()
                        Exit Sub
                    Else
                        MsgBox("Login inválido" + vbCrLf +
                           "Conta Bloqueada" + vbCrLf +
                           "Contate o administrador", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    End If

                ElseIf aux = "II" Then
                    If rs.Fields(5).Value = "ATIVADA" Then
                        MsgBox("Login nível II" + vbCrLf +
                           "Redirecionando para:" + vbCrLf +
                           "Área de processos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO")
                        limpar_menu()
                        frm_processo.Show()
                        Exit Sub
                    Else
                        MsgBox("Login inválido" + vbCrLf +
                           "Conta Bloqueada" + vbCrLf +
                           "Contate o administrador", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                ElseIf aux = "III" Then
                    If rs.Fields(5).Value = "ATIVADA" Then
                        MsgBox("Login nível III" + vbCrLf +
                           "Redirecionando para:" + vbCrLf +
                           "Área financeira", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO")
                        limpar_menu()
                        frm_financeiro.Show()
                        Exit Sub
                    Else
                        MsgBox("Login inválido" + vbCrLf +
                           "Conta Bloqueada" + vbCrLf +
                           "Contate o administrador", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                ElseIf aux = "IV" Then
                    If rs.Fields(5).Value = "ATIVADA" Then
                        MsgBox("Login nível IV" + vbCrLf +
                           "Redirecionando para:" + vbCrLf +
                           "Menu mestre", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO")
                        limpar_menu()
                        frm_menu.Show()
                        Exit Sub
                    Else
                        MsgBox("Login inválido" + vbCrLf +
                           "Conta Bloqueada" + vbCrLf +
                           "Contate o administrador", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                ElseIf aux = "V" Then
                    If rs.Fields(5).Value = "ATIVADA" Then
                        MsgBox("Login nível V" + vbCrLf +
                           "Redirecionando para:" + vbCrLf +
                           "Cadastro de funcionários", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO")
                        limpar_menu()
                        frm_funcionarios.Show()
                        Exit Sub
                    Else
                        MsgBox("Login inválido" + vbCrLf +
                           "Conta Bloqueada" + vbCrLf +
                           "Contate o desenvolvedor", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                End If
            Else
                MsgBox("Login inválido!!" + vbCrLf +
                       "Tente novamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro na leitura de Credênciais" + vbCrLf +
                   "Tente novamente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        limpar_menu()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class