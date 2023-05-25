Public Class frm_funcionarios
	Private Sub frm_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		conectar_banco()
		carregar_cad_dados()
	End Sub

	Private Sub txt_cpf_cad_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf_cad.LostFocus
		Try
			sql = "select * from tb_login where cpf= '" & txt_cpf_cad.Text & "'"
			rs = db.Execute(sql)
			If rs.EOF = False Then
				txt_nome_cad.Text = rs.Fields(2).Value
				txt_user_cad.Text = rs.Fields(0).Value
				txt_senha_cad.Text = rs.Fields(3).Value
			Else
				txt_nome_cad.Focus()
			End If
		Catch ex As Exception
			MsgBox("Erro ao consultar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
		End Try
	End Sub

	Private Sub txt_cpf_cad_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf_cad.DoubleClick
		txt_nome_cad.Focus()
	End Sub

	Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
		Try
			sql = "select * from tb_login where usuario like '" & txt_busca.Text & "%'"
			rs = db.Execute(sql)
			cont = 1
			With dgv_funcionarios
				.Rows.Clear()
				Do While rs.EOF = False
					.Rows.Add(cont, rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
					rs.MoveNext()
					cont = cont + 1
				Loop
			End With
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub dgv_funcionarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_funcionarios.CellContentClick
		Try
			With dgv_funcionarios
				If .CurrentRow.Cells(7).Selected Then
					aux = .CurrentRow.Cells(3).Value
					sql = "select * from tb_login where cpf = '" & aux & "'"
					rs = db.Execute(sql)

					If rs.EOF = False Then
						TabControl1.SelectTab(0) 'aba 1
						txt_cpf_cad.Text = rs.Fields(1).Value
						txt_nome_cad.Text = rs.Fields(2).Value
						txt_user_cad.Text = rs.Fields(0).Value
						txt_senha_cad.Text = rs.Fields(3).Value
						txt_nivel.Text = rs.Fields(4).Value
						txt_status.Text = rs.Fields(5).Value
					End If
				ElseIf .CurrentRow.Cells(8).Selected Then
					aux = .CurrentRow.Cells(3).Value
					resp = MsgBox("Deseja realmente excluir" + vbNewLine &
									  "O CPF: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
					If resp = MsgBoxResult.Yes Then
						sql = "delete * from tb_login where cpf = '" & aux & "'"
						rs = db.Execute(sql)
						carregar_cad_dados()
					End If
				Else
					Exit Sub
				End If
			End With
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub btn_gravar_Click_1(sender As Object, e As EventArgs) Handles btn_gravar.Click
		Try
			sql = "select * from tb_login where usuario= '" & txt_user_cad.Text & "'"
			rs = db.Execute(sql)
			If rs.EOF = True Then 'Se não existir o User na tabela
				sql = "insert into tb_login values ('" & txt_user_cad.Text & "', " &
								   "'" & txt_cpf_cad.Text & "', " &
								   "'" & txt_nome_cad.Text & "', " &
								   "'" & txt_senha_cad.Text & "', " &
								   "'" & txt_nivel.Text & "', " &
								   "'" & txt_status.Text & "')"
				rs = db.Execute(sql)
				MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
				limpar_cad_funcionarios()
				carregar_cad_dados()
			Else
				sql = "update tb_login set usuario='" & txt_user_cad.Text & "'," &
						"cpf = '" & txt_cpf_cad.Text & "', " &
						"nome = '" & txt_nome_cad.Text & "', " &
						"senha = '" & txt_senha_cad.Text & "', " &
						"nivel = '" & txt_nivel.Text & "', " &
						"status = '" & txt_status.Text & "' where usuario='" & txt_user_cad.Text & "'"
				rs = db.Execute(sql)
				MsgBox("Dados alterados com sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
				limpar_cad_funcionarios()
				carregar_cad_dados()

			End If
		Catch ex As Exception
			MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
		End Try
	End Sub

	Private Sub btn_encerrar_Click(sender As Object, e As EventArgs) Handles btn_encerrar.Click
		frm_login.Show()
		Exit Sub
	End Sub
End Class