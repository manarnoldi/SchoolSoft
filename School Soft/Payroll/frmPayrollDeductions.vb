Imports System.Data.SqlClient

Public Class frmPayrollDeductions
    Dim duplicateFound As Boolean = True
    Dim cmdPayrollDeductions As New SqlCommand
    Dim reader As SqlDataReader
    Dim rec As Integer = 0
    Dim queryType As String = Nothing
    Private Sub frmPayrollDeductions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.txtDeductionName.Clear()
        Me.txtAbbreviation.Clear()
        Me.txtAmount.Clear()
        Me.txtComments.Clear()
        Me.cboDeductionType.SelectedIndex = -1
        Me.cboDeductionTable.SelectedIndex = -1
        Me.cbAppliesToAll.Checked = False
        Me.cbTaxDeductible.Checked = False
        Me.cbStatutoryDeduction.Checked = False
    End Sub

    Private Sub loadList()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollDeductions.Items.Clear()
            cmdPayrollDeductions.Connection = conn
            cmdPayrollDeductions.CommandText = "SELECT * FROM tblPayrollDeductions ORDER BY Name"
            cmdPayrollDeductions.CommandType = CommandType.Text
            cmdPayrollDeductions.Parameters.Clear()
            reader = cmdPayrollDeductions.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    li = Me.lstPayrollDeductions.Items.Add(IIf(DBNull.Value.Equals(reader!Name), "", reader!Name))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!Abbreviation), "", reader!Abbreviation))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!DeductionType), "", reader!DeductionType))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!DeductionTable), "", reader!DeductionTable))
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

    Private Sub frmPayrollDeductions_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
        If Me.txtDeductionName.Text.Trim.Length <= 0 Then
            MsgBox("Deduction name is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtAbbreviation.Text.Trim.Length <= 0 Then
            MsgBox("Abbreviation is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.cboDeductionType.Text.Trim.Length <= 0 Then
            MsgBox("Deduction type is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.cboDeductionType.Text = "Check Table" And Me.cboDeductionTable.Text = "" Then
            MsgBox("Select check table.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtAmount.Text.Trim.Length <= 0 And Not Me.cboDeductionType.Text = "Check Table" Then
            MsgBox("Deduction value or amount is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
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
            Me.cmdPayrollDeductions.Connection = conn
            Me.cmdPayrollDeductions.CommandType = CommandType.StoredProcedure
            Me.cmdPayrollDeductions.CommandText = "sprocPayrollDeductions"
            Me.cmdPayrollDeductions.Parameters.Clear()
            Me.cmdPayrollDeductions.Parameters.AddWithValue("@Name", Me.txtDeductionName.Text.Trim)
            Me.cmdPayrollDeductions.Parameters.AddWithValue("@Abbreviation", Me.txtAbbreviation.Text.Trim)
            Me.cmdPayrollDeductions.Parameters.AddWithValue("@DeductionType", Me.cboDeductionType.Text)
            Me.cmdPayrollDeductions.Parameters.AddWithValue("@DeductionTable", Me.cboDeductionTable.Text)
            Me.cmdPayrollDeductions.Parameters.AddWithValue("@Amount", IIf(Me.txtAmount.Text = "", 0, Me.txtAmount.Text))
            Me.cmdPayrollDeductions.Parameters.AddWithValue("@TaxDeductible", Me.cbTaxDeductible.Checked)
            Me.cmdPayrollDeductions.Parameters.AddWithValue("@AllEmployees", Me.cbAppliesToAll.Checked)
            Me.cmdPayrollDeductions.Parameters.AddWithValue("@Statutory", Me.cbStatutoryDeduction.Checked)
            Me.cmdPayrollDeductions.Parameters.AddWithValue("@Comments", Me.txtComments.Text.Trim)
            Me.cmdPayrollDeductions.Parameters.AddWithValue("@regBy", userName.Trim)
            Me.cmdPayrollDeductions.Parameters.AddWithValue("@queryType", queryType)
            If Me.btnSave.Text = "Update" Then
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@Id", Me.txtDeductionName.Tag)
            End If
            rec = Me.cmdPayrollDeductions.ExecuteNonQuery
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
        If Me.lstPayrollDeductions.Items.Count <= 0 Then
            MsgBox("No items in the list.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollDeductions.SelectedItems.Count <= 0 Then
            MsgBox("Select the item to delete.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollDeductions.SelectedItems.Count > 1 Then
            MsgBox("Select One item at a time for updating.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        If Me.lstPayrollDeductions.SelectedItems.Count = 1 Then
            Me.txtDeductionName.Text = Me.lstPayrollDeductions.SelectedItems(0).Text
            Me.txtAbbreviation.Text = Me.lstPayrollDeductions.SelectedItems(0).SubItems(1).Text
            Me.cboDeductionType.Text = Me.lstPayrollDeductions.SelectedItems(0).SubItems(2).Text
            Me.cboDeductionTable.Text = Me.lstPayrollDeductions.SelectedItems(0).SubItems(3).Text
            Me.txtAmount.Text = Me.lstPayrollDeductions.SelectedItems(0).SubItems(4).Text
            Me.cbTaxDeductible.Checked = Me.lstPayrollDeductions.SelectedItems(0).SubItems(5).Text
            Me.cbAppliesToAll.Checked = Me.lstPayrollDeductions.SelectedItems(0).SubItems(6).Text
            Me.cbStatutoryDeduction.Checked = Me.lstPayrollDeductions.SelectedItems(0).SubItems(7).Text
            Me.txtComments.Text = Me.lstPayrollDeductions.SelectedItems(0).Name
            Me.txtDeductionName.Tag = Me.lstPayrollDeductions.SelectedItems(0).Tag
            Me.btnSave.Text = "Update"
            Me.lstPayrollDeductions.Items.Clear()
        End If
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        If Me.lstPayrollDeductions.Items.Count <= 0 Then
            MsgBox("No items in the list.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollDeductions.SelectedItems.Count <= 0 Then
            MsgBox("Select the item to delete.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.lstPayrollDeductions.SelectedItems.Count > 1 Then
            MsgBox("Select One item at a time for deletion.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        End If
        If Me.lstPayrollDeductions.SelectedItems.Count = 1 Then
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
                Me.cmdPayrollDeductions.Connection = conn
                Me.cmdPayrollDeductions.CommandType = CommandType.StoredProcedure
                Me.cmdPayrollDeductions.CommandText = "sprocPayrollDeductions"
                Me.cmdPayrollDeductions.Parameters.Clear()
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@Name", Me.lstPayrollDeductions.SelectedItems(0).Text)
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@Abbreviation", Me.lstPayrollDeductions.SelectedItems(0).SubItems(1).Text)
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@DeductionType", Me.lstPayrollDeductions.SelectedItems(0).SubItems(2).Text)
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@DeductionTable", Me.lstPayrollDeductions.SelectedItems(0).SubItems(3).Text)
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@Amount", Me.lstPayrollDeductions.SelectedItems(0).SubItems(4).Text)
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@TaxDeductible", Me.lstPayrollDeductions.SelectedItems(0).SubItems(5).Text)
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@AllEmployees", Me.lstPayrollDeductions.SelectedItems(0).SubItems(6).Text)
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@Statutory", Me.lstPayrollDeductions.SelectedItems(0).SubItems(7).Text)
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@Comments", Me.lstPayrollDeductions.SelectedItems(0).Name)
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@regBy", userName.Trim)
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@queryType", queryType)
                Me.cmdPayrollDeductions.Parameters.AddWithValue("@Id", Me.lstPayrollDeductions.SelectedItems(0).Tag)
                rec = Me.cmdPayrollDeductions.ExecuteNonQuery
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

    Private Sub cboDeductionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDeductionType.SelectedIndexChanged
        If Me.cboDeductionType.Text = "Check Table" Then
            Me.cboDeductionTable.Enabled = True
            Me.txtAmount.Enabled = False
        ElseIf Me.cboDeductionType.Text = "Percentage" Or Me.cboDeductionType.Text = "Amount" Then
            Me.cboDeductionTable.Enabled = False
            Me.txtAmount.Enabled = True
        Else
            Me.cboDeductionTable.Enabled = False
            Me.txtAmount.Enabled = False
        End If
    End Sub
End Class