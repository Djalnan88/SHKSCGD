Imports System.Reflection

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label6.Text = Form2.cafe_student & "/" & Form2.cafe_student_max
        Label7.Text = Form2.cafe_staff & "/" & Form2.cafe_staff_max
        Label8.Text = Form2.cafe_research & "/" & Form2.cafe_research_max
        Label9.Text = Form2.book_2 & "/" & Form2.book_2_max
        Label10.Text = Form2.book_3 & "/" & Form2.book_3_max
        Label11.Text = Form2.book_4 & "/" & Form2.book_4_max
        Label19.Text = Form2.book_5 & "/" & Form2.book_5_max
        Label20.Text = Form2.book_6 & "/" & Form2.book_6_max
        Label21.Text = Form2.book_dorm & "/" & Form2.book_dorm_max
        Label22.Text = Form2.book_E7 & "/" & Form2.book_E7_max
        Label23.Text = Form2.book_sun & "/" & Form2.book_sun_max

        Label6.BackColor = Color.FromArgb(Int(Form2.cafe_student / Form2.cafe_student_max * 255), Int((1 - Form2.cafe_student / Form2.cafe_student_max) * 255), 0)
        Label7.BackColor = Color.FromArgb(Int(Form2.cafe_staff / Form2.cafe_staff_max * 255), Int((1 - Form2.cafe_staff / Form2.cafe_staff_max) * 255), 0)
        Label8.BackColor = Color.FromArgb(Int(Form2.cafe_student / Form2.cafe_research_max * 255), Int((1 - Form2.cafe_research / Form2.cafe_research_max) * 255), 0)
        Label9.BackColor = Color.FromArgb(Int(Form2.book_2 / Form2.book_2_max * 255), Int((1 - Form2.book_2 / Form2.book_2_max) * 255), 0)
        Label10.BackColor = Color.FromArgb(Int(Form2.book_3 / Form2.book_3_max * 255), Int((1 - Form2.book_3 / Form2.book_3_max) * 255), 0)
        Label11.BackColor = Color.FromArgb(Int(Form2.book_4 / Form2.book_4_max * 255), Int((1 - Form2.book_4 / Form2.book_4_max) * 255), 0)
        Label19.BackColor = Color.FromArgb(Int(Form2.book_5 / Form2.book_5_max * 255), Int((1 - Form2.book_5 / Form2.book_5_max) * 255), 0)
        Label20.BackColor = Color.FromArgb(Int(Form2.book_6 / Form2.book_6_max * 255), Int((1 - Form2.book_6 / Form2.book_6_max) * 255), 0)
        Label21.BackColor = Color.FromArgb(Int(Form2.book_dorm / Form2.book_dorm_max * 255), Int((1 - Form2.book_dorm / Form2.book_dorm_max) * 255), 0)
        Label22.BackColor = Color.FromArgb(Int(Form2.book_E7 / Form2.book_E7_max * 255), Int((1 - Form2.book_E7 / Form2.book_E7_max) * 255), 0)
        Label23.BackColor = Color.FromArgb(Int(Form2.book_sun / Form2.book_sun_max * 255), Int((1 - Form2.book_sun / Form2.book_sun_max) * 255), 0)

        For i As Integer = 0 To 5
            ListBox1.Items.Add(Form2.menu_student(i))
            ListBox2.Items.Add(Form2.menu_staff(i))
            ListBox3.Items.Add(Form2.menu_research(i))
        Next
        For i As Integer = 6 To 8
            ListBox4.Items.Add(Form2.menu_student(i))
        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = Form2.cafe_student & "/" & Form2.cafe_student_max
        Label7.Text = Form2.cafe_staff & "/" & Form2.cafe_staff_max
        Label8.Text = Form2.cafe_research & "/" & Form2.cafe_research_max
        Label9.Text = Form2.book_2 & "/" & Form2.book_2_max
        Label10.Text = Form2.book_3 & "/" & Form2.book_3_max
        Label11.Text = Form2.book_4 & "/" & Form2.book_4_max
        Label19.Text = Form2.book_5 & "/" & Form2.book_5_max
        Label20.Text = Form2.book_6 & "/" & Form2.book_6_max
        Label21.Text = Form2.book_dorm & "/" & Form2.book_dorm_max
        Label22.Text = Form2.book_E7 & "/" & Form2.book_E7_max
        Label23.Text = Form2.book_sun & "/" & Form2.book_sun_max

        Label6.BackColor = Color.FromArgb(Int(Form2.cafe_student / Form2.cafe_student_max * 255), Int((1 - Form2.cafe_student / Form2.cafe_student_max) * 255), 0)
        Label7.BackColor = Color.FromArgb(Int(Form2.cafe_staff / Form2.cafe_staff_max * 255), Int((1 - Form2.cafe_staff / Form2.cafe_staff_max) * 255), 0)
        Label8.BackColor = Color.FromArgb(Int(Form2.cafe_research / Form2.cafe_research_max * 255), Int((1 - Form2.cafe_research / Form2.cafe_research_max) * 255), 0)
        Label9.BackColor = Color.FromArgb(Int(Form2.book_2 / Form2.book_2_max * 255), Int((1 - Form2.book_2 / Form2.book_2_max) * 255), 0)
        Label10.BackColor = Color.FromArgb(Int(Form2.book_3 / Form2.book_3_max * 255), Int((1 - Form2.book_3 / Form2.book_3_max) * 255), 0)
        Label11.BackColor = Color.FromArgb(Int(Form2.book_4 / Form2.book_4_max * 255), Int((1 - Form2.book_4 / Form2.book_4_max) * 255), 0)
        Label19.BackColor = Color.FromArgb(Int(Form2.book_5 / Form2.book_5_max * 255), Int((1 - Form2.book_5 / Form2.book_5_max) * 255), 0)
        Label20.BackColor = Color.FromArgb(Int(Form2.book_6 / Form2.book_6_max * 255), Int((1 - Form2.book_6 / Form2.book_6_max) * 255), 0)
        Label21.BackColor = Color.FromArgb(Int(Form2.book_dorm / Form2.book_dorm_max * 255), Int((1 - Form2.book_dorm / Form2.book_dorm_max) * 255), 0)
        Label22.BackColor = Color.FromArgb(Int(Form2.book_E7 / Form2.book_E7_max * 255), Int((1 - Form2.book_E7 / Form2.book_E7_max) * 255), 0)
        Label23.BackColor = Color.FromArgb(Int(Form2.book_sun / Form2.book_sun_max * 255), Int((1 - Form2.book_sun / Form2.book_sun_max) * 255), 0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        Me.Close()

    End Sub
End Class