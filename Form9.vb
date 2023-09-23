Imports System.Reflection.Emit

Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Label2.Text = Form2.book_dorm & "/" & Form2.book_dorm_max

        Label2.BackColor = Color.FromArgb(Int(Form2.book_dorm / Form2.book_dorm_max * 255), Int((1 - Form2.book_dorm / Form2.book_dorm_max) * 255), 0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()
        Timer1.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Form2.book_dorm & "/" & Form2.book_dorm_max

        Label2.BackColor = Color.FromArgb(Int(Form2.book_dorm / Form2.book_dorm_max * 255), Int((1 - Form2.book_dorm / Form2.book_dorm_max) * 255), 0)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        Form2.Show()
        Timer1.Stop()

    End Sub
End Class