<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(112, 49)
        Me.label3.Name = "label3"
        Me.label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label3.Size = New System.Drawing.Size(157, 22)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Universitas Surakarta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(62, 27)
        Me.label2.Name = "label2"
        Me.label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label2.Size = New System.Drawing.Size(241, 22)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Diagnosa Penyakit Pada Lambung"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("HP Simplified", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(143, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(81, 19)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Sistem Pakar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(115, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(302, 45)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Mulai Diagnosa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(28, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 36)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Tentang Kelompok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(182, 267)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 36)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Detail Penyakit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(31, 309)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(299, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 347)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
