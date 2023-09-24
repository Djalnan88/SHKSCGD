Imports System.Reflection.Emit

Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Label3.Text = Form2.book_E7 & "/" & Form2.book_E7_max
        Label4.Text = Form2.book_sun & "/" & Form2.book_sun_max

        Label3.BackColor = Color.FromArgb(Int(Form2.book_E7 / Form2.book_E7_max * 255), Int((1 - Form2.book_E7 / Form2.book_E7_max) * 255), 0)
        Label4.BackColor = Color.FromArgb(Int(Form2.book_sun / Form2.book_sun_max * 255), Int((1 - Form2.book_sun / Form2.book_sun_max) * 255), 0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()
        Timer1.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Form2.book_E7 & "/" & Form2.book_E7_max
        Label4.Text = Form2.book_sun & "/" & Form2.book_sun_max

        Label3.BackColor = Color.FromArgb(Int(Form2.book_E7 / Form2.book_E7_max * 255), Int((1 - Form2.book_E7 / Form2.book_E7_max) * 255), 0)
        Label4.BackColor = Color.FromArgb(Int(Form2.book_sun / Form2.book_sun_max * 255), Int((1 - Form2.book_sun / Form2.book_sun_max) * 255), 0)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form2.Show()
        Timer1.Stop()

    End Sub
End Class