Public Class PrimeiroAtendimento
    Private Sub PrimeiroAtendimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDTextBox.Clear()
        DefeitoTextBox.Clear()
        PeríodoTextBox.Clear()
        TécnicoTextBox.Clear()
        ObservaçãoTextBox.Clear()
    End Sub
    Private Sub bSalvarAtendimento_Click(sender As Object, e As EventArgs) Handles bSalvarAtendimento.Click
        If IDTextBox.Text = "" Then
            MessageBox.Show("Insira um ID")
        ElseIf IDTextBox.Text Then
            Try
                Me.AtendimentoTableAdapter.AtendimentoInsertQuery(IDTextBox.Text, DefeitoTextBox.Text, DataTextBox.Text, PeríodoTextBox.Text, TécnicoTextBox.Text, ObservaçãoTextBox.Text)
                Me.AtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.Atendimento, ID)
                MessageBox.Show("Atendimento cadastrado com sucesso!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Close()
            End Try
        End If
        Close()
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Detalhar.Show()
        Close()
    End Sub
End Class