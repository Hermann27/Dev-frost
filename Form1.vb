Imports System.Data.SqlClient
Public Class Form1
    Dim sql As New SQL
   
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtnom.Text = "" And txtadresse.Text = "" Then
            MsgBox("veuillez Renseigner l'Element a modifier SVP....", MsgBoxStyle.Information, "Infos Enregistrement")
        Else
        Try
            Dim Query As String = "insert into entreprise(nomEntreprise,bpEntreprise,ville,tel,email,siteInternet,fax,slogan,adresse) values ('" & txtnom.Text & "','" & txtBP.Text & "','" & txtville.Text & "'," & txtphone.Text & ",'" & txtemail.Text & "','" & txtsite.Text & "','" & txtfax.Text & "','" & txtslogan.Text & "','" & txtadresse.Text & "') "

            MsgBox(Query)
            Dim cmd As New SqlCommand(Query, sql.Getconnection())
            cmd.ExecuteNonQuery()
                MsgBox("Enregistrement Effectué ! ", MsgBoxStyle.Information, "Infos Entreprise")
                Affichageserveur()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                sql.Getconnection.Close()
            End Try

        End If
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If txtBP.Text = "" And txtnom.Text = "" Then
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
                OleCreationAdapt = New SqlDataAdapter("Select * From entreprise  WHERE ID=" & Trim(DGV.Rows(i).Cells("ID").Value) & "", sql.Getconnection)
                    CreationDs = New DataSet
                    OleCreationAdapt.Fill(CreationDs)
                    CreationTab = CreationDs.Tables(0)
                    If CreationTab.Rows.Count <> 0 Then
                    Insertion = "Update entreprise SET nomEntreprise='" & Join(Split(Trim(txtnom.Text), "'"), "''") & "',bpEntreprise='" & Join(Split(Trim(txtBP.Text), "'"), "''") & "',ville='" & Join(Split(Trim(txtville.Text), "'"), "''") & "', tel=" & Join(Split(Trim(txtphone.Text), "'"), "''") & ",email='" & Join(Split(Trim(txtemail.Text), "'"), "''") & "', siteInternet='" & Join(Split(Trim(txtsite.Text), "'"), "''") & "',fax='" & Join(Split(Trim(txtfax.Text), "'"), "''") & "',slogan='" & Join(Split(Trim(txtslogan.Text), "'"), "''") & "',adresse='" & Join(Split(Trim(txtadresse.Text), "'"), "''") & "'  WHERE ID=" & Join(Split(Trim(txtnumero.Text), "'"), "''") & ""
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

    Private Sub Affichageserveur()
        Dim OleAfficheAdapt As SqlDataAdapter
        Dim AfficheDs As New DataSet
        Dim AfficheTab As DataTable
        DGV.Rows.Clear()
        Try
            OleAfficheAdapt = New SqlDataAdapter("Select ID,nomEntreprise,bpEntreprise,ville,tel,email,siteInternet,fax,slogan,adresse From  entreprise ", sql.Getconnection)
            OleAfficheAdapt.Fill(AfficheDs)
            AfficheTab = AfficheDs.Tables(0)
            If AfficheTab.Rows.Count <> 0 Then
                DGV.RowCount = AfficheTab.Rows.Count
                For i As Integer = 0 To AfficheTab.Rows.Count - 1
                    DGV.Rows(i).Cells("ID").Value = AfficheTab.Rows(i).Item("ID")
                    DGV.Rows(i).Cells("Nom").Value = AfficheTab.Rows(i).Item("nomEntreprise")
                    DGV.Rows(i).Cells("BP").Value = AfficheTab.Rows(i).Item("bpEntreprise")
                    DGV.Rows(i).Cells("Ville").Value = AfficheTab.Rows(i).Item("ville")
                    DGV.Rows(i).Cells("Tel").Value = AfficheTab.Rows(i).Item("tel")
                    DGV.Rows(i).Cells("Email").Value = AfficheTab.Rows(i).Item("email")
                    DGV.Rows(i).Cells("Siteweb").Value = AfficheTab.Rows(i).Item("siteInternet")
                    DGV.Rows(i).Cells("Fax").Value = AfficheTab.Rows(i).Item("fax")
                    DGV.Rows(i).Cells("Slogan").Value = AfficheTab.Rows(i).Item("slogan")
                    DGV.Rows(i).Cells("Adresse").Value = AfficheTab.Rows(i).Item("adresse")
                    DGV.Rows(i).Cells("Supprimer").Value = False
                Next
            Else
                DGV.DataSource = AfficheDs
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                    OleCreationAdapt = New SqlDataAdapter("Select * From entreprise  WHERE ID=" & Trim(DGV.Rows(i).Cells("ID").Value) & "", sql.Getconnection)
                    CreationDs = New DataSet
                    OleCreationAdapt.Fill(CreationDs)
                    CreationTab = CreationDs.Tables(0)
                    If CreationTab.Rows.Count <> 0 Then
                        Insertion = "Delete From entreprise WHERE ID=" & Join(Split(Trim(DGV.Rows(i).Cells("ID").Value), "'"), "''") & ""
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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBL.Visible = False
        txtnumero.Visible = False
        Affichageserveur()
    End Sub

    Private Sub DGV_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV.SelectionChanged
        If DGV.SelectedRows.Count > 0 Then
            txtnumero.Enabled = False
            txtnumero.Text = DGV.SelectedRows(0).Cells(0).Value
            txtnom.Text = DGV.SelectedRows(0).Cells(1).Value
            txtBP.Text = DGV.SelectedRows(0).Cells(2).Value
            txtphone.Text = DGV.SelectedRows(0).Cells(3).Value
            txtville.Text = DGV.SelectedRows(0).Cells(4).Value
            txtemail.Text = DGV.SelectedRows(0).Cells(5).Value
            txtsite.Text = DGV.SelectedRows(0).Cells(6).Value
            txtslogan.Text = DGV.SelectedRows(0).Cells(7).Value
            txtfax.Text = DGV.SelectedRows(0).Cells(8).Value
            txtadresse.Text = DGV.SelectedRows(0).Cells(9).Value
        End If
    End Sub

    Private Sub btnSupp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupp.Click
        Supprimerdonneserveur()
    End Sub

   
End Class
