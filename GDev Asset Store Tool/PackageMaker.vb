Public Class PackageMaker
    ReadOnly SupportedImageFormats() As String = {".png", ".bmp", ".jpeg", ".jpg", ".tiff", ".tif"}
    Dim ForceImageAspectRatio_16_9_Size As Size
    Dim aspectRatio_IsAlready_16_9 As Boolean = False

    ' PackageMaker - Load
    Private Sub PackageMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set custom renderer for the context menu strip
        ContextMenuStrip_PackageThumbnail.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub

    ' Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        ' Check if the required fields are filled and a thumbnail image is selected
        If TextBox_PackageName.Text.Length > 0 AndAlso
            TextBox_Description.Text.Length > 0 AndAlso
            PixelBox_PackageThumbnail.Image IsNot Nothing AndAlso
            (CheckBox_FullGamePack.Checked OrElse
            CheckBox_Character.Checked OrElse
            CheckBox_Props.Checked OrElse
            CheckBox_Background.Checked OrElse
            CheckBox_VisualEffect.Checked OrElse
            CheckBox_Interface.Checked OrElse
            CheckBox_Prefab.Checked OrElse
            CheckBox_Sounds.Checked) Then

            SaveFileDialog_PackJson.FileName = "PACK.json"

            'Dim euroValue As Double = NumericUpDown_Price.Value / 100.0
            Dim formattedValue As Integer = CInt(NumericUpDown_Price.Value * 100)

            ' Set initial directory for saving the PACK.json file
            If Not Directory.Exists(SaveFileDialog_PackJson.InitialDirectory) Then
                SaveFileDialog_PackJson.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            End If

            ' Show the save file dialog
            If SaveFileDialog_PackJson.ShowDialog = DialogResult.OK Then
                Dim sb As New StringBuilder
                Dim sw As New StringWriter(sb)
                Dim writer As JsonWriter = New JsonTextWriter(sw) With {
                            .Formatting = Formatting.Indented
                        }
                writer.WriteStartObject() ' Start writing the JSON object

                ' Write properties and values inside the object
                writer.WritePropertyName("longDescription")
                writer.WriteValue(TextBox_Description.Text.Replace(vbNewLine, "\n"))

                writer.WritePropertyName("tag")
                writer.WriteValue(TextBox_PackageName.Text)

                writer.WritePropertyName("sellerId")
                writer.WriteValue("")

                writer.WritePropertyName("sellerStripeAccountId")
                writer.WriteValue("")

                ' Start writing the "prices" array
                writer.WritePropertyName("prices")
                writer.WriteStartArray()

                ' Write the price object inside the array
                writer.WriteStartObject()
                writer.WritePropertyName("value")
                writer.WriteValue(formattedValue) 'euroValue.ToString
                writer.WritePropertyName("name")
                writer.WriteValue("default")
                writer.WriteEndObject() ' End the price object

                ' End writing the "prices" array
                writer.WriteEndArray()

                ' Write the "categories" array
                writer.WritePropertyName("categories")
                writer.WriteStartArray()

                If CheckBox_FullGamePack.Checked Then
                    writer.WriteValue("full-game-pack")
                End If
                If CheckBox_Character.Checked Then
                    writer.WriteValue("character")
                End If

                If CheckBox_Props.Checked Then
                    writer.WriteValue("props")
                End If

                If CheckBox_Background.Checked Then
                    writer.WriteValue("background")
                End If

                If CheckBox_VisualEffect.Checked Then
                    writer.WriteValue("visual-effect")
                End If

                If CheckBox_Interface.Checked Then
                    writer.WriteValue("interface")
                End If

                If CheckBox_Prefab.Checked Then
                    writer.WriteValue("prefab")
                End If

                If CheckBox_Sounds.Checked Then
                    writer.WriteValue("sounds")
                End If

                writer.WriteEndArray()

                writer.WriteEndObject() ' End writing the JSON object

                ' Don't forget to close the JsonWriter and StringWriter
                writer.Close()
                sw.Close()


                ' Resize and save the thumbnail image
                If aspectRatio_IsAlready_16_9 = False Then
                    Dim bmp = New Bitmap(ForceImageAspectRatio_16_9_Size.Width, ForceImageAspectRatio_16_9_Size.Height)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        ' Draw the original image at the new size on the memory bitmap
                        g.DrawImage(PixelBox_PackageThumbnail.Image, 0, 0, bmp.Width, bmp.Height)

                        ' Save the temporarily resized bitmap
                        bmp.Save(Path.GetDirectoryName(SaveFileDialog_PackJson.FileName) & "\thumbnail.png", Imaging.ImageFormat.Png)
                    End Using
                Else
                    ' Save the original thumbnail image
                    PixelBox_PackageThumbnail.Image.Save(Path.GetDirectoryName(SaveFileDialog_PackJson.FileName) & "\thumbnail.png", Imaging.ImageFormat.Png)
                End If

                ' Write the JSON data to the file
                My.Computer.FileSystem.WriteAllText(SaveFileDialog_PackJson.FileName, sb.ToString, False)

                ' Clear all fields for the next package
                'SaveFileDialog_PackJson.InitialDirectory = ""
                TextBox_PackageName.Clear()
                TextBox_Description.Clear()
                PixelBox_PackageThumbnail.Image = Nothing
                PixelBox_PackageThumbnail.Refresh()
                NumericUpDown_Price.Value = NumericUpDown_Price.Minimum
                CheckBox_FullGamePack.Checked = False
                CheckBox_Character.Checked = False
                CheckBox_Props.Checked = False
                CheckBox_Background.Checked = False
                CheckBox_VisualEffect.Checked = False
                CheckBox_Interface.Checked = False
                CheckBox_Prefab.Checked = False
                CheckBox_Sounds.Checked = False
            End If
        Else
            ' Display a message if all required fields are not filled
            MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
        End If
    End Sub

    ' TextBox_PackageName - KeyPress
    Private Sub TextBox_PackageName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_PackageName.KeyPress
        ' Move focus to TextBox_Tag when Enter is pressed in TextBox_PackageName
        If e.KeyChar = ChrW(Keys.Enter) And TextBox_PackageName.Text.Length > 0 Then
            e.Handled = True
            TextBox_Description.Focus()
        End If
    End Sub

    ' TextBox_Tag - KeyPress
    Private Sub TextBox_Tag_KeyPress(sender As Object, e As KeyPressEventArgs) 'Handles TextBox_Description.KeyPress
        ' Trigger Button_Save click event when Enter is pressed in TextBox_Tag
        If e.KeyChar = ChrW(Keys.Enter) And TextBox_PackageName.Text.Length > 0 And TextBox_Description.Text.Length > 0 Then
            e.Handled = True
            Button_Save.PerformClick()
        End If
    End Sub

    ' PackageMaker - DragDrop
    Private Sub PackageMaker_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        ' Retrieve the dropped files
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        If files.Length <> 0 Then
            Try
                ' Load the image from the dropped file and display it in the PictureBox
                PixelBox_PackageThumbnail.Image = SafeImageFromFile(files(0))

                ' Check if the aspect ratio of the image is already 16:9
                Dim aspectRatio As Decimal = CDec(PixelBox_PackageThumbnail.Image.Width / PixelBox_PackageThumbnail.Image.Height)
                Dim Ratio_16_9 As Decimal = CDec(1.77777777777778)
                aspectRatio_IsAlready_16_9 = Decimal.Equals(aspectRatio, Ratio_16_9)

                ' Calculate the dimensions for forcing the aspect ratio to 16:9 if needed
                If aspectRatio_IsAlready_16_9 = False Then
                    Dim aspectRatio_16_9 As Double = 16.0 / 9.0
                    Dim n1 As Double = PixelBox_PackageThumbnail.Image.Width
                    n1 = Math.Round(n1 / 16) * 16 - 16

                    Dim n2 As Double = PixelBox_PackageThumbnail.Image.Height
                    n2 = n1 / aspectRatio_16_9

                    ForceImageAspectRatio_16_9_Size.Width = Convert.ToInt32(n1)
                    ForceImageAspectRatio_16_9_Size.Height = Convert.ToInt32(n2)
                End If
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' PackageMaker - DragEnter
    Private Sub PackageMaker_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        ' Check if the dragged file is supported and set the appropriate drag effect
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        If e.Data.GetDataPresent(DataFormats.FileDrop) And SupportedImageFormats.Contains(Path.GetExtension(files(0)).ToLower) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Save (ToolStripMenuItem) - Click
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        ' Show the save file dialog for saving the thumbnail image
        If SaveFileDialog_PackageThumbnail.ShowDialog = DialogResult.OK Then
            ' Resize and save the thumbnail image
            If aspectRatio_IsAlready_16_9 = False Then
                Dim bmp = New Bitmap(ForceImageAspectRatio_16_9_Size.Width, ForceImageAspectRatio_16_9_Size.Height)
                Using g As Graphics = Graphics.FromImage(bmp)
                    ' Draw the original image at the new size on the memory bitmap
                    g.DrawImage(PixelBox_PackageThumbnail.Image, 0, 0, bmp.Width, bmp.Height)

                    ' Save the resized bitmap
                    bmp.Save(SaveFileDialog_PackageThumbnail.FileName, Imaging.ImageFormat.Png)
                End Using
            Else
                ' Save the original thumbnail image
                PixelBox_PackageThumbnail.Image.Save(SaveFileDialog_PackageThumbnail.FileName, Imaging.ImageFormat.Png)
            End If
        End If
    End Sub

    ' ContextMenuStrip_PackageThumbnail - Opening
    Private Sub ContextMenuStrip_PackageThumbnail_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_PackageThumbnail.Opening
        ' Enable or disable the "Save" option based on whether an image is present in the PictureBox
        If PixelBox_PackageThumbnail.Image IsNot Nothing Then
            SaveToolStripMenuItem.Enabled = True
        Else
            SaveToolStripMenuItem.Enabled = False
        End If
    End Sub

    ' SafeImageFromFile()
    Public Shared Function SafeImageFromFile(path As String) As Image
        ' Safely load an image from a file
        Dim bytes = File.ReadAllBytes(path)

        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms)
            Return img
        End Using
    End Function

    '
    ' Window Handle Code
    '

    ' Move Window - Panel
    Private Sub Panel_Main_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Main.MouseDown
        ' Allow dragging the form by clicking and holding the panel
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Panel_Main.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    ' Move Window - Label_Application_Title
    Private Sub Label_Application_Title_MouseDown(sender As Object, e As MouseEventArgs) Handles Label_Application_Title.MouseDown
        ' Allow dragging the form by clicking and holding the application title label
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Label_Application_Title.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    ' Minimize
    Private Sub PictureBox_Minimize_Click(sender As Object, e As EventArgs) Handles PictureBox_Minimize.Click
        ' Minimize the form
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Close
    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        ' Close the form
        Me.Close()
    End Sub

    ' Minimize Blue
    Private Sub PictureBox_Minimize_MouseHover(sender As Object, e As EventArgs) Handles PictureBox_Minimize.MouseHover
        ' Change the minimize button image to Minimize_Blue when hovering
        PictureBox_Minimize.Image = My.Resources.Minimize_Blue
    End Sub

    ' Minimize Grey
    Private Sub PictureBox_Minimize_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_Minimize.MouseLeave
        ' Change the minimize button image to Minimize_Grey when not hovering
        PictureBox_Minimize.Image = My.Resources.Minimize_Grey
    End Sub

    ' Form Deactivate Close Grey
    Private Sub Main_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        ' Change the close button image to Close_Grey and set the panel background color to a dark shade when the form is deactivated
        PictureBox_Close.Image = My.Resources.Close_Grey
        Panel_Main.BackColor = Color.FromArgb(28, 30, 34)
    End Sub

    ' Form Activated Close Red
    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Change the close button image to Close_Red and set the panel background color to black when the form is activated
        PictureBox_Close.Image = My.Resources.Close_Red
        Panel_Main.BackColor = Color.Black
    End Sub
End Class