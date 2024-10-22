<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Torre = New System.Windows.Forms.PictureBox()
        Me.Raton = New System.Windows.Forms.PictureBox()
        Me.Explosion = New System.Windows.Forms.PictureBox()
        Me.PBTejo = New System.Windows.Forms.PictureBox()
        Me.Suelo = New System.Windows.Forms.PictureBox()
        Me.MensajeLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Torre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Raton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Explosion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBTejo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Suelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Torre
        '
        Me.Torre.BackColor = System.Drawing.Color.Transparent
        Me.Torre.Image = CType(resources.GetObject("Torre.Image"), System.Drawing.Image)
        Me.Torre.Location = New System.Drawing.Point(320, 443)
        Me.Torre.Name = "Torre"
        Me.Torre.Size = New System.Drawing.Size(115, 165)
        Me.Torre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Torre.TabIndex = 0
        Me.Torre.TabStop = False
        '
        'Raton
        '
        Me.Raton.BackColor = System.Drawing.Color.Transparent
        Me.Raton.Image = CType(resources.GetObject("Raton.Image"), System.Drawing.Image)
        Me.Raton.Location = New System.Drawing.Point(821, 443)
        Me.Raton.Name = "Raton"
        Me.Raton.Size = New System.Drawing.Size(79, 93)
        Me.Raton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Raton.TabIndex = 1
        Me.Raton.TabStop = False
        '
        'Explosion
        '
        Me.Explosion.BackColor = System.Drawing.Color.Transparent
        Me.Explosion.Image = CType(resources.GetObject("Explosion.Image"), System.Drawing.Image)
        Me.Explosion.Location = New System.Drawing.Point(821, 88)
        Me.Explosion.Name = "Explosion"
        Me.Explosion.Size = New System.Drawing.Size(112, 149)
        Me.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Explosion.TabIndex = 2
        Me.Explosion.TabStop = False
        Me.Explosion.Visible = False
        '
        'PBTejo
        '
        Me.PBTejo.BackColor = System.Drawing.Color.Transparent
        Me.PBTejo.Image = CType(resources.GetObject("PBTejo.Image"), System.Drawing.Image)
        Me.PBTejo.Location = New System.Drawing.Point(153, 503)
        Me.PBTejo.Name = "PBTejo"
        Me.PBTejo.Size = New System.Drawing.Size(34, 33)
        Me.PBTejo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBTejo.TabIndex = 3
        Me.PBTejo.TabStop = False
        '
        'Suelo
        '
        Me.Suelo.Location = New System.Drawing.Point(441, 607)
        Me.Suelo.Name = "Suelo"
        Me.Suelo.Size = New System.Drawing.Size(384, 27)
        Me.Suelo.TabIndex = 4
        Me.Suelo.TabStop = False
        '
        'MensajeLabel
        '
        Me.MensajeLabel.AutoSize = True
        Me.MensajeLabel.BackColor = System.Drawing.Color.Transparent
        Me.MensajeLabel.Location = New System.Drawing.Point(198, 36)
        Me.MensajeLabel.Name = "MensajeLabel"
        Me.MensajeLabel.Size = New System.Drawing.Size(39, 13)
        Me.MensajeLabel.TabIndex = 5
        Me.MensajeLabel.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(927, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Reinicar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1021, 632)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MensajeLabel)
        Me.Controls.Add(Me.Suelo)
        Me.Controls.Add(Me.PBTejo)
        Me.Controls.Add(Me.Explosion)
        Me.Controls.Add(Me.Raton)
        Me.Controls.Add(Me.Torre)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Torre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Raton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Explosion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBTejo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Suelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Torre As PictureBox
    Friend WithEvents Raton As PictureBox
    Friend WithEvents Explosion As PictureBox
    Friend WithEvents PBTejo As PictureBox
    Friend WithEvents Suelo As PictureBox
    Friend WithEvents MensajeLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
