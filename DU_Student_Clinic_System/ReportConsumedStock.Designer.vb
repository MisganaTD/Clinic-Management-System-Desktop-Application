<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportConsumedStock
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
        Me.prescriptiontblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsumedStockItemprecritbl = New Clinic_System.ConsumedStockItemprecritbl()
        Me.GroupBoxPaRport = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickercstoto = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickercstofrom = New System.Windows.Forms.DateTimePicker()
        Me.btnsearchconsto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchconsumstockReport = New System.Windows.Forms.Button()
        Me.txtboxSearchconsumedstockRport = New System.Windows.Forms.TextBox()
        Me.ReportViewerConsumedstock = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.prescriptiontblTableAdapter = New Clinic_System.ConsumedStockItemprecritblTableAdapters.prescriptiontblTableAdapter()
        CType(Me.prescriptiontblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumedStockItemprecritbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPaRport.SuspendLayout()
        Me.SuspendLayout()
        '
        'prescriptiontblBindingSource
        '
        Me.prescriptiontblBindingSource.DataMember = "prescriptiontbl"
        Me.prescriptiontblBindingSource.DataSource = Me.ConsumedStockItemprecritbl
        '
        'ConsumedStockItemprecritbl
        '
        Me.ConsumedStockItemprecritbl.DataSetName = "ConsumedStockItemprecritbl"
        Me.ConsumedStockItemprecritbl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxPaRport
        '
        Me.GroupBoxPaRport.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxPaRport.Controls.Add(Me.Label4)
        Me.GroupBoxPaRport.Controls.Add(Me.Label2)
        Me.GroupBoxPaRport.Controls.Add(Me.DateTimePickercstoto)
        Me.GroupBoxPaRport.Controls.Add(Me.Label3)
        Me.GroupBoxPaRport.Controls.Add(Me.DateTimePickercstofrom)
        Me.GroupBoxPaRport.Controls.Add(Me.btnsearchconsto)
        Me.GroupBoxPaRport.Controls.Add(Me.Label1)
        Me.GroupBoxPaRport.Controls.Add(Me.btnSearchconsumstockReport)
        Me.GroupBoxPaRport.Controls.Add(Me.txtboxSearchconsumedstockRport)
        Me.GroupBoxPaRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPaRport.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxPaRport.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxPaRport.Name = "GroupBoxPaRport"
        Me.GroupBoxPaRport.Size = New System.Drawing.Size(739, 95)
        Me.GroupBoxPaRport.TabIndex = 9
        Me.GroupBoxPaRport.TabStop = False
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
        'DateTimePickercstoto
        '
        Me.DateTimePickercstoto.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickercstoto.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickercstoto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickercstoto.Location = New System.Drawing.Point(405, 59)
        Me.DateTimePickercstoto.Name = "DateTimePickercstoto"
        Me.DateTimePickercstoto.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePickercstoto.TabIndex = 45
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
        'DateTimePickercstofrom
        '
        Me.DateTimePickercstofrom.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickercstofrom.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickercstofrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickercstofrom.Location = New System.Drawing.Point(244, 59)
        Me.DateTimePickercstofrom.Name = "DateTimePickercstofrom"
        Me.DateTimePickercstofrom.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePickercstofrom.TabIndex = 43
        '
        'btnsearchconsto
        '
        Me.btnsearchconsto.BackColor = System.Drawing.Color.Gainsboro
        Me.btnsearchconsto.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchconsto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnsearchconsto.Location = New System.Drawing.Point(531, 59)
        Me.btnsearchconsto.Name = "btnsearchconsto"
        Me.btnsearchconsto.Size = New System.Drawing.Size(75, 26)
        Me.btnsearchconsto.TabIndex = 42
        Me.btnsearchconsto.Text = "Search"
        Me.btnsearchconsto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(74, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by: product, employee id"
        '
        'btnSearchconsumstockReport
        '
        Me.btnSearchconsumstockReport.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSearchconsumstockReport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchconsumstockReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchconsumstockReport.Location = New System.Drawing.Point(531, 30)
        Me.btnSearchconsumstockReport.Name = "btnSearchconsumstockReport"
        Me.btnSearchconsumstockReport.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchconsumstockReport.TabIndex = 1
        Me.btnSearchconsumstockReport.Text = "Search"
        Me.btnSearchconsumstockReport.UseVisualStyleBackColor = False
        '
        'txtboxSearchconsumedstockRport
        '
        Me.txtboxSearchconsumedstockRport.Location = New System.Drawing.Point(244, 30)
        Me.txtboxSearchconsumedstockRport.Name = "txtboxSearchconsumedstockRport"
        Me.txtboxSearchconsumedstockRport.Size = New System.Drawing.Size(281, 23)
        Me.txtboxSearchconsumedstockRport.TabIndex = 0
        '
        'ReportViewerConsumedstock
        '
        ReportDataSource1.Name = "DataSetConsumedstockitem"
        ReportDataSource1.Value = Me.prescriptiontblBindingSource
        Me.ReportViewerConsumedstock.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerConsumedstock.LocalReport.ReportEmbeddedResource = "Clinic_System.ReportConsumedItem.rdlc"
        Me.ReportViewerConsumedstock.Location = New System.Drawing.Point(12, 113)
        Me.ReportViewerConsumedstock.Name = "ReportViewerConsumedstock"
        Me.ReportViewerConsumedstock.Size = New System.Drawing.Size(744, 439)
        Me.ReportViewerConsumedstock.TabIndex = 10
        '
        'prescriptiontblTableAdapter
        '
        Me.prescriptiontblTableAdapter.ClearBeforeFill = True
        '
        'ReportConsumedStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(760, 564)
        Me.Controls.Add(Me.ReportViewerConsumedstock)
        Me.Controls.Add(Me.GroupBoxPaRport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportConsumedStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Consumed Stock - Clinic and Pharm Store Management System"
        CType(Me.prescriptiontblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumedStockItemprecritbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPaRport.ResumeLayout(False)
        Me.GroupBoxPaRport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxPaRport As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchconsumstockReport As Button
    Friend WithEvents txtboxSearchconsumedstockRport As TextBox
    Friend WithEvents ReportViewerConsumedstock As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents prescriptiontblBindingSource As BindingSource
    Friend WithEvents ConsumedStockItemprecritbl As ConsumedStockItemprecritbl
    Friend WithEvents prescriptiontblTableAdapter As ConsumedStockItemprecritblTableAdapters.prescriptiontblTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickercstoto As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickercstofrom As DateTimePicker
    Friend WithEvents btnsearchconsto As Button
    Friend WithEvents Label4 As Label
End Class
