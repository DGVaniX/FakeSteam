Public Class Form3
    Public Property val As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        System.Threading.Thread.Sleep(1500)
        Me.Hide()
        System.Threading.Thread.Sleep(1500)
        Dim RecoveryCode As New Form4
        RecoveryCode.Show()
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub
End Class