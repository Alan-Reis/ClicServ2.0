Public Class Cadastro
    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CadastroTableAdapter.Fill(Me.DataSet.Cadastro)

        'TORNA AS TEXTBOX INACESSIVEIS
        IDTextBox.Enabled = False
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
        Nº_sérieTextBox.Enabled = False
        EmailTextBox.Enabled = False
        ComplementoTextBox.Enabled = False
        BairroTextBox.Enabled = False

        'COMPLEMENTOS
        bNovoCliente.Enabled = True
        bSalvarCliente.Enabled = False
        bEditarCliente.Enabled = True
        bAtualizarCliente.Enabled = False
        bExcluirCliente.Enabled = True
        txtBuscarCliente.Clear()
    End Sub
    Private Sub bNovoCliente_Click(sender As Object, e As EventArgs) Handles bNovoCliente.Click
        Me.CadastroBindingSource.AddNew()

        'TORNA AS TEXTBOX ACESSIVEIS
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
        Nº_sérieTextBox.Enabled = True
        EmailTextBox.Enabled = True
        ComplementoTextBox.Enabled = True
        BairroTextBox.Enabled = True
        'COMPLEMENTOS
        NomeTextBox.Focus()
        bSalvarCliente.Enabled = True
        bNovoCliente.Enabled = False
        bEditarCliente.Enabled = False
        bExcluirCliente.Enabled = False
    End Sub
    Private Sub bSalvarCliente_Click(sender As Object, e As EventArgs) Handles bSalvarCliente.Click
        Try
            CadastroTableAdapter.CadastroInsertQuery(NomeTextBox.Text, CPFTextBox.Text, EndereçoTextBox.Text, BairroTextBox.Text, CondomínioTextBox.Text, AptTextBox.Text, ComplementoTextBox.Text, TelefoneTextBox.Text, CelularTextBox.Text, EquipTextBox.Text, FabricanteTextBox.Text, ModeloTextBox.Text, Nº_sérieTextBox.Text, EmailTextBox.Text)
            CadastroTableAdapter.Fill(Me.DataSet.Cadastro)
            MessageBox.Show("Cliente cadastrado com sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
        Nº_sérieTextBox.Enabled = False
        bNovoCliente.Enabled = True
        EmailTextBox.Enabled = False
        ComplementoTextBox.Enabled = False
        BairroTextBox.Enabled = False
        'COMPLEMENTO
        bSalvarCliente.Enabled = False
        bEditarCliente.Enabled = True
        bExcluirCliente.Enabled = True

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
        Nº_sérieTextBox.Enabled = True
        EmailTextBox.Enabled = True
        ComplementoTextBox.Enabled = True
        BairroTextBox.Enabled = True
        'COMPLEMENTOS
        bSalvarCliente.Enabled = False
        bAtualizarCliente.Enabled = True
        bNovoCliente.Enabled = False
        bExcluirCliente.Enabled = False
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
        Nº_sérieTextBox.Enabled = False
        EmailTextBox.Enabled = False
        ComplementoTextBox.Enabled = False
        BairroTextBox.Enabled = False
        'COMPLEMENTOS
        bNovoCliente.Enabled = True
        bExcluirCliente.Enabled = True
        bEditarCliente.Enabled = True
        'ATUALIZA A TABELA
        Try
            CadastroTableAdapter.CadastroUpdateQuery(NomeTextBox.Text, CPFTextBox.Text, EndereçoTextBox.Text, BairroTextBox.Text, CondomínioTextBox.Text, AptTextBox.Text, ComplementoTextBox.Text, TelefoneTextBox.Text, CelularTextBox.Text, EmailTextBox.Text, EquipTextBox.Text, FabricanteTextBox.Text, ModeloTextBox.Text, Nº_sérieTextBox.Text, IDTextBox.Text)
            CadastroTableAdapter.Fill(Me.DataSet.Cadastro)
            MessageBox.Show("Alteração realizada com sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        bAtualizarCliente.Enabled = False
    End Sub

    Private Sub bExcluirCliente_Click(sender As Object, e As EventArgs) Handles bExcluirCliente.Click
        Dim msg As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "Deseja excluir cliente?"
        style = MsgBoxStyle.DefaultButton2 Or
   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        response = MsgBox(msg, style)
        If response = MsgBoxResult.Yes Then
            CadastroTableAdapter.CadastroDeleteQuery(IDTextBox.Text)
        Else
            response = MsgBoxResult.Abort
        End If

        Try
            Me.CadastroTableAdapter.Fill(Me.DataSet.Cadastro)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub bVoltar_Click(sender As Object, e As EventArgs) Handles bVoltar.Click
        Close()
    End Sub
    Private Sub bPesquisar_Click(sender As Object, e As EventArgs) Handles bPesquisar.Click
        'SISTEMA DE BUSCA POR NOME
        If cbNomeCondominio.SelectedItem = "ID" Then

            Try
                Me.CadastroTableAdapter.usp_ConsultaCliente(Me.DataSet.Cadastro, "%" + Me.txtBuscarCliente.Text + "%")
            Catch ex As Exception
            End Try

        ElseIf cbNomeCondominio.SelectedItem = "Nome" Then
            Try
                Me.CadastroTableAdapter.ups_ConsultaClienteNome(Me.DataSet.Cadastro, "%" + Me.txtBuscarCliente.Text + "%")
            Catch ex As Exception
            End Try

        Else
            Try
                Me.CadastroTableAdapter.usp_ConsultaClienteCondomínio(Me.DataSet.Cadastro, "%" + Me.txtBuscarCliente.Text + "%")
            Catch ex As Exception
            End Try

        End If
        txtBuscarCliente.Clear()
    End Sub
End Class