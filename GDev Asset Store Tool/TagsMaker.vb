﻿Public Class TagsMaker
    Dim TAGS_StringBuilder As New StringBuilder
    ReadOnly SpecialTags As String() = {"top-down", "side view", "isometric", "interface"}
    'TagsMaker - Load
    Private Sub TagsMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadFileAssetFilters()
        SetFileAgeLable()
    End Sub
    'ListBox_ExistingTags - DoubleClick
    Private Sub ListBox_ExistingTags_DoubleClick(sender As Object, e As EventArgs) Handles ListBox_ExistingTags.DoubleClick
        If Not ListBox_ExistingTags.SelectedIndex = -1 Then
            If Not ListBox_TAGS.Items.Contains(ListBox_ExistingTags.SelectedItem.ToString.ToLower) Then
                ListBox_TAGS.Items.Add(ListBox_ExistingTags.SelectedItem.ToString.ToLower)
            End If
        End If
    End Sub
    'ListBox_SpecialTags - DoubleClick
    Private Sub ListBox_SpecialTags_DoubleClick(sender As Object, e As EventArgs) Handles ListBox_SpecialTags.DoubleClick
        If Not ListBox_SpecialTags.SelectedIndex = -1 Then
            If Not ListBox_TAGS.Items.Contains(ListBox_SpecialTags.SelectedItem) Then
                ListBox_TAGS.Items.Add(ListBox_SpecialTags.SelectedItem)
            End If
        End If
    End Sub
    'ListBox_TAGS - DoubleClick
    Private Sub ListBox_TAGS_DoubleClick(sender As Object, e As EventArgs) Handles ListBox_TAGS.DoubleClick
        If Not ListBox_TAGS.SelectedIndex = -1 Then
            ListBox_TAGS.Items.RemoveAt(ListBox_TAGS.SelectedIndex)
        End If
    End Sub
    'Panel_TAGSmd - DragDrop
    Private Sub Panel_TAGSmd_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_TAGSmd.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                ListBox_TAGS.Items.Clear()
                SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(files(0))
                Dim TagsFileStr As String = File.ReadAllText(files(0))
                Dim Tags As String() = TagsFileStr.Split(New Char() {","c})
                For Each Tag As String In Tags
                    ListBox_TAGS.Items.Add(Tag)
                Next
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_TAGSmd - DragEnter
    Private Sub Panel_TAGSmd_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_TAGSmd.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Path.GetExtension(files(0)) = ".md" Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    'TextBox_NewTag - KeyPress
    Private Sub TextBox_NewTag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_NewTag.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And TextBox_NewTag.Text.Length > 0 Then
            If Not ListBox_TAGS.Items.Contains(TextBox_NewTag.Text.ToLower) Then
                e.Handled = True
                ListBox_TAGS.Items.Add(TextBox_NewTag.Text.ToLower)
                TextBox_NewTag.Clear()
            End If
        End If
    End Sub
    'Button_Open - Click
    Private Sub Button_Open_Click(sender As Object, e As EventArgs) Handles Button_Open.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ListBox_TAGS.Items.Clear()
            Dim Filestr As String = File.ReadAllText(OpenFileDialog1.FileName)
            Dim Tags As String() = Filestr.Split(New Char() {","c})
            For Each Tag As String In Tags
                ListBox_TAGS.Items.Add(Tag)
            Next
        End If
    End Sub
    'Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Dim HasSpecialTag As Boolean = False
        For Each item As String In ListBox_TAGS.Items
            If SpecialTags.Contains(item) Then
                HasSpecialTag = True
                Exit For
            End If
        Next

        If HasSpecialTag = False Then
            MsgBox("You must include at least one speacial tag," & vbNewLine & "(top-down, side view, isometric, interface)." & vbNewLine & "The tag 'pixel art' is a optionary tag.", MsgBoxStyle.Information)
        Else
            SaveFileDialog1.FileName = "TAGS.md"
            If SaveFileDialog1.InitialDirectory = "" Then
                If MetadataGenerator.TreeView1.Nodes.Count > 0 Then
                    If Directory.Exists(MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + MetadataGenerator.TreeView1.SelectedNode.FullPath) Then
                        SaveFileDialog1.InitialDirectory = MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath + "\" + MetadataGenerator.TreeView1.SelectedNode.FullPath
                    ElseIf Directory.Exists(MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath) Then
                        SaveFileDialog1.InitialDirectory = MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath
                    Else
                        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
                    End If
                Else
                    SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
                End If
            End If

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Build_TAGS()
                File.WriteAllText(SaveFileDialog1.FileName, TAGS_StringBuilder.ToString)
                'Clear all for next
                SaveFileDialog1.InitialDirectory = ""
                TextBox_NewTag.Clear()
                ListBox_TAGS.Items.Clear()
            End If
        End If
    End Sub
    'Build_TAGS
    Private Sub Build_TAGS()
        TAGS_StringBuilder.Clear()
        For Num = 0 To ListBox_TAGS.Items.Count - 1
            If Not Num = ListBox_TAGS.Items.Count - 1 Then
                TAGS_StringBuilder.Append(ListBox_TAGS.Items.Item(Num).ToString & ",")
            Else
                TAGS_StringBuilder.Append(ListBox_TAGS.Items.Item(Num).ToString)
            End If
        Next
    End Sub
    'Button_Download - Click
    Private Sub Button_Download_Click(sender As Object, e As EventArgs) Handles Button_Download.Click
        My.Computer.Network.DownloadFile("https://resources.gdevelop-app.com/assets-database/assetFilters.json", Application.StartupPath & "\assetFilters.json", "", "", True, 500, True)
        SetFileAgeLable()
        ListBox_ExistingTags.Items.Clear()
        ReadFileAssetFilters()
    End Sub
    'Set File Age Lable
    Private Sub SetFileAgeLable()
        If File.Exists("assetFilters.json") Then
            Dim fileLastWriteTime As DateTime = File.GetLastWriteTime("assetFilters.json")
            Dim days As String = (DateTime.Now - fileLastWriteTime.Date).Days.ToString
            Label_FileAge.Text = "assetFilters.json file is " & days & " days old"
        Else
            Label_FileAge.Text = "No assetFilters.json file"
        End If
    End Sub
    'Read assetFilters File
    Public Sub ReadFileAssetFilters()
        Try
            Dim Filestr As String = ""
            If File.Exists("assetFilters.json") Then
                Filestr = File.ReadAllText("assetFilters.json")
            End If
            If Not Filestr = "" Then
                Dim jsonFile As JObject = JObject.Parse(Filestr)
                ListBox_ExistingTags.Items.AddRange(jsonFile.SelectToken("allTags").ToArray)
                ListBox_ExistingTags.EndUpdate()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'LinkLabel_Wiki_Info - LinkClicked
    Private Sub LinkLabel_Wiki_Info_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Wiki_Info.LinkClicked
        LinkLabel_Wiki_Info.LinkVisited = True
        Process.Start("https://wiki.gdevelop.io/gdevelop5/community/contribute-to-the-assets-store#organizing_the_assets_with_tags")
    End Sub
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