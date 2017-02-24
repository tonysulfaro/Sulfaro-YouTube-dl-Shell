Imports System.IO

Public Class frmYouTubeDL

    'Opens file browser to specify target directory in txtFilePath.Text
    Public Sub brnFileBrowse_Click(sender As Object, e As EventArgs) Handles brnFileBrowse.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtFilePath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Public Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click


        'depreciated code that ended up being too complicated.
        'Dim youtubedlDir As String = "z:\other\youtube\youtube-dl.exe"
        'Dim filepath As String = txtFilePath.Text

        'If Not Directory.Exists(filepath) Then
        '    Directory.CreateDirectory(filepath)
        'End If
        'Dim file = New FileInfo(youtubedlDir)
        'file.CopyTo(Path.Combine(filepath, file.Name), True)

        'change dir to specified file path
        ChDir(txtFilePath.Text)

        'shell to update youtube-dl
        'Shell("cmd.exe /k " + "youtube-dl -U")

        'shell to run cmd.exe and youtube-dl with the url from txtSource.Text
        Shell("cmd.exe /k " + "youtube-dl " + txtSource.Text)


    End Sub

End Class
