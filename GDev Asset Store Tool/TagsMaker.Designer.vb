<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TagsMaker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TagsMaker))
        Me.ListBox_ExistingTags = New System.Windows.Forms.ListBox()
        Me.ListBox_SpecialTags = New System.Windows.Forms.ListBox()
        Me.ListBox_TAGS = New System.Windows.Forms.ListBox()
        Me.TextBox_NewTag = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Existingtags = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_Animation = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button_Open = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Label_TAGSmd = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label_Newtag = New System.Windows.Forms.Label()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label_Specialtags = New System.Windows.Forms.Label()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel_ControlBox = New System.Windows.Forms.Panel()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Minimize = New System.Windows.Forms.PictureBox()
        Me.Label_Application_Title = New System.Windows.Forms.Label()
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button_Download = New System.Windows.Forms.Button()
        Me.Label_FileAge = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LinkLabel_Wiki_Info = New System.Windows.Forms.LinkLabel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.Panel_ControlBox.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox_ExistingTags
        '
        Me.ListBox_ExistingTags.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListBox_ExistingTags.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_ExistingTags.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox_ExistingTags.FormattingEnabled = True
        Me.ListBox_ExistingTags.Location = New System.Drawing.Point(16, 32)
        Me.ListBox_ExistingTags.Name = "ListBox_ExistingTags"
        Me.ListBox_ExistingTags.Size = New System.Drawing.Size(240, 247)
        Me.ListBox_ExistingTags.Sorted = True
        Me.ListBox_ExistingTags.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ListBox_ExistingTags, "Double-click a tag to add it to the TAGS.md list.")
        '
        'ListBox_SpecialTags
        '
        Me.ListBox_SpecialTags.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListBox_SpecialTags.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_SpecialTags.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox_SpecialTags.FormattingEnabled = True
        Me.ListBox_SpecialTags.Items.AddRange(New Object() {"top-down", "side view", "isometric", "interface", "pixel art"})
        Me.ListBox_SpecialTags.Location = New System.Drawing.Point(16, 32)
        Me.ListBox_SpecialTags.Name = "ListBox_SpecialTags"
        Me.ListBox_SpecialTags.Size = New System.Drawing.Size(240, 104)
        Me.ListBox_SpecialTags.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ListBox_SpecialTags, "Double-click a special tag to add it to the TAGS.md list.")
        '
        'ListBox_TAGS
        '
        Me.ListBox_TAGS.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListBox_TAGS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_TAGS.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox_TAGS.FormattingEnabled = True
        Me.ListBox_TAGS.Location = New System.Drawing.Point(16, 32)
        Me.ListBox_TAGS.Name = "ListBox_TAGS"
        Me.ListBox_TAGS.Size = New System.Drawing.Size(240, 143)
        Me.ListBox_TAGS.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.ListBox_TAGS, "Double-click to remove tag from list." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can drag & drop a TAGS.md file here.")
        '
        'TextBox_NewTag
        '
        Me.TextBox_NewTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_NewTag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_NewTag.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_NewTag.Location = New System.Drawing.Point(16, 32)
        Me.TextBox_NewTag.Name = "TextBox_NewTag"
        Me.TextBox_NewTag.Size = New System.Drawing.Size(240, 13)
        Me.TextBox_NewTag.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListBox_ExistingTags)
        Me.Panel1.Controls.Add(Me.Label_Existingtags)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(0, 224)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 296)
        Me.Panel1.TabIndex = 11
        '
        'Label_Existingtags
        '
        Me.Label_Existingtags.AutoSize = True
        Me.Label_Existingtags.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Existingtags.Location = New System.Drawing.Point(8, 8)
        Me.Label_Existingtags.Name = "Label_Existingtags"
        Me.Label_Existingtags.Size = New System.Drawing.Size(152, 13)
        Me.Label_Existingtags.TabIndex = 84
        Me.Label_Existingtags.Text = "Existing Asset Store Tags"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Animation})
        Me.ShapeContainer2.Size = New System.Drawing.Size(272, 296)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape_Animation
        '
        Me.RectangleShape_Animation.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Animation.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Animation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Animation.CornerRadius = 3
        Me.RectangleShape_Animation.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Animation.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Animation.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape_Animation.Name = "RectangleShape_Animation"
        Me.RectangleShape_Animation.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Animation.Size = New System.Drawing.Size(256, 264)
        '
        'Button_Open
        '
        Me.Button_Open.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Open.FlatAppearance.BorderSize = 0
        Me.Button_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Open.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Open.Location = New System.Drawing.Point(280, 480)
        Me.Button_Open.Name = "Button_Open"
        Me.Button_Open.Size = New System.Drawing.Size(96, 24)
        Me.Button_Open.TabIndex = 93
        Me.Button_Open.Text = "Open"
        Me.ToolTip1.SetToolTip(Me.Button_Open, "You can drag & drop a TAGS.md file here.")
        Me.Button_Open.UseVisualStyleBackColor = False
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Save.FlatAppearance.BorderSize = 0
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(440, 480)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(96, 24)
        Me.Button_Save.TabIndex = 92
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'Label_TAGSmd
        '
        Me.Label_TAGSmd.AutoSize = True
        Me.Label_TAGSmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_TAGSmd.Location = New System.Drawing.Point(8, 8)
        Me.Label_TAGSmd.Name = "Label_TAGSmd"
        Me.Label_TAGSmd.Size = New System.Drawing.Size(60, 13)
        Me.Label_TAGSmd.TabIndex = 85
        Me.Label_TAGSmd.Text = "TAGS.md"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(256, 160)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label_Newtag)
        Me.Panel3.Controls.Add(Me.TextBox_NewTag)
        Me.Panel3.Controls.Add(Me.ShapeContainer4)
        Me.Panel3.Location = New System.Drawing.Point(272, 224)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(272, 56)
        Me.Panel3.TabIndex = 13
        '
        'Label_Newtag
        '
        Me.Label_Newtag.AutoSize = True
        Me.Label_Newtag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Newtag.Location = New System.Drawing.Point(8, 8)
        Me.Label_Newtag.Name = "Label_Newtag"
        Me.Label_Newtag.Size = New System.Drawing.Size(58, 13)
        Me.Label_Newtag.TabIndex = 83
        Me.Label_Newtag.Text = "New Tag"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer4.Size = New System.Drawing.Size(272, 56)
        Me.ShapeContainer4.TabIndex = 9
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
        Me.RectangleShape2.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Size = New System.Drawing.Size(256, 24)
        '
        'Label_Specialtags
        '
        Me.Label_Specialtags.AutoSize = True
        Me.Label_Specialtags.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Specialtags.Location = New System.Drawing.Point(8, 8)
        Me.Label_Specialtags.Name = "Label_Specialtags"
        Me.Label_Specialtags.Size = New System.Drawing.Size(81, 13)
        Me.Label_Specialtags.TabIndex = 86
        Me.Label_Specialtags.Text = "Special Tags"
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape3.CornerRadius = 3
        Me.RectangleShape3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Size = New System.Drawing.Size(256, 120)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ListBox_SpecialTags)
        Me.Panel4.Controls.Add(Me.Label_Specialtags)
        Me.Panel4.Controls.Add(Me.ShapeContainer5)
        Me.Panel4.Location = New System.Drawing.Point(0, 72)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(272, 152)
        Me.Panel4.TabIndex = 88
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3})
        Me.ShapeContainer5.Size = New System.Drawing.Size(272, 152)
        Me.ShapeContainer5.TabIndex = 87
        Me.ShapeContainer5.TabStop = False
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
        Me.Panel_Main.Size = New System.Drawing.Size(544, 26)
        Me.Panel_Main.TabIndex = 95
        '
        'Panel_ControlBox
        '
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Close)
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Minimize)
        Me.Panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_ControlBox.Location = New System.Drawing.Point(492, 0)
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
        Me.Label_Application_Title.Size = New System.Drawing.Size(106, 26)
        Me.Label_Application_Title.TabIndex = 2
        Me.Label_Application_Title.Text = "Tags Maker"
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Markdown files (*.md)|*.md"
        '
        'Button_Download
        '
        Me.Button_Download.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Download.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Download.FlatAppearance.BorderSize = 0
        Me.Button_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Download.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Download.Location = New System.Drawing.Point(256, 8)
        Me.Button_Download.Name = "Button_Download"
        Me.Button_Download.Size = New System.Drawing.Size(112, 24)
        Me.Button_Download.TabIndex = 97
        Me.Button_Download.Text = "Download"
        Me.Button_Download.UseVisualStyleBackColor = False
        '
        'Label_FileAge
        '
        Me.Label_FileAge.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label_FileAge.Location = New System.Drawing.Point(0, 0)
        Me.Label_FileAge.Name = "Label_FileAge"
        Me.Label_FileAge.Size = New System.Drawing.Size(248, 40)
        Me.Label_FileAge.TabIndex = 97
        Me.Label_FileAge.Text = "File is 0 Days Old"
        Me.Label_FileAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel7.Controls.Add(Me.LinkLabel_Wiki_Info)
        Me.Panel7.Controls.Add(Me.Button_Download)
        Me.Panel7.Controls.Add(Me.Label_FileAge)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 26)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(544, 40)
        Me.Panel7.TabIndex = 97
        '
        'LinkLabel_Wiki_Info
        '
        Me.LinkLabel_Wiki_Info.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_Wiki_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Wiki_Info.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel_Wiki_Info.Location = New System.Drawing.Point(471, 8)
        Me.LinkLabel_Wiki_Info.Name = "LinkLabel_Wiki_Info"
        Me.LinkLabel_Wiki_Info.Size = New System.Drawing.Size(65, 24)
        Me.LinkLabel_Wiki_Info.TabIndex = 108
        Me.LinkLabel_Wiki_Info.TabStop = True
        Me.LinkLabel_Wiki_Info.Text = "Wiki Info"
        Me.LinkLabel_Wiki_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel_Wiki_Info.VisitedLinkColor = System.Drawing.Color.DarkOrchid
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "TAGS.md"
        Me.SaveFileDialog1.Filter = "Markdown files (*.md)|*.md"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Hint"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ForeColor = System.Drawing.Color.Gray
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(16, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(240, 104)
        Me.ListBox1.TabIndex = 94
        Me.ToolTip1.SetToolTip(Me.ListBox1, "Double-click to remove tag from list." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can drag & drop a TAGS.md file here.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Tags From Directories"
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape4.CornerRadius = 3
        Me.RectangleShape4.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape4.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape4.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape4.Size = New System.Drawing.Size(256, 120)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(272, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(272, 152)
        Me.Panel2.TabIndex = 96
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4})
        Me.ShapeContainer1.Size = New System.Drawing.Size(272, 152)
        Me.ShapeContainer1.TabIndex = 96
        Me.ShapeContainer1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label_TAGSmd)
        Me.Panel5.Controls.Add(Me.ListBox_TAGS)
        Me.Panel5.Controls.Add(Me.ShapeContainer6)
        Me.Panel5.Location = New System.Drawing.Point(272, 280)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(272, 192)
        Me.Panel5.TabIndex = 97
        '
        'ShapeContainer6
        '
        Me.ShapeContainer6.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer6.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer6.Name = "ShapeContainer6"
        Me.ShapeContainer6.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer6.Size = New System.Drawing.Size(272, 192)
        Me.ShapeContainer6.TabIndex = 86
        Me.ShapeContainer6.TabStop = False
        '
        'TagsMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 520)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button_Open)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TagsMaker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tags Maker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_ControlBox.ResumeLayout(False)
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox_ExistingTags As ListBox
    Friend WithEvents ListBox_SpecialTags As ListBox
    Friend WithEvents ListBox_TAGS As ListBox
    Friend WithEvents TextBox_NewTag As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents RectangleShape_Animation As RectangleShape
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ShapeContainer4 As ShapeContainer
    Friend WithEvents RectangleShape2 As RectangleShape
    Friend WithEvents Label_Existingtags As Label
    Friend WithEvents Label_TAGSmd As Label
    Friend WithEvents Label_Newtag As Label
    Friend WithEvents Label_Specialtags As Label
    Friend WithEvents RectangleShape3 As RectangleShape
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ShapeContainer5 As ShapeContainer
    Friend WithEvents Button_Save As Button
    Friend WithEvents Button_Open As Button
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_ControlBox As Panel
    Friend WithEvents PictureBox_Close As PictureBox
    Friend WithEvents PictureBox_Minimize As PictureBox
    Friend WithEvents Label_Application_Title As Label
    Friend WithEvents PictureBox_AppIcon As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button_Download As Button
    Friend WithEvents Label_FileAge As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LinkLabel_Wiki_Info As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents RectangleShape4 As RectangleShape
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ShapeContainer6 As ShapeContainer
End Class
