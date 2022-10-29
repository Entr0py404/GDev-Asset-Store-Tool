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
        Me.PixelBox_PackageThumbnail = New GDev_Asset_Store_Tool.PixelBox()
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
        Me.Label_Tag = New System.Windows.Forms.Label()
        Me.TextBox_Tag = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SaveFileDialog_PackageThumbnail = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PixelBox_PackageThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_PackageThumbnail.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.Panel_ControlBox.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_PackageThumbnail.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Hint"
        '
        'PixelBox_PackageThumbnail
        '
        Me.PixelBox_PackageThumbnail.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PixelBox_PackageThumbnail.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.PixelBox_PackageThumbnail.ContextMenuStrip = Me.ContextMenuStrip_PackageThumbnail
        Me.PixelBox_PackageThumbnail.Location = New System.Drawing.Point(16, 24)
        Me.PixelBox_PackageThumbnail.Name = "PixelBox_PackageThumbnail"
        Me.PixelBox_PackageThumbnail.Size = New System.Drawing.Size(320, 180)
        Me.PixelBox_PackageThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox_PackageThumbnail.TabIndex = 103
        Me.PixelBox_PackageThumbnail.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PixelBox_PackageThumbnail, "Right-click for options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can drag & drop a image here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Saved image will be " &
        "scaled to a 16:9 aspect ratio.")
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
        Me.Panel_Main.Size = New System.Drawing.Size(354, 26)
        Me.Panel_Main.TabIndex = 80
        '
        'Panel_ControlBox
        '
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Close)
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Minimize)
        Me.Panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_ControlBox.Location = New System.Drawing.Point(302, 0)
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
        Me.Button_Save.Location = New System.Drawing.Point(248, 368)
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
        Me.Panel_PackageThumbnail.Size = New System.Drawing.Size(352, 216)
        Me.Panel_PackageThumbnail.TabIndex = 94
        '
        'Label_PackageThumbnail
        '
        Me.Label_PackageThumbnail.AutoSize = True
        Me.Label_PackageThumbnail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_PackageThumbnail.Location = New System.Drawing.Point(0, 0)
        Me.Label_PackageThumbnail.Name = "Label_PackageThumbnail"
        Me.Label_PackageThumbnail.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label_PackageThumbnail.Size = New System.Drawing.Size(127, 13)
        Me.Label_PackageThumbnail.TabIndex = 103
        Me.Label_PackageThumbnail.Text = "Package Thumbnail"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 8)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Image})
        Me.ShapeContainer3.Size = New System.Drawing.Size(352, 208)
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
        Me.RectangleShape_Image.Size = New System.Drawing.Size(336, 192)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label_PackageName)
        Me.Panel3.Controls.Add(Me.TextBox_PackageName)
        Me.Panel3.Controls.Add(Me.ShapeContainer4)
        Me.Panel3.Location = New System.Drawing.Point(0, 248)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(352, 56)
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
        Me.TextBox_PackageName.Size = New System.Drawing.Size(320, 13)
        Me.TextBox_PackageName.TabIndex = 8
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer4.Size = New System.Drawing.Size(352, 56)
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
        Me.RectangleShape2.Size = New System.Drawing.Size(336, 24)
        '
        'SaveFileDialog_PackJson
        '
        Me.SaveFileDialog_PackJson.FileName = "PACK.json"
        Me.SaveFileDialog_PackJson.Filter = "Json files (*.json)|*.json"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_Tag)
        Me.Panel1.Controls.Add(Me.TextBox_Tag)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(0, 304)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 56)
        Me.Panel1.TabIndex = 96
        '
        'Label_Tag
        '
        Me.Label_Tag.AutoSize = True
        Me.Label_Tag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Tag.Location = New System.Drawing.Point(8, 8)
        Me.Label_Tag.Name = "Label_Tag"
        Me.Label_Tag.Size = New System.Drawing.Size(29, 13)
        Me.Label_Tag.TabIndex = 83
        Me.Label_Tag.Text = "Tag"
        '
        'TextBox_Tag
        '
        Me.TextBox_Tag.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_Tag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Tag.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_Tag.Location = New System.Drawing.Point(16, 32)
        Me.TextBox_Tag.Name = "TextBox_Tag"
        Me.TextBox_Tag.Size = New System.Drawing.Size(320, 13)
        Me.TextBox_Tag.TabIndex = 8
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(352, 56)
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
        Me.RectangleShape1.Size = New System.Drawing.Size(336, 24)
        '
        'SaveFileDialog_PackageThumbnail
        '
        Me.SaveFileDialog_PackageThumbnail.FileName = "thumbnail"
        Me.SaveFileDialog_PackageThumbnail.Filter = "Png Image (*.png)|*.png"
        '
        'PackageMaker
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 403)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel_PackageThumbnail)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Panel_Main)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PackageMaker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Package Maker"
        CType(Me.PixelBox_PackageThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label_PackageThumbnail As Label
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
    Friend WithEvents Label_Tag As Label
    Friend WithEvents TextBox_Tag As TextBox
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents ContextMenuStrip_PackageThumbnail As ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog_PackageThumbnail As SaveFileDialog
End Class
