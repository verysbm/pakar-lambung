Public Class Diagnosa
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If checkBox1.Checked = True And checkBox2.Checked = True And checkBox3.Checked = True And checkBox4.Checked = True And checkBox13.Checked = True Then
            MsgBox("Anda Terdiagnosa Penyakit 'MAAG GASTRITIS'")
            Gastritis.Show()
            Me.Hide()

        ElseIf checkBox1.Checked = True And checkBox2.Checked = True And checkBox4.Checked = True And checkBox5.Checked = True And checkBox6.Checked = True And checkBox14.Checked = True Then
            MsgBox("Anda Terdiagnosa Penyakit 'DIPEPSIA'")
            Dipepsia.Show()
            Me.Hide()

        ElseIf checkBox3.Checked = True And checkBox4.Checked = True And checkBox7.Checked = True And checkBox8.Checked = True And checkBox12.Checked = True Then
            MsgBox("Anda Terdiagnosa Penyakit 'KANKER LAMBUNG'")
            Kanker.Show()
            Me.Hide()

        ElseIf checkBox1.Checked = True And checkBox2.Checked = True And checkBox4.Checked = True And checkBox9.Checked = True And checkBox10.Checked = True And checkBox12.Checked = True And checkBox17.Checked = True Then
            MsgBox("Anda Terdiagnosa Penyakit 'GERD'")
            GERD.Show()
            Me.Hide()

        ElseIf checkBox1.Checked = True And checkBox4.Checked = True And checkBox6.Checked = True And checkBox9.Checked = True And checkBox10.Checked = True And checkBox12.Checked = True And checkBox16.Checked = True Then
            MsgBox("Anda Terdiagnosa Penyakit 'GASTROENTERITIS'")
            Gastroenteritis.Show()
            Me.Hide()

        ElseIf checkBox2.Checked = True And checkBox3.Checked = True And checkBox7.Checked = True And checkBox10.Checked = True And checkBox12.Checked = True And checkBox14.Checked = True Then
            MsgBox("Anda Terdiagnosa Penyakit 'GASTROPARESIS'")
            Gastroparesis.Show()
            Me.Hide()

        ElseIf checkBox1.Checked = True And checkBox3.Checked = True And checkBox4.Checked = True And checkBox8.Checked = True And checkBox15.Checked = True Then
            MsgBox("Anda Terdiagnosa Penyakit 'TUKAK LAMBUNG'")
            TukakLambung.Show()
            Me.Hide()

        Else
            MsgBox("Inputan Gejala Tidak Teridentifkasi")
            Me.Hide()
        End If

    End Sub
    Sub Clear()
        checkBox1.Checked = False
        checkBox2.Checked = False
        checkBox3.Checked = False
        checkBox4.Checked = False
        checkBox5.Checked = False
        checkBox6.Checked = False
        checkBox7.Checked = False
        checkBox8.Checked = False
        checkBox9.Checked = False
        checkBox10.Checked = False
        checkBox11.Checked = False
        checkBox12.Checked = False
        checkBox13.Checked = False
        checkBox14.Checked = False
        checkBox15.Checked = False
        checkBox16.Checked = False
        checkBox17.Checked = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Clear()
    End Sub

End Class