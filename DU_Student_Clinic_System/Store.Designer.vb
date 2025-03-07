<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Store
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtboxapv = New System.Windows.Forms.TextBox()
        Me.txtboxui = New System.Windows.Forms.TextBox()
        Me.DateTimePickerexpirydate = New System.Windows.Forms.DateTimePicker()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btndeleteitem = New System.Windows.Forms.Button()
        Me.btnedititem = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnitemsearch = New System.Windows.Forms.Button()
        Me.txtboxsearchitem = New System.Windows.Forms.TextBox()
        Me.DataGridViewStockdata = New System.Windows.Forms.DataGridView()
        Me.btnimportstockfromexcelfile = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnadditem = New System.Windows.Forms.Button()
        Me.txtboxremark = New System.Windows.Forms.TextBox()
        Me.txtboxbno = New System.Windows.Forms.TextBox()
        Me.txtboxqb = New System.Windows.Forms.TextBox()
        Me.txtboxql = New System.Windows.Forms.TextBox()
        Me.txtboxqi = New System.Windows.Forms.TextBox()
        Me.txtboxqr = New System.Windows.Forms.TextBox()
        Me.txtboxrforit = New System.Windows.Forms.TextBox()
        Me.txtboxdocno = New System.Windows.Forms.TextBox()
        Me.txtboxamc = New System.Windows.Forms.TextBox()
        Me.txtboxeop = New System.Windows.Forms.TextBox()
        Me.txtboxmsl = New System.Windows.Forms.TextBox()
        Me.txtboxpnsdf = New System.Windows.Forms.TextBox()
        Me.txtboxnhf = New System.Windows.Forms.TextBox()
        Me.txtboxsi = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtboxbranch = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtboxitem = New System.Windows.Forms.TextBox()
        Me.txtboxreqid = New System.Windows.Forms.TextBox()
        Me.btndispenserequesteditem = New System.Windows.Forms.Button()
        Me.DataGridViewforStockrequested = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStriptxtBoxrequestedstock = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripbtnrequesteditem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolTipforvalidatetxtboxinput = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewStockdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridViewforStockrequested, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(782, 564)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.txtboxapv)
        Me.TabPage1.Controls.Add(Me.txtboxui)
        Me.TabPage1.Controls.Add(Me.DateTimePickerexpirydate)
        Me.TabPage1.Controls.Add(Me.btnrefresh)
        Me.TabPage1.Controls.Add(Me.btndeleteitem)
        Me.TabPage1.Controls.Add(Me.btnedititem)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.DataGridViewStockdata)
        Me.TabPage1.Controls.Add(Me.btnimportstockfromexcelfile)
        Me.TabPage1.Controls.Add(Me.btnclear)
        Me.TabPage1.Controls.Add(Me.btnadditem)
        Me.TabPage1.Controls.Add(Me.txtboxremark)
        Me.TabPage1.Controls.Add(Me.txtboxbno)
        Me.TabPage1.Controls.Add(Me.txtboxqb)
        Me.TabPage1.Controls.Add(Me.txtboxql)
        Me.TabPage1.Controls.Add(Me.txtboxqi)
        Me.TabPage1.Controls.Add(Me.txtboxqr)
        Me.TabPage1.Controls.Add(Me.txtboxrforit)
        Me.TabPage1.Controls.Add(Me.txtboxdocno)
        Me.TabPage1.Controls.Add(Me.txtboxamc)
        Me.TabPage1.Controls.Add(Me.txtboxeop)
        Me.TabPage1.Controls.Add(Me.txtboxmsl)
        Me.TabPage1.Controls.Add(Me.txtboxpnsdf)
        Me.TabPage1.Controls.Add(Me.txtboxnhf)
        Me.TabPage1.Controls.Add(Me.txtboxsi)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(774, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Manage Stock"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(6, 125)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(142, 15)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "Piece value (for one unit)"
        '
        'txtboxapv
        '
        Me.txtboxapv.Location = New System.Drawing.Point(242, 119)
        Me.txtboxapv.Name = "txtboxapv"
        Me.txtboxapv.Size = New System.Drawing.Size(305, 21)
        Me.txtboxapv.TabIndex = 49
        '
        'txtboxui
        '
        Me.txtboxui.Location = New System.Drawing.Point(242, 92)
        Me.txtboxui.Name = "txtboxui"
        Me.txtboxui.Size = New System.Drawing.Size(305, 21)
        Me.txtboxui.TabIndex = 48
        '
        'DateTimePickerexpirydate
        '
        Me.DateTimePickerexpirydate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerexpirydate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerexpirydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerexpirydate.Location = New System.Drawing.Point(242, 388)
        Me.DateTimePickerexpirydate.Name = "DateTimePickerexpirydate"
        Me.DateTimePickerexpirydate.Size = New System.Drawing.Size(305, 22)
        Me.DateTimePickerexpirydate.TabIndex = 47
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(493, 493)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnrefresh.TabIndex = 46
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btndeleteitem
        '
        Me.btndeleteitem.Location = New System.Drawing.Point(404, 493)
        Me.btndeleteitem.Name = "btndeleteitem"
        Me.btndeleteitem.Size = New System.Drawing.Size(83, 23)
        Me.btndeleteitem.TabIndex = 45
        Me.btndeleteitem.Text = "Delete Item"
        Me.btndeleteitem.UseVisualStyleBackColor = True
        '
        'btnedititem
        '
        Me.btnedititem.Location = New System.Drawing.Point(323, 493)
        Me.btnedititem.Name = "btnedititem"
        Me.btnedititem.Size = New System.Drawing.Size(75, 23)
        Me.btnedititem.TabIndex = 44
        Me.btnedititem.Text = "Edit Item"
        Me.btnedititem.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnitemsearch)
        Me.GroupBox2.Controls.Add(Me.txtboxsearchitem)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(553, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 85)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Item"
        '
        'btnitemsearch
        '
        Me.btnitemsearch.Location = New System.Drawing.Point(127, 51)
        Me.btnitemsearch.Name = "btnitemsearch"
        Me.btnitemsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnitemsearch.TabIndex = 15
        Me.btnitemsearch.Text = "Search"
        Me.btnitemsearch.UseVisualStyleBackColor = True
        '
        'txtboxsearchitem
        '
        Me.txtboxsearchitem.Location = New System.Drawing.Point(6, 25)
        Me.txtboxsearchitem.Name = "txtboxsearchitem"
        Me.txtboxsearchitem.Size = New System.Drawing.Size(196, 22)
        Me.txtboxsearchitem.TabIndex = 0
        '
        'DataGridViewStockdata
        '
        Me.DataGridViewStockdata.AllowUserToAddRows = False
        Me.DataGridViewStockdata.AllowUserToDeleteRows = False
        Me.DataGridViewStockdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStockdata.Location = New System.Drawing.Point(553, 108)
        Me.DataGridViewStockdata.Name = "DataGridViewStockdata"
        Me.DataGridViewStockdata.ReadOnly = True
        Me.DataGridViewStockdata.Size = New System.Drawing.Size(214, 297)
        Me.DataGridViewStockdata.TabIndex = 36
        '
        'btnimportstockfromexcelfile
        '
        Me.btnimportstockfromexcelfile.Location = New System.Drawing.Point(574, 493)
        Me.btnimportstockfromexcelfile.Name = "btnimportstockfromexcelfile"
        Me.btnimportstockfromexcelfile.Size = New System.Drawing.Size(117, 23)
        Me.btnimportstockfromexcelfile.TabIndex = 34
        Me.btnimportstockfromexcelfile.Text = "Import from Excel"
        Me.btnimportstockfromexcelfile.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(242, 493)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 33
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnadditem
        '
        Me.btnadditem.Location = New System.Drawing.Point(161, 493)
        Me.btnadditem.Name = "btnadditem"
        Me.btnadditem.Size = New System.Drawing.Size(75, 23)
        Me.btnadditem.TabIndex = 32
        Me.btnadditem.Text = "Add Item"
        Me.btnadditem.UseVisualStyleBackColor = True
        '
        'txtboxremark
        '
        Me.txtboxremark.Location = New System.Drawing.Point(242, 413)
        Me.txtboxremark.Name = "txtboxremark"
        Me.txtboxremark.Size = New System.Drawing.Size(305, 21)
        Me.txtboxremark.TabIndex = 31
        '
        'txtboxbno
        '
        Me.txtboxbno.Location = New System.Drawing.Point(242, 365)
        Me.txtboxbno.Name = "txtboxbno"
        Me.txtboxbno.Size = New System.Drawing.Size(305, 21)
        Me.txtboxbno.TabIndex = 29
        '
        'txtboxqb
        '
        Me.txtboxqb.Location = New System.Drawing.Point(242, 341)
        Me.txtboxqb.Name = "txtboxqb"
        Me.txtboxqb.Size = New System.Drawing.Size(305, 21)
        Me.txtboxqb.TabIndex = 28
        '
        'txtboxql
        '
        Me.txtboxql.Location = New System.Drawing.Point(242, 316)
        Me.txtboxql.Name = "txtboxql"
        Me.txtboxql.Size = New System.Drawing.Size(305, 21)
        Me.txtboxql.TabIndex = 27
        '
        'txtboxqi
        '
        Me.txtboxqi.Location = New System.Drawing.Point(242, 292)
        Me.txtboxqi.Name = "txtboxqi"
        Me.txtboxqi.Size = New System.Drawing.Size(305, 21)
        Me.txtboxqi.TabIndex = 26
        '
        'txtboxqr
        '
        Me.txtboxqr.Location = New System.Drawing.Point(242, 267)
        Me.txtboxqr.Name = "txtboxqr"
        Me.txtboxqr.Size = New System.Drawing.Size(305, 21)
        Me.txtboxqr.TabIndex = 25
        '
        'txtboxrforit
        '
        Me.txtboxrforit.Location = New System.Drawing.Point(242, 242)
        Me.txtboxrforit.Name = "txtboxrforit"
        Me.txtboxrforit.Size = New System.Drawing.Size(305, 21)
        Me.txtboxrforit.TabIndex = 24
        '
        'txtboxdocno
        '
        Me.txtboxdocno.Location = New System.Drawing.Point(242, 218)
        Me.txtboxdocno.Name = "txtboxdocno"
        Me.txtboxdocno.Size = New System.Drawing.Size(305, 21)
        Me.txtboxdocno.TabIndex = 23
        '
        'txtboxamc
        '
        Me.txtboxamc.Location = New System.Drawing.Point(242, 193)
        Me.txtboxamc.Name = "txtboxamc"
        Me.txtboxamc.Size = New System.Drawing.Size(305, 21)
        Me.txtboxamc.TabIndex = 22
        '
        'txtboxeop
        '
        Me.txtboxeop.Location = New System.Drawing.Point(242, 169)
        Me.txtboxeop.Name = "txtboxeop"
        Me.txtboxeop.Size = New System.Drawing.Size(305, 21)
        Me.txtboxeop.TabIndex = 21
        '
        'txtboxmsl
        '
        Me.txtboxmsl.Location = New System.Drawing.Point(242, 145)
        Me.txtboxmsl.Name = "txtboxmsl"
        Me.txtboxmsl.Size = New System.Drawing.Size(305, 21)
        Me.txtboxmsl.TabIndex = 20
        '
        'txtboxpnsdf
        '
        Me.txtboxpnsdf.Location = New System.Drawing.Point(242, 68)
        Me.txtboxpnsdf.Name = "txtboxpnsdf"
        Me.txtboxpnsdf.Size = New System.Drawing.Size(305, 21)
        Me.txtboxpnsdf.TabIndex = 18
        '
        'txtboxnhf
        '
        Me.txtboxnhf.Location = New System.Drawing.Point(242, 43)
        Me.txtboxnhf.Name = "txtboxnhf"
        Me.txtboxnhf.Size = New System.Drawing.Size(305, 21)
        Me.txtboxnhf.TabIndex = 17
        '
        'txtboxsi
        '
        Me.txtboxsi.Location = New System.Drawing.Point(242, 17)
        Me.txtboxsi.Name = "txtboxsi"
        Me.txtboxsi.ReadOnly = True
        Me.txtboxsi.Size = New System.Drawing.Size(305, 21)
        Me.txtboxsi.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 419)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 15)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Remark"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 395)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 15)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Expiry date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 371)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Batch no."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(6, 347)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Quantity unit balance"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(6, 322)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 15)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Quantity loss (adjustment)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(6, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Quantity issued"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Quantity received"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Received from or issued to"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Doc. no. (Receiving or issueing)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Average monthly consumption (AMC)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Emergency order point"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Maximum stock level"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unit of issue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product name, strength and dosage form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name health facility"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Id"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Lavender
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.txtboxbranch)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.txtboxitem)
        Me.TabPage4.Controls.Add(Me.txtboxreqid)
        Me.TabPage4.Controls.Add(Me.btndispenserequesteditem)
        Me.TabPage4.Controls.Add(Me.DataGridViewforStockrequested)
        Me.TabPage4.Controls.Add(Me.ToolStrip1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(774, 535)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "View Requested Stock Items"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(455, 289)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 16)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Branch"
        '
        'txtboxbranch
        '
        Me.txtboxbranch.BackColor = System.Drawing.SystemColors.Control
        Me.txtboxbranch.Location = New System.Drawing.Point(427, 316)
        Me.txtboxbranch.Name = "txtboxbranch"
        Me.txtboxbranch.ReadOnly = True
        Me.txtboxbranch.Size = New System.Drawing.Size(119, 22)
        Me.txtboxbranch.TabIndex = 61
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(209, 289)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 16)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Item"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(18, 289)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 16)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Request Id"
        '
        'txtboxitem
        '
        Me.txtboxitem.BackColor = System.Drawing.SystemColors.Control
        Me.txtboxitem.Location = New System.Drawing.Point(139, 316)
        Me.txtboxitem.Name = "txtboxitem"
        Me.txtboxitem.ReadOnly = True
        Me.txtboxitem.Size = New System.Drawing.Size(282, 22)
        Me.txtboxitem.TabIndex = 54
        '
        'txtboxreqid
        '
        Me.txtboxreqid.BackColor = System.Drawing.SystemColors.Control
        Me.txtboxreqid.Location = New System.Drawing.Point(17, 316)
        Me.txtboxreqid.Name = "txtboxreqid"
        Me.txtboxreqid.ReadOnly = True
        Me.txtboxreqid.Size = New System.Drawing.Size(116, 22)
        Me.txtboxreqid.TabIndex = 53
        '
        'btndispenserequesteditem
        '
        Me.btndispenserequesteditem.BackColor = System.Drawing.Color.Gainsboro
        Me.btndispenserequesteditem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndispenserequesteditem.Location = New System.Drawing.Point(556, 315)
        Me.btndispenserequesteditem.Name = "btndispenserequesteditem"
        Me.btndispenserequesteditem.Size = New System.Drawing.Size(96, 23)
        Me.btndispenserequesteditem.TabIndex = 52
        Me.btndispenserequesteditem.Text = "Dispense Item"
        Me.btndispenserequesteditem.UseVisualStyleBackColor = False
        '
        'DataGridViewforStockrequested
        '
        Me.DataGridViewforStockrequested.AllowUserToAddRows = False
        Me.DataGridViewforStockrequested.AllowUserToDeleteRows = False
        Me.DataGridViewforStockrequested.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewforStockrequested.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewforStockrequested.Location = New System.Drawing.Point(6, 46)
        Me.DataGridViewforStockrequested.Name = "DataGridViewforStockrequested"
        Me.DataGridViewforStockrequested.ReadOnly = True
        Me.DataGridViewforStockrequested.Size = New System.Drawing.Size(762, 228)
        Me.DataGridViewforStockrequested.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStriptxtBoxrequestedstock, Me.ToolStripbtnrequesteditem, Me.ToolStripSeparator1, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(768, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStriptxtBoxrequestedstock
        '
        Me.ToolStriptxtBoxrequestedstock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStriptxtBoxrequestedstock.Name = "ToolStriptxtBoxrequestedstock"
        Me.ToolStriptxtBoxrequestedstock.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripbtnrequesteditem
        '
        Me.ToolStripbtnrequesteditem.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripbtnrequesteditem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripbtnrequesteditem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripbtnrequesteditem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripbtnrequesteditem.Name = "ToolStripbtnrequesteditem"
        Me.ToolStripbtnrequesteditem.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripbtnrequesteditem.Text = "Search"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripLabel1.Text = "by item name,stockitemid"
        '
        'Store
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(806, 588)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Store"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Management - Clinic System"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewStockdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridViewforStockrequested, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btnadditem As Button
    Friend WithEvents txtboxremark As TextBox
    Friend WithEvents txtboxbno As TextBox
    Friend WithEvents txtboxqb As TextBox
    Friend WithEvents txtboxql As TextBox
    Friend WithEvents txtboxqi As TextBox
    Friend WithEvents txtboxqr As TextBox
    Friend WithEvents txtboxrforit As TextBox
    Friend WithEvents txtboxdocno As TextBox
    Friend WithEvents txtboxamc As TextBox
    Friend WithEvents txtboxeop As TextBox
    Friend WithEvents txtboxmsl As TextBox
    Friend WithEvents txtboxpnsdf As TextBox
    Friend WithEvents txtboxnhf As TextBox
    Friend WithEvents txtboxsi As TextBox
    Friend WithEvents btnimportstockfromexcelfile As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnitemsearch As Button
    Friend WithEvents txtboxsearchitem As TextBox
    Friend WithEvents DataGridViewStockdata As DataGridView
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btndeleteitem As Button
    Friend WithEvents btnedititem As Button
    Friend WithEvents DateTimePickerexpirydate As DateTimePicker
    Friend WithEvents DataGridViewforStockrequested As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents txtboxbranch As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtboxitem As TextBox
    Friend WithEvents txtboxreqid As TextBox
    Friend WithEvents btndispenserequesteditem As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStriptxtBoxrequestedstock As ToolStripTextBox
    Friend WithEvents ToolStripbtnrequesteditem As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolTipforvalidatetxtboxinput As ToolTip
    Friend WithEvents txtboxui As TextBox
    Friend WithEvents txtboxapv As TextBox
    Friend WithEvents Label21 As Label
End Class
