Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Class SteamTheme
    Inherits ThemeContainer153

    Sub New()
        ForeColor = Color.FromArgb(226, 226, 226)
        Font = New Font("Segoe UI", 7)
    End Sub

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        DrawGradient(Color.FromArgb(25, 54, 82), Color.FromArgb(29, 30, 31), ClientRectangle, 43)
        DrawGradient(Color.FromArgb(25, 54, 82), Color.Transparent, ClientRectangle, -100)
        G.FillRectangle(New SolidBrush(Color.FromArgb(38, 38, 38)), New Rectangle(1, 1, Width - 2, Height - 2))
        DrawGradient(Color.FromArgb(30, 36, 44), Color.FromArgb(38, 38, 38), New Rectangle(1, 1, Width - 2, 35), 90S)
        DrawText(New SolidBrush(Color.FromArgb(195, 193, 191)), HorizontalAlignment.Left, 7, 2)
    End Sub
End Class

Class SteamButton
    Inherits ThemeControl153

    Private O As _Options
    <Flags()>
    Enum _Options
        _true
        _false
    End Enum
    <Category("Activated")>
    Public Property Activated As _Options
        Get
            Return O
        End Get
        Set(value As _Options)
            O = value
        End Set
    End Property
    Sub New()
        Font = New Font("Verdana", 7.25)

    End Sub

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(38, 38, 38))


        Select Case O
            Case _Options._true

                Select Case State
                    Case 0
                        DrawGradient(Color.FromArgb(79, 79, 79), Color.FromArgb(58, 58, 58), ClientRectangle, 90S)
                    Case 1
                        DrawGradient(Color.FromArgb(105, 105, 105), Color.FromArgb(61, 61, 61), ClientRectangle, 90S)
                    Case 2
                        DrawGradient(Color.FromArgb(39, 39, 39), Color.FromArgb(57, 57, 57), ClientRectangle, 90S)
                End Select
                DrawText(New SolidBrush(Color.FromArgb(195, 193, 191)), Text.ToUpper, HorizontalAlignment.Left, 4, 0)
            Case _Options._false
                Select Case State
                    Case 0
                        DrawGradient(Color.FromArgb(44, 44, 44), Color.FromArgb(44, 44, 44), ClientRectangle, 90S)
                    Case 1
                        DrawGradient(Color.FromArgb(44, 44, 44), Color.FromArgb(44, 44, 44), ClientRectangle, 90S)
                    Case 2
                        DrawGradient(Color.FromArgb(44, 44, 44), Color.FromArgb(44, 44, 44), ClientRectangle, 90S)
                End Select
                DrawText(New SolidBrush(Color.FromArgb(115, 115, 115)), Text.ToUpper, HorizontalAlignment.Left, 4, 0)
        End Select
    End Sub
End Class

Class SteamSeparator
    Inherits ThemeControl153

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.FillRectangle(New SolidBrush(Color.FromArgb(38, 38, 38)), ClientRectangle)
        DrawGradient(Color.FromArgb(107, 104, 101), Color.FromArgb(74, 72, 70), New Rectangle(0, Height / 2, Width, 1), 45S)
    End Sub
End Class

<DefaultEvent("CheckedChanged")> Class SteamCheckBox : Inherits Control

#Region " Variables"

    Private W, H As Integer
    Private State As MouseState = MouseState.None
    Private O As _Options
    Private _Checked As Boolean

#End Region

#Region " Properties"
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property

    Event CheckedChanged(ByVal sender As Object)
    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub

    <Flags>
    Enum _Options
        Style1
        Style2
    End Enum

    <Category("Options")>
    Public Property Options As _Options
        Get
            Return O
        End Get
        Set(value As _Options)
            O = value
        End Set
    End Property

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = Height
    End Sub

#Region " Colors"

    <Category("Colors")>
    Public Property BaseColor As Color
        Get
            Return _BaseColor
        End Get
        Set(value As Color)
            _BaseColor = value
        End Set
    End Property

    <Category("Colors")>
    Public Property BorderColor As Color
        Get
            Return _BorderColor
        End Get
        Set(value As Color)
            _BorderColor = value
        End Set
    End Property

#End Region

#Region " Mouse States"

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub

#End Region

#End Region

#Region " Colors"
#Region " Variables"
    Friend G As Graphics, B As Bitmap
    Friend _FlatColor As Color = Color.FromArgb(103, 103, 103)
    Friend NearSF As New StringFormat() With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near}
    Friend CenterSF As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
#End Region
    Private _BaseColor As Color = Color.FromArgb(38, 38, 38)
    Private _BorderColor As Color = Color.FromArgb(103, 103, 103)
    Private _TextColor As Color = Color.FromArgb(226, 226, 226)
    Private checkcolor As Color = Color.FromArgb(226, 226, 226)

#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        BackColor = Color.FromArgb(38, 38, 38)
        Cursor = Cursors.Hand
        Font = New Font("Segoe UI", 8)
        Size = New Size(112, 22)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        B = New Bitmap(Width, Height) : G = Graphics.FromImage(B)
        W = Width - 1 : H = Height - 1

        Dim Base As New Rectangle(0, 3, Height - 8, Height - 8)

        With G
            .SmoothingMode = 2
            .TextRenderingHint = 5
            .Clear(BackColor)

            .FillRectangle(New SolidBrush(_BaseColor), Base)

            .DrawRectangle(New Pen(_BorderColor), Base)

            If Checked Then
                .DrawString("✔", New Font("Segoe UI Symbol", 10), New SolidBrush(checkcolor), New Rectangle(4, 6, H - 12.5, H - 11), CenterSF)
            End If

            .DrawString(Text, Font, New SolidBrush(_TextColor), New Rectangle(23, 4.5, W, H), NearSF)

        End With

        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
