<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovoOS
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim OSLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim DefeitoLabel As System.Windows.Forms.Label
        Dim RelatórioLabel As System.Windows.Forms.Label
        Dim TécnicoLabel As System.Windows.Forms.Label
        Dim ObservaçãoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovoOS))
        Me.dgvOS = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefeitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelatórioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TécnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservaçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New ClicServ_2._0.DataSet()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.OSTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.DefeitoTextBox = New System.Windows.Forms.TextBox()
        Me.RelatórioTextBox = New System.Windows.Forms.TextBox()
        Me.ObservaçãoTextBox = New System.Windows.Forms.TextBox()
        Me.TécnicoTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.bEditarOS = New System.Windows.Forms.Button()
        Me.bSalvarOS = New System.Windows.Forms.Button()
        Me.bNovoOS = New System.Windows.Forms.Button()
        Me.bAtualizarOS = New System.Windows.Forms.Button()
        Me.bExcluirOS = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.OSTableAdapter = New ClicServ_2._0.DataSetTableAdapters.OSTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        OSLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        DefeitoLabel = New System.Windows.Forms.Label()
        RelatórioLabel = New System.Windows.Forms.Label()
        TécnicoLabel = New System.Windows.Forms.Label()
        ObservaçãoLabel = New System.Windows.Forms.Label()
        CType(Me.dgvOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
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
        'OSLabel
        '
        OSLabel.AutoSize = True
        OSLabel.BackColor = System.Drawing.Color.Transparent
        OSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OSLabel.ForeColor = System.Drawing.Color.White
        OSLabel.Location = New System.Drawing.Point(4, 30)
        OSLabel.Name = "OSLabel"
        OSLabel.Size = New System.Drawing.Size(30, 16)
        OSLabel.TabIndex = 3
        OSLabel.Text = "OS:"
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
        DataLabel.TabIndex = 5
        DataLabel.Text = "Data:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.BackColor = System.Drawing.Color.Transparent
        ValorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorLabel.ForeColor = System.Drawing.Color.White
        ValorLabel.Location = New System.Drawing.Point(4, 86)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(43, 16)
        ValorLabel.TabIndex = 7
        ValorLabel.Text = "Valor:"
        '
        'DefeitoLabel
        '
        DefeitoLabel.AutoSize = True
        DefeitoLabel.BackColor = System.Drawing.Color.Transparent
        DefeitoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DefeitoLabel.ForeColor = System.Drawing.Color.White
        DefeitoLabel.Location = New System.Drawing.Point(4, 115)
        DefeitoLabel.Name = "DefeitoLabel"
        DefeitoLabel.Size = New System.Drawing.Size(54, 16)
        DefeitoLabel.TabIndex = 11
        DefeitoLabel.Text = "Defeito:"
        '
        'RelatórioLabel
        '
        RelatórioLabel.AutoSize = True
        RelatórioLabel.BackColor = System.Drawing.Color.Transparent
        RelatórioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RelatórioLabel.ForeColor = System.Drawing.Color.White
        RelatórioLabel.Location = New System.Drawing.Point(4, 144)
        RelatórioLabel.Name = "RelatórioLabel"
        RelatórioLabel.Size = New System.Drawing.Size(66, 16)
        RelatórioLabel.TabIndex = 13
        RelatórioLabel.Text = "Relatório:"
        '
        'TécnicoLabel
        '
        TécnicoLabel.AutoSize = True
        TécnicoLabel.BackColor = System.Drawing.Color.Transparent
        TécnicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TécnicoLabel.ForeColor = System.Drawing.Color.White
        TécnicoLabel.Location = New System.Drawing.Point(4, 173)
        TécnicoLabel.Name = "TécnicoLabel"
        TécnicoLabel.Size = New System.Drawing.Size(60, 16)
        TécnicoLabel.TabIndex = 15
        TécnicoLabel.Text = "Técnico:"
        '
        'ObservaçãoLabel
        '
        ObservaçãoLabel.AutoSize = True
        ObservaçãoLabel.BackColor = System.Drawing.Color.Transparent
        ObservaçãoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObservaçãoLabel.ForeColor = System.Drawing.Color.White
        ObservaçãoLabel.Location = New System.Drawing.Point(4, 202)
        ObservaçãoLabel.Name = "ObservaçãoLabel"
        ObservaçãoLabel.Size = New System.Drawing.Size(86, 16)
        ObservaçãoLabel.TabIndex = 17
        ObservaçãoLabel.Text = "Observação:"
        '
        'dgvOS
        '
        Me.dgvOS.AllowUserToAddRows = False
        Me.dgvOS.AllowUserToDeleteRows = False
        Me.dgvOS.AutoGenerateColumns = False
        Me.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.OSDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn, Me.DefeitoDataGridViewTextBoxColumn, Me.RelatórioDataGridViewTextBoxColumn, Me.TécnicoDataGridViewTextBoxColumn, Me.ObservaçãoDataGridViewTextBoxColumn})
        Me.dgvOS.DataSource = Me.OSBindingSource
        Me.dgvOS.Location = New System.Drawing.Point(2, 392)
        Me.dgvOS.Name = "dgvOS"
        Me.dgvOS.ReadOnly = True
        Me.dgvOS.Size = New System.Drawing.Size(598, 260)
        Me.dgvOS.TabIndex = 72
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OSDataGridViewTextBoxColumn
        '
        Me.OSDataGridViewTextBoxColumn.DataPropertyName = "OS"
        Me.OSDataGridViewTextBoxColumn.HeaderText = "OS"
        Me.OSDataGridViewTextBoxColumn.Name = "OSDataGridViewTextBoxColumn"
        Me.OSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DefeitoDataGridViewTextBoxColumn
        '
        Me.DefeitoDataGridViewTextBoxColumn.DataPropertyName = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn.HeaderText = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn.Name = "DefeitoDataGridViewTextBoxColumn"
        Me.DefeitoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RelatórioDataGridViewTextBoxColumn
        '
        Me.RelatórioDataGridViewTextBoxColumn.DataPropertyName = "Relatório"
        Me.RelatórioDataGridViewTextBoxColumn.HeaderText = "Relatório"
        Me.RelatórioDataGridViewTextBoxColumn.Name = "RelatórioDataGridViewTextBoxColumn"
        Me.RelatórioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TécnicoDataGridViewTextBoxColumn
        '
        Me.TécnicoDataGridViewTextBoxColumn.DataPropertyName = "Técnico"
        Me.TécnicoDataGridViewTextBoxColumn.HeaderText = "Técnico"
        Me.TécnicoDataGridViewTextBoxColumn.Name = "TécnicoDataGridViewTextBoxColumn"
        Me.TécnicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservaçãoDataGridViewTextBoxColumn
        '
        Me.ObservaçãoDataGridViewTextBoxColumn.DataPropertyName = "Observação"
        Me.ObservaçãoDataGridViewTextBoxColumn.HeaderText = "Observação"
        Me.ObservaçãoDataGridViewTextBoxColumn.Name = "ObservaçãoDataGridViewTextBoxColumn"
        Me.ObservaçãoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OSBindingSource
        '
        Me.OSBindingSource.DataMember = "OS"
        Me.OSBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpData
        '
        Me.dtpData.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OSBindingSource, "Data", True))
        Me.dtpData.Location = New System.Drawing.Point(97, 62)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(211, 20)
        Me.dtpData.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(-8, -4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(616, 47)
        Me.TextBox1.TabIndex = 70
        Me.TextBox1.Text = "Ordem de Serviço"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OSBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(97, 4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(61, 22)
        Me.IDTextBox.TabIndex = 1
        '
        'OSTextBox
        '
        Me.OSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OSBindingSource, "OS", True))
        Me.OSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSTextBox.Location = New System.Drawing.Point(97, 33)
        Me.OSTextBox.Name = "OSTextBox"
        Me.OSTextBox.Size = New System.Drawing.Size(61, 22)
        Me.OSTextBox.TabIndex = 2
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OSBindingSource, "Valor", True))
        Me.ValorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorTextBox.Location = New System.Drawing.Point(97, 89)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(109, 22)
        Me.ValorTextBox.TabIndex = 4
        '
        'DefeitoTextBox
        '
        Me.DefeitoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OSBindingSource, "Defeito", True))
        Me.DefeitoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefeitoTextBox.Location = New System.Drawing.Point(97, 118)
        Me.DefeitoTextBox.Name = "DefeitoTextBox"
        Me.DefeitoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DefeitoTextBox.TabIndex = 5
        '
        'RelatórioTextBox
        '
        Me.RelatórioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OSBindingSource, "Relatório", True))
        Me.RelatórioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RelatórioTextBox.Location = New System.Drawing.Point(97, 147)
        Me.RelatórioTextBox.Name = "RelatórioTextBox"
        Me.RelatórioTextBox.Size = New System.Drawing.Size(475, 22)
        Me.RelatórioTextBox.TabIndex = 6
        '
        'ObservaçãoTextBox
        '
        Me.ObservaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OSBindingSource, "Observação", True))
        Me.ObservaçãoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservaçãoTextBox.Location = New System.Drawing.Point(97, 205)
        Me.ObservaçãoTextBox.Name = "ObservaçãoTextBox"
        Me.ObservaçãoTextBox.Size = New System.Drawing.Size(475, 22)
        Me.ObservaçãoTextBox.TabIndex = 8
        '
        'TécnicoTextBox
        '
        Me.TécnicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OSBindingSource, "Técnico", True))
        Me.TécnicoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TécnicoTextBox.Location = New System.Drawing.Point(97, 176)
        Me.TécnicoTextBox.Name = "TécnicoTextBox"
        Me.TécnicoTextBox.Size = New System.Drawing.Size(109, 22)
        Me.TécnicoTextBox.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(OSLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.OSTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(DataLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpData, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(ValorLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ValorTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(DefeitoLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DefeitoTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(RelatórioLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.RelatórioTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(TécnicoLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ObservaçãoTextBox, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(ObservaçãoLabel, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TécnicoTextBox, 1, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 49)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(596, 235)
        Me.TableLayoutPanel1.TabIndex = 71
        '
        'bEditarOS
        '
        Me.bEditarOS.BackColor = System.Drawing.Color.Transparent
        Me.bEditarOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEditarOS.FlatAppearance.BorderSize = 0
        Me.bEditarOS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bEditarOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEditarOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEditarOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bEditarOS.Image = CType(resources.GetObject("bEditarOS.Image"), System.Drawing.Image)
        Me.bEditarOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bEditarOS.Location = New System.Drawing.Point(203, 303)
        Me.bEditarOS.Name = "bEditarOS"
        Me.bEditarOS.Size = New System.Drawing.Size(93, 81)
        Me.bEditarOS.TabIndex = 67
        Me.bEditarOS.Text = "Editar"
        Me.bEditarOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bEditarOS.UseVisualStyleBackColor = False
        '
        'bSalvarOS
        '
        Me.bSalvarOS.BackColor = System.Drawing.Color.Transparent
        Me.bSalvarOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSalvarOS.FlatAppearance.BorderSize = 0
        Me.bSalvarOS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bSalvarOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalvarOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalvarOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bSalvarOS.Image = CType(resources.GetObject("bSalvarOS.Image"), System.Drawing.Image)
        Me.bSalvarOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bSalvarOS.Location = New System.Drawing.Point(104, 303)
        Me.bSalvarOS.Name = "bSalvarOS"
        Me.bSalvarOS.Size = New System.Drawing.Size(93, 81)
        Me.bSalvarOS.TabIndex = 66
        Me.bSalvarOS.Text = "Salvar"
        Me.bSalvarOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bSalvarOS.UseVisualStyleBackColor = False
        '
        'bNovoOS
        '
        Me.bNovoOS.BackColor = System.Drawing.Color.Transparent
        Me.bNovoOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bNovoOS.FlatAppearance.BorderSize = 0
        Me.bNovoOS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bNovoOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNovoOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNovoOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bNovoOS.Image = CType(resources.GetObject("bNovoOS.Image"), System.Drawing.Image)
        Me.bNovoOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bNovoOS.Location = New System.Drawing.Point(5, 303)
        Me.bNovoOS.Name = "bNovoOS"
        Me.bNovoOS.Size = New System.Drawing.Size(93, 81)
        Me.bNovoOS.TabIndex = 64
        Me.bNovoOS.Text = "Novo"
        Me.bNovoOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bNovoOS.UseVisualStyleBackColor = False
        '
        'bAtualizarOS
        '
        Me.bAtualizarOS.BackColor = System.Drawing.Color.Transparent
        Me.bAtualizarOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAtualizarOS.FlatAppearance.BorderSize = 0
        Me.bAtualizarOS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAtualizarOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAtualizarOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAtualizarOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAtualizarOS.Image = CType(resources.GetObject("bAtualizarOS.Image"), System.Drawing.Image)
        Me.bAtualizarOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bAtualizarOS.Location = New System.Drawing.Point(302, 303)
        Me.bAtualizarOS.Name = "bAtualizarOS"
        Me.bAtualizarOS.Size = New System.Drawing.Size(93, 81)
        Me.bAtualizarOS.TabIndex = 69
        Me.bAtualizarOS.Text = "Atualizar"
        Me.bAtualizarOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bAtualizarOS.UseVisualStyleBackColor = False
        '
        'bExcluirOS
        '
        Me.bExcluirOS.BackColor = System.Drawing.Color.Transparent
        Me.bExcluirOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bExcluirOS.FlatAppearance.BorderSize = 0
        Me.bExcluirOS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bExcluirOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExcluirOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExcluirOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bExcluirOS.Image = CType(resources.GetObject("bExcluirOS.Image"), System.Drawing.Image)
        Me.bExcluirOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bExcluirOS.Location = New System.Drawing.Point(401, 303)
        Me.bExcluirOS.Name = "bExcluirOS"
        Me.bExcluirOS.Size = New System.Drawing.Size(93, 81)
        Me.bExcluirOS.TabIndex = 68
        Me.bExcluirOS.Text = "Excluir"
        Me.bExcluirOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bExcluirOS.UseVisualStyleBackColor = False
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
        Me.bCancelar.Location = New System.Drawing.Point(500, 303)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(93, 81)
        Me.bCancelar.TabIndex = 76
        Me.bCancelar.Text = "Voltar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'OSTableAdapter
        '
        Me.OSTableAdapter.ClearBeforeFill = True
        '
        'NovoOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClicServ_2._0.My.Resources.Resources.Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(601, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.dgvOS)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bEditarOS)
        Me.Controls.Add(Me.bSalvarOS)
        Me.Controls.Add(Me.bNovoOS)
        Me.Controls.Add(Me.bAtualizarOS)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.bExcluirOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NovoOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvOS As DataGridView
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents OSTextBox As TextBox
    Friend WithEvents ValorTextBox As TextBox
    Friend WithEvents DefeitoTextBox As TextBox
    Friend WithEvents bEditarOS As Button
    Friend WithEvents bSalvarOS As Button
    Friend WithEvents bNovoOS As Button
    Friend WithEvents RelatórioTextBox As TextBox
    Friend WithEvents bAtualizarOS As Button
    Friend WithEvents ObservaçãoTextBox As TextBox
    Friend WithEvents TécnicoTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents bExcluirOS As Button
    Friend WithEvents bCancelar As Button
    Friend WithEvents DataSet As DataSet
    Friend WithEvents OSBindingSource As BindingSource
    Friend WithEvents OSTableAdapter As DataSetTableAdapters.OSTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DefeitoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RelatórioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TécnicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservaçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RevisãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
