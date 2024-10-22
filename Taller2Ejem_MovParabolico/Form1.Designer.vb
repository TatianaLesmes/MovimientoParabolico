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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Torre = New System.Windows.Forms.PictureBox()
        Me.Raton = New System.Windows.Forms.PictureBox()
        Me.Suelo = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        CType(Me.Torre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Raton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Suelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Torre
        '
        Me.Torre.BackColor = System.Drawing.Color.Transparent
        Me.Torre.BackgroundImage = CType(resources.GetObject("Torre.BackgroundImage"), System.Drawing.Image)
        Me.Torre.Image = CType(resources.GetObject("Torre.Image"), System.Drawing.Image)
        Me.Torre.Location = New System.Drawing.Point(332, 445)
        Me.Torre.Name = "Torre"
        Me.Torre.Size = New System.Drawing.Size(115, 161)
        Me.Torre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Torre.TabIndex = 0
        Me.Torre.TabStop = False
        Me.Torre.Visible = False
        '
        'Raton
        '
        Me.Raton.BackColor = System.Drawing.Color.Transparent
        Me.Raton.Image = CType(resources.GetObject("Raton.Image"), System.Drawing.Image)
        Me.Raton.Location = New System.Drawing.Point(920, 459)
        Me.Raton.Name = "Raton"
        Me.Raton.Size = New System.Drawing.Size(107, 105)
        Me.Raton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Raton.TabIndex = 1
        Me.Raton.TabStop = False
        Me.Raton.Visible = False
        '
        'Suelo
        '
        Me.Suelo.Location = New System.Drawing.Point(440, 603)
        Me.Suelo.Name = "Suelo"
        Me.Suelo.Size = New System.Drawing.Size(571, 27)
        Me.Suelo.TabIndex = 2
        Me.Suelo.TabStop = False
        Me.Suelo.Visible = False
        '
        'Timer1
        '
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1023, 630)
        Me.Controls.Add(Me.Suelo)
        Me.Controls.Add(Me.Raton)
        Me.Controls.Add(Me.Torre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Torre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Raton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Suelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Torre As PictureBox
    Friend WithEvents Raton As PictureBox
    Friend WithEvents Suelo As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class
