Public Class PackageMaker
    ReadOnly SupportedIamgeFormats() As String = {".png", ".bmp", ".jpeg", ".jpg", ".tiff", ".tif"}
    Dim ForceImageAspectRatio_16_9_Size As Size
    Dim aspectRatio_IsAlready_16_9 As Boolean = False
    Private Sub PackageMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip_PackageThumbnail.Renderer = New ToolStripProfessionalRenderer(New ColorTable())
    End Sub
    'Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If TextBox_PackageName.Text.Length > 0 And TextBox_Tag.Text.Length > 0 And PixelBox_PackageThumbnail.Image IsNot Nothing Then
            SaveFileDialog_PackJson.FileName = "PACK.json"
            If Not Directory.Exists(SaveFileDialog_PackJson.InitialDirectory) Then
                SaveFileDialog_PackJson.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            End If

            If SaveFileDialog_PackJson.ShowDialog = DialogResult.OK Then
                Dim sb As New StringBuilder
                Dim sw As New StringWriter(sb)
                Dim writer As JsonWriter = New JsonTextWriter(sw) With {
                            .Formatting = Formatting.Indented
                        }
                writer.WriteStartObject()
                writer.WritePropertyName("name")
                writer.WriteValue(TextBox_PackageName.Text)
                writer.WritePropertyName("tag")
                writer.WriteValue(TextBox_Tag.Text.ToLower)
                writer.WriteEndObject()

                If aspectRatio_IsAlready_16_9 = False Then
                    Dim bmp = New Bitmap(ForceImageAspectRatio_16_9_Size.Width, ForceImageAspectRatio_16_9_Size.Height)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        'draw the original at the new size on memory bitmap
                        g.DrawImage(PixelBox_PackageThumbnail.Image, 0, 0, bmp.Width, bmp.Height)
                        'save the temp resized bitmamp
                        bmp.Save(Path.GetDirectoryName(SaveFileDialog_PackJson.FileName) & "\thumbnail.png", Imaging.ImageFormat.Png)
                    End Using
                Else
                    PixelBox_PackageThumbnail.Image.Save(Path.GetDirectoryName(SaveFileDialog_PackJson.FileName) & "\thumbnail.png", Imaging.ImageFormat.Png)
                End If

                My.Computer.FileSystem.WriteAllText(SaveFileDialog_PackJson.FileName, sb.ToString, False)

                'Clear all for next
                'SaveFileDialog_PackJson.InitialDirectory = ""
                TextBox_PackageName.Clear()
                TextBox_Tag.Clear()
                PixelBox_PackageThumbnail.Image = Nothing
                PixelBox_PackageThumbnail.Refresh()
            End If
        Else
            MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
        End If
    End Sub
    'TextBox_PackageName - KeyPress
    Private Sub TextBox_PackageName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_PackageName.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And TextBox_PackageName.Text.Length > 0 Then
            e.Handled = True
            TextBox_Tag.Focus()
        End If
    End Sub
    'TextBox_Tag - KeyPress
    Private Sub TextBox_Tag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Tag.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And TextBox_PackageName.Text.Length > 0 And TextBox_Tag.Text.Length > 0 Then
            e.Handled = True
            Button_Save.PerformClick()
        End If
    End Sub
    'PackageMaker - DragDrop
    Private Sub PackageMaker_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                'ClearPicturebox
                '???
                PixelBox_PackageThumbnail.Image = SafeImageFromFile(files(0))

                Dim aspectRatio As Decimal = CDec(PixelBox_PackageThumbnail.Image.Width / PixelBox_PackageThumbnail.Image.Height)
                Dim Ratio_16_9 As Decimal = CDec(1.77777777777778)
                aspectRatio_IsAlready_16_9 = Decimal.Equals(aspectRatio, Ratio_16_9)

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
    'PackageMaker - DragEnter
    Private Sub PackageMaker_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And SupportedIamgeFormats.Contains(Path.GetExtension(files(0)).ToLower) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Save (ToolStripMenuItem) - Click
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveFileDialog_PackageThumbnail.ShowDialog = DialogResult.OK Then
            If aspectRatio_IsAlready_16_9 = False Then
                Dim bmp = New Bitmap(ForceImageAspectRatio_16_9_Size.Width, ForceImageAspectRatio_16_9_Size.Height)
                Using g As Graphics = Graphics.FromImage(bmp)
                    'draw the original at the new size on memory bitmap
                    g.DrawImage(PixelBox_PackageThumbnail.Image, 0, 0, bmp.Width, bmp.Height)
                    'save the temp resized bitmamp
                    bmp.Save(SaveFileDialog_PackageThumbnail.FileName, Imaging.ImageFormat.Png)
                End Using
            Else
                PixelBox_PackageThumbnail.Image.Save(SaveFileDialog_PackageThumbnail.FileName, Imaging.ImageFormat.Png)
            End If
        End If
    End Sub
    'ContextMenuStrip_PackageThumbnail - Opening
    Private Sub ContextMenuStrip_PackageThumbnail_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_PackageThumbnail.Opening
        If PixelBox_PackageThumbnail.Image IsNot Nothing Then
            SaveToolStripMenuItem.Enabled = True
        Else
            SaveToolStripMenuItem.Enabled = False
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