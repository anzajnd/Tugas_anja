Public Class Frmpraktikum1

    Private Sub Frmpraktikum1_Load(ByVal sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmbmodel.Items.Add("Lengan Pendek")
        cmbmodel.Items.Add("Lengan Panjang")
        cmbmodel.Items.Add("Singlet")
    End Sub

    Private Sub cmbmodel_SelectedIndexChanged(ByVal sender As System.Object, e As System.EventArgs) Handles cmbmodel.SelectedIndexChanged
        If cmbmodel.Text = "Lengan Pendek" Then
            cmbnama.Items.Clear()
            cmbnama.Text = ""
            cmbnama.Items.Add("Polo")
            cmbnama.Items.Add("Uniqlo")
            cmbnama.Items.Add("Hysteria")

        ElseIf cmbmodel.Text = "Lengan Panjang" Then
            cmbnama.Items.Clear()
            cmbnama.Text = ""
            cmbnama.Items.Add("Rucas")
            cmbnama.Items.Add("Skymo")
            cmbnama.Items.Add("Adidas")

        ElseIf cmbmodel.Text = "Singlet" Then
            cmbnama.Items.Clear()
            cmbnama.Text = ""
            cmbnama.Items.Add("Nike")
            cmbnama.Items.Add("Eiger")
            cmbnama.Items.Add("Asics")
        End If
    End Sub

    Private Sub cmbnama_SelectedIndexChanged(ByVal sender As System.Object, e As System.EventArgs) Handles cmbnama.SelectedIndexChanged
        If cmbnama.Text = "Polo" Then
            txtharga.Text = 150000
        ElseIf cmbnama.Text = "Uniqlo" Then
            txtharga.Text = 100000
        ElseIf cmbnama.Text = "Hysteria" Then
            txtharga.Text = 90000
        ElseIf cmbnama.Text = "Rucas" Then
            txtharga.Text = 120000
        ElseIf cmbnama.Text = "Skymo" Then
            txtharga.Text = 95000
        ElseIf cmbnama.Text = "Adidas" Then
            txtharga.Text = 130000
        ElseIf cmbnama.Text = "Uniqlo" Then
            txtharga.Text = 100000
        ElseIf cmbnama.Text = "Nike" Then
            txtharga.Text = 140000
        ElseIf cmbnama.Text = "Eiger" Then
            txtharga.Text = 200000
        ElseIf cmbnama.Text = "Asics" Then
            txtharga.Text = 180000
        End If
    End Sub

    Private Sub btnhitung_Click(ByVal sender As System.Object, e As System.EventArgs) Handles btnhitung.Click
        txttotal.Text = Val(txtharga.Text) * Val(txtjumlah.Text)
        If txttotal.Text > 50000 Then
            txtpotongan.Text = 50000
        Else
            txtpotongan.Text = 0
        End If
        txtbayar.Text = Val(txttotal.Text) - Val(txttotal.Text)

    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, e As System.EventArgs) Handles btnbatal.Click
        End
    End Sub
End Class
