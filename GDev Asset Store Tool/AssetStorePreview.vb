
Public Class AssetStorePreview
    Dim RectangleShape_SelectedDirectory_Padding As Integer = 0
    Dim TextBox_Selected_Directory_Padding As Integer = 0
    Dim resizeLoadlock As Boolean = True
    Private Sub AssetStorePreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RectangleShape_SelectedDirectory_Padding = Panel_Selected_Directory.Width - RectangleShape_Selected_Directory.Width
        TextBox_Selected_Directory_Padding = RectangleShape_Selected_Directory.Width - TextBox_Selected_Directory.Width
        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip2.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        If My.Settings.AssetPannelSize = 98 Then
            Small_ToolStripMenuItem.Checked = True
        ElseIf My.Settings.AssetPannelSize = 128 Then
            Medium_ToolStripMenuItem.Checked = True
        ElseIf My.Settings.AssetPannelSize = 150 Then
            MediumLarge_ToolStripMenuItem.Checked = True
        ElseIf My.Settings.AssetPannelSize = 182 Then
            Large_ToolStripMenuItem.Checked = True
        ElseIf My.Settings.AssetPannelSize = 229 Then
            ExtraLarge_ToolStripMenuItem.Checked = True
        Else
            Medium_ToolStripMenuItem.Checked = True
        End If

        resizeLoadlock = False
    End Sub
    'LoadAssetsFromSelectedDirectory
    Public Sub LoadAssetsFromSelectedDirectory(AssetDirectory As String)
        TextBox_Selected_Directory.Text = AssetDirectory
        FlowLayoutPanel1.Controls.Clear()
        Label_AssetCount.Text = "Assets"
        Label_AssetCount.Update()
        Label_Status.Text = "Loading Files..."
        Label_Status.Refresh()
        Dim ContainsIgnoredDirectories As Boolean = False
        Dim PreviousAssetName As String = ""
        Dim PreviousAssetPath As String = ""
        Dim AssetCount As Integer = 0
        Dim TempColor As Color = Color.WhiteSmoke
        FlowLayoutPanel1.Visible = False
        For Each PNG_file As String In Directory.GetFiles(AssetDirectory, "*.png", SearchOption.AllDirectories)
            If Not PNG_file.ToLower.Contains("!zip") And Not PNG_file.ToLower.Contains("!remove") And Not PNG_file.ToLower.Contains("!notused") And Not PNG_file.ToLower.Contains("!not used") Then

                Dim TempFileName As String = Path.GetFileNameWithoutExtension(PNG_file)
                TempColor = Color.WhiteSmoke

                If TempFileName.StartsWith("tiled_") Or TempFileName.StartsWith("Tiled_") Then
                    TempFileName = TempFileName.Substring(TempFileName.IndexOf("_") + 1)
                    TempColor = Color.MediumTurquoise
                End If

                If TempFileName.StartsWith("9patch_") Or TempFileName.StartsWith("9Patch_") Then
                    TempFileName = TempFileName.Substring(7)
                    TempFileName = TempFileName.Substring(0, TempFileName.LastIndexOf("_") + 1)
                    TempColor = Color.PaleGoldenrod
                End If

                If TempFileName.Contains("_") Then
                    TempFileName = Microsoft.VisualBasic.Left(TempFileName, TempFileName.IndexOf("_"))
                    If Not TempFileName = PreviousAssetName Then
                        CreateNewPanel(PNG_file, TempFileName, TempColor)
                        PreviousAssetName = TempFileName
                        PreviousAssetPath = PNG_file
                        AssetCount += 1
                    ElseIf Not Path.GetDirectoryName(PNG_file) = Path.GetDirectoryName(PreviousAssetPath) Then
                        CreateNewPanel(PNG_file, TempFileName, TempColor)
                        PreviousAssetName = TempFileName
                        PreviousAssetPath = PNG_file
                        AssetCount += 1
                    End If
                Else
                    CreateNewPanel(PNG_file, TempFileName, TempColor)
                    PreviousAssetName = TempFileName
                    PreviousAssetPath = PNG_file
                    AssetCount += 1
                End If
            Else
                ContainsIgnoredDirectories = True
            End If
        Next

        If ContainsIgnoredDirectories = True Then
            Label_Status.Text = "Load Completed, Contains Ignored Directories!"
        Else
            Label_Status.Text = "Load Completed."
        End If

        Label_AssetCount.Text = AssetCount & " Assets"

        FlowLayoutPanel1.Visible = True
    End Sub
    'CreateNewPanel
    Private Sub CreateNewPanel(imagePath As String, assetObjectText As String, textColor As Color)
        'Panel
        Dim AssetPanel = New Panel
        AssetPanel.Size = New Size(My.Settings.AssetPannelSize, My.Settings.AssetPannelSize)
        AssetPanel.BackColor = Color.FromArgb(46, 49, 54)
        AssetPanel.Name = "AssetPanel1"

        'Label
        Dim AssetLabel = New Label
        AssetLabel.AutoEllipsis = True
        AssetLabel.TextAlign = ContentAlignment.MiddleCenter
        AssetLabel.Dock = DockStyle.Bottom
        AssetLabel.Text = assetObjectText
        AssetLabel.ForeColor = textColor
        AssetLabel.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        AssetLabel.BackColor = Color.FromArgb(28, 30, 34)
        ToolTip1.SetToolTip(AssetLabel, imagePath)

        'PixelBox
        Dim AssetPixelBox = New PixelBox
        AssetPixelBox.Dock = DockStyle.Fill
        AssetPixelBox.Image = SafeImageFromFile(imagePath)
        AssetPixelBox.SizeMode = PictureBoxSizeMode.Zoom
        AssetPixelBox.Name = "PixelBox1"
        AssetPixelBox.Cursor = Cursors.Hand
        AssetPixelBox.Text = imagePath
        AssetPixelBox.ContextMenuStrip = ContextMenuStrip1

        'Add AssetLabel and AssetPixelBox to AssetPanel
        AssetPanel.Controls.Add(AssetPixelBox)
        AssetPanel.Controls.Add(AssetLabel)

        'Add AssetPanel to FlowLayoutPanel1
        FlowLayoutPanel1.Controls.Add(AssetPanel)

        AddHandler AssetPixelBox.MouseClick, AddressOf PixelBox1_MouseClick
    End Sub
    'AssetStorePreview - Resize
    Private Sub AssetStorePreview_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If resizeLoadlock = False Then
            RectangleShape_Selected_Directory.Width = Panel_Selected_Directory.Width - RectangleShape_SelectedDirectory_Padding
            TextBox_Selected_Directory.Width = RectangleShape_Selected_Directory.Width - TextBox_Selected_Directory_Padding
        End If
    End Sub
    'Button_Select_Directory - Click
    Private Sub Button_Select_Directory_Click(sender As Object, e As EventArgs) Handles Button_Select_Directory.Click
        If FolderBrowserDialog_Selected_Directory.ShowDialog() = DialogResult.OK Then
            LoadAssetsFromSelectedDirectory(FolderBrowserDialog_Selected_Directory.SelectedPath)
        End If
    End Sub
    'Button_Reload - Click
    Private Sub Button_Reload_Click(sender As Object, e As EventArgs) Handles Button_Reload.Click
        If Directory.Exists(TextBox_Selected_Directory.Text) Then
            LoadAssetsFromSelectedDirectory(TextBox_Selected_Directory.Text)
        End If
    End Sub
    'AssetStorePreview - DragEnter
    Private Sub AssetStorePreview_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Directory.Exists(Folders(0)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'AssetStorePreview - DragDrop
    Private Sub AssetStorePreview_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If Folders.Length <> 0 Then
            Try
                FolderBrowserDialog_Selected_Directory.SelectedPath = Folders(0)
                LoadAssetsFromSelectedDirectory(FolderBrowserDialog_Selected_Directory.SelectedPath)
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'AssetPanel1 - Click
    Private Sub PixelBox1_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Try
                AssetInfo.LoadAsset(DirectCast(sender, PixelBox).Text.ToString)
                AssetInfo.Show()
                AssetInfo.BringToFront()
            Catch ex As Exception
                If MessageBox.Show("An error has occurred while reading this asset, Run the file name validator in this directory?", "AssetInfo Error", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
                    Dim New_FileNameValidator_Window As New FileNameValidator
                    New_FileNameValidator_Window.Show()
                    New_FileNameValidator_Window.BringToFront()
                    New_FileNameValidator_Window.FolderBrowserDialog_Selected_Directory.SelectedPath = FolderBrowserDialog_Selected_Directory.SelectedPath '+ "\" + TreeView1.SelectedNode.FullPath
                    New_FileNameValidator_Window.LoadFiles()
                End If
            End Try
        End If
    End Sub
    'OpenDirectoryToolStripMenuItem - Click
    Private Sub OpenDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDirectoryToolStripMenuItem.Click
        If File.Exists(ContextMenuStrip1.SourceControl.Text) Then
            Process.Start("explorer.exe", "/select," & ContextMenuStrip1.SourceControl.Text)
        End If
    End Sub
    'OpenFileToolStripMenuItem - Click
    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        If File.Exists(ContextMenuStrip1.SourceControl.Text) Then
            Process.Start(ContextMenuStrip1.SourceControl.Text)
        End If
    End Sub
    'SafeImageFromFile()
    Public Shared Function SafeImageFromFile(path As String) As Image
        Dim bytes = File.ReadAllBytes(path)
        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms)
            Return img
        End Using
    End Function
    'TextBox_Selected_Directory - KeyPress
    Private Sub TextBox_Selected_Directory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Selected_Directory.KeyPress
        If e.KeyChar = Chr(13) And TextBox_Selected_Directory.Text.Length > 0 Then
            e.Handled = True
            If Directory.Exists(TextBox_Selected_Directory.Text) Then
                FolderBrowserDialog_Selected_Directory.SelectedPath = TextBox_Selected_Directory.Text
                LoadAssetsFromSelectedDirectory(FolderBrowserDialog_Selected_Directory.SelectedPath)
            Else
                MsgBox("Directory does Not exists.", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    'Button1 - Click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContextMenuStrip2.Show(Button1, 4, 4)
    End Sub
    'ResizePanels (sizeInt)
    Private Sub ResizePanels(sizeInt As Integer)
        My.Settings.AssetPannelSize = sizeInt

        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.Visible = False
        For Each oObj As Control In FlowLayoutPanel1.Controls
            Dim pPanel As Panel = CType(oObj, Panel)
            pPanel.Width = sizeInt
            pPanel.Height = sizeInt
        Next
        FlowLayoutPanel1.Visible = True
        FlowLayoutPanel1.ResumeLayout()
    End Sub
    'Small_ToolStripMenuItem - Click
    Private Sub Small_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Small_ToolStripMenuItem.Click
        UnCheckAllSizes()
        Small_ToolStripMenuItem.Checked = True
        ResizePanels(98)
    End Sub
    'Medium_ToolStripMenuItem - Click
    Private Sub Medium_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Medium_ToolStripMenuItem.Click
        UnCheckAllSizes()
        Medium_ToolStripMenuItem.Checked = True
        ResizePanels(128)
    End Sub
    'MediumLarge_ToolStripMenuItem - Click
    Private Sub MediumLarge_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumLarge_ToolStripMenuItem.Click
        UnCheckAllSizes()
        MediumLarge_ToolStripMenuItem.Checked = True
        ResizePanels(150)
    End Sub
    'Large_ToolStripMenuItem - Click
    Private Sub Large_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Large_ToolStripMenuItem.Click
        UnCheckAllSizes()
        Large_ToolStripMenuItem.Checked = True
        ResizePanels(182)
    End Sub
    'ExtraLarge_ToolStripMenuItem - Click
    Private Sub ExtraLarge_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtraLarge_ToolStripMenuItem.Click
        UnCheckAllSizes()
        ExtraLarge_ToolStripMenuItem.Checked = True
        ResizePanels(229)
    End Sub
    'UnCheckAllSizes
    Private Sub UnCheckAllSizes()
        Small_ToolStripMenuItem.Checked = False
        Medium_ToolStripMenuItem.Checked = False
        MediumLarge_ToolStripMenuItem.Checked = False
        Large_ToolStripMenuItem.Checked = False
        ExtraLarge_ToolStripMenuItem.Checked = False
    End Sub
End Class