End Class
Class SteamProgressBar
    Inherits ThemeControl153

    Private _Maximum As Integer
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal v As Integer)
            Select Case v
                Case Is < _Value
                    _Value = v
            End Select
            _Maximum = v
            Invalidate()
        End Set
    End Property
    Private _Value As Integer
    Public Property Value() As Integer
        Get
            Select Case _Value
                Case 0
                    Return 1
                Case Else
                    Return _Value
            End Select
        End Get
        Set(ByVal v As Integer)
            Select Case v
                Case Is > _Maximum
                    v = _Maximum
            End Select
            _Value = v
            Invalidate()
        End Set
    End Property

    Sub New()
        Transparent = True
        BackColor = Color.Transparent
        LockHeight = 18
        Value = 0
        Maximum = 100
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(BackColor)
        'Fill
        Select Case _Value
            Case Is > 2
                G.FillRectangle(New SolidBrush(Color.FromArgb(166, 164, 161)), New Rectangle(4, 4, CInt(_Value / _Maximum * Width) - 8, Height - 8))
            Case Is > 0
                G.FillRectangle(New SolidBrush(Color.FromArgb(166, 164, 161)), New Rectangle(4, 4, CInt(_Value / _Maximum * Width) - 2, Height - 8))

        End Select

        DrawBorders(New Pen(New SolidBrush(Color.FromArgb(128, 124, 120))))
        DrawCorners(BackColor)
    End Sub

    Protected Overrides Sub ColorHook()

    End Sub
End Class

Class SteamTextBox
    Inherits ThemeControl153
    Dim WithEvents txtbox As New TextBox

    Private _PassMask As Boolean
    Public Property UsePasswordMask() As Boolean
        Get
            Return _PassMask
        End Get
        Set(ByVal v As Boolean)
            _PassMask = v
            Invalidate()
        End Set
    End Property
    Private _maxchars As Integer
    Public Property MaxCharacters() As Integer
        Get
            Return _maxchars
        End Get
        Set(ByVal v As Integer)
            _maxchars = v
        End Set
    End Property

    Sub New()
        txtbox.TextAlign = HorizontalAlignment.Left
        txtbox.BorderStyle = BorderStyle.None
        txtbox.Location = New Point(4, 4)
        txtbox.Font = New Font("Segoe UI", 8)
        Controls.Add(txtbox)
        Text = ""
        txtbox.Text = ""
        Me.Size = New Size(135, 22)
        Transparent = True
        BackColor = Color.Transparent
    End Sub

    Dim P1 As Pen

    Protected Overrides Sub ColorHook()
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(38, 38, 38))
        Select Case UsePasswordMask
            Case True
                txtbox.UseSystemPasswordChar = True
            Case False
                txtbox.UseSystemPasswordChar = False
        End Select
        Size = New Size(Width, Height)
        txtbox.BackColor = Color.FromArgb(38, 38, 38)
        txtbox.ForeColor = Color.FromArgb(195, 193, 191)
        txtbox.Font = Font
        txtbox.Size = New Size(Width - 10, txtbox.Height - 10)
        txtbox.MaxLength = MaxCharacters
        DrawBorders(New Pen(New SolidBrush(Color.FromArgb(137, 137, 137))))
        DrawCorners(BackColor)
    End Sub
    Sub TextChngTxtBox() Handles txtbox.TextChanged
        Text = txtbox.Text
    End Sub
    Sub TextChng() Handles MyBase.TextChanged
        txtbox.Text = Text
    End Sub
End Class

Class SteamClose
    Inherits Control

#Region " Declarations "
    Private _State As MouseState
#End Region

#Region " Mouse States "
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        Environment.Exit(0)
    End Sub
#End Region

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(12, 12)
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(12, 12)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        BackColor = Color.Transparent

        Dim _StringF As New StringFormat
        _StringF.Alignment = StringAlignment.Center
        _StringF.LineAlignment = StringAlignment.Center

        G.DrawString("X", New Font("Verdana", 8, FontStyle.Bold), New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(175, 175, 175), Color.FromArgb(175, 175, 175)), New RectangleF(0, 0, Width, Height), _StringF)

        Select Case _State
            Case MouseState.Over
                G.DrawString("X", New Font("Verdana", 8, FontStyle.Bold), New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(226, 226, 226), Color.FromArgb(226, 226, 226)), New RectangleF(0, 0, Width, Height), _StringF)

            Case MouseState.Down
                G.DrawString("X", New Font("Verdana", 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(40, Color.Black)), New RectangleF(0, 0, Width, Height), _StringF)
        End Select

    End Sub

End Class

Class SteamMinimize
    Inherits Control

#Region " Declarations "
    Private _State As MouseState
#End Region

#Region " Mouse States "
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        FindForm.WindowState = FormWindowState.Minimized
    End Sub
#End Region

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(12, 12)
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(12, 12)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        BackColor = Color.Transparent
        Dim _StringF As New StringFormat
        _StringF.Alignment = StringAlignment.Center
        _StringF.LineAlignment = StringAlignment.Center
        G.DrawString("0", New Font("Marlett", 11), New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(175, 175, 175), Color.FromArgb(175, 175, 175)), New RectangleF(0, 0, Width, Height), _StringF)
        Select Case _State
            Case MouseState.Over
                G.DrawString("0", New Font("Marlett", 11), New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(226, 226, 226), Color.FromArgb(175, 175, 175)), New RectangleF(0, 0, Width, Height), _StringF)

            Case MouseState.Down
                G.DrawString("0", New Font("Marlett", 11), New SolidBrush(Color.FromArgb(40, Color.Black)), New RectangleF(0, 0, Width, Height), _StringF)
        End Select
    End Sub
End Class