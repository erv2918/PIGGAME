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
        Me.lblJugador = New System.Windows.Forms.Label()
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.txtPuntajeParcial = New System.Windows.Forms.TextBox()
        Me.txtDado = New System.Windows.Forms.TextBox()
        Me.lblParcial = New System.Windows.Forms.Label()
        Me.txtJugador = New System.Windows.Forms.TextBox()
        Me.txtMaquina = New System.Windows.Forms.TextBox()
        Me.lblDado = New System.Windows.Forms.Label()
        Me.btnTirar = New System.Windows.Forms.Button()
        Me.btnParar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblJugador
        '
        Me.lblJugador.AutoSize = True
        Me.lblJugador.Location = New System.Drawing.Point(12, 35)
        Me.lblJugador.Name = "lblJugador"
        Me.lblJugador.Size = New System.Drawing.Size(59, 13)
        Me.lblJugador.TabIndex = 0
        Me.lblJugador.Text = "JUGADOR"
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.Location = New System.Drawing.Point(188, 35)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(57, 13)
        Me.lblMaquina.TabIndex = 1
        Me.lblMaquina.Text = "MAQUINA"
        '
        'txtPuntajeParcial
        '
        Me.txtPuntajeParcial.Location = New System.Drawing.Point(87, 89)
        Me.txtPuntajeParcial.Name = "txtPuntajeParcial"
        Me.txtPuntajeParcial.Size = New System.Drawing.Size(100, 20)
        Me.txtPuntajeParcial.TabIndex = 2
        '
        'txtDado
        '
        Me.txtDado.Location = New System.Drawing.Point(87, 141)
        Me.txtDado.Name = "txtDado"
        Me.txtDado.Size = New System.Drawing.Size(100, 20)
        Me.txtDado.TabIndex = 3
        '
        'lblParcial
        '
        Me.lblParcial.AutoSize = True
        Me.lblParcial.Location = New System.Drawing.Point(84, 73)
        Me.lblParcial.Name = "lblParcial"
        Me.lblParcial.Size = New System.Drawing.Size(104, 13)
        Me.lblParcial.TabIndex = 4
        Me.lblParcial.Text = "PUNTAJE PARCIAL"
        '
        'txtJugador
        '
        Me.txtJugador.Location = New System.Drawing.Point(18, 51)
        Me.txtJugador.Name = "txtJugador"
        Me.txtJugador.Size = New System.Drawing.Size(37, 20)
        Me.txtJugador.TabIndex = 7
        '
        'txtMaquina
        '
        Me.txtMaquina.Location = New System.Drawing.Point(202, 51)
        Me.txtMaquina.Name = "txtMaquina"
        Me.txtMaquina.Size = New System.Drawing.Size(33, 20)
        Me.txtMaquina.TabIndex = 8
        '
        'lblDado
        '
        Me.lblDado.AutoSize = True
        Me.lblDado.Location = New System.Drawing.Point(118, 125)
        Me.lblDado.Name = "lblDado"
        Me.lblDado.Size = New System.Drawing.Size(38, 13)
        Me.lblDado.TabIndex = 9
        Me.lblDado.Text = "DADO"
        '
        'btnTirar
        '
        Me.btnTirar.Location = New System.Drawing.Point(12, 190)
        Me.btnTirar.Name = "btnTirar"
        Me.btnTirar.Size = New System.Drawing.Size(59, 23)
        Me.btnTirar.TabIndex = 10
        Me.btnTirar.Text = "TIRAR"
        Me.btnTirar.UseVisualStyleBackColor = True
        '
        'btnParar
        '
        Me.btnParar.Location = New System.Drawing.Point(191, 190)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(56, 23)
        Me.btnParar.TabIndex = 11
        Me.btnParar.Text = "PARAR"
        Me.btnParar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnParar)
        Me.Controls.Add(Me.btnTirar)
        Me.Controls.Add(Me.lblDado)
        Me.Controls.Add(Me.txtMaquina)
        Me.Controls.Add(Me.txtJugador)
        Me.Controls.Add(Me.lblParcial)
        Me.Controls.Add(Me.txtDado)
        Me.Controls.Add(Me.txtPuntajeParcial)
        Me.Controls.Add(Me.lblMaquina)
        Me.Controls.Add(Me.lblJugador)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJugador As Label
    Friend WithEvents lblMaquina As Label
    Friend WithEvents txtPuntajeParcial As TextBox
    Friend WithEvents txtDado As TextBox
    Friend WithEvents lblParcial As Label
    Friend WithEvents txtJugador As TextBox
    Friend WithEvents txtMaquina As TextBox
    Friend WithEvents lblDado As Label
    Friend WithEvents btnTirar As Button
    Friend WithEvents btnParar As Button
End Class
