<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportRequestedStockbyPharmasist
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
        Me.pharmstoretblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetReportRequestedby = New Clinic_System.DataSetReportRequestedby()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerreqtoto = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerreqtofrom = New System.Windows.Forms.DateTimePicker()
        Me.btnsearchcreqsto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchreqstockReport = New System.Windows.Forms.Button()
        Me.txtboxSearchreqstockRport = New System.Windows.Forms.TextBox()
        Me.GroupBoxPareqRport = New System.Windows.Forms.GroupBox()
        Me.ReportViewerreqstock = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pharmstoretblTableAdapter = New Clinic_System.DataSetReportRequestedbyTableAdapters.pharmstoretblTableAdapter()
        CType(Me.pharmstoretblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetReportRequestedby, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPareqRport.SuspendLayout()
        Me.SuspendLayout()
        '
        'pharmstoretblBindingSource
        '
        Me.pharmstoretblBindingSource.DataMember = "pharmstoretbl"
        Me.pharmstoretblBindingSource.DataSource = Me.DataSetReportRequestedby
        '
        'DataSetReportRequestedby
        '
        Me.DataSetReportRequestedby.DataSetName = "DataSetReportRequestedby"
        Me.DataSetReportRequestedby.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(612, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 22)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "OR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(379, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "To"
        '
        'DateTimePickerreqtoto
        '
        Me.DateTimePickerreqtoto.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerreqtoto.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerreqtoto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerreqtoto.Location = New System.Drawing.Point(405, 59)
        Me.DateTimePickerreqtoto.Name = "DateTimePickerreqtoto"
        Me.DateTimePickerreqtoto.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePickerreqtoto.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(205, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "From"
        '
        'DateTimePickerreqtofrom
        '
        Me.DateTimePickerreqtofrom.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerreqtofrom.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerreqtofrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerreqtofrom.Location = New System.Drawing.Point(244, 59)
        Me.DateTimePickerreqtofrom.Name = "DateTimePickerreqtofrom"
        Me.DateTimePickerreqtofrom.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePickerreqtofrom.TabIndex = 43
        '
        'btnsearchcreqsto
        '
        Me.btnsearchcreqsto.BackColor = System.Drawing.Color.Gainsboro
        Me.btnsearchcreqsto.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchcreqsto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnsearchcreqsto.Location = New System.Drawing.Point(531, 59)
        Me.btnsearchcreqsto.Name = "btnsearchcreqsto"
        Me.btnsearchcreqsto.Size = New System.Drawing.Size(75, 26)
        Me.btnsearchcreqsto.TabIndex = 42
        Me.btnsearchcreqsto.Text = "Search"
        Me.btnsearchcreqsto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(101, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by: product,branch"
        '
        'btnSearchreqstockReport
        '
        Me.btnSearchreqstockReport.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSearchreqstockReport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchreqstockReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchreqstockReport.Location = New System.Drawing.Point(531, 30)
        Me.btnSearchreqstockReport.Name = "btnSearchreqstockReport"
        Me.btnSearchreqstockReport.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchreqstockReport.TabIndex = 1
        Me.btnSearchreqstockReport.Text = "Search"
        Me.btnSearchreqstockReport.UseVisualStyleBackColor = False
        '
        'txtboxSearchreqstockRport
        '
        Me.txtboxSearchreqstockRport.Location = New System.Drawing.Point(244, 30)
        Me.txtboxSearchreqstockRport.Name = "txtboxSearchreqstockRport"
        Me.txtboxSearchreqstockRport.Size = New System.Drawing.Size(281, 23)
        Me.txtboxSearchreqstockRport.TabIndex = 0
        '
        'GroupBoxPareqRport
        '
        Me.GroupBoxPareqRport.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxPareqRport.Controls.Add(Me.Label4)
        Me.GroupBoxPareqRport.Controls.Add(Me.Label2)
        Me.GroupBoxPareqRport.Controls.Add(Me.DateTimePickerreqtoto)
        Me.GroupBoxPareqRport.Controls.Add(Me.Label3)
        Me.GroupBoxPareqRport.Controls.Add(Me.DateTimePickerreqtofrom)
        Me.GroupBoxPareqRport.Controls.Add(Me.btnsearchcreqsto)
        Me.GroupBoxPareqRport.Controls.Add(Me.Label1)
        Me.GroupBoxPareqRport.Controls.Add(Me.btnSearchreqstockReport)
        Me.GroupBoxPareqRport.Controls.Add(Me.txtboxSearchreqstockRport)
        Me.GroupBoxPareqRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPareqRport.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxPareqRport.Location = New System.Drawing.Point(12, 13)
        Me.GroupBoxPareqRport.Name = "GroupBoxPareqRport"
        Me.GroupBoxPareqRport.Size = New System.Drawing.Size(739, 95)
        Me.GroupBoxPareqRport.TabIndex = 10
        Me.GroupBoxPareqRport.TabStop = False
        '
        'ReportViewerreqstock
        '
        ReportDataSource1.Name = "DataSetReportRequestedstockbyphrmst"
        ReportDataSource1.Value = Me.pharmstoretblBindingSource
        Me.ReportViewerreqstock.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerreqstock.LocalReport.ReportEmbeddedResource = "Clinic_System.ReportReqstedStockbyPhrmst.rdlc"
        Me.ReportViewerreqstock.Location = New System.Drawing.Point(12, 114)
        Me.ReportViewerreqstock.Name = "ReportViewerreqstock"
        Me.ReportViewerreqstock.Size = New System.Drawing.Size(744, 439)
        Me.ReportViewerreqstock.TabIndex = 11
        '
        'pharmstoretblTableAdapter
        '
        Me.pharmstoretblTableAdapter.ClearBeforeFill = True
        '
        'ReportRequestedStockbyPharmasist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(760, 564)
        Me.Controls.Add(Me.ReportViewerreqstock)
        Me.Controls.Add(Me.GroupBoxPareqRport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportRequestedStockbyPharmasist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report requested stock by pharmasist - Clinic and Pharm Store Management System"
        CType(Me.pharmstoretblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReportRequestedby, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPareqRport.ResumeLayout(False)
        Me.GroupBoxPareqRport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerreqtoto As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerreqtofrom As DateTimePicker
    Friend WithEvents btnsearchcreqsto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchreqstockReport As Button
    Friend WithEvents txtboxSearchreqstockRport As TextBox
    Friend WithEvents GroupBoxPareqRport As GroupBox
    Friend WithEvents ReportViewerreqstock As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pharmstoretblBindingSource As BindingSource
    Friend WithEvents DataSetReportRequestedby As DataSetReportRequestedby
    Friend WithEvents pharmstoretblTableAdapter As DataSetReportRequestedbyTableAdapters.pharmstoretblTableAdapter
End Class
