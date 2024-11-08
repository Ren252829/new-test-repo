Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.InitializeListBuku()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudul.Text.Trim()
        Dim genre As String = txtGenre.Text.Trim()
        If Module1.IsJudulBukuExist(judul) Then
            MessageBox.Show("Judul buku sudah ada dalam daftar. Judul buku tidak boleh sama.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not String.IsNullOrEmpty(judul) AndAlso Not String.IsNullOrEmpty(genre) Then
            Dim bukuBaru As New Module1.Buku
            bukuBaru.Judul = judul
            bukuBaru.Genre = genre

            Module1.TambahBuku(bukuBaru)
            txtJudul.Clear()
            txtGenre.Clear()
        Else
            MessageBox.Show("Harap isi Judul dan Genre buku.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub ButtonLihatDaftar_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        Dim form2 As New Form2()
        form2.Show()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtHapus.Text.Trim()

        If Not String.IsNullOrEmpty(judul) Then
            Dim index As Integer = CariIndexBuku(judul)
            If index <> -1 Then
                Module1.HapusBuku(judul)
                TampilkanDaftarBuku()
                txtHapus.Text = ""
                MessageBox.Show("Buku Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Buku dengan judul tersebut tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Masukkan judul buku yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function CariIndexBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To Module1.JumlahBuku - 1
            If Module1.ListBuku(i).Judul = judul Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub TampilkanDaftarBuku()
        lvBuku.Items.Clear()
        For Each buku As Module1.Buku In Module1.ListBuku
            Dim item As New ListViewItem(buku.Judul)
            item.SubItems.Add(buku.Genre)
            lvBuku.Items.Add(item)
        Next
    End Sub
    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

End Class
