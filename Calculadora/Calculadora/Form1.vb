Public Class Calculadora
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdconvertir.Click
        If cbxentrada.Text = "Pie cuadrado" And cbxsalida.Text = "Pie cuadrado" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "ft²"
        ElseIf cbxentrada.Text = "Pie cudrado" And cbxsalida.Text = "Vara cuadrada" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "v² "
        ElseIf cbxentrada.Text = "Pie cuadrado" And cbxsalida.Text = "Yarda cuadrado" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "yd²"
        ElseIf cbxentrada.Text = "Pie cuadrado" And cbxsalida.Text = "Metro cuadrado" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "m²"
        ElseIf cbxentrada.Text = "Pie cuadrado" And cbxsalida.Text = "Tareas" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Tareas"
        ElseIf cbxentrada.Text = "Pie cuadrado" And cbxsalida.Text = "Manzana" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "mz"
        ElseIf cbxentrada.Text = "Pie cuadrado" And cbxsalida.Text = "Hectarea" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "hm²"
        End If

        If cbxentrada.Text = "Vara cuadrada" And cbxsalida.Text = "Vara cuadrada" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "v²"
        ElseIf cbxentrada.Text = "Vara cuadrada" And cbxsalida.Text = "Pie cuadrado" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "ft²"
        ElseIf cbxentrada.Text = "Vara cuadrada" And cbxsalida.Text = "Yarda cuadrado" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "yd²"
        ElseIf cbxentrada.Text = "Vara cuadrada" And cbxsalida.Text = "Metro cuadrado" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "m²"
        ElseIf cbxentrada.Text = "Vara cuadrada" And cbxsalida.Text = "Tareas" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Tareas"
        ElseIf cbxentrada.Text = "Vara cuadrado" And cbxsalida.Text = "Manzana" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "mz"
        ElseIf cbxentrada.Text = "Vara cuadrado" And cbxsalida.Text = "Hectarea" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "hm²"
        End If

        If cbxentrada.Text = "Yarda cuadrada" And cbxsalida.Text = "Yarda cuadrada" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "yd²"
        ElseIf cbxentrada.Text = "Yarda cuadrada" And cbxsalida.Text = "Pie cuadrado" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "ft²"
        ElseIf cbxentrada.Text = "Yarda cuadrada" And cbxsalida.Text = "Vara cuadrado" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "v²"
        ElseIf cbxentrada.Text = "Yarda cuadrada" And cbxsalida.Text = "Metro cuadrado" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "m²"
        ElseIf cbxentrada.Text = "Yarda cuadrada" And cbxsalida.Text = "Tareas" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Tareas"
        ElseIf cbxentrada.Text = "Yarda cuadrado" And cbxsalida.Text = "Manzana" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "mz"
        ElseIf cbxentrada.Text = "Yarda cuadrado" And cbxsalida.Text = "Hectarea" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "hm²"
        End If


    End Sub
End Class
