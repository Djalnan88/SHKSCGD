Public Class Form3
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim study = Me.ComboBox1.Text

        If study = "적은" Then
            Form2.prefer_study = 1
        ElseIf study = "적당한" Then
            Form2.prefer_study = 2
        ElseIf study = "많은" Then
            Form2.prefer_study = 3
        End If

        Me.Close()

    End Sub

End Class