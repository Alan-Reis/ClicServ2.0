Imports System.Data.OleDb
Public Class NovoAtendimento
    Private Sub NovoAtendimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.Atendimento, ID)

        DefeitoTextBox.Enabled = False
        DataTextBox.Enabled = False
        PeríodoTextBox.Enabled = False
        TécnicoTextBox.Enabled = False
        ObservaçãoTextBox.Enabled = False
        ProtocoloTextBox.Enabled = False

        'COMPLEMENTOS
        IDTextBox.Focus()
        bNovoAtendimento.Enabled = True
        bSalvarAtendimento.Enabled = False
        bEditarAtendimento.Enabled = True
        bAtualizarAtendimento.Enabled = False
        bExcluirAtendimento.Enabled = True
    End Sub

    Private Sub bNovoCAtendimento_Click(sender As Object, e As EventArgs) Handles bNovoAtendimento.Click

        'TORNA AS TEXTBOX ACESSIVEIS
        DefeitoTextBox.Enabled = True
        DataTextBox.Enabled = True
        PeríodoTextBox.Enabled = True
        TécnicoTextBox.Enabled = True
        ObservaçãoTextBox.Enabled = True
        ProtocoloTextBox.Enabled = False
        'LIMPAR
        DefeitoTextBox.Clear()
        PeríodoTextBox.Clear()
        TécnicoTextBox.Clear()
        ObservaçãoTextBox.Clear()


        'COMPLEMENTOS
        IDTextBox.Focus()
        bSalvarAtendimento.Enabled = True
        bNovoAtendimento.Enabled = False
        bEditarAtendimento.Enabled = False
        bExcluirAtendimento.Enabled = False

        '///////////////COMANDO PARA AO CLICAR DEIXAR O DateTimePicker ATUALIZADO COM A DATA DO DIA\\\\\\\\\\\\\\\\\\\\
        DataTextBox.Value = DateTime.Now.Date

    End Sub
    Private Sub bSalvarAtendimento_Click(sender As Object, e As EventArgs) Handles bSalvarAtendimento.Click
        Try
            Me.AtendimentoTableAdapter.AtendimentoInsertQuery(IDTextBox.Text, DefeitoTextBox.Text, DataTextBox.Text, PeríodoTextBox.Text, TécnicoTextBox.Text, ObservaçãoTextBox.Text)
            Me.AtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.Atendimento, ID)
            MessageBox.Show("Atendimento cadastrado com sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        IDTextBox.Enabled = False
        DefeitoTextBox.Enabled = False
        DataTextBox.Enabled = False
        PeríodoTextBox.Enabled = False
        TécnicoTextBox.Enabled = False
        ObservaçãoTextBox.Enabled = False
        ProtocoloTextBox.Enabled = False

        'COMPLEMENTO
        bSalvarAtendimento.Enabled = False
        bEditarAtendimento.Enabled = True
        bExcluirAtendimento.Enabled = True
        bNovoAtendimento.Enabled = True
    End Sub
    Private Sub bEditarAtendimento_Click(sender As Object, e As EventArgs) Handles bEditarAtendimento.Click
        'TORNA OS TEXTBOX ACESSIVEIS
        IDTextBox.Enabled = False
        DefeitoTextBox.Enabled = True
        DataTextBox.Enabled = True
        PeríodoTextBox.Enabled = True
        TécnicoTextBox.Enabled = True
        ObservaçãoTextBox.Enabled = True
        ProtocoloTextBox.Enabled = False

        'COMPLEMENTOS
        bSalvarAtendimento.Enabled = False
        bAtualizarAtendimento.Enabled = True
        bNovoAtendimento.Enabled = False
        bExcluirAtendimento.Enabled = False
        bEditarAtendimento.Enabled = False
    End Sub

    Private Sub bAtualizarAtendimento_Click(sender As Object, e As EventArgs) Handles bAtualizarAtendimento.Click
        'TORNA AS TEXTBOX INACESSIVEIS
        IDTextBox.Enabled = False
        DefeitoTextBox.Enabled = False
        DataTextBox.Enabled = False
        PeríodoTextBox.Enabled = False
        TécnicoTextBox.Enabled = False
        ObservaçãoTextBox.Enabled = False
        ProtocoloTextBox.Enabled = False


        'COMPLEMENTOS
        bNovoAtendimento.Enabled = True
        bExcluirAtendimento.Enabled = True
        bEditarAtendimento.Enabled = True
        bAtualizarAtendimento.Enabled = False
        'ATUALIZA A TABELA
        Try
            AtendimentoTableAdapter.AtendimentoUpdateQuery(DefeitoTextBox.Text, DataTextBox.Text, PeríodoTextBox.Text, TécnicoTextBox.Text, ObservaçãoTextBox.Text, ProtocoloTextBox.Text)
            AtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.Atendimento, ID)
            MessageBox.Show("Alteração realizada com sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bExcluirAtendimento_Click(sender As Object, e As EventArgs) Handles bExcluirAtendimento.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "Deseja excluir atendimento?"
        style = MsgBoxStyle.DefaultButton2 Or
   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "ClicServ 2.0"
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then
            AtendimentoTableAdapter.AtendimentoDeleteQuery(ProtocoloTextBox.Text)
        Else
            response = MsgBoxResult.Abort
        End If

        Try
            Me.AtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.Atendimento, ID)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub bCancelarAtendimento_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub
    Private Sub dtpData_ValueChanged(sender As Object, e As EventArgs) Handles dtpData.ValueChanged
        Me.AtendimentoTableAdapter.usp_ConsultaData(Me.DataSet.Atendimento, dtpData.Value.ToShortDateString())
        Me.AtendimentoDataGridView.Refresh()
    End Sub
End Class