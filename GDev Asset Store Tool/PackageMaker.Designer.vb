<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PackageMaker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PackageMaker))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip_PackageThumbnail = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel_ControlBox = New System.Windows.Forms.Panel()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Minimize = New System.Windows.Forms.PictureBox()
        Me.Label_Application_Title = New System.Windows.Forms.Label()
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Panel_PackageThumbnail = New System.Windows.Forms.Panel()
        Me.Label_PackageThumbnail = New System.Windows.Forms.Label()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_Image = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label_PackageName = New System.Windows.Forms.Label()
        Me.TextBox_PackageName = New System.Windows.Forms.TextBox()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SaveFileDialog_PackJson = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Description = New System.Windows.Forms.Label()
        Me.TextBox_Description = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SaveFileDialog_PackageThumbnail = New System.Windows.Forms.SaveFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NumericUpDown_Price = New System.Windows.Forms.NumericUpDown()
        Me.Label_Price = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CheckBox_FullGamePack = New System.Windows.Forms.CheckBox()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CheckBox_Character = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Props = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Background = New System.Windows.Forms.CheckBox()
        Me.CheckBox_VisualEffect = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Interface = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Prefab = New System.Windows.Forms.CheckBox()
        Me.Label_Categories = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CheckBox_Sounds = New System.Windows.Forms.CheckBox()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.PixelBox_PackageThumbnail = New GDev_Asset_Store_Tool.PixelBox()
        Me.ContextMenuStrip_PackageThumbnail.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.Panel_ControlBox.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_PackageThumbnail.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown_Price, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PixelBox_PackageThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Hint"
        '
        'ContextMenuStrip_PackageThumbnail
        '
        Me.ContextMenuStrip_PackageThumbnail.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip_PackageThumbnail.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_PackageThumbnail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.ContextMenuStrip_PackageThumbnail.Name = "ContextMenuStrip_PackageThumbnail"
        Me.ContextMenuStrip_PackageThumbnail.ShowImageMargin = False
        Me.ContextMenuStrip_PackageThumbnail.Size = New System.Drawing.Size(85, 28)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.SaveToolStripMenuItem.Text = "Save"
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
        Me.Panel_Main.Size = New System.Drawing.Size(551, 26)
        Me.Panel_Main.TabIndex = 80
        '
        'Panel_ControlBox
        '
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Close)
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Minimize)
        Me.Panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_ControlBox.Location = New System.Drawing.Point(499, 0)
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
        Me.Label_Application_Title.Text = "Package Maker"
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
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Save.FlatAppearance.BorderSize = 0
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(440, 328)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(96, 24)
        Me.Button_Save.TabIndex = 93
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'Panel_PackageThumbnail
        '
        Me.Panel_PackageThumbnail.Controls.Add(Me.Label_PackageThumbnail)
        Me.Panel_PackageThumbnail.Controls.Add(Me.PixelBox_PackageThumbnail)
        Me.Panel_PackageThumbnail.Controls.Add(Me.ShapeContainer3)
        Me.Panel_PackageThumbnail.Location = New System.Drawing.Point(0, 32)
        Me.Panel_PackageThumbnail.Name = "Panel_PackageThumbnail"
        Me.Panel_PackageThumbnail.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Panel_PackageThumbnail.Size = New System.Drawing.Size(200, 168)
        Me.Panel_PackageThumbnail.TabIndex = 94
        '
        'Label_PackageThumbnail
        '
        Me.Label_PackageThumbnail.AutoSize = True
        Me.Label_PackageThumbnail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_PackageThumbnail.Location = New System.Drawing.Point(8, 8)
        Me.Label_PackageThumbnail.Name = "Label_PackageThumbnail"
        Me.Label_PackageThumbnail.Size = New System.Drawing.Size(119, 13)
        Me.Label_PackageThumbnail.TabIndex = 103
        Me.Label_PackageThumbnail.Text = "Package Thumbnail"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 8)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Image})
        Me.ShapeContainer3.Size = New System.Drawing.Size(200, 160)
        Me.ShapeContainer3.TabIndex = 104
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape_Image
        '
        Me.RectangleShape_Image.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Image.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Image.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Image.CornerRadius = 3
        Me.RectangleShape_Image.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Image.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Image.Location = New System.Drawing.Point(8, 16)
        Me.RectangleShape_Image.Name = "RectangleShape_Image"
        Me.RectangleShape_Image.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Image.Size = New System.Drawing.Size(184, 136)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label_PackageName)
        Me.Panel3.Controls.Add(Me.TextBox_PackageName)
        Me.Panel3.Controls.Add(Me.ShapeContainer4)
        Me.Panel3.Location = New System.Drawing.Point(200, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(248, 56)
        Me.Panel3.TabIndex = 95
        '
        'Label_PackageName
        '
        Me.Label_PackageName.AutoSize = True
        Me.Label_PackageName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_PackageName.Location = New System.Drawing.Point(8, 8)
        Me.Label_PackageName.Name = "Label_PackageName"
        Me.Label_PackageName.Size = New System.Drawing.Size(91, 13)
        Me.Label_PackageName.TabIndex = 83
        Me.Label_PackageName.Text = "Package name"
        '
        'TextBox_PackageName
        '
        Me.TextBox_PackageName.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_PackageName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_PackageName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_PackageName.Location = New System.Drawing.Point(16, 32)
        Me.TextBox_PackageName.Name = "TextBox_PackageName"
        Me.TextBox_PackageName.Size = New System.Drawing.Size(216, 13)
        Me.TextBox_PackageName.TabIndex = 8
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer4.Size = New System.Drawing.Size(248, 56)
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
        Me.RectangleShape2.Size = New System.Drawing.Size(232, 24)
        '
        'SaveFileDialog_PackJson
        '
        Me.SaveFileDialog_PackJson.FileName = "PACK.json"
        Me.SaveFileDialog_PackJson.Filter = "Json files (*.json)|*.json"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_Description)
        Me.Panel1.Controls.Add(Me.TextBox_Description)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(0, 200)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 128)
        Me.Panel1.TabIndex = 96
        '
        'Label_Description
        '
        Me.Label_Description.AutoSize = True
        Me.Label_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Description.Location = New System.Drawing.Point(8, 8)
        Me.Label_Description.Name = "Label_Description"
        Me.Label_Description.Size = New System.Drawing.Size(71, 13)
        Me.Label_Description.TabIndex = 83
        Me.Label_Description.Text = "Description"
        '
        'TextBox_Description
        '
        Me.TextBox_Description.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Description.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_Description.Location = New System.Drawing.Point(16, 32)
        Me.TextBox_Description.Multiline = True
        Me.TextBox_Description.Name = "TextBox_Description"
        Me.TextBox_Description.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_Description.Size = New System.Drawing.Size(520, 80)
        Me.TextBox_Description.TabIndex = 8
        Me.TextBox_Description.WordWrap = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(552, 128)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
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
        Me.RectangleShape1.Name = "RectangleShape2"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(536, 96)
        '
        'SaveFileDialog_PackageThumbnail
        '
        Me.SaveFileDialog_PackageThumbnail.FileName = "thumbnail"
        Me.SaveFileDialog_PackageThumbnail.Filter = "Png Image (*.png)|*.png"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.NumericUpDown_Price)
        Me.Panel2.Controls.Add(Me.Label_Price)
        Me.Panel2.Controls.Add(Me.ShapeContainer2)
        Me.Panel2.Location = New System.Drawing.Point(448, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(104, 56)
        Me.Panel2.TabIndex = 97
        '
        'NumericUpDown_Price
        '
        Me.NumericUpDown_Price.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_Price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown_Price.DecimalPlaces = 2
        Me.NumericUpDown_Price.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_Price.Location = New System.Drawing.Point(16, 29)
        Me.NumericUpDown_Price.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.NumericUpDown_Price.Name = "NumericUpDown_Price"
        Me.NumericUpDown_Price.Size = New System.Drawing.Size(72, 16)
        Me.NumericUpDown_Price.TabIndex = 108
        '
        'Label_Price
        '
        Me.Label_Price.AutoSize = True
        Me.Label_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Price.Location = New System.Drawing.Point(8, 8)
        Me.Label_Price.Name = "Label_Price"
        Me.Label_Price.Size = New System.Drawing.Size(81, 13)
        Me.Label_Price.TabIndex = 83
        Me.Label_Price.Text = "Price€ (Euro)"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(104, 56)
        Me.ShapeContainer2.TabIndex = 9
        Me.ShapeContainer2.TabStop = False
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
        Me.RectangleShape3.Name = "RectangleShape2"
        Me.RectangleShape3.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Size = New System.Drawing.Size(88, 24)
        '
        'CheckBox_FullGamePack
        '
        Me.CheckBox_FullGamePack.AutoSize = True
        Me.CheckBox_FullGamePack.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CheckBox_FullGamePack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_FullGamePack.Location = New System.Drawing.Point(16, 32)
        Me.CheckBox_FullGamePack.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CheckBox_FullGamePack.Name = "CheckBox_FullGamePack"
        Me.CheckBox_FullGamePack.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox_FullGamePack.TabIndex = 98
        Me.CheckBox_FullGamePack.Text = "Full-Game-Pack"
        Me.CheckBox_FullGamePack.UseVisualStyleBackColor = False
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
        Me.RectangleShape4.Size = New System.Drawing.Size(336, 80)
        '
        'CheckBox_Character
        '
        Me.CheckBox_Character.AutoSize = True
        Me.CheckBox_Character.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CheckBox_Character.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Character.Location = New System.Drawing.Point(160, 56)
        Me.CheckBox_Character.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CheckBox_Character.Name = "CheckBox_Character"
        Me.CheckBox_Character.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox_Character.TabIndex = 100
        Me.CheckBox_Character.Text = "Character"
        Me.CheckBox_Character.UseVisualStyleBackColor = False
        '
        'CheckBox_Props
        '
        Me.CheckBox_Props.AutoSize = True
        Me.CheckBox_Props.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CheckBox_Props.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Props.Location = New System.Drawing.Point(272, 32)
        Me.CheckBox_Props.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CheckBox_Props.Name = "CheckBox_Props"
        Me.CheckBox_Props.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox_Props.TabIndex = 101
        Me.CheckBox_Props.Text = "Props"
        Me.CheckBox_Props.UseVisualStyleBackColor = False
        '
        'CheckBox_Background
        '
        Me.CheckBox_Background.AutoSize = True
        Me.CheckBox_Background.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CheckBox_Background.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Background.Location = New System.Drawing.Point(16, 80)
        Me.CheckBox_Background.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CheckBox_Background.Name = "CheckBox_Background"
        Me.CheckBox_Background.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox_Background.TabIndex = 102
        Me.CheckBox_Background.Text = "Background"
        Me.CheckBox_Background.UseVisualStyleBackColor = False
        '
        'CheckBox_VisualEffect
        '
        Me.CheckBox_VisualEffect.AutoSize = True
        Me.CheckBox_VisualEffect.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CheckBox_VisualEffect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_VisualEffect.Location = New System.Drawing.Point(16, 56)
        Me.CheckBox_VisualEffect.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CheckBox_VisualEffect.Name = "CheckBox_VisualEffect"
        Me.CheckBox_VisualEffect.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox_VisualEffect.TabIndex = 103
        Me.CheckBox_VisualEffect.Text = "Visual-Effect"
        Me.CheckBox_VisualEffect.UseVisualStyleBackColor = False
        '
        'CheckBox_Interface
        '
        Me.CheckBox_Interface.AutoSize = True
        Me.CheckBox_Interface.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CheckBox_Interface.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Interface.Location = New System.Drawing.Point(160, 32)
        Me.CheckBox_Interface.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CheckBox_Interface.Name = "CheckBox_Interface"
        Me.CheckBox_Interface.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox_Interface.TabIndex = 104
        Me.CheckBox_Interface.Text = "Interface"
        Me.CheckBox_Interface.UseVisualStyleBackColor = False
        '
        'CheckBox_Prefab
        '
        Me.CheckBox_Prefab.AutoSize = True
        Me.CheckBox_Prefab.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CheckBox_Prefab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Prefab.Location = New System.Drawing.Point(272, 56)
        Me.CheckBox_Prefab.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CheckBox_Prefab.Name = "CheckBox_Prefab"
        Me.CheckBox_Prefab.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox_Prefab.TabIndex = 105
        Me.CheckBox_Prefab.Text = "Prefab"
        Me.CheckBox_Prefab.UseVisualStyleBackColor = False
        '
        'Label_Categories
        '
        Me.Label_Categories.AutoSize = True
        Me.Label_Categories.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Categories.Location = New System.Drawing.Point(8, 8)
        Me.Label_Categories.Name = "Label_Categories"
        Me.Label_Categories.Size = New System.Drawing.Size(67, 13)
        Me.Label_Categories.TabIndex = 106
        Me.Label_Categories.Text = "Categories"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CheckBox_Sounds)
        Me.Panel4.Controls.Add(Me.CheckBox_Prefab)
        Me.Panel4.Controls.Add(Me.CheckBox_Interface)
        Me.Panel4.Controls.Add(Me.CheckBox_VisualEffect)
        Me.Panel4.Controls.Add(Me.CheckBox_Background)
        Me.Panel4.Controls.Add(Me.CheckBox_Props)
        Me.Panel4.Controls.Add(Me.CheckBox_Character)
        Me.Panel4.Controls.Add(Me.CheckBox_FullGamePack)
        Me.Panel4.Controls.Add(Me.Label_Categories)
        Me.Panel4.Controls.Add(Me.ShapeContainer6)
        Me.Panel4.Location = New System.Drawing.Point(200, 88)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(352, 112)
        Me.Panel4.TabIndex = 107
        '
        'CheckBox_Sounds
        '
        Me.CheckBox_Sounds.AutoSize = True
        Me.CheckBox_Sounds.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CheckBox_Sounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Sounds.Location = New System.Drawing.Point(160, 80)
        Me.CheckBox_Sounds.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CheckBox_Sounds.Name = "CheckBox_Sounds"
        Me.CheckBox_Sounds.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox_Sounds.TabIndex = 108
        Me.CheckBox_Sounds.Text = "Sounds"
        Me.CheckBox_Sounds.UseVisualStyleBackColor = False
        '
        'ShapeContainer6
        '
        Me.ShapeContainer6.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer6.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer6.Name = "ShapeContainer6"
        Me.ShapeContainer6.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4})
        Me.ShapeContainer6.Size = New System.Drawing.Size(352, 112)
        Me.ShapeContainer6.TabIndex = 107
        Me.ShapeContainer6.TabStop = False
        '
        'PixelBox_PackageThumbnail
        '
        Me.PixelBox_PackageThumbnail.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PixelBox_PackageThumbnail.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.PixelBox_PackageThumbnail.ContextMenuStrip = Me.ContextMenuStrip_PackageThumbnail
        Me.PixelBox_PackageThumbnail.Location = New System.Drawing.Point(16, 32)
        Me.PixelBox_PackageThumbnail.Name = "PixelBox_PackageThumbnail"
        Me.PixelBox_PackageThumbnail.Size = New System.Drawing.Size(168, 120)
        Me.PixelBox_PackageThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox_PackageThumbnail.TabIndex = 103
        Me.PixelBox_PackageThumbnail.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PixelBox_PackageThumbnail, "Right-click for options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can drag & drop a image here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Saved image will be " &
        "scaled to a 16:9 aspect ratio.")
        '
        'PackageMaker
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(551, 359)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel_PackageThumbnail)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PackageMaker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Package Maker"
        Me.ContextMenuStrip_PackageThumbnail.ResumeLayout(False)
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_ControlBox.ResumeLayout(False)
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_PackageThumbnail.ResumeLayout(False)
        Me.Panel_PackageThumbnail.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDown_Price, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PixelBox_PackageThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_ControlBox As Panel
    Friend WithEvents PictureBox_Close As PictureBox
    Friend WithEvents PictureBox_Minimize As PictureBox
    Friend WithEvents Label_Application_Title As Label
    Friend WithEvents PictureBox_AppIcon As PictureBox
    Friend WithEvents Button_Save As Button
    Friend WithEvents Panel_PackageThumbnail As Panel
    Friend WithEvents PixelBox_PackageThumbnail As PixelBox
    Friend WithEvents ShapeContainer3 As ShapeContainer
    Friend WithEvents RectangleShape_Image As RectangleShape
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label_PackageName As Label
    Friend WithEvents TextBox_PackageName As TextBox
    Friend WithEvents ShapeContainer4 As ShapeContainer
    Friend WithEvents RectangleShape2 As RectangleShape
    Friend WithEvents SaveFileDialog_PackJson As SaveFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_Description As Label
    Friend WithEvents TextBox_Description As TextBox
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents ContextMenuStrip_PackageThumbnail As ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog_PackageThumbnail As SaveFileDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_Price As Label
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents RectangleShape3 As RectangleShape
    Friend WithEvents CheckBox_FullGamePack As CheckBox
    Friend WithEvents RectangleShape4 As RectangleShape
    Friend WithEvents CheckBox_Character As CheckBox
    Friend WithEvents CheckBox_Props As CheckBox
    Friend WithEvents CheckBox_Background As CheckBox
    Friend WithEvents CheckBox_VisualEffect As CheckBox
    Friend WithEvents CheckBox_Interface As CheckBox
    Friend WithEvents CheckBox_Prefab As CheckBox
    Friend WithEvents Label_Categories As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ShapeContainer6 As ShapeContainer
    Friend WithEvents CheckBox_Sounds As CheckBox
    Friend WithEvents NumericUpDown_Price As NumericUpDown
    Private WithEvents Label_PackageThumbnail As Label
End Class
