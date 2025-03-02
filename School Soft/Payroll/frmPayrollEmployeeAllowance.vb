Imports System.Data.SqlClient

Public Class frmPayrollEmployeeAllowance
    Dim duplicateFound As Boolean = True
    Dim cmdEmployeeAllowances As New SqlCommand
    Dim reader As SqlDataReader
    Dim rec As Integer = 0
    Dim queryType As String = Nothing
    Private Sub frmPayrollEmployeeAllowance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCombos()
    End Sub

    Private Sub frmPayrollEmployeeAllowance_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If Me.IsMdiChild Then
            Dim PnlLoc As New Point
            PnlLoc.X = CInt((Me.Width - Me.TableLayoutPanel1.Width) / 2)
            PnlLoc.Y = CInt((Me.Height - Me.TableLayoutPanel1.Height) / 2.5)
            Me.TableLayoutPanel1.Location = PnlLoc
        Else
            Me.TableLayoutPanel1.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub loadCombos()
        Try
            Me.cboEmployeeName.Items.Clear()
            Me.cboEmployeeName.Text = ""
            Me.cboEmployeeName.SelectedIndex = -1
            Me.cboEmployeeName.DisplayMember = "Value"
            Me.cboEmployeeName.ValueMember = "Key"

            Me.cboAllowanceName.Items.Clear()
            Me.cboAllowanceName.Text = ""
            Me.cboAllowanceName.SelectedIndex = -1
            Me.cboAllowanceName.DisplayMember = "Value"
            Me.cboAllowanceName.ValueMember = "Key"

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollEmployeeAllowances.Items.Clear()

            cmdEmployeeAllowances.Connection = conn
            cmdEmployeeAllowances.CommandText = "SELECT * FROM tblSchoolStaff Where Status=1 ORDER BY FullName"
            cmdEmployeeAllowances.CommandType = CommandType.Text
            cmdEmployeeAllowances.Parameters.Clear()
            reader = Me.cmdEmployeeAllowances.ExecuteReader
            While reader.Read
                Me.cboEmployeeName.Items.Add(New DictionaryEntry(reader!empId, IIf(DBNull.Value.Equals(reader!FullName), "", reader!FullName)))
            End While
            reader.Close()

            cmdEmployeeAllowances.Connection = conn
            cmdEmployeeAllowances.CommandText = "SELECT * FROM tblPayrollAllowances Where AllEmployees=0 ORDER BY Name"
            cmdEmployeeAllowances.CommandType = CommandType.Text
            cmdEmployeeAllowances.Parameters.Clear()
            reader = Me.cmdEmployeeAllowances.ExecuteReader
            While reader.Read
                Me.cboAllowanceName.Items.Add(New DictionaryEntry(reader!Id, IIf(DBNull.Value.Equals(reader!Name), "", reader!Name)))
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

    Private Sub cboEmployeeName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmployeeName.SelectedIndexChanged
        If Me.cboEmployeeName.SelectedIndex = -1 Or Me.cboEmployeeName.Text = "" Then
            Exit Sub
        End If
        ClearTextControls()
        Me.cboAllowanceName.SelectedIndex = -1
        Me.cboAllowanceName.Text = ""
        loadEmployeeDetails(Me.cboEmployeeName.SelectedItem.Key)
        loadAllowances(Me.cboEmployeeName.SelectedItem.Key)
    End Sub

    Private Sub ClearTextControls()
        Me.txtAbbreviation.Clear()
        Me.txtAmount.Clear()
        Me.txtContractType.Clear()
        Me.txtEmployeeNo.Clear()
        Me.txtEmployeeType.Clear()
    End Sub

    Private Sub loadAllowances(ByVal empId As Integer)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollEmployeeAllowances.Items.Clear()
            cmdEmployeeAllowances.Connection = conn
            cmdEmployeeAllowances.CommandText = "SELECT * FROM vwPayrollEmployeeAllowance WHERE (EmpId=@EmpId) AND (Status=1)  ORDER BY Name"
            cmdEmployeeAllowances.CommandType = CommandType.Text
            cmdEmployeeAllowances.Parameters.Clear()
            cmdEmployeeAllowances.Parameters.AddWithValue("@EmpId", empId)
            reader = cmdEmployeeAllowances.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    li = Me.lstPayrollEmployeeAllowances.Items.Add(IIf(DBNull.Value.Equals(reader!Name), "", reader!Name))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!Abbreviation), "", reader!Abbreviation))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!Amount), "", reader!Amount))
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

    Private Sub loadEmployeeDetails(ByVal empId As Integer)

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollEmployeeAllowances.Items.Clear()
            cmdEmployeeAllowances.Connection = conn
            cmdEmployeeAllowances.CommandText = "SELECT * FROM tblSchoolStaff WHERE (EmpId=@EmpId) AND (Status=1)"
            cmdEmployeeAllowances.CommandType = CommandType.Text
            cmdEmployeeAllowances.Parameters.Clear()
            cmdEmployeeAllowances.Parameters.AddWithValue("@EmpId", empId)
            reader = cmdEmployeeAllowances.ExecuteReader
            If reader.Read() Then
                Me.txtEmployeeNo.Text = IIf(DBNull.Value.Equals(reader!empNo), "", reader!empNo)
                Me.txtEmployeeType.Text = IIf(DBNull.Value.Equals(reader!empType), "", reader!empType)
                Me.txtContractType.Text = IIf(DBNull.Value.Equals(reader!contractType), "", reader!contractType)
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

    Private Sub cboAllowanceName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAllowanceName.SelectedIndexChanged
        If Me.cboAllowanceName.SelectedIndex = -1 Or Me.cboAllowanceName.Text = "" Then
            Exit Sub
        End If
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            cmdEmployeeAllowances.Connection = conn
            cmdEmployeeAllowances.CommandText = "SELECT * FROM tblPayrollAllowances WHERE (Id=@Id)"
            cmdEmployeeAllowances.CommandType = CommandType.Text
            cmdEmployeeAllowances.Parameters.Clear()
            cmdEmployeeAllowances.Parameters.AddWithValue("@Id", Me.cboAllowanceName.SelectedItem.Key)
            reader = cmdEmployeeAllowances.ExecuteReader
            If reader.Read() Then
                Me.txtAbbreviation.Text = IIf(DBNull.Value.Equals(reader!Abbreviation), "", reader!Abbreviation)
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
        Me.ClearTextControls()
        Me.cboEmployeeName.SelectedIndex = -1
        Me.cboAllowanceName.Text = ""
        Me.cboAllowanceName.SelectedIndex = -1
        Me.cboAllowanceName.Text = ""
        Me.lstPayrollEmployeeAllowances.Items.Clear()
        Me.btnSave.Text = "Save New"
    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click
        If Me.lstPayrollEmployeeAllowances.SelectedItems.Count = 1 Then

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                dbconnection()

                cmdEmployeeAllowances.Connection = conn
                cmdEmployeeAllowances.CommandText = "SELECT * FROM vwPayrollEmployeeAllowance WHERE (Id=@Id)"
                cmdEmployeeAllowances.CommandType = CommandType.Text
                cmdEmployeeAllowances.Parameters.Clear()
                cmdEmployeeAllowances.Parameters.AddWithValue("@Id", Me.lstPayrollEmployeeAllowances.SelectedItems(0).Tag)
                reader = cmdEmployeeAllowances.ExecuteReader
                If reader.Read() Then
                    Me.cboEmployeeName.Text = IIf(DBNull.Value.Equals(reader!FullName), "", reader!FullName)
                    Me.txtEmployeeNo.Text = IIf(DBNull.Value.Equals(reader!empNo), "", reader!empNo)
                    Me.txtEmployeeType.Text = IIf(DBNull.Value.Equals(reader!empType), "", reader!empType)
                    Me.txtContractType.Text = IIf(DBNull.Value.Equals(reader!contractType), "", reader!contractType)
                    Me.txtAbbreviation.Text = IIf(DBNull.Value.Equals(reader!Abbreviation), "", reader!Abbreviation)
                    Me.txtAmount.Text = IIf(DBNull.Value.Equals(reader!Amount), "", reader!Amount)
                    Me.cboEmployeeName.Tag = IIf(DBNull.Value.Equals(reader!Id), "", reader!Id)
                    Me.cboAllowanceName.Text = IIf(DBNull.Value.Equals(reader!Name), "", reader!Name)
                    Me.btnSave.Text = "Update"
                End If
                reader.Close()
                Me.lstPayrollEmployeeAllowances.Items.Clear()
            Catch ex As Exception
                MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        Else
            Me.btnSave.Text = "Save New"
        End If
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        If Me.lstPayrollEmployeeAllowances.Items.Count <= 0 Then
            MsgBox("No items in the list.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollEmployeeAllowances.SelectedItems.Count <= 0 Then
            MsgBox("Select the item to delete.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollEmployeeAllowances.SelectedItems.Count > 1 Then
            MsgBox("Select One item at a time for deletion.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        If Me.lstPayrollEmployeeAllowances.SelectedItems.Count = 1 Then
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
                Me.cmdEmployeeAllowances.Connection = conn
                Me.cmdEmployeeAllowances.CommandType = CommandType.StoredProcedure
                Me.cmdEmployeeAllowances.CommandText = "sprocPayrollEmployeeAllowance"
                Me.cmdEmployeeAllowances.Parameters.Clear()
                Me.cmdEmployeeAllowances.Parameters.AddWithValue("@EmpId", lstPayrollEmployeeAllowances.SelectedItems(0).Tag)
                Me.cmdEmployeeAllowances.Parameters.AddWithValue("@AllowanceId", lstPayrollEmployeeAllowances.SelectedItems(0).Tag)
                Me.cmdEmployeeAllowances.Parameters.AddWithValue("@Amount", lstPayrollEmployeeAllowances.SelectedItems(0).SubItems(2).Text)
                Me.cmdEmployeeAllowances.Parameters.AddWithValue("@regBy", userName.Trim)
                Me.cmdEmployeeAllowances.Parameters.AddWithValue("@queryType", queryType)
                Me.cmdEmployeeAllowances.Parameters.AddWithValue("@Id", lstPayrollEmployeeAllowances.SelectedItems(0).Tag)
                rec = Me.cmdEmployeeAllowances.ExecuteNonQuery
                MsgBox("Record Deleted", MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "SuccessFull Transaction")
                loadAllowances(Me.cboEmployeeName.SelectedItem.Key)
            Catch ex As Exception
                MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim amountTry As Single
        If Me.cboEmployeeName.SelectedIndex < 0 Or Me.cboEmployeeName.Text = "" Then
            MsgBox("Select employee name.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.cboAllowanceName.SelectedIndex < 0 Or Me.cboAllowanceName.Text = "" Then
            MsgBox("Select allowance name.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtAmount.Text.Trim.Length <= 0 Then
            MsgBox("Allowance amount is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Not Single.TryParse(Me.txtAmount.Text, amountTry) Then
            MsgBox("Enter correct amount.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Me.txtAmount.Clear()
            Exit Sub
        End If

        For i = 0 To Me.lstPayrollEmployeeAllowances.Items.Count - 1
            If Me.cboAllowanceName.Text.Trim = Me.lstPayrollEmployeeAllowances.Items(i).Text.Trim Then
                MsgBox("Allowance already added for the employee.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
                Exit Sub
            End If
        Next

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
            Me.cmdEmployeeAllowances.Connection = conn
            Me.cmdEmployeeAllowances.CommandType = CommandType.StoredProcedure
            Me.cmdEmployeeAllowances.CommandText = "sprocPayrollEmployeeAllowance"
            Me.cmdEmployeeAllowances.Parameters.Clear()
            Me.cmdEmployeeAllowances.Parameters.AddWithValue("@EmpId", Me.cboEmployeeName.SelectedItem.Key)
            Me.cmdEmployeeAllowances.Parameters.AddWithValue("@AllowanceId", Me.cboAllowanceName.SelectedItem.Key)
            Me.cmdEmployeeAllowances.Parameters.AddWithValue("@Amount", Me.txtAmount.Text)
            Me.cmdEmployeeAllowances.Parameters.AddWithValue("@regBy", userName.Trim)
            Me.cmdEmployeeAllowances.Parameters.AddWithValue("@queryType", queryType)
            If Me.btnSave.Text = "Update" Then
                Me.cmdEmployeeAllowances.Parameters.AddWithValue("@Id", Me.cboEmployeeName.Tag)
            End If
            rec = Me.cmdEmployeeAllowances.ExecuteNonQuery
            If rec > 0 Then
                MsgBox(If(Me.btnSave.Text = "Update", "Record Updated", "Record Saved"), MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "SuccessFull Transaction")
            End If
            Me.btnSave.Text = "Save New"
            Me.loadAllowances(Me.cboEmployeeName.SelectedItem.Key)
            Me.cboAllowanceName.SelectedIndex = -1
            Me.cboAllowanceName.Text = ""
            Me.txtAbbreviation.Clear()
            Me.txtAmount.Clear()
        Catch ex As Exception
            MsgBox(Err.GetException.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class