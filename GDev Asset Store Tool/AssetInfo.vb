
Public Class AssetInfo
    Dim assetPath As String = ""
    Dim AnimationFiles As New List(Of String)()
    Dim AllAnimationFiles As New List(Of String)()
    Dim AnimLoopCounter As Integer = 0
    Dim ObjectName As String = ""
    'AssetInfo - Load
    Private Sub AssetInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Button_PreviousAnimation - Click
    Private Sub Button_PreviousAnimation_Click(sender As Object, e As EventArgs) Handles Button_PreviousAnimation.Click
        If Not ComboBox_Animations.SelectedIndex = -1 Then
            If ComboBox_Animations.SelectedIndex = 0 Then
                ComboBox_Animations.SelectedIndex = ComboBox_Animations.Items.Count - 1
            Else
                ComboBox_Animations.SelectedIndex -= 1
            End If
        End If
    End Sub
    'Button_NextAnimation - Click
    Private Sub Button_NextAnimation_Click(sender As Object, e As EventArgs) Handles Button_NextAnimation.Click
        If Not ComboBox_Animations.SelectedIndex = -1 Then
            If ComboBox_Animations.SelectedIndex = ComboBox_Animations.Items.Count - 1 Then
                ComboBox_Animations.SelectedIndex = 0
            Else
                ComboBox_Animations.SelectedIndex += 1
            End If
        End If
    End Sub
    'Button_OpenDirectory - Click
    Private Sub Button_OpenDirectory_Click(sender As Object, e As EventArgs) Handles Button_OpenDirectory.Click
        If Directory.Exists(assetPath) Then
            Process.Start(assetPath)
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
    'CountCharacter
    Public Function CountCharacter(ByVal inputString As String, ByVal charToCount As Char) As Integer
        Return inputString.Count(Function(c As Char) c = charToCount)
    End Function
    'LoadAsset
    Public Sub LoadAsset(assetFilePath As String)
        Try
            'Clear all for next
            AllAnimationFiles.Clear()
            AnimationFiles.Clear()
            ComboBox_Animations.Items.Clear()
            Label_ObjectName.Text = "Object Name: "
            Label_AnimationsList.Text = "Contains # Animations: "
            Label_AnimationsList.Show()
            Label_TimeBetweenFrames.Text = "Time Between Frames: "
            Label_TimeBetweenFrames.Show()
            Label_FrameCount.Text = "Frame Count: "
            Label_FrameCount.Show()
            Label_Loop.Text = "Loop: "
            Label_Loop.Show()
            AnimLoopCounter = 0
            PixelBox_PreviewImage.Image = Nothing

            Dim LastAnimationName As String = ""
            Dim Temp_ObjectName As String = ""
            Dim Temp_AnimationName As String = ""

            Dim TempFileNameNoExt As String = Path.GetFileNameWithoutExtension(assetFilePath)
            assetPath = Path.GetDirectoryName(assetFilePath)

            If TempFileNameNoExt.ToLower.StartsWith("tiled_") Then

                PixelBox_PreviewImage.Image = SafeImageFromFile(assetFilePath)
                Label_ObjectName.Text = "Object Name: " & TempFileNameNoExt.Replace("tiled_", "")
                Label_AnimationsList.Hide()
                Label_TimeBetweenFrames.Hide()
                Label_FrameCount.Hide()
                Label_Loop.Hide()

            ElseIf TempFileNameNoExt.ToLower.StartsWith("9patch_") Then  'If starts with tiled_ or 9patch_

                PixelBox_PreviewImage.Image = SafeImageFromFile(assetFilePath)
                TempFileNameNoExt = TempFileNameNoExt.Replace("9patch_", "")
                TempFileNameNoExt = Microsoft.VisualBasic.Left(TempFileNameNoExt, TempFileNameNoExt.IndexOf("_"))
                Label_ObjectName.Text = "Object Name: " & TempFileNameNoExt
                Label_AnimationsList.Hide()
                Label_TimeBetweenFrames.Hide()
                Label_FrameCount.Hide()
                Label_Loop.Hide()

            ElseIf CountCharacter(TempFileNameNoExt, CChar("_")) = 0 Then

                PixelBox_PreviewImage.Image = SafeImageFromFile(assetFilePath)
                Label_ObjectName.Text = "Object Name: " & TempFileNameNoExt
                Label_AnimationsList.Hide()
                Label_TimeBetweenFrames.Hide()
                Label_FrameCount.Hide()
                Label_Loop.Hide()

            ElseIf CountCharacter(TempFileNameNoExt, CChar("_")) <= 2 Then 'CountCharacter "_"

                TempFileNameNoExt = Microsoft.VisualBasic.Left(TempFileNameNoExt, TempFileNameNoExt.IndexOf("_"))
                'Object Name
                Label_ObjectName.Text = "Object Name: " & TempFileNameNoExt
                ObjectName = TempFileNameNoExt

                ComboBox_Animations.BeginUpdate()
                AllAnimationFiles.AddRange(Directory.GetFiles(Path.GetDirectoryName(assetFilePath), "*.png", SearchOption.TopDirectoryOnly).Where(Function(x) Path.GetFileName(x).StartsWith(TempFileNameNoExt + "_")))

                Label_AnimationsList.Text = ""

                For Each AnimationName As String In AllAnimationFiles
                    Temp_ObjectName = Path.GetFileName(AnimationName)
                    If Temp_ObjectName.Contains("_") Then
                        Temp_ObjectName = Temp_ObjectName.Substring(0, Temp_ObjectName.IndexOf("_"))

                        If CountCharacter(Path.GetFileName(AnimationName), CChar("_")) = 1 Then
                            Temp_AnimationName = Path.GetFileNameWithoutExtension(AnimationName)
                            Temp_AnimationName = Temp_AnimationName.Substring(Temp_AnimationName.IndexOf("_") + 1)

                            If IsNumeric(Temp_AnimationName) Then
                                Temp_AnimationName = Path.GetFileNameWithoutExtension(AnimationName)
                                Temp_AnimationName = Temp_AnimationName.Substring(0, Temp_AnimationName.IndexOf("_"))
                                AnimationName = "NA"
                            Else
                                Temp_AnimationName = Path.GetFileNameWithoutExtension(AnimationName)
                                Temp_AnimationName = Temp_AnimationName.Substring(Temp_AnimationName.IndexOf("_") + 1)
                                AnimationName = Temp_AnimationName
                            End If

                        Else
                            AnimationName = Path.GetFileName(AnimationName)
                            AnimationName = AnimationName.Substring(AnimationName.IndexOf("_") + 1)
                            AnimationName = AnimationName.Substring(0, AnimationName.IndexOf("_"))
                        End If

                        If Not AnimationName = LastAnimationName And ObjectName = Temp_ObjectName Then

                            LastAnimationName = AnimationName
                            'Add animation names to combobox
                            ComboBox_Animations.Items.Add(LastAnimationName)

                            If ComboBox_Animations.Items.Count = 1 Then
                                Label_AnimationsList.Text += LastAnimationName
                            Else
                                Label_AnimationsList.Text += ", " & LastAnimationName
                            End If
                        End If
                    End If
                Next
                ComboBox_Animations.EndUpdate()

                'Number of Animations & List of Animation Names
                Label_AnimationsList.Text = "Contains " & ComboBox_Animations.Items.Count.ToString() & " Animations: " & Label_AnimationsList.Text

                If ComboBox_Animations.Items.Count > 0 Then
                    ComboBox_Animations.SelectedIndex = 0
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Timer_Animation - Tick
    Private Sub Timer_Animation_Tick(sender As Object, e As EventArgs) Handles Timer_Animation.Tick
        If AnimationFiles.Count > 0 Then
            Dim AnimationFile As String = AnimationFiles.Item(0).ToString()
            If AnimLoopCounter < AnimationFiles.Count Then
                AnimLoopCounter += 1
                AnimationFile = AnimationFile.Substring(0, AnimationFile.LastIndexOf("_") + 1) & AnimLoopCounter & ".png"
                PixelBox_PreviewImage.Image = SafeImageFromFile(AnimationFile)
            Else
                AnimLoopCounter = 1 'Set to first frame on animation play completed
                AnimationFile = AnimationFile.Substring(0, AnimationFile.LastIndexOf("_") + 1) & AnimLoopCounter & ".png"
                PixelBox_PreviewImage.Image = SafeImageFromFile(AnimationFile)
            End If
        End If
    End Sub
    'ComboBox_Animations - SelectedIndexChanged
    Private Sub ComboBox_Animations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Animations.SelectedIndexChanged
        Try
            AnimationFiles.Clear()
            Dim ComboBox_SelectedItem As String = "_" & ComboBox_Animations.SelectedItem.ToString
            Dim ThisObjectname As String = ""
            Dim Animationname As String = ""
            For Each PNG_file As String In AllAnimationFiles

                If CountCharacter(Path.GetFileName(PNG_file), CChar("_")) >= 2 Then
                    ThisObjectname = Path.GetFileName(PNG_file)
                    ThisObjectname = ThisObjectname.Substring(0, ThisObjectname.IndexOf("_"))

                    Animationname = Path.GetFileName(PNG_file)
                    Animationname = Animationname.Substring(Animationname.IndexOf("_") + 1)
                    Animationname = Animationname.Substring(0, Animationname.IndexOf("_"))

                    If ObjectName = ThisObjectname And Animationname = ComboBox_Animations.SelectedItem.ToString Then
                        AnimationFiles.Add(PNG_file)
                    End If

                ElseIf ComboBox_Animations.SelectedItem.ToString = "NA" Then
                    AnimationFiles.Add(PNG_file)
                    ComboBox_SelectedItem = ""
                End If

            Next

            'Get Meta data file for Time Between Frames, Loop
            If File.Exists(assetPath & "\" & ObjectName & ComboBox_SelectedItem & "_METADATA.json") Then
                Dim jsonFile As JObject = JObject.Parse(File.ReadAllText(assetPath & "\" & ObjectName & ComboBox_SelectedItem & "_METADATA.json"))
                'Time Between Frames
                Label_TimeBetweenFrames.Text = "Time Between Frames: " & jsonFile.SelectToken("timeBetweenFrames").ToString()

                Dim tBF As Decimal = CDec(jsonFile.SelectToken("timeBetweenFrames"))
                Timer_Animation.Interval = CInt(tBF * 1000) 'This with cause a crash if 0
                Timer_Animation.Enabled = True

                'Loop
                Label_Loop.Text = "Loop: " & jsonFile.SelectToken("loop").ToString
            ElseIf IsNumeric(Path.GetFileNameWithoutExtension(AllAnimationFiles(0).ToString).Last()) Then
                PixelBox_PreviewImage.Image = SafeImageFromFile(AllAnimationFiles(0).ToString)
                Label_TimeBetweenFrames.Text = "Time Between Frames: NA"
                Label_Loop.Text = "Loop: NA"
            Else
                Timer_Animation.Enabled = False
                'Console.WriteLine(assetPath & "\" & ObjectName & ComboBox_SelectedItem & ".png")
                PixelBox_PreviewImage.Image = SafeImageFromFile(assetPath & "\" & ObjectName & ComboBox_SelectedItem & ".png")
                Label_TimeBetweenFrames.Text = "Time Between Frames: NA"
                Label_Loop.Text = "Loop: NA"
            End If

            'Frame Count
            Label_FrameCount.Text = "Frame Count: " & AnimationFiles.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class