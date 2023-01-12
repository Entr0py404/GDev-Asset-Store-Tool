
Public Class FileNameValidator
    ReadOnly regexValidWords As New Regex("^[a-zA-Z0-9 ()_&.-]*$") '("\|!#$%&/()=?»«@£§€{}.-;'<>,")
    ReadOnly regexInvalidWords As New Regex("\s{2,}|_\s|\s_|__") '(  )(_ ) (_ ) (__)
    'FileNameValidator - Load
    Private Sub FileNameValidator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip_ListBox_Errors.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub
    'CountCharacter
    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Return value.Count(Function(c As Char) c = ch)
    End Function
    'TextBox_Selected_Directory - KeyPress
    Private Sub TextBox_Selected_Directory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Selected_Directory.KeyPress
        If e.KeyChar = Chr(13) And TextBox_Selected_Directory.Text.Length > 0 Then
            e.Handled = True
            If Directory.Exists(TextBox_Selected_Directory.Text) Then
                If TextBox_Selected_Directory.Text.EndsWith("\") Then
                    TextBox_Selected_Directory.Text = TextBox_Selected_Directory.Text.TrimEnd(CChar("\"))
                End If
                FolderBrowserDialog_Selected_Directory.SelectedPath = TextBox_Selected_Directory.Text
                LoadFiles()
            Else
                MsgBox("Directory does Not exists.", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    'Button_Select_Directory - Click
    Private Sub Button_Select_Directory_Click(sender As Object, e As EventArgs) Handles Button_Select_Directory.Click
        If FolderBrowserDialog_Selected_Directory.ShowDialog() = DialogResult.OK Then
            LoadFiles()
        End If
    End Sub
    'Button_Reload - Click
    Private Sub Button_Reload_Click(sender As Object, e As EventArgs) Handles Button_Reload.Click
        If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath) Then
            ClearForNext()
            LoadFiles()
        Else
            MsgBox("This path no longer exists, Please Select a New directory.", MsgBoxStyle.Information)
        End If
    End Sub
    'OpenDirectory (ToolStripMenuItem) - Click
    Private Sub OpenDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDirectoryToolStripMenuItem.Click
        If (ListBox_Errors.SelectedItem.ToString.StartsWith("Possible") Or ListBox_Errors.SelectedItem.ToString.StartsWith("Invalid")) And Directory.Exists(ListBox_Errors.SelectedItem.ToString.Substring(ListBox_Errors.SelectedItem.ToString.IndexOf("|") + 2)) Then
            Process.Start("explorer.exe", ListBox_Errors.SelectedItem.ToString.Substring(ListBox_Errors.SelectedItem.ToString.IndexOf("|") + 2))
        ElseIf ListBox_Errors.SelectedItem.ToString.Contains("|") And File.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString.Substring(ListBox_Errors.SelectedItem.ToString.IndexOf("|") + 2)) Then
            Process.Start("explorer.exe", "/select," & FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString.Substring(ListBox_Errors.SelectedItem.ToString.IndexOf("|") + 2))
        ElseIf File.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString) Then
            Process.Start("explorer.exe", "/select," & FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString)
        Else
            MsgBox("Directory does Not exist, Interface will be reloaded", MsgBoxStyle.OkOnly)
            If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath) Then
                LoadFiles()
            Else
                ListBox_Errors.Items.Clear()
                RichTextBox_Correct.Clear()
                TextBox_Selected_Directory.Clear()
            End If
        End If
    End Sub
    'OpenFile (ToolStripMenuItem) - Click
    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        If ListBox_Errors.SelectedItem.ToString.Contains("|") And File.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString.Substring(ListBox_Errors.SelectedItem.ToString.IndexOf("|") + 2)) Then
            Process.Start(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString.Substring(ListBox_Errors.SelectedItem.ToString.IndexOf("|") + 2))
        ElseIf File.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString) Then
            Process.Start(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString)
        Else
            MsgBox("File does Not exist, Interface will be reloaded", MsgBoxStyle.OkOnly)
            If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath) Then
                LoadFiles()
            Else
                ListBox_Errors.Items.Clear()
                RichTextBox_Correct.Clear()
                TextBox_Selected_Directory.Clear()
            End If
        End If
    End Sub
    'ContextMenuStrip_ListBox_Errors - Opening
    Private Sub ContextMenuStrip_ListBox_Errors_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_ListBox_Errors.Opening
        If Not ListBox_Errors.SelectedIndex = -1 Then
            OpenDirectoryToolStripMenuItem.Enabled = True
            If Not ListBox_Errors.SelectedItem.ToString.StartsWith("Possible") And Not ListBox_Errors.SelectedItem.ToString.StartsWith("Invalid") Then
                OpenFileToolStripMenuItem.Enabled = True
            Else
                OpenFileToolStripMenuItem.Enabled = False
            End If
        Else
            OpenDirectoryToolStripMenuItem.Enabled = False
            OpenFileToolStripMenuItem.Enabled = False
        End If
    End Sub
    'LoadFiles
    Public Sub LoadFiles()
        PixelBox1.ImageLocation = ""
        PixelBox1.Image = Nothing
        ListBox_Errors.Items.Clear()
        RichTextBox_Correct.Clear()
        ListBox_Errors.Refresh()
        RichTextBox_Correct.Refresh()
        Label_Status.Text = "Scaning Files..."
        Label_Status.Refresh()
        Dim ContainsIgnoredDirectories As Boolean = False
        Dim TempListofFiles As New ArrayList
        TextBox_Selected_Directory.Text = FolderBrowserDialog_Selected_Directory.SelectedPath

        For Each Dir As String In Directory.GetDirectories(FolderBrowserDialog_Selected_Directory.SelectedPath, "*", SearchOption.AllDirectories)
            'Console.WriteLine(Path.GetFileName(Dir))
            If Not Path.GetFileName(Dir).ToLower.Contains("!zip") And Not Dir.ToLower.Contains("!remove") And Not Dir.ToLower.Contains("!notused") And Not Dir.ToLower.Contains("!not used") Then
                If Dir.ToLower.EndsWith("s") Then 'Check for plural in folder name
                    TempListofFiles.Add("Possible plural directory name. | " & Dir)
                End If
                If Not regexValidWords.IsMatch(Path.GetFileName(Dir)) Or regexInvalidWords.IsMatch(Path.GetFileName(Dir)) Or Path.GetFileName(Dir).Contains("_") Then
                    TempListofFiles.Add("Invalid directory name. | " & Dir)
                End If
            End If
        Next

        For Each PNG_file As String In Directory.GetFiles(FolderBrowserDialog_Selected_Directory.SelectedPath, "*.png", SearchOption.AllDirectories)
            If Not PNG_file.ToLower.Contains("!zip") And Not PNG_file.ToLower.Contains("!remove") And Not PNG_file.ToLower.Contains("!notused") And Not PNG_file.ToLower.Contains("!not used") Then
                Dim PNG_filefull As String = PNG_file.Replace(FolderBrowserDialog_Selected_Directory.SelectedPath + "\", "")
                Dim PNG_fileNameNoExt As String = Path.GetFileNameWithoutExtension(PNG_file)
                Dim PNG_fileName As String = Path.GetFileName(PNG_file)
                'Console.WriteLine("PNG_filefull: " + PNG_filefull)
                'Console.WriteLine("PNG_fileNameNoExt: " + PNG_fileNameNoExt)
                'Console.WriteLine("PNG_file: " + PNG_file)
                If Not regexValidWords.IsMatch(PNG_fileNameNoExt) Or regexInvalidWords.IsMatch(PNG_fileNameNoExt) Or CountCharacter(PNG_fileNameNoExt, CChar("_")) > 2 Or PNG_filefull.ToLower.EndsWith(".png.png") Or Not Char.IsLetter(PNG_fileNameNoExt.First) And Not PNG_fileNameNoExt.ToLower.StartsWith("9patch_") Then
                    TempListofFiles.Add(PNG_filefull)
                ElseIf CountCharacter(PNG_filefull, CChar("_")) = 1 Then
                    Dim AllAnimationFiles As New List(Of String)()
                    AllAnimationFiles.AddRange(Directory.GetFiles(Path.GetDirectoryName(PNG_file), "*.png", SearchOption.TopDirectoryOnly).Where(Function(x) Path.GetFileName(x).StartsWith(PNG_fileNameNoExt + "_"))) 'Check if there are any files starting with sprite name _
                    'For Each str As String In AllAnimationFiles
                    'Console.WriteLine(str)
                    'Next
                    'Console.WriteLine(AllAnimationFiles.Count)
                    If AllAnimationFiles.Count > 1 Then 'If array cotaining file names is more then 1 add to error list
                        TempListofFiles.Add("Animation name needed object has more then one animation. | " + PNG_filefull)
                    End If
                ElseIf CountCharacter(PNG_fileNameNoExt, CChar("_")) = 0 Then
                    Dim AllAnimationFiles As New List(Of String)()
                    AllAnimationFiles.AddRange(Directory.GetFiles(Path.GetDirectoryName(PNG_file), "*.png", SearchOption.TopDirectoryOnly).Where(Function(x) Path.GetFileName(x).StartsWith(PNG_fileNameNoExt + "_"))) 'Check if there are any files starting with sprite name _
                    Console.WriteLine("PNG_fileNameNoExt: " + PNG_fileNameNoExt)
                    'For Each str As String In AllAnimationFiles
                    'Console.WriteLine(str)
                    'Next
                    'Console.WriteLine(AllAnimationFiles.Count)
                    If AllAnimationFiles.Count > 1 Then 'If array cotaining file names is more then 1 add to error list
                        Console.WriteLine("PNG_file: " + PNG_file)
                        TempListofFiles.Add("Part of a object that is missing its animation name. | " + PNG_filefull)
                    End If
                Else
                    If PNG_fileName.ToLower.StartsWith("tiled_") Then
                        RichTextBox_Correct.SelectionColor = Color.MediumTurquoise
                        RichTextBox_Correct.AppendText("Tiled: ")
                        RichTextBox_Correct.SelectionColor = Color.WhiteSmoke
                        RichTextBox_Correct.AppendText(PNG_fileName & vbNewLine)
                    ElseIf PNG_fileName.ToLower.StartsWith("9patch_") Then
                        RichTextBox_Correct.SelectionColor = Color.PaleGoldenrod
                        RichTextBox_Correct.AppendText("9 Patch: ")
                        RichTextBox_Correct.SelectionColor = Color.WhiteSmoke
                        RichTextBox_Correct.AppendText(PNG_fileName & vbNewLine)
                    ElseIf CountCharacter(PNG_fileName, CChar("_")) = 0 Then
                        RichTextBox_Correct.SelectionColor = Color.HotPink
                        RichTextBox_Correct.AppendText("Single frame: ")
                        RichTextBox_Correct.SelectionColor = Color.WhiteSmoke
                        RichTextBox_Correct.AppendText(PNG_fileName & vbNewLine)
                    ElseIf CountCharacter(PNG_fileName, CChar("_")) <= 2 Then
                        RichTextBox_Correct.SelectionColor = Color.LightSkyBlue
                        RichTextBox_Correct.AppendText("Multi frame: ")
                        RichTextBox_Correct.SelectionColor = Color.WhiteSmoke
                        RichTextBox_Correct.AppendText(PNG_fileName & vbNewLine)
                    End If
                End If
            Else
                ContainsIgnoredDirectories = True
            End If
        Next

        If ContainsIgnoredDirectories = True Then
            Label_Status.Text = "Scan Completed, Contains Ignored Directories!"
        Else
            Label_Status.Text = "Scan Completed."
        End If
        Label_Status.Refresh()

        ListBox_Errors.Items.AddRange(TempListofFiles.ToArray)
    End Sub
    'ListBox_Errors - SelectedValueChanged
    Private Sub ListBox_Errors_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox_Errors.SelectedValueChanged
        If Not ListBox_Errors.SelectedIndex = -1 Then
            Label_CurrentName.Text = "Current Name: "
            PixelBox1.Image = Nothing
            TextBox_NewName.Clear()
            If Not ListBox_Errors.SelectedItem.ToString.StartsWith("Possible") And Not ListBox_Errors.SelectedItem.ToString.StartsWith("Invalid") Then
                If ListBox_Errors.SelectedItem.ToString.Contains("|") And File.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString.Substring(ListBox_Errors.SelectedItem.ToString.IndexOf("|") + 2)) Then
                    Label_CurrentName.Text = "Current Name: " & Path.GetFileNameWithoutExtension(ListBox_Errors.SelectedItem.ToString.Substring(ListBox_Errors.SelectedItem.ToString.IndexOf("|") + 2))
                    TextBox_NewName.Text = Path.GetFileNameWithoutExtension(ListBox_Errors.SelectedItem.ToString.Substring(ListBox_Errors.SelectedItem.ToString.IndexOf("|") + 2))
                    PixelBox1.Image = SafeImageFromFile(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString.Substring(ListBox_Errors.SelectedItem.ToString.IndexOf("|") + 2))
                ElseIf File.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString) Then
                    Label_CurrentName.Text = "Current Name: " & Path.GetFileNameWithoutExtension(ListBox_Errors.SelectedItem.ToString)
                    TextBox_NewName.Text = Path.GetFileNameWithoutExtension(ListBox_Errors.SelectedItem.ToString)
                    PixelBox1.Image = SafeImageFromFile(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString)
                ElseIf Path.HasExtension(ListBox_Errors.SelectedItem.ToString) Then
                    ClearForNext()
                    MsgBox("Selected file doesn't exist directory will now be reloaded.", MsgBoxStyle.Information)
                    If Directory.Exists(FolderBrowserDialog_Selected_Directory.SelectedPath) Then
                        LoadFiles()
                    Else
                        MsgBox("This path no longer exists, Please select a new directory.", MsgBoxStyle.Information)
                    End If
                End If
            End If
        End If
    End Sub
    'Button_Rename - Click
    Private Sub Button_Rename_Click(sender As Object, e As EventArgs) Handles Button_Rename.Click
        Try
            Dim PNG_filefull As String = TextBox_NewName.Text
            Dim PNG_file = Path.GetFileNameWithoutExtension(TextBox_NewName.Text)
            If Not regexValidWords.IsMatch(PNG_file) Or regexInvalidWords.IsMatch(PNG_file) Or CountCharacter(PNG_file, CChar("_")) > 2 Or PNG_filefull.ToLower.EndsWith(".png.png") Or Not Char.IsLetter(PNG_file.First) And Not PNG_file.ToLower.StartsWith("9patch_") Then
                MsgBox("Not a vaild file name.", MsgBoxStyle.Exclamation)
            Else
                If Not ListBox_Errors.SelectedIndex = -1 And Not Label_CurrentName.Text = "Current Name: " Then
                    Dim newfilepath As String = Path.GetDirectoryName(ListBox_Errors.SelectedItem.ToString) + "\" + TextBox_NewName.Text & ".png"
                    My.Computer.FileSystem.RenameFile(FolderBrowserDialog_Selected_Directory.SelectedPath & "\" & ListBox_Errors.SelectedItem.ToString, TextBox_NewName.Text & ".png")
                    ListBox_Errors.Items.RemoveAt(ListBox_Errors.SelectedIndex)
                    Label_CurrentName.Text = "Current Name: "
                    PixelBox1.Image = Nothing
                    TextBox_NewName.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'TextBox_NewName - KeyPress
    Private Sub TextBox_NewName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_NewName.KeyPress
        If e.KeyChar = Chr(13) And TextBox_NewName.Text.Length > 0 Then
            e.Handled = True
            Button_Rename.PerformClick()
        End If
    End Sub
    'clear all for next
    Private Sub ClearForNext()
        PixelBox1.ImageLocation = ""
        PixelBox1.Image = Nothing
        ListBox_Errors.Items.Clear()
        RichTextBox_Correct.Clear()
        TextBox_Selected_Directory.Clear()
        Label_CurrentName.Text = "Current Name: "
        TextBox_NewName.Clear()
    End Sub
    'FileNameValidator - DragEnter
    Private Sub FileNameValidator_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Directory.Exists(Folders(0)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'FileNameValidator - DragDrop
    Private Sub FileNameValidator_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim Folders() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        FolderBrowserDialog_Selected_Directory.SelectedPath = Folders(0)
        LoadFiles()
    End Sub
    'LinkLabel_Wiki_Info - LinkClicked
    Private Sub LinkLabel_Wiki_Info_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Wiki_Info.LinkClicked
        LinkLabel_Wiki_Info.LinkVisited = True
        Process.Start("https://wiki.gdevelop.io/gdevelop5/community/contribute-to-the-assets-store#for_images_to_make_sprite_tiled_sprite_or_panel_sprite_objects")
    End Sub
    'SafeImageFromFile()
    Public Shared Function SafeImageFromFile(path As String) As Image
        Dim bytes = File.ReadAllBytes(path)
        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms)
            Return img
        End Using
    End Function
    '
    'Window Handle Code
    '
    'Move Window - Panel
    Private Sub Panel_Main_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Main.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Panel_Main.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub
    'Move Window - Label_Application_Title
    Private Sub Label_Application_Title_MouseDown(sender As Object, e As MouseEventArgs) Handles Label_Application_Title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Label_Application_Title.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub
    'Minimize
    Private Sub PictureBox_Minimize_Click(sender As Object, e As EventArgs) Handles PictureBox_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Close
    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        Me.Close()
    End Sub
    'Minimize Blue
    Private Sub PictureBox_Minimize_MouseHover(sender As Object, e As EventArgs) Handles PictureBox_Minimize.MouseHover
        PictureBox_Minimize.Image = My.Resources.Minimize_Blue
    End Sub
    'Minimize Grey
    Private Sub PictureBox_Minimize_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_Minimize.MouseLeave
        PictureBox_Minimize.Image = My.Resources.Minimize_Grey
    End Sub
    'Form Deactivate Close Grey
    Private Sub Main_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        PictureBox_Close.Image = My.Resources.Close_Grey
        Panel_Main.BackColor = Color.FromArgb(28, 30, 34)
    End Sub
    'Form Activated Close Red
    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        PictureBox_Close.Image = My.Resources.Close_Red
        Panel_Main.BackColor = Color.Black
    End Sub
End Class