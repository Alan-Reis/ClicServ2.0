<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RelatórioAtendimento
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelatórioAtendimento))
        Me.RelatórioAtendimentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New ClicServ_2._0.DataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpAtendimento = New System.Windows.Forms.DateTimePicker()
        Me.rptAtendimento = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RelatórioAtendimentoTableAdapter = New ClicServ_2._0.DataSetTableAdapters.RelatórioAtendimentoTableAdapter()
        CType(Me.RelatórioAtendimentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RelatórioAtendimentoBindingSource
        '
        Me.RelatórioAtendimentoBindingSource.DataMember = "RelatórioAtendimento"
        Me.RelatórioAtendimentoBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 29)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Selecione uma data:"
        '
        'dtpAtendimento
        '
        Me.dtpAtendimento.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAtendimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAtendimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAtendimento.Location = New System.Drawing.Point(250, 9)
        Me.dtpAtendimento.Name = "dtpAtendimento"
        Me.dtpAtendimento.Size = New System.Drawing.Size(130, 29)
        Me.dtpAtendimento.TabIndex = 71
        '
        'rptAtendimento
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.RelatórioAtendimentoBindingSource
        Me.rptAtendimento.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptAtendimento.LocalReport.ReportEmbeddedResource = "ClicServ_2._0.rptAtendimento.rdlc"
        Me.rptAtendimento.Location = New System.Drawing.Point(0, 41)
        Me.rptAtendimento.Name = "rptAtendimento"
        Me.rptAtendimento.ServerReport.BearerToken = Nothing
        Me.rptAtendimento.Size = New System.Drawing.Size(841, 607)
        Me.rptAtendimento.TabIndex = 73
        '
        'RelatórioAtendimentoTableAdapter
        '
        Me.RelatórioAtendimentoTableAdapter.ClearBeforeFill = True
        '
        'RelatórioAtendimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 651)
        Me.Controls.Add(Me.rptAtendimento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpAtendimento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(450, 60)
        Me.Name = "RelatórioAtendimento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Relatório Atendimento"
        CType(Me.RelatórioAtendimentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpAtendimento As DateTimePicker
    Friend WithEvents rptAtendimento As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RelatórioAtendimentoBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents RelatórioAtendimentoTableAdapter As DataSetTableAdapters.RelatórioAtendimentoTableAdapter
End Class
