Public Class Calculadora
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs)
        Dim ntabla As SByte
        ntabla = txtntabla.Text

        For i = 1 To 10
            lstTablas.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
        Next

    End Sub

End Class
