<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFinPeriods
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlSchoolPeriods = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.checkStatus = New System.Windows.Forms.CheckBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPeriodName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip12 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip13 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip14 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip5 = New System.Windows.Forms.StatusStrip()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lstSchoolFinancialPeriods = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip4 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip6 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip7 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.CLOSEYEARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlSchoolPeriods.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSchoolPeriods
        '
        Me.pnlSchoolPeriods.BackColor = System.Drawing.SystemColors.Control
        Me.pnlSchoolPeriods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSchoolPeriods.Controls.Add(Me.SplitContainer1)
        Me.pnlSchoolPeriods.Controls.Add(Me.StatusStrip2)
        Me.pnlSchoolPeriods.Controls.Add(Me.StatusStrip1)
        Me.pnlSchoolPeriods.Location = New System.Drawing.Point(13, 13)
        Me.pnlSchoolPeriods.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSchoolPeriods.Name = "pnlSchoolPeriods"
        Me.pnlSchoolPeriods.Size = New System.Drawing.Size(733, 558)
        Me.pnlSchoolPeriods.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(731, 494)
        Me.SplitContainer1.SplitterDistance = 139
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.checkStatus)
        Me.Panel1.Controls.Add(Me.txtComments)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtPeriodName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(7, 6)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 125)
        Me.Panel1.TabIndex = 57
        '
        'checkStatus
        '
        Me.checkStatus.AutoSize = True
        Me.checkStatus.Location = New System.Drawing.Point(546, 12)
        Me.checkStatus.Name = "checkStatus"
        Me.checkStatus.Size = New System.Drawing.Size(106, 21)
        Me.checkStatus.TabIndex = 71
        Me.checkStatus.Text = "Tick if Open"
        Me.checkStatus.UseVisualStyleBackColor = True
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(164, 46)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(531, 66)
        Me.txtComments.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Comments:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(388, 13)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 17)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Finance Period Status:"
        '
        'txtPeriodName
        '
        Me.txtPeriodName.Location = New System.Drawing.Point(164, 10)
        Me.txtPeriodName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPeriodName.Name = "txtPeriodName"
        Me.txtPeriodName.Size = New System.Drawing.Size(190, 22)
        Me.txtPeriodName.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Finance Period Name:"
        '
        'StatusStrip12
        '
        Me.StatusStrip12.AutoSize = False
        Me.StatusStrip12.BackColor = System.Drawing.Color.MediumAquamarine
        Me.StatusStrip12.Dock = System.Windows.Forms.DockStyle.Left
        Me.StatusStrip12.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip12.Location = New System.Drawing.Point(0, 6)
        Me.StatusStrip12.Name = "StatusStrip12"
        Me.StatusStrip12.Padding = New System.Windows.Forms.Padding(1, 4, 1, 27)
        Me.StatusStrip12.Size = New System.Drawing.Size(7, 125)
        Me.StatusStrip12.SizingGrip = False
        Me.StatusStrip12.TabIndex = 56
        Me.StatusStrip12.Text = "StatusStrip12"
        '
        'StatusStrip13
        '
        Me.StatusStrip13.AutoSize = False
        Me.StatusStrip13.BackColor = System.Drawing.Color.MediumAquamarine
        Me.StatusStrip13.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip13.Location = New System.Drawing.Point(0, 131)
        Me.StatusStrip13.Name = "StatusStrip13"
        Me.StatusStrip13.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip13.Size = New System.Drawing.Size(722, 6)
        Me.StatusStrip13.SizingGrip = False
        Me.StatusStrip13.TabIndex = 55
        Me.StatusStrip13.Text = "StatusStrip13"
        '
        'StatusStrip14
        '
        Me.StatusStrip14.AutoSize = False
        Me.StatusStrip14.BackColor = System.Drawing.Color.MediumAquamarine
        Me.StatusStrip14.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip14.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip14.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip14.Name = "StatusStrip14"
        Me.StatusStrip14.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip14.Size = New System.Drawing.Size(722, 6)
        Me.StatusStrip14.SizingGrip = False
        Me.StatusStrip14.TabIndex = 54
        Me.StatusStrip14.Text = "StatusStrip14"
        '
        'StatusStrip5
        '
        Me.StatusStrip5.AutoSize = False
        Me.StatusStrip5.BackColor = System.Drawing.Color.MediumAquamarine
        Me.StatusStrip5.Dock = System.Windows.Forms.DockStyle.Right
        Me.StatusStrip5.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip5.Location = New System.Drawing.Point(722, 0)
        Me.StatusStrip5.Name = "StatusStrip5"
        Me.StatusStrip5.Padding = New System.Windows.Forms.Padding(1, 4, 1, 27)
        Me.StatusStrip5.Size = New System.Drawing.Size(7, 137)
        Me.StatusStrip5.SizingGrip = False
        Me.StatusStrip5.TabIndex = 53
        Me.StatusStrip5.Text = "StatusStrip5"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lstSchoolFinancialPeriods)
        Me.SplitContainer2.Panel1MinSize = 50
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.StatusStrip3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.StatusStrip4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.StatusStrip6)
        Me.SplitContainer2.Panel2.Controls.Add(Me.StatusStrip7)
        Me.SplitContainer2.Panel2MinSize = 70
        Me.SplitContainer2.Size = New System.Drawing.Size(731, 354)
        Me.SplitContainer2.SplitterDistance = 226
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 34
        '
        'lstSchoolFinancialPeriods
        '
        Me.lstSchoolFinancialPeriods.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstSchoolFinancialPeriods.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstSchoolFinancialPeriods.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSchoolFinancialPeriods.FullRowSelect = True
        Me.lstSchoolFinancialPeriods.GridLines = True
        Me.lstSchoolFinancialPeriods.HideSelection = False
        Me.lstSchoolFinancialPeriods.Location = New System.Drawing.Point(0, 0)
        Me.lstSchoolFinancialPeriods.Margin = New System.Windows.Forms.Padding(4)
        Me.lstSchoolFinancialPeriods.Name = "lstSchoolFinancialPeriods"
        Me.lstSchoolFinancialPeriods.Size = New System.Drawing.Size(729, 224)
        Me.lstSchoolFinancialPeriods.TabIndex = 2
        Me.lstSchoolFinancialPeriods.UseCompatibleStateImageBehavior = False
        Me.lstSchoolFinancialPeriods.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Period Name"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Comments"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        Me.ColumnHeader3.Width = 150
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSaveChanges)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(7, 6)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(715, 113)
        Me.Panel2.TabIndex = 58
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(16, 16)
        Me.btnSaveChanges.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(145, 28)
        Me.btnSaveChanges.TabIndex = 8
        Me.btnSaveChanges.Text = "Add Year"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(595, 16)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'StatusStrip3
        '
        Me.StatusStrip3.AutoSize = False
        Me.StatusStrip3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.StatusStrip3.Dock = System.Windows.Forms.DockStyle.Left
        Me.StatusStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip3.Location = New System.Drawing.Point(0, 6)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.Padding = New System.Windows.Forms.Padding(1, 4, 1, 27)
        Me.StatusStrip3.Size = New System.Drawing.Size(7, 113)
        Me.StatusStrip3.SizingGrip = False
        Me.StatusStrip3.TabIndex = 56
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'StatusStrip4
        '
        Me.StatusStrip4.AutoSize = False
        Me.StatusStrip4.BackColor = System.Drawing.Color.MediumAquamarine
        Me.StatusStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip4.Location = New System.Drawing.Point(0, 119)
        Me.StatusStrip4.Name = "StatusStrip4"
        Me.StatusStrip4.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip4.Size = New System.Drawing.Size(722, 6)
        Me.StatusStrip4.SizingGrip = False
        Me.StatusStrip4.TabIndex = 55
        Me.StatusStrip4.Text = "StatusStrip4"
        '
        'StatusStrip6
        '
        Me.StatusStrip6.AutoSize = False
        Me.StatusStrip6.BackColor = System.Drawing.Color.MediumAquamarine
        Me.StatusStrip6.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip6.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip6.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip6.Name = "StatusStrip6"
        Me.StatusStrip6.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip6.Size = New System.Drawing.Size(722, 6)
        Me.StatusStrip6.SizingGrip = False
        Me.StatusStrip6.TabIndex = 54
        Me.StatusStrip6.Text = "StatusStrip6"
        '
        'StatusStrip7
        '
        Me.StatusStrip7.AutoSize = False
        Me.StatusStrip7.BackColor = System.Drawing.Color.MediumAquamarine
        Me.StatusStrip7.Dock = System.Windows.Forms.DockStyle.Right
        Me.StatusStrip7.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip7.Location = New System.Drawing.Point(722, 0)
        Me.StatusStrip7.Name = "StatusStrip7"
        Me.StatusStrip7.Padding = New System.Windows.Forms.Padding(1, 4, 1, 27)
        Me.StatusStrip7.Size = New System.Drawing.Size(7, 125)
        Me.StatusStrip7.SizingGrip = False
        Me.StatusStrip7.TabIndex = 53
        Me.StatusStrip7.Text = "StatusStrip7"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.AutoSize = False
        Me.StatusStrip2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.StatusStrip2.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip2.Size = New System.Drawing.Size(731, 31)
        Me.StatusStrip2.SizingGrip = False
        Me.StatusStrip2.TabIndex = 32
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(283, 25)
        Me.ToolStripStatusLabel1.Text = "SET SCHOOL FINANCIAL PERIODS"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 525)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(731, 31)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 31
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'CLOSEYEARToolStripMenuItem
        '
        Me.CLOSEYEARToolStripMenuItem.Name = "CLOSEYEARToolStripMenuItem"
        Me.CLOSEYEARToolStripMenuItem.Size = New System.Drawing.Size(210, 28)
        Me.CLOSEYEARToolStripMenuItem.Text = "CLOSE YEAR"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLOSEYEARToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 32)
        '
        'frmFinPeriods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(765, 584)
        Me.Controls.Add(Me.pnlSchoolPeriods)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFinPeriods"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance Periods"
        Me.pnlSchoolPeriods.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSchoolPeriods As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPeriodName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip12 As StatusStrip
    Friend WithEvents StatusStrip13 As StatusStrip
    Friend WithEvents StatusStrip14 As StatusStrip
    Friend WithEvents StatusStrip5 As StatusStrip
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents lstSchoolFinancialPeriods As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents StatusStrip3 As StatusStrip
    Friend WithEvents StatusStrip4 As StatusStrip
    Friend WithEvents StatusStrip6 As StatusStrip
    Friend WithEvents StatusStrip7 As StatusStrip
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents checkStatus As CheckBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CLOSEYEARToolStripMenuItem As ToolStripMenuItem
End Class
