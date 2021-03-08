Public Class RelatórioAtendimentoCliente
    Private Sub RelatórioAtendimentoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RelatórioAtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.RelatórioAtendimento, ID)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class