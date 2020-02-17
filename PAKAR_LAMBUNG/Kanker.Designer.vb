<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kanker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kanker))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(29, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 338)
        Me.Panel1.TabIndex = 2
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
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
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
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(276, 102)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.RichTextBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(377, 217)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 135)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cara Mengatasi & Pengobatan"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(276, 102)
        Me.RichTextBox3.TabIndex = 0
        Me.RichTextBox3.Text = "Pengobatan Kanker :" & Global.Microsoft.VisualBasic.ChrW(10) & "- Radioterapi" & Global.Microsoft.VisualBasic.ChrW(10) & "- Kemoterapi" & Global.Microsoft.VisualBasic.ChrW(10) & "- Operasi" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Pencegahan :" & Global.Microsoft.VisualBasic.ChrW(10) & "- Tidak Me" &
    "rokok" & Global.Microsoft.VisualBasic.ChrW(10) & "- Pola Makan Sehat" & Global.Microsoft.VisualBasic.ChrW(10) & "- Menjaga Berat Badan"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(528, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 36)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(383, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 36)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(383, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Kanker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 407)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Kanker"
        Me.Text = "Kanker Lambung"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
