Imports FastColoredTextBoxNS

Public Class ClipboardAsset
    ReadOnly SupportedIamgeFormats() As String = {".png", ".bmp", ".jpeg", ".jpg", ".tiff", ".tif"}
    Dim ForceImageAspectRatio_1_1_Size As Size
    Dim aspectRatio_IsAlready_1_1 As Boolean = False
    Dim ObjectsJson As New JArray
    Dim objectAssets As New JArray
    Private key As New TextStyle(Brushes.MediumAquamarine, Nothing, FontStyle.Regular)
    Private str As New TextStyle(Brushes.PaleGoldenrod, Nothing, FontStyle.Regular)
    Private boo As New TextStyle(Brushes.MediumSlateBlue, Nothing, FontStyle.Regular)
    Private num As New TextStyle(Brushes.DeepPink, Nothing, FontStyle.Regular)
    Private nul As New TextStyle(Brushes.DarkGray, Nothing, FontStyle.Regular)
    'ClipboardAsset - Load
    Private Sub ClipboardAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip_PreviewImage.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_AssetJSON.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_Resources.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub
    'Button_PasteObjects - Click
    Private Sub Button_PasteObjects_Click(sender As Object, e As EventArgs) Handles Button_PasteObject.Click
        If Clipboard.ContainsText Then
            Dim CB_Text As String = Clipboard.GetText
            If CB_Text.Contains("GDEVELOP_Object_CLIPBOARD_KIND") Or CB_Text.Contains("000kind") Then
                Dim jsonFromClipboard As JObject = JObject.Parse(CB_Text)
                ListBox_Objects.Items.Add(jsonFromClipboard.Item("content")("name"))
                ObjectsJson.Add(jsonFromClipboard.SelectToken("content")("object"))
                ErrorProvider1.SetError(ListBox_Objects, Nothing)
            End If
        End If
    End Sub
    'ListBox_Objects - DoubleClick
    Private Sub ListBox_Objects_DoubleClick(sender As Object, e As EventArgs) Handles ListBox_Objects.DoubleClick
        If Not ListBox_Objects.SelectedIndex = -1 Then
            ObjectsJson.RemoveAt(ListBox_Objects.SelectedIndex)
            ListBox_Objects.Items.RemoveAt(ListBox_Objects.SelectedIndex)

            If ListBox_Objects.Items.Count = 0 Then
                ErrorProvider1.SetError(ListBox_Objects, "Required")
            End If
        End If
    End Sub
    'Button_GenerateAsset - Click
    Private Sub Button_GenerateAsset_Click(sender As Object, e As EventArgs) Handles Button_GenerateAsset.Click
        If TextBox_Description.Text.Length > 0 And ListBox_Objects.Items.Count > 0 Then
            Dim jsonFile As JObject = JObject.Parse(My.Resources.asset_template)

            jsonFile.Item("description") = TextBox_Description.Text

            For i As Integer = 0 To ListBox_Objects.Items.Count - 1
                Dim jsonFile_objectAssets As JObject = JObject.Parse(My.Resources.objectAssets_template)
                jsonFile_objectAssets.Item("object") = ObjectsJson.Item(i)
                objectAssets.Add(jsonFile_objectAssets)
            Next

            jsonFile.Item("objectAssets") = objectAssets

            FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            ErrorProvider1.SetError(FastColoredTextBox_AssetJson, Nothing)

            objectAssets.Clear()
        Else

            If TextBox_Description.Text.Length = 0 Then
                ErrorProvider1.SetError(TextBox_Description, "Required")
            End If

            If ListBox_Objects.Items.Count = 0 Then
                ErrorProvider1.SetError(ListBox_Objects, "Required")
            End If

            MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
        End If
    End Sub
    'Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If TextBox_Description.Text.Length > 0 And FastColoredTextBox_AssetJson.Text.Length > 0 And PixelBox_PreviewImage.Image IsNot Nothing Then
            If SaveFileDialog1.InitialDirectory = "" Then
                If Directory.Exists(MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath) Then
                    SaveFileDialog1.InitialDirectory = MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath
                Else
                    SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
                End If
            End If

            If ListBox_Objects.Items.Count = 1 Then
                SaveFileDialog1.FileName = ListBox_Objects.Items.Item(0).ToString
            Else
                SaveFileDialog1.FileName = ""
            End If

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim tempImageName As String = Path.GetFileNameWithoutExtension(SaveFileDialog1.FileName)
                tempImageName = Path.GetFileNameWithoutExtension(tempImageName)

                If aspectRatio_IsAlready_1_1 = False Then
                    Dim bmp = New Bitmap(ForceImageAspectRatio_1_1_Size.Width, ForceImageAspectRatio_1_1_Size.Height)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        'draw the original at the new size on memory bitmap
                        g.DrawImage(PixelBox_PreviewImage.Image, 0, 0, bmp.Width, bmp.Height)
                        'save the temp resized bitmamp
                        bmp.Save(Path.GetDirectoryName(SaveFileDialog1.FileName) & "\" & tempImageName & ".preview.png", Imaging.ImageFormat.Png)
                    End Using
                Else
                    PixelBox_PreviewImage.Image.Save(Path.GetDirectoryName(SaveFileDialog1.FileName) & "\" & tempImageName & ".preview.png", Imaging.ImageFormat.Png)
                End If

                'Write Asset Json
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox_AssetJson.Text, False)

                'Clear all
                TextBox_Description.Clear()
                ListBox_Objects.Items.Clear()
                FastColoredTextBox_AssetJson.Clear()
                PixelBox_PreviewImage.Image = Nothing
                ObjectsJson.Clear()
                objectAssets.Clear()

            End If
        Else

            'If TextBox_Description.Text.Length = 0 Then
            'ErrorProvider1.SetError(TextBox_Description, "Required")
            'End If

            If PixelBox_PreviewImage.Image Is Nothing Then
                ErrorProvider1.SetError(PixelBox_PreviewImage, "Required")
            End If

            If FastColoredTextBox_AssetJson.Text.Length = 0 Then
                ErrorProvider1.SetError(FastColoredTextBox_AssetJson, "Required")
            End If

            MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
        End If
    End Sub
    'Panel_PreviewImage - DragDrop
    Private Sub Panel_PreviewImage_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_PreviewImage.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If files.Length <> 0 Then
                Try
                    'ClearPicturebox
                    PixelBox_PreviewImage.Image = SafeImageFromFile(files(0))
                    ErrorProvider1.SetError(PixelBox_PreviewImage, Nothing)

                    Dim aspectRatio As Decimal = CDec(PixelBox_PreviewImage.Image.Width / PixelBox_PreviewImage.Image.Height)
                    Dim Ratio_1_1 As Decimal = 1
                    aspectRatio_IsAlready_1_1 = Decimal.Equals(aspectRatio, Ratio_1_1)

                    If aspectRatio_IsAlready_1_1 = False Then
                        Dim n1 As Double = PixelBox_PreviewImage.Image.Width

                        Dim n2 As Double = PixelBox_PreviewImage.Image.Height
                        n2 = n1

                        ForceImageAspectRatio_1_1_Size.Width = Convert.ToInt32(n1)
                        ForceImageAspectRatio_1_1_Size.Height = Convert.ToInt32(n2)
                    End If
                Catch ex As Exception
                    MsgBox("Problem opening file.", MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub
    'Panel_PreviewImage - DragEnter
    Private Sub Panel_PreviewImage_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_PreviewImage.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If e.Data.GetDataPresent(DataFormats.FileDrop) And SupportedIamgeFormats.Contains(Path.GetExtension(files(0)).ToLower) Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        End If
    End Sub
    'ContextMenuStrip_PreviewImage - Opening
    Private Sub ContextMenuStrip_PreviewImage_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_PreviewImage.Opening
        If PixelBox_PreviewImage.Image IsNot Nothing Then
            SaveToolStripMenuItem.Enabled = True
        Else
            SaveToolStripMenuItem.Enabled = False
        End If
    End Sub
    'Save (ToolStripMenuItem) - Click
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveFileDialog_PreviewImage.ShowDialog = DialogResult.OK Then
            If aspectRatio_IsAlready_1_1 = False Then
                Dim bmp = New Bitmap(ForceImageAspectRatio_1_1_Size.Width, ForceImageAspectRatio_1_1_Size.Height)
                Using g As Graphics = Graphics.FromImage(bmp)
                    'draw the original at the new size on memory bitmap
                    g.DrawImage(PixelBox_PreviewImage.Image, 0, 0, bmp.Width, bmp.Height)
                    'save the temp resized bitmamp
                    bmp.Save(SaveFileDialog_PreviewImage.FileName, Imaging.ImageFormat.Png)
                End Using
            Else
                PixelBox_PreviewImage.Image.Save(SaveFileDialog_PreviewImage.FileName, Imaging.ImageFormat.Png)
            End If
        End If
    End Sub
    'TextBox_Description  - GotFocus
    Private Sub TextBox_Description_GotFocus(sender As Object, e As EventArgs) Handles TextBox_Description.GotFocus
        ErrorProvider1.SetError(TextBox_Description, Nothing)
    End Sub
    'TextBox_Description - LostFocus
    Private Sub TextBox_Description_LostFocus(sender As Object, e As EventArgs) Handles TextBox_Description.LostFocus
        If TextBox_Description.Text.Length = 0 Then
            ErrorProvider1.SetError(TextBox_Description, "Required")
        End If
    End Sub
    'FastColoredTextBox_AssetJson - TextChanging
    Private Sub FastColoredTextBox_AssetJson_TextChanging(sender As Object, e As TextChangingEventArgs) Handles FastColoredTextBox_AssetJson.TextChanging
        If FastColoredTextBox_AssetJson.Text.Length = 0 Then
            ErrorProvider1.SetError(FastColoredTextBox_AssetJson, "Required")
        Else
            ErrorProvider1.SetError(FastColoredTextBox_AssetJson, Nothing)
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
    'FastColoredTextBox_AssetJson - TextChanged
    Private Sub FastColoredTextBox_AssetJson_TextChanged(sender As Object, e As TextChangedEventArgs) Handles FastColoredTextBox_AssetJson.TextChanged
        e.ChangedRange.ClearFoldingMarkers()
        e.ChangedRange.SetFoldingMarkers("{", "}")
        e.ChangedRange.SetFoldingMarkers("\[", "\]")
        FastColoredTextBox_AssetJson.Range.ClearStyle(key, str, boo, nul)
        For Each found As Range In FastColoredTextBox_AssetJson.GetRanges("(¤(\\u[a-zA-Z0-9]{4}|\\[^u]|[^\\¤])*¤(\s*:)?|\b(true|false|null)\b|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?)".Replace("¤"c, """"c))
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
    'FastColoredTextBox_Resources - DragDrop
    Private Sub FastColoredTextBox_Resources_DragDrop(sender As Object, e As DragEventArgs) Handles FastColoredTextBox_Resources.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If files.Length <> 0 Then
                Try
                    Dim jsonFile As JObject = JObject.Parse(File.ReadAllText(files(0)))
                    TextBox_ProjectFilepath.Text = files(0)
                    FastColoredTextBox_Resources.Text = jsonFile.Item("resources")("resources").ToString
                Catch ex As Exception
                    MsgBox("Problem opening file.", MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub
    'FastColoredTextBox_Resources - DragEnter
    Private Sub FastColoredTextBox_Resources_DragEnter(sender As Object, e As DragEventArgs) Handles FastColoredTextBox_Resources.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If Path.GetExtension(files(0)) = ".json" Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        End If
    End Sub
    'FastColoredTextBox_Resources - TextChanged
    Private Sub FastColoredTextBox_Resources_TextChanged(sender As Object, e As TextChangedEventArgs) Handles FastColoredTextBox_Resources.TextChanged
        e.ChangedRange.ClearFoldingMarkers()
        e.ChangedRange.SetFoldingMarkers("{", "}")
        e.ChangedRange.SetFoldingMarkers("\[", "\]")
        FastColoredTextBox_Resources.Range.ClearStyle(key, str, boo, nul)
        For Each found As Range In FastColoredTextBox_Resources.GetRanges("(¤(\\u[a-zA-Z0-9]{4}|\\[^u]|[^\\¤])*¤(\s*:)?|\b(true|false|null)\b|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?)".Replace("¤"c, """"c))
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
    '
    'ContextMenuStrip - Resources
    '
    'CutToolStripMenuItem_Click
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        FastColoredTextBox_Resources.Cut()
    End Sub
    'CopyToolStripMenuItem_Click
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        FastColoredTextBox_Resources.Copy()
    End Sub
    'ClearToolStripMenuItem_Click
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        FastColoredTextBox_Resources.Clear()
        TextBox_ProjectFilepath.Clear()
    End Sub
    'ReloadToolStripMenuItem_Click
    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        If File.Exists(TextBox_ProjectFilepath.Text) Then
            Dim jsonFile As JObject = JObject.Parse(File.ReadAllText(TextBox_ProjectFilepath.Text))
            FastColoredTextBox_Resources.Text = jsonFile.Item("resources")("resources").ToString
        Else
            'Tell the user that the file does not exist

            'Clear the bad path
            TextBox_ProjectFilepath.Clear()
        End If
    End Sub
    'ContextMenuStrip_Resources - Opening
    Private Sub ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_Resources.Opening
        If Not FastColoredTextBox_Resources.SelectionLength = 0 Then
            CutToolStripMenuItem.Enabled = True
            CopyToolStripMenuItem.Enabled = True
        Else
            CutToolStripMenuItem.Enabled = False
            CopyToolStripMenuItem.Enabled = False
        End If

        If Not TextBox_ProjectFilepath.Text = "" Then
            ReloadToolStripMenuItem.Enabled = True
        Else
            ReloadToolStripMenuItem.Enabled = False
        End If
    End Sub
    '
    'ContextMenuStrip - AssetJSON
    '
    'CutToolStripMenuItem1 - Click
    Private Sub CutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem1.Click
        FastColoredTextBox_AssetJson.Cut()
    End Sub
    'CopyToolStripMenuItem1 - Click
    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        FastColoredTextBox_AssetJson.Copy()
    End Sub
    'PasteToolStripMenuItem - Click
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        FastColoredTextBox_AssetJson.Paste()
    End Sub
    'ContextMenuStrip_AssetJSON - Opening
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_AssetJSON.Opening
        If Not FastColoredTextBox_AssetJson.SelectionLength = 0 Then
            CutToolStripMenuItem1.Enabled = True
            CopyToolStripMenuItem1.Enabled = True
        Else
            CutToolStripMenuItem1.Enabled = False
            CopyToolStripMenuItem1.Enabled = False
        End If
        If Clipboard.ContainsText Then
            PasteToolStripMenuItem.Enabled = True
        Else
            PasteToolStripMenuItem.Enabled = False
        End If
    End Sub
End Class