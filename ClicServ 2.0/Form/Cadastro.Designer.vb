<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cadastro
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
        Dim EquipLabel As System.Windows.Forms.Label
        Dim FabricanteLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim Nº_sérieLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim CondomínioLabel As System.Windows.Forms.Label
        Dim AptLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro))
        Me.CPFTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New ClicServ_2._0.DataSet()
        Me.TelefoneTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CelularTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.bAtualizarCliente = New System.Windows.Forms.Button()
        Me.bExcluirCliente = New System.Windows.Forms.Button()
        Me.bEditarCliente = New System.Windows.Forms.Button()
        Me.bSalvarCliente = New System.Windows.Forms.Button()
        Me.bNovoCliente = New System.Windows.Forms.Button()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.EquipTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbNomeCondominio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.FabricanteTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.Nº_sérieTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox()
        Me.CondomínioTextBox = New System.Windows.Forms.TextBox()
        Me.AptTextBox = New System.Windows.Forms.TextBox()
        Me.bPesquisar = New System.Windows.Forms.Button()
        Me.dgvListaCliente = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndereçoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BairroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CondomínioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComplementoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FabricanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SérieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.bVoltar = New System.Windows.Forms.Button()
        Me.CadastroTableAdapter = New ClicServ_2._0.DataSetTableAdapters.CadastroTableAdapter()
        EquipLabel = New System.Windows.Forms.Label()
        FabricanteLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        Nº_sérieLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        ComplementoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CPFLabel = New System.Windows.Forms.Label()
        EndereçoLabel = New System.Windows.Forms.Label()
        CondomínioLabel = New System.Windows.Forms.Label()
        AptLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        CType(Me.CadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvListaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'EquipLabel
        '
        EquipLabel.AutoSize = True
        EquipLabel.BackColor = System.Drawing.Color.Transparent
        EquipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EquipLabel.ForeColor = System.Drawing.Color.White
        EquipLabel.Location = New System.Drawing.Point(4, 1)
        EquipLabel.Name = "EquipLabel"
        EquipLabel.Size = New System.Drawing.Size(46, 16)
        EquipLabel.TabIndex = 21
        EquipLabel.Text = "Equip:"
        '
        'FabricanteLabel
        '
        FabricanteLabel.AutoSize = True
        FabricanteLabel.BackColor = System.Drawing.Color.Transparent
        FabricanteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FabricanteLabel.ForeColor = System.Drawing.Color.White
        FabricanteLabel.Location = New System.Drawing.Point(4, 30)
        FabricanteLabel.Name = "FabricanteLabel"
        FabricanteLabel.Size = New System.Drawing.Size(75, 16)
        FabricanteLabel.TabIndex = 23
        FabricanteLabel.Text = "Fabricante:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.BackColor = System.Drawing.Color.Transparent
        ModeloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModeloLabel.ForeColor = System.Drawing.Color.White
        ModeloLabel.Location = New System.Drawing.Point(4, 59)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(57, 16)
        ModeloLabel.TabIndex = 25
        ModeloLabel.Text = "Modelo:"
        '
        'Nº_sérieLabel
        '
        Nº_sérieLabel.AutoSize = True
        Nº_sérieLabel.BackColor = System.Drawing.Color.Transparent
        Nº_sérieLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nº_sérieLabel.ForeColor = System.Drawing.Color.White
        Nº_sérieLabel.Location = New System.Drawing.Point(4, 88)
        Nº_sérieLabel.Name = "Nº_sérieLabel"
        Nº_sérieLabel.Size = New System.Drawing.Size(59, 16)
        Nº_sérieLabel.TabIndex = 27
        Nº_sérieLabel.Text = "Nº série:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        EmailLabel.Location = New System.Drawing.Point(4, 291)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 16)
        EmailLabel.TabIndex = 51
        EmailLabel.Text = "Email:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.Transparent
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.Color.White
        IDLabel.Location = New System.Drawing.Point(4, 1)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 16)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.BackColor = System.Drawing.Color.Transparent
        ComplementoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComplementoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ComplementoLabel.Location = New System.Drawing.Point(4, 146)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(95, 16)
        ComplementoLabel.TabIndex = 49
        ComplementoLabel.Text = "Complemento:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.BackColor = System.Drawing.Color.Transparent
        BairroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BairroLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        BairroLabel.Location = New System.Drawing.Point(4, 117)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(47, 16)
        BairroLabel.TabIndex = 50
        BairroLabel.Text = "Bairro:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.BackColor = System.Drawing.Color.Transparent
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.ForeColor = System.Drawing.Color.White
        NomeLabel.Location = New System.Drawing.Point(4, 30)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(48, 16)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.BackColor = System.Drawing.Color.Transparent
        CPFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPFLabel.ForeColor = System.Drawing.Color.White
        CPFLabel.Location = New System.Drawing.Point(4, 59)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(37, 16)
        CPFLabel.TabIndex = 5
        CPFLabel.Text = "CPF:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.BackColor = System.Drawing.Color.Transparent
        EndereçoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndereçoLabel.ForeColor = System.Drawing.Color.White
        EndereçoLabel.Location = New System.Drawing.Point(4, 88)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(70, 16)
        EndereçoLabel.TabIndex = 7
        EndereçoLabel.Text = "Endereço:"
        '
        'CondomínioLabel
        '
        CondomínioLabel.AutoSize = True
        CondomínioLabel.BackColor = System.Drawing.Color.Transparent
        CondomínioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CondomínioLabel.ForeColor = System.Drawing.Color.White
        CondomínioLabel.Location = New System.Drawing.Point(4, 175)
        CondomínioLabel.Name = "CondomínioLabel"
        CondomínioLabel.Size = New System.Drawing.Size(83, 16)
        CondomínioLabel.TabIndex = 11
        CondomínioLabel.Text = "Condomínio:"
        '
        'AptLabel
        '
        AptLabel.AutoSize = True
        AptLabel.BackColor = System.Drawing.Color.Transparent
        AptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AptLabel.ForeColor = System.Drawing.Color.White
        AptLabel.Location = New System.Drawing.Point(4, 204)
        AptLabel.Name = "AptLabel"
        AptLabel.Size = New System.Drawing.Size(31, 16)
        AptLabel.TabIndex = 13
        AptLabel.Text = "Apt:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.BackColor = System.Drawing.Color.Transparent
        TelefoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.ForeColor = System.Drawing.Color.White
        TelefoneLabel.Location = New System.Drawing.Point(4, 233)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(65, 16)
        TelefoneLabel.TabIndex = 17
        TelefoneLabel.Text = "Telefone:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.BackColor = System.Drawing.Color.Transparent
        CelularLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CelularLabel.ForeColor = System.Drawing.Color.White
        CelularLabel.Location = New System.Drawing.Point(4, 262)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(53, 16)
        CelularLabel.TabIndex = 19
        CelularLabel.Text = "Celular:"
        '
        'CPFTextBox
        '
        Me.CPFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "CPF", True))
        Me.CPFTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPFTextBox.Location = New System.Drawing.Point(106, 62)
        Me.CPFTextBox.Mask = "000,000,000-00"
        Me.CPFTextBox.Name = "CPFTextBox"
        Me.CPFTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CPFTextBox.TabIndex = 3
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
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Telefone", True))
        Me.TelefoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TelefoneTextBox.Location = New System.Drawing.Point(106, 236)
        Me.TelefoneTextBox.Mask = "(99) 0 0000-0000"
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(110, 22)
        Me.TelefoneTextBox.TabIndex = 9
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Celular", True))
        Me.CelularTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CelularTextBox.Location = New System.Drawing.Point(106, 265)
        Me.CelularTextBox.Mask = "(99) 0 0000-0000"
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(110, 22)
        Me.CelularTextBox.TabIndex = 10
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
        Me.bAtualizarCliente.Location = New System.Drawing.Point(399, 280)
        Me.bAtualizarCliente.Name = "bAtualizarCliente"
        Me.bAtualizarCliente.Size = New System.Drawing.Size(93, 81)
        Me.bAtualizarCliente.TabIndex = 63
        Me.bAtualizarCliente.Text = "Atualizar"
        Me.bAtualizarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bAtualizarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bAtualizarCliente.UseVisualStyleBackColor = False
        '
        'bExcluirCliente
        '
        Me.bExcluirCliente.BackColor = System.Drawing.Color.Transparent
        Me.bExcluirCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bExcluirCliente.FlatAppearance.BorderSize = 0
        Me.bExcluirCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExcluirCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExcluirCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bExcluirCliente.Image = CType(resources.GetObject("bExcluirCliente.Image"), System.Drawing.Image)
        Me.bExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bExcluirCliente.Location = New System.Drawing.Point(507, 280)
        Me.bExcluirCliente.Name = "bExcluirCliente"
        Me.bExcluirCliente.Size = New System.Drawing.Size(93, 81)
        Me.bExcluirCliente.TabIndex = 62
        Me.bExcluirCliente.Text = "Excluir"
        Me.bExcluirCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bExcluirCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bExcluirCliente.UseVisualStyleBackColor = False
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
        Me.bEditarCliente.Location = New System.Drawing.Point(498, 193)
        Me.bEditarCliente.Name = "bEditarCliente"
        Me.bEditarCliente.Size = New System.Drawing.Size(93, 81)
        Me.bEditarCliente.TabIndex = 61
        Me.bEditarCliente.Text = "Editar"
        Me.bEditarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bEditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bEditarCliente.UseVisualStyleBackColor = False
        '
        'bSalvarCliente
        '
        Me.bSalvarCliente.BackColor = System.Drawing.Color.Transparent
        Me.bSalvarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSalvarCliente.FlatAppearance.BorderSize = 0
        Me.bSalvarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bSalvarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalvarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalvarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bSalvarCliente.Image = CType(resources.GetObject("bSalvarCliente.Image"), System.Drawing.Image)
        Me.bSalvarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bSalvarCliente.Location = New System.Drawing.Point(597, 193)
        Me.bSalvarCliente.Name = "bSalvarCliente"
        Me.bSalvarCliente.Size = New System.Drawing.Size(93, 81)
        Me.bSalvarCliente.TabIndex = 60
        Me.bSalvarCliente.Text = "Salvar"
        Me.bSalvarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bSalvarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bSalvarCliente.UseVisualStyleBackColor = False
        '
        'bNovoCliente
        '
        Me.bNovoCliente.BackColor = System.Drawing.Color.Transparent
        Me.bNovoCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bNovoCliente.FlatAppearance.BorderSize = 0
        Me.bNovoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNovoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNovoCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bNovoCliente.Image = CType(resources.GetObject("bNovoCliente.Image"), System.Drawing.Image)
        Me.bNovoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bNovoCliente.Location = New System.Drawing.Point(392, 193)
        Me.bNovoCliente.Name = "bNovoCliente"
        Me.bNovoCliente.Size = New System.Drawing.Size(93, 81)
        Me.bNovoCliente.TabIndex = 58
        Me.bNovoCliente.Text = "Novo"
        Me.bNovoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bNovoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bNovoCliente.UseVisualStyleBackColor = False
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCliente.Location = New System.Drawing.Point(566, 6)
        Me.txtBuscarCliente.Multiline = True
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(111, 20)
        Me.txtBuscarCliente.TabIndex = 16
        '
        'EquipTextBox
        '
        Me.EquipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Equip", True))
        Me.EquipTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.EquipTextBox.Location = New System.Drawing.Point(86, 4)
        Me.EquipTextBox.Name = "EquipTextBox"
        Me.EquipTextBox.Size = New System.Drawing.Size(122, 22)
        Me.EquipTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(399, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Pesquisar cliente:"
        '
        'cbNomeCondominio
        '
        Me.cbNomeCondominio.FormattingEnabled = True
        Me.cbNomeCondominio.Items.AddRange(New Object() {"Nome", "Condomínio"})
        Me.cbNomeCondominio.Location = New System.Drawing.Point(293, 6)
        Me.cbNomeCondominio.Name = "cbNomeCondominio"
        Me.cbNomeCondominio.Size = New System.Drawing.Size(97, 21)
        Me.cbNomeCondominio.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 24)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Selecione o modo de pesquisa:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.EmailTextBox.Location = New System.Drawing.Point(106, 294)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(171, 22)
        Me.EmailTextBox.TabIndex = 11
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ComplementoTextBox.Location = New System.Drawing.Point(106, 149)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ComplementoTextBox.TabIndex = 6
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Bairro", True))
        Me.BairroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.BairroTextBox.Location = New System.Drawing.Point(106, 120)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BairroTextBox.TabIndex = 5
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(EquipLabel, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.EquipTextBox, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(FabricanteLabel, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.FabricanteTextBox, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(ModeloLabel, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.ModeloTextBox, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Nº_sérieLabel, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Nº_sérieTextBox, 1, 3)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(434, 68)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(217, 119)
        Me.TableLayoutPanel3.TabIndex = 66
        '
        'FabricanteTextBox
        '
        Me.FabricanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Fabricante", True))
        Me.FabricanteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.FabricanteTextBox.Location = New System.Drawing.Point(86, 33)
        Me.FabricanteTextBox.Name = "FabricanteTextBox"
        Me.FabricanteTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FabricanteTextBox.TabIndex = 13
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Modelo", True))
        Me.ModeloTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ModeloTextBox.Location = New System.Drawing.Point(86, 62)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ModeloTextBox.TabIndex = 14
        '
        'Nº_sérieTextBox
        '
        Me.Nº_sérieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Série", True))
        Me.Nº_sérieTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Nº_sérieTextBox.Location = New System.Drawing.Point(86, 91)
        Me.Nº_sérieTextBox.Name = "Nº_sérieTextBox"
        Me.Nº_sérieTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Nº_sérieTextBox.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(760, 47)
        Me.TextBox1.TabIndex = 45
        Me.TextBox1.Text = "Cadastrar dados do cliente e equipamento"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(EmailLabel, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailTextBox, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.NomeTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(ComplementoLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(BairroLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ComplementoTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(NomeLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BairroTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CPFTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(CPFLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.EndereçoTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(EndereçoLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CondomínioTextBox, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(CondomínioLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.AptTextBox, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(AptLabel, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TelefoneTextBox, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(TelefoneLabel, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.CelularTextBox, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(CelularLabel, 0, 9)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 68)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(377, 324)
        Me.TableLayoutPanel1.TabIndex = 64
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(106, 4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(47, 22)
        Me.IDTextBox.TabIndex = 1
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(106, 33)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(171, 22)
        Me.NomeTextBox.TabIndex = 2
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(106, 91)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(261, 22)
        Me.EndereçoTextBox.TabIndex = 4
        '
        'CondomínioTextBox
        '
        Me.CondomínioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Condomínio", True))
        Me.CondomínioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CondomínioTextBox.Location = New System.Drawing.Point(106, 178)
        Me.CondomínioTextBox.Name = "CondomínioTextBox"
        Me.CondomínioTextBox.Size = New System.Drawing.Size(231, 22)
        Me.CondomínioTextBox.TabIndex = 7
        '
        'AptTextBox
        '
        Me.AptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Apt", True))
        Me.AptTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.AptTextBox.Location = New System.Drawing.Point(106, 207)
        Me.AptTextBox.Name = "AptTextBox"
        Me.AptTextBox.Size = New System.Drawing.Size(59, 22)
        Me.AptTextBox.TabIndex = 8
        '
        'bPesquisar
        '
        Me.bPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPesquisar.Image = CType(resources.GetObject("bPesquisar.Image"), System.Drawing.Image)
        Me.bPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bPesquisar.Location = New System.Drawing.Point(686, 6)
        Me.bPesquisar.Name = "bPesquisar"
        Me.bPesquisar.Size = New System.Drawing.Size(38, 37)
        Me.bPesquisar.TabIndex = 44
        Me.bPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bPesquisar.UseVisualStyleBackColor = False
        '
        'dgvListaCliente
        '
        Me.dgvListaCliente.AllowUserToAddRows = False
        Me.dgvListaCliente.AllowUserToDeleteRows = False
        Me.dgvListaCliente.AutoGenerateColumns = False
        Me.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.CPFDataGridViewTextBoxColumn, Me.EndereçoDataGridViewTextBoxColumn, Me.BairroDataGridViewTextBoxColumn, Me.CondomínioDataGridViewTextBoxColumn, Me.AptDataGridViewTextBoxColumn, Me.ComplementoDataGridViewTextBoxColumn, Me.TelefoneDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.EquipDataGridViewTextBoxColumn, Me.FabricanteDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.SérieDataGridViewTextBoxColumn})
        Me.dgvListaCliente.DataSource = Me.CadastroBindingSource
        Me.dgvListaCliente.Location = New System.Drawing.Point(29, 459)
        Me.dgvListaCliente.Name = "dgvListaCliente"
        Me.dgvListaCliente.ReadOnly = True
        Me.dgvListaCliente.Size = New System.Drawing.Size(728, 196)
        Me.dgvListaCliente.TabIndex = 68
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CPFDataGridViewTextBoxColumn
        '
        Me.CPFDataGridViewTextBoxColumn.DataPropertyName = "CPF"
        Me.CPFDataGridViewTextBoxColumn.HeaderText = "CPF"
        Me.CPFDataGridViewTextBoxColumn.Name = "CPFDataGridViewTextBoxColumn"
        Me.CPFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EndereçoDataGridViewTextBoxColumn
        '
        Me.EndereçoDataGridViewTextBoxColumn.DataPropertyName = "Endereço"
        Me.EndereçoDataGridViewTextBoxColumn.HeaderText = "Endereço"
        Me.EndereçoDataGridViewTextBoxColumn.Name = "EndereçoDataGridViewTextBoxColumn"
        Me.EndereçoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BairroDataGridViewTextBoxColumn
        '
        Me.BairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.HeaderText = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.Name = "BairroDataGridViewTextBoxColumn"
        Me.BairroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CondomínioDataGridViewTextBoxColumn
        '
        Me.CondomínioDataGridViewTextBoxColumn.DataPropertyName = "Condomínio"
        Me.CondomínioDataGridViewTextBoxColumn.HeaderText = "Condomínio"
        Me.CondomínioDataGridViewTextBoxColumn.Name = "CondomínioDataGridViewTextBoxColumn"
        Me.CondomínioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AptDataGridViewTextBoxColumn
        '
        Me.AptDataGridViewTextBoxColumn.DataPropertyName = "Apt"
        Me.AptDataGridViewTextBoxColumn.HeaderText = "Apt"
        Me.AptDataGridViewTextBoxColumn.Name = "AptDataGridViewTextBoxColumn"
        Me.AptDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComplementoDataGridViewTextBoxColumn
        '
        Me.ComplementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento"
        Me.ComplementoDataGridViewTextBoxColumn.HeaderText = "Complemento"
        Me.ComplementoDataGridViewTextBoxColumn.Name = "ComplementoDataGridViewTextBoxColumn"
        Me.ComplementoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefoneDataGridViewTextBoxColumn
        '
        Me.TelefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.Name = "TelefoneDataGridViewTextBoxColumn"
        Me.TelefoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "Celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EquipDataGridViewTextBoxColumn
        '
        Me.EquipDataGridViewTextBoxColumn.DataPropertyName = "Equip"
        Me.EquipDataGridViewTextBoxColumn.HeaderText = "Equip"
        Me.EquipDataGridViewTextBoxColumn.Name = "EquipDataGridViewTextBoxColumn"
        Me.EquipDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FabricanteDataGridViewTextBoxColumn
        '
        Me.FabricanteDataGridViewTextBoxColumn.DataPropertyName = "Fabricante"
        Me.FabricanteDataGridViewTextBoxColumn.HeaderText = "Fabricante"
        Me.FabricanteDataGridViewTextBoxColumn.Name = "FabricanteDataGridViewTextBoxColumn"
        Me.FabricanteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SérieDataGridViewTextBoxColumn
        '
        Me.SérieDataGridViewTextBoxColumn.DataPropertyName = "Série"
        Me.SérieDataGridViewTextBoxColumn.HeaderText = "Série"
        Me.SérieDataGridViewTextBoxColumn.Name = "SérieDataGridViewTextBoxColumn"
        Me.SérieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.bPesquisar, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtBuscarCliente, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cbNomeCondominio, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(29, 407)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(728, 51)
        Me.TableLayoutPanel4.TabIndex = 67
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
        Me.bVoltar.Location = New System.Drawing.Point(597, 275)
        Me.bVoltar.Name = "bVoltar"
        Me.bVoltar.Size = New System.Drawing.Size(93, 88)
        Me.bVoltar.TabIndex = 86
        Me.bVoltar.Text = "Voltar"
        Me.bVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bVoltar.UseVisualStyleBackColor = False
        '
        'CadastroTableAdapter
        '
        Me.CadastroTableAdapter.ClearBeforeFill = True
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClicServ_2._0.My.Resources.Resources.Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 667)
        Me.ControlBox = False
        Me.Controls.Add(Me.bVoltar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bAtualizarCliente)
        Me.Controls.Add(Me.bExcluirCliente)
        Me.Controls.Add(Me.bEditarCliente)
        Me.Controls.Add(Me.bSalvarCliente)
        Me.Controls.Add(Me.bNovoCliente)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dgvListaCliente)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(500, 50)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.CadastroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvListaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CPFTextBox As MaskedTextBox
    Friend WithEvents TelefoneTextBox As MaskedTextBox
    Friend WithEvents CelularTextBox As MaskedTextBox
    Friend WithEvents bAtualizarCliente As Button
    Friend WithEvents bExcluirCliente As Button
    Friend WithEvents bEditarCliente As Button
    Friend WithEvents bSalvarCliente As Button
    Friend WithEvents bNovoCliente As Button
    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents EquipTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbNomeCondominio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ComplementoTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents FabricanteTextBox As TextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents Nº_sérieTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents EndereçoTextBox As TextBox
    Friend WithEvents CondomínioTextBox As TextBox
    Friend WithEvents AptTextBox As TextBox
    Friend WithEvents bPesquisar As Button
    Friend WithEvents dgvListaCliente As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents bVoltar As Button
    Friend WithEvents DataSet As DataSet
    Friend WithEvents CadastroBindingSource As BindingSource
    Friend WithEvents CadastroTableAdapter As DataSetTableAdapters.CadastroTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndereçoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BairroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CondomínioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComplementoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EquipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FabricanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SérieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
