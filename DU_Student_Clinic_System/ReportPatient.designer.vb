<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportPatient
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.patientdiagnosistblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Diagnosis_Dataset = New Clinic_System.Diagnosis_Dataset()
        Me.ReportViewerPatientReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBoxPaRport = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxsrchbybranchanddiagnosisoricdonly = New System.Windows.Forms.TextBox()
        Me.btnsrchbycmbox = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchPaRport = New System.Windows.Forms.Button()
        Me.txtboxSearchPaRport = New System.Windows.Forms.TextBox()
        Me.patientdiagnosistblTableAdapter = New Clinic_System.Diagnosis_DatasetTableAdapters.patientdiagnosistblTableAdapter()
        CType(Me.patientdiagnosistblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diagnosis_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPaRport.SuspendLayout()
        Me.SuspendLayout()
        '
        'patientdiagnosistblBindingSource
        '
        Me.patientdiagnosistblBindingSource.DataMember = "patientdiagnosistbl"
        Me.patientdiagnosistblBindingSource.DataSource = Me.Diagnosis_Dataset
        '
        'Diagnosis_Dataset
        '
        Me.Diagnosis_Dataset.DataSetName = "Diagnosis_Dataset"
        Me.Diagnosis_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewerPatientReport
        '
        ReportDataSource1.Name = "Diagnosis_Dataset"
        ReportDataSource1.Value = Me.patientdiagnosistblBindingSource
        Me.ReportViewerPatientReport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerPatientReport.LocalReport.ReportEmbeddedResource = "Clinic_System.DiagnosisReport.rdlc"
        Me.ReportViewerPatientReport.Location = New System.Drawing.Point(12, 98)
        Me.ReportViewerPatientReport.Name = "ReportViewerPatientReport"
        Me.ReportViewerPatientReport.Size = New System.Drawing.Size(739, 446)
        Me.ReportViewerPatientReport.TabIndex = 0
        '
        'GroupBoxPaRport
        '
        Me.GroupBoxPaRport.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxPaRport.Controls.Add(Me.Label2)
        Me.GroupBoxPaRport.Controls.Add(Me.txtboxsrchbybranchanddiagnosisoricdonly)
        Me.GroupBoxPaRport.Controls.Add(Me.btnsrchbycmbox)
        Me.GroupBoxPaRport.Controls.Add(Me.Label1)
        Me.GroupBoxPaRport.Controls.Add(Me.btnSearchPaRport)
        Me.GroupBoxPaRport.Controls.Add(Me.txtboxSearchPaRport)
        Me.GroupBoxPaRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPaRport.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxPaRport.Location = New System.Drawing.Point(12, 10)
        Me.GroupBoxPaRport.Name = "GroupBoxPaRport"
        Me.GroupBoxPaRport.Size = New System.Drawing.Size(739, 82)
        Me.GroupBoxPaRport.TabIndex = 3
        Me.GroupBoxPaRport.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search by: diagnosisoricd only"
        '
        'txtboxsrchbybranchanddiagnosisoricdonly
        '
        Me.txtboxsrchbybranchanddiagnosisoricdonly.Location = New System.Drawing.Point(6, 20)
        Me.txtboxsrchbybranchanddiagnosisoricdonly.Name = "txtboxsrchbybranchanddiagnosisoricdonly"
        Me.txtboxsrchbybranchanddiagnosisoricdonly.Size = New System.Drawing.Size(173, 23)
        Me.txtboxsrchbybranchanddiagnosisoricdonly.TabIndex = 5
        '
        'btnsrchbycmbox
        '
        Me.btnsrchbycmbox.BackColor = System.Drawing.Color.Gainsboro
        Me.btnsrchbycmbox.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsrchbycmbox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnsrchbycmbox.Location = New System.Drawing.Point(185, 20)
        Me.btnsrchbycmbox.Name = "btnsrchbycmbox"
        Me.btnsrchbycmbox.Size = New System.Drawing.Size(75, 26)
        Me.btnsrchbycmbox.TabIndex = 4
        Me.btnsrchbycmbox.Text = "Search"
        Me.btnsrchbycmbox.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(264, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by: patient ID, name, branch,diagnosisoricd for all branch"
        '
        'btnSearchPaRport
        '
        Me.btnSearchPaRport.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSearchPaRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPaRport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchPaRport.Location = New System.Drawing.Point(461, 20)
        Me.btnSearchPaRport.Name = "btnSearchPaRport"
        Me.btnSearchPaRport.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchPaRport.TabIndex = 1
        Me.btnSearchPaRport.Text = "Search"
        Me.btnSearchPaRport.UseVisualStyleBackColor = False
        '
        'txtboxSearchPaRport
        '
        Me.txtboxSearchPaRport.Location = New System.Drawing.Point(266, 20)
        Me.txtboxSearchPaRport.Name = "txtboxSearchPaRport"
        Me.txtboxSearchPaRport.Size = New System.Drawing.Size(189, 23)
        Me.txtboxSearchPaRport.TabIndex = 0
        '
        'patientdiagnosistblTableAdapter
        '
        Me.patientdiagnosistblTableAdapter.ClearBeforeFill = True
        '
        'ReportPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(760, 556)
        Me.Controls.Add(Me.GroupBoxPaRport)
        Me.Controls.Add(Me.ReportViewerPatientReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Report - Clinic System"
        CType(Me.patientdiagnosistblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diagnosis_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPaRport.ResumeLayout(False)
        Me.GroupBoxPaRport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerPatientReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents patientdiagnosistblBindingSource As BindingSource
    Friend WithEvents Diagnosis_Dataset As Diagnosis_Dataset
    Friend WithEvents GroupBoxPaRport As GroupBox
    Friend WithEvents btnSearchPaRport As Button
    Friend WithEvents txtboxSearchPaRport As TextBox
    Friend WithEvents patientdiagnosistblTableAdapter As Diagnosis_DatasetTableAdapters.patientdiagnosistblTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsrchbycmbox As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxsrchbybranchanddiagnosisoricdonly As TextBox
End Class
