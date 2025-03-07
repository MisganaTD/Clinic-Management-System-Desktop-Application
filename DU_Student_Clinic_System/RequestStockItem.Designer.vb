<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RequestStockItem
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtboxpval = New System.Windows.Forms.TextBox()
        Me.txtboxiu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxreqid = New System.Windows.Forms.TextBox()
        Me.lblstiid = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxforitemedit = New System.Windows.Forms.TextBox()
        Me.btnviewbalance = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtboxblance = New System.Windows.Forms.TextBox()
        Me.btnviewreqnotapprovalorproceed = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btndeleteitem = New System.Windows.Forms.Button()
        Me.btnedititem = New System.Windows.Forms.Button()
        Me.DataGridViewRquesteddata = New System.Windows.Forms.DataGridView()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnadditem = New System.Windows.Forms.Button()
        Me.txtboxremark = New System.Windows.Forms.TextBox()
        Me.txtboxq = New System.Windows.Forms.TextBox()
        Me.txtboxi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnrefreshdisp = New System.Windows.Forms.Button()
        Me.txtbubyeid = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbrid = New System.Windows.Forms.TextBox()
        Me.lblstid = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnvwitembal = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbbalitem = New System.Windows.Forms.TextBox()
        Me.btncrlit = New System.Windows.Forms.Button()
        Me.btndispit = New System.Windows.Forms.Button()
        Me.txtbr = New System.Windows.Forms.TextBox()
        Me.txtbq = New System.Windows.Forms.TextBox()
        Me.txtbi = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewRquesteddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(782, 525)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.txtboxpval)
        Me.TabPage1.Controls.Add(Me.txtboxiu)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtboxreqid)
        Me.TabPage1.Controls.Add(Me.lblstiid)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtboxforitemedit)
        Me.TabPage1.Controls.Add(Me.btnviewbalance)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtboxblance)
        Me.TabPage1.Controls.Add(Me.btnviewreqnotapprovalorproceed)
        Me.TabPage1.Controls.Add(Me.btnrefresh)
        Me.TabPage1.Controls.Add(Me.btndeleteitem)
        Me.TabPage1.Controls.Add(Me.btnedititem)
        Me.TabPage1.Controls.Add(Me.DataGridViewRquesteddata)
        Me.TabPage1.Controls.Add(Me.btnclear)
        Me.TabPage1.Controls.Add(Me.btnadditem)
        Me.TabPage1.Controls.Add(Me.txtboxremark)
        Me.TabPage1.Controls.Add(Me.txtboxq)
        Me.TabPage1.Controls.Add(Me.txtboxi)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(774, 496)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Item Request"
        '
        'txtboxpval
        '
        Me.txtboxpval.Location = New System.Drawing.Point(140, 67)
        Me.txtboxpval.Name = "txtboxpval"
        Me.txtboxpval.Size = New System.Drawing.Size(412, 21)
        Me.txtboxpval.TabIndex = 58
        '
        'txtboxiu
        '
        Me.txtboxiu.Location = New System.Drawing.Point(140, 43)
        Me.txtboxiu.Name = "txtboxiu"
        Me.txtboxiu.Size = New System.Drawing.Size(412, 21)
        Me.txtboxiu.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 15)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Unit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Request Id"
        '
        'txtboxreqid
        '
        Me.txtboxreqid.Location = New System.Drawing.Point(77, 17)
        Me.txtboxreqid.Name = "txtboxreqid"
        Me.txtboxreqid.ReadOnly = True
        Me.txtboxreqid.Size = New System.Drawing.Size(101, 21)
        Me.txtboxreqid.TabIndex = 54
        '
        'lblstiid
        '
        Me.lblstiid.AutoSize = True
        Me.lblstiid.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstiid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblstiid.Location = New System.Drawing.Point(635, 126)
        Me.lblstiid.Name = "lblstiid"
        Me.lblstiid.Size = New System.Drawing.Size(11, 15)
        Me.lblstiid.TabIndex = 53
        Me.lblstiid.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(577, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Stock ID"
        '
        'txtboxforitemedit
        '
        Me.txtboxforitemedit.Location = New System.Drawing.Point(570, 44)
        Me.txtboxforitemedit.Name = "txtboxforitemedit"
        Me.txtboxforitemedit.ReadOnly = True
        Me.txtboxforitemedit.Size = New System.Drawing.Size(197, 21)
        Me.txtboxforitemedit.TabIndex = 51
        '
        'btnviewbalance
        '
        Me.btnviewbalance.Location = New System.Drawing.Point(609, 156)
        Me.btnviewbalance.Name = "btnviewbalance"
        Me.btnviewbalance.Size = New System.Drawing.Size(95, 26)
        Me.btnviewbalance.TabIndex = 49
        Me.btnviewbalance.Text = "View balance"
        Me.btnviewbalance.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(577, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 15)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Quantity unit of selected item"
        '
        'txtboxblance
        '
        Me.txtboxblance.Location = New System.Drawing.Point(570, 92)
        Me.txtboxblance.Name = "txtboxblance"
        Me.txtboxblance.ReadOnly = True
        Me.txtboxblance.Size = New System.Drawing.Size(197, 21)
        Me.txtboxblance.TabIndex = 47
        '
        'btnviewreqnotapprovalorproceed
        '
        Me.btnviewreqnotapprovalorproceed.ForeColor = System.Drawing.Color.Blue
        Me.btnviewreqnotapprovalorproceed.Location = New System.Drawing.Point(77, 198)
        Me.btnviewreqnotapprovalorproceed.Name = "btnviewreqnotapprovalorproceed"
        Me.btnviewreqnotapprovalorproceed.Size = New System.Drawing.Size(410, 26)
        Me.btnviewreqnotapprovalorproceed.TabIndex = 15
        Me.btnviewreqnotapprovalorproceed.Text = "View requested which is not approved or proceeded for update"
        Me.btnviewreqnotapprovalorproceed.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(412, 167)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 26)
        Me.btnrefresh.TabIndex = 46
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btndeleteitem
        '
        Me.btndeleteitem.Location = New System.Drawing.Point(323, 167)
        Me.btndeleteitem.Name = "btndeleteitem"
        Me.btndeleteitem.Size = New System.Drawing.Size(75, 26)
        Me.btndeleteitem.TabIndex = 45
        Me.btndeleteitem.Text = "Delete"
        Me.btndeleteitem.UseVisualStyleBackColor = True
        '
        'btnedititem
        '
        Me.btnedititem.Location = New System.Drawing.Point(242, 167)
        Me.btnedititem.Name = "btnedititem"
        Me.btnedititem.Size = New System.Drawing.Size(75, 26)
        Me.btnedititem.TabIndex = 44
        Me.btnedititem.Text = "Edit"
        Me.btnedititem.UseVisualStyleBackColor = True
        '
        'DataGridViewRquesteddata
        '
        Me.DataGridViewRquesteddata.AllowUserToAddRows = False
        Me.DataGridViewRquesteddata.AllowUserToDeleteRows = False
        Me.DataGridViewRquesteddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRquesteddata.Location = New System.Drawing.Point(9, 230)
        Me.DataGridViewRquesteddata.Name = "DataGridViewRquesteddata"
        Me.DataGridViewRquesteddata.ReadOnly = True
        Me.DataGridViewRquesteddata.Size = New System.Drawing.Size(758, 251)
        Me.DataGridViewRquesteddata.TabIndex = 36
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(161, 167)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 26)
        Me.btnclear.TabIndex = 33
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnadditem
        '
        Me.btnadditem.Location = New System.Drawing.Point(77, 167)
        Me.btnadditem.Name = "btnadditem"
        Me.btnadditem.Size = New System.Drawing.Size(75, 26)
        Me.btnadditem.TabIndex = 32
        Me.btnadditem.Text = "Add"
        Me.btnadditem.UseVisualStyleBackColor = True
        '
        'txtboxremark
        '
        Me.txtboxremark.Location = New System.Drawing.Point(141, 120)
        Me.txtboxremark.Name = "txtboxremark"
        Me.txtboxremark.Size = New System.Drawing.Size(411, 21)
        Me.txtboxremark.TabIndex = 22
        '
        'txtboxq
        '
        Me.txtboxq.Location = New System.Drawing.Point(141, 93)
        Me.txtboxq.Name = "txtboxq"
        Me.txtboxq.Size = New System.Drawing.Size(411, 21)
        Me.txtboxq.TabIndex = 20
        '
        'txtboxi
        '
        Me.txtboxi.Location = New System.Drawing.Point(220, 16)
        Me.txtboxi.Name = "txtboxi"
        Me.txtboxi.Size = New System.Drawing.Size(332, 21)
        Me.txtboxi.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Remark"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantity by unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Piece value (for a unit)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage2.Controls.Add(Me.btnrefreshdisp)
        Me.TabPage2.Controls.Add(Me.txtbubyeid)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtbrid)
        Me.TabPage2.Controls.Add(Me.lblstid)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.btnvwitembal)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtbbalitem)
        Me.TabPage2.Controls.Add(Me.btncrlit)
        Me.TabPage2.Controls.Add(Me.btndispit)
        Me.TabPage2.Controls.Add(Me.txtbr)
        Me.TabPage2.Controls.Add(Me.txtbq)
        Me.TabPage2.Controls.Add(Me.txtbi)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(774, 496)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dispense Item for physician"
        '
        'btnrefreshdisp
        '
        Me.btnrefreshdisp.Location = New System.Drawing.Point(343, 163)
        Me.btnrefreshdisp.Name = "btnrefreshdisp"
        Me.btnrefreshdisp.Size = New System.Drawing.Size(75, 26)
        Me.btnrefreshdisp.TabIndex = 84
        Me.btnrefreshdisp.Text = "Refresh"
        Me.btnrefreshdisp.UseVisualStyleBackColor = True
        '
        'txtbubyeid
        '
        Me.txtbubyeid.Location = New System.Drawing.Point(175, 52)
        Me.txtbubyeid.Name = "txtbubyeid"
        Me.txtbubyeid.Size = New System.Drawing.Size(332, 22)
        Me.txtbubyeid.TabIndex = 83
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(29, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 16)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "Employee ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(564, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Request Id"
        '
        'txtbrid
        '
        Me.txtbrid.Location = New System.Drawing.Point(557, 73)
        Me.txtbrid.Name = "txtbrid"
        Me.txtbrid.ReadOnly = True
        Me.txtbrid.Size = New System.Drawing.Size(197, 22)
        Me.txtbrid.TabIndex = 77
        '
        'lblstid
        '
        Me.lblstid.AutoSize = True
        Me.lblstid.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblstid.Location = New System.Drawing.Point(622, 168)
        Me.lblstid.Name = "lblstid"
        Me.lblstid.Size = New System.Drawing.Size(11, 15)
        Me.lblstid.TabIndex = 76
        Me.lblstid.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(564, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Stock ID"
        '
        'btnvwitembal
        '
        Me.btnvwitembal.Location = New System.Drawing.Point(596, 198)
        Me.btnvwitembal.Name = "btnvwitembal"
        Me.btnvwitembal.Size = New System.Drawing.Size(95, 26)
        Me.btnvwitembal.TabIndex = 73
        Me.btnvwitembal.Text = "View balance"
        Me.btnvwitembal.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(564, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(189, 16)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Quantity piece of selected item"
        '
        'txtbbalitem
        '
        Me.txtbbalitem.Location = New System.Drawing.Point(557, 134)
        Me.txtbbalitem.Name = "txtbbalitem"
        Me.txtbbalitem.ReadOnly = True
        Me.txtbbalitem.Size = New System.Drawing.Size(197, 22)
        Me.txtbbalitem.TabIndex = 71
        '
        'btncrlit
        '
        Me.btncrlit.Location = New System.Drawing.Point(262, 163)
        Me.btncrlit.Name = "btncrlit"
        Me.btncrlit.Size = New System.Drawing.Size(75, 26)
        Me.btncrlit.TabIndex = 67
        Me.btncrlit.Text = "Clear"
        Me.btncrlit.UseVisualStyleBackColor = True
        '
        'btndispit
        '
        Me.btndispit.Location = New System.Drawing.Point(175, 163)
        Me.btndispit.Name = "btndispit"
        Me.btndispit.Size = New System.Drawing.Size(78, 26)
        Me.btndispit.TabIndex = 66
        Me.btndispit.Text = "Dispense"
        Me.btndispit.UseVisualStyleBackColor = True
        '
        'txtbr
        '
        Me.txtbr.Location = New System.Drawing.Point(175, 135)
        Me.txtbr.Name = "txtbr"
        Me.txtbr.Size = New System.Drawing.Size(332, 22)
        Me.txtbr.TabIndex = 65
        '
        'txtbq
        '
        Me.txtbq.Location = New System.Drawing.Point(175, 108)
        Me.txtbq.Name = "txtbq"
        Me.txtbq.Size = New System.Drawing.Size(332, 22)
        Me.txtbq.TabIndex = 64
        '
        'txtbi
        '
        Me.txtbi.Location = New System.Drawing.Point(175, 80)
        Me.txtbi.Name = "txtbi"
        Me.txtbi.Size = New System.Drawing.Size(332, 22)
        Me.txtbi.TabIndex = 63
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 140)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 16)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Remark"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 113)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 16)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Quantity a piece"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(29, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 16)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Item"
        '
        'RequestStockItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(806, 588)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RequestStockItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Item - Clinic System"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridViewRquesteddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btndeleteitem As Button
    Friend WithEvents btnedititem As Button
    Friend WithEvents btnviewreqnotapprovalorproceed As Button
    Friend WithEvents DataGridViewRquesteddata As DataGridView
    Friend WithEvents btnclear As Button
    Friend WithEvents btnadditem As Button
    Friend WithEvents txtboxremark As TextBox
    Friend WithEvents txtboxq As TextBox
    Friend WithEvents txtboxi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnviewbalance As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtboxblance As TextBox
    Friend WithEvents txtboxforitemedit As TextBox
    Friend WithEvents lblstiid As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxreqid As TextBox
    Friend WithEvents txtboxpval As TextBox
    Friend WithEvents txtboxiu As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents txtbrid As TextBox
    Friend WithEvents lblstid As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnvwitembal As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbbalitem As TextBox
    Friend WithEvents btncrlit As Button
    Friend WithEvents btndispit As Button
    Friend WithEvents txtbr As TextBox
    Friend WithEvents txtbq As TextBox
    Friend WithEvents txtbi As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtbubyeid As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnrefreshdisp As Button
End Class
