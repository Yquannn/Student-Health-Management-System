Imports MySql.Data.MySqlClient

Public Class Form1

    Dim connection As String = "server=127.0.0.1; user=root; database=studenthealthdb; password="
    Dim Con As New MySqlConnection(connection)
    Dim clicked As Boolean = True
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles userName.TextChanged

    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim nextForm As New Form2()

        nextForm.Show()

        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim containsSpecialChar As Boolean = False
        Dim specialChar() As String = {"@", "!", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "|", "\", ":", ";", """", "'", "<", ">", ",", ".", "/", "?", "~", "`", "¢", "£", "€", "¥", "µ"}


        For Each passChar As Char In password.Text
            For Each itemChar As String In specialChar
                If passChar = itemChar AndAlso password.Text.Length >= 6 Then
                    containsSpecialChar = True
                    Exit For
                End If
            Next
            If containsSpecialChar Then Exit For
        Next

        If Not containsSpecialChar Then
            status.Text = "Password must contain at least one special character and have a
minimum length of 6 characters."
            password.Text = ""
        Else
            Try
                Dim query As String = "INSERT INTO register_account (name, email, password) VALUES (@name, @email, @password)"

                Con.Open()
                Using cmd As New MySqlCommand(query, Con)
                    cmd.Parameters.AddWithValue("@name", userName.Text)
                    cmd.Parameters.AddWithValue("@email", email.Text)
                    cmd.Parameters.AddWithValue("@password", password.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("account created")
                Me.Hide()
                Form2.Show()
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            Finally
                Con.Close()
            End Try
        End If


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Toggle the value of clicked
        clicked = Not clicked

        ' Set the UseSystemPasswordChar property based on the updated value of clicked
        password.UseSystemPasswordChar = Not clicked

    End Sub

    'Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    'End Sub
End Class
