Imports System.Data.OleDb
Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregadados()
        PCarregadadosOS()
    End Sub

    Private Sub PCarregadadosOS()
        Using con As OleDbConnection = Getconnection()
            Try
                con.Open()
                Dim sql As String = "SELECT ID,OS FROM dbo_OS"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvOS.DataSource = dt
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PCarregadados()
        Using con As OleDbConnection = Getconnection()
            Try
                con.Open()
                Dim sql As String = "SELECT ID,Nome,Condomínio,Apt FROM dbo_Cadastro"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvCliente.DataSource = dt
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PPesquisarOS()
        Using con As OleDbConnection = Getconnection()
            Try
                con.Open()
                Dim sql As String = "SELECT ID,OS FROM dbo_OS WHERE OS LIKE '%" & txtPesquisar_OS.Text & "%'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvOS.DataSource = dt
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PPesquisar()
        Using con As OleDbConnection = Getconnection()
            Try
                con.Open()
                Dim sql As String = "SELECT ID,Nome,Condomínio,Apt FROM dbo_Cadastro WHERE Nome LIKE '%" & txtBuscar.Text & "%'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvCliente.DataSource = dt
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PPesquisarII()
        Using con As OleDbConnection = Getconnection()
            Try
                con.Open()
                Dim sql As String = "SELECT ID,Nome,Condomínio,Apt FROM dbo_Cadastro WHERE Condomínio LIKE '%" & txtBuscarII.Text & "%'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvCliente.DataSource = dt
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    '////////////////////////////////////RELATÓRIOS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

    Private Sub bRelatórioAtendimento_Click(sender As Object, e As EventArgs) Handles bRelatórioAtendimento.Click
        Me.Cursor = Cursors.WaitCursor
        ID = dgvCliente.CurrentRow().Cells(0).Value
        RelatórioAtendimento.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    '/////////////////////////////////BOTÕES\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Private Sub bCliente_Click(sender As Object, e As EventArgs) Handles bCliente.Click
        Cadastro.ShowDialog()
    End Sub
    Private Sub bDetalhar_Click(sender As Object, e As EventArgs) Handles bDetalhar.Click
        Me.Cursor = Cursors.WaitCursor
        ID = dgvCliente.CurrentRow().Cells(0).Value
        Detalhar.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub bSair_Click(sender As Object, e As EventArgs) Handles bSair.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "Deseja sair do sistema?"
        style = MsgBoxStyle.DefaultButton2 Or
   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "ClicServ 2.0"

        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            response = MsgBoxResult.Abort
        End If

    End Sub

    Private Sub bAtualizarLista_Click(sender As Object, e As EventArgs) Handles bAtualizarLista.Click
        PPesquisar()
    End Sub


    '/////////////////////////////////TEXTBOX\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            ID = dgvCliente.CurrentRow().Cells(0).Value
            Detalhar.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        PPesquisar()
    End Sub

    Private Sub txtBuscarII_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarII.TextChanged
        PPesquisarII()
    End Sub

    Private Sub txtBuscarII_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarII.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            ID = dgvCliente.CurrentRow().Cells(0).Value
            Detalhar.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub AtendimentoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
    End Sub

    Private Sub AtendimentoBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AtendimentoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)
    End Sub

    Private Sub txtPesquisar_OS_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisar_OS.TextChanged
        PPesquisarOS()
    End Sub

    Private Sub btn_DetalharOS_Click(sender As Object, e As EventArgs) Handles btn_DetalharOS.Click
        Me.Cursor = Cursors.WaitCursor
        ID = dgvOS.CurrentRow().Cells(0).Value
        Detalhar.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub
End Class
