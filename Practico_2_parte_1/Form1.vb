Public Class ventana_principal
    Private Sub txt_input_TextChanged(sender As Object, e As EventArgs) Handles txt_input.TextChanged
        txt_input.Text = Conversor_Celsius_Fahrenheit(Val(txt_input), True)
    End Sub

    Private Sub ventana_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txt_input.KeyPress, AddressOf Solo_numeros
    End Sub
End Class
