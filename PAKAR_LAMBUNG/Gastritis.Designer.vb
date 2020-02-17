<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gastritis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gastritis))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 312)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Definisi"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(338, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(276, 102)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RichTextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 135)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gejala"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(276, 102)
        Me.RichTextBox2.TabIndex = 0
        Me.RichTextBox2.Text = "· hilang nafsu makan" & Global.Microsoft.VisualBasic.ChrW(10) & "· mual dan muntah" & Global.Microsoft.VisualBasic.ChrW(10) & "· nyeri di perut bagian atas" & Global.Microsoft.VisualBasic.ChrW(10) & "· merasa keny" &
    "ang meski baru makan sedikit" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.RichTextBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(342, 229)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(212, 95)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cara Mengatasi & Pengobatan"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(200, 70)
        Me.RichTextBox3.TabIndex = 0
        Me.RichTextBox3.Text = "Minum Proma, jangan telat" & Global.Microsoft.VisualBasic.ChrW(10) & "makan, hindari makan pedas," & Global.Microsoft.VisualBasic.ChrW(10) & "asam dank eras, pemberian" & Global.Microsoft.VisualBasic.ChrW(10) & "g" &
    "astrolan, propepsa sirup," & Global.Microsoft.VisualBasic.ChrW(10) & "vometa, dan mertiga "
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(447, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 36)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(340, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 36)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Gastritis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 385)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Gastritis"
        Me.Text = "Gastritis"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
