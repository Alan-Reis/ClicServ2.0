Imports System.Data.OleDb

Module mdlAcesso
    Public ID As Integer
    Public Function Getconnection() As OleDbConnection
        Dim sql As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BDClicServ.accdb"
        Return New OleDbConnection(sql)
    End Function
End Module
