Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim connection As String = "server=127.0.0.1; user=root; database=studenthealthdb; password="
    Dim Con As New MySqlConnection(connection)
    Dim clicked As Boolean = True
    'Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    '    ' Create an instance of the next form
    '    Dim nextForm As New Form1()
    '    ' Show the next form
    '    nextForm.Show()
    '    ' Optionally, hide the current form
    '    Me.Hide()
    'End Sub

    Private Sub clearTxt()
        email.Text = ""
        pass.Text = ""
        status.Text = ""
    End Sub

    Public greet As String
    Private Sub Login(username As String, password As String)
        Try
            Dim query As String = "SELECT name FROM register_account WHERE email = @Username AND password = @Password"

            Con.Open()

            Using command As New MySqlCommand(query, Con)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim name As String = reader.GetString(reader.GetOrdinal("name"))

                        Dim newForm3 As New Form3

                        ' Set the color of the name part
                        newForm3.greetUser.Text = name & "!"


                        newForm3.UserEmail = name
                        newForm3.UserEmail = username
                        newForm3.UserPassword = password
                        Me.Hide()
                        newForm3.Show()
                        email.Text = ""
                        pass.Text = ""
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            End Using


            Con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login(email.Text, pass.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If clicked Then
            ' Show the password
            pass.PasswordChar = ControlChars.NullChar
            clicked = False
        Else
            ' Hide the password
            pass.PasswordChar = "•"
            clicked = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged

    End Sub
End Class