Public Class AssetInfo
    Dim assetPath As String = ""
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
    'LoadAsset
    Public Sub LoadAsset(assetFilePath As String)
        Console.WriteLine(assetFilePath)
        Dim TempFileName As String = Path.GetFileNameWithoutExtension(assetFilePath)

        If TempFileName.StartsWith("tiled_") Or TempFileName.StartsWith("Tiled_") Then
            TempFileName = TempFileName.Substring(TempFileName.IndexOf("_") + 1)
        End If

        If TempFileName.StartsWith("9patch_") Or TempFileName.StartsWith("9Patch_") Then
        End If

        If TempFileName.Contains("_") Then
            TempFileName = Microsoft.VisualBasic.Left(TempFileName, TempFileName.IndexOf("_"))
        End If
        Console.WriteLine(Path.GetDirectoryName(assetFilePath))
        assetPath = Path.GetDirectoryName(assetFilePath)

        Dim assetFilePaths As String() = Directory.GetFiles(Path.GetDirectoryName(assetFilePath), "*" & TempFileName & "*.png", SearchOption.TopDirectoryOnly)
        Console.WriteLine("Total Animations Frame Count: " & assetFilePaths.Count)

        'For Each PNG_file As String In Directory.GetFiles(Path.GetDirectoryName(assetFilePath), "*" & TempFileName & "*.png", SearchOption.TopDirectoryOnly)
        'ListBox1.Items.Add(PNG_file)
        'Next

        'Object Name
        Label_ObjectName.Text = "Object Name: " & TempFileName
        Console.WriteLine(TempFileName)

        'Get Meta data file for Time Between Frames, Loop
        Console.WriteLine(Path.GetDirectoryName(assetFilePath) & "\" & TempFileName & "_METADATA.json")
        'Time Between Frames

        If File.Exists(Path.GetDirectoryName(assetFilePath) & "\" & TempFileName & "_METADATA.json") Then
            Dim jsonFile As JObject = JObject.Parse(File.ReadAllText(Path.GetDirectoryName(assetFilePath) & "\" & TempFileName & "_METADATA.json"))
            'Dim tBF As Decimal = CDec(jsonFile.SelectToken("timeBetweenFrames"))
            'Timer_Animation.Interval = CInt(tBF * 1000) 'This with cause a crash if 0

            'Dim islooping As Boolean = CBool(jsonFile.SelectToken("loop").ToString.ToLower)
            'Dim tBF_FromFile As Decimal = CDec(jsonFile.SelectToken("timeBetweenFrames"))
            'NumericUpDown_TimeBetweenFrames.Value = tBF_FromFile

            'Dim tBF_Str As String = CStr(Math.Round(NumericUpDown_TimeBetweenFrames.Value, 4))
            'tBF_Str = tBF_Str.TrimEnd(CChar("0"))
            'tBF_Str = tBF_Str.TrimEnd(CChar("."))
            'TextBox_TimeBetweenFrames.Text = tBF_Str 'Math.Round(NumericUpDown_TimeBetweenFrames.Value, 4)

            'Time Between Frames
            Label_TimeBetweenFrames.Text = "Time Between Frames: " & jsonFile.SelectToken("timeBetweenFrames").ToString()

            'Loop
            Label_Loop.Text = "Loop: " & jsonFile.SelectToken("loop").ToString
        Else
            Label_TimeBetweenFrames.Text = "Time Between Frames: NA"
            Label_Loop.Text = "Loop: NA"
        End If


        'Frame Count


        'Number of Animations & List of Animation Names
        Label_AnimationsList.Text = "Contains " & ComboBox_Animations.Items.Count.ToString() & " Animations: "
    End Sub
    'Button_OpenDirectory - Click
    Private Sub Button_OpenDirectory_Click(sender As Object, e As EventArgs) Handles Button_OpenDirectory.Click
        If Directory.Exists(assetPath) Then
            Process.Start(assetPath)
        End If
    End Sub
End Class