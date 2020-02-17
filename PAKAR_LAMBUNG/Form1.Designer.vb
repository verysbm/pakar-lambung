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
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("HP Simplified", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label3.Location = New System.Drawing.Point(84, 58)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(153, 19)
        Me.label3.TabIndex = 5
        Me.label3.Text = "UNIVERSITAS SURAKARTA"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label2.Location = New System.Drawing.Point(20, 36)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(263, 22)
        Me.label2.TabIndex = 4
        Me.label2.Text = "DIAGNOSA  PENYAKIT  PADA LAMBUNG"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("HP Simplified", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label1.Location = New System.Drawing.Point(110, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(87, 19)
        Me.label1.TabIndex = 3
        Me.label1.Text = "SISTEM PAKAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("HP Simplified", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(21, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("HP Simplified", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(23, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(87, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 20)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(87, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(170, 20)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(87, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(181, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 26)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 223)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.label3)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.label1)
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(308, 88)
        Me.Panel2.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 316)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
