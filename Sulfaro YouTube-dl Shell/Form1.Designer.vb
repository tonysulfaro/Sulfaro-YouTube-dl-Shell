<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmYouTubeDL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.lblSourceAdress = New System.Windows.Forms.Label()
        Me.lblDownloadFilePath = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.brnFileBrowse = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(195, 401)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(225, 81)
        Me.btnDownload.TabIndex = 0
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'lblSourceAdress
        '
        Me.lblSourceAdress.AutoSize = True
        Me.lblSourceAdress.Location = New System.Drawing.Point(60, 113)
        Me.lblSourceAdress.Name = "lblSourceAdress"
        Me.lblSourceAdress.Size = New System.Drawing.Size(118, 20)
        Me.lblSourceAdress.TabIndex = 1
        Me.lblSourceAdress.Text = "Source Adress:"
        '
        'lblDownloadFilePath
        '
        Me.lblDownloadFilePath.AutoSize = True
        Me.lblDownloadFilePath.Location = New System.Drawing.Point(27, 231)
        Me.lblDownloadFilePath.Name = "lblDownloadFilePath"
        Me.lblDownloadFilePath.Size = New System.Drawing.Size(151, 20)
        Me.lblDownloadFilePath.TabIndex = 2
        Me.lblDownloadFilePath.Text = "Download Directory:"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(185, 113)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(378, 26)
        Me.txtSource.TabIndex = 3
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'brnFileBrowse
        '
        Me.brnFileBrowse.Location = New System.Drawing.Point(481, 228)
        Me.brnFileBrowse.Name = "brnFileBrowse"
        Me.brnFileBrowse.Size = New System.Drawing.Size(101, 29)
        Me.brnFileBrowse.TabIndex = 4
        Me.brnFileBrowse.Text = "Browse"
        Me.brnFileBrowse.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(185, 231)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(290, 26)
        Me.txtFilePath.TabIndex = 5
        '
        'frmYouTubeDL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 530)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.brnFileBrowse)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.lblDownloadFilePath)
        Me.Controls.Add(Me.lblSourceAdress)
        Me.Controls.Add(Me.btnDownload)
        Me.Name = "frmYouTubeDL"
        Me.Text = "Youtube-dl Front End"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDownload As Button
    Friend WithEvents lblSourceAdress As Label
    Friend WithEvents lblDownloadFilePath As Label
    Friend WithEvents txtSource As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents brnFileBrowse As Button
End Class
