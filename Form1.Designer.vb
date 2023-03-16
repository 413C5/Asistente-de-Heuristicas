<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReconocer = New System.Windows.Forms.Button()
        Me.btnVisibilidad = New System.Windows.Forms.Button()
        Me.btnPrevencion = New System.Windows.Forms.Button()
        Me.btnEstetico = New System.Windows.Forms.Button()
        Me.btnControl = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPalabra = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(234, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Heuristicas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReconocer
        '
        Me.btnReconocer.Location = New System.Drawing.Point(34, 67)
        Me.btnReconocer.Name = "btnReconocer"
        Me.btnReconocer.Size = New System.Drawing.Size(635, 29)
        Me.btnReconocer.TabIndex = 1
        Me.btnReconocer.Text = "&Reconocer en Vez de Recordar"
        Me.btnReconocer.UseVisualStyleBackColor = True
        '
        'btnVisibilidad
        '
        Me.btnVisibilidad.Location = New System.Drawing.Point(34, 111)
        Me.btnVisibilidad.Name = "btnVisibilidad"
        Me.btnVisibilidad.Size = New System.Drawing.Size(635, 29)
        Me.btnVisibilidad.TabIndex = 2
        Me.btnVisibilidad.Text = "&Visibilidad de Estado del Sistema"
        Me.btnVisibilidad.UseVisualStyleBackColor = True
        '
        'btnPrevencion
        '
        Me.btnPrevencion.Location = New System.Drawing.Point(34, 166)
        Me.btnPrevencion.Name = "btnPrevencion"
        Me.btnPrevencion.Size = New System.Drawing.Size(635, 29)
        Me.btnPrevencion.TabIndex = 3
        Me.btnPrevencion.Text = "&Prevencion de Errores"
        Me.btnPrevencion.UseVisualStyleBackColor = True
        '
        'btnEstetico
        '
        Me.btnEstetico.Location = New System.Drawing.Point(34, 212)
        Me.btnEstetico.Name = "btnEstetico"
        Me.btnEstetico.Size = New System.Drawing.Size(635, 29)
        Me.btnEstetico.TabIndex = 4
        Me.btnEstetico.Text = "&Diseño Estético y Minimalista"
        Me.btnEstetico.UseVisualStyleBackColor = True
        '
        'btnControl
        '
        Me.btnControl.Location = New System.Drawing.Point(34, 265)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Size = New System.Drawing.Size(635, 29)
        Me.btnControl.TabIndex = 5
        Me.btnControl.Text = "&Control y Libertad de Ususario"
        Me.btnControl.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(34, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(595, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Relación con  el Modelo de Procesamiento del Usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(34, 351)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.ReadOnly = True
        Me.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTexto.Size = New System.Drawing.Size(635, 175)
        Me.txtTexto.TabIndex = 7
        Me.txtTexto.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(34, 545)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 51)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Busca una relación con una palabra clave o texto:"
        '
        'txtPalabra
        '
        Me.txtPalabra.Location = New System.Drawing.Point(269, 545)
        Me.txtPalabra.Name = "txtPalabra"
        Me.txtPalabra.Size = New System.Drawing.Size(264, 27)
        Me.txtPalabra.TabIndex = 9
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(539, 543)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(130, 29)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AcceptButton = Me.btnBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 655)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtPalabra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnControl)
        Me.Controls.Add(Me.btnEstetico)
        Me.Controls.Add(Me.btnPrevencion)
        Me.Controls.Add(Me.btnVisibilidad)
        Me.Controls.Add(Me.btnReconocer)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente de Heusísticas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnReconocer As Button
    Friend WithEvents btnVisibilidad As Button
    Friend WithEvents btnPrevencion As Button
    Friend WithEvents btnEstetico As Button
    Friend WithEvents btnControl As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTexto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPalabra As TextBox
    Friend WithEvents btnBuscar As Button
End Class
