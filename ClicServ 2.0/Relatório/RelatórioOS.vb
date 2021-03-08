Public Class RelatórioOS
    Private Sub RelatórioOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RelatórioOSTableAdapter.usp_RelatórioOS(Me.DataSet.RelatórioOS, ID)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class