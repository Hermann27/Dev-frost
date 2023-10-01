Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient
Public Class FrmAuthentification

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Dim sql As New SQL
    Dim cryp As New ClassCryptageMotPass
    Dim privileg As String = ""
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Using md5hash As MD5 = MD5.Create
            Dim hash As String = ClassCryptageMotPass.GetMd5Hash(md5hash, PasswordTextBox.Text)
            Try
                Dim Query As String = "select privilege from utilisateur where password='" & hash & "' and login='" & UsernameTextBox.Text & "'"
                Dim cmd As New SqlCommand(Query, sql.Getconnection)
                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader

                While reader.Read
                    privileg = reader("privilege").ToString
                End While
                If privileg = "Admin" Then
                    With MDIParent1

                        .Show()
                    End With
                    Me.Close()
                Else
                    With MDIParent1
                        .mnUser.Visible = False
                        .Show()
                    End With
                    Me.Close()
                End If
            Catch ex As Exception
            Finally
                sql.Getconnection.Close()
            End Try

        End Using


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
