<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPharmacy
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.prescriptiontblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pharmcy_DataSet = New Clinic_System.Pharmcy_DataSet()
        Me.GroupBoxPaRport = New System.Windows.Forms.GroupBox()
        Me.btnexportallpharmacyreslt = New System.Windows.Forms.Button()
        Me.lblphtotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpickerallto = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpikerallfrom = New System.Windows.Forms.DateTimePicker()
        Me.btnsearchpharmacyall = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsrchbydrugnameandbranchonly = New System.Windows.Forms.Button()
        Me.txtboxsrchbydrugnameandbranchonly = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchPharRport = New System.Windows.Forms.Button()
        Me.txtboxSearchPharRport = New System.Windows.Forms.TextBox()
        Me.ReportViewerPharRport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewpharmcyall = New System.Windows.Forms.DataGridView()
        Me.prescriptiontblTableAdapter = New Clinic_System.Pharmcy_DataSetTableAdapters.prescriptiontblTableAdapter()
        Me.SaveFileDialogpharmcyallrslt = New System.Windows.Forms.SaveFileDialog()
        CType(Me.prescriptiontblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pharmcy_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPaRport.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewpharmcyall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prescriptiontblBindingSource
        '
        Me.prescriptiontblBindingSource.DataMember = "prescriptiontbl"
        Me.prescriptiontblBindingSource.DataSource = Me.Pharmcy_DataSet
        '
        'Pharmcy_DataSet
        '
        Me.Pharmcy_DataSet.DataSetName = "Pharmcy_DataSet"
        Me.Pharmcy_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxPaRport
        '
        Me.GroupBoxPaRport.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxPaRport.Controls.Add(Me.btnexportallpharmacyreslt)
        Me.GroupBoxPaRport.Controls.Add(Me.lblphtotal)
        Me.GroupBoxPaRport.Controls.Add(Me.Label10)
        Me.GroupBoxPaRport.Controls.Add(Me.Label3)
        Me.GroupBoxPaRport.Controls.Add(Me.dtpickerallto)
        Me.GroupBoxPaRport.Controls.Add(Me.Label11)
        Me.GroupBoxPaRport.Controls.Add(Me.dtpikerallfrom)
        Me.GroupBoxPaRport.Controls.Add(Me.btnsearchpharmacyall)
        Me.GroupBoxPaRport.Controls.Add(Me.Label2)
        Me.GroupBoxPaRport.Controls.Add(Me.btnsrchbydrugnameandbranchonly)
        Me.GroupBoxPaRport.Controls.Add(Me.txtboxsrchbydrugnameandbranchonly)
        Me.GroupBoxPaRport.Controls.Add(Me.Label1)
        Me.GroupBoxPaRport.Controls.Add(Me.btnSearchPharRport)
        Me.GroupBoxPaRport.Controls.Add(Me.txtboxSearchPharRport)
        Me.GroupBoxPaRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPaRport.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxPaRport.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxPaRport.Name = "GroupBoxPaRport"
        Me.GroupBoxPaRport.Size = New System.Drawing.Size(947, 91)
        Me.GroupBoxPaRport.TabIndex = 4
        Me.GroupBoxPaRport.TabStop = False
        '
        'btnexportallpharmacyreslt
        '
        Me.btnexportallpharmacyreslt.Location = New System.Drawing.Point(830, 55)
        Me.btnexportallpharmacyreslt.Name = "btnexportallpharmacyreslt"
        Me.btnexportallpharmacyreslt.Size = New System.Drawing.Size(111, 27)
        Me.btnexportallpharmacyreslt.TabIndex = 46
        Me.btnexportallpharmacyreslt.Text = "Export to Excel"
        Me.btnexportallpharmacyreslt.UseVisualStyleBackColor = True
        '
        'lblphtotal
        '
        Me.lblphtotal.AutoSize = True
        Me.lblphtotal.BackColor = System.Drawing.Color.Transparent
        Me.lblphtotal.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphtotal.ForeColor = System.Drawing.Color.Red
        Me.lblphtotal.Location = New System.Drawing.Point(772, 61)
        Me.lblphtotal.Name = "lblphtotal"
        Me.lblphtotal.Size = New System.Drawing.Size(11, 15)
        Me.lblphtotal.TabIndex = 45
        Me.lblphtotal.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(694, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Total result"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(461, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "To"
        '
        'dtpickerallto
        '
        Me.dtpickerallto.CustomFormat = "yyyy-MM-dd"
        Me.dtpickerallto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpickerallto.Location = New System.Drawing.Point(487, 55)
        Me.dtpickerallto.Name = "dtpickerallto"
        Me.dtpickerallto.Size = New System.Drawing.Size(120, 23)
        Me.dtpickerallto.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(287, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 15)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "From"
        '
        'dtpikerallfrom
        '
        Me.dtpikerallfrom.CustomFormat = "yyyy-MM-dd"
        Me.dtpikerallfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpikerallfrom.Location = New System.Drawing.Point(326, 55)
        Me.dtpikerallfrom.Name = "dtpikerallfrom"
        Me.dtpikerallfrom.Size = New System.Drawing.Size(120, 23)
        Me.dtpikerallfrom.TabIndex = 40
        '
        'btnsearchpharmacyall
        '
        Me.btnsearchpharmacyall.BackColor = System.Drawing.Color.Gainsboro
        Me.btnsearchpharmacyall.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchpharmacyall.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnsearchpharmacyall.Location = New System.Drawing.Point(613, 55)
        Me.btnsearchpharmacyall.Name = "btnsearchpharmacyall"
        Me.btnsearchpharmacyall.Size = New System.Drawing.Size(75, 26)
        Me.btnsearchpharmacyall.TabIndex = 39
        Me.btnsearchpharmacyall.Text = "Search"
        Me.btnsearchpharmacyall.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search by: drug name only"
        '
        'btnsrchbydrugnameandbranchonly
        '
        Me.btnsrchbydrugnameandbranchonly.BackColor = System.Drawing.Color.Gainsboro
        Me.btnsrchbydrugnameandbranchonly.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsrchbydrugnameandbranchonly.ForeColor = System.Drawing.Color.Indigo
        Me.btnsrchbydrugnameandbranchonly.Location = New System.Drawing.Point(195, 26)
        Me.btnsrchbydrugnameandbranchonly.Name = "btnsrchbydrugnameandbranchonly"
        Me.btnsrchbydrugnameandbranchonly.Size = New System.Drawing.Size(75, 26)
        Me.btnsrchbydrugnameandbranchonly.TabIndex = 5
        Me.btnsrchbydrugnameandbranchonly.Text = "Search"
        Me.btnsrchbydrugnameandbranchonly.UseVisualStyleBackColor = False
        '
        'txtboxsrchbydrugnameandbranchonly
        '
        Me.txtboxsrchbydrugnameandbranchonly.Location = New System.Drawing.Point(6, 26)
        Me.txtboxsrchbydrugnameandbranchonly.Name = "txtboxsrchbydrugnameandbranchonly"
        Me.txtboxsrchbydrugnameandbranchonly.Size = New System.Drawing.Size(183, 23)
        Me.txtboxsrchbydrugnameandbranchonly.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(596, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search by: patient ID, name, branch,drug for all branch"
        '
        'btnSearchPharRport
        '
        Me.btnSearchPharRport.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSearchPharRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPharRport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchPharRport.Location = New System.Drawing.Point(515, 25)
        Me.btnSearchPharRport.Name = "btnSearchPharRport"
        Me.btnSearchPharRport.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchPharRport.TabIndex = 1
        Me.btnSearchPharRport.Text = "Search"
        Me.btnSearchPharRport.UseVisualStyleBackColor = False
        '
        'txtboxSearchPharRport
        '
        Me.txtboxSearchPharRport.Location = New System.Drawing.Point(326, 25)
        Me.txtboxSearchPharRport.Name = "txtboxSearchPharRport"
        Me.txtboxSearchPharRport.Size = New System.Drawing.Size(183, 23)
        Me.txtboxSearchPharRport.TabIndex = 0
        '
        'ReportViewerPharRport
        '
        Me.ReportViewerPharRport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Pharmacy_DataSet"
        ReportDataSource1.Value = Me.prescriptiontblBindingSource
        Me.ReportViewerPharRport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerPharRport.LocalReport.ReportEmbeddedResource = "Clinic_System.ReportPharmcy.rdlc"
        Me.ReportViewerPharRport.Location = New System.Drawing.Point(6, 15)
        Me.ReportViewerPharRport.Name = "ReportViewerPharRport"
        Me.ReportViewerPharRport.Size = New System.Drawing.Size(916, 370)
        Me.ReportViewerPharRport.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 109)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(947, 435)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewerPharRport)
        Me.TabPage1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(939, 403)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General Pharmacy Report List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.DataGridViewpharmcyall)
        Me.TabPage2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(939, 403)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Report by Date List"
        '
        'DataGridViewpharmcyall
        '
        Me.DataGridViewpharmcyall.AllowUserToAddRows = False
        Me.DataGridViewpharmcyall.AllowUserToDeleteRows = False
        Me.DataGridViewpharmcyall.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewpharmcyall.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewpharmcyall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewpharmcyall.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewpharmcyall.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewpharmcyall.Name = "DataGridViewpharmcyall"
        Me.DataGridViewpharmcyall.ReadOnly = True
        Me.DataGridViewpharmcyall.Size = New System.Drawing.Size(933, 397)
        Me.DataGridViewpharmcyall.TabIndex = 0
        '
        'prescriptiontblTableAdapter
        '
        Me.prescriptiontblTableAdapter.ClearBeforeFill = True
        '
        'ReportPharmacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(971, 556)
        Me.Controls.Add(Me.GroupBoxPaRport)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportPharmacy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmacy Report - Clinic System"
        CType(Me.prescriptiontblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pharmcy_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPaRport.ResumeLayout(False)
        Me.GroupBoxPaRport.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewpharmcyall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxPaRport As GroupBox
    Friend WithEvents btnSearchPharRport As Button
    Friend WithEvents txtboxSearchPharRport As TextBox
    Friend WithEvents ReportViewerPharRport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents prescriptiontblBindingSource As BindingSource
    Friend WithEvents Pharmcy_DataSet As Pharmcy_DataSet
    Friend WithEvents prescriptiontblTableAdapter As Pharmcy_DataSetTableAdapters.prescriptiontblTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsrchbydrugnameandbranchonly As Button
    Friend WithEvents txtboxsrchbydrugnameandbranchonly As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridViewpharmcyall As DataGridView
    Friend WithEvents lblphtotal As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpickerallto As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpikerallfrom As DateTimePicker
    Friend WithEvents btnsearchpharmacyall As Button
    Friend WithEvents btnexportallpharmacyreslt As Button
    Friend WithEvents SaveFileDialogpharmcyallrslt As SaveFileDialog
End Class
