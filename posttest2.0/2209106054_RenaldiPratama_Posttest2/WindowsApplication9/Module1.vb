Module Module1
    Public Structure Buku
        Public Judul As String
        Public Genre As String
    End Structure

    Public ListBuku() As Buku
    Public JumlahBuku As Integer
    Public Sub InitializeListBuku()
        ReDim ListBuku(-1)
        JumlahBuku = 0
    End Sub
    Public Function IsJudulBukuExist(ByVal judul As String) As Boolean
        For Each buku As Buku In ListBuku
            If buku.Judul = judul Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub TambahBuku(ByVal bukuBaru As Buku)
        If Not IsJudulBukuExist(bukuBaru.Judul) Then
            ReDim Preserve ListBuku(JumlahBuku)
            ListBuku(JumlahBuku) = bukuBaru
            JumlahBuku += 1
        End If
    End Sub
    Public Sub HapusBuku(ByVal judul As String)
        For i As Integer = 0 To JumlahBuku - 1
            If ListBuku(i).Judul = judul Then
                For j As Integer = i To JumlahBuku - 2
                    ListBuku(j) = ListBuku(j + 1)
                Next
                JumlahBuku -= 1
                ReDim Preserve ListBuku(JumlahBuku - 1)
                Exit For
            End If
        Next
    End Sub
End Module
