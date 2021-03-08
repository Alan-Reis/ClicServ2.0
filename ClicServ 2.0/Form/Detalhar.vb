Public Class Detalhar

    '////////////////////////////////PEGA A ID SELECIONADO NO HOME\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Private Sub Detalhar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OSTableAdapter.usp_ConcultaDetalhar(Me.DataSet.OS, ID)
        Me.AtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.Atendimento, ID)
        Me.CadastroTableAdapter.usp_ConsultaCliente(Me.DataSet.Cadastro, ID)
    End Sub
    Private Sub bRelatórioOS_Click(sender As Object, e As EventArgs) Handles bRelatórioOS.Click
        If Me.OSTableAdapter.usp_ConcultaDetalhar(Me.DataSet.OS, ID) = 0 Then
            MessageBox.Show("Não existe Ordem de serviço!")
        ElseIf ID > 0 Then
            Me.Cursor = Cursors.WaitCursor
            ID = OSDataGridView.CurrentRow().Cells(0).Value
            RelatórioOS.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub bRelatórioAtendimento_Click(sender As Object, e As EventArgs) Handles bRelatórioAtendimento.Click
        If Me.AtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.Atendimento, ID) = 0 Then
            MessageBox.Show("Não existe atendimento!")
        ElseIf ID > 0 Then
            Me.Cursor = Cursors.WaitCursor
            ID = AtendimentoDataGridView.CurrentRow().Cells(0).Value
            RelatórioAtendimentoCliente.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    '/////////////////////O CAMANDO ABRIR O PRIMEIRO ATENDIMENTO SE NÃO TIVER ATENDIMENTO\\\\\\\\\\\\\\\
    '////////////////////CASO JÁ TENHA ELE ABRI O NOVO ATENDIMENTO\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Private Sub bAtenderCliente_Click(sender As Object, e As EventArgs) Handles bAtender.Click
        If Me.AtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.Atendimento, ID) = 0 Then
            Me.Cursor = Cursors.WaitCursor
            PrimeiroAtendimento.ShowDialog()
            Me.Cursor = Cursors.Default
        ElseIf ID > 0 Then
            Me.Cursor = Cursors.WaitCursor
            ID = AtendimentoDataGridView.CurrentRow().Cells(0).Value
            NovoAtendimento.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub bAtualizarLista_Click(sender As Object, e As EventArgs) Handles bAtualizarLista.Click
        Me.AtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.Atendimento, ID)
    End Sub

    Private Sub bAtualizarOS_Click(sender As Object, e As EventArgs) Handles bAtualizarOS.Click
        Me.OSTableAdapter.usp_ConcultaDetalhar(Me.DataSet.OS, ID)
    End Sub

    Private Sub bVoltar_Click(sender As Object, e As EventArgs) Handles bVoltar.Click
        Home.Show()
        Close()
    End Sub

    Private Sub bAddOS_Click(sender As Object, e As EventArgs) Handles bAddOS.Click
        If Me.OSTableAdapter.usp_ConcultaDetalhar(Me.DataSet.OS, ID) = 0 Then
            Me.Cursor = Cursors.WaitCursor
            PrimeiraOS.ShowDialog()
            Me.Cursor = Cursors.Default
        ElseIf ID > 0 Then
            Me.Cursor = Cursors.WaitCursor
            ID = OSDataGridView.CurrentRow().Cells(0).Value
            NovoOS.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub bRelatórioIndividual_Click(sender As Object, e As EventArgs) Handles bRelatórioIndividual.Click
        If Me.AtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.Atendimento, ID) = 0 Then
            MessageBox.Show("Não existe atendimento!")
        ElseIf ID > 0 Then
            Me.Cursor = Cursors.WaitCursor
            ID = AtendimentoDataGridView.CurrentRow().Cells(6).Value
            RelatórioIndividual.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub bEditarCliente_Click(sender As Object, e As EventArgs) Handles bEditarCliente.Click
        'TORNA OS TEXTBOX ACESSIVEIS
        NomeTextBox.Enabled = True
        CPFTextBox.Enabled = True
        EndereçoTextBox.Enabled = True
        CondomínioTextBox.Enabled = True
        AptTextBox.Enabled = True
        TelefoneTextBox.Enabled = True
        CelularTextBox.Enabled = True
        EquipTextBox.Enabled = True
        FabricanteTextBox.Enabled = True
        ModeloTextBox.Enabled = True
        SérieTextBox.Enabled = True
        EmailTextBox.Enabled = True
        ComplementoTextBox.Enabled = True
        BairroTextBox.Enabled = True
        'COMPLEMENTOS
        bAtualizarCliente.Enabled = True
        bEditarCliente.Enabled = False
    End Sub

    Private Sub bAtualizarCliente_Click(sender As Object, e As EventArgs) Handles bAtualizarCliente.Click
        'TORNA AS TEXTBOX INACESSIVEIS
        NomeTextBox.Enabled = False
        CPFTextBox.Enabled = False
        EndereçoTextBox.Enabled = False
        CondomínioTextBox.Enabled = False
        AptTextBox.Enabled = False
        TelefoneTextBox.Enabled = False
        CelularTextBox.Enabled = False
        EquipTextBox.Enabled = False
        FabricanteTextBox.Enabled = False
        ModeloTextBox.Enabled = False
        SérieTextBox.Enabled = False
        EmailTextBox.Enabled = False
        ComplementoTextBox.Enabled = False
        BairroTextBox.Enabled = False
        'COMPLEMENTOS
        bEditarCliente.Enabled = True
        Try
            CadastroTableAdapter.CadastroUpdateQuery(NomeTextBox.Text, CPFTextBox.Text, EndereçoTextBox.Text, BairroTextBox.Text, CondomínioTextBox.Text, AptTextBox.Text, ComplementoTextBox.Text, TelefoneTextBox.Text, CelularTextBox.Text, EmailTextBox.Text, EquipTextBox.Text, FabricanteTextBox.Text, ModeloTextBox.Text, SérieTextBox.Text, IDTextBox.Text)
            Me.AtendimentoTableAdapter.usp_ConsultaDetalharAtendimento(Me.DataSet.Atendimento, ID)
            MessageBox.Show("Alteração realizada com sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        bAtualizarCliente.Enabled = False

    End Sub
End Class