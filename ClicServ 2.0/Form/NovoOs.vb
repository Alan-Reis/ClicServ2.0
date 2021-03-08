Imports System.Data.OleDb
Public Class NovoOS

    Private Sub NovoOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OSTableAdapter.usp_ConcultaDetalhar(Me.DataSet.OS, ID)

        'TORNA AS TEXTBOX INACESSIVEIS
        IDTextBox.Enabled = False
        OSTextBox.Enabled = False
        dtpData.Enabled = False
        ValorTextBox.Enabled = False
        DefeitoTextBox.Enabled = False
        RelatórioTextBox.Enabled = False
        TécnicoTextBox.Enabled = False
        ObservaçãoTextBox.Enabled = False
        'COMPLEMENTOS
        bNovoOS.Enabled = True
        bSalvarOS.Enabled = False
        bEditarOS.Enabled = True
        bAtualizarOS.Enabled = False
        bExcluirOS.Enabled = True
    End Sub
    Private Sub bNovoCliente_Click(sender As Object, e As EventArgs) Handles bNovoOS.Click
        'TORNA AS TEXTBOX ACESSIVEIS
        OSTextBox.Enabled = True
        dtpData.Enabled = True
        ValorTextBox.Enabled = True
        DefeitoTextBox.Enabled = True
        RelatórioTextBox.Enabled = True
        TécnicoTextBox.Enabled = True
        ObservaçãoTextBox.Enabled = True

        'LIMPA OS CAMPOS
        OSTextBox.Clear()
        ValorTextBox.Clear()
        DefeitoTextBox.Clear()
        RelatórioTextBox.Clear()
        TécnicoTextBox.Clear()
        ObservaçãoTextBox.Clear()
        'COMPLEMENTOS
        OSTextBox.Focus()
        bSalvarOS.Enabled = True
        bNovoOS.Enabled = False
        bEditarOS.Enabled = False
        bExcluirOS.Enabled = False
        '///////////////COMANDO PARA AO CLICAR DEIXAR O DateTimePicker ATUALIZADO COM A DATA DO DIA\\\\\\\\\\\\\\\\\\\\
        dtpData.Value = DateTime.Now.Date

    End Sub
    Private Sub bSalvarOS_Click(sender As Object, e As EventArgs) Handles bSalvarOS.Click
        Try
            Me.OSTableAdapter.OSInsertQuery(IDTextBox.Text, OSTextBox.Text, dtpData.Text, ValorTextBox.Text, DefeitoTextBox.Text, RelatórioTextBox.Text, TécnicoTextBox.Text, ObservaçãoTextBox.Text)
            Me.OSTableAdapter.usp_ConcultaDetalhar(Me.DataSet.OS, ID)
            MessageBox.Show("Ordem de serviço cadastrada com sucesso!")
        Catch ex As Exception
            If MessageBox.Show("Ordem de serviço já cadastrada!", "*****ERRO*****") Then
                Me.OSTextBox.Clear()
                Me.OSTextBox.Focus()
            End If
        End Try


        'TORNA AS TEXTBOX INACESSIVEIS
        IDTextBox.Enabled = False
        OSTextBox.Enabled = False
        dtpData.Enabled = False
        ValorTextBox.Enabled = False
        DefeitoTextBox.Enabled = False
        RelatórioTextBox.Enabled = False
        TécnicoTextBox.Enabled = False
        ObservaçãoTextBox.Enabled = False

        'COMPLEMENTO
        bSalvarOS.Enabled = False
        bEditarOS.Enabled = True
        bExcluirOS.Enabled = True
        bNovoOS.Enabled = True
    End Sub

    Private Sub bEditarOS_Click(sender As Object, e As EventArgs) Handles bEditarOS.Click
        'TORNA OS TEXTBOX ACESSIVEIS
        IDTextBox.Enabled = False
        OSTextBox.Enabled = False
        dtpData.Enabled = True
        ValorTextBox.Enabled = True
        DefeitoTextBox.Enabled = True
        RelatórioTextBox.Enabled = True
        TécnicoTextBox.Enabled = True
        ObservaçãoTextBox.Enabled = True

        'COMPLEMENTOS
        bSalvarOS.Enabled = False
        bAtualizarOS.Enabled = True
        bNovoOS.Enabled = False
        bExcluirOS.Enabled = False
        bEditarOS.Enabled = False
    End Sub

    Private Sub bAtualizarOS_Click(sender As Object, e As EventArgs) Handles bAtualizarOS.Click
        'TORNA AS TEXTBOX INACESSIVEIS
        IDTextBox.Enabled = False
        OSTextBox.Enabled = False
        dtpData.Enabled = False
        ValorTextBox.Enabled = False
        DefeitoTextBox.Enabled = False
        RelatórioTextBox.Enabled = False
        TécnicoTextBox.Enabled = False
        ObservaçãoTextBox.Enabled = False

        'COMPLEMENTOS
        bNovoOS.Enabled = True
        bExcluirOS.Enabled = True
        bEditarOS.Enabled = True
        bAtualizarOS.Enabled = False
        'ATUALIZA A TABELA
        Try
            OSTableAdapter.OSUpdateQuery(dtpData.Text, ValorTextBox.Text, DefeitoTextBox.Text, RelatórioTextBox.Text, TécnicoTextBox.Text, ObservaçãoTextBox.Text, OSTextBox.Text)
            OSTableAdapter.usp_ConcultaDetalhar(DataSet.OS, ID)
            MessageBox.Show("Ordem de serviço atualizada com sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Close()
    End Sub

    Private Sub bExcluirOS_Click(sender As Object, e As EventArgs) Handles bExcluirOS.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "Deseja excluir a ordem de serviço?"
        style = MsgBoxStyle.DefaultButton2 Or
   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "ClicServ 2.0"
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then
            OSTableAdapter.OSDeleteQuery(OSTextBox.Text)
        Else
            response = MsgBoxResult.Abort
        End If

        Try
            Me.OSTableAdapter.usp_ConcultaDetalhar(Me.DataSet.OS, ID)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class