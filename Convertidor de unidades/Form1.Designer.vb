<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.opcion1 = New System.Windows.Forms.ComboBox()
        Me.opcion2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nc = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.um = New System.Windows.Forms.Label()
        Me.Lbr = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conversor de unidades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "convertir de:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "A:"
        '
        'opcion1
        '
        Me.opcion1.AutoCompleteCustomSource.AddRange(New String() {"Kilogramos", "Gramos", "Libras", "Onza"})
        Me.opcion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.opcion1.FormattingEnabled = True
        Me.opcion1.Items.AddRange(New Object() {"Kilogramos", "Gramos", "Libras"})
        Me.opcion1.Location = New System.Drawing.Point(102, 159)
        Me.opcion1.Name = "opcion1"
        Me.opcion1.Size = New System.Drawing.Size(121, 21)
        Me.opcion1.TabIndex = 4
        '
        'opcion2
        '
        Me.opcion2.AutoCompleteCustomSource.AddRange(New String() {"Kilogramos", "Gramos", "Libras", "Onza"})
        Me.opcion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.opcion2.FormattingEnabled = True
        Me.opcion2.Items.AddRange(New Object() {"Kilogramos", "Gramos", "Libras"})
        Me.opcion2.Location = New System.Drawing.Point(268, 159)
        Me.opcion2.Name = "opcion2"
        Me.opcion2.Size = New System.Drawing.Size(121, 21)
        Me.opcion2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ingrese el numero a convertir"
        '
        'nc
        '
        Me.nc.Location = New System.Drawing.Point(233, 97)
        Me.nc.Name = "nc"
        Me.nc.Size = New System.Drawing.Size(100, 20)
        Me.nc.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.um)
        Me.GroupBox1.Controls.Add(Me.Lbr)
        Me.GroupBox1.Location = New System.Drawing.Point(151, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 88)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado"
        '
        'um
        '
        Me.um.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.um.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.um.Location = New System.Drawing.Point(78, 35)
        Me.um.Name = "um"
        Me.um.Size = New System.Drawing.Size(37, 23)
        Me.um.TabIndex = 1
        '
        'Lbr
        '
        Me.Lbr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbr.Location = New System.Drawing.Point(36, 35)
        Me.Lbr.Name = "Lbr"
        Me.Lbr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbr.Size = New System.Drawing.Size(39, 23)
        Me.Lbr.TabIndex = 0
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(79, 358)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 9
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.opcion2)
        Me.Controls.Add(Me.opcion1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents opcion1 As ComboBox
    Friend WithEvents opcion2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nc As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents um As Label
    Friend WithEvents Lbr As Label
    Friend WithEvents Calcular As Button
    Friend WithEvents Button1 As Button
End Class
