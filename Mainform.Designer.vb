<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaybackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Track1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SterioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.IncreaseVolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoTrackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubtitleTrackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.FullscreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AspectRatioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CropToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediaInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodecInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreferancesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeInterfaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wmp
        '
        Me.wmp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wmp.Enabled = True
        Me.wmp.Location = New System.Drawing.Point(0, 24)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(938, 454)
        Me.wmp.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.MediaToolStripMenuItem, Me.PlaybackToolStripMenuItem, Me.AudioToolStripMenuItem, Me.VideoToolStripMenuItem, Me.ToolToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(938, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(48, 20)
        Me.ToolStripMenuItem9.Text = "Open"
        '
        'MediaToolStripMenuItem
        '
        Me.MediaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem, Me.OpenFolderToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.MediaToolStripMenuItem.Name = "MediaToolStripMenuItem"
        Me.MediaToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MediaToolStripMenuItem.Text = "Media"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.home
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'OpenFolderToolStripMenuItem
        '
        Me.OpenFolderToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.folder3
        Me.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        Me.OpenFolderToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.OpenFolderToolStripMenuItem.Text = "Open Folder"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(136, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.Delete16
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PlaybackToolStripMenuItem
        '
        Me.PlaybackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.PauseToolStripMenuItem, Me.StopToolStripMenuItem, Me.PreviousToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.PlaybackToolStripMenuItem.Name = "PlaybackToolStripMenuItem"
        Me.PlaybackToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PlaybackToolStripMenuItem.Text = "Playback"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.play
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.pause
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Image = Global.VLC.My.Resources.Resources._stop
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'PreviousToolStripMenuItem
        '
        Me.PreviousToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.Back
        Me.PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem"
        Me.PreviousToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.PreviousToolStripMenuItem.Text = "Previous"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.Button_Next_Icon_32
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'AudioToolStripMenuItem
        '
        Me.AudioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem3, Me.ToolStripMenuItem5, Me.IncreaseVolumeToolStripMenuItem, Me.ToolStripMenuItem2, Me.MuteToolStripMenuItem})
        Me.AudioToolStripMenuItem.Name = "AudioToolStripMenuItem"
        Me.AudioToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AudioToolStripMenuItem.Text = "Audio"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisableToolStripMenuItem, Me.Track1ToolStripMenuItem})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem4.Text = "Audeo Track"
        '
        'DisableToolStripMenuItem
        '
        Me.DisableToolStripMenuItem.Name = "DisableToolStripMenuItem"
        Me.DisableToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DisableToolStripMenuItem.Text = "Disable"
        '
        'Track1ToolStripMenuItem
        '
        Me.Track1ToolStripMenuItem.Checked = True
        Me.Track1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Track1ToolStripMenuItem.Name = "Track1ToolStripMenuItem"
        Me.Track1ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.Track1ToolStripMenuItem.Text = "Track 1"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SterioToolStripMenuItem, Me.MonoToolStripMenuItem})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem3.Text = "Audio Device"
        '
        'SterioToolStripMenuItem
        '
        Me.SterioToolStripMenuItem.Name = "SterioToolStripMenuItem"
        Me.SterioToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.SterioToolStripMenuItem.Text = "Sterio"
        '
        'MonoToolStripMenuItem
        '
        Me.MonoToolStripMenuItem.Name = "MonoToolStripMenuItem"
        Me.MonoToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.MonoToolStripMenuItem.Text = "Mono"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(141, 6)
        '
        'IncreaseVolumeToolStripMenuItem
        '
        Me.IncreaseVolumeToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.skype
        Me.IncreaseVolumeToolStripMenuItem.Name = "IncreaseVolumeToolStripMenuItem"
        Me.IncreaseVolumeToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.IncreaseVolumeToolStripMenuItem.Text = "Volume"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(141, 6)
        '
        'MuteToolStripMenuItem
        '
        Me.MuteToolStripMenuItem.Name = "MuteToolStripMenuItem"
        Me.MuteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.MuteToolStripMenuItem.Text = "Mute"
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VideoTrackToolStripMenuItem, Me.SubtitleTrackToolStripMenuItem, Me.ToolStripMenuItem6, Me.FullscreenToolStripMenuItem, Me.ToolStripMenuItem7, Me.ZoomToolStripMenuItem, Me.AspectRatioToolStripMenuItem, Me.CropToolStripMenuItem})
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        Me.VideoToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.VideoToolStripMenuItem.Text = "Video"
        '
        'VideoTrackToolStripMenuItem
        '
        Me.VideoTrackToolStripMenuItem.Name = "VideoTrackToolStripMenuItem"
        Me.VideoTrackToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.VideoTrackToolStripMenuItem.Text = "Video Track"
        '
        'SubtitleTrackToolStripMenuItem
        '
        Me.SubtitleTrackToolStripMenuItem.Name = "SubtitleTrackToolStripMenuItem"
        Me.SubtitleTrackToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SubtitleTrackToolStripMenuItem.Text = "Subtitle Track"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(143, 6)
        '
        'FullscreenToolStripMenuItem
        '
        Me.FullscreenToolStripMenuItem.Name = "FullscreenToolStripMenuItem"
        Me.FullscreenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.FullscreenToolStripMenuItem.Text = "Fullscreen"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(143, 6)
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ZoomToolStripMenuItem.Text = "Zoom"
        '
        'AspectRatioToolStripMenuItem
        '
        Me.AspectRatioToolStripMenuItem.Name = "AspectRatioToolStripMenuItem"
        Me.AspectRatioToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AspectRatioToolStripMenuItem.Text = "Aspect Ratio"
        '
        'CropToolStripMenuItem
        '
        Me.CropToolStripMenuItem.Name = "CropToolStripMenuItem"
        Me.CropToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CropToolStripMenuItem.Text = "Crop"
        '
        'ToolToolStripMenuItem
        '
        Me.ToolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MediaInformationToolStripMenuItem, Me.CodecInformationToolStripMenuItem, Me.ToolStripMenuItem8, Me.PreferancesToolStripMenuItem, Me.CustomizeInterfaceToolStripMenuItem})
        Me.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        Me.ToolToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolToolStripMenuItem.Text = "Tools"
        '
        'MediaInformationToolStripMenuItem
        '
        Me.MediaInformationToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.info
        Me.MediaInformationToolStripMenuItem.Name = "MediaInformationToolStripMenuItem"
        Me.MediaInformationToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.MediaInformationToolStripMenuItem.Text = "Media Information"
        '
        'CodecInformationToolStripMenuItem
        '
        Me.CodecInformationToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.info
        Me.CodecInformationToolStripMenuItem.Name = "CodecInformationToolStripMenuItem"
        Me.CodecInformationToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CodecInformationToolStripMenuItem.Text = "Codec Information"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(185, 6)
        '
        'PreferancesToolStripMenuItem
        '
        Me.PreferancesToolStripMenuItem.Image = Global.VLC.My.Resources.Resources._8d156129_7ad6_48c6_800b_3a7c0b529de5
        Me.PreferancesToolStripMenuItem.Name = "PreferancesToolStripMenuItem"
        Me.PreferancesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PreferancesToolStripMenuItem.Text = "Preferances"
        '
        'CustomizeInterfaceToolStripMenuItem
        '
        Me.CustomizeInterfaceToolStripMenuItem.Image = Global.VLC.My.Resources.Resources._8d156129_7ad6_48c6_800b_3a7c0b529de5
        Me.CustomizeInterfaceToolStripMenuItem.Name = "CustomizeInterfaceToolStripMenuItem"
        Me.CustomizeInterfaceToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CustomizeInterfaceToolStripMenuItem.Text = "Customize Interface..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaylistToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'PlaylistToolStripMenuItem
        '
        Me.PlaylistToolStripMenuItem.Image = Global.VLC.My.Resources.Resources._1369869503_99195
        Me.PlaylistToolStripMenuItem.Name = "PlaylistToolStripMenuItem"
        Me.PlaylistToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PlaylistToolStripMenuItem.Text = "Playlist"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.help_icon_p
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.VLC.My.Resources.Resources.info
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 477)
        Me.Controls.Add(Me.wmp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Mainform"
        Me.Text = "VLC"
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaybackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IncreaseVolumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MuteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoTrackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubtitleTrackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FullscreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AspectRatioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CropToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediaInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodecInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PreferancesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeInterfaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaylistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Track1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SterioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem

End Class
