<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssetInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssetInfo))
        Me.Panel_PreviewImage = New System.Windows.Forms.Panel()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_Image = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label_FrameCount = New System.Windows.Forms.Label()
        Me.ComboBox_Animations = New System.Windows.Forms.ComboBox()
        Me.Label_TimeBetweenFrames = New System.Windows.Forms.Label()
        Me.Label_AnimationsList = New System.Windows.Forms.Label()
        Me.Button_PreviousAnimation = New System.Windows.Forms.Button()
        Me.Button_NextAnimation = New System.Windows.Forms.Button()
        Me.Label_Loop = New System.Windows.Forms.Label()
        Me.Label_ObjectName = New System.Windows.Forms.Label()
        Me.Button_OpenDirectory = New System.Windows.Forms.Button()
        Me.Timer_Animation = New System.Windows.Forms.Timer(Me.components)
        Me.PixelBox_PreviewImage = New GDev_Asset_Store_Tool.PixelBox()
        Me.Panel_PreviewImage.SuspendLayout()
        CType(Me.PixelBox_PreviewImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_PreviewImage
        '
        Me.Panel_PreviewImage.AllowDrop = True
        Me.Panel_PreviewImage.Controls.Add(Me.PixelBox_PreviewImage)
        Me.Panel_PreviewImage.Controls.Add(Me.ShapeContainer3)
        Me.Panel_PreviewImage.Location = New System.Drawing.Point(0, 8)
        Me.Panel_PreviewImage.Name = "Panel_PreviewImage"
        Me.Panel_PreviewImage.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Panel_PreviewImage.Size = New System.Drawing.Size(288, 288)
        Me.Panel_PreviewImage.TabIndex = 119
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 8)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Image})
        Me.ShapeContainer3.Size = New System.Drawing.Size(288, 280)
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
        Me.RectangleShape_Image.Location = New System.Drawing.Point(8, 0)
        Me.RectangleShape_Image.Name = "RectangleShape_Image"
        Me.RectangleShape_Image.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Image.Size = New System.Drawing.Size(272, 272)
        '
        'Label_FrameCount
        '
        Me.Label_FrameCount.AutoSize = True
        Me.Label_FrameCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FrameCount.Location = New System.Drawing.Point(296, 72)
        Me.Label_FrameCount.Name = "Label_FrameCount"
        Me.Label_FrameCount.Size = New System.Drawing.Size(86, 13)
        Me.Label_FrameCount.TabIndex = 120
        Me.Label_FrameCount.Text = "Frame Count: "
        '
        'ComboBox_Animations
        '
        Me.ComboBox_Animations.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox_Animations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Animations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Animations.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox_Animations.FormattingEnabled = True
        Me.ComboBox_Animations.Location = New System.Drawing.Point(16, 304)
        Me.ComboBox_Animations.Name = "ComboBox_Animations"
        Me.ComboBox_Animations.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox_Animations.TabIndex = 131
        '
        'Label_TimeBetweenFrames
        '
        Me.Label_TimeBetweenFrames.AutoSize = True
        Me.Label_TimeBetweenFrames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TimeBetweenFrames.Location = New System.Drawing.Point(296, 96)
        Me.Label_TimeBetweenFrames.Name = "Label_TimeBetweenFrames"
        Me.Label_TimeBetweenFrames.Size = New System.Drawing.Size(139, 13)
        Me.Label_TimeBetweenFrames.TabIndex = 132
        Me.Label_TimeBetweenFrames.Text = "Time Between Frames: "
        '
        'Label_AnimationsList
        '
        Me.Label_AnimationsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AnimationsList.Location = New System.Drawing.Point(296, 120)
        Me.Label_AnimationsList.Name = "Label_AnimationsList"
        Me.Label_AnimationsList.Size = New System.Drawing.Size(240, 168)
        Me.Label_AnimationsList.TabIndex = 133
        Me.Label_AnimationsList.Text = "Contains # Animations: "
        '
        'Button_PreviousAnimation
        '
        Me.Button_PreviousAnimation.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_PreviousAnimation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_PreviousAnimation.FlatAppearance.BorderSize = 0
        Me.Button_PreviousAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_PreviousAnimation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_PreviousAnimation.Location = New System.Drawing.Point(288, 304)
        Me.Button_PreviousAnimation.Name = "Button_PreviousAnimation"
        Me.Button_PreviousAnimation.Size = New System.Drawing.Size(32, 24)
        Me.Button_PreviousAnimation.TabIndex = 135
        Me.Button_PreviousAnimation.Text = "<"
        Me.Button_PreviousAnimation.UseVisualStyleBackColor = False
        '
        'Button_NextAnimation
        '
        Me.Button_NextAnimation.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_NextAnimation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_NextAnimation.FlatAppearance.BorderSize = 0
        Me.Button_NextAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_NextAnimation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_NextAnimation.Location = New System.Drawing.Point(336, 304)
        Me.Button_NextAnimation.Name = "Button_NextAnimation"
        Me.Button_NextAnimation.Size = New System.Drawing.Size(32, 24)
        Me.Button_NextAnimation.TabIndex = 136
        Me.Button_NextAnimation.Text = ">"
        Me.Button_NextAnimation.UseVisualStyleBackColor = False
        '
        'Label_Loop
        '
        Me.Label_Loop.AutoSize = True
        Me.Label_Loop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Loop.Location = New System.Drawing.Point(296, 48)
        Me.Label_Loop.Name = "Label_Loop"
        Me.Label_Loop.Size = New System.Drawing.Size(43, 13)
        Me.Label_Loop.TabIndex = 137
        Me.Label_Loop.Text = "Loop: "
        '
        'Label_ObjectName
        '
        Me.Label_ObjectName.AutoSize = True
        Me.Label_ObjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ObjectName.Location = New System.Drawing.Point(296, 24)
        Me.Label_ObjectName.Name = "Label_ObjectName"
        Me.Label_ObjectName.Size = New System.Drawing.Size(88, 13)
        Me.Label_ObjectName.TabIndex = 138
        Me.Label_ObjectName.Text = "Object Name: "
        '
        'Button_OpenDirectory
        '
        Me.Button_OpenDirectory.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_OpenDirectory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_OpenDirectory.FlatAppearance.BorderSize = 0
        Me.Button_OpenDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_OpenDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_OpenDirectory.Location = New System.Drawing.Point(400, 304)
        Me.Button_OpenDirectory.Name = "Button_OpenDirectory"
        Me.Button_OpenDirectory.Size = New System.Drawing.Size(136, 24)
        Me.Button_OpenDirectory.TabIndex = 139
        Me.Button_OpenDirectory.Text = "Open Directory"
        Me.Button_OpenDirectory.UseVisualStyleBackColor = False
        '
        'Timer_Animation
        '
        '
        'PixelBox_PreviewImage
        '
        Me.PixelBox_PreviewImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PixelBox_PreviewImage.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.PixelBox_PreviewImage.Location = New System.Drawing.Point(16, 16)
        Me.PixelBox_PreviewImage.Name = "PixelBox_PreviewImage"
        Me.PixelBox_PreviewImage.Size = New System.Drawing.Size(256, 256)
        Me.PixelBox_PreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox_PreviewImage.TabIndex = 103
        Me.PixelBox_PreviewImage.TabStop = False
        '
        'AssetInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(543, 340)
        Me.Controls.Add(Me.Button_OpenDirectory)
        Me.Controls.Add(Me.Label_ObjectName)
        Me.Controls.Add(Me.Label_Loop)
        Me.Controls.Add(Me.Button_NextAnimation)
        Me.Controls.Add(Me.Button_PreviousAnimation)
        Me.Controls.Add(Me.Label_AnimationsList)
        Me.Controls.Add(Me.Label_TimeBetweenFrames)
        Me.Controls.Add(Me.ComboBox_Animations)
        Me.Controls.Add(Me.Label_FrameCount)
        Me.Controls.Add(Me.Panel_PreviewImage)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AssetInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asset Information"
        Me.Panel_PreviewImage.ResumeLayout(False)
        CType(Me.PixelBox_PreviewImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel_PreviewImage As Panel
    Friend WithEvents PixelBox_PreviewImage As PixelBox
    Friend WithEvents ShapeContainer3 As ShapeContainer
    Friend WithEvents RectangleShape_Image As RectangleShape
    Friend WithEvents Label_FrameCount As Label
    Friend WithEvents ComboBox_Animations As ComboBox
    Friend WithEvents Label_TimeBetweenFrames As Label
    Friend WithEvents Label_AnimationsList As Label
    Friend WithEvents Button_PreviousAnimation As Button
    Friend WithEvents Button_NextAnimation As Button
    Friend WithEvents Label_Loop As Label
    Friend WithEvents Label_ObjectName As Label
    Friend WithEvents Button_OpenDirectory As Button
    Friend WithEvents Timer_Animation As Timer
End Class
