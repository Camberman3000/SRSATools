Imports IniFile


Class MainWindow


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim WindowsDriveLetter As String = Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 3)


        If (Not System.IO.Directory.Exists(WindowsDriveLetter & "\Setup analyzer config\")) Then
            System.IO.Directory.CreateDirectory(WindowsDriveLetter & "\Setup analyzer config\")
        End If

    End Sub

    Private Sub LoadINI()

        Try

            Dim WindowsDriveLetter As String = Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 3)

            Dim ini As New IniFile.IniFile(WindowsDriveLetter & "\Setup analyzer config\SetupAnalyzer.ini")

            'Dim ini As New IniFile.IniFile

            ' Load and existing file
            ' ini.Load("C:\temp\ini2open.ini")
            ini.AddSection("DB")
            ini.AddKey("ActiveRaceWeekendDBConnString", "", "DB")
            ini.AddKey("ActiveRaceWeekendDBConnStringSaved", "", "DB")
            ini.AddKey("ActiveDBFileName", "", "DB")
            ini.AddKey("ActiveDBFullPath", "", "DB")

            ini.AddSection("ProgramSetup")
            ini.AddKey("CheckBoxSetupSummaryDiskSpaceConfigChecked", "", "ProgramSetup")
            ini.AddKey("ComboBoxWorkingDirectorySelectedIndex", "", "ProgramSetup")
            ini.AddKey("DeleteWorkingDirectoryFilesWhenDownTo", "", "ProgramSetup")
            ini.AddKey("FirstTimeDeleteWhenDownToChosen", "", "ProgramSetup")
            ini.AddKey("AlwaysStartMaximized", "", "ProgramSetup")
            ini.AddKey("CustomerEmailAddress", "", "ProgramSetup")
            ini.AddKey("HTMFilePathForErroremail", "", "ProgramSetup")
            ini.AddKey("ModifiedSpaceOnDiskNumber0", "", "ProgramSetup")
            ini.AddKey("ModifiedSpaceOnDiskNumber1", "", "ProgramSetup")
            ini.AddKey("ModifiedSpaceOnDiskNumber2", "", "ProgramSetup")
            ini.AddKey("ModifiedSpaceOnDiskNumber3", "", "ProgramSetup")
            ini.AddKey("ModifiedSpaceOnDiskNumber4", "", "ProgramSetup")
            ini.AddKey("ModifiedSpaceOnDiskNumber5", "", "ProgramSetup")
            ini.AddKey("ModifiedSpaceOnDiskNumber6", "", "ProgramSetup")
            ini.AddKey("ModifiedSpaceOnDiskNumber7", "", "ProgramSetup")
            ini.AddKey("ModifiedSpaceOnDiskNumber8", "", "ProgramSetup")
            ini.AddKey("ModifiedSpaceOnDiskNumber9", "", "ProgramSetup")
            ini.AddKey("ModifiedSpaceOnDiskNumber10", "", "ProgramSetup")
            ini.AddKey("OkToSendSupportEmail", "", "ProgramSetup")
            ini.AddKey("OneStepSetupComplete", "", "ProgramSetup")
            ini.AddKey("VersionNumberText", "", "ProgramSetup")
            ini.AddKey("WhenInTrayNormalOperations", "", "ProgramSetup")
            ini.AddKey("WindowBounds", "", "ProgramSetup")
            ini.AddKey("WindowMaximized", "", "ProgramSetup")
            ini.AddKey("OneStepSetupComplete", "", "ProgramSetup")


            ini.AddSection("ProgramOps")
            ini.AddKey("MovedToNewWorkingDirName", "", "ProgramOps")
            ini.AddKey("PlayImportSounds", "", "ProgramOps")
            ini.AddKey("ProgramSetupComplete", "", "ProgramOps")
            ini.AddKey("CurrentRaceWeekendName", "", "ProgramOps")
            ini.AddKey("RaceWeekendLoaded", "", "ProgramOps")
            ini.AddKey("RaceWeekendName", "", "ProgramOps")
            ini.AddKey("SetupCopyFromFolder", "", "ProgramOps")
            ini.AddKey("SetupCopyToFolder", "", "ProgramOps")
            ini.AddKey("SetupExportCopyFromPathChosen", "", "ProgramOps")
            ini.AddKey("SetupExportCopyToFolderOldLocation", "", "ProgramOps")
            ini.AddKey("SetupExportCopyToPathChosen", "", "ProgramOps")
            ini.AddKey("SkipTelemetryDiagnosticInput", "", "ProgramOps")
            ini.AddKey("SkipUserDiagnosticInput", "", "ProgramOps")
            ini.AddKey("TabItemHandlingCondition", "", "ProgramOps")
            ini.AddKey("TelemetryCopyFromFolder", "", "ProgramOps")
            ini.AddKey("TelemetryCopyToFolder", "", "ProgramOps")
            ini.AddKey("TelemetryExportCopyFromPathChosen", "", "ProgramOps")
            ini.AddKey("TelemetryExportCopyToPathChosen", "", "ProgramOps")


            ini.AddSection("Lic")
            ini.AddKey("BWOARC", "", "Lic")
            ini.AddKey("BWOARCK", "", "Lic")
            ini.AddKey("BWOC", "", "Lic")
            ini.AddKey("BWOCK", "", "Lic")
            ini.AddKey("BWRC", "", "Lic")
            ini.AddKey("BWRCK", "", "Lic")
            ini.AddKey("OC", "", "Lic")
            ini.AddKey("OCK", "", "Lic")
            ini.AddKey("OCO", "", "Lic")
            ini.AddKey("RC", "", "Lic")
            ini.AddKey("RCK", "", "Lic")
            ini.AddKey("RCO", "", "Lic")

            ini.AddSection("SpecialDiag")
            ini.AddKey("ChattersDueToMultipleCurbsFirstWheel", "", "SpecialDiag")
            ini.AddKey("ChattersDueToMultipleCurbsSecondWheel", "", "SpecialDiag")
            ini.AddKey("ChattersDueToMultipleCurbsThirdWheel", "", "SpecialDiag")
            ini.AddKey("ChattersDueToMultipleCurbsFourthWheel", "", "SpecialDiag")

            ini.AddKey("MushyDueToMultipleCurbsFirstWheel", "", "SpecialDiag")
            ini.AddKey("MushyDueToMultipleCurbsSecondWheel", "", "SpecialDiag")
            ini.AddKey("MushyDueToMultipleCurbsThirdWheel", "", "SpecialDiag")
            ini.AddKey("MushyDueToMultipleCurbsFourthWheel", "", "SpecialDiag")

            ini.AddKey("ComboBoxChattersOverCurbsFirstWheelNumber", "", "SpecialDiag")
            ini.AddKey("ComboBoxChattersOverCurbsSecondWheelNumber", "", "SpecialDiag")
            ini.AddKey("ComboBoxChattersOverCurbsThirdWheelNumber", "", "SpecialDiag")
            ini.AddKey("ComboBoxChattersOverCurbsFourthWheelNumber", "", "SpecialDiag")

            ini.AddKey("ComboBoxMushyOverCurbsFirstWheelNumber", "", "SpecialDiag")
            ini.AddKey("ComboBoxMushyOverCurbsSecondWheelNumber", "", "SpecialDiag")
            ini.AddKey("ComboBoxMushyOverCurbsThirdWheelNumber", "", "SpecialDiag")
            ini.AddKey("ComboBoxMushyOverCurbsFourthWheelNumber", "", "SpecialDiag")

            'ini.AddSection("MySection")
            'ini.AddKey("MyKey", "MyValue", "MySection")

            ini.Save("C:\Setup analyzer config\test.ini")

        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnMakeFile_Click(sender As Object, e As RoutedEventArgs) Handles btnMakeFile.Click
        LoadINI()
    End Sub


    Private Sub btnChangeValue_Click(sender As Object, e As RoutedEventArgs) Handles btnChangeValue.Click
        Dim File = "C:\Setup analyzer config\test.ini"
        Dim Section = "DB"
        Dim Key = "ActiveRaceWeekendDBConnString"
        ' Dim org = "Organization"

        writeIni(File, Section, Key, "1")


    End Sub
    Private Sub btnGetValue_Click(sender As Object, e As RoutedEventArgs) Handles btnGetValue.Click
        Dim File = "C:\Setup analyzer config\test.ini"
        Dim Section = "DB"
        Dim Key = "ActiveRaceWeekendDBConnString"
        Textbox1.Text = ReadIni(File, Section, Key, "")


    End Sub



    'Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    '    TextBox1.Text = ReadIni(File, Section, Author, "")
    '    TextBox2.Text = ReadIni(File, Section, org, "")
    'End Sub

    'Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    '    writeIni(File, Section, Author, TextBox3.Text)
    '    writeIni(File, Section, org, TextBox4.Text)
    'End Sub



End Class


Module modINI
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32

    Public Sub writeIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamVal As String)
        Dim Result As Integer = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName)
    End Sub

    Public Function ReadIni(ByVal IniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), IniFileName)
        ReadIni = Left$(ParamVal, LenParamVal)
    End Function
