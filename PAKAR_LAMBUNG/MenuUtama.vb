Public Class MenuUtama
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Diagnosa.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DetailPenyakit.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Tentang.Show()
        Me.Hide()
    End Sub
End Class