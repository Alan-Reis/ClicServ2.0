Public Class PrimeiraOS
    Private Sub PrimeiraOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDTextBox.Clear()
        OSTextBox.Clear()
        ValorTextBox.Clear()
        DefeitoTextBox.Clear()
        RelatórioTextBox.Clear()
        TécnicoTextBox.Clear()
        ObservaçãoTextBox.Clear()
    End Sub
    Private Sub bSalvarOS_Click(sender As Object, e As EventArgs) Handles bSalvarOS.Click
        If IDTextBox.Text = "" Then
            MessageBox.Show("Insira um ID")
        ElseIf IDTextBox.Text Then
            Try
                Me.OSTableAdapter.OSInsertQuery(IDTextBox.Text, OSTextBox.Text, dtpData.Text, ValorTextBox.Text, DefeitoTextBox.Text, RelatórioTextBox.Text, TécnicoTextBox.Text, ObservaçãoTextBox.Text)
                Me.OSTableAdapter.usp_ConcultaDetalhar(Me.DataSet.OS, ID)
                MessageBox.Show("Ordem de serviço cadastrada com sucesso!")
                Close()
            Catch ex As Exception
                If MessageBox.Show("Ordem de serviço já cadastrada!", "*****ERRO*****") Then
                    Me.OSTextBox.Clear()
                    Me.OSTextBox.Focus()
                End If
            End Try
        End If
    End Sub

    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Detalhar.Show()
        Close()
    End Sub
End Class