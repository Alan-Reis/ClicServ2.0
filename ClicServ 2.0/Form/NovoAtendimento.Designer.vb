<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovoAtendimento
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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim DefeitoLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim PeríodoLabel As System.Windows.Forms.Label
        Dim TécnicoLabel As System.Windows.Forms.Label
        Dim ObservaçãoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovoAtendimento))
        Me.DataTextBox = New System.Windows.Forms.DateTimePicker()
        Me.AtendimentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New ClicServ_2._0.DataSet()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.DefeitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeríodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TécnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ProtocoloTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DefeitoTextBox = New System.Windows.Forms.TextBox()
        Me.TécnicoTextBox = New System.Windows.Forms.TextBox()
        Me.PeríodoTextBox = New System.Windows.Forms.TextBox()
        Me.ObservaçãoTextBox = New System.Windows.Forms.TextBox()
        Me.bAtualizarAtendimento = New System.Windows.Forms.Button()
        Me.bExcluirAtendimento = New System.Windows.Forms.Button()
        Me.bEditarAtendimento = New System.Windows.Forms.Button()
        Me.bSalvarAtendimento = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SituaçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bNovoAtendimento = New System.Windows.Forms.Button()
        Me.ObservaçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.AtendimentoDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefeitoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeríodoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TécnicoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservaçãoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AtendimentoTableAdapter = New ClicServ_2._0.DataSetTableAdapters.AtendimentoTableAdapter()
        Me.TableAdapterManager = New ClicServ_2._0.DataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        DefeitoLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        PeríodoLabel = New System.Windows.Forms.Label()
        TécnicoLabel = New System.Windows.Forms.Label()
        ObservaçãoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.AtendimentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AtendimentoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'DefeitoLabel
        '
        DefeitoLabel.AutoSize = True
        DefeitoLabel.BackColor = System.Drawing.Color.Transparent
        DefeitoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DefeitoLabel.ForeColor = System.Drawing.Color.White
        DefeitoLabel.Location = New System.Drawing.Point(4, 30)
        DefeitoLabel.Name = "DefeitoLabel"
        DefeitoLabel.Size = New System.Drawing.Size(54, 16)
        DefeitoLabel.TabIndex = 7
        DefeitoLabel.Text = "Defeito:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.BackColor = System.Drawing.Color.Transparent
        DataLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.ForeColor = System.Drawing.Color.White
        DataLabel.Location = New System.Drawing.Point(4, 59)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(40, 16)
        DataLabel.TabIndex = 9
        DataLabel.Text = "Data:"
        '
        'PeríodoLabel
        '
        PeríodoLabel.AutoSize = True
        PeríodoLabel.BackColor = System.Drawing.Color.Transparent
        PeríodoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PeríodoLabel.ForeColor = System.Drawing.Color.White
        PeríodoLabel.Location = New System.Drawing.Point(4, 86)
        PeríodoLabel.Name = "PeríodoLabel"
        PeríodoLabel.Size = New System.Drawing.Size(59, 16)
        PeríodoLabel.TabIndex = 11
        PeríodoLabel.Text = "Período:"
        '
        'TécnicoLabel
        '
        TécnicoLabel.AutoSize = True
        TécnicoLabel.BackColor = System.Drawing.Color.Transparent
        TécnicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TécnicoLabel.ForeColor = System.Drawing.Color.White
        TécnicoLabel.Location = New System.Drawing.Point(4, 115)
        TécnicoLabel.Name = "TécnicoLabel"
        TécnicoLabel.Size = New System.Drawing.Size(60, 16)
        TécnicoLabel.TabIndex = 13
        TécnicoLabel.Text = "Técnico:"
        '
        'ObservaçãoLabel
        '
        ObservaçãoLabel.AutoSize = True
        ObservaçãoLabel.BackColor = System.Drawing.Color.Transparent
        ObservaçãoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObservaçãoLabel.ForeColor = System.Drawing.Color.White
        ObservaçãoLabel.Location = New System.Drawing.Point(4, 142)
        ObservaçãoLabel.Name = "ObservaçãoLabel"
        ObservaçãoLabel.Size = New System.Drawing.Size(86, 16)
        ObservaçãoLabel.TabIndex = 15
        ObservaçãoLabel.Text = "Observação:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(4, 171)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(69, 16)
        Label1.TabIndex = 16
        Label1.Text = "Protocolo:"
        '
        'DataTextBox
        '
        Me.DataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AtendimentoBindingSource, "Data", True))
        Me.DataTextBox.Location = New System.Drawing.Point(97, 62)
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.Size = New System.Drawing.Size(212, 20)
        Me.DataTextBox.TabIndex = 3
        '
        'AtendimentoBindingSource
        '
        Me.AtendimentoBindingSource.DataMember = "Atendimento"
        Me.AtendimentoBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpData
        '
        Me.dtpData.Location = New System.Drawing.Point(325, 6)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(214, 20)
        Me.dtpData.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 24)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Selecione a data e digite a situação:"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dtpData, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(12, 280)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(544, 36)
        Me.TableLayoutPanel4.TabIndex = 67
        '
        'DefeitoDataGridViewTextBoxColumn
        '
        Me.DefeitoDataGridViewTextBoxColumn.DataPropertyName = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn.HeaderText = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn.Name = "DefeitoDataGridViewTextBoxColumn"
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        '
        'PeríodoDataGridViewTextBoxColumn
        '
        Me.PeríodoDataGridViewTextBoxColumn.DataPropertyName = "Período"
        Me.PeríodoDataGridViewTextBoxColumn.HeaderText = "Período"
        Me.PeríodoDataGridViewTextBoxColumn.Name = "PeríodoDataGridViewTextBoxColumn"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(-10, -1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(785, 47)
        Me.TextBox1.TabIndex = 65
        Me.TextBox1.Text = "Atendimento"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TécnicoDataGridViewTextBoxColumn
        '
        Me.TécnicoDataGridViewTextBoxColumn.DataPropertyName = "Técnico"
        Me.TécnicoDataGridViewTextBoxColumn.HeaderText = "Técnico"
        Me.TécnicoDataGridViewTextBoxColumn.Name = "TécnicoDataGridViewTextBoxColumn"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.ProtocoloTextBox, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Label1, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(DefeitoLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DefeitoTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(DataLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TécnicoTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DataTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(PeríodoLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PeríodoTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(TécnicoLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(ObservaçãoLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ObservaçãoTextBox, 1, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 52)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(439, 198)
        Me.TableLayoutPanel1.TabIndex = 66
        '
        'ProtocoloTextBox
        '
        Me.ProtocoloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtendimentoBindingSource, "Protocolo", True))
        Me.ProtocoloTextBox.Location = New System.Drawing.Point(97, 174)
        Me.ProtocoloTextBox.Name = "ProtocoloTextBox"
        Me.ProtocoloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProtocoloTextBox.TabIndex = 77
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtendimentoBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(97, 4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(62, 22)
        Me.IDTextBox.TabIndex = 1
        '
        'DefeitoTextBox
        '
        Me.DefeitoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtendimentoBindingSource, "Defeito", True))
        Me.DefeitoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefeitoTextBox.Location = New System.Drawing.Point(97, 33)
        Me.DefeitoTextBox.Name = "DefeitoTextBox"
        Me.DefeitoTextBox.Size = New System.Drawing.Size(278, 22)
        Me.DefeitoTextBox.TabIndex = 2
        '
        'TécnicoTextBox
        '
        Me.TécnicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtendimentoBindingSource, "Técnico", True))
        Me.TécnicoTextBox.Location = New System.Drawing.Point(97, 118)
        Me.TécnicoTextBox.Name = "TécnicoTextBox"
        Me.TécnicoTextBox.Size = New System.Drawing.Size(106, 20)
        Me.TécnicoTextBox.TabIndex = 5
        '
        'PeríodoTextBox
        '
        Me.PeríodoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtendimentoBindingSource, "Período", True))
        Me.PeríodoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeríodoTextBox.Location = New System.Drawing.Point(97, 89)
        Me.PeríodoTextBox.Name = "PeríodoTextBox"
        Me.PeríodoTextBox.Size = New System.Drawing.Size(106, 22)
        Me.PeríodoTextBox.TabIndex = 4
        '
        'ObservaçãoTextBox
        '
        Me.ObservaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtendimentoBindingSource, "Observação", True))
        Me.ObservaçãoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservaçãoTextBox.Location = New System.Drawing.Point(97, 145)
        Me.ObservaçãoTextBox.Name = "ObservaçãoTextBox"
        Me.ObservaçãoTextBox.Size = New System.Drawing.Size(330, 22)
        Me.ObservaçãoTextBox.TabIndex = 6
        '
        'bAtualizarAtendimento
        '
        Me.bAtualizarAtendimento.BackColor = System.Drawing.Color.Transparent
        Me.bAtualizarAtendimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAtualizarAtendimento.FlatAppearance.BorderSize = 0
        Me.bAtualizarAtendimento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAtualizarAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAtualizarAtendimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAtualizarAtendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAtualizarAtendimento.Image = CType(resources.GetObject("bAtualizarAtendimento.Image"), System.Drawing.Image)
        Me.bAtualizarAtendimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bAtualizarAtendimento.Location = New System.Drawing.Point(463, 139)
        Me.bAtualizarAtendimento.Name = "bAtualizarAtendimento"
        Me.bAtualizarAtendimento.Size = New System.Drawing.Size(93, 81)
        Me.bAtualizarAtendimento.TabIndex = 64
        Me.bAtualizarAtendimento.Text = "Atualizar"
        Me.bAtualizarAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bAtualizarAtendimento.UseVisualStyleBackColor = False
        '
        'bExcluirAtendimento
        '
        Me.bExcluirAtendimento.BackColor = System.Drawing.Color.Transparent
        Me.bExcluirAtendimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bExcluirAtendimento.FlatAppearance.BorderSize = 0
        Me.bExcluirAtendimento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bExcluirAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExcluirAtendimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExcluirAtendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bExcluirAtendimento.Image = CType(resources.GetObject("bExcluirAtendimento.Image"), System.Drawing.Image)
        Me.bExcluirAtendimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bExcluirAtendimento.Location = New System.Drawing.Point(562, 138)
        Me.bExcluirAtendimento.Name = "bExcluirAtendimento"
        Me.bExcluirAtendimento.Size = New System.Drawing.Size(93, 81)
        Me.bExcluirAtendimento.TabIndex = 63
        Me.bExcluirAtendimento.Text = "Excluir"
        Me.bExcluirAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bExcluirAtendimento.UseVisualStyleBackColor = False
        '
        'bEditarAtendimento
        '
        Me.bEditarAtendimento.BackColor = System.Drawing.Color.Transparent
        Me.bEditarAtendimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEditarAtendimento.FlatAppearance.BorderSize = 0
        Me.bEditarAtendimento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bEditarAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEditarAtendimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEditarAtendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bEditarAtendimento.Image = CType(resources.GetObject("bEditarAtendimento.Image"), System.Drawing.Image)
        Me.bEditarAtendimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bEditarAtendimento.Location = New System.Drawing.Point(661, 52)
        Me.bEditarAtendimento.Name = "bEditarAtendimento"
        Me.bEditarAtendimento.Size = New System.Drawing.Size(93, 81)
        Me.bEditarAtendimento.TabIndex = 62
        Me.bEditarAtendimento.Text = "Editar"
        Me.bEditarAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bEditarAtendimento.UseVisualStyleBackColor = False
        '
        'bSalvarAtendimento
        '
        Me.bSalvarAtendimento.BackColor = System.Drawing.Color.Transparent
        Me.bSalvarAtendimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSalvarAtendimento.FlatAppearance.BorderSize = 0
        Me.bSalvarAtendimento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bSalvarAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalvarAtendimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalvarAtendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bSalvarAtendimento.Image = CType(resources.GetObject("bSalvarAtendimento.Image"), System.Drawing.Image)
        Me.bSalvarAtendimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bSalvarAtendimento.Location = New System.Drawing.Point(562, 52)
        Me.bSalvarAtendimento.Name = "bSalvarAtendimento"
        Me.bSalvarAtendimento.Size = New System.Drawing.Size(93, 81)
        Me.bSalvarAtendimento.TabIndex = 61
        Me.bSalvarAtendimento.Text = "Salvar"
        Me.bSalvarAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bSalvarAtendimento.UseVisualStyleBackColor = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'SituaçãoDataGridViewTextBoxColumn
        '
        Me.SituaçãoDataGridViewTextBoxColumn.DataPropertyName = "Situação"
        Me.SituaçãoDataGridViewTextBoxColumn.HeaderText = "Situação"
        Me.SituaçãoDataGridViewTextBoxColumn.Name = "SituaçãoDataGridViewTextBoxColumn"
        '
        'bNovoAtendimento
        '
        Me.bNovoAtendimento.BackColor = System.Drawing.Color.Transparent
        Me.bNovoAtendimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bNovoAtendimento.FlatAppearance.BorderSize = 0
        Me.bNovoAtendimento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bNovoAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNovoAtendimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNovoAtendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bNovoAtendimento.Image = CType(resources.GetObject("bNovoAtendimento.Image"), System.Drawing.Image)
        Me.bNovoAtendimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bNovoAtendimento.Location = New System.Drawing.Point(463, 52)
        Me.bNovoAtendimento.Name = "bNovoAtendimento"
        Me.bNovoAtendimento.Size = New System.Drawing.Size(93, 81)
        Me.bNovoAtendimento.TabIndex = 59
        Me.bNovoAtendimento.Text = "Novo"
        Me.bNovoAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bNovoAtendimento.UseVisualStyleBackColor = False
        '
        'ObservaçãoDataGridViewTextBoxColumn
        '
        Me.ObservaçãoDataGridViewTextBoxColumn.DataPropertyName = "Observação"
        Me.ObservaçãoDataGridViewTextBoxColumn.HeaderText = "Observação"
        Me.ObservaçãoDataGridViewTextBoxColumn.Name = "ObservaçãoDataGridViewTextBoxColumn"
        '
        'bCancelar
        '
        Me.bCancelar.BackColor = System.Drawing.Color.Transparent
        Me.bCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCancelar.FlatAppearance.BorderSize = 0
        Me.bCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bCancelar.Image = Global.ClicServ_2._0.My.Resources.Resources.voltar1
        Me.bCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bCancelar.Location = New System.Drawing.Point(661, 138)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(93, 81)
        Me.bCancelar.TabIndex = 76
        Me.bCancelar.Text = "Voltar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'AtendimentoDataGridView
        '
        Me.AtendimentoDataGridView.AllowUserToAddRows = False
        Me.AtendimentoDataGridView.AllowUserToDeleteRows = False
        Me.AtendimentoDataGridView.AutoGenerateColumns = False
        Me.AtendimentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AtendimentoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.DefeitoDataGridViewTextBoxColumn1, Me.DataDataGridViewTextBoxColumn1, Me.PeríodoDataGridViewTextBoxColumn1, Me.TécnicoDataGridViewTextBoxColumn1, Me.ObservaçãoDataGridViewTextBoxColumn1})
        Me.AtendimentoDataGridView.DataSource = Me.AtendimentoBindingSource
        Me.AtendimentoDataGridView.Location = New System.Drawing.Point(11, 322)
        Me.AtendimentoDataGridView.Name = "AtendimentoDataGridView"
        Me.AtendimentoDataGridView.ReadOnly = True
        Me.AtendimentoDataGridView.Size = New System.Drawing.Size(645, 220)
        Me.AtendimentoDataGridView.TabIndex = 68
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DefeitoDataGridViewTextBoxColumn1
        '
        Me.DefeitoDataGridViewTextBoxColumn1.DataPropertyName = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn1.HeaderText = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn1.Name = "DefeitoDataGridViewTextBoxColumn1"
        Me.DefeitoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn1
        '
        Me.DataDataGridViewTextBoxColumn1.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn1.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn1.Name = "DataDataGridViewTextBoxColumn1"
        Me.DataDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PeríodoDataGridViewTextBoxColumn1
        '
        Me.PeríodoDataGridViewTextBoxColumn1.DataPropertyName = "Período"
        Me.PeríodoDataGridViewTextBoxColumn1.HeaderText = "Período"
        Me.PeríodoDataGridViewTextBoxColumn1.Name = "PeríodoDataGridViewTextBoxColumn1"
        Me.PeríodoDataGridViewTextBoxColumn1.ReadOnly = True
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
        'AtendimentoTableAdapter
        '
        Me.AtendimentoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AtendimentoTableAdapter = Me.AtendimentoTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CadastroTableAdapter = Nothing
        Me.TableAdapterManager.OSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ClicServ_2._0.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NovoAtendimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClicServ_2._0.My.Resources.Resources.Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(762, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.AtendimentoDataGridView)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.bAtualizarAtendimento)
        Me.Controls.Add(Me.bExcluirAtendimento)
        Me.Controls.Add(Me.bEditarAtendimento)
        Me.Controls.Add(Me.bSalvarAtendimento)
        Me.Controls.Add(Me.bNovoAtendimento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NovoAtendimento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.AtendimentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.AtendimentoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataTextBox As DateTimePicker
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents DefeitoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeríodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TécnicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DefeitoTextBox As TextBox
    Friend WithEvents TécnicoTextBox As TextBox
    Friend WithEvents PeríodoTextBox As TextBox
    Friend WithEvents ObservaçãoTextBox As TextBox
    Friend WithEvents bAtualizarAtendimento As Button
    Friend WithEvents bExcluirAtendimento As Button
    Friend WithEvents bEditarAtendimento As Button
    Friend WithEvents bSalvarAtendimento As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SituaçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bNovoAtendimento As Button
    Friend WithEvents ObservaçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bCancelar As Button
    Friend WithEvents DataSet As DataSet
    Friend WithEvents AtendimentoBindingSource As BindingSource
    Friend WithEvents AtendimentoTableAdapter As DataSetTableAdapters.AtendimentoTableAdapter
    Friend WithEvents AtendimentoDataGridView As DataGridView
    Friend WithEvents ProtocoloTextBox As TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DefeitoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PeríodoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TécnicoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ObservaçãoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
End Class
