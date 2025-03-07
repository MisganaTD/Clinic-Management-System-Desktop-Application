Imports System.Data.SqlClient
Public Class Prescriptionrequest
    Dim index As Integer
    Dim cnp As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ' ErrorProviderBioChem.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Private Sub Prescriptionrequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DUSCSDataSet.patienttbl' table. You can move, or remove it, as needed.
        'FilterDataForPharReq("") BY Misgana when modified
        FilterDataForPharReq("") 'BY Misgana when modified
    End Sub
#Region "view prescription list for current date"
    Public Sub FilterDataForPharReq(valueforSearch As String)
        Dim curentDate As DateTime = DateTime.Today
        'mp.prescribeddate = '{curentDate.ToShortDateString()}' and
        'MsgBox("Current date is " & curentDate)
        'Try
        'Dim physid As String = Mainmenu.lblEID.Text.Trim() 'userName.ToString()
        Dim brnc As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQuery As String = $"SELECT mp.patientid,ptbl.name,mp.drugid,mp.drugname,mp.dose,mp.frequency,mp.otherinfo,mp.drugtwo,mp.frequencyfordrugtwo,mp.dosefordrugtwo,mp.otherinformationfordrugtwo,mp.drugthree,mp.frequencyfordrugthree,mp.dosefordrugthree,mp.otherinformationfordrugthree,mp.drugfour,mp.frequencyfordrugfour,mp.dosefordrugfour,mp.otherinformationfordrugfour,mp.drugfive,mp.frequencyfordrugfive,mp.dosefordrugfive,mp.otherinformationfordrugfive,mp.prescribeddate from prescriptiontbl mp INNER Join patienttbl ptbl ON mp.patientid = ptbl.patientid WHERE mp.prescribeddate='" & curentDate.ToShortDateString() & "' and mp.giveoutstatus = 'prescribed' and ptbl.branch='" & brnc & "'"
        'Dim SearchQuery As String = $"SELECT mp.patientid,mp.medicineid,mp.prescripeddate,mp.diet,mp.medicinename,mp.precaution,mp.nofdose,mp.other from perscribeandinjectiontbl mp WHERE mp.prescripeddate = '{curentDate.ToShortDateString()}'"
        Dim cc As New SqlCommand(SearchQuery, cn)
        Dim ac As New SqlDataAdapter(cc)
        Dim tb As New DataTable()
        ac.Fill(tb)
        DataGridViewforPrescreq.DataSource = tb
        'Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub
