Imports System.Data.SqlClient
Public Class SQL
    Public Function Getconnection() As SqlConnection
        Try
            Dim con As New SqlConnection("server=TEMDEMNOU-PC\SQLEXPRESS;uid=sa;password=@IUC-PA2;database=BD_frost")
            con.Open()
            Return con
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
      
    End Function
End Class
