<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewPatient
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
        Me.DataGridViewVAllPatient = New System.Windows.Forms.DataGridView()
        Me.ErrorProviderVP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnexportvp = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TextBoxPSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripbtnSrchP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnclremplist = New System.Windows.Forms.Button()
        Me.cmbboxpebranch = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btneditemp = New System.Windows.Forms.Button()
        Me.txtpeemail = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbboxpeopd = New System.Windows.Forms.ComboBox()
        Me.txtpephone = New System.Windows.Forms.TextBox()
        Me.txtpeaddress = New System.Windows.Forms.TextBox()
        Me.txtpename = New System.Windows.Forms.TextBox()
        Me.txtpeid = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DataGridViewpatientandedit = New System.Windows.Forms.DataGridView()
        Me.ToolStripEditPatientS = New System.Windows.Forms.ToolStrip()
        Me.txttobeeditandsearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripBtnEditPSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabelemp = New System.Windows.Forms.ToolStripLabel()
        Me.SaveFileDialogvp = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridViewVAllPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderVP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewpatientandedit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripEditPatientS.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewVAllPatient
        '
        Me.DataGridViewVAllPatient.AllowUserToAddRows = False
        Me.DataGridViewVAllPatient.AllowUserToDeleteRows = False
        Me.DataGridViewVAllPatient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewVAllPatient.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewVAllPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVAllPatient.Location = New System.Drawing.Point(6, 32)
        Me.DataGridViewVAllPatient.Name = "DataGridViewVAllPatient"
        Me.DataGridViewVAllPatient.ReadOnly = True
        Me.DataGridViewVAllPatient.Size = New System.Drawing.Size(927, 472)
        Me.DataGridViewVAllPatient.TabIndex = 1
        '
        'ErrorProviderVP
        '
        Me.ErrorProviderVP.ContainerControl = Me
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(947, 538)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnexportvp)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Controls.Add(Me.DataGridViewVAllPatient)
        Me.TabPage1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(939, 510)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View Patient"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnexportvp
        '
        Me.btnexportvp.Location = New System.Drawing.Point(463, 3)
        Me.btnexportvp.Name = "btnexportvp"
        Me.btnexportvp.Size = New System.Drawing.Size(100, 23)
        Me.btnexportvp.TabIndex = 3
        Me.btnexportvp.Text = "Export to Excel"
        Me.btnexportvp.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextBoxPSearch, Me.ToolStripbtnSrchP, Me.ToolStripSeparator1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(933, 26)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TextBoxPSearch
        '
        Me.TextBoxPSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPSearch.Name = "TextBoxPSearch"
        Me.TextBoxPSearch.Size = New System.Drawing.Size(200, 26)
        '
        'ToolStripbtnSrchP
        '
        Me.ToolStripbtnSrchP.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripbtnSrchP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripbtnSrchP.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripbtnSrchP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripbtnSrchP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripbtnSrchP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripbtnSrchP.Name = "ToolStripbtnSrchP"
        Me.ToolStripbtnSrchP.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripbtnSrchP.Text = "Search"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(169, 23)
        Me.ToolStripLabel2.Text = "by patient id, name, phone,branch"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnclremplist)
        Me.TabPage2.Controls.Add(Me.cmbboxpebranch)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.btneditemp)
        Me.TabPage2.Controls.Add(Me.txtpeemail)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.cmbboxpeopd)
        Me.TabPage2.Controls.Add(Me.txtpephone)
        Me.TabPage2.Controls.Add(Me.txtpeaddress)
        Me.TabPage2.Controls.Add(Me.txtpename)
        Me.TabPage2.Controls.Add(Me.txtpeid)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.DataGridViewpatientandedit)
        Me.TabPage2.Controls.Add(Me.ToolStripEditPatientS)
        Me.TabPage2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(939, 510)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edit Patient Detail"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnclremplist
        '
        Me.btnclremplist.BackColor = System.Drawing.Color.Transparent
        Me.btnclremplist.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclremplist.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclremplist.Location = New System.Drawing.Point(464, 322)
        Me.btnclremplist.Name = "btnclremplist"
        Me.btnclremplist.Size = New System.Drawing.Size(75, 39)
        Me.btnclremplist.TabIndex = 109
        Me.btnclremplist.Text = "Clear"
        Me.btnclremplist.UseVisualStyleBackColor = False
        '
        'cmbboxpebranch
        '
        Me.cmbboxpebranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxpebranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxpebranch.FormattingEnabled = True
        Me.cmbboxpebranch.Items.AddRange(New Object() {"Odayea Campus", "Main Campus"})
        Me.cmbboxpebranch.Location = New System.Drawing.Point(14, 340)
        Me.cmbboxpebranch.Name = "cmbboxpebranch"
        Me.cmbboxpebranch.Size = New System.Drawing.Size(139, 21)
        Me.cmbboxpebranch.TabIndex = 108
        Me.cmbboxpebranch.Tag = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(21, 322)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 15)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "Branch"
        '
        'btneditemp
        '
        Me.btneditemp.BackColor = System.Drawing.Color.Transparent
        Me.btneditemp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btneditemp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditemp.Location = New System.Drawing.Point(374, 322)
        Me.btneditemp.Name = "btneditemp"
        Me.btneditemp.Size = New System.Drawing.Size(84, 39)
        Me.btneditemp.TabIndex = 90
        Me.btneditemp.Text = "Edit"
        Me.btneditemp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btneditemp.UseVisualStyleBackColor = False
        '
        'txtpeemail
        '
        Me.txtpeemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpeemail.Location = New System.Drawing.Point(374, 291)
        Me.txtpeemail.Name = "txtpeemail"
        Me.txtpeemail.ReadOnly = True
        Me.txtpeemail.Size = New System.Drawing.Size(139, 20)
        Me.txtpeemail.TabIndex = 95
        Me.txtpeemail.Tag = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(379, 270)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 15)
        Me.Label19.TabIndex = 103
        Me.Label19.Text = "Email"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(183, 320)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 15)
        Me.Label20.TabIndex = 102
        Me.Label20.Text = "OPD"
        '
        'cmbboxpeopd
        '
        Me.cmbboxpeopd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxpeopd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxpeopd.FormattingEnabled = True
        Me.cmbboxpeopd.Items.AddRange(New Object() {"opd 1", "opd 2", "opd 3", "opd 4"})
        Me.cmbboxpeopd.Location = New System.Drawing.Point(170, 340)
        Me.cmbboxpeopd.Name = "cmbboxpeopd"
        Me.cmbboxpeopd.Size = New System.Drawing.Size(185, 21)
        Me.cmbboxpeopd.TabIndex = 98
        Me.cmbboxpeopd.Tag = ""
        '
        'txtpephone
        '
        Me.txtpephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpephone.Location = New System.Drawing.Point(656, 291)
        Me.txtpephone.Name = "txtpephone"
        Me.txtpephone.ReadOnly = True
        Me.txtpephone.Size = New System.Drawing.Size(190, 20)
        Me.txtpephone.TabIndex = 96
        Me.txtpephone.Tag = ""
        '
        'txtpeaddress
        '
        Me.txtpeaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpeaddress.Location = New System.Drawing.Point(519, 291)
        Me.txtpeaddress.Name = "txtpeaddress"
        Me.txtpeaddress.ReadOnly = True
        Me.txtpeaddress.Size = New System.Drawing.Size(131, 20)
        Me.txtpeaddress.TabIndex = 100
        Me.txtpeaddress.Tag = ""
        '
        'txtpename
        '
        Me.txtpename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpename.Location = New System.Drawing.Point(117, 291)
        Me.txtpename.Name = "txtpename"
        Me.txtpename.ReadOnly = True
        Me.txtpename.Size = New System.Drawing.Size(252, 20)
        Me.txtpename.TabIndex = 99
        Me.txtpename.Tag = ""
        '
        'txtpeid
        '
        Me.txtpeid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpeid.Location = New System.Drawing.Point(14, 290)
        Me.txtpeid.Name = "txtpeid"
        Me.txtpeid.Size = New System.Drawing.Size(97, 20)
        Me.txtpeid.TabIndex = 97
        Me.txtpeid.Tag = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(671, 270)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 15)
        Me.Label22.TabIndex = 93
        Me.Label22.Text = "Phone"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(529, 271)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 15)
        Me.Label24.TabIndex = 91
        Me.Label24.Text = "Address"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(133, 271)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(35, 15)
        Me.Label25.TabIndex = 89
        Me.Label25.Text = "Name"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(19, 271)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(20, 15)
        Me.Label26.TabIndex = 88
        Me.Label26.Text = "ID"
        '
        'DataGridViewpatientandedit
        '
        Me.DataGridViewpatientandedit.AllowUserToAddRows = False
        Me.DataGridViewpatientandedit.AllowUserToDeleteRows = False
        Me.DataGridViewpatientandedit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewpatientandedit.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewpatientandedit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridViewpatientandedit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewpatientandedit.Location = New System.Drawing.Point(6, 31)
        Me.DataGridViewpatientandedit.Name = "DataGridViewpatientandedit"
        Me.DataGridViewpatientandedit.ReadOnly = True
        Me.DataGridViewpatientandedit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewpatientandedit.Size = New System.Drawing.Size(927, 225)
        Me.DataGridViewpatientandedit.TabIndex = 3
        '
        'ToolStripEditPatientS
        '
        Me.ToolStripEditPatientS.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripEditPatientS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txttobeeditandsearch, Me.ToolStripBtnEditPSearch, Me.ToolStripSeparator2, Me.ToolStripLabelemp})
        Me.ToolStripEditPatientS.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripEditPatientS.Name = "ToolStripEditPatientS"
        Me.ToolStripEditPatientS.Size = New System.Drawing.Size(933, 25)
        Me.ToolStripEditPatientS.TabIndex = 2
        Me.ToolStripEditPatientS.Text = "ToolStrip for Lab request"
        '
        'txttobeeditandsearch
        '
        Me.txttobeeditandsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txttobeeditandsearch.Name = "txttobeeditandsearch"
        Me.txttobeeditandsearch.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripBtnEditPSearch
        '
        Me.ToolStripBtnEditPSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripBtnEditPSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripBtnEditPSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripBtnEditPSearch.ImageTransparentColor = System.Drawing.Color.DarkViolet
        Me.ToolStripBtnEditPSearch.Name = "ToolStripBtnEditPSearch"
        Me.ToolStripBtnEditPSearch.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripBtnEditPSearch.Text = "Search"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabelemp
        '
        Me.ToolStripLabelemp.ActiveLinkColor = System.Drawing.Color.White
        Me.ToolStripLabelemp.BackColor = System.Drawing.Color.White
        Me.ToolStripLabelemp.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabelemp.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabelemp.LinkColor = System.Drawing.Color.White
        Me.ToolStripLabelemp.Name = "ToolStripLabelemp"
        Me.ToolStripLabelemp.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripLabelemp.Text = "by patient id, name, phone,branch"
        Me.ToolStripLabelemp.VisitedLinkColor = System.Drawing.Color.White
        '
        'ViewPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(971, 556)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View/Edit Patient details - Clinic System"
        CType(Me.DataGridViewVAllPatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderVP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridViewpatientandedit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripEditPatientS.ResumeLayout(False)
        Me.ToolStripEditPatientS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewVAllPatient As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProviderVP As System.Windows.Forms.ErrorProvider
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TextBoxPSearch As ToolStripTextBox
    Friend WithEvents ToolStripbtnSrchP As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripEditPatientS As ToolStrip
    Friend WithEvents txttobeeditandsearch As ToolStripTextBox
    Friend WithEvents ToolStripBtnEditPSearch As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabelemp As ToolStripLabel
    Friend WithEvents DataGridViewpatientandedit As DataGridView
    Friend WithEvents btnclremplist As Button
    Friend WithEvents cmbboxpebranch As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btneditemp As Button
    Friend WithEvents txtpeemail As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbboxpeopd As ComboBox
    Friend WithEvents txtpephone As TextBox
    Friend WithEvents txtpeaddress As TextBox
    Friend WithEvents txtpename As TextBox
    Friend WithEvents txtpeid As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents btnexportvp As Button
    Friend WithEvents SaveFileDialogvp As SaveFileDialog
End Class
