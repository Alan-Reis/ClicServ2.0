<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscarII = New System.Windows.Forms.TextBox()
        Me.bAtualizarLista = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.bDetalhar = New System.Windows.Forms.Button()
        Me.bRelatórioAtendimento = New System.Windows.Forms.Button()
        Me.bSair = New System.Windows.Forms.Button()
        Me.bCliente = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AtendimentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New ClicServ_2._0.DataSet()
        Me.AtendimentoTableAdapter = New ClicServ_2._0.DataSetTableAdapters.AtendimentoTableAdapter()
        Me.TableAdapterManager = New ClicServ_2._0.DataSetTableAdapters.TableAdapterManager()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtPesquisar_OS = New System.Windows.Forms.TextBox()
        Me.dgvOS = New System.Windows.Forms.DataGridView()
        Me.btn_DetalharOS = New System.Windows.Forms.Button()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtendimentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarII
        '
        Me.txtBuscarII.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarII.Location = New System.Drawing.Point(152, 217)
        Me.txtBuscarII.Name = "txtBuscarII"
        Me.txtBuscarII.Size = New System.Drawing.Size(123, 26)
        Me.txtBuscarII.TabIndex = 71
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
        Me.bAtualizarLista.Location = New System.Drawing.Point(349, 165)
        Me.bAtualizarLista.Name = "bAtualizarLista"
        Me.bAtualizarLista.Size = New System.Drawing.Size(98, 88)
        Me.bAtualizarLista.TabIndex = 75
        Me.bAtualizarLista.Text = "Atualizar Lista"
        Me.bAtualizarLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bAtualizarLista.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(152, 174)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(84, 26)
        Me.txtBuscar.TabIndex = 70
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(6, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(441, 47)
        Me.TextBox1.TabIndex = 73
        Me.TextBox1.Text = "Clientes"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCliente.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCliente.Location = New System.Drawing.Point(6, 259)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.Size = New System.Drawing.Size(441, 226)
        Me.dgvCliente.TabIndex = 72
        '
        'bDetalhar
        '
        Me.bDetalhar.BackColor = System.Drawing.Color.Transparent
        Me.bDetalhar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bDetalhar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bDetalhar.FlatAppearance.BorderSize = 0
        Me.bDetalhar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bDetalhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDetalhar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDetalhar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bDetalhar.Image = CType(resources.GetObject("bDetalhar.Image"), System.Drawing.Image)
        Me.bDetalhar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bDetalhar.Location = New System.Drawing.Point(89, 12)
        Me.bDetalhar.Name = "bDetalhar"
        Me.bDetalhar.Size = New System.Drawing.Size(98, 88)
        Me.bDetalhar.TabIndex = 81
        Me.bDetalhar.Text = "Detalhar"
        Me.bDetalhar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bDetalhar.UseVisualStyleBackColor = False
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
        Me.bRelatórioAtendimento.Location = New System.Drawing.Point(193, 12)
        Me.bRelatórioAtendimento.Name = "bRelatórioAtendimento"
        Me.bRelatórioAtendimento.Size = New System.Drawing.Size(93, 88)
        Me.bRelatórioAtendimento.TabIndex = 80
        Me.bRelatórioAtendimento.Text = "Relatório Atendimento"
        Me.bRelatórioAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bRelatórioAtendimento.UseVisualStyleBackColor = False
        '
        'bSair
        '
        Me.bSair.BackColor = System.Drawing.Color.Transparent
        Me.bSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bSair.FlatAppearance.BorderSize = 0
        Me.bSair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bSair.Image = Global.ClicServ_2._0.My.Resources.Resources.sair
        Me.bSair.Location = New System.Drawing.Point(292, 12)
        Me.bSair.Name = "bSair"
        Me.bSair.Size = New System.Drawing.Size(93, 88)
        Me.bSair.TabIndex = 79
        Me.bSair.Text = "Sair"
        Me.bSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bSair.UseVisualStyleBackColor = False
        '
        'bCliente
        '
        Me.bCliente.BackColor = System.Drawing.Color.Transparent
        Me.bCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bCliente.FlatAppearance.BorderSize = 0
        Me.bCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bCliente.Image = CType(resources.GetObject("bCliente.Image"), System.Drawing.Image)
        Me.bCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bCliente.Location = New System.Drawing.Point(6, 17)
        Me.bCliente.Name = "bCliente"
        Me.bCliente.Size = New System.Drawing.Size(93, 81)
        Me.bCliente.TabIndex = 78
        Me.bCliente.Text = "Cliente"
        Me.bCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bCliente.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox2.Location = New System.Drawing.Point(6, 217)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(140, 26)
        Me.TextBox2.TabIndex = 82
        Me.TextBox2.Text = "Condomínio"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox3.Location = New System.Drawing.Point(6, 174)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(140, 26)
        Me.TextBox3.TabIndex = 83
        Me.TextBox3.Text = "Nome"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(469, 179)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(839, 384)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
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
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextBox4.Location = New System.Drawing.Point(6, 491)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(93, 26)
        Me.TextBox4.TabIndex = 86
        Me.TextBox4.Text = "O.S"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPesquisar_OS
        '
        Me.txtPesquisar_OS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisar_OS.Location = New System.Drawing.Point(105, 491)
        Me.txtPesquisar_OS.Name = "txtPesquisar_OS"
        Me.txtPesquisar_OS.Size = New System.Drawing.Size(84, 26)
        Me.txtPesquisar_OS.TabIndex = 85
        '
        'dgvOS
        '
        Me.dgvOS.AllowUserToAddRows = False
        Me.dgvOS.AllowUserToDeleteRows = False
        Me.dgvOS.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOS.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvOS.Location = New System.Drawing.Point(6, 523)
        Me.dgvOS.Name = "dgvOS"
        Me.dgvOS.ReadOnly = True
        Me.dgvOS.Size = New System.Drawing.Size(230, 158)
        Me.dgvOS.TabIndex = 87
        '
        'btn_DetalharOS
        '
        Me.btn_DetalharOS.BackColor = System.Drawing.Color.Transparent
        Me.btn_DetalharOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_DetalharOS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_DetalharOS.FlatAppearance.BorderSize = 0
        Me.btn_DetalharOS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_DetalharOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DetalharOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DetalharOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_DetalharOS.Image = CType(resources.GetObject("btn_DetalharOS.Image"), System.Drawing.Image)
        Me.btn_DetalharOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_DetalharOS.Location = New System.Drawing.Point(242, 523)
        Me.btn_DetalharOS.Name = "btn_DetalharOS"
        Me.btn_DetalharOS.Size = New System.Drawing.Size(98, 88)
        Me.btn_DetalharOS.TabIndex = 88
        Me.btn_DetalharOS.Text = "Detalhar"
        Me.btn_DetalharOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_DetalharOS.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 691)
        Me.Controls.Add(Me.btn_DetalharOS)
        Me.Controls.Add(Me.dgvOS)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtPesquisar_OS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.bDetalhar)
        Me.Controls.Add(Me.bRelatórioAtendimento)
        Me.Controls.Add(Me.bSair)
        Me.Controls.Add(Me.bCliente)
        Me.Controls.Add(Me.txtBuscarII)
        Me.Controls.Add(Me.bAtualizarLista)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClicServ 2.0"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtendimentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscarII As TextBox
    Friend WithEvents bAtualizarLista As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvCliente As DataGridView
    Friend WithEvents bDetalhar As Button
    Friend WithEvents bRelatórioAtendimento As Button
    Friend WithEvents bSair As Button
    Friend WithEvents bCliente As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataSet As DataSet
    Friend WithEvents AtendimentoBindingSource As BindingSource
    Friend WithEvents AtendimentoTableAdapter As DataSetTableAdapters.AtendimentoTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtPesquisar_OS As TextBox
    Friend WithEvents dgvOS As DataGridView
    Friend WithEvents btn_DetalharOS As Button
End Class
