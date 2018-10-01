<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tab_Principal = New System.Windows.Forms.TabControl()
        Me.tab_Conversor_celsius = New System.Windows.Forms.TabPage()
        Me.tab_reverso = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_input = New System.Windows.Forms.TextBox()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.lbl_reverso = New System.Windows.Forms.Label()
        Me.txt_input_reverso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tab_cifras = New System.Windows.Forms.TabPage()
        Me.lbl_cifras_resultado = New System.Windows.Forms.Label()
        Me.txt_cifras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tab_eliminar_caracter = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_frase_para_borrar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_caracter_borrar = New System.Windows.Forms.TextBox()
        Me.tab_calcular_IVA = New System.Windows.Forms.TabPage()
        Me.lbl_iva_resultado = New System.Windows.Forms.Label()
        Me.txt_iva_precio_producto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tab_autos_alquiler = New System.Windows.Forms.TabPage()
        Me.label_alquiler_autos = New System.Windows.Forms.Label()
        Me.tab_venta_productos = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_productos = New System.Windows.Forms.DataGridView()
        Me.cmbo_productos = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nup_cantidad_productos = New System.Windows.Forms.NumericUpDown()
        Me.btn_agregar_producto = New System.Windows.Forms.Button()
        Me.tab_Principal.SuspendLayout()
        Me.tab_Conversor_celsius.SuspendLayout()
        Me.tab_reverso.SuspendLayout()
        Me.tab_cifras.SuspendLayout()
        Me.tab_eliminar_caracter.SuspendLayout()
        Me.tab_calcular_IVA.SuspendLayout()
        Me.tab_autos_alquiler.SuspendLayout()
        Me.tab_venta_productos.SuspendLayout()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nup_cantidad_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_Principal
        '
        Me.tab_Principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_Principal.Controls.Add(Me.tab_Conversor_celsius)
        Me.tab_Principal.Controls.Add(Me.tab_reverso)
        Me.tab_Principal.Controls.Add(Me.tab_cifras)
        Me.tab_Principal.Controls.Add(Me.tab_eliminar_caracter)
        Me.tab_Principal.Controls.Add(Me.tab_calcular_IVA)
        Me.tab_Principal.Controls.Add(Me.tab_autos_alquiler)
        Me.tab_Principal.Controls.Add(Me.tab_venta_productos)
        Me.tab_Principal.Location = New System.Drawing.Point(8, 6)
        Me.tab_Principal.Name = "tab_Principal"
        Me.tab_Principal.SelectedIndex = 0
        Me.tab_Principal.Size = New System.Drawing.Size(771, 579)
        Me.tab_Principal.TabIndex = 0
        '
        'tab_Conversor_celsius
        '
        Me.tab_Conversor_celsius.Controls.Add(Me.lbl_resultado)
        Me.tab_Conversor_celsius.Controls.Add(Me.txt_input)
        Me.tab_Conversor_celsius.Controls.Add(Me.Label1)
        Me.tab_Conversor_celsius.Location = New System.Drawing.Point(4, 22)
        Me.tab_Conversor_celsius.Name = "tab_Conversor_celsius"
        Me.tab_Conversor_celsius.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Conversor_celsius.Size = New System.Drawing.Size(763, 553)
        Me.tab_Conversor_celsius.TabIndex = 0
        Me.tab_Conversor_celsius.Text = "Conversor Celisus"
        Me.tab_Conversor_celsius.UseVisualStyleBackColor = True
        '
        'tab_reverso
        '
        Me.tab_reverso.Controls.Add(Me.lbl_reverso)
        Me.tab_reverso.Controls.Add(Me.txt_input_reverso)
        Me.tab_reverso.Controls.Add(Me.Label3)
        Me.tab_reverso.Location = New System.Drawing.Point(4, 22)
        Me.tab_reverso.Name = "tab_reverso"
        Me.tab_reverso.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_reverso.Size = New System.Drawing.Size(763, 553)
        Me.tab_reverso.TabIndex = 1
        Me.tab_reverso.Text = "Revertir"
        Me.tab_reverso.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 179)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduzca una remperatura en grados Celsius para obtener su valor en Fahrenheit"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_input
        '
        Me.txt_input.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_input.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_input.Location = New System.Drawing.Point(155, 177)
        Me.txt_input.MaxLength = 10
        Me.txt_input.Name = "txt_input"
        Me.txt_input.Size = New System.Drawing.Size(453, 50)
        Me.txt_input.TabIndex = 1
        Me.txt_input.Text = "0"
        '
        'lbl_resultado
        '
        Me.lbl_resultado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_resultado.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_resultado.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbl_resultado.Location = New System.Drawing.Point(106, 289)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(550, 179)
        Me.lbl_resultado.TabIndex = 2
        Me.lbl_resultado.Text = "32"
        Me.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_reverso
        '
        Me.lbl_reverso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_reverso.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reverso.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbl_reverso.Location = New System.Drawing.Point(36, 371)
        Me.lbl_reverso.Name = "lbl_reverso"
        Me.lbl_reverso.Size = New System.Drawing.Size(690, 179)
        Me.lbl_reverso.TabIndex = 5
        Me.lbl_reverso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_input_reverso
        '
        Me.txt_input_reverso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_input_reverso.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_input_reverso.Location = New System.Drawing.Point(36, 209)
        Me.txt_input_reverso.MaxLength = 10
        Me.txt_input_reverso.Multiline = True
        Me.txt_input_reverso.Name = "txt_input_reverso"
        Me.txt_input_reverso.Size = New System.Drawing.Size(690, 160)
        Me.txt_input_reverso.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(550, 179)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Introduzca una palabra para ver el reverso de la misma"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_cifras
        '
        Me.tab_cifras.Controls.Add(Me.lbl_cifras_resultado)
        Me.tab_cifras.Controls.Add(Me.txt_cifras)
        Me.tab_cifras.Controls.Add(Me.Label4)
        Me.tab_cifras.Location = New System.Drawing.Point(4, 22)
        Me.tab_cifras.Name = "tab_cifras"
        Me.tab_cifras.Size = New System.Drawing.Size(763, 553)
        Me.tab_cifras.TabIndex = 2
        Me.tab_cifras.Text = "Cifras"
        Me.tab_cifras.UseVisualStyleBackColor = True
        '
        'lbl_cifras_resultado
        '
        Me.lbl_cifras_resultado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_cifras_resultado.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cifras_resultado.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbl_cifras_resultado.Location = New System.Drawing.Point(106, 321)
        Me.lbl_cifras_resultado.Name = "lbl_cifras_resultado"
        Me.lbl_cifras_resultado.Size = New System.Drawing.Size(550, 179)
        Me.lbl_cifras_resultado.TabIndex = 5
        Me.lbl_cifras_resultado.Text = "0"
        Me.lbl_cifras_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_cifras
        '
        Me.txt_cifras.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cifras.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cifras.Location = New System.Drawing.Point(155, 209)
        Me.txt_cifras.MaxLength = 10
        Me.txt_cifras.Name = "txt_cifras"
        Me.txt_cifras.Size = New System.Drawing.Size(453, 50)
        Me.txt_cifras.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(550, 179)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Introduzca un numero para ver el numero de cifras que posee"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_eliminar_caracter
        '
        Me.tab_eliminar_caracter.Controls.Add(Me.txt_caracter_borrar)
        Me.tab_eliminar_caracter.Controls.Add(Me.Label7)
        Me.tab_eliminar_caracter.Controls.Add(Me.Label6)
        Me.tab_eliminar_caracter.Controls.Add(Me.Label2)
        Me.tab_eliminar_caracter.Controls.Add(Me.txt_frase_para_borrar)
        Me.tab_eliminar_caracter.Controls.Add(Me.Label5)
        Me.tab_eliminar_caracter.Location = New System.Drawing.Point(4, 22)
        Me.tab_eliminar_caracter.Name = "tab_eliminar_caracter"
        Me.tab_eliminar_caracter.Size = New System.Drawing.Size(763, 553)
        Me.tab_eliminar_caracter.TabIndex = 3
        Me.tab_eliminar_caracter.Text = "Eliminar Caracter"
        Me.tab_eliminar_caracter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label2.Location = New System.Drawing.Point(3, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(756, 179)
        Me.Label2.TabIndex = 5
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_frase_para_borrar
        '
        Me.txt_frase_para_borrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_frase_para_borrar.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_frase_para_borrar.Location = New System.Drawing.Point(3, 123)
        Me.txt_frase_para_borrar.MaxLength = 250
        Me.txt_frase_para_borrar.Multiline = True
        Me.txt_frase_para_borrar.Name = "txt_frase_para_borrar"
        Me.txt_frase_para_borrar.Size = New System.Drawing.Size(756, 156)
        Me.txt_frase_para_borrar.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, -9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(550, 132)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Introduzca una frase en la caja de texto y a continuacion un caracter que desee b" &
    "orrar de la misma"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 37)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Frase"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 39)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Caracter"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_caracter_borrar
        '
        Me.txt_caracter_borrar.Location = New System.Drawing.Point(139, 299)
        Me.txt_caracter_borrar.MaxLength = 1
        Me.txt_caracter_borrar.Name = "txt_caracter_borrar"
        Me.txt_caracter_borrar.Size = New System.Drawing.Size(37, 20)
        Me.txt_caracter_borrar.TabIndex = 8
        '
        'tab_calcular_IVA
        '
        Me.tab_calcular_IVA.Controls.Add(Me.lbl_iva_resultado)
        Me.tab_calcular_IVA.Controls.Add(Me.txt_iva_precio_producto)
        Me.tab_calcular_IVA.Controls.Add(Me.Label9)
        Me.tab_calcular_IVA.Location = New System.Drawing.Point(4, 22)
        Me.tab_calcular_IVA.Name = "tab_calcular_IVA"
        Me.tab_calcular_IVA.Size = New System.Drawing.Size(763, 553)
        Me.tab_calcular_IVA.TabIndex = 4
        Me.tab_calcular_IVA.Text = "Calcular IVA"
        Me.tab_calcular_IVA.UseVisualStyleBackColor = True
        '
        'lbl_iva_resultado
        '
        Me.lbl_iva_resultado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_iva_resultado.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_iva_resultado.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbl_iva_resultado.Location = New System.Drawing.Point(106, 321)
        Me.lbl_iva_resultado.Name = "lbl_iva_resultado"
        Me.lbl_iva_resultado.Size = New System.Drawing.Size(550, 179)
        Me.lbl_iva_resultado.TabIndex = 5
        Me.lbl_iva_resultado.Text = "0"
        Me.lbl_iva_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_iva_precio_producto
        '
        Me.txt_iva_precio_producto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_iva_precio_producto.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_iva_precio_producto.Location = New System.Drawing.Point(155, 209)
        Me.txt_iva_precio_producto.MaxLength = 10
        Me.txt_iva_precio_producto.Name = "txt_iva_precio_producto"
        Me.txt_iva_precio_producto.Size = New System.Drawing.Size(453, 50)
        Me.txt_iva_precio_producto.TabIndex = 4
        Me.txt_iva_precio_producto.Text = "0"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(106, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(550, 179)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Introduzca el valor del producto y se le calculara el IVA ( 22 % ) "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab_autos_alquiler
        '
        Me.tab_autos_alquiler.Controls.Add(Me.label_alquiler_autos)
        Me.tab_autos_alquiler.Location = New System.Drawing.Point(4, 22)
        Me.tab_autos_alquiler.Name = "tab_autos_alquiler"
        Me.tab_autos_alquiler.Size = New System.Drawing.Size(763, 553)
        Me.tab_autos_alquiler.TabIndex = 5
        Me.tab_autos_alquiler.Text = "Alquiler Autos"
        Me.tab_autos_alquiler.UseVisualStyleBackColor = True
        '
        'label_alquiler_autos
        '
        Me.label_alquiler_autos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_alquiler_autos.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_alquiler_autos.ForeColor = System.Drawing.Color.LimeGreen
        Me.label_alquiler_autos.Location = New System.Drawing.Point(15, 14)
        Me.label_alquiler_autos.Name = "label_alquiler_autos"
        Me.label_alquiler_autos.Size = New System.Drawing.Size(733, 527)
        Me.label_alquiler_autos.TabIndex = 6
        '
        'tab_venta_productos
        '
        Me.tab_venta_productos.Controls.Add(Me.btn_agregar_producto)
        Me.tab_venta_productos.Controls.Add(Me.nup_cantidad_productos)
        Me.tab_venta_productos.Controls.Add(Me.Label10)
        Me.tab_venta_productos.Controls.Add(Me.cmbo_productos)
        Me.tab_venta_productos.Controls.Add(Me.dgv_productos)
        Me.tab_venta_productos.Controls.Add(Me.Label8)
        Me.tab_venta_productos.Location = New System.Drawing.Point(4, 22)
        Me.tab_venta_productos.Name = "tab_venta_productos"
        Me.tab_venta_productos.Size = New System.Drawing.Size(763, 553)
        Me.tab_venta_productos.TabIndex = 6
        Me.tab_venta_productos.Text = "Venta Productos"
        Me.tab_venta_productos.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(760, 92)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Introduzca un producto y su cantidad"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_productos
        '
        Me.dgv_productos.AllowUserToAddRows = False
        Me.dgv_productos.AllowUserToDeleteRows = False
        Me.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_productos.Location = New System.Drawing.Point(13, 117)
        Me.dgv_productos.Name = "dgv_productos"
        Me.dgv_productos.ReadOnly = True
        Me.dgv_productos.Size = New System.Drawing.Size(733, 389)
        Me.dgv_productos.TabIndex = 2
        '
        'cmbo_productos
        '
        Me.cmbo_productos.FormattingEnabled = True
        Me.cmbo_productos.Items.AddRange(New Object() {"Agua Jane - $10", "Queso - $120", "Salame - $26", "Pan - $50", "Whisky - $60", "Bananas - $20", "Tortas - $20"})
        Me.cmbo_productos.Location = New System.Drawing.Point(13, 90)
        Me.cmbo_productos.Name = "cmbo_productos"
        Me.cmbo_productos.Size = New System.Drawing.Size(536, 21)
        Me.cmbo_productos.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label10.Location = New System.Drawing.Point(8, 511)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 29)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "0"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nup_cantidad_productos
        '
        Me.nup_cantidad_productos.Location = New System.Drawing.Point(555, 90)
        Me.nup_cantidad_productos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nup_cantidad_productos.Name = "nup_cantidad_productos"
        Me.nup_cantidad_productos.Size = New System.Drawing.Size(120, 20)
        Me.nup_cantidad_productos.TabIndex = 7
        Me.nup_cantidad_productos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_agregar_producto
        '
        Me.btn_agregar_producto.Location = New System.Drawing.Point(682, 90)
        Me.btn_agregar_producto.Name = "btn_agregar_producto"
        Me.btn_agregar_producto.Size = New System.Drawing.Size(63, 20)
        Me.btn_agregar_producto.TabIndex = 8
        Me.btn_agregar_producto.Text = "Agregar"
        Me.btn_agregar_producto.UseVisualStyleBackColor = True
        '
        'ventana_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 595)
        Me.Controls.Add(Me.tab_Principal)
        Me.Name = "ventana_principal"
        Me.Text = "Ventana Principal"
        Me.tab_Principal.ResumeLayout(False)
        Me.tab_Conversor_celsius.ResumeLayout(False)
        Me.tab_Conversor_celsius.PerformLayout()
        Me.tab_reverso.ResumeLayout(False)
        Me.tab_reverso.PerformLayout()
        Me.tab_cifras.ResumeLayout(False)
        Me.tab_cifras.PerformLayout()
        Me.tab_eliminar_caracter.ResumeLayout(False)
        Me.tab_eliminar_caracter.PerformLayout()
        Me.tab_calcular_IVA.ResumeLayout(False)
        Me.tab_calcular_IVA.PerformLayout()
        Me.tab_autos_alquiler.ResumeLayout(False)
        Me.tab_venta_productos.ResumeLayout(False)
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nup_cantidad_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_Principal As TabControl
    Friend WithEvents tab_Conversor_celsius As TabPage
    Friend WithEvents tab_reverso As TabPage
    Friend WithEvents lbl_resultado As Label
    Friend WithEvents txt_input As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_reverso As Label
    Friend WithEvents txt_input_reverso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tab_cifras As TabPage
    Friend WithEvents lbl_cifras_resultado As Label
    Friend WithEvents txt_cifras As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tab_eliminar_caracter As TabPage
    Friend WithEvents txt_caracter_borrar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_frase_para_borrar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tab_calcular_IVA As TabPage
    Friend WithEvents lbl_iva_resultado As Label
    Friend WithEvents txt_iva_precio_producto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tab_autos_alquiler As TabPage
    Friend WithEvents label_alquiler_autos As Label
    Friend WithEvents tab_venta_productos As TabPage
    Friend WithEvents dgv_productos As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents nup_cantidad_productos As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbo_productos As ComboBox
    Friend WithEvents btn_agregar_producto As Button
End Class
