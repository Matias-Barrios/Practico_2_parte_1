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
        Dim resultado As String
        For Each letra In input
            resultado = letra & resultado
        Next
        Return resultado
    End Function
End Module
