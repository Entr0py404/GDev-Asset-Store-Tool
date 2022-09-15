Imports FastColoredTextBoxNS

Public Class ClipboardAsset
    ReadOnly SupportedIamgeFormats() As String = {".png", ".bmp", ".jpeg", ".jpg", ".tiff", ".tif"}
    Dim ForceImageAspectRatio_1_1_Size As Size
    Dim aspectRatio_IsAlready_1_1 As Boolean = False
    Dim ObjectsJson As New JArray
    Dim objectAssets As New JArray
    Private Sub ClipboardAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip_PreviewImage.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub
    'Button_PasteObjects - Click
    Private Sub Button_PasteObjects_Click(sender As Object, e As EventArgs) Handles Button_PasteObject.Click
        If Clipboard.ContainsText Then
            Dim CB_Text As String = Clipboard.GetText
            If CB_Text.Contains("GDEVELOP_Object_CLIPBOARD_KIND") Or CB_Text.Contains("000kind") Then
                Dim jsonFromClipboard As JObject = JObject.Parse(CB_Text)
                ListBox_Objects.Items.Add(jsonFromClipboard.Item("content")("name"))
                ObjectsJson.Add(jsonFromClipboard.SelectToken("content")("object"))
                'Console.WriteLine(jsonFromClipboard.SelectToken("content")("object"))

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
                        'Console.WriteLine(Path.GetDirectoryName(SaveFileDialog1.FileName) & "\" & tempImageName & ".preview.png")
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
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                'ClearPicturebox
                PixelBox_PreviewImage.Image = Image.FromFile(files(0))
                ErrorProvider1.SetError(PixelBox_PreviewImage, Nothing)

                Dim aspectRatio As Decimal = CDec(PixelBox_PreviewImage.Image.Width / PixelBox_PreviewImage.Image.Height)
                Dim Ratio_1_1 As Decimal = 1
                aspectRatio_IsAlready_1_1 = Decimal.Equals(aspectRatio, Ratio_1_1)
                'Console.WriteLine(aspectRatio_IsAlready_1_1)
                'Console.WriteLine(aspectRatio)

                If aspectRatio_IsAlready_1_1 = False Then
                    Dim n1 As Double = PixelBox_PreviewImage.Image.Width
                    'Console.WriteLine(n1)

                    Dim n2 As Double = PixelBox_PreviewImage.Image.Height
                    n2 = n1
                    'Console.WriteLine(n2)

                    ForceImageAspectRatio_1_1_Size.Width = Convert.ToInt32(n1)
                    ForceImageAspectRatio_1_1_Size.Height = Convert.ToInt32(n2)
                End If
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_PreviewImage - DragEnter
    Private Sub Panel_PreviewImage_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_PreviewImage.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And SupportedIamgeFormats.Contains(Path.GetExtension(files(0)).ToLower) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
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