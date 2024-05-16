Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Text
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports SendGrid
Imports SendGrid.Helpers.Mail
Imports System.Threading.Tasks
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Devices
Imports Twilio.Base


Public Class studentInformation
    Dim connection As String = "server=127.0.0.1; user=root; database=studenthealthdb; password="
    Dim Con As New MySqlConnection(connection)

    Public Property studentData As String

    Dim data As New Form3()

    Private Sub loadData()
        data.populateSchoolOfEconomics()
        data.populateAbm()
        data.populateCe()
        data.populateCitcs()
        data.populateCte()
        data.populateCthm()
        data.populateElem()
        data.populateHE()
        data.populateHumss()
        data.populateIct()
        data.populateJh()
        data.populateSchoolOfEconomics()
        data.populateSeba()
        data.populateSoc()
        data.populateStem()
        data.populateCas()



    End Sub

    Private Sub populateBodyInfo()
        Con.Open()
        Dim sql As String = "SELECT * FROM body_information"
        Dim cmd As New MySqlCommand(sql, Con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim ds As New DataSet()
        adapter.Fill(ds, "body_information") ' Corrected table name


        If ds.Tables("body_information").Rows.Count > 0 Then
            Dim row As DataRow = ds.Tables("body_information").Rows(0)
            pr.Text = row("PR").ToString()
            rr.Text = row("RR").ToString()
            bp.Text = row("BP").ToString()
            cc.Text = row("CC").ToString()
            medication.Text = row("medication").ToString()
            temp.Text = row("temp").ToString()
        End If

        Con.Close()
    End Sub




    Private Sub enableBtn()
        studName.Enabled = True
        studentAge.Enabled = True
        studentCourse.Enabled = True
        studentDepartment.Enabled = True
        studentMedHistory.Enabled = True
        studentNumber.Enabled = True
        parentName.Enabled = True
        email.Enabled = True
        relationship.Enabled = True
        address.Enabled = True
        contactNo.Enabled = True
    End Sub
    Private Sub disableBtn()
        studName.Enabled = False
        studentAge.Enabled = False
        studentCourse.Enabled = False
        studentDepartment.Enabled = False
        studentMedHistory.Enabled = False
        studentNumber.Enabled = False
        parentName.Enabled = False
        email.Enabled = False
        relationship.Enabled = False
        address.Enabled = False
        contactNo.Enabled = False

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Opacity = 1.0
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub disableVitalSignBtn()
        pr.Enabled = False
        rr.Enabled = False
        bp.Enabled = False
        cc.Enabled = False
        medication.Enabled = False
        temp.Enabled = False
    End Sub

    Private Sub enableVitalSignBtn()
        pr.Enabled = True
        rr.Enabled = True
        bp.Enabled = True
        cc.Enabled = True
        medication.Enabled = True
        temp.Enabled = True
    End Sub
    Private Sub clear()
        pr.Text = ""
        rr.Text = ""
        bp.Text = ""
        cc.Text = ""
        medication.Text = ""
        temp.Text = ""
    End Sub

    Private Sub studentInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableBtn()
        If pr.Text = "" And rr.Text = "" And bp.Text = "" And cc.Text = "" And medication.Text = "" And temp.Text = "" Then
            enableVitalSignBtn()


        Else
            disableVitalSignBtn()
        End If
        messages.Enabled = False


        loadData()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        'SendSMS("09455314645", "good morning")

        'SendEmail().Wait()
        'Try
        '    Dim Smtp_Server As New SmtpClient()
        '    Dim e_mail As New MailMessage()

        '    Smtp_Server.UseDefaultCredentials = False
        '    Smtp_Server.Credentials = New Net.NetworkCredential("clinicwestmeadinternationalsch@gmail.com", "Westmead_clinic")
        '    Smtp_Server.Port = 465
        '    Smtp_Server.EnableSsl = True
        '    Smtp_Server.Host = "smtp.gmail.com"

        '    e_mail.From = New MailAddress(txtFrom.Text)
        '    e_mail.To.Add(email2.Text)
        '    e_mail.Subject = "Email Sending"
        '    e_mail.IsBodyHtml = False
        '    e_mail.Body = messages.Text

        '    Smtp_Server.Send(e_mail)
        '    MessageBox.Show("Mail Sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        '    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage2



    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If pr.Text = "" And rr.Text = "" And bp.Text = "" And cc.Text = "" And medication.Text = "" And temp.Text = "" Then
            status1.Text = "Please complete the information"
            status1.ForeColor = Color.Red
        Else

            Try
                Dim query As String = "UPDATE student_information SET PR = @PR, RR = @RR, BP = @BP, CC = @CC, medication = @medication, temp = @temp WHERE id = @id"

                Con.Open()
                Using cmd As New MySqlCommand(query, Con)
                    cmd.Parameters.AddWithValue("@PR", pr.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@RR", rr.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@BP", bp.Text.ToUpper())  ' BP instead of BR
                    cmd.Parameters.AddWithValue("@CC", cc.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@medication", medication.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@temp", temp.Text.ToUpper())
                    cmd.Parameters.AddWithValue("@id", id.Text)

                    cmd.ExecuteNonQuery()
                End Using
                status1.Text = "Information saved successfully!!"
                loadData()
                disableVitalSignBtn()
            Catch ex As Exception
                status1.Text = "Failed to save information!!"
                status1.ForeColor = Color.Red
            Finally
                Con.Close()
            End Try

        End If



    End Sub



    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim clickedBtn As Boolean = True

        If clickedBtn Then
            enableBtn()
            status.Text = "You can edit the information!"
            status.ForeColor = Color.Orange
        End If




    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MsgBox("This feature is unavailable!", MsgBoxStyle.OkOnly, "Error")

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        disableBtn()
        Con.Open()

        Dim sql As String = "UPDATE student_information SET studentName=@studentName, age=@age, studentNumber=@studentNumber, medicalHistory=@medcert, " &
                    "course=@course, department=@department, birthday=@birthday, date=@date, guardianName=@guardianName, " &
                    "relationship=@relationship, contactNo=@contactNo, address=@address, emailAddress=@emailAddress " &
                    "WHERE id=@id"

        Using cmds As New MySqlCommand(sql, Con)
            cmds.Parameters.AddWithValue("@studentName", studName.Text.ToUpper())
            cmds.Parameters.AddWithValue("@age", studentAge.Text)
            cmds.Parameters.AddWithValue("@studentNumber", studentNumber.Text.ToUpper())
            cmds.Parameters.AddWithValue("@medcert", studentMedHistory.Text.ToUpper())
            cmds.Parameters.AddWithValue("@course", studentCourse.Text.ToUpper())
            cmds.Parameters.AddWithValue("@department", studentDepartment.Text)
            cmds.Parameters.AddWithValue("@birthday", birthday.Text)
            cmds.Parameters.AddWithValue("@date", dateNow.Text)
            cmds.Parameters.AddWithValue("@guardianName", parentName.Text.ToUpper())
            cmds.Parameters.AddWithValue("@relationship", relationship.Text.ToUpper())
            cmds.Parameters.AddWithValue("@contactNo", contactNo.Text)
            cmds.Parameters.AddWithValue("@address", address.Text.ToUpper())
            cmds.Parameters.AddWithValue("@emailAddress", email.Text.ToUpper())
            cmds.Parameters.AddWithValue("@id", id.Text)

            cmds.ExecuteNonQuery()
        End Using

        loadData()
        status.Text = "Information updated!"
        status.ForeColor = Color.Green
        Con.Close()

    End Sub

    Dim g, mg As Graphics
    Dim bmp As Bitmap

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        qrId.Width = 150
        qrId.Height = 150
        bmp = New Bitmap(qrId.Width, qrId.Height)

        mg = Graphics.FromImage(bmp)

        qrId.DrawToBitmap(bmp, New Rectangle(0, 0, qrId.Width, qrId.Height))


        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        enableVitalSignBtn()
    End Sub


    'Async Function SendEmail() As Task
    '    Try
    '        Dim apiKey As String = "YOUR_SENDGRID_API_KEY"
    '        Dim client As New SendGridClient(apiKey)

    '        Dim fromEmail As New EmailAddress("clinicwestmeadinternationalsch@gmail.com", "Westmead international school clinic")
    '        Dim toEmail As New EmailAddress("dondonbautista1223@gmail.com", "Dondon")
    '        Dim subject As String = "Test Email"
    '        Dim plainTextContent As String = "This is a test email sent using SendGrid."
    '        Dim htmlContent As String = "<strong>This is a test email sent using SendGrid.</strong>"
    '        Dim msg As New SendGridMessage With {
    '            .From = fromEmail,
    '            .Subject = subject,
    '            .PlainTextContent = plainTextContent,
    '            .HtmlContent = htmlContent
    '        }
    '        msg.AddTo(toEmail)

    '        Dim response = Await client.SendEmailAsync(msg)
    '        MsgBox("Email sent successfully")
    '    Catch ex As Exception
    '        MsgBox("An error occurred: " & ex.Message)
    '    End Try
    'End Function



    ' Function to validate email addresses (optional)

    'Private Const API_URL As String = "z1zg1x.api.infobip.com"
    'Private Const API_KEY As String = "725c10576ee06e634f7de98db091b8c7-23aebe8b-c605-403d-8d20-b37374667da1"

    'Public Sub SendSMS(ByVal phoneNumber As String, ByVal message As String)
    '    Dim request As HttpWebRequest = CType(WebRequest.Create(API_URL), HttpWebRequest)
    '    request.Method = "POST"
    '    request.Headers.Add("Authorization", "App " & API_KEY)
    '    request.ContentType = "application/json"

    '    Dim json As String = "{""from"":""YourSenderID"",""to"":""" & phoneNumber & """,""text"":""" & message & """}"

    '    Dim byteArray As Byte() = Encoding.UTF8.GetBytes(json)
    '    request.ContentLength = byteArray.Length

    '    Using dataStream As Stream = request.GetRequestStream()
    '        dataStream.Write(byteArray, 0, byteArray.Length)
    '    End Using

    '    Try
    '        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
    '        Using streamReader As New StreamReader(response.GetResponseStream())
    '            Dim responseText As String = streamReader.ReadToEnd()
    '            ' You can handle the response here
    '            Console.WriteLine(responseText)
    '        End Using
    '    Catch ex As WebException
    '        ' Handle exceptions here
    '        Console.WriteLine("An error occurred: " & ex.Message)
    '    End Try
    'End Sub

End Class