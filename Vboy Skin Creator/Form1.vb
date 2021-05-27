Option Explicit On
Imports System.Drawing.Imaging
Imports System.IO
Imports System.IO.Compression



Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeCustom.AllowDrop = True
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/soaresden/Vboy-Skin-Creator")
    End Sub

    Private Sub ThemeBlank_Click(sender As Object, e As EventArgs) Handles ThemeBlank.Click
        Dim finalpath = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Blank.BMP"
        Dim lebmp = My.Resources.BLANK

        'Copy exactly the bytes ! Else Windows use his compression...
        Dim picArray As Byte() = CType(My.Resources.BLANK, Byte())
        System.IO.File.WriteAllBytes(finalpath, picArray)
        MsgBox("Successfully Created BMP on Desktop")
    End Sub

    Sub readhexdata()
        Dim hexstring As String
        Using file As New IO.FileStream(custompath.Text, FileMode.Open)
            Dim value As Integer = file.ReadByte()

            Do Until value = -1
                hexstring = hexstring & (value.ToString("X2"))
                hexstring = hexstring & "-"
                value = file.ReadByte()
            Loop
        End Using
        hexdata.Text = hexstring
    End Sub
    Private Sub picCategoryImage_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles ThemeCustom.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub picCategoryImage_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles ThemeCustom.DragDrop
        Dim picbox As PictureBox = CType(sender, PictureBox)

        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 1 Then
            MsgBox("Need ONE file !")
            Exit Sub
        End If

        For Each path In files
            If System.IO.Path.GetExtension(path) <> ".bmp" Then
                MsgBox("Need a BMP file !")
                Exit Sub
            Else
                custompath.Text = path

                Dim g As Graphics = picbox.CreateGraphics()
                g.DrawImage(CType(GetImageFile(custompath.Text), Image), New Point(0, 0))
            End If
        Next

        picbox.Image = GetImageFile(custompath.Text)
        ThemeCustom.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub
    Public Function GetImageFile(ByVal fn As String) As Image
        If IO.File.Exists(fn) Then
            Dim img As Image = Image.FromFile(fn)
            Dim bm As New Bitmap(width:=img.Width, height:=img.Height, format:=img.PixelFormat)
            Using g As Graphics = Graphics.FromImage(bm)
                g.DrawImage(img, Point.Empty)
            End Using
            img.Dispose()
            Return bm
        Else
            MessageBox.Show("Nice try!, but " & fn & "does not exist.  Returning Nothing")
            Return Nothing
        End If
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If themename.Text = "" Then
            MsgBox("No Theme Name")
            themename.Focus()
            Exit Sub
        End If


        'reading hex data
        hexdata.Clear()
        Call readhexdata()

        'Testing now
        Dim filelength = hexdata.Text.Length
        Dim beginning = Replace(hexdata.Text.Substring(0, 161), "-", " ")

        'Testing file length and do 
        If filelength < 329640 Then
            Do Until filelength = 329640
                hexdata.Text = hexdata.Text + "00-"
                filelength = filelength + 3
            Loop
        ElseIf filelength > 329640 Then
            MsgBox("Bad size file")
            Exit Sub
        End If

        'Test the beginning
        Dim goodbeginning = "42 4D 38 AD 01 00 00 00 00 00 36 00 00 00 28 00 00 00 B0 00 00 00 D0 00 00 00 01 00 18 00 00 00 00 00 02 AD 01 00 12 0B 00 00 12 0B 00 00 00 00 00 00 00 00 00 00"

        If beginning <> goodbeginning Then
            hexdata.Text = Replace(Replace(Replace(hexdata.Text, "-", " "), beginning, Replace(goodbeginning, " ", "-")), " ", "-")
        End If

        'Export as "1" BMP File
        Dim newbytes = Replace(hexdata.Text, "-", "")
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.Desktop & "\VBOYCONVERTER\") = False Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.Desktop & "\VBOYCONVERTER\")
        End If

        Dim tempdir = My.Computer.FileSystem.SpecialDirectories.Desktop & "\VBOYCONVERTER"
        Dim thebitmapfile = tempdir & "\1.bmp"
        Dim thezipfile = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & themename.Text & ".vby"

        My.Computer.FileSystem.WriteAllBytes(thebitmapfile, StringToByteArray(newbytes), False)

        'Zip it to a vby
        Dim startPath As String = tempdir
        Dim zipPath As String = thezipfile
        'kill zippath
        ZipFile.CreateFromDirectory(startPath, zipPath)

        ' Cleaning temp directory and del the file "1"
        System.IO.Directory.Delete(tempdir, True)
        'Open folder
        MsgBox("Conversion Done !" & Chr(10) & Chr(10) & "Don't forget to transfer it and move to :" & Chr(10) & "system\apps\vboy\skins")
        Process.Start(My.Computer.FileSystem.SpecialDirectories.Desktop)
    End Sub
    Public Shared Function StringToByteArray(ByVal hex As String) As Byte()
        Return Enumerable.Range(0, hex.Length).Where(Function(x) x Mod 2 = 0).[Select](Function(x) Convert.ToByte(hex.Substring(x, 2), 16)).ToArray()
    End Function
End Class
