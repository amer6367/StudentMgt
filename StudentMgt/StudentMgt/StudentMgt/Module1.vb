Imports System.Data.OleDb
Module Module1

    Public con As New OleDbConnection

    Sub Main()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\StudentMgt\StudentMgt.mdb"
        Dim frmStudent As New frmStudent
        frmStudent.ShowDialog()
    End Sub

End Module
