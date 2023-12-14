Imports FastColoredTextBoxNS

Public Class TemplateAsset
    ReadOnly SupportedImageFormats() As String = {".png", ".bmp", ".jpeg", ".jpg", ".tiff", ".tif"}
    Dim ForceImageAspectRatio_1_1_Size As Size
    Dim aspectRatio_IsAlready_1_1 As Boolean = False
    Private key As New TextStyle(Brushes.MediumAquamarine, Nothing, FontStyle.Regular)
    Private str As New TextStyle(Brushes.PaleGoldenrod, Nothing, FontStyle.Regular)
    Private boo As New TextStyle(Brushes.MediumSlateBlue, Nothing, FontStyle.Regular)
    Private num As New TextStyle(Brushes.DeepPink, Nothing, FontStyle.Regular)
    Private nul As New TextStyle(Brushes.DarkGray, Nothing, FontStyle.Regular)

    ' TemplateAsset - Load
    Private Sub TemplateAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Region = New Region(New RectangleF(Me.TabPage_BitmapText.Left, Me.TabPage_BitmapText.Top, Me.TabPage_BitmapText.Width, Me.TabPage_BitmapText.Height))
        TabControl2.DrawMode = TabDrawMode.OwnerDrawFixed
        Me.TabControl2.Region = New Region(New RectangleF(Me.TabPage_Idle.Left, Me.TabPage_Idle.Top, Me.TabPage_Idle.Width, Me.TabPage_Idle.Height))

        ComboBox_TilemapDisplayMode.SelectedIndex = 0
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        MenuStrip2.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_PreviewImage.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        ContextMenuStrip_AssetJSON.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
        FastColoredTextBox_AssetJson.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" + "(?<range>:)\\s*(?<range>[^;]+);"
    End Sub

    ' Button_GenerateAsset - Click
    Private Sub Button_GenerateAsset_Click(sender As Object, e As EventArgs) Handles Button_GenerateAsset.Click
        If TabControl1.SelectedTab Is TabPage_BitmapText Then

            If TextBox_Name.Text.Length > 0 And TextBox_BitmapAtlasImage.Text.EndsWith(".png") And (TextBox_BitmapFont.Text.EndsWith(".fnt") Or TextBox_BitmapFont.Text.EndsWith(".xml")) Then
                FastColoredTextBox_AssetJson.Clear()
                ErrorProvider1.SetError(FastColoredTextBox_AssetJson, Nothing)
                Dim jsonFile As JObject = JObject.Parse(My.Resources.bitmaptext_template)
                jsonFile.Item("description") = TextBox_Description.Text
                jsonFile.Item("objectAssets")(0)("object")("name") = TextBox_Name.Text
                jsonFile.Item("objectAssets")(0)("object")("content")("scale") = CInt(NumericUpDown_BitmapTextScale.Value)
                jsonFile.Item("objectAssets")(0)("object")("content")("bitmapFontResourceName") = TextBox_BitmapFont.Text
                jsonFile.Item("objectAssets")(0)("object")("content")("textureAtlasResourceName") = TextBox_BitmapAtlasImage.Text
                jsonFile.Item("objectAssets")(0)("resources")(0)("file") = TextBox_BitmapFont.Text
                jsonFile.Item("objectAssets")(0)("resources")(0)("name") = TextBox_BitmapFont.Text
                jsonFile.Item("objectAssets")(0)("resources")(1)("file") = TextBox_BitmapAtlasImage.Text
                jsonFile.Item("objectAssets")(0)("resources")(1)("name") = TextBox_BitmapAtlasImage.Text
                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            Else

                If TextBox_Name.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Name, "Required")
                End If

                'If TextBox_Description.Text.Length = 0 Then
                'ErrorProvider1.SetError(TextBox_Description, "Required")
                'End If

                If Not TextBox_BitmapAtlasImage.Text.EndsWith(".png") Then
                    ErrorProvider1.SetError(TextBox_BitmapAtlasImage, "Blank or does not end with .png")
                End If

                If Not TextBox_BitmapFont.Text.EndsWith(".fnt") Or Not TextBox_BitmapFont.Text.EndsWith(".xml") Then
                    ErrorProvider1.SetError(TextBox_BitmapFont, "Blank or does not end with .fnt or .xml")
                End If

                MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
            End If

        ElseIf TabControl1.SelectedTab Is TabPage_Light Then

            If TextBox_Name.Text.Length > 0 And TextBox_LightTexture.Text.EndsWith(".png") Then
                FastColoredTextBox_AssetJson.Clear()
                ErrorProvider1.SetError(FastColoredTextBox_AssetJson, Nothing)
                Dim jsonFile As JObject = JObject.Parse(My.Resources.light_template)
                jsonFile.Item("description") = TextBox_Description.Text
                jsonFile.Item("objectAssets")(0)("object")("name") = TextBox_Name.Text
                jsonFile.Item("objectAssets")(0)("object")("content")("radius") = CInt(NumericUpDown_LightRadius.Value)
                jsonFile.Item("objectAssets")(0)("object")("content")("color") = Button_LightColor.BackColor.R.ToString & ";" & Button_LightColor.BackColor.G.ToString & ";" & Button_LightColor.BackColor.B.ToString
                jsonFile.Item("objectAssets")(0)("object")("content")("texture") = TextBox_LightTexture.Text
                jsonFile.Item("objectAssets")(0)("resources")(0)("file") = TextBox_LightTexture.Text
                jsonFile.Item("objectAssets")(0)("resources")(0)("name") = TextBox_LightTexture.Text
                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            Else

                If TextBox_Name.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Name, "Required")
                End If

                'If TextBox_Description.Text.Length = 0 Then
                'ErrorProvider1.SetError(TextBox_Description, "Required")
                'End If

                If Not TextBox_LightTexture.Text.EndsWith(".png") Then
                    ErrorProvider1.SetError(TextBox_LightTexture, "Blank or does not end with .png")
                End If

                MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
            End If

        ElseIf TabControl1.SelectedTab Is TabPage_PanelSprite Then

            If TextBox_Name.Text.Length > 0 And TextBox_PanelSpriteImage.Text.EndsWith(".png") Then
                FastColoredTextBox_AssetJson.Clear()
                ErrorProvider1.SetError(FastColoredTextBox_AssetJson, Nothing)
                Dim jsonFile As JObject = JObject.Parse(My.Resources.panelsprite_template)
                jsonFile.Item("description") = TextBox_Description.Text
                jsonFile.Item("objectAssets")(0)("object")("name") = TextBox_Name.Text
                jsonFile.Item("objectAssets")(0)("object")("bottomMargin") = CInt(NumericUpDown_PSBottomMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("height") = CInt(NumericUpDown_PSDefaultHeight.Value)
                jsonFile.Item("objectAssets")(0)("object")("leftMargin") = CInt(NumericUpDown_PSLeftMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("rightMargin") = CInt(NumericUpDown_PSRightMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("texture") = TextBox_PanelSpriteImage.Text
                jsonFile.Item("objectAssets")(0)("object")("tiled") = CheckBox_PSRepeatBoarders.Checked
                jsonFile.Item("objectAssets")(0)("object")("topMargin") = CInt(NumericUpDown_PSTopMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("width") = CInt(NumericUpDown_DefaultWidth.Value)
                jsonFile.Item("objectAssets")(0)("resources")(0)("file") = TextBox_PanelSpriteImage.Text
                jsonFile.Item("objectAssets")(0)("resources")(0)("name") = TextBox_PanelSpriteImage.Text
                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            Else

                If TextBox_Name.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Name, "Required")
                End If

                'If TextBox_Description.Text.Length = 0 Then
                'ErrorProvider1.SetError(TextBox_Description, "Required")
                'End If

                If Not TextBox_PanelSpriteImage.Text.EndsWith(".png") Then
                    ErrorProvider1.SetError(TextBox_PanelSpriteImage, "Blank or does not end with .png")
                End If

                MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
            End If

        ElseIf TabControl1.SelectedTab Is TabPage_Tilemap Then

            If TextBox_Name.Text.Length > 0 And TextBox_TilemapJSONFile.Text.EndsWith(".json") And TextBox_TilemapAtlasImage.Text.EndsWith(".png") Then
                FastColoredTextBox_AssetJson.Clear()
                ErrorProvider1.SetError(FastColoredTextBox_AssetJson, Nothing)
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
                jsonFile.Item("objectAssets")(0)("resources")(0)("file") = TextBox_TilemapAtlasImage.Text
                jsonFile.Item("objectAssets")(0)("resources")(0)("name") = TextBox_TilemapAtlasImage.Text
                jsonFile.Item("objectAssets")(0)("resources")(1)("file") = TextBox_TilemapJSONFile.Text
                jsonFile.Item("objectAssets")(0)("resources")(1)("name") = TextBox_TilemapJSONFile.Text
                If Not TextBox_TilesetJSONFile.Text = "" And Not TextBox_TilesetJSONFile.Text = TextBox_TilemapJSONFile.Text Then
                    jsonFile.Item("objectAssets")(0)("resources")(2)("file") = TextBox_TilesetJSONFile.Text
                    jsonFile.Item("objectAssets")(0)("resources")(2)("name") = TextBox_TilesetJSONFile.Text
                Else
                    jsonFile.Item("objectAssets")(0)("resources")(2).Remove()
                End If

                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            Else

                If TextBox_Name.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Name, "Required")
                End If

                'If TextBox_Description.Text.Length = 0 Then
                'ErrorProvider1.SetError(TextBox_Description, "Required")
                'End If

                If Not TextBox_TilemapJSONFile.Text.EndsWith(".json") Then
                    ErrorProvider1.SetError(TextBox_TilemapJSONFile, "Blank or does not end with .json")
                End If

                If Not TextBox_TilemapAtlasImage.Text.EndsWith(".png") Then
                    ErrorProvider1.SetError(TextBox_TilemapAtlasImage, "Blank or does not end with .png")
                End If

                MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
            End If

        ElseIf TabControl1.SelectedTab Is TabPage_Button Then

            If TextBox_Button_Hovered_Image.Text.Length > 0 And TextBox_Button_Hovered_Image.Text.EndsWith(".png") _
                And TextBox_Button_Idle_Image.Text.Length > 0 And TextBox_Button_Idle_Image.Text.EndsWith(".png") _
                And TextBox_Button_Pressed_Image.Text.Length > 0 And TextBox_Button_Pressed_Image.Text.EndsWith(".png") Then
                FastColoredTextBox_AssetJson.Clear()
                ErrorProvider1.SetError(FastColoredTextBox_AssetJson, Nothing)

                Dim jsonFile As JObject = JObject.Parse(My.Resources.button_template)
                jsonFile.Item("description") = TextBox_Description.Text
                jsonFile.Item("objectAssets")(0)("object")("name") = TextBox_Name.Text
                'content
                jsonFile.Item("objectAssets")(0)("object")("content")("LeftPadding") = NumericUpDown_LeftPadding.Value
                jsonFile.Item("objectAssets")(0)("object")("content")("RightPadding") = NumericUpDown_RightPadding.Value
                jsonFile.Item("objectAssets")(0)("object")("content")("PressedLabelOffsetY") = NumericUpDown_LableOffset_Y.Value
                jsonFile.Item("objectAssets")(0)("object")("content")("BottomPadding") = NumericUpDown_BottomPadding.Value
                jsonFile.Item("objectAssets")(0)("object")("content")("TopPadding") = NumericUpDown_TopPadding.Value
                'Hovered
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Hovered")("bottomMargin") = CInt(NumericUpDown_Hovered_BottomMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Hovered")("height") = CInt(NumericUpDown_Hovered_DefaultHeight.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Hovered")("leftMargin") = CInt(NumericUpDown_Hovered_LeftMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Hovered")("rightMargin") = CInt(NumericUpDown_Hovered_RightMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Hovered")("texture") = TextBox_Button_Hovered_Image.Text
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Hovered")("topMargin") = CInt(NumericUpDown_Hovered_TopMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Hovered")("width") = CInt(NumericUpDown_Hovered_DefaultWidth.Value)
                'Idle
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Idle")("bottomMargin") = CInt(NumericUpDown_Idle_BottomMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Idle")("height") = CInt(NumericUpDown_Idle_DefaultHeight.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Idle")("leftMargin") = CInt(NumericUpDown_Idle_LeftMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Idle")("rightMargin") = CInt(NumericUpDown_Idle_RightMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Idle")("texture") = TextBox_Button_Idle_Image.Text
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Idle")("topMargin") = CInt(NumericUpDown_Idle_TopMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Idle")("width") = CInt(NumericUpDown_Idle_DefaultWidth.Value)
                'Label
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Label")("characterSize") = CInt(NumericUpDown_LabelFontSize.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Label")("color")("b") = Button_LabelColor.BackColor.B.ToString
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Label")("color")("g") = Button_LabelColor.BackColor.G.ToString
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Label")("color")("r") = Button_LabelColor.BackColor.R.ToString
                'Pressed
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Pressed")("bottomMargin") = CInt(NumericUpDown_Pressed_BottomMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Pressed")("height") = CInt(NumericUpDown_Pressed_DefaultHeight.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Pressed")("leftMargin") = CInt(NumericUpDown_Pressed_LeftMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Pressed")("rightMargin") = CInt(NumericUpDown_Pressed_RightMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Pressed")("texture") = TextBox_Button_Pressed_Image.Text
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Pressed")("topMargin") = CInt(NumericUpDown_Pressed_TopMargin.Value)
                jsonFile.Item("objectAssets")(0)("object")("childrenContent")("Pressed")("width") = CInt(NumericUpDown_Pressed_DefaultWidth.Value)

                If Not TextBox_Button_Hovered_Image.Text = TextBox_Button_Idle_Image.Text And Not TextBox_Button_Hovered_Image.Text = TextBox_Button_Pressed_Image.Text Then
                    jsonFile.Item("objectAssets")(0)("resources")(0)("file") = TextBox_Button_Hovered_Image.Text
                    jsonFile.Item("objectAssets")(0)("resources")(0)("name") = TextBox_Button_Hovered_Image.Text
                Else
                    jsonFile.Item("objectAssets")(0)("resources")(0).Remove()
                End If

                If Not TextBox_Button_Idle_Image.Text = TextBox_Button_Pressed_Image.Text And Not TextBox_Button_Idle_Image.Text = TextBox_Button_Hovered_Image.Text Then
                    jsonFile.Item("objectAssets")(0)("resources")(1)("file") = TextBox_Button_Idle_Image.Text
                    jsonFile.Item("objectAssets")(0)("resources")(1)("name") = TextBox_Button_Idle_Image.Text
                Else
                    jsonFile.Item("objectAssets")(0)("resources")(1).Remove()
                End If

                If Not TextBox_Button_Pressed_Image.Text = TextBox_Button_Idle_Image.Text And Not TextBox_Button_Pressed_Image.Text = TextBox_Button_Hovered_Image.Text Then
                    jsonFile.Item("objectAssets")(0)("resources")(2)("file") = TextBox_Button_Pressed_Image.Text
                    jsonFile.Item("objectAssets")(0)("resources")(2)("name") = TextBox_Button_Pressed_Image.Text
                Else
                    jsonFile.Item("objectAssets")(0)("resources")(2).Remove()
                End If

                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            Else

                If TextBox_Name.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Name, "Required")
                End If

                'If TextBox_Description.Text.Length = 0 Then
                'ErrorProvider1.SetError(TextBox_Description, "Required")
                'End If

                If TextBox_Button_Hovered_Image.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Button_Hovered_Image, "Required")
                End If

                If TextBox_Button_Idle_Image.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Button_Idle_Image, "Required")
                End If

                If TextBox_Button_Pressed_Image.Text.Length = 0 Then
                    ErrorProvider1.SetError(TextBox_Button_Pressed_Image, "Required")
                End If

                If Not TextBox_Button_Hovered_Image.Text.EndsWith(".png") Then
                    ErrorProvider1.SetError(TextBox_Button_Hovered_Image, "Blank or does not end with .png")
                End If

                If Not TextBox_Button_Idle_Image.Text.EndsWith(".png") Then
                    ErrorProvider1.SetError(TextBox_Button_Idle_Image, "Blank or does not end with .png")
                End If

                If Not TextBox_Button_Pressed_Image.Text.EndsWith(".png") Then
                    ErrorProvider1.SetError(TextBox_Button_Pressed_Image, "Blank or does not end with .png")
                End If

                MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    ' Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If TextBox_Description.Text.Length > 0 And FastColoredTextBox_AssetJson.Text.Length > 0 Then
            If SaveFileDialog1.InitialDirectory = "" Then
                If Directory.Exists(MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath) Then
                    SaveFileDialog1.InitialDirectory = MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath
                Else
                    SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
                End If
            End If

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                'Write Asset Json
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox_AssetJson.Text, False)

                If PixelBox_PreviewImage.Image IsNot Nothing Then
                    Dim tempImageName As String = Path.GetFileNameWithoutExtension(SaveFileDialog1.FileName)
                    tempImageName = Path.GetFileNameWithoutExtension(tempImageName)
                    If aspectRatio_IsAlready_1_1 = False Then
                        Dim bmp = New Bitmap(ForceImageAspectRatio_1_1_Size.Width, ForceImageAspectRatio_1_1_Size.Height)
                        Using g As Graphics = Graphics.FromImage(bmp)
                            'draw the original at the new size on memory bitmap
                            g.DrawImage(PixelBox_PreviewImage.Image, 0, 0, bmp.Width, bmp.Height)
                            'save the temp resized bitmap
                            'Console.WriteLine(Path.GetDirectoryName(SaveFileDialog1.FileName) & "\" & tempImageName & ".preview.png")
                            bmp.Save(Path.GetDirectoryName(SaveFileDialog1.FileName) & "\" & tempImageName & ".preview.png", Imaging.ImageFormat.Png)
                        End Using
                    Else
                        PixelBox_PreviewImage.Image.Save(Path.GetDirectoryName(SaveFileDialog1.FileName) & "\" & tempImageName & ".preview.png", Imaging.ImageFormat.Png)
                    End If
                End If

                'Clear all
                TextBox_Name.Clear()
                TextBox_Description.Clear()
                FastColoredTextBox_AssetJson.Clear()
                PixelBox_PreviewImage.Image = Nothing

                'Panel Sprite
                TextBox_PanelSpriteImage.Clear()

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

            'If PixelBox_PreviewImage.Image Is Nothing Then
            'ErrorProvider1.SetError(PixelBox_PreviewImage, "Required")
            'End If

            If FastColoredTextBox_AssetJson.Text.Length = 0 Then
                ErrorProvider1.SetError(FastColoredTextBox_AssetJson, "Required")
            End If

            MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
        End If
    End Sub

    ' ContextMenuStrip_PreviewImage - Opening
    Private Sub ContextMenuStrip_PreviewImage_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_PreviewImage.Opening
        If PixelBox_PreviewImage.Image IsNot Nothing Then
            SaveToolStripMenuItem.Enabled = True
            ClearPreviewImageToolStripMenuItem.Enabled = True
        Else
            SaveToolStripMenuItem.Enabled = False
            ClearPreviewImageToolStripMenuItem.Enabled = False
        End If
    End Sub

    ' Save (ToolStripMenuItem) - Click
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

    ' ClearPreviewImage (ToolStripMenuItem) - Click
    Private Sub ClearPreviewImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearPreviewImageToolStripMenuItem.Click
        PixelBox_PreviewImage.Image = Nothing
    End Sub

    '
    'TabControl1 - ToolStripMenuItems
    '

    ' BitmapText (ToolStripMenuItem) - Click
    Private Sub BitmapTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitmapTextToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_BitmapText
        ResetToolStripMenuItemBackGroundColors()
        BitmapTextToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub

    ' Light (ToolStripMenuItem) - Click
    Private Sub LightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_Light
        ResetToolStripMenuItemBackGroundColors()
        LightToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub

    ' Button (ToolStripMenuItem) - Click
    Private Sub ButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ButtonToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_Button
        ResetToolStripMenuItemBackGroundColors()
        ButtonToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub

    ' Tilemap (ToolStripMenuItem) - Click
    Private Sub TilemapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TilemapToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_Tilemap
        ResetToolStripMenuItemBackGroundColors()
        TilemapToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub

    ' PanelSprite (ToolStripMenuItem) - Click
    Private Sub PanelSpriteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanelSpriteToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage_PanelSprite
        ResetToolStripMenuItemBackGroundColors()
        PanelSpriteToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub

    '
    ' TabControl2 - ToolStripMenuItems
    '

    ' Idle (ToolStripMenuItem - Click
    Private Sub IdleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdleToolStripMenuItem.Click
        TabControl2.SelectedTab = TabPage_Idle
        ResetToolStripMenuItemBackGroundColors_Button()
        IdleToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub

    ' Hovered (ToolStripMenuItem) - Click
    Private Sub HoveredToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoveredToolStripMenuItem.Click
        TabControl2.SelectedTab = TabPage_Hovered
        ResetToolStripMenuItemBackGroundColors_Button()
        HoveredToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub

    ' Pressed (ToolStripMenuItem) - Click
    Private Sub PressedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PressedToolStripMenuItem.Click
        TabControl2.SelectedTab = TabPage_Pressed
        ResetToolStripMenuItemBackGroundColors_Button()
        PressedToolStripMenuItem.BackColor = Color.RoyalBlue
    End Sub

    '
    ' Drag & Drop
    '

    ' Panel_PreviewImage - DragDrop
    Private Sub Panel_PreviewImage_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_PreviewImage.DragDrop
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
    End Sub

    ' Panel_PreviewImage - DragEnter
    Private Sub Panel_PreviewImage_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_PreviewImage.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If e.Data.GetDataPresent(DataFormats.FileDrop) And SupportedImageFormats.Contains(Path.GetExtension(files(0)).ToLower) Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        End If
    End Sub

    ' Panel_PanelSpriteImage - DragDrop
    Private Sub Panel_PanelSpriteImage_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_PanelSpriteImage.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                Dim tempImage As Image = SafeImageFromFile(files(0))
                TextBox_PanelSpriteImage.Text = Path.GetFileName(files(0))
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

    ' Panel_PanelSpriteImage - DragEnter
    Private Sub Panel_PanelSpriteImage_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_PanelSpriteImage.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".png") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Panel_BitmapFont - DragDrop
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

    ' Panel_BitmapFont - DragEnter
    Private Sub Panel_BitmapFont_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_BitmapFont.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".fnt") Or files(0).EndsWith(".xml") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Panel_BitmapAtlasImage - DragDrop
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

    ' Panel_BitmapAtlasImage - DragEnter
    Private Sub Panel_BitmapAtlasImage_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_BitmapAtlasImage.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".png") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Panel_TilemapAtlasImage - DragDrop
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

    ' Panel_TilemapAtlasImage - DragEnter
    Private Sub Panel_TilemapAtlasImage_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_TilemapAtlasImage.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".png") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Panel_TilemapJSONFile - DragDrop
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

    ' Panel_TilemapJSONFile - DragEnter
    Private Sub Panel_TilemapJSONFile_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_TilemapJSONFile.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".json") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Panel_TilesetJSONFile - DragDrop
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

    ' Panel_TilesetJSONFile - DragEnter
    Private Sub Panel_TilesetJSONFile_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_TilesetJSONFile.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".json") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Panel_LightTexture - DragDrop
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

    ' Panel_LightTexture - DragEnter
    Private Sub Panel_LightTexture_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_LightTexture.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".png") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Panel_Button_Idle - DragDrop
    Private Sub Panel_Button_Idle_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_Button_Idle.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                Dim tempImage As Image = SafeImageFromFile(files(0))
                TextBox_Button_Idle_Image.Text = Path.GetFileName(files(0))
                NumericUpDown_Idle_TopMargin.Value = CDec(tempImage.Height / 3) 'TopMargin
                NumericUpDown_Idle_BottomMargin.Value = CDec(tempImage.Height / 3) 'BottomMargin
                NumericUpDown_Idle_LeftMargin.Value = CDec(tempImage.Width / 3) 'LeftMargin
                NumericUpDown_Idle_RightMargin.Value = CDec(tempImage.Width / 3) 'RightMargin
                NumericUpDown_Idle_DefaultHeight.Value = tempImage.Height 'DefaultHeight
                NumericUpDown_Idle_DefaultWidth.Value = tempImage.Width 'DefaultWidth
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' Panel_Button_Idle - DragEnter
    Private Sub Panel_Button_Idle_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_Button_Idle.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".png") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Panel_Button_Hovered - DragDrop
    Private Sub Panel_Button_Hovered_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_Button_Hovered.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                Dim tempImage As Image = SafeImageFromFile(files(0))
                TextBox_Button_Hovered_Image.Text = Path.GetFileName(files(0))
                NumericUpDown_Hovered_TopMargin.Value = CDec(tempImage.Height / 3) 'TopMargin
                NumericUpDown_Hovered_BottomMargin.Value = CDec(tempImage.Height / 3) 'BottomMargin
                NumericUpDown_Hovered_LeftMargin.Value = CDec(tempImage.Width / 3) 'LeftMargin
                NumericUpDown_Hovered_RightMargin.Value = CDec(tempImage.Width / 3) 'RightMargin
                NumericUpDown_Hovered_DefaultHeight.Value = tempImage.Height 'DefaultHeight
                NumericUpDown_Hovered_DefaultWidth.Value = tempImage.Width 'DefaultWidth
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' Panel_Button_Hovered - DragEnter
    Private Sub Panel_Button_Hovered_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_Button_Hovered.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".png") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Panel_Button_Pressed - DragDrop
    Private Sub Panel_Button_Pressed_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_Button_Pressed.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                Dim tempImage As Image = SafeImageFromFile(files(0))
                TextBox_Button_Pressed_Image.Text = Path.GetFileName(files(0))
                NumericUpDown_Pressed_TopMargin.Value = CDec(tempImage.Height / 3) 'TopMargin
                NumericUpDown_Pressed_BottomMargin.Value = CDec(tempImage.Height / 3) 'BottomMargin
                NumericUpDown_Pressed_LeftMargin.Value = CDec(tempImage.Width / 3) 'LeftMargin
                NumericUpDown_Pressed_RightMargin.Value = CDec(tempImage.Width / 3) 'RightMargin
                NumericUpDown_Pressed_DefaultHeight.Value = tempImage.Height 'DefaultHeight
                NumericUpDown_Pressed_DefaultWidth.Value = tempImage.Width 'DefaultWidth
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' Panel_Button_Pressed - DragEnter
    Private Sub Panel_Button_Pressed_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_Button_Pressed.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And files(0).EndsWith(".png") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' TabControl1 - Selected
    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        ErrorProvider1.Clear()
        If TabControl1.SelectedTab Is TabPage_Button Then
            TextBox_Description.Text = "A button that can be clicked. The background images and text can be edited.\n\nThis button provides conditions and actions for an easy use."
            TextBox_Description.ReadOnly = True
        Else
            TextBox_Description.Text = ""
            TextBox_Description.ReadOnly = False
        End If
    End Sub

    '
    ' TextChanged
    '

    ' FastColoredTextBox_AssetJson - TextChanged
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

    ' TextBox_Name - TextChanged
    Private Sub TextBox_Name_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Name.TextChanged
        If TextBox_Name.Text.Length > 0 And ErrorProvider1.GetError(TextBox_Name) IsNot Nothing Then
            ErrorProvider1.SetError(TextBox_Name, Nothing)
        End If
    End Sub

    ' TextBox_Description - TextChanged
    'Private Sub TextBox_Description_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Description.TextChanged
    'If TextBox_Description.Text.Length > 0 And ErrorProvider1.GetError(TextBox_Description) IsNot Nothing Then
    'ErrorProvider1.SetError(TextBox_Description, Nothing)
    'End If
    'End Sub

    '
    ' LostFocus
    '

    ' TextBox_LightTexture - LostFocus
    Private Sub TextBox_LightTexture_LostFocus(sender As Object, e As EventArgs) Handles TextBox_LightTexture.LostFocus
        If Not TextBox_LightTexture.Text.EndsWith(".png") And TextBox_LightTexture.Text.Length > 0 Then
            ErrorProvider1.SetError(TextBox_LightTexture, "Blank or does not end with .png")
        Else
            ErrorProvider1.SetError(TextBox_LightTexture, Nothing)
        End If
    End Sub

    ' TextBox_TilemapAtlasImage - LostFocus
    Private Sub TextBox_TilemapAtlasImage_LostFocus(sender As Object, e As EventArgs) Handles TextBox_TilemapAtlasImage.LostFocus
        If Not TextBox_TilemapAtlasImage.Text.EndsWith(".png") And TextBox_TilemapAtlasImage.Text.Length > 0 Then
            ErrorProvider1.SetError(TextBox_TilemapAtlasImage, "Blank or does not end with .png")
        Else
            ErrorProvider1.SetError(TextBox_TilemapAtlasImage, Nothing)
        End If
    End Sub

    ' TextBox_TilemapJSONFile - LostFocus
    Private Sub TextBox_TilemapJSONFile_LostFocus(sender As Object, e As EventArgs) Handles TextBox_TilemapJSONFile.LostFocus
        If Not TextBox_TilemapJSONFile.Text.EndsWith(".json") And TextBox_TilemapJSONFile.Text.Length > 0 Then
            ErrorProvider1.SetError(TextBox_TilemapJSONFile, "Blank or does not end with .json")
        Else
            ErrorProvider1.SetError(TextBox_TilemapJSONFile, Nothing)
        End If
    End Sub

    ' TextBox_TilesetJSONFile - LostFocus
    Private Sub TextBox_TilesetJSONFile_LostFocus(sender As Object, e As EventArgs) Handles TextBox_TilesetJSONFile.LostFocus
        If Not TextBox_TilesetJSONFile.Text.EndsWith(".json") And TextBox_TilesetJSONFile.Text.Length > 0 Then
            ErrorProvider1.SetError(TextBox_TilesetJSONFile, "Blank or does not end with .json")
        Else
            ErrorProvider1.SetError(TextBox_TilesetJSONFile, Nothing)
        End If
    End Sub

    ' TextBox_BitmapFont - LostFocus
    Private Sub TextBox_BitmapFont_LostFocus(sender As Object, e As EventArgs) Handles TextBox_BitmapFont.LostFocus
        If Not TextBox_BitmapFont.Text.EndsWith(".fnt") And Not TextBox_BitmapFont.Text.EndsWith(".xml") And TextBox_BitmapFont.Text.Length > 0 Then
            ErrorProvider1.SetError(TextBox_BitmapFont, "Blank or does not end with .fnt or .xml")
        Else
            ErrorProvider1.SetError(TextBox_BitmapFont, Nothing)
        End If
    End Sub

    ' TextBox_BitmapAtlasImage - LostFocus
    Private Sub TextBox_BitmapAtlasImage_LostFocus(sender As Object, e As EventArgs) Handles TextBox_BitmapAtlasImage.LostFocus
        If Not TextBox_BitmapAtlasImage.Text.EndsWith(".png") And TextBox_BitmapAtlasImage.Text.Length > 0 Then
            ErrorProvider1.SetError(TextBox_BitmapAtlasImage, "Blank or does not end with .png")
        Else
            ErrorProvider1.SetError(TextBox_BitmapAtlasImage, Nothing)
        End If
    End Sub

    ' TextBox_PanelSpriteImage - LostFocus
    Private Sub TextBox_PanelSpriteImage_LostFocus(sender As Object, e As EventArgs) Handles TextBox_PanelSpriteImage.LostFocus
        If Not TextBox_PanelSpriteImage.Text.EndsWith(".png") And TextBox_PanelSpriteImage.Text.Length > 0 Then
            ErrorProvider1.SetError(TextBox_PanelSpriteImage, "Blank or does not end with .png")
        Else
            ErrorProvider1.SetError(TextBox_PanelSpriteImage, Nothing)
        End If
    End Sub

    ' TextBox_Button_Hovered_Image - LostFocus
    Private Sub TextBox_Button_Hovered_Image_LostFocus(sender As Object, e As EventArgs) Handles TextBox_Button_Hovered_Image.LostFocus
        If Not TextBox_Button_Hovered_Image.Text.EndsWith(".png") And TextBox_Button_Hovered_Image.Text.Length > 0 Then
            ErrorProvider1.SetError(TextBox_Button_Hovered_Image, "Blank or does not end with .png")
        Else
            ErrorProvider1.SetError(TextBox_Button_Hovered_Image, Nothing)
        End If
    End Sub

    ' TextBox_Button_Idle_Image - LostFocus
    Private Sub TextBox_Button_Idle_Image_LostFocus(sender As Object, e As EventArgs) Handles TextBox_Button_Idle_Image.LostFocus
        If Not TextBox_Button_Idle_Image.Text.EndsWith(".png") And TextBox_Button_Idle_Image.Text.Length > 0 Then
            ErrorProvider1.SetError(TextBox_Button_Idle_Image, "Blank or does not end with .png")
        Else
            ErrorProvider1.SetError(TextBox_Button_Idle_Image, Nothing)
        End If
    End Sub

    ' TextBox_Button_Pressed_Image - LostFocus
    Private Sub TextBox_Button_Pressed_Image_LostFocus(sender As Object, e As EventArgs) Handles TextBox_Button_Pressed_Image.LostFocus
        If Not TextBox_Button_Pressed_Image.Text.EndsWith(".png") And TextBox_Button_Pressed_Image.Text.Length > 0 Then
            ErrorProvider1.SetError(TextBox_Button_Pressed_Image, "Blank or does not end with .png")
        Else
            ErrorProvider1.SetError(TextBox_Button_Pressed_Image, Nothing)
        End If
    End Sub

    '
    ' Functions & Subs
    '

    ' SafeImageFromFile()
    Public Shared Function SafeImageFromFile(path As String) As Image
        Dim bytes = File.ReadAllBytes(path)
        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms)
            Return img
        End Using
    End Function

    ' ResetToolStripMenuItemBackGroundColors_Button
    Private Sub ResetToolStripMenuItemBackGroundColors_Button()
        IdleToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        HoveredToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        PressedToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
    End Sub

    ' ResetToolStripMenuItemBackGroundColors
    Private Sub ResetToolStripMenuItemBackGroundColors()
        BitmapTextToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        LightToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        TilemapToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        PanelSpriteToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
        ButtonToolStripMenuItem.BackColor = Color.FromArgb(28, 30, 34)
    End Sub

    '
    ' ContextMenuStrip_AssetJSON & ToolStripMenuItems
    '

    ' ContextMenuStrip_AssetJSON - Opening
    Private Sub ContextMenuStrip_AssetJSON_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_AssetJSON.Opening
        If Not FastColoredTextBox_AssetJson.SelectionLength = 0 Then
            CutToolStripMenuItem.Enabled = True
            CopyToolStripMenuItem.Enabled = True
        Else
            CutToolStripMenuItem.Enabled = False
            CopyToolStripMenuItem.Enabled = False
        End If
        If Clipboard.ContainsText Then
            PasteToolStripMenuItem.Enabled = True
        Else
            PasteToolStripMenuItem.Enabled = False
        End If
    End Sub

    ' CutToolStripMenuItem - Click
    Private Sub CutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        FastColoredTextBox_AssetJson.Cut()
    End Sub

    ' CopyToolStripMenuItem_Click
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        FastColoredTextBox_AssetJson.Copy()
    End Sub

    ' PasteToolStripMenuItem - Click
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        FastColoredTextBox_AssetJson.Paste()
    End Sub

    ' ClearToolStripMenuItem - Click
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        FastColoredTextBox_AssetJson.Clear()
    End Sub

    '
    ' PanelSprite - Buttons
    '

    ' Button_PanelSpriteImage - Click
    Private Sub Button_PanelSpriteImage_Click(sender As Object, e As EventArgs) Handles Button_PanelSpriteImage.Click
        If OpenFileDialog_Image.ShowDialog = DialogResult.OK Then
            Try
                Dim tempImage As Image = SafeImageFromFile(OpenFileDialog_Image.FileName)
                TextBox_PanelSpriteImage.Text = Path.GetFileName(OpenFileDialog_Image.FileName)
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

    '
    ' Bitmap Font - Buttons
    '

    ' Button_SelectFont - Click
    Private Sub Button_SelectFont_Click(sender As Object, e As EventArgs) Handles Button_SelectBitmapFont.Click
        If OpenFileDialog_FNT_XML.ShowDialog = DialogResult.OK Then
            TextBox_BitmapFont.Text = Path.GetFileName(OpenFileDialog_FNT_XML.FileName)
        End If
    End Sub

    ' Button_SelectBitmapAtlasImage - Click
    Private Sub Button_SelectBitmapAtlasImage_Click(sender As Object, e As EventArgs) Handles Button_SelectBitmapAtlasImage.Click
        If OpenFileDialog_Image.ShowDialog = DialogResult.OK Then
            TextBox_BitmapAtlasImage.Text = Path.GetFileName(OpenFileDialog_Image.FileName)
        End If
    End Sub

    '
    ' Tilemap - Buttons
    '

    ' Button_TilemapAtlasImage - Click
    Private Sub Button_TilemapAtlasImage_Click(sender As Object, e As EventArgs) Handles Button_TilemapAtlasImage.Click
        If OpenFileDialog_Image.ShowDialog = DialogResult.OK Then
            TextBox_TilemapAtlasImage.Text = Path.GetFileName(OpenFileDialog_Image.FileName)
        End If
    End Sub

    ' Button_TilemapJSONFile - Click
    Private Sub Button_TilemapJSONFile_Click(sender As Object, e As EventArgs) Handles Button_TilemapJSONFile.Click
        If OpenFileDialog_JSON.ShowDialog = DialogResult.OK Then
            TextBox_TilemapJSONFile.Text = Path.GetFileName(OpenFileDialog_JSON.FileName)
        End If
    End Sub

    ' Button_TilesetJSONFile - Click
    Private Sub Button_TilesetJSONFile_Click(sender As Object, e As EventArgs) Handles Button_TilesetJSONFile.Click
        If OpenFileDialog_JSON.ShowDialog = DialogResult.OK Then
            TextBox_TilesetJSONFile.Text = Path.GetFileName(OpenFileDialog_JSON.FileName)
        End If
    End Sub

    '
    ' Light - Buttons
    '

    ' Button_LightTexture - Click
    Private Sub Button_LightTexture_Click(sender As Object, e As EventArgs) Handles Button_LightTexture.Click
        If OpenFileDialog_Image.ShowDialog = DialogResult.OK Then
            TextBox_LightTexture.Text = Path.GetFileName(OpenFileDialog_Image.FileName)
        End If
    End Sub

    ' Button_LightColor - Click
    Private Sub Button_LightColor_Click(sender As Object, e As EventArgs) Handles Button_LightColor.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            Button_LightColor.BackColor = ColorDialog1.Color
        End If
    End Sub

    '
    ' Button - Buttons
    '

    ' Button_Button_Idle_Image - Click
    Private Sub Button_Button_Idle_Image_Click(sender As Object, e As EventArgs) Handles Button_Button_Idle_Image.Click
        If OpenFileDialog_Image.ShowDialog = DialogResult.OK Then
            Try
                Dim tempImage As Image = SafeImageFromFile(OpenFileDialog_Image.FileName)
                TextBox_Button_Idle_Image.Text = Path.GetFileName(OpenFileDialog_Image.FileName)
                NumericUpDown_Idle_TopMargin.Value = CDec(tempImage.Height / 3) 'TopMargin
                NumericUpDown_Idle_BottomMargin.Value = CDec(tempImage.Height / 3) 'BottomMargin
                NumericUpDown_Idle_LeftMargin.Value = CDec(tempImage.Width / 3) 'LeftMargin
                NumericUpDown_Idle_RightMargin.Value = CDec(tempImage.Width / 3) 'RightMargin
                NumericUpDown_Idle_DefaultHeight.Value = tempImage.Height 'DefaultHeight
                NumericUpDown_Idle_DefaultWidth.Value = tempImage.Width 'DefaultWidth
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' Button_Button_Hovered_Image - Click
    Private Sub Button_Button_Hovered_Image_Click(sender As Object, e As EventArgs) Handles Button_Button_Hovered_Image.Click
        If OpenFileDialog_Image.ShowDialog = DialogResult.OK Then
            Try
                Dim tempImage As Image = SafeImageFromFile(OpenFileDialog_Image.FileName)
                TextBox_Button_Hovered_Image.Text = Path.GetFileName(OpenFileDialog_Image.FileName)
                NumericUpDown_Hovered_TopMargin.Value = CDec(tempImage.Height / 3) 'TopMargin
                NumericUpDown_Hovered_BottomMargin.Value = CDec(tempImage.Height / 3) 'BottomMargin
                NumericUpDown_Hovered_LeftMargin.Value = CDec(tempImage.Width / 3) 'LeftMargin
                NumericUpDown_Hovered_RightMargin.Value = CDec(tempImage.Width / 3) 'RightMargin
                NumericUpDown_Hovered_DefaultHeight.Value = tempImage.Height 'DefaultHeight
                NumericUpDown_Hovered_DefaultWidth.Value = tempImage.Width 'DefaultWidth
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' Button_Button_Pressed_Image - Click
    Private Sub Button_Button_Pressed_Image_Click(sender As Object, e As EventArgs) Handles Button_Button_Pressed_Image.Click
        If OpenFileDialog_Image.ShowDialog = DialogResult.OK Then
            Try
                Dim tempImage As Image = SafeImageFromFile(OpenFileDialog_Image.FileName)
                TextBox_Button_Pressed_Image.Text = Path.GetFileName(OpenFileDialog_Image.FileName)
                NumericUpDown_Pressed_TopMargin.Value = CDec(tempImage.Height / 3) 'TopMargin
                NumericUpDown_Pressed_BottomMargin.Value = CDec(tempImage.Height / 3) 'BottomMargin
                NumericUpDown_Pressed_LeftMargin.Value = CDec(tempImage.Width / 3) 'LeftMargin
                NumericUpDown_Pressed_RightMargin.Value = CDec(tempImage.Width / 3) 'RightMargin
                NumericUpDown_Pressed_DefaultHeight.Value = tempImage.Height 'DefaultHeight
                NumericUpDown_Pressed_DefaultWidth.Value = tempImage.Width 'DefaultWidth
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' Button_LabelColor - Click
    Private Sub Button_LabelColor_Click(sender As Object, e As EventArgs) Handles Button_LabelColor.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            Button_LabelColor.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class