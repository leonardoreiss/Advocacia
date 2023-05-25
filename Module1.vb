Module Module1
	Public sql, aux, resp As String
	Public db As New ADODB.Connection
	Public rs As New ADODB.Recordset
	Public dirbanco = Application.StartupPath & "\banco\projeto.mdb"
	Public cont As Integer

	Sub conectar_banco()
		Try
			db = CreateObject("ADODB.Connection")
			db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
			'MsgBox("Conexão bem sucedida", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
		Catch ex As Exception
			MsgBox("Falha na conexão do banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Sub limpar_cad_funcionarios()
		Try
			With frm_funcionarios
				.txt_nome_cad.Clear()
				.txt_cpf_cad.Clear()
				.txt_user_cad.Clear()
				.txt_senha_cad.Clear()
				.txt_nome_cad.Focus()
			End With
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub
	Sub carregar_cad_dados()
		Try
			sql = "select * from tb_login order by usuario asc"
			rs = db.Execute(sql)
			cont = 1
			With frm_funcionarios.dgv_funcionarios
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

	Sub limpar_cadastro()
		Try
			With frm_cadastro
				.txt_cpf.Clear()
				.txt_cliente.Clear()
				.txt_pasta.Clear()
				.txt_rua.Clear()
				.txt_numRua.Clear()
				.txt_comp.Clear()
				.txt_cidade.Clear()
				.txt_estado.Clear()
				.txt_cep.Clear()
				.txt_bairro.Clear()
				.txt_tel.Clear()
				.txt_cel.Clear()
				.txt_email.Clear()
				.txt_obs.Clear()
				.txt_niver.Clear()
				.txt_cpf.Focus()

			End With
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Sub carregar_cadastro()
		Try
			sql = "select * from tb_cadastro order by cliente asc"
			rs = db.Execute(sql)
			cont = 1
			With frm_cadastro.dgv_cadastro
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

	Sub carregar_financeiro()
		Try
			sql = "select * from tb_processo order by cpf asc"
			rs = db.Execute(sql)
			cont = 1
			With frm_financeiro.dgv_financeiro
				.Rows.Clear()
				Do While rs.EOF = False
					.Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(11).Value, rs.Fields(12).Value, Nothing)
					rs.MoveNext()
					cont = cont + 1
				Loop
			End With
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Sub limpar_financeiro()
		Try
			With frm_financeiro
				.txt_cpf.Clear()
				.txt_cliente.Clear()
				.txt_processo.Clear()
				.txt_valor.Clear()
				.txt_pago.Clear()
				.txt_obs.Clear()
				.txt_valor.Focus()
			End With
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Sub carregar_processo()
		Try
			sql = "select * from tb_cadastro order by cliente asc"
			rs = db.Execute(sql)
			cont = 1
			With frm_processo.dgv_cliente
				.Rows.Clear()
				Do While rs.EOF = False
					.Rows.Add(cont, rs.Fields(1).Value, rs.Fields(0).Value, rs.Fields(2).Value, Nothing)
					rs.MoveNext()
					cont = cont + 1
				Loop
			End With
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
		Try
			sql = "select * from tb_processo order by cpf asc"
			rs = db.Execute(sql)
			cont = 1
			With frm_processo.dgv_processos
				.Rows.Clear()
				Do While rs.EOF = False
					.Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value, Nothing)
					rs.MoveNext()
					cont = cont + 1
				Loop
			End With
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Sub limpar_processo()
		Try
			With frm_processo
				.txt_cpf.Clear()
				.txt_cliente.Clear()
				.txt_processo.Clear()
				.txt_vara.Clear()
				.txt_comarca.Clear()
				.txt_advogado.Clear()
				.txt_tel.Clear()
				.txt_cel.Clear()
				.txt_email.Clear()
				.txt_andamento.Clear()
				.txt_cpf.Focus()
			End With
		Catch ex As Exception
			MsgBox("Falha de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub

	Sub limpar_menu()
		Try
			With frm_login
				.txt_usuario.Clear()
				.txt_senha.Clear()
				.txt_usuario.Focus()
			End With
		Catch ex As Exception
			MsgBox("Falha de inicialização", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
		End Try
	End Sub
End Module
