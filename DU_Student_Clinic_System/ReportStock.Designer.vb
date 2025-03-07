<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportStock
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
        Me.DUSCSDataSetmainstoretbl = New Clinic_System.DUSCSDataSetmainstoretbl()
        Me.ReportViewerStockdata = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mainstoretblTableAdapter = New Clinic_System.DUSCSDataSetmainstoretblTableAdapters.mainstoretblTableAdapter()
        Me.GroupBoxPaRport = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerstoto = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerstofrom = New System.Windows.Forms.DateTimePicker()
        Me.btnsearchsto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchstockRport = New System.Windows.Forms.Button()
        Me.txtboxSearchstockRport = New System.Windows.Forms.TextBox()
        CType(Me.mainstoretblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DUSCSDataSetmainstoretbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPaRport.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainstoretblBindingSource
        '
        Me.mainstoretblBindingSource.DataMember = "mainstoretbl"
        Me.mainstoretblBindingSource.DataSource = Me.DUSCSDataSetmainstoretbl
        '
        'DUSCSDataSetmainstoretbl
        '
        Me.DUSCSDataSetmainstoretbl.DataSetName = "DUSCSDataSetmainstoretbl"
        Me.DUSCSDataSetmainstoretbl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewerStockdata
        '
        ReportDataSource1.Name = "DataSetmainstoretbl"
        ReportDataSource1.Value = Me.mainstoretblBindingSource
        Me.ReportViewerStockdata.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerStockdata.LocalReport.ReportEmbeddedResource = "Clinic_System.ReportmainstoretblStock.rdlc"
        Me.ReportViewerStockdata.Location = New System.Drawing.Point(12, 114)
        Me.ReportViewerStockdata.Name = "ReportViewerStockdata"
        Me.ReportViewerStockdata.Size = New System.Drawing.Size(740, 434)
        Me.ReportViewerStockdata.TabIndex = 0
        '
        'mainstoretblTableAdapter
        '
        Me.mainstoretblTableAdapter.ClearBeforeFill = True
        '
        'GroupBoxPaRport
        '
        Me.GroupBoxPaRport.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxPaRport.Controls.Add(Me.Label4)
        Me.GroupBoxPaRport.Controls.Add(Me.Label2)
        Me.GroupBoxPaRport.Controls.Add(Me.DateTimePickerstoto)
        Me.GroupBoxPaRport.Controls.Add(Me.Label3)
        Me.GroupBoxPaRport.Controls.Add(Me.DateTimePickerstofrom)
        Me.GroupBoxPaRport.Controls.Add(Me.btnsearchsto)
        Me.GroupBoxPaRport.Controls.Add(Me.Label1)
        Me.GroupBoxPaRport.Controls.Add(Me.btnSearchstockRport)
        Me.GroupBoxPaRport.Controls.Add(Me.txtboxSearchstockRport)
        Me.GroupBoxPaRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPaRport.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxPaRport.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxPaRport.Name = "GroupBoxPaRport"
        Me.GroupBoxPaRport.Size = New System.Drawing.Size(739, 96)
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
        Me.Label4.TabIndex = 53
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
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "To"
        '
        'DateTimePickerstoto
        '
        Me.DateTimePickerstoto.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerstoto.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerstoto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerstoto.Location = New System.Drawing.Point(405, 59)
        Me.DateTimePickerstoto.Name = "DateTimePickerstoto"
        Me.DateTimePickerstoto.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePickerstoto.TabIndex = 51
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
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "From"
        '
        'DateTimePickerstofrom
        '
        Me.DateTimePickerstofrom.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerstofrom.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerstofrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerstofrom.Location = New System.Drawing.Point(244, 59)
        Me.DateTimePickerstofrom.Name = "DateTimePickerstofrom"
        Me.DateTimePickerstofrom.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePickerstofrom.TabIndex = 49
        '
        'btnsearchsto
        '
        Me.btnsearchsto.BackColor = System.Drawing.Color.Gainsboro
        Me.btnsearchsto.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchsto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnsearchsto.Location = New System.Drawing.Point(531, 59)
        Me.btnsearchsto.Name = "btnsearchsto"
        Me.btnsearchsto.Size = New System.Drawing.Size(75, 26)
        Me.btnsearchsto.TabIndex = 48
        Me.btnsearchsto.Text = "Search"
        Me.btnsearchsto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by: product name, employee id"
        '
        'btnSearchstockRport
        '
        Me.btnSearchstockRport.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSearchstockRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchstockRport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchstockRport.Location = New System.Drawing.Point(531, 30)
        Me.btnSearchstockRport.Name = "btnSearchstockRport"
        Me.btnSearchstockRport.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchstockRport.TabIndex = 1
        Me.btnSearchstockRport.Text = "Search"
        Me.btnSearchstockRport.UseVisualStyleBackColor = False
        '
        'txtboxSearchstockRport
        '
        Me.txtboxSearchstockRport.Location = New System.Drawing.Point(244, 30)
        Me.txtboxSearchstockRport.Name = "txtboxSearchstockRport"
        Me.txtboxSearchstockRport.Size = New System.Drawing.Size(281, 23)
        Me.txtboxSearchstockRport.TabIndex = 0
        '
        'ReportStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 560)
        Me.Controls.Add(Me.GroupBoxPaRport)
        Me.Controls.Add(Me.ReportViewerStockdata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Stock - Clinic and Pharm Store Management System"
        CType(Me.mainstoretblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DUSCSDataSetmainstoretbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPaRport.ResumeLayout(False)
        Me.GroupBoxPaRport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerStockdata As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mainstoretblBindingSource As BindingSource
    Friend WithEvents DUSCSDataSetmainstoretbl As DUSCSDataSetmainstoretbl
    Friend WithEvents mainstoretblTableAdapter As DUSCSDataSetmainstoretblTableAdapters.mainstoretblTableAdapter
    Friend WithEvents GroupBoxPaRport As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchstockRport As Button
    Friend WithEvents txtboxSearchstockRport As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerstoto As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerstofrom As DateTimePicker
    Friend WithEvents btnsearchsto As Button
End Class
