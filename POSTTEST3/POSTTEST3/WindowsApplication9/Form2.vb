Public Class Form2
    Private _nama As String
    Private _umur As Integer
    Private _tglLahir As Date
    Private _prodi As String
    Private _angkatan As String
    Private _noTelf As String
    Private _alamat As String
    Private _gender As String
    Private _hobi As String


    Public Sub New(nama As String, umur As Integer, tglLahir As Date, prodi As String, angkatan As String, noTelf As String, alamat As String, gender As String, hobi As String, gambar As Image)
        InitializeComponent()

        _nama = nama
        _umur = umur
        _tglLahir = tglLahir
        _prodi = prodi
        _angkatan = angkatan
        _noTelf = noTelf
        _alamat = alamat
        _gender = gender
        _hobi = hobi


        txtNama.Text = _nama
        txtUmur.Text = _umur.ToString()
        txtTglLahir.Text = _tglLahir.ToShortDateString()
        txtProdi.Text = _prodi
        txtAngkatan.Text = _angkatan
        txtNoTelf.Text = _noTelf
        txtAlamat.Text = _alamat
        txtGender.Text = _gender
        txtHobi.Text = _hobi
        PictureBox1.Image = gambar
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub
End Class
