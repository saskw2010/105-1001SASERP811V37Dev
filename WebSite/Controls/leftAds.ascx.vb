
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Net.Mail
Imports System.Net

Public Partial Class leftAds
	Inherits System.Web.UI.UserControl
    Private adsins As New Ads()
	Protected Sub Page_Load(sender As Object, e As EventArgs)

	End Sub

	Protected Sub GetAdds()
		Try
			Dim dt As New DataTable()
			dt = adsins.SelectAllAds()
			For i As Integer = 0 To dt.Rows.Count - 1
                'If dt.Rows(i)("URL").ToString() = "#" Then
                '<a href="http://www.w3schools.com">Visit W3Schools</a>
                ' Response.Write(" <tr> <td> <img src='Banners/" + dt.Rows(i)("PhotoName").ToString() + "' width='196' height='253' border='0px' /> </td> </tr> <tr> <td style='height: 10px;'> </td> </tr>")
                'Response.Write(" <tr> <td> <p>" + dt.Rows(i)("NameAr").ToString() + "</p> </td> </tr> <tr> <td style='height: 10px;'> </td> </tr>")
                'Else
                'Response.Write(" <tr> <td><a target='_blank' href='" + dt.Rows(i)("URL").ToString() + "'> <img src='Banners/" + dt.Rows(i)("PhotoName").ToString() + "' width='196' height='253' border='0px' /></a> </td> </tr> <tr> <td style='height: 10px;'> </td> </tr>")
                Response.Write("<li> <a target='_blank' href='" + dt.Rows(i)("URL").ToString() + "'>" + dt.Rows(i)("NameAr").ToString() + "</a> </li>")
                'End If
            Next
		Catch generatedExceptionName As Exception
            Response.Write(" <tr> <td> <img src='images/10001.png' width='100%' height='10px' border='0px' /> </td> </tr> <tr> <td style='height: 10px;'> </td> </tr>")
		End Try

	End Sub
    'Protected Sub btnSubscribe_Click(sender As Object, e As ImageClickEventArgs)
    '	Try

    '		If txtMobileNumber.Text <> "" Then
    '			Dim mail As New MailMessage()
    '			Dim cred As New NetworkCredential("sembameto@gmail.com", "co-operativehost")
    '			mail.[To].Add("q8touch2011@hotmail.com")
    '			mail.Subject = "اشتراك برقم موبايل"
    '			mail.From = New MailAddress("noreply@q8touch.net", "noreply@q8touch.net")
    '			mail.IsBodyHtml = True
    '			mail.Body = "<table align='left' cellpadding='20'  width='700' dir='ltr'>  <tr>  <td> السلام عليكم , تم ارسال رقم موبايل عميل لكم من خلال الموقع والرقم هو : </td>    </tr>  <tr>  <td> <br> " + txtMobileNumber.Text + "</td>   </tr> </table>"
    '			Dim smtp As New SmtpClient("smtp.gmail.com")
    '			smtp.UseDefaultCredentials = False
    '			smtp.EnableSsl = True
    '			smtp.Credentials = cred
    '			smtp.Port = 587
    '			smtp.Send(mail)

    '				'     ScriptManager.RegisterStartupScript(Page, Page.GetType(), "h", "alert('تم إرسال رقم الموبايل بنجاح , سوف يتم الإتصال بك في أقرب وقت ممكن , شكرا لتسجيلك معنا');", true);

    '			txtUser_TextBoxWatermarkExtender.WatermarkText = "تم إرسال الرقم بنجاح , شكراً"
    '		Else

    '			ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "h", "alert('من فضلك أدخل رقم الموبايل أولاً');", True)


    '		End If
    '	Catch


    '		ScriptManager.RegisterStartupScript(Page, Page.[GetType](), "h", "alert('لم تتم عملية التسحيل بنجاح , حاول مرة أخري');", True)
    '	End Try
    '	txtMobileNumber.Text = ""

    'End Sub
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
