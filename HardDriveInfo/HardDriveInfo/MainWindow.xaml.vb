Class MainWindow 
    Dim strOut As String
    Private Sub BtnDriveInfo_Click(sender As Object, e As RoutedEventArgs) Handles BtnDriveInfo.Click



        Dim ObjReturn As Management.ManagementObjectCollection
        Dim ObjSearch As Management.ManagementObjectSearcher
        Dim ObjManage As Management.ManagementObject
        ObjSearch = New Management.ManagementObjectSearcher("Select * from Win32_LogicalDisk ")
        ObjReturn = ObjSearch.Get
        For Each ObjManage In ObjReturn
            Dim VolumeName As String = ObjManage("Name")
            Dim SerialNumber As String = ObjManage("Volumeserialnumber")
            strOut = String.Format("{0} - {1}", VolumeName, SerialNumber)
            Debug.WriteLine(strOut)
            If VolumeName = "C:" Then
                ' TextboxDriveInfo.Text = strOuthellifino

                TextboxDriveInfo.Text = SerialNumber
            Else

            End If
        Next




    End Sub
End Class
