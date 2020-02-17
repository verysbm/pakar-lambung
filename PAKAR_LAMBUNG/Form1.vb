Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Isi Login Dengan Benar")
        Else
            If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
                MsgBox("Login Berhasil")
                MenuUtama.Show()
                Me.Hide()
            Else
                MsgBox("Login Anda Gagal !!")
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
