<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.Information.Location = New System.Drawing.Point(701, 226)
        Me.Information.Name = "Information"
        Me.Information.Size = New System.Drawing.Size(193, 280)
        Me.Information.TabIndex = 5
        Me.Information.TabStop = False
        Me.Information.Text = "Information :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(179, 211)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(9, 12)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(412, 103)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(427, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(464, 154)
        Me.PictureBox7.TabIndex = 7
        Me.PictureBox7.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 172)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(882, 31)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = "This Tool was made to easily customize your overly in Vboy emulator.. for S60 v1 " &
    "and S60v2 (S60v3 didn't have Skin feature)"
        '
        'ThemeBlank
        '
        Me.ThemeBlank.Image = CType(resources.GetObject("ThemeBlank.Image"), System.Drawing.Image)
        Me.ThemeBlank.Location = New System.Drawing.Point(34, 32)
        Me.ThemeBlank.Name = "ThemeBlank"
        Me.ThemeBlank.Size = New System.Drawing.Size(179, 211)
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
        Me.HowTo.Location = New System.Drawing.Point(9, 226)
        Me.HowTo.Name = "HowTo"
        Me.HowTo.Size = New System.Drawing.Size(683, 280)
        Me.HowTo.TabIndex = 9
        Me.HowTo.TabStop = False
        Me.HowTo.Text = "How To ? :"
        '
        'custompath
        '
        Me.custompath.Location = New System.Drawing.Point(279, 249)
        Me.custompath.Name = "custompath"
        Me.custompath.Size = New System.Drawing.Size(179, 20)
        Me.custompath.TabIndex = 17
        Me.custompath.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(494, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
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
        Me.Button1.Location = New System.Drawing.Point(528, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 48)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "EXPORT THEME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'themename
        '
        Me.themename.Location = New System.Drawing.Point(497, 41)
        Me.themename.Name = "themename"
        Me.themename.Size = New System.Drawing.Size(180, 20)
        Me.themename.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(494, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "4°) Name your Theme :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "3°) Drag and Drop your Image below"
        '
        'ThemeCustom
        '
        Me.ThemeCustom.BackColor = System.Drawing.Color.Black
        Me.ThemeCustom.Image = CType(resources.GetObject("ThemeCustom.Image"), System.Drawing.Image)
        Me.ThemeCustom.Location = New System.Drawing.Point(279, 32)
        Me.ThemeCustom.Name = "ThemeCustom"
        Me.ThemeCustom.Size = New System.Drawing.Size(179, 211)
        Me.ThemeCustom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ThemeCustom.TabIndex = 10
        Me.ThemeCustom.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "2°) Edit it Manually via Photoshop or Other"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "1°) Click the image below to save it on Desktop"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "v1 by Soaresden"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(322, 118)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(99, 13)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Soaresden's Github"
        '
        'hexdata
        '
        Me.hexdata.Location = New System.Drawing.Point(427, 95)
        Me.hexdata.Name = "hexdata"
        Me.hexdata.Size = New System.Drawing.Size(463, 71)
        Me.hexdata.TabIndex = 12
        Me.hexdata.Text = ""
        Me.hexdata.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(895, 513)
        Me.Controls.Add(Me.hexdata)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.HowTo)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Information)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(911, 552)
        Me.MinimumSize = New System.Drawing.Size(911, 552)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
End Class
