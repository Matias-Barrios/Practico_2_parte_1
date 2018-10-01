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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_input = New System.Windows.Forms.TextBox()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.lbl_reverso = New System.Windows.Forms.Label()
        Me.txt_input_reverso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tab_Principal.SuspendLayout()
        Me.tab_Conversor_celsius.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_Principal
        '
        Me.tab_Principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_Principal.Controls.Add(Me.tab_Conversor_celsius)
        Me.tab_Principal.Controls.Add(Me.TabPage2)
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbl_reverso)
        Me.TabPage2.Controls.Add(Me.txt_input_reverso)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(763, 553)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Revertir"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_Principal As TabControl
    Friend WithEvents tab_Conversor_celsius As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbl_resultado As Label
    Friend WithEvents txt_input As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_reverso As Label
    Friend WithEvents txt_input_reverso As TextBox
    Friend WithEvents Label3 As Label
End Class
