Public Class frmPayrollEmployeeAllowance
    Private Sub frmPayrollEmployeeAllowance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class