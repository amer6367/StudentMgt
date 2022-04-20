Imports System.Data.OleDb
Public Class frmStudent

    Dim adStd As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim n As Integer
    Dim chrDBCommmad As Char

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmStd As New OleDbCommand
        cmStd.Connection = con
        cmStd.CommandText = "SELECT * FROM Student"
        adStd.SelectCommand = cmStd
        adStd.Fill(ds, "Student")
        n = ds.Tables("Student").Rows.Count - 1
        con.Close()
        showRecords()
    End Sub

    Sub showRecords()
        Dim drStd As DataRow
        If n >= 0 Then
            drStd = ds.Tables("Student").Rows(n)
            With drStd
                txtMatricNo.Text = .Item("MatricNo")
                txtSName.Text = .Item("sName")
                txtSNIC.Text = .Item("sNIC")
                radMale.Checked = (.Item("sGender") = "M")
                radFemale.Checked = (.Item("sGender") = "F")
                txtSTP.Text = .Item("sTP")
                txtAddress1.Text = .Item("sAddress1")
                txtAddress2.Text = .Item("sAddress2")
                txtAddress3.Text = .Item("sAddress3")

            End With
        End If
    End Sub

    Sub clearControls()
        txtMatricNo.Clear()
        txtSName.Clear()
        txtSNIC.Clear()
        radMale.Checked = True
        txtSTP.Clear()
        txtAddress1.Clear()
        txtAddress2.Clear()
        txtAddress3.Clear()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        n = 0
        showRecords()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If n > 0 Then
            n = n - 1
            showRecords()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If n < ds.Tables("Student").Rows.Count - 1 Then
            n = n + 1
            showRecords()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        n = ds.Tables("Student").Rows.Count - 1
        showRecords()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        chrDBCommmad = "A"
        clearControls()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If n >= 0 Then
            chrDBCommmad = "E"
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If n >= 0 Then
            chrDBCommmad = "D"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim chrGender As String
        If radMale.Checked = True Then
            chrGender = "M"
        Else
            chrGender = "F"
        End If

        Dim cmBuilder As New OleDbCommandBuilder
        cmBuilder.DataAdapter = adStd

        If chrDBCommmad = "A" Then
            If txtSNIC.Text = "" Then
                MessageBox.Show("Please enter data before saving...")
            Else
                Dim drStd As DataRow
                drStd = ds.Tables("Student").NewRow
                With drStd
                    .Item("MatricNo") = txtMatricNo.Text
                    .Item("sName") = txtSName.Text
                    .Item("sNIC") = txtSNIC.Text
                    .Item("sGender") = chrGender
                    .Item("sTP") = txtSTP.Text
                    .Item("sAddress1") = txtAddress1.Text
                    .Item("sAddress2") = txtAddress2.Text
                    .Item("sAddress3") = txtAddress3.Text
                End With
                ds.Tables("Student").Rows.Add(drStd)
                adStd.InsertCommand = cmBuilder.GetInsertCommand
                n = n + 1
                MessageBox.Show("Data saved successfully...")
            End If

        ElseIf chrDBCommmad = "E" Then
            Dim tbStd As DataTable
            Dim dcPrimaryKey(0) As DataColumn
            tbStd = ds.Tables("Student")
            dcPrimaryKey(0) = tbStd.Columns("sNIC")
            tbStd.PrimaryKey = dcPrimaryKey
            Dim drStd As DataRow = tbStd.Rows.Find(txtSNIC.Text)
            With drStd
                .Item("MatricNo") = txtMatricNo.Text
                .Item("sName") = txtSName.Text
                .Item("sNIC") = txtSNIC.Text
                .Item("sGender") = chrGender
                .Item("sTP") = txtSTP.Text
                .Item("sAddress1") = txtAddress1.Text
                .Item("sAddress2") = txtAddress2.Text
                .Item("sAddress3") = txtAddress3.Text
            End With
            adStd.UpdateCommand = cmBuilder.GetUpdateCommand
            MessageBox.Show("Data updated successfully...")

        ElseIf chrDBCommmad = "D" Then
            ds.Tables("Student").Rows(n).Delete()
            adStd.DeleteCommand = cmBuilder.GetDeleteCommand
            n = n - 1
            MessageBox.Show("Data deleted successfully...")
        End If

        con.Open()
        Try
            adStd.Update(ds, "Student")
            clearControls()
            showRecords()
        Catch ex As Exception
            MessageBox.Show("You are trying to save data incorrectly...")
        End Try
        con.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        showRecords()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
