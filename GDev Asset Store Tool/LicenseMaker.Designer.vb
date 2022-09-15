<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LicenseMaker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LicenseMaker))
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel_ControlBox = New System.Windows.Forms.Panel()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Minimize = New System.Windows.Forms.PictureBox()
        Me.Label_Application_Title = New System.Windows.Forms.Label()
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TextBox_Artist = New System.Windows.Forms.TextBox()
        Me.TextBox_ArtistLink = New System.Windows.Forms.TextBox()
        Me.ComboBox_License = New System.Windows.Forms.ComboBox()
        Me.Label_License = New System.Windows.Forms.Label()
        Me.Label_Artist = New System.Windows.Forms.Label()
        Me.Label_ArtistLink = New System.Windows.Forms.Label()
        Me.SaveFileDialog_License = New System.Windows.Forms.SaveFileDialog()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_Open = New System.Windows.Forms.Button()
        Me.OpenFileDialog_License = New System.Windows.Forms.OpenFileDialog()
        Me.LinkLabel_Wiki_Info = New System.Windows.Forms.LinkLabel()
        Me.Panel_Main.SuspendLayout()
        Me.Panel_ControlBox.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel_Main.Size = New System.Drawing.Size(346, 26)
        Me.Panel_Main.TabIndex = 96
        '
        'Panel_ControlBox
        '
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Close)
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Minimize)
        Me.Panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_ControlBox.Location = New System.Drawing.Point(294, 0)
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
        Me.Label_Application_Title.Size = New System.Drawing.Size(130, 26)
        Me.Label_Application_Title.TabIndex = 2
        Me.Label_Application_Title.Text = "License Maker"
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
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape2.CornerRadius = 3
        Me.RectangleShape2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.Location = New System.Drawing.Point(8, 112)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Size = New System.Drawing.Size(328, 24)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(346, 242)
        Me.ShapeContainer1.TabIndex = 97
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
        Me.RectangleShape1.Location = New System.Drawing.Point(8, 168)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(328, 24)
        '
        'TextBox_Artist
        '
        Me.TextBox_Artist.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_Artist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Artist.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_Artist.Location = New System.Drawing.Point(16, 120)
        Me.TextBox_Artist.Name = "TextBox_Artist"
        Me.TextBox_Artist.Size = New System.Drawing.Size(312, 13)
        Me.TextBox_Artist.TabIndex = 98
        '
        'TextBox_ArtistLink
        '
        Me.TextBox_ArtistLink.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_ArtistLink.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ArtistLink.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_ArtistLink.Location = New System.Drawing.Point(16, 176)
        Me.TextBox_ArtistLink.Name = "TextBox_ArtistLink"
        Me.TextBox_ArtistLink.Size = New System.Drawing.Size(312, 13)
        Me.TextBox_ArtistLink.TabIndex = 99
        '
        'ComboBox_License
        '
        Me.ComboBox_License.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ComboBox_License.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_License.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_License.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox_License.FormattingEnabled = True
        Me.ComboBox_License.Items.AddRange(New Object() {"CC0", "CC-BY 3.0", "CC-BY 4.0", "CC BY-SA 3.0", "CC BY-SA 4.0", "Apache 2.0", "Open Font License", "Trademark of GDevelop Ltd"})
        Me.ComboBox_License.Location = New System.Drawing.Point(8, 56)
        Me.ComboBox_License.Name = "ComboBox_License"
        Me.ComboBox_License.Size = New System.Drawing.Size(248, 24)
        Me.ComboBox_License.TabIndex = 100
        '
        'Label_License
        '
        Me.Label_License.AutoSize = True
        Me.Label_License.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_License.Location = New System.Drawing.Point(8, 40)
        Me.Label_License.Name = "Label_License"
        Me.Label_License.Size = New System.Drawing.Size(51, 13)
        Me.Label_License.TabIndex = 101
        Me.Label_License.Text = "License"
        '
        'Label_Artist
        '
        Me.Label_Artist.AutoSize = True
        Me.Label_Artist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Artist.Location = New System.Drawing.Point(8, 96)
        Me.Label_Artist.Name = "Label_Artist"
        Me.Label_Artist.Size = New System.Drawing.Size(36, 13)
        Me.Label_Artist.TabIndex = 102
        Me.Label_Artist.Text = "Artist"
        '
        'Label_ArtistLink
        '
        Me.Label_ArtistLink.AutoSize = True
        Me.Label_ArtistLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_ArtistLink.Location = New System.Drawing.Point(8, 152)
        Me.Label_ArtistLink.Name = "Label_ArtistLink"
        Me.Label_ArtistLink.Size = New System.Drawing.Size(64, 13)
        Me.Label_ArtistLink.TabIndex = 103
        Me.Label_ArtistLink.Text = "Artist Link"
        '
        'SaveFileDialog_License
        '
        Me.SaveFileDialog_License.FileName = "license.txt"
        Me.SaveFileDialog_License.Filter = "Text files (*.txt)|*.txt"
        '
        'Button_Save
        '
        Me.Button_Save.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Save.FlatAppearance.BorderSize = 0
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(240, 208)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(96, 24)
        Me.Button_Save.TabIndex = 104
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Hint"
        '
        'Button_Open
        '
        Me.Button_Open.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Open.FlatAppearance.BorderSize = 0
        Me.Button_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Open.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Open.Location = New System.Drawing.Point(8, 208)
        Me.Button_Open.Name = "Button_Open"
        Me.Button_Open.Size = New System.Drawing.Size(96, 24)
        Me.Button_Open.TabIndex = 106
        Me.Button_Open.Text = "Open"
        Me.ToolTip1.SetToolTip(Me.Button_Open, "You can drag & drop a license file here.")
        Me.Button_Open.UseVisualStyleBackColor = False
        '
        'OpenFileDialog_License
        '
        Me.OpenFileDialog_License.Filter = "Text files (*.txt)|*.txt"
        '
        'LinkLabel_Wiki_Info
        '
        Me.LinkLabel_Wiki_Info.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_Wiki_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Wiki_Info.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel_Wiki_Info.Location = New System.Drawing.Point(272, 56)
        Me.LinkLabel_Wiki_Info.Name = "LinkLabel_Wiki_Info"
        Me.LinkLabel_Wiki_Info.Size = New System.Drawing.Size(65, 24)
        Me.LinkLabel_Wiki_Info.TabIndex = 107
        Me.LinkLabel_Wiki_Info.TabStop = True
        Me.LinkLabel_Wiki_Info.Text = "Wiki Info"
        Me.LinkLabel_Wiki_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel_Wiki_Info.VisitedLinkColor = System.Drawing.Color.DarkOrchid
        '
        'LicenseMaker
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(346, 242)
        Me.Controls.Add(Me.ComboBox_License)
        Me.Controls.Add(Me.LinkLabel_Wiki_Info)
        Me.Controls.Add(Me.Button_Open)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Label_ArtistLink)
        Me.Controls.Add(Me.Label_Artist)
        Me.Controls.Add(Me.Label_License)
        Me.Controls.Add(Me.TextBox_ArtistLink)
        Me.Controls.Add(Me.TextBox_Artist)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LicenseMaker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "License Maker"
        Me.ToolTip1.SetToolTip(Me, "You can drag & drop a license file here.")
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_ControlBox.ResumeLayout(False)
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_ControlBox As Panel
    Friend WithEvents PictureBox_Close As PictureBox
    Friend WithEvents PictureBox_Minimize As PictureBox
    Friend WithEvents Label_Application_Title As Label
    Friend WithEvents PictureBox_AppIcon As PictureBox
    Friend WithEvents RectangleShape2 As RectangleShape
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents TextBox_Artist As TextBox
    Friend WithEvents TextBox_ArtistLink As TextBox
    Friend WithEvents ComboBox_License As ComboBox
    Friend WithEvents Label_License As Label
    Friend WithEvents Label_Artist As Label
    Friend WithEvents Label_ArtistLink As Label
    Friend WithEvents Button_Save As Button
    Friend WithEvents SaveFileDialog_License As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button_Open As Button
    Friend WithEvents OpenFileDialog_License As OpenFileDialog
    Friend WithEvents LinkLabel_Wiki_Info As LinkLabel
End Class
