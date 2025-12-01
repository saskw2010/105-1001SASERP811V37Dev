Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Web
Imports System.Data


Public Class Uploading

    Public Shared Function Uploading_File_fun(ByVal FileTOUpload As FileUpload, ByVal FileName As String, ByVal FilePath As String) As String

        Dim strString As String = ""
        Dim fileNameIndataBase As String = ""
        Dim fileStatuse As Integer

        Dim FileExt As String = Path.GetExtension(Path.GetFileName(FileTOUpload.FileName))

        Try

            If (Not FileExt Is Nothing) And (FileExt.Length > 0) Then

                Dim filetype As String
                filetype = FileExt.Remove(0, 1)
                If filetype.ToLower() = "jpg" Or filetype.ToLower() = "gif" Or filetype.ToLower() = "png" Then

                    fileNameIndataBase = FileName + Replace(Guid.NewGuid().ToString().GetHashCode().ToString(""), "-", String.Empty) + FileExt

                    fileStatuse = UploadingFile(FilePath, FileTOUpload, fileNameIndataBase)

                    If fileStatuse = 1 Then
                        strString = fileNameIndataBase
                    End If
                End If

            Else
                Return ("") '("لا يوجد ملفات للتحميل")
            End If

        Catch ex As Exception

        End Try

        Return (strString)

    End Function
    Public Shared Function UploadingFile(ByVal FilePath As String, ByVal Filename As FileUpload, ByVal NewFileNameh As String) As String

        Dim sFileDir As String = HttpContext.Current.Server.MapPath(FilePath + "/")
        Dim lMaxFileSize As Long = 4096000

        Dim File1 As HttpPostedFile

        File1 = Filename.PostedFile

        If (Not File1 Is Nothing) And (File1.ContentLength > 0) Then
            'determine file name
            Dim sFileName As String = Path.GetFileName(File1.FileName)
            Try
                If File1.ContentLength <= lMaxFileSize Then
                    'save file on disk
                    File1.SaveAs(sFileDir + NewFileNameh)
                    Return ("1") '"File: " + sFileName + " Uploaded Successfully"

                Else    'reject file
                    Return ("2") '"File Size if Over the Limit of " + lMaxFileSize
                End If
            Catch exc As Exception    'in case of an error
                Return ("3") '"An Error Occured. Please Try Again!"
                DeleteFile(sFileDir + sFileName) 'Cancel uploading"
            End Try
        Else
            Return ("4") '"Nothing to upload. Please Try Again!"
        End If
    End Function

    Public Shared Function DeleteFile(ByVal strFileName As String) As String

        'Dim Mess As String = ""
        If strFileName.Trim().Length > 0 Then
            Dim fi As New FileInfo(strFileName)
            If (fi.Exists) Then    'if file exists, delete it
                fi.Delete()
                'Mess = "Cancel uploading"
            End If

        End If
        Return ("")
    End Function

End Class
