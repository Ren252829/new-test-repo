Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BukaFile.Filter = "JPG Image|*.jpg|PNG Image|*.png|JPEG Image|*.jpeg"
        If BukaFile.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = BukaFile.FileName
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Form2.Label9.Text = txtnama.Text & ""
        Form2.Label10.Text = txtnim.Text & ""
        Form2.Label12.Text = ComboBox1.Text & ""

        If rblaki.Checked Then
            Form2.Label5.Text &= rblaki.Text
        Else
            Form2.Label5.Text &= rbperempuan.Text
        End If

        Form2.Label8.Text &= DateTimePicker1.Text

        Dim hobi As String = ""
        If CheckBox1.Checked Then
            hobi &= CheckBox1.Text & ""
        End If
        If CheckBox2.Checked Then
            hobi &= CheckBox2.Text & ""
        End If
        If CheckBox3.Checked Then
            hobi &= CheckBox3.Text & ""
        End If
        Form2.Label6.Text &= hobi
        Form2.PictureBox1.ImageLocation = BukaFile.FileName
        Form2.Show()
    End Sub
End Class
