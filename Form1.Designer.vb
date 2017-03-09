<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rojo = New System.Windows.Forms.Button()
        Me.amarillo = New System.Windows.Forms.Button()
        Me.verde = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(198, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(433, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "inicio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rojo
        '
        Me.rojo.BackColor = System.Drawing.Color.Black
        Me.rojo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rojo.ForeColor = System.Drawing.Color.Black
        Me.rojo.Location = New System.Drawing.Point(258, 46)
        Me.rojo.Name = "rojo"
        Me.rojo.Size = New System.Drawing.Size(79, 82)
        Me.rojo.TabIndex = 2
        Me.rojo.UseVisualStyleBackColor = False
        '
        'amarillo
        '
        Me.amarillo.BackColor = System.Drawing.Color.Black
        Me.amarillo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.amarillo.Location = New System.Drawing.Point(258, 126)
        Me.amarillo.Name = "amarillo"
        Me.amarillo.Size = New System.Drawing.Size(79, 75)
        Me.amarillo.TabIndex = 3
        Me.amarillo.UseVisualStyleBackColor = False
        '
        'verde
        '
        Me.verde.BackColor = System.Drawing.Color.Black
        Me.verde.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.verde.ForeColor = System.Drawing.SystemColors.ControlText
        Me.verde.Location = New System.Drawing.Point(258, 198)
        Me.verde.Name = "verde"
        Me.verde.Size = New System.Drawing.Size(79, 76)
        Me.verde.TabIndex = 4
        Me.verde.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 314)
        Me.Controls.Add(Me.verde)
        Me.Controls.Add(Me.amarillo)
        Me.Controls.Add(Me.rojo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "semaforo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rojo As System.Windows.Forms.Button
    Friend WithEvents amarillo As System.Windows.Forms.Button
    Friend WithEvents verde As System.Windows.Forms.Button

End Class
