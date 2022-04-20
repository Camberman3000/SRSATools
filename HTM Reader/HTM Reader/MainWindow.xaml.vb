Class MainWindow

    Dim filename As String
    Dim IncrementDigit As Integer = 0
    Dim GeneralString As String
    Dim ArrayColonGeneralString() As String
   


    Private Sub File_Open(sender As Object, e As RoutedEventArgs)
        ProcessOpen()

    
    End Sub








    Private Sub File_Exit(sender As Object, e As RoutedEventArgs)
        System.Environment.Exit(-1)
    End Sub

   

    Private Sub CheckBoxSplitByColon_Checked(sender As Object, e As RoutedEventArgs) Handles CheckBoxSplitByColon.Checked
        Try
            CheckBoxSplitByColon.IsChecked = True
            CheckBoxSplitByPercent.IsChecked = False
            CallClear()
            If CheckBoxSplitByColon.IsChecked = True Then
                OpenAndSplitFileByColon()
            Else
                OpenAndSplitFileByPercent()
            End If
        Catch ex As Exception

        End Try
       
    End Sub
    Private Sub CheckBoxSplitByPercent_Checked(sender As Object, e As RoutedEventArgs) Handles CheckBoxSplitByPercent.Checked
        Try
            CheckBoxSplitByColon.IsChecked = False
            CheckBoxSplitByPercent.IsChecked = True
            CallClear()
            If CheckBoxSplitByColon.IsChecked = True Then
                OpenAndSplitFileByColon()
            Else
                OpenAndSplitFileByPercent()
            End If
        Catch ex As Exception

        End Try
       
    End Sub
    Private Sub ButtonClear_Click(sender As Object, e As RoutedEventArgs) Handles ButtonClear.Click
        CallClear()

    End Sub

    Private Sub CallClear()
        IncrementDigit = 0
        ArrayColonGeneralString = Nothing
        ListViewAllText.Items.Clear()
    End Sub

    Private Sub ButtonOpen_Click(sender As Object, e As RoutedEventArgs) Handles ButtonOpen.Click
        ProcessOpen()
    End Sub

    Private Sub ProcessOpen()
        Dim dlg As New Microsoft.Win32.OpenFileDialog()
        'dlg.FileName = "Document" ' Default file name 
        dlg.DefaultExt = ".htm" ' Default file extension 
        dlg.Filter = "Text documents (.txt)|*.htm" ' Filter files by extension 

        ' Show open file dialog box 
        Dim result? As Boolean = dlg.ShowDialog()

        ' Process open file dialog box results 
        If result = True Then
            ' Open document 


            CallClear()
            filename = dlg.FileName
            If CheckBoxSplitByColon.IsChecked = True Then
                OpenAndSplitFileByColon()
            Else
                OpenAndSplitFileByPercent()
            End If

        Else
            ' MessageBox.Show("cancel")
        End If
    End Sub

    Private Sub OpenAndSplitFileByColon()
        Dim ImportSetupHTMStream As New System.IO.StreamReader(filename)
        Dim ImportSetupHTMString As String = ImportSetupHTMStream.ReadToEnd()

        ImportSetupHTMStream.Close()
        ImportSetupHTMStream.Dispose()
        'FOR ALL OTHER IMPORTS FROM IRACING HTM FILE

        GeneralString = ImportSetupHTMString
        ArrayColonGeneralString = GeneralString.Split(":")

        For Each item In ArrayColonGeneralString

            ListViewAllText.Items.Add(IncrementDigit & item)
            IncrementDigit += 1
        Next



    End Sub

    Private Sub OpenAndSplitFileByPercent()
        Dim ImportSetupHTMStream As New System.IO.StreamReader(filename)
        Dim ImportSetupHTMString As String = ImportSetupHTMStream.ReadToEnd()

        ImportSetupHTMStream.Close()
        ImportSetupHTMStream.Dispose()
        'FOR ALL OTHER IMPORTS FROM IRACING HTM FILE

        GeneralString = ImportSetupHTMString
        ArrayColonGeneralString = GeneralString.Split("%")

        For Each item In ArrayColonGeneralString

            ListViewAllText.Items.Add(IncrementDigit & item)
            IncrementDigit += 1
        Next



    End Sub
End Class
