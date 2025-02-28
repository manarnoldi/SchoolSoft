<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollReliefs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lstPayrollReliefs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboPercentageOrAmount = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbAppliesToAll = New System.Windows.Forms.RadioButton()
        Me.cboReliefType = New System.Windows.Forms.ComboBox()
        Me.cboReliefImpacting = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReliefName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(58, 67)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.56098!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.43903!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 416.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1291, 667)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lstPayrollReliefs)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 167)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1285, 410)
        Me.Panel3.TabIndex = 37
        '
        'lstPayrollReliefs
        '
        Me.lstPayrollReliefs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstPayrollReliefs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lstPayrollReliefs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPayrollReliefs.FullRowSelect = True
        Me.lstPayrollReliefs.GridLines = True
        Me.lstPayrollReliefs.HideSelection = False
        Me.lstPayrollReliefs.Location = New System.Drawing.Point(0, 0)
        Me.lstPayrollReliefs.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPayrollReliefs.Name = "lstPayrollReliefs"
        Me.lstPayrollReliefs.Size = New System.Drawing.Size(1283, 408)
        Me.lstPayrollReliefs.TabIndex = 1
        Me.lstPayrollReliefs.UseCompatibleStateImageBehavior = False
        Me.lstPayrollReliefs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Relief name"
        Me.ColumnHeader1.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Relief Impacting"
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Relief Type"
        Me.ColumnHeader3.Width = 130
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Applies to All"
        Me.ColumnHeader4.Width = 130
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Percentage Or Amount"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Amount"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Comments"
        Me.ColumnHeader7.Width = 300
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.StatusStrip2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 31)
        Me.Panel1.TabIndex = 36
        '
        'StatusStrip2
        '
        Me.StatusStrip2.AutoSize = False
        Me.StatusStrip2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.StatusStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip2.Size = New System.Drawing.Size(1283, 29)
        Me.StatusStrip2.SizingGrip = False
        Me.StatusStrip2.TabIndex = 33
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(149, 23)
        Me.ToolStripStatusLabel1.Text = "PAYROLL RELIEFS"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cboPercentageOrAmount)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.rbAppliesToAll)
        Me.Panel2.Controls.Add(Me.cboReliefType)
        Me.Panel2.Controls.Add(Me.cboReliefImpacting)
        Me.Panel2.Controls.Add(Me.txtAmount)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtComments)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtReliefName)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1285, 121)
        Me.Panel2.TabIndex = 37
        '
        'cboPercentageOrAmount
        '
        Me.cboPercentageOrAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPercentageOrAmount.FormattingEnabled = True
        Me.cboPercentageOrAmount.Items.AddRange(New Object() {"PERCENTAGE", "AMOUNT"})
        Me.cboPercentageOrAmount.Location = New System.Drawing.Point(322, 50)
        Me.cboPercentageOrAmount.Name = "cboPercentageOrAmount"
        Me.cboPercentageOrAmount.Size = New System.Drawing.Size(181, 24)
        Me.cboPercentageOrAmount.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Percentage or Amount:"
        '
        'rbAppliesToAll
        '
        Me.rbAppliesToAll.AutoSize = True
        Me.rbAppliesToAll.Location = New System.Drawing.Point(17, 51)
        Me.rbAppliesToAll.Name = "rbAppliesToAll"
        Me.rbAppliesToAll.Size = New System.Drawing.Size(110, 21)
        Me.rbAppliesToAll.TabIndex = 31
        Me.rbAppliesToAll.TabStop = True
        Me.rbAppliesToAll.Text = "Applies to All"
        Me.rbAppliesToAll.UseVisualStyleBackColor = True
        '
        'cboReliefType
        '
        Me.cboReliefType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReliefType.FormattingEnabled = True
        Me.cboReliefType.Location = New System.Drawing.Point(1046, 10)
        Me.cboReliefType.Name = "cboReliefType"
        Me.cboReliefType.Size = New System.Drawing.Size(223, 24)
        Me.cboReliefType.TabIndex = 30
        '
        'cboReliefImpacting
        '
        Me.cboReliefImpacting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReliefImpacting.FormattingEnabled = True
        Me.cboReliefImpacting.Items.AddRange(New Object() {"BASIC SALARY", "GROSS SALARY", "ALLOWANCE", "DEDUCTION"})
        Me.cboReliefImpacting.Location = New System.Drawing.Point(731, 10)
        Me.cboReliefImpacting.Name = "cboReliefImpacting"
        Me.cboReliefImpacting.Size = New System.Drawing.Size(205, 24)
        Me.cboReliefImpacting.TabIndex = 29
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(597, 53)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(169, 22)
        Me.txtAmount.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(529, 53)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 21)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Value:"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(872, 53)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(397, 59)
        Me.txtComments.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(786, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Comments:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(955, 13)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Relief Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(612, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Relief Impacting:"
        '
        'txtReliefName
        '
        Me.txtReliefName.Location = New System.Drawing.Point(106, 10)
        Me.txtReliefName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReliefName.Name = "txtReliefName"
        Me.txtReliefName.Size = New System.Drawing.Size(498, 22)
        Me.txtReliefName.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 13)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Relief Name:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 643)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1291, 24)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 35
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnClear)
        Me.Panel4.Controls.Add(Me.btnView)
        Me.Panel4.Controls.Add(Me.btnClose)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 583)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1285, 57)
        Me.Panel4.TabIndex = 38
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(779, 13)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save New"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(9, 13)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(390, 13)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(100, 28)
        Me.btnView.TabIndex = 9
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1169, 13)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmPayrollReliefs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1407, 801)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPayrollReliefs"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reliefs"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lstPayrollReliefs As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReliefName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents cboPercentageOrAmount As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbAppliesToAll As RadioButton
    Friend WithEvents cboReliefType As ComboBox
    Friend WithEvents cboReliefImpacting As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label7 As Label
End Class
