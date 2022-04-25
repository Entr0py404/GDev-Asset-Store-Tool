<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileNameValidator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileNameValidator))
        Me.Panel_Errors = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox_Errors = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip_ListBox_Errors = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape_Image = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel_Correct = New System.Windows.Forms.Panel()
        Me.RichTextBox_Correct = New System.Windows.Forms.RichTextBox()
        Me.Label_Correct = New System.Windows.Forms.Label()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel_ControlBox = New System.Windows.Forms.Panel()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Minimize = New System.Windows.Forms.PictureBox()
        Me.Label_Application_Title = New System.Windows.Forms.Label()
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.Panel_Image = New System.Windows.Forms.Panel()
        Me.Label_Image = New System.Windows.Forms.Label()
        Me.PixelBox1 = New GDev_Asset_Store_Tool.PixelBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.FolderBrowserDialog_Selected_Directory = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel_Selected_Directory_Controls = New System.Windows.Forms.Panel()
        Me.LinkLabel_Wiki_Info = New System.Windows.Forms.LinkLabel()
        Me.Button_Reload = New System.Windows.Forms.Button()
        Me.Button_Select_Directory = New System.Windows.Forms.Button()
        Me.Label_Selected_Directory = New System.Windows.Forms.Label()
        Me.TextBox_Selected_Directory = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_Selected_Directory = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel_Errors.SuspendLayout()
        Me.ContextMenuStrip_ListBox_Errors.SuspendLayout()
        Me.Panel_Correct.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.Panel_ControlBox.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Image.SuspendLayout()
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Selected_Directory_Controls.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Errors
        '
        Me.Panel_Errors.Controls.Add(Me.Label2)
        Me.Panel_Errors.Controls.Add(Me.ListBox_Errors)
        Me.Panel_Errors.Controls.Add(Me.ShapeContainer4)
        Me.Panel_Errors.Location = New System.Drawing.Point(0, 82)
        Me.Panel_Errors.Name = "Panel_Errors"
        Me.Panel_Errors.Padding = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.Panel_Errors.Size = New System.Drawing.Size(504, 224)
        Me.Panel_Errors.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Errors"
        '
        'ListBox_Errors
        '
        Me.ListBox_Errors.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListBox_Errors.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_Errors.ContextMenuStrip = Me.ContextMenuStrip_ListBox_Errors
        Me.ListBox_Errors.ForeColor = System.Drawing.Color.Tomato
        Me.ListBox_Errors.FormattingEnabled = True
        Me.ListBox_Errors.HorizontalScrollbar = True
        Me.ListBox_Errors.Location = New System.Drawing.Point(16, 24)
        Me.ListBox_Errors.Margin = New System.Windows.Forms.Padding(60, 3, 3, 3)
        Me.ListBox_Errors.Name = "ListBox_Errors"
        Me.ListBox_Errors.Size = New System.Drawing.Size(472, 182)
        Me.ListBox_Errors.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ListBox_Errors, "Right-click for options.")
        '
        'ContextMenuStrip_ListBox_Errors
        '
        Me.ContextMenuStrip_ListBox_Errors.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip_ListBox_Errors.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDirectoryToolStripMenuItem, Me.OpenFileToolStripMenuItem})
        Me.ContextMenuStrip_ListBox_Errors.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip_ListBox_Errors.ShowImageMargin = False
        Me.ContextMenuStrip_ListBox_Errors.Size = New System.Drawing.Size(130, 48)
        '
        'OpenDirectoryToolStripMenuItem
        '
        Me.OpenDirectoryToolStripMenuItem.Enabled = False
        Me.OpenDirectoryToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.OpenDirectoryToolStripMenuItem.Name = "OpenDirectoryToolStripMenuItem"
        Me.OpenDirectoryToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.OpenDirectoryToolStripMenuItem.Text = "Open Directory"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Enabled = False
        Me.OpenFileToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(8, 8)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer4.Size = New System.Drawing.Size(496, 216)
        Me.ShapeContainer4.TabIndex = 5
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape2.CornerRadius = 3
        Me.RectangleShape2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.Location = New System.Drawing.Point(0, 8)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Size = New System.Drawing.Size(488, 200)
        '
        'RectangleShape_Image
        '
        Me.RectangleShape_Image.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Image.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Image.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Image.CornerRadius = 3
        Me.RectangleShape_Image.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Image.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Image.Location = New System.Drawing.Point(8, 8)
        Me.RectangleShape_Image.Name = "RectangleShape_Image"
        Me.RectangleShape_Image.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Image.Size = New System.Drawing.Size(288, 200)
        '
        'Panel_Correct
        '
        Me.Panel_Correct.Controls.Add(Me.RichTextBox_Correct)
        Me.Panel_Correct.Controls.Add(Me.Label_Correct)
        Me.Panel_Correct.Controls.Add(Me.ShapeContainer5)
        Me.Panel_Correct.Location = New System.Drawing.Point(0, 304)
        Me.Panel_Correct.Name = "Panel_Correct"
        Me.Panel_Correct.Padding = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.Panel_Correct.Size = New System.Drawing.Size(504, 232)
        Me.Panel_Correct.TabIndex = 3
        '
        'RichTextBox_Correct
        '
        Me.RichTextBox_Correct.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RichTextBox_Correct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox_Correct.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox_Correct.Location = New System.Drawing.Point(16, 24)
        Me.RichTextBox_Correct.Name = "RichTextBox_Correct"
        Me.RichTextBox_Correct.ReadOnly = True
        Me.RichTextBox_Correct.Size = New System.Drawing.Size(472, 192)
        Me.RichTextBox_Correct.TabIndex = 4
        Me.RichTextBox_Correct.Text = ""
        Me.ToolTip1.SetToolTip(Me.RichTextBox_Correct, "Shows how assets are being recognized: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SFA: Single frame asset." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MFA: Multiple " &
        "frame animation.")
        '
        'Label_Correct
        '
        Me.Label_Correct.AutoSize = True
        Me.Label_Correct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Correct.Location = New System.Drawing.Point(0, 0)
        Me.Label_Correct.Name = "Label_Correct"
        Me.Label_Correct.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_Correct.Size = New System.Drawing.Size(56, 13)
        Me.Label_Correct.TabIndex = 4
        Me.Label_Correct.Text = "Correct"
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(8, 8)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer5.Size = New System.Drawing.Size(496, 224)
        Me.ShapeContainer5.TabIndex = 5
        Me.ShapeContainer5.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 8)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(488, 208)
        '
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel_Main.Controls.Add(Me.Panel_ControlBox)
        Me.Panel_Main.Controls.Add(Me.Label_Application_Title)
        Me.Panel_Main.Controls.Add(Me.PictureBox_AppIcon)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Main.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Panel_Main.ForeColor = System.Drawing.Color.White
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(807, 26)
        Me.Panel_Main.TabIndex = 79
        '
        'Panel_ControlBox
        '
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Close)
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Minimize)
        Me.Panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_ControlBox.Location = New System.Drawing.Point(755, 0)
        Me.Panel_ControlBox.Name = "Panel_ControlBox"
        Me.Panel_ControlBox.Size = New System.Drawing.Size(52, 26)
        Me.Panel_ControlBox.TabIndex = 4
        '
        'PictureBox_Close
        '
        Me.PictureBox_Close.Image = Global.GDev_Asset_Store_Tool.My.Resources.Resources.Close_Grey
        Me.PictureBox_Close.Location = New System.Drawing.Point(30, 5)
        Me.PictureBox_Close.Name = "PictureBox_Close"
        Me.PictureBox_Close.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Close.TabIndex = 0
        Me.PictureBox_Close.TabStop = False
        '
        'PictureBox_Minimize
        '
        Me.PictureBox_Minimize.Image = Global.GDev_Asset_Store_Tool.My.Resources.Resources.Minimize_Grey
        Me.PictureBox_Minimize.Location = New System.Drawing.Point(8, 5)
        Me.PictureBox_Minimize.Name = "PictureBox_Minimize"
        Me.PictureBox_Minimize.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Minimize.TabIndex = 1
        Me.PictureBox_Minimize.TabStop = False
        '
        'Label_Application_Title
        '
        Me.Label_Application_Title.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label_Application_Title.Location = New System.Drawing.Point(30, 0)
        Me.Label_Application_Title.Name = "Label_Application_Title"
        Me.Label_Application_Title.Size = New System.Drawing.Size(146, 26)
        Me.Label_Application_Title.TabIndex = 2
        Me.Label_Application_Title.Text = "File Name Validator"
        Me.Label_Application_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_AppIcon
        '
        Me.PictureBox_AppIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox_AppIcon.Image = Global.GDev_Asset_Store_Tool.My.Resources.Resources.Application_Icon
        Me.PictureBox_AppIcon.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox_AppIcon.Name = "PictureBox_AppIcon"
        Me.PictureBox_AppIcon.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox_AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_AppIcon.TabIndex = 3
        Me.PictureBox_AppIcon.TabStop = False
        '
        'Panel_Image
        '
        Me.Panel_Image.Controls.Add(Me.Label_Image)
        Me.Panel_Image.Controls.Add(Me.PixelBox1)
        Me.Panel_Image.Controls.Add(Me.ShapeContainer3)
        Me.Panel_Image.Location = New System.Drawing.Point(504, 80)
        Me.Panel_Image.Name = "Panel_Image"
        Me.Panel_Image.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Panel_Image.Size = New System.Drawing.Size(303, 224)
        Me.Panel_Image.TabIndex = 90
        '
        'Label_Image
        '
        Me.Label_Image.AutoSize = True
        Me.Label_Image.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Image.Location = New System.Drawing.Point(0, 0)
        Me.Label_Image.Name = "Label_Image"
        Me.Label_Image.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_Image.Size = New System.Drawing.Size(49, 13)
        Me.Label_Image.TabIndex = 103
        Me.Label_Image.Text = "Image"
        '
        'PixelBox1
        '
        Me.PixelBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PixelBox1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.PixelBox1.Location = New System.Drawing.Point(16, 24)
        Me.PixelBox1.Name = "PixelBox1"
        Me.PixelBox1.Size = New System.Drawing.Size(272, 184)
        Me.PixelBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox1.TabIndex = 103
        Me.PixelBox1.TabStop = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 8)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Image})
        Me.ShapeContainer3.Size = New System.Drawing.Size(303, 216)
        Me.ShapeContainer3.TabIndex = 104
        Me.ShapeContainer3.TabStop = False
        '
        'Panel_Selected_Directory_Controls
        '
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.LinkLabel_Wiki_Info)
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.Button_Reload)
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.Button_Select_Directory)
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.Label_Selected_Directory)
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.TextBox_Selected_Directory)
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.ShapeContainer1)
        Me.Panel_Selected_Directory_Controls.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Selected_Directory_Controls.Location = New System.Drawing.Point(0, 26)
        Me.Panel_Selected_Directory_Controls.Name = "Panel_Selected_Directory_Controls"
        Me.Panel_Selected_Directory_Controls.Size = New System.Drawing.Size(807, 54)
        Me.Panel_Selected_Directory_Controls.TabIndex = 100
        '
        'LinkLabel_Wiki_Info
        '
        Me.LinkLabel_Wiki_Info.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_Wiki_Info.AutoSize = True
        Me.LinkLabel_Wiki_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Wiki_Info.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel_Wiki_Info.Location = New System.Drawing.Point(736, 32)
        Me.LinkLabel_Wiki_Info.Name = "LinkLabel_Wiki_Info"
        Me.LinkLabel_Wiki_Info.Size = New System.Drawing.Size(57, 16)
        Me.LinkLabel_Wiki_Info.TabIndex = 101
        Me.LinkLabel_Wiki_Info.TabStop = True
        Me.LinkLabel_Wiki_Info.Text = "Wiki Info"
        Me.LinkLabel_Wiki_Info.VisitedLinkColor = System.Drawing.Color.DarkOrchid
        '
        'Button_Reload
        '
        Me.Button_Reload.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Reload.FlatAppearance.BorderSize = 0
        Me.Button_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Reload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reload.Location = New System.Drawing.Point(608, 24)
        Me.Button_Reload.Name = "Button_Reload"
        Me.Button_Reload.Size = New System.Drawing.Size(80, 24)
        Me.Button_Reload.TabIndex = 94
        Me.Button_Reload.Text = "Reload"
        Me.Button_Reload.UseVisualStyleBackColor = False
        '
        'Button_Select_Directory
        '
        Me.Button_Select_Directory.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Select_Directory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Select_Directory.FlatAppearance.BorderSize = 0
        Me.Button_Select_Directory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Select_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Select_Directory.Location = New System.Drawing.Point(512, 24)
        Me.Button_Select_Directory.Name = "Button_Select_Directory"
        Me.Button_Select_Directory.Size = New System.Drawing.Size(80, 24)
        Me.Button_Select_Directory.TabIndex = 3
        Me.Button_Select_Directory.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Button_Select_Directory, "Hint: You can drag drop a directory here.")
        Me.Button_Select_Directory.UseVisualStyleBackColor = False
        '
        'Label_Selected_Directory
        '
        Me.Label_Selected_Directory.AutoSize = True
        Me.Label_Selected_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Selected_Directory.Location = New System.Drawing.Point(0, 8)
        Me.Label_Selected_Directory.Name = "Label_Selected_Directory"
        Me.Label_Selected_Directory.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_Selected_Directory.Size = New System.Drawing.Size(120, 13)
        Me.Label_Selected_Directory.TabIndex = 84
        Me.Label_Selected_Directory.Text = "Selected Directory"
        '
        'TextBox_Selected_Directory
        '
        Me.TextBox_Selected_Directory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_Selected_Directory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Selected_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Selected_Directory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_Selected_Directory.Location = New System.Drawing.Point(16, 32)
        Me.TextBox_Selected_Directory.Name = "TextBox_Selected_Directory"
        Me.TextBox_Selected_Directory.Size = New System.Drawing.Size(472, 13)
        Me.TextBox_Selected_Directory.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TextBox_Selected_Directory, "Hint: You can drag drop a directory here.")
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Selected_Directory})
        Me.ShapeContainer1.Size = New System.Drawing.Size(807, 54)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape_Selected_Directory
        '
        Me.RectangleShape_Selected_Directory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Selected_Directory.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Selected_Directory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Selected_Directory.CornerRadius = 3
        Me.RectangleShape_Selected_Directory.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Selected_Directory.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Selected_Directory.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape_Selected_Directory.Name = "RectangleShape_Selected_Directory"
        Me.RectangleShape_Selected_Directory.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Selected_Directory.Size = New System.Drawing.Size(488, 24)
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "File Name Validator"
        '
        'FileNameValidator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(807, 545)
        Me.Controls.Add(Me.Panel_Errors)
        Me.Controls.Add(Me.Panel_Correct)
        Me.Controls.Add(Me.Panel_Image)
        Me.Controls.Add(Me.Panel_Selected_Directory_Controls)
        Me.Controls.Add(Me.Panel_Main)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FileNameValidator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Name Validator"
        Me.Panel_Errors.ResumeLayout(False)
        Me.Panel_Errors.PerformLayout()
        Me.ContextMenuStrip_ListBox_Errors.ResumeLayout(False)
        Me.Panel_Correct.ResumeLayout(False)
        Me.Panel_Correct.PerformLayout()
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_ControlBox.ResumeLayout(False)
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Image.ResumeLayout(False)
        Me.Panel_Image.PerformLayout()
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Selected_Directory_Controls.ResumeLayout(False)
        Me.Panel_Selected_Directory_Controls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Errors As Panel
    Friend WithEvents ListBox_Errors As ListBox
    Friend WithEvents Panel_Correct As Panel
    Friend WithEvents RichTextBox_Correct As RichTextBox
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_ControlBox As Panel
    Friend WithEvents PictureBox_Close As PictureBox
    Friend WithEvents PictureBox_Minimize As PictureBox
    Friend WithEvents Label_Application_Title As Label
    Friend WithEvents PictureBox_AppIcon As PictureBox
    Friend WithEvents Panel_Image As Panel
    Friend WithEvents RectangleShape_Image As RectangleShape
    Friend WithEvents ContextMenuStrip_ListBox_Errors As ContextMenuStrip
    Friend WithEvents OpenDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog_Selected_Directory As FolderBrowserDialog
    Friend WithEvents Button_Reload As Button
    Friend WithEvents Panel_Selected_Directory_Controls As Panel
    Friend WithEvents Button_Select_Directory As Button
    Friend WithEvents Label_Selected_Directory As Label
    Friend WithEvents TextBox_Selected_Directory As TextBox
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape_Selected_Directory As RectangleShape
    Friend WithEvents LinkLabel_Wiki_Info As LinkLabel
    Friend WithEvents PixelBox1 As PixelBox
    Friend WithEvents Label_Correct As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_Image As Label
    Friend WithEvents ShapeContainer3 As ShapeContainer
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents RectangleShape2 As RectangleShape
    Friend WithEvents ShapeContainer4 As ShapeContainer
    Friend WithEvents ShapeContainer5 As ShapeContainer
    Friend WithEvents ToolTip1 As ToolTip
End Class
