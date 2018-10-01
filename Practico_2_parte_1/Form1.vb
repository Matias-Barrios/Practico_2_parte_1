Imports System.Globalization

Public Class ventana_principal
    '' Aca se definen distintas cosas cuando carga la ventana
    '' 
    Dim mis_datos As New DataTable
    Private Sub ventana_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txt_input.KeyPress, AddressOf Solo_numeros
        AddHandler txt_cifras.KeyPress, AddressOf Solo_numeros
        AddHandler txt_iva_precio_producto.KeyPress, AddressOf Solo_numeros
        label_alquiler_autos.Text = Calcular_costo_alquiler("A", DateTime.ParseExact("10/01/2018", "dd/mm/yyyy", CultureInfo.InvariantCulture), 7, DateTime.ParseExact("19/01/2018", "dd/mm/yyyy", CultureInfo.InvariantCulture))

        mis_datos.Columns.Add(New DataColumn("Producto", GetType(String)))
        mis_datos.Columns.Add(New DataColumn("Cantidad", GetType(Integer)))
        mis_datos.Columns.Add(New DataColumn("Precio unitario", GetType(Integer)))
        mis_datos.Columns.Add(New DataColumn("Precio total", GetType(Integer)))
        dgv_productos.DataSource = mis_datos
    End Sub
    '' FIN CARGA VENTANA

    Private Sub txt_input_TextChanged(sender As Object, e As EventArgs) Handles txt_input.TextChanged
        If String.IsNullOrEmpty(sender.Text) Then
            sender.Text = 0
        End If
        lbl_resultado.Text = Conversor_Celsius_Fahrenheit(Val(txt_input.Text), True)
    End Sub

    Private Sub txt_input_reverso_TextChanged(sender As Object, e As EventArgs) Handles txt_input_reverso.TextChanged
        lbl_reverso.Text = revertir(sender.Text)
    End Sub

    Private Sub txt_cifras_TextChanged(sender As Object, e As EventArgs) Handles txt_cifras.TextChanged
        lbl_cifras_resultado.Text = contar_cifras(txt_cifras.Text)
    End Sub

    Private Sub txt_caracter_borrar_TextChanged(sender As Object, e As EventArgs) Handles txt_caracter_borrar.TextChanged
        txt_frase_para_borrar.Text = remover_caracter(txt_frase_para_borrar.Text, txt_caracter_borrar.Text)
    End Sub

    Private Sub txt_iva_precio_producto_TextChanged(sender As Object, e As EventArgs) Handles txt_iva_precio_producto.TextChanged
        If String.IsNullOrEmpty(sender.Text) Then
            sender.Text = 0
        End If
        lbl_iva_resultado.Text = calcular_IVA(Val(txt_iva_precio_producto.Text))
    End Sub

    Private Sub btn_agregar_producto_Click(sender As Object, e As EventArgs) Handles btn_agregar_producto.Click
        Console.WriteLine(Val(cmbo_productos.SelectedItem().ToString().Split("$")(1)).ToString())
        mis_datos.Rows.Add(New String() {cmbo_productos.SelectedItem().ToString().Split("- $")(0), nup_cantidad_productos.Value().ToString(), Val(cmbo_productos.SelectedItem().ToString().Split("$")(1).ToString()), (Val(cmbo_productos.SelectedItem().ToString().Split("$")(1)) * nup_cantidad_productos.Value()).ToString()})

    End Sub
End Class
