<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_funcionarios
	Inherits System.Windows.Forms.Form

	'Descartar substituições de formulário para limpar a lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Exigido pelo Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
	'Pode ser modificado usando o Windows Form Designer.  
	'Não o modifique usando o editor de códigos.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_funcionarios))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_encerrar = New System.Windows.Forms.Button()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.ListBox()
        Me.txt_nivel = New System.Windows.Forms.ListBox()
        Me.txt_cpf_cad = New System.Windows.Forms.MaskedTextBox()
        Me.txt_senha_cad = New System.Windows.Forms.TextBox()
        Me.txt_user_cad = New System.Windows.Forms.TextBox()
        Me.txt_nome_cad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_funcionarios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_gravar1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_funcionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 468)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.btn_encerrar)
        Me.TabPage1.Controls.Add(Me.btn_gravar)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_status)
        Me.TabPage1.Controls.Add(Me.txt_nivel)
        Me.TabPage1.Controls.Add(Me.txt_cpf_cad)
        Me.TabPage1.Controls.Add(Me.txt_senha_cad)
        Me.TabPage1.Controls.Add(Me.txt_user_cad)
        Me.TabPage1.Controls.Add(Me.txt_nome_cad)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(715, 442)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CADASTRO DE FUNCIONÁRIOS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_encerrar
        '
        Me.btn_encerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_encerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_encerrar.Location = New System.Drawing.Point(473, 328)
        Me.btn_encerrar.Name = "btn_encerrar"
        Me.btn_encerrar.Size = New System.Drawing.Size(118, 52)
        Me.btn_encerrar.TabIndex = 72
        Me.btn_encerrar.Text = "ENCERRAR SESSÃO "
        Me.btn_encerrar.UseVisualStyleBackColor = False
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_gravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.Location = New System.Drawing.Point(287, 328)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(122, 52)
        Me.btn_gravar.TabIndex = 71
        Me.btn_gravar.Text = "GRAVAR"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Wide Latin", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(40, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(596, 23)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "CADASTRO DE FUNCIONÁRIOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(264, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Status da Conta"
        '
        'txt_status
        '
        Me.txt_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_status.FormattingEnabled = True
        Me.txt_status.ItemHeight = 20
        Me.txt_status.Items.AddRange(New Object() {"ATIVADA", "BLOQUEADA"})
        Me.txt_status.Location = New System.Drawing.Point(267, 211)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(154, 44)
        Me.txt_status.TabIndex = 25
        '
        'txt_nivel
        '
        Me.txt_nivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nivel.FormattingEnabled = True
        Me.txt_nivel.ItemHeight = 20
        Me.txt_nivel.Items.AddRange(New Object() {"I", "II", "III", "IV", "V"})
        Me.txt_nivel.Location = New System.Drawing.Point(72, 211)
        Me.txt_nivel.Name = "txt_nivel"
        Me.txt_nivel.Size = New System.Drawing.Size(154, 104)
        Me.txt_nivel.TabIndex = 24
        '
        'txt_cpf_cad
        '
        Me.txt_cpf_cad.Location = New System.Drawing.Point(72, 83)
        Me.txt_cpf_cad.Mask = "999,999,999-99"
        Me.txt_cpf_cad.Name = "txt_cpf_cad"
        Me.txt_cpf_cad.Size = New System.Drawing.Size(84, 20)
        Me.txt_cpf_cad.TabIndex = 22
        Me.txt_cpf_cad.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'txt_senha_cad
        '
        Me.txt_senha_cad.Location = New System.Drawing.Point(461, 146)
        Me.txt_senha_cad.Name = "txt_senha_cad"
        Me.txt_senha_cad.Size = New System.Drawing.Size(154, 20)
        Me.txt_senha_cad.TabIndex = 8
        '
        'txt_user_cad
        '
        Me.txt_user_cad.Location = New System.Drawing.Point(72, 146)
        Me.txt_user_cad.Name = "txt_user_cad"
        Me.txt_user_cad.Size = New System.Drawing.Size(366, 20)
        Me.txt_user_cad.TabIndex = 7
        '
        'txt_nome_cad
        '
        Me.txt_nome_cad.Location = New System.Drawing.Point(181, 83)
        Me.txt_nome_cad.Name = "txt_nome_cad"
        Me.txt_nome_cad.Size = New System.Drawing.Size(434, 20)
        Me.txt_nome_cad.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(69, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nível"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(458, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(69, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(69, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CPF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(178, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.dgv_funcionarios)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(715, 442)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LISTA DE FUNCIONÁRIOS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_funcionarios
        '
        Me.dgv_funcionarios.AllowUserToAddRows = False
        Me.dgv_funcionarios.AllowUserToDeleteRows = False
        Me.dgv_funcionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_funcionarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_funcionarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column9, Me.Column7, Me.Column8})
        Me.dgv_funcionarios.Location = New System.Drawing.Point(6, 5)
        Me.dgv_funcionarios.Name = "dgv_funcionarios"
        Me.dgv_funcionarios.ReadOnly = True
        Me.dgv_funcionarios.RowHeadersWidth = 51
        Me.dgv_funcionarios.Size = New System.Drawing.Size(720, 321)
        Me.dgv_funcionarios.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "N°"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 44
        '
        'Column2
        '
        Me.Column2.HeaderText = "Usuário"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 68
        '
        'Column3
        '
        Me.Column3.HeaderText = "Senha"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 63
        '
        'Column4
        '
        Me.Column4.HeaderText = "CPF"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 52
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nome"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 60
        '
        'Column6
        '
        Me.Column6.HeaderText = "Função"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 68
        '
        'Column9
        '
        Me.Column9.HeaderText = "Status"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 62
        '
        'Column7
        '
        Me.Column7.HeaderText = "editar"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 39
        '
        'Column8
        '
        Me.Column8.HeaderText = "Excluir"
        Me.Column8.Image = CType(resources.GetObject("Column8.Image"), System.Drawing.Image)
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 44
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravar1, Me.ToolStripLabel1, Me.txt_busca})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(768, 27)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_gravar1
        '
        Me.btn_gravar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar1.Image = CType(resources.GetObject("btn_gravar1.Image"), System.Drawing.Image)
        Me.btn_gravar1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar1.Name = "btn_gravar1"
        Me.btn_gravar1.Size = New System.Drawing.Size(24, 24)
        Me.btn_gravar1.Text = "ToolStripButton1"
        Me.btn_gravar1.ToolTipText = "Gravar dados"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(170, 24)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de busca:"
        '
        'txt_busca
        '
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(100, 27)
        Me.txt_busca.ToolTipText = "Escreva aqui um parâmetro de busca "
        '
        'frm_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(768, 535)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE FUNCIONÁRIOS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_funcionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents txt_user_cad As TextBox
	Friend WithEvents txt_nome_cad As TextBox
	Friend WithEvents txt_senha_cad As TextBox
	Friend WithEvents txt_cpf_cad As MaskedTextBox
	Friend WithEvents txt_nivel As ListBox
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents btn_gravar1 As ToolStripButton
	Friend WithEvents ToolStripLabel1 As ToolStripLabel
	Friend WithEvents txt_busca As ToolStripTextBox
	Friend WithEvents dgv_funcionarios As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_status As ListBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_encerrar As Button
    Friend WithEvents btn_gravar As Button
End Class
