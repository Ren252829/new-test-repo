Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanDaftarBuku()
        lvBuku.Columns.Add("Judul", 120)
        lvBuku.Columns.Add("Genre", 120)
    End Sub

    Private Sub TampilkanDaftarBuku()
        lvBuku.Items.Clear()

        For i As Integer = 0 To JumlahBuku - 1
            Dim item As New ListViewItem(ListBuku(i).Judul)
            item.SubItems.Add(ListBuku(i).Genre)
            lvBuku.Items.Add(item)
        Next
    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
