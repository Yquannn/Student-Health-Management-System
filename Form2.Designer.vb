<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        Label4 = New Label()
        password = New TextBox()
        Label3 = New Label()
        email = New TextBox()
        Label1 = New Label()
        status = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.Green
        LinkLabel1.Location = New Point(254, 302)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(142, 17)
        LinkLabel1.TabIndex = 17
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "don't have an account?"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Location = New Point(254, 339)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 38)
        Button1.TabIndex = 16
        Button1.Text = "Log  in"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(132, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 21)
        Label4.TabIndex = 15
        Label4.Text = "Password:"
        ' 
        ' password
        ' 
        password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        password.Location = New Point(217, 193)
        password.Name = "password"
        password.PlaceholderText = "Enter your password"
        password.Size = New Size(270, 29)
        password.TabIndex = 14
        password.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(132, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 13
        Label3.Text = "Email:"
        ' 
        ' email
        ' 
        email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        email.Location = New Point(217, 138)
        email.Name = "email"
        email.PlaceholderText = "Enter your email"
        email.Size = New Size(270, 29)
        email.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(281, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 32)
        Label1.TabIndex = 9
        Label1.Text = "Log in"
        ' 
        ' status
        ' 
        status.AutoSize = True
        status.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        status.ForeColor = Color.Red
        status.Location = New Point(217, 236)
        status.Name = "status"
        status.Size = New Size(0, 17)
        status.TabIndex = 18
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = My.Resources.Resources.close_eye
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(493, 194)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 28)
        Button2.TabIndex = 19
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(629, 418)
        Controls.Add(Button2)
        Controls.Add(status)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(password)
        Controls.Add(Label3)
        Controls.Add(email)
        Controls.Add(Label1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents status As Label
    Friend WithEvents Button2 As Button
End Class
