
Imports System.IO

Partial Class _Defaultlogin
    Inherits System.Web.UI.Page

    Private Sub _Default_Init(sender As Object, e As EventArgs) Handles Me.Init
        Dim starturlstring As String = ""
        If IsNothing(ConfigurationManager.AppSettings("startapppage").ToString()) Then
            starturlstring = "website/pages/home"
        Else
            starturlstring = ConfigurationManager.AppSettings("startapppage").ToString()
        End If


        'Response.Redirect(starturlstring)


        Dim requespath As String = ""
        If IsNothing(Request.QueryString("req")) Then

        Else
            requespath = mydomainname() + Request.QueryString("req").ToString()
            Response.Redirect(requespath)
        End If




    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Response.Write(MyMapPath("/temp") & Convert.ToString("<br />"))
        Response.Write(MyMapPath("/temp2") & Convert.ToString("<br />"))
        Response.Write(MyMapPath("/temp3") & Convert.ToString("<br />"))

        Response.Write(Convert.ToString("<br />") + " HttpContext.Current.Request.Url.Host : " + HttpContext.Current.Request.Url.Host)
        Response.Write(Convert.ToString("<br />") + " HttpContext.Current.Request.Url.Authority : " + HttpContext.Current.Request.Url.Authority)
        Response.Write(Convert.ToString("<br />") + " HttpContext.Current.Request.Url.Port : " + Convert.ToString(HttpContext.Current.Request.Url.Port))
        Response.Write(Convert.ToString("<br />") + " HttpContext.Current.Request.Url.AbsolutePath : " + HttpContext.Current.Request.Url.AbsolutePath)
        Response.Write(Convert.ToString("<br />") + " HttpContext.Current.Request.ApplicationPath : " + HttpContext.Current.Request.ApplicationPath)
        Response.Write(Convert.ToString("<br />") + " HttpContext.Current.Request.Url.AbsoluteUri : " + HttpContext.Current.Request.Url.AbsoluteUri)
        Response.Write(Convert.ToString("<br />") + " HttpContext.Current.Request.Url.PathAndQuery : " + HttpContext.Current.Request.Url.PathAndQuery)



        Response.Write(Convert.ToString("<br />") + " HttpContext.Current.Request.RawUrl : " + HttpContext.Current.Request.RawUrl)

        Response.Write(Convert.ToString("<br />") + " Request.Url.GetLeftPart(UriPartial.Authority) : " + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority))

        Response.Write(Convert.ToString("<br />") + " Request.Url.GetLeftPart(UriPartial.Path) : " + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path))


        Response.Write(Convert.ToString("<br />") + " Request.Url.GetLeftPart(UriPartial.Authority)+ HttpContext.Current.Request.ApplicationPath : " + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath)



        Response.Write(Convert.ToString("<br />") + " myvirtualpathfun : " + myvirtualpathfun())

        Response.Write(Convert.ToString("<br />") + " myvirtualpathfunwithout : " + myvirtualpathfunwithout())


        Response.Write(Convert.ToString("<br />") + " mydomainname : " + mydomainname())

        Dim spage As String = Path.GetFileName(Request.PhysicalPath)

        Response.Write(Convert.ToString("<br />") + " spage : " + spage)


        Dim spage1 As String = Path.GetFileName("~/Pages/Homecar.aspx")

        Response.Write(Convert.ToString("<br />") + " ~/Pages/Homecar.aspx : " + spage1)


        Dim urlfilanl As String = "~/Pages/Homecar.aspx"
        urlfilanl = Path.GetFileName(urlfilanl)
        urlfilanl = Left(urlfilanl, Len(urlfilanl) - 5)

        Dim filpathe As String = MyMapPath("/images/dashboard")


        Response.Write(Convert.ToString("<br />") + "filpathe : " + filpathe)

        Response.Write(Convert.ToString("<br />") + "filpathe+ \ + urlfilanl + .png : " + filpathe + "\" + urlfilanl + ".png")

        If (System.IO.File.Exists(filpathe + "\" + urlfilanl + ".png")) Then


            urlfilanl = myvirtualpathfun() + "images/dashboard/" + urlfilanl + ".png"
            Response.Write(Convert.ToString("<br />") + "urlfilanl : " + vbTrue.ToString())
            Response.Write(Convert.ToString("<br />") + "urlfilanl : " + urlfilanl)

        Else
            Response.Write(Convert.ToString("<br />") + "urlfilanl : " + vbFalse.ToString())
            Response.Write(Convert.ToString("<br />") + "myvirtualpathfun + images/dashboard/10001.png : " + myvirtualpathfun() + "images/dashboard/10001.png")


        End If

    End Sub


    Public Function MyMapPath(path As String) As String
        If HttpContext.Current.Request.ApplicationPath = "/" Then
        Else
            path = HttpContext.Current.Request.ApplicationPath + path

        End If
        Return HttpContext.Current.Server.MapPath(path)

    End Function
    Public Function myvirtualpathfun() As String
        Dim myvirtualpath As String = ""
        If HttpContext.Current.Request.ApplicationPath = "/" Then
            myvirtualpath = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath
        Else
            myvirtualpath = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath + "/"
        End If

        Return myvirtualpath
    End Function
    Public Function myvirtualpathfunwithout() As String
        Dim myvirtualpath As String = ""
        If HttpContext.Current.Request.ApplicationPath = "/" Then
            myvirtualpath = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority)
        Else
            myvirtualpath = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath
        End If

        Return myvirtualpath
    End Function
    Public Function mydomainname() As String
        Return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + "/"
    End Function

End Class
