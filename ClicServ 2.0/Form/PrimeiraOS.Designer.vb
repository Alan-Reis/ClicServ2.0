<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrimeiraOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrimeiraOS))
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.OSTextBox = New System.Windows.Forms.TextBox()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.DefeitoTextBox = New System.Windows.Forms.TextBox()
        Me.RelatórioTextBox = New System.Windows.Forms.TextBox()
        Me.ObservaçãoTextBox = New System.Windows.Forms.TextBox()
        Me.TécnicoTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bSalvarOS = New System.Windows.Forms.Button()
        Me.DataSet = New ClicServ_2._0.DataSet()
        Me.OSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OSTableAdapter = New ClicServ_2._0.DataSetTableAdapters.OSTableAdapter()
        Me.TableAdapterManager = New ClicServ_2._0.DataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        OSLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        DefeitoLabel = New System.Windows.Forms.Label()
        RelatórioLabel = New System.Windows.Forms.Label()
        TécnicoLabel = New System.Windows.Forms.Label()
        ObservaçãoLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.bCancelar.Location = New System.Drawing.Point(79, 294)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(93, 81)
        Me.bCancelar.TabIndex = 75
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(-15, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(622, 47)
        Me.TextBox1.TabIndex = 73
        Me.TextBox1.Text = "Ordem de Serviço"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(97, 4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(61, 22)
        Me.IDTextBox.TabIndex = 1
        '
        'OSTextBox
        '
        Me.OSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSTextBox.Location = New System.Drawing.Point(97, 33)
        Me.OSTextBox.Name = "OSTextBox"
        Me.OSTextBox.Size = New System.Drawing.Size(61, 22)
        Me.OSTextBox.TabIndex = 2
        '
        'dtpData
        '
        Me.dtpData.Location = New System.Drawing.Point(97, 62)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(211, 20)
        Me.dtpData.TabIndex = 3
        '
        'ValorTextBox
        '
        Me.ValorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorTextBox.Location = New System.Drawing.Point(97, 89)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(109, 22)
        Me.ValorTextBox.TabIndex = 4
        '
        'DefeitoTextBox
        '
        Me.DefeitoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefeitoTextBox.Location = New System.Drawing.Point(97, 118)
        Me.DefeitoTextBox.Name = "DefeitoTextBox"
        Me.DefeitoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DefeitoTextBox.TabIndex = 5
        '
        'RelatórioTextBox
        '
        Me.RelatórioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RelatórioTextBox.Location = New System.Drawing.Point(97, 147)
        Me.RelatórioTextBox.Name = "RelatórioTextBox"
        Me.RelatórioTextBox.Size = New System.Drawing.Size(475, 22)
        Me.RelatórioTextBox.TabIndex = 6
        '
        'ObservaçãoTextBox
        '
        Me.ObservaçãoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservaçãoTextBox.Location = New System.Drawing.Point(97, 205)
        Me.ObservaçãoTextBox.Name = "ObservaçãoTextBox"
        Me.ObservaçãoTextBox.Size = New System.Drawing.Size(475, 22)
        Me.ObservaçãoTextBox.TabIndex = 8
        '
        'TécnicoTextBox
        '
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 53)
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
        Me.TableLayoutPanel1.TabIndex = 74
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OS"
        Me.DataGridViewTextBoxColumn2.HeaderText = "OS"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Data"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Valor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Defeito"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Defeito"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Relatório"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Relatório"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Técnico"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Técnico"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Observação"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Observação"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
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
        Me.bSalvarOS.Location = New System.Drawing.Point(-8, 294)
        Me.bSalvarOS.Name = "bSalvarOS"
        Me.bSalvarOS.Size = New System.Drawing.Size(93, 81)
        Me.bSalvarOS.TabIndex = 72
        Me.bSalvarOS.Text = "Salvar"
        Me.bSalvarOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bSalvarOS.UseVisualStyleBackColor = False
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OSBindingSource
        '
        Me.OSBindingSource.DataMember = "OS"
        Me.OSBindingSource.DataSource = Me.DataSet
        '
        'OSTableAdapter
        '
        Me.OSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AtendimentoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CadastroTableAdapter = Nothing
        Me.TableAdapterManager.OSTableAdapter = Me.OSTableAdapter
        Me.TableAdapterManager.UpdateOrder = ClicServ_2._0.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrimeiraOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClicServ_2._0.My.Resources.Resources.Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(607, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.bSalvarOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PrimeiraOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bCancelar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents OSTextBox As TextBox
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents ValorTextBox As TextBox
    Friend WithEvents DefeitoTextBox As TextBox
    Friend WithEvents RelatórioTextBox As TextBox
    Friend WithEvents ObservaçãoTextBox As TextBox
    Friend WithEvents TécnicoTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents bSalvarOS As Button
    Friend WithEvents DataSet As DataSet
    Friend WithEvents OSBindingSource As BindingSource
    Friend WithEvents OSTableAdapter As DataSetTableAdapters.OSTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
End Class
