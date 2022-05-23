Public Class ClipboardAsset
    Dim ObjectsJson As New JArray
    'Button_PasteObjects - Click
    Private Sub Button_PasteObjects_Click(sender As Object, e As EventArgs) Handles Button_PasteObject.Click
        If Clipboard.ContainsText Then
            Dim CB_Text As String = Clipboard.GetText
            If CB_Text.Contains("GDEVELOP_Object_CLIPBOARD_KIND") Or CB_Text.Contains("000kind") Then
                Dim jsonFromClipboard As JObject = JObject.Parse(CB_Text)
                ListBox_Objects.Items.Add(jsonFromClipboard.Item("content")("name"))
                ObjectsJson.Add(jsonFromClipboard.SelectToken("content"))
            End If
        End If
    End Sub
    'ListBox_Objects - DoubleClick
    Private Sub ListBox_Objects_DoubleClick(sender As Object, e As EventArgs) Handles ListBox_Objects.DoubleClick
        If Not ListBox_Objects.SelectedIndex = -1 Then
            ObjectsJson.RemoveAt(ListBox_Objects.SelectedIndex)
            ListBox_Objects.Items.RemoveAt(ListBox_Objects.SelectedIndex)
        End If
    End Sub
    'Button_GenerateAsset - Click
    Private Sub Button_GenerateAsset_Click(sender As Object, e As EventArgs) Handles Button_GenerateAsset.Click
        If TextBox_Description.Text.Length > 0 And ListBox_Objects.Items.Count > 0 Then
            Dim jsonFile As JObject = JObject.Parse(My.Resources.asset_template)
            jsonFile.Item("description") = TextBox_Description.Text
            If ListBox_Objects.Items.Count = 1 Then
                jsonFile.Item("objectAssets")(0)("object") = CType(ObjectsJson.Item(0), JToken)
            Else
                jsonFile.Item("objectAssets")(0)("object") = ObjectsJson
                Console.WriteLine(ObjectsJson)
            End If
            FastColoredTextBox_AssetJson.Text = jsonFile.ToString
        End If
    End Sub
    'Button_Save - Click
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
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox_AssetJson.Text, False)
            End If
        Else
            MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
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