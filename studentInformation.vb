Public Class studentInformation
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub studentInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentName.Enabled = False
        studentAge.Enabled = False
        studentCourse.Enabled = False
        studentDepartment.Enabled = False
        studentMedHistory.Enabled = False
        studentNumber.Enabled = False
        parentName.Enabled = False
        parentContactNo.Enabled = False
        relationship.Enabled = False
        address.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        studentName.Enabled = True
        studentAge.Enabled = True
        studentCourse.Enabled = True
        studentDepartment.Enabled = True
        studentMedHistory.Enabled = True
        studentNumber.Enabled = True
        parentName.Enabled = True
        parentContactNo.Enabled = True
        relationship.Enabled = True
        address.Enabled = True
    End Sub
End Class