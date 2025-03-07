<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportExpiry
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
        Me.mainstoretblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Expiry = New Clinic_System.Expiry()
        Me.ReportViewerExpirydata = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBoxPaRport = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchexpiryReport = New System.Windows.Forms.Button()
        Me.txtboxSearchexpiryRport = New System.Windows.Forms.TextBox()
        Me.mainstoretblTableAdapter = New Clinic_System.ExpiryTableAdapters.mainstoretblTableAdapter()
        CType(Me.mainstoretblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Expiry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPaRport.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainstoretblBindingSource
        '
        Me.mainstoretblBindingSource.DataMember = "mainstoretbl"
        Me.mainstoretblBindingSource.DataSource = Me.Expiry
        '
        'Expiry
        '
        Me.Expiry.DataSetName = "Expiry"
        Me.Expiry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewerExpirydata
        '
        ReportDataSource1.Name = "DataSetExpiry"
        ReportDataSource1.Value = Me.mainstoretblBindingSource
        Me.ReportViewerExpirydata.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerExpirydata.LocalReport.ReportEmbeddedResource = "Clinic_System.ReportExpiry.rdlc"
        Me.ReportViewerExpirydata.Location = New System.Drawing.Point(12, 100)
        Me.ReportViewerExpirydata.Name = "ReportViewerExpirydata"
        Me.ReportViewerExpirydata.Size = New System.Drawing.Size(740, 448)
        Me.ReportViewerExpirydata.TabIndex = 9
        '
        'GroupBoxPaRport
        '
        Me.GroupBoxPaRport.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxPaRport.Controls.Add(Me.Label1)
        Me.GroupBoxPaRport.Controls.Add(Me.btnSearchexpiryReport)
        Me.GroupBoxPaRport.Controls.Add(Me.txtboxSearchexpiryRport)
        Me.GroupBoxPaRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPaRport.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxPaRport.Location = New System.Drawing.Point(13, 12)
        Me.GroupBoxPaRport.Name = "GroupBoxPaRport"
        Me.GroupBoxPaRport.Size = New System.Drawing.Size(739, 82)
        Me.GroupBoxPaRport.TabIndex = 8
        Me.GroupBoxPaRport.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(33, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by: product name, batch number"
        '
        'btnSearchexpiryReport
        '
        Me.btnSearchexpiryReport.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSearchexpiryReport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchexpiryReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchexpiryReport.Location = New System.Drawing.Point(531, 30)
        Me.btnSearchexpiryReport.Name = "btnSearchexpiryReport"
        Me.btnSearchexpiryReport.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchexpiryReport.TabIndex = 1
        Me.btnSearchexpiryReport.Text = "Search"
        Me.btnSearchexpiryReport.UseVisualStyleBackColor = False
        '
        'txtboxSearchexpiryRport
        '
        Me.txtboxSearchexpiryRport.Location = New System.Drawing.Point(244, 30)
        Me.txtboxSearchexpiryRport.Name = "txtboxSearchexpiryRport"
        Me.txtboxSearchexpiryRport.Size = New System.Drawing.Size(281, 23)
        Me.txtboxSearchexpiryRport.TabIndex = 0
        '
        'mainstoretblTableAdapter
        '
        Me.mainstoretblTableAdapter.ClearBeforeFill = True
        '
        'ReportExpiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 560)
        Me.Controls.Add(Me.ReportViewerExpirydata)
        Me.Controls.Add(Me.GroupBoxPaRport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportExpiry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Expiry - Clinic and Pharm Store Management System"
        CType(Me.mainstoretblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Expiry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPaRport.ResumeLayout(False)
        Me.GroupBoxPaRport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerExpirydata As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBoxPaRport As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchexpiryReport As Button
    Friend WithEvents txtboxSearchexpiryRport As TextBox
    Friend WithEvents mainstoretblBindingSource As BindingSource
    Friend WithEvents Expiry As Expiry
    Friend WithEvents mainstoretblTableAdapter As ExpiryTableAdapters.mainstoretblTableAdapter
End Class
