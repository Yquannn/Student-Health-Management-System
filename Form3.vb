Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx.Notice
Imports QRCoder
Imports USB_Barcode_Scanner
Public Class Form3
    WithEvents barcodeScanner As BarcodeScanner

    Dim connection As String = "server=127.0.0.1; user=root; database=studenthealthdb; password="
    Dim Con As New MySqlConnection(connection)
    Public Property studentId = ""

    Public Property UserName As String
    Public Property UserEmail As String
    Public Property UserPassword As String
    Public Sub populateSchoolOfEconomics()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'SCHOOL OF ECONOMICS' "
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        soe.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateSeba()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'BUSINESS AND ACCOUNTANCY'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        seba.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateCas()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'COLLEGE OF ARTS AND SCIENCES'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        cas.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateCte()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'COLLEGE OF TEACHER EDUCATION'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        cte.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateSoc()
        Con.Open()
        Dim sql As String = "SELECT id,qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'SCHOOL OF CRIMINOLOGY'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        soc.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateCe()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'COLLEGE OF ENGINEERING'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        bsce.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateCthm()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'COLLEGE OF TOURISM AND HOSPITALITY MANAGEMENT'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        cthm.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateCitcs()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'COLLEGE OF INFORMATION TECHNOLOGY AND COMPUTER STUDIES'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        citcs.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateAbm()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'SENIOR HIGHSCHOOL/ABM'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        abm.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateStem()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'SENIOR HIGHSCHOOL/STEM'"
        '"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        stem.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateHumss()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'SENIOR HIGHSCHOOL/HUMSS'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        humss.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateIct()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'SENIOR HIGHSCHOOL/ICT'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        ict.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateHE()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'SENIOR HIGHSCHOOL/HOME ECONOMICS'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        he.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateJh()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'JUNIOR HIGHSCHOOL'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        jh.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Public Sub populateElem()
        Con.Open()
        Dim sql As String = "SELECT id, qrcode,studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress FROM student_information WHERE department = 'ELEMENTARY'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        elem.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    'Private Sub populateGuardianInformation()
    '    Con.Open()
    '    Dim sql As String = "SELECT * FROM guardian_information"
    '    Dim cmd As New MySqlCommand(sql, Con)
    '    Dim adapter As New MySqlDataAdapter(cmd)
    '    Dim builder As New MySqlCommandBuilder(adapter)

    '    Dim ds As New DataSet()
    '    adapter.Fill(ds, "student_information")
    '    studentRecord.DataSource = ds.Tables("student_information")
    '    Con.Close()
    'End Sub

    Private Sub clear()
        studentName.Text = ""
        studentAge.Text = ""
        studentCourse.Text = ""
        studentDepartment.Text = ""
        studentMedHistory.Text = ""
        studentNumber.Text = ""
        studentId = ""
        parentName.Text = ""
        parentContactNo.Text = ""
        relationship.Text = ""
        address.Text = ""
        emailAddress.Text = ""
        qrId.Image = Nothing
        'address.Text = ""
        'statusLabel.Text = ""

    End Sub

    Private Sub saveStudentInformation()

        Try
            Dim query As String = "INSERT INTO student_information (id, qrcode, studentName, age, studentNumber, department, medicalHistory, course, birthday, date, guardianName, relationship, contactNo, address, emailAddress) VALUES (@id, @qrcode, @studentName, @age, @studentNumber, @department, @medicalHistory, @course, @birthday, NOW(), @guardianName, @relationship, @contactNo, @address, @emailadd)"

            Con.Open()
            Using cmd As New MySqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@id", studentId)
                cmd.Parameters.AddWithValue("@qrcode", ImageToBase64(qrId.Image, System.Drawing.Imaging.ImageFormat.Png))
                cmd.Parameters.AddWithValue("@studentName", studentName.Text.ToUpper())
                cmd.Parameters.AddWithValue("@age", studentAge.Text.ToUpper())
                cmd.Parameters.AddWithValue("@studentNumber", studentNumber.Text.ToUpper()) 'assuming studentNumber is a TextBox control
                cmd.Parameters.AddWithValue("@department", studentDepartment.Text.ToUpper())
                cmd.Parameters.AddWithValue("@medicalHistory", studentMedHistory.Text.ToUpper())
                cmd.Parameters.AddWithValue("@course", studentCourse.Text.ToUpper())

                cmd.Parameters.AddWithValue("@birthday", DateTimePicker1.Value.Date) ' Assuming you only need the date part
                cmd.Parameters.AddWithValue("@guardianName", parentName.Text.ToUpper())
                cmd.Parameters.AddWithValue("@relationship", relationship.Text.ToUpper()) 'assuming studentNumber is a TextBox control
                cmd.Parameters.AddWithValue("@contactNo", parentContactNo.Text)
                cmd.Parameters.AddWithValue("@address", address.Text)
                cmd.Parameters.AddWithValue("@emailadd", emailAddress.Text)
                cmd.ExecuteNonQuery()
            End Using
            statusLabel.Text = "Information saved Successfully!!"
        Catch ex As Exception
            statusLabel.Text = "Failed to save information!!"
        Finally
            Con.Close()
        End Try


    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
    Private lastCheckTime As DateTime = DateTime.MinValue ' Initialize the last check time

    Private Sub CheckForNewRecords()
        ' Calculate the date 7 days ago from now
        Dim dateSevenDaysAgo As DateTime = DateTime.Now.AddDays(-3)

        Dim query As String = "SELECT COUNT(*) FROM student_information WHERE date >= @date"

        Con.Open()

        Using command As New MySqlCommand(query, Con)
            ' Use the calculated dateSevenDaysAgo
            command.Parameters.AddWithValue("@date", dateSevenDaysAgo)

            Dim newRecordCount As Integer = Convert.ToInt32(command.ExecuteScalar())
            patientCount.Text = newRecordCount.ToString()

            ' Update lastCheckTime for future reference if needed
            lastCheckTime = DateTime.Now
        End Using

        Con.Close()
    End Sub

    Private Sub renewPlaceholder()
        If searchStudent.Text = "" Then
            searchStudent.PlaceholderText = "search"
        End If
    End Sub

    Private Sub countOfStudent()
        Dim query As String = "SELECT COUNT(*) FROM student_information"
        Con.Open()

        Using command As New MySqlCommand(query, Con)
            Dim totalRecords As Integer = Convert.ToInt32(command.ExecuteScalar())
            studentCount.Text = totalRecords.ToString()
        End Using
        Con.Close()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = TabPage20


        'barcodeScanner = New BarcodeScanner(searchStudent)

        CheckForNewRecords()
        countOfStudent()
        populateSchoolOfEconomics()
        populateAbm()
        populateCe()
        populateCitcs()
        populateCte()
        populateCthm()
        populateElem()
        populateHE()
        populateHumss()
        populateIct()
        populateJh()
        populateSchoolOfEconomics()
        populateSeba()
        populateSoc()
        populateStem()

        populateCas()


    End Sub

    Private Sub generateQrId()

        If studentId = "" Then
            Dim myId As Guid = Guid.NewGuid()
            Dim myIdString = myId.ToString().Substring(0, 6)
            studentId = myIdString

        End If
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(studentId, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        qrId.Image = code.GetGraphic(6)
    End Sub


    Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Dim ms As New MemoryStream
        image.Save(ms, format)
        Dim imageByte() As Byte = ms.ToArray()
        Dim base64String As String = Convert.ToBase64String(imageByte)
        Return base64String
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If studentName.Text = "" AndAlso studentAge.Text = "" AndAlso studentNumber.Text = "" AndAlso studentDepartment.SelectedIndex = -1 AndAlso
            studentMedHistory.Text = "" AndAlso studentCourse.Text = "" AndAlso parentName.Text = "" AndAlso relationship.Text = "" AndAlso
            emailAddress.Text = "" AndAlso parentContactNo.Text = "" AndAlso address.Text = "" Then

            statusLabel.ForeColor = Color.Red
            statusLabel.Text = "Please complete the information"
        Else

            saveStudentInformation()
            populateSchoolOfEconomics()
            populateAbm()
            populateCe()
            populateCitcs()
            populateCte()
            populateCthm()
            populateElem()
            populateHE()
            populateHumss()
            populateIct()
            populateJh()
            populateSeba()
            populateSoc()
            populateStem()
            populateCas()
            CheckForNewRecords()
            countOfStudent()
            clear()
            recentActivities.Add("•Register Student" & DateTime.Now.ToString("HH:mm:ss"))

            ' Ensure only the latest 4 activities are kept
            If recentActivities.Count > 4 Then
                recentActivities.RemoveAt(0)
            End If

            ' Update the labels
            UpdateActivityLabels()

        End If


    End Sub

    Public Property id = ""
    Private Sub getStudentData(e)
        Dim studentInfo As New studentInformation()

        Dim row As DataGridViewRow = Me.soe.Rows(e.RowIndex)

        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using

        studentInfo.id.Text = row.Cells("id").Value.ToString()

        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.pr.Text = row.Cells("pr").Value.ToString()
        studentInfo.rr.Text = row.Cells("rr").Value.ToString()
        studentInfo.bp.Text = row.Cells("bp").Value.ToString()
        studentInfo.cc.Text = row.Cells("cc").Value.ToString()
        studentInfo.medication.Text = row.Cells("medication").Value.ToString()

        studentInfo.temp.Text = row.Cells("temp").Value.ToString()



        studentInfo.Show()

    End Sub

    Private Sub studentRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles soe.CellContentClick

        getStudentData(e)




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form2.Show()


    End Sub

    Private Sub TabPage18_Click(sender As Object, e As EventArgs) Handles TabPage18.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = TabPage18
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()
    End Sub






    Private Sub seba_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles seba.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.seba.Rows(e.RowIndex)

        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub cas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles cas.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.cas.Rows(e.RowIndex)

        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles dueDate.ValueChanged
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles purpose.TextChanged
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles dateIssue.ValueChanged
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
    End Sub

    Private Sub calculateBmi()


        If height.Text = "" And weight.Text = "" Then
            MsgBox("Please enter your height and weight!")
        Else


            PictureBox1.Top = 0
            PictureBox1.Left = (Me.Width - PictureBox1.Width) / 2
            medcert.Controls.Add(PictureBox1)


            medcert.AppendText("                                               Westmead International School - Clinic               " & vbCrLf)
            medcert.AppendText("                                                         +639086555521                                 " & vbCrLf)
            medcert.AppendText("        Comet St., Golden Country Homes Subdivision, Alangilan 4200 Batangas City" & vbCrLf & vbCrLf)

            Dim pName As String = patientName.Text
            Dim pAge As String = age.Text
            Dim pGender As String = gender.Text
            Dim pAddress As String = address.Text

            Dim h, w, result As Double
            h = height.Text
            w = weight.Text
            h = h / 100

            result = w / (h * h)
            result = Math.Round(result, 1)
            bmiResult.Text = result.ToString()

            ' Determine BMI status
            'Dim bmiStatus1 As String = ""
            If result <= 18.5 Then
                bmiStatus.Text = "Under Weight"
                bmiStatus.ForeColor = Color.Yellow
            ElseIf result >= 18.6 AndAlso result <= 24.9 Then
                bmiStatus.Text = "Normal"
                bmiStatus.ForeColor = Color.Green
            ElseIf result >= 25.0 AndAlso result <= 29.9 Then
                bmiStatus.Text = "Over Weight"
                bmiStatus.ForeColor = Color.Orange
            ElseIf result >= 30.0 Then
                bmiStatus.Text = "Obese"
                bmiStatus.ForeColor = Color.Red
            End If

            ' Retrieve purpose and date of issue
            Dim purp As String = purpose.Text
            Dim dateOfIssue As String = dateIssue.Text
            'Dim doctorName = "Dr. Piolo Gutierrez"

            ' Date of BMI calculation
            Dim dateOfBMI As String = Date.Now.ToShortDateString()

            ' Append patient information and certificate details to the RichTextBox
            medcert.AppendText("This is to certify " & pName.ToUpper & " " & pAge & " years oldhas undergone a medical examination at Westmead International Schools' clinic")
            medcert.AppendText(" on " & dateOfIssue & ". The following requirements were obtained:" & vbCrLf & vbCrLf)

            medcert.AppendText("             • BMI: " & result.ToString("F2") & " (" & bmiStatus.Text & ")" & vbCrLf)
            medcert.AppendText("             •Height: " & height.Text & " cm" & vbCrLf)
            medcert.AppendText("             •Weight: " & weight.Text & " kg" & vbCrLf & vbCrLf)

            medcert.AppendText("Based on the examination these measurements, " & gender.Text & "is deemed medically " & purp.ToUpper & vbCrLf & vbCrLf)
            medcert.AppendText("Remarks: " & purp.ToUpper & vbCrLf & vbCrLf)


            medcert.AppendText("This medical Certificate is valid from: " & dateOfIssue & "to" & dueDate.Text)
            medcert.AppendText("This certificate is being issued upon the request of the above-mentioned for whatever purpose if may serve, except of those of medico-legal-nature.")
            medcert.AppendText("I HEREBY CERTIFY that the information provided in this form is complete, true and correct to the best of my knowledge." & vbCrLf & vbCrLf & vbCrLf)

            ' Add doctor's signature
            medcert.AppendText("Signature: ___________________" & vbCrLf)
            medcert.AppendText("Dr." & docName.Text.ToUpper & vbCrLf)

            medcert.AppendText("Date: " & DateTime.Now.ToShortDateString() & vbCrLf & vbCrLf & vbCrLf)
            medcert.AppendText("Disclaimer:This document not to be copied, modified or reproduced in any way without the express written permission of the issuing party: This document shall not be used for medicolegal
purposes")
        End If



    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        calculateBmi()


    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles medcert.TextChanged

    End Sub



    Private Sub Button12_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = TabPage1

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = TabPage19

    End Sub

    Private Sub stem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles stem.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.stem.Rows(e.RowIndex)


        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub bsce_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bsce.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.bsce.Rows(e.RowIndex)

        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub soc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles soc.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.soc.Rows(e.RowIndex)

        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub cte_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles cte.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.cte.Rows(e.RowIndex)


        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub cthm_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles cthm.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.cthm.Rows(e.RowIndex)


        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub citcs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles citcs.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.citcs.Rows(e.RowIndex)

        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub abm_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles abm.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.abm.Rows(e.RowIndex)

        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub humss_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles humss.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.humss.Rows(e.RowIndex)


        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub ict_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ict.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.ict.Rows(e.RowIndex)



        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub he_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles he.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.he.Rows(e.RowIndex)

        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub jh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles jh.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.jh.Rows(e.RowIndex)

        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub elem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles elem.CellContentClick
        Dim studentInfo As New studentInformation()


        Dim row As DataGridViewRow = Me.elem.Rows(e.RowIndex)

        Dim base64String As String = row.Cells("qrcode").Value.ToString()

        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Using ms As New MemoryStream(imageBytes)
            studentInfo.qrId.Image = Image.FromStream(ms)
        End Using
        Dim name = row.Cells("studentName").Value.ToString()
        studentInfo.studName.Text = name
        studentInfo.studentAge.Text = row.Cells("age").Value.ToString()
        studentInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
        studentInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
        studentInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
        studentInfo.studentCourse.Text = row.Cells("course").Value.ToString()
        studentInfo.birthday.Text = row.Cells("birthday").Value.ToString()
        studentInfo.dateNow.Text = row.Cells("date").Value.ToString()
        studentInfo.parentName.Text = row.Cells("guardianName").Value.ToString()
        studentInfo.relationship.Text = row.Cells("relationship").Value.ToString()
        studentInfo.contactNo.Text = row.Cells("contactNo").Value.ToString()
        studentInfo.address.Text = row.Cells("address").Value.ToString()
        studentInfo.email.Text = row.Cells("emailAddress").Value.ToString()
        studentInfo.Show()

        'Me.Opacity = 0.8
        'Me.BackColor = SystemColors.Control
    End Sub

    Private Sub studentName_Click(sender As Object, e As EventArgs) Handles studentName.Click
        generateQrId()
    End Sub

    Private Sub docName_Click(sender As Object, e As EventArgs) Handles docName.Click

    End Sub

    Dim g, mg As Graphics
    Dim bmp As Bitmap
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)

    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        bmp = New Bitmap(medcert.Width, medcert.Height)

        mg = Graphics.FromImage(bmp)

        medcert.DrawToBitmap(bmp, New Rectangle(0, 0, medcert.Width, medcert.Height))


        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

        recentActivities.Add("•Print med cert " & DateTime.Now.ToString("HH:mm:ss"))

        ' Ensure only the latest 4 activities are kept
        If recentActivities.Count > 4 Then
            recentActivities.RemoveAt(0)
        End If

        patientName.Text = ""
        age.Text = ""
        patientAddress.Text = ""
        height.Text = ""
        weight.Text = ""
        purpose.Text = ""
        dueDate.Text = ""
        docName.Text = ""
        bmiResult.Text = ""
        bmiStatus.Text = ""
        gender.Text = ""
        UpdateActivityLabels()

    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        TabControl1.SelectedTab = TabPage1
        renewPlaceholder()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabPage2
        renewPlaceholder()

        ' Add a new activity (for simplicity, using a timestamp as the activity)
        recentActivities.Add("•View Record " & DateTime.Now.ToString("HH:mm:ss"))

        ' Ensure only the latest 4 activities are kept
        If recentActivities.Count > 4 Then
            recentActivities.RemoveAt(0)
        End If

        ' Update the labels
        UpdateActivityLabels()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectedTab = TabPage18

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage19
        renewPlaceholder()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = TabPage20
        renewPlaceholder()
    End Sub

    Private Sub studentAge_Click(sender As Object, e As EventArgs) Handles studentAge.Click
        generateQrId()
    End Sub



    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub greetUser_Click(sender As Object, e As EventArgs) Handles greetUser.Click

    End Sub

    Private Sub Guna2CustomGradientPanel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel3.Paint

    End Sub

    Private Sub barcodeScanner_BarcodeScanned(sender As Object, e As BarcodeScannerEventArgs) Handles barcodeScanner.BarcodeScanned
        searchStudent.Text = e.Barcode
    End Sub

    Private Sub searchStudent_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub searchStudent_TextChanged_1(sender As Object, e As EventArgs) Handles searchStudent.TextChanged
        Dim query As String = "SELECT * FROM student_information WHERE id LIKE @id OR studentName LIKE @name"

        ' Open the database connection
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If

        Using cmd As New MySqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@id", "%" & searchStudent.Text & "%")
            cmd.Parameters.AddWithValue("@name", "%" & searchStudent.Text & "%")

            Using da As New MySqlDataAdapter(cmd)
                Using dt As New DataTable()
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        ' Bind the data to the DataGridView
                        soe.DataSource = dt
                        seba.DataSource = dt
                        cas.DataSource = dt
                        bsce.DataSource = dt
                        soc.DataSource = dt
                        cte.DataSource = dt
                        cthm.DataSource = dt
                        abm.DataSource = dt
                        stem.DataSource = dt
                        humss.DataSource = dt
                        ict.DataSource = dt
                        he.DataSource = dt
                        jh.DataSource = dt
                        elem.DataSource = dt
                        TabPage2.Show()

                    Else
                        searchStudent.Text = ""
                        MsgBox("Record not found!")
                    End If
                End Using
            End Using
        End Using

        ' Close the database connection
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

    Private Sub TabPage19_Click(sender As Object, e As EventArgs) Handles TabPage19.Click

    End Sub


    Private Sub newPassword_Click(sender As Object, e As EventArgs) Handles newPassword.Click

    End Sub
    Dim passwordMatch As Boolean
    Dim containsSpecialChar As Boolean = False

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' Ensure password validation flags are correctly set
        passwordMatch = (oldPassword.Text = UserPassword)

        If Not passwordMatch Then
            oldPassswordStatus.Text = "Password not match!"
            oldPassswordStatus.ForeColor = Color.Red
        ElseIf Not containsSpecialChar Then
            status.Text = "Password must contain at least one special character and have a minimum length of 6 characters."
        Else
            Try
                Dim query As String = "UPDATE register_account SET name = @NewName, email = @NewEmail, password = @NewPassword WHERE email = @OldEmail AND password = @OldPassword"

                ' Open the database connection
                Con.Open()

                Using command As New MySqlCommand(query, Con)
                    ' Parameters for the update query
                    command.Parameters.AddWithValue("@NewName", newName.Text)
                    command.Parameters.AddWithValue("@NewEmail", newEmail.Text)
                    command.Parameters.AddWithValue("@NewPassword", newPassword.Text)

                    ' Parameters for identifying the record to update
                    command.Parameters.AddWithValue("@OldEmail", UserEmail)
                    command.Parameters.AddWithValue("@OldPassword", UserPassword)

                    ' Execute the update query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Update successful")
                        newName.Text = ""
                        newEmail.Text = ""
                        oldPassword.Text = ""
                        newPassword.Text = ""
                        oldPassswordStatus.Text = ""
                        status.Text = ""
                        recentActivities.Add("•Updated Account " & DateTime.Now.ToString("HH:mm:ss"))

                        ' Ensure only the latest 4 activities are kept
                        If recentActivities.Count > 4 Then
                            recentActivities.RemoveAt(0)
                        End If

                        ' Update the labels
                        UpdateActivityLabels()

                    Else
                        MessageBox.Show("No records updated. User with old email and password not found.")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                ' Ensure the database connection is closed
                Con.Close()
            End Try
        End If
    End Sub

    Private Sub newPassword_TextChanged(sender As Object, e As EventArgs) Handles newPassword.TextChanged
        Dim specialChars As String = "@!#$%^&*()-_+= {}[]|\\:;""'<>,./?~`¢£€¥µ"
        containsSpecialChar = newPassword.Text.Any(Function(c) specialChars.Contains(c)) And newPassword.Text.Length >= 6

        If Not containsSpecialChar Then
            status.Text = "Password must contain at least one special character and have a
minimum length of 6 characters."
        Else
            status.Text = "Strong password!"
            status.ForeColor = Color.Green
        End If
    End Sub

    Private Sub oldPassword_TextChanged(sender As Object, e As EventArgs) Handles oldPassword.TextChanged
        If oldPassword.Text <> UserPassword Then
            oldPassswordStatus.Text = "Password not match!"
            oldPassswordStatus.ForeColor = Color.Red
            passwordMatch = False
        Else
            oldPassswordStatus.Text = "Password Match!"
            oldPassswordStatus.ForeColor = Color.Green
            passwordMatch = True
        End If
    End Sub

    Dim clicked As Boolean = True
    Dim clicked2 As Boolean = True
    Dim clicked3 As Boolean = True
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        If clicked Then
            ' Show the password
            oldPassword.PasswordChar = ControlChars.NullChar
            clicked = False
        Else
            ' Hide the password
            oldPassword.PasswordChar = "•"
            clicked = True
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If clicked2 Then
            ' Show the password
            newPassword.PasswordChar = ControlChars.NullChar
            clicked2 = False
        Else
            ' Hide the password
            newPassword.PasswordChar = "•"
            clicked2 = True
        End If
    End Sub
    Private recentActivities As New List(Of String)

    ' Method to update the labels with recent activities
    Private Sub UpdateActivityLabels()
        ' Clear the labels first
        lblActivity1.Text = "No activity"
        lblActivity2.Text = "No activity"
        lblActivity3.Text = "No activity"
        lblActivity4.Text = "No activity"
        lblActivity5.Text = "No activity"

        ' Display the most recent activities
        Dim count As Integer = recentActivities.Count
        If count > 0 Then lblActivity1.Text = recentActivities(count - 1)
        If count > 1 Then lblActivity2.Text = recentActivities(count - 2)
        If count > 2 Then lblActivity3.Text = recentActivities(count - 3)
        If count > 3 Then lblActivity4.Text = recentActivities(count - 4)
        If count > 4 Then lblActivity5.Text = recentActivities(count - 5)
    End Sub

    Dim containsSpecialChar2 As Boolean = False
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Not containsSpecialChar2 Then
        Else
            createNewAccount()
        End If


        recentActivities.Add("•Created Account " & DateTime.Now.ToString("HH:mm:ss"))

        ' Ensure only the latest 4 activities are kept
        If recentActivities.Count > 5 Then
            recentActivities.RemoveAt(0)
        End If

        ' Update the labels
        UpdateActivityLabels()


    End Sub

    Private Sub createNewAccount()


        Try
            Dim query As String = "INSERT INTO register_account (name, email, password) VALUES (@name, @email, @password)"

            Con.Open()
            Using cmd As New MySqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@name", createName.Text)
                cmd.Parameters.AddWithValue("@email", createEmail.Text)
                cmd.Parameters.AddWithValue("@password", createPass.Text)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("account created")
            createName.Text = ""
            createPass.Text = ""
            createEmail.Text = ""
            createAccStatus.Text = ""
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Private Sub createPass_TextChanged(sender As Object, e As EventArgs) Handles createPass.TextChanged
        Dim specialChars As String = "@!#$%^&*()-_+= {}[]|\\:;""'<>,./?~`¢£€¥µ"
        containsSpecialChar2 = createPass.Text.Any(Function(c) specialChars.Contains(c)) And createPass.Text.Length >= 6

        If Not containsSpecialChar2 Then
            createAccStatus.Text = "Password must contain at least one special character and have a
minimum length of 6 characters."
        Else
            createAccStatus.Text = "Strong password!"
            createAccStatus.ForeColor = Color.Green
        End If

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If clicked Then
            ' Show the password
            createPass.PasswordChar = ControlChars.NullChar
            clicked = False
        Else
            ' Hide the password
            createPass.PasswordChar = "•"
            clicked = True
        End If
    End Sub

    Private Sub Guna2CustomGradientPanel12_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel12.Paint

    End Sub
End Class