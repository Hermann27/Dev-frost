Imports System.Data.SqlClient
Public Class FrmSociete
    Dim sql As New SQL

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtnom.Text = "" And txtadresse.Text = "" Then
            MsgBox("veuillez Renseigner l'Element a enregistrer SVP....", MsgBoxStyle.Information, "Infos Enregistrement")
        Else
            Try
                Dim Query As String = "insert into societe(nomSoc,bpSoc,villeSoc,telSoc,emailSoc,siteSoc,faxSoc,descriptionSoc,sloganSoc,adresseSoc,chiffDafSoc) values ('" & txtnom.Text & "','" & txtBP.Text & "','" & txtville.Text & "'," & txtphone.Text & ",'" & txtemail.Text & "','" & txtsite.Text & "','" & txtfax.Text & "','" & txtDes.Text & "','" & txtslogan.Text & "','" & txtadresse.Text & "','" & txtChif.Text & "') "

                MsgBox(Query)
                Dim cmd As New SqlCommand(Query, sql.Getconnection())
                cmd.ExecuteNonQuery()
                MsgBox("Enregistrement Effectué ! ", MsgBoxStyle.Information, "Infos societe")
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
                OleCreationAdapt = New SqlDataAdapter("Select * From societe  WHERE ID=" & Trim(DGV.Rows(i).Cells("ID").Value) & "", sql.Getconnection)
                CreationDs = New DataSet
                OleCreationAdapt.Fill(CreationDs)
                CreationTab = CreationDs.Tables(0)
                If CreationTab.Rows.Count <> 0 Then
                    Insertion = "Update societe SET nomSoc='" & Join(Split(Trim(txtnom.Text), "'"), "''") & "',bpSoc='" & Join(Split(Trim(txtBP.Text), "'"), "''") & "',villeSoc='" & Join(Split(Trim(txtville.Text), "'"), "''") & "', telSoc=" & Join(Split(Trim(txtphone.Text), "'"), "''") & ",emailSoc='" & Join(Split(Trim(txtemail.Text), "'"), "''") & "', siteSoc='" & Join(Split(Trim(txtsite.Text), "'"), "''") & "',faxSoc='" & Join(Split(Trim(txtfax.Text), "'"), "''") & "',descriptionSoc='" & Join(Split(Trim(txtDes.Text), "'"), "''") & "',sloganSoc='" & Join(Split(Trim(txtslogan.Text), "'"), "''") & "',adresseSoc='" & Join(Split(Trim(txtadresse.Text), "'"), "''") & "',chiffDafSoc='" & Join(Split(Trim(txtChif.Text), "'"), "''") & "'  WHERE ID=" & Join(Split(Trim(txtnumero.Text), "'"), "''") & ""
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
            OleAfficheAdapt = New SqlDataAdapter("Select ID,nomSoc,bpSoc,villeSoc,telSoc,emailSoc,siteSoc,faxSoc,descriptionSoc,sloganSoc,adresseSoc,chiffDafSoc From  societe ", sql.Getconnection)
            OleAfficheAdapt.Fill(AfficheDs)
            AfficheTab = AfficheDs.Tables(0)
            If AfficheTab.Rows.Count <> 0 Then
                DGV.RowCount = AfficheTab.Rows.Count
                For i As Integer = 0 To AfficheTab.Rows.Count - 1
                    DGV.Rows(i).Cells("ID").Value = AfficheTab.Rows(i).Item("ID")
                    DGV.Rows(i).Cells("Nom").Value = AfficheTab.Rows(i).Item("nomSoc")
                    DGV.Rows(i).Cells("BP").Value = AfficheTab.Rows(i).Item("bpSoc")
                    DGV.Rows(i).Cells("Ville").Value = AfficheTab.Rows(i).Item("villeSoc")
                    DGV.Rows(i).Cells("Tel").Value = AfficheTab.Rows(i).Item("telSoc")
                    DGV.Rows(i).Cells("Email").Value = AfficheTab.Rows(i).Item("emailSoc")
                    DGV.Rows(i).Cells("Siteweb").Value = AfficheTab.Rows(i).Item("siteSoc")
                    DGV.Rows(i).Cells("Fax").Value = AfficheTab.Rows(i).Item("faxSoc")
                    DGV.Rows(i).Cells("Slogan").Value = AfficheTab.Rows(i).Item("sloganSoc")
                    DGV.Rows(i).Cells("Adresse").Value = AfficheTab.Rows(i).Item("adresseSoc")
                    DGV.Rows(i).Cells("Description").Value = AfficheTab.Rows(i).Item("descriptionSoc")
                    DGV.Rows(i).Cells("Chiffre").Value = AfficheTab.Rows(i).Item("chiffDafSoc")
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
                    OleCreationAdapt = New SqlDataAdapter("Select * From societe  WHERE ID=" & Trim(DGV.Rows(i).Cells("ID").Value) & "", sql.Getconnection)
                    CreationDs = New DataSet
                    OleCreationAdapt.Fill(CreationDs)
                    CreationTab = CreationDs.Tables(0)
                    If CreationTab.Rows.Count <> 0 Then
                        Insertion = "Delete From societe WHERE ID=" & Join(Split(Trim(DGV.Rows(i).Cells("ID").Value), "'"), "''") & ""
                        OleCommandEnreg = New SqlCommand(Insertion, sql.Getconnection())
                        OleCommandEnreg.ExecuteNonQuery()
                        Insert = True
                    End If
                End If
            Next i
            If Insert = True Then
                MsgBox("Suppression Reussie", MsgBoxStyle.Information, "Suppression Societe")
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
            txtDes.Text = DGV.SelectedRows(0).Cells(8).Value
            txtChif.Text = DGV.SelectedRows(0).Cells(9).Value
        End If
    End Sub

    Private Sub btnSupp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupp.Click
        Supprimerdonneserveur()
    End Sub

 
End Class
