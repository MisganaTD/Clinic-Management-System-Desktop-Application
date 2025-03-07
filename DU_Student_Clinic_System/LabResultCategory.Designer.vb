<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabResultCategory
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewforLabResultHem = New System.Windows.Forms.DataGridView()
        Me.GroupBoxforHem = New System.Windows.Forms.GroupBox()
        Me.btnSearchLabResultforHem = New System.Windows.Forms.Button()
        Me.txtboxSearchLabHem = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewforLabResultSto = New System.Windows.Forms.DataGridView()
        Me.GroupBoxforSto = New System.Windows.Forms.GroupBox()
        Me.btnSearchLabResultforSto = New System.Windows.Forms.Button()
        Me.txtboxSearchLabSto = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridViewforLabResultUri = New System.Windows.Forms.DataGridView()
        Me.GroupBoxforUri = New System.Windows.Forms.GroupBox()
        Me.btnSearchLabResultforUri = New System.Windows.Forms.Button()
        Me.txtboxSearchLabUri = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridViewforLabResultSero = New System.Windows.Forms.DataGridView()
        Me.GroupBoxforSero = New System.Windows.Forms.GroupBox()
        Me.btnSearchLabResultforSero = New System.Windows.Forms.Button()
        Me.txtboxSearchLabSero = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewforLabResultHem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxforHem.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewforLabResultSto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxforSto.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridViewforLabResultUri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxforUri.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridViewforLabResultSero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxforSero.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(947, 532)
        Me.TabControl1.TabIndex = 112
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridViewforLabResultHem)
        Me.TabPage1.Controls.Add(Me.GroupBoxforHem)
        Me.TabPage1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(939, 506)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "HEMATOLOGY"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewforLabResultHem
        '
        Me.DataGridViewforLabResultHem.AllowUserToAddRows = False
        Me.DataGridViewforLabResultHem.AllowUserToDeleteRows = False
        Me.DataGridViewforLabResultHem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewforLabResultHem.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewforLabResultHem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewforLabResultHem.Location = New System.Drawing.Point(15, 83)
        Me.DataGridViewforLabResultHem.Name = "DataGridViewforLabResultHem"
        Me.DataGridViewforLabResultHem.ReadOnly = True
        Me.DataGridViewforLabResultHem.Size = New System.Drawing.Size(918, 407)
        Me.DataGridViewforLabResultHem.TabIndex = 4
        '
        'GroupBoxforHem
        '
        Me.GroupBoxforHem.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxforHem.Controls.Add(Me.btnSearchLabResultforHem)
        Me.GroupBoxforHem.Controls.Add(Me.txtboxSearchLabHem)
        Me.GroupBoxforHem.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxforHem.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxforHem.Location = New System.Drawing.Point(15, 14)
        Me.GroupBoxforHem.Name = "GroupBoxforHem"
        Me.GroupBoxforHem.Size = New System.Drawing.Size(337, 63)
        Me.GroupBoxforHem.TabIndex = 3
        Me.GroupBoxforHem.TabStop = False
        Me.GroupBoxforHem.Text = "Search"
        '
        'btnSearchLabResultforHem
        '
        Me.btnSearchLabResultforHem.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchLabResultforHem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchLabResultforHem.Location = New System.Drawing.Point(256, 22)
        Me.btnSearchLabResultforHem.Name = "btnSearchLabResultforHem"
        Me.btnSearchLabResultforHem.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchLabResultforHem.TabIndex = 1
        Me.btnSearchLabResultforHem.Text = "Serach"
        Me.btnSearchLabResultforHem.UseVisualStyleBackColor = True
        '
        'txtboxSearchLabHem
        '
        Me.txtboxSearchLabHem.Location = New System.Drawing.Point(6, 22)
        Me.txtboxSearchLabHem.Name = "txtboxSearchLabHem"
        Me.txtboxSearchLabHem.Size = New System.Drawing.Size(244, 23)
        Me.txtboxSearchLabHem.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewforLabResultSto)
        Me.TabPage2.Controls.Add(Me.GroupBoxforSto)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(939, 506)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "STOOL EXAM (DIRECT)"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewforLabResultSto
        '
        Me.DataGridViewforLabResultSto.AllowUserToAddRows = False
        Me.DataGridViewforLabResultSto.AllowUserToDeleteRows = False
        Me.DataGridViewforLabResultSto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewforLabResultSto.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewforLabResultSto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewforLabResultSto.Location = New System.Drawing.Point(10, 82)
        Me.DataGridViewforLabResultSto.Name = "DataGridViewforLabResultSto"
        Me.DataGridViewforLabResultSto.ReadOnly = True
        Me.DataGridViewforLabResultSto.Size = New System.Drawing.Size(918, 407)
        Me.DataGridViewforLabResultSto.TabIndex = 5
        '
        'GroupBoxforSto
        '
        Me.GroupBoxforSto.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxforSto.Controls.Add(Me.btnSearchLabResultforSto)
        Me.GroupBoxforSto.Controls.Add(Me.txtboxSearchLabSto)
        Me.GroupBoxforSto.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxforSto.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxforSto.Location = New System.Drawing.Point(12, 10)
        Me.GroupBoxforSto.Name = "GroupBoxforSto"
        Me.GroupBoxforSto.Size = New System.Drawing.Size(337, 63)
        Me.GroupBoxforSto.TabIndex = 3
        Me.GroupBoxforSto.TabStop = False
        Me.GroupBoxforSto.Text = "Search"
        '
        'btnSearchLabResultforSto
        '
        Me.btnSearchLabResultforSto.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchLabResultforSto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchLabResultforSto.Location = New System.Drawing.Point(256, 22)
        Me.btnSearchLabResultforSto.Name = "btnSearchLabResultforSto"
        Me.btnSearchLabResultforSto.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchLabResultforSto.TabIndex = 1
        Me.btnSearchLabResultforSto.Text = "Serach"
        Me.btnSearchLabResultforSto.UseVisualStyleBackColor = True
        '
        'txtboxSearchLabSto
        '
        Me.txtboxSearchLabSto.Location = New System.Drawing.Point(6, 22)
        Me.txtboxSearchLabSto.Name = "txtboxSearchLabSto"
        Me.txtboxSearchLabSto.Size = New System.Drawing.Size(244, 23)
        Me.txtboxSearchLabSto.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridViewforLabResultUri)
        Me.TabPage3.Controls.Add(Me.GroupBoxforUri)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(939, 506)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "URINALYSIS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridViewforLabResultUri
        '
        Me.DataGridViewforLabResultUri.AllowUserToAddRows = False
        Me.DataGridViewforLabResultUri.AllowUserToDeleteRows = False
        Me.DataGridViewforLabResultUri.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewforLabResultUri.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewforLabResultUri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewforLabResultUri.Location = New System.Drawing.Point(10, 86)
        Me.DataGridViewforLabResultUri.Name = "DataGridViewforLabResultUri"
        Me.DataGridViewforLabResultUri.ReadOnly = True
        Me.DataGridViewforLabResultUri.Size = New System.Drawing.Size(918, 407)
        Me.DataGridViewforLabResultUri.TabIndex = 5
        '
        'GroupBoxforUri
        '
        Me.GroupBoxforUri.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxforUri.Controls.Add(Me.btnSearchLabResultforUri)
        Me.GroupBoxforUri.Controls.Add(Me.txtboxSearchLabUri)
        Me.GroupBoxforUri.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxforUri.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxforUri.Location = New System.Drawing.Point(14, 15)
        Me.GroupBoxforUri.Name = "GroupBoxforUri"
        Me.GroupBoxforUri.Size = New System.Drawing.Size(337, 63)
        Me.GroupBoxforUri.TabIndex = 3
        Me.GroupBoxforUri.TabStop = False
        Me.GroupBoxforUri.Text = "Search"
        '
        'btnSearchLabResultforUri
        '
        Me.btnSearchLabResultforUri.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchLabResultforUri.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchLabResultforUri.Location = New System.Drawing.Point(256, 22)
        Me.btnSearchLabResultforUri.Name = "btnSearchLabResultforUri"
        Me.btnSearchLabResultforUri.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchLabResultforUri.TabIndex = 1
        Me.btnSearchLabResultforUri.Text = "Serach"
        Me.btnSearchLabResultforUri.UseVisualStyleBackColor = True
        '
        'txtboxSearchLabUri
        '
        Me.txtboxSearchLabUri.Location = New System.Drawing.Point(6, 22)
        Me.txtboxSearchLabUri.Name = "txtboxSearchLabUri"
        Me.txtboxSearchLabUri.Size = New System.Drawing.Size(244, 23)
        Me.txtboxSearchLabUri.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGridViewforLabResultSero)
        Me.TabPage4.Controls.Add(Me.GroupBoxforSero)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(939, 506)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "SEROLOGY"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridViewforLabResultSero
        '
        Me.DataGridViewforLabResultSero.AllowUserToAddRows = False
        Me.DataGridViewforLabResultSero.AllowUserToDeleteRows = False
        Me.DataGridViewforLabResultSero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewforLabResultSero.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewforLabResultSero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewforLabResultSero.Location = New System.Drawing.Point(10, 88)
        Me.DataGridViewforLabResultSero.Name = "DataGridViewforLabResultSero"
        Me.DataGridViewforLabResultSero.ReadOnly = True
        Me.DataGridViewforLabResultSero.Size = New System.Drawing.Size(918, 407)
        Me.DataGridViewforLabResultSero.TabIndex = 5
        '
        'GroupBoxforSero
        '
        Me.GroupBoxforSero.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxforSero.Controls.Add(Me.btnSearchLabResultforSero)
        Me.GroupBoxforSero.Controls.Add(Me.txtboxSearchLabSero)
        Me.GroupBoxforSero.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxforSero.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxforSero.Location = New System.Drawing.Point(14, 17)
        Me.GroupBoxforSero.Name = "GroupBoxforSero"
        Me.GroupBoxforSero.Size = New System.Drawing.Size(337, 63)
        Me.GroupBoxforSero.TabIndex = 3
        Me.GroupBoxforSero.TabStop = False
        Me.GroupBoxforSero.Text = "Search"
        '
        'btnSearchLabResultforSero
        '
        Me.btnSearchLabResultforSero.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchLabResultforSero.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchLabResultforSero.Location = New System.Drawing.Point(256, 22)
        Me.btnSearchLabResultforSero.Name = "btnSearchLabResultforSero"
        Me.btnSearchLabResultforSero.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchLabResultforSero.TabIndex = 1
        Me.btnSearchLabResultforSero.Text = "Serach"
        Me.btnSearchLabResultforSero.UseVisualStyleBackColor = True
        '
        'txtboxSearchLabSero
        '
        Me.txtboxSearchLabSero.Location = New System.Drawing.Point(6, 22)
        Me.txtboxSearchLabSero.Name = "txtboxSearchLabSero"
        Me.txtboxSearchLabSero.Size = New System.Drawing.Size(244, 23)
        Me.txtboxSearchLabSero.TabIndex = 0
        '
        'LabResultCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(971, 556)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "LabResultCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab Result - Clinic System"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridViewforLabResultHem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxforHem.ResumeLayout(False)
        Me.GroupBoxforHem.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewforLabResultSto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxforSto.ResumeLayout(False)
        Me.GroupBoxforSto.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridViewforLabResultUri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxforUri.ResumeLayout(False)
        Me.GroupBoxforUri.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridViewforLabResultSero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxforSero.ResumeLayout(False)
        Me.GroupBoxforSero.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBoxforHem As GroupBox
    Friend WithEvents btnSearchLabResultforHem As Button
    Friend WithEvents txtboxSearchLabHem As TextBox
    Friend WithEvents GroupBoxforUri As GroupBox
    Friend WithEvents btnSearchLabResultforUri As Button
    Friend WithEvents txtboxSearchLabUri As TextBox
    Friend WithEvents GroupBoxforSero As GroupBox
    Friend WithEvents btnSearchLabResultforSero As Button
    Friend WithEvents txtboxSearchLabSero As TextBox
    Friend WithEvents GroupBoxforSto As GroupBox
    Friend WithEvents btnSearchLabResultforSto As Button
    Friend WithEvents txtboxSearchLabSto As TextBox
    Friend WithEvents DataGridViewforLabResultHem As DataGridView
    Friend WithEvents DataGridViewforLabResultSto As DataGridView
    Friend WithEvents DataGridViewforLabResultUri As DataGridView
    Friend WithEvents DataGridViewforLabResultSero As DataGridView
End Class
