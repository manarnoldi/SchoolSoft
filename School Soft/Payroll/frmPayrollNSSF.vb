Imports System.Data.SqlClient

Public Class frmPayrollNSSF
    Dim duplicateFound As Boolean = True
    Dim cmdPayrollNSSF As New SqlCommand
    Dim reader As SqlDataReader
    Dim rec As Integer = 0
    Dim queryType As String = Nothing
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmPayrollNSSF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.loadList()
    End Sub

    Private Sub frmPayrollNSSF_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If Me.IsMdiChild Then
            Dim PnlLoc As New Point
            PnlLoc.X = CInt((Me.Width - Me.TableLayoutPanel1.Width) / 2)
            PnlLoc.Y = CInt((Me.Height - Me.TableLayoutPanel1.Height) / 2.5)
            Me.TableLayoutPanel1.Location = PnlLoc
        Else
            Me.TableLayoutPanel1.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.ClearControls()
        Me.btnSave.Text = "Save New"
    End Sub

    Private Sub ClearControls()
        Me.txtYearName.Clear()
        Me.txtYear.Clear()
        Me.txtLowerLimitPercentage.Clear()
        Me.txtLowerLimitAmount.Clear()
        Me.txtUpperLimitPercentage.Clear()
        Me.txtUpperLimitAmount.Clear()
        Me.txtComments.Clear()
    End Sub

    Private Sub loadList()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollNSSF.Items.Clear()
            cmdPayrollNSSF.Connection = conn
            cmdPayrollNSSF.CommandText = "SELECT * FROM tblPayrollNSSF ORDER BY Name"
            cmdPayrollNSSF.CommandType = CommandType.Text
            cmdPayrollNSSF.Parameters.Clear()
            reader = cmdPayrollNSSF.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    li = Me.lstPayrollNSSF.Items.Add(IIf(DBNull.Value.Equals(reader!Name), "", reader!Name))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!Year), "", reader!Year))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!LowerLimitPercentage), "", reader!LowerLimitPercentage))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!LowerLimitAmount), "", reader!LowerLimitAmount))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!UpperLimitPercentage), "", reader!UpperLimitPercentage))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!UpperLimitAmount), "", reader!UpperLimitAmount))
                    li.Name = IIf(DBNull.Value.Equals(reader!Comments), "", reader!Comments)
                    li.Tag = IIf(DBNull.Value.Equals(reader!Id), "", reader!Id)
                End While
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Me.ClearControls()
            loadList()
            Me.btnSave.Text = "Save New"
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.txtYearName.Text.Trim.Length <= 0 Then
            MsgBox("Year name is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtYear.Text.Trim.Length <= 0 Then
            MsgBox("Year is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtLowerLimitPercentage.Text.Trim.Length <= 0 Then
            MsgBox("Lower limit percentage is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtLowerLimitAmount.Text.Trim.Length <= 0 Then
            MsgBox("Lower limit amount is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtUpperLimitPercentage.Text.Trim.Length <= 0 Then
            MsgBox("Upper limit percentage is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtUpperLimitAmount.Text.Trim.Length <= 0 Then
            MsgBox("Upper limit amount is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        queryType = "INSERT"
        If Me.btnSave.Text = "Update" Then
            queryType = "UPDATE"
        End If
        Try
            Dim result As MsgBoxResult = MsgBox(Me.btnSave.Text + " Record?", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo, "Confirm Transaction")
            If result = MsgBoxResult.No Then
                Exit Sub
            End If
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            rec = 0
            Me.cmdPayrollNSSF.Connection = conn
            Me.cmdPayrollNSSF.CommandType = CommandType.StoredProcedure
            Me.cmdPayrollNSSF.CommandText = "sprocPayrollNSSF"
            Me.cmdPayrollNSSF.Parameters.Clear()
            Me.cmdPayrollNSSF.Parameters.AddWithValue("@Name", Me.txtYearName.Text.Trim)
            Me.cmdPayrollNSSF.Parameters.AddWithValue("@Year", Me.txtYear.Text.Trim)
            Me.cmdPayrollNSSF.Parameters.AddWithValue("@LowerLimitPercentage", Me.txtLowerLimitPercentage.Text)
            Me.cmdPayrollNSSF.Parameters.AddWithValue("@LowerLimitAmount", Me.txtLowerLimitAmount.Text)
            Me.cmdPayrollNSSF.Parameters.AddWithValue("@UpperLimitPercentage", Me.txtUpperLimitPercentage.Text)
            Me.cmdPayrollNSSF.Parameters.AddWithValue("@UpperLimitAmount", Me.txtUpperLimitAmount.Text)
            Me.cmdPayrollNSSF.Parameters.AddWithValue("@Comments", Me.txtComments.Text.Trim)
            Me.cmdPayrollNSSF.Parameters.AddWithValue("@regBy", userName.Trim)
            Me.cmdPayrollNSSF.Parameters.AddWithValue("@queryType", queryType)
            If Me.btnSave.Text = "Update" Then
                Me.cmdPayrollNSSF.Parameters.AddWithValue("@Id", Me.txtYearName.Tag)
            End If
            rec = Me.cmdPayrollNSSF.ExecuteNonQuery
            If rec > 0 Then
                MsgBox(If(Me.btnSave.Text = "Update", "Record Updated", "Record Saved"), MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "SuccessFull Transaction")
            End If
            ClearControls()
            loadList()
            Me.btnSave.Text = "Save New"
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click
        If Me.lstPayrollNSSF.Items.Count <= 0 Then
            MsgBox("No items in the list.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollNSSF.SelectedItems.Count <= 0 Then
            MsgBox("Select the item to delete.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollNSSF.SelectedItems.Count > 1 Then
            MsgBox("Select One item at a time for updating.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        If Me.lstPayrollNSSF.SelectedItems.Count = 1 Then
            Me.txtYearName.Text = Me.lstPayrollNSSF.SelectedItems(0).Text
            Me.txtYear.Text = Me.lstPayrollNSSF.SelectedItems(0).SubItems(1).Text
            Me.txtLowerLimitPercentage.Text = Me.lstPayrollNSSF.SelectedItems(0).SubItems(2).Text
            Me.txtLowerLimitAmount.Text = Me.lstPayrollNSSF.SelectedItems(0).SubItems(3).Text
            Me.txtUpperLimitPercentage.Text = Me.lstPayrollNSSF.SelectedItems(0).SubItems(4).Text
            Me.txtUpperLimitAmount.Text = Me.lstPayrollNSSF.SelectedItems(0).SubItems(5).Text
            Me.txtComments.Text = Me.lstPayrollNSSF.SelectedItems(0).Name
            Me.txtYearName.Tag = Me.lstPayrollNSSF.SelectedItems(0).Tag
            Me.btnSave.Text = "Update"
            Me.lstPayrollNSSF.Items.Clear()
        End If
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        If Me.lstPayrollNSSF.Items.Count <= 0 Then
            MsgBox("No items in the list.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollNSSF.SelectedItems.Count <= 0 Then
            MsgBox("Select the item to delete.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollNSSF.SelectedItems.Count > 1 Then
            MsgBox("Select One item at a time for deletion.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        If Me.lstPayrollNSSF.SelectedItems.Count = 1 Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                dbconnection()
                Dim result As MsgBoxResult = MsgBox("Delete Record?", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo, "Confirm Transaction")
                If result = MsgBoxResult.No Then
                    Exit Sub
                End If
                queryType = "DELETE"
                Me.cmdPayrollNSSF.Connection = conn
                Me.cmdPayrollNSSF.CommandType = CommandType.StoredProcedure
                Me.cmdPayrollNSSF.CommandText = "sprocPayrollNSSF"
                Me.cmdPayrollNSSF.Parameters.Clear()
                Me.cmdPayrollNSSF.Parameters.AddWithValue("@Name", Me.lstPayrollNSSF.SelectedItems(0).Text)
                Me.cmdPayrollNSSF.Parameters.AddWithValue("@Year", Me.lstPayrollNSSF.SelectedItems(0).SubItems(1).Text)
                Me.cmdPayrollNSSF.Parameters.AddWithValue("@LowerLimitPercentage", Me.lstPayrollNSSF.SelectedItems(0).SubItems(2).Text)
                Me.cmdPayrollNSSF.Parameters.AddWithValue("@LowerLimitAmount", Me.lstPayrollNSSF.SelectedItems(0).SubItems(3).Text)
                Me.cmdPayrollNSSF.Parameters.AddWithValue("@UpperLimitPercentage", Me.lstPayrollNSSF.SelectedItems(0).SubItems(4).Text)
                Me.cmdPayrollNSSF.Parameters.AddWithValue("@UpperLimitAmount", Me.lstPayrollNSSF.SelectedItems(0).SubItems(5).Text)
                Me.cmdPayrollNSSF.Parameters.AddWithValue("@Comments", Me.lstPayrollNSSF.SelectedItems(0).Name)
                Me.cmdPayrollNSSF.Parameters.AddWithValue("@regBy", userName.Trim)
                Me.cmdPayrollNSSF.Parameters.AddWithValue("@queryType", queryType)
                Me.cmdPayrollNSSF.Parameters.AddWithValue("@Id", Me.lstPayrollNSSF.SelectedItems(0).Tag)
                rec = Me.cmdPayrollNSSF.ExecuteNonQuery
                MsgBox("Record Deleted", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "SuccessFull Transaction")

                ClearControls()
                loadList()
            Catch ex As Exception
                MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub
End Class