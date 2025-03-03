Imports System.Data.SqlClient

Public Class frmPayrollProcessedRpt
    Dim reader As SqlDataReader
    Dim rec As Integer
    Dim cmdRptPayroll As New SqlCommand
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPayrollProcessedRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCombos()
    End Sub

    Private Sub loadCombos()
        Try
            Me.cboYear.Items.Clear()
            Me.cboYear.Text = ""
            Me.cboYear.SelectedIndex = -1
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()

            cmdRptPayroll.Connection = conn
            cmdRptPayroll.CommandText = "SELECT DISTINCT PayrollYear FROM tblPayrollRegister ORDER BY PayrollYear"
            cmdRptPayroll.CommandType = CommandType.Text
            cmdRptPayroll.Parameters.Clear()
            reader = Me.cmdRptPayroll.ExecuteReader
            While reader.Read
                Me.cboYear.Items.Add(IIf(DBNull.Value.Equals(reader!PayrollYear), "", reader!PayrollYear))
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub frmPayrollProcessedRpt_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If Me.IsMdiChild Then
            Dim PnlLoc As New Point
            PnlLoc.X = CInt((Me.Width - Me.pnlExpenseRpt.Width) / 2)
            PnlLoc.Y = CInt((Me.Height - Me.pnlExpenseRpt.Height) / 2.5)
            Me.pnlExpenseRpt.Location = PnlLoc
        Else
            Me.pnlExpenseRpt.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        If Me.cboYear.SelectedIndex = -1 Or Me.cboYear.Text = "" Then
            Exit Sub
        End If
        Try
            Me.cboMonth.Items.Clear()
            Me.cboMonth.Text = ""
            Me.cboMonth.SelectedIndex = -1

            Me.crtVwExpenseReport.ReportSource = Nothing

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()

            cmdRptPayroll.Connection = conn
            cmdRptPayroll.CommandText = "SELECT PayrollMonth FROM tblPayrollRegister ORDER BY PayrollMonth"
            cmdRptPayroll.CommandType = CommandType.Text
            cmdRptPayroll.Parameters.Clear()
            reader = Me.cmdRptPayroll.ExecuteReader
            While reader.Read
                Me.cboMonth.Items.Add(IIf(DBNull.Value.Equals(reader!PayrollMonth), "", reader!PayrollMonth))
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Function checkIfPayrollRun(ByVal payrollMonth As Integer, ByVal payrollYear As Integer) As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            cmdRptPayroll.Connection = conn
            cmdRptPayroll.CommandType = CommandType.Text
            cmdRptPayroll.CommandText = "SELECT * FROM vwPayrollProcessed WHERE (PayrollMonth=@PayrollMonth) AND (PayrollYear=@PayrollYear)"
            cmdRptPayroll.Parameters.Clear()
            cmdRptPayroll.Parameters.AddWithValue("@PayrollMonth", payrollMonth)
            cmdRptPayroll.Parameters.AddWithValue("@PayrollYear", payrollYear)
            reader = cmdRptPayroll.ExecuteReader
            If reader.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If Me.cboYear.SelectedIndex = -1 Or Me.cboYear.Text = "" Then
            MsgBox("Select payroll year.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.cboMonth.SelectedIndex = -1 Or Me.cboMonth.Text = "" Then
            MsgBox("Select payroll month.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        Try
            If Not checkIfPayrollRun(Me.cboMonth.Text, Me.cboYear.Text) Then
                MsgBox("Payroll not run. Please run payroll before accessing the report.",
                       MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
                Exit Sub
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.crtVwExpenseReport.ReportSource = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim RptResultsView As New crtPayrollEmployeesReport
            SetReportLogOn(RptResultsView)
            RptResultsView.SummaryInfo.ReportTitle = "PAYROLL REPORT FOR " & MonthName(Me.cboMonth.Text) & "-" & Me.cboYear.Text
            RptResultsView.SummaryInfo.ReportComments = fullName.Trim
            RptResultsView.RecordSelectionFormula = "({vwPayrollProcessed.PayrollMonth}=" & Me.cboMonth.Text & ")"
            RptResultsView.RecordSelectionFormula += " AND ({vwPayrollProcessed.PayrollYear}=" & Me.cboYear.Text & ")"

            Me.crtVwExpenseReport.ReportSource = RptResultsView
            Me.crtVwExpenseReport.Zoom(100)
            Me.crtVwExpenseReport.RefreshReport()
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        Me.crtVwExpenseReport.ReportSource = Nothing
    End Sub
End Class