Imports System
Imports System.IO
Imports System.Threading

' Synchronizes files between folders '
Public Class FileSync
    Private sourceFolderDialog As New FolderBrowserDialog
    Private destFolderDialog As New FolderBrowserDialog

    Private Sub SourceFileChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SourceFileChooser.Click
        Dim result As DialogResult = sourceFolderDialog.ShowDialog()
        If (result = DialogResult.OK) Then
            SourceDirectory.Text = sourceFolderDialog.SelectedPath
        End If
    End Sub

    Private Sub DestFileChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DestFileChooser.Click
        Dim result As DialogResult = destFolderDialog.ShowDialog()
        If (result = DialogResult.OK) Then
            DestDirectory.Text = destFolderDialog.SelectedPath
        End If
    End Sub

    ' Main synchronizing function, helper functions below '
    Private Sub Synchronize(ByVal delString As String)
        ' If synchronize checkbox is checked '
        Dim deleted As Boolean = False
        If My.Settings.SyncState Then
            Try
                ' If the two paths given by the user are VALID (NOT that they exist) ' 
                If Not String.IsNullOrEmpty(Path.GetFullPath(My.Settings.OriginPath)) And Not String.IsNullOrEmpty(Path.GetFullPath(My.Settings.DestinationPath)) Then
                    Try
                        FileSystemWatcher1.Path = SourceDirectory.Text
                        Dim dir As New DirectoryInfo(My.Settings.OriginPath)
                        Dim fileArray As FileInfo() = dir.GetFiles()
                        Dim file As FileInfo

                        ' Split COMMA SEPARATED string of acceptable extensions into usable string array ' 
                        Dim srcExtArr As String() = My.Settings.OriginExt.Split(",")
                        Dim dstExtArr As String() = My.Settings.DestExt.Split(",")

                        ' If "Source Extensions" textbox is empty then sync everything '
                        Dim syncAll As Boolean = False
                        If String.IsNullOrEmpty(srcExtArr(0)) Then
                            syncAll = True
                        End If

                        ' Iterate through all files in source directory and copy them according to given Source Extensions (or lack thereof) '
                        For Each file In fileArray
                            If syncAll = True Then
                                AttemptCopy(file)
                            ElseIf Array.IndexOf(srcExtArr, file.Extension) > -1 Then
                                AttemptCopy(file, srcExtArr, dstExtArr)
                            Else
                                ' Skip file because it's not in the acceptable extensions '
                            End If
                            If Not String.IsNullOrEmpty(delString) And deleted = False Then
                                For i As Integer = 2 To 0 Step -1
                                    Try
                                        My.Computer.FileSystem.DeleteFile(My.Settings.DestinationPath + "\" + delString)
                                        deleted = True
                                        Exit For
                                    Catch ex As IOException
                                        Thread.Sleep(5000)
                                    End Try
                                Next
                            End If
                        Next
                        ' Catch problematic directory '
                    Catch ex As DirectoryNotFoundException
                        MessageBox.Show("Must use existing directory as Source Directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Exit Sub
                    End Try

                Else
                    MessageBox.Show("Please change to valid path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As ArgumentException
                MessageBox.Show("Please input valid file path", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Try
        Else
            MessageBox.Show("Synchronize Stopped! Recheck box and click 'Reset' to continue synchronizing", "Status", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SetPaths()
        Synchronize("")
    End Sub

    Private Sub SetPaths()
        ' Remove spaces from user input '
        My.Settings.OriginExt = SourceExt.Text.Replace(" ", "")
        My.Settings.DestExt = DestExt.Text.Replace(" ", "")
        My.Settings.OriginPath = SourceDirectory.Text
        My.Settings.DestinationPath = DestDirectory.Text
        My.Settings.SyncState = SyncBox.Checked
        My.Settings.Save()
    End Sub

    Private Sub SetTextBoxes()
        SourceExt.Text = My.Settings.OriginExt
        DestExt.Text = My.Settings.DestExt
        SourceDirectory.Text = My.Settings.OriginPath
        DestDirectory.Text = My.Settings.DestinationPath
        SyncBox.Checked = My.Settings.SyncState
    End Sub

    ' Copy file same extension '
    Private Sub AttemptCopy(ByVal file)
        Dim maxAttempt As Integer = 2
        For i As Integer = maxAttempt To 0 Step -1
            Try
                My.Computer.FileSystem.CopyFile(file.FullName, My.Settings.DestinationPath + "\" + file.Name, overwrite:=True)
                Exit For
            Catch ex As IOException
                Thread.Sleep(5000)
            End Try
        Next


    End Sub

    ' Copy file different extension '
    Private Sub AttemptCopy(ByVal file As FileInfo, ByVal src As String(), ByVal dst As String())
        Dim maxAttempt As Integer = 2
        Dim newExt As Integer

        newExt = Array.IndexOf(src, file.Extension)
        For i As Integer = maxAttempt To 0 Step -1
            Try
                If newExt = -1 Or newExt > dst.Count() - 1 Then
                    My.Computer.FileSystem.CopyFile(file.FullName, My.Settings.DestinationPath + "\" + file.Name, overwrite:=True)
                Else
                    My.Computer.FileSystem.CopyFile(file.FullName, My.Settings.DestinationPath + "\" + Path.ChangeExtension(file.Name, dst(newExt)), overwrite:=True)
                End If
                Exit For
            Catch ex As IOException
                Thread.Sleep(5000)
            End Try
        Next


    End Sub

    Private Sub FileSystemWatcher1_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        Synchronize("")
    End Sub
    Private Sub FileSystemWatcher1_Created(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        Synchronize("")
    End Sub
    Private Sub FileSystemWatcher1_Deleted(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Deleted
        Synchronize(e.Name)
    End Sub
    Private Sub FileSystemWatcher1_Renamed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Renamed
        Synchronize("")
    End Sub

    Private Sub FileSync_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetTextBoxes()
        Synchronize("")
    End Sub
End Class