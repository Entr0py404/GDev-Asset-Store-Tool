Imports FastColoredTextBoxNS

Public Class TemplateAsset
    ReadOnly SupportedIamgeFormats() As String = {".png", ".bmp", ".jpeg", ".jpg", ".tiff", ".tif"}
    Dim ForceImageAspectRatio_16_9_Size As Size
    Dim aspectRatio_IsAlready_16_9 As Boolean = False
    'TemplateAsset - Load
    Private Sub TemplateAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Region = New Region(New RectangleF(Me.TabPage_BitmapText.Left, Me.TabPage_BitmapText.Top, Me.TabPage_BitmapText.Width, Me.TabPage_BitmapText.Height))
        ComboBox_TilemapDisplayMode.SelectedIndex = 0
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_PreviewImage.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub
    'BitmapText (ToolStripMenuItem) - Click
    Private Sub BitmapTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitmapTextToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_BitmapText
        ResetToolStripMenuItemBackGroundColors()
        BitmapTextToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub
    'Light (ToolStripMenuItem) - Click
    Private Sub LightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_Light
        ResetToolStripMenuItemBackGroundColors()
        LightToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub
    'Tilemap (ToolStripMenuItem) - Click
    Private Sub TilemapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TilemapToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_Tilemap
        ResetToolStripMenuItemBackGroundColors()
        TilemapToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub
    'PanelSprite (ToolStripMenuItem) - Click
    Private Sub PanelSpriteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanelSpriteToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_PanelSprite
        ResetToolStripMenuItemBackGroundColors()
        PanelSpriteToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub
    'ResetToolStripMenuItemBackGroundColors
    Private Sub ResetToolStripMenuItemBackGroundColors()
        BitmapTextToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        LightToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        TilemapToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        PanelSpriteToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
    End Sub
    'Button_GenerateAsset - Click
    Private Sub Button_GenerateAsset_Click(sender As Object, e As EventArgs) Handles Button_GenerateAsset.Click
        If TabControl1.SelectedTab Is TabPage_BitmapText Then

            If TextBox_Name.Text.Length > 0 And TextBox_Description.Text.Length > 0 And TextBox_BitmapAtlasImage.Text.EndsWith(".png") And (TextBox_BitmapFont.Text.EndsWith(".fnt") Or TextBox_BitmapFont.Text.EndsWith(".xml")) Then
                FastColoredTextBox_AssetJson.Clear()
                Dim jsonFile As JObject = JObject.Parse(My.Resources.bitmaptext_template)
                jsonFile.Item("description") = TextBox_Description.Text
                jsonFile.Item("objectAssets")(0)("object")("name") = TextBox_Name.Text
                jsonFile.Item("objectAssets")(0)("object")("content")("scale") = CInt(NumericUpDown_BitmapTextScale.Value)
                jsonFile.Item("objectAssets")(0)("object")("content")("bitmapFontResourceName") = TextBox_BitmapFont.Text
                jsonFile.Item("objectAssets")(0)("object")("content")("textureAtlasResourceName") = TextBox_BitmapAtlasImage.Text
                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
                ErrorProvider1.SetError(FastColoredTextBox_AssetJson, Nothing)
            Else

                If TextBox_Name.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Name, "Required")
                End If

                If TextBox_Description.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Description, "Required")
                End If

                If Not TextBox_BitmapAtlasImage.Text.EndsWith(".png") Then
                    ErrorProvider1.SetError(TextBox_BitmapAtlasImage, "Blank or does not end with .png")
                End If

                If Not TextBox_BitmapFont.Text.EndsWith(".fnt") Or Not TextBox_BitmapFont.Text.EndsWith(".xml") Then
                    ErrorProvider1.SetError(TextBox_BitmapFont, "Blank or does not end with .fnt or .xml")
                End If

                MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
            End If

        ElseIf TabControl1.SelectedTab Is TabPage_Light Then

            If TextBox_Name.Text.Length > 0 And TextBox_Description.Text.Length > 0 And TextBox_LightTexture.Text.EndsWith(".png") Then
                FastColoredTextBox_AssetJson.Clear()
                Dim jsonFile As JObject = JObject.Parse(My.Resources.light_template)
                jsonFile.Item("description") = TextBox_Description.Text
                jsonFile.Item("objectAssets")(0)("object")("name") = TextBox_Name.Text
                jsonFile.Item("objectAssets")(0)("object")("content")("radius") = CInt(NumericUpDown_LightRadius.Value)
                jsonFile.Item("objectAssets")(0)("object")("content")("color") = Button_LightColor.BackColor.R.ToString & ";" & Button_LightColor.BackColor.G.ToString & ";" & Button_LightColor.BackColor.B.ToString
                jsonFile.Item("objectAssets")(0)("object")("content")("texture") = TextBox_LightTexture.Text
                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            Else

                If TextBox_Name.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Name, "Required")
                End If

                If TextBox_Description.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Description, "Required")
                End If

                If Not TextBox_LightTexture.Text.EndsWith(".png") Then
                    ErrorProvider1.SetError(TextBox_LightTexture, "Blank or does not end with .png")
                End If

                MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
            End If

        ElseIf TabControl1.SelectedTab Is TabPage_PanelSprite Then

            If TextBox_Name.Text.Length > 0 And TextBox_Description.Text.Length > 0 And TextBox_PanelSpriteIamge.Text.EndsWith(".png") Then
                FastColoredTextBox_AssetJson.Clear()
                Dim jsonFile As JObject = JObject.Parse(My.Resources.panelsprite_template)
                jsonFile.Item("description") = TextBox_Description.Text
                jsonFile.Item("objectAssets")(0)("object")("name") = TextBox_Name.Text
                jsonFile.Item("objectAssets")(0)("object")("bottomMargin") = CInt(NumericUpDown_PSBottomMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("height") = CInt(NumericUpDown_PSDefaultHeight.Value)
                jsonFile.Item("objectAssets")(0)("object")("leftMargin") = CInt(NumericUpDown_PSLeftMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("rightMargin") = CInt(NumericUpDown_PSRightMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("texture") = TextBox_PanelSpriteIamge.Text
                jsonFile.Item("objectAssets")(0)("object")("tiled") = CheckBox_PSRepeatBoarders.Checked
                jsonFile.Item("objectAssets")(0)("object")("topMargin") = CInt(NumericUpDown_PSTopMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("width") = CInt(NumericUpDown_DefaultWidth.Value)
                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            Else

                If TextBox_Name.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Name, "Required")
                End If

                If TextBox_Description.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Description, "Required")
                End If

                If Not TextBox_PanelSpriteIamge.Text.EndsWith(".png") Then
                    ErrorProvider1.SetError(TextBox_PanelSpriteIamge, "Blank or does not end with .png")
                End If

                MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
            End If

        ElseIf TabControl1.SelectedTab Is TabPage_Tilemap Then

            If TextBox_Name.Text.Length > 0 And TextBox_Description.Text.Length > 0 And TextBox_TilemapJSONFile.Text.EndsWith(".json") And TextBox_TilemapAtlasImage.Text.EndsWith(".png") Then
                FastColoredTextBox_AssetJson.Clear()
                Dim jsonFile As JObject = JObject.Parse(My.Resources.tilemap_template)
                jsonFile.Item("description") = TextBox_Description.Text
                jsonFile.Item("objectAssets")(0)("object")("name") = TextBox_Name.Text
                jsonFile.Item("objectAssets")(0)("object")("content")("tilemapJsonFile") = TextBox_TilemapJSONFile.Text
                jsonFile.Item("objectAssets")(0)("object")("content")("tilesetJsonFile") = TextBox_TilesetJSONFile.Text
                jsonFile.Item("objectAssets")(0)("object")("content")("tilemapAtlasImage") = TextBox_TilemapAtlasImage.Text
                jsonFile.Item("objectAssets")(0)("object")("content")("displayMode") = ComboBox_TilemapDisplayMode.SelectedItem.ToString
                jsonFile.Item("objectAssets")(0)("object")("content")("layerIndex") = CInt(NumericUpDown_TilemapLayerDisplayIndex.Value)
                jsonFile.Item("objectAssets")(0)("object")("content")("animationSpeedScale") = CInt(NumericUpDown_TilemapAnimationSpeedScale.Value)
                jsonFile.Item("objectAssets")(0)("object")("content")("animationFps") = CInt(NumericUpDown_TilemapAnimationFPS.Value)
                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            Else

                If TextBox_Name.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Name, "Required")
                End If

                If TextBox_Description.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Description, "Required")
                End If

                If Not TextBox_TilemapJSONFile.Text.EndsWith(".json") Then
                    ErrorProvider1.SetError(TextBox_TilemapJSONFile, "Blank or does not end with .json")
                End If

                If Not TextBox_TilemapAtlasImage.Text.EndsWith(".png") Then
                    ErrorProvider1.SetError(TextBox_TilemapAtlasImage, "Blank or does not end with .png")
                End If

                MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
            End If
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

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim tempImageName As String = Path.GetFileNameWithoutExtension(SaveFileDialog1.FileName)
                tempImageName = Path.GetFileNameWithoutExtension(tempImageName)

                If aspectRatio_IsAlready_16_9 = False Then
                    Dim bmp = New Bitmap(ForceImageAspectRatio_16_9_Size.Width, ForceImageAspectRatio_16_9_Size.Height)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        'draw the original at the new size on memory bitmap
                        g.DrawImage(PixelBox_PreviewImage.Image, 0, 0, bmp.Width, bmp.Height)
                        'save the temp resized bitmamp
                        Console.WriteLine(Path.GetDirectoryName(SaveFileDialog1.FileName) & "\" & tempImageName & ".preview.png")
                        bmp.Save(Path.GetDirectoryName(SaveFileDialog1.FileName) & "\" & tempImageName & ".preview.png", Imaging.ImageFormat.Png)
                    End Using
                Else
                    PixelBox_PreviewImage.Image.Save(Path.GetDirectoryName(SaveFileDialog1.FileName) & "\" & tempImageName & ".preview.png", Imaging.ImageFormat.Png)
                End If

                'Write Asset Json
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox_AssetJson.Text, False)

                'Clear all
                TextBox_Name.Clear()
                TextBox_Description.Clear()
                FastColoredTextBox_AssetJson.Clear()
                PixelBox_PreviewImage.Image = Nothing

                'Panel Sprite
                TextBox_PanelSpriteIamge.Clear()

                'Bitmap Text
                TextBox_BitmapFont.Clear()
                TextBox_BitmapAtlasImage.Clear()

                'Tilemap
                TextBox_TilemapAtlasImage.Clear()
                TextBox_TilemapJSONFile.Clear()
                TextBox_TilesetJSONFile.Clear()

                'Light
                TextBox_LightTexture.Clear()

            End If
        Else

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
                Dim Ratio_16_9 As Decimal = CDec(1.77777777777778)
                aspectRatio_IsAlready_16_9 = Decimal.Equals(aspectRatio, Ratio_16_9)
                'Console.WriteLine(aspectRatio_IsAlready_16_9)

                If aspectRatio_IsAlready_16_9 = False Then
                    Dim aspectRatio_16_9 As Double = 16.0 / 9.0
                    Dim n1 As Double = PixelBox_PreviewImage.Image.Width
                    n1 = Math.Round(n1 / 16) * 16 - 16
                    'Console.WriteLine(n1)

                    Dim n2 As Double = PixelBox_PreviewImage.Image.Height
                    n2 = n1 / aspectRatio_16_9
                    'Console.WriteLine(n2)

                    ForceImageAspectRatio_16_9_Size.Width = Convert.ToInt32(n1)
                    ForceImageAspectRatio_16_9_Size.Height = Convert.ToInt32(n2)
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
            If aspectRatio_IsAlready_16_9 = False Then
                Dim bmp = New Bitmap(ForceImageAspectRatio_16_9_Size.Width, ForceImageAspectRatio_16_9_Size.Height)
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
    'Button_LightColor - Click
    Private Sub Button_LightColor_Click(sender As Object, e As EventArgs) Handles Button_LightColor.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            Button_LightColor.BackColor = ColorDialog1.Color
        End If
    End Sub
    '
    'Drag & Drop
    '
    'Panel_PanelSpriteIamge - DragDrop
    Private Sub Panel_PanelSpriteIamge_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_PanelSpriteIamge.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                Dim tempImage As Image = Image.FromFile(files(0))
                TextBox_PanelSpriteIamge.Text = Path.GetFileName(files(0))
                NumericUpDown_PSTopMargin.Value = CDec(tempImage.Height / 3)
                NumericUpDown_PSBottomMargin.Value = CDec(tempImage.Height / 3)
                NumericUpDown_PSLeftMargin.Value = CDec(tempImage.Width / 3)
                NumericUpDown_PSRightMargin.Value = CDec(tempImage.Width / 3)
                NumericUpDown_PSDefaultHeight.Value = tempImage.Height
                NumericUpDown_DefaultWidth.Value = tempImage.Width
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_PanelSpriteIamge - DragEnter
    Private Sub Panel_PanelSpriteIamge_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_PanelSpriteIamge.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".png") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Panel_BitmapFont - DragDrop
    Private Sub Panel_BitmapFont_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_BitmapFont.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                TextBox_BitmapFont.Text = Path.GetFileName(files(0))
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_BitmapFont - DragEnter
    Private Sub Panel_BitmapFont_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_BitmapFont.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".fnt") Or files(0).EndsWith(".xml") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Panel_BitmapAtlasImage - DragDrop
    Private Sub Panel_BitmapAtlasImage_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_BitmapAtlasImage.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                TextBox_BitmapAtlasImage.Text = Path.GetFileName(files(0))
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_BitmapAtlasImage - DragEnter
    Private Sub Panel_BitmapAtlasImage_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_BitmapAtlasImage.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".png") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Panel_TilemapAtlasImage - DragDrop
    Private Sub Panel_TilemapAtlasImage_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_TilemapAtlasImage.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                TextBox_TilemapAtlasImage.Text = Path.GetFileName(files(0))
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_TilemapAtlasImage - DragEnter
    Private Sub Panel_TilemapAtlasImage_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_TilemapAtlasImage.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".png") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Panel_TilemapJSONFile - DragDrop
    Private Sub Panel_TilemapJSONFile_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_TilemapJSONFile.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                TextBox_TilemapJSONFile.Text = Path.GetFileName(files(0))
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_TilemapJSONFile - DragEnter
    Private Sub Panel_TilemapJSONFile_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_TilemapJSONFile.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".json") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Panel_TilesetJSONFile - DragDrop
    Private Sub Panel_TilesetJSONFile_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_TilesetJSONFile.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                TextBox_TilesetJSONFile.Text = Path.GetFileName(files(0))
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_TilesetJSONFile - DragEnter
    Private Sub Panel_TilesetJSONFile_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_TilesetJSONFile.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".json") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Panel_LightTexture - DragDrop
    Private Sub Panel_LightTexture_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_LightTexture.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                TextBox_LightTexture.Text = Path.GetFileName(files(0))
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Panel_LightTexture - DragEnter
    Private Sub Panel_LightTexture_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_LightTexture.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".png") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'TabControl1 - Selected
    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        ErrorProvider1.Clear()
    End Sub
    'TextBox_Name - GotFocus
    Private Sub TextBox_Name_GotFocus(sender As Object, e As EventArgs) Handles TextBox_Name.GotFocus
        ErrorProvider1.SetError(TextBox_Name, Nothing)
    End Sub
    'TextBox_Name - LostFocus
    Private Sub TextBox_Name_LostFocus(sender As Object, e As EventArgs) Handles TextBox_Name.LostFocus
        If TextBox_Name.Text.Length = 0 Then
            ErrorProvider1.SetError(TextBox_Name, "Required")
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
    '
    'TextChanged
    '
    'TextBox_LightTexture - TextChanged
    Private Sub TextBox_LightTexture_TextChanged(sender As Object, e As EventArgs) Handles TextBox_LightTexture.TextChanged
        If TextBox_LightTexture.Text.EndsWith(".png") Then
            ErrorProvider1.SetError(TextBox_LightTexture, Nothing)
        Else
            ErrorProvider1.SetError(TextBox_LightTexture, "Blank or does not end with .png")
        End If
    End Sub
    'TextBox_TilemapAtlasImage - TextChanged
    Private Sub TextBox_TilemapAtlasImage_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TilemapAtlasImage.TextChanged
        If TextBox_TilemapAtlasImage.Text.EndsWith(".png") Then
            ErrorProvider1.SetError(TextBox_TilemapAtlasImage, Nothing)
        Else
            ErrorProvider1.SetError(TextBox_TilemapAtlasImage, "Blank or does not end with .png")
        End If
    End Sub
    'TextBox_TilemapJSONFile - TextChanged
    Private Sub TextBox_TilemapJSONFile_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TilemapJSONFile.TextChanged
        If TextBox_TilemapJSONFile.Text.EndsWith(".json") Then
            ErrorProvider1.SetError(TextBox_TilemapJSONFile, Nothing)
        Else
            ErrorProvider1.SetError(TextBox_TilemapJSONFile, "Blank or does not end with .json")
        End If
    End Sub
    'TextBox_BitmapFont - TextChanged
    Private Sub TextBox_BitmapFont_TextChanged(sender As Object, e As EventArgs) Handles TextBox_BitmapFont.TextChanged
        If TextBox_BitmapFont.Text.EndsWith(".fnt") Or TextBox_BitmapFont.Text.EndsWith(".xml") Then
            ErrorProvider1.SetError(TextBox_BitmapFont, Nothing)
        Else
            ErrorProvider1.SetError(TextBox_BitmapFont, "Blank or does not end with .fnt or .xml")
        End If
    End Sub
    'TextBox_BitmapAtlasImage - TextChanged
    Private Sub TextBox_BitmapAtlasImage_TextChanged(sender As Object, e As EventArgs) Handles TextBox_BitmapAtlasImage.TextChanged
        If TextBox_BitmapAtlasImage.Text.EndsWith(".png") Then
            ErrorProvider1.SetError(TextBox_BitmapAtlasImage, Nothing)
        Else
            ErrorProvider1.SetError(TextBox_BitmapAtlasImage, "Blank or does not end with .png")
        End If
    End Sub
    'TextBox_PanelSpriteIamge - TextChanged
    Private Sub TextBox_PanelSpriteIamge_TextChanged(sender As Object, e As EventArgs) Handles TextBox_PanelSpriteIamge.TextChanged
        If TextBox_PanelSpriteIamge.Text.EndsWith(".png") Then
            ErrorProvider1.SetError(TextBox_PanelSpriteIamge, Nothing)
        Else
            ErrorProvider1.SetError(TextBox_PanelSpriteIamge, "Blank or does not end with .png")
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
    Private Sub Main_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        PictureBox_Close.Image = My.Resources.Close_Grey
        Panel_Main.BackColor = Color.FromArgb(28, 30, 34)
    End Sub
    'Form Activated Close Red
    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        PictureBox_Close.Image = My.Resources.Close_Red
        Panel_Main.BackColor = Color.Black
    End Sub
End Class