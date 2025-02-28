Imports System.Data.SqlClient

Public Class frmPayrollAllowances
    Dim duplicateFound As Boolean = True
    Dim cmdPayrollAllowances As New SqlCommand
    Dim reader As SqlDataReader
    Dim rec As Integer = 0
    Dim queryType As String = Nothing
    Private Sub frmPayrollAllowances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadList()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.ClearControls()
        Me.btnSave.Text = "Save New"
    End Sub

    Private Sub ClearControls()
        Me.txtAllowanceName.Clear()
        Me.txtAbbreviation.Clear()
        Me.txtAmount.Clear()
        Me.txtComments.Clear()
        Me.cboAllowanceType.SelectedIndex = -1
        Me.cboAllowanceTable.SelectedIndex = -1
        Me.cbAppliesToAll.Checked = False
        Me.cbTaxDeductible.Checked = False
        Me.cbStatutoryAllowance.Checked = False
    End Sub

    Private Sub loadList()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollAllowances.Items.Clear()
            cmdPayrollAllowances.Connection = conn
            cmdPayrollAllowances.CommandText = "SELECT * FROM tblPayrollAllowances ORDER BY Name"
            cmdPayrollAllowances.CommandType = CommandType.Text
            cmdPayrollAllowances.Parameters.Clear()
            reader = cmdPayrollAllowances.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    li = Me.lstPayrollAllowances.Items.Add(IIf(DBNull.Value.Equals(reader!Name), "", reader!Name))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!Abbreviation), "", reader!Abbreviation))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!AllowanceType), "", reader!AllowanceType))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!AllowanceTable), "", reader!AllowanceTable))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!Amount), "", reader!Amount))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!TaxDeductible), "", reader!TaxDeductible))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!AllEmployees), "", reader!AllEmployees))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!Statutory), "", reader!Statutory))
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

    Private Sub frmPayrollAllowances_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If Me.IsMdiChild Then
            Dim PnlLoc As New Point
            PnlLoc.X = CInt((Me.Width - Me.TableLayoutPanel1.Width) / 2)
            PnlLoc.Y = CInt((Me.Height - Me.TableLayoutPanel1.Height) / 2.5)
            Me.TableLayoutPanel1.Location = PnlLoc
        Else
            Me.TableLayoutPanel1.Dock = DockStyle.Fill
        End If
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
        If Me.txtAllowanceName.Text.Trim.Length <= 0 Then
            MsgBox("Allowance name is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtAbbreviation.Text.Trim.Length <= 0 Then
            MsgBox("Abbreviation is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.cboAllowanceType.Text.Trim.Length <= 0 Then
            MsgBox("Allowance type is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.cboAllowanceType.Text = "Check Table" And Me.cboAllowanceTable.Text = "" Then
            MsgBox("Select check table.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtAmount.Text.Trim.Length <= 0 And Not Me.cboAllowanceType.Text = "Check Table" Then
            MsgBox("Allowance value or amount is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
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
            Me.cmdPayrollAllowances.Connection = conn
            Me.cmdPayrollAllowances.CommandType = CommandType.StoredProcedure
            Me.cmdPayrollAllowances.CommandText = "sprocPayrollAllowances"
            Me.cmdPayrollAllowances.Parameters.Clear()
            Me.cmdPayrollAllowances.Parameters.AddWithValue("@Name", Me.txtAllowanceName.Text.Trim)
            Me.cmdPayrollAllowances.Parameters.AddWithValue("@Abbreviation", Me.txtAbbreviation.Text.Trim)
            Me.cmdPayrollAllowances.Parameters.AddWithValue("@AllowanceType", Me.cboAllowanceType.Text)
            Me.cmdPayrollAllowances.Parameters.AddWithValue("@AllowanceTable", Me.cboAllowanceTable.Text)
            Me.cmdPayrollAllowances.Parameters.AddWithValue("@Amount", IIf(Me.txtAmount.Text = "", 0, Me.txtAmount.Text))
            Me.cmdPayrollAllowances.Parameters.AddWithValue("@TaxDeductible", Me.cbTaxDeductible.Checked)
            Me.cmdPayrollAllowances.Parameters.AddWithValue("@AllEmployees", Me.cbAppliesToAll.Checked)
            Me.cmdPayrollAllowances.Parameters.AddWithValue("@Statutory", Me.cbStatutoryAllowance.Checked)
            Me.cmdPayrollAllowances.Parameters.AddWithValue("@Comments", Me.txtComments.Text.Trim)
            Me.cmdPayrollAllowances.Parameters.AddWithValue("@regBy", userName.Trim)
            Me.cmdPayrollAllowances.Parameters.AddWithValue("@queryType", queryType)
            If Me.btnSave.Text = "Update" Then
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@Id", Me.txtAllowanceName.Tag)
            End If
            rec = Me.cmdPayrollAllowances.ExecuteNonQuery
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

    Private Sub CLOSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click
        If Me.lstPayrollAllowances.Items.Count <= 0 Then
            MsgBox("No items in the list.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollAllowances.SelectedItems.Count <= 0 Then
            MsgBox("Select the item to delete.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollAllowances.SelectedItems.Count > 1 Then
            MsgBox("Select One item at a time for updating.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        If Me.lstPayrollAllowances.SelectedItems.Count = 1 Then
            Me.txtAllowanceName.Text = Me.lstPayrollAllowances.SelectedItems(0).Text
            Me.txtAbbreviation.Text = Me.lstPayrollAllowances.SelectedItems(0).SubItems(1).Text
            Me.cboAllowanceType.Text = Me.lstPayrollAllowances.SelectedItems(0).SubItems(2).Text
            Me.cboAllowanceTable.Text = Me.lstPayrollAllowances.SelectedItems(0).SubItems(3).Text
            Me.txtAmount.Text = Me.lstPayrollAllowances.SelectedItems(0).SubItems(4).Text
            Me.cbTaxDeductible.Checked = Me.lstPayrollAllowances.SelectedItems(0).SubItems(5).Text
            Me.cbAppliesToAll.Checked = Me.lstPayrollAllowances.SelectedItems(0).SubItems(6).Text
            Me.cbStatutoryAllowance.Checked = Me.lstPayrollAllowances.SelectedItems(0).SubItems(7).Text
            Me.txtComments.Text = Me.lstPayrollAllowances.SelectedItems(0).Name
            Me.txtAllowanceName.Tag = Me.lstPayrollAllowances.SelectedItems(0).Tag
            Me.btnSave.Text = "Update"
            Me.lstPayrollAllowances.Items.Clear()
        End If
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        If Me.lstPayrollAllowances.Items.Count <= 0 Then
            MsgBox("No items in the list.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollAllowances.SelectedItems.Count <= 0 Then
            MsgBox("Select the item to delete.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollAllowances.SelectedItems.Count > 1 Then
            MsgBox("Select One item at a time for deletion.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        If Me.lstPayrollAllowances.SelectedItems.Count = 1 Then
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
                Me.cmdPayrollAllowances.Connection = conn
                Me.cmdPayrollAllowances.CommandType = CommandType.StoredProcedure
                Me.cmdPayrollAllowances.CommandText = "sprocPayrollAllowances"
                Me.cmdPayrollAllowances.Parameters.Clear()
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@Name", Me.lstPayrollAllowances.SelectedItems(0).Text)
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@Abbreviation", Me.lstPayrollAllowances.SelectedItems(0).SubItems(1).Text)
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@AllowanceType", Me.lstPayrollAllowances.SelectedItems(0).SubItems(2).Text)
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@AllowanceTable", Me.lstPayrollAllowances.SelectedItems(0).SubItems(3).Text)
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@Amount", Me.lstPayrollAllowances.SelectedItems(0).SubItems(4).Text)
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@TaxDeductible", Me.lstPayrollAllowances.SelectedItems(0).SubItems(5).Text)
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@AllEmployees", Me.lstPayrollAllowances.SelectedItems(0).SubItems(6).Text)
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@Statutory", Me.lstPayrollAllowances.SelectedItems(0).SubItems(7).Text)
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@Comments", Me.lstPayrollAllowances.SelectedItems(0).Name)
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@regBy", userName.Trim)
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@queryType", queryType)
                Me.cmdPayrollAllowances.Parameters.AddWithValue("@Id", Me.lstPayrollAllowances.SelectedItems(0).Tag)
                rec = Me.cmdPayrollAllowances.ExecuteNonQuery
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

    Private Sub cboAllowanceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAllowanceType.SelectedIndexChanged
        If Me.cboAllowanceType.Text = "Check Table" Then
            Me.cboAllowanceTable.Enabled = True
            Me.txtAmount.Enabled = False
        ElseIf Me.cboAllowanceType.Text = "Percentage" Or Me.cboAllowanceType.Text = "Amount" Then
            Me.cboAllowanceTable.Enabled = False
            Me.txtAmount.Enabled = True
        Else
            Me.cboAllowanceTable.Enabled = False
            Me.txtAmount.Enabled = False
        End If
    End Sub
End Class