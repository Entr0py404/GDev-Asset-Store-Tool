
Public Class LicenseMaker
    'LicenseMaker - Load
    Private Sub LicenseMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
    End Sub
    'Button_Open - Click
    Private Sub Button_Open_Click(sender As Object, e As EventArgs) Handles Button_Open.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim Readfile As String() = File.ReadAllLines(OpenFileDialog1.FileName)
            SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(OpenFileDialog1.FileName)
            If Readfile(0) = "CC0 (public domain)" Then
                ComboBox_License.SelectedIndex = 0
            Else
                Dim index As Integer = ComboBox_License.FindStringExact(Readfile(0))
                ComboBox_License.SelectedIndex = index
            End If
            TextBox_Artist.Text = Readfile(1)
            TextBox_ArtistLink.Text = Readfile(2)
        End If
    End Sub
    'Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If ComboBox_License.SelectedIndex > -1 And Not TextBox_Artist.Text = "" And Not TextBox_ArtistLink.Text = "" Then
            SaveFileDialog1.FileName = "license.txt"
            If SaveFileDialog1.InitialDirectory = "" Then
                If Directory.Exists(MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath) Then
                    SaveFileDialog1.InitialDirectory = MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath
                Else
                    SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
                End If
            End If

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim file As StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, False)
                file.WriteLine(ComboBox_License.SelectedItem.ToString)
                file.WriteLine(TextBox_Artist.Text)
                file.WriteLine(TextBox_ArtistLink.Text)
                file.Close()
                'Clear all for next
                SaveFileDialog1.InitialDirectory = ""
                ComboBox_License.SelectedIndex = -1
                TextBox_Artist.Clear()
                TextBox_ArtistLink.Clear()
            End If
        Else
            MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
        End If
    End Sub
    'LicenseMaker - DragEnter
    Private Sub Button_Open_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Path.GetFileName(files(0)) = "license.txt" Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'LicenseMaker - DragDrop
    Private Sub Button_Open_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        Dim Readfile As String() = File.ReadAllLines(files(0))
        SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(files(0))
        If Readfile(0) = "CC0 (public domain)" Then
            ComboBox_License.SelectedIndex = 0
        Else
            Dim index As Integer = ComboBox_License.FindStringExact(Readfile(0))
            ComboBox_License.SelectedIndex = index
        End If
        TextBox_Artist.Text = Readfile(1)
        TextBox_ArtistLink.Text = Readfile(2)
    End Sub
    'LinkLabel_Wiki_Info - LinkClicked
    Private Sub LinkLabel_Wiki_Info_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Wiki_Info.LinkClicked
        LinkLabel_Wiki_Info.LinkVisited = True
        Process.Start("https://wiki.gdevelop.io/gdevelop5/community/contribute-to-the-assets-store#license")
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