Imports System.Data.SqlClient

Public Class frmPayrollEmployeePayroll
    Dim duplicateFound As Boolean = True
    Dim cmdEmployeePayroll As New SqlCommand
    Dim reader As SqlDataReader
    Dim rec As Integer = 0
    Dim queryType As String = Nothing
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPayrollEmployeePayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCombos()
    End Sub

    Private Sub loadCombos()
        Try
            Me.cboPayrollYear.Items.Clear()
            Me.cboPayrollYear.Text = ""
            Me.cboPayrollYear.SelectedIndex = -1
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollEmployeePayroll.Items.Clear()

            cmdEmployeePayroll.Connection = conn
            cmdEmployeePayroll.CommandText = "SELECT DISTINCT PayrollYear FROM tblPayrollRegister ORDER BY PayrollYear"
            cmdEmployeePayroll.CommandType = CommandType.Text
            cmdEmployeePayroll.Parameters.Clear()
            reader = Me.cmdEmployeePayroll.ExecuteReader
            While reader.Read
                Me.cboPayrollYear.Items.Add(IIf(DBNull.Value.Equals(reader!PayrollYear), "", reader!PayrollYear))
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

    Private Sub ClearTexts()
        Me.txtPayrollName.Text = ""
        Me.txtPayrollName.Tag = ""
        Me.txtStartDate.Text = ""
        Me.txtEndDate.Text = ""
    End Sub
    Private Sub cboPayrollYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPayrollYear.SelectedIndexChanged
        If Me.cboPayrollYear.SelectedIndex = -1 Or Me.cboPayrollYear.Text = "" Then
            Exit Sub
        End If
        Try
            Me.cboPayrollMonth.Items.Clear()
            Me.cboPayrollMonth.Text = ""
            Me.cboPayrollMonth.SelectedIndex = -1

            ClearTexts()

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollEmployeePayroll.Items.Clear()

            cmdEmployeePayroll.Connection = conn
            cmdEmployeePayroll.CommandText = "SELECT PayrollMonth FROM tblPayrollRegister ORDER BY PayrollMonth"
            cmdEmployeePayroll.CommandType = CommandType.Text
            cmdEmployeePayroll.Parameters.Clear()
            reader = Me.cmdEmployeePayroll.ExecuteReader
            While reader.Read
                Me.cboPayrollMonth.Items.Add(IIf(DBNull.Value.Equals(reader!PayrollMonth), "", reader!PayrollMonth))
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

    Private Sub cboPayrollMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPayrollMonth.SelectedIndexChanged
        If Me.cboPayrollMonth.Text = "" Or Me.cboPayrollMonth.SelectedIndex = -1 Then
            Exit Sub
        End If
        If Me.cboPayrollMonth.SelectedIndex = -1 Or Me.cboPayrollMonth.Text = "" Then
            MsgBox("Select payroll year first.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        Try
            ClearTexts()

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollEmployeePayroll.Items.Clear()

            cmdEmployeePayroll.Connection = conn
            cmdEmployeePayroll.CommandText = "SELECT * FROM tblPayrollRegister WHERE (PayrollMonth=@PayrollMonth) AND (PayrollYear=@PayrollYear)"
            cmdEmployeePayroll.CommandType = CommandType.Text
            cmdEmployeePayroll.Parameters.Clear()
            cmdEmployeePayroll.Parameters.AddWithValue("@PayrollMonth", Me.cboPayrollMonth.Text)
            cmdEmployeePayroll.Parameters.AddWithValue("@PayrollYear", Me.cboPayrollYear.Text)
            reader = Me.cmdEmployeePayroll.ExecuteReader
            While reader.Read
                Me.txtPayrollName.Text = IIf(DBNull.Value.Equals(reader!PayrollName), "", reader!PayrollName)
                Me.txtPayrollName.Tag = IIf(DBNull.Value.Equals(reader!Id), "", reader!Id)
                Me.txtStartDate.Text = IIf(DBNull.Value.Equals(reader!StartDate), "", reader!StartDate)
                Me.txtEndDate.Text = IIf(DBNull.Value.Equals(reader!EndDate), "", reader!EndDate)
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

    Private Sub btnRunPayroll_Click(sender As Object, e As EventArgs) Handles btnRunPayroll.Click
        If Me.cboPayrollYear.SelectedIndex = -1 Or Me.cboPayrollYear.Text = "" Then
            MsgBox("Select payroll year.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.cboPayrollMonth.SelectedIndex = -1 Or Me.cboPayrollMonth.Text = "" Then
            MsgBox("Select payroll month.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtPayrollName.Tag Is Nothing Then
            MsgBox("Select payroll month and year first.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        If checkIfPayrollRun(Me.txtPayrollName.Tag) Then
            Dim result As MsgBoxResult = MsgBox("Payroll already run. Re-running the payroll will delete the records for the run payroll. " +
                                                "Are you sure you want to continue?", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo, "Confirm Transaction")
            If result = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Try
            Dim result As MsgBoxResult = MsgBox("Are you sure you want to run payroll for month " +
                                                Me.cboPayrollMonth.Text + " and year " + Me.cboPayrollYear.Text + "?",
                                                MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo, "Confirm Transaction")
            If result = MsgBoxResult.No Then
                Exit Sub
            End If
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            rec = 0
            Me.cmdEmployeePayroll.Connection = conn
            Me.cmdEmployeePayroll.CommandType = CommandType.StoredProcedure
            Me.cmdEmployeePayroll.CommandText = "sprocPayrollEmployeePayroll"
            Me.cmdEmployeePayroll.Parameters.Clear()
            Me.cmdEmployeePayroll.Parameters.AddWithValue("@PayrollId", Me.txtPayrollName.Tag)
            Me.cmdEmployeePayroll.Parameters.AddWithValue("@regBy", userName.Trim)
            Me.cmdEmployeePayroll.Parameters.AddWithValue("@year", Me.cboPayrollYear.Text.Trim)
            rec = Me.cmdEmployeePayroll.ExecuteNonQuery
            If rec > 0 Then
                MsgBox("Payroll run completed successfully!", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "SuccessFull Transaction")
            End If
            loadPayrollDetails(Me.txtPayrollName.Tag)
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Function checkIfPayrollRun(ByVal payrollId As Integer) As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            cmdEmployeePayroll.Connection = conn
            cmdEmployeePayroll.CommandType = CommandType.Text
            cmdEmployeePayroll.CommandText = "SELECT * FROM tblPayrollEmployeePayroll WHERE (PayrollId=@PayrollId)"
            cmdEmployeePayroll.Parameters.Clear()
            cmdEmployeePayroll.Parameters.AddWithValue("@PayrollId", payrollId)
            reader = cmdEmployeePayroll.ExecuteReader
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

    Private Sub loadPayrollDetails(ByVal payrollId As Integer)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollEmployeePayroll.Items.Clear()
            cmdEmployeePayroll.Connection = conn
            cmdEmployeePayroll.CommandText = "SELECT * FROM vwPayrollProcessed WHERE (PayrollId=@PayrollId)"
            cmdEmployeePayroll.CommandType = CommandType.Text
            cmdEmployeePayroll.Parameters.Clear()
            cmdEmployeePayroll.Parameters.AddWithValue("@PayrollId", payrollId)
            reader = cmdEmployeePayroll.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    li = Me.lstPayrollEmployeePayroll.Items.Add(IIf(DBNull.Value.Equals(reader!PayrollName), "", reader!PayrollName))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!PayrollMonth), "", reader!PayrollMonth))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!PayrollYear), "", reader!PayrollYear))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!empNo), "", reader!empNo))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!FullName), "", reader!FullName))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!BasicSalary), "", reader!BasicSalary))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!OtherAllowances), "", reader!OtherAllowances))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!GrossSalary), "", reader!GrossSalary))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!SHA), "", reader!SHA))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!Housing), "", reader!Housing))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!NSSF1), "", reader!NSSF1))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!NSSF2), "", reader!NSSF2))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!IncomeTax), "", reader!IncomeTax))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!PersonalRelief), "", reader!PersonalRelief))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!PAYE), "", reader!PAYE))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!TaxableIncome), "", reader!TaxableIncome))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!OtherDeductions), "", reader!OtherDeductions))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!TotalDeductions), "", reader!TotalDeductions))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!NetSalary), "", reader!NetSalary))
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

    Private Sub frmPayrollEmployeePayroll_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If Me.IsMdiChild Then
            Dim PnlLoc As New Point
            PnlLoc.X = CInt((Me.Width - Me.TableLayoutPanel1.Width) / 2)
            PnlLoc.Y = CInt((Me.Height - Me.TableLayoutPanel1.Height) / 2.5)
            Me.TableLayoutPanel1.Location = PnlLoc
        Else
            Me.TableLayoutPanel1.Dock = DockStyle.Fill
        End If
    End Sub
End Class