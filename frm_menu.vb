Public Class frm_menu
    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Close()
        frm_cadastro.Show()
    End Sub

    Private Sub btn_processo_Click(sender As Object, e As EventArgs) Handles btn_processo.Click
        Close()
        frm_processo.Show()
    End Sub

    Private Sub btn_financeiro_Click(sender As Object, e As EventArgs) Handles btn_financeiro.Click
        Close()
        frm_financeiro.Show()
    End Sub

    Private Sub btn_encerrar_Click(sender As Object, e As EventArgs) Handles btn_encerrar.Click
        Close()
        frm_login.Show()
    End Sub
End Class