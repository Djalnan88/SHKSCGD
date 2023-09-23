Imports System.Windows.Forms.Design
Imports System.IO.Ports

Public Class Form2
    Friend Shared prefer_study = 1

    Friend Shared cafe_student_max = 150
    Friend Shared cafe_staff_max = 75
    Friend Shared cafe_research_max = 200
    Friend Shared book_2_max = 20
    Friend Shared book_3_max = 20
    Friend Shared book_4_max = 100
    Friend Shared book_5_max = 50
    Friend Shared book_6_max = 150
    Friend Shared book_dorm_max = 120
    Friend Shared book_E7_max = 16
    Friend Shared book_sun_max = 40

    Friend Shared cafe_student As Integer
    Friend Shared cafe_staff As Integer
    Friend Shared cafe_research As Integer
    Friend Shared book_2 As Integer
    Friend Shared book_3 As Integer
    Friend Shared book_4 As Integer
    Friend Shared book_5 As Integer
    Friend Shared book_6 As Integer
    Friend Shared book_dorm As Integer
    Friend Shared book_E7 As Integer
    Friend Shared book_sun As Integer

    Friend Shared menu_student(9) As String
    Friend Shared menu_staff(6) As String
    Friend Shared menu_research(6) As String


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddOwnedForm(Form3)
        AddOwnedForm(Form4)
        AddOwnedForm(Form5)
        AddOwnedForm(Form6)
        AddOwnedForm(Form7)
        Timer1.Start()

        menu_student = {"백미밥", "순두부찌개", "연어까스&타르타르소스", "콩나물무침", "양념깻잎지", "포기김치", "대패삼겹라면", "닭갈비덮밥", "돈까스마요덮밥"}
        menu_staff = {"자장라이스", "계란국", "꿔바로우탕수육", "고추잡채", "깍둑단무지무침", "파김치"}
        menu_research = {"백미밥", "들깨무채국", "오징어볶음", "어묵볶음", "마늘쫑지", "배추김치"}

        Dim rd As New Random
        cafe_student += rd.Next(0, cafe_student_max)
        cafe_staff += rd.Next(0, cafe_staff_max)
        cafe_research += rd.Next(0, cafe_research_max)
        book_2 += rd.Next(0, book_2_max)
        book_3 += rd.Next(0, book_3_max)
        book_4 += rd.Next(0, book_4_max)
        book_5 += rd.Next(0, book_5_max)
        book_6 += rd.Next(0, book_6_max)
        book_dorm += rd.Next(0, book_dorm_max)
        book_E7 += rd.Next(0, book_E7_max)
        book_sun += rd.Next(0, book_sun_max)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form7.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form8.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form9.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

    End Sub

    Public Function min(a As Integer, b As Integer) As Integer
        If a < b Then
            min = a
        Else
            min = b
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rd As New Random

        cafe_student += rd.Next(-1 * min(cafe_student, 5), min(cafe_student_max - cafe_student, 5))
        cafe_staff += rd.Next(-1 * min(cafe_staff, 5), min(cafe_staff_max - cafe_staff, 5))
        cafe_research += rd.Next(-1 * min(cafe_research, 5), min(cafe_research_max - cafe_research, 5))
        book_2 += rd.Next(-1 * min(book_2, 5), min(book_2_max - book_2, 5))
        book_3 += rd.Next(-1 * min(book_3, 5), min(book_3_max - book_3, 5))
        book_4 += rd.Next(-1 * min(book_4, 5), min(book_4_max - book_4, 5))
        book_5 += rd.Next(-1 * min(book_5, 5), min(book_5_max - book_5, 5))
        book_6 += rd.Next(-1 * min(book_6, 5), min(book_6_max - book_6, 5))
        book_dorm += rd.Next(-1 * min(book_dorm, 5), min(book_dorm_max - book_dorm, 5))
        book_E7 += rd.Next(-1 * min(book_E7, 5), min(book_E7_max - book_E7, 5))
        book_sun += rd.Next(-1 * min(book_sun, 5), min(book_sun_max - book_sun, 5))

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form5.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form4.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form3.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form6.Show()

    End Sub
End Class