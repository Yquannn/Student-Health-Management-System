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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Button1 = New Button()
        Label4 = New Label()
        pass = New TextBox()
        Label3 = New Label()
        email = New TextBox()
        status = New Label()
        Button2 = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGray
        Button1.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(259, 336)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 40)
        Button1.TabIndex = 16
        Button1.Text = "Log  in"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(182, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 21)
        Label4.TabIndex = 15
        Label4.Text = "Password:"
        ' 
        ' pass
        ' 
        pass.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        pass.Location = New Point(182, 259)
        pass.Name = "pass"
        pass.PasswordChar = "•"c
        pass.PlaceholderText = "Enter your password"
        pass.Size = New Size(270, 29)
        pass.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(182, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 13
        Label3.Text = "Email:"
        ' 
        ' email
        ' 
        email.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        email.Location = New Point(182, 193)
        email.Name = "email"
        email.PlaceholderText = "Enter your email"
        email.Size = New Size(270, 29)
        email.TabIndex = 12
        ' 
        ' status
        ' 
        status.AutoSize = True
        status.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        status.ForeColor = Color.Red
        status.Location = New Point(207, 314)
        status.Name = "status"
        status.Size = New Size(0, 17)
        status.TabIndex = 18
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.BackgroundImage = My.Resources.Resources.close_eye
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(458, 260)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 28)
        Button2.TabIndex = 19
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(636, 93)
        Panel1.TabIndex = 21
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.wis_removebg_preview
        PictureBox1.Location = New Point(28, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(573, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(267, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 32)
        Label2.TabIndex = 0
        Label2.Text = "Sign In"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(629, 418)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(status)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(pass)
        Controls.Add(Label3)
        Controls.Add(email)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents status As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
