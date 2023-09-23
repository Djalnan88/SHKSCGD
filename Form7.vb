Imports System.Reflection.Emit

Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Label6.Text = Form2.book_2 & "/" & Form2.book_2_max
        Label7.Text = Form2.book_3 & "/" & Form2.book_3_max
        Label8.Text = Form2.book_4 & "/" & Form2.book_4_max
        Label9.Text = Form2.book_5 & "/" & Form2.book_5_max
        Label10.Text = Form2.book_6 & "/" & Form2.book_6_max

        Label6.BackColor = Color.FromArgb(Int(Form2.book_2 / Form2.book_2_max * 255), Int((1 - Form2.book_2 / Form2.book_2_max) * 255), 0)
        Label7.BackColor = Color.FromArgb(Int(Form2.book_3 / Form2.book_3_max * 255), Int((1 - Form2.book_3 / Form2.book_3_max) * 255), 0)
        Label8.BackColor = Color.FromArgb(Int(Form2.book_4 / Form2.book_4_max * 255), Int((1 - Form2.book_4 / Form2.book_4_max) * 255), 0)
        Label9.BackColor = Color.FromArgb(Int(Form2.book_5 / Form2.book_5_max * 255), Int((1 - Form2.book_5 / Form2.book_5_max) * 255), 0)
        Label10.BackColor = Color.FromArgb(Int(Form2.book_6 / Form2.book_6_max * 255), Int((1 - Form2.book_6 / Form2.book_6_max) * 255), 0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()
        Timer1.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = Form2.book_2 & "/" & Form2.book_2_max
        Label7.Text = Form2.book_3 & "/" & Form2.book_3_max
        Label8.Text = Form2.book_4 & "/" & Form2.book_4_max
        Label9.Text = Form2.book_5 & "/" & Form2.book_5_max
        Label10.Text = Form2.book_6 & "/" & Form2.book_6_max

        Label6.BackColor = Color.FromArgb(Int(Form2.book_2 / Form2.book_2_max * 255), Int((1 - Form2.book_2 / Form2.book_2_max) * 255), 0)
        Label7.BackColor = Color.FromArgb(Int(Form2.book_3 / Form2.book_3_max * 255), Int((1 - Form2.book_3 / Form2.book_3_max) * 255), 0)
        Label8.BackColor = Color.FromArgb(Int(Form2.book_4 / Form2.book_4_max * 255), Int((1 - Form2.book_4 / Form2.book_4_max) * 255), 0)
        Label9.BackColor = Color.FromArgb(Int(Form2.book_5 / Form2.book_5_max * 255), Int((1 - Form2.book_5 / Form2.book_5_max) * 255), 0)
        Label10.BackColor = Color.FromArgb(Int(Form2.book_6 / Form2.book_6_max * 255), Int((1 - Form2.book_6 / Form2.book_6_max) * 255), 0)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Form2.Show()
        Timer1.Stop()

    End Sub
End Class