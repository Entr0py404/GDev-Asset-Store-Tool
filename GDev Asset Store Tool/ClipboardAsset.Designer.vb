<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClipboardAsset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClipboardAsset))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.TextBox_Description = New System.Windows.Forms.TextBox()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button_PasteObject = New System.Windows.Forms.Button()
        Me.FastColoredTextBox_AssetJson = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.ContextMenuStrip_AssetJSON = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_assetjson = New System.Windows.Forms.Label()
        Me.Panel_SelectedFont = New System.Windows.Forms.Panel()
        Me.Label_Description = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox_Objects = New System.Windows.Forms.ListBox()
        Me.Panel_Objects = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button_GenerateAsset = New System.Windows.Forms.Button()
        Me.Panel_PreviewImage = New System.Windows.Forms.Panel()
        Me.Label_Image = New System.Windows.Forms.Label()
        Me.PixelBox_PreviewImage = New GDev_Asset_Store_Tool.PixelBox()
        Me.ContextMenuStrip_PreviewImage = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_Image = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog_PreviewImage = New System.Windows.Forms.SaveFileDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FastColoredTextBox_Resources = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.ContextMenuStrip_Resources = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBox_ProjectFilepath = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.FastColoredTextBox_AssetJson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_AssetJSON.SuspendLayout()
        Me.Panel_SelectedFont.SuspendLayout()
        Me.Panel_Objects.SuspendLayout()
        Me.Panel_PreviewImage.SuspendLayout()
        CType(Me.PixelBox_PreviewImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_PreviewImage.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FastColoredTextBox_Resources, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_Resources.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Asset Json file (*.asset.json)|*.asset.json"
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Save.FlatAppearance.BorderSize = 0
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(848, 200)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(104, 24)
        Me.Button_Save.TabIndex = 105
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'TextBox_Description
        '
        Me.TextBox_Description.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Description.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_Description.Location = New System.Drawing.Point(16, 24)
        Me.TextBox_Description.Name = "TextBox_Description"
        Me.TextBox_Description.Size = New System.Drawing.Size(432, 13)
        Me.TextBox_Description.TabIndex = 106
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape2.CornerRadius = 3
        Me.RectangleShape2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.Location = New System.Drawing.Point(8, 16)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Size = New System.Drawing.Size(448, 24)
        '
        'Button_PasteObject
        '
        Me.Button_PasteObject.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_PasteObject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_PasteObject.FlatAppearance.BorderSize = 0
        Me.Button_PasteObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_PasteObject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_PasteObject.Location = New System.Drawing.Point(24, 144)
        Me.Button_PasteObject.Name = "Button_PasteObject"
        Me.Button_PasteObject.Size = New System.Drawing.Size(264, 24)
        Me.Button_PasteObject.TabIndex = 109
        Me.Button_PasteObject.Text = "Paste Object From GDevelop"
        Me.Button_PasteObject.UseVisualStyleBackColor = False
        '
        'FastColoredTextBox_AssetJson
        '
        Me.FastColoredTextBox_AssetJson.AllowDrop = False
        Me.FastColoredTextBox_AssetJson.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.FastColoredTextBox_AssetJson.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FastColoredTextBox_AssetJson.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.FastColoredTextBox_AssetJson.BackBrush = Nothing
        Me.FastColoredTextBox_AssetJson.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.FastColoredTextBox_AssetJson.CaretColor = System.Drawing.Color.DodgerBlue
        Me.FastColoredTextBox_AssetJson.CharHeight = 14
        Me.FastColoredTextBox_AssetJson.CharWidth = 8
        Me.FastColoredTextBox_AssetJson.CommentPrefix = "'"
        Me.FastColoredTextBox_AssetJson.ContextMenuStrip = Me.ContextMenuStrip_AssetJSON
        Me.FastColoredTextBox_AssetJson.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox_AssetJson.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox_AssetJson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FastColoredTextBox_AssetJson.FoldingIndicatorColor = System.Drawing.Color.Khaki
        Me.FastColoredTextBox_AssetJson.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.FastColoredTextBox_AssetJson.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FastColoredTextBox_AssetJson.IndentBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.FastColoredTextBox_AssetJson.IsReplaceMode = False
        Me.FastColoredTextBox_AssetJson.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.FastColoredTextBox_AssetJson.LineNumberColor = System.Drawing.Color.DodgerBlue
        Me.FastColoredTextBox_AssetJson.Location = New System.Drawing.Point(8, 29)
        Me.FastColoredTextBox_AssetJson.Name = "FastColoredTextBox_AssetJson"
        Me.FastColoredTextBox_AssetJson.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox_AssetJson.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.FastColoredTextBox_AssetJson.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FastColoredTextBox_AssetJson.ServiceColors = CType(resources.GetObject("FastColoredTextBox_AssetJson.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.FastColoredTextBox_AssetJson.ServiceLinesColor = System.Drawing.Color.WhiteSmoke
        Me.FastColoredTextBox_AssetJson.ShowFoldingLines = True
        Me.FastColoredTextBox_AssetJson.Size = New System.Drawing.Size(671, 412)
        Me.FastColoredTextBox_AssetJson.TabIndex = 91
        Me.FastColoredTextBox_AssetJson.Zoom = 100
        '
        'ContextMenuStrip_AssetJSON
        '
        Me.ContextMenuStrip_AssetJSON.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip_AssetJSON.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_AssetJSON.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem1, Me.CopyToolStripMenuItem1, Me.PasteToolStripMenuItem})
        Me.ContextMenuStrip_AssetJSON.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip_AssetJSON.ShowImageMargin = False
        Me.ContextMenuStrip_AssetJSON.Size = New System.Drawing.Size(88, 76)
        '
        'CutToolStripMenuItem1
        '
        Me.CutToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1"
        Me.CutToolStripMenuItem1.Size = New System.Drawing.Size(87, 24)
        Me.CutToolStripMenuItem1.Text = "Cut"
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(87, 24)
        Me.CopyToolStripMenuItem1.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'Label_assetjson
        '
        Me.Label_assetjson.AutoSize = True
        Me.Label_assetjson.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_assetjson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_assetjson.Location = New System.Drawing.Point(8, 0)
        Me.Label_assetjson.Name = "Label_assetjson"
        Me.Label_assetjson.Padding = New System.Windows.Forms.Padding(8)
        Me.Label_assetjson.Size = New System.Drawing.Size(84, 29)
        Me.Label_assetjson.TabIndex = 81
        Me.Label_assetjson.Text = ".asset.json"
        Me.Label_assetjson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_SelectedFont
        '
        Me.Panel_SelectedFont.AllowDrop = True
        Me.Panel_SelectedFont.Controls.Add(Me.Label_Description)
        Me.Panel_SelectedFont.Controls.Add(Me.TextBox_Description)
        Me.Panel_SelectedFont.Controls.Add(Me.ShapeContainer2)
        Me.Panel_SelectedFont.Location = New System.Drawing.Point(216, 184)
        Me.Panel_SelectedFont.Name = "Panel_SelectedFont"
        Me.Panel_SelectedFont.Size = New System.Drawing.Size(464, 48)
        Me.Panel_SelectedFont.TabIndex = 113
        '
        'Label_Description
        '
        Me.Label_Description.AutoSize = True
        Me.Label_Description.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Description.Location = New System.Drawing.Point(0, 0)
        Me.Label_Description.Name = "Label_Description"
        Me.Label_Description.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_Description.Size = New System.Drawing.Size(79, 13)
        Me.Label_Description.TabIndex = 110
        Me.Label_Description.Text = "Description"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(464, 48)
        Me.ShapeContainer2.TabIndex = 107
        Me.ShapeContainer2.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'ListBox_Objects
        '
        Me.ListBox_Objects.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListBox_Objects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_Objects.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox_Objects.FormattingEnabled = True
        Me.ListBox_Objects.Location = New System.Drawing.Point(16, 24)
        Me.ListBox_Objects.Name = "ListBox_Objects"
        Me.ListBox_Objects.Size = New System.Drawing.Size(280, 104)
        Me.ListBox_Objects.TabIndex = 114
        '
        'Panel_Objects
        '
        Me.Panel_Objects.Controls.Add(Me.Button_PasteObject)
        Me.Panel_Objects.Controls.Add(Me.Label1)
        Me.Panel_Objects.Controls.Add(Me.ListBox_Objects)
        Me.Panel_Objects.Controls.Add(Me.ShapeContainer1)
        Me.Panel_Objects.Location = New System.Drawing.Point(216, 8)
        Me.Panel_Objects.Name = "Panel_Objects"
        Me.Panel_Objects.Size = New System.Drawing.Size(312, 176)
        Me.Panel_Objects.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Objects"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(312, 176)
        Me.ShapeContainer1.TabIndex = 116
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
        Me.RectangleShape1.Location = New System.Drawing.Point(8, 16)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(296, 120)
        '
        'Button_GenerateAsset
        '
        Me.Button_GenerateAsset.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_GenerateAsset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_GenerateAsset.FlatAppearance.BorderSize = 0
        Me.Button_GenerateAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_GenerateAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_GenerateAsset.Location = New System.Drawing.Point(688, 200)
        Me.Button_GenerateAsset.Name = "Button_GenerateAsset"
        Me.Button_GenerateAsset.Size = New System.Drawing.Size(144, 24)
        Me.Button_GenerateAsset.TabIndex = 116
        Me.Button_GenerateAsset.Text = "Generate Asset"
        Me.Button_GenerateAsset.UseVisualStyleBackColor = False
        '
        'Panel_PreviewImage
        '
        Me.Panel_PreviewImage.AllowDrop = True
        Me.Panel_PreviewImage.Controls.Add(Me.Label_Image)
        Me.Panel_PreviewImage.Controls.Add(Me.PixelBox_PreviewImage)
        Me.Panel_PreviewImage.Controls.Add(Me.ShapeContainer3)
        Me.Panel_PreviewImage.Location = New System.Drawing.Point(0, 8)
        Me.Panel_PreviewImage.Name = "Panel_PreviewImage"
        Me.Panel_PreviewImage.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Panel_PreviewImage.Size = New System.Drawing.Size(216, 224)
        Me.Panel_PreviewImage.TabIndex = 117
        '
        'Label_Image
        '
        Me.Label_Image.AutoSize = True
        Me.Label_Image.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Image.Location = New System.Drawing.Point(0, 0)
        Me.Label_Image.Name = "Label_Image"
        Me.Label_Image.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_Image.Size = New System.Drawing.Size(98, 13)
        Me.Label_Image.TabIndex = 103
        Me.Label_Image.Text = "Preview Image"
        '
        'PixelBox_PreviewImage
        '
        Me.PixelBox_PreviewImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PixelBox_PreviewImage.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.PixelBox_PreviewImage.ContextMenuStrip = Me.ContextMenuStrip_PreviewImage
        Me.PixelBox_PreviewImage.Location = New System.Drawing.Point(16, 24)
        Me.PixelBox_PreviewImage.Name = "PixelBox_PreviewImage"
        Me.PixelBox_PreviewImage.Size = New System.Drawing.Size(184, 184)
        Me.PixelBox_PreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox_PreviewImage.TabIndex = 103
        Me.PixelBox_PreviewImage.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PixelBox_PreviewImage, "Right-click for options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can drag & drop a image here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Saved image will be " &
        "scaled to a 1:1 aspect ratio.")
        '
        'ContextMenuStrip_PreviewImage
        '
        Me.ContextMenuStrip_PreviewImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip_PreviewImage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_PreviewImage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.ContextMenuStrip_PreviewImage.Name = "ContextMenuStrip_PackageThumbnail"
        Me.ContextMenuStrip_PreviewImage.ShowImageMargin = False
        Me.ContextMenuStrip_PreviewImage.Size = New System.Drawing.Size(85, 28)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 8)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Image})
        Me.ShapeContainer3.Size = New System.Drawing.Size(216, 216)
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
        Me.RectangleShape_Image.Location = New System.Drawing.Point(8, 8)
        Me.RectangleShape_Image.Name = "RectangleShape_Image"
        Me.RectangleShape_Image.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Image.Size = New System.Drawing.Size(200, 200)
        '
        'SaveFileDialog_PreviewImage
        '
        Me.SaveFileDialog_PreviewImage.Filter = "Png Image (*.preview.png)|*.preview.png"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FastColoredTextBox_Resources
        '
        Me.FastColoredTextBox_Resources.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.FastColoredTextBox_Resources.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FastColoredTextBox_Resources.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.FastColoredTextBox_Resources.BackBrush = Nothing
        Me.FastColoredTextBox_Resources.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.FastColoredTextBox_Resources.CaretColor = System.Drawing.Color.DodgerBlue
        Me.FastColoredTextBox_Resources.CharHeight = 14
        Me.FastColoredTextBox_Resources.CharWidth = 8
        Me.FastColoredTextBox_Resources.CommentPrefix = "'"
        Me.FastColoredTextBox_Resources.ContextMenuStrip = Me.ContextMenuStrip_Resources
        Me.FastColoredTextBox_Resources.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox_Resources.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox_Resources.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FastColoredTextBox_Resources.FoldingIndicatorColor = System.Drawing.Color.Khaki
        Me.FastColoredTextBox_Resources.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.FastColoredTextBox_Resources.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FastColoredTextBox_Resources.IndentBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.FastColoredTextBox_Resources.IsReplaceMode = False
        Me.FastColoredTextBox_Resources.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.FastColoredTextBox_Resources.LineNumberColor = System.Drawing.Color.DodgerBlue
        Me.FastColoredTextBox_Resources.Location = New System.Drawing.Point(0, 44)
        Me.FastColoredTextBox_Resources.Name = "FastColoredTextBox_Resources"
        Me.FastColoredTextBox_Resources.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox_Resources.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.FastColoredTextBox_Resources.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FastColoredTextBox_Resources.ServiceColors = CType(resources.GetObject("FastColoredTextBox_Resources.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.FastColoredTextBox_Resources.ServiceLinesColor = System.Drawing.Color.WhiteSmoke
        Me.FastColoredTextBox_Resources.ShowFoldingLines = True
        Me.FastColoredTextBox_Resources.Size = New System.Drawing.Size(362, 397)
        Me.FastColoredTextBox_Resources.TabIndex = 91
        Me.FastColoredTextBox_Resources.Zoom = 100
        '
        'ContextMenuStrip_Resources
        '
        Me.ContextMenuStrip_Resources.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip_Resources.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_Resources.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.ToolStripSeparator1, Me.ClearToolStripMenuItem, Me.ReloadToolStripMenuItem})
        Me.ContextMenuStrip_Resources.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip_Resources.ShowImageMargin = False
        Me.ContextMenuStrip_Resources.Size = New System.Drawing.Size(101, 106)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(97, 6)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(8)
        Me.Label2.Size = New System.Drawing.Size(148, 29)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "game.json, Resources"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 232)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FastColoredTextBox_AssetJson)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_assetjson)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 8)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FastColoredTextBox_Resources)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox_ProjectFilepath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.SplitContainer1.Size = New System.Drawing.Size(1065, 449)
        Me.SplitContainer1.SplitterDistance = 679
        Me.SplitContainer1.SplitterWidth = 16
        Me.SplitContainer1.TabIndex = 119
        '
        'TextBox_ProjectFilepath
        '
        Me.TextBox_ProjectFilepath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_ProjectFilepath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ProjectFilepath.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_ProjectFilepath.Enabled = False
        Me.TextBox_ProjectFilepath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ProjectFilepath.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_ProjectFilepath.Location = New System.Drawing.Point(0, 29)
        Me.TextBox_ProjectFilepath.Name = "TextBox_ProjectFilepath"
        Me.TextBox_ProjectFilepath.ReadOnly = True
        Me.TextBox_ProjectFilepath.Size = New System.Drawing.Size(362, 15)
        Me.TextBox_ProjectFilepath.TabIndex = 119
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button_Save)
        Me.Panel2.Controls.Add(Me.Button_GenerateAsset)
        Me.Panel2.Controls.Add(Me.Panel_PreviewImage)
        Me.Panel2.Controls.Add(Me.Panel_SelectedFont)
        Me.Panel2.Controls.Add(Me.Panel_Objects)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1065, 232)
        Me.Panel2.TabIndex = 120
        '
        'ClipboardAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1065, 681)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ClipboardAsset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clipboard Asset"
        CType(Me.FastColoredTextBox_AssetJson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_AssetJSON.ResumeLayout(False)
        Me.Panel_SelectedFont.ResumeLayout(False)
        Me.Panel_SelectedFont.PerformLayout()
        Me.Panel_Objects.ResumeLayout(False)
        Me.Panel_Objects.PerformLayout()
        Me.Panel_PreviewImage.ResumeLayout(False)
        Me.Panel_PreviewImage.PerformLayout()
        CType(Me.PixelBox_PreviewImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_PreviewImage.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FastColoredTextBox_Resources, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_Resources.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button_Save As Button
    Friend WithEvents TextBox_Description As TextBox
    Friend WithEvents RectangleShape2 As RectangleShape
    Friend WithEvents Button_PasteObject As Button
    Friend WithEvents FastColoredTextBox_AssetJson As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Label_assetjson As Label
    Friend WithEvents Panel_SelectedFont As Panel
    Friend WithEvents Label_Description As Label
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents ListBox_Objects As ListBox
    Friend WithEvents Panel_Objects As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_GenerateAsset As Button
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents Panel_PreviewImage As Panel
    Friend WithEvents Label_Image As Label
    Friend WithEvents PixelBox_PreviewImage As PixelBox
    Friend WithEvents ShapeContainer3 As ShapeContainer
    Friend WithEvents RectangleShape_Image As RectangleShape
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContextMenuStrip_PreviewImage As ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog_PreviewImage As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents FastColoredTextBox_Resources As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ContextMenuStrip_AssetJSON As ContextMenuStrip
    Friend WithEvents TextBox_ProjectFilepath As TextBox
    Friend WithEvents ContextMenuStrip_Resources As ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem1 As ToolStripMenuItem
End Class
