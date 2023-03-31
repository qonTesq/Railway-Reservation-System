<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomeForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BookButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.ExitButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout
        CType(Me.Guna2PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1121, 32)
        Me.Guna2Panel1.TabIndex = 3
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.Animated = true
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(993, 0)
        Me.Guna2ControlBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(61, 32)
        Me.Guna2ControlBox3.TabIndex = 6
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = true
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1061, 0)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(61, 32)
        Me.Guna2ControlBox1.TabIndex = 4
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 29!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(493, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 66)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "travel"
        '
        'BookButton
        '
        Me.BookButton.Animated = true
        Me.BookButton.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.BookButton.BorderRadius = 10
        Me.BookButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BookButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BookButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169,Byte),Integer), CType(CType(169,Byte),Integer), CType(CType(169,Byte),Integer))
        Me.BookButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141,Byte),Integer), CType(CType(141,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.BookButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.BookButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BookButton.ForeColor = System.Drawing.Color.White
        Me.BookButton.ImageSize = New System.Drawing.Size(25, 25)
        Me.BookButton.Location = New System.Drawing.Point(292, 414)
        Me.BookButton.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Size = New System.Drawing.Size(220, 57)
        Me.BookButton.TabIndex = 30
        Me.BookButton.Text = "Book "
        '
        'ExitButton
        '
        Me.ExitButton.Animated = true
        Me.ExitButton.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.ExitButton.BorderRadius = 10
        Me.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169,Byte),Integer), CType(CType(169,Byte),Integer), CType(CType(169,Byte),Integer))
        Me.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141,Byte),Integer), CType(CType(141,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.ExitButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.ImageSize = New System.Drawing.Size(25, 25)
        Me.ExitButton.Location = New System.Drawing.Point(668, 414)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(220, 57)
        Me.ExitButton.TabIndex = 31
        Me.ExitButton.Text = "Exit"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"),System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(357, 74)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(448, 369)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 32
        Me.Guna2PictureBox1.TabStop = false
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1121, 555)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BookButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "WelcomeForm"
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(false)
        CType(Me.Guna2PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BookButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
