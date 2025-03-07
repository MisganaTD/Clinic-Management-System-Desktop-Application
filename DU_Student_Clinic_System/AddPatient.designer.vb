<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPatient
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxPCi = New System.Windows.Forms.TextBox()
        Me.TextBoxPEA = New System.Windows.Forms.TextBox()
        Me.TextBoxPCo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxPTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPID = New System.Windows.Forms.TextBox()
        Me.cmbboxopdna = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxPDept = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPYear = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBoxPaID = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboBoxBgroup = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DateTimePickerRD = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxMStatus = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxPLN = New System.Windows.Forms.TextBox()
        Me.TextBoxPMN = New System.Windows.Forms.TextBox()
        Me.ComboBoxPG = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxPFN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProviderPntF = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTipForPval = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProviderPntF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBoxPCi)
        Me.GroupBox1.Controls.Add(Me.TextBoxPEA)
        Me.GroupBox1.Controls.Add(Me.TextBoxPCo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(2, 226)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Details:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(320, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Email"
        '
        'TextBoxPCi
        '
        Me.TextBoxPCi.Location = New System.Drawing.Point(178, 53)
        Me.TextBoxPCi.Name = "TextBoxPCi"
        Me.TextBoxPCi.Size = New System.Drawing.Size(111, 22)
        Me.TextBoxPCi.TabIndex = 7
        Me.TextBoxPCi.Tag = ""
        '
        'TextBoxPEA
        '
        Me.TextBoxPEA.Location = New System.Drawing.Point(295, 53)
        Me.TextBoxPEA.Name = "TextBoxPEA"
        Me.TextBoxPEA.Size = New System.Drawing.Size(160, 22)
        Me.TextBoxPEA.TabIndex = 4
        Me.TextBoxPEA.Tag = ""
        '
        'TextBoxPCo
        '
        Me.TextBoxPCo.Location = New System.Drawing.Point(60, 53)
        Me.TextBoxPCo.Name = "TextBoxPCo"
        Me.TextBoxPCo.Size = New System.Drawing.Size(112, 22)
        Me.TextBoxPCo.TabIndex = 6
        Me.TextBoxPCo.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(191, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(73, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Country"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(345, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Telephone"
        '
        'TextBoxPTel
        '
        Me.TextBoxPTel.Location = New System.Drawing.Point(326, 156)
        Me.TextBoxPTel.Name = "TextBoxPTel"
        Me.TextBoxPTel.Size = New System.Drawing.Size(126, 22)
        Me.TextBoxPTel.TabIndex = 12
        Me.TextBoxPTel.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(142, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Department"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBoxPID)
        Me.GroupBox2.Controls.Add(Me.cmbboxopdna)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ComboBoxPDept)
        Me.GroupBox2.Controls.Add(Me.ComboBoxPYear)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TextBoxPTel)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.TextBoxPaID)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.ComboBoxBgroup)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerRD)
        Me.GroupBox2.Controls.Add(Me.ComboBoxMStatus)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TextBoxAge)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBoxPLN)
        Me.GroupBox2.Controls.Add(Me.TextBoxPMN)
        Me.GroupBox2.Controls.Add(Me.ComboBoxPG)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBoxPFN)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(795, 208)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General Information:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(70, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Card Number"
        '
        'TextBoxPID
        '
        Me.TextBoxPID.Location = New System.Drawing.Point(59, 54)
        Me.TextBoxPID.Name = "TextBoxPID"
        Me.TextBoxPID.Size = New System.Drawing.Size(137, 22)
        Me.TextBoxPID.TabIndex = 41
        '
        'cmbboxopdna
        '
        Me.cmbboxopdna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxopdna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxopdna.FormattingEnabled = True
        Me.cmbboxopdna.Items.AddRange(New Object() {"opd 1", "opd 2", "opd 3", "opd 4"})
        Me.cmbboxopdna.Location = New System.Drawing.Point(463, 156)
        Me.cmbboxopdna.Name = "cmbboxopdna"
        Me.cmbboxopdna.Size = New System.Drawing.Size(232, 21)
        Me.cmbboxopdna.TabIndex = 40
        Me.cmbboxopdna.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(470, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Assign to OPD"
        '
        'ComboBoxPDept
        '
        Me.ComboBoxPDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPDept.FormattingEnabled = True
        Me.ComboBoxPDept.Items.AddRange(New Object() {"Social Anthropology", "Medicine", "Pre-Engineering", "Animal and Range Science", "Mechanical Engineering", "Biology ", "Educational Planning and Management", "Department of Architecture", "Psychiatry Nurse", "Computer Science", "Special Needs and Inclusive Education", "Horticulture", "Water Resource and Irrigation Engineering ", "information Communication Technology", "Physics", "Automotive Engineering", "Land Administration and Surveying", "Natural Resource Management", "MANUFACTURING", "Public Administration & Development Management", "Post Graduate Diploma Train", "Sociology", "Economics", "Department of Law", "Management", "Statistics", "Ethiopian Language and Literature Amharic", "History and Heritage Management ", "Water Resource and Irrigation Management", "Health Officer ", "Food Engineering ", "Medical Laboratory ", "Civics and Ethical Studies", "Psychology", "Afan Oromo Language and Literature ", "Electrical and Computer Engineering", "Hydraulic and Water Resources Engineering", "Agricultural Economics", "Construction Technology and Management", "Plant Science", "Logistic and Transport Management ", "Accounting & Finance", "MSc Summer Program in Mathematics", "Curriculum and Instructional Supervision", "Chemistry ", "Journalism and Communication ", "Gedeuffa and literature ", "Anesthesiology", "English Language and Literature", "Sport Science", "Nursing ", "Civil Engineering ", "Pharmacy", "Geography and Environmental Studies", "Midwifery ", "Mathematics", "Animal Health", "Geology"})
        Me.ComboBoxPDept.Location = New System.Drawing.Point(59, 156)
        Me.ComboBoxPDept.Name = "ComboBoxPDept"
        Me.ComboBoxPDept.Size = New System.Drawing.Size(261, 23)
        Me.ComboBoxPDept.TabIndex = 33
        Me.ComboBoxPDept.Tag = ""
        '
        'ComboBoxPYear
        '
        Me.ComboBoxPYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPYear.FormattingEnabled = True
        Me.ComboBoxPYear.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ComboBoxPYear.Location = New System.Drawing.Point(591, 104)
        Me.ComboBoxPYear.Name = "ComboBoxPYear"
        Me.ComboBoxPYear.Size = New System.Drawing.Size(104, 23)
        Me.ComboBoxPYear.TabIndex = 32
        Me.ComboBoxPYear.Tag = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(597, 84)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 15)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Year"
        '
        'TextBoxPaID
        '
        Me.TextBoxPaID.Location = New System.Drawing.Point(459, 106)
        Me.TextBoxPaID.Name = "TextBoxPaID"
        Me.TextBoxPaID.Size = New System.Drawing.Size(126, 22)
        Me.TextBoxPaID.TabIndex = 28
        Me.TextBoxPaID.Tag = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(489, 85)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 15)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "ID Number"
        '
        'ComboBoxBgroup
        '
        Me.ComboBoxBgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBgroup.FormattingEnabled = True
        Me.ComboBoxBgroup.Items.AddRange(New Object() {"A", "A+", "A-", "B", "B+", "B-", "AB", "AB+", "AB-", "O", "O+", "O-"})
        Me.ComboBoxBgroup.Location = New System.Drawing.Point(372, 106)
        Me.ComboBoxBgroup.Name = "ComboBoxBgroup"
        Me.ComboBoxBgroup.Size = New System.Drawing.Size(82, 23)
        Me.ComboBoxBgroup.TabIndex = 26
        Me.ComboBoxBgroup.Tag = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(380, 84)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 15)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Blood group"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(255, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 15)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Registration date"
        '
        'DateTimePickerRD
        '
        Me.DateTimePickerRD.CalendarFont = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerRD.CustomFormat = "dd-MM-yyy"
        Me.DateTimePickerRD.Enabled = False
        Me.DateTimePickerRD.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerRD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerRD.Location = New System.Drawing.Point(249, 106)
        Me.DateTimePickerRD.Name = "DateTimePickerRD"
        Me.DateTimePickerRD.Size = New System.Drawing.Size(117, 21)
        Me.DateTimePickerRD.TabIndex = 23
        Me.DateTimePickerRD.Tag = ""
        '
        'ComboBoxMStatus
        '
        Me.ComboBoxMStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMStatus.FormattingEnabled = True
        Me.ComboBoxMStatus.Items.AddRange(New Object() {"Married", "Unmarried"})
        Me.ComboBoxMStatus.Location = New System.Drawing.Point(124, 105)
        Me.ComboBoxMStatus.Name = "ComboBoxMStatus"
        Me.ComboBoxMStatus.Size = New System.Drawing.Size(118, 23)
        Me.ComboBoxMStatus.TabIndex = 20
        Me.ComboBoxMStatus.Tag = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(141, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 15)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Marital Status"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(65, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 15)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Age"
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(59, 106)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(57, 22)
        Me.TextBoxAge.TabIndex = 14
        Me.TextBoxAge.Tag = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(479, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Last name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(357, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 15)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Middle name"
        '
        'TextBoxPLN
        '
        Me.TextBoxPLN.Location = New System.Drawing.Point(458, 54)
        Me.TextBoxPLN.Name = "TextBoxPLN"
        Me.TextBoxPLN.Size = New System.Drawing.Size(118, 22)
        Me.TextBoxPLN.TabIndex = 15
        Me.TextBoxPLN.Tag = ""
        '
        'TextBoxPMN
        '
        Me.TextBoxPMN.Location = New System.Drawing.Point(334, 54)
        Me.TextBoxPMN.Name = "TextBoxPMN"
        Me.TextBoxPMN.Size = New System.Drawing.Size(118, 22)
        Me.TextBoxPMN.TabIndex = 14
        Me.TextBoxPMN.Tag = ""
        '
        'ComboBoxPG
        '
        Me.ComboBoxPG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPG.FormattingEnabled = True
        Me.ComboBoxPG.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxPG.Location = New System.Drawing.Point(582, 54)
        Me.ComboBoxPG.Name = "ComboBoxPG"
        Me.ComboBoxPG.Size = New System.Drawing.Size(113, 23)
        Me.ComboBoxPG.TabIndex = 5
        Me.ComboBoxPG.Tag = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(601, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Gender"
        '
        'TextBoxPFN
        '
        Me.TextBoxPFN.Location = New System.Drawing.Point(210, 54)
        Me.TextBoxPFN.Name = "TextBoxPFN"
        Me.TextBoxPFN.Size = New System.Drawing.Size(118, 22)
        Me.TextBoxPFN.TabIndex = 1
        Me.TextBoxPFN.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(230, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First name"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(143, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 26)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Clear"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(62, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorProviderPntF
        '
        Me.ErrorProviderPntF.ContainerControl = Me
        '
        'AddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 484)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Patient - Clinic System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProviderPntF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPFN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPCi As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPCo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPEA As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPG As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ErrorProviderPntF As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPLN As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPMN As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPTel As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipForPval As System.Windows.Forms.ToolTip
    Friend WithEvents ComboBoxMStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAge As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerRD As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxBgroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPaID As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ComboBoxPYear As ComboBox
    Friend WithEvents ComboBoxPDept As ComboBox
    Friend WithEvents cmbboxopdna As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPID As TextBox
End Class
