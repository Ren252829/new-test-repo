<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.rbCowo = New System.Windows.Forms.RadioButton()
        Me.gboxGender = New System.Windows.Forms.GroupBox()
        Me.rbCewe = New System.Windows.Forms.RadioButton()
        Me.dateTTL = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboxProdi = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboxAngkatan = New System.Windows.Forms.ComboBox()
        Me.txtNotelf = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.boxHiking = New System.Windows.Forms.CheckBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.boxBultang = New System.Windows.Forms.CheckBox()
        Me.boxFutsal = New System.Windows.Forms.CheckBox()
        Me.boxRenang = New System.Windows.Forms.CheckBox()
        Me.boxCamping = New System.Windows.Forms.CheckBox()
        Me.boxMainGame = New System.Windows.Forms.CheckBox()
        Me.boxBilliard = New System.Windows.Forms.CheckBox()
        Me.boxBersepeda = New System.Windows.Forms.CheckBox()
        Me.boxJalanJalan = New System.Windows.Forms.CheckBox()
        Me.boxBowling = New System.Windows.Forms.CheckBox()
        Me.gboxHobi = New System.Windows.Forms.GroupBox()
        Me.gboxGender.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxHobi.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Umur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(360, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID CARD"
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(127, 182)
        Me.txtUmur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(89, 22)
        Me.txtUmur.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(127, 133)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(89, 22)
        Me.txtNama.TabIndex = 5
        '
        'rbCowo
        '
        Me.rbCowo.AutoSize = True
        Me.rbCowo.Location = New System.Drawing.Point(5, 38)
        Me.rbCowo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbCowo.Name = "rbCowo"
        Me.rbCowo.Size = New System.Drawing.Size(86, 21)
        Me.rbCowo.TabIndex = 7
        Me.rbCowo.TabStop = True
        Me.rbCowo.Text = "Laki-Laki"
        Me.rbCowo.UseVisualStyleBackColor = True
        '
        'gboxGender
        '
        Me.gboxGender.Controls.Add(Me.rbCewe)
        Me.gboxGender.Controls.Add(Me.rbCowo)
        Me.gboxGender.Location = New System.Drawing.Point(428, 62)
        Me.gboxGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboxGender.Name = "gboxGender"
        Me.gboxGender.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboxGender.Size = New System.Drawing.Size(211, 90)
        Me.gboxGender.TabIndex = 8
        Me.gboxGender.TabStop = False
        Me.gboxGender.Text = "Pilihan"
        '
        'rbCewe
        '
        Me.rbCewe.AutoSize = True
        Me.rbCewe.Location = New System.Drawing.Point(97, 38)
        Me.rbCewe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbCewe.Name = "rbCewe"
        Me.rbCewe.Size = New System.Drawing.Size(102, 21)
        Me.rbCewe.TabIndex = 8
        Me.rbCewe.TabStop = True
        Me.rbCewe.Text = "Perempuan"
        Me.rbCewe.UseVisualStyleBackColor = True
        '
        'dateTTL
        '
        Me.dateTTL.Location = New System.Drawing.Point(127, 226)
        Me.dateTTL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateTTL.Name = "dateTTL"
        Me.dateTTL.Size = New System.Drawing.Size(178, 22)
        Me.dateTTL.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tanggal Lahir"
        '
        'cboxProdi
        '
        Me.cboxProdi.FormattingEnabled = True
        Me.cboxProdi.Items.AddRange(New Object() {"Informatika", "Sistem Informasi", "Elektro"})
        Me.cboxProdi.Location = New System.Drawing.Point(127, 264)
        Me.cboxProdi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxProdi.Name = "cboxProdi"
        Me.cboxProdi.Size = New System.Drawing.Size(108, 24)
        Me.cboxProdi.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Prodi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Angkatan"
        '
        'cboxAngkatan
        '
        Me.cboxAngkatan.FormattingEnabled = True
        Me.cboxAngkatan.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.cboxAngkatan.Location = New System.Drawing.Point(127, 306)
        Me.cboxAngkatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxAngkatan.Name = "cboxAngkatan"
        Me.cboxAngkatan.Size = New System.Drawing.Size(108, 24)
        Me.cboxAngkatan.TabIndex = 17
        '
        'txtNotelf
        '
        Me.txtNotelf.Location = New System.Drawing.Point(127, 354)
        Me.txtNotelf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNotelf.Name = "txtNotelf"
        Me.txtNotelf.Size = New System.Drawing.Size(89, 22)
        Me.txtNotelf.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 354)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Nomor HP"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(127, 398)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(89, 22)
        Me.txtAlamat.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 402)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Alamat"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(19, 71)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(82, 32)
        Me.btnBrowse.TabIndex = 22
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(127, 40)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'boxHiking
        '
        Me.boxHiking.AutoSize = True
        Me.boxHiking.Location = New System.Drawing.Point(159, 27)
        Me.boxHiking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boxHiking.Name = "boxHiking"
        Me.boxHiking.Size = New System.Drawing.Size(69, 21)
        Me.boxHiking.TabIndex = 31
        Me.boxHiking.Text = "Hiking"
        Me.boxHiking.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.SystemColors.Control
        Me.btnCetak.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.ForeColor = System.Drawing.Color.Peru
        Me.btnCetak.Location = New System.Drawing.Point(489, 327)
        Me.btnCetak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(162, 102)
        Me.btnCetak.TabIndex = 34
        Me.btnCetak.Text = "CETAK KARTU ANGGOTA"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'boxBultang
        '
        Me.boxBultang.AutoSize = True
        Me.boxBultang.Location = New System.Drawing.Point(159, 117)
        Me.boxBultang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boxBultang.Name = "boxBultang"
        Me.boxBultang.Size = New System.Drawing.Size(108, 21)
        Me.boxBultang.TabIndex = 24
        Me.boxBultang.Text = "BuluTangkis"
        Me.boxBultang.UseVisualStyleBackColor = True
        '
        'boxFutsal
        '
        Me.boxFutsal.AutoSize = True
        Me.boxFutsal.Location = New System.Drawing.Point(159, 93)
        Me.boxFutsal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boxFutsal.Name = "boxFutsal"
        Me.boxFutsal.Size = New System.Drawing.Size(68, 21)
        Me.boxFutsal.TabIndex = 25
        Me.boxFutsal.Text = "Futsal"
        Me.boxFutsal.UseVisualStyleBackColor = True
        '
        'boxRenang
        '
        Me.boxRenang.AutoSize = True
        Me.boxRenang.Location = New System.Drawing.Point(159, 49)
        Me.boxRenang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boxRenang.Name = "boxRenang"
        Me.boxRenang.Size = New System.Drawing.Size(80, 21)
        Me.boxRenang.TabIndex = 30
        Me.boxRenang.Text = "Renang"
        Me.boxRenang.UseVisualStyleBackColor = True
        '
        'boxCamping
        '
        Me.boxCamping.AutoSize = True
        Me.boxCamping.Location = New System.Drawing.Point(159, 70)
        Me.boxCamping.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boxCamping.Name = "boxCamping"
        Me.boxCamping.Size = New System.Drawing.Size(85, 21)
        Me.boxCamping.TabIndex = 32
        Me.boxCamping.Text = "Camping"
        Me.boxCamping.UseVisualStyleBackColor = True
        '
        'boxMainGame
        '
        Me.boxMainGame.AutoSize = True
        Me.boxMainGame.Location = New System.Drawing.Point(5, 117)
        Me.boxMainGame.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boxMainGame.Name = "boxMainGame"
        Me.boxMainGame.Size = New System.Drawing.Size(102, 21)
        Me.boxMainGame.TabIndex = 15
        Me.boxMainGame.Text = "Main Game"
        Me.boxMainGame.UseVisualStyleBackColor = True
        '
        'boxBilliard
        '
        Me.boxBilliard.AutoSize = True
        Me.boxBilliard.Location = New System.Drawing.Point(5, 70)
        Me.boxBilliard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boxBilliard.Name = "boxBilliard"
        Me.boxBilliard.Size = New System.Drawing.Size(72, 21)
        Me.boxBilliard.TabIndex = 27
        Me.boxBilliard.Text = "Billiard"
        Me.boxBilliard.UseVisualStyleBackColor = True
        '
        'boxBersepeda
        '
        Me.boxBersepeda.AutoSize = True
        Me.boxBersepeda.Location = New System.Drawing.Point(5, 93)
        Me.boxBersepeda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boxBersepeda.Name = "boxBersepeda"
        Me.boxBersepeda.Size = New System.Drawing.Size(99, 21)
        Me.boxBersepeda.TabIndex = 33
        Me.boxBersepeda.Text = "Bersepeda"
        Me.boxBersepeda.UseVisualStyleBackColor = True
        '
        'boxJalanJalan
        '
        Me.boxJalanJalan.AutoSize = True
        Me.boxJalanJalan.Location = New System.Drawing.Point(5, 27)
        Me.boxJalanJalan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boxJalanJalan.Name = "boxJalanJalan"
        Me.boxJalanJalan.Size = New System.Drawing.Size(103, 21)
        Me.boxJalanJalan.TabIndex = 14
        Me.boxJalanJalan.Text = "Jalan-Jalan"
        Me.boxJalanJalan.UseVisualStyleBackColor = True
        '
        'boxBowling
        '
        Me.boxBowling.AutoSize = True
        Me.boxBowling.Location = New System.Drawing.Point(5, 49)
        Me.boxBowling.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boxBowling.Name = "boxBowling"
        Me.boxBowling.Size = New System.Drawing.Size(78, 21)
        Me.boxBowling.TabIndex = 26
        Me.boxBowling.Text = "Bowling"
        Me.boxBowling.UseVisualStyleBackColor = True
        '
        'gboxHobi
        '
        Me.gboxHobi.Controls.Add(Me.boxBowling)
        Me.gboxHobi.Controls.Add(Me.boxJalanJalan)
        Me.gboxHobi.Controls.Add(Me.boxBultang)
        Me.gboxHobi.Controls.Add(Me.boxFutsal)
        Me.gboxHobi.Controls.Add(Me.boxCamping)
        Me.gboxHobi.Controls.Add(Me.boxBersepeda)
        Me.gboxHobi.Controls.Add(Me.boxRenang)
        Me.gboxHobi.Controls.Add(Me.boxHiking)
        Me.gboxHobi.Controls.Add(Me.boxBilliard)
        Me.gboxHobi.Controls.Add(Me.boxMainGame)
        Me.gboxHobi.Location = New System.Drawing.Point(427, 174)
        Me.gboxHobi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboxHobi.Name = "gboxHobi"
        Me.gboxHobi.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboxHobi.Size = New System.Drawing.Size(297, 148)
        Me.gboxHobi.TabIndex = 35
        Me.gboxHobi.TabStop = False
        Me.gboxHobi.Text = "HOBI"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.WindowsApplication9.My.Resources.Resources.Putih_biru_dan_hitam_geometris_foto_Kartu_Identitas_Bisnis
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 472)
        Me.Controls.Add(Me.gboxHobi)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNotelf)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboxAngkatan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboxProdi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dateTTL)
        Me.Controls.Add(Me.gboxGender)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gboxGender.ResumeLayout(False)
        Me.gboxGender.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxHobi.ResumeLayout(False)
        Me.gboxHobi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUmur As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents rbCowo As System.Windows.Forms.RadioButton
    Friend WithEvents gboxGender As System.Windows.Forms.GroupBox
    Friend WithEvents rbCewe As System.Windows.Forms.RadioButton
    Friend WithEvents dateTTL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboxProdi As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboxAngkatan As System.Windows.Forms.ComboBox
    Friend WithEvents txtNotelf As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents boxHiking As System.Windows.Forms.CheckBox
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents boxBultang As System.Windows.Forms.CheckBox
    Friend WithEvents boxFutsal As System.Windows.Forms.CheckBox
    Friend WithEvents boxRenang As System.Windows.Forms.CheckBox
    Friend WithEvents boxCamping As System.Windows.Forms.CheckBox
    Friend WithEvents boxMainGame As System.Windows.Forms.CheckBox
    Friend WithEvents boxBilliard As System.Windows.Forms.CheckBox
    Friend WithEvents boxBersepeda As System.Windows.Forms.CheckBox
    Friend WithEvents boxJalanJalan As System.Windows.Forms.CheckBox
    Friend WithEvents boxBowling As System.Windows.Forms.CheckBox
    Friend WithEvents gboxHobi As System.Windows.Forms.GroupBox

End Class
