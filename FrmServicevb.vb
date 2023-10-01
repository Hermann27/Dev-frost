Imports System.Data.SqlClient
Public Class FrmServicevb
    Dim sql As New SQL
    Dim id As Integer
    Dim id1 As Integer

    Private Sub FrmServicevb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String = "select nom from personnel"
        Dim query1 As String = "select nomEntreprise,ID from entreprise"
        Dim cmd As New SqlCommand(query, sql.Getconnection)
        Dim cmd1 As New SqlCommand(query1, sql.Getconnection)
        Dim reader As SqlDataReader
        Dim reader1 As SqlDataReader
        reader = cmd.ExecuteReader
        reader1 = cmd1.ExecuteReader
        While reader.Read
            CmbPers.Items.Add(reader("nom").ToString)
        End While
        While reader1.Read
            txtEntrep.Text = reader1("nomEntreprise").ToString
            id1 = reader1("ID")
        End While

        'LBL.Visible = False
        'txtnumero.Visible = False
        Affichageserveur()
        sql.Getconnection.Close()
    End Sub

    Private Sub Affichageserveur()
        Dim OleAfficheAdapt As SqlDataAdapter
        Dim AfficheDs As New DataSet
        Dim AfficheTab As DataTable
        DGV.Rows.Clear()
        Try
            OleAfficheAdapt = New SqlDataAdapter("Select s.ID, s.type,s.dateDemande,s.dureeService,p.nom From  service s,personnel p where s.ID_personnel=p.ID ", sql.Getconnection)
            OleAfficheAdapt.Fill(AfficheDs)
            AfficheTab = AfficheDs.Tables(0)
            If AfficheTab.Rows.Count <> 0 Then
                DGV.RowCount = AfficheTab.Rows.Count
                For i As Integer = 0 To AfficheTab.Rows.Count - 1
                    DGV.Rows(i).Cells("IDU").Value = AfficheTab.Rows(i).Item("ID")
                    DGV.Rows(i).Cells("Nom").Value = AfficheTab.Rows(i).Item("type")
                    DGV.Rows(i).Cells("Personnel").Value = AfficheTab.Rows(i).Item("nom")
                    DGV.Rows(i).Cells("Duree").Value = AfficheTab.Rows(i).Item("dureeService")
                    DGV.Rows(i).Cells("DateD").Value = AfficheTab.Rows(i).Item("dateDemande")
                    DGV.Rows(i).Cells("Supprimer").Value = False
                Next
            Else
                DGV.DataSource = AfficheDs
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtNom.Text = "" And txtDat.Text = "" And CmbPers.SelectedItem = "" Then
            MsgBox("veuillez Renseigner l'Element a enregistrer SVP....", MsgBoxStyle.Information, "Infos Enregistrement")
        Else
                 Try
                Dim Query As String = "insert into service(type,dateDemande,dureeService,ID_entreprise,ID_personnel) values ('" & txtNom.Text & "','" & txtDat.Text & "','" & txtDur.Text & "'," & id1 & "," & id & ") "

                    MsgBox(Query)
                    Dim cmd As New SqlCommand(Query, sql.Getconnection())
                    cmd.ExecuteNonQuery()
                MsgBox("Enregistrement Effectué ! ", MsgBoxStyle.Information, "Infos service")
                    Affichageserveur()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    sql.Getconnection.Close()
                End Try
        End If
    End Sub

    Private Sub CmbPers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPers.SelectedIndexChanged
        Dim Query As String = "select ID from Personnel where nom='" & CmbPers.SelectedItem & "'"
        Dim cmd As New SqlCommand(Query, sql.Getconnection)
        Dim read As SqlDataReader = cmd.ExecuteReader
        While read.Read
            id = read("ID")
        End While
        sql.Getconnection.Close()
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If txtNom.Text = "" And txtDat.Text = "" And CmbPers.SelectedItem = "" Then
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
                OleCreationAdapt = New SqlDataAdapter("Select * From service  WHERE ID=" & Trim(DGV.Rows(i).Cells("IDU").Value) & "", sql.Getconnection)
                CreationDs = New DataSet
                OleCreationAdapt.Fill(CreationDs)
                CreationTab = CreationDs.Tables(0)
                If CreationTab.Rows.Count <> 0 Then
                    Insertion = "Update service SET type='" & Join(Split(Trim(txtNom.Text), "'"), "''") & "',dateDemande='" & Join(Split(Trim(txtDat.Text), "'"), "''") & "',dureeService='" & Join(Split(Trim(txtDur.Text), "'"), "''") & "',ID_personnel='" & Join(Split(Trim(id), "'"), "''") & "',ID_entreprise='" & Join(Split(Trim(id1), "'"), "''") & "'  WHERE ID=" & Join(Split(Trim(txtnumero.Text), "'"), "''") & ""
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

    Private Sub DGV_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            txtnumero.Enabled = False
            txtnumero.Text = DGV.SelectedRows(0).Cells(0).Value
            txtNom.Text = DGV.SelectedRows(0).Cells(1).Value
            CmbPers.SelectedItem = DGV.SelectedRows(0).Cells(2).Value
            txtDur.Text = DGV.SelectedRows(0).Cells(3).Value
            txtDat.Text = DGV.SelectedRows(0).Cells(4).Value
        End If
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
                    OleCreationAdapt = New SqlDataAdapter("Select * From service  WHERE ID=" & Trim(DGV.Rows(i).Cells("IDU").Value) & "", sql.Getconnection)
                    CreationDs = New DataSet
                    OleCreationAdapt.Fill(CreationDs)
                    CreationTab = CreationDs.Tables(0)
                    If CreationTab.Rows.Count <> 0 Then
                        Insertion = "Delete From service WHERE ID=" & Join(Split(Trim(DGV.Rows(i).Cells("IDU").Value), "'"), "''") & ""
                        OleCommandEnreg = New SqlCommand(Insertion, sql.Getconnection())
                        OleCommandEnreg.ExecuteNonQuery()
                        Insert = True
                    End If
                End If
            Next i
            If Insert = True Then
                MsgBox("Suppression Reussie", MsgBoxStyle.Information, "Suppression service")
            Else
                MsgBox(" Selectionner l'Element a Supprimer SVP...", MsgBoxStyle.Information, "Infos Suppression")
            End If
            Affichageserveur()
            sql.Getconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
