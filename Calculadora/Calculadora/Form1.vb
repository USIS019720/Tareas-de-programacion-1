Public Class Calculadora

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdconvertir.Click

        If cbxentrada.Text = "Pie Cuadrado" And cbxsalida.Text = "Pie Cuadrado" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "ft²"
        ElseIf cbxentrada.Text = "Pie Cuadrado" And cbxsalida.Text = "Vara Cuadrada" Then
            lblr.Text = Val(txtvalor.Text) / 0.09290304 / 0.70258205
            lblum.Text = "v² "
        ElseIf cbxentrada.Text = "Pie Cuadrado" And cbxsalida.Text = "Yarda Cuadrada" Then
            lblr.Text = Val(txtvalor.Text) / 9
            lblum.Text = "yd²"
        ElseIf cbxentrada.Text = "Pie Cuadrado" And cbxsalida.Text = "Metro Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) / 10.764
            lblum.Text = "m²"
        ElseIf cbxentrada.Text = "Pie Cuadrado" And cbxsalida.Text = "Tareas" Then
            lblr.Text = Val(txtvalor.Text) / 0.09290304 / 628.8
            lblum.Text = "Tareas"
        ElseIf cbxentrada.Text = "Pie Cuadrado" And cbxsalida.Text = "Manzana" Then
            lblr.Text = Val(txtvalor.Text) / 0.09290304 / 70.44 * 100
            lblum.Text = "mz"
        ElseIf cbxentrada.Text = "Pie Cuadrado" And cbxsalida.Text = "Hectarea" Then
            lblr.Text = Val(txtvalor.Text) / 1007639
            lblum.Text = "hm²"
        End If

        If cbxentrada.Text = "Vara Cuadrada" And cbxsalida.Text = "Vara Cuadrada" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "v²"
        ElseIf cbxentrada.Text = "Vara Cuadrada" And cbxsalida.Text = "Pie Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) / 0.364634737201
            lblum.Text = "ft²"
        ElseIf cbxentrada.Text = "Vara Cuadrada" And cbxsalida.Text = "Yarda Cuadrada" Then
            lblr.Text = Val(txtvalor.Text) * 0.8357
            lblum.Text = "yd²"
        ElseIf cbxentrada.Text = "Vara Cuadrada" And cbxsalida.Text = "Metro Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) * 0.698896
            lblum.Text = "m²"
        ElseIf cbxentrada.Text = "Vara Cuadrada" And cbxsalida.Text = "Tareas" Then
            lblr.Text = Val(txtvalor.Text) * 0.0003556
            lblum.Text = "Tareas"
        ElseIf cbxentrada.Text = "Vara Cuadrada" And cbxsalida.Text = "Manzana" Then
            lblr.Text = Val(txtvalor.Text) * 0.0001
            lblum.Text = "mz"
        ElseIf cbxentrada.Text = "Vara Cuadrada" And cbxsalida.Text = "Hectarea" Then
            lblr.Text = Val(txtvalor.Text) * 0.00006987
            lblum.Text = "hm²"
        End If

        If cbxentrada.Text = "Yarda Cuadrada" And cbxsalida.Text = "Yarda Cuadrada" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "yd²"
        ElseIf cbxentrada.Text = "Yarda Cuadrada" And cbxsalida.Text = "Pie Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) * 9
            lblum.Text = "ft²"
        ElseIf cbxentrada.Text = "Yarda Cuadrada" And cbxsalida.Text = "Vara Cuadrada" Then
            lblr.Text = Val(txtvalor.Text) / 0.09290304 * 9 / 0.71684731
            lblum.Text = "v²"
        ElseIf cbxentrada.Text = "Yarda Cuadrada" And cbxsalida.Text = "Metro Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) / 1.196
            lblum.Text = "m²"
        ElseIf cbxentrada.Text = "Yarda Cuadrada" And cbxsalida.Text = "Tareas" Then
            lblr.Text = Val(txtvalor.Text) / 628.8 / 0.09290304 * 9
            lblum.Text = "Tareas"
        ElseIf cbxentrada.Text = "Yarda Cuadrada" And cbxsalida.Text = "Manzana" Then
            lblr.Text = Val(txtvalor.Text) / 0.09290304 * 9 / 70.44 * 100
            lblum.Text = "mz"
        ElseIf cbxentrada.Text = "Yarda Cuadrada" And cbxsalida.Text = "Hectarea" Then
            lblr.Text = Val(txtvalor.Text) / 11960
            lblum.Text = "hm²"
        End If

        If cbxentrada.Text = "Metro Cuadrado" And cbxsalida.Text = "Metro Cuadrado" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "m²"
        ElseIf cbxentrada.Text = "Metro Cuadrado" And cbxsalida.Text = "Pie Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) * 10.764
            lblum.Text = "ft²"
        ElseIf cbxentrada.Text = "Metro Cuadrado" And cbxsalida.Text = "Vara Cuadrada" Then
            lblr.Text = Val(label33.Text) * 1.431
            lblum.Text = "v²"
        ElseIf cbxentrada.Text = "Metro Cuadrado" And cbxsalida.Text = "Yarda Cuadrada" Then
            lblr.Text = Val(txtvalor.Text) * 1.196
            lblum.Text = "yd²"
        ElseIf cbxentrada.Text = "Metro Cuadrado" And cbxsalida.Text = "Tareas" Then
            lblr.Text = Val(txtvalor.Text) / 628.8
            lblum.Text = "Tareas"
        ElseIf cbxentrada.Text = "Metro Cuadrado" And cbxsalida.Text = "Manzana" Then
            lblr.Text = Val(txtvalor.Text) / 1 / 70.44 * 100
            lblum.Text = "mz"
        ElseIf cbxentrada.Text = "Metro Cuadrado" And cbxsalida.Text = "Hectarea" Then
            lblr.Text = Val(txtvalor.Text) / 10000
            lblum.Text = "hm²"
        End If

        If cbxentrada.Text = "Tareas" And cbxsalida.Text = "Tareas" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Tareas"
        ElseIf cbxentrada.Text = "Tareas" And cbxsalida.Text = "Pie Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) / 628.8 / 0.09290304
            lblum.Text = "ft²"
        ElseIf cbxentrada.Text = "Tareas" And cbxsalida.Text = "Vara Cuadrada" Then
            lblr.Text = Val(txtvalor.Text) / 628.8 / 0.70258205
            lblum.Text = "v²"
        ElseIf cbxentrada.Text = "Tareas" And cbxsalida.Text = "Yarda Cuadrada" Then
            lblr.Text = Val(txtvalor.Text) / 628.8 / 0.09290304 * 9
            lblum.Text = "yd²"
        ElseIf cbxentrada.Text = "Tareas" And cbxsalida.Text = "Metro Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) / 628.8 / 1
            lblum.Text = "m²"
        ElseIf cbxentrada.Text = "Tareas" And cbxsalida.Text = "Manzana" Then
            lblr.Text = Val(txtvalor.Text) / 628.8 / 70.44 * 100
            lblum.Text = "mz"
        ElseIf cbxentrada.Text = "Tareas" And cbxsalida.Text = "Hectarea" Then
            lblr.Text = Val(txtvalor.Text) / 10000 / 628.8
            lblum.Text = "hm²"
        End If

        If cbxentrada.Text = "Manzana" And cbxsalida.Text = "Manzana" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "mz"
        ElseIf cbxentrada.Text = "Manzana" And cbxsalida.Text = "Pie Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) / 10.44 * 100 / 0.09290304
            lblum.Text = "ft²"
        ElseIf cbxentrada.Text = "Manzana" And cbxsalida.Text = "Vara Cuadrada" Then
            lblr.Text = Val(txtvalor.Text) * 0.836
            lblum.Text = "v²"
        ElseIf cbxentrada.Text = "Manzana" And cbxsalida.Text = "Yarda Cuadrada" Then
            lblr.Text = Val(txtvalor.Text) / 0.9290304
            lblum.Text = "yd²"
        ElseIf cbxentrada.Text = "Manzana" And cbxsalida.Text = "Metro Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) * 0.6988
            lblum.Text = "m²"
        ElseIf cbxentrada.Text = "Manzana" And cbxsalida.Text = "Tareas" Then
            lblr.Text = Val(txtvalor.Text) * 15.903307888040711
            lblum.Text = "Tareas"
        ElseIf cbxentrada.Text = "Manzana" And cbxsalida.Text = "Hectarea" Then
            lblr.Text = Val(txtvalor.Text) / 10000
            lblum.Text = "hm²"
        End If

        If cbxentrada.Text = "Hectarea" And cbxsalida.Text = "Hectarea" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "hm²"
        ElseIf cbxentrada.Text = "Hectarea" And cbxsalida.Text = "Pie Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) * 107639
            lblum.Text = "ft²"
        ElseIf cbxentrada.Text = "Hectarea" And cbxsalida.Text = "Vara Cuadrada" Then
            lblr.Text = Val(txtvalor.Text) / 10000 / 0.70258205
            lblum.Text = "v²"
        ElseIf cbxentrada.Text = "Hectarea" And cbxsalida.Text = "Yarda Cuadrada" Then
            lblr.Text = Val(txtvalor.Text) * 11960
            lblum.Text = "yd²"
        ElseIf cbxentrada.Text = "Hectarea" And cbxsalida.Text = "Metro Cuadrado" Then
            lblr.Text = Val(txtvalor.Text) * 10000
            lblum.Text = "m²"
        ElseIf cbxentrada.Text = "Hectarea" And cbxsalida.Text = "Tareas" Then
            lblr.Text = Val(txtvalor.Text) / 10000 / 628.8
            lblum.Text = "Tareas"
        ElseIf cbxentrada.Text = "Hectarea" And cbxsalida.Text = "Manzana" Then
            lblr.Text = Val(txtvalor.Text) * 0.705
            lblum.Text = "mz"
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblr.Text = ""
        lblum.Text = ""
        txtvalor.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Scan, Fall, Respuesta As String
        Scan = txtScan.Text
        Fall = txtFall.Text
        Respuesta = txtRespuesta.Text

        txtRespuesta.Text = (Scan / Fall).ToString() + "/" + (Scan Mod Fall).ToString()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtScan.Text = ""
        txtFall.Text = ""
        txtRespuesta.Text = ""
    End Sub
End Class