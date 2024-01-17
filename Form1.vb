Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grade As String
        grade = ComboBox1.Text
        Select Case grade
            Case "A"
                TextBox1.Text = "high distinction"
            Case "A-"
                TextBox1.Text = "distinction"
            Case "B"
                TextBox1.Text = "credit"
            Case "C"
                TextBox1.Text = "Pass"
            Case "D"
                TextBox1.Text = "Fail"
            Case Else
                TextBox1.Text = "Fail"

        End Select

    End Sub
End Class
