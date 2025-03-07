<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prescriptionrequest
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStriptxtBoxprescriptionreq = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripbtnprescriptionreq = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ErrorProviderPrescreqs = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewforPrescreq = New System.Windows.Forms.DataGridView()
        Me.TextBoxCNum = New System.Windows.Forms.TextBox()
        Me.TextBoxPNam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerdispDate = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtboxdrugid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxMedid = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProviderPrescreqs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewforPrescreq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStriptxtBoxprescriptionreq, Me.ToolStripbtnprescriptionreq, Me.ToolStripSeparator1, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(971, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStriptxtBoxprescriptionreq
        '
        Me.ToolStriptxtBoxprescriptionreq.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStriptxtBoxprescriptionreq.Name = "ToolStriptxtBoxprescriptionreq"
        Me.ToolStriptxtBoxprescriptionreq.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripbtnprescriptionreq
        '
        Me.ToolStripbtnprescriptionreq.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripbtnprescriptionreq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripbtnprescriptionreq.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripbtnprescriptionreq.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripbtnprescriptionreq.Name = "ToolStripbtnprescriptionreq"
        Me.ToolStripbtnprescriptionreq.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripbtnprescriptionreq.Text = "Search"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripLabel1.Text = "by name,patient id,phone"
        '
        'ErrorProviderPrescreqs
        '
        Me.ErrorProviderPrescreqs.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(881, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Dispense"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridViewforPrescreq
        '
        Me.DataGridViewforPrescreq.AllowUserToAddRows = False
        Me.DataGridViewforPrescreq.AllowUserToDeleteRows = False
        Me.DataGridViewforPrescreq.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewforPrescreq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewforPrescreq.Location = New System.Drawing.Point(12, 28)
        Me.DataGridViewforPrescreq.Name = "DataGridViewforPrescreq"
        Me.DataGridViewforPrescreq.ReadOnly = True
        Me.DataGridViewforPrescreq.Size = New System.Drawing.Size(947, 353)
        Me.DataGridViewforPrescreq.TabIndex = 1
        '
        'TextBoxCNum
        '
        Me.TextBoxCNum.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxCNum.Location = New System.Drawing.Point(18, 423)
        Me.TextBoxCNum.Name = "TextBoxCNum"
        Me.TextBoxCNum.ReadOnly = True
        Me.TextBoxCNum.Size = New System.Drawing.Size(116, 21)
        Me.TextBoxCNum.TabIndex = 3
        '
        'TextBoxPNam
        '
        Me.TextBoxPNam.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxPNam.Location = New System.Drawing.Point(140, 423)
        Me.TextBoxPNam.Name = "TextBoxPNam"
        Me.TextBoxPNam.ReadOnly = True
        Me.TextBoxPNam.Size = New System.Drawing.Size(184, 21)
        Me.TextBoxPNam.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 396)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Card Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name"
        '
        'DateTimePickerdispDate
        '
        Me.DateTimePickerdispDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerdispDate.Enabled = False
        Me.DateTimePickerdispDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerdispDate.Location = New System.Drawing.Point(738, 483)
        Me.DateTimePickerdispDate.Name = "DateTimePickerdispDate"
        Me.DateTimePickerdispDate.Size = New System.Drawing.Size(137, 21)
        Me.DateTimePickerdispDate.TabIndex = 42
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(766, 456)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 15)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "Date"
        '
        'txtboxdrugid
        '
        Me.txtboxdrugid.BackColor = System.Drawing.SystemColors.Control
        Me.txtboxdrugid.Location = New System.Drawing.Point(330, 423)
        Me.txtboxdrugid.Name = "txtboxdrugid"
        Me.txtboxdrugid.ReadOnly = True
        Me.txtboxdrugid.Size = New System.Drawing.Size(119, 21)
        Me.txtboxdrugid.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 396)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Drug Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Drug items"
        '
        'TextBoxMedid
        '
        Me.TextBoxMedid.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxMedid.Location = New System.Drawing.Point(18, 483)
        Me.TextBoxMedid.Name = "TextBoxMedid"
        Me.TextBoxMedid.ReadOnly = True
        Me.TextBoxMedid.Size = New System.Drawing.Size(714, 21)
        Me.TextBoxMedid.TabIndex = 52
        '
        'Prescriptionrequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(971, 556)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxMedid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxdrugid)
        Me.Controls.Add(Me.DateTimePickerdispDate)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPNam)
        Me.Controls.Add(Me.TextBoxCNum)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridViewforPrescreq)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prescriptionrequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription Requested List - Clinic System"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProviderPrescreqs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewforPrescreq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStriptxtBoxprescriptionreq As ToolStripTextBox
    Friend WithEvents ToolStripbtnprescriptionreq As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ErrorProviderPrescreqs As ErrorProvider
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewforPrescreq As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPNam As TextBox
    Friend WithEvents TextBoxCNum As TextBox
    Friend WithEvents DateTimePickerdispDate As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxdrugid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxMedid As TextBox
End Class
