<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchoolStaff
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
        Me.cboResidence = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.DTPDOR = New System.Windows.Forms.DateTimePicker()
        Me.DTPDOE = New System.Windows.Forms.DateTimePicker()
        Me.DTPDOB = New System.Windows.Forms.DateTimePicker()
        Me.cboEmpType = New System.Windows.Forms.ComboBox()
        Me.cboContractType = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cboEmpTitle = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBasicSalary = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboReligion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.txtIdNo = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstStaff = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.StatusStrip11 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip12 = New System.Windows.Forms.StatusStrip()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtKRAPin = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtShifNo = New System.Windows.Forms.TextBox()
        Me.txtNSSFNo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbMale = New System.Windows.Forms.CheckBox()
        Me.cbHead = New System.Windows.Forms.CheckBox()
        Me.cbMarried = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.StatusStrip11.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboResidence
        '
        Me.cboResidence.FormattingEnabled = True
        Me.cboResidence.Location = New System.Drawing.Point(447, 62)
        Me.cboResidence.Margin = New System.Windows.Forms.Padding(4)
        Me.cboResidence.Name = "cboResidence"
        Me.cboResidence.Size = New System.Drawing.Size(213, 24)
        Me.cboResidence.TabIndex = 71
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(85, 62)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(247, 22)
        Me.txtAddress.TabIndex = 70
        '
        'DTPDOR
        '
        Me.DTPDOR.CustomFormat = "dd - MM - yyy"
        Me.DTPDOR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPDOR.Location = New System.Drawing.Point(447, 141)
        Me.DTPDOR.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPDOR.Name = "DTPDOR"
        Me.DTPDOR.Size = New System.Drawing.Size(213, 22)
        Me.DTPDOR.TabIndex = 64
        '
        'DTPDOE
        '
        Me.DTPDOE.CustomFormat = "dd - MM - yyy"
        Me.DTPDOE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPDOE.Location = New System.Drawing.Point(129, 144)
        Me.DTPDOE.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPDOE.Name = "DTPDOE"
        Me.DTPDOE.Size = New System.Drawing.Size(203, 22)
        Me.DTPDOE.TabIndex = 63
        '
        'DTPDOB
        '
        Me.DTPDOB.CustomFormat = "dd - MM - yyy"
        Me.DTPDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPDOB.Location = New System.Drawing.Point(786, 143)
        Me.DTPDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPDOB.Name = "DTPDOB"
        Me.DTPDOB.Size = New System.Drawing.Size(208, 22)
        Me.DTPDOB.TabIndex = 62
        '
        'cboEmpType
        '
        Me.cboEmpType.FormattingEnabled = True
        Me.cboEmpType.Location = New System.Drawing.Point(1100, 62)
        Me.cboEmpType.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEmpType.Name = "cboEmpType"
        Me.cboEmpType.Size = New System.Drawing.Size(217, 24)
        Me.cboEmpType.TabIndex = 59
        '
        'cboContractType
        '
        Me.cboContractType.FormattingEnabled = True
        Me.cboContractType.Location = New System.Drawing.Point(786, 62)
        Me.cboContractType.Margin = New System.Windows.Forms.Padding(4)
        Me.cboContractType.Name = "cboContractType"
        Me.cboContractType.Size = New System.Drawing.Size(208, 24)
        Me.cboContractType.TabIndex = 58
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(85, 102)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(247, 22)
        Me.txtEmail.TabIndex = 57
        '
        'cboEmpTitle
        '
        Me.cboEmpTitle.FormattingEnabled = True
        Me.cboEmpTitle.Location = New System.Drawing.Point(85, 19)
        Me.cboEmpTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEmpTitle.Name = "cboEmpTitle"
        Me.cboEmpTitle.Size = New System.Drawing.Size(81, 24)
        Me.cboEmpTitle.TabIndex = 53
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1028, 105)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 17)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Religion:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(677, 65)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 17)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Contract Type:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(345, 146)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 17)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Date Of Reg:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(684, 146)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 17)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Date Of Birth:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 148)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 17)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Date Employed:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 65)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 17)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Address:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(360, 65)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 17)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Residence:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1016, 65)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Emp Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 24)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Title:"
        '
        'txtBasicSalary
        '
        Me.txtBasicSalary.Location = New System.Drawing.Point(786, 184)
        Me.txtBasicSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBasicSalary.Name = "txtBasicSalary"
        Me.txtBasicSalary.Size = New System.Drawing.Size(208, 22)
        Me.txtBasicSalary.TabIndex = 76
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(684, 189)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 21)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Basic Salary:"
        '
        'cboReligion
        '
        Me.cboReligion.FormattingEnabled = True
        Me.cboReligion.Location = New System.Drawing.Point(1101, 102)
        Me.cboReligion.Margin = New System.Windows.Forms.Padding(4)
        Me.cboReligion.Name = "cboReligion"
        Me.cboReligion.Size = New System.Drawing.Size(216, 24)
        Me.cboReligion.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(364, 106)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Phone No:"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(447, 103)
        Me.txtPhoneNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(213, 22)
        Me.txtPhoneNo.TabIndex = 61
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(1100, 19)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(217, 22)
        Me.txtLName.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(726, 105)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "ID No:"
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(786, 19)
        Me.txtMName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(208, 22)
        Me.txtMName.TabIndex = 55
        '
        'txtIdNo
        '
        Me.txtIdNo.Location = New System.Drawing.Point(786, 102)
        Me.txtIdNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdNo.Name = "txtIdNo"
        Me.txtIdNo.Size = New System.Drawing.Size(208, 22)
        Me.txtIdNo.TabIndex = 60
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(447, 19)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(213, 22)
        Me.txtFName.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(174, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "No:"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(212, 19)
        Me.txtEmpNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(120, 22)
        Me.txtEmpNo.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(718, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "MName:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1011, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Last Name:"
        '
        'lstStaff
        '
        Me.lstStaff.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lstStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstStaff.FullRowSelect = True
        Me.lstStaff.GridLines = True
        Me.lstStaff.HideSelection = False
        Me.lstStaff.Location = New System.Drawing.Point(0, 0)
        Me.lstStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.lstStaff.Name = "lstStaff"
        Me.lstStaff.Size = New System.Drawing.Size(1330, 414)
        Me.lstStaff.TabIndex = 25
        Me.lstStaff.UseCompatibleStateImageBehavior = False
        Me.lstStaff.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Emp No"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FULL NAME"
        Me.ColumnHeader2.Width = 240
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CONTRACT TYPE"
        Me.ColumnHeader3.Width = 156
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "EMP TYPE"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "PHONE NO"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID NUMBER"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "RELIGION"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "RESIDENCE"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "BASIC SALARY"
        Me.ColumnHeader9.Width = 116
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(613, 11)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(100, 28)
        Me.btnView.TabIndex = 52
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(1057, 11)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 28)
        Me.btnDelete.TabIndex = 51
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(907, 11)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 50
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(757, 11)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1209, 11)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 48
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip12, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(22, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.50365!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.49635!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 422.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1338, 755)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lstStaff)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 263)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1332, 416)
        Me.Panel3.TabIndex = 37
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.StatusStrip11)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1332, 29)
        Me.Panel4.TabIndex = 36
        '
        'StatusStrip11
        '
        Me.StatusStrip11.AutoSize = False
        Me.StatusStrip11.BackColor = System.Drawing.Color.LightSeaGreen
        Me.StatusStrip11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip11.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip11.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3})
        Me.StatusStrip11.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip11.Name = "StatusStrip11"
        Me.StatusStrip11.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip11.Size = New System.Drawing.Size(1330, 27)
        Me.StatusStrip11.SizingGrip = False
        Me.StatusStrip11.TabIndex = 33
        Me.StatusStrip11.Text = "StatusStrip11"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(205, 21)
        Me.ToolStripStatusLabel3.Text = "SCHOOL STAFF DETAILS"
        '
        'StatusStrip12
        '
        Me.StatusStrip12.AutoSize = False
        Me.StatusStrip12.BackColor = System.Drawing.Color.LightSeaGreen
        Me.StatusStrip12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip12.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip12.Location = New System.Drawing.Point(0, 740)
        Me.StatusStrip12.Name = "StatusStrip12"
        Me.StatusStrip12.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip12.Size = New System.Drawing.Size(1338, 15)
        Me.StatusStrip12.SizingGrip = False
        Me.StatusStrip12.TabIndex = 35
        Me.StatusStrip12.Text = "StatusStrip12"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnView)
        Me.Panel5.Controls.Add(Me.btnClose)
        Me.Panel5.Controls.Add(Me.btnDelete)
        Me.Panel5.Controls.Add(Me.btnSave)
        Me.Panel5.Controls.Add(Me.btnUpdate)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 685)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1332, 52)
        Me.Panel5.TabIndex = 38
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.cbMarried)
        Me.Panel6.Controls.Add(Me.cbHead)
        Me.Panel6.Controls.Add(Me.cbMale)
        Me.Panel6.Controls.Add(Me.txtShifNo)
        Me.Panel6.Controls.Add(Me.txtNSSFNo)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.txtKRAPin)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.DTPDOR)
        Me.Panel6.Controls.Add(Me.cboReligion)
        Me.Panel6.Controls.Add(Me.txtBasicSalary)
        Me.Panel6.Controls.Add(Me.DTPDOE)
        Me.Panel6.Controls.Add(Me.cboResidence)
        Me.Panel6.Controls.Add(Me.DTPDOB)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.txtEmail)
        Me.Panel6.Controls.Add(Me.txtPhoneNo)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.txtAddress)
        Me.Panel6.Controls.Add(Me.txtIdNo)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Controls.Add(Me.cboEmpType)
        Me.Panel6.Controls.Add(Me.txtLName)
        Me.Panel6.Controls.Add(Me.cboEmpTitle)
        Me.Panel6.Controls.Add(Me.cboContractType)
        Me.Panel6.Controls.Add(Me.txtMName)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.txtFName)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.txtEmpNo)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 38)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1332, 219)
        Me.Panel6.TabIndex = 37
        '
        'txtKRAPin
        '
        Me.txtKRAPin.Location = New System.Drawing.Point(1100, 146)
        Me.txtKRAPin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKRAPin.Name = "txtKRAPin"
        Me.txtKRAPin.Size = New System.Drawing.Size(217, 22)
        Me.txtKRAPin.TabIndex = 78
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1027, 146)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 17)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "KRA Pin:"
        '
        'txtShifNo
        '
        Me.txtShifNo.Location = New System.Drawing.Point(447, 184)
        Me.txtShifNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShifNo.Name = "txtShifNo"
        Me.txtShifNo.Size = New System.Drawing.Size(213, 22)
        Me.txtShifNo.TabIndex = 82
        '
        'txtNSSFNo
        '
        Me.txtNSSFNo.Location = New System.Drawing.Point(129, 184)
        Me.txtNSSFNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNSSFNo.Name = "txtNSSFNo"
        Me.txtNSSFNo.Size = New System.Drawing.Size(203, 22)
        Me.txtNSSFNo.TabIndex = 81
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(364, 187)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 17)
        Me.Label19.TabIndex = 80
        Me.Label19.Text = "SHIF No:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 187)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 17)
        Me.Label20.TabIndex = 79
        Me.Label20.Text = "NSSF No:"
        '
        'cbMale
        '
        Me.cbMale.AutoSize = True
        Me.cbMale.Location = New System.Drawing.Point(1128, 183)
        Me.cbMale.Name = "cbMale"
        Me.cbMale.Size = New System.Drawing.Size(68, 21)
        Me.cbMale.TabIndex = 83
        Me.cbMale.Text = "Male?"
        Me.cbMale.UseVisualStyleBackColor = True
        '
        'cbHead
        '
        Me.cbHead.AutoSize = True
        Me.cbHead.Location = New System.Drawing.Point(1014, 184)
        Me.cbHead.Name = "cbHead"
        Me.cbHead.Size = New System.Drawing.Size(86, 21)
        Me.cbHead.TabIndex = 84
        Me.cbHead.Text = "Is Head?"
        Me.cbHead.UseVisualStyleBackColor = True
        '
        'cbMarried
        '
        Me.cbMarried.AutoSize = True
        Me.cbMarried.Location = New System.Drawing.Point(1231, 183)
        Me.cbMarried.Name = "cbMarried"
        Me.cbMarried.Size = New System.Drawing.Size(86, 21)
        Me.cbMarried.TabIndex = 85
        Me.cbMarried.Text = "Married?"
        Me.cbMarried.UseVisualStyleBackColor = True
        '
        'frmSchoolStaff
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1411, 833)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSchoolStaff"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "School Staff"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.StatusStrip11.ResumeLayout(False)
        Me.StatusStrip11.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstStaff As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DTPDOR As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDOE As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txtIdNo As System.Windows.Forms.TextBox
    Friend WithEvents cboEmpType As System.Windows.Forms.ComboBox
    Friend WithEvents cboContractType As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents cboEmpTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cboReligion As System.Windows.Forms.ComboBox
    Friend WithEvents cboResidence As System.Windows.Forms.ComboBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents StatusStrip11 As StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents StatusStrip12 As StatusStrip
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbMarried As CheckBox
    Friend WithEvents cbHead As CheckBox
    Friend WithEvents cbMale As CheckBox
    Friend WithEvents txtShifNo As TextBox
    Friend WithEvents txtNSSFNo As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtKRAPin As TextBox
    Friend WithEvents Label18 As Label
End Class
