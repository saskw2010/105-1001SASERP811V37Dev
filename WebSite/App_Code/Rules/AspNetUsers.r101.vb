Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security
Imports eZee.Security
Imports System.Security.Cryptography

Namespace eZee.Rules
    
    Partial Public Class AspNetUsersBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Insert".
        ''' </summary>
        <Rule("r101")>  _
        Public Sub r101Implementation( _
                    ByVal id As String,  _
                    ByVal userName As String,  _
                    ByVal firstName As String,  _
                    ByVal lastName As String,  _
                    ByVal bio As String,  _
                    ByVal avatarUrl As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal isDeleted As Nullable(Of Boolean),  _
                    ByVal deletedOn As Nullable(Of DateTime),  _
                    ByVal email As String,  _
                    ByVal emailConfirmed As Nullable(Of Boolean),  _
                    ByVal passwordHash As String,  _
                    ByVal securityStamp As String,  _
                    ByVal discriminator As String,  _
                    ByVal applicationId As String,  _
                    ByVal legacyPasswordHash As String,  _
                    ByVal isAnonymous As Nullable(Of Boolean),  _
                    ByVal lastActivityDate As Nullable(Of DateTime),  _
                    ByVal passwordQuestion As String,  _
                    ByVal passwordAnswer As String,  _
                    ByVal isApproved As Nullable(Of Boolean),  _
                    ByVal isLockedOut As Nullable(Of Boolean),  _
                    ByVal createDate As Nullable(Of DateTime),  _
                    ByVal lastLoginDate As Nullable(Of DateTime),  _
                    ByVal lastPasswordChangedDate As Nullable(Of DateTime),  _
                    ByVal lastLockoutDate As Nullable(Of DateTime),  _
                    ByVal failedPasswordAttemptCount As Nullable(Of Integer),  _
                    ByVal failedPasswordAttemptWindowStart As Nullable(Of DateTime),  _
                    ByVal failedPasswordAnswerAttemptCount As Nullable(Of Integer),  _
                    ByVal failedPasswordAnswerAttemptWindowStart As Nullable(Of DateTime),  _
                    ByVal comment As String,  _
                    ByVal profile_DateOfBirth As Nullable(Of DateTime),  _
                    ByVal profile_City As String,  _
                    ByVal profile_UserStats_Height As Nullable(Of Integer),  _
                    ByVal profile_UserStats_Weight As Nullable(Of Integer),  _
                    ByVal phoneNumber As String,  _
                    ByVal phoneNumberConfirmed As Nullable(Of Boolean),  _
                    ByVal twoFactorEnabled As Nullable(Of Boolean),  _
                    ByVal lockoutEndDateUtc As Nullable(Of DateTime),  _
                    ByVal lockoutEnabled As Nullable(Of Boolean),  _
                    ByVal accessFailedCount As Nullable(Of Integer),  _
                    ByVal userurl As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal createdBy As String,  _
                    ByVal pictureFileName As String,  _
                    ByVal pictureContentType As String,  _
                    ByVal pictureLength As Nullable(Of Integer),  _
                    ByVal lastLockedOutDate As Nullable(Of DateTime),  _
                    ByVal creationDate As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
			  UpdateFieldValue("PasswordHash", EncodePasswordmosso(profile_City))
        End Sub
		 Public Overridable Function EncodePasswordmosso(ByVal password As String) As String
            Dim encodedPassword As String = password
            'Dim pwdFormat As String = Config("passwordFormat")
            'If (pwdFormat = System.Web.Security.MembershipPasswordFormat.Encrypted) Then
            '    encodedPassword = Convert.ToBase64String(EncryptPassword(Encoding.Unicode.GetBytes(password)))
            'Else
            'If (passwordformat = System.Web.Security.MembershipPasswordFormat.Hashed) Then
            Dim hash As HMACSHA1 = New HMACSHA1()
            Dim m_ValidationKey As String = ConfigurationManager.AppSettings("MembershipProviderValidationKey")
            If (String.IsNullOrEmpty(m_ValidationKey) OrElse m_ValidationKey.Contains("AutoGenerate")) Then
                m_ValidationKey = "FE876E90EF985641A24F77B05190FADD2EE660336C233E4707D8F08457318D6333FFF117A764D57A8" &
                    "29E9549DCEA9883FBCD4979841CD53BC810C7538507A191"
            End If
            hash.Key = HexToByte(m_ValidationKey)
            encodedPassword = Convert.ToBase64String(hash.ComputeHash(Encoding.Unicode.GetBytes(password)))
            '    End If
            'End If
            Return encodedPassword
        End Function
        Public Shared Function HexToByte(ByVal hexString As String) As Byte()
            Dim returnBytes(((hexString.Length / 2)) - 1) As Byte
            Dim i As Integer = 0
            Do While (i < returnBytes.Length)
                returnBytes(i) = Convert.ToByte(hexString.Substring((i * 2), 2), 16)
                i = (i + 1)
            Loop
            Return returnBytes
        End Function
    End Class
End Namespace
