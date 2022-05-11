<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GRUP_CIFRADOS = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.V_K = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.V_P = New System.Windows.Forms.TextBox()
        Me.V_Q = New System.Windows.Forms.TextBox()
        Me.T_CLARO = New System.Windows.Forms.TextBox()
        Me.T_CIFRADO = New System.Windows.Forms.TextBox()
        Me.T_DESCIFRADO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VER_TABLA = New System.Windows.Forms.Button()
        Me.VER_CIFRADO = New System.Windows.Forms.Button()
        Me.VER_DESCIFRADO = New System.Windows.Forms.Button()
        Me.LIMPIAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GRUP_CIFRADOS
        '
        Me.GRUP_CIFRADOS.FormattingEnabled = True
        Me.GRUP_CIFRADOS.Items.AddRange(New Object() {"Cifrado de Cesar", "Encadenamiento de bloques cifrado (n aleatorio)", "Cifrado RSA"})
        Me.GRUP_CIFRADOS.Location = New System.Drawing.Point(12, 32)
        Me.GRUP_CIFRADOS.Name = "GRUP_CIFRADOS"
        Me.GRUP_CIFRADOS.Size = New System.Drawing.Size(185, 28)
        Me.GRUP_CIFRADOS.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TIPO DE CIFRADO:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "VALOR DE K:"
        '
        'V_K
        '
        Me.V_K.Location = New System.Drawing.Point(323, 34)
        Me.V_K.Name = "V_K"
        Me.V_K.Size = New System.Drawing.Size(100, 26)
        Me.V_K.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TEXTO EN CLARO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "TEXTO CIFRADO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "TEXTO DESCIFRADO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(434, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "VALOR DE P:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(549, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "VALOR DE Q"
        '
        'V_P
        '
        Me.V_P.Location = New System.Drawing.Point(438, 34)
        Me.V_P.Name = "V_P"
        Me.V_P.Size = New System.Drawing.Size(100, 26)
        Me.V_P.TabIndex = 9
        '
        'V_Q
        '
        Me.V_Q.Location = New System.Drawing.Point(553, 34)
        Me.V_Q.Name = "V_Q"
        Me.V_Q.Size = New System.Drawing.Size(100, 26)
        Me.V_Q.TabIndex = 10
        '
        'T_CLARO
        '
        Me.T_CLARO.Location = New System.Drawing.Point(12, 207)
        Me.T_CLARO.Name = "T_CLARO"
        Me.T_CLARO.Size = New System.Drawing.Size(168, 26)
        Me.T_CLARO.TabIndex = 11
        '
        'T_CIFRADO
        '
        Me.T_CIFRADO.Location = New System.Drawing.Point(12, 274)
        Me.T_CIFRADO.Name = "T_CIFRADO"
        Me.T_CIFRADO.Size = New System.Drawing.Size(168, 26)
        Me.T_CIFRADO.TabIndex = 12
        '
        'T_DESCIFRADO
        '
        Me.T_DESCIFRADO.Location = New System.Drawing.Point(12, 364)
        Me.T_DESCIFRADO.Name = "T_DESCIFRADO"
        Me.T_DESCIFRADO.Size = New System.Drawing.Size(168, 26)
        Me.T_DESCIFRADO.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(319, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "PROCEDIMIENTO:"
        '
        'VER_TABLA
        '
        Me.VER_TABLA.Location = New System.Drawing.Point(63, 96)
        Me.VER_TABLA.Name = "VER_TABLA"
        Me.VER_TABLA.Size = New System.Drawing.Size(134, 53)
        Me.VER_TABLA.TabIndex = 15
        Me.VER_TABLA.Text = "Ver tabla:"
        Me.VER_TABLA.UseVisualStyleBackColor = True
        '
        'VER_CIFRADO
        '
        Me.VER_CIFRADO.Location = New System.Drawing.Point(203, 89)
        Me.VER_CIFRADO.Name = "VER_CIFRADO"
        Me.VER_CIFRADO.Size = New System.Drawing.Size(121, 66)
        Me.VER_CIFRADO.TabIndex = 16
        Me.VER_CIFRADO.Text = "VER CIFRADO"
        Me.VER_CIFRADO.UseVisualStyleBackColor = True
        '
        'VER_DESCIFRADO
        '
        Me.VER_DESCIFRADO.Location = New System.Drawing.Point(342, 89)
        Me.VER_DESCIFRADO.Name = "VER_DESCIFRADO"
        Me.VER_DESCIFRADO.Size = New System.Drawing.Size(136, 66)
        Me.VER_DESCIFRADO.TabIndex = 17
        Me.VER_DESCIFRADO.Text = "VER DESCIFRADO"
        Me.VER_DESCIFRADO.UseVisualStyleBackColor = True
        '
        'LIMPIAR
        '
        Me.LIMPIAR.Location = New System.Drawing.Point(484, 107)
        Me.LIMPIAR.Name = "LIMPIAR"
        Me.LIMPIAR.Size = New System.Drawing.Size(105, 31)
        Me.LIMPIAR.TabIndex = 18
        Me.LIMPIAR.Text = "LIMPIAR"
        Me.LIMPIAR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(667, 450)
        Me.Controls.Add(Me.LIMPIAR)
        Me.Controls.Add(Me.VER_DESCIFRADO)
        Me.Controls.Add(Me.VER_CIFRADO)
        Me.Controls.Add(Me.VER_TABLA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.T_DESCIFRADO)
        Me.Controls.Add(Me.T_CIFRADO)
        Me.Controls.Add(Me.T_CLARO)
        Me.Controls.Add(Me.V_Q)
        Me.Controls.Add(Me.V_P)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.V_K)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GRUP_CIFRADOS)
        Me.Name = "Form1"
        Me.Text = "CIFRADOS SIMETRICOS Y ASIMETRICOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GRUP_CIFRADOS As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents V_K As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents V_P As TextBox
    Friend WithEvents V_Q As TextBox
    Friend WithEvents T_CLARO As TextBox
    Friend WithEvents T_CIFRADO As TextBox
    Friend WithEvents T_DESCIFRADO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents VER_TABLA As Button
    Friend WithEvents VER_CIFRADO As Button
    Friend WithEvents VER_DESCIFRADO As Button
    Friend WithEvents LIMPIAR As Button
End Class
