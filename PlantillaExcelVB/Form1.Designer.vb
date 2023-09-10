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
        Me.BTNexcel = New System.Windows.Forms.Button()
        Me.DGVtabla = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNexcel
        '
        Me.BTNexcel.BackColor = System.Drawing.Color.OldLace
        Me.BTNexcel.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNexcel.Location = New System.Drawing.Point(12, 396)
        Me.BTNexcel.Name = "BTNexcel"
        Me.BTNexcel.Size = New System.Drawing.Size(75, 42)
        Me.BTNexcel.TabIndex = 0
        Me.BTNexcel.Text = "EXCEL"
        Me.BTNexcel.UseVisualStyleBackColor = False
        '
        'DGVtabla
        '
        Me.DGVtabla.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.DGVtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVtabla.Location = New System.Drawing.Point(12, 42)
        Me.DGVtabla.Name = "DGVtabla"
        Me.DGVtabla.Size = New System.Drawing.Size(620, 348)
        Me.DGVtabla.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PLANTILLA EXCEL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(652, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVtabla)
        Me.Controls.Add(Me.BTNexcel)
        Me.Name = "Form1"
        Me.Text = "PLANTILLA EXCEL"
        CType(Me.DGVtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNexcel As Button
    Friend WithEvents DGVtabla As DataGridView
    Friend WithEvents Label1 As Label
End Class
