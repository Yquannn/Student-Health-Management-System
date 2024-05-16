<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentInformation
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(studentInformation))
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        dateNow = New Label()
        status = New Label()
        id = New TextBox()
        Button5 = New Button()
        Button10 = New Button()
        Label17 = New Label()
        qrId = New PictureBox()
        birthday = New DateTimePicker()
        Label16 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        studName = New TextBox()
        Label15 = New Label()
        contactNo = New TextBox()
        Label1 = New Label()
        messages = New TextBox()
        Label14 = New Label()
        relationship = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        studentCourse = New TextBox()
        Label11 = New Label()
        studentMedHistory = New TextBox()
        studentDepartment = New ComboBox()
        Label10 = New Label()
        parentName = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        studentNumber = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        email = New TextBox()
        Label4 = New Label()
        studentAge = New TextBox()
        Label3 = New Label()
        address = New TextBox()
        Label2 = New Label()
        TabPage2 = New TabPage()
        status1 = New Label()
        Button6 = New Button()
        Button7 = New Button()
        Label26 = New Label()
        temp = New TextBox()
        Label25 = New Label()
        medication = New TextBox()
        Label24 = New Label()
        cc = New TextBox()
        Label23 = New Label()
        bp = New TextBox()
        Label21 = New Label()
        rr = New TextBox()
        pr = New TextBox()
        Label22 = New Label()
        Label20 = New Label()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(qrId, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(-6, -6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 108)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel2.Location = New Point(12, 117)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(963, 24)
        Panel2.TabIndex = 64
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.wis_removebg_preview
        PictureBox1.Location = New Point(214, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(573, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = My.Resources.Resources.close
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(934, 23)
        Button2.Name = "Button2"
        Button2.Size = New Size(47, 47)
        Button2.TabIndex = 0
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 117)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(963, 592)
        TabControl1.TabIndex = 63
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(dateNow)
        TabPage1.Controls.Add(status)
        TabPage1.Controls.Add(id)
        TabPage1.Controls.Add(Button5)
        TabPage1.Controls.Add(Button10)
        TabPage1.Controls.Add(Label17)
        TabPage1.Controls.Add(qrId)
        TabPage1.Controls.Add(birthday)
        TabPage1.Controls.Add(Label16)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(Button3)
        TabPage1.Controls.Add(Button4)
        TabPage1.Controls.Add(studName)
        TabPage1.Controls.Add(Label15)
        TabPage1.Controls.Add(contactNo)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(messages)
        TabPage1.Controls.Add(Label14)
        TabPage1.Controls.Add(relationship)
        TabPage1.Controls.Add(Label13)
        TabPage1.Controls.Add(Label12)
        TabPage1.Controls.Add(studentCourse)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(studentMedHistory)
        TabPage1.Controls.Add(studentDepartment)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(parentName)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(studentNumber)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(email)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(studentAge)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(address)
        TabPage1.Controls.Add(Label2)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(955, 564)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' dateNow
        ' 
        dateNow.AutoSize = True
        dateNow.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dateNow.Location = New Point(176, 378)
        dateNow.Name = "dateNow"
        dateNow.Size = New Size(0, 21)
        dateNow.TabIndex = 104
        ' 
        ' status
        ' 
        status.AutoSize = True
        status.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        status.Location = New Point(613, 468)
        status.Name = "status"
        status.Size = New Size(0, 21)
        status.TabIndex = 103
        ' 
        ' id
        ' 
        id.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        id.Location = New Point(276, 7)
        id.Name = "id"
        id.Size = New Size(98, 29)
        id.TabIndex = 102
        id.Visible = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = SystemColors.Window
        Button5.Location = New Point(646, 512)
        Button5.Name = "Button5"
        Button5.Size = New Size(119, 40)
        Button5.TabIndex = 101
        Button5.Text = "Save"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Transparent
        Button10.BackgroundImageLayout = ImageLayout.Stretch
        Button10.Cursor = Cursors.Hand
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatStyle = FlatStyle.Flat
        Button10.ForeColor = SystemColors.ActiveCaptionText
        Button10.Image = CType(resources.GetObject("Button10.Image"), Image)
        Button10.ImageAlign = ContentAlignment.MiddleLeft
        Button10.Location = New Point(850, 399)
        Button10.Name = "Button10"
        Button10.Size = New Size(38, 31)
        Button10.TabIndex = 100
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(20, 427)
        Label17.Name = "Label17"
        Label17.Size = New Size(68, 21)
        Label17.TabIndex = 97
        Label17.Text = "Qr code:"
        ' 
        ' qrId
        ' 
        qrId.BackColor = Color.WhiteSmoke
        qrId.BackgroundImageLayout = ImageLayout.Stretch
        qrId.Location = New Point(176, 426)
        qrId.Name = "qrId"
        qrId.Size = New Size(125, 113)
        qrId.SizeMode = PictureBoxSizeMode.CenterImage
        qrId.TabIndex = 96
        qrId.TabStop = False
        ' 
        ' birthday
        ' 
        birthday.Location = New Point(176, 338)
        birthday.Name = "birthday"
        birthday.Size = New Size(248, 23)
        birthday.TabIndex = 95
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(20, 340)
        Label16.Name = "Label16"
        Label16.Size = New Size(71, 21)
        Label16.TabIndex = 94
        Label16.Text = "Birthday:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Maroon
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.Window
        Button1.Location = New Point(530, 512)
        Button1.Name = "Button1"
        Button1.Size = New Size(98, 40)
        Button1.TabIndex = 93
        Button1.Text = "Set body  info"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkOrange
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.Window
        Button3.Location = New Point(333, 496)
        Button3.Name = "Button3"
        Button3.Size = New Size(69, 43)
        Button3.TabIndex = 91
        Button3.Text = "Print QRcode"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Gold
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.Window
        Button4.Location = New Point(780, 512)
        Button4.Name = "Button4"
        Button4.Size = New Size(119, 40)
        Button4.TabIndex = 90
        Button4.Text = "Update"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' studName
        ' 
        studName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        studName.Location = New Point(176, 54)
        studName.Name = "studName"
        studName.PlaceholderText = "Student Name"
        studName.Size = New Size(248, 29)
        studName.TabIndex = 89
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(526, 182)
        Label15.Name = "Label15"
        Label15.Size = New Size(139, 21)
        Label15.TabIndex = 88
        Label15.Text = "Parent Contact No."
        ' 
        ' contactNo
        ' 
        contactNo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        contactNo.Location = New Point(682, 174)
        contactNo.Name = "contactNo"
        contactNo.PlaceholderText = "Contact Number"
        contactNo.Size = New Size(162, 29)
        contactNo.TabIndex = 87
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(526, 250)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 21)
        Label1.TabIndex = 86
        Label1.Text = "Messages:"
        ' 
        ' messages
        ' 
        messages.Location = New Point(530, 284)
        messages.Multiline = True
        messages.Name = "messages"
        messages.Size = New Size(369, 157)
        messages.TabIndex = 85
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(526, 99)
        Label14.Name = "Label14"
        Label14.Size = New Size(99, 21)
        Label14.TabIndex = 84
        Label14.Text = "Relationship:"
        ' 
        ' relationship
        ' 
        relationship.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        relationship.Location = New Point(682, 91)
        relationship.Name = "relationship"
        relationship.PlaceholderText = "Relationship"
        relationship.Size = New Size(248, 29)
        relationship.TabIndex = 83
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(20, 378)
        Label13.Name = "Label13"
        Label13.Size = New Size(108, 21)
        Label13.TabIndex = 81
        Label13.Text = "Date admitted"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(20, 305)
        Label12.Name = "Label12"
        Label12.Size = New Size(119, 21)
        Label12.TabIndex = 80
        Label12.Text = "Student Course:"
        ' 
        ' studentCourse
        ' 
        studentCourse.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        studentCourse.Location = New Point(176, 297)
        studentCourse.Name = "studentCourse"
        studentCourse.PlaceholderText = "Student  Course"
        studentCourse.Size = New Size(248, 29)
        studentCourse.TabIndex = 79
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(20, 258)
        Label11.Name = "Label11"
        Label11.Size = New Size(121, 21)
        Label11.TabIndex = 78
        Label11.Text = "Medical History:"
        ' 
        ' studentMedHistory
        ' 
        studentMedHistory.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        studentMedHistory.Location = New Point(176, 250)
        studentMedHistory.Name = "studentMedHistory"
        studentMedHistory.PlaceholderText = "Student Medical History"
        studentMedHistory.Size = New Size(248, 29)
        studentMedHistory.TabIndex = 77
        ' 
        ' studentDepartment
        ' 
        studentDepartment.DisplayMember = "Select"
        studentDepartment.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        studentDepartment.FormattingEnabled = True
        studentDepartment.Items.AddRange(New Object() {"SCHOOL OF ECONOMICS", "BUSINESS AND ACCOUNTANCY ", "COLLEGE OF ARTS AND SCIENCES", "COLLEGE OF ENGINEERING", "SCHOOL OF CRIMINOLOGY", "COLLEGE OF TEACHER EDUCATION", "COLLEGE OF TOURISM AND HOSPITALITY MANAGEMENT", "COLLEGE OF INFORMATION TECHNOLOGY AND COMPUTER STUDIES", "SENIOR HIGHSCHOOL/ABM", "SENIOR HIGHSCHOOL/STEM", "SENIOR HIGHSCHOOL/HUMSS", "SENIOR HIGHSCHOOL/ICT", "SENIOR HIGHSCHOOL/HOME ECONOMICS", "JUNIOR HIGHSCHOOL", "ELEMENTARY", "NKP"})
        studentDepartment.Location = New Point(176, 206)
        studentDepartment.Name = "studentDepartment"
        studentDepartment.Size = New Size(248, 29)
        studentDepartment.TabIndex = 76
        studentDepartment.Text = "Select department"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(526, 57)
        Label10.Name = "Label10"
        Label10.Size = New Size(55, 21)
        Label10.TabIndex = 75
        Label10.Text = "Name:"
        ' 
        ' parentName
        ' 
        parentName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        parentName.Location = New Point(682, 49)
        parentName.Name = "parentName"
        parentName.PlaceholderText = "Parent Name"
        parentName.Size = New Size(248, 29)
        parentName.TabIndex = 74
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(528, 11)
        Label9.Name = "Label9"
        Label9.Size = New Size(208, 25)
        Label9.TabIndex = 73
        Label9.Text = "Guardian Information"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(20, 156)
        Label8.Name = "Label8"
        Label8.Size = New Size(128, 21)
        Label8.TabIndex = 72
        Label8.Text = "Student Number:"
        ' 
        ' studentNumber
        ' 
        studentNumber.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        studentNumber.Location = New Point(176, 148)
        studentNumber.Name = "studentNumber"
        studentNumber.PlaceholderText = "Student  Number"
        studentNumber.Size = New Size(142, 29)
        studentNumber.TabIndex = 71
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(20, 204)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 21)
        Label7.TabIndex = 70
        Label7.Text = "Department:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(22, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(196, 25)
        Label6.TabIndex = 69
        Label6.Text = "Student Information"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(526, 139)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 21)
        Label5.TabIndex = 68
        Label5.Text = "Email Address:"
        ' 
        ' email
        ' 
        email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        email.Location = New Point(682, 131)
        email.Name = "email"
        email.PlaceholderText = "Enter Email"
        email.Size = New Size(248, 29)
        email.TabIndex = 67
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(20, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 21)
        Label4.TabIndex = 66
        Label4.Text = "Age:"
        ' 
        ' studentAge
        ' 
        studentAge.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        studentAge.Location = New Point(176, 96)
        studentAge.Name = "studentAge"
        studentAge.PlaceholderText = "Student Age"
        studentAge.Size = New Size(98, 29)
        studentAge.TabIndex = 65
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(526, 220)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 21)
        Label3.TabIndex = 64
        Label3.Text = "Address:"
        ' 
        ' address
        ' 
        address.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        address.Location = New Point(682, 212)
        address.Name = "address"
        address.PlaceholderText = "Parent address"
        address.Size = New Size(248, 29)
        address.TabIndex = 63
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(20, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 21)
        Label2.TabIndex = 62
        Label2.Text = "Name:"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(status1)
        TabPage2.Controls.Add(Button6)
        TabPage2.Controls.Add(Button7)
        TabPage2.Controls.Add(Label26)
        TabPage2.Controls.Add(temp)
        TabPage2.Controls.Add(Label25)
        TabPage2.Controls.Add(medication)
        TabPage2.Controls.Add(Label24)
        TabPage2.Controls.Add(cc)
        TabPage2.Controls.Add(Label23)
        TabPage2.Controls.Add(bp)
        TabPage2.Controls.Add(Label21)
        TabPage2.Controls.Add(rr)
        TabPage2.Controls.Add(pr)
        TabPage2.Controls.Add(Label22)
        TabPage2.Controls.Add(Label20)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(955, 564)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' status1
        ' 
        status1.AutoSize = True
        status1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        status1.ForeColor = Color.ForestGreen
        status1.Location = New Point(162, 379)
        status1.Name = "status1"
        status1.Size = New Size(0, 21)
        status1.TabIndex = 117
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Maroon
        Button6.ForeColor = SystemColors.Window
        Button6.Location = New Point(139, 438)
        Button6.Name = "Button6"
        Button6.Size = New Size(119, 40)
        Button6.TabIndex = 116
        Button6.Text = "Save"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button7.ForeColor = SystemColors.Window
        Button7.Location = New Point(289, 438)
        Button7.Name = "Button7"
        Button7.Size = New Size(119, 40)
        Button7.TabIndex = 115
        Button7.Text = "Update"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label26.Location = New Point(109, 305)
        Label26.Name = "Label26"
        Label26.Size = New Size(50, 21)
        Label26.TabIndex = 112
        Label26.Text = "Temp:"
        ' 
        ' temp
        ' 
        temp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        temp.Location = New Point(224, 297)
        temp.Name = "temp"
        temp.PlaceholderText = "Enter student temperature"
        temp.Size = New Size(175, 29)
        temp.TabIndex = 111
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label25.Location = New Point(109, 257)
        Label25.Name = "Label25"
        Label25.Size = New Size(103, 21)
        Label25.TabIndex = 110
        Label25.Text = "Medication/s:"
        ' 
        ' medication
        ' 
        medication.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        medication.Location = New Point(224, 249)
        medication.Name = "medication"
        medication.PlaceholderText = "Enter medication"
        medication.Size = New Size(175, 29)
        medication.TabIndex = 109
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.Location = New Point(109, 209)
        Label24.Name = "Label24"
        Label24.Size = New Size(33, 21)
        Label24.TabIndex = 108
        Label24.Text = "CC:"
        ' 
        ' cc
        ' 
        cc.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cc.Location = New Point(222, 203)
        cc.Name = "cc"
        cc.PlaceholderText = "Enter chronic condition"
        cc.Size = New Size(175, 29)
        cc.TabIndex = 107
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(109, 160)
        Label23.Name = "Label23"
        Label23.Size = New Size(31, 21)
        Label23.TabIndex = 106
        Label23.Text = "BP:"
        ' 
        ' bp
        ' 
        bp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        bp.Location = New Point(222, 157)
        bp.Name = "bp"
        bp.PlaceholderText = "Enter body pressure"
        bp.Size = New Size(175, 29)
        bp.TabIndex = 105
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label21.Location = New Point(108, 117)
        Label21.Name = "Label21"
        Label21.Size = New Size(33, 21)
        Label21.TabIndex = 104
        Label21.Text = "RR:"
        ' 
        ' rr
        ' 
        rr.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rr.Location = New Point(223, 114)
        rr.Name = "rr"
        rr.PlaceholderText = "Enter respiratory rate"
        rr.Size = New Size(175, 29)
        rr.TabIndex = 103
        ' 
        ' pr
        ' 
        pr.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pr.Location = New Point(223, 67)
        pr.Name = "pr"
        pr.PlaceholderText = "Enter pulse rate"
        pr.Size = New Size(185, 29)
        pr.TabIndex = 102
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label22.Location = New Point(108, 70)
        Label22.Name = "Label22"
        Label22.Size = New Size(32, 21)
        Label22.TabIndex = 101
        Label22.Text = "PR:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(95, 26)
        Label20.Name = "Label20"
        Label20.Size = New Size(84, 21)
        Label20.TabIndex = 100
        Label20.Text = "Vital Sign"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' studentInformation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(991, 721)
        Controls.Add(Panel2)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "studentInformation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "studentInformation"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(qrId, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents studName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents contactNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents messages As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents relationship As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents studentCourse As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents studentMedHistory As TextBox
    Friend WithEvents studentDepartment As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents parentName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents studentNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents studentAge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents temp As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents medication As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents cc As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents bp As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents rr As TextBox
    Friend WithEvents pr As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents birthday As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents status1 As Label
    Friend WithEvents qrId As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents id As TextBox
    Friend WithEvents status As Label
    Friend WithEvents dateNow As Label
    Friend WithEvents Panel2 As Panel
End Class
