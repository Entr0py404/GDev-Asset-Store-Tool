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
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel_ControlBox = New System.Windows.Forms.Panel()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Minimize = New System.Windows.Forms.PictureBox()
        Me.Label_Application_Title = New System.Windows.Forms.Label()
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.TextBox_Description = New System.Windows.Forms.TextBox()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button_PasteObject = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FastColoredTextBox_AssetJson = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Label_assetjson = New System.Windows.Forms.Label()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_Selected_File = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel_SelectedFont = New System.Windows.Forms.Panel()
        Me.Label_Description = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox_Objects = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel_Main.SuspendLayout()
        Me.Panel_ControlBox.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.FastColoredTextBox_AssetJson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_SelectedFont.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel_PreviewImage.SuspendLayout()
        CType(Me.PixelBox_PreviewImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_PreviewImage.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel_Main.Size = New System.Drawing.Size(465, 26)
        Me.Panel_Main.TabIndex = 97
        '
        'Panel_ControlBox
        '
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Close)
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Minimize)
        Me.Panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_ControlBox.Location = New System.Drawing.Point(413, 0)
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
        Me.Label_Application_Title.Size = New System.Drawing.Size(154, 26)
        Me.Label_Application_Title.TabIndex = 2
        Me.Label_Application_Title.Text = "Asset Json From Clipboard"
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
        Me.Button_Save.Location = New System.Drawing.Point(352, 496)
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
        Me.Button_PasteObject.Location = New System.Drawing.Point(8, 120)
        Me.Button_PasteObject.Name = "Button_PasteObject"
        Me.Button_PasteObject.Size = New System.Drawing.Size(224, 24)
        Me.Button_PasteObject.TabIndex = 109
        Me.Button_PasteObject.Text = "Paste Object From GDevelop"
        Me.Button_PasteObject.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FastColoredTextBox_AssetJson)
        Me.Panel2.Controls.Add(Me.Label_assetjson)
        Me.Panel2.Controls.Add(Me.ShapeContainer5)
        Me.Panel2.Location = New System.Drawing.Point(0, 232)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 256)
        Me.Panel2.TabIndex = 110
        '
        'FastColoredTextBox_AssetJson
        '
        Me.FastColoredTextBox_AssetJson.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.FastColoredTextBox_AssetJson.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FastColoredTextBox_AssetJson.AutoScrollMinSize = New System.Drawing.Size(2, 14)
        Me.FastColoredTextBox_AssetJson.BackBrush = Nothing
        Me.FastColoredTextBox_AssetJson.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FastColoredTextBox_AssetJson.CharHeight = 14
        Me.FastColoredTextBox_AssetJson.CharWidth = 8
        Me.FastColoredTextBox_AssetJson.CommentPrefix = "'"
        Me.FastColoredTextBox_AssetJson.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox_AssetJson.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox_AssetJson.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.FastColoredTextBox_AssetJson.ForeColor = System.Drawing.Color.Black
        Me.FastColoredTextBox_AssetJson.IndentBackColor = System.Drawing.Color.Black
        Me.FastColoredTextBox_AssetJson.IsReplaceMode = False
        Me.FastColoredTextBox_AssetJson.Language = FastColoredTextBoxNS.Language.VB
        Me.FastColoredTextBox_AssetJson.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.FastColoredTextBox_AssetJson.Location = New System.Drawing.Point(16, 24)
        Me.FastColoredTextBox_AssetJson.Name = "FastColoredTextBox_AssetJson"
        Me.FastColoredTextBox_AssetJson.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox_AssetJson.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.FastColoredTextBox_AssetJson.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FastColoredTextBox_AssetJson.ServiceColors = CType(resources.GetObject("FastColoredTextBox_AssetJson.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.FastColoredTextBox_AssetJson.ShowLineNumbers = False
        Me.FastColoredTextBox_AssetJson.Size = New System.Drawing.Size(432, 216)
        Me.FastColoredTextBox_AssetJson.TabIndex = 91
        Me.FastColoredTextBox_AssetJson.Zoom = 100
        '
        'Label_assetjson
        '
        Me.Label_assetjson.AutoSize = True
        Me.Label_assetjson.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_assetjson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_assetjson.Location = New System.Drawing.Point(0, 0)
        Me.Label_assetjson.Name = "Label_assetjson"
        Me.Label_assetjson.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_assetjson.Size = New System.Drawing.Size(76, 13)
        Me.Label_assetjson.TabIndex = 81
        Me.Label_assetjson.Text = ".asset.json"
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Selected_File})
        Me.ShapeContainer5.Size = New System.Drawing.Size(464, 256)
        Me.ShapeContainer5.TabIndex = 82
        Me.ShapeContainer5.TabStop = False
        '
        'RectangleShape_Selected_File
        '
        Me.RectangleShape_Selected_File.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Selected_File.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Selected_File.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Selected_File.CornerRadius = 3
        Me.RectangleShape_Selected_File.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Selected_File.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Selected_File.Location = New System.Drawing.Point(8, 16)
        Me.RectangleShape_Selected_File.Name = "RectangleShape_Selected_File"
        Me.RectangleShape_Selected_File.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Selected_File.Size = New System.Drawing.Size(448, 232)
        '
        'Panel_SelectedFont
        '
        Me.Panel_SelectedFont.AllowDrop = True
        Me.Panel_SelectedFont.Controls.Add(Me.Label_Description)
        Me.Panel_SelectedFont.Controls.Add(Me.TextBox_Description)
        Me.Panel_SelectedFont.Controls.Add(Me.ShapeContainer2)
        Me.Panel_SelectedFont.Location = New System.Drawing.Point(0, 32)
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
        Me.ListBox_Objects.Size = New System.Drawing.Size(208, 78)
        Me.ListBox_Objects.TabIndex = 114
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_PasteObject)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ListBox_Objects)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(0, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 152)
        Me.Panel1.TabIndex = 115
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
        Me.ShapeContainer1.Size = New System.Drawing.Size(240, 152)
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
        Me.RectangleShape1.Size = New System.Drawing.Size(224, 96)
        '
        'Button_GenerateAsset
        '
        Me.Button_GenerateAsset.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_GenerateAsset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_GenerateAsset.FlatAppearance.BorderSize = 0
        Me.Button_GenerateAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_GenerateAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_GenerateAsset.Location = New System.Drawing.Point(8, 496)
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
        Me.Panel_PreviewImage.Location = New System.Drawing.Point(240, 80)
        Me.Panel_PreviewImage.Name = "Panel_PreviewImage"
        Me.Panel_PreviewImage.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Panel_PreviewImage.Size = New System.Drawing.Size(224, 152)
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
        Me.PixelBox_PreviewImage.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.[Default]
        Me.PixelBox_PreviewImage.Location = New System.Drawing.Point(16, 24)
        Me.PixelBox_PreviewImage.Name = "PixelBox_PreviewImage"
        Me.PixelBox_PreviewImage.Size = New System.Drawing.Size(192, 108)
        Me.PixelBox_PreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox_PreviewImage.TabIndex = 103
        Me.PixelBox_PreviewImage.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PixelBox_PreviewImage, "Right-click for options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can drag & drop a image here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Saved image will be " &
        "scaled to a 16:9 aspect ratio.")
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
        Me.ShapeContainer3.Size = New System.Drawing.Size(224, 144)
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
        Me.RectangleShape_Image.Size = New System.Drawing.Size(208, 128)
        '
        'SaveFileDialog_PreviewImage
        '
        Me.SaveFileDialog_PreviewImage.Filter = "Png Image (*.preview.png)|*.preview.png"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ClipboardAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(465, 531)
        Me.Controls.Add(Me.Panel_PreviewImage)
        Me.Controls.Add(Me.Button_GenerateAsset)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_SelectedFont)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Panel_Main)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ClipboardAsset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clipboard Asset"
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_ControlBox.ResumeLayout(False)
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.FastColoredTextBox_AssetJson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_SelectedFont.ResumeLayout(False)
        Me.Panel_SelectedFont.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_PreviewImage.ResumeLayout(False)
        Me.Panel_PreviewImage.PerformLayout()
        CType(Me.PixelBox_PreviewImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_PreviewImage.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_ControlBox As Panel
    Friend WithEvents PictureBox_Close As PictureBox
    Friend WithEvents PictureBox_Minimize As PictureBox
    Friend WithEvents Label_Application_Title As Label
    Friend WithEvents PictureBox_AppIcon As PictureBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button_Save As Button
    Friend WithEvents TextBox_Description As TextBox
    Friend WithEvents RectangleShape2 As RectangleShape
    Friend WithEvents Button_PasteObject As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FastColoredTextBox_AssetJson As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Label_assetjson As Label
    Friend WithEvents ShapeContainer5 As ShapeContainer
    Friend WithEvents RectangleShape_Selected_File As RectangleShape
    Friend WithEvents Panel_SelectedFont As Panel
    Friend WithEvents Label_Description As Label
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents ListBox_Objects As ListBox
    Friend WithEvents Panel1 As Panel
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
End Class
