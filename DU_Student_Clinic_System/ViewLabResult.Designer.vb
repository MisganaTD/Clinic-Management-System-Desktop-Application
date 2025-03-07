<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewLabResult
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
        Me.DataGridViewforLabResult = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchLabResult = New System.Windows.Forms.Button()
        Me.txtboxSearchLabR = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewforLabResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewforLabResult
        '
        Me.DataGridViewforLabResult.AllowUserToAddRows = False
        Me.DataGridViewforLabResult.AllowUserToDeleteRows = False
        Me.DataGridViewforLabResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewforLabResult.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewforLabResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewforLabResult.Location = New System.Drawing.Point(12, 81)
        Me.DataGridViewforLabResult.Name = "DataGridViewforLabResult"
        Me.DataGridViewforLabResult.ReadOnly = True
        Me.DataGridViewforLabResult.Size = New System.Drawing.Size(947, 463)
        Me.DataGridViewforLabResult.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSearchLabResult)
        Me.GroupBox1.Controls.Add(Me.txtboxSearchLabR)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 63)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(357, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search by: patient ID, name, branch"
        '
        'btnSearchLabResult
        '
        Me.btnSearchLabResult.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchLabResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchLabResult.Location = New System.Drawing.Point(256, 22)
        Me.btnSearchLabResult.Name = "btnSearchLabResult"
        Me.btnSearchLabResult.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchLabResult.TabIndex = 1
        Me.btnSearchLabResult.Text = "Serach"
        Me.btnSearchLabResult.UseVisualStyleBackColor = True
        '
        'txtboxSearchLabR
        '
        Me.txtboxSearchLabR.Location = New System.Drawing.Point(6, 22)
        Me.txtboxSearchLabR.Name = "txtboxSearchLabR"
        Me.txtboxSearchLabR.Size = New System.Drawing.Size(244, 23)
        Me.txtboxSearchLabR.TabIndex = 0
        '
        'ViewLabResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(971, 556)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewforLabResult)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewLabResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Lab Result - Clinic System"
        CType(Me.DataGridViewforLabResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewforLabResult As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearchLabResult As Button
    Friend WithEvents txtboxSearchLabR As TextBox
    Friend WithEvents Label1 As Label
End Class
