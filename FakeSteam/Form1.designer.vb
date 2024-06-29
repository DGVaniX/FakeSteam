<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SteamTheme1 = New FakeSteam.SteamTheme()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SteamButton2 = New FakeSteam.SteamButton()
        Me.SteamButton1 = New FakeSteam.SteamButton()
        Me.SteamClose2 = New FakeSteam.SteamClose()
        Me.SteamMinimize2 = New FakeSteam.SteamMinimize()
        Me.SteamTextBox1 = New FakeSteam.SteamTextBox()
        Me.UsernameBox = New FakeSteam.SteamTextBox()
        Me.RememberMeButton = New FakeSteam.SteamCheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CancelButton = New FakeSteam.SteamButton()
        Me.LoginButton = New FakeSteam.SteamButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SteamTheme1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SteamTheme1
        '
        Me.SteamTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SteamTheme1.Colors = New FakeSteam.Bloom(-1) {}
        Me.SteamTheme1.Controls.Add(Me.PictureBox4)
        Me.SteamTheme1.Controls.Add(Me.SteamButton2)
        Me.SteamTheme1.Controls.Add(Me.SteamButton1)
        Me.SteamTheme1.Controls.Add(Me.SteamClose2)
        Me.SteamTheme1.Controls.Add(Me.SteamMinimize2)
        Me.SteamTheme1.Controls.Add(Me.SteamTextBox1)
        Me.SteamTheme1.Controls.Add(Me.UsernameBox)
        Me.SteamTheme1.Controls.Add(Me.RememberMeButton)
        Me.SteamTheme1.Controls.Add(Me.PictureBox2)
        Me.SteamTheme1.Controls.Add(Me.CancelButton)
        Me.SteamTheme1.Controls.Add(Me.LoginButton)
        Me.SteamTheme1.Controls.Add(Me.PictureBox1)
        Me.SteamTheme1.Controls.Add(Me.PictureBox3)
        Me.SteamTheme1.Customization = ""
        Me.SteamTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SteamTheme1.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.SteamTheme1.Image = Nothing
        Me.SteamTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SteamTheme1.Movable = True
        Me.SteamTheme1.Name = "SteamTheme1"
        Me.SteamTheme1.NoRounding = False
        Me.SteamTheme1.Sizable = False
        Me.SteamTheme1.Size = New System.Drawing.Size(480, 330)
        Me.SteamTheme1.SmartBounds = True
        Me.SteamTheme1.TabIndex = 0
        Me.SteamTheme1.Text = "Steam - VAC Remover"
        Me.SteamTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.SteamTheme1.Transparent = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(29, 221)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(420, 52)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'SteamButton2
        '
        Me.SteamButton2.Activated = FakeSteam.SteamButton._Options._true
        Me.SteamButton2.Colors = New FakeSteam.Bloom(-1) {}
        Me.SteamButton2.Customization = ""
        Me.SteamButton2.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.SteamButton2.Image = Nothing
        Me.SteamButton2.Location = New System.Drawing.Point(213, 272)
        Me.SteamButton2.Name = "SteamButton2"
        Me.SteamButton2.NoRounding = False
        Me.SteamButton2.Size = New System.Drawing.Size(237, 23)
        Me.SteamButton2.TabIndex = 22
        Me.SteamButton2.Text = "Create a new account"
        Me.SteamButton2.Transparent = False
        '
        'SteamButton1
        '
        Me.SteamButton1.Activated = FakeSteam.SteamButton._Options._true
        Me.SteamButton1.Colors = New FakeSteam.Bloom(-1) {}
        Me.SteamButton1.Customization = ""
        Me.SteamButton1.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.SteamButton1.Image = Nothing
        Me.SteamButton1.Location = New System.Drawing.Point(213, 241)
        Me.SteamButton1.Name = "SteamButton1"
        Me.SteamButton1.NoRounding = False
        Me.SteamButton1.Size = New System.Drawing.Size(237, 23)
        Me.SteamButton1.TabIndex = 21
        Me.SteamButton1.Text = "I can't sign in..."
        Me.SteamButton1.Transparent = False
        '
        'SteamClose2
        '
        Me.SteamClose2.BackColor = System.Drawing.Color.Transparent
        Me.SteamClose2.Location = New System.Drawing.Point(458, 9)
        Me.SteamClose2.Name = "SteamClose2"
        Me.SteamClose2.Size = New System.Drawing.Size(12, 12)
        Me.SteamClose2.TabIndex = 16
        Me.SteamClose2.Text = "SteamClose2"
        '
        'SteamMinimize2
        '
        Me.SteamMinimize2.BackColor = System.Drawing.Color.Transparent
        Me.SteamMinimize2.Location = New System.Drawing.Point(443, 9)
        Me.SteamMinimize2.Name = "SteamMinimize2"
        Me.SteamMinimize2.Size = New System.Drawing.Size(12, 12)
        Me.SteamMinimize2.TabIndex = 15
        Me.SteamMinimize2.Text = "SteamMinimize2"
        '
        'SteamTextBox1
        '
        Me.SteamTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.SteamTextBox1.Colors = New FakeSteam.Bloom(-1) {}
        Me.SteamTextBox1.Customization = ""
        Me.SteamTextBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SteamTextBox1.Image = Nothing
        Me.SteamTextBox1.Location = New System.Drawing.Point(113, 123)
        Me.SteamTextBox1.MaxCharacters = 0
        Me.SteamTextBox1.Name = "SteamTextBox1"
        Me.SteamTextBox1.NoRounding = False
        Me.SteamTextBox1.Size = New System.Drawing.Size(334, 22)
        Me.SteamTextBox1.TabIndex = 14
        Me.SteamTextBox1.Transparent = True
        Me.SteamTextBox1.UsePasswordMask = True
        '
        'UsernameBox
        '
        Me.UsernameBox.BackColor = System.Drawing.Color.Transparent
        Me.UsernameBox.Colors = New FakeSteam.Bloom(-1) {}
        Me.UsernameBox.Customization = ""
        Me.UsernameBox.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.UsernameBox.Image = Nothing
        Me.UsernameBox.Location = New System.Drawing.Point(113, 89)
        Me.UsernameBox.MaxCharacters = 0
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.NoRounding = False
        Me.UsernameBox.Size = New System.Drawing.Size(334, 22)
        Me.UsernameBox.TabIndex = 13
        Me.UsernameBox.Transparent = True
        Me.UsernameBox.UsePasswordMask = False
        '
        'RememberMeButton
        '
        Me.RememberMeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RememberMeButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RememberMeButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.RememberMeButton.Checked = False
        Me.RememberMeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RememberMeButton.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.RememberMeButton.Location = New System.Drawing.Point(112, 153)
        Me.RememberMeButton.Name = "RememberMeButton"
        Me.RememberMeButton.Options = FakeSteam.SteamCheckBox._Options.Style1
        Me.RememberMeButton.Size = New System.Drawing.Size(166, 22)
        Me.RememberMeButton.TabIndex = 12
        Me.RememberMeButton.Text = "Remember my password"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(66, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'CancelButton
        '
        Me.CancelButton.Activated = FakeSteam.SteamButton._Options._true
        Me.CancelButton.Colors = New FakeSteam.Bloom(-1) {}
        Me.CancelButton.Customization = ""
        Me.CancelButton.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.CancelButton.Image = Nothing
        Me.CancelButton.Location = New System.Drawing.Point(285, 184)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.NoRounding = False
        Me.CancelButton.Size = New System.Drawing.Size(161, 23)
        Me.CancelButton.TabIndex = 10
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.Transparent = False
        '
        'LoginButton
        '
        Me.LoginButton.Activated = FakeSteam.SteamButton._Options._true
        Me.LoginButton.Colors = New FakeSteam.Bloom(-1) {}
        Me.LoginButton.Customization = ""
        Me.LoginButton.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.LoginButton.Image = Nothing
        Me.LoginButton.Location = New System.Drawing.Point(112, 184)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.NoRounding = False
        Me.LoginButton.Size = New System.Drawing.Size(167, 23)
        Me.LoginButton.TabIndex = 9
        Me.LoginButton.Text = "Login"
        Me.LoginButton.Transparent = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(481, 221)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(2, 215)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(480, 116)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 330)
        Me.Controls.Add(Me.SteamTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.SteamTheme1.ResumeLayout(False)
        Me.SteamTheme1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SteamTheme1 As SteamTheme
    Friend WithEvents SteamMinimize2 As SteamMinimize
    Friend WithEvents SteamClose2 As SteamClose
    Friend WithEvents SteamTextBox1 As SteamTextBox
    Friend WithEvents UsernameBox As SteamTextBox
    Friend WithEvents RememberMeButton As SteamCheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CancelButton As SteamButton
    Friend WithEvents LoginButton As SteamButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SteamButton2 As SteamButton
    Friend WithEvents SteamButton1 As SteamButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
