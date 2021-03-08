<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Detalhar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SérieLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim EquipLabel As System.Windows.Forms.Label
        Dim FabricanteLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim AptLabel As System.Windows.Forms.Label
        Dim CondomínioLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detalhar))
        Me.bVoltar = New System.Windows.Forms.Button()
        Me.SérieTextBox = New System.Windows.Forms.TextBox()
        Me.CadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New ClicServ_2._0.DataSet()
        Me.EquipTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.bAddOS = New System.Windows.Forms.Button()
        Me.bRelatórioAtendimento = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bRelatórioOS = New System.Windows.Forms.Button()
        Me.AtendimentoDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefeitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeríodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TécnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observação = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Protocolo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AtendimentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OSDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefeitoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelatórioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TécnicoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservaçãoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FabricanteTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.AptTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.CondomínioTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.CPFTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.bAtualizarOS = New System.Windows.Forms.Button()
        Me.bAtualizarLista = New System.Windows.Forms.Button()
        Me.bAtender = New System.Windows.Forms.Button()
        Me.AtendimentoTableAdapter = New ClicServ_2._0.DataSetTableAdapters.AtendimentoTableAdapter()
        Me.OSTableAdapter = New ClicServ_2._0.DataSetTableAdapters.OSTableAdapter()
        Me.CadastroTableAdapter = New ClicServ_2._0.DataSetTableAdapters.CadastroTableAdapter()
        Me.TableAdapterManager = New ClicServ_2._0.DataSetTableAdapters.TableAdapterManager()
        Me.bRelatórioIndividual = New System.Windows.Forms.Button()
        Me.bAtualizarCliente = New System.Windows.Forms.Button()
        Me.bEditarCliente = New System.Windows.Forms.Button()
        SérieLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        EquipLabel = New System.Windows.Forms.Label()
        FabricanteLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        AptLabel = New System.Windows.Forms.Label()
        CondomínioLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CPFLabel = New System.Windows.Forms.Label()
        EndereçoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.CadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtendimentoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtendimentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SérieLabel
        '
        SérieLabel.AutoSize = True
        SérieLabel.Enabled = False
        SérieLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SérieLabel.Location = New System.Drawing.Point(4, 404)
        SérieLabel.Name = "SérieLabel"
        SérieLabel.Size = New System.Drawing.Size(43, 16)
        SérieLabel.TabIndex = 29
        SérieLabel.Text = "Série:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Enabled = False
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(4, 1)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 16)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Enabled = False
        ModeloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModeloLabel.Location = New System.Drawing.Point(4, 375)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(57, 16)
        ModeloLabel.TabIndex = 27
        ModeloLabel.Text = "Modelo:"
        '
        'EquipLabel
        '
        EquipLabel.AutoSize = True
        EquipLabel.Enabled = False
        EquipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EquipLabel.Location = New System.Drawing.Point(4, 317)
        EquipLabel.Name = "EquipLabel"
        EquipLabel.Size = New System.Drawing.Size(46, 16)
        EquipLabel.TabIndex = 23
        EquipLabel.Text = "Equip:"
        '
        'FabricanteLabel
        '
        FabricanteLabel.AutoSize = True
        FabricanteLabel.Enabled = False
        FabricanteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FabricanteLabel.Location = New System.Drawing.Point(4, 346)
        FabricanteLabel.Name = "FabricanteLabel"
        FabricanteLabel.Size = New System.Drawing.Size(75, 16)
        FabricanteLabel.TabIndex = 25
        FabricanteLabel.Text = "Fabricante:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Enabled = False
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(4, 28)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(48, 16)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Enabled = False
        CelularLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CelularLabel.Location = New System.Drawing.Point(4, 257)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(53, 16)
        CelularLabel.TabIndex = 19
        CelularLabel.Text = "Celular:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Enabled = False
        TelefoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(4, 226)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(65, 16)
        TelefoneLabel.TabIndex = 17
        TelefoneLabel.Text = "Telefone:"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Enabled = False
        ComplementoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComplementoLabel.Location = New System.Drawing.Point(4, 197)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(95, 16)
        ComplementoLabel.TabIndex = 15
        ComplementoLabel.Text = "Complemento:"
        '
        'AptLabel
        '
        AptLabel.AutoSize = True
        AptLabel.Enabled = False
        AptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AptLabel.Location = New System.Drawing.Point(4, 169)
        AptLabel.Name = "AptLabel"
        AptLabel.Size = New System.Drawing.Size(31, 16)
        AptLabel.TabIndex = 13
        AptLabel.Text = "Apt:"
        '
        'CondomínioLabel
        '
        CondomínioLabel.AutoSize = True
        CondomínioLabel.Enabled = False
        CondomínioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CondomínioLabel.Location = New System.Drawing.Point(4, 139)
        CondomínioLabel.Name = "CondomínioLabel"
        CondomínioLabel.Size = New System.Drawing.Size(83, 16)
        CondomínioLabel.TabIndex = 11
        CondomínioLabel.Text = "Condomínio:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Enabled = False
        BairroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BairroLabel.Location = New System.Drawing.Point(4, 110)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(47, 16)
        BairroLabel.TabIndex = 9
        BairroLabel.Text = "Bairro:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Enabled = False
        CPFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPFLabel.Location = New System.Drawing.Point(4, 55)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(37, 16)
        CPFLabel.TabIndex = 5
        CPFLabel.Text = "CPF:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Enabled = False
        EndereçoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndereçoLabel.Location = New System.Drawing.Point(4, 82)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(70, 16)
        EndereçoLabel.TabIndex = 7
        EndereçoLabel.Text = "Endereço:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Enabled = False
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(4, 287)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 16)
        EmailLabel.TabIndex = 21
        EmailLabel.Text = "Email:"
        '
        'bVoltar
        '
        Me.bVoltar.BackColor = System.Drawing.Color.Transparent
        Me.bVoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bVoltar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bVoltar.FlatAppearance.BorderSize = 0
        Me.bVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bVoltar.Image = Global.ClicServ_2._0.My.Resources.Resources.voltar
        Me.bVoltar.Location = New System.Drawing.Point(475, 2)
        Me.bVoltar.Name = "bVoltar"
        Me.bVoltar.Size = New System.Drawing.Size(93, 88)
        Me.bVoltar.TabIndex = 85
        Me.bVoltar.Text = "Voltar"
        Me.bVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bVoltar.UseVisualStyleBackColor = False
        '
        'SérieTextBox
        '
        Me.SérieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Série", True))
        Me.SérieTextBox.Enabled = False
        Me.SérieTextBox.Location = New System.Drawing.Point(106, 407)
        Me.SérieTextBox.Name = "SérieTextBox"
        Me.SérieTextBox.Size = New System.Drawing.Size(136, 20)
        Me.SérieTextBox.TabIndex = 30
        '
        'CadastroBindingSource
        '
        Me.CadastroBindingSource.DataMember = "Cadastro"
        Me.CadastroBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquipTextBox
        '
        Me.EquipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Equip", True))
        Me.EquipTextBox.Enabled = False
        Me.EquipTextBox.Location = New System.Drawing.Point(106, 320)
        Me.EquipTextBox.Name = "EquipTextBox"
        Me.EquipTextBox.Size = New System.Drawing.Size(136, 20)
        Me.EquipTextBox.TabIndex = 24
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Modelo", True))
        Me.ModeloTextBox.Enabled = False
        Me.ModeloTextBox.Location = New System.Drawing.Point(106, 378)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(113, 20)
        Me.ModeloTextBox.TabIndex = 28
        '
        'bAddOS
        '
        Me.bAddOS.BackColor = System.Drawing.Color.Transparent
        Me.bAddOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAddOS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAddOS.FlatAppearance.BorderSize = 0
        Me.bAddOS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAddOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAddOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAddOS.Image = Global.ClicServ_2._0.My.Resources.Resources.add_os
        Me.bAddOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bAddOS.Location = New System.Drawing.Point(1132, 356)
        Me.bAddOS.Name = "bAddOS"
        Me.bAddOS.Size = New System.Drawing.Size(98, 88)
        Me.bAddOS.TabIndex = 83
        Me.bAddOS.Text = "Adicionar"
        Me.bAddOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bAddOS.UseVisualStyleBackColor = False
        '
        'bRelatórioAtendimento
        '
        Me.bRelatórioAtendimento.BackColor = System.Drawing.Color.Transparent
        Me.bRelatórioAtendimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bRelatórioAtendimento.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bRelatórioAtendimento.FlatAppearance.BorderSize = 0
        Me.bRelatórioAtendimento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bRelatórioAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRelatórioAtendimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRelatórioAtendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bRelatórioAtendimento.Image = Global.ClicServ_2._0.My.Resources.Resources.relatório
        Me.bRelatórioAtendimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bRelatórioAtendimento.Location = New System.Drawing.Point(1033, 2)
        Me.bRelatórioAtendimento.Name = "bRelatórioAtendimento"
        Me.bRelatórioAtendimento.Size = New System.Drawing.Size(93, 88)
        Me.bRelatórioAtendimento.TabIndex = 80
        Me.bRelatórioAtendimento.Text = "Relatório Atendimento"
        Me.bRelatórioAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bRelatórioAtendimento.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox3.Location = New System.Drawing.Point(10, 21)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(451, 47)
        Me.TextBox3.TabIndex = 79
        Me.TextBox3.Text = "I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "n" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "f" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ç" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ã" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o do cliente"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox2.Location = New System.Drawing.Point(586, 377)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(441, 47)
        Me.TextBox2.TabIndex = 78
        Me.TextBox2.Text = "Ordem de serviço"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(586, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(345, 47)
        Me.TextBox1.TabIndex = 77
        Me.TextBox1.Text = "Atendimento"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bRelatórioOS
        '
        Me.bRelatórioOS.BackColor = System.Drawing.Color.Transparent
        Me.bRelatórioOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bRelatórioOS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bRelatórioOS.FlatAppearance.BorderSize = 0
        Me.bRelatórioOS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bRelatórioOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRelatórioOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRelatórioOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bRelatórioOS.Image = Global.ClicServ_2._0.My.Resources.Resources.relatório
        Me.bRelatórioOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bRelatórioOS.Location = New System.Drawing.Point(1033, 354)
        Me.bRelatórioOS.Name = "bRelatórioOS"
        Me.bRelatórioOS.Size = New System.Drawing.Size(93, 88)
        Me.bRelatórioOS.TabIndex = 76
        Me.bRelatórioOS.Text = "Relatório OS"
        Me.bRelatórioOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bRelatórioOS.UseVisualStyleBackColor = False
        '
        'AtendimentoDataGridView
        '
        Me.AtendimentoDataGridView.AllowUserToAddRows = False
        Me.AtendimentoDataGridView.AllowUserToDeleteRows = False
        Me.AtendimentoDataGridView.AutoGenerateColumns = False
        Me.AtendimentoDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.AtendimentoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AtendimentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AtendimentoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DefeitoDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.PeríodoDataGridViewTextBoxColumn, Me.TécnicoDataGridViewTextBoxColumn, Me.Observação, Me.Protocolo})
        Me.AtendimentoDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AtendimentoDataGridView.DataSource = Me.AtendimentoBindingSource
        Me.AtendimentoDataGridView.EnableHeadersVisualStyles = False
        Me.AtendimentoDataGridView.GridColor = System.Drawing.SystemColors.Highlight
        Me.AtendimentoDataGridView.Location = New System.Drawing.Point(586, 96)
        Me.AtendimentoDataGridView.Name = "AtendimentoDataGridView"
        Me.AtendimentoDataGridView.ReadOnly = True
        Me.AtendimentoDataGridView.Size = New System.Drawing.Size(720, 252)
        Me.AtendimentoDataGridView.TabIndex = 73
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DefeitoDataGridViewTextBoxColumn
        '
        Me.DefeitoDataGridViewTextBoxColumn.DataPropertyName = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn.HeaderText = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn.Name = "DefeitoDataGridViewTextBoxColumn"
        Me.DefeitoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeríodoDataGridViewTextBoxColumn
        '
        Me.PeríodoDataGridViewTextBoxColumn.DataPropertyName = "Período"
        Me.PeríodoDataGridViewTextBoxColumn.HeaderText = "Período"
        Me.PeríodoDataGridViewTextBoxColumn.Name = "PeríodoDataGridViewTextBoxColumn"
        Me.PeríodoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TécnicoDataGridViewTextBoxColumn
        '
        Me.TécnicoDataGridViewTextBoxColumn.DataPropertyName = "Técnico"
        Me.TécnicoDataGridViewTextBoxColumn.HeaderText = "Técnico"
        Me.TécnicoDataGridViewTextBoxColumn.Name = "TécnicoDataGridViewTextBoxColumn"
        Me.TécnicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Observação
        '
        Me.Observação.DataPropertyName = "Observação"
        Me.Observação.HeaderText = "Observação"
        Me.Observação.Name = "Observação"
        Me.Observação.ReadOnly = True
        '
        'Protocolo
        '
        Me.Protocolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Protocolo.DataPropertyName = "Protocolo"
        Me.Protocolo.HeaderText = "Protocolo"
        Me.Protocolo.Name = "Protocolo"
        Me.Protocolo.ReadOnly = True
        Me.Protocolo.Width = 77
        '
        'AtendimentoBindingSource
        '
        Me.AtendimentoBindingSource.DataMember = "Atendimento"
        Me.AtendimentoBindingSource.DataSource = Me.DataSet
        '
        'OSDataGridView
        '
        Me.OSDataGridView.AllowUserToAddRows = False
        Me.OSDataGridView.AllowUserToDeleteRows = False
        Me.OSDataGridView.AutoGenerateColumns = False
        Me.OSDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.OSDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.OSDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn1, Me.ValorDataGridViewTextBoxColumn, Me.DefeitoDataGridViewTextBoxColumn1, Me.RelatórioDataGridViewTextBoxColumn, Me.TécnicoDataGridViewTextBoxColumn1, Me.ObservaçãoDataGridViewTextBoxColumn1})
        Me.OSDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OSDataGridView.DataSource = Me.OSBindingSource
        Me.OSDataGridView.EnableHeadersVisualStyles = False
        Me.OSDataGridView.GridColor = System.Drawing.SystemColors.Highlight
        Me.OSDataGridView.Location = New System.Drawing.Point(586, 448)
        Me.OSDataGridView.Name = "OSDataGridView"
        Me.OSDataGridView.ReadOnly = True
        Me.OSDataGridView.Size = New System.Drawing.Size(734, 255)
        Me.OSDataGridView.TabIndex = 74
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDDataGridViewTextBoxColumn1.Width = 43
        '
        'OSDataGridViewTextBoxColumn
        '
        Me.OSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.OSDataGridViewTextBoxColumn.DataPropertyName = "OS"
        Me.OSDataGridViewTextBoxColumn.HeaderText = "OS"
        Me.OSDataGridViewTextBoxColumn.Name = "OSDataGridViewTextBoxColumn"
        Me.OSDataGridViewTextBoxColumn.ReadOnly = True
        Me.OSDataGridViewTextBoxColumn.Width = 47
        '
        'DataDataGridViewTextBoxColumn1
        '
        Me.DataDataGridViewTextBoxColumn1.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn1.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn1.Name = "DataDataGridViewTextBoxColumn1"
        Me.DataDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DefeitoDataGridViewTextBoxColumn1
        '
        Me.DefeitoDataGridViewTextBoxColumn1.DataPropertyName = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn1.HeaderText = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn1.Name = "DefeitoDataGridViewTextBoxColumn1"
        Me.DefeitoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'RelatórioDataGridViewTextBoxColumn
        '
        Me.RelatórioDataGridViewTextBoxColumn.DataPropertyName = "Relatório"
        Me.RelatórioDataGridViewTextBoxColumn.HeaderText = "Relatório"
        Me.RelatórioDataGridViewTextBoxColumn.Name = "RelatórioDataGridViewTextBoxColumn"
        Me.RelatórioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TécnicoDataGridViewTextBoxColumn1
        '
        Me.TécnicoDataGridViewTextBoxColumn1.DataPropertyName = "Técnico"
        Me.TécnicoDataGridViewTextBoxColumn1.HeaderText = "Técnico"
        Me.TécnicoDataGridViewTextBoxColumn1.Name = "TécnicoDataGridViewTextBoxColumn1"
        Me.TécnicoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ObservaçãoDataGridViewTextBoxColumn1
        '
        Me.ObservaçãoDataGridViewTextBoxColumn1.DataPropertyName = "Observação"
        Me.ObservaçãoDataGridViewTextBoxColumn1.HeaderText = "Observação"
        Me.ObservaçãoDataGridViewTextBoxColumn1.Name = "ObservaçãoDataGridViewTextBoxColumn1"
        Me.ObservaçãoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'OSBindingSource
        '
        Me.OSBindingSource.DataMember = "OS"
        Me.OSBindingSource.DataSource = Me.DataSet
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.SérieTextBox, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.EquipTextBox, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(SérieLabel, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.ModeloTextBox, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FabricanteTextBox, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(ModeloLabel, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(EquipLabel, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(FabricanteLabel, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(NomeLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(CelularLabel, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(TelefoneLabel, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.CelularTextBox, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(ComplementoLabel, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TelefoneTextBox, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.AptTextBox, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ComplementoTextBox, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(AptLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CondomínioTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(CondomínioLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.BairroTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(BairroLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CPFTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(CPFLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NomeTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(EndereçoLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.EndereçoTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(EmailLabel, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailTextBox, 1, 10)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 96)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 15
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(558, 433)
        Me.TableLayoutPanel1.TabIndex = 75
        '
        'FabricanteTextBox
        '
        Me.FabricanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Fabricante", True))
        Me.FabricanteTextBox.Enabled = False
        Me.FabricanteTextBox.Location = New System.Drawing.Point(106, 349)
        Me.FabricanteTextBox.Name = "FabricanteTextBox"
        Me.FabricanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FabricanteTextBox.TabIndex = 26
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(106, 4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(45, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Celular", True))
        Me.CelularTextBox.Enabled = False
        Me.CelularTextBox.Location = New System.Drawing.Point(106, 260)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CelularTextBox.TabIndex = 20
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Telefone", True))
        Me.TelefoneTextBox.Enabled = False
        Me.TelefoneTextBox.Location = New System.Drawing.Point(106, 229)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneTextBox.TabIndex = 18
        '
        'AptTextBox
        '
        Me.AptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Apt", True))
        Me.AptTextBox.Enabled = False
        Me.AptTextBox.Location = New System.Drawing.Point(106, 172)
        Me.AptTextBox.Name = "AptTextBox"
        Me.AptTextBox.Size = New System.Drawing.Size(45, 20)
        Me.AptTextBox.TabIndex = 14
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Enabled = False
        Me.ComplementoTextBox.Location = New System.Drawing.Point(106, 200)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(254, 20)
        Me.ComplementoTextBox.TabIndex = 16
        '
        'CondomínioTextBox
        '
        Me.CondomínioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Condomínio", True))
        Me.CondomínioTextBox.Enabled = False
        Me.CondomínioTextBox.Location = New System.Drawing.Point(106, 142)
        Me.CondomínioTextBox.Name = "CondomínioTextBox"
        Me.CondomínioTextBox.Size = New System.Drawing.Size(254, 20)
        Me.CondomínioTextBox.TabIndex = 12
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Bairro", True))
        Me.BairroTextBox.Enabled = False
        Me.BairroTextBox.Location = New System.Drawing.Point(106, 113)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(142, 20)
        Me.BairroTextBox.TabIndex = 10
        '
        'CPFTextBox
        '
        Me.CPFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "CPF", True))
        Me.CPFTextBox.Enabled = False
        Me.CPFTextBox.Location = New System.Drawing.Point(106, 58)
        Me.CPFTextBox.Name = "CPFTextBox"
        Me.CPFTextBox.Size = New System.Drawing.Size(88, 20)
        Me.CPFTextBox.TabIndex = 6
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(106, 31)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(254, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Enabled = False
        Me.EndereçoTextBox.Location = New System.Drawing.Point(106, 85)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(441, 20)
        Me.EndereçoTextBox.TabIndex = 8
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(106, 290)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(171, 20)
        Me.EmailTextBox.TabIndex = 22
        '
        'bAtualizarOS
        '
        Me.bAtualizarOS.BackColor = System.Drawing.Color.Transparent
        Me.bAtualizarOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAtualizarOS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAtualizarOS.FlatAppearance.BorderSize = 0
        Me.bAtualizarOS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAtualizarOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAtualizarOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAtualizarOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAtualizarOS.Image = CType(resources.GetObject("bAtualizarOS.Image"), System.Drawing.Image)
        Me.bAtualizarOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bAtualizarOS.Location = New System.Drawing.Point(1236, 353)
        Me.bAtualizarOS.Name = "bAtualizarOS"
        Me.bAtualizarOS.Size = New System.Drawing.Size(98, 88)
        Me.bAtualizarOS.TabIndex = 84
        Me.bAtualizarOS.Text = "Atualizar Lista"
        Me.bAtualizarOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bAtualizarOS.UseVisualStyleBackColor = False
        '
        'bAtualizarLista
        '
        Me.bAtualizarLista.BackColor = System.Drawing.Color.Transparent
        Me.bAtualizarLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAtualizarLista.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAtualizarLista.FlatAppearance.BorderSize = 0
        Me.bAtualizarLista.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAtualizarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAtualizarLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAtualizarLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAtualizarLista.Image = CType(resources.GetObject("bAtualizarLista.Image"), System.Drawing.Image)
        Me.bAtualizarLista.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bAtualizarLista.Location = New System.Drawing.Point(1222, 2)
        Me.bAtualizarLista.Name = "bAtualizarLista"
        Me.bAtualizarLista.Size = New System.Drawing.Size(98, 88)
        Me.bAtualizarLista.TabIndex = 82
        Me.bAtualizarLista.Text = "Atualizar Lista"
        Me.bAtualizarLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bAtualizarLista.UseVisualStyleBackColor = False
        '
        'bAtender
        '
        Me.bAtender.BackColor = System.Drawing.Color.Transparent
        Me.bAtender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAtender.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAtender.FlatAppearance.BorderSize = 0
        Me.bAtender.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAtender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAtender.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAtender.Image = CType(resources.GetObject("bAtender.Image"), System.Drawing.Image)
        Me.bAtender.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bAtender.Location = New System.Drawing.Point(1132, 2)
        Me.bAtender.Name = "bAtender"
        Me.bAtender.Size = New System.Drawing.Size(93, 88)
        Me.bAtender.TabIndex = 81
        Me.bAtender.Text = "Atender"
        Me.bAtender.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bAtender.UseVisualStyleBackColor = False
        '
        'AtendimentoTableAdapter
        '
        Me.AtendimentoTableAdapter.ClearBeforeFill = True
        '
        'OSTableAdapter
        '
        Me.OSTableAdapter.ClearBeforeFill = True
        '
        'CadastroTableAdapter
        '
        Me.CadastroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AtendimentoTableAdapter = Me.AtendimentoTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CadastroTableAdapter = Me.CadastroTableAdapter
        Me.TableAdapterManager.OSTableAdapter = Me.OSTableAdapter
        Me.TableAdapterManager.UpdateOrder = ClicServ_2._0.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'bRelatórioIndividual
        '
        Me.bRelatórioIndividual.BackColor = System.Drawing.Color.Transparent
        Me.bRelatórioIndividual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bRelatórioIndividual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bRelatórioIndividual.FlatAppearance.BorderSize = 0
        Me.bRelatórioIndividual.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bRelatórioIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRelatórioIndividual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRelatórioIndividual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bRelatórioIndividual.Image = Global.ClicServ_2._0.My.Resources.Resources.relatório
        Me.bRelatórioIndividual.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bRelatórioIndividual.Location = New System.Drawing.Point(937, 2)
        Me.bRelatórioIndividual.Name = "bRelatórioIndividual"
        Me.bRelatórioIndividual.Size = New System.Drawing.Size(90, 88)
        Me.bRelatórioIndividual.TabIndex = 87
        Me.bRelatórioIndividual.Text = "Relatório Protocolo"
        Me.bRelatórioIndividual.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bRelatórioIndividual.UseVisualStyleBackColor = False
        '
        'bAtualizarCliente
        '
        Me.bAtualizarCliente.BackColor = System.Drawing.Color.Transparent
        Me.bAtualizarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAtualizarCliente.FlatAppearance.BorderSize = 0
        Me.bAtualizarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAtualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAtualizarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAtualizarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAtualizarCliente.Image = CType(resources.GetObject("bAtualizarCliente.Image"), System.Drawing.Image)
        Me.bAtualizarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bAtualizarCliente.Location = New System.Drawing.Point(109, 535)
        Me.bAtualizarCliente.Name = "bAtualizarCliente"
        Me.bAtualizarCliente.Size = New System.Drawing.Size(93, 81)
        Me.bAtualizarCliente.TabIndex = 89
        Me.bAtualizarCliente.Text = "Atualizar"
        Me.bAtualizarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bAtualizarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bAtualizarCliente.UseVisualStyleBackColor = False
        '
        'bEditarCliente
        '
        Me.bEditarCliente.BackColor = System.Drawing.Color.Transparent
        Me.bEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEditarCliente.FlatAppearance.BorderSize = 0
        Me.bEditarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEditarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEditarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bEditarCliente.Image = CType(resources.GetObject("bEditarCliente.Image"), System.Drawing.Image)
        Me.bEditarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bEditarCliente.Location = New System.Drawing.Point(10, 535)
        Me.bEditarCliente.Name = "bEditarCliente"
        Me.bEditarCliente.Size = New System.Drawing.Size(93, 81)
        Me.bEditarCliente.TabIndex = 88
        Me.bEditarCliente.Text = "Editar"
        Me.bEditarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bEditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bEditarCliente.UseVisualStyleBackColor = False
        '
        'Detalhar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.ClicServ_2._0.My.Resources.Resources.Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 691)
        Me.Controls.Add(Me.bAtualizarCliente)
        Me.Controls.Add(Me.bEditarCliente)
        Me.Controls.Add(Me.bRelatórioIndividual)
        Me.Controls.Add(Me.bVoltar)
        Me.Controls.Add(Me.bAtualizarOS)
        Me.Controls.Add(Me.bAddOS)
        Me.Controls.Add(Me.bAtualizarLista)
        Me.Controls.Add(Me.bAtender)
        Me.Controls.Add(Me.bRelatórioAtendimento)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bRelatórioOS)
        Me.Controls.Add(Me.AtendimentoDataGridView)
        Me.Controls.Add(Me.OSDataGridView)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Detalhar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.CadastroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtendimentoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtendimentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bVoltar As Button
    Friend WithEvents SérieTextBox As TextBox
    Friend WithEvents EquipTextBox As TextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents bAtualizarOS As Button
    Friend WithEvents bAddOS As Button
    Friend WithEvents bAtualizarLista As Button
    Friend WithEvents bAtender As Button
    Friend WithEvents bRelatórioAtendimento As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents bRelatórioOS As Button
    Friend WithEvents AtendimentoDataGridView As DataGridView
    Friend WithEvents OSDataGridView As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FabricanteTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents CelularTextBox As TextBox
    Friend WithEvents TelefoneTextBox As TextBox
    Friend WithEvents AptTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents CondomínioTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents CPFTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents EndereçoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DataSet As DataSet
    Friend WithEvents AtendimentoBindingSource As BindingSource
    Friend WithEvents AtendimentoTableAdapter As DataSetTableAdapters.AtendimentoTableAdapter
    Friend WithEvents SituaçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OSBindingSource As BindingSource
    Friend WithEvents OSTableAdapter As DataSetTableAdapters.OSTableAdapter
    Friend WithEvents RevisãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CadastroBindingSource As BindingSource
    Friend WithEvents CadastroTableAdapter As DataSetTableAdapters.CadastroTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Private WithEvents bRelatórioIndividual As Button
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DefeitoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RelatórioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TécnicoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ObservaçãoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DefeitoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeríodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TécnicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Observação As DataGridViewTextBoxColumn
    Friend WithEvents Protocolo As DataGridViewTextBoxColumn
    Friend WithEvents bAtualizarCliente As Button
    Friend WithEvents bEditarCliente As Button
End Class
