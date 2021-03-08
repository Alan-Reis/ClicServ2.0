<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrimeiroAtendimento
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
        Dim DefeitoLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim PeríodoLabel As System.Windows.Forms.Label
        Dim TécnicoLabel As System.Windows.Forms.Label
        Dim ObservaçãoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrimeiroAtendimento))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PeríodoTextBox = New System.Windows.Forms.TextBox()
        Me.ObservaçãoTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DefeitoTextBox = New System.Windows.Forms.TextBox()
        Me.TécnicoTextBox = New System.Windows.Forms.TextBox()
        Me.DataTextBox = New System.Windows.Forms.DateTimePicker()
        Me.SituaçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TécnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeríodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservaçãoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefeitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.bSalvarAtendimento = New System.Windows.Forms.Button()
        Me.DataSet = New ClicServ_2._0.DataSet()
        Me.AtendimentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AtendimentoTableAdapter = New ClicServ_2._0.DataSetTableAdapters.AtendimentoTableAdapter()
        Me.TableAdapterManager = New ClicServ_2._0.DataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        DefeitoLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        PeríodoLabel = New System.Windows.Forms.Label()
        TécnicoLabel = New System.Windows.Forms.Label()
        ObservaçãoLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtendimentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(-5, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(453, 47)
        Me.TextBox1.TabIndex = 69
        Me.TextBox1.Text = "Atendimento"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PeríodoTextBox
        '
        Me.PeríodoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeríodoTextBox.Location = New System.Drawing.Point(97, 89)
        Me.PeríodoTextBox.Name = "PeríodoTextBox"
        Me.PeríodoTextBox.Size = New System.Drawing.Size(106, 22)
        Me.PeríodoTextBox.TabIndex = 4
        '
        'ObservaçãoTextBox
        '
        Me.ObservaçãoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservaçãoTextBox.Location = New System.Drawing.Point(97, 145)
        Me.ObservaçãoTextBox.Name = "ObservaçãoTextBox"
        Me.ObservaçãoTextBox.Size = New System.Drawing.Size(330, 22)
        Me.ObservaçãoTextBox.TabIndex = 6
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 54)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(439, 173)
        Me.TableLayoutPanel1.TabIndex = 70
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(97, 4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(62, 22)
        Me.IDTextBox.TabIndex = 1
        '
        'DefeitoTextBox
        '
        Me.DefeitoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefeitoTextBox.Location = New System.Drawing.Point(97, 33)
        Me.DefeitoTextBox.Name = "DefeitoTextBox"
        Me.DefeitoTextBox.Size = New System.Drawing.Size(278, 22)
        Me.DefeitoTextBox.TabIndex = 2
        '
        'TécnicoTextBox
        '
        Me.TécnicoTextBox.Location = New System.Drawing.Point(97, 118)
        Me.TécnicoTextBox.Name = "TécnicoTextBox"
        Me.TécnicoTextBox.Size = New System.Drawing.Size(106, 20)
        Me.TécnicoTextBox.TabIndex = 5
        '
        'DataTextBox
        '
        Me.DataTextBox.Location = New System.Drawing.Point(97, 62)
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.Size = New System.Drawing.Size(212, 20)
        Me.DataTextBox.TabIndex = 3
        '
        'SituaçãoDataGridViewTextBoxColumn
        '
        Me.SituaçãoDataGridViewTextBoxColumn.DataPropertyName = "Situação"
        Me.SituaçãoDataGridViewTextBoxColumn.HeaderText = "Situação"
        Me.SituaçãoDataGridViewTextBoxColumn.Name = "SituaçãoDataGridViewTextBoxColumn"
        '
        'TécnicoDataGridViewTextBoxColumn
        '
        Me.TécnicoDataGridViewTextBoxColumn.DataPropertyName = "Técnico"
        Me.TécnicoDataGridViewTextBoxColumn.HeaderText = "Técnico"
        Me.TécnicoDataGridViewTextBoxColumn.Name = "TécnicoDataGridViewTextBoxColumn"
        '
        'PeríodoDataGridViewTextBoxColumn
        '
        Me.PeríodoDataGridViewTextBoxColumn.DataPropertyName = "Período"
        Me.PeríodoDataGridViewTextBoxColumn.HeaderText = "Período"
        Me.PeríodoDataGridViewTextBoxColumn.Name = "PeríodoDataGridViewTextBoxColumn"
        '
        'ObservaçãoDataGridViewTextBoxColumn
        '
        Me.ObservaçãoDataGridViewTextBoxColumn.DataPropertyName = "Observação"
        Me.ObservaçãoDataGridViewTextBoxColumn.HeaderText = "Observação"
        Me.ObservaçãoDataGridViewTextBoxColumn.Name = "ObservaçãoDataGridViewTextBoxColumn"
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        '
        'DefeitoDataGridViewTextBoxColumn
        '
        Me.DefeitoDataGridViewTextBoxColumn.DataPropertyName = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn.HeaderText = "Defeito"
        Me.DefeitoDataGridViewTextBoxColumn.Name = "DefeitoDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
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
        Me.bCancelar.Location = New System.Drawing.Point(90, 261)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(93, 81)
        Me.bCancelar.TabIndex = 71
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bCancelar.UseVisualStyleBackColor = False
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
        Me.bSalvarAtendimento.Location = New System.Drawing.Point(2, 261)
        Me.bSalvarAtendimento.Name = "bSalvarAtendimento"
        Me.bSalvarAtendimento.Size = New System.Drawing.Size(93, 81)
        Me.bSalvarAtendimento.TabIndex = 68
        Me.bSalvarAtendimento.Text = "Salvar"
        Me.bSalvarAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bSalvarAtendimento.UseVisualStyleBackColor = False
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AtendimentoBindingSource
        '
        Me.AtendimentoBindingSource.DataMember = "Atendimento"
        Me.AtendimentoBindingSource.DataSource = Me.DataSet
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
        'PrimeiroAtendimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClicServ_2._0.My.Resources.Resources.Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(447, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bSalvarAtendimento)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrimeiroAtendimento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtendimentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bCancelar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents bSalvarAtendimento As Button
    Friend WithEvents PeríodoTextBox As TextBox
    Friend WithEvents ObservaçãoTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DefeitoTextBox As TextBox
    Friend WithEvents TécnicoTextBox As TextBox
    Friend WithEvents DataTextBox As DateTimePicker
    Friend WithEvents SituaçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TécnicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeríodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservaçãoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DefeitoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataSet As DataSet
    Friend WithEvents AtendimentoBindingSource As BindingSource
    Friend WithEvents AtendimentoTableAdapter As DataSetTableAdapters.AtendimentoTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
End Class
