Public Class frm_financeiro
	Private Sub frm_financeiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		conectar_banco()
		carregar_financeiro()
	End Sub

	Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar1.Click
		Try
			sql = "select * from tb_processo where processo= '" & txt_processo.Text & "'"
			rs = db.Execute(sql)
			If rs.EOF = True Then 'Se não existir o cliente na tabela
				sql = "insert into tb_processo (valor, pago, obsfinanceiro, data) values ('" & txt_valor.Text & "', " &
																						"'" & txt_pago.Text & "', " &
																						"'" & txt_obs.Text & "', " &
																						"'" & txt_dataa.Text & "')"
				rs = db.Execute(sql)
				MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
				limpar_financeiro()
				carregar_financeiro()
			Else
				sql = "update tb_processo set valor= '" & txt_valor.Text & "'," &
											  "pago= '" & txt_pago.Text & "'," &
											  "obsfinanceiro= '" & txt_obs.Text & "', " &
											  "data= '" & txt_dataa.Text & "' where processo='" & txt_processo.Text & "'"
				rs = db.Execute(sql)
				MsgBox("Dados alterados com sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
				limpar_financeiro()
				carregar_financeiro()
			End If
		Catch ex As Exception
			MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
		End Try
	End Sub

	Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
		Try
			sql = "select * from tb_processo where cliente like '" & txt_busca.Text & "%'"
			rs = db.Execute(sql)
			cont = 1
			With dgv_financeiro
				.Rows.Clear()
				Do While rs.EOF = False
					.Rows.Add(cont, rs.Fields(1).Value, rs.Fields("").Value, rs.Fields(11).Value, rs.Fields(12).Value, Nothing)
					rs.MoveNext()
					cont += 1
				Loop
			End With
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub dgv_financeiro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_financeiro.CellContentClick
		Try
			With dgv_financeiro
				If .CurrentRow.Cells(5).Selected Then
					aux = .CurrentRow.Cells(1).Value
					sql = "select cliente from tb_cadastro where cpf='" & aux & "'"
					rs = db.Execute(sql)
					If rs.EOF = False Then
						txt_cliente.Text = rs.Fields(0).Value
					End If
					aux = .CurrentRow.Cells(2).Value
					sql = "select * from tb_processo where processo= '" & aux & "'"
					rs = db.Execute(sql)

					If rs.EOF = False Then
						TabControl1.SelectTab(0) 'aba 1
						txt_cpf.Text = rs.Fields(0).Value
						txt_processo.Text = rs.Fields(1).Value
						txt_valor.Text = rs.Fields(11).Value
						txt_pago.Text = rs.Fields(12).Value
						txt_obs.Text = rs.Fields(13).Value + " " 'Gambiarra 
						txt_dataa.Text = rs.Fields(14).Value + " " 'Gambiarra 
					Else
						TabControl1.SelectTab(1) 'aba 1
						aux = .CurrentRow.Cells(2).Value
						sql = "select * from tb_processo where processo='" & aux & "'"
						rs = db.Execute(sql)
						aux = rs.Fields(2).Value
						txt_cpf.Text = rs.Fields(1).Value
						txt_processo.Text = aux
						txt_valor.Clear()
						txt_pago.Clear()
						txt_obs.Clear()
						txt_dataa.Clear()
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
			sql = "select * from tb_processo where processo= '" & txt_processo.Text & "'"
			rs = db.Execute(sql)
			If rs.EOF = True Then 'Se não existir o cliente na tabela
				sql = "insert into tb_processo (valor, pago, obsfinanceiro) values ('" & txt_valor.Text & "', " &
																						"'" & txt_pago.Text & "', " &
																						"'" & txt_obs.Text & "')"
				rs = db.Execute(sql)
				MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
				limpar_financeiro()
				carregar_financeiro()
			Else
				sql = "update tb_processo set valor= '" & txt_valor.Text & "'," &
											  "pago= '" & txt_pago.Text & "'," &
											  "obsfinanceiro= '" & txt_obs.Text & "' where processo='" & txt_processo.Text & "'"
				rs = db.Execute(sql)
				MsgBox("Dados alterados com sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
				limpar_financeiro()
				carregar_financeiro()
			End If
		Catch ex As Exception
			MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
		End Try
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		frm_login.ShowDialog()
		Exit Sub
	End Sub
End Class