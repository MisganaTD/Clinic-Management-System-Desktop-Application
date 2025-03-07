<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportdispenserforphyiscian
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
        Me.dispenseryforphysiciantblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetDispenseryPhyiscians = New Clinic_System.DataSetDispenseryPhyiscians()
        Me.ReportViewerreqddstock = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBoxPareqRport = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerddto = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerddfrom = New System.Windows.Forms.DateTimePicker()
        Me.btnsearchddfromto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchddReport = New System.Windows.Forms.Button()
        Me.txtboxSearchddRport = New System.Windows.Forms.TextBox()
        Me.dispenseryforphysiciantblTableAdapter = New Clinic_System.DataSetDispenseryPhyisciansTableAdapters.dispenseryforphysiciantblTableAdapter()
        CType(Me.dispenseryforphysiciantblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetDispenseryPhyiscians, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPareqRport.SuspendLayout()
        Me.SuspendLayout()
        '
        'dispenseryforphysiciantblBindingSource
        '
        Me.dispenseryforphysiciantblBindingSource.DataMember = "dispenseryforphysiciantbl"
        Me.dispenseryforphysiciantblBindingSource.DataSource = Me.DataSetDispenseryPhyiscians
        '
        'DataSetDispenseryPhyiscians
        '
        Me.DataSetDispenseryPhyiscians.DataSetName = "DataSetDispenseryPhyiscians"
        Me.DataSetDispenseryPhyiscians.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewerreqddstock
        '
        ReportDataSource1.Name = "DataSetDispenseryPhyisci"
        ReportDataSource1.Value = Me.dispenseryforphysiciantblBindingSource
        Me.ReportViewerreqddstock.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerreqddstock.LocalReport.ReportEmbeddedResource = "Clinic_System.ReportDispenseryPhyiscians.rdlc"
        Me.ReportViewerreqddstock.Location = New System.Drawing.Point(8, 117)
        Me.ReportViewerreqddstock.Name = "ReportViewerreqddstock"
        Me.ReportViewerreqddstock.Size = New System.Drawing.Size(744, 439)
        Me.ReportViewerreqddstock.TabIndex = 12
        '
        'GroupBoxPareqRport
        '
        Me.GroupBoxPareqRport.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxPareqRport.Controls.Add(Me.Label4)
        Me.GroupBoxPareqRport.Controls.Add(Me.Label2)
        Me.GroupBoxPareqRport.Controls.Add(Me.DateTimePickerddto)
        Me.GroupBoxPareqRport.Controls.Add(Me.Label3)
        Me.GroupBoxPareqRport.Controls.Add(Me.DateTimePickerddfrom)
        Me.GroupBoxPareqRport.Controls.Add(Me.btnsearchddfromto)
        Me.GroupBoxPareqRport.Controls.Add(Me.Label1)
        Me.GroupBoxPareqRport.Controls.Add(Me.btnSearchddReport)
        Me.GroupBoxPareqRport.Controls.Add(Me.txtboxSearchddRport)
        Me.GroupBoxPareqRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPareqRport.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxPareqRport.Location = New System.Drawing.Point(8, 12)
        Me.GroupBoxPareqRport.Name = "GroupBoxPareqRport"
        Me.GroupBoxPareqRport.Size = New System.Drawing.Size(739, 95)
        Me.GroupBoxPareqRport.TabIndex = 13
        Me.GroupBoxPareqRport.TabStop = False
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
        'DateTimePickerddto
        '
        Me.DateTimePickerddto.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerddto.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerddto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerddto.Location = New System.Drawing.Point(405, 59)
        Me.DateTimePickerddto.Name = "DateTimePickerddto"
        Me.DateTimePickerddto.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePickerddto.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(121, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Dispensed date From"
        '
        'DateTimePickerddfrom
        '
        Me.DateTimePickerddfrom.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerddfrom.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerddfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerddfrom.Location = New System.Drawing.Point(244, 59)
        Me.DateTimePickerddfrom.Name = "DateTimePickerddfrom"
        Me.DateTimePickerddfrom.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePickerddfrom.TabIndex = 43
        '
        'btnsearchddfromto
        '
        Me.btnsearchddfromto.BackColor = System.Drawing.Color.Gainsboro
        Me.btnsearchddfromto.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchddfromto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnsearchddfromto.Location = New System.Drawing.Point(531, 59)
        Me.btnsearchddfromto.Name = "btnsearchddfromto"
        Me.btnsearchddfromto.Size = New System.Drawing.Size(75, 26)
        Me.btnsearchddfromto.TabIndex = 42
        Me.btnsearchddfromto.Text = "Search"
        Me.btnsearchddfromto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by: product,branch,dispensereid"
        '
        'btnSearchddReport
        '
        Me.btnSearchddReport.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSearchddReport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchddReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchddReport.Location = New System.Drawing.Point(531, 30)
        Me.btnSearchddReport.Name = "btnSearchddReport"
        Me.btnSearchddReport.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchddReport.TabIndex = 1
        Me.btnSearchddReport.Text = "Search"
        Me.btnSearchddReport.UseVisualStyleBackColor = False
        '
        'txtboxSearchddRport
        '
        Me.txtboxSearchddRport.Location = New System.Drawing.Point(244, 30)
        Me.txtboxSearchddRport.Name = "txtboxSearchddRport"
        Me.txtboxSearchddRport.Size = New System.Drawing.Size(281, 23)
        Me.txtboxSearchddRport.TabIndex = 0
        '
        'dispenseryforphysiciantblTableAdapter
        '
        Me.dispenseryforphysiciantblTableAdapter.ClearBeforeFill = True
        '
        'Reportdispenserforphyiscian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 568)
        Me.Controls.Add(Me.GroupBoxPareqRport)
        Me.Controls.Add(Me.ReportViewerreqddstock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reportdispenserforphyiscian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report dispensery for phyiscian - Clinic and Pharm Store Management System"
        CType(Me.dispenseryforphysiciantblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetDispenseryPhyiscians, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPareqRport.ResumeLayout(False)
        Me.GroupBoxPareqRport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerreqddstock As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBoxPareqRport As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerddto As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerddfrom As DateTimePicker
    Friend WithEvents btnsearchddfromto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchddReport As Button
    Friend WithEvents txtboxSearchddRport As TextBox
    Friend WithEvents dispenseryforphysiciantblBindingSource As BindingSource
    Friend WithEvents DataSetDispenseryPhyiscians As DataSetDispenseryPhyiscians
    Friend WithEvents dispenseryforphysiciantblTableAdapter As DataSetDispenseryPhyisciansTableAdapters.dispenseryforphysiciantblTableAdapter
End Class
