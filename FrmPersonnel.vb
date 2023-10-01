Imports System.Data.SqlClient
Public Class FrmPersonnel
    Dim sql As New SQL

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtNom.Text = "" And CmbSoc.SelectedItem = "" Then
            MsgBox("veuillez Renseigner l'Element a enregistrer SVP....", MsgBoxStyle.Information, "Infos Enregistrement")
        Else
            Try
                Dim Query As String = "insert into personnel(nom,prenom,poste,email,telPers,ID_societe) values ('" & txtNom.Text & "','" & txtPrenom.Text & "','" & txtPost.Text & "','" & txtEmail.Text & "'," & txtTel.Text & "," & id & ") "

                MsgBox(Query)
                Dim cmd As New SqlCommand(Query, SQL.Getconnection())
                cmd.ExecuteNonQuery()
                MsgBox("Enregistrement Effectué ! ", MsgBoxStyle.Information, "Infos personnel")
                Affichageserveur()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                SQL.Getconnection.Close()
            End Try

        End If
    End Sub

    Private Sub Affichageserveur()
        Dim OleAfficheAdapt As SqlDataAdapter
        Dim AfficheDs As New DataSet
        Dim AfficheTab As DataTable
        DGV.Rows.Clear()
        Try
            OleAfficheAdapt = New SqlDataAdapter("Select p.ID,p.nom,p.prenom,p.poste,p.email,p.telPers,c.nomSoc From  personnel p,societe c ", sql.Getconnection)
            OleAfficheAdapt.Fill(AfficheDs)
            AfficheTab = AfficheDs.Tables(0)
            If AfficheTab.Rows.Count <> 0 Then
                DGV.RowCount = AfficheTab.Rows.Count
                For i As Integer = 0 To AfficheTab.Rows.Count - 1
                    DGV.Rows(i).Cells("IDU").Value = AfficheTab.Rows(i).Item("ID")
                    DGV.Rows(i).Cells("Nom").Value = AfficheTab.Rows(i).Item("nom")
                    DGV.Rows(i).Cells("Prenom").Value = AfficheTab.Rows(i).Item("prenom")
                    DGV.Rows(i).Cells("Poste").Value = AfficheTab.Rows(i).Item("poste")
                    DGV.Rows(i).Cells("Email").Value = AfficheTab.Rows(i).Item("email")
                    DGV.Rows(i).Cells("Tel").Value = AfficheTab.Rows(i).Item("telPers")
                    DGV.Rows(i).Cells("Societe").Value = AfficheTab.Rows(i).Item("nomSoc")
                    DGV.Rows(i).Cells("Supprimer").Value = False
                Next
            Else
                DGV.DataSource = AfficheDs
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If txtNom.Text = "" And txtPrenom.Text = "" And txtPost.Text = "" And txtEmail.Text = "" And txtTel.Text = "" And CmbSoc.SelectedItem = "" Then
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
        Try
            For i As Integer = 0 To DGV.RowCount - 1
                OleCreationAdapt = New SqlDataAdapter("Select * From personnel  WHERE ID=" & Trim(DGV.Rows(i).Cells("IDU").Value) & "", sql.Getconnection)
                CreationDs = New DataSet
                OleCreationAdapt.Fill(CreationDs)
                CreationTab = CreationDs.Tables(0)
                If CreationTab.Rows.Count <> 0 Then
                    Insertion = "Update personnel SET nom='" & Join(Split(Trim(txtNom.Text), "'"), "''") & "',prenom='" & Join(Split(Trim(txtPrenom.Text), "'"), "''") & "',poste='" & Join(Split(Trim(txtPost.Text), "'"), "''") & "', Email='" & Join(Split(Trim(txtEmail.Text), "'"), "''") & "',telPers='" & Join(Split(Trim(txtTel.Text), "'"), "''") & "', ID_societe=" & Join(Split(Trim(id), "'"), "''") & "  WHERE ID=" & Join(Split(Trim(txtnumero.Text), "'"), "''") & ""
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
    End Sub


    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        Supprimerdonneserveur()
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
                    OleCreationAdapt = New SqlDataAdapter("Select * From personnel  WHERE ID=" & Trim(DGV.Rows(i).Cells("IDU").Value) & "", sql.Getconnection)
                    CreationDs = New DataSet
                    OleCreationAdapt.Fill(CreationDs)
                    CreationTab = CreationDs.Tables(0)
                    If CreationTab.Rows.Count <> 0 Then
                        Insertion = "Delete From entreprise WHERE ID=" & Join(Split(Trim(DGV.Rows(i).Cells("IDU").Value), "'"), "''") & ""
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


    Private Sub FrmPersonnel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim query As String = "select nomSoc from societe"
        Dim cmd As New SqlCommand(query, sql.Getconnection)
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            CmbSoc.Items.Add(reader("nomSoc").ToString)

        End While
        LBL.Visible = False
        txtnumero.Visible = False
        Affichageserveur()
    End Sub

    Private Sub DGV_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            txtnumero.Enabled = False
            txtnumero.Text = DGV.SelectedRows(0).Cells(0).Value
            txtnom.Text = DGV.SelectedRows(0).Cells(1).Value
            txtPrenom.Text = DGV.SelectedRows(0).Cells(2).Value
            txtEmail.Text = DGV.SelectedRows(0).Cells(3).Value
            txtTel.Text = DGV.SelectedRows(0).Cells(4).Value
            txtPost.Text = DGV.SelectedRows(0).Cells(5).Value
            CmbSoc.SelectedItem = DGV.SelectedRows(0).Cells(6).Value
            
        End If
    End Sub

    Dim id As Integer

    Private Sub CmbSoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSoc.SelectedIndexChanged
        Dim Query As String = "select ID from societe where nomSoc='" & CmbSoc.SelectedItem & "'"
        Dim cmd As New SqlCommand(Query, sql.Getconnection)
        Dim read As SqlDataReader = cmd.ExecuteReader
        While read.Read
            id = read("ID")
        End While
        sql.Getconnection.Close()
    End Sub
End Class
