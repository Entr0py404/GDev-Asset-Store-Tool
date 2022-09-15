<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssetStorePreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssetStorePreview))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_Reload = New System.Windows.Forms.Button()
        Me.Button_Select_Directory = New System.Windows.Forms.Button()
        Me.Panel_Selected_Directory_Controls = New System.Windows.Forms.Panel()
        Me.Panel_Selected_Directory = New System.Windows.Forms.Panel()
        Me.Label_Selected_Directory = New System.Windows.Forms.Label()
        Me.TextBox_Selected_Directory = New System.Windows.Forms.TextBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape_Selected_Directory = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_AssetCount = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog_Selected_Directory = New System.Windows.Forms.FolderBrowserDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_Selected_Directory_Controls.SuspendLayout()
        Me.Panel_Selected_Directory.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 96)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(826, 465)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Button_Reload
        '
        Me.Button_Reload.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Reload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Reload.FlatAppearance.BorderSize = 0
        Me.Button_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Reload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reload.Location = New System.Drawing.Point(88, 32)
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
        Me.Button_Select_Directory.Location = New System.Drawing.Point(8, 32)
        Me.Button_Select_Directory.Name = "Button_Select_Directory"
        Me.Button_Select_Directory.Size = New System.Drawing.Size(64, 24)
        Me.Button_Select_Directory.TabIndex = 3
        Me.Button_Select_Directory.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Button_Select_Directory, "You can drag & drop a directory here.")
        Me.Button_Select_Directory.UseVisualStyleBackColor = False
        '
        'Panel_Selected_Directory_Controls
        '
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.Panel_Selected_Directory)
        Me.Panel_Selected_Directory_Controls.Controls.Add(Me.Panel1)
        Me.Panel_Selected_Directory_Controls.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Selected_Directory_Controls.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Selected_Directory_Controls.Name = "Panel_Selected_Directory_Controls"
        Me.Panel_Selected_Directory_Controls.Size = New System.Drawing.Size(826, 64)
        Me.Panel_Selected_Directory_Controls.TabIndex = 99
        '
        'Panel_Selected_Directory
        '
        Me.Panel_Selected_Directory.Controls.Add(Me.Label_Selected_Directory)
        Me.Panel_Selected_Directory.Controls.Add(Me.TextBox_Selected_Directory)
        Me.Panel_Selected_Directory.Controls.Add(Me.ShapeContainer3)
        Me.Panel_Selected_Directory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Selected_Directory.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Selected_Directory.Name = "Panel_Selected_Directory"
        Me.Panel_Selected_Directory.Size = New System.Drawing.Size(648, 64)
        Me.Panel_Selected_Directory.TabIndex = 14
        '
        'Label_Selected_Directory
        '
        Me.Label_Selected_Directory.AutoSize = True
        Me.Label_Selected_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Selected_Directory.Location = New System.Drawing.Point(8, 16)
        Me.Label_Selected_Directory.Name = "Label_Selected_Directory"
        Me.Label_Selected_Directory.Size = New System.Drawing.Size(112, 13)
        Me.Label_Selected_Directory.TabIndex = 6
        Me.Label_Selected_Directory.Text = "Selected Directory"
        '
        'TextBox_Selected_Directory
        '
        Me.TextBox_Selected_Directory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_Selected_Directory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Selected_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Selected_Directory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_Selected_Directory.Location = New System.Drawing.Point(16, 40)
        Me.TextBox_Selected_Directory.Name = "TextBox_Selected_Directory"
        Me.TextBox_Selected_Directory.ReadOnly = True
        Me.TextBox_Selected_Directory.Size = New System.Drawing.Size(616, 14)
        Me.TextBox_Selected_Directory.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TextBox_Selected_Directory, "You can drag & drop a directory here.")
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape_Selected_Directory})
        Me.ShapeContainer3.Size = New System.Drawing.Size(648, 64)
        Me.ShapeContainer3.TabIndex = 1
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape_Selected_Directory
        '
        Me.RectangleShape_Selected_Directory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape_Selected_Directory.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape_Selected_Directory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape_Selected_Directory.CornerRadius = 3
        Me.RectangleShape_Selected_Directory.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Selected_Directory.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape_Selected_Directory.Location = New System.Drawing.Point(8, 32)
        Me.RectangleShape_Selected_Directory.Name = "RectangleShape_Selected_Directory"
        Me.RectangleShape_Selected_Directory.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape_Selected_Directory.Size = New System.Drawing.Size(632, 24)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_Select_Directory)
        Me.Panel1.Controls.Add(Me.Button_Reload)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(648, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 64)
        Me.Panel1.TabIndex = 14
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Hint"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label_AssetCount)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(826, 32)
        Me.Panel2.TabIndex = 101
        '
        'Label_AssetCount
        '
        Me.Label_AssetCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label_AssetCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_AssetCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AssetCount.Location = New System.Drawing.Point(0, 0)
        Me.Label_AssetCount.Name = "Label_AssetCount"
        Me.Label_AssetCount.Size = New System.Drawing.Size(826, 32)
        Me.Label_AssetCount.TabIndex = 101
        Me.Label_AssetCount.Text = "0 Assets"
        Me.Label_AssetCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDirectoryToolStripMenuItem, Me.OpenFileToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 74)
        '
        'OpenDirectoryToolStripMenuItem
        '
        Me.OpenDirectoryToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.OpenDirectoryToolStripMenuItem.Name = "OpenDirectoryToolStripMenuItem"
        Me.OpenDirectoryToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.OpenDirectoryToolStripMenuItem.Text = "Open Directory"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'AssetStorePreview
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(826, 561)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Selected_Directory_Controls)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AssetStorePreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asset Store Preview"
        Me.Panel_Selected_Directory_Controls.ResumeLayout(False)
        Me.Panel_Selected_Directory.ResumeLayout(False)
        Me.Panel_Selected_Directory.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button_Reload As Button
    Friend WithEvents Button_Select_Directory As Button
    Friend WithEvents Panel_Selected_Directory_Controls As Panel
    Friend WithEvents Panel_Selected_Directory As Panel
    Friend WithEvents Label_Selected_Directory As Label
    Friend WithEvents TextBox_Selected_Directory As TextBox
    Friend WithEvents ShapeContainer3 As ShapeContainer
    Friend WithEvents RectangleShape_Selected_Directory As RectangleShape
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_AssetCount As Label
    Friend WithEvents FolderBrowserDialog_Selected_Directory As FolderBrowserDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
End Class
