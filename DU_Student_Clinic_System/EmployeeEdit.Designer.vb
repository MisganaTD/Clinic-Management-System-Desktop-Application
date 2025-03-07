<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeEdit
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewAllEmployeeforEdit = New System.Windows.Forms.DataGridView()
        Me.ToolStripEditEmpS = New System.Windows.Forms.ToolStrip()
        Me.txttobeeditandsearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripBtnEditEmpSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabelemp = New System.Windows.Forms.ToolStripLabel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBoxinac = New System.Windows.Forms.GroupBox()
        Me.btninactiveemp = New System.Windows.Forms.Button()
        Me.txtEmpIDtobeinactive = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclremplist = New System.Windows.Forms.Button()
        Me.cmbboxeditbranch = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbboxeditrole = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btneditemp = New System.Windows.Forms.Button()
        Me.cmbboxeditdept = New System.Windows.Forms.ComboBox()
        Me.txtboxeditemail = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbboxeditqual = New System.Windows.Forms.ComboBox()
        Me.cmbboxeditgender = New System.Windows.Forms.ComboBox()
        Me.txtboxeditphone = New System.Windows.Forms.TextBox()
        Me.txtboxeditaddress = New System.Windows.Forms.TextBox()
        Me.txtboxeditfn = New System.Windows.Forms.TextBox()
        Me.txtboxediteid = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ErrorProviderEditEmp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbboxopdname = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewAllEmployeeforEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripEditEmpS.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBoxinac.SuspendLayout()
        CType(Me.ErrorProviderEditEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(778, 285)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewAllEmployeeforEdit)
        Me.TabPage2.Controls.Add(Me.ToolStripEditEmpS)
        Me.TabPage2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(770, 253)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DU SCS Employee List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewAllEmployeeforEdit
        '
        Me.DataGridViewAllEmployeeforEdit.AllowUserToAddRows = False
        Me.DataGridViewAllEmployeeforEdit.AllowUserToDeleteRows = False
        Me.DataGridViewAllEmployeeforEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewAllEmployeeforEdit.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewAllEmployeeforEdit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridViewAllEmployeeforEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAllEmployeeforEdit.Location = New System.Drawing.Point(6, 31)
        Me.DataGridViewAllEmployeeforEdit.Name = "DataGridViewAllEmployeeforEdit"
        Me.DataGridViewAllEmployeeforEdit.ReadOnly = True
        Me.DataGridViewAllEmployeeforEdit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewAllEmployeeforEdit.Size = New System.Drawing.Size(758, 216)
        Me.DataGridViewAllEmployeeforEdit.TabIndex = 2
        '
        'ToolStripEditEmpS
        '
        Me.ToolStripEditEmpS.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripEditEmpS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txttobeeditandsearch, Me.ToolStripBtnEditEmpSearch, Me.ToolStripSeparator1, Me.ToolStripLabelemp})
        Me.ToolStripEditEmpS.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripEditEmpS.Name = "ToolStripEditEmpS"
        Me.ToolStripEditEmpS.Size = New System.Drawing.Size(764, 25)
        Me.ToolStripEditEmpS.TabIndex = 1
        Me.ToolStripEditEmpS.Text = "ToolStrip for Lab request"
        '
        'txttobeeditandsearch
        '
        Me.txttobeeditandsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txttobeeditandsearch.Name = "txttobeeditandsearch"
        Me.txttobeeditandsearch.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripBtnEditEmpSearch
        '
        Me.ToolStripBtnEditEmpSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripBtnEditEmpSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripBtnEditEmpSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripBtnEditEmpSearch.ImageTransparentColor = System.Drawing.Color.DarkViolet
        Me.ToolStripBtnEditEmpSearch.Name = "ToolStripBtnEditEmpSearch"
        Me.ToolStripBtnEditEmpSearch.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripBtnEditEmpSearch.Text = "Search"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabelemp
        '
        Me.ToolStripLabelemp.ActiveLinkColor = System.Drawing.Color.White
        Me.ToolStripLabelemp.BackColor = System.Drawing.Color.White
        Me.ToolStripLabelemp.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabelemp.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabelemp.LinkColor = System.Drawing.Color.White
        Me.ToolStripLabelemp.Name = "ToolStripLabelemp"
        Me.ToolStripLabelemp.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripLabelemp.Text = "by employee id, name, phone,branch"
        Me.ToolStripLabelemp.VisitedLinkColor = System.Drawing.Color.White
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBoxinac)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(770, 253)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Inactive Employee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBoxinac
        '
        Me.GroupBoxinac.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBoxinac.Controls.Add(Me.btninactiveemp)
        Me.GroupBoxinac.Controls.Add(Me.txtEmpIDtobeinactive)
        Me.GroupBoxinac.Controls.Add(Me.Label1)
        Me.GroupBoxinac.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxinac.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxinac.Location = New System.Drawing.Point(20, 16)
        Me.GroupBoxinac.Name = "GroupBoxinac"
        Me.GroupBoxinac.Size = New System.Drawing.Size(735, 221)
        Me.GroupBoxinac.TabIndex = 2
        Me.GroupBoxinac.TabStop = False
        '
        'btninactiveemp
        '
        Me.btninactiveemp.BackColor = System.Drawing.Color.Transparent
        Me.btninactiveemp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninactiveemp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btninactiveemp.Location = New System.Drawing.Point(138, 53)
        Me.btninactiveemp.Name = "btninactiveemp"
        Me.btninactiveemp.Size = New System.Drawing.Size(75, 37)
        Me.btninactiveemp.TabIndex = 1
        Me.btninactiveemp.Text = "Inactive"
        Me.btninactiveemp.UseVisualStyleBackColor = False
        '
        'txtEmpIDtobeinactive
        '
        Me.txtEmpIDtobeinactive.Location = New System.Drawing.Point(138, 25)
        Me.txtEmpIDtobeinactive.Name = "txtEmpIDtobeinactive"
        Me.txtEmpIDtobeinactive.Size = New System.Drawing.Size(205, 22)
        Me.txtEmpIDtobeinactive.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Employee ID"
        '
        'btnclremplist
        '
        Me.btnclremplist.BackColor = System.Drawing.Color.Transparent
        Me.btnclremplist.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclremplist.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclremplist.Location = New System.Drawing.Point(531, 414)
        Me.btnclremplist.Name = "btnclremplist"
        Me.btnclremplist.Size = New System.Drawing.Size(75, 39)
        Me.btnclremplist.TabIndex = 87
        Me.btnclremplist.Text = "Clear"
        Me.btnclremplist.UseVisualStyleBackColor = False
        '
        'cmbboxeditbranch
        '
        Me.cmbboxeditbranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxeditbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxeditbranch.FormattingEnabled = True
        Me.cmbboxeditbranch.Items.AddRange(New Object() {"Main Campus", "Odayea Campus", "Hasedela Campus", "A.A Campus", "Dilla Campus", "Hawasa Campus", "Other Campus"})
        Me.cmbboxeditbranch.Location = New System.Drawing.Point(296, 424)
        Me.cmbboxeditbranch.Name = "cmbboxeditbranch"
        Me.cmbboxeditbranch.Size = New System.Drawing.Size(139, 21)
        Me.cmbboxeditbranch.TabIndex = 86
        Me.cmbboxeditbranch.Tag = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(303, 406)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 15)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Branch"
        '
        'cmbboxeditrole
        '
        Me.cmbboxeditrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxeditrole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxeditrole.FormattingEnabled = True
        Me.cmbboxeditrole.Items.AddRange(New Object() {"Physician", "Reception (Card Room)", "Pharmacist", "Laboratorist", "Managing Physician For DUSCS", "Store Manager", "Student Service Team Leader", "System Admin"})
        Me.cmbboxeditrole.Location = New System.Drawing.Point(14, 424)
        Me.cmbboxeditrole.Name = "cmbboxeditrole"
        Me.cmbboxeditrole.Size = New System.Drawing.Size(276, 21)
        Me.cmbboxeditrole.TabIndex = 84
        Me.cmbboxeditrole.Tag = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(21, 406)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 15)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Role"
        '
        'btneditemp
        '
        Me.btneditemp.BackColor = System.Drawing.Color.Transparent
        Me.btneditemp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btneditemp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditemp.Location = New System.Drawing.Point(441, 414)
        Me.btneditemp.Name = "btneditemp"
        Me.btneditemp.Size = New System.Drawing.Size(84, 39)
        Me.btneditemp.TabIndex = 68
        Me.btneditemp.Text = "Edit"
        Me.btneditemp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btneditemp.UseVisualStyleBackColor = False
        '
        'cmbboxeditdept
        '
        Me.cmbboxeditdept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxeditdept.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxeditdept.FormattingEnabled = True
        Me.cmbboxeditdept.Items.AddRange(New Object() {"OPD", "Pharmacy", "Labratory", "C.R", "Store", "Managing", "IT"})
        Me.cmbboxeditdept.Location = New System.Drawing.Point(492, 380)
        Me.cmbboxeditdept.Name = "cmbboxeditdept"
        Me.cmbboxeditdept.Size = New System.Drawing.Size(125, 21)
        Me.cmbboxeditdept.TabIndex = 82
        Me.cmbboxeditdept.Tag = ""
        '
        'txtboxeditemail
        '
        Me.txtboxeditemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxeditemail.Location = New System.Drawing.Point(14, 380)
        Me.txtboxeditemail.Name = "txtboxeditemail"
        Me.txtboxeditemail.Size = New System.Drawing.Size(139, 20)
        Me.txtboxeditemail.TabIndex = 73
        Me.txtboxeditemail.Tag = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(19, 359)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 15)
        Me.Label19.TabIndex = 81
        Me.Label19.Text = "Email"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(636, 360)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 15)
        Me.Label20.TabIndex = 80
        Me.Label20.Text = "Qualification"
        '
        'cmbboxeditqual
        '
        Me.cmbboxeditqual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxeditqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxeditqual.FormattingEnabled = True
        Me.cmbboxeditqual.Items.AddRange(New Object() {"MPH/RH", "HO", "PHS", "MPH", "Pharmacy.Tec", "Laboratury.Tec", "Recorder", "Others"})
        Me.cmbboxeditqual.Location = New System.Drawing.Point(623, 380)
        Me.cmbboxeditqual.Name = "cmbboxeditqual"
        Me.cmbboxeditqual.Size = New System.Drawing.Size(111, 21)
        Me.cmbboxeditqual.TabIndex = 76
        Me.cmbboxeditqual.Tag = ""
        '
        'cmbboxeditgender
        '
        Me.cmbboxeditgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxeditgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxeditgender.FormattingEnabled = True
        Me.cmbboxeditgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbboxeditgender.Location = New System.Drawing.Point(375, 331)
        Me.cmbboxeditgender.Name = "cmbboxeditgender"
        Me.cmbboxeditgender.Size = New System.Drawing.Size(111, 21)
        Me.cmbboxeditgender.TabIndex = 79
        Me.cmbboxeditgender.Tag = ""
        '
        'txtboxeditphone
        '
        Me.txtboxeditphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxeditphone.Location = New System.Drawing.Point(296, 380)
        Me.txtboxeditphone.Name = "txtboxeditphone"
        Me.txtboxeditphone.Size = New System.Drawing.Size(190, 20)
        Me.txtboxeditphone.TabIndex = 74
        Me.txtboxeditphone.Tag = ""
        '
        'txtboxeditaddress
        '
        Me.txtboxeditaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxeditaddress.Location = New System.Drawing.Point(159, 380)
        Me.txtboxeditaddress.Name = "txtboxeditaddress"
        Me.txtboxeditaddress.Size = New System.Drawing.Size(131, 20)
        Me.txtboxeditaddress.TabIndex = 78
        Me.txtboxeditaddress.Tag = ""
        '
        'txtboxeditfn
        '
        Me.txtboxeditfn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxeditfn.Location = New System.Drawing.Point(117, 331)
        Me.txtboxeditfn.Name = "txtboxeditfn"
        Me.txtboxeditfn.Size = New System.Drawing.Size(252, 20)
        Me.txtboxeditfn.TabIndex = 77
        Me.txtboxeditfn.Tag = ""
        '
        'txtboxediteid
        '
        Me.txtboxediteid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxediteid.Location = New System.Drawing.Point(14, 330)
        Me.txtboxediteid.Name = "txtboxediteid"
        Me.txtboxediteid.ReadOnly = True
        Me.txtboxediteid.Size = New System.Drawing.Size(97, 20)
        Me.txtboxediteid.TabIndex = 75
        Me.txtboxediteid.Tag = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(498, 359)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 15)
        Me.Label21.TabIndex = 72
        Me.Label21.Text = "Department"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(311, 359)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 15)
        Me.Label22.TabIndex = 71
        Me.Label22.Text = "Phone"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(393, 311)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 15)
        Me.Label23.TabIndex = 70
        Me.Label23.Text = "Gender"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(169, 360)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 15)
        Me.Label24.TabIndex = 69
        Me.Label24.Text = "Address"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(133, 311)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(35, 15)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = "Name"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(19, 311)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(20, 15)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "ID"
        '
        'ErrorProviderEditEmp
        '
        Me.ErrorProviderEditEmp.ContainerControl = Me
        '
        'cmbboxopdname
        '
        Me.cmbboxopdname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxopdname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxopdname.FormattingEnabled = True
        Me.cmbboxopdname.Items.AddRange(New Object() {"opd 1", "opd 2", "opd 3", "opd 4", "other"})
        Me.cmbboxopdname.Location = New System.Drawing.Point(492, 331)
        Me.cmbboxopdname.Name = "cmbboxopdname"
        Me.cmbboxopdname.Size = New System.Drawing.Size(242, 21)
        Me.cmbboxopdname.TabIndex = 89
        Me.cmbboxopdname.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(510, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "OPD Name"
        '
        'EmployeeEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 484)
        Me.Controls.Add(Me.cmbboxopdname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnclremplist)
        Me.Controls.Add(Me.cmbboxeditbranch)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbboxeditrole)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btneditemp)
        Me.Controls.Add(Me.cmbboxeditdept)
        Me.Controls.Add(Me.txtboxeditemail)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmbboxeditqual)
        Me.Controls.Add(Me.cmbboxeditgender)
        Me.Controls.Add(Me.txtboxeditphone)
        Me.Controls.Add(Me.txtboxeditaddress)
        Me.Controls.Add(Me.txtboxeditfn)
        Me.Controls.Add(Me.txtboxediteid)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmployeeEdit"
        Me.Text = "Edit Physician / Employee - Clinic System"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridViewAllEmployeeforEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripEditEmpS.ResumeLayout(False)
        Me.ToolStripEditEmpS.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBoxinac.ResumeLayout(False)
        Me.GroupBoxinac.PerformLayout()
        CType(Me.ErrorProviderEditEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridViewAllEmployeeforEdit As DataGridView
    Friend WithEvents ToolStripEditEmpS As ToolStrip
    Friend WithEvents txttobeeditandsearch As ToolStripTextBox
    Friend WithEvents ToolStripBtnEditEmpSearch As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabelemp As ToolStripLabel
    Friend WithEvents btnclremplist As Button
    Friend WithEvents cmbboxeditbranch As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbboxeditrole As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btneditemp As Button
    Friend WithEvents cmbboxeditdept As ComboBox
    Friend WithEvents txtboxeditemail As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbboxeditqual As ComboBox
    Friend WithEvents cmbboxeditgender As ComboBox
    Friend WithEvents txtboxeditphone As TextBox
    Friend WithEvents txtboxeditaddress As TextBox
    Friend WithEvents txtboxeditfn As TextBox
    Friend WithEvents txtboxediteid As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents ErrorProviderEditEmp As ErrorProvider
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBoxinac As GroupBox
    Friend WithEvents btninactiveemp As Button
    Friend WithEvents txtEmpIDtobeinactive As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbboxopdname As ComboBox
    Friend WithEvents Label2 As Label
End Class
