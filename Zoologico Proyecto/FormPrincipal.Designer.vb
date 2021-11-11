<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.btnEspecie = New System.Windows.Forms.Button()
        Me.btnRecorrido = New System.Windows.Forms.Button()
        Me.btnHabitat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEspecie
        '
        Me.btnEspecie.Location = New System.Drawing.Point(570, 166)
        Me.btnEspecie.Name = "btnEspecie"
        Me.btnEspecie.Size = New System.Drawing.Size(169, 118)
        Me.btnEspecie.TabIndex = 5
        Me.btnEspecie.Text = "Especie"
        Me.btnEspecie.UseVisualStyleBackColor = True
        '
        'btnRecorrido
        '
        Me.btnRecorrido.Location = New System.Drawing.Point(324, 166)
        Me.btnRecorrido.Name = "btnRecorrido"
        Me.btnRecorrido.Size = New System.Drawing.Size(169, 118)
        Me.btnRecorrido.TabIndex = 4
        Me.btnRecorrido.Text = "Recorrido"
        Me.btnRecorrido.UseVisualStyleBackColor = True
        '
        'btnHabitat
        '
        Me.btnHabitat.Location = New System.Drawing.Point(58, 166)
        Me.btnHabitat.Name = "btnHabitat"
        Me.btnHabitat.Size = New System.Drawing.Size(169, 118)
        Me.btnHabitat.TabIndex = 3
        Me.btnHabitat.Text = "Habitat"
        Me.btnHabitat.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEspecie)
        Me.Controls.Add(Me.btnRecorrido)
        Me.Controls.Add(Me.btnHabitat)
        Me.Name = "FormPrincipal"
        Me.Text = "FormHabitat"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEspecie As Button
    Friend WithEvents btnRecorrido As Button
    Friend WithEvents btnHabitat As Button
End Class
