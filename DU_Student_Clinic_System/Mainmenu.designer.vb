<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainmenu
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
        Me.MenuStripmainmenu = New System.Windows.Forms.MenuStrip()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetEmployeePasswordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEditPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhysicianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrescriptionEntryDiagnosisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProceedRequestedStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLabResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCatagoricallyLabReslutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientAppointmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPatientToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabratoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTestResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PharmacistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StServTeamLeaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportPharmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabReportByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpiryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsumedStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpiryAlertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestedStockbyPharmasistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DispenseryByPharmasistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeYourPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.myTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblusername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxMain = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblcampus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEID = New System.Windows.Forms.Label()
        Me.MenuStripmainmenu.SuspendLayout()
        Me.GroupBoxMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripmainmenu
        '
        Me.MenuStripmainmenu.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.MenuStripmainmenu.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripmainmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministratorToolStripMenuItem, Me.PatientInformationToolStripMenuItem, Me.PhysicianToolStripMenuItem, Me.LabratoryToolStripMenuItem, Me.PharmacistToolStripMenuItem, Me.StoreToolStripMenuItem, Me.StServTeamLeaderToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SettingToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStripmainmenu.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripmainmenu.Name = "MenuStripmainmenu"
        Me.MenuStripmainmenu.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStripmainmenu.Size = New System.Drawing.Size(1016, 24)
        Me.MenuStripmainmenu.TabIndex = 1
        Me.MenuStripmainmenu.Text = "MenuStrip1"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.ManageEmployeeToolStripMenuItem, Me.OtherToolStripMenuItem})
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.AdministratorToolStripMenuItem.Text = "Administrator"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(334, 22)
        Me.AddEmployeeToolStripMenuItem.Text = "Employee Registration /  DU SCS Employee List"
        '
        'ManageEmployeeToolStripMenuItem
        '
        Me.ManageEmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TToolStripMenuItem, Me.ResetEmployeePasswordToolStripMenuItem1})
        Me.ManageEmployeeToolStripMenuItem.Name = "ManageEmployeeToolStripMenuItem"
        Me.ManageEmployeeToolStripMenuItem.Size = New System.Drawing.Size(334, 22)
        Me.ManageEmployeeToolStripMenuItem.Text = "Manage Employee"
        '
        'TToolStripMenuItem
        '
        Me.TToolStripMenuItem.Name = "TToolStripMenuItem"
        Me.TToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.TToolStripMenuItem.Text = "Edit / Inactive Employee "
        '
        'ResetEmployeePasswordToolStripMenuItem1
        '
        Me.ResetEmployeePasswordToolStripMenuItem1.Name = "ResetEmployeePasswordToolStripMenuItem1"
        Me.ResetEmployeePasswordToolStripMenuItem1.Size = New System.Drawing.Size(214, 22)
        Me.ResetEmployeePasswordToolStripMenuItem1.Text = "Reset Employee Password"
        '
        'OtherToolStripMenuItem
        '
        Me.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        Me.OtherToolStripMenuItem.Size = New System.Drawing.Size(334, 22)
        Me.OtherToolStripMenuItem.Text = "Other"
        '
        'PatientInformationToolStripMenuItem
        '
        Me.PatientInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPatientToolStripMenuItem, Me.ViewEditPatientToolStripMenuItem})
        Me.PatientInformationToolStripMenuItem.Name = "PatientInformationToolStripMenuItem"
        Me.PatientInformationToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.PatientInformationToolStripMenuItem.Text = "Card Room"
        '
        'ViewPatientToolStripMenuItem
        '
        Me.ViewPatientToolStripMenuItem.Name = "ViewPatientToolStripMenuItem"
        Me.ViewPatientToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ViewPatientToolStripMenuItem.Text = "Patient Registration"
        '
        'ViewEditPatientToolStripMenuItem
        '
        Me.ViewEditPatientToolStripMenuItem.Name = "ViewEditPatientToolStripMenuItem"
        Me.ViewEditPatientToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ViewEditPatientToolStripMenuItem.Text = "View/Edit Patient"
        '
        'PhysicianToolStripMenuItem
        '
        Me.PhysicianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrescriptionEntryDiagnosisToolStripMenuItem, Me.ProceedRequestedStockToolStripMenuItem, Me.ViewLabResultToolStripMenuItem, Me.ViewCatagoricallyLabReslutToolStripMenuItem, Me.PatientAppointmentToolStripMenuItem1, Me.ViewPatientToolStripMenuItem2, Me.PatientRegistrationToolStripMenuItem})
        Me.PhysicianToolStripMenuItem.Name = "PhysicianToolStripMenuItem"
        Me.PhysicianToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PhysicianToolStripMenuItem.Text = "Physician"
        '
        'PrescriptionEntryDiagnosisToolStripMenuItem
        '
        Me.PrescriptionEntryDiagnosisToolStripMenuItem.Name = "PrescriptionEntryDiagnosisToolStripMenuItem"
        Me.PrescriptionEntryDiagnosisToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.PrescriptionEntryDiagnosisToolStripMenuItem.Text = "Diagnosis / Prescription Entry"
        '
        'ProceedRequestedStockToolStripMenuItem
        '
        Me.ProceedRequestedStockToolStripMenuItem.Name = "ProceedRequestedStockToolStripMenuItem"
        Me.ProceedRequestedStockToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.ProceedRequestedStockToolStripMenuItem.Text = "Proceed Requested Stock"
        '
        'ViewLabResultToolStripMenuItem
        '
        Me.ViewLabResultToolStripMenuItem.Name = "ViewLabResultToolStripMenuItem"
        Me.ViewLabResultToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.ViewLabResultToolStripMenuItem.Text = "Lab Result For Current Day"
        '
        'ViewCatagoricallyLabReslutToolStripMenuItem
        '
        Me.ViewCatagoricallyLabReslutToolStripMenuItem.Name = "ViewCatagoricallyLabReslutToolStripMenuItem"
        Me.ViewCatagoricallyLabReslutToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.ViewCatagoricallyLabReslutToolStripMenuItem.Text = "Lab Reslut"
        '
        'PatientAppointmentToolStripMenuItem1
        '
        Me.PatientAppointmentToolStripMenuItem1.Name = "PatientAppointmentToolStripMenuItem1"
        Me.PatientAppointmentToolStripMenuItem1.Size = New System.Drawing.Size(313, 22)
        Me.PatientAppointmentToolStripMenuItem1.Text = "Patient Appointment / Emergency / Injection"
        '
        'ViewPatientToolStripMenuItem2
        '
        Me.ViewPatientToolStripMenuItem2.Name = "ViewPatientToolStripMenuItem2"
        Me.ViewPatientToolStripMenuItem2.Size = New System.Drawing.Size(313, 22)
        Me.ViewPatientToolStripMenuItem2.Text = "View Patient"
        '
        'PatientRegistrationToolStripMenuItem
        '
        Me.PatientRegistrationToolStripMenuItem.Name = "PatientRegistrationToolStripMenuItem"
        Me.PatientRegistrationToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.PatientRegistrationToolStripMenuItem.Text = "Patient Registration"
        '
        'LabratoryToolStripMenuItem
        '
        Me.LabratoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTestResultToolStripMenuItem})
        Me.LabratoryToolStripMenuItem.Name = "LabratoryToolStripMenuItem"
        Me.LabratoryToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.LabratoryToolStripMenuItem.Text = "Laboratory"
        '
        'AddTestResultToolStripMenuItem
        '
        Me.AddTestResultToolStripMenuItem.Name = "AddTestResultToolStripMenuItem"
        Me.AddTestResultToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AddTestResultToolStripMenuItem.Text = "Add Lab Result"
        '
        'PharmacistToolStripMenuItem
        '
        Me.PharmacistToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequestListToolStripMenuItem, Me.RequestStockToolStripMenuItem})
        Me.PharmacistToolStripMenuItem.Name = "PharmacistToolStripMenuItem"
        Me.PharmacistToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.PharmacistToolStripMenuItem.Text = "Pharmacist"
        '
        'RequestListToolStripMenuItem
        '
        Me.RequestListToolStripMenuItem.Name = "RequestListToolStripMenuItem"
        Me.RequestListToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.RequestListToolStripMenuItem.Text = "Prescription Requested"
        '
        'RequestStockToolStripMenuItem
        '
        Me.RequestStockToolStripMenuItem.Name = "RequestStockToolStripMenuItem"
        Me.RequestStockToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.RequestStockToolStripMenuItem.Text = "Stock"
        '
        'StoreToolStripMenuItem
        '
        Me.StoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageStockToolStripMenuItem})
        Me.StoreToolStripMenuItem.Name = "StoreToolStripMenuItem"
        Me.StoreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.StoreToolStripMenuItem.Text = "Store"
        '
        'ManageStockToolStripMenuItem
        '
        Me.ManageStockToolStripMenuItem.Name = "ManageStockToolStripMenuItem"
        Me.ManageStockToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManageStockToolStripMenuItem.Text = "Manage Stock"
        '
        'StServTeamLeaderToolStripMenuItem
        '
        Me.StServTeamLeaderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApprovalToolStripMenuItem})
        Me.StServTeamLeaderToolStripMenuItem.Name = "StServTeamLeaderToolStripMenuItem"
        Me.StServTeamLeaderToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.StServTeamLeaderToolStripMenuItem.Text = "St. Serv. Team Leader"
        '
        'ApprovalToolStripMenuItem
        '
        Me.ApprovalToolStripMenuItem.Name = "ApprovalToolStripMenuItem"
        Me.ApprovalToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ApprovalToolStripMenuItem.Text = "Approve Requested Stock"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientReportsToolStripMenuItem, Me.ReportPharmToolStripMenuItem, Me.LabReportToolStripMenuItem, Me.LabReportByDateToolStripMenuItem, Me.StockToolStripMenuItem, Me.ExpiryToolStripMenuItem, Me.ConsumedStockToolStripMenuItem, Me.ExpiryAlertToolStripMenuItem, Me.RequestedStockbyPharmasistToolStripMenuItem, Me.DispenseryByPharmasistToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ReportsToolStripMenuItem.Text = "Report"
        '
        'PatientReportsToolStripMenuItem
        '
        Me.PatientReportsToolStripMenuItem.Name = "PatientReportsToolStripMenuItem"
        Me.PatientReportsToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.PatientReportsToolStripMenuItem.Text = "Patient"
        '
        'ReportPharmToolStripMenuItem
        '
        Me.ReportPharmToolStripMenuItem.Name = "ReportPharmToolStripMenuItem"
        Me.ReportPharmToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ReportPharmToolStripMenuItem.Text = "Pharmacy"
        '
        'LabReportToolStripMenuItem
        '
        Me.LabReportToolStripMenuItem.Name = "LabReportToolStripMenuItem"
        Me.LabReportToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.LabReportToolStripMenuItem.Text = "Labratory"
        '
        'LabReportByDateToolStripMenuItem
        '
        Me.LabReportByDateToolStripMenuItem.Name = "LabReportByDateToolStripMenuItem"
        Me.LabReportByDateToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.LabReportByDateToolStripMenuItem.Text = "Lab Report by Date"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.StockToolStripMenuItem.Text = "Stock for Store Keeper"
        '
        'ExpiryToolStripMenuItem
        '
        Me.ExpiryToolStripMenuItem.Name = "ExpiryToolStripMenuItem"
        Me.ExpiryToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ExpiryToolStripMenuItem.Text = "Expiry"
        '
        'ConsumedStockToolStripMenuItem
        '
        Me.ConsumedStockToolStripMenuItem.Name = "ConsumedStockToolStripMenuItem"
        Me.ConsumedStockToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ConsumedStockToolStripMenuItem.Text = "Stock Item Used by Patient"
        '
        'ExpiryAlertToolStripMenuItem
        '
        Me.ExpiryAlertToolStripMenuItem.Name = "ExpiryAlertToolStripMenuItem"
        Me.ExpiryAlertToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ExpiryAlertToolStripMenuItem.Text = "Expiry Alert"
        '
        'RequestedStockbyPharmasistToolStripMenuItem
        '
        Me.RequestedStockbyPharmasistToolStripMenuItem.Name = "RequestedStockbyPharmasistToolStripMenuItem"
        Me.RequestedStockbyPharmasistToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.RequestedStockbyPharmasistToolStripMenuItem.Text = "Stock Detail for Pharmacist"
        '
        'DispenseryByPharmasistToolStripMenuItem
        '
        Me.DispenseryByPharmasistToolStripMenuItem.Name = "DispenseryByPharmasistToolStripMenuItem"
        Me.DispenseryByPharmasistToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.DispenseryByPharmasistToolStripMenuItem.Text = "Stock Item Used by Phyiscian"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeYourPasswordToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.SettingToolStripMenuItem.Text = "User Account"
        '
        'ChangeYourPasswordToolStripMenuItem
        '
        Me.ChangeYourPasswordToolStripMenuItem.Name = "ChangeYourPasswordToolStripMenuItem"
        Me.ChangeYourPasswordToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ChangeYourPasswordToolStripMenuItem.Text = "Change Your Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'myTimer
        '
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblusername.Location = New System.Drawing.Point(104, 39)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(11, 16)
        Me.lblusername.TabIndex = 20
        Me.lblusername.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Welcome:"
        '
        'GroupBoxMain
        '
        Me.GroupBoxMain.BackColor = System.Drawing.Color.MintCream
        Me.GroupBoxMain.Controls.Add(Me.Label7)
        Me.GroupBoxMain.Controls.Add(Me.lblcampus)
        Me.GroupBoxMain.Controls.Add(Me.Label2)
        Me.GroupBoxMain.Controls.Add(Me.lblEID)
        Me.GroupBoxMain.Controls.Add(Me.Label1)
        Me.GroupBoxMain.Controls.Add(Me.lblusername)
        Me.GroupBoxMain.Location = New System.Drawing.Point(700, 27)
        Me.GroupBoxMain.Name = "GroupBoxMain"
        Me.GroupBoxMain.Size = New System.Drawing.Size(304, 155)
        Me.GroupBoxMain.TabIndex = 22
        Me.GroupBoxMain.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(10, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Campus:"
        '
        'lblcampus
        '
        Me.lblcampus.AutoSize = True
        Me.lblcampus.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcampus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcampus.Location = New System.Drawing.Point(104, 89)
        Me.lblcampus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcampus.Name = "lblcampus"
        Me.lblcampus.Size = New System.Drawing.Size(11, 16)
        Me.lblcampus.TabIndex = 30
        Me.lblcampus.Text = "-"
        Me.lblcampus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Active User ID:"
        '
        'lblEID
        '
        Me.lblEID.AutoSize = True
        Me.lblEID.BackColor = System.Drawing.Color.Transparent
        Me.lblEID.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEID.Location = New System.Drawing.Point(104, 68)
        Me.lblEID.Name = "lblEID"
        Me.lblEID.Size = New System.Drawing.Size(11, 16)
        Me.lblEID.TabIndex = 22
        Me.lblEID.Text = "-"
        '
        'Mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1016, 650)
        Me.Controls.Add(Me.GroupBoxMain)
        Me.Controls.Add(Me.MenuStripmainmenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStripmainmenu
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Mainmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu - Clinic System"
        Me.MenuStripmainmenu.ResumeLayout(False)
        Me.MenuStripmainmenu.PerformLayout()
        Me.GroupBoxMain.ResumeLayout(False)
        Me.GroupBoxMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripmainmenu As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportPharmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabratoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhysicianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrescriptionEntryDiagnosisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTestResultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PharmacistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents RequestListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewLabResultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCatagoricallyLabReslutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblusername As Label
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeYourPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PatientAppointmentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewPatientToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LabReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabReportByDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBoxMain As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEID As Label
    Friend WithEvents PatientRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetEmployeePasswordToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewEditPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents lblcampus As Label
    Friend WithEvents StoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpiryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsumedStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StServTeamLeaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApprovalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpiryAlertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestedStockbyPharmasistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DispenseryByPharmasistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProceedRequestedStockToolStripMenuItem As ToolStripMenuItem
End Class
