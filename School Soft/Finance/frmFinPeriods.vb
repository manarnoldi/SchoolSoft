Imports System.Data.SqlClient

Public Class frmFinPeriods
    Dim rec As Integer = 0
    Dim recordExists As Boolean = False
    Dim queryType As String = Nothing
    Dim reader As SqlDataReader
    Dim cmdFinancePeriods As New SqlCommand
    Private Sub loadYears()
        dbconnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Me.lstSchoolFinancialPeriods.Items.Clear()
        cmdFinancePeriods.Connection = conn
        cmdFinancePeriods.CommandType = CommandType.Text
        cmdFinancePeriods.CommandText = "SELECT * FROM tblFinPeriods ORDER BY year desc"
        cmdFinancePeriods.Parameters.Clear()
        reader = cmdFinancePeriods.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                li = Me.lstSchoolFinancialPeriods.Items.Add(IIf(DBNull.Value.Equals(reader!year), "", reader!year))
                li.SubItems.Add(IIf(DBNull.Value.Equals(reader!comments), "", reader!comments))
                li.SubItems.Add(IIf(DBNull.Value.Equals(reader!status), "", reader!status))
                li.Tag = IIf(DBNull.Value.Equals(reader!finPeriodId), "", reader!finPeriodId)
            End While
        End If
        reader.Close()
    End Sub
    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub frmFinPaymentPeriods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            loadYears()
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub frmFinPeriods_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If Me.IsMdiChild Then
            Dim PnlLoc As New Point
            PnlLoc.X = CInt((Me.Width - Me.pnlSchoolPeriods.Width) / 2)
            PnlLoc.Y = CInt((Me.Height - Me.pnlSchoolPeriods.Height) / 2.5)
            Me.pnlSchoolPeriods.Location = PnlLoc
        Else
            Me.pnlSchoolPeriods.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub checkForExistence()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        dbconnection()
        cmdFinancePeriods.Connection = conn
        cmdFinancePeriods.CommandType = CommandType.Text
        cmdFinancePeriods.CommandText = "SELECT * FROM tblFinPeriods WHERE (year=@year)"
        cmdFinancePeriods.Parameters.Clear()
        cmdFinancePeriods.Parameters.AddWithValue("@year", Me.txtPeriodName.Text)
        reader = cmdFinancePeriods.ExecuteReader
        If reader.HasRows Then
            recordExists = True
        Else
            recordExists = False
        End If
        reader.Close()
    End Sub
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If Me.txtPeriodName.Text.Trim.Length <= 0 Then
            MsgBox("Period name is Missing!", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        Try
            queryType = "INSERT"
            dbconnection()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            checkForExistence()
            If recordExists = True Then
                MsgBox("Record Exists!", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "UnsuccessFul Transaction")
                Exit Sub
            End If
            Dim result As MsgBoxResult = MsgBox("Save Record?", MsgBoxStyle.Question + MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo, "Confirm Transaction")
            If result = MsgBoxResult.Yes Then
                cmdFinancePeriods.Connection = conn
                cmdFinancePeriods.CommandType = CommandType.StoredProcedure
                cmdFinancePeriods.CommandText = "sprocFinPeriods"
                cmdFinancePeriods.Parameters.Clear()
                cmdFinancePeriods.Parameters.AddWithValue("@queryType", queryType.Trim)
                cmdFinancePeriods.Parameters.AddWithValue("@year", Me.txtPeriodName.Text.Trim)
                cmdFinancePeriods.Parameters.AddWithValue("@status", Me.checkStatus.Checked)
                cmdFinancePeriods.Parameters.AddWithValue("@regBy", userName.Trim)
                cmdFinancePeriods.Parameters.AddWithValue("@dateOfReg", Date.Now)
                cmdFinancePeriods.Parameters.AddWithValue("@comments", Me.txtComments.Text.Trim)
                rec = cmdFinancePeriods.ExecuteNonQuery
                If rec > 0 Then
                    MsgBox("Record Saved!", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "SuccessFul Transaction")
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            Me.lstSchoolFinancialPeriods.Items.Clear()
            loadYears()
            Me.txtPeriodName.Text = ""
            Me.txtComments.Text = Nothing
            queryType = Nothing
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub CLOSEYEARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEYEARToolStripMenuItem.Click
        If Me.lstSchoolFinancialPeriods.Items.Count <= 0 Then
            MsgBox("Missing Items In The List.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstSchoolFinancialPeriods.SelectedItems.Count <= 0 Then
            MsgBox("Missing selected Items In The List.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstSchoolFinancialPeriods.SelectedItems.Count > 1 Then
            MsgBox("Select one item At A Time.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()

            Dim result As MsgBoxResult = MsgBox("Save Record?", MsgBoxStyle.Question + MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo, "Confirm Transaction")
            If result = MsgBoxResult.Yes Then
                cmdFinancePeriods.Connection = conn
                cmdFinancePeriods.CommandType = CommandType.StoredProcedure
                cmdFinancePeriods.CommandText = "sprocFinPeriods"
                cmdFinancePeriods.Parameters.Clear()
                cmdFinancePeriods.Parameters.AddWithValue("@queryType", "CLOSEYEAR")
                cmdFinancePeriods.Parameters.AddWithValue("@finPeriodId", Me.lstSchoolFinancialPeriods.SelectedItems(0).Tag)
                cmdFinancePeriods.Parameters.AddWithValue("@year", Me.lstSchoolFinancialPeriods.SelectedItems(0).Text.Trim)
                cmdFinancePeriods.Parameters.AddWithValue("@status", False)
                cmdFinancePeriods.Parameters.AddWithValue("@regBy", userName.Trim)
                cmdFinancePeriods.Parameters.AddWithValue("@dateOfReg", Date.Now)
                cmdFinancePeriods.Parameters.AddWithValue("@comments", Me.lstSchoolFinancialPeriods.SelectedItems(0).SubItems(1).Text.Trim)
                rec = cmdFinancePeriods.ExecuteNonQuery
                If rec > 0 Then
                    MsgBox("Record Saved!", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "SuccessFul Transaction")
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            Me.lstSchoolFinancialPeriods.Items.Clear()
            loadYears()
            Me.txtPeriodName.Text = ""
            Me.txtComments.Text = Nothing
            queryType = Nothing
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class