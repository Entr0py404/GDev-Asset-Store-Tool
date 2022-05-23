Public Class Form1
    'TextBox_SelectedFont - TextChanged
    Private Sub TextBox_SelectedFont_TextChanged(sender As Object, e As EventArgs) Handles TextBox_SelectedFont.TextChanged
        FastColoredTextBox_AssetJson.Clear()
        If TextBox_SelectedFont.Text.EndsWith(".ttf") Or TextBox_SelectedFont.Text.EndsWith(".otf") Then
            If RadioButton_Text.Checked Then
                Dim textobject_template As String = My.Resources.textobject_template 'File.ReadAllText("Asset Templates\textobject.template.json")
                Dim jsonFile As JObject = JObject.Parse(textobject_template)
                jsonFile.Item("objectAssets")(0)("object")("font") = TextBox_SelectedFont.Text
                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            End If

            If RadioButton_BBText.Checked Then
                Dim bbtextobject_template As String = My.Resources.bbtextobject_template
                Dim jsonFile As JObject = JObject.Parse(bbtextobject_template)
                jsonFile.Item("objectAssets")(0)("object")("content")("fontFamily") = TextBox_SelectedFont.Text
                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            End If

            If RadioButton_BitmapText.Checked Then
                Dim bitmaptext_template As String = My.Resources.bitmaptext_template
                Dim jsonFile As JObject = JObject.Parse(bitmaptext_template)
                jsonFile.Item("objectAssets")(0)("object")("content")("fontFamily") = TextBox_SelectedFont.Text
                FastColoredTextBox_AssetJson.Text = jsonFile.ToString
            End If
        End If
    End Sub
    'Panel_SelectedFont - DragEnter
    Private Sub Panel_SelectedFont_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_SelectedFont.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Path.GetExtension(files(0)) = ".ttf" Or Path.GetExtension(files(0)) = ".otf" Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Panel_SelectedFont - DragDrop
    Private Sub Panel_SelectedFont_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_SelectedFont.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        TextBox_SelectedFont.Text = Path.GetFileName(files(0))
    End Sub
    'Panel_BitmapAtlasImage - DragEnter
    Private Sub Panel_BitmapAtlasImage_DragEnter(sender As Object, e As DragEventArgs) Handles Panel_BitmapAtlasImage.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Path.GetExtension(files(0)) = ".png" Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Panel_BitmapAtlasImage - DragDrop
    Private Sub Panel_BitmapAtlasImage_DragDrop(sender As Object, e As DragEventArgs) Handles Panel_BitmapAtlasImage.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        TextBox_BitmapAtlasImage.Text = Path.GetFileName(files(0))
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