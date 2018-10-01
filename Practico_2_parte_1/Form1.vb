Public Class ventana_principal
    Private Sub txt_input_TextChanged(sender As Object, e As EventArgs) Handles txt_input.TextChanged
        If String.IsNullOrEmpty(sender.Text) Then
            sender.Text = 0
        End If
        lbl_resultado.Text = Conversor_Celsius_Fahrenheit(Val(txt_input.Text), True)
    End Sub

    Private Sub ventana_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txt_input.KeyPress, AddressOf Solo_numeros
    End Sub

    Private Sub txt_input_reverso_TextChanged(sender As Object, e As EventArgs) Handles txt_input_reverso.TextChanged
        lbl_reverso.Text = revertir(sender.Text)
    End Sub
End Class
