Public Class frm_processo
	Private Sub frm_processo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		conectar_banco()
		carregar_processo()
	End Sub
	Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
		Try
			sql = "select * from tb_processo where processo= '" & txt_processo.Text & "'"
			rs = db.Execute(sql)
			If rs.EOF = True Then 'Se não existir o cliente na tabela
				sql = "insert into tb_processo (cpf,
												processo, 
												cpf_contra, 
												advo_contra,
												telefone, 
												celular, 
												email, 
												andamento, 
												vara, 
												comarca, 
												fase) 
												values ('" & txt_cpf.Text & "', " &
														"'" & txt_processo.Text & "', " &
														"'" & txt_cpfx.Text & "', " &
														"'" & txt_advogado.Text & "', " &
														"'" & txt_tel.Text & "', " &
														"'" & txt_cel.Text & "', " &
														"'" & txt_email.Text & "', " &
														"'" & txt_andamento.Text & "', " &
														"'" & txt_vara.Text & "', " &
														"'" & txt_comarca.Text & "', " &
														"'" & txt_fase.Text & "')"
				rs = db.Execute(sql)
				MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
				limpar_processo()
				carregar_processo()
			Else
				MsgBox("Processo: " & txt_processo.Text & ", Já cadastrado", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
			End If
		Catch ex As Exception
			MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
		End Try
	End Sub
	Private Sub dgv_processo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellContentClick
		'Try
		With dgv_cliente
			If .CurrentRow.Cells(4).Selected Then
				aux = .CurrentRow.Cells(2).Value
				sql = "select cliente from tb_cadastro where cpf='" & aux & "'"
				rs = db.Execute(sql)
				If rs.EOF = False Then
					txt_cliente.Text = rs.Fields(0).Value
				End If

				sql = "select * from tb_cadastro where cpf='" & aux & "'"
				rs = db.Execute(sql)

				If rs.EOF = False Then
					dgv_processo.SelectTab(1) 'aba 1
					txt_cpf.Text = rs.Fields(0).Value
					txt_processo.Clear()
					txt_cpfx.Clear()
					txt_vara.Clear()
					txt_comarca.Clear()
					txt_advogado.Clear()
					txt_tel.Clear()
					txt_cel.Clear()
					txt_email.Clear()
					txt_andamento.Clear()

				End If
			Else
				Exit Sub
			End If
		End With
		'Catch ex As Exception
		'MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		'End Try
	End Sub
	Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
		sql = "select cliente from tb_cadastro where cpf = '" & txt_cpf.Text & "'"
		rs = db.Execute(sql)
		If rs.EOF = False Then
			txt_cliente.Text = rs.Fields(0).Value
		End If
	End Sub
	Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
		Try
			If dgv_cliente.Focus Then
				txt_busca.Focus()
				sql = "select * from tb_cadastro where cpf like '" & txt_busca.Text & "%'"
				rs = db.Execute(sql)
				cont = 1
				With dgv_cliente
					.Rows.Clear()
					Do While rs.EOF = False
						.Rows.Add(cont, rs.Fields(1).Value, rs.Fields(0).Value, rs.Fields(2).Value, Nothing, Nothing)
						rs.MoveNext()
						cont += 1
					Loop
				End With
			End If
			If dgv_processos.Focus Then
				txt_busca.Focus()
				sql = "select * from tb_processo where cpf like '" & txt_busca.Text & "%'"
				rs = db.Execute(sql)
				cont = 1
				With dgv_processos
					.Rows.Clear()
					Do While rs.EOF = False
						.Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value, Nothing)
						rs.MoveNext()
						cont += 1
					Loop
				End With
			End If
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub
	Private Sub dgv_processos_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_processos.CellContentClick
		Try
			With dgv_processos
				If .CurrentRow.Cells(6).Selected Then
					aux = .CurrentRow.Cells(1).Value
					sql = "select cliente from tb_cadastro where cpf='" & aux & "'"
					rs = db.Execute(sql)
					If rs.EOF = False Then
						txt_cliente.Text = rs.Fields(0).Value
					End If

					aux = .CurrentRow.Cells(2).Value
					sql = "select * from tb_processo where processo='" & aux & "'"
					rs = db.Execute(sql)

					If rs.EOF = False Then
						dgv_processo.SelectTab(1) 'aba 1
						txt_cpf.Text = rs.Fields(0).Value
						txt_processo.Text = rs.Fields(1).Value
						txt_cpfx.Text = rs.Fields(2).Value
						txt_vara.Text = rs.Fields(8).Value
						txt_comarca.Text = rs.Fields(9).Value
						txt_advogado.Text = rs.Fields(3).Value
						txt_tel.Text = rs.Fields(4).Value
						txt_cel.Text = rs.Fields(5).Value
						txt_email.Text = rs.Fields(6).Value
						txt_andamento.Text = rs.Fields(7).Value
						txt_fase.Text = rs.Fields(10).Value

					End If
				Else
					Exit Sub
				End If
			End With

		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Private Sub btn_encerrar_Click(sender As Object, e As EventArgs) Handles btn_encerrar.Click
		frm_login.Show()
		Exit Sub
	End Sub
End Class