Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx.Notice


Public Class Form3

    Dim connection As String = "server=127.0.0.1; user=root; database=studenthealthdb; password="
    Dim Con As New MySqlConnection(connection)
    Dim studentId = ""

    Private Sub populateSchoolOfEconomics()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'SCHOOL OF ECONOMICS'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        studentRecord.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateSeba()
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
    Private Sub populateCas()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'COLLEGE OF ARTS AND SCIENCES'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        cas.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateCte()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'COLLEGE OF TEACHER EDUCATION'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        cte.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateSoc()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'SCHOOL OF CRIMINOLOGY'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        soc.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateCe()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'COLLEGE OF ENGINEERING'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        bsce.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateCthm()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'COLLEGE OF TOURISM AND HOSPITALITY MANAGEMENT'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        cthm.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateCitcs()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'COLLEGE OF INFORMATION TECHNOLOGY AND COMPUTER STUDIES'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        citcs.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateAbm()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'ABM'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        abm.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateStem()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'STEM'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        stem.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateHumss()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'HUMSS'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        humss.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateIct()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'ICT'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        ict.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateHE()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'HOME ECONOMICS'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        he.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateJh()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'JUNIOR HIGHSCHOOL'"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim builder As New MySqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds, "student_information")
        jh.DataSource = ds.Tables("student_information")
        Con.Close()
    End Sub
    Private Sub populateElem()
        Con.Open()
        Dim sql As String = "SELECT * FROM student_information WHERE department = 'ELEMENTARY'"
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


    End Sub

    Private Sub saveStudentInformation()
        If studentId = "" Then
            Dim myId As Guid = Guid.NewGuid()
            Dim myIdString = myId.ToString().Substring(0, 6)
            studentId = myIdString

        End If
        Try
            Dim query As String = "INSERT INTO student_information (id, studentName, age, studentNumber, department, medicalHistory, course, date) VALUES (@id, @studentName, @age, @studentNumber, @department, @medicalHistory, @course, @date)"

            Con.Open()
            Using cmd As New MySqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@id", studentId)
                cmd.Parameters.AddWithValue("@studentName", studentName.Text.ToUpper())
                cmd.Parameters.AddWithValue("@age", studentAge.Text.ToUpper())
                cmd.Parameters.AddWithValue("@studentNumber", studentNumber.Text.ToUpper()) 'assuming studentNumber is a TextBox control
                cmd.Parameters.AddWithValue("@department", studentDepartment.Text.ToUpper())
                cmd.Parameters.AddWithValue("@medicalHistory", studentMedHistory.Text.ToUpper())
                cmd.Parameters.AddWithValue("@course", studentCourse.Text.ToUpper())
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value) 'assuming DateTimePicker1 is a DateTimePicker control
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Information saved successfully.")
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub saveGuardianInformation()
        Try
            Dim query As String = "INSERT INTO guardian_information (id, name, relationship, contactNo, address) VALUES (@id, @name, @relationship, @contactNo, @address)"

            Con.Open()
            Using cmd As New MySqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@id", studentId)
                cmd.Parameters.AddWithValue("@name", parentName.Text.ToUpper())
                cmd.Parameters.AddWithValue("@relationship", relationship.Text.ToUpper()) 'assuming studentNumber is a TextBox control
                cmd.Parameters.AddWithValue("@contactNo", parentContactNo.Text.ToUpper())
                cmd.Parameters.AddWithValue("@address", address.Text.ToUpper())

                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        saveStudentInformation()
        populateSchoolOfEconomics()
        saveGuardianInformation()
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
        clear()

    End Sub

    Private Sub studentRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentRecord.CellContentClick
        Dim studenInfo As New studentInformation()

        If e.RowIndex >= 0 Then
            populateSchoolOfEconomics()
            '    Dim row As DataGridViewRow = Me.studentRecord.Rows(e.RowIndex)

            '    ' Check if the cell value is not Nothing before accessing it
            '    If row.Cells("studentName").Value IsNot Nothing Then
            '        studenInfo.studentName.Text = row.Cells("studentName").Value.ToString()
            '    End If

            '    If row.Cells("age").Value IsNot Nothing Then
            '        studenInfo.studentAge.Text = row.Cells("age").Value.ToString()
            '    End If

            '    If row.Cells("studentNumber").Value IsNot Nothing Then
            '        studenInfo.studentNumber.Text = row.Cells("studentNumber").Value.ToString()
            '    End If

            '    If row.Cells("department").Value IsNot Nothing Then
            '        studenInfo.studentDepartment.Text = row.Cells("department").Value.ToString()
            '    End If

            '    If row.Cells("medicalHistory").Value IsNot Nothing Then
            '        studenInfo.studentMedHistory.Text = row.Cells("medicalHistory").Value.ToString()
            '    End If

            '    If row.Cells("course").Value IsNot Nothing Then
            '        studenInfo.studentCourse.Text = row.Cells("course").Value.ToString()
            '    End If

            '    If row.Cells("date").Value IsNot Nothing Then
            '        studenInfo.DateTimePicker1.Text = row.Cells("date").Value.ToString()
            '    End If



            '    ' Show the studentInformation form
            '    studenInfo.Show()
        End If

        Me.Opacity = 0.75


        Dim modalForm As New studentInformation()
            Dim result As DialogResult = modalForm.ShowDialog()


            Me.Opacity = 1.0
            Me.BackColor = SystemColors.Control ' Restore the original background color

        'If result = DialogResult.OK Then
        '    MessageBox.Show("User clicked OK on the modal form.")
        'ElseIf result = DialogResult.Cancel Then
        '    MessageBox.Show("User clicked Cancel or closed the modal form.")
        'End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click



    End Sub
End Class