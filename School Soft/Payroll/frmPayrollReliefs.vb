Imports System.Data.SqlClient

Public Class frmPayrollReliefs
    Dim duplicateFound As Boolean = True
    Dim cmdPayrollReliefs As New SqlCommand
    Dim reader As SqlDataReader
    Dim rec As Integer = 0
    Dim queryType As String = Nothing
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPayrollReliefs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub loadList()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            dbconnection()
            Me.lstPayrollReliefs.Items.Clear()
            cmdPayrollReliefs.Connection = conn
            cmdPayrollReliefs.CommandText = "SELECT * FROM tblPayrollReliefs ORDER BY ReliefName"
            cmdPayrollReliefs.CommandType = CommandType.Text
            cmdPayrollReliefs.Parameters.Clear()
            reader = cmdPayrollReliefs.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    li = Me.lstPayrollReliefs.Items.Add(IIf(DBNull.Value.Equals(reader!ReliefName), "", reader!ReliefName))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!ReliefImpacting), "", reader!ReliefImpacting))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!ReliefType), "", reader!ReliefType))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!AppliesToAll), "", reader!AppliesToAll))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!PercentageOrAmount), "", reader!PercentageOrAmount))
                    li.SubItems.Add(IIf(DBNull.Value.Equals(reader!Amount), "", reader!Amount))
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

    Private Sub frmPayrollReliefs_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
        Me.txtReliefName.Clear()
        Me.cboReliefImpacting.SelectedIndex = -1
        Me.cboReliefType.SelectedIndex = -1
        Me.rbAppliesToAll.Checked = False
        Me.cboPercentageOrAmount.SelectedIndex = -1
        Me.txtAmount.Clear()
        Me.txtComments.Clear()
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
        If Me.txtReliefName.Text.Trim.Length <= 0 Then
            MsgBox("Relief name is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.cboReliefImpacting.SelectedIndex < 0 Then
            MsgBox("Relief impacting is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.cboReliefType.SelectedIndex < 0 Then
            MsgBox("Relief type is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.cboPercentageOrAmount.Text.Trim.Length <= 0 Then
            MsgBox("Percentage or amount selection is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
            Exit Sub
        ElseIf Me.txtAmount.Text.Trim.Length <= 0 Then
            MsgBox("Value is Missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly, "Error Detected")
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
            Me.cmdPayrollReliefs.Connection = conn
            Me.cmdPayrollReliefs.CommandType = CommandType.StoredProcedure
            Me.cmdPayrollReliefs.CommandText = "sprocPayrollReliefs"
            Me.cmdPayrollReliefs.Parameters.Clear()
            Me.cmdPayrollReliefs.Parameters.AddWithValue("@ReliefName", Me.txtReliefName.Text.Trim)
            Me.cmdPayrollReliefs.Parameters.AddWithValue("@ReliefImpacting", Me.cboReliefImpacting.Text.Trim)
            Me.cmdPayrollReliefs.Parameters.AddWithValue("@ReliefType", Me.cboReliefType.Text.Trim)
            Me.cmdPayrollReliefs.Parameters.AddWithValue("@AppliesToAll", Me.rbAppliesToAll.Checked)
            Me.cmdPayrollReliefs.Parameters.AddWithValue("@PercentageOrAmount", Me.cboPercentageOrAmount.Text.Trim)
            Me.cmdPayrollReliefs.Parameters.AddWithValue("@Amount", Me.txtAmount.Text.Trim)
            Me.cmdPayrollReliefs.Parameters.AddWithValue("@Comments", Me.txtComments.Text.Trim)
            Me.cmdPayrollReliefs.Parameters.AddWithValue("@regBy", userName.Trim)
            Me.cmdPayrollReliefs.Parameters.AddWithValue("@queryType", queryType)
            If Me.btnSave.Text = "Update" Then
                Me.cmdPayrollReliefs.Parameters.AddWithValue("@Id", Me.txtReliefName.Tag)
            End If
            rec = Me.cmdPayrollReliefs.ExecuteNonQuery
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

    Private Sub lstPayrollReliefs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPayrollReliefs.SelectedIndexChanged

    End Sub

    Private Sub lstPayrollReliefs_DoubleClick(sender As Object, e As EventArgs) Handles lstPayrollReliefs.DoubleClick
        If Me.lstPayrollReliefs.SelectedItems.Count = 1 Then
            Me.txtReliefName.Text = Me.lstPayrollReliefs.SelectedItems(0).Text
            Me.cboReliefImpacting.Text = Me.lstPayrollReliefs.SelectedItems(0).SubItems(1).Text
            Me.cboReliefType.Text = Me.lstPayrollReliefs.SelectedItems(0).SubItems(2).Text
            Me.rbAppliesToAll.Text = Me.lstPayrollReliefs.SelectedItems(0).SubItems(3).Text
            Me.cboPercentageOrAmount.Text = Me.lstPayrollReliefs.SelectedItems(0).SubItems(4).Text
            Me.txtAmount.Text = Me.lstPayrollReliefs.SelectedItems(0).SubItems(5).Text
            Me.txtComments.Text = Me.lstPayrollReliefs.SelectedItems(0).SubItems(6).Text
            Me.txtReliefName.Tag = Me.lstPayrollReliefs.SelectedItems(0).Tag
            Me.btnSave.Text = "Update"
            Me.lstPayrollReliefs.Items.Clear()
        Else
            Me.btnSave.Text = "Save New"
        End If
    End Sub
End Class