Public Class Form1

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" _
        OrElse keyascii = Keys.Back _
        OrElse keyascii = Keys.Space _
        OrElse keyascii = Keys.Return _
        OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txtNotelf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNotelf.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtUmur.Text) OrElse String.IsNullOrWhiteSpace(txtAlamat.Text) OrElse String.IsNullOrWhiteSpace(txtNoTelf.Text) OrElse String.IsNullOrWhiteSpace(cboxProdi.Text) OrElse String.IsNullOrWhiteSpace(cboxAngkatan.Text) OrElse dateTTL.Value = Nothing OrElse (Not rbCowo.Checked AndAlso Not rbCewe.Checked) Then
            MessageBox.Show("Silakan isi semua kolom yang diperlukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim hobi As String = ""
        For Each control As Control In gboxHobi.Controls
            If TypeOf control Is CheckBox AndAlso DirectCast(control, CheckBox).Checked Then
                hobi &= control.Text & vbCrLf
            End If
        Next

        Dim gambar As Image = PictureBox1.Image
        Dim Form2 As New Form2(txtNama.Text, Convert.ToInt32(txtUmur.Text), dateTTL.Value, cboxProdi.Text, cboxAngkatan.Text, txtNotelf.Text, txtAlamat.Text, If(rbCowo.Checked, rbCowo.Text, rbCewe.Text), hobi, gambar)
        form2.Show()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Gambar Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Semua Files|*.*"
        openFileDialog.Title = "Pilih Gambar"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
