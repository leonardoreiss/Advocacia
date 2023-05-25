
Public Class frm_cadastro
	Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		conectar_banco()
		carregar_cadastro()
	End Sub

	Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
		Try
			sql = "select * from tb_cadastro where cliente like '" & txt_busca.Text & "%'"
			rs = db.Execute(sql)
			cont = 1
			With dgv_cadastro
				.Rows.Clear()
				Do While rs.EOF = False
					.Rows.Add(cont, rs.Fields(1).Value, rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(10).Value, rs.Fields(11).Value, rs.Fields(12).Value, rs.Fields(13).Value, Nothing, Nothing)
					rs.MoveNext()
					cont = cont + 1
				Loop
			End With
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub dgv_cadastro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cadastro.CellContentClick
		Try
			With dgv_cadastro
				If .CurrentRow.Cells(8).Selected Then
					aux = .CurrentRow.Cells(2).Value
					sql = "select * from tb_cadastro where cpf = '" & aux & "'"
					rs = db.Execute(sql)

					If rs.EOF = False Then
						TabControl1.SelectTab(0) 'aba 1
						txt_cpf.Text = rs.Fields(0).Value
						txt_cliente.Text = rs.Fields(1).Value
						txt_pasta.Text = rs.Fields(2).Value
						txt_rua.Text = rs.Fields(3).Value
						txt_numRua.Text = rs.Fields(4).Value
						txt_comp.Text = rs.Fields(5).Value
						txt_cidade.Text = rs.Fields(6).Value
						txt_estado.Text = rs.Fields(7).Value
						txt_cep.Text = rs.Fields(8).Value
						txt_bairro.Text = rs.Fields(9).Value
						txt_tel.Text = rs.Fields(10).Value
						txt_cel.Text = rs.Fields(11).Value
						txt_email.Text = rs.Fields(12).Value
						txt_niver.Text = rs.Fields(13).Value
						txt_obs.Text = rs.Fields(14).Value
					End If
				ElseIf .CurrentRow.Cells(9).Selected Then
					aux = .CurrentRow.Cells(2).Value
					resp = MsgBox("Deseja realmente excluir" + vbNewLine &
									  "O CPF: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
					If resp = MsgBoxResult.Yes Then
						sql = "delete * from tb_cadastro where cpf = '" & aux & "'"
						rs = db.Execute(sql)
						carregar_cadastro()
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
			sql = "select * from tb_cadastro where cpf= '" & txt_cpf.Text & "'"
			rs = db.Execute(sql)
			If rs.EOF = True Then 'Se não existir o cpf na tabela
				sql = "insert into tb_cadastro values ('" & txt_cpf.Text & "', " &
									   "'" & txt_cliente.Text & "', " &
									   "'" & txt_pasta.Text & "', " &
									   "'" & txt_rua.Text & "', " &
									   "'" & txt_numRua.Text & "', " &
									   "'" & txt_comp.Text & "', " &
									   "'" & txt_cidade.Text & "', " &
									   "'" & txt_estado.Text & "', " &
									   "'" & txt_cep.Text & "', " &
									   "'" & txt_bairro.Text & "', " &
									   "'" & txt_tel.Text & "', " &
									   "'" & txt_cel.Text & "', " &
									   "'" & txt_email.Text & "', " &
									   "'" & txt_niver.Text & "', " &
									   "'" & txt_obs.Text & "')"
				rs = db.Execute(sql)
				MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
				limpar_cadastro()
				carregar_cadastro()
			Else
				MsgBox("CPF: " & txt_cpf.Text & ", Já cadastrado", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

			End If
		Catch ex As Exception
			MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
		End Try
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_encerrar.Click
		frm_login.Show()
		Exit Sub
	End Sub
End Class
