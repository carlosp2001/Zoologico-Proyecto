<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEspecie
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
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtnombrecienti = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtnombrec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtespecieid = New System.Windows.Forms.TextBox()
        Me.cbxHabitat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvespecie = New System.Windows.Forms.DataGridView()
        CType(Me.dgvespecie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(119, 398)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(139, 69)
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(206, 300)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(139, 69)
        Me.btnEditar.TabIndex = 21
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(28, 300)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(139, 69)
        Me.btnIngresar.TabIndex = 20
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtnombrecienti
        '
        Me.txtnombrecienti.Location = New System.Drawing.Point(149, 132)
        Me.txtnombrecienti.Name = "txtnombrecienti"
        Me.txtnombrecienti.Size = New System.Drawing.Size(100, 23)
        Me.txtnombrecienti.TabIndex = 19
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(149, 181)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(100, 23)
        Me.txtdescripcion.TabIndex = 18
        '
        'txtnombrec
        '
        Me.txtnombrec.Location = New System.Drawing.Point(149, 87)
        Me.txtnombrec.Name = "txtnombrec"
        Me.txtnombrec.Size = New System.Drawing.Size(100, 23)
        Me.txtnombrec.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nombre Cientifico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre Comun:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Id Especie:"
        '
        'txtespecieid
        '
        Me.txtespecieid.Location = New System.Drawing.Point(149, 45)
        Me.txtespecieid.Name = "txtespecieid"
        Me.txtespecieid.Size = New System.Drawing.Size(100, 23)
        Me.txtespecieid.TabIndex = 12
        '
        'cbxHabitat
        '
        Me.cbxHabitat.FormattingEnabled = True
        Me.cbxHabitat.Location = New System.Drawing.Point(149, 236)
        Me.cbxHabitat.Name = "cbxHabitat"
        Me.cbxHabitat.Size = New System.Drawing.Size(121, 23)
        Me.cbxHabitat.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Habitat:"
        '
        'dgvespecie
        '
        Me.dgvespecie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvespecie.Location = New System.Drawing.Point(386, 12)
        Me.dgvespecie.Name = "dgvespecie"
        Me.dgvespecie.RowTemplate.Height = 25
        Me.dgvespecie.Size = New System.Drawing.Size(402, 504)
        Me.dgvespecie.TabIndex = 27
        '
        'FormEspecie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 532)
        Me.Controls.Add(Me.dgvespecie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxHabitat)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtnombrecienti)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtnombrec)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtespecieid)
        Me.Name = "FormEspecie"
        Me.Text = "FormEspecie"
        CType(Me.dgvespecie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtnombrecienti As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtnombrec As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtespecieid As TextBox
    Friend WithEvents cbxHabitat As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvespecie As DataGridView
End Class
