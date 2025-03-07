<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabRequest
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
        Me.ToolStripLabreuest = New System.Windows.Forms.ToolStrip()
        Me.ToolStriptxtBoxlabrequest = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripBtnLabreq = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridViewforLabreq = New System.Windows.Forms.DataGridView()
        Me.ErrorProviderforLabreq = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStripLabreuest.SuspendLayout()
        CType(Me.DataGridViewforLabreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderforLabreq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripLabreuest
        '
        Me.ToolStripLabreuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripLabreuest.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStriptxtBoxlabrequest, Me.ToolStripBtnLabreq, Me.ToolStripSeparator1, Me.ToolStripLabel1})
        Me.ToolStripLabreuest.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripLabreuest.Name = "ToolStripLabreuest"
        Me.ToolStripLabreuest.Size = New System.Drawing.Size(971, 25)
        Me.ToolStripLabreuest.TabIndex = 0
        Me.ToolStripLabreuest.Text = "ToolStrip for Lab request"
        '
        'ToolStriptxtBoxlabrequest
        '
        Me.ToolStriptxtBoxlabrequest.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStriptxtBoxlabrequest.Name = "ToolStriptxtBoxlabrequest"
        Me.ToolStriptxtBoxlabrequest.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripBtnLabreq
        '
        Me.ToolStripBtnLabreq.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripBtnLabreq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripBtnLabreq.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripBtnLabreq.ImageTransparentColor = System.Drawing.Color.DarkViolet
        Me.ToolStripBtnLabreq.Name = "ToolStripBtnLabreq"
        Me.ToolStripBtnLabreq.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripBtnLabreq.Text = "Search"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripLabel1.Text = "by name, patient id , phone"
        '
        'DataGridViewforLabreq
        '
        Me.DataGridViewforLabreq.AllowUserToAddRows = False
        Me.DataGridViewforLabreq.AllowUserToDeleteRows = False
        Me.DataGridViewforLabreq.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewforLabreq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewforLabreq.Location = New System.Drawing.Point(12, 38)
        Me.DataGridViewforLabreq.Name = "DataGridViewforLabreq"
        Me.DataGridViewforLabreq.ReadOnly = True
        Me.DataGridViewforLabreq.Size = New System.Drawing.Size(947, 506)
        Me.DataGridViewforLabreq.TabIndex = 1
        '
        'ErrorProviderforLabreq
        '
        Me.ErrorProviderforLabreq.ContainerControl = Me
        '
        'LabRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(971, 556)
        Me.Controls.Add(Me.DataGridViewforLabreq)
        Me.Controls.Add(Me.ToolStripLabreuest)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LabRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Labratory Requested List - Clinic System"
        Me.ToolStripLabreuest.ResumeLayout(False)
        Me.ToolStripLabreuest.PerformLayout()
        CType(Me.DataGridViewforLabreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderforLabreq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripLabreuest As ToolStrip
    Friend WithEvents ToolStriptxtBoxlabrequest As ToolStripTextBox
    Friend WithEvents ToolStripBtnLabreq As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DataGridViewforLabreq As DataGridView
    Friend WithEvents ErrorProviderforLabreq As ErrorProvider
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