End Module




' SQLiteCommand.CommandText = "CREATE TABLE AppConfigDB (UniqueID integer , ActiveRaceWeekendDBConnStringSaved integer , ActiveDBFileName nvarchar(254) , ActiveDBFullPath nvarchar(254) , AlwaysStartMaximized integer , BWOARC nvarchar(254) , BWOARCK nvarchar(254) , BWOC nvarchar(254) , BWOCK nvarchar(254) , BWRC nvarchar(254) , BWRCK nvarchar(254) , ChattersDueToMultipleCurbsFirstWheel integer , ChattersDueToMultipleCurbsSecondWheel integer , ChattersDueToMultipleCurbsThirdWheel integer , ChattersDueToMultipleCurbsFourthWheel integer , CheckBoxSetupSummaryDiskSpaceConfigChecked integer , ComboBoxChattersOverCurbsFirstWheelNumber integer , ComboBoxChattersOverCurbsSecondWheelNumber integer , ComboBoxChattersOverCurbsThirdWheelNumber integer , ComboBoxChattersOverCurbsFouthWheelNumber integer , ComboBoxMushyOverCurbsFirstWheelNumber integer , ComboBoxMushyOverCurbsSecondWheelNumber integer , ComboBoxMushyOverCurbsThirdWheelNumber integer , ComboBoxMushyOverCurbsFouthWheelNumber integer , 
'ComboBoxWorkingDirectorySelectedIndex integer , CurrentRaceWeekendName nvarchar(254) , CustomerEmailAddress nvarchar(254) ,  DeleteWorkingDirectoryFilesWhenDownTo float(6) , FirstTimeDeleteWhenDownToChosen integer , 
'HTMFilePathForErroremail nvarchar(254) , Language integer ,   ModifiedSpaceOnDiskNumber0 integer , ModifiedSpaceOnDiskNumber1 integer , ModifiedSpaceOnDiskNumber2 integer , ModifiedSpaceOnDiskNumber3 integer , ModifiedSpaceOnDiskNumber4 integer , ModifiedSpaceOnDiskNumber5 integer , ModifiedSpaceOnDiskNumber6 integer , ModifiedSpaceOnDiskNumber7 integer , ModifiedSpaceOnDiskNumber8 integer , ModifiedSpaceOnDiskNumber9 integer , ModifiedSpaceOnDiskNumber10 integer ,
' MovedToNewWorkingDirName integer , MushyDueToMultipleCurbsFirstWheel integer , MushyDueToMultipleCurbsSecondWheel integer , MushyDueToMultipleCurbsThirdWheel integer , MushyDueToMultipleCurbsFourthWheel integer , 
'OC nvarchar(254) , OCK nvarchar(254) , OCO nvarchar(254) , OkToSendSupportEmail integer , OneStepSetupComplete integer , PlayImportSounds integer , ProgramSetupComplete integer , RaceWeekendLoaded integer , RaceWeekendName nvarchar(254) , RC nvarchar(254) , RCK nvarchar(254) ,  RCO nvarchar(254) , 
'SetupCopyFromFolder nvarchar(254) , SetupCopyToFolder nvarchar(254) , SetupExportCopyFromPathChosen integer , SetupExportCopyToFolderOldLocation nvarchar(254) , SetupExportCopyToPathChosen integer , 
'SkipTelemetryDiagnosticInput integer , SkipUserDiagnosticInput integer , TabItemHandlingCondition integer , TelemetryCopyFromFolder nvarchar(254) , TelemetryCopyToFolder nvarchar(254) , 
'TelemetryExportCopyFromPathChosen integer , TelemetryExportCopyToPathChosen integer , VersionNumberText nvarchar(254) , WhenInTrayNormalOperations integer , WindowBounds nvarchar(54) , WindowMaximized integer );"
