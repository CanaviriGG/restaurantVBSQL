<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conexion_Manual
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCnString = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar la cadena de conexion local"
        Me.Label1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(93, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(441, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Una vez que este listo dale a ""generar cadena de conexion"" se creara un archivo q" &
    "ue contendra tu conexion Encryptada. Ahora tu conexion es mas segura ante posibl" &
    "es hacks"
        Me.Label2.UseWaitCursor = True
        '
        'txtCnString
        '
        Me.txtCnString.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCnString.Location = New System.Drawing.Point(96, 126)
        Me.txtCnString.Name = "txtCnString"
        Me.txtCnString.Size = New System.Drawing.Size(364, 26)
        Me.txtCnString.TabIndex = 2
        Me.txtCnString.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(96, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 44)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generar cadena de conexion"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(523, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Conexion_Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 259)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCnString)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Conexion_Manual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Una vez que este listo dale a ""generar cadena de conexion"" se creara un archivo q" &
    "ue contendra tu conexion Encryptada. "
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCnString As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
