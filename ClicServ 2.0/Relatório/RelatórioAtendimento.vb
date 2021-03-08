Public Class RelatórioAtendimento
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\COMANDO INICIA O RELATÓRIO DE ATENDIMENTO COM TODOS OS REGISTROS////////////////////////////////
    Private Sub RelatórioAtendimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RelatórioAtendimentoTableAdapter.DTPData(Me.DataSet.RelatórioAtendimento, dtpAtendimento.Value.ToShortDateString())
        Me.rptAtendimento.RefreshReport()
    End Sub
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\FIM////////////////////////////////


    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\COMANDO PARA CARREGAR POR DATA O RELATÓRIO DE ATENDIMENTO////////////////////////////////
    Private Sub dtpAtendimento_ValueChanged(sender As Object, e As EventArgs) Handles dtpAtendimento.ValueChanged
        Me.RelatórioAtendimentoTableAdapter.DTPData(Me.DataSet.RelatórioAtendimento, dtpAtendimento.Value.ToShortDateString())
        Me.rptAtendimento.RefreshReport()
    End Sub

    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\FIM////////////////////////////////
End Class