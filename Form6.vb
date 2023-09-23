Public Class Form6
    Dim book_place(8) As String
    Dim lunch_place(3) As String
    Dim rd As New Random
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        book_place(1) = "학술정보관 2층"
        book_place(2) = "학술정보관 3층"
        book_place(3) = "학술정보관 4층"
        book_place(4) = "학술정보관 5층"
        book_place(5) = "학술정보관 6층"
        book_place(6) = "기숙사 독서실"
        book_place(7) = "E7 독서실"
        book_place(8) = "해동창의 마루"

        lunch_place(1) = "학생 식당"
        lunch_place(2) = "교직원 식당"
        lunch_place(3) = "연구동 식당"

        Label1.Text = book_place(rd.Next(1, 9))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = book_place(rd.Next(1, 9))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = lunch_place(rd.Next(1, 3))
    End Sub
End Class