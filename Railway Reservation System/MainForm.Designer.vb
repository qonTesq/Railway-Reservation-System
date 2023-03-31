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
        Me.TrainPanel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ArriveTimeLabel1 = New System.Windows.Forms.Label()
        Me.DepartTimeLabel1 = New System.Windows.Forms.Label()
        Me.DestinationLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SourceLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TrainNameLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrainClassLabel1 = New System.Windows.Forms.Label()
        Me.TrainNameDashLabel = New System.Windows.Forms.Label()
        Me.TrainIdLabel1 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
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
        Me.TrainPanel1.SuspendLayout
        CType(Me.Guna2CirclePictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Guna2Panel2.SuspendLayout
        CType(Me.Guna2CirclePictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PassengerIcon
        '
        Me.PassengerIcon.BackColor = System.Drawing.Color.Transparent
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
        Me.ClassLabel.BackColor = System.Drawing.Color.Transparent
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
        Me.ClassIcon.BackColor = System.Drawing.Color.Transparent
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
        Me.ClassComboBox.Sorted = true
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
        Me.ClassPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
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
        Me.ToComboBox.Sorted = true
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
        Me.ToLabel.BackColor = System.Drawing.Color.Transparent
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
        Me.ToIcon.BackColor = System.Drawing.Color.Transparent
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
        Me.PassengerPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
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
        Me.ToPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
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
        Me.FromPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.FromPanel.Location = New System.Drawing.Point(13, 118)
        Me.FromPanel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.FromPanel.Name = "FromPanel"
        Me.FromPanel.Size = New System.Drawing.Size(371, 57)
        Me.FromPanel.TabIndex = 31
        '
        'FromLabel
        '
        Me.FromLabel.AutoSize = true
        Me.FromLabel.BackColor = System.Drawing.Color.Transparent
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
        Me.FromIcon.BackColor = System.Drawing.Color.Transparent
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
        Me.FromComboBox.Sorted = true
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
        Me.Label1.Location = New System.Drawing.Point(307, 33)
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
        Me.Guna2Separator1.Location = New System.Drawing.Point(48, 262)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(688, 12)
        Me.Guna2Separator1.TabIndex = 41
        '
        'TrainPanel1
        '
        Me.TrainPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TrainPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.TrainPanel1.BorderRadius = 10
        Me.TrainPanel1.BorderThickness = 3
        Me.TrainPanel1.Controls.Add(Me.ArriveTimeLabel1)
        Me.TrainPanel1.Controls.Add(Me.DepartTimeLabel1)
        Me.TrainPanel1.Controls.Add(Me.DestinationLabel1)
        Me.TrainPanel1.Controls.Add(Me.SourceLabel1)
        Me.TrainPanel1.Controls.Add(Me.TrainNameLabel1)
        Me.TrainPanel1.Controls.Add(Me.Label2)
        Me.TrainPanel1.Controls.Add(Me.TrainClassLabel1)
        Me.TrainPanel1.Controls.Add(Me.TrainNameDashLabel)
        Me.TrainPanel1.Controls.Add(Me.TrainIdLabel1)
        Me.TrainPanel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.TrainPanel1.Controls.Add(Me.Guna2Shapes1)
        Me.TrainPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.TrainPanel1.Location = New System.Drawing.Point(21, 292)
        Me.TrainPanel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TrainPanel1.Name = "TrainPanel1"
        Me.TrainPanel1.Size = New System.Drawing.Size(738, 185)
        Me.TrainPanel1.TabIndex = 42
        '
        'ArriveTimeLabel1
        '
        Me.ArriveTimeLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ArriveTimeLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ArriveTimeLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ArriveTimeLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.ArriveTimeLabel1.Location = New System.Drawing.Point(618, 113)
        Me.ArriveTimeLabel1.Name = "ArriveTimeLabel1"
        Me.ArriveTimeLabel1.Size = New System.Drawing.Size(97, 19)
        Me.ArriveTimeLabel1.TabIndex = 12
        Me.ArriveTimeLabel1.Text = "00:00 AM/PM"
        Me.ArriveTimeLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DepartTimeLabel1
        '
        Me.DepartTimeLabel1.AutoSize = true
        Me.DepartTimeLabel1.BackColor = System.Drawing.Color.Transparent
        Me.DepartTimeLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DepartTimeLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.DepartTimeLabel1.Location = New System.Drawing.Point(19, 113)
        Me.DepartTimeLabel1.Name = "DepartTimeLabel1"
        Me.DepartTimeLabel1.Size = New System.Drawing.Size(97, 19)
        Me.DepartTimeLabel1.TabIndex = 11
        Me.DepartTimeLabel1.Text = "00:00 AM/PM"
        '
        'DestinationLabel1
        '
        Me.DestinationLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.DestinationLabel1.AutoSize = false
        Me.DestinationLabel1.BackColor = System.Drawing.Color.Transparent
        Me.DestinationLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DestinationLabel1.ForeColor = System.Drawing.Color.White
        Me.DestinationLabel1.Location = New System.Drawing.Point(553, 83)
        Me.DestinationLabel1.Name = "DestinationLabel1"
        Me.DestinationLabel1.Size = New System.Drawing.Size(162, 27)
        Me.DestinationLabel1.TabIndex = 10
        Me.DestinationLabel1.Text = "<strong>Destination</strong> <FONT COLOR=""#d9d9d9"">(DST)</FONT>"
        Me.DestinationLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'SourceLabel1
        '
        Me.SourceLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SourceLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SourceLabel1.ForeColor = System.Drawing.Color.White
        Me.SourceLabel1.Location = New System.Drawing.Point(23, 83)
        Me.SourceLabel1.Name = "SourceLabel1"
        Me.SourceLabel1.Size = New System.Drawing.Size(108, 27)
        Me.SourceLabel1.TabIndex = 9
        Me.SourceLabel1.Text = "<strong>Source</strong> <FONT COLOR=""#d9d9d9"">(SRC)</FONT>"
        '
        'TrainNameLabel1
        '
        Me.TrainNameLabel1.AutoSize = true
        Me.TrainNameLabel1.BackColor = System.Drawing.Color.Transparent
        Me.TrainNameLabel1.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TrainNameLabel1.ForeColor = System.Drawing.Color.White
        Me.TrainNameLabel1.Location = New System.Drawing.Point(166, 25)
        Me.TrainNameLabel1.Name = "TrainNameLabel1"
        Me.TrainNameLabel1.Size = New System.Drawing.Size(115, 25)
        Me.TrainNameLabel1.TabIndex = 7
        Me.TrainNameLabel1.Text = "Train Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(156, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 19)
        Me.Label2.TabIndex = 5
        '
        'TrainClassLabel1
        '
        Me.TrainClassLabel1.AutoSize = true
        Me.TrainClassLabel1.BackColor = System.Drawing.Color.Transparent
        Me.TrainClassLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TrainClassLabel1.ForeColor = System.Drawing.Color.Silver
        Me.TrainClassLabel1.Location = New System.Drawing.Point(84, 50)
        Me.TrainClassLabel1.Name = "TrainClassLabel1"
        Me.TrainClassLabel1.Size = New System.Drawing.Size(163, 19)
        Me.TrainClassLabel1.TabIndex = 4
        Me.TrainClassLabel1.Text = "Train Class • 00hr 00min"
        '
        'TrainNameDashLabel
        '
        Me.TrainNameDashLabel.AutoSize = true
        Me.TrainNameDashLabel.BackColor = System.Drawing.Color.Transparent
        Me.TrainNameDashLabel.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TrainNameDashLabel.ForeColor = System.Drawing.Color.White
        Me.TrainNameDashLabel.Location = New System.Drawing.Point(154, 25)
        Me.TrainNameDashLabel.Name = "TrainNameDashLabel"
        Me.TrainNameDashLabel.Size = New System.Drawing.Size(19, 25)
        Me.TrainNameDashLabel.TabIndex = 3
        Me.TrainNameDashLabel.Text = "-"
        '
        'TrainIdLabel1
        '
        Me.TrainIdLabel1.AutoSize = true
        Me.TrainIdLabel1.BackColor = System.Drawing.Color.Transparent
        Me.TrainIdLabel1.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TrainIdLabel1.ForeColor = System.Drawing.Color.White
        Me.TrainIdLabel1.Location = New System.Drawing.Point(83, 25)
        Me.TrainIdLabel1.Name = "TrainIdLabel1"
        Me.TrainIdLabel1.Size = New System.Drawing.Size(78, 25)
        Me.TrainIdLabel1.TabIndex = 2
        Me.TrainIdLabel1.Text = "#00000"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"),System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(30, 30)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 1
        Me.Guna2CirclePictureBox1.TabStop = false
        Me.Guna2CirclePictureBox1.UseTransparentBackground = true
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.White
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.White
        Me.Guna2Shapes1.Location = New System.Drawing.Point(18, 18)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse
        Me.Guna2Shapes1.Size = New System.Drawing.Size(59, 59)
        Me.Guna2Shapes1.TabIndex = 0
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.UseTransparentBackground = true
        Me.Guna2Shapes1.Zoom = 80
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.BorderThickness = 3
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Controls.Add(Me.Label8)
        Me.Guna2Panel2.Controls.Add(Me.Label9)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Shapes2)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(38,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(21, 503)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(738, 185)
        Me.Guna2Panel2.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.Label3.Location = New System.Drawing.Point(618, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "00:00 AM/PM"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(211,Byte),Integer))
        Me.Label4.Location = New System.Drawing.Point(19, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "00:00 AM/PM"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel1.AutoSize = false
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(553, 83)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(162, 27)
        Me.Guna2HtmlLabel1.TabIndex = 10
        Me.Guna2HtmlLabel1.Text = "<strong>Destination</strong> <FONT COLOR=""#d9d9d9"">(DST)</FONT>"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(23, 83)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(108, 27)
        Me.Guna2HtmlLabel2.TabIndex = 9
        Me.Guna2HtmlLabel2.Text = "<strong>Source</strong> <FONT COLOR=""#d9d9d9"">(SRC)</FONT>"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(166, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Train Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(156, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 19)
        Me.Label6.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(84, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Train Class • 00hr 00min"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(154, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 25)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(83, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 25)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "#00000"
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.Image = CType(resources.GetObject("Guna2CirclePictureBox2.Image"),System.Drawing.Image)
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(30, 30)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox2.TabIndex = 1
        Me.Guna2CirclePictureBox2.TabStop = false
        Me.Guna2CirclePictureBox2.UseTransparentBackground = true
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Shapes2.BorderColor = System.Drawing.Color.White
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.White
        Me.Guna2Shapes2.Location = New System.Drawing.Point(18, 18)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0!
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse
        Me.Guna2Shapes2.Size = New System.Drawing.Size(59, 59)
        Me.Guna2Shapes2.TabIndex = 0
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.UseTransparentBackground = true
        Me.Guna2Shapes2.Zoom = 80
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(40,Byte),Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(781, 710)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.TrainPanel1)
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
        Me.TrainPanel1.ResumeLayout(false)
        Me.TrainPanel1.PerformLayout
        CType(Me.Guna2CirclePictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Guna2Panel2.ResumeLayout(false)
        Me.Guna2Panel2.PerformLayout
        CType(Me.Guna2CirclePictureBox2,System.ComponentModel.ISupportInitialize).EndInit
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
    Friend WithEvents TrainPanel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents TrainNameLabel1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TrainClassLabel1 As Label
    Friend WithEvents TrainNameDashLabel As Label
    Friend WithEvents TrainIdLabel1 As Label
    Friend WithEvents DestinationLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents SourceLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ArriveTimeLabel1 As Label
    Friend WithEvents DepartTimeLabel1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
End Class
