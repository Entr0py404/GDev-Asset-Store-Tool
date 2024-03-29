﻿
Public Class AssetStorePreview
    Dim RectangleShape_SelectedDirectory_Padding As Integer = 0
    Dim TextBox_Selected_Directory_Padding As Integer = 0
    Dim ResizeLoadLock As Boolean = True

    ' AssetStorePreview - Load
    Private Sub AssetStorePreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Store the padding values based on the initial sizes of controls
        RectangleShape_SelectedDirectory_Padding = Panel_Selected_Directory.Width - RectangleShape_Selected_Directory.Width
        TextBox_Selected_Directory_Padding = RectangleShape_Selected_Directory.Width - TextBox_Selected_Directory.Width

        ' Set the custom renderers for context menus
        ContextMenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip2.Renderer = New ToolStripProfessionalRenderer(New ColorTable())

        ' Set the checked state of the menu items based on the saved settings
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

        ResizeLoadLock = False ' Unlock resizing
    End Sub

    ' LoadAssetsFromSelectedDirectory
    Public Sub LoadAssetsFromSelectedDirectory(AssetDirectory As String)
        ' Update the selected directory text box
        TextBox_Selected_Directory.Text = AssetDirectory

        ' Clear the existing asset panels and reset labels
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

        ' Iterate over PNG files in the specified directory and its subdirectories
        For Each PNG_file As String In Directory.GetFiles(AssetDirectory, "*.png", SearchOption.AllDirectories)
            ' Exclude files with specific keywords in their paths
            If Not PNG_file.ToLower.Contains("!zip") And Not PNG_file.ToLower.Contains("!remove") And Not PNG_file.ToLower.Contains("!notused") And Not PNG_file.ToLower.Contains("!not used") Then

                Dim TempFileName As String = Path.GetFileNameWithoutExtension(PNG_file)
                TempColor = Color.WhiteSmoke

                ' Check if the asset starts with "tiled_" or "Tiled_" and modify the file name and color accordingly
                If TempFileName.StartsWith("tiled_") Or TempFileName.StartsWith("Tiled_") Then
                    TempFileName = TempFileName.Substring(TempFileName.IndexOf("_") + 1)
                    TempColor = Color.MediumTurquoise
                End If

                ' Check if the asset starts with "9patch_" or "9Patch_" and modify the file name and color accordingly
                If TempFileName.StartsWith("9patch_") Or TempFileName.StartsWith("9Patch_") Then
                    TempFileName = TempFileName.Substring(7)
                    TempFileName = TempFileName.Substring(0, TempFileName.LastIndexOf("_") + 1)
                    TempColor = Color.PaleGoldenrod
                End If

                If TempFileName.Contains("_") Then
                    TempFileName = Microsoft.VisualBasic.Left(TempFileName, TempFileName.IndexOf("_"))

                    ' Check if the asset name is different from the previous asset name
                    If Not TempFileName = PreviousAssetName Then
                        CreateNewPanel(PNG_file, TempFileName, TempColor)
                        PreviousAssetName = TempFileName
                        PreviousAssetPath = PNG_file
                        AssetCount += 1
                        ' Check if the asset is in a different directory from the previous asset
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

        ' Update the status label based on whether ignored directories were found
        If ContainsIgnoredDirectories = True Then
            Label_Status.Text = "Load Completed, Contains Ignored Directories!"
        Else
            Label_Status.Text = "Load Completed."
        End If

        ' Update the asset count label
        Label_AssetCount.Text = AssetCount & " Assets"

        FlowLayoutPanel1.Visible = True
    End Sub

    ' CreateNewPanel
    Private Sub CreateNewPanel(imagePath As String, assetObjectText As String, textColor As Color)
        ' Create a new panel to hold the asset
        Dim AssetPanel = New Panel
        AssetPanel.Size = New Size(My.Settings.AssetPannelSize, My.Settings.AssetPannelSize)
        AssetPanel.BackColor = Color.FromArgb(46, 49, 54)
        AssetPanel.Name = "AssetPanel1"

        ' Create a label to display the asset object text
        Dim AssetLabel = New Label
        AssetLabel.AutoEllipsis = True
        AssetLabel.TextAlign = ContentAlignment.MiddleCenter
        AssetLabel.Dock = DockStyle.Bottom
        AssetLabel.Text = assetObjectText
        AssetLabel.ForeColor = textColor
        AssetLabel.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        AssetLabel.BackColor = Color.FromArgb(28, 30, 34)
        ToolTip1.SetToolTip(AssetLabel, imagePath)

        ' Create a PixelBox to display the asset image
        Dim AssetPixelBox = New PixelBox
        AssetPixelBox.Dock = DockStyle.Fill
        AssetPixelBox.Image = SafeImageFromFile(imagePath)
        AssetPixelBox.SizeMode = PictureBoxSizeMode.Zoom
        AssetPixelBox.Name = "PixelBox1"
        AssetPixelBox.Cursor = Cursors.Hand
        AssetPixelBox.Text = imagePath
        AssetPixelBox.ContextMenuStrip = ContextMenuStrip1

        ' Add the PixelBox and Label to the AssetPanel
        AssetPanel.Controls.Add(AssetPixelBox)
        AssetPanel.Controls.Add(AssetLabel)

        ' Add the AssetPanel to the FlowLayoutPanel
        FlowLayoutPanel1.Controls.Add(AssetPanel)

        ' Add a MouseClick event handler for the AssetPixelBox
        AddHandler AssetPixelBox.MouseClick, AddressOf PixelBox1_MouseClick
    End Sub

    ' AssetStorePreview - Resize
    Private Sub AssetStorePreview_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Adjust the width of the RectangleShape_Selected_Directory and TextBox_Selected_Directory controls
        ' based on the new width of the Panel_Selected_Directory and padding
        If ResizeLoadLock = False Then
            RectangleShape_Selected_Directory.Width = Panel_Selected_Directory.Width - RectangleShape_SelectedDirectory_Padding
            TextBox_Selected_Directory.Width = RectangleShape_Selected_Directory.Width - TextBox_Selected_Directory_Padding
        End If
    End Sub

    ' Button_Select_Directory - Click
    Private Sub Button_Select_Directory_Click(sender As Object, e As EventArgs) Handles Button_Select_Directory.Click
        ' Show the folder browser dialog to select a directory
        If FolderBrowserDialog_Selected_Directory.ShowDialog() = DialogResult.OK Then
            ' Load assets from the selected directory
            LoadAssetsFromSelectedDirectory(FolderBrowserDialog_Selected_Directory.SelectedPath)
        End If
    End Sub

    ' Button_Reload - Click
    Private Sub Button_Reload_Click(sender As Object, e As EventArgs) Handles Button_Reload.Click
        ' Check if the selected directory exists
        If Directory.Exists(TextBox_Selected_Directory.Text) Then
            ' Call the function to load assets from the selected directory
            LoadAssetsFromSelectedDirectory(TextBox_Selected_Directory.Text)
        End If
    End Sub

    ' AssetStorePreview - DragEnter
    Private Sub AssetStorePreview_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        ' Check if the dragged data contains file drop information
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            ' Retrieve the array of folder paths from the dropped data
            Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

            ' Check if the first folder path exists as a directory
            If Directory.Exists(Folders(0)) Then
                ' Set the drag-and-drop effect to copy since a valid directory is being dragged
                e.Effect = DragDropEffects.Copy
            Else
                ' Set the drag-and-drop effect to none since the dragged item is not a valid directory
                e.Effect = DragDropEffects.None
            End If
        Else
            ' Set the drag-and-drop effect to none since the dragged item does not contain file drop information
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' AssetStorePreview - DragDrop
    Private Sub AssetStorePreview_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        ' Retrieve the array of folder paths from the dropped data
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        ' Check if any folders were dropped
        If Folders.Length <> 0 Then
            Try
                ' Set the selected path in the folder browser dialog to the first dropped folder
                FolderBrowserDialog_Selected_Directory.SelectedPath = Folders(0)

                ' Load assets from the selected directory
                LoadAssetsFromSelectedDirectory(FolderBrowserDialog_Selected_Directory.SelectedPath)
            Catch ex As Exception
                ' Display an error message if there was a problem opening the file
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' AssetPanel1 - Click
    Private Sub PixelBox1_MouseClick(sender As Object, e As MouseEventArgs)
        ' Check if the left mouse button was clicked
        If e.Button = MouseButtons.Left Then
            Try
                ' Load asset information based on the clicked PixelBox
                AssetInfo.LoadAsset(DirectCast(sender, PixelBox).Text.ToString)

                ' Show the AssetInfo form
                AssetInfo.Show()

                ' Bring the AssetInfo form to the front
                AssetInfo.BringToFront()
            Catch ex As Exception
                ' If an error occurs while reading the asset, prompt the user to run the file name validator
                If MessageBox.Show("An error has occurred while reading this asset, Run the file name validator in this directory?", "AssetInfo Error", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
                    ' Create a new FileNameValidator form
                    Dim New_FileNameValidator_Window As New FileNameValidator

                    ' Show the FileNameValidator form
                    New_FileNameValidator_Window.Show()

                    ' Bring the FileNameValidator form to the front
                    New_FileNameValidator_Window.BringToFront()

                    ' Set the selected path in the folder browser dialog to the current directory
                    New_FileNameValidator_Window.FolderBrowserDialog_Selected_Directory.SelectedPath = FolderBrowserDialog_Selected_Directory.SelectedPath '+ "\" + TreeView1.SelectedNode.FullPath

                    ' Load files in the directory using the FileNameValidator form
                    New_FileNameValidator_Window.LoadFiles()
                End If
            End Try
        End If
    End Sub

    ' OpenDirectoryToolStripMenuItem - Click
    Private Sub OpenDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDirectoryToolStripMenuItem.Click
        ' Check if the file exists
        If File.Exists(ContextMenuStrip1.SourceControl.Text) Then
            ' Open the directory containing the file in File Explorer
            Process.Start("explorer.exe", "/select," & ContextMenuStrip1.SourceControl.Text)
        End If
    End Sub

    ' OpenFileToolStripMenuItem - Click
    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        ' Check if the file exists
        If File.Exists(ContextMenuStrip1.SourceControl.Text) Then
            ' Open the file using the default program associated with its file type
            Process.Start(ContextMenuStrip1.SourceControl.Text)
        End If
    End Sub

    ' SafeImageFromFile()
    Public Shared Function SafeImageFromFile(path As String) As Image
        ' Read the file contents into a byte array
        Dim bytes = File.ReadAllBytes(path)

        ' Create a memory stream and load the image from the byte array
        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms)
            Return img
        End Using
    End Function

    ' TextBox_Selected_Directory - KeyPress
    Private Sub TextBox_Selected_Directory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Selected_Directory.KeyPress
        ' Check if the Enter key was pressed and the text box is not empty
        If e.KeyChar = Chr(13) And TextBox_Selected_Directory.Text.Length > 0 Then
            e.Handled = True

            ' Check if the directory exists
            If Directory.Exists(TextBox_Selected_Directory.Text) Then
                ' Set the selected path in the folder browser dialog
                FolderBrowserDialog_Selected_Directory.SelectedPath = TextBox_Selected_Directory.Text

                ' Load assets from the selected directory
                LoadAssetsFromSelectedDirectory(FolderBrowserDialog_Selected_Directory.SelectedPath)
            Else
                MsgBox("Directory does Not exists.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    ' Button1 - Click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Show the context menu strip near Button1 with specific offset
        ContextMenuStrip2.Show(Button1, 4, 4)
    End Sub

    ' ResizePanels (sizeInt)
    Private Sub ResizePanels(sizeInt As Integer)
        ' Update the panel size setting
        My.Settings.AssetPannelSize = sizeInt

        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.Visible = False

        ' Resize each panel in the flow layout panel
        For Each oObj As Control In FlowLayoutPanel1.Controls
            Dim pPanel As Panel = CType(oObj, Panel)
            pPanel.Width = sizeInt
            pPanel.Height = sizeInt
        Next

        FlowLayoutPanel1.Visible = True
        FlowLayoutPanel1.ResumeLayout()
    End Sub

    ' Small_ToolStripMenuItem - Click
    Private Sub Small_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Small_ToolStripMenuItem.Click
        ' Uncheck all size options
        UnCheckAllSizes()

        ' Check Small_ToolStripMenuItem
        Small_ToolStripMenuItem.Checked = True

        ' Resize panels to 98 pixels
        ResizePanels(98)
    End Sub

    ' Medium_ToolStripMenuItem - Click
    Private Sub Medium_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Medium_ToolStripMenuItem.Click
        ' Uncheck all size options
        UnCheckAllSizes()

        ' Check Medium_ToolStripMenuItem
        Medium_ToolStripMenuItem.Checked = True

        ' Resize panels to 128 pixels
        ResizePanels(128)
    End Sub

    ' MediumLarge_ToolStripMenuItem - Click
    Private Sub MediumLarge_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumLarge_ToolStripMenuItem.Click
        ' Uncheck all size options
        UnCheckAllSizes()

        ' Check MediumLarge_ToolStripMenuItem
        MediumLarge_ToolStripMenuItem.Checked = True

        ' Resize panels to 150 pixels
        ResizePanels(150)
    End Sub

    ' Large_ToolStripMenuItem - Click
    Private Sub Large_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Large_ToolStripMenuItem.Click
        ' Uncheck all size options
        UnCheckAllSizes()

        ' Check Large_ToolStripMenuItem
        Large_ToolStripMenuItem.Checked = True

        ' Resize panels to 182 pixels
        ResizePanels(182)
    End Sub

    ' ExtraLarge_ToolStripMenuItem - Click
    Private Sub ExtraLarge_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtraLarge_ToolStripMenuItem.Click
        ' Uncheck all size options
        UnCheckAllSizes()

        ' Check ExtraLarge_ToolStripMenuItem
        ExtraLarge_ToolStripMenuItem.Checked = True

        ' Resize panels to 229 pixels
        ResizePanels(229)
    End Sub

    ' UnCheckAllSizes
    Private Sub UnCheckAllSizes()
        ' Uncheck all size options
        Small_ToolStripMenuItem.Checked = False
        Medium_ToolStripMenuItem.Checked = False
        MediumLarge_ToolStripMenuItem.Checked = False
        Large_ToolStripMenuItem.Checked = False
        ExtraLarge_ToolStripMenuItem.Checked = False
    End Sub

    Private Sub FlowLayoutPanel1_Scroll(sender As Object, e As ScrollEventArgs) Handles FlowLayoutPanel1.Scroll
        FlowLayoutPanel1.Update()
    End Sub
End Class