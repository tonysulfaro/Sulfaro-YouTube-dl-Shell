Imports System.IO

Public Class frmYouTubeDL


    Public Sub brnFileBrowse_Click(sender As Object, e As EventArgs) Handles brnFileBrowse.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtFilePath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Public Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click

        Dim youtubedlDir As String = "z:\other\youtube\youtube-dl.exe"
        Dim filepath As String = txtFilePath.Text

        If Not Directory.Exists(filepath) Then
            Directory.CreateDirectory(filepath)
        End If
        Dim file = New FileInfo(youtubedlDir)
        file.CopyTo(Path.Combine(filepath, file.Name), True)

        ChDir(txtFilePath.Text)
        Shell("cmd.exe /k " + "youtube-dl " + txtSource.Text)

    End Sub

End Class
