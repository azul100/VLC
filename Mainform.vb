Public Class Mainform
    Dim musiclocation As New TextBox
    Private Sub OpenFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim Openmusic As New OpenFileDialog
        Openmusic.FileName = ""
        Openmusic.Filter = "All Audio & Video Files|*.wav;*.mpa;*.mp2;*.mp3;*.au;*.aif;*.aiff;*.snd;*.wma;*.avi;*.qt;*.mov;*.mpq;*.mpeg;*.mkv;*.wmv;*.m1v;*.mp4;*.avi;*.qt;*.mov;*.mpq;*.mpeg;*.wmv;*.m1v;*.mp4"
        Openmusic.Title = "Open File"
        Openmusic.ShowDialog()
        If Openmusic.FileName <> "" Then
            wmp.URL = Openmusic.FileName
        End If
    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFolderToolStripMenuItem.Click
      
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        wmp.Ctlcontrols.play()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        wmp.Ctlcontrols.pause()
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        wmp.Ctlcontrols.stop()
    End Sub

    Private Sub PreviousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousToolStripMenuItem.Click
        wmp.Ctlcontrols.previous()
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        wmp.Ctlcontrols.next()
    End Sub

    Private Sub IncreaseVolumeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncreaseVolumeToolStripMenuItem.Click
        Volume.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Dim Openmusic As New OpenFileDialog
        Openmusic.InitialDirectory = "c"
        Openmusic.FileName = ""
        Openmusic.Filter = "All Audio & Video Files|*.wav;*.mpa;*.mp2;*.mp3;*.au;*.aif;*.aiff;*.snd;*.wma;*.avi;*.qt;*.mov;*.mpq;*.mpeg;*.mkv;*.wmv;*.m1v;*.mp4;*.avi;*.qt;*.mov;*.mpq;*.mpeg;*.wmv;*.m1v;*.mp4"
        Openmusic.Title = "Open File"
        Openmusic.ShowDialog()
        If Openmusic.FileName <> "" Then
            wmp.URL = Openmusic.FileName
        End If
    End Sub

   
    Private Sub VideoTrackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideoTrackToolStripMenuItem.Click

    End Sub

   
    Private Sub PreferancesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferancesToolStripMenuItem.Click

    End Sub

    Private Sub PlaylistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaylistToolStripMenuItem.Click

    End Sub

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub wmp_Enter(sender As Object, e As EventArgs) Handles wmp.Enter

    End Sub
End Class
