<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmpraktikum1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmpraktikum1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        cmbmodel = New ComboBox()
        cmbnama = New ComboBox()
        txtharga = New TextBox()
        txtjumlah = New TextBox()
        txttotal = New TextBox()
        txtpotongan = New TextBox()
        txtbayar = New TextBox()
        PictureBox1 = New PictureBox()
        btnhitung = New Button()
        btnbatal = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Grouns", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(224, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(328, 38)
        Label1.TabIndex = 0
        Label1.Text = "Penjualan T-Shirt"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Geometr415 Blk BT", 12F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(12, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 24)
        Label2.TabIndex = 1
        Label2.Text = "Model Baju :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Geometr415 Blk BT", 12F)
        Label3.Location = New Point(13, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 24)
        Label3.TabIndex = 2
        Label3.Text = "Nama Baju :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Geometr415 Blk BT", 12F)
        Label4.Location = New Point(56, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 24)
        Label4.TabIndex = 3
        Label4.Text = "Harga :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Geometr415 Blk BT", 12F)
        Label5.Location = New Point(49, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 24)
        Label5.TabIndex = 4
        Label5.Text = "Jumlah :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Geometr415 Blk BT", 12F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(431, 305)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 24)
        Label6.TabIndex = 5
        Label6.Text = "Total Harga :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Geometr415 Blk BT", 12F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(454, 348)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 24)
        Label7.TabIndex = 6
        Label7.Text = "Potongan :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Geometr415 Blk BT", 12F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(436, 392)
        Label8.Name = "Label8"
        Label8.Size = New Size(125, 24)
        Label8.TabIndex = 7
        Label8.Text = "Total Bayar :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Geometr415 Blk BT", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(355, 485)
        Label9.Name = "Label9"
        Label9.Size = New Size(379, 18)
        Label9.TabIndex = 8
        Label9.Text = "Potongan 50 ribu untuk total pembelian di atas 500.000"
        ' 
        ' cmbmodel
        ' 
        cmbmodel.FormattingEnabled = True
        cmbmodel.Location = New Point(140, 95)
        cmbmodel.Name = "cmbmodel"
        cmbmodel.Size = New Size(151, 28)
        cmbmodel.TabIndex = 9
        ' 
        ' cmbnama
        ' 
        cmbnama.FormattingEnabled = True
        cmbnama.Location = New Point(140, 137)
        cmbnama.Name = "cmbnama"
        cmbnama.Size = New Size(151, 28)
        cmbnama.TabIndex = 10
        ' 
        ' txtharga
        ' 
        txtharga.Location = New Point(140, 177)
        txtharga.Name = "txtharga"
        txtharga.Size = New Size(151, 27)
        txtharga.TabIndex = 11
        ' 
        ' txtjumlah
        ' 
        txtjumlah.Location = New Point(140, 217)
        txtjumlah.Name = "txtjumlah"
        txtjumlah.Size = New Size(151, 27)
        txtjumlah.TabIndex = 12
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(584, 302)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(125, 27)
        txttotal.TabIndex = 13
        ' 
        ' txtpotongan
        ' 
        txtpotongan.Location = New Point(584, 345)
        txtpotongan.Name = "txtpotongan"
        txtpotongan.Size = New Size(125, 27)
        txtpotongan.TabIndex = 14
        ' 
        ' txtbayar
        ' 
        txtbayar.Location = New Point(584, 389)
        txtbayar.Name = "txtbayar"
        txtbayar.Size = New Size(125, 27)
        txtbayar.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(523, 62)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(199, 234)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' btnhitung
        ' 
        btnhitung.Location = New Point(399, 439)
        btnhitung.Name = "btnhitung"
        btnhitung.Size = New Size(94, 29)
        btnhitung.TabIndex = 17
        btnhitung.Text = "Hitung"
        btnhitung.UseVisualStyleBackColor = True
        ' 
        ' btnbatal
        ' 
        btnbatal.Location = New Point(545, 439)
        btnbatal.Name = "btnbatal"
        btnbatal.Size = New Size(94, 29)
        btnbatal.TabIndex = 18
        btnbatal.Text = "Batal"
        btnbatal.UseVisualStyleBackColor = True
        ' 
        ' Frmpraktikum1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(734, 512)
        Controls.Add(btnbatal)
        Controls.Add(btnhitung)
        Controls.Add(PictureBox1)
        Controls.Add(txtbayar)
        Controls.Add(txtpotongan)
        Controls.Add(txttotal)
        Controls.Add(txtjumlah)
        Controls.Add(txtharga)
        Controls.Add(cmbnama)
        Controls.Add(cmbmodel)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Frmpraktikum1"
        Text = "Praktikum1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbmodel As ComboBox
    Friend WithEvents cmbnama As ComboBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtpotongan As TextBox
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnhitung As Button
    Friend WithEvents btnbatal As Button

End Class
