Public Class RelatórioIndividual
    Private Sub RelatórioIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RelatórioAtendimentoTableAdapter.usp_ConsultaAtendimentoIndividual(Me.DataSet.RelatórioAtendimento, ID)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class