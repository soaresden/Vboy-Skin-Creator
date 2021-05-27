Imports System.Drawing.Imaging
Imports System.IO

Public Class Form1
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
End Class
