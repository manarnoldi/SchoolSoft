Imports System.Data.SqlClient

Public Class frmPayrollPAYE
    Dim duplicateFound As Boolean = True
    Dim cmdPayrollPAYE As New SqlCommand
    Dim reader As SqlDataReader
    Dim rec As Integer = 0
    Dim queryType As String = Nothing
    Private Sub frmPayrollPAYE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            loadList()
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub ClearControls()
        Me.txtMonthMaximum.Clear()
        Me.txtMonthMinimum.Clear()
        Me.txtYearMaximum.Clear()
        Me.txtYearMinimum.Clear()
        Me.txtTaxRate.Clear()
        Me.txtComments.Clear()
    End Sub

    Private Sub loadList()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        dbconnection()
        Me.lstPayrollPAYE.Items.Clear()
        Me.lstPayrollPAYE.Items.Clear()

        cmdPayrollPAYE.Connection = conn
        cmdPayrollPAYE.CommandText = "SELECT * FROM tblPayrollPAYE ORDER BY TaxRate"
        cmdPayrollPAYE.CommandType = CommandType.Text
        cmdPayrollPAYE.Parameters.Clear()
        reader = cmdPayrollPAYE.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                li = Me.lstPayrollPAYE.Items.Add(IIf(DBNull.Value.Equals(reader!MonthMinimum), "", reader!MonthMinimum))
                li.SubItems.Add(IIf(DBNull.Value.Equals(reader!MonthMaximum), "", reader!MonthMaximum))
                li.SubItems.Add(IIf(DBNull.Value.Equals(reader!YearMinimum), "", reader!YearMinimum))
                li.SubItems.Add(IIf(DBNull.Value.Equals(reader!YearMaximum), "", reader!YearMaximum))
                li.SubItems.Add(IIf(DBNull.Value.Equals(reader!TaxRate), "", reader!TaxRate))
                li.SubItems.Add(IIf(DBNull.Value.Equals(reader!Comments), "", reader!Comments))
                li.Tag = IIf(DBNull.Value.Equals(reader!Id), "", reader!Id)
            End While
        End If
        reader.Close()
    End Sub

    Private Sub frmPayrollPAYE_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If Me.IsMdiChild Then
            Dim PnlLoc As New Point
            PnlLoc.X = CInt((Me.Width - Me.TableLayoutPanel1.Width) / 2)
            PnlLoc.Y = CInt((Me.Height - Me.TableLayoutPanel1.Height) / 2.5)
            Me.TableLayoutPanel1.Location = PnlLoc
        Else
            Me.TableLayoutPanel1.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.ClearControls()
        Me.lstPayrollPAYE.Items.Clear()
        Me.btnSave.Text = "Save New"
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
        If Me.txtMonthMinimum.Text.Trim.Length <= 0 Then
            MsgBox("Month Minimum is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtMonthMaximum.Text.Trim.Length <= 0 Then
            MsgBox("Month Maximum is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtYearMinimum.Text.Trim.Length <= 0 Then
            MsgBox("Year Minimum is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtYearMaximum.Text.Trim.Length <= 0 Then
            MsgBox("Year Maximum is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtTaxRate.Text.Trim.Length <= 0 Then
            MsgBox("Tax Rate is Missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
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
            Dim result As MsgBoxResult = MsgBox(Me.btnSave.Text + " Record?", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo, "Confirm Transaction")
            If result = MsgBoxResult.No Then
                Exit Sub
            End If

            rec = 0
            Me.cmdPayrollPAYE.Connection = conn
            Me.cmdPayrollPAYE.CommandType = CommandType.StoredProcedure
            Me.cmdPayrollPAYE.CommandText = "sprocPayrollPAYE"
            Me.cmdPayrollPAYE.Parameters.Clear()
            Me.cmdPayrollPAYE.Parameters.AddWithValue("@MonthMinimum", Me.txtMonthMinimum.Text.Trim)
            Me.cmdPayrollPAYE.Parameters.AddWithValue("@MonthMaximum", Me.txtMonthMaximum.Text.Trim)
            Me.cmdPayrollPAYE.Parameters.AddWithValue("@YearMinimum", Me.txtYearMinimum.Text.Trim)
            Me.cmdPayrollPAYE.Parameters.AddWithValue("@YearMaximum", Me.txtYearMaximum.Text.Trim)
            Me.cmdPayrollPAYE.Parameters.AddWithValue("@TaxRate", Me.txtTaxRate.Text.Trim)
            Me.cmdPayrollPAYE.Parameters.AddWithValue("@Comments", Me.txtComments.Text.Trim)
            Me.cmdPayrollPAYE.Parameters.AddWithValue("@regBy", userName.Trim)
            Me.cmdPayrollPAYE.Parameters.AddWithValue("@queryType", queryType)
            If Me.btnSave.Text = "Update" Then
                Me.cmdPayrollPAYE.Parameters.AddWithValue("@Id", Me.txtMonthMinimum.Tag)
            End If

            rec = Me.cmdPayrollPAYE.ExecuteNonQuery
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

    Private Sub lstPayrollPAYE_DoubleClick(sender As Object, e As EventArgs) Handles lstPayrollPAYE.DoubleClick
        If Me.lstPayrollPAYE.SelectedItems.Count = 1 Then
            Me.txtMonthMinimum.Text = Me.lstPayrollPAYE.SelectedItems(0).Text
            Me.txtMonthMaximum.Text = Me.lstPayrollPAYE.SelectedItems(0).SubItems(1).Text
            Me.txtYearMinimum.Text = Me.lstPayrollPAYE.SelectedItems(0).SubItems(2).Text
            Me.txtYearMaximum.Text = Me.lstPayrollPAYE.SelectedItems(0).SubItems(3).Text
            Me.txtTaxRate.Text = Me.lstPayrollPAYE.SelectedItems(0).SubItems(4).Text
            Me.txtComments.Text = Me.lstPayrollPAYE.SelectedItems(0).SubItems(5).Text
            Me.txtMonthMinimum.Tag = Me.lstPayrollPAYE.SelectedItems(0).Tag
            Me.btnSave.Text = "Update"
            Me.lstPayrollPAYE.Items.Clear()
        Else
            Me.btnSave.Text = "Save New"
        End If
    End Sub

End Class