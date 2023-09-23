Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim book_place(8) As String
        Dim book_people(8) As Double
        Dim rd As New Random

        book_people(1) = Form2.book_2 / Form2.book_2_max
        book_people(2) = Form2.book_3 / Form2.book_3_max
        book_people(3) = Form2.book_4 / Form2.book_4_max
        book_people(4) = Form2.book_5 / Form2.book_5_max
        book_people(5) = Form2.book_6 / Form2.book_6_max
        book_people(6) = Form2.book_dorm / Form2.book_dorm_max
        book_people(7) = Form2.book_E7 / Form2.book_E7_max
        book_people(8) = Form2.book_sun / Form2.book_sun

        book_place(1) = "학술정보관 2층"
        book_place(2) = "학술정보관 3층"
        book_place(3) = "학술정보관 4층"
        book_place(4) = "학술정보관 5층"
        book_place(5) = "학술정보관 6층"
        book_place(6) = "기숙사 독서실"
        book_place(7) = "E7 독서실"
        book_place(8) = "해동창의 마루"

        Label1.Text = book_place(rd.Next(1, 9))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class