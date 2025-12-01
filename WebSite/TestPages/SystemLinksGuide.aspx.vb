Imports System

Partial Class SystemLinksGuide
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                ' Set page metadata
                Dim master As UniversalNavMaster = TryCast(Me.Master, UniversalNavMaster)
                If master IsNot Nothing Then
                    master.SetMetaDescription("دليل شامل لجميع روابط صفحات SASERP V37 مع أمثلة Vue.js والنظام الهرمي mainmaster.pages")
                    master.SetMetaKeywords("links, pages, vue.js, mainmaster, navigation, saserp, routes, روابط, صفحات")
                End If

                ' Log page access
                LogPageAccess()
                
                ' Register page-specific resources
                RegisterPageResources()
            End If
        Catch ex As Exception
            ' Log error but don't break the page
            System.Diagnostics.Debug.WriteLine("Error in SystemLinksGuide Page_Load: " & ex.Message)
        End Try
    End Sub

    Private Sub LogPageAccess()
        Try
            ' Log access to this guide page
            Dim logEntry As String = String.Format("User: {0}, Page: SystemLinksGuide, Time: {1}, IP: {2}", 
                                                  If(User.Identity.IsAuthenticated, User.Identity.Name, "Anonymous"),
                                                  DateTime.Now.ToString(),
                                                  Request.UserHostAddress)
            
            System.Diagnostics.Debug.WriteLine("Links Guide Access: " & logEntry)
            
            ' You could also log to database or file here for analytics
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error logging page access: " & ex.Message)
        End Try
    End Sub

    Private Sub RegisterPageResources()
        Try
            ' Register additional CSS for better presentation
            Dim customCSS As String = _
                "/* Additional styles for links guide */" & vbCrLf & _
                ".links-section:hover {" & vbCrLf & _
                "    transform: translateY(-2px);" & vbCrLf & _
                "    box-shadow: 0 6px 12px rgba(0,0,0,0.15);" & vbCrLf & _
                "}" & vbCrLf & _
                "" & vbCrLf & _
                ".link-button {" & vbCrLf & _
                "    min-width: 140px;" & vbCrLf & _
                "    text-align: center;" & vbCrLf & _
                "}" & vbCrLf & _
                "" & vbCrLf & _
                "@media (max-width: 768px) {" & vbCrLf & _
                "    .link-button {" & vbCrLf & _
                "        display: block;" & vbCrLf & _
                "        width: 100%;" & vbCrLf & _
                "        margin: 5px 0;" & vbCrLf & _
                "    }" & vbCrLf & _
                "}"
            
            Page.ClientScript.RegisterClientScriptBlock(Me.GetType(), "LinksGuideCSS", 
                "<style>" & customCSS & "</style>")

            ' Register JavaScript for enhanced functionality
            Dim enhancedJS As String = _
                "// Enhanced functionality for links guide" & vbCrLf & _
                "document.addEventListener('DOMContentLoaded', function() {" & vbCrLf & _
                "    // Add tooltips to buttons" & vbCrLf & _
                "    const buttons = document.querySelectorAll('.link-button');" & vbCrLf & _
                "    buttons.forEach(button => {" & vbCrLf & _
                "        button.title = 'النقر للذهاب إلى: ' + button.textContent;" & vbCrLf & _
                "    });" & vbCrLf & _
                "    " & vbCrLf & _
                "    // Add keyboard navigation" & vbCrLf & _
                "    document.addEventListener('keydown', function(e) {" & vbCrLf & _
                "        if (e.altKey && e.key >= '1' && e.key <= '9') {" & vbCrLf & _
                "            const sectionIndex = parseInt(e.key) - 1;" & vbCrLf & _
                "            const sections = document.querySelectorAll('.links-section');" & vbCrLf & _
                "            if (sections[sectionIndex]) {" & vbCrLf & _
                "                sections[sectionIndex].scrollIntoView({ behavior: 'smooth' });" & vbCrLf & _
                "            }" & vbCrLf & _
                "        }" & vbCrLf & _
                "    });" & vbCrLf & _
                "    " & vbCrLf & _
                "    console.log('✅ Links Guide Enhanced Functionality Loaded');" & vbCrLf & _
                "});"
            
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "LinksGuideJS", enhancedJS, True)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error registering page resources: " & ex.Message)
        End Try
    End Sub

    Protected Sub Page_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        Try
            ' Add final optimizations before rendering
            OptimizePageForSEO()
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in Page_PreRender: " & ex.Message)
        End Try
    End Sub

    Private Sub OptimizePageForSEO()
        Try
            ' Add structured data for better SEO
            Dim structuredData As String = _
                "{" & vbCrLf & _
                "    ""@context"": ""https://schema.org""," & vbCrLf & _
                "    ""@type"": ""WebPage""," & vbCrLf & _
                "    ""name"": ""دليل روابط النظام""," & vbCrLf & _
                "    ""description"": ""دليل شامل لجميع روابط صفحات SASERP V37""," & vbCrLf & _
                "    ""inLanguage"": ""ar""," & vbCrLf & _
                "    ""isPartOf"": {" & vbCrLf & _
                "        ""@type"": ""WebSite""," & vbCrLf & _
                "        ""name"": ""SASERP V37""" & vbCrLf & _
                "    }" & vbCrLf & _
                "}"
            
            Dim structuredDataScript As String = String.Format("<script type=""application/ld+json"">{0}</script>", structuredData)
            Page.Header.Controls.Add(New LiteralControl(structuredDataScript))

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error optimizing for SEO: " & ex.Message)
        End Try
    End Sub

End Class
