Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Routing
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls

Namespace eZee.Services
    
    Partial Public Class ApplicationServices
        Inherits EnterpriseApplicationServices
        
        Public Shared Sub Initialize()
            Dim services As ApplicationServices = New ApplicationServices()
            services.RegisterServices()
        End Sub
        
        Public Shared Function Login(ByVal username As String, ByVal password As String, ByVal createPersistentCookie As Boolean) As Boolean
            Dim services As ApplicationServices = New ApplicationServices()
            Return services.UserLogin(username, password, createPersistentCookie)
        End Function
        
        Public Shared Sub Logout()
            Dim services As ApplicationServices = New ApplicationServices()
            services.UserLogout()
        End Sub
        
        Public Shared Function Roles() As String()
            Dim services As ApplicationServices = New ApplicationServices()
            Return services.UserRoles()
        End Function
    End Class
    
    Public Class ApplicationServicesBase
        
        Public Shared EnableMobileClient As Boolean = true
        
        Private Shared m_EnableMinifiedCss As Boolean
        
        Public Shared MobileAgentBRegex As Regex = New Regex("(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fenn"& _ 
                "ec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|netfront|opera m("& _ 
                "ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|tre"& _ 
                "o|up\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino|android|ipad|play"& _ 
                "book|silk", (RegexOptions.IgnoreCase Or RegexOptions.Multiline))
        
        Public Shared MobileAgentVRegex As Regex = New Regex("1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al("& _ 
                "av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|"& _ 
                "be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|c"& _ 
                "ell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p"& _ 
                ")o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-"& _ 
                "|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|"& _ 
                "hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i23"& _ 
                "0|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|k"& _ 
                "ddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a"& _ 
                "-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|"& _ 
                "oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n2"& _ 
                "0[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzp"& _ 
                "h|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl("& _ 
                "ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|q"& _ 
                "tek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|"& _ 
                "sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3"& _ 
                "|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|t"& _ 
                "cl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|u"& _ 
                "tst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|"& _ 
                "80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|"& _ 
                "zte\-", (RegexOptions.IgnoreCase Or RegexOptions.Multiline))
        
        Private Shared m_CssUrlRegex As Regex = New Regex("(?'Header'\burl\s*\(\s*(\&quot;|\')?)(?'Name'\w+)(?'Symbol'\S)")
        
        Public Shared Property EnableMinifiedCss() As Boolean
            Get
                Return m_EnableMinifiedCss
            End Get
            Set
                m_EnableMinifiedCss = value
            End Set
        End Property
        
        Public Overridable ReadOnly Property Realm() As String
            Get
                Return "eZee Application Services"
            End Get
        End Property
        
        Public Shared ReadOnly Property IsMobileClient() As Boolean
            Get
                Dim isMobile As Object = HttpContext.Current.Items("ApplicationServices_IsMobileClient")
                If (isMobile Is Nothing) Then
                    isMobile = ClientIsMobile()
                    HttpContext.Current.Items("ApplicationServices_IsMobileClient") = isMobile
                End If
                Return CType(isMobile,Boolean)
            End Get
        End Property
        
        Public Overridable Function GetNavigateUrl() As String
            Return Nothing
        End Function
        
        Public Shared Sub VerifyUrl()
            Dim services As ApplicationServices = New ApplicationServices()
            Dim navigateUrl As String = services.GetNavigateUrl()
            If Not (String.IsNullOrEmpty(navigateUrl)) Then
                Dim current As HttpContext = HttpContext.Current
                If Not (VirtualPathUtility.ToAbsolute(navigateUrl).Equals(current.Request.RawUrl, StringComparison.CurrentCultureIgnoreCase)) Then
                    current.Response.Redirect(navigateUrl)
                End If
            End If
        End Sub
        
        Public Overridable Sub RegisterServices()
            CreateStandardMembershipAccounts()
            GenericRoute.Map(RouteTable.Routes, New PlaceholderHandler(), "placeholder/{FileName}")
        End Sub
        
        Public Overridable Sub CreateStandardMembershipAccounts()
            'Create a separate code file with a definition of the partial class ApplicationServices overriding
            'this method to prevent automatic registration of 'admin' and 'user'. Do not change this file directly.
            RegisterStandardMembershipAccounts()
        End Sub
        
        Public Overridable Function RequiresAuthentication(ByVal request As HttpRequest) As Boolean
            Return request.Path.EndsWith("Export.ashx", StringComparison.CurrentCultureIgnoreCase)
        End Function
        
        Public Overridable Function AuthenticateRequest(ByVal context As HttpContext) As Boolean
            Return false
        End Function
        
        Public Overridable Function UserLogin(ByVal username As String, ByVal password As String, ByVal createPersistentCookie As Boolean) As Boolean
            'If Membership.ValidateUser(username, password) Then
            FormsAuthentication.SetAuthCookie(username, createPersistentCookie)
            Return True
            'Else
            '    Return false
            'End If
        End Function
        
        Public Overridable Sub UserLogout()
            FormsAuthentication.SignOut()
        End Sub
        
        Public Overridable Function UserRoles() As String()
            Return Roles.GetRolesForUser()
        End Function
        
        Public Shared Sub RegisterStandardMembershipAccounts()
            Dim admin As MembershipUser = Membership.GetUser("admin")
            If ((Not (admin) Is Nothing) AndAlso admin.IsLockedOut) Then
                admin.UnlockUser()
            End If
            Dim user As MembershipUser = Membership.GetUser("user")
            If ((Not (user) Is Nothing) AndAlso user.IsLockedOut) Then
                user.UnlockUser()
            End If
            If (Membership.GetUser("admin") Is Nothing) Then
                Dim status As MembershipCreateStatus
                admin = Membership.CreateUser("admin", "admin123%", "admin@eZee.com", "ASP.NET", "Code OnTime", true, status)
                user = Membership.CreateUser("user", "user123%", "user@eZee.com", "ASP.NET", "Code OnTime", true, status)
                Roles.CreateRole("Administrators")
                Roles.CreateRole("Users")
                Roles.AddUserToRole(admin.UserName, "Users")
                Roles.AddUserToRole(user.UserName, "Users")
                Roles.AddUserToRole(admin.UserName, "Administrators")
            End If
        End Sub
        
        Public Shared Function ClientIsMobile() As Boolean
            If Not (EnableMobileClient) Then
                Return false
            End If
            Dim request As HttpRequest = HttpContext.Current.Request
            Dim mobileCookie As HttpCookie = request.Cookies("appfactorytouchui")
            If (Not (mobileCookie) Is Nothing) Then
                Return (mobileCookie.Value = "true")
            End If
            Dim u As String = request.ServerVariables("HTTP_USER_AGENT")
            If String.IsNullOrEmpty(u) Then
                Return false
            End If
            Return (MobileAgentBRegex.IsMatch(u) OrElse MobileAgentVRegex.IsMatch(u.Substring(0, 4)))
        End Function
        
        Public Shared Sub RegisterCssLinks(ByVal p As Page)
            For Each c As Control in p.Header.Controls
                If TypeOf c Is HtmlLink Then
                    Dim l As HtmlLink = CType(c,HtmlLink)
                    If (l.ID = "eZeeTheme") Then
                        Return
                    End If
                    If l.Href.Contains("_Theme_Citrus.css") Then
                        l.ID = "eZeeTheme"
                        If ApplicationServices.IsMobileClient Then
                            Dim jqmCss As String = String.Format("jquery.mobile-{0}.min.css", ApplicationServices.JqmVersion)
                            l.Href = ("~/touch/" + jqmCss)
                            Dim meta As HtmlMeta = New HtmlMeta()
                            meta.Attributes("name") = "viewport"
                            meta.Attributes("content") = "width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"
                            p.Header.Controls.AddAt(0, meta)
                            Dim allowCompression As Boolean = true
                            If (ApplicationServices.EnableMinifiedCss AndAlso allowCompression) Then
                                l.Href = String.Format("~/appservices/stylesheet-{0}.min.css", ApplicationServices.Version)
                            Else
                                For Each stylesheet As String in ApplicationServices.TouchUIStylesheets()
                                    If Not (stylesheet.StartsWith("jquery.mobile")) Then
                                        Dim cssLink As HtmlLink = New HtmlLink()
                                        cssLink.Href = String.Format("~/touch/{0}?{1}", stylesheet, ApplicationServices.Version)
                                        cssLink.Attributes("type") = "text/css"
                                        cssLink.Attributes("rel") = "stylesheet"
                                        p.Header.Controls.Add(cssLink)
                                    End If
                                Next
                            End If
                            Dim removeList As List(Of Control) = New List(Of Control)()
                            For Each c2 As Control in p.Header.Controls
                                If TypeOf c2 Is HtmlLink Then
                                    l = CType(c2,HtmlLink)
                                    If l.Href.Contains("App_Themes/") Then
                                        removeList.Add(l)
                                    End If
                                End If
                            Next
                            For Each c2 As Control in removeList
                                p.Header.Controls.Remove(c2)
                            Next
                            Return
                        Else
                            If Not (l.Href.Contains("?")) Then
                                l.Href = (l.Href + String.Format("?{0}", ApplicationServices.Version))
                            End If
                        End If
                        Return
                    End If
                End If
            Next
        End Sub
        
        Protected Overridable Function AllowTouchUIStylesheet(ByVal name As String) As Boolean
            Return true
        End Function
        
        Public Shared Function TouchUIStylesheets() As List(Of String)
            Dim services As ApplicationServices = New ApplicationServices()
            Return services.EnumerateTouchUIStylesheets()
        End Function
        
        Public Overridable Function EnumerateTouchUIStylesheets() As List(Of String)
            Dim stylesheets As List(Of String) = New List(Of String)()
            stylesheets.Add(String.Format("jquery.mobile-{0}.min.css", ApplicationServices.JqmVersion))
            'enumerate custom css files
            Dim mobilePath As String = Path.GetDirectoryName(HttpContext.Current.Server.MapPath("~/touch/"))
            Dim cssFiles As SortedDictionary(Of String, String) = New SortedDictionary(Of String, String)()
            Dim minifiedCssFiles As List(Of String) = New List(Of String)()
            For Each css As String in Directory.GetFiles(mobilePath, "*.css")
                If Not (css.Contains("jquery.mobile")) Then
                    cssFiles(css) = css
                    If css.EndsWith(".min.css") Then
                        If EnableMinifiedCss Then
                            minifiedCssFiles.Add((css.Substring(0, (css.Length - 7)) + "css"))
                        Else
                            cssFiles.Remove(css)
                        End If
                    End If
                End If
            Next
            For Each css As String in minifiedCssFiles
                cssFiles.Remove(css)
            Next
            For Each fileName As String in cssFiles.Keys
                Dim cssFile As String = Path.GetFileName(fileName)
                If AllowTouchUIStylesheet(fileName) Then
                    stylesheets.Add(cssFile)
                End If
            Next
            Return stylesheets
        End Function
        
        Private Shared Function DoReplaceCssUrl(ByVal m As Match) As String
            Dim header As String = m.Groups("Header").Value
            Dim name As String = m.Groups("Name").Value
            Dim symbol As String = m.Groups("Symbol").Value
            If ((name = "data") AndAlso (symbol = ":")) Then
                Return m.Value
            End If
            Return (header  _
                        + ("../touch/"  _
                        + (name + symbol)))
        End Function
        
        Public Shared Function CombineTouchUIStylesheets(ByVal context As HttpContext) As String
            Dim response As HttpResponse = context.Response
            Dim cache As HttpCachePolicy = response.Cache
            cache.SetCacheability(HttpCacheability.Public)
            cache.VaryByHeaders("User-Agent") = true
            cache.SetOmitVaryStar(true)
            cache.SetExpires(DateTime.Now.AddDays(365))
            cache.SetValidUntilExpires(true)
            cache.SetLastModifiedFromFileDependencies()
            'combine scripts
            Dim sb As StringBuilder = New StringBuilder()
            For Each stylesheet As String in ApplicationServices.TouchUIStylesheets()
                Dim data As String = File.ReadAllText(HttpContext.Current.Server.MapPath(("~/touch/" + stylesheet)))
                data = m_CssUrlRegex.Replace(data, AddressOf DoReplaceCssUrl)
                sb.AppendLine(data)
            Next
            Return sb.ToString()
        End Function
    End Class
    
    Partial Public Class ApplicationSiteMapProvider
        Inherits ApplicationSiteMapProviderBase
    End Class
    
    Public Class ApplicationSiteMapProviderBase
        Inherits System.Web.XmlSiteMapProvider
        
        Public Overrides Function IsAccessibleToUser(ByVal context As HttpContext, ByVal node As SiteMapNode) As Boolean
            Dim device As String = node("Device")
            If (((device = "Mobile") OrElse (device = "Touch UI")) AndAlso Not (ApplicationServices.IsMobileClient)) Then
                Return false
            End If
            If ((device = "Desktop") AndAlso ApplicationServices.IsMobileClient) Then
                Return false
            End If
            Return MyBase.IsAccessibleToUser(context, node)
        End Function
    End Class
    
    Partial Public Class PlaceholderHandler
        Inherits PlaceholderHandlerBase
    End Class
    
    Public Class PlaceholderHandlerBase
        Inherits Object
        Implements IHttpHandler
        
        Private Shared m_ImageSizeRegex As Regex = New Regex("((?'background'[a-zA-Z0-9]+?)-((?'textcolor'[a-zA-Z0-9]+?)-)?)?(?'width'[0-9]+?)("& _ 
                "x(?'height'[0-9]*))?\.[a-zA-Z][a-zA-Z][a-zA-Z]")
        
        Overridable ReadOnly Property IHttpHandler_IsReusable() As Boolean Implements IHttpHandler.IsReusable
            Get
                Return true
            End Get
        End Property
        
        Overridable Sub IHttpHandler_ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
            'Get file name
            Dim routeValues As RouteValueDictionary = context.Request.RequestContext.RouteData.Values
            Dim fileName As String = CType(routeValues("FileName"),String)
            'Get extension
            Dim ext As String = Path.GetExtension(fileName)
            Dim format As ImageFormat = ImageFormat.Png
            Dim contentType As String = "image/png"
            If (ext = ".jpg") Then
                format = ImageFormat.Jpeg
                contentType = "image/jpg"
            Else
                If (ext = ".gif") Then
                    format = ImageFormat.Gif
                    contentType = "image/jpg"
                End If
            End If
            'get width and height
            Dim regexMatch As Match = m_ImageSizeRegex.Matches(fileName)(0)
            Dim widthCapture As Capture = regexMatch.Groups("width")
            Dim width As Integer = 500
            If Not ((widthCapture.Length = 0)) Then
                width = Convert.ToInt32(widthCapture.Value)
            End If
            If (width = 0) Then
                width = 500
            End If
            If (width > 4096) Then
                width = 4096
            End If
            Dim heightCapture As Capture = regexMatch.Groups("height")
            Dim height As Integer = width
            If Not ((heightCapture.Length = 0)) Then
                height = Convert.ToInt32(heightCapture.Value)
            End If
            If (height = 0) Then
                height = 500
            End If
            If (height > 4096) Then
                height = 4096
            End If
            'Get background and text colors
            Dim background As Color = GetColor(regexMatch.Groups("background"), Color.LightGray)
            Dim textColor As Color = GetColor(regexMatch.Groups("textcolor"), Color.Black)
            Dim fontSize As Integer = ((width + height)  _
                        / 50)
            If (fontSize < 10) Then
                fontSize = 10
            End If
            Dim font As Font = New Font(FontFamily.GenericSansSerif, fontSize)
            'Get text
            Dim text As String = context.Request.QueryString("text")
            If String.IsNullOrEmpty(text) Then
                text = String.Format("{0} x {1}", width, height)
            End If
            'Get position for text
            Dim textSize As SizeF
            Using img As Image = New Bitmap(1, 1)
                Dim textDrawing As Graphics = Graphics.FromImage(img)
                textSize = textDrawing.MeasureString(text, font)
            End Using
            'Draw the image
            Using image As Image = New Bitmap(width, height)
                Dim drawing As Graphics = Graphics.FromImage(image)
                drawing.Clear(background)
                Using textBrush As Brush = New SolidBrush(textColor)
                    drawing.DrawString(text, font, textBrush, ((width - textSize.Width)  _
                                    / 2), ((height - textSize.Height)  _
                                    / 2))
                End Using
                drawing.Save()
                drawing.Dispose()
                'Return image
                Using stream As MemoryStream = New MemoryStream()
                    image.Save(stream, format)
                    Dim cache As HttpCachePolicy = context.Response.Cache
                    cache.SetCacheability(HttpCacheability.Public)
                    cache.SetOmitVaryStar(true)
                    cache.SetExpires(DateTime.Now.AddDays(365))
                    cache.SetValidUntilExpires(true)
                    cache.SetLastModifiedFromFileDependencies()
                    context.Response.ContentType = contentType
                    context.Response.AddHeader("Content-Length", Convert.ToString(stream.Length))
                    context.Response.AddHeader("File-Name", fileName)
                    context.Response.BinaryWrite(stream.ToArray())
                    context.Response.OutputStream.Flush()
                End Using
            End Using
        End Sub
        
        Private Shared Function GetColor(ByVal colorName As Capture, ByVal defaultColor As Color) As Color
            Try 
                If (colorName.Length > 0) Then
                    Dim s As String = colorName.Value
                    If Regex.IsMatch(s, "^[0-9abcdef]{3,6}$") Then
                        s = ("#" + s)
                    End If
                    Return ColorTranslator.FromHtml(s)
                End If
            Catch __exception As Exception
            End Try
            Return defaultColor
        End Function
    End Class
    
    Public Class GenericRoute
        Inherits Object
        Implements IRouteHandler
        
        Private m_Handler As IHttpHandler
        
        Public Sub New(ByVal handler As IHttpHandler)
            MyBase.New
            m_Handler = handler
        End Sub
        
        Function IRouteHandler_GetHttpHandler(ByVal context As RequestContext) As IHttpHandler Implements IRouteHandler.GetHttpHandler
            Return m_Handler
        End Function
        
        Public Shared Sub Map(ByVal routes As RouteCollection, ByVal handler As IHttpHandler, ByVal url As String)
            Dim r As Route = New Route(url, New GenericRoute(handler))
            r.Defaults = New RouteValueDictionary()
            r.Constraints = New RouteValueDictionary()
            routes.Add(r)
        End Sub
    End Class
End Namespace
