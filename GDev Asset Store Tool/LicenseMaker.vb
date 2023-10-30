Public Class LicenseMaker
    Dim UsingDirectoryFromDragDrop As Boolean = False

    ' Button_Open - Click
    Private Sub Button_Open_Click(sender As Object, e As EventArgs) Handles Button_Open.Click
        ' Open file dialog to select a license file
        If OpenFileDialog_License.ShowDialog = DialogResult.OK Then
            ' Read the contents of the selected license file
            Dim ReadFile As String() = File.ReadAllLines(OpenFileDialog_License.FileName)
            SaveFileDialog_License.InitialDirectory = Path.GetDirectoryName(OpenFileDialog_License.FileName)

            ' Check the license type and set the corresponding combo box selection
            If ReadFile(0) = "CC0 (public domain)" Then
                ComboBox_License.SelectedIndex = 0
            Else
                Dim index As Integer = ComboBox_License.FindStringExact(ReadFile(0))
                ComboBox_License.SelectedIndex = index
            End If

            ' Set the artist and artist link text boxes
            TextBox_Artist.Text = ReadFile(1)
            TextBox_ArtistLink.Text = ReadFile(2)
        End If
    End Sub

    ' Button_Save - Click
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        ' Check if all fields are filled out
        If ComboBox_License.SelectedIndex > -1 And Not TextBox_Artist.Text = "" And Not TextBox_ArtistLink.Text = "" Then
            SaveFileDialog_License.FileName = "license.txt"

            ' Check if the initial directory is set based on drag and drop or manually selected directory
            If UsingDirectoryFromDragDrop = False And Not SaveFileDialog_License.InitialDirectory = MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath Then
                SaveFileDialog_License.InitialDirectory = MetadataGenerator.FolderBrowserDialog_Selected_Directory.SelectedPath
            End If

            ' Check if the initial directory exists, if not, set it to the desktop
            If Not Directory.Exists(SaveFileDialog_License.InitialDirectory) Then
                SaveFileDialog_License.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            End If

            ' Open the save file dialog to choose the license file location
            If SaveFileDialog_License.ShowDialog = DialogResult.OK Then
                ' Write the selected license information to the file
                Dim TXT_File As StreamWriter
                TXT_File = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog_License.FileName, False)
                TXT_File.WriteLine(ComboBox_License.SelectedItem.ToString)
                TXT_File.WriteLine(TextBox_Artist.Text)
                TXT_File.WriteLine(TextBox_ArtistLink.Text)
                TXT_File.Close()

                ' Clear all fields for the next operation
                ComboBox_License.SelectedIndex = -1
                TextBox_Artist.Clear()
                TextBox_ArtistLink.Clear()
            End If
        Else
            MsgBox("Please fill out all fields.", MsgBoxStyle.Information)
        End If
    End Sub

    ' LicenseMaker - DragEnter
    Private Sub LicenseMaker_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        ' Check if the dragged file is "license.txt" and enable copying
        Dim DraggedFiles() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Path.GetFileName(DraggedFiles(0)) = "license.txt" Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' LicenseMaker - DragDrop
    Private Sub LicenseMaker_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        ' Handle the dropped "license.txt" file
        Dim DroppedFiles() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        Dim ReadFile As String() = File.ReadAllLines(DroppedFiles(0))
        SaveFileDialog_License.InitialDirectory = Path.GetDirectoryName(DroppedFiles(0))
        UsingDirectoryFromDragDrop = True

        ' Check the license type and set the corresponding combo box selection
        If ReadFile(0) = "CC0 (public domain)" Then
            ComboBox_License.SelectedIndex = 0
        Else
            Dim index As Integer = ComboBox_License.FindStringExact(ReadFile(0))
            ComboBox_License.SelectedIndex = index
        End If

        ' Set the artist and artist link text boxes
        TextBox_Artist.Text = ReadFile(1)
        TextBox_ArtistLink.Text = ReadFile(2)
    End Sub

    ' LinkLabel_Wiki_Info - LinkClicked
    Private Sub LinkLabel_Wiki_Info_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Wiki_Info.LinkClicked
        ' Open the link to the GDevelop Wiki about licenses
        LinkLabel_Wiki_Info.LinkVisited = True
        Process.Start("https://wiki.gdevelop.io/gdevelop5/community/contribute-to-the-assets-store#license")
    End Sub

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