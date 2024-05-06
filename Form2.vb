Imports MySql.Data.MySqlClient

Public Class Form2
    Dim connection As String = "server=127.0.0.1; user=root; database=studenthealthdb; password="
    Dim Con As New MySqlConnection(connection)
    Dim clicked As Boolean = True
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Create an instance of the next form
        Dim nextForm As New Form1()
        ' Show the next form
        nextForm.Show()
        ' Optionally, hide the current form
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "SELECT COUNT(*) FROM register_account WHERE email = @Email AND password = @Password"


        Using command As New MySqlCommand(query, Con)
            ' Replace YourServer and YourDatabase with your server and database names

            ' Parameters to prevent SQL injection
            command.Parameters.AddWithValue("@Email", email.Text)
            command.Parameters.AddWithValue("@Password", password.Text)

            Con.Open()
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            If result > 0 Then
                MessageBox.Show("Login successful!")
                ' Redirect to another form or perform other actions here
                Me.Hide()
                Form3.Show()
            Else
                status.Text = "Invalid email or password."
            End If
            Con.Close()
        End Using


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clicked = Not clicked

        ' Set the UseSystemPasswordChar property based on the updated value of clicked
        password.UseSystemPasswordChar = Not clicked
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class