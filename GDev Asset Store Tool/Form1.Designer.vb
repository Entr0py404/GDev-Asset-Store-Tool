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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel_ControlBox = New System.Windows.Forms.Panel()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Minimize = New System.Windows.Forms.PictureBox()
        Me.Label_Application_Title = New System.Windows.Forms.Label()
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.RadioButton_Text = New System.Windows.Forms.RadioButton()
        Me.RadioButton_BBText = New System.Windows.Forms.RadioButton()
        Me.RadioButton_BitmapText = New System.Windows.Forms.RadioButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.TextBox_SelectedFont = New System.Windows.Forms.TextBox()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button_SelectFont = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FastColoredTextBox_AssetJson = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Label_assetjson = New System.Windows.Forms.Label()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_Selected_File = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_SelectedFont = New System.Windows.Forms.Panel()
        Me.Label_SelectedFont = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel_BitmapAtlasImage = New System.Windows.Forms.Panel()
        Me.Label_BitmapAtlasImage = New System.Windows.Forms.Label()
        Me.Button_SelectBitmapAtlasImage = New System.Windows.Forms.Button()
        Me.TextBox_BitmapAtlasImage = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel_Main.SuspendLayout()
        Me.Panel_ControlBox.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.FastColoredTextBox_AssetJson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_SelectedFont.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel_BitmapAtlasImage.SuspendLayout()
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
        Me.Label_Application_Title.Text = "Font Asset Json Maker"
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
        'RadioButton_Text
        '
        Me.RadioButton_Text.AutoSize = True
        Me.RadioButton_Text.Checked = True
        Me.RadioButton_Text.Location = New System.Drawing.Point(96, 8)
        Me.RadioButton_Text.Name = "RadioButton_Text"
        Me.RadioButton_Text.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton_Text.TabIndex = 98
        Me.RadioButton_Text.TabStop = True
        Me.RadioButton_Text.Text = "Text"
        Me.RadioButton_Text.UseVisualStyleBackColor = True
        '
        'RadioButton_BBText
        '
        Me.RadioButton_BBText.AutoSize = True
        Me.RadioButton_BBText.Location = New System.Drawing.Point(152, 8)
        Me.RadioButton_BBText.Name = "RadioButton_BBText"
        Me.RadioButton_BBText.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton_BBText.TabIndex = 99
        Me.RadioButton_BBText.Text = "BBText"
        Me.RadioButton_BBText.UseVisualStyleBackColor = True
        '
        'RadioButton_BitmapText
        '
        Me.RadioButton_BitmapText.AutoSize = True
        Me.RadioButton_BitmapText.Location = New System.Drawing.Point(224, 8)
        Me.RadioButton_BitmapText.Name = "RadioButton_BitmapText"
        Me.RadioButton_BitmapText.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton_BitmapText.TabIndex = 100
        Me.RadioButton_BitmapText.Text = "Bitmap Text"
        Me.RadioButton_BitmapText.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Save.FlatAppearance.BorderSize = 0
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(360, 496)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(96, 24)
        Me.Button_Save.TabIndex = 105
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'TextBox_SelectedFont
        '
        Me.TextBox_SelectedFont.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_SelectedFont.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_SelectedFont.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_SelectedFont.Location = New System.Drawing.Point(16, 24)
        Me.TextBox_SelectedFont.Name = "TextBox_SelectedFont"
        Me.TextBox_SelectedFont.Size = New System.Drawing.Size(368, 13)
        Me.TextBox_SelectedFont.TabIndex = 106
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
        Me.RectangleShape2.Size = New System.Drawing.Size(384, 24)
        '
        'Button_SelectFont
        '
        Me.Button_SelectFont.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_SelectFont.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_SelectFont.FlatAppearance.BorderSize = 0
        Me.Button_SelectFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SelectFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SelectFont.Location = New System.Drawing.Point(400, 16)
        Me.Button_SelectFont.Name = "Button_SelectFont"
        Me.Button_SelectFont.Size = New System.Drawing.Size(56, 24)
        Me.Button_SelectFont.TabIndex = 109
        Me.Button_SelectFont.Text = "..."
        Me.Button_SelectFont.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FastColoredTextBox_AssetJson)
        Me.Panel2.Controls.Add(Me.Label_assetjson)
        Me.Panel2.Controls.Add(Me.ShapeContainer5)
        Me.Panel2.Location = New System.Drawing.Point(0, 184)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 304)
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
        Me.FastColoredTextBox_AssetJson.Size = New System.Drawing.Size(432, 264)
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
        Me.ShapeContainer5.Size = New System.Drawing.Size(464, 304)
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
        Me.RectangleShape_Selected_File.Size = New System.Drawing.Size(448, 280)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Font Object: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_SelectedFont
        '
        Me.Panel_SelectedFont.AllowDrop = True
        Me.Panel_SelectedFont.Controls.Add(Me.Label_SelectedFont)
        Me.Panel_SelectedFont.Controls.Add(Me.Button_SelectFont)
        Me.Panel_SelectedFont.Controls.Add(Me.TextBox_SelectedFont)
        Me.Panel_SelectedFont.Controls.Add(Me.ShapeContainer2)
        Me.Panel_SelectedFont.Location = New System.Drawing.Point(0, 72)
        Me.Panel_SelectedFont.Name = "Panel_SelectedFont"
        Me.Panel_SelectedFont.Size = New System.Drawing.Size(464, 56)
        Me.Panel_SelectedFont.TabIndex = 113
        '
        'Label_SelectedFont
        '
        Me.Label_SelectedFont.AutoSize = True
        Me.Label_SelectedFont.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_SelectedFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_SelectedFont.Location = New System.Drawing.Point(0, 0)
        Me.Label_SelectedFont.Name = "Label_SelectedFont"
        Me.Label_SelectedFont.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_SelectedFont.Size = New System.Drawing.Size(94, 13)
        Me.Label_SelectedFont.TabIndex = 110
        Me.Label_SelectedFont.Text = "Selected Font"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(464, 56)
        Me.ShapeContainer2.TabIndex = 107
        Me.ShapeContainer2.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.RadioButton_Text)
        Me.Panel3.Controls.Add(Me.RadioButton_BBText)
        Me.Panel3.Controls.Add(Me.RadioButton_BitmapText)
        Me.Panel3.Location = New System.Drawing.Point(0, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(464, 32)
        Me.Panel3.TabIndex = 114
        '
        'Panel_BitmapAtlasImage
        '
        Me.Panel_BitmapAtlasImage.AllowDrop = True
        Me.Panel_BitmapAtlasImage.Controls.Add(Me.Label_BitmapAtlasImage)
        Me.Panel_BitmapAtlasImage.Controls.Add(Me.Button_SelectBitmapAtlasImage)
        Me.Panel_BitmapAtlasImage.Controls.Add(Me.TextBox_BitmapAtlasImage)
        Me.Panel_BitmapAtlasImage.Controls.Add(Me.ShapeContainer1)
        Me.Panel_BitmapAtlasImage.Location = New System.Drawing.Point(0, 128)
        Me.Panel_BitmapAtlasImage.Name = "Panel_BitmapAtlasImage"
        Me.Panel_BitmapAtlasImage.Size = New System.Drawing.Size(464, 56)
        Me.Panel_BitmapAtlasImage.TabIndex = 115
        '
        'Label_BitmapAtlasImage
        '
        Me.Label_BitmapAtlasImage.AutoSize = True
        Me.Label_BitmapAtlasImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_BitmapAtlasImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_BitmapAtlasImage.Location = New System.Drawing.Point(0, 0)
        Me.Label_BitmapAtlasImage.Name = "Label_BitmapAtlasImage"
        Me.Label_BitmapAtlasImage.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_BitmapAtlasImage.Size = New System.Drawing.Size(121, 13)
        Me.Label_BitmapAtlasImage.TabIndex = 110
        Me.Label_BitmapAtlasImage.Text = "Bitmap atlas image"
        '
        'Button_SelectBitmapAtlasImage
        '
        Me.Button_SelectBitmapAtlasImage.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_SelectBitmapAtlasImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_SelectBitmapAtlasImage.FlatAppearance.BorderSize = 0
        Me.Button_SelectBitmapAtlasImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SelectBitmapAtlasImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SelectBitmapAtlasImage.Location = New System.Drawing.Point(400, 16)
        Me.Button_SelectBitmapAtlasImage.Name = "Button_SelectBitmapAtlasImage"
        Me.Button_SelectBitmapAtlasImage.Size = New System.Drawing.Size(56, 24)
        Me.Button_SelectBitmapAtlasImage.TabIndex = 109
        Me.Button_SelectBitmapAtlasImage.Text = "..."
        Me.Button_SelectBitmapAtlasImage.UseVisualStyleBackColor = False
        '
        'TextBox_BitmapAtlasImage
        '
        Me.TextBox_BitmapAtlasImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_BitmapAtlasImage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_BitmapAtlasImage.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_BitmapAtlasImage.Location = New System.Drawing.Point(16, 24)
        Me.TextBox_BitmapAtlasImage.Name = "TextBox_BitmapAtlasImage"
        Me.TextBox_BitmapAtlasImage.Size = New System.Drawing.Size(368, 13)
        Me.TextBox_BitmapAtlasImage.TabIndex = 106
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(464, 56)
        Me.ShapeContainer1.TabIndex = 107
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
        Me.RectangleShape1.Name = "RectangleShape2"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(384, 24)
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Hint"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(465, 530)
        Me.Controls.Add(Me.Panel_BitmapAtlasImage)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel_SelectedFont)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Panel_Main)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BBText"
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel_BitmapAtlasImage.ResumeLayout(False)
        Me.Panel_BitmapAtlasImage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_ControlBox As Panel
    Friend WithEvents PictureBox_Close As PictureBox
    Friend WithEvents PictureBox_Minimize As PictureBox
    Friend WithEvents Label_Application_Title As Label
    Friend WithEvents PictureBox_AppIcon As PictureBox
    Friend WithEvents RadioButton_Text As RadioButton
    Friend WithEvents RadioButton_BBText As RadioButton
    Friend WithEvents RadioButton_BitmapText As RadioButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button_Save As Button
    Friend WithEvents TextBox_SelectedFont As TextBox
    Friend WithEvents RectangleShape2 As RectangleShape
    Friend WithEvents Button_SelectFont As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FastColoredTextBox_AssetJson As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Label_assetjson As Label
    Friend WithEvents ShapeContainer5 As ShapeContainer
    Friend WithEvents RectangleShape_Selected_File As RectangleShape
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_SelectedFont As Panel
    Friend WithEvents Label_SelectedFont As Label
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel_BitmapAtlasImage As Panel
    Friend WithEvents Label_BitmapAtlasImage As Label
    Friend WithEvents Button_SelectBitmapAtlasImage As Button
    Friend WithEvents TextBox_BitmapAtlasImage As TextBox
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
End Class
