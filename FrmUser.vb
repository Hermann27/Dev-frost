Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class FrmUser
    Dim sql As New SQL
    Dim cryp As New ClassCryptageMotPass

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtNom.Text = "" And txtPrenom.Text = "" And txtCNI.Text = "" And txtLog.Text = "" And txtPass.Text = "" And CmbPriv.SelectedItem = "" And CmbEntrep.SelectedItem = "" Then
            MsgBox("veuillez Renseigner l'Element a enregistrer SVP....", MsgBoxStyle.Information, "Infos Modification")
        Else
            Try
                Using md5hash As MD5 = MD5.Create
                    Dim hash As String = GetMd5Hash(md5hash, txtPass.Text)
                    'MsgBox(id.ToString)
                    Dim Query As String = "insert into utilisateur(nomUser,prenomUser,CNI,login,password,privilege,ID_entreprise) values ('" & txtNom.Text & "','" & txtPrenom.Text & "'," & txtCNI.Text & ",'" & txtLog.Text & "','" & hash & "','" & CmbPriv.SelectedItem & "'," & id & ") "

                    MsgBox(Query)
                    Dim cmd As New SqlCommand(Query, sql.Getconnection())
                    cmd.ExecuteNonQuery()
                    MsgBox("Enregistrement Effectué ! ", MsgBoxStyle.Information, "Infos Utilisateur")
                    Affichageserveur()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                sql.Getconnection.Close()
            End Try
        End If

    End Sub
    Shared Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String

        ' Convert the input string to a byte array and compute the hash. 
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes 
        ' and create a string. 
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data  
        ' and format each one as a hexadecimal string. 
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string. 
        Return sBuilder.ToString()

    End Function 'GetMd5Hash


    ' Verify a hash against a string. 
    Shared Function VerifyMd5Hash(ByVal md5Hash As MD5, ByVal input As String, ByVal hash As String) As Boolean
        ' Hash the input. 
        Dim hashOfInput As String = GetMd5Hash(md5Hash, input)

        ' Create a StringComparer an compare the hashes. 
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase

        If 0 = comparer.Compare(hashOfInput, hash) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub FrmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String = "select nomEntreprise from entreprise"
        Dim cmd As New SqlCommand(query, sql.Getconnection)
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            CmbEntrep.Items.Add(reader("nomEntreprise").ToString)

        End While
        LBL.Visible = False
        txtnumero.Visible = False
        Affichageserveur()
        sql.Getconnection.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Dim id As Integer

    Private Sub CmbEntrep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbEntrep.SelectedIndexChanged
        Dim Query As String = "select ID from entreprise where nomEntreprise='" & CmbEntrep.SelectedItem & "'"
        Dim cmd As New SqlCommand(Query, sql.Getconnection)
        Dim read As SqlDataReader = cmd.ExecuteReader
        While read.Read
            id = read("ID")
        End While
        sql.Getconnection.Close()
    End Sub

    Private Sub Affichageserveur()
        Dim OleAfficheAdapt As SqlDataAdapter
        Dim AfficheDs As New DataSet
        Dim AfficheTab As DataTable
        DGV.Rows.Clear()
        Try
            OleAfficheAdapt = New SqlDataAdapter("Select u.ID, u.nomUser,u.prenomUser,u.CNI,u.login,u.password,u.privilege,e.nomEntreprise From  utilisateur u,entreprise e ", sql.Getconnection)
            OleAfficheAdapt.Fill(AfficheDs)
            AfficheTab = AfficheDs.Tables(0)
            If AfficheTab.Rows.Count <> 0 Then
                DGV.RowCount = AfficheTab.Rows.Count
                For i As Integer = 0 To AfficheTab.Rows.Count - 1
                    DGV.Rows(i).Cells("IDU").Value = AfficheTab.Rows(i).Item("ID")
                    DGV.Rows(i).Cells("Nom").Value = AfficheTab.Rows(i).Item("nomUser")
                    DGV.Rows(i).Cells("Prenom").Value = AfficheTab.Rows(i).Item("prenomUser")
                    DGV.Rows(i).Cells("CNI").Value = AfficheTab.Rows(i).Item("CNI")
                    DGV.Rows(i).Cells("Login").Value = AfficheTab.Rows(i).Item("login")
                    DGV.Rows(i).Cells("Password").Value = AfficheTab.Rows(i).Item("password")
                    DGV.Rows(i).Cells("Privilege").Value = AfficheTab.Rows(i).Item("privilege")
                    DGV.Rows(i).Cells("Entreprise").Value = AfficheTab.Rows(i).Item("nomEntreprise")
                    DGV.Rows(i).Cells("Supprimer").Value = False
                Next
            Else
                DGV.DataSource = AfficheDs
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If txtNom.Text = "" And txtPrenom.Text = "" And txtCNI.Text = "" And txtLog.Text = "" And txtPass.Text = "" And CmbPriv.SelectedItem = "" And CmbEntrep.SelectedItem = "" Then
            MsgBox("veuillez Renseigner l'Element a modifier SVP....", MsgBoxStyle.Information, "Infos Modification")
        Else
            Modifierserveur()
        End If
    End Sub

    Private Sub Modifierserveur()
        Dim OleCreationAdapt As SqlDataAdapter
        Dim CreationDs As DataSet
        Dim CreationTab As DataTable
        Dim OleCommandEnreg As SqlCommand
        Dim Insert As Boolean = False
        Dim Insertion As String

        Using md5hash As MD5 = MD5.Create
            Try

                Dim hash As String = GetMd5Hash(md5hash, txtPass.Text)
                For i As Integer = 0 To DGV.RowCount - 1
                    OleCreationAdapt = New SqlDataAdapter("Select * From utilisateur  WHERE ID=" & Trim(DGV.Rows(i).Cells("IDU").Value) & "", sql.Getconnection)
                    CreationDs = New DataSet
                    OleCreationAdapt.Fill(CreationDs)
                    CreationTab = CreationDs.Tables(0)
                    If CreationTab.Rows.Count <> 0 Then
                        Insertion = "Update utilisateur SET nomUser='" & Join(Split(Trim(txtNom.Text), "'"), "''") & "',prenomUser='" & Join(Split(Trim(txtPrenom.Text), "'"), "''") & "',CNI=" & Join(Split(Trim(txtCNI.Text), "'"), "''") & ", login='" & Join(Split(Trim(txtLog.Text), "'"), "''") & "',password='" & Join(Split(Trim(hash), "'"), "''") & "', privilege='" & Join(Split(Trim(CmbPriv.SelectedItem), "'"), "''") & "',ID_entreprise=" & Join(Split(Trim(id), "'"), "''") & "  WHERE ID=" & Join(Split(Trim(txtnumero.Text), "'"), "''") & ""
                        OleCommandEnreg = New SqlCommand(Insertion, sql.Getconnection())
                        OleCommandEnreg.ExecuteNonQuery()
                        Insert = True
                    End If
                Next i
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            If Insert = True Then
                MsgBox("Modification Reussie", MsgBoxStyle.Information, "Modification Table Serveur")
            End If
            Affichageserveur()
            sql.Getconnection.Close()
        End Using
    End Sub

    Private Sub DGV_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            txtnumero.Enabled = False
            txtnumero.Text = DGV.SelectedRows(0).Cells(0).Value
            txtNom.Text = DGV.SelectedRows(0).Cells(1).Value
            txtPrenom.Text = DGV.SelectedRows(0).Cells(2).Value
            txtCNI.Text = DGV.SelectedRows(0).Cells(3).Value
            txtLog.Text = DGV.SelectedRows(0).Cells(4).Value
            txtPass.Text = DGV.SelectedRows(0).Cells(5).Value
            CmbPriv.SelectedItem = DGV.SelectedRows(0).Cells(6).Value
            CmbEntrep.SelectedItem = DGV.SelectedRows(0).Cells(7).Value
        End If
    End Sub

    Private Sub Supprimerdonneserveur()
        Try
            Dim OleCreationAdapt As SqlDataAdapter
            Dim CreationDs As DataSet
            Dim CreationTab As DataTable
            Dim OleCommandEnreg As SqlCommand
            Dim Insert As Boolean = False
            Dim Insertion As String
            For i As Integer = 0 To DGV.RowCount - 1
                If DGV.Rows(i).Cells("Supprimer").Value = True Then
                    OleCreationAdapt = New SqlDataAdapter("Select * From utilisateur  WHERE ID=" & Trim(DGV.Rows(i).Cells("IDU").Value) & "", sql.Getconnection)
                    CreationDs = New DataSet
                    OleCreationAdapt.Fill(CreationDs)
                    CreationTab = CreationDs.Tables(0)
                    If CreationTab.Rows.Count <> 0 Then
                        Insertion = "Delete From utilisateur WHERE ID=" & Join(Split(Trim(DGV.Rows(i).Cells("IDU").Value), "'"), "''") & ""
                        OleCommandEnreg = New SqlCommand(Insertion, sql.Getconnection())
                        OleCommandEnreg.ExecuteNonQuery()
                        Insert = True
                    End If
                End If
            Next i
            If Insert = True Then
                MsgBox("Suppression Reussie", MsgBoxStyle.Information, "Suppression Entreprise")
            Else
                MsgBox(" Selectionner l'Element a Supprimer SVP...", MsgBoxStyle.Information, "Infos Suppression")
            End If
            Affichageserveur()
            sql.Getconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        Supprimerdonneserveur()
    End Sub

End Class
