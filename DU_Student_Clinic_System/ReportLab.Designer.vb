<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportLab
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
        Me.labresultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabResult_DataSet = New Clinic_System.LabResult_DataSet()
        Me.GroupBoxLabRport = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchLabRport = New System.Windows.Forms.Button()
        Me.txtboxSearchLabport = New System.Windows.Forms.TextBox()
        Me.ReportViewerLabRport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.labresultTableAdapter = New Clinic_System.LabResult_DataSetTableAdapters.labresultTableAdapter()
        CType(Me.labresultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabResult_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxLabRport.SuspendLayout()
        Me.SuspendLayout()
        '
        'labresultBindingSource
        '
        Me.labresultBindingSource.DataMember = "labresult"
        Me.labresultBindingSource.DataSource = Me.LabResult_DataSet
        '
        'LabResult_DataSet
        '
        Me.LabResult_DataSet.DataSetName = "LabResult_DataSet"
        Me.LabResult_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxLabRport
        '
        Me.GroupBoxLabRport.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxLabRport.Controls.Add(Me.Label1)
        Me.GroupBoxLabRport.Controls.Add(Me.btnSearchLabRport)
        Me.GroupBoxLabRport.Controls.Add(Me.txtboxSearchLabport)
        Me.GroupBoxLabRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxLabRport.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxLabRport.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxLabRport.Name = "GroupBoxLabRport"
        Me.GroupBoxLabRport.Size = New System.Drawing.Size(947, 52)
        Me.GroupBoxLabRport.TabIndex = 5
        Me.GroupBoxLabRport.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(337, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search by: patient ID, name, branch, lab category"
        '
        'btnSearchLabRport
        '
        Me.btnSearchLabRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchLabRport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchLabRport.Location = New System.Drawing.Point(256, 22)
        Me.btnSearchLabRport.Name = "btnSearchLabRport"
        Me.btnSearchLabRport.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchLabRport.TabIndex = 1
        Me.btnSearchLabRport.Text = "Search"
        Me.btnSearchLabRport.UseVisualStyleBackColor = True
        '
        'txtboxSearchLabport
        '
        Me.txtboxSearchLabport.Location = New System.Drawing.Point(6, 22)
        Me.txtboxSearchLabport.Name = "txtboxSearchLabport"
        Me.txtboxSearchLabport.Size = New System.Drawing.Size(244, 23)
        Me.txtboxSearchLabport.TabIndex = 0
        '
        'ReportViewerLabRport
        '
        Me.ReportViewerLabRport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "LabResult_DataSet"
        ReportDataSource1.Value = Me.labresultBindingSource
        Me.ReportViewerLabRport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerLabRport.LocalReport.ReportEmbeddedResource = "Clinic_System.LabReport.rdlc"
        Me.ReportViewerLabRport.Location = New System.Drawing.Point(12, 70)
        Me.ReportViewerLabRport.Name = "ReportViewerLabRport"
        Me.ReportViewerLabRport.Size = New System.Drawing.Size(947, 474)
        Me.ReportViewerLabRport.TabIndex = 6
        '
        'labresultTableAdapter
        '
        Me.labresultTableAdapter.ClearBeforeFill = True
        '
        'ReportLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(971, 556)
        Me.Controls.Add(Me.ReportViewerLabRport)
        Me.Controls.Add(Me.GroupBoxLabRport)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportLab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab Report - Clinic System"
        CType(Me.labresultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabResult_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxLabRport.ResumeLayout(False)
        Me.GroupBoxLabRport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxLabRport As GroupBox
    Friend WithEvents btnSearchLabRport As Button
    Friend WithEvents txtboxSearchLabport As TextBox
    Friend WithEvents ReportViewerLabRport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents labresultBindingSource As BindingSource
    Friend WithEvents LabResult_DataSet As LabResult_DataSet
    Friend WithEvents labresultTableAdapter As LabResult_DataSetTableAdapters.labresultTableAdapter
    Friend WithEvents Label1 As Label
End Class
