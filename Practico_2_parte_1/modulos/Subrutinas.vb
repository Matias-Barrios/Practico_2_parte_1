Module Subrutinas

    Function Conversor_Celsius_Fahrenheit(valor As Double, es_celsius As Integer) As Double
        If es_celsius Then
            Return (valor * 1.8) + 32
        End If
        Return (valor - 32) * 0.5556
    End Function
    Public Sub Solo_numeros(ob As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Not e.KeyChar Like "[0-9]" And Not Asc(e.KeyChar) = "8" Then
            e.Handled = True
        End If
    End Sub

    Public Function revertir(input As String) As String
        Dim resultado As String = ""
        For Each letra In input
            resultado = letra & resultado
        Next
        Return resultado
    End Function

    Public Function contar_cifras(input As String) As Integer
        Return input.Count()
    End Function
    Public Function remover_caracter(input As String, caracter As Char) As String
        Return input.Replace(caracter, "")
    End Function
    Public Function calcular_IVA(precio As Double) As Double
        Return precio + (precio * 0.22)
    End Function
    Public Function Calcular_costo_alquiler(tipo As Char, Fecha_alquiler As DateTime, dias As Integer, Fecha_devolucion As DateTime) As String
        Dim precio_x_dia As Integer = 0
        Dim costo_por_dias As Integer = 0
        If tipo = "A" Then
            precio_x_dia = 100
        End If
        If tipo = "C" Then
            precio_x_dia = 120
        End If
        If dias > 7 Then
            costo_por_dias = (dias * precio_x_dia) - ((dias * precio_x_dia) * 0.25)
        Else
            costo_por_dias = (dias * precio_x_dia)
        End If

        Dim deberia_devolverse As Date = DateAdd(DateInterval.Day, dias, Fecha_alquiler)
        Dim demora As Integer = (Fecha_devolucion - deberia_devolverse).TotalDays

        If demora > 0 Then
            Return "Su alquiler sufrio una mora de " & demora & " dias. Deberia haber devuelto el mismo el " & deberia_devolverse.ToShortDateString() & " El costo
                    total del alquiler es de " & costo_por_dias + (demora * 15 + (precio_x_dia * demora))
        Else
            Return "El costo total del alquiler es de " & costo_por_dias
        End If

    End Function
End Module
