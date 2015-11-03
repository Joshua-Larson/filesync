<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileSync
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
        Me.DestDirectory = New System.Windows.Forms.TextBox
        Me.SyncBox = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SourceDirectory = New System.Windows.Forms.TextBox
        Me.SourceFileChooser = New System.Windows.Forms.Button
        Me.DestFileChooser = New System.Windows.Forms.Button
        Me.SourceExt = New System.Windows.Forms.TextBox
        Me.DestExt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DestDirectory
        '
        Me.DestDirectory.Location = New System.Drawing.Point(12, 79)
        Me.DestDirectory.Name = "DestDirectory"
        Me.DestDirectory.Size = New System.Drawing.Size(238, 20)
        Me.DestDirectory.TabIndex = 2
        '
        'SyncBox
        '
        Me.SyncBox.AutoSize = True
        Me.SyncBox.Location = New System.Drawing.Point(12, 158)
        Me.SyncBox.Name = "SyncBox"
        Me.SyncBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SyncBox.Size = New System.Drawing.Size(87, 17)
        Me.SyncBox.TabIndex = 6
        Me.SyncBox.Text = "Sync Folders"
        Me.SyncBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Source Directory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Destination Directory"
        '
        'SourceDirectory
        '
        Me.SourceDirectory.Location = New System.Drawing.Point(12, 27)
        Me.SourceDirectory.Name = "SourceDirectory"
        Me.SourceDirectory.Size = New System.Drawing.Size(238, 20)
        Me.SourceDirectory.TabIndex = 0
        '
        'SourceFileChooser
        '
        Me.SourceFileChooser.Location = New System.Drawing.Point(256, 27)
        Me.SourceFileChooser.Name = "SourceFileChooser"
        Me.SourceFileChooser.Size = New System.Drawing.Size(24, 21)
        Me.SourceFileChooser.TabIndex = 1
        Me.SourceFileChooser.Text = "..."
        Me.SourceFileChooser.UseVisualStyleBackColor = True
        '
        'DestFileChooser
        '
        Me.DestFileChooser.Location = New System.Drawing.Point(256, 79)
        Me.DestFileChooser.Name = "DestFileChooser"
        Me.DestFileChooser.Size = New System.Drawing.Size(24, 21)
        Me.DestFileChooser.TabIndex = 3
        Me.DestFileChooser.Text = "..."
        Me.DestFileChooser.UseVisualStyleBackColor = True
        '
        'SourceExt
        '
        Me.SourceExt.Location = New System.Drawing.Point(12, 130)
        Me.SourceExt.Name = "SourceExt"
        Me.SourceExt.Size = New System.Drawing.Size(106, 20)
        Me.SourceExt.TabIndex = 4
        '
        'DestExt
        '
        Me.DestExt.Location = New System.Drawing.Point(180, 130)
        Me.DestExt.Name = "DestExt"
        Me.DestExt.Size = New System.Drawing.Size(100, 20)
        Me.DestExt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Source Extensions"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Destination Extensions"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'FileSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 196)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DestExt)
        Me.Controls.Add(Me.SourceExt)
        Me.Controls.Add(Me.DestFileChooser)
        Me.Controls.Add(Me.SourceFileChooser)
        Me.Controls.Add(Me.SourceDirectory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SyncBox)
        Me.Controls.Add(Me.DestDirectory)
        Me.Name = "FileSync"
        Me.Text = "File Synchronizer"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DestDirectory As System.Windows.Forms.TextBox
    Friend WithEvents SyncBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SourceDirectory As System.Windows.Forms.TextBox
    Friend WithEvents SourceFileChooser As System.Windows.Forms.Button
    Friend WithEvents DestFileChooser As System.Windows.Forms.Button
    Friend WithEvents SourceExt As System.Windows.Forms.TextBox
    Friend WithEvents DestExt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher

End Class
