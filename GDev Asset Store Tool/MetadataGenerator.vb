Imports FastColoredTextBoxNS

Public Class MetadataGenerator
    Dim AnimationFiles As New List(Of String)()
    Dim AnimationLoopCounter As Integer = -1
    Dim ZoomCounter As Integer = 100
    Dim isPaused As Boolean = False
    ReadOnly Font_MSS As New Font(New FontFamily("Microsoft Sans Serif"), 8, FontStyle.Bold)
    Dim LoopedAnimationKeywords As String() = {"idle", "idling", "walk", "walking", "run", "running", "swim", "swimming", "loop", "looping", "movement", "spinning", "rippling", "flowing", "climb", "climbing", "fly", "flying", "up", "down", "left", "right", "walk up", "walk down", "walk left", "walk right", "idle up", "idle down", "idle left", "idle right"} 'These strings will no longer be used unless the file is missing
    ReadOnly regexValidWords As New Regex("^[a-zA-Z0-9 ()_&.-]*$") '("\|!#$%&/()=?»«@£§€{}.-;'<>,")
    ReadOnly regexInvalidWords As New Regex("\s{2,}|_\s|\s_|__") '(  )(_ ) (_ ) (__)

    Private key As New TextStyle(Brushes.MediumAquamarine, Nothing, FontStyle.Regular)
    Private str As New TextStyle(Brushes.PaleGoldenrod, Nothing, FontStyle.Regular)
    Private boo As New TextStyle(Brushes.MediumSlateBlue, Nothing, FontStyle.Regular)
    Private num As New TextStyle(Brushes.DeepPink, Nothing, FontStyle.Regular)
    Private nul As New TextStyle(Brushes.DarkGray, Nothing, FontStyle.Regular)

    ' MetadataGenerator - Load
    Private Sub MetadataGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add images to the image list
        ImageList1.Images.Add("Folder", My.Resources.Folder) '0: 
        ImageList1.Images.Add("Metadata", My.Resources.Metadata) '1: 
        ImageList1.Images.Add("SelectionArrow", My.Resources.SelectionArrow) '2: 
        TreeView1.SelectedImageIndex = 2

        ' Format the time between frames value and update the text box
        Dim tBF_Str As String = CStr(Math.Round(NumericUpDown_TimeBetweenFrames.Value, 4))
        tBF_Str = tBF_Str.TrimEnd(CChar("0"))
        tBF_Str = tBF_Str.TrimEnd(CChar("."))
        TextBox_TimeBetweenFrames.Text = tBF_Str


        Label_MetadataFileToGen.Text = "" ' Clear the metadata file label

        ' Check if the "Looped Animation Keywords.txt" file exists
        If File.Exists(Application.StartupPath & "\Looped Animation Keywords.txt") Then
            ' Load the contents of the file into the LoopedAnimationKeywords array
            LoopedAnimationKeywords = File.ReadAllLines(Application.StartupPath & "\Looped Animation Keywords.txt").ToArray
        Else
            ' Display a message box indicating that the file is not found and will be regenerated
            MsgBox("File not found: Looped Animation Keywords.txt" & vbNewLine & "This file will be regenerated from a internal list.", MsgBoxStyle.Information)

            ' Regenerate the needed file by writing the contents of the LoopedAnimationKeywords array
            File.WriteAllLines(Application.StartupPath & "\Looped Animation Keywords.txt", LoopedAnimationKeywords)
        End If

        ' Set custom renderers for the menu strip and context menus
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_FastColoredTextBox_Selected_File.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_Log.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_TreeView.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub

    ' TextBox_Selected_Directory - KeyPress
    Private Sub TextBox_Selected_Directory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Selected_Directory.KeyPress
        ' Check if the Enter key is pressed and the text box is not empty
        If e.KeyChar = Chr(13) And TextBox_Selected_Directory.Text.Length > 0 Then
            e.Handled = True

            ' Check if the entered directory exists
            If Directory.Exists(TextBox_Selected_Directory.Text) Then
                ' Set the selected path of the FolderBrowserDialog to the entered directory
                FolderBrowserDialog_Selected_Directory.SelectedPath = TextBox_Selected_Directory.Text

                ' Load the directory contents
                Load_Directory()
            Else
                ' Display a message box indicating that the directory does not exist
                MsgBox("Directory does not exists.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    ' Button_Select_Directory - Click
    Private Sub Button_Select_Directory_Click(sender As Object, e As EventArgs) Handles Button_Select_Directory.Click
        ' Show the FolderBrowserDialog to select a directory
        If FolderBrowserDialog_Selected_Directory.ShowDialog() = DialogResult.OK Then
            ' Set the selected directory path to the TextBox_Selected_Directory
            TextBox_Selected_Directory.Text = FolderBrowserDialog_Selected_Directory.SelectedPath

            ' Load the directory contents
            Load_Directory()
        End If
    End Sub

    ' TreeView1 - DragDrop
    Private Sub TreeView1_DragDrop(sender As Object, e As DragEventArgs) Handles TreeView1.DragDrop
        ' Retrieve the paths of the dropped folders/files
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        ' Check if any folders/files were dropped
        If Folders.Length <> 0 Then
            Try
                ' Set the selected path to the first dropped folder/file
                FolderBrowserDialog_Selected_Directory.SelectedPath = Folders(0)
                TextBox_Selected_Directory.Text = Folders(0)

                ' Load the directory contents
                Load_Directory()
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' TreeView1 - DragEnter
    Private Sub TreeView1_DragEnter(sender As Object, e As DragEventArgs) Handles TreeView1.DragEnter
        ' Retrieve the paths of the dropped folders/files
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        ' Check if the dropped data is in the FileDrop format and the first item is a valid directory
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Directory.Exists(Folders(0)) Then
            ' Set the drag effect to Copy since it is a valid directory
            e.Effect = DragDropEffects.Copy
        Else
            ' Set the drag effect to None since it is not a valid directory
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' NumericUpDown_FPS - ValueChanged
    Private Sub NumericUpDown_FPS_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_FPS.ValueChanged
        ' Check if the NumericUpDown control has focus to avoid recursive triggering
        If NumericUpDown_FPS.Focused Then
            ' Calculate the time between frames based on the new FPS value
            NumericUpDown_TimeBetweenFrames.Value = 1 / NumericUpDown_FPS.Value

            ' Format the time between frames value as a string without trailing zeros
            Dim tBF_Str As String = CStr(Math.Round(NumericUpDown_TimeBetweenFrames.Value, 4))
            tBF_Str = tBF_Str.TrimEnd(CChar("0"))
            tBF_Str = tBF_Str.TrimEnd(CChar("."))

            ' Update the TextBox with the formatted time between frames value
            TextBox_TimeBetweenFrames.Text = tBF_Str

            ' Update the Timer interval for animation based on the new time between frames value
            Timer_Animation.Interval = CInt(NumericUpDown_TimeBetweenFrames.Value * 1000)
        End If
    End Sub

    ' Button_Replay - Click
    Private Sub Button_Replay_Click(sender As Object, e As EventArgs) Handles Button_Replay.Click
        ' Reset the AnimationLoopCounter to -1 to restart the animation from the beginning
        AnimationLoopCounter = -1

        ' Enable the Timer_Animation to start the animation
        Timer_Animation.Enabled = True

        ' Set the isPaused flag to False indicating that the animation is not paused
        isPaused = False

        ' Update the Button_PausePlay text and image to indicate "Pause"
        Button_PausePlay.Text = "Pause"
        Button_PausePlay.Image = My.Resources.Pause
    End Sub

    ' Button_PausePlay - Click
    Private Sub Button_PausePlay_Click(sender As Object, e As EventArgs) Handles Button_PausePlay.Click
        If isPaused = True Then
            ' If the animation is currently paused

            ' Set isPaused flag to False to resume the animation
            isPaused = False

            ' Update the Button_PausePlay text to indicate "Pause"
            Button_PausePlay.Text = "Pause"

            If CheckBox_Loop.Checked Then
                ' If the Loop checkbox is checked, enable the Timer_Animation to resume looping the animation
                Timer_Animation.Enabled = True
            End If

            ' Update the Button_PausePlay image to the "Pause" icon
            Button_PausePlay.Image = My.Resources.Pause
        Else
            ' If the animation is currently playing

            ' Set isPaused flag to True to pause the animation
            isPaused = True

            ' Update the Button_PausePlay text to indicate "Play"
            Button_PausePlay.Text = "Play"

            ' Disable the Timer_Animation to pause the animation
            Timer_Animation.Enabled = False

            ' Update the Button_PausePlay image to the "Play" icon
            Button_PausePlay.Image = My.Resources.Play
        End If
    End Sub

    ' Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If TreeView1.Nodes.Count > 0 Then
            If TreeView1.SelectedNode.Text.EndsWith(".json") And FastColoredTextBox_Selected_File.Text.Length > 0 Then
                'Dim TempDirectoryString As String = FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + TreeView1.SelectedNode.FullPath
                Dim SelectedItem_FilePath As String = FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + TreeView1.SelectedNode.FullPath

                'Build json string
                Dim sb As New StringBuilder
                Dim sw As New StringWriter(sb)
                Dim flt As Single = Single.Parse(TextBox_TimeBetweenFrames.Text)
                Dim writer As JsonWriter = New JsonTextWriter(sw) With {
                .Formatting = Formatting.Indented
            }
                writer.WriteStartObject()
                writer.WritePropertyName("timeBetweenFrames")
                writer.WriteValue(flt)
                writer.WritePropertyName("loop")
                writer.WriteValue(CheckBox_Loop.Checked)
                writer.WriteEndObject()

                'Write to file
                My.Computer.FileSystem.WriteAllText(SelectedItem_FilePath, sb.ToString, False)

                'Update FastColoredTextBox_Selected_File Text
                FastColoredTextBox_Selected_File.Text = sb.ToString

                'Reload animation timer value
                Dim JSONFile As JObject = JObject.Parse(FastColoredTextBox_Selected_File.Text)
                Dim tBF As Decimal = CDec(JSONFile.SelectToken("timeBetweenFrames"))
                Timer_Animation.Interval = CInt(tBF * 1000) 'This will cause a crash if 0

                AppendToLog("File Saved: ", Color.MediumSpringGreen, False)
                AppendToLog(Path.GetFileName(SelectedItem_FilePath), Color.LightSkyBlue, True)
            End If
        End If
    End Sub

    ' CheckBox_Loop - CheckedChanged
    Private Sub CheckBox_Loop_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Loop.CheckedChanged
        If CheckBox_Loop.Checked Then
            Timer_Animation.Enabled = True
        Else
            Timer_Animation.Enabled = False
        End If
    End Sub

    ' Panel_Selected_Directory_Controls - DragEnter
    Private Sub Panel_Selected_Directory_Controls_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_Selected_Directory_Controls.DragEnter
        ' Retrieve the list of folders being dragged
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        If e.Data.GetDataPresent(DataFormats.FileDrop) And Directory.Exists(Folders(0)) Then
            ' If the drag data contains file/folder information and the first folder exists

            ' Set the drag effect to Copy to indicate that dropping the data will copy it
            e.Effect = DragDropEffects.Copy
        Else
            ' If the drag data does not contain file/folder information or the first folder does not exist

            ' Set the drag effect to None to indicate that dropping the data is not allowed
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Panel_Selected_Directory_Controls - DragDrop
    Private Sub Panel_Selected_Directory_Controls_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_Selected_Directory_Controls.DragDrop
        ' Retrieve the list of folders being dropped
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        If Folders.Length <> 0 Then
            ' If at least one folder is being dropped

            Try
                ' Set the selected path in the FolderBrowserDialog to the first folder
                FolderBrowserDialog_Selected_Directory.SelectedPath = Folders(0)

                ' Set the text of the TextBox_Selected_Directory to the selected folder path
                TextBox_Selected_Directory.Text = Folders(0)

                ' Load the directory and its contents
                Load_Directory()
            Catch ex As Exception
                ' An exception occurred while trying to open the file/folder

                ' Display an error message
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' Button_Reload - Click
    Private Sub Button_Reload_Click(sender As Object, e As EventArgs) Handles Button_Reload.Click
        If TreeView1.Nodes.Count > 0 Then
            ' Check if there are nodes in the TreeView

            If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath) Then
                ' Check if the selected directory path exists

                ' Reload the directory and its contents
                Load_Directory()

                ' Append a log message indicating that the directory was reloaded
                AppendToLog("Directory reloaded", Color.MediumSpringGreen, True)
            End If
        End If
    End Sub

    '
    ' RichTextBox_Log
    '

    ' RichTextBox_Log - TextChanged
    Private Sub RichTextBox_Log_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox_Log.TextChanged
        RichTextBox_Log.SelectionStart = RichTextBox_Log.Text.Length
        RichTextBox_Log.ScrollToCaret()
    End Sub

    ' AppendToLog - Text - SelectedColor - NewLine
    Public Sub AppendToLog(text As String, selectionColor As Color, newLine As Boolean)
        RichTextBox_Log.SelectionColor = selectionColor
        If newLine Then
            RichTextBox_Log.AppendText(text & vbNewLine)
        Else
            RichTextBox_Log.AppendText(text)
        End If
    End Sub

    '
    'ContextMenuStrip_Log
    '

    ' Clear (ToolStripMenuItem) - Click
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        RichTextBox_Log.Clear()
    End Sub

    '
    ' PictureBox_Animation
    '

    'Panel_Animation - MouseWheel
    Private Sub Panel_Animation_MouseWheel(sender As Object, e As MouseEventArgs) Handles Panel_Animation.MouseWheel
        If e.Delta < 0 And ZoomCounter < 100 Then ' Zoom in
            ' If the mouse wheel is scrolled down (e.Delta < 0) and the ZoomCounter is less than 100, zoom in.

            ' Increase the ZoomCounter by 5
            ZoomCounter += 5

            ' Update the label to display the new zoom level
            Label_ZoomLvl.Text = "Zoom: " & ZoomCounter & "%"

            ' Scale the size of the PixelBox_Animation based on the updated zoom level
            PixelBox_Animation.Size = ObjectScale(New Size(320, 304), ZoomCounter)

            ' Center the PixelBox_Animation within the Panel_Animation control
            PixelBox_Animation.Location = New Point(CInt((Panel_Animation.Width / 2 - PixelBox_Animation.Width / 2)), CInt((Panel_Animation.Height / 2 - PixelBox_Animation.Height / 2) - 4))
        ElseIf e.Delta > 0 And ZoomCounter > 10 Then ' Zoom out
            ' If the mouse wheel is scrolled up (e.Delta > 0) and the ZoomCounter is greater than 10, zoom out.

            ' Decrease the ZoomCounter by 5
            ZoomCounter -= 5

            ' Update the label to display the new zoom level
            Label_ZoomLvl.Text = "Zoom: " & ZoomCounter & "%"

            ' Scale the size of the PixelBox_Animation based on the updated zoom level
            PixelBox_Animation.Size = ObjectScale(New Size(320, 304), ZoomCounter)

            ' Center the PixelBox_Animation within the Panel_Animation control
            PixelBox_Animation.Location = New Point(CInt((Panel_Animation.Width / 2 - PixelBox_Animation.Width / 2)), CInt((Panel_Animation.Height / 2 - PixelBox_Animation.Height / 2) - 4))
        End If
    End Sub

    ' Timer_Animation - Tick
    Private Sub Timer_Animation_Tick(sender As Object, e As EventArgs) Handles Timer_Animation.Tick
        If AnimationFiles.Count > 0 Then
            ' If there are animation files in the collection.

            If AnimationLoopCounter < AnimationFiles.Count - 1 Then
                ' If the AnimationLoopCounter is less than the index of the last animation file, continue playing the animation.

                ' Increment the AnimationLoopCounter to move to the next frame
                AnimationLoopCounter += 1

                ' Set the image of the PixelBox_Animation control to the next frame of the animation
                PixelBox_Animation.Image = SafeImageFromFile(AnimationFiles.Item(AnimationLoopCounter).ToString)
            Else
                ' If the AnimationLoopCounter is equal to the index of the last animation file, check if looping is enabled.

                If CheckBox_Loop.Checked = False Then
                    ' If looping is not enabled, stop the animation by disabling the Timer_Animation.
                    Timer_Animation.Enabled = False
                Else
                    ' If looping is enabled, reset the AnimationLoopCounter to 0 to play the animation from the beginning.

                    AnimationLoopCounter = 0 ' Set to first frame on animation play completed

                    ' Set the image of the PixelBox_Animation control to the first frame of the animation
                    PixelBox_Animation.Image = SafeImageFromFile(AnimationFiles.Item(AnimationLoopCounter).ToString)
                End If
            End If

            'Console.WriteLine(AnimationLoopCounter)
            'Console.WriteLine(AnimationFiles.Item(AnimationLoopCounter).ToString)
        End If
    End Sub

    '
    ' ContextMenuStrip_PictureBox_Animation
    '
    '

    ' ContextMenuStrip_FastColoredTextBox_Selected_File - Opening
    Private Sub ContextMenuStrip_FastColoredTextBox_Selected_File_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_FastColoredTextBox_Selected_File.Opening
        If TreeView1.Nodes.Count > 0 Then
            If Not TreeView1.SelectedNode.Index = -1 And TreeView1.SelectedNode.Text.EndsWith(".json") Then 'Changed
                SaveToolStripMenuItem.Enabled = True
                FlipLoopBooleanToolStripMenuItem.Enabled = True
            Else
                SaveToolStripMenuItem.Enabled = False
                FlipLoopBooleanToolStripMenuItem.Enabled = False
            End If
        Else
            SaveToolStripMenuItem.Enabled = False
            FlipLoopBooleanToolStripMenuItem.Enabled = False
        End If
    End Sub

    ' FlipLoopBoolean (ToolStripMenuItem) - Click
    Private Sub FlipLoopBooleanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipLoopBooleanToolStripMenuItem.Click
        'Flip Value
        If FastColoredTextBox_Selected_File.Text.Contains("false") Then
            FastColoredTextBox_Selected_File.Text = FastColoredTextBox_Selected_File.Text.Replace("false", "true")
            CheckBox_Loop.Checked = True
        Else
            FastColoredTextBox_Selected_File.Text = FastColoredTextBox_Selected_File.Text.Replace("true", "false")
            CheckBox_Loop.Checked = False
        End If

        'Write file
        My.Computer.FileSystem.WriteAllText(FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + TreeView1.SelectedNode.FullPath, FastColoredTextBox_Selected_File.Text, False)

        'Reload animation timer value
        Dim JSONFile As JObject = JObject.Parse(FastColoredTextBox_Selected_File.Text)
        Dim tBF As Decimal = CDec(JSONFile.SelectToken("timeBetweenFrames"))
        Timer_Animation.Interval = CInt(tBF * 1000) 'This with cause a crash if 0

        'Log
        AppendToLog("File Saved: ", Color.MediumSpringGreen, False)
        AppendToLog(Path.GetFileName(TreeView1.SelectedNode.FullPath), Color.LightSkyBlue, True)
    End Sub

    ' Save (ToolStripMenuItem) - Click
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Write file
        My.Computer.FileSystem.WriteAllText(FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + TreeView1.SelectedNode.FullPath, FastColoredTextBox_Selected_File.Text, False)

        'Reload animation timer value
        Dim JSONFile As JObject = JObject.Parse(FastColoredTextBox_Selected_File.Text)
        Dim tBF As Decimal = CDec(JSONFile.SelectToken("timeBetweenFrames"))
        Timer_Animation.Interval = CInt(tBF * 1000) 'This with cause a crash if 0

        'Log
        AppendToLog("File Saved: ", Color.MediumSpringGreen, False)
        AppendToLog(Path.GetFileName(TreeView1.SelectedNode.FullPath), Color.LightSkyBlue, True)
    End Sub

    '
    ' TreeView1
    '

    ' TreeView1 - BeforeExpand
    Private Sub TreeView1_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand
        Try
            e.Node.Nodes.Clear()
            Dim CurrentNode As TreeNode = e.Node
            Dim FolderPath As New DirectoryInfo(FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + CurrentNode.FullPath)
            For Each dir As DirectoryInfo In FolderPath.GetDirectories()
                Dim FileName As String = dir.Name
                Dim node As TreeNode = CurrentNode.Nodes.Add(FileName)
                node.ForeColor = Color.WhiteSmoke
                node.Nodes.Add(" ").ImageIndex = 0
            Next

            Dim i As Integer = CurrentNode.Nodes.Count - 1 'used to be -1
            For Each file As String In Directory.GetFiles(FolderPath.FullName, "*.json", SearchOption.TopDirectoryOnly) 'path.GetFiles()
                i += 1
                CurrentNode.Nodes.Add(Path.GetFileName(file)).ImageIndex = 1
                CurrentNode.Nodes.Item(i).ForeColor = Color.PaleGoldenrod
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' TreeView1 - AfterSelect
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        'Clear before loading
        AnimationFiles.Clear()
        AnimationLoopCounter = -1
        Timer_Animation.Enabled = False
        PixelBox_Animation.ImageLocation = ""
        PixelBox_Animation.Image = Nothing
        FastColoredTextBox_Selected_File.Clear()
        Label_Frames.Text = "Frames: 0"
        Try
            Dim SelectedItem_FilePath As String = FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + TreeView1.SelectedNode.FullPath
            Dim TempDirectoryString As String = FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + Path.GetDirectoryName(TreeView1.SelectedNode.FullPath)
            'Console.WriteLine(e.Node.Level)
            If e.Node.Text.EndsWith(".json") And Not e.Node.Text.EndsWith(".asset.json") And Not e.Node.Text = "PACK.json" Then 'Ignore PACK.json and .asset.json 'e.Node.Level > 0 And
                If File.Exists(selectedItem_filepath) Then

                    Label_MetadataFileToGen.Text = ""
                    FastColoredTextBox_Selected_File.Text = File.ReadAllText(selectedItem_filepath)

                    'Clear
                    AnimationFiles.Clear()
                    AnimationLoopCounter = -1
                    Timer_Animation.Enabled = False

                    Dim Frames As Integer = 0
                    Dim METADATA_Name As String = ""
                    METADATA_Name = Path.GetFileNameWithoutExtension(selectedItem_filepath)
                    METADATA_Name = METADATA_Name.Replace("_METADATA", "")
                    METADATA_Name = METADATA_Name.Substring(METADATA_Name.IndexOf("_") + 1)

                    Dim AnimationName2 As String = ""
                    AnimationName2 = METADATA_Name.Substring(METADATA_Name.IndexOf("_") + 1)

                    Dim ObjectName1 As String = Microsoft.VisualBasic.Left(Path.GetFileNameWithoutExtension(selectedItem_filepath), Path.GetFileNameWithoutExtension(selectedItem_filepath).IndexOf("_"))
                    Dim ObjectName2 As String = ""

                    For Each PNG_file As String In Directory.GetFiles(TempDirectoryString, "*.png", SearchOption.TopDirectoryOnly)
                        Dim PNG_file_Untouched As String = PNG_file

                        If CountCharacter(Path.GetFileName(PNG_file), CChar("_")) > 0 Then
                            ObjectName2 = Microsoft.VisualBasic.Left(Path.GetFileNameWithoutExtension(PNG_file), Path.GetFileNameWithoutExtension(PNG_file).IndexOf("_"))
                        Else
                            ObjectName2 = Path.GetFileNameWithoutExtension(PNG_file)
                        End If

                        If ObjectName2 = ObjectName1 Then
                            If CountCharacter(Path.GetFileName(PNG_file), CChar("_")) > 1 Then 'Fixes images without a animation name like (Candle_1)
                                PNG_file = Path.GetFileNameWithoutExtension(PNG_file)
                                PNG_file = PNG_file.Substring(PNG_file.IndexOf("_") + 1)
                                If PNG_file.Contains("_") Then
                                    PNG_file = Microsoft.VisualBasic.Left(PNG_file, PNG_file.IndexOf("_"))
                                End If
                                If PNG_file = METADATA_Name Then
                                    Frames += 1
                                    AnimationFiles.Add(PNG_file_Untouched)
                                End If
                            Else
                                PNG_file = Path.GetFileNameWithoutExtension(PNG_file)
                                If PNG_file.Contains("_") Then
                                    PNG_file = Microsoft.VisualBasic.Left(PNG_file, PNG_file.IndexOf("_"))
                                End If
                                If PNG_file = METADATA_Name Then
                                    Frames += 1
                                    AnimationFiles.Add(PNG_file_Untouched)
                                End If
                            End If
                        End If
                    Next

                    Dim tempString As String = ""
                    Dim animationName As String = ""
                    Dim objectName As String = ""
                    tempString = TreeView1.SelectedNode.Text.Replace("_METADATA", "") 'This may cause issues (TreeView1.SelectedNode.Text)
                    animationName = tempString.Substring(tempString.IndexOf("_") + 1)
                    animationName = Path.GetFileNameWithoutExtension(animationName)

                    If CountCharacter(Path.GetFileName(tempString), CChar("_")) = 0 Then
                        objectName = animationName
                        animationName = "NO ANIMATION NAME"
                    Else
                        objectName = Microsoft.VisualBasic.Left(tempString, tempString.IndexOf("_")) 'This will cause a crash for single images
                    End If

                    'Frames tbf math
                    Dim timeBetweenFrames As Decimal = 0
                    If Frames > 0 Then
                        If XFramesToolStripMenuItem.Checked Then
                            timeBetweenFrames = CDec(1 / (Frames * 2)) 'Might want to use a Double
                        Else
                            timeBetweenFrames = CDec(1 / Frames) 'Might want to use a Double
                        End If
                    End If

                    Dim AnimationLoop As Boolean = False
                    If LoopedAnimationKeywords.Contains(animationName.ToLower) Then
                        AnimationLoop = True
                    Else
                        AnimationLoop = False
                    End If

                    Dim JSONFile As JObject = JObject.Parse(File.ReadAllText(selectedItem_filepath))
                    Dim tBF As Decimal = CDec(JSONFile.SelectToken("timeBetweenFrames"))
                    Timer_Animation.Interval = CInt(tBF * 1000) 'This with cause a crash if 0

                    Dim IsLooping As Boolean = CBool(JSONFile.SelectToken("loop").ToString.ToLower)
                    Dim tBF_FromFile As Decimal = CDec(JSONFile.SelectToken("timeBetweenFrames"))
                    NumericUpDown_TimeBetweenFrames.Value = tBF_FromFile

                    Dim tBF_Str As String = CStr(Math.Round(NumericUpDown_TimeBetweenFrames.Value, 4))
                    tBF_Str = tBF_Str.TrimEnd(CChar("0"))
                    tBF_Str = tBF_Str.TrimEnd(CChar("."))
                    TextBox_TimeBetweenFrames.Text = tBF_Str 'Math.Round(NumericUpDown_TimeBetweenFrames.Value, 4)

                    If IsLooping Then
                        CheckBox_Loop.Checked = True
                    Else
                        CheckBox_Loop.Checked = False
                    End If

                    '8 frames
                    '1 / 8 = 0.125
                    '0.125 * 1000 = 125
                    '1000 / 125 = 8
                    Dim FPSValue As Integer = CInt((tBF_FromFile * 1000))
                    FPSValue = CInt(1000 / FPSValue)
                    NumericUpDown_FPS.Value = FPSValue

                    If isPaused = True Then
                        isPaused = False
                        Button_PausePlay.Text = "Pause"
                        Timer_Animation.Enabled = True
                        Button_PausePlay.Image = My.Resources.Pause
                    End If

                    Label_Frames.Text = "Frames: " & Frames.ToString

                    'Log
                    AppendToLog("Object:", Color.WhiteSmoke, False)
                    AppendToLog(objectName, Color.LightSkyBlue, False)

                    AppendToLog(", Animation:", Color.WhiteSmoke, False)
                    If animationName = "NO ANIMATION NAME" Then
                        AppendToLog(animationName, Color.Goldenrod, False)
                    Else
                        AppendToLog(animationName, Color.LightSkyBlue, False)
                    End If

                    AppendToLog(", Frames:", Color.WhiteSmoke, False)
                    AppendToLog(Frames.ToString, Color.HotPink, False)

                    AppendToLog(", Calculated tbf:", Color.WhiteSmoke, False)
                    AppendToLog(Math.Round(timeBetweenFrames, 4).ToString, Color.HotPink, False)

                    AppendToLog(", Predicted loop:", Color.WhiteSmoke, False)
                    AppendToLog(AnimationLoop.ToString.ToLower, Color.LightSkyBlue, True)

                    If Not AnimationLoop = IsLooping And AnimationLoop = False Then 'FIX THIS MESSAGE
                        AppendToLog("This animation name is not in the looped animation keywords file", Color.PaleGoldenrod, True)
                    ElseIf Not AnimationLoop = IsLooping And IsLooping = False Then
                        'This animation predicted loop does not match
                        AppendToLog("This animation does not match it's predicted loop value", Color.PaleGoldenrod, True)
                    End If

                Else
                    AppendToLog("Selected file doesn't exist directory will now be reloaded", Color.Tomato, True)
                    Load_Directory()
                    AppendToLog("Directory reloaded", Color.MediumSpringGreen, True)
                End If

                AnimationFiles = AnimationFiles.OrderBy(Function(x) Integer.Parse("0" & x.Substring(x.LastIndexOf("_") + 1, x.Length - x.LastIndexOf("_") - 5))).ToList
                Timer_Animation.Enabled = True
            Else
                If Not e.Node.Text.EndsWith(".asset.json") And Not e.Node.Text = "PACK.json" Then
                    CalcMetadata() 'HERE
                    'Console.WriteLine("CalcMetadata")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    '
    ' ContextMenuStrip_TreeView
    '

    ' ContextMenuStrip_TreeView - Opening
    Private Sub ContextMenuStrip_TreeView_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_TreeView.Opening
        If TreeView1.Nodes.Count > 0 Then
            If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath) Then
                GenerateMetadataFilesToolStripMenuItem.Enabled = True
                RegenerateMetadataFilesToolStripMenuItem.Enabled = True
                AssetStorePreviewToolStripMenuItem1.Enabled = True
                TagsMakerToolStripMenuItem.Enabled = True
                OpenDirectoryToolStripMenuItem.Enabled = True
                If Not TreeView1.SelectedNode.Index = -1 And TreeView1.SelectedNode.Text.EndsWith(".json") Then 'Changed
                    LoopedAnimationKeywordsToolStripMenuItem1.Enabled = True
                    OpenFileToolStripMenuItem.Enabled = True
                    RegenerateSelectedFileToolStripMenuItem.Enabled = True
                    GenerateMetadataFilesToolStripMenuItem.Enabled = False
                    RegenerateMetadataFilesToolStripMenuItem.Enabled = False
                    AssetStorePreviewToolStripMenuItem1.Enabled = False
                    TagsMakerToolStripMenuItem.Enabled = False
                Else
                    LoopedAnimationKeywordsToolStripMenuItem1.Enabled = False
                    OpenFileToolStripMenuItem.Enabled = False
                    RegenerateSelectedFileToolStripMenuItem.Enabled = False
                    GenerateMetadataFilesToolStripMenuItem.Enabled = True
                    RegenerateMetadataFilesToolStripMenuItem.Enabled = True
                    AssetStorePreviewToolStripMenuItem1.Enabled = True
                    TagsMakerToolStripMenuItem.Enabled = True
                End If
            Else
                GenerateMetadataFilesToolStripMenuItem.Enabled = False
                RegenerateMetadataFilesToolStripMenuItem.Enabled = False
                AssetStorePreviewToolStripMenuItem1.Enabled = False
                TagsMakerToolStripMenuItem.Enabled = False
                OpenDirectoryToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub

    ' OpenFile (ToolStripMenuItem) - Click
    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        If File.Exists(TextBox_Selected_Directory.Text & "\" & TreeView1.SelectedNode.FullPath) Then
            Process.Start(TextBox_Selected_Directory.Text & "\" & TreeView1.SelectedNode.FullPath)
        Else
            AppendToLog("Selected file doesn't exist directory will now be reloaded", Color.Tomato, True)
            Load_Directory()
            AppendToLog("Directory reloaded", Color.MediumSpringGreen, True)
        End If
    End Sub

    ' OpenDirectory (ToolStripMenuItem) - Click
    Private Sub OpenDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDirectoryToolStripMenuItem.Click
        If TreeView1.SelectedNode.FullPath.EndsWith(".json") Then
            If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & Path.GetDirectoryName(TreeView1.SelectedNode.FullPath)) Then
                Process.Start(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & Path.GetDirectoryName(TreeView1.SelectedNode.FullPath))
            Else
                AppendToLog("Directory doesn't exist Interface will now be cleared", Color.Tomato, True)
                FastColoredTextBox_Selected_File.Clear()
                TextBox_Selected_Directory.Clear()
                AppendToLog("Interface cleared", Color.MediumSpringGreen, True)
            End If
        Else
            If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & TreeView1.SelectedNode.FullPath) Then
                Process.Start(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & TreeView1.SelectedNode.FullPath)
            Else
                AppendToLog("Directory doesn't exist Interface will now be cleared", Color.Tomato, True)
                FastColoredTextBox_Selected_File.Clear()
                TextBox_Selected_Directory.Clear()
                AppendToLog("Interface cleared", Color.MediumSpringGreen, True)
            End If
        End If
    End Sub

    ' XFrames (ToolStripMenuItem) - Click
    Private Sub XFramesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XFramesToolStripMenuItem.Click
        If XFramesToolStripMenuItem.Checked Then
            XFramesToolStripMenuItem.Checked = False
        Else
            XFramesToolStripMenuItem.Checked = True
        End If
    End Sub

    ' GenerateMetadataFiles (ToolStripMenuItem) - Click
    Private Sub GenerateMetadataFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateMetadataFilesToolStripMenuItem.Click
        If HasFileNameErrors() = False Then
            GenerateMetadata(False)
        Else
            Dim New_FileNameValidator_Window As New FileNameValidator
            New_FileNameValidator_Window.Show()
            New_FileNameValidator_Window.BringToFront()
            New_FileNameValidator_Window.FolderBrowserDialog_Selected_Directory.SelectedPath = FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + TreeView1.SelectedNode.FullPath
            New_FileNameValidator_Window.LoadFiles()
        End If
    End Sub

    ' RegenerateMetadataFiles (ToolStripMenuItem) - Click
    Private Sub RegenerateMetadataFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegenerateMetadataFilesToolStripMenuItem.Click
        If MsgBox("Are you sure you would like to regenerate metadata files?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If HasFileNameErrors() = False Then
                GenerateMetadata(True)
            Else
                Dim New_FileNameValidator_Window As New FileNameValidator
                New_FileNameValidator_Window.Show()
                New_FileNameValidator_Window.BringToFront()
                New_FileNameValidator_Window.FolderBrowserDialog_Selected_Directory.SelectedPath = FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + TreeView1.SelectedNode.FullPath
                New_FileNameValidator_Window.LoadFiles()
            End If
        End If
    End Sub

    ' HasFileNameErrors
    Public Function HasFileNameErrors() As Boolean
        For Each PNG_file As String In Directory.GetFiles(FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + TreeView1.SelectedNode.FullPath, "*.png", SearchOption.TopDirectoryOnly)
            Dim PNG_FileFull As String = PNG_file.Replace(FolderBrowserDialog_Selected_Directory.SelectedPath + "\", "")
            PNG_file = Path.GetFileNameWithoutExtension(PNG_file)
            If Not regexValidWords.IsMatch(PNG_file) Or regexInvalidWords.IsMatch(PNG_file) Or CountCharacter(PNG_file, CChar("_")) > 2 Or PNG_FileFull.ToLower.EndsWith(".png.png") Or Not Char.IsLetter(PNG_file.First) And Not PNG_file.ToLower.StartsWith("9patch_") Then
                Return True
            End If
        Next
        Return False
    End Function

    ' RegenerateSelectedFile (ToolStripMenuItem) - Click
    Private Sub RegenerateSelectedFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegenerateSelectedFileToolStripMenuItem.Click
        'If Not TreeView1.SelectedNode.Index = -1
        'File naming structure: ObjectName_AnimationName_METADATA
        'Count all PNG's that match the name of the selected JSON file -_METADATA to use for 'timeBetweenFrames':
        'if selected JSON file name contains (run,runing,idle,idling,swim,swimming) then set 'loop': to true
        Dim SelectedItem_FilePath As String = FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + TreeView1.SelectedNode.FullPath
        Dim TempDirectoryString As String = FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + Path.GetDirectoryName(TreeView1.SelectedNode.FullPath)

        If Not TreeView1.SelectedNode.Index = -1 Then
            If File.Exists(SelectedItem_FilePath) Then

                Dim Frames As Integer = 0
                Dim METADATA_Name As String = ""
                METADATA_Name = Path.GetFileNameWithoutExtension(SelectedItem_FilePath)
                METADATA_Name = METADATA_Name.Replace("_METADATA", "")
                METADATA_Name = METADATA_Name.Substring(METADATA_Name.IndexOf("_") + 1)

                For Each PNG_file As String In Directory.GetFiles(TempDirectoryString, "*.png", SearchOption.TopDirectoryOnly)
                    If CountCharacter(Path.GetFileName(PNG_file), CChar("_")) > 1 Then 'Fixes images without a animation name like (Candle_1)
                        PNG_file = Path.GetFileNameWithoutExtension(PNG_file)
                        PNG_file = PNG_file.Substring(PNG_file.IndexOf("_") + 1)
                        If PNG_file.Contains("_") Then
                            PNG_file = Microsoft.VisualBasic.Left(PNG_file, PNG_file.IndexOf("_"))
                        End If
                        If PNG_file = METADATA_Name Then
                            Frames += 1
                        End If
                    Else
                        PNG_file = Path.GetFileNameWithoutExtension(PNG_file)
                        If PNG_file.Contains("_") Then
                            PNG_file = Microsoft.VisualBasic.Left(PNG_file, PNG_file.IndexOf("_"))
                        End If
                        If PNG_file = METADATA_Name Then
                            Frames += 1
                        End If
                    End If
                Next

                Dim tempString As String = ""
                Dim animationName As String = ""
                Dim objectName As String = ""
                tempString = TreeView1.SelectedNode.Text.Replace("_METADATA", "").ToString
                animationName = tempString.Substring(tempString.IndexOf("_") + 1)
                animationName = Path.GetFileNameWithoutExtension(animationName)

                If CountCharacter(Path.GetFileName(tempString), CChar("_")) = 0 Then
                    objectName = animationName
                    animationName = "NO ANIMATION NAME"
                Else
                    objectName = Microsoft.VisualBasic.Left(tempString, tempString.IndexOf("_"))
                End If

                'Frames tbf math
                Dim timeBetweenFrames As Decimal = 0
                If Frames > 0 Then
                    If XFramesToolStripMenuItem.Checked Then
                        timeBetweenFrames = CDec(1 / (Frames * 2)) 'Might want to use a Double
                    Else
                        timeBetweenFrames = CDec(1 / Frames) 'Might want to use a Double
                    End If
                End If

                'Looping Calculation
                Dim AnimationLoop As Boolean = False
                If LoopedAnimationKeywords.Contains(animationName.ToLower) Then
                    AnimationLoop = True
                Else
                    AnimationLoop = False
                End If

                'Build json string
                Dim sb As New StringBuilder
                Dim sw As New StringWriter(sb)
                Dim writer As JsonWriter = New JsonTextWriter(sw) With {
                    .Formatting = Formatting.Indented
                }
                writer.WriteStartObject()
                writer.WritePropertyName("timeBetweenFrames")
                writer.WriteValue(Math.Round(timeBetweenFrames, 4))
                writer.WritePropertyName("loop")
                writer.WriteValue(AnimationLoop)
                writer.WriteEndObject()

                'Write to file
                My.Computer.FileSystem.WriteAllText(SelectedItem_FilePath, sb.ToString, False)

                'Update FastColoredTextBox_Selected_File Text
                FastColoredTextBox_Selected_File.Text = sb.ToString

                'Reload animation timer value
                Dim JSONFile As JObject = JObject.Parse(FastColoredTextBox_Selected_File.Text)
                Dim tBF As Decimal = CDec(JSONFile.SelectToken("timeBetweenFrames"))
                Timer_Animation.Interval = CInt(tBF * 1000) 'This with cause a crash if 0

                AppendToLog("Regenerated File: ", Color.MediumSpringGreen, False)
                AppendToLog(Path.GetFileName(SelectedItem_FilePath), Color.LightSkyBlue, True)
            Else
                AppendToLog("Selected file doesn't exist directory will now be reloaded", Color.Tomato, True)
                Load_Directory()
                AppendToLog("Directory reloaded", Color.MediumSpringGreen, True)
            End If
        End If
    End Sub

    ' AddAnimationNameToFile - (ToolStripMenuItem) - Click
    Private Sub AddAnimationNameToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddAnimationNameToolStripMenuItem1.Click
        If File.Exists(Application.StartupPath & "\Looped Animation Keywords.txt") Then
            LoopedAnimationKeywords = File.ReadAllLines(Application.StartupPath & "\Looped Animation Keywords.txt").ToArray
            Dim tempString As String = ""
            Dim animationName As String = ""
            tempString = TreeView1.SelectedNode.Text.Replace("_METADATA", "") 'This may cause issues (TreeView1.SelectedNode.Text)
            animationName = tempString.Substring(tempString.IndexOf("_") + 1)
            animationName = Path.GetFileNameWithoutExtension(animationName)
            If Not LoopedAnimationKeywords.Contains(animationName.ToLower) Then
                If MessageBox.Show("Add the animation name: " & animationName & ", to file?", "Metadata Generator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim file_LoopedAnimationKeywords As StreamWriter
                    file_LoopedAnimationKeywords = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Looped Animation Keywords.txt", True)
                    file_LoopedAnimationKeywords.WriteLine(animationName.ToLower)
                    file_LoopedAnimationKeywords.Close()
                    LoopedAnimationKeywords = File.ReadAllLines(Application.StartupPath & "\Looped Animation Keywords.txt").ToArray

                    AppendToLog("Animation name added to file", Color.MediumSpringGreen, True)

                    AppendToLog("Looped animation keywords reloaded", Color.MediumSpringGreen, True)
                End If
            Else
                MsgBox("Animation name: " & animationName & ", is already in file.", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("File not found: Looped Animation Keywords.txt" & vbNewLine & "This file will be regenerated from a internal list.", MsgBoxStyle.Information)
            'Generate needed file
            File.WriteAllLines(Application.StartupPath & "\Looped Animation Keywords.txt", LoopedAnimationKeywords)
        End If
    End Sub

    '
    ' Func Subs
    '

    ' Load_Directory
    Private Sub Load_Directory()
        'Clear before loading
        AnimationFiles.Clear()
        AnimationLoopCounter = -1
        Timer_Animation.Enabled = False
        PixelBox_Animation.ImageLocation = ""
        PixelBox_Animation.Image = Nothing
        FastColoredTextBox_Selected_File.Clear()
        TreeView1.Nodes.Clear()
        Label_MetadataFileToGen.Text = ""
        Dim folderPath As New DirectoryInfo(FolderBrowserDialog_Selected_Directory.SelectedPath)
        Try
            For Each dir As DirectoryInfo In folderPath.GetDirectories()
                Dim node As TreeNode = TreeView1.Nodes.Add(dir.Name)
                node.TreeView.LabelEdit = True
                node.BeginEdit()
                node.NodeFont = Font_MSS
                node.ForeColor = Color.FromArgb(27, 179, 245)
                node.Nodes.Add(" ")
                node.EndEdit(False)
                node.TreeView.LabelEdit = False
            Next

            For Each file As String In Directory.GetFiles(folderPath.FullName, "*.json", SearchOption.TopDirectoryOnly) 'path.GetFiles()
                'currentNode.Nodes.Add(Path.GetFileName(file)).ImageIndex = 1
                'currentNode.Nodes.Item(i).ForeColor = Color.PaleGoldenrod
                Dim node2 As TreeNode = TreeView1.Nodes.Add(Path.GetFileName(file))

                node2.TreeView.LabelEdit = True
                node2.BeginEdit()
                node2.ImageIndex = 1
                'node2.NodeFont = Font_MSS
                node2.ForeColor = Color.PaleGoldenrod
                'node2.Nodes.Add(" ")
                node2.EndEdit(False)
                node2.TreeView.LabelEdit = False
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' CountCharacter
    Public Function CountCharacter(ByVal inputString As String, ByVal charToCount As Char) As Integer
        Return inputString.Count(Function(c As Char) c = charToCount)
    End Function

    ' GenerateMetadata
    Private Sub GenerateMetadata(overwrite As Boolean)
        Dim TempDirectoryString As String = FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + TreeView1.SelectedNode.FullPath
        Dim MetaDataFileName As String = ""
        Dim MetaDataFileNames As New List(Of String)()
        For Each PNG_file As String In Directory.GetFiles(TempDirectoryString, "*.png", SearchOption.TopDirectoryOnly)

            PNG_file = Path.GetFileNameWithoutExtension(PNG_file)

            If PNG_file.Contains("_") And CountCharacter(PNG_file, CChar("_")) <= 2 Then
                If Regex.IsMatch(PNG_file.Substring(PNG_file.LastIndexOf("_") + 1), "^[0-9 ]+$") Then

                    PNG_file = Microsoft.VisualBasic.Left(PNG_file, PNG_file.LastIndexOf("_") + 1)

                    If PNG_file.EndsWith("_") And Not MetaDataFileNames.Contains(PNG_file) Then

                        MetaDataFileNames.Add(PNG_file)
                        MetaDataFileName = TempDirectoryString & "\" & PNG_file & "METADATA.json"

                        Dim Frames As Integer = 0
                        Dim METADATA_Name As String = ""
                        METADATA_Name = Path.GetFileNameWithoutExtension(MetaDataFileName)
                        METADATA_Name = METADATA_Name.Replace("_METADATA", "")
                        METADATA_Name = METADATA_Name.Substring(METADATA_Name.IndexOf("_") + 1)

                        For Each PNG_file2 As String In Directory.GetFiles(TempDirectoryString, "*.png", SearchOption.TopDirectoryOnly)
                            If CountCharacter(Path.GetFileName(PNG_file2), CChar("_")) > 1 Then 'Fixes images without a animation name like (Candle_1)
                                PNG_file2 = Path.GetFileNameWithoutExtension(PNG_file2)
                                PNG_file2 = PNG_file2.Substring(PNG_file2.IndexOf("_") + 1)
                                If PNG_file2.Contains("_") Then
                                    PNG_file2 = Microsoft.VisualBasic.Left(PNG_file2, PNG_file2.IndexOf("_"))
                                End If
                                If PNG_file2 = METADATA_Name Then
                                    Frames += 1
                                End If
                            Else
                                PNG_file2 = Path.GetFileNameWithoutExtension(PNG_file2)
                                If PNG_file2.Contains("_") Then
                                    PNG_file2 = Microsoft.VisualBasic.Left(PNG_file2, PNG_file2.IndexOf("_"))
                                End If
                                If PNG_file2 = METADATA_Name Then
                                    Frames += 1
                                End If
                            End If
                        Next

                        Dim tempString As String = ""
                        Dim animationName As String = ""
                        Dim objectName As String = ""
                        tempString = MetaDataFileName.Replace("_METADATA", "").ToString
                        animationName = tempString.Substring(tempString.IndexOf("_") + 1)
                        animationName = Path.GetFileNameWithoutExtension(animationName)

                        If CountCharacter(Path.GetFileName(tempString), CChar("_")) = 0 Then
                            objectName = animationName
                            animationName = "NO ANIMATION NAME"
                        Else
                            objectName = Microsoft.VisualBasic.Left(tempString, tempString.IndexOf("_")) 'This will cause a crash for single images
                        End If

                        'Frames tbf math
                        Dim timeBetweenFrames As Decimal = 0
                        If Frames > 0 Then
                            If XFramesToolStripMenuItem.Checked Then
                                timeBetweenFrames = CDec(1 / (Frames * 2)) 'Might want to use a Double
                            Else
                                timeBetweenFrames = CDec(1 / Frames) 'Might want to use a Double
                            End If
                        End If

                        'Looping Calculation
                        Dim AnimationLoop As Boolean = False
                        If LoopedAnimationKeywords.Contains(animationName.ToLower) Then
                            AnimationLoop = True
                        Else
                            AnimationLoop = False
                        End If

                        'Build json string
                        Dim sb As New StringBuilder
                        Dim sw As New StringWriter(sb)
                        Dim writer As JsonWriter = New JsonTextWriter(sw) With {
                            .Formatting = Formatting.Indented
                        }
                        writer.WriteStartObject()
                        writer.WritePropertyName("timeBetweenFrames")
                        writer.WriteValue(Math.Round(timeBetweenFrames, 4))
                        writer.WritePropertyName("loop")
                        writer.WriteValue(AnimationLoop)
                        writer.WriteEndObject()

                        'Write to file
                        If overwrite = True Then
                            My.Computer.FileSystem.WriteAllText(MetaDataFileName, sb.ToString, False)
                            'Log
                            AppendToLog("Generated file: ", Color.MediumSpringGreen, False)
                            AppendToLog(MetaDataFileName, Color.LightSkyBlue, True)
                        Else
                            If Not File.Exists(MetaDataFileName) Then
                                My.Computer.FileSystem.WriteAllText(MetaDataFileName, sb.ToString, False)
                                'Log
                                AppendToLog("Generated file: ", Color.MediumSpringGreen, False)
                                AppendToLog(MetaDataFileName, Color.LightSkyBlue, True)
                            End If
                        End If
                    End If
                End If
            End If
        Next
        'Load_Directory()
        Label_MetadataFileToGen.ForeColor = Color.Gainsboro
        Label_MetadataFileToGen.Text = "0 Metadata files can be generated."
        TreeView1.SelectedNode.Nodes.Add("")
        TreeView1.SelectedNode.Collapse()
        TreeView1.SelectedNode.Expand()
    End Sub

    ' ObjectScale
    Public Shared Function ObjectScale(size As Size, scalePercent As Single) As Size
        If Math.Abs(scalePercent - 1) < Single.Epsilon Then
            Return size
        End If

        Dim height = CInt(size.Height * (scalePercent / 100))
        Dim width = CInt(size.Width * (scalePercent / 100))

        Return New Size(width, height)
    End Function

    ' CalcMetadata
    Private Sub CalcMetadata()
        Dim TempDirectoryString As String = FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + TreeView1.SelectedNode.FullPath
        Dim MetaDataItems As New ArrayList
        Dim MetaDataFileName As String = ""
        Dim MetaDataFileNames As New List(Of String)()

        For Each PNG_file As String In Directory.GetFiles(TempDirectoryString, "*.png", SearchOption.TopDirectoryOnly)
            PNG_file = Path.GetFileNameWithoutExtension(PNG_file)
            If PNG_file.Contains("_") And CountCharacter(PNG_file, CChar("_")) <= 2 Then
                If Regex.IsMatch(PNG_file.Substring(PNG_file.LastIndexOf("_") + 1), "^[0-9 ]+$") Then
                    PNG_file = Microsoft.VisualBasic.Left(PNG_file, PNG_file.LastIndexOf("_") + 1) ' This will cause a crash for single images
                    If PNG_file.EndsWith("_") And Not MetaDataFileNames.Contains(PNG_file) Then
                        MetaDataFileNames.Add(PNG_file)
                        MetaDataFileName = TempDirectoryString & "\" & PNG_file & "METADATA.json"
                        Dim METADATA_Name As String = ""
                        METADATA_Name = Path.GetFileNameWithoutExtension(MetaDataFileName)
                        METADATA_Name = METADATA_Name.Replace("_METADATA", "")
                        METADATA_Name = METADATA_Name.Substring(METADATA_Name.IndexOf("_") + 1)
                        For Each PNG_file2 As String In Directory.GetFiles(TempDirectoryString, "*.png", SearchOption.TopDirectoryOnly)
                            If CountCharacter(Path.GetFileName(PNG_file2), CChar("_")) > 1 Then
                                PNG_file2 = Path.GetFileNameWithoutExtension(PNG_file2)
                                PNG_file2 = PNG_file2.Substring(PNG_file2.IndexOf("_") + 1)
                                If PNG_file2.Contains("_") Then
                                    PNG_file2 = Microsoft.VisualBasic.Left(PNG_file2, PNG_file2.IndexOf("_"))
                                End If
                                If Not MetaDataItems.Contains(METADATA_Name) And Not File.Exists(MetaDataFileName) Then
                                    MetaDataItems.Add(METADATA_Name)
                                End If
                            Else
                                PNG_file2 = Path.GetFileNameWithoutExtension(PNG_file2)
                                If PNG_file2.Contains("_") Then
                                    PNG_file2 = Microsoft.VisualBasic.Left(PNG_file2, PNG_file2.IndexOf("_"))
                                End If
                                If Not metadataitems.Contains(METADATA_Name) And Not File.Exists(MetaDataFileName) Then
                                    metadataitems.Add(METADATA_Name)
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        Next

        If metadataitems.Count > 0 Then
            Label_MetadataFileToGen.ForeColor = Color.MediumSpringGreen
        Else
            Label_MetadataFileToGen.ForeColor = Color.Gainsboro
        End If
        Label_MetadataFileToGen.Text = metadataitems.Count.ToString & " Metadata files can be generated."
    End Sub

    ' Tags (ToolStripMenuItem) - Click
    Private Sub TagsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagsToolStripMenuItem.Click
        TagsMaker.Show()
        TagsMaker.BringToFront()
        If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath) Then
            TagsMaker.LoadDirTagsAndDir(FolderBrowserDialog_Selected_Directory.SelectedPath)
        End If
    End Sub

    ' License (ToolStripMenuItem) - Click
    Private Sub LicenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicenseToolStripMenuItem.Click
        LicenseMaker.Show()
        LicenseMaker.BringToFront()
        If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath) Then
            LicenseMaker.SaveFileDialog_License.InitialDirectory = FolderBrowserDialog_Selected_Directory.SelectedPath
        End If
    End Sub

    ' Package (ToolStripMenuItem) - Click
    Private Sub PackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackageToolStripMenuItem.Click
        PackageMaker.Show()
        PackageMaker.BringToFront()
        If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath) Then
            PackageMaker.SaveFileDialog_PackJson.InitialDirectory = FolderBrowserDialog_Selected_Directory.SelectedPath
        End If
    End Sub

    ' ClipboardAsset (ToolStripMenuItem) - Click
    Private Sub ClipboardAssetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClipboardAssetToolStripMenuItem.Click
        ClipboardAsset.Show()
        ClipboardAsset.BringToFront()
    End Sub

    ' TemplateAsset (ToolStripMenuItem) - Click
    Private Sub TemplateAssetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemplateAssetToolStripMenuItem.Click
        TemplateAsset.Show()
        TemplateAsset.BringToFront()
    End Sub

    ' AssetStorePreview (ToolStripMenuItem) - Click
    Private Sub AssetStorePreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssetStorePreviewToolStripMenuItem.Click
        AssetStorePreview.Show()
        AssetStorePreview.BringToFront()
        If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath) Then
            AssetStorePreview.LoadAssetsFromSelectedDirectory(FolderBrowserDialog_Selected_Directory.SelectedPath)
        End If
    End Sub

    ' FileNameValidator (ToolStripMenuItem) - Click
    Private Sub FileNameValidatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileNameValidatorToolStripMenuItem.Click
        FileNameValidator.Show()
        FileNameValidator.BringToFront()
    End Sub

    ' Reload (ToolStripMenuItem) - Click
    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        If File.Exists(Application.StartupPath & "\Looped Animation Keywords.txt") Then
            LoopedAnimationKeywords = File.ReadAllLines(Application.StartupPath & "\Looped Animation Keywords.txt").ToArray
            AppendToLog("Looped animation keywords reloaded", Color.MediumSpringGreen, True)
        Else
            MsgBox("File not found: Looped Animation Keywords.txt" & vbNewLine & "This file will be regenerated from a internal list.", MsgBoxStyle.Information)
            'Generate needed file
            File.WriteAllLines(Application.StartupPath & "\Looped Animation Keywords.txt", LoopedAnimationKeywords)
        End If
    End Sub

    ' Import (ToolStripMenuItem) - Click
    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim ReadFile As String() = File.ReadAllLines(OpenFileDialog1.FileName)
            Dim OldFile As String() = File.ReadAllLines(Application.StartupPath & "\Looped Animation Keywords.txt")
            Dim NewKeywordsFromFile As New ArrayList

            For Each Keyword As String In ReadFile
                If Not OldFile.Contains(Keyword) Then
                    NewKeywordsFromFile.Add(Keyword)
                End If
            Next

            Dim sw As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Looped Animation Keywords.txt", True)
            For Each line As String In NewKeywordsFromFile
                sw.WriteLine(line)
            Next
            sw.Close()

            MsgBox("Added " & NewKeywordsFromFile.Count & " Keywords.", MsgBoxStyle.Information)
        End If
    End Sub

    ' LinkLabel1 - LinkClicked
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Trello.LinkClicked
        LinkLabel_Trello.LinkVisited = True
        Process.Start("https://trello.com/b/xoOCKFOf/gdevelop-assets")
    End Sub

    ' SafeImageFromFile()
    Public Shared Function SafeImageFromFile(path As String) As Image
        Dim bytes = File.ReadAllBytes(path)
        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms)
            Return img
        End Using
    End Function

    ' FastColoredTextBox_Selected_File - TextChanged
    Private Sub FastColoredTextBox_Selected_File_TextChanged(sender As Object, e As TextChangedEventArgs) Handles FastColoredTextBox_Selected_File.TextChanged
        e.ChangedRange.ClearFoldingMarkers()
        e.ChangedRange.SetFoldingMarkers("{", "}")
        e.ChangedRange.SetFoldingMarkers("\[", "\]")
        FastColoredTextBox_Selected_File.Range.ClearStyle(key, str, boo, nul)
        For Each found As Range In FastColoredTextBox_Selected_File.GetRanges("(¤(\\u[a-zA-Z0-9]{4}|\\[^u]|[^\\¤])*¤(\s*:)?|\b(true|false|null)\b|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?)".Replace("¤"c, """"c))
            If Regex.IsMatch(found.Text, "^¤".Replace("¤"c, """"c)) Then
                If Regex.IsMatch(found.Text, ":$") Then
                    found.SetStyle(key)
                Else
                    found.SetStyle(str)
                End If
            ElseIf Regex.IsMatch(found.Text, "true|false") Then
                found.SetStyle(boo)
            ElseIf Regex.IsMatch(found.Text, "\d") Then
                found.SetStyle(num)
            ElseIf Regex.IsMatch(found.Text, "null") Then
                found.SetStyle(nul)
            End If
        Next
    End Sub

    ' AssetStorePreviewToolStripMenuItem1_Click
    Private Sub AssetStorePreviewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AssetStorePreviewToolStripMenuItem1.Click
        If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & TreeView1.SelectedNode.FullPath) Then
            AssetStorePreview.Show()
            AssetStorePreview.BringToFront()
            AssetStorePreview.LoadAssetsFromSelectedDirectory(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & TreeView1.SelectedNode.FullPath)
        End If
    End Sub

    ' TagsMaker (ToolStripMenuItem) - Click
    Private Sub TagsMakerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagsMakerToolStripMenuItem.Click
        If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & TreeView1.SelectedNode.FullPath) Then
            TagsMaker.Show()
            TagsMaker.BringToFront()
            TagsMaker.LoadDirTagsAndDir(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & TreeView1.SelectedNode.FullPath)
        End If
    End Sub

    '
    ' Window Handle Code
    '

    ' Move Window - Panel
    Private Sub Panel_Main_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Main.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Panel_Main.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Windows.Forms.Message = Windows.Forms.Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    ' Move Window - Label_Application_Title
    Private Sub Label_Application_Title_MouseDown(sender As Object, e As MouseEventArgs) Handles Label_Application_Title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Label_Application_Title.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Windows.Forms.Message = Windows.Forms.Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    ' Minimize
    Private Sub PictureBox_Minimize_Click(sender As Object, e As EventArgs) Handles PictureBox_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Close
    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        Me.Close()
    End Sub

    ' Minimize Blue
    Private Sub PictureBox_Minimize_MouseHover(sender As Object, e As EventArgs) Handles PictureBox_Minimize.MouseHover
        PictureBox_Minimize.Image = My.Resources.Minimize_Blue
    End Sub

    ' Minimize Grey
    Private Sub PictureBox_Minimize_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_Minimize.MouseLeave
        PictureBox_Minimize.Image = My.Resources.Minimize_Grey
    End Sub

    ' Form Deactivate Close Grey
    Private Sub Main_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        PictureBox_Close.Image = My.Resources.Close_Grey
        Panel_Main.BackColor = Color.FromArgb(28, 30, 34)
    End Sub

    ' Form Activated Close Red
    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        PictureBox_Close.Image = My.Resources.Close_Red
        Panel_Main.BackColor = Color.Black
    End Sub
End Class