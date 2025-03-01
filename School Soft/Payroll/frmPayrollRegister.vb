Imports System.Data.SqlClient

Public Class frmPayrollRegister
    Dim duplicateFound As Boolean = True
    Dim cmdPayrollRegister As New SqlCommand
    Dim reader As SqlDataReader
    Dim rec As Integer = 0
    Dim queryType As String = Nothing
    Private Sub frmPayrollRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadList()
    End Sub

    Private Sub frmPayrollRegister_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If Me.IsMdiChild Then
            Dim PnlLoc As New Point
            PnlLoc.X = CInt((Me.Width - Me.TableLayoutPanel1.Width) / 2)
            PnlLoc.Y = CInt((Me.Height - Me.TableLayoutPanel1.Height) / 2.5)
            Me.TableLayoutPanel1.Location = PnlLoc
        Else
            Me.TableLayoutPanel1.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub loadList()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollRegister.Items.Clear()
            cmdPayrollRegister.Connection = conn
            cmdPayrollRegister.CommandText = "SELECT * FROM tblPayrollRegister ORDER BY PayrollName"
            cmdPayrollRegister.CommandType = CommandType.Text
            cmdPayrollRegister.Parameters.Clear()
            reader = cmdPayrollRegister.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    li = Me.lstPayrollRegister.Items.Add(IIf(DBNull.Value.Equals(reader!PayrollName), "", reader!PayrollName))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!StartDate), "", reader!StartDate))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!EndDate), "", reader!EndDate))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!PayrollMonth), "", reader!PayrollMonth))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!PayrollYear), "", reader!PayrollYear))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!Comments), "", reader!Comments))
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.ClearControls()
        Me.btnSave.Text = "Save New"
    End Sub

    Private Sub ClearControls()
        Me.txtComments.Clear()
        Me.txtPayrollName.Clear()
        Me.dtpStartDate.Value = Now.Date
        Me.dtpEndDate.Value = Now.Date
        Me.dtpPayrollMonth.Value = Now.Date
        Me.dtpPayrollYear.Value = Now.Date
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
        If Me.txtPayrollName.Text.Trim.Length <= 0 Then
            MsgBox("Payroll name is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        queryType = "INSERT"
        If Me.btnSave.Text = "Update" Then
            queryType = "UPDATE"
        End If
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()

            If Me.btnSave.Text = "Save New" Then
                cmdPayrollRegister.Connection = conn
                cmdPayrollRegister.CommandText = "SELECT * FROM tblPayrollRegister Where PayrollName=@PayrollName"
                cmdPayrollRegister.CommandType = CommandType.Text
                cmdPayrollRegister.Parameters.Clear()
                Me.cmdPayrollRegister.Parameters.AddWithValue("@PayrollName", Me.txtPayrollName.Text.Trim)
                reader = Me.cmdPayrollRegister.ExecuteReader
                If reader.HasRows Then
                    MsgBox("Payroll register already exists!", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
                    Exit Sub
                End If
                reader.Close()
            End If

            Dim result As MsgBoxResult = MsgBox(Me.btnSave.Text + " Record?", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo, "Confirm Transaction")
            If result = MsgBoxResult.No Then
                Exit Sub
            End If

            rec = 0
            Me.cmdPayrollRegister.Connection = conn
            Me.cmdPayrollRegister.CommandType = CommandType.StoredProcedure
            Me.cmdPayrollRegister.CommandText = "sprocPayrollRegister"
            Me.cmdPayrollRegister.Parameters.Clear()
            Me.cmdPayrollRegister.Parameters.AddWithValue("@PayrollName", Me.txtPayrollName.Text.Trim)
            Me.cmdPayrollRegister.Parameters.AddWithValue("@StartDate", Me.dtpStartDate.Value)
            Me.cmdPayrollRegister.Parameters.AddWithValue("@EndDate", Me.dtpEndDate.Value)
            Me.cmdPayrollRegister.Parameters.AddWithValue("@PayrollMonth", Me.dtpPayrollMonth.Value.Month)
            Me.cmdPayrollRegister.Parameters.AddWithValue("@PayrollYear", Me.dtpPayrollYear.Value.Year)
            Me.cmdPayrollRegister.Parameters.AddWithValue("@Comments", Me.txtComments.Text.Trim)
            Me.cmdPayrollRegister.Parameters.AddWithValue("@regBy", userName.Trim)
            Me.cmdPayrollRegister.Parameters.AddWithValue("@queryType", queryType)
            If Me.btnSave.Text = "Update" Then
                Me.cmdPayrollRegister.Parameters.AddWithValue("@Id", Me.txtPayrollName.Tag)
            End If
            rec = Me.cmdPayrollRegister.ExecuteNonQuery
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

    Private Sub lstPayrollRegister_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPayrollRegister.SelectedIndexChanged

    End Sub

    Private Sub lstPayrollRegister_DoubleClick(sender As Object, e As EventArgs) Handles lstPayrollRegister.DoubleClick
        If Me.lstPayrollRegister.SelectedItems.Count = 1 Then
            Me.txtPayrollName.Text = Me.lstPayrollRegister.SelectedItems(0).Text
            Me.dtpStartDate.Value = Me.lstPayrollRegister.SelectedItems(0).SubItems(1).Text
            Me.dtpEndDate.Value = Me.lstPayrollRegister.SelectedItems(0).SubItems(2).Text
            Me.dtpPayrollMonth.Value = New DateTime(Me.lstPayrollRegister.SelectedItems(0).SubItems(4).Text, Me.lstPayrollRegister.SelectedItems(0).SubItems(3).Text, 1)
            Me.dtpPayrollYear.Value = New DateTime(Me.lstPayrollRegister.SelectedItems(0).SubItems(4).Text, Me.lstPayrollRegister.SelectedItems(0).SubItems(3).Text, 1)
            Me.txtComments.Text = Me.lstPayrollRegister.SelectedItems(0).SubItems(5).Text
            Me.txtPayrollName.Tag = Me.lstPayrollRegister.SelectedItems(0).Tag
            Me.btnSave.Text = "Update"
            Me.lstPayrollRegister.Items.Clear()
        Else
            Me.btnSave.Text = "Save New"
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Me.lstPayrollRegister.Items.Count <= 0 Then
            MsgBox("No items in the list.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollRegister.SelectedItems.Count <= 0 Then
            MsgBox("Select the item to delete.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollRegister.SelectedItems.Count > 1 Then
            MsgBox("Select One item at a time for deletion.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        If Me.lstPayrollRegister.SelectedItems.Count = 1 Then
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
                Me.cmdPayrollRegister.Connection = conn
                Me.cmdPayrollRegister.CommandType = CommandType.StoredProcedure
                Me.cmdPayrollRegister.CommandText = "sprocPayrollRegister"
                Me.cmdPayrollRegister.Parameters.Clear()
                Me.cmdPayrollRegister.Parameters.AddWithValue("@PayrollName", Me.lstPayrollRegister.SelectedItems(0).Text)
                Me.cmdPayrollRegister.Parameters.AddWithValue("@StartDate", Me.lstPayrollRegister.SelectedItems(0).SubItems(1).Text)
                Me.cmdPayrollRegister.Parameters.AddWithValue("@EndDate", Me.lstPayrollRegister.SelectedItems(0).SubItems(2).Text)
                Me.cmdPayrollRegister.Parameters.AddWithValue("@PayrollMonth", Me.lstPayrollRegister.SelectedItems(0).SubItems(3).Text)
                Me.cmdPayrollRegister.Parameters.AddWithValue("@PayrollYear", Me.lstPayrollRegister.SelectedItems(0).SubItems(4).Text)
                Me.cmdPayrollRegister.Parameters.AddWithValue("@Comments", Me.lstPayrollRegister.SelectedItems(0).SubItems(5).Text)
                Me.cmdPayrollRegister.Parameters.AddWithValue("@regBy", userName.Trim)
                Me.cmdPayrollRegister.Parameters.AddWithValue("@queryType", queryType)
                Me.cmdPayrollRegister.Parameters.AddWithValue("@Id", Me.lstPayrollRegister.SelectedItems(0).Tag)
                rec = Me.cmdPayrollRegister.ExecuteNonQuery
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class