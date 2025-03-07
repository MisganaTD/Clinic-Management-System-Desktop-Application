<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportExpirytobe
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
        Me.mainstoretblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DUSCSDataSetToBeExpi = New Clinic_System.DUSCSDataSetToBeExpi()
        Me.ReportViewerStockdatatobexpi = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBoxPaRport = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchstocktobeRport = New System.Windows.Forms.Button()
        Me.txtboxSearchstocktobeRport = New System.Windows.Forms.TextBox()
        Me.mainstoretblTableAdapter = New Clinic_System.DUSCSDataSetToBeExpiTableAdapters.mainstoretblTableAdapter()
        CType(Me.mainstoretblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DUSCSDataSetToBeExpi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPaRport.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainstoretblBindingSource
        '
        Me.mainstoretblBindingSource.DataMember = "mainstoretbl"
        Me.mainstoretblBindingSource.DataSource = Me.DUSCSDataSetToBeExpi
        '
        'DUSCSDataSetToBeExpi
        '
        Me.DUSCSDataSetToBeExpi.DataSetName = "DUSCSDataSetToBeExpi"
        Me.DUSCSDataSetToBeExpi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewerStockdatatobexpi
        '
        ReportDataSource1.Name = "DataSetTBeExp"
        ReportDataSource1.Value = Me.mainstoretblBindingSource
        Me.ReportViewerStockdatatobexpi.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerStockdatatobexpi.LocalReport.ReportEmbeddedResource = "Clinic_System.ReporttobeExpiry.rdlc"
        Me.ReportViewerStockdatatobexpi.Location = New System.Drawing.Point(12, 82)
        Me.ReportViewerStockdatatobexpi.Name = "ReportViewerStockdatatobexpi"
        Me.ReportViewerStockdatatobexpi.Size = New System.Drawing.Size(740, 466)
        Me.ReportViewerStockdatatobexpi.TabIndex = 1
        '
        'GroupBoxPaRport
        '
        Me.GroupBoxPaRport.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxPaRport.Controls.Add(Me.Label1)
        Me.GroupBoxPaRport.Controls.Add(Me.btnSearchstocktobeRport)
        Me.GroupBoxPaRport.Controls.Add(Me.txtboxSearchstocktobeRport)
        Me.GroupBoxPaRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPaRport.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxPaRport.Location = New System.Drawing.Point(12, 9)
        Me.GroupBoxPaRport.Name = "GroupBoxPaRport"
        Me.GroupBoxPaRport.Size = New System.Drawing.Size(739, 64)
        Me.GroupBoxPaRport.TabIndex = 10
        Me.GroupBoxPaRport.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(109, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by: product name"
        '
        'btnSearchstocktobeRport
        '
        Me.btnSearchstocktobeRport.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSearchstocktobeRport.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchstocktobeRport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchstocktobeRport.Location = New System.Drawing.Point(531, 25)
        Me.btnSearchstocktobeRport.Name = "btnSearchstocktobeRport"
        Me.btnSearchstocktobeRport.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchstocktobeRport.TabIndex = 1
        Me.btnSearchstocktobeRport.Text = "Search"
        Me.btnSearchstocktobeRport.UseVisualStyleBackColor = False
        '
        'txtboxSearchstocktobeRport
        '
        Me.txtboxSearchstocktobeRport.Location = New System.Drawing.Point(244, 25)
        Me.txtboxSearchstocktobeRport.Name = "txtboxSearchstocktobeRport"
        Me.txtboxSearchstocktobeRport.Size = New System.Drawing.Size(281, 23)
        Me.txtboxSearchstocktobeRport.TabIndex = 0
        '
        'mainstoretblTableAdapter
        '
        Me.mainstoretblTableAdapter.ClearBeforeFill = True
        '
        'ReportExpirytobe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 560)
        Me.Controls.Add(Me.GroupBoxPaRport)
        Me.Controls.Add(Me.ReportViewerStockdatatobexpi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportExpirytobe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock item to be expired after a month - Clinic and Pharm Store Management System" &
    ""
        CType(Me.mainstoretblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DUSCSDataSetToBeExpi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPaRport.ResumeLayout(False)
        Me.GroupBoxPaRport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerStockdatatobexpi As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBoxPaRport As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchstocktobeRport As Button
    Friend WithEvents txtboxSearchstocktobeRport As TextBox
    Friend WithEvents mainstoretblBindingSource As BindingSource
    Friend WithEvents DUSCSDataSetToBeExpi As DUSCSDataSetToBeExpi
    Friend WithEvents mainstoretblTableAdapter As DUSCSDataSetToBeExpiTableAdapters.mainstoretblTableAdapter
End Class
