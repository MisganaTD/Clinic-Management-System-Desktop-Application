<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbboxbranch = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbboxopdname = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBoxpref = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbboxRole = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.ComboBoxDept = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxELN = New System.Windows.Forms.TextBox()
        Me.TextBoxEMN = New System.Windows.Forms.TextBox()
        Me.TextBoxEE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxET = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEG = New System.Windows.Forms.ComboBox()
        Me.TextBoxEP = New System.Windows.Forms.TextBox()
        Me.TextBoxEA = New System.Windows.Forms.TextBox()
        Me.TextBoxEFN = New System.Windows.Forms.TextBox()
        Me.TextBoxEMid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tipForValidation = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProviderDctF = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnexportelist = New System.Windows.Forms.Button()
        Me.DataGridViewAllEmployee = New System.Windows.Forms.DataGridView()
        Me.ToolStripEmpS = New System.Windows.Forms.ToolStrip()
        Me.txttobesearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripBtnEmpSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabelemp = New System.Windows.Forms.ToolStripLabel()
        Me.SaveFileDialogeexportelist = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProviderDctF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewAllEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripEmpS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbboxbranch)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbboxopdname)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ComboBoxpref)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbboxRole)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnAddEmp)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDept)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBoxELN)
        Me.GroupBox1.Controls.Add(Me.TextBoxEMN)
        Me.GroupBox1.Controls.Add(Me.TextBoxEE)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ComboBoxET)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEG)
        Me.GroupBox1.Controls.Add(Me.TextBoxEP)
        Me.GroupBox1.Controls.Add(Me.TextBoxEA)
        Me.GroupBox1.Controls.Add(Me.TextBoxEFN)
        Me.GroupBox1.Controls.Add(Me.TextBoxEMid)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 419)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Physician / Employee Detail"
        '
        'cmbboxbranch
        '
        Me.cmbboxbranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxbranch.FormattingEnabled = True
        Me.cmbboxbranch.Items.AddRange(New Object() {"Main Campus", "Odayea Campus", "Hasedela Campus", "A.A Campus", "Dilla Campus", "Hawasa Campus", "Other Campus"})
        Me.cmbboxbranch.Location = New System.Drawing.Point(500, 146)
        Me.cmbboxbranch.Name = "cmbboxbranch"
        Me.cmbboxbranch.Size = New System.Drawing.Size(125, 21)
        Me.cmbboxbranch.TabIndex = 40
        Me.cmbboxbranch.Tag = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(508, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 15)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Branch"
        '
        'cmbboxopdname
        '
        Me.cmbboxopdname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxopdname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxopdname.FormattingEnabled = True
        Me.cmbboxopdname.Items.AddRange(New Object() {"opd 1", "opd 2", "opd 3", "opd 4", "other"})
        Me.cmbboxopdname.Location = New System.Drawing.Point(304, 143)
        Me.cmbboxopdname.Name = "cmbboxopdname"
        Me.cmbboxopdname.Size = New System.Drawing.Size(190, 21)
        Me.cmbboxopdname.TabIndex = 38
        Me.cmbboxopdname.Tag = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(311, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 15)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "OPD Name"
        '
        'ComboBoxpref
        '
        Me.ComboBoxpref.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxpref.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxpref.FormattingEnabled = True
        Me.ComboBoxpref.Items.AddRange(New Object() {"Dr.", "Ms.", "Sr.", "Mr."})
        Me.ComboBoxpref.Location = New System.Drawing.Point(147, 50)
        Me.ComboBoxpref.Name = "ComboBoxpref"
        Me.ComboBoxpref.Size = New System.Drawing.Size(61, 21)
        Me.ComboBoxpref.TabIndex = 34
        Me.ComboBoxpref.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(155, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 15)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Prefix"
        '
        'cmbboxRole
        '
        Me.cmbboxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxRole.FormattingEnabled = True
        Me.cmbboxRole.Items.AddRange(New Object() {"Physician", "Reception (Card Room)", "Pharmacist", "Laboratorist", "Managing Physician For DUSCS", "Store Manager", "Student Service Team Leader", "System Admin"})
        Me.cmbboxRole.Location = New System.Drawing.Point(22, 143)
        Me.cmbboxRole.Name = "cmbboxRole"
        Me.cmbboxRole.Size = New System.Drawing.Size(276, 21)
        Me.cmbboxRole.TabIndex = 32
        Me.cmbboxRole.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(29, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 15)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Role"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(100, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnAddEmp
        '
        Me.btnAddEmp.BackColor = System.Drawing.Color.Transparent
        Me.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddEmp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.Location = New System.Drawing.Point(22, 170)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnAddEmp.TabIndex = 1
        Me.btnAddEmp.Text = "Add"
        Me.btnAddEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddEmp.UseVisualStyleBackColor = False
        '
        'ComboBoxDept
        '
        Me.ComboBoxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDept.FormattingEnabled = True
        Me.ComboBoxDept.Items.AddRange(New Object() {"OPD", "Pharmacy", "Labratory", "C.R", "Store", "Managing", "IT"})
        Me.ComboBoxDept.Location = New System.Drawing.Point(500, 99)
        Me.ComboBoxDept.Name = "ComboBoxDept"
        Me.ComboBoxDept.Size = New System.Drawing.Size(125, 21)
        Me.ComboBoxDept.TabIndex = 21
        Me.ComboBoxDept.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(506, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Last Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(387, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Middle Name"
        '
        'TextBoxELN
        '
        Me.TextBoxELN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxELN.Location = New System.Drawing.Point(500, 50)
        Me.TextBoxELN.Name = "TextBoxELN"
        Me.TextBoxELN.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxELN.TabIndex = 18
        Me.TextBoxELN.Tag = ""
        '
        'TextBoxEMN
        '
        Me.TextBoxEMN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEMN.Location = New System.Drawing.Point(357, 50)
        Me.TextBoxEMN.Name = "TextBoxEMN"
        Me.TextBoxEMN.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxEMN.TabIndex = 17
        Me.TextBoxEMN.Tag = ""
        '
        'TextBoxEE
        '
        Me.TextBoxEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEE.Location = New System.Drawing.Point(22, 99)
        Me.TextBoxEE.Name = "TextBoxEE"
        Me.TextBoxEE.Size = New System.Drawing.Size(139, 20)
        Me.TextBoxEE.TabIndex = 6
        Me.TextBoxEE.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(27, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(644, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Qualification"
        '
        'ComboBoxET
        '
        Me.ComboBoxET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxET.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxET.FormattingEnabled = True
        Me.ComboBoxET.Items.AddRange(New Object() {"MPH/RH", "HO", "PHS", "MPH", "Pharmacy.Tec", "Laboratury.Tec", "Recorder", "Others"})
        Me.ComboBoxET.Location = New System.Drawing.Point(631, 99)
        Me.ComboBoxET.Name = "ComboBoxET"
        Me.ComboBoxET.Size = New System.Drawing.Size(111, 21)
        Me.ComboBoxET.TabIndex = 7
        Me.ComboBoxET.Tag = ""
        '
        'ComboBoxEG
        '
        Me.ComboBoxEG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEG.FormattingEnabled = True
        Me.ComboBoxEG.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxEG.Location = New System.Drawing.Point(631, 49)
        Me.ComboBoxEG.Name = "ComboBoxEG"
        Me.ComboBoxEG.Size = New System.Drawing.Size(111, 21)
        Me.ComboBoxEG.TabIndex = 12
        Me.ComboBoxEG.Tag = ""
        '
        'TextBoxEP
        '
        Me.TextBoxEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEP.Location = New System.Drawing.Point(304, 99)
        Me.TextBoxEP.Name = "TextBoxEP"
        Me.TextBoxEP.Size = New System.Drawing.Size(190, 20)
        Me.TextBoxEP.TabIndex = 7
        Me.TextBoxEP.Tag = ""
        '
        'TextBoxEA
        '
        Me.TextBoxEA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEA.Location = New System.Drawing.Point(167, 99)
        Me.TextBoxEA.Name = "TextBoxEA"
        Me.TextBoxEA.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxEA.TabIndex = 7
        Me.TextBoxEA.Tag = ""
        '
        'TextBoxEFN
        '
        Me.TextBoxEFN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEFN.Location = New System.Drawing.Point(222, 50)
        Me.TextBoxEFN.Name = "TextBoxEFN"
        Me.TextBoxEFN.Size = New System.Drawing.Size(129, 20)
        Me.TextBoxEFN.TabIndex = 7
        Me.TextBoxEFN.Tag = ""
        '
        'TextBoxEMid
        '
        Me.TextBoxEMid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEMid.Location = New System.Drawing.Point(22, 49)
        Me.TextBoxEMid.Name = "TextBoxEMid"
        Me.TextBoxEMid.ReadOnly = True
        Me.TextBoxEMid.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxEMid.TabIndex = 7
        Me.TextBoxEMid.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(506, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(319, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(644, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(177, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(259, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'tipForValidation
        '
        Me.tipForValidation.IsBalloon = True
        Me.tipForValidation.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'ErrorProviderDctF
        '
        Me.ErrorProviderDctF.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(778, 463)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(770, 435)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add New Employee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnexportelist)
        Me.TabPage2.Controls.Add(Me.DataGridViewAllEmployee)
        Me.TabPage2.Controls.Add(Me.ToolStripEmpS)
        Me.TabPage2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(770, 435)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DU SCS Employee List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnexportelist
        '
        Me.btnexportelist.Location = New System.Drawing.Point(488, 4)
        Me.btnexportelist.Name = "btnexportelist"
        Me.btnexportelist.Size = New System.Drawing.Size(97, 23)
        Me.btnexportelist.TabIndex = 3
        Me.btnexportelist.Text = "Export to Excel"
        Me.btnexportelist.UseVisualStyleBackColor = True
        '
        'DataGridViewAllEmployee
        '
        Me.DataGridViewAllEmployee.AllowUserToAddRows = False
        Me.DataGridViewAllEmployee.AllowUserToDeleteRows = False
        Me.DataGridViewAllEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewAllEmployee.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewAllEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridViewAllEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAllEmployee.Location = New System.Drawing.Point(6, 31)
        Me.DataGridViewAllEmployee.Name = "DataGridViewAllEmployee"
        Me.DataGridViewAllEmployee.ReadOnly = True
        Me.DataGridViewAllEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewAllEmployee.Size = New System.Drawing.Size(758, 398)
        Me.DataGridViewAllEmployee.TabIndex = 2
        '
        'ToolStripEmpS
        '
        Me.ToolStripEmpS.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripEmpS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txttobesearch, Me.ToolStripBtnEmpSearch, Me.ToolStripSeparator1, Me.ToolStripLabelemp})
        Me.ToolStripEmpS.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripEmpS.Name = "ToolStripEmpS"
        Me.ToolStripEmpS.Size = New System.Drawing.Size(764, 25)
        Me.ToolStripEmpS.TabIndex = 1
        Me.ToolStripEmpS.Text = "ToolStrip for Lab request"
        '
        'txttobesearch
        '
        Me.txttobesearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txttobesearch.Name = "txttobesearch"
        Me.txttobesearch.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripBtnEmpSearch
        '
        Me.ToolStripBtnEmpSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripBtnEmpSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripBtnEmpSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripBtnEmpSearch.ImageTransparentColor = System.Drawing.Color.DarkViolet
        Me.ToolStripBtnEmpSearch.Name = "ToolStripBtnEmpSearch"
        Me.ToolStripBtnEmpSearch.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripBtnEmpSearch.Text = "Search"
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
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 484)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Physician / Employee - Clinic System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProviderDctF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridViewAllEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripEmpS.ResumeLayout(False)
        Me.ToolStripEmpS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxEP As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEA As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEFN As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEMid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddEmp As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBoxEG As System.Windows.Forms.ComboBox
    Friend WithEvents tipForValidation As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProviderDctF As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxET As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxEE As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxELN As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEMN As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxDept As System.Windows.Forms.ComboBox
    Friend WithEvents cmbboxRole As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBoxpref As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStripEmpS As ToolStrip
    Friend WithEvents txttobesearch As ToolStripTextBox
    Friend WithEvents ToolStripBtnEmpSearch As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DataGridViewAllEmployee As DataGridView
    Friend WithEvents ToolStripLabelemp As ToolStripLabel
    Friend WithEvents cmbboxopdname As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbboxbranch As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnexportelist As Button
    Friend WithEvents SaveFileDialogeexportelist As SaveFileDialog
End Class
