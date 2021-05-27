<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Converter
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Converter))
        Me.Information = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ThemeBlank = New System.Windows.Forms.PictureBox()
        Me.HowTo = New System.Windows.Forms.GroupBox()
        Me.custompath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.themename = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ThemeCustom = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.hexdata = New System.Windows.Forms.RichTextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Information.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThemeBlank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HowTo.SuspendLayout()
        CType(Me.ThemeCustom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Information
        '
        Me.Information.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Information.Controls.Add(Me.PictureBox2)
        Me.Information.Location = New System.Drawing.Point(935, 278)
        Me.Information.Margin = New System.Windows.Forms.Padding(4)
        Me.Information.Name = "Information"
        Me.Information.Padding = New System.Windows.Forms.Padding(4)
        Me.Information.Size = New System.Drawing.Size(257, 345)
        Me.Information.TabIndex = 5
        Me.Information.TabStop = False
        Me.Information.Text = "Information :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 20)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(239, 260)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(549, 127)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(569, 15)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(619, 190)
        Me.PictureBox7.TabIndex = 7
        Me.PictureBox7.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RichTextBox1.Location = New System.Drawing.Point(569, 212)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(619, 58)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = "This tool was made to easily customize your overlay in Vboy emulator." & Global.Microsoft.VisualBasic.ChrW(10) & "For S60 v1 " &
    "and S60v2 ONLY" & Global.Microsoft.VisualBasic.ChrW(10) & "(S60v3 didn't have Skin feature)"
        '
        'ThemeBlank
        '
        Me.ThemeBlank.Image = CType(resources.GetObject("ThemeBlank.Image"), System.Drawing.Image)
        Me.ThemeBlank.Location = New System.Drawing.Point(45, 39)
        Me.ThemeBlank.Margin = New System.Windows.Forms.Padding(4)
        Me.ThemeBlank.Name = "ThemeBlank"
        Me.ThemeBlank.Size = New System.Drawing.Size(239, 260)
        Me.ThemeBlank.TabIndex = 7
        Me.ThemeBlank.TabStop = False
        '
        'HowTo
        '
        Me.HowTo.BackColor = System.Drawing.Color.LightGreen
        Me.HowTo.Controls.Add(Me.custompath)
        Me.HowTo.Controls.Add(Me.Label5)
        Me.HowTo.Controls.Add(Me.Button1)
        Me.HowTo.Controls.Add(Me.themename)
        Me.HowTo.Controls.Add(Me.Label4)
        Me.HowTo.Controls.Add(Me.Label2)
        Me.HowTo.Controls.Add(Me.ThemeCustom)
        Me.HowTo.Controls.Add(Me.Label1)
        Me.HowTo.Controls.Add(Me.Label3)
        Me.HowTo.Controls.Add(Me.ThemeBlank)
        Me.HowTo.Location = New System.Drawing.Point(12, 278)
        Me.HowTo.Margin = New System.Windows.Forms.Padding(4)
        Me.HowTo.Name = "HowTo"
        Me.HowTo.Padding = New System.Windows.Forms.Padding(4)
        Me.HowTo.Size = New System.Drawing.Size(911, 345)
        Me.HowTo.TabIndex = 9
        Me.HowTo.TabStop = False
        Me.HowTo.Text = "How To ? :"
        '
        'custompath
        '
        Me.custompath.Location = New System.Drawing.Point(372, 319)
        Me.custompath.Margin = New System.Windows.Forms.Padding(4)
        Me.custompath.Name = "custompath"
        Me.custompath.Size = New System.Drawing.Size(252, 22)
        Me.custompath.TabIndex = 17
        Me.custompath.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(659, 155)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "5°) Export it in .vby"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(709, 219)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 80)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "EXPORT THEME AS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VBOY THEME " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(.VBY)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'themename
        '
        Me.themename.Location = New System.Drawing.Point(663, 50)
        Me.themename.Margin = New System.Windows.Forms.Padding(4)
        Me.themename.Name = "themename"
        Me.themename.Size = New System.Drawing.Size(239, 22)
        Me.themename.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(659, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "4°) Name your Theme :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "3°) Drag and Drop your Image below"
        '
        'ThemeCustom
        '
        Me.ThemeCustom.BackColor = System.Drawing.Color.Lime
        Me.ThemeCustom.Image = CType(resources.GetObject("ThemeCustom.Image"), System.Drawing.Image)
        Me.ThemeCustom.Location = New System.Drawing.Point(372, 39)
        Me.ThemeCustom.Margin = New System.Windows.Forms.Padding(4)
        Me.ThemeCustom.Name = "ThemeCustom"
        Me.ThemeCustom.Size = New System.Drawing.Size(253, 272)
        Me.ThemeCustom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ThemeCustom.TabIndex = 10
        Me.ThemeCustom.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 319)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "2°) Edit it Manually via Photoshop or Other"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "1°) Click the image below to save it on Desktop"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(433, 145)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "v1.1 by Soaresden"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(429, 161)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(133, 17)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Soaresden's Github"
        '
        'hexdata
        '
        Me.hexdata.Location = New System.Drawing.Point(569, 116)
        Me.hexdata.Margin = New System.Windows.Forms.Padding(4)
        Me.hexdata.Name = "hexdata"
        Me.hexdata.Size = New System.Drawing.Size(617, 88)
        Me.hexdata.TabIndex = 12
        Me.hexdata.Text = ""
        Me.hexdata.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 145)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(332, 34)
        Me.LinkLabel2.TabIndex = 13
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Vampent Vboy's .sis Archive :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://archive.org/download/SymbianS60Emulators"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.Location = New System.Drawing.Point(12, 183)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(548, 87)
        Me.RichTextBox2.TabIndex = 15
        Me.RichTextBox2.Text = "Vboy v1.3:" & Global.Microsoft.VisualBasic.ChrW(10) & "262K = for 6680 ..." & Global.Microsoft.VisualBasic.ChrW(10) & "65K   = for N70 ..." & Global.Microsoft.VisualBasic.ChrW(10) & "4k      = for 3650, 3620, 3660" &
    ", 3600, 7650, NGage, QD, 6600, 7610..."
        '
        'Converter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(1191, 620)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.hexdata)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.HowTo)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Information)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1209, 667)
        Me.MinimumSize = New System.Drawing.Size(1209, 667)
        Me.Name = "Converter"
        Me.Text = "Vampent Vboy Skin Creator by Soaresden v1.1"
        Me.Information.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThemeBlank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HowTo.ResumeLayout(False)
        Me.HowTo.PerformLayout()
        CType(Me.ThemeCustom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Information As GroupBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ThemeBlank As PictureBox
    Friend WithEvents HowTo As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents themename As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ThemeCustom As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents custompath As TextBox
    Friend WithEvents hexdata As RichTextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents RichTextBox2 As RichTextBox
End Class
