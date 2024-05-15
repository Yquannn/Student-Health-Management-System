<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        userName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        email = New TextBox()
        Label4 = New Label()
        password = New TextBox()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        Button2 = New Button()
        status = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(250, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 32)
        Label1.TabIndex = 0
        Label1.Text = "Sign Up"
        ' 
        ' userName
        ' 
        userName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        userName.Location = New Point(193, 121)
        userName.Name = "userName"
        userName.PlaceholderText = "Enter your name"
        userName.Size = New Size(270, 29)
        userName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(108, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 21)
        Label2.TabIndex = 2
        Label2.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(108, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 4
        Label3.Text = "Email:"
        ' 
        ' email
        ' 
        email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        email.Location = New Point(193, 171)
        email.Name = "email"
        email.PlaceholderText = "Enter your email"
        email.Size = New Size(270, 29)
        email.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(108, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 21)
        Label4.TabIndex = 6
        Label4.Text = "Password:"
        ' 
        ' password
        ' 
        password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        password.Location = New Point(193, 226)
        password.Name = "password"
        password.PlaceholderText = "Enter your password"
        password.Size = New Size(270, 29)
        password.TabIndex = 5
        password.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Location = New Point(238, 338)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 38)
        Button1.TabIndex = 7
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.Green
        LinkLabel1.Location = New Point(230, 308)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(148, 17)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "already has an account?"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = My.Resources.Resources.close_eye
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(469, 227)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 28)
        Button2.TabIndex = 9
        Button2.UseVisualStyleBackColor = False
        ' 
        ' status
        ' 
        status.AutoSize = True
        status.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        status.ForeColor = Color.Red
        status.Location = New Point(163, 268)
        status.Name = "status"
        status.Size = New Size(0, 13)
        status.TabIndex = 19
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-2, -6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(636, 93)
        Panel1.TabIndex = 20
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(629, 418)
        Controls.Add(Panel1)
        Controls.Add(status)
        Controls.Add(Button2)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(password)
        Controls.Add(Label3)
        Controls.Add(email)
        Controls.Add(Label2)
        Controls.Add(userName)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents userName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents status As Label
    Friend WithEvents Panel1 As Panel
End Class
