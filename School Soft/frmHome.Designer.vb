<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("STAFF DETAILS")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PAYE Table")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reliefs")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Allowance Types")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deduction Types")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payrolls Register")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SETTINGS", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee Allowances")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee Deductions")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee Payroll")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PAYROLL", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payroll")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payslips")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deductions")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Allowances")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("REPORTS", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Details")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Assign Class")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Images")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Parents")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Former School")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search Details")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("STUDENT DETAILS", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PROMOTE STUDENT")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ACCOMODATION")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("FEES SUMMARY")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("School Details")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Term Dates")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Departments")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Teaching Rooms")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Classes")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Staff Details")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Class Heads")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("School Periods")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Max Subject SetUp")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SCHOOL SETUP", New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28, TreeNode29, TreeNode30, TreeNode31, TreeNode32, TreeNode33, TreeNode34, TreeNode35})
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Class Lists")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Teacher Subject")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ADMINISTRATION", New System.Windows.Forms.TreeNode() {TreeNode37, TreeNode38})
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payment Modes")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payment Accounts")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bank Balances")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cash Balances")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mobile Balances")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Adjust Balances")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SETTINGS", New System.Windows.Forms.TreeNode() {TreeNode40, TreeNode41, TreeNode42, TreeNode43, TreeNode44, TreeNode45})
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fee Category")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VoteHeads")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Student Fee")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fee Receipts")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Find Receipt")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SCHOOL FEE", New System.Windows.Forms.TreeNode() {TreeNode47, TreeNode48, TreeNode49, TreeNode50, TreeNode51})
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OTHERS")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("INCOME", New System.Windows.Forms.TreeNode() {TreeNode52, TreeNode53})
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Expense Category")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Expense Master")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payment Request")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payment Approval")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payment Voucher")
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payment Reversal")
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("EXPENSES", New System.Windows.Forms.TreeNode() {TreeNode55, TreeNode56, TreeNode57, TreeNode58, TreeNode59, TreeNode60})
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Account Transfers")
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Account Adjustments")
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fee Payments")
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fee Balances")
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fee Statement")
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vote Summary")
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fee Expectation")
        Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Other Income")
        Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Expenses Summary")
        Dim TreeNode71 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payment Approvals")
        Dim TreeNode72 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payment Reversals")
        Dim TreeNode73 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Income Expenditure")
        Dim TreeNode74 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("REPORTS", New System.Windows.Forms.TreeNode() {TreeNode62, TreeNode63, TreeNode64, TreeNode65, TreeNode66, TreeNode67, TreeNode68, TreeNode69, TreeNode70, TreeNode71, TreeNode72, TreeNode73})
        Dim TreeNode75 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("REGISTER GRADES")
        Dim TreeNode76 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Register Subjects")
        Dim TreeNode77 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Student Subject")
        Dim TreeNode78 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Teacher Subject")
        Dim TreeNode79 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Exam Names")
        Dim TreeNode80 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Examinations")
        Dim TreeNode81 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SUBJECTS", New System.Windows.Forms.TreeNode() {TreeNode76, TreeNode77, TreeNode78, TreeNode79, TreeNode80})
        Dim TreeNode82 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mark Entry Class")
        Dim TreeNode83 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mark Entry Subject")
        Dim TreeNode84 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Results Viewing")
        Dim TreeNode85 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Results Analysis")
        Dim TreeNode86 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Report Form")
        Dim TreeNode87 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("EXAM RESULTS", New System.Windows.Forms.TreeNode() {TreeNode82, TreeNode83, TreeNode84, TreeNode85, TreeNode86})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SECURITYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODULESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DOMAINSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DOMAINRIGHTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SYSTEMSETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITMYACCOUNTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.REVERSEFEESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANAGEFINANCEPERIODSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowManagerPanel1 = New MDIWindowManager.WindowManagerPanel()
        Me.TimerHome = New System.Windows.Forms.Timer(Me.components)
        Me.NaviBand1 = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.naviPayroll = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvPayroll = New System.Windows.Forms.TreeView()
        Me.naviStudent = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvStudent = New System.Windows.Forms.TreeView()
        Me.naviSchool = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvSchool = New System.Windows.Forms.TreeView()
        Me.naviFinance = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvFinance = New System.Windows.Forms.TreeView()
        Me.naviAcademics = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvAcademics = New System.Windows.Forms.TreeView()
        Me.NaviBarHome = New Guifreaks.NavigationBar.NaviBar(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.NaviBand1.SuspendLayout()
        Me.naviPayroll.ClientArea.SuspendLayout()
        Me.naviPayroll.SuspendLayout()
        Me.naviStudent.ClientArea.SuspendLayout()
        Me.naviStudent.SuspendLayout()
        Me.naviSchool.ClientArea.SuspendLayout()
        Me.naviSchool.SuspendLayout()
        Me.naviFinance.ClientArea.SuspendLayout()
        Me.naviFinance.SuspendLayout()
        Me.naviAcademics.ClientArea.SuspendLayout()
        Me.naviAcademics.SuspendLayout()
        CType(Me.NaviBarHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NaviBarHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(159, 28)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 691)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1352, 31)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(159, 28)
        Me.ToolStripLabel2.Text = "ToolStripLabel2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(159, 28)
        Me.ToolStripLabel3.Text = "ToolStripLabel3"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.LightSeaGreen
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGOUTToolStripMenuItem, Me.SECURITYToolStripMenuItem, Me.EDITMYACCOUNTToolStripMenuItem1, Me.REVERSEFEESToolStripMenuItem, Me.MANAGEFINANCEPERIODSToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(1352, 31)
        Me.MenuStrip.TabIndex = 21
        Me.MenuStrip.Text = "MenuStrip"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(98, 27)
        Me.LOGOUTToolStripMenuItem.Text = "LOG OUT"
        '
        'SECURITYToolStripMenuItem
        '
        Me.SECURITYToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERSToolStripMenuItem, Me.MODULESToolStripMenuItem, Me.DOMAINSToolStripMenuItem, Me.DOMAINRIGHTSToolStripMenuItem, Me.SYSTEMSETTINGSToolStripMenuItem})
        Me.SECURITYToolStripMenuItem.Name = "SECURITYToolStripMenuItem"
        Me.SECURITYToolStripMenuItem.Size = New System.Drawing.Size(102, 27)
        Me.SECURITYToolStripMenuItem.Text = "SECURITY"
        '
        'USERSToolStripMenuItem
        '
        Me.USERSToolStripMenuItem.Name = "USERSToolStripMenuItem"
        Me.USERSToolStripMenuItem.Size = New System.Drawing.Size(243, 28)
        Me.USERSToolStripMenuItem.Text = "USERS"
        '
        'MODULESToolStripMenuItem
        '
        Me.MODULESToolStripMenuItem.Name = "MODULESToolStripMenuItem"
        Me.MODULESToolStripMenuItem.Size = New System.Drawing.Size(243, 28)
        Me.MODULESToolStripMenuItem.Text = "MODULES"
        '
        'DOMAINSToolStripMenuItem
        '
        Me.DOMAINSToolStripMenuItem.Name = "DOMAINSToolStripMenuItem"
        Me.DOMAINSToolStripMenuItem.Size = New System.Drawing.Size(243, 28)
        Me.DOMAINSToolStripMenuItem.Text = "DOMAINS"
        '
        'DOMAINRIGHTSToolStripMenuItem
        '
        Me.DOMAINRIGHTSToolStripMenuItem.Name = "DOMAINRIGHTSToolStripMenuItem"
        Me.DOMAINRIGHTSToolStripMenuItem.Size = New System.Drawing.Size(243, 28)
        Me.DOMAINRIGHTSToolStripMenuItem.Text = "DOMAIN RIGHTS"
        '
        'SYSTEMSETTINGSToolStripMenuItem
        '
        Me.SYSTEMSETTINGSToolStripMenuItem.Name = "SYSTEMSETTINGSToolStripMenuItem"
        Me.SYSTEMSETTINGSToolStripMenuItem.Size = New System.Drawing.Size(243, 28)
        Me.SYSTEMSETTINGSToolStripMenuItem.Text = "SYSTEM SETTINGS"
        '
        'EDITMYACCOUNTToolStripMenuItem1
        '
        Me.EDITMYACCOUNTToolStripMenuItem1.Name = "EDITMYACCOUNTToolStripMenuItem1"
        Me.EDITMYACCOUNTToolStripMenuItem1.Size = New System.Drawing.Size(178, 27)
        Me.EDITMYACCOUNTToolStripMenuItem1.Text = "EDIT MY ACCOUNT"
        '
        'REVERSEFEESToolStripMenuItem
        '
        Me.REVERSEFEESToolStripMenuItem.Name = "REVERSEFEESToolStripMenuItem"
        Me.REVERSEFEESToolStripMenuItem.Size = New System.Drawing.Size(136, 27)
        Me.REVERSEFEESToolStripMenuItem.Text = "REVERSE FEES"
        '
        'MANAGEFINANCEPERIODSToolStripMenuItem
        '
        Me.MANAGEFINANCEPERIODSToolStripMenuItem.Name = "MANAGEFINANCEPERIODSToolStripMenuItem"
        Me.MANAGEFINANCEPERIODSToolStripMenuItem.Size = New System.Drawing.Size(251, 27)
        Me.MANAGEFINANCEPERIODSToolStripMenuItem.Text = "MANAGE FINANCE PERIODS"
        '
        'WindowManagerPanel1
        '
        Me.WindowManagerPanel1.AllowUserVerticalRepositioning = False
        Me.WindowManagerPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WindowManagerPanel1.AutoDetectMdiChildWindows = True
        Me.WindowManagerPanel1.AutoHide = False
        Me.WindowManagerPanel1.BackColor = System.Drawing.Color.LightBlue
        Me.WindowManagerPanel1.ButtonRenderMode = MDIWindowManager.ButtonRenderMode.Standard
        Me.WindowManagerPanel1.DisableCloseAction = False
        Me.WindowManagerPanel1.DisableHTileAction = False
        Me.WindowManagerPanel1.DisablePopoutAction = False
        Me.WindowManagerPanel1.DisableTileAction = False
        Me.WindowManagerPanel1.EnableTabPaintEvent = False
        Me.WindowManagerPanel1.Location = New System.Drawing.Point(362, 33)
        Me.WindowManagerPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.WindowManagerPanel1.MinMode = False
        Me.WindowManagerPanel1.Name = "WindowManagerPanel1"
        Me.WindowManagerPanel1.Orientation = MDIWindowManager.WindowManagerOrientation.Top
        Me.WindowManagerPanel1.ShowCloseButton = True
        Me.WindowManagerPanel1.ShowIcons = False
        Me.WindowManagerPanel1.ShowLayoutButtons = False
        Me.WindowManagerPanel1.ShowTitle = False
        Me.WindowManagerPanel1.Size = New System.Drawing.Size(988, 36)
        Me.WindowManagerPanel1.Style = MDIWindowManager.TabStyle.AngledHiliteTabs
        Me.WindowManagerPanel1.TabIndex = 26
        Me.WindowManagerPanel1.TabRenderMode = MDIWindowManager.TabsProvider.Standard
        Me.WindowManagerPanel1.TitleBackColor = System.Drawing.SystemColors.ControlDark
        Me.WindowManagerPanel1.TitleForeColor = System.Drawing.SystemColors.ControlLightLight
        '
        'TimerHome
        '
        Me.TimerHome.Enabled = True
        Me.TimerHome.Interval = 1000
        '
        'NaviBand1
        '
        '
        'NaviBand1.ClientArea
        '
        Me.NaviBand1.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.NaviBand1.ClientArea.Name = "ClientArea"
        Me.NaviBand1.ClientArea.Size = New System.Drawing.Size(281, 374)
        Me.NaviBand1.ClientArea.TabIndex = 0
        Me.NaviBand1.Location = New System.Drawing.Point(1, 27)
        Me.NaviBand1.Name = "NaviBand1"
        Me.NaviBand1.Size = New System.Drawing.Size(281, 374)
        Me.NaviBand1.TabIndex = 17
        '
        'naviPayroll
        '
        '
        'naviPayroll.ClientArea
        '
        Me.naviPayroll.ClientArea.Controls.Add(Me.tvPayroll)
        Me.naviPayroll.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.naviPayroll.ClientArea.Margin = New System.Windows.Forms.Padding(4)
        Me.naviPayroll.ClientArea.Name = "ClientArea"
        Me.naviPayroll.ClientArea.Size = New System.Drawing.Size(358, 433)
        Me.naviPayroll.ClientArea.TabIndex = 0
        Me.naviPayroll.Location = New System.Drawing.Point(1, 27)
        Me.naviPayroll.Margin = New System.Windows.Forms.Padding(4)
        Me.naviPayroll.Name = "naviPayroll"
        Me.naviPayroll.Size = New System.Drawing.Size(358, 433)
        Me.naviPayroll.TabIndex = 6
        Me.naviPayroll.Text = "PAYROLL"
        '
        'tvPayroll
        '
        Me.tvPayroll.BackColor = System.Drawing.Color.Azure
        Me.tvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvPayroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvPayroll.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvPayroll.Indent = 35
        Me.tvPayroll.ItemHeight = 30
        Me.tvPayroll.Location = New System.Drawing.Point(0, 0)
        Me.tvPayroll.Margin = New System.Windows.Forms.Padding(4)
        Me.tvPayroll.Name = "tvPayroll"
        TreeNode1.Name = "nodePayrollStaffDetails"
        TreeNode1.Text = "STAFF DETAILS"
        TreeNode2.Name = "nodePAYETable"
        TreeNode2.Text = "PAYE Table"
        TreeNode3.Name = "nodeReliefs"
        TreeNode3.Text = "Reliefs"
        TreeNode4.Name = "nodeAllowanceTypes"
        TreeNode4.Text = "Allowance Types"
        TreeNode5.Name = "nodeDeductionTypes"
        TreeNode5.Text = "Deduction Types"
        TreeNode6.Name = "nodePayrollsRegister"
        TreeNode6.Text = "Payrolls Register"
        TreeNode7.Name = "nodeSettings"
        TreeNode7.Text = "SETTINGS"
        TreeNode8.Name = "nodeEmplAllowances"
        TreeNode8.Text = "Employee Allowances"
        TreeNode9.Name = "nodeEmployeeDeductions"
        TreeNode9.Text = "Employee Deductions"
        TreeNode10.Name = "nodeEmployeeSalaries"
        TreeNode10.Text = "Employee Payroll"
        TreeNode11.Name = "nodePayroll"
        TreeNode11.Text = "PAYROLL"
        TreeNode12.Name = "nodePayroll"
        TreeNode12.Text = "Payroll"
        TreeNode13.Name = "nodePayslips"
        TreeNode13.Text = "Payslips"
        TreeNode14.Name = "nodeDeductions"
        TreeNode14.Text = "Deductions"
        TreeNode15.Name = "nodeAllowances"
        TreeNode15.Text = "Allowances"
        TreeNode16.Name = "nodeReports"
        TreeNode16.Text = "REPORTS"
        Me.tvPayroll.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode7, TreeNode11, TreeNode16})
        Me.tvPayroll.Size = New System.Drawing.Size(358, 433)
        Me.tvPayroll.TabIndex = 5
        '
        'naviStudent
        '
        '
        'naviStudent.ClientArea
        '
        Me.naviStudent.ClientArea.Controls.Add(Me.tvStudent)
        Me.naviStudent.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.naviStudent.ClientArea.Margin = New System.Windows.Forms.Padding(4)
        Me.naviStudent.ClientArea.Name = "ClientArea"
        Me.naviStudent.ClientArea.Size = New System.Drawing.Size(358, 433)
        Me.naviStudent.ClientArea.TabIndex = 0
        Me.naviStudent.Location = New System.Drawing.Point(1, 27)
        Me.naviStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.naviStudent.Name = "naviStudent"
        Me.naviStudent.Size = New System.Drawing.Size(358, 433)
        Me.naviStudent.TabIndex = 2
        Me.naviStudent.Text = "STUDENT"
        '
        'tvStudent
        '
        Me.tvStudent.BackColor = System.Drawing.Color.Azure
        Me.tvStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvStudent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvStudent.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvStudent.Indent = 35
        Me.tvStudent.ItemHeight = 30
        Me.tvStudent.Location = New System.Drawing.Point(0, 0)
        Me.tvStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.tvStudent.Name = "tvStudent"
        TreeNode17.Name = "nodeStudDetails"
        TreeNode17.Text = "Details"
        TreeNode18.Name = "nodeAssigStudClass"
        TreeNode18.Text = "Assign Class"
        TreeNode19.Name = "nodeStudImages"
        TreeNode19.Text = "Images"
        TreeNode20.Name = "nodeStudParents"
        TreeNode20.Text = "Parents"
        TreeNode21.Name = "nodeFormerSchool"
        TreeNode21.Text = "Former School"
        TreeNode22.Name = "nodeSearchDetails"
        TreeNode22.Text = "Search Details"
        TreeNode23.Name = "Node0"
        TreeNode23.Text = "STUDENT DETAILS"
        TreeNode24.Name = "nodePromoteStudent"
        TreeNode24.Text = "PROMOTE STUDENT"
        TreeNode25.Name = "nodeStudAccomodation"
        TreeNode25.Text = "ACCOMODATION"
        TreeNode26.Name = "nodeStudFees"
        TreeNode26.Text = "FEES SUMMARY"
        Me.tvStudent.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25, TreeNode26})
        Me.tvStudent.Size = New System.Drawing.Size(358, 433)
        Me.tvStudent.TabIndex = 3
        '
        'naviSchool
        '
        '
        'naviSchool.ClientArea
        '
        Me.naviSchool.ClientArea.Controls.Add(Me.tvSchool)
        Me.naviSchool.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.naviSchool.ClientArea.Margin = New System.Windows.Forms.Padding(4)
        Me.naviSchool.ClientArea.Name = "ClientArea"
        Me.naviSchool.ClientArea.Size = New System.Drawing.Size(358, 433)
        Me.naviSchool.ClientArea.TabIndex = 0
        Me.naviSchool.Location = New System.Drawing.Point(1, 27)
        Me.naviSchool.Margin = New System.Windows.Forms.Padding(4)
        Me.naviSchool.Name = "naviSchool"
        Me.naviSchool.Size = New System.Drawing.Size(358, 433)
        Me.naviSchool.TabIndex = 1
        Me.naviSchool.Text = "SCHOOL"
        '
        'tvSchool
        '
        Me.tvSchool.BackColor = System.Drawing.Color.Azure
        Me.tvSchool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvSchool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvSchool.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvSchool.Indent = 35
        Me.tvSchool.ItemHeight = 30
        Me.tvSchool.Location = New System.Drawing.Point(0, 0)
        Me.tvSchool.Margin = New System.Windows.Forms.Padding(4)
        Me.tvSchool.Name = "tvSchool"
        TreeNode27.Name = "nodeSchDetails"
        TreeNode27.Text = "School Details"
        TreeNode28.Name = "nodeTermDates"
        TreeNode28.Text = "Term Dates"
        TreeNode29.Name = "nodeDepartments"
        TreeNode29.Text = "Departments"
        TreeNode30.Name = "nodeTeachingRooms"
        TreeNode30.Text = "Teaching Rooms"
        TreeNode31.Name = "nodeClasses"
        TreeNode31.Text = "Classes"
        TreeNode32.Name = "nodeStaffDetails"
        TreeNode32.Text = "Staff Details"
        TreeNode33.Name = "nodeClassHeads"
        TreeNode33.Text = "Class Heads"
        TreeNode34.Name = "nodeSchoolPeriods"
        TreeNode34.Text = "School Periods"
        TreeNode35.Name = "nodeSubMaxSetUp"
        TreeNode35.Text = "Max Subject SetUp"
        TreeNode36.Name = "nodeSchSetUp"
        TreeNode36.Text = "SCHOOL SETUP"
        TreeNode37.Name = "nodeClassLists"
        TreeNode37.Text = "Class Lists"
        TreeNode38.Name = "nodeTeacherSubject"
        TreeNode38.Text = "Teacher Subject"
        TreeNode39.Name = "nodeAdministration"
        TreeNode39.Text = "ADMINISTRATION"
        Me.tvSchool.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode36, TreeNode39})
        Me.tvSchool.Size = New System.Drawing.Size(358, 433)
        Me.tvSchool.TabIndex = 0
        '
        'naviFinance
        '
        '
        'naviFinance.ClientArea
        '
        Me.naviFinance.ClientArea.Controls.Add(Me.tvFinance)
        Me.naviFinance.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.naviFinance.ClientArea.Margin = New System.Windows.Forms.Padding(4)
        Me.naviFinance.ClientArea.Name = "ClientArea"
        Me.naviFinance.ClientArea.Size = New System.Drawing.Size(358, 433)
        Me.naviFinance.ClientArea.TabIndex = 0
        Me.naviFinance.Location = New System.Drawing.Point(1, 27)
        Me.naviFinance.Margin = New System.Windows.Forms.Padding(4)
        Me.naviFinance.Name = "naviFinance"
        Me.naviFinance.Size = New System.Drawing.Size(358, 433)
        Me.naviFinance.TabIndex = 5
        Me.naviFinance.Text = "FINANCE"
        '
        'tvFinance
        '
        Me.tvFinance.BackColor = System.Drawing.Color.Azure
        Me.tvFinance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvFinance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvFinance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvFinance.Indent = 35
        Me.tvFinance.ItemHeight = 30
        Me.tvFinance.Location = New System.Drawing.Point(0, 0)
        Me.tvFinance.Margin = New System.Windows.Forms.Padding(4)
        Me.tvFinance.Name = "tvFinance"
        TreeNode40.Name = "nodePaymentModes"
        TreeNode40.Text = "Payment Modes"
        TreeNode41.Name = "nodePayAccounts"
        TreeNode41.Text = "Payment Accounts"
        TreeNode42.Name = "nodeBankBal"
        TreeNode42.Text = "Bank Balances"
        TreeNode43.Name = "nodeCashBal"
        TreeNode43.Text = "Cash Balances"
        TreeNode44.Name = "nodeMobileBal"
        TreeNode44.Text = "Mobile Balances"
        TreeNode45.Name = "nodeAdjustBal"
        TreeNode45.Text = "Adjust Balances"
        TreeNode46.Name = "nodeFinSetting"
        TreeNode46.Text = "SETTINGS"
        TreeNode47.Name = "nodeFeeCat"
        TreeNode47.Text = "Fee Category"
        TreeNode48.Name = "nodeVoteHeads"
        TreeNode48.Text = "VoteHeads"
        TreeNode49.Name = "nodeStudFee"
        TreeNode49.Text = "Set Student Fee"
        TreeNode50.Name = "nodeFeeReceipts"
        TreeNode50.Text = "Fee Receipts"
        TreeNode51.Name = "nodeFindReceipt"
        TreeNode51.Text = "Find Receipt"
        TreeNode52.Name = "nodeSchFee"
        TreeNode52.Text = "SCHOOL FEE"
        TreeNode53.Name = "nodeOthers"
        TreeNode53.Text = "OTHERS"
        TreeNode54.Name = "nodeIncome"
        TreeNode54.Text = "INCOME"
        TreeNode55.Name = "nodeExpCat"
        TreeNode55.Text = "Expense Category"
        TreeNode56.Name = "nodeExpMaster"
        TreeNode56.Text = "Expense Master"
        TreeNode57.Name = "nodePayRequest"
        TreeNode57.Text = "Payment Request"
        TreeNode58.Name = "nodePayApproval"
        TreeNode58.Text = "Payment Approval"
        TreeNode59.Name = "nodePaymentVoucher"
        TreeNode59.Text = "Payment Voucher"
        TreeNode60.Name = "nodePayReversal"
        TreeNode60.Text = "Payment Reversal"
        TreeNode61.Name = "nodeExpensesMain"
        TreeNode61.Text = "EXPENSES"
        TreeNode62.Name = "nodeAccountTransfers"
        TreeNode62.Text = "Account Transfers"
        TreeNode63.Name = "nodeAccountAdj"
        TreeNode63.Text = "Account Adjustments"
        TreeNode64.Name = "nodeFeePayments"
        TreeNode64.Text = "Fee Payments"
        TreeNode65.Name = "nodeFeeBalances"
        TreeNode65.Text = "Fee Balances"
        TreeNode66.Name = "nodeFeeStatement"
        TreeNode66.Text = "Fee Statement"
        TreeNode67.Name = "nodeVoteSummary"
        TreeNode67.Text = "Vote Summary"
        TreeNode68.Name = "nodeFeeExpectation"
        TreeNode68.Text = "Fee Expectation"
        TreeNode69.Name = "nodeOtherIncome"
        TreeNode69.Text = "Other Income"
        TreeNode70.Name = "nodeExpenses"
        TreeNode70.Text = "Expenses Summary"
        TreeNode71.Name = "nodePayApprovals"
        TreeNode71.Text = "Payment Approvals"
        TreeNode72.Name = "nodePayReversals"
        TreeNode72.Text = "Payment Reversals"
        TreeNode73.Name = "nodeIncomeExp"
        TreeNode73.Text = "Income Expenditure"
        TreeNode74.Name = "nodeIncReports"
        TreeNode74.Text = "REPORTS"
        Me.tvFinance.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode46, TreeNode54, TreeNode61, TreeNode74})
        Me.tvFinance.Size = New System.Drawing.Size(358, 433)
        Me.tvFinance.TabIndex = 4
        '
        'naviAcademics
        '
        '
        'naviAcademics.ClientArea
        '
        Me.naviAcademics.ClientArea.Controls.Add(Me.tvAcademics)
        Me.naviAcademics.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.naviAcademics.ClientArea.Margin = New System.Windows.Forms.Padding(4)
        Me.naviAcademics.ClientArea.Name = "ClientArea"
        Me.naviAcademics.ClientArea.Size = New System.Drawing.Size(358, 433)
        Me.naviAcademics.ClientArea.TabIndex = 0
        Me.naviAcademics.Location = New System.Drawing.Point(1, 27)
        Me.naviAcademics.Margin = New System.Windows.Forms.Padding(4)
        Me.naviAcademics.Name = "naviAcademics"
        Me.naviAcademics.Size = New System.Drawing.Size(358, 433)
        Me.naviAcademics.TabIndex = 3
        Me.naviAcademics.Text = "ACADEMICS"
        '
        'tvAcademics
        '
        Me.tvAcademics.BackColor = System.Drawing.Color.Azure
        Me.tvAcademics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvAcademics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvAcademics.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvAcademics.Indent = 35
        Me.tvAcademics.ItemHeight = 30
        Me.tvAcademics.Location = New System.Drawing.Point(0, 0)
        Me.tvAcademics.Margin = New System.Windows.Forms.Padding(4)
        Me.tvAcademics.Name = "tvAcademics"
        TreeNode75.Name = "nodeAcadGrades"
        TreeNode75.Text = "REGISTER GRADES"
        TreeNode76.Name = "nodeAcadSubjectsReg"
        TreeNode76.Text = "Register Subjects"
        TreeNode77.Name = "nodeAcadSubjectsStudent"
        TreeNode77.Text = "Student Subject"
        TreeNode78.Name = "nodeAcadSubjectsTeacher"
        TreeNode78.Text = "Teacher Subject"
        TreeNode79.Name = "nodeExamNames"
        TreeNode79.Text = "Exam Names"
        TreeNode80.Name = "nodeAcadExams"
        TreeNode80.Text = "Examinations"
        TreeNode81.Name = "nodeAcadSubjects"
        TreeNode81.Text = "SUBJECTS"
        TreeNode82.Name = "nodeAcadMarkEntryClass"
        TreeNode82.Text = "Mark Entry Class"
        TreeNode83.Name = "nodeAcadMarkEntrySubj"
        TreeNode83.Text = "Mark Entry Subject"
        TreeNode84.Name = "nodeResultsViewing"
        TreeNode84.Text = "Results Viewing"
        TreeNode85.Name = "nodeAcadResultAnalysis"
        TreeNode85.Text = "Results Analysis"
        TreeNode86.Name = "nodeAcadReportForm"
        TreeNode86.Text = "Report Form"
        TreeNode87.Name = "nodeAcadExamResults"
        TreeNode87.Text = "EXAM RESULTS"
        Me.tvAcademics.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode75, TreeNode81, TreeNode87})
        Me.tvAcademics.Size = New System.Drawing.Size(358, 433)
        Me.tvAcademics.TabIndex = 1
        '
        'NaviBarHome
        '
        Me.NaviBarHome.ActiveBand = Me.naviPayroll
        Me.NaviBarHome.BackColor = System.Drawing.Color.Azure
        Me.NaviBarHome.Controls.Add(Me.naviPayroll)
        Me.NaviBarHome.Controls.Add(Me.naviSchool)
        Me.NaviBarHome.Controls.Add(Me.naviStudent)
        Me.NaviBarHome.Controls.Add(Me.naviFinance)
        Me.NaviBarHome.Controls.Add(Me.naviAcademics)
        Me.NaviBarHome.Dock = System.Windows.Forms.DockStyle.Left
        Me.NaviBarHome.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NaviBarHome.Location = New System.Drawing.Point(0, 31)
        Me.NaviBarHome.Margin = New System.Windows.Forms.Padding(4)
        Me.NaviBarHome.Name = "NaviBarHome"
        Me.NaviBarHome.ShowMoreOptionsButton = False
        Me.NaviBarHome.Size = New System.Drawing.Size(360, 660)
        Me.NaviBarHome.TabIndex = 30
        Me.NaviBarHome.Text = "NaviBarHome"
        Me.NaviBarHome.VisibleLargeButtons = 5
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1352, 722)
        Me.Controls.Add(Me.NaviBarHome)
        Me.Controls.Add(Me.WindowManagerPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SCHOOL SOFT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.NaviBand1.ResumeLayout(False)
        Me.naviPayroll.ClientArea.ResumeLayout(False)
        Me.naviPayroll.ResumeLayout(False)
        Me.naviStudent.ClientArea.ResumeLayout(False)
        Me.naviStudent.ResumeLayout(False)
        Me.naviSchool.ClientArea.ResumeLayout(False)
        Me.naviSchool.ResumeLayout(False)
        Me.naviFinance.ClientArea.ResumeLayout(False)
        Me.naviFinance.ResumeLayout(False)
        Me.naviAcademics.ClientArea.ResumeLayout(False)
        Me.naviAcademics.ResumeLayout(False)
        CType(Me.NaviBarHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NaviBarHome.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents WindowManagerPanel1 As MDIWindowManager.WindowManagerPanel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TimerHome As System.Windows.Forms.Timer
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SECURITYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MODULESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DOMAINSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DOMAINRIGHTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NaviBand1 As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents EDITMYACCOUNTToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SYSTEMSETTINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REVERSEFEESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MANAGEFINANCEPERIODSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents naviPayroll As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents naviStudent As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents tvStudent As TreeView
    Friend WithEvents naviSchool As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents tvSchool As TreeView
    Friend WithEvents naviFinance As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents tvFinance As TreeView
    Friend WithEvents naviAcademics As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents tvAcademics As TreeView
    Friend WithEvents NaviBarHome As Guifreaks.NavigationBar.NaviBar
    Friend WithEvents tvPayroll As TreeView
End Class
