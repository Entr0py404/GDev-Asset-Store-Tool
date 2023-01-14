<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MetadataGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MetadataGenerator))
        Me.TextBox_Selected_Directory = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip_TreeView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RegenerateSelectedFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GenerateMetadataFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegenerateMetadataFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.XFramesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssetStorePreviewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoopedAnimationKeywordsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAnimationNameToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip_Log = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog_Selected_Directory = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer_Animation = New System.Windows.Forms.Timer(Me.components)
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel_ControlBox = New System.Windows.Forms.Panel()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Minimize = New System.Windows.Forms.PictureBox()
        Me.Label_Application_Title = New System.Windows.Forms.Label()
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.RectangleShape_Log = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape_Metadata_Files = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape_Selected_File = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape_Animation = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape_Selected_Directory = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label_Log = New System.Windows.Forms.Label()
        Me.Label_Selected_File = New System.Windows.Forms.Label()
        Me.Label_Animation = New System.Windows.Forms.Label()
        Me.Label_Metadata_Files = New System.Windows.Forms.Label()
        Me.Label_Selected_Directory = New System.Windows.Forms.Label()
        Me.Panel_Selected_Directory_Controls = New System.Windows.Forms.Panel()
        Me.LinkLabel_Trello = New System.Windows.Forms.LinkLabel()
        Me.Button_Reload = New System.Windows.Forms.Button()
        Me.Button_Select_Directory = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel_Log = New System.Windows.Forms.Panel()
        Me.RichTextBox_Log = New System.Windows.Forms.RichTextBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel_Metadata_Files = New System.Windows.Forms.Panel()
        Me.Label_MetadataFileToGen = New System.Windows.Forms.Label()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel_Selected_File = New System.Windows.Forms.Panel()
        Me.FastColoredTextBox_Selected_File = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.ContextMenuStrip_FastColoredTextBox_Selected_File = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FlipLoopBooleanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel_Animation = New System.Windows.Forms.Panel()
        Me.Label_ZoomLvl = New System.Windows.Forms.Label()
        Me.Label_Frames = New System.Windows.Forms.Label()
        Me.PixelBox_Animation = New GDev_Asset_Store_Tool.PixelBox()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel_Controls = New System.Windows.Forms.Panel()
        Me.TextBox_TimeBetweenFrames = New System.Windows.Forms.TextBox()
        Me.CheckBox_Loop = New System.Windows.Forms.CheckBox()
        Me.Button_PausePlay = New System.Windows.Forms.Button()
        Me.Label_FPS = New System.Windows.Forms.Label()
        Me.Button_Replay = New System.Windows.Forms.Button()
        Me.NumericUpDown_TimeBetweenFrames = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox_Clock = New System.Windows.Forms.PictureBox()
        Me.NumericUpDown_FPS = New System.Windows.Forms.NumericUpDown()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemplateAssetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClipboardAssetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileNameValidatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssetStorePreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoopedAnimationKeywordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip_TreeView.SuspendLayout()
        Me.ContextMenuStrip_Log.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.Panel_ControlBox.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Selected_Directory_Controls.SuspendLayout()
        Me.Panel_Log.SuspendLayout()
        Me.Panel_Metadata_Files.SuspendLayout()
        Me.Panel_Selected_File.SuspendLayout()
        CType(Me.FastColoredTextBox_Selected_File, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_FastColoredTextBox_Selected_File.SuspendLayout()
        Me.Panel_Animation.SuspendLayout()
        CType(Me.PixelBox_Animation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Controls.SuspendLayout()
        CType(Me.NumericUpDown_TimeBetweenFrames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Clock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_FPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_Selected_Directory
        '
        Me.TextBox_Selected_Directory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_Selected_Directory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Selected_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Selected_Directory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_Selected_Directory.Location = New System.Drawing.Point(13, 22)
        Me.TextBox_Selected_Directory.Name = "TextBox_Selected_Directory"
        Me.TextBox_Selected_Directory.Size = New System.Drawing.Size(675, 13)
        Me.TextBox_Selected_Directory.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TextBox_Selected_Directory, "You can drag & drop a directory here.")
        '
        'ContextMenuStrip_TreeView
        '
        Me.ContextMenuStrip_TreeView.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip_TreeView.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_TreeView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegenerateSelectedFileToolStripMenuItem, Me.ToolStripSeparator1, Me.GenerateMetadataFilesToolStripMenuItem, Me.RegenerateMetadataFilesToolStripMenuItem, Me.ToolStripSeparator3, Me.XFramesToolStripMenuItem, Me.ToolStripSeparator4, Me.OpenFileToolStripMenuItem, Me.OpenDirectoryToolStripMenuItem, Me.AssetStorePreviewToolStripMenuItem1, Me.ToolStripSeparator6, Me.LoopedAnimationKeywordsToolStripMenuItem1})
        Me.ContextMenuStrip_TreeView.Name = "ContextMenuStrip_Listbox"
        Me.ContextMenuStrip_TreeView.ShowCheckMargin = True
        Me.ContextMenuStrip_TreeView.ShowImageMargin = False
        Me.ContextMenuStrip_TreeView.Size = New System.Drawing.Size(271, 220)
        '
        'RegenerateSelectedFileToolStripMenuItem
        '
        Me.RegenerateSelectedFileToolStripMenuItem.Enabled = False
        Me.RegenerateSelectedFileToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RegenerateSelectedFileToolStripMenuItem.Name = "RegenerateSelectedFileToolStripMenuItem"
        Me.RegenerateSelectedFileToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.RegenerateSelectedFileToolStripMenuItem.Text = "Regenerate selected file"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(267, 6)
        '
        'GenerateMetadataFilesToolStripMenuItem
        '
        Me.GenerateMetadataFilesToolStripMenuItem.Enabled = False
        Me.GenerateMetadataFilesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GenerateMetadataFilesToolStripMenuItem.Name = "GenerateMetadataFilesToolStripMenuItem"
        Me.GenerateMetadataFilesToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.GenerateMetadataFilesToolStripMenuItem.Text = "Generate metadata files"
        '
        'RegenerateMetadataFilesToolStripMenuItem
        '
        Me.RegenerateMetadataFilesToolStripMenuItem.Enabled = False
        Me.RegenerateMetadataFilesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RegenerateMetadataFilesToolStripMenuItem.Name = "RegenerateMetadataFilesToolStripMenuItem"
        Me.RegenerateMetadataFilesToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.RegenerateMetadataFilesToolStripMenuItem.Text = "Regenerate metadata files"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(267, 6)
        '
        'XFramesToolStripMenuItem
        '
        Me.XFramesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.XFramesToolStripMenuItem.Name = "XFramesToolStripMenuItem"
        Me.XFramesToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.XFramesToolStripMenuItem.Text = "2X frames"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(267, 6)
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Enabled = False
        Me.OpenFileToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.OpenFileToolStripMenuItem.Text = "Open file"
        '
        'OpenDirectoryToolStripMenuItem
        '
        Me.OpenDirectoryToolStripMenuItem.Enabled = False
        Me.OpenDirectoryToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.OpenDirectoryToolStripMenuItem.Name = "OpenDirectoryToolStripMenuItem"
        Me.OpenDirectoryToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.OpenDirectoryToolStripMenuItem.Text = "Open directory"
        '
        'AssetStorePreviewToolStripMenuItem1
        '
        Me.AssetStorePreviewToolStripMenuItem1.Enabled = False
        Me.AssetStorePreviewToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AssetStorePreviewToolStripMenuItem1.Name = "AssetStorePreviewToolStripMenuItem1"
        Me.AssetStorePreviewToolStripMenuItem1.Size = New System.Drawing.Size(270, 24)
        Me.AssetStorePreviewToolStripMenuItem1.Text = "Asset store preview"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(267, 6)
        '
        'LoopedAnimationKeywordsToolStripMenuItem1
        '
        Me.LoopedAnimationKeywordsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAnimationNameToolStripMenuItem1})
        Me.LoopedAnimationKeywordsToolStripMenuItem1.Enabled = False
        Me.LoopedAnimationKeywordsToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LoopedAnimationKeywordsToolStripMenuItem1.Name = "LoopedAnimationKeywordsToolStripMenuItem1"
        Me.LoopedAnimationKeywordsToolStripMenuItem1.Size = New System.Drawing.Size(270, 24)
        Me.LoopedAnimationKeywordsToolStripMenuItem1.Text = "Looped Animation Keywords"
        '
        'AddAnimationNameToolStripMenuItem1
        '
        Me.AddAnimationNameToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.AddAnimationNameToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AddAnimationNameToolStripMenuItem1.Name = "AddAnimationNameToolStripMenuItem1"
        Me.AddAnimationNameToolStripMenuItem1.Size = New System.Drawing.Size(218, 24)
        Me.AddAnimationNameToolStripMenuItem1.Text = "Add animation name"
        '
        'ContextMenuStrip_Log
        '
        Me.ContextMenuStrip_Log.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip_Log.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_Log.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.ContextMenuStrip_Log.Name = "ContextMenuStrip_Log"
        Me.ContextMenuStrip_Log.ShowImageMargin = False
        Me.ContextMenuStrip_Log.Size = New System.Drawing.Size(117, 28)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(116, 24)
        Me.ClearToolStripMenuItem.Text = "Clear Log"
        '
        'Timer_Animation
        '
        '
        'TreeView1
        '
        Me.TreeView1.AllowDrop = True
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip_TreeView
        Me.TreeView1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TreeView1.HideSelection = False
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.LineColor = System.Drawing.Color.DodgerBlue
        Me.TreeView1.Location = New System.Drawing.Point(16, 24)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(448, 408)
        Me.TreeView1.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.TreeView1, "Right-click for options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can drag & drop a directory here.")
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
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
        Me.Panel_Main.Size = New System.Drawing.Size(960, 26)
        Me.Panel_Main.TabIndex = 78
        '
        'Panel_ControlBox
        '
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Close)
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Minimize)
        Me.Panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_ControlBox.Location = New System.Drawing.Point(908, 0)
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
        Me.Label_Application_Title.Text = "Metadata Generator"
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
        'RectangleShape_Log
        '
        Me.RectangleShape_Log.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Log.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Log.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Log.CornerRadius = 3
        Me.RectangleShape_Log.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Log.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Log.Location = New System.Drawing.Point(8, 16)
        Me.RectangleShape_Log.Name = "RectangleShape_Log"
        Me.RectangleShape_Log.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Log.Size = New System.Drawing.Size(944, 112)
        '
        'RectangleShape_Metadata_Files
        '
        Me.RectangleShape_Metadata_Files.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Metadata_Files.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Metadata_Files.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Metadata_Files.CornerRadius = 3
        Me.RectangleShape_Metadata_Files.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Metadata_Files.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Metadata_Files.Location = New System.Drawing.Point(8, 16)
        Me.RectangleShape_Metadata_Files.Name = "RectangleShape_Metadata_Files"
        Me.RectangleShape_Metadata_Files.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Metadata_Files.Size = New System.Drawing.Size(464, 448)
        '
        'RectangleShape_Selected_File
        '
        Me.RectangleShape_Selected_File.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Selected_File.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Selected_File.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Selected_File.CornerRadius = 3
        Me.RectangleShape_Selected_File.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Selected_File.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Selected_File.Location = New System.Drawing.Point(8, 16)
        Me.RectangleShape_Selected_File.Name = "RectangleShape_Selected_File"
        Me.RectangleShape_Selected_File.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Selected_File.Size = New System.Drawing.Size(464, 88)
        '
        'RectangleShape_Animation
        '
        Me.RectangleShape_Animation.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Animation.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Animation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Animation.CornerRadius = 3
        Me.RectangleShape_Animation.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Animation.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Animation.Location = New System.Drawing.Point(8, 16)
        Me.RectangleShape_Animation.Name = "RectangleShape_Animation"
        Me.RectangleShape_Animation.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Animation.Size = New System.Drawing.Size(336, 336)
        '
        'RectangleShape_Selected_Directory
        '
        Me.RectangleShape_Selected_Directory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Selected_Directory.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Selected_Directory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Selected_Directory.CornerRadius = 3
        Me.RectangleShape_Selected_Directory.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Selected_Directory.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Selected_Directory.Location = New System.Drawing.Point(8, 16)
        Me.RectangleShape_Selected_Directory.Name = "RectangleShape_Selected_Directory"
        Me.RectangleShape_Selected_Directory.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Selected_Directory.Size = New System.Drawing.Size(688, 24)
        '
        'Label_Log
        '
        Me.Label_Log.AutoSize = True
        Me.Label_Log.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Log.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Log.Location = New System.Drawing.Point(0, 0)
        Me.Label_Log.Name = "Label_Log"
        Me.Label_Log.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_Log.Size = New System.Drawing.Size(36, 13)
        Me.Label_Log.TabIndex = 80
        Me.Label_Log.Text = "Log"
        '
        'Label_Selected_File
        '
        Me.Label_Selected_File.AutoSize = True
        Me.Label_Selected_File.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Selected_File.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Selected_File.Location = New System.Drawing.Point(0, 0)
        Me.Label_Selected_File.Name = "Label_Selected_File"
        Me.Label_Selected_File.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_Selected_File.Size = New System.Drawing.Size(89, 13)
        Me.Label_Selected_File.TabIndex = 81
        Me.Label_Selected_File.Text = "Selected File"
        '
        'Label_Animation
        '
        Me.Label_Animation.AutoSize = True
        Me.Label_Animation.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Animation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Animation.Location = New System.Drawing.Point(0, 0)
        Me.Label_Animation.Name = "Label_Animation"
        Me.Label_Animation.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_Animation.Size = New System.Drawing.Size(70, 13)
        Me.Label_Animation.TabIndex = 82
        Me.Label_Animation.Text = "Animation"
        '
        'Label_Metadata_Files
        '
        Me.Label_Metadata_Files.AutoSize = True
        Me.Label_Metadata_Files.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Metadata_Files.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Metadata_Files.Location = New System.Drawing.Point(0, 0)
        Me.Label_Metadata_Files.Name = "Label_Metadata_Files"
        Me.Label_Metadata_Files.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_Metadata_Files.Size = New System.Drawing.Size(98, 13)
        Me.Label_Metadata_Files.TabIndex = 83
        Me.Label_Metadata_Files.Text = "Metadata Files"
        '
        'Label_Selected_Directory
        '
        Me.Label_Selected_Directory.AutoSize = True
        Me.Label_Selected_Directory.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Selected_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Selected_Directory.Location = New System.Drawing.Point(0, 0)
        Me.Label_Selected_Directory.Name = "Label_Selected_Directory"
        Me.Label_Selected_Directory.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_Selected_Directory.Size = New System.Drawing.Size(120, 13)
        Me.Label_Selected_Directory.TabIndex = 84
        Me.Label_Selected_Directory.Text = "Selected Directory"
        '
        'Panel_Selected_Directory_Controls
        '
        Me.Panel_Selected_Directory_Controls.AllowDrop = True
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.LinkLabel_Trello)
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.Button_Reload)
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.Button_Select_Directory)
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.Label_Selected_Directory)
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.TextBox_Selected_Directory)
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.ShapeContainer2)
        Me.Panel_Selected_Directory_Controls.Location = New System.Drawing.Point(0, 64)
        Me.Panel_Selected_Directory_Controls.Name = "Panel_Selected_Directory_Controls"
        Me.Panel_Selected_Directory_Controls.Size = New System.Drawing.Size(960, 48)
        Me.Panel_Selected_Directory_Controls.TabIndex = 85
        '
        'LinkLabel_Trello
        '
        Me.LinkLabel_Trello.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LinkLabel_Trello.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Trello.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel_Trello.Location = New System.Drawing.Point(904, 16)
        Me.LinkLabel_Trello.Name = "LinkLabel_Trello"
        Me.LinkLabel_Trello.Size = New System.Drawing.Size(50, 24)
        Me.LinkLabel_Trello.TabIndex = 96
        Me.LinkLabel_Trello.TabStop = True
        Me.LinkLabel_Trello.Text = "Trello"
        Me.LinkLabel_Trello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel_Trello.VisitedLinkColor = System.Drawing.Color.DarkOrchid
        '
        'Button_Reload
        '
        Me.Button_Reload.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Reload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Reload.FlatAppearance.BorderSize = 0
        Me.Button_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Reload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reload.Location = New System.Drawing.Point(808, 16)
        Me.Button_Reload.Name = "Button_Reload"
        Me.Button_Reload.Size = New System.Drawing.Size(80, 24)
        Me.Button_Reload.TabIndex = 95
        Me.Button_Reload.Text = "Reload"
        Me.Button_Reload.UseVisualStyleBackColor = False
        '
        'Button_Select_Directory
        '
        Me.Button_Select_Directory.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Select_Directory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Select_Directory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Select_Directory.FlatAppearance.BorderSize = 0
        Me.Button_Select_Directory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Select_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Select_Directory.Location = New System.Drawing.Point(712, 16)
        Me.Button_Select_Directory.Name = "Button_Select_Directory"
        Me.Button_Select_Directory.Size = New System.Drawing.Size(80, 24)
        Me.Button_Select_Directory.TabIndex = 3
        Me.Button_Select_Directory.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Button_Select_Directory, "You can drag & drop a directory here.")
        Me.Button_Select_Directory.UseVisualStyleBackColor = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Selected_Directory})
        Me.ShapeContainer2.Size = New System.Drawing.Size(960, 48)
        Me.ShapeContainer2.TabIndex = 2
        Me.ShapeContainer2.TabStop = False
        '
        'Panel_Log
        '
        Me.Panel_Log.Controls.Add(Me.RichTextBox_Log)
        Me.Panel_Log.Controls.Add(Me.Label_Log)
        Me.Panel_Log.Controls.Add(Me.ShapeContainer3)
        Me.Panel_Log.Location = New System.Drawing.Point(0, 584)
        Me.Panel_Log.Name = "Panel_Log"
        Me.Panel_Log.Size = New System.Drawing.Size(960, 136)
        Me.Panel_Log.TabIndex = 86
        '
        'RichTextBox_Log
        '
        Me.RichTextBox_Log.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RichTextBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox_Log.ContextMenuStrip = Me.ContextMenuStrip_Log
        Me.RichTextBox_Log.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.RichTextBox_Log.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox_Log.Location = New System.Drawing.Point(16, 24)
        Me.RichTextBox_Log.Name = "RichTextBox_Log"
        Me.RichTextBox_Log.ReadOnly = True
        Me.RichTextBox_Log.Size = New System.Drawing.Size(928, 96)
        Me.RichTextBox_Log.TabIndex = 92
        Me.RichTextBox_Log.Text = ""
        Me.ToolTip1.SetToolTip(Me.RichTextBox_Log, "Right-click for options.")
        Me.RichTextBox_Log.WordWrap = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Log})
        Me.ShapeContainer3.Size = New System.Drawing.Size(960, 136)
        Me.ShapeContainer3.TabIndex = 0
        Me.ShapeContainer3.TabStop = False
        '
        'Panel_Metadata_Files
        '
        Me.Panel_Metadata_Files.Controls.Add(Me.Label_MetadataFileToGen)
        Me.Panel_Metadata_Files.Controls.Add(Me.Label_Metadata_Files)
        Me.Panel_Metadata_Files.Controls.Add(Me.TreeView1)
        Me.Panel_Metadata_Files.Controls.Add(Me.ShapeContainer4)
        Me.Panel_Metadata_Files.Location = New System.Drawing.Point(0, 112)
        Me.Panel_Metadata_Files.Name = "Panel_Metadata_Files"
        Me.Panel_Metadata_Files.Size = New System.Drawing.Size(480, 472)
        Me.Panel_Metadata_Files.TabIndex = 87
        '
        'Label_MetadataFileToGen
        '
        Me.Label_MetadataFileToGen.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label_MetadataFileToGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_MetadataFileToGen.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label_MetadataFileToGen.Location = New System.Drawing.Point(16, 440)
        Me.Label_MetadataFileToGen.Name = "Label_MetadataFileToGen"
        Me.Label_MetadataFileToGen.Size = New System.Drawing.Size(440, 16)
        Me.Label_MetadataFileToGen.TabIndex = 84
        Me.Label_MetadataFileToGen.Text = "0 Metadata files can be generated."
        Me.Label_MetadataFileToGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Metadata_Files})
        Me.ShapeContainer4.Size = New System.Drawing.Size(480, 472)
        Me.ShapeContainer4.TabIndex = 18
        Me.ShapeContainer4.TabStop = False
        '
        'Panel_Selected_File
        '
        Me.Panel_Selected_File.Controls.Add(Me.FastColoredTextBox_Selected_File)
        Me.Panel_Selected_File.Controls.Add(Me.Label_Selected_File)
        Me.Panel_Selected_File.Controls.Add(Me.ShapeContainer5)
        Me.Panel_Selected_File.Location = New System.Drawing.Point(480, 472)
        Me.Panel_Selected_File.Name = "Panel_Selected_File"
        Me.Panel_Selected_File.Size = New System.Drawing.Size(480, 112)
        Me.Panel_Selected_File.TabIndex = 88
        '
        'FastColoredTextBox_Selected_File
        '
        Me.FastColoredTextBox_Selected_File.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.FastColoredTextBox_Selected_File.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FastColoredTextBox_Selected_File.AutoScrollMinSize = New System.Drawing.Size(2, 12)
        Me.FastColoredTextBox_Selected_File.BackBrush = Nothing
        Me.FastColoredTextBox_Selected_File.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FastColoredTextBox_Selected_File.CharHeight = 12
        Me.FastColoredTextBox_Selected_File.CharWidth = 7
        Me.FastColoredTextBox_Selected_File.CommentPrefix = "'"
        Me.FastColoredTextBox_Selected_File.ContextMenuStrip = Me.ContextMenuStrip_FastColoredTextBox_Selected_File
        Me.FastColoredTextBox_Selected_File.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox_Selected_File.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox_Selected_File.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.FastColoredTextBox_Selected_File.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FastColoredTextBox_Selected_File.IsReplaceMode = False
        Me.FastColoredTextBox_Selected_File.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.FastColoredTextBox_Selected_File.Location = New System.Drawing.Point(16, 24)
        Me.FastColoredTextBox_Selected_File.Name = "FastColoredTextBox_Selected_File"
        Me.FastColoredTextBox_Selected_File.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox_Selected_File.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.FastColoredTextBox_Selected_File.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FastColoredTextBox_Selected_File.ServiceColors = CType(resources.GetObject("FastColoredTextBox_Selected_File.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.FastColoredTextBox_Selected_File.ShowLineNumbers = False
        Me.FastColoredTextBox_Selected_File.Size = New System.Drawing.Size(448, 72)
        Me.FastColoredTextBox_Selected_File.TabIndex = 91
        Me.ToolTip1.SetToolTip(Me.FastColoredTextBox_Selected_File, "Right-click for options.")
        Me.FastColoredTextBox_Selected_File.Zoom = 100
        '
        'ContextMenuStrip_FastColoredTextBox_Selected_File
        '
        Me.ContextMenuStrip_FastColoredTextBox_Selected_File.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip_FastColoredTextBox_Selected_File.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip_FastColoredTextBox_Selected_File.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FlipLoopBooleanToolStripMenuItem, Me.ToolStripSeparator5, Me.SaveToolStripMenuItem})
        Me.ContextMenuStrip_FastColoredTextBox_Selected_File.Name = "ContextMenuStrip_FastColoredTextBox_Selected_File"
        Me.ContextMenuStrip_FastColoredTextBox_Selected_File.ShowImageMargin = False
        Me.ContextMenuStrip_FastColoredTextBox_Selected_File.Size = New System.Drawing.Size(172, 58)
        '
        'FlipLoopBooleanToolStripMenuItem
        '
        Me.FlipLoopBooleanToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlipLoopBooleanToolStripMenuItem.Name = "FlipLoopBooleanToolStripMenuItem"
        Me.FlipLoopBooleanToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.FlipLoopBooleanToolStripMenuItem.Text = "Flip loop boolean"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(168, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Selected_File})
        Me.ShapeContainer5.Size = New System.Drawing.Size(480, 112)
        Me.ShapeContainer5.TabIndex = 82
        Me.ShapeContainer5.TabStop = False
        '
        'Panel_Animation
        '
        Me.Panel_Animation.Controls.Add(Me.Label_ZoomLvl)
        Me.Panel_Animation.Controls.Add(Me.Label_Frames)
        Me.Panel_Animation.Controls.Add(Me.PixelBox_Animation)
        Me.Panel_Animation.Controls.Add(Me.Label_Animation)
        Me.Panel_Animation.Controls.Add(Me.ShapeContainer6)
        Me.Panel_Animation.Location = New System.Drawing.Point(480, 112)
        Me.Panel_Animation.Name = "Panel_Animation"
        Me.Panel_Animation.Size = New System.Drawing.Size(352, 360)
        Me.Panel_Animation.TabIndex = 89
        '
        'Label_ZoomLvl
        '
        Me.Label_ZoomLvl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_ZoomLvl.AutoSize = True
        Me.Label_ZoomLvl.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label_ZoomLvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_ZoomLvl.Location = New System.Drawing.Point(272, 336)
        Me.Label_ZoomLvl.Name = "Label_ZoomLvl"
        Me.Label_ZoomLvl.Size = New System.Drawing.Size(66, 13)
        Me.Label_ZoomLvl.TabIndex = 84
        Me.Label_ZoomLvl.Text = "Zoom: 100%"
        '
        'Label_Frames
        '
        Me.Label_Frames.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Frames.AutoSize = True
        Me.Label_Frames.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label_Frames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Frames.Location = New System.Drawing.Point(16, 336)
        Me.Label_Frames.Name = "Label_Frames"
        Me.Label_Frames.Size = New System.Drawing.Size(53, 13)
        Me.Label_Frames.TabIndex = 85
        Me.Label_Frames.Text = "Frames: 0"
        '
        'PixelBox_Animation
        '
        Me.PixelBox_Animation.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PixelBox_Animation.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.PixelBox_Animation.Location = New System.Drawing.Point(16, 24)
        Me.PixelBox_Animation.Name = "PixelBox_Animation"
        Me.PixelBox_Animation.Size = New System.Drawing.Size(320, 304)
        Me.PixelBox_Animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox_Animation.TabIndex = 86
        Me.PixelBox_Animation.TabStop = False
        '
        'ShapeContainer6
        '
        Me.ShapeContainer6.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer6.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer6.Name = "ShapeContainer6"
        Me.ShapeContainer6.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Animation})
        Me.ShapeContainer6.Size = New System.Drawing.Size(352, 360)
        Me.ShapeContainer6.TabIndex = 83
        Me.ShapeContainer6.TabStop = False
        '
        'Panel_Controls
        '
        Me.Panel_Controls.Controls.Add(Me.TextBox_TimeBetweenFrames)
        Me.Panel_Controls.Controls.Add(Me.CheckBox_Loop)
        Me.Panel_Controls.Controls.Add(Me.Button_PausePlay)
        Me.Panel_Controls.Controls.Add(Me.Label_FPS)
        Me.Panel_Controls.Controls.Add(Me.Button_Replay)
        Me.Panel_Controls.Controls.Add(Me.NumericUpDown_TimeBetweenFrames)
        Me.Panel_Controls.Controls.Add(Me.PictureBox_Clock)
        Me.Panel_Controls.Controls.Add(Me.NumericUpDown_FPS)
        Me.Panel_Controls.Controls.Add(Me.ShapeContainer1)
        Me.Panel_Controls.Location = New System.Drawing.Point(832, 112)
        Me.Panel_Controls.Name = "Panel_Controls"
        Me.Panel_Controls.Size = New System.Drawing.Size(128, 360)
        Me.Panel_Controls.TabIndex = 93
        '
        'TextBox_TimeBetweenFrames
        '
        Me.TextBox_TimeBetweenFrames.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_TimeBetweenFrames.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_TimeBetweenFrames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TimeBetweenFrames.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_TimeBetweenFrames.Location = New System.Drawing.Point(48, 128)
        Me.TextBox_TimeBetweenFrames.Name = "TextBox_TimeBetweenFrames"
        Me.TextBox_TimeBetweenFrames.ReadOnly = True
        Me.TextBox_TimeBetweenFrames.Size = New System.Drawing.Size(64, 13)
        Me.TextBox_TimeBetweenFrames.TabIndex = 85
        '
        'CheckBox_Loop
        '
        Me.CheckBox_Loop.AutoSize = True
        Me.CheckBox_Loop.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CheckBox_Loop.Checked = True
        Me.CheckBox_Loop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Loop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox_Loop.Location = New System.Drawing.Point(16, 32)
        Me.CheckBox_Loop.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.CheckBox_Loop.Name = "CheckBox_Loop"
        Me.CheckBox_Loop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_Loop.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox_Loop.TabIndex = 83
        Me.CheckBox_Loop.Text = "Loop"
        Me.ToolTip1.SetToolTip(Me.CheckBox_Loop, "Hint: You can add to the ""Looped Animation Keywords.txt"" file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for auto detection" &
        " of looped animations when generating metadata.")
        Me.CheckBox_Loop.UseVisualStyleBackColor = False
        '
        'Button_PausePlay
        '
        Me.Button_PausePlay.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_PausePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_PausePlay.FlatAppearance.BorderSize = 0
        Me.Button_PausePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_PausePlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_PausePlay.Image = Global.GDev_Asset_Store_Tool.My.Resources.Resources.Pause
        Me.Button_PausePlay.Location = New System.Drawing.Point(16, 224)
        Me.Button_PausePlay.Name = "Button_PausePlay"
        Me.Button_PausePlay.Size = New System.Drawing.Size(96, 32)
        Me.Button_PausePlay.TabIndex = 81
        Me.Button_PausePlay.Text = "Pause"
        Me.Button_PausePlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_PausePlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_PausePlay.UseVisualStyleBackColor = False
        '
        'Label_FPS
        '
        Me.Label_FPS.AutoSize = True
        Me.Label_FPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label_FPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FPS.Location = New System.Drawing.Point(16, 80)
        Me.Label_FPS.Name = "Label_FPS"
        Me.Label_FPS.Size = New System.Drawing.Size(34, 13)
        Me.Label_FPS.TabIndex = 7
        Me.Label_FPS.Text = "FPS:"
        '
        'Button_Replay
        '
        Me.Button_Replay.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Replay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Replay.FlatAppearance.BorderSize = 0
        Me.Button_Replay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Replay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Replay.Image = Global.GDev_Asset_Store_Tool.My.Resources.Resources.Replay
        Me.Button_Replay.Location = New System.Drawing.Point(16, 168)
        Me.Button_Replay.Name = "Button_Replay"
        Me.Button_Replay.Size = New System.Drawing.Size(96, 32)
        Me.Button_Replay.TabIndex = 80
        Me.Button_Replay.Text = "Replay"
        Me.Button_Replay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Replay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Replay.UseVisualStyleBackColor = False
        '
        'NumericUpDown_TimeBetweenFrames
        '
        Me.NumericUpDown_TimeBetweenFrames.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_TimeBetweenFrames.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown_TimeBetweenFrames.DecimalPlaces = 4
        Me.NumericUpDown_TimeBetweenFrames.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_TimeBetweenFrames.Increment = New Decimal(New Integer() {5, 0, 0, 196608})
        Me.NumericUpDown_TimeBetweenFrames.Location = New System.Drawing.Point(48, 128)
        Me.NumericUpDown_TimeBetweenFrames.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_TimeBetweenFrames.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDown_TimeBetweenFrames.Name = "NumericUpDown_TimeBetweenFrames"
        Me.NumericUpDown_TimeBetweenFrames.ReadOnly = True
        Me.NumericUpDown_TimeBetweenFrames.Size = New System.Drawing.Size(64, 16)
        Me.NumericUpDown_TimeBetweenFrames.TabIndex = 10
        Me.NumericUpDown_TimeBetweenFrames.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_TimeBetweenFrames.Visible = False
        '
        'PictureBox_Clock
        '
        Me.PictureBox_Clock.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PictureBox_Clock.Image = Global.GDev_Asset_Store_Tool.My.Resources.Resources.Stopwatch
        Me.PictureBox_Clock.Location = New System.Drawing.Point(16, 120)
        Me.PictureBox_Clock.Name = "PictureBox_Clock"
        Me.PictureBox_Clock.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox_Clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_Clock.TabIndex = 8
        Me.PictureBox_Clock.TabStop = False
        '
        'NumericUpDown_FPS
        '
        Me.NumericUpDown_FPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.NumericUpDown_FPS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown_FPS.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown_FPS.Location = New System.Drawing.Point(56, 80)
        Me.NumericUpDown_FPS.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown_FPS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_FPS.Name = "NumericUpDown_FPS"
        Me.NumericUpDown_FPS.Size = New System.Drawing.Size(56, 16)
        Me.NumericUpDown_FPS.TabIndex = 9
        Me.NumericUpDown_FPS.Value = New Decimal(New Integer() {99, 0, 0, 0})
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(128, 360)
        Me.ShapeContainer1.TabIndex = 82
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape3.CornerRadius = 3
        Me.RectangleShape3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.Location = New System.Drawing.Point(8, 16)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Size = New System.Drawing.Size(112, 336)
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Save.FlatAppearance.BorderSize = 0
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(848, 424)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(96, 32)
        Me.Button_Save.TabIndex = 4
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Hint"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 26)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(960, 32)
        Me.MenuStrip1.TabIndex = 99
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TagsToolStripMenuItem, Me.LicenseToolStripMenuItem, Me.PackageToolStripMenuItem, Me.TemplateAssetToolStripMenuItem, Me.ClipboardAssetToolStripMenuItem, Me.FileNameValidatorToolStripMenuItem, Me.AssetStorePreviewToolStripMenuItem, Me.LoopedAnimationKeywordsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolsToolStripMenuItem.Image = Global.GDev_Asset_Store_Tool.My.Resources.Resources.Tools
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(81, 28)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'TagsToolStripMenuItem
        '
        Me.TagsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TagsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TagsToolStripMenuItem.Name = "TagsToolStripMenuItem"
        Me.TagsToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.TagsToolStripMenuItem.Text = "Tags"
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LicenseToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'PackageToolStripMenuItem
        '
        Me.PackageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PackageToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PackageToolStripMenuItem.Name = "PackageToolStripMenuItem"
        Me.PackageToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.PackageToolStripMenuItem.Text = "Package"
        '
        'TemplateAssetToolStripMenuItem
        '
        Me.TemplateAssetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TemplateAssetToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TemplateAssetToolStripMenuItem.Name = "TemplateAssetToolStripMenuItem"
        Me.TemplateAssetToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.TemplateAssetToolStripMenuItem.Text = "Template Asset"
        '
        'ClipboardAssetToolStripMenuItem
        '
        Me.ClipboardAssetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClipboardAssetToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ClipboardAssetToolStripMenuItem.Name = "ClipboardAssetToolStripMenuItem"
        Me.ClipboardAssetToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.ClipboardAssetToolStripMenuItem.Text = "Clipboard Asset"
        '
        'FileNameValidatorToolStripMenuItem
        '
        Me.FileNameValidatorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.FileNameValidatorToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FileNameValidatorToolStripMenuItem.Name = "FileNameValidatorToolStripMenuItem"
        Me.FileNameValidatorToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.FileNameValidatorToolStripMenuItem.Text = "File Name Validator"
        '
        'AssetStorePreviewToolStripMenuItem
        '
        Me.AssetStorePreviewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.AssetStorePreviewToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AssetStorePreviewToolStripMenuItem.Name = "AssetStorePreviewToolStripMenuItem"
        Me.AssetStorePreviewToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.AssetStorePreviewToolStripMenuItem.Text = "Asset Store Preview"
        '
        'LoopedAnimationKeywordsToolStripMenuItem
        '
        Me.LoopedAnimationKeywordsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LoopedAnimationKeywordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem, Me.ImportToolStripMenuItem})
        Me.LoopedAnimationKeywordsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LoopedAnimationKeywordsToolStripMenuItem.Name = "LoopedAnimationKeywordsToolStripMenuItem"
        Me.LoopedAnimationKeywordsToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.LoopedAnimationKeywordsToolStripMenuItem.Text = "Looped Animation Keywords"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ReloadToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ImportToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'MetadataGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 720)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel_Selected_File)
        Me.Controls.Add(Me.Panel_Controls)
        Me.Controls.Add(Me.Panel_Animation)
        Me.Controls.Add(Me.Panel_Metadata_Files)
        Me.Controls.Add(Me.Panel_Log)
        Me.Controls.Add(Me.Panel_Selected_Directory_Controls)
        Me.Controls.Add(Me.Panel_Main)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MetadataGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Metadata Generator"
        Me.ContextMenuStrip_TreeView.ResumeLayout(False)
        Me.ContextMenuStrip_Log.ResumeLayout(False)
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_ControlBox.ResumeLayout(False)
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Selected_Directory_Controls.ResumeLayout(False)
        Me.Panel_Selected_Directory_Controls.PerformLayout()
        Me.Panel_Log.ResumeLayout(False)
        Me.Panel_Log.PerformLayout()
        Me.Panel_Metadata_Files.ResumeLayout(False)
        Me.Panel_Metadata_Files.PerformLayout()
        Me.Panel_Selected_File.ResumeLayout(False)
        Me.Panel_Selected_File.PerformLayout()
        CType(Me.FastColoredTextBox_Selected_File, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_FastColoredTextBox_Selected_File.ResumeLayout(False)
        Me.Panel_Animation.ResumeLayout(False)
        Me.Panel_Animation.PerformLayout()
        CType(Me.PixelBox_Animation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Controls.ResumeLayout(False)
        Me.Panel_Controls.PerformLayout()
        CType(Me.NumericUpDown_TimeBetweenFrames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Clock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_FPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_Selected_Directory As TextBox
    Friend WithEvents Button_Select_Directory As Button
    Friend WithEvents ContextMenuStrip_TreeView As ContextMenuStrip
    Friend WithEvents ContextMenuStrip_Log As ContextMenuStrip
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateMetadataFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FolderBrowserDialog_Selected_Directory As FolderBrowserDialog
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegenerateSelectedFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents XFramesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents Timer_Animation As Timer
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_ControlBox As Panel
    Friend WithEvents PictureBox_Close As PictureBox
    Friend WithEvents PictureBox_Minimize As PictureBox
    Friend WithEvents Label_Application_Title As Label
    Friend WithEvents PictureBox_AppIcon As PictureBox
    Friend WithEvents RectangleShape_Selected_Directory As RectangleShape
    Friend WithEvents Label_Log As Label
    Friend WithEvents Label_Selected_File As Label
    Friend WithEvents Label_Animation As Label
    Friend WithEvents Label_Metadata_Files As Label
    Friend WithEvents Label_Selected_Directory As Label
    Friend WithEvents RectangleShape_Log As RectangleShape
    Friend WithEvents RectangleShape_Metadata_Files As RectangleShape
    Friend WithEvents RectangleShape_Selected_File As RectangleShape
    Friend WithEvents RectangleShape_Animation As RectangleShape
    Friend WithEvents Panel_Selected_Directory_Controls As Panel
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents Panel_Log As Panel
    Friend WithEvents ShapeContainer3 As ShapeContainer
    Friend WithEvents Panel_Metadata_Files As Panel
    Friend WithEvents ShapeContainer4 As ShapeContainer
    Friend WithEvents Panel_Selected_File As Panel
    Friend WithEvents ShapeContainer5 As ShapeContainer
    Friend WithEvents Panel_Animation As Panel
    Friend WithEvents ShapeContainer6 As ShapeContainer
    Friend WithEvents FastColoredTextBox_Selected_File As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents RichTextBox_Log As RichTextBox
    Friend WithEvents Label_ZoomLvl As Label
    Friend WithEvents ContextMenuStrip_FastColoredTextBox_Selected_File As ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipLoopBooleanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_Controls As Panel
    Friend WithEvents CheckBox_Loop As CheckBox
    Friend WithEvents Button_Save As Button
    Friend WithEvents Button_PausePlay As Button
    Friend WithEvents Label_FPS As Label
    Friend WithEvents Button_Replay As Button
    Friend WithEvents NumericUpDown_TimeBetweenFrames As NumericUpDown
    Friend WithEvents PictureBox_Clock As PictureBox
    Friend WithEvents NumericUpDown_FPS As NumericUpDown
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape3 As RectangleShape
    Friend WithEvents TextBox_TimeBetweenFrames As TextBox
    Friend WithEvents Label_MetadataFileToGen As Label
    Friend WithEvents RegenerateMetadataFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label_Frames As Label
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents LinkLabel_Trello As LinkLabel
    Friend WithEvents PixelBox_Animation As PixelBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LoopedAnimationKeywordsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents Button_Reload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TagsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileNameValidatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoopedAnimationKeywordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClipboardAssetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemplateAssetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssetStorePreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssetStorePreviewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddAnimationNameToolStripMenuItem1 As ToolStripMenuItem
End Class
