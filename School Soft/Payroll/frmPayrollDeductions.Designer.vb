<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollDeductions
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lstPayrollDeductions = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboDeductionTable = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDeductionType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAbbreviation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbStatutoryDeduction = New System.Windows.Forms.CheckBox()
        Me.cbAppliesToAll = New System.Windows.Forms.CheckBox()
        Me.cbTaxDeductible = New System.Windows.Forms.CheckBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDeductionName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(43, 46)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.69444!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.30556!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 426.0!))
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
        Me.Panel3.Controls.Add(Me.lstPayrollDeductions)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 157)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1285, 420)
        Me.Panel3.TabIndex = 37
        '
        'lstPayrollDeductions
        '
        Me.lstPayrollDeductions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstPayrollDeductions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lstPayrollDeductions.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstPayrollDeductions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPayrollDeductions.FullRowSelect = True
        Me.lstPayrollDeductions.GridLines = True
        Me.lstPayrollDeductions.HideSelection = False
        Me.lstPayrollDeductions.Location = New System.Drawing.Point(0, 0)
        Me.lstPayrollDeductions.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPayrollDeductions.Name = "lstPayrollDeductions"
        Me.lstPayrollDeductions.Size = New System.Drawing.Size(1283, 418)
        Me.lstPayrollDeductions.TabIndex = 1
        Me.lstPayrollDeductions.UseCompatibleStateImageBehavior = False
        Me.lstPayrollDeductions.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Deduction Name"
        Me.ColumnHeader1.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Abbreviation"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Deduction Type"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Deduction Table"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Amount"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tax Deductible"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Applies To All"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Statutory"
        Me.ColumnHeader9.Width = 100
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UPDATEToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.CLOSEToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(140, 88)
        '
        'UPDATEToolStripMenuItem
        '
        Me.UPDATEToolStripMenuItem.Name = "UPDATEToolStripMenuItem"
        Me.UPDATEToolStripMenuItem.Size = New System.Drawing.Size(139, 28)
        Me.UPDATEToolStripMenuItem.Text = "EDIT"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(139, 28)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'CLOSEToolStripMenuItem
        '
        Me.CLOSEToolStripMenuItem.Name = "CLOSEToolStripMenuItem"
        Me.CLOSEToolStripMenuItem.Size = New System.Drawing.Size(139, 28)
        Me.CLOSEToolStripMenuItem.Text = "CLOSE"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.StatusStrip2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 33)
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
        Me.StatusStrip2.Size = New System.Drawing.Size(1283, 31)
        Me.StatusStrip2.SizingGrip = False
        Me.StatusStrip2.TabIndex = 33
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(196, 25)
        Me.ToolStripStatusLabel1.Text = "PAYROLL DEDUCTIONS"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtAmount)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cboDeductionTable)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cboDeductionType)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtAbbreviation)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cbStatutoryDeduction)
        Me.Panel2.Controls.Add(Me.cbAppliesToAll)
        Me.Panel2.Controls.Add(Me.cbTaxDeductible)
        Me.Panel2.Controls.Add(Me.txtComments)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtDeductionName)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1285, 109)
        Me.Panel2.TabIndex = 37
        '
        'txtAmount
        '
        Me.txtAmount.Enabled = False
        Me.txtAmount.Location = New System.Drawing.Point(139, 71)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(227, 22)
        Me.txtAmount.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Amount/Value:"
        '
        'cboDeductionTable
        '
        Me.cboDeductionTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeductionTable.Enabled = False
        Me.cboDeductionTable.FormattingEnabled = True
        Me.cboDeductionTable.Items.AddRange(New Object() {"tblPayrollPAYE", "tblPayrollNSSF"})
        Me.cboDeductionTable.Location = New System.Drawing.Point(514, 40)
        Me.cboDeductionTable.Name = "cboDeductionTable"
        Me.cboDeductionTable.Size = New System.Drawing.Size(227, 24)
        Me.cboDeductionTable.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(381, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Deduction Table:"
        '
        'cboDeductionType
        '
        Me.cboDeductionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeductionType.FormattingEnabled = True
        Me.cboDeductionType.Items.AddRange(New Object() {"Check Table", "Percentage", "Amount"})
        Me.cboDeductionType.Location = New System.Drawing.Point(139, 40)
        Me.cboDeductionType.Name = "cboDeductionType"
        Me.cboDeductionType.Size = New System.Drawing.Size(227, 24)
        Me.cboDeductionType.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Deduction Type:"
        '
        'txtAbbreviation
        '
        Me.txtAbbreviation.Location = New System.Drawing.Point(846, 8)
        Me.txtAbbreviation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAbbreviation.Name = "txtAbbreviation"
        Me.txtAbbreviation.Size = New System.Drawing.Size(407, 22)
        Me.txtAbbreviation.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(753, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Abbreviation:"
        '
        'cbStatutoryDeduction
        '
        Me.cbStatutoryDeduction.AutoSize = True
        Me.cbStatutoryDeduction.Location = New System.Drawing.Point(676, 74)
        Me.cbStatutoryDeduction.Name = "cbStatutoryDeduction"
        Me.cbStatutoryDeduction.Size = New System.Drawing.Size(155, 21)
        Me.cbStatutoryDeduction.TabIndex = 37
        Me.cbStatutoryDeduction.Text = "Statutory Deduction"
        Me.cbStatutoryDeduction.UseVisualStyleBackColor = True
        '
        'cbAppliesToAll
        '
        Me.cbAppliesToAll.AutoSize = True
        Me.cbAppliesToAll.Location = New System.Drawing.Point(535, 74)
        Me.cbAppliesToAll.Name = "cbAppliesToAll"
        Me.cbAppliesToAll.Size = New System.Drawing.Size(111, 21)
        Me.cbAppliesToAll.TabIndex = 36
        Me.cbAppliesToAll.Text = "Applies to All"
        Me.cbAppliesToAll.UseVisualStyleBackColor = True
        '
        'cbTaxDeductible
        '
        Me.cbTaxDeductible.AutoSize = True
        Me.cbTaxDeductible.Location = New System.Drawing.Point(384, 74)
        Me.cbTaxDeductible.Name = "cbTaxDeductible"
        Me.cbTaxDeductible.Size = New System.Drawing.Size(124, 21)
        Me.cbTaxDeductible.TabIndex = 35
        Me.cbTaxDeductible.Text = "Tax Deductible"
        Me.cbTaxDeductible.UseVisualStyleBackColor = True
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(846, 40)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(407, 55)
        Me.txtComments.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(753, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Comments:"
        '
        'txtDeductionName
        '
        Me.txtDeductionName.Location = New System.Drawing.Point(139, 8)
        Me.txtDeductionName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeductionName.Name = "txtDeductionName"
        Me.txtDeductionName.Size = New System.Drawing.Size(602, 22)
        Me.txtDeductionName.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Deduction Name:"
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
        Me.btnSave.Location = New System.Drawing.Point(778, 13)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save New"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(17, 13)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(391, 13)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(100, 28)
        Me.btnView.TabIndex = 9
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1153, 13)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmPayrollDeductions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1382, 754)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPayrollDeductions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deductions"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
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
    Friend WithEvents lstPayrollDeductions As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDeductionName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents cbStatutoryDeduction As CheckBox
    Friend WithEvents cbAppliesToAll As CheckBox
    Friend WithEvents cbTaxDeductible As CheckBox
    Friend WithEvents txtAbbreviation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboDeductionTable As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboDeductionType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLOSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
End Class