#End Region
#Region "Select randomly patientdiagnosis tbl"
    Public Sub FilterDatarndmForPhar(valueforSearchrndm As String)
        Try
            Dim ctDate As DateTime = DateTime.Today
            'Dim SearchQuery As String = "select * from patientdiagnosistbl where CONCAT(name,email,phone) like '%" & valueToSearch & "%'"
            Dim brn As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQuer As String = $"SELECT mp.patientid,ptbl.name,ptbl.branch,mp.drugid,mp.drugname,mp.dose,mp.frequency,mp.otherinfo,mp.drugtwo,mp.frequencyfordrugtwo,mp.dosefordrugtwo,mp.otherinformationfordrugtwo,mp.drugthree,mp.frequencyfordrugthree,mp.dosefordrugthree,mp.otherinformationfordrugthree,mp.drugfour,mp.frequencyfordrugfour,mp.dosefordrugfour,mp.otherinformationfordrugfour,mp.drugfive,mp.frequencyfordrugfive,mp.dosefordrugfive,mp.otherinformationfordrugfive,mp.prescribeddate from prescriptiontbl mp INNER Join patienttbl ptbl ON mp.patientid = ptbl.patientid WHERE CONCAT(ptbl.name,ptbl.phone,mp.patientid) like '%" & valueforSearchrndm & "%' and mp.giveoutstatus = 'prescribed' and ptbl.branch='" & brn & "'"
            Dim c As New SqlCommand(SearchQuer, cn)
            Dim sd As New SqlDataAdapter(c)
            Dim tbl As New DataTable()
            sd.Fill(tbl)
            DataGridViewforPrescreq.DataSource = tbl
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
#End Region
    End Sub
    Private Sub ToolStripbtnprescriptionreq_Click(sender As Object, e As EventArgs) Handles ToolStripbtnprescriptionreq.Click
        If vld(ToolStriptxtBoxprescriptionreq) = False Then
            'Exit Sub
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
        Else
            FilterDatarndmForPhar(ToolStriptxtBoxprescriptionreq.Text)
        End If
    End Sub
    Private Sub ToolStriptxtBoxprescriptionreq_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStriptxtBoxprescriptionreq.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripbtnprescriptionreq_Click(sender, e)
        End If
    End Sub

    Private Sub DataGridViewforPrescreq_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewforPrescreq.CellContentClick
        'If IsConfirm("Do you want to dispense ?") Then
        Try
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewforPrescreq.Rows(index)
            TextBoxCNum.Text = selectedRow.Cells(0).Value.ToString
            TextBoxPNam.Text = selectedRow.Cells(1).Value.ToString
            TextBoxMedid.Text = "  " + selectedRow.Cells(3).Value.ToString + "  " + selectedRow.Cells(7).Value.ToString + "   " + selectedRow.Cells(12).Value.ToString + "   " + selectedRow.Cells(17).Value.ToString + "   " + selectedRow.Cells(22).Value.ToString
            txtboxdrugid.Text = selectedRow.Cells(2).Value.ToString
            'TextBoxHowtouse.Text = selectedRow.Cells(8).Value.ToString
            'TextBoxOtherInf.Text = selectedRow.Cells(9).Value.ToString
        Catch ex As Exception
            MsgBox("Ctrl + C to copy patient details from database", MsgBoxStyle.Information)
        End Try
        'Else
        'MsgBox("Dispense Failed")
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If vld(TextBoxCNum, TextBoxPNam, TextBoxMedid, DateTimePickerdispDate) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
            'End If
            'If IsConfirm("Do you want to dispense ?") Then
        Else
            '-----------------  dispby detail---------------------------------------------------------
            'Try
            cnp.Open()
                Dim dispby As String = Mainmenu.lblusername.Text 'userName.ToString()
                Dim cmddiag = New SqlCommand("select * from physiciantbl WHERE name = '" & dispby & "'", cnp)
                Dim dr = cmddiag.ExecuteReader()
                If (dr.HasRows) Then
                    While (dr.Read())
                        'Mainmenu.txtlblusername.Text = dr("name").ToString()
                        Dim dispnby = dr("name").ToString()
                    Dim dispbyqual = dr("qualification").ToString()
                    Dim disp As String = "dispensed"
                    Dim dispeidby As String = Mainmenu.lblEID.Text 'employeeid.ToString()
                    Dim updatequery As String = "update prescriptiontbl set dispensereid = '" & dispeidby & "', giveoutstatus = '" & disp & "',dispensername = '" & dispnby & "', dispenserqualification = '" & dispbyqual & "',dispenseddate = '" & DateTimePickerdispDate.Value.ToShortDateString() & "' where drugid='" & txtboxdrugid.Text & "'"
                    ' Dim updatequeryph As String = "update pharmstoretbl set availablebalance = availablebalance-1 where reqid='" & txtboxdrugid.Text & "'"
                    InsertUpdateDelete(updatequery)
                    ' InsertUpdateDelete(updatequeryph)
                    MessageBox.Show("Successfully dispensed !", "Data updated - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("Successfully updated!"
                End While
                    dr.Close()
                    cnp.Close()
                End If
                'Catch ex As Exception
                '  MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
                'End Try
                '-------------------------------end  dispby detail -----------------------------------------------------------
                TextBoxCNum.Clear()
            TextBoxPNam.Clear()
            txtboxdrugid.Clear()
            'TextBoxOtherInf.Clear()
            TextBoxMedid.Clear()
            TextBoxCNum.Focus()
            'Else
            ' MsgBox("Dispense Failed")
        End If
    End Sub
    Private Sub DataGridViewforPrescreq_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewforPrescreq.CellFormatting
        DataGridViewforPrescreq.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub
End Class