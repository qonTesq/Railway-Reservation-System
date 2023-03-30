<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PassengerIcon = New System.Windows.Forms.PictureBox()
        Me.ClassLabel = New System.Windows.Forms.Label()
        Me.ClassIcon = New System.Windows.Forms.PictureBox()
        Me.ClassComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ClassPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.ToComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.ToLabel = New System.Windows.Forms.Label()
        Me.ToIcon = New System.Windows.Forms.PictureBox()
        Me.PassengerPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.PassengerCount = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.ToPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.FromPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.FromLabel = New System.Windows.Forms.Label()
        Me.FromIcon = New System.Windows.Forms.PictureBox()
        Me.FromComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SearchButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.PassengerIcon,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ClassIcon,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ClassPanel.SuspendLayout
        CType(Me.ToIcon,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PassengerPanel.SuspendLayout
        CType(Me.PassengerCount,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToPanel.SuspendLayout
        Me.FromPanel.SuspendLayout
        CType(Me.FromIcon,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Guna2Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'PassengerIcon
        '
        Me.PassengerIcon.Image = CType(resources.GetObject("PassengerIcon.Image"),System.Drawing.Image)
        Me.PassengerIcon.Location = New System.Drawing.Point(9, 15)
        Me.PassengerIcon.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PassengerIcon.Name = "PassengerIcon"
        Me.PassengerIcon.Size = New System.Drawing.Size(28, 26)
        Me.PassengerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PassengerIcon.TabIndex = 5
        Me.PassengerIcon.TabStop = false
        '
        'ClassLabel
        '
        Me.ClassLabel.AutoSize = true
        Me.ClassLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11!, System.Drawing.FontStyle.Bold)
        Me.ClassLabel.ForeColor = System.Drawing.Color.White
        Me.ClassLabel.Location = New System.Drawing.Point(37, 14)
        Me.ClassLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ClassLabel.Name = "ClassLabel"
        Me.ClassLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClassLabel.Size = New System.Drawing.Size(60, 25)
        Me.ClassLabel.TabIndex = 23
        Me.ClassLabel.Text = "Class:"
        '
        'ClassIcon
        '
        Me.ClassIcon.Image = CType(resources.GetObject("ClassIcon.Image"),System.Drawing.Image)
        Me.ClassIcon.Location = New System.Drawing.Point(11, 12)
        Me.ClassIcon.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ClassIcon.Name = "ClassIcon"
        Me.ClassIcon.Size = New System.Drawing.Size(28, 26)
        Me.ClassIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ClassIcon.TabIndex = 5
        Me.ClassIcon.TabStop = false
        '
        'ClassComboBox
        '
        Me.ClassComboBox.BackColor = System.Drawing.Color.Transparent
        Me.ClassComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.ClassComboBox.BorderRadius = 10
        Me.ClassComboBox.BorderThickness = 3
        Me.ClassComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.ClassComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.ClassComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 11!, System.Drawing.FontStyle.Bold)
        Me.ClassComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.ClassComboBox.ItemHeight = 30
        Me.ClassComboBox.Items.AddRange(New Object() {"First Class", "Second Class", "Third Class"})
        Me.ClassComboBox.Location = New System.Drawing.Point(115, 10)
        Me.ClassComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(203, 36)
        Me.ClassComboBox.TabIndex = 19
        Me.ClassComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClassPanel
        '
        Me.ClassPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.ClassPanel.BorderRadius = 10
        Me.ClassPanel.BorderThickness = 3
        Me.ClassPanel.Controls.Add(Me.ClassLabel)
        Me.ClassPanel.Controls.Add(Me.ClassIcon)
        Me.ClassPanel.Controls.Add(Me.ClassComboBox)
        Me.ClassPanel.Location = New System.Drawing.Point(13, 186)
        Me.ClassPanel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ClassPanel.Name = "ClassPanel"
        Me.ClassPanel.Size = New System.Drawing.Size(328, 57)
        Me.ClassPanel.TabIndex = 33
        '
        'ToComboBox
        '
        Me.ToComboBox.BackColor = System.Drawing.Color.Transparent
        Me.ToComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.ToComboBox.BorderRadius = 10
        Me.ToComboBox.BorderThickness = 3
        Me.ToComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.ToComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.ToComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 11!, System.Drawing.FontStyle.Bold)
        Me.ToComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.ToComboBox.ItemHeight = 30
        Me.ToComboBox.Items.AddRange(New Object() {"Ahmedabad", "Jaipur", "Mumbai", "Rajkot", "Vadodara"})
        Me.ToComboBox.Location = New System.Drawing.Point(115, 11)
        Me.ToComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ToComboBox.Name = "ToComboBox"
        Me.ToComboBox.Size = New System.Drawing.Size(245, 36)
        Me.ToComboBox.TabIndex = 19
        Me.ToComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DatePicker
        '
        Me.DatePicker.Animated = true
        Me.DatePicker.BorderRadius = 10
        Me.DatePicker.Checked = true
        Me.DatePicker.CustomFormat = "ddd, dd MMM"
        Me.DatePicker.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.DatePicker.Font = New System.Drawing.Font("Segoe UI Semibold", 11!, System.Drawing.FontStyle.Bold)
        Me.DatePicker.ForeColor = System.Drawing.Color.White
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePicker.Location = New System.Drawing.Point(355, 186)
        Me.DatePicker.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.DatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(195, 57)
        Me.DatePicker.TabIndex = 30
        Me.DatePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DatePicker.Value = New Date(2023, 3, 29, 19, 55, 59, 717)
        '
        'ToLabel
        '
        Me.ToLabel.AutoSize = true
        Me.ToLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11!, System.Drawing.FontStyle.Bold)
        Me.ToLabel.ForeColor = System.Drawing.Color.White
        Me.ToLabel.Location = New System.Drawing.Point(35, 15)
        Me.ToLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ToLabel.Name = "ToLabel"
        Me.ToLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToLabel.Size = New System.Drawing.Size(36, 25)
        Me.ToLabel.TabIndex = 23
        Me.ToLabel.Text = "To:"
        '
        'ToIcon
        '
        Me.ToIcon.Image = CType(resources.GetObject("ToIcon.Image"),System.Drawing.Image)
        Me.ToIcon.Location = New System.Drawing.Point(11, 14)
        Me.ToIcon.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ToIcon.Name = "ToIcon"
        Me.ToIcon.Size = New System.Drawing.Size(28, 26)
        Me.ToIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ToIcon.TabIndex = 5
        Me.ToIcon.TabStop = false
        '
        'PassengerPanel
        '
        Me.PassengerPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.PassengerPanel.BorderRadius = 10
        Me.PassengerPanel.BorderThickness = 3
        Me.PassengerPanel.Controls.Add(Me.PassengerIcon)
        Me.PassengerPanel.Controls.Add(Me.PassengerCount)
        Me.PassengerPanel.Location = New System.Drawing.Point(563, 186)
        Me.PassengerPanel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PassengerPanel.Name = "PassengerPanel"
        Me.PassengerPanel.Size = New System.Drawing.Size(132, 57)
        Me.PassengerPanel.TabIndex = 34
        '
        'PassengerCount
        '
        Me.PassengerCount.BackColor = System.Drawing.Color.Transparent
        Me.PassengerCount.BorderRadius = 10
        Me.PassengerCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PassengerCount.Font = New System.Drawing.Font("Segoe UI Semibold", 11!, System.Drawing.FontStyle.Bold)
        Me.PassengerCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.PassengerCount.Location = New System.Drawing.Point(47, 14)
        Me.PassengerCount.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PassengerCount.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.PassengerCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PassengerCount.Name = "PassengerCount"
        Me.PassengerCount.Size = New System.Drawing.Size(76, 30)
        Me.PassengerCount.TabIndex = 20
        Me.PassengerCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.PassengerCount.UpDownButtonForeColor = System.Drawing.Color.White
        Me.PassengerCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ToPanel
        '
        Me.ToPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.ToPanel.BorderRadius = 10
        Me.ToPanel.BorderThickness = 3
        Me.ToPanel.Controls.Add(Me.ToLabel)
        Me.ToPanel.Controls.Add(Me.ToIcon)
        Me.ToPanel.Controls.Add(Me.ToComboBox)
        Me.ToPanel.Location = New System.Drawing.Point(399, 118)
        Me.ToPanel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ToPanel.Name = "ToPanel"
        Me.ToPanel.Size = New System.Drawing.Size(371, 57)
        Me.ToPanel.TabIndex = 32
        '
        'FromPanel
        '
        Me.FromPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.FromPanel.BorderRadius = 10
        Me.FromPanel.BorderThickness = 3
        Me.FromPanel.Controls.Add(Me.FromLabel)
        Me.FromPanel.Controls.Add(Me.FromIcon)
        Me.FromPanel.Controls.Add(Me.FromComboBox)
        Me.FromPanel.Location = New System.Drawing.Point(13, 118)
        Me.FromPanel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.FromPanel.Name = "FromPanel"
        Me.FromPanel.Size = New System.Drawing.Size(371, 57)
        Me.FromPanel.TabIndex = 31
        '
        'FromLabel
        '
        Me.FromLabel.AutoSize = true
        Me.FromLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11!, System.Drawing.FontStyle.Bold)
        Me.FromLabel.ForeColor = System.Drawing.Color.White
        Me.FromLabel.Location = New System.Drawing.Point(35, 15)
        Me.FromLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FromLabel.Size = New System.Drawing.Size(62, 25)
        Me.FromLabel.TabIndex = 23
        Me.FromLabel.Text = "From:"
        '
        'FromIcon
        '
        Me.FromIcon.Image = CType(resources.GetObject("FromIcon.Image"),System.Drawing.Image)
        Me.FromIcon.Location = New System.Drawing.Point(11, 14)
        Me.FromIcon.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.FromIcon.Name = "FromIcon"
        Me.FromIcon.Size = New System.Drawing.Size(28, 26)
        Me.FromIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.FromIcon.TabIndex = 5
        Me.FromIcon.TabStop = false
        '
        'FromComboBox
        '
        Me.FromComboBox.BackColor = System.Drawing.Color.Transparent
        Me.FromComboBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.FromComboBox.BorderRadius = 10
        Me.FromComboBox.BorderThickness = 3
        Me.FromComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FromComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.FromComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.FromComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 11!, System.Drawing.FontStyle.Bold)
        Me.FromComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.FromComboBox.ItemHeight = 30
        Me.FromComboBox.Items.AddRange(New Object() {"Ahmedabad", "Jaipur", "Mumbai", "Rajkot", "Vadodara"})
        Me.FromComboBox.Location = New System.Drawing.Point(115, 11)
        Me.FromComboBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.FromComboBox.Name = "FromComboBox"
        Me.FromComboBox.Size = New System.Drawing.Size(245, 36)
        Me.FromComboBox.TabIndex = 19
        Me.FromComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SearchButton
        '
        Me.SearchButton.Animated = true
        Me.SearchButton.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.SearchButton.BorderRadius = 10
        Me.SearchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SearchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SearchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169,Byte),Integer), CType(CType(169,Byte),Integer), CType(CType(169,Byte),Integer))
        Me.SearchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141,Byte),Integer), CType(CType(141,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.SearchButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.SearchButton.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Image = CType(resources.GetObject("SearchButton.Image"),System.Drawing.Image)
        Me.SearchButton.ImageSize = New System.Drawing.Size(25, 25)
        Me.SearchButton.Location = New System.Drawing.Point(707, 186)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(63, 57)
        Me.SearchButton.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 29!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(301, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 66)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "travel"
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
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(781, 38)
        Me.Guna2Panel1.TabIndex = 35
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.Animated = true
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(640, 0)
        Me.Guna2ControlBox3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(67, 38)
        Me.Guna2ControlBox3.TabIndex = 37
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = true
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(715, 0)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(67, 38)
        Me.Guna2ControlBox1.TabIndex = 36
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = true
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.Guna2Separator1.FillThickness = 3
        Me.Guna2Separator1.Location = New System.Drawing.Point(48, 258)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(688, 12)
        Me.Guna2Separator1.TabIndex = 41
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.BorderThickness = 3
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(21, 285)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(738, 200)
        Me.Guna2Panel2.TabIndex = 42
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.Guna2Panel3.BorderRadius = 10
        Me.Guna2Panel3.BorderThickness = 3
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(21, 503)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(738, 200)
        Me.Guna2Panel3.TabIndex = 43
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120!, 120!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(781, 722)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.ClassPanel)
        Me.Controls.Add(Me.DatePicker)
        Me.Controls.Add(Me.PassengerPanel)
        Me.Controls.Add(Me.ToPanel)
        Me.Controls.Add(Me.FromPanel)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.PassengerIcon,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ClassIcon,System.ComponentModel.ISupportInitialize).EndInit
        Me.ClassPanel.ResumeLayout(false)
        Me.ClassPanel.PerformLayout
        CType(Me.ToIcon,System.ComponentModel.ISupportInitialize).EndInit
        Me.PassengerPanel.ResumeLayout(false)
        CType(Me.PassengerCount,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToPanel.ResumeLayout(false)
        Me.ToPanel.PerformLayout
        Me.FromPanel.ResumeLayout(false)
        Me.FromPanel.PerformLayout
        CType(Me.FromIcon,System.ComponentModel.ISupportInitialize).EndInit
        Me.Guna2Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PassengerIcon As PictureBox
    Friend WithEvents ClassLabel As Label
    Friend WithEvents ClassIcon As PictureBox
    Friend WithEvents ClassComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ClassPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ToComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents ToLabel As Label
    Friend WithEvents ToIcon As PictureBox
    Friend WithEvents PassengerPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PassengerCount As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents ToPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FromPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FromLabel As Label
    Friend WithEvents FromIcon As PictureBox
    Friend WithEvents FromComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SearchButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
End Class
