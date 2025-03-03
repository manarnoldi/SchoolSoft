Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPayrollPayslips
    Dim resultsFound As Boolean
    Dim reader As SqlDataReader
    Dim cmdPayslip As New SqlCommand
    Dim rec As Integer
    Private Sub frmPayrollPayslips_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            cmdPayslip.Connection = conn
            cmdPayslip.CommandText = "SELECT DISTINCT PayrollYear FROM tblPayrollRegister ORDER BY PayrollYear"
            cmdPayslip.CommandType = CommandType.Text
            cmdPayslip.Parameters.Clear()
            reader = Me.cmdPayslip.ExecuteReader
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
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPayrollPayslips_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If Me.IsMdiChild Then
            Dim PnlLoc As New Point
            PnlLoc.X = CInt((Me.Width - Me.TableLayoutPanel1.Width) / 2)
            PnlLoc.Y = CInt((Me.Height - Me.TableLayoutPanel1.Height) / 2.5)
            Me.TableLayoutPanel1.Location = PnlLoc
        Else
            Me.TableLayoutPanel1.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        If Me.cboYear.SelectedIndex = -1 Or Me.cboYear.Text = "" Then
            Exit Sub
        End If
        Me.lstPayslips.Items.Clear()
        Try
            Me.cboMonth.Items.Clear()
            Me.cboMonth.Text = ""
            Me.cboMonth.SelectedIndex = -1

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()

            cmdPayslip.Connection = conn
            cmdPayslip.CommandText = "SELECT PayrollMonth FROM tblPayrollRegister ORDER BY PayrollMonth"
            cmdPayslip.CommandType = CommandType.Text
            cmdPayslip.Parameters.Clear()
            reader = Me.cmdPayslip.ExecuteReader
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
            Me.lstPayslips.Items.Clear()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()

            cmdPayslip.Connection = conn
            cmdPayslip.CommandText = "SELECT * FROM tblSchoolStaff WHERE (status=1)"
            cmdPayslip.CommandType = CommandType.Text
            cmdPayslip.Parameters.Clear()
            reader = Me.cmdPayslip.ExecuteReader
            While reader.Read
                li = Me.lstPayslips.Items.Add(IIf(DBNull.Value.Equals(reader!empNo), "", reader!empNo))
                li.SubItems.Add(IIf(DBNull.Value.Equals(reader!FullName), "", reader!FullName))
                li.Tag = (IIf(DBNull.Value.Equals(reader!empId), "", reader!empId))
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

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        Me.lstPayslips.Items.Clear()
    End Sub

    Private Function checkIfPayrollRun(ByVal payrollMonth As Integer, ByVal payrollYear As Integer) As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            cmdPayslip.Connection = conn
            cmdPayslip.CommandType = CommandType.Text
            cmdPayslip.CommandText = "SELECT * FROM vwPayrollProcessed WHERE (PayrollMonth=@PayrollMonth) AND (PayrollYear=@PayrollYear)"
            cmdPayslip.Parameters.Clear()
            cmdPayslip.Parameters.AddWithValue("@PayrollMonth", payrollMonth)
            cmdPayslip.Parameters.AddWithValue("@PayrollYear", payrollYear)
            reader = cmdPayslip.ExecuteReader
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

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            If Me.lstPayslips.CheckedItems.Count <> 1 Then
                MsgBox("Check One item to Preview.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly + MsgBoxStyle.ApplicationModal, "System Reply")
                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor

                Dim RptResultsView As New crtPayrollPayslipReport
                SetReportLogOn(RptResultsView)
                RptResultsView.SummaryInfo.ReportComments = fullName.Trim
                RptResultsView.RecordSelectionFormula = "({vwPayrollProcessed.EmpId}=" & Me.lstPayslips.CheckedItems(0).Tag & ")"
                RptResultsView.RecordSelectionFormula += "AND ({vwPayrollProcessed.PayrollMonth}=" & Me.cboMonth.Text.Trim & ")"
                RptResultsView.RecordSelectionFormula += "AND ({vwPayrollProcessed.PayrollYear}=" & Me.cboYear.Text.Trim & ")"

                frmResultsViewing.crtViewResultsSummary.ReportSource = RptResultsView
                frmResultsViewing.crtViewResultsSummary.Zoom(100)
                frmResultsViewing.crtViewResultsSummary.RefreshReport()
                frmResultsViewing.MdiParent = frmHome
                frmResultsViewing.Show()
                Me.Cursor = Cursors.Arrow
            End If
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Me.lstPayslips.Items.Count <= 0 Then
            MsgBox("Load items in the list before printing.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly + MsgBoxStyle.ApplicationModal, "System Reply")
            Exit Sub
        ElseIf Me.lstPayslips.CheckedItems.Count <= 0 Then
            MsgBox("Check the items to print.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly + MsgBoxStyle.ApplicationModal, "System Reply")
            Exit Sub
        Else
            Dim result As MsgBoxResult = MsgBox("Print Selected Items?", MsgBoxStyle.Question + MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo, "Confirm Transaction")
            If result = MsgBoxResult.No Then
                Exit Sub
            End If
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                dbconnection()
                Me.Cursor = Cursors.WaitCursor

                j = 1


                For i = 0 To Me.lstPayslips.CheckedItems.Count - 1
                    Dim RptResultsView As New crtPayrollPayslipReport
                    SetReportLogOn(RptResultsView)

                    Dim ReportPrintOptions As PrintOptions = RptResultsView.PrintOptions
                    Dim ReportPrinter As New PrinterSettings
                    ReportPrintOptions.PrinterName = ReportPrinter.PrinterName
                    ReportPrintOptions.PaperOrientation = PaperOrientation.DefaultPaperOrientation
                    ReportPrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                    Dim margins As New CrystalDecisions.Shared.PageMargins(0, 300, 10, 10) ' Left=0, Right=300 (shift to left)
                    ReportPrintOptions.ApplyPageMargins(margins)
                    ReportPrintOptions.PrinterDuplex = PrinterDuplex.Default
                    RptResultsView.SummaryInfo.ReportComments = fullName.Trim
                    RptResultsView.RecordSelectionFormula = "({vwPayrollProcessed.EmpId}=" & Me.lstPayslips.CheckedItems(i).Tag & ")"
                    RptResultsView.RecordSelectionFormula += "AND ({vwPayrollProcessed.PayrollMonth}=" & Me.cboMonth.Text.Trim & ")"
                    RptResultsView.RecordSelectionFormula += "AND ({vwPayrollProcessed.PayrollYear}=" & Me.cboYear.Text.Trim & ")"

                    RptResultsView.PrintToPrinter(1, True, 1, 1)
                    Me.ToolStripStatusLabel4.Text = "Printing...." & j & " Of " & Me.lstPayslips.CheckedItems.Count & " Payslips."
                    j = j + 1
                Next
                Me.ToolStripStatusLabel4.Text = "Printing Complete"
                Me.Cursor = Cursors.Arrow

                Me.lstPayslips.Items.Clear()
                Me.ToolStripStatusLabel4.Text = "Printing Status"

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