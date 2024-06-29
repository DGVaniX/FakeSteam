<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.SteamTheme1 = New FakeSteam.SteamTheme()
        Me.SteamClose1 = New FakeSteam.SteamClose()
        Me.SteamTextBox1 = New FakeSteam.SteamTextBox()
        Me.SteamButton2 = New FakeSteam.SteamButton()
        Me.SteamButton1 = New FakeSteam.SteamButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SteamTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SteamTheme1
        '
        Me.SteamTheme1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.SteamTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SteamTheme1.Colors = New FakeSteam.Bloom(-1) {}
        Me.SteamTheme1.Controls.Add(Me.SteamClose1)
        Me.SteamTheme1.Controls.Add(Me.SteamTextBox1)
        Me.SteamTheme1.Controls.Add(Me.SteamButton2)
        Me.SteamTheme1.Controls.Add(Me.SteamButton1)
        Me.SteamTheme1.Controls.Add(Me.PictureBox1)
        Me.SteamTheme1.Customization = ""
        Me.SteamTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SteamTheme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SteamTheme1.Image = Nothing
        Me.SteamTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SteamTheme1.Movable = True
        Me.SteamTheme1.Name = "SteamTheme1"
        Me.SteamTheme1.NoRounding = False
        Me.SteamTheme1.Sizable = True
        Me.SteamTheme1.Size = New System.Drawing.Size(380, 420)
        Me.SteamTheme1.SmartBounds = True
        Me.SteamTheme1.TabIndex = 0
        Me.SteamTheme1.Text = "Steam"
        Me.SteamTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.SteamTheme1.Transparent = False
        '
        'SteamClose1
        '
        Me.SteamClose1.BackColor = System.Drawing.Color.Transparent
        Me.SteamClose1.Location = New System.Drawing.Point(357, 8)
        Me.SteamClose1.Name = "SteamClose1"
        Me.SteamClose1.Size = New System.Drawing.Size(12, 12)
        Me.SteamClose1.TabIndex = 4
        Me.SteamClose1.Text = "SteamClose1"
        '
        'SteamTextBox1
        '
        Me.SteamTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.SteamTextBox1.Colors = New FakeSteam.Bloom(-1) {}
        Me.SteamTextBox1.Customization = ""
        Me.SteamTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.SteamTextBox1.Image = Nothing
        Me.SteamTextBox1.Location = New System.Drawing.Point(86, 76)
        Me.SteamTextBox1.MaxCharacters = 0
        Me.SteamTextBox1.Name = "SteamTextBox1"
        Me.SteamTextBox1.NoRounding = False
        Me.SteamTextBox1.Size = New System.Drawing.Size(190, 48)
        Me.SteamTextBox1.TabIndex = 3
        Me.SteamTextBox1.Text = "R"
        Me.SteamTextBox1.Transparent = True
        Me.SteamTextBox1.UsePasswordMask = False
        '
        'SteamButton2
        '
        Me.SteamButton2.Activated = FakeSteam.SteamButton._Options._true
        Me.SteamButton2.Colors = New FakeSteam.Bloom(-1) {}
        Me.SteamButton2.Customization = ""
        Me.SteamButton2.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.SteamButton2.Image = Nothing
        Me.SteamButton2.Location = New System.Drawing.Point(177, 384)
        Me.SteamButton2.Name = "SteamButton2"
        Me.SteamButton2.NoRounding = False
        Me.SteamButton2.Size = New System.Drawing.Size(91, 24)
        Me.SteamButton2.TabIndex = 2
        Me.SteamButton2.Text = "Ok"
        Me.SteamButton2.Transparent = False
        '
        'SteamButton1
        '
        Me.SteamButton1.Activated = FakeSteam.SteamButton._Options._true
        Me.SteamButton1.Colors = New FakeSteam.Bloom(-1) {}
        Me.SteamButton1.Customization = ""
        Me.SteamButton1.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.SteamButton1.Image = Nothing
        Me.SteamButton1.Location = New System.Drawing.Point(278, 384)
        Me.SteamButton1.Name = "SteamButton1"
        Me.SteamButton1.NoRounding = False
        Me.SteamButton1.Size = New System.Drawing.Size(91, 24)
        Me.SteamButton1.TabIndex = 1
        Me.SteamButton1.Text = "Close"
        Me.SteamButton1.Transparent = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 420)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 420)
        Me.Controls.Add(Me.SteamTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Steam"
        Me.SteamTheme1.ResumeLayout(False)
        Me.SteamTheme1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SteamTheme1 As SteamTheme
    Friend WithEvents SteamTextBox1 As SteamTextBox
    Friend WithEvents SteamButton2 As SteamButton
    Friend WithEvents SteamButton1 As SteamButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SteamClose1 As SteamClose
End Class
