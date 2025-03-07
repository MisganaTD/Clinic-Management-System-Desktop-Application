<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proceeditemrequest
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtboxbrnch = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtboxitemname = New System.Windows.Forms.TextBox()
        Me.txtboxreqiid = New System.Windows.Forms.TextBox()
        Me.btnproceedrequesteditem = New System.Windows.Forms.Button()
        Me.DataGridViewforStockrequested = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStriptxtBoxrequestedstockitem = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripbutnrequesteditem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtboxsearchitem = New System.Windows.Forms.TextBox()
        Me.btnitemsearch = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridViewforStockrequested, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(782, 513)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Lavender
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.txtboxbrnch)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.txtboxitemname)
        Me.TabPage4.Controls.Add(Me.txtboxreqiid)
        Me.TabPage4.Controls.Add(Me.btnproceedrequesteditem)
        Me.TabPage4.Controls.Add(Me.DataGridViewforStockrequested)
        Me.TabPage4.Controls.Add(Me.ToolStrip1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(774, 484)
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
        'txtboxbrnch
        '
        Me.txtboxbrnch.BackColor = System.Drawing.SystemColors.Control
        Me.txtboxbrnch.Location = New System.Drawing.Point(427, 316)
        Me.txtboxbrnch.Name = "txtboxbrnch"
        Me.txtboxbrnch.ReadOnly = True
        Me.txtboxbrnch.Size = New System.Drawing.Size(119, 22)
        Me.txtboxbrnch.TabIndex = 61
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
        'txtboxitemname
        '
        Me.txtboxitemname.BackColor = System.Drawing.SystemColors.Control
        Me.txtboxitemname.Location = New System.Drawing.Point(139, 316)
        Me.txtboxitemname.Name = "txtboxitemname"
        Me.txtboxitemname.ReadOnly = True
        Me.txtboxitemname.Size = New System.Drawing.Size(282, 22)
        Me.txtboxitemname.TabIndex = 54
        '
        'txtboxreqiid
        '
        Me.txtboxreqiid.BackColor = System.Drawing.SystemColors.Control
        Me.txtboxreqiid.Location = New System.Drawing.Point(17, 316)
        Me.txtboxreqiid.Name = "txtboxreqiid"
        Me.txtboxreqiid.ReadOnly = True
        Me.txtboxreqiid.Size = New System.Drawing.Size(116, 22)
        Me.txtboxreqiid.TabIndex = 53
        '
        'btnproceedrequesteditem
        '
        Me.btnproceedrequesteditem.BackColor = System.Drawing.Color.Gainsboro
        Me.btnproceedrequesteditem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproceedrequesteditem.Location = New System.Drawing.Point(556, 315)
        Me.btnproceedrequesteditem.Name = "btnproceedrequesteditem"
        Me.btnproceedrequesteditem.Size = New System.Drawing.Size(96, 23)
        Me.btnproceedrequesteditem.TabIndex = 52
        Me.btnproceedrequesteditem.Text = "Proceed Item"
        Me.btnproceedrequesteditem.UseVisualStyleBackColor = False
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStriptxtBoxrequestedstockitem, Me.ToolStripbutnrequesteditem, Me.ToolStripSeparator1, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(768, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStriptxtBoxrequestedstockitem
        '
        Me.ToolStriptxtBoxrequestedstockitem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStriptxtBoxrequestedstockitem.Name = "ToolStriptxtBoxrequestedstockitem"
        Me.ToolStriptxtBoxrequestedstockitem.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripbutnrequesteditem
        '
        Me.ToolStripbutnrequesteditem.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripbutnrequesteditem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripbutnrequesteditem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripbutnrequesteditem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripbutnrequesteditem.Name = "ToolStripbutnrequesteditem"
        Me.ToolStripbutnrequesteditem.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripbutnrequesteditem.Text = "Search"
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
        'txtboxsearchitem
        '
        Me.txtboxsearchitem.Location = New System.Drawing.Point(6, 25)
        Me.txtboxsearchitem.Name = "txtboxsearchitem"
        Me.txtboxsearchitem.Size = New System.Drawing.Size(196, 20)
        Me.txtboxsearchitem.TabIndex = 0
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
        'Proceeditemrequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(810, 592)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Proceeditemrequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proceed stock item request - Clinic System"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridViewforStockrequested, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents txtboxbrnch As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtboxitemname As TextBox
    Friend WithEvents txtboxreqiid As TextBox
    Friend WithEvents btnproceedrequesteditem As Button
    Friend WithEvents DataGridViewforStockrequested As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStriptxtBoxrequestedstockitem As ToolStripTextBox
    Friend WithEvents ToolStripbutnrequesteditem As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txtboxsearchitem As TextBox
    Friend WithEvents btnitemsearch As Button
End Class
