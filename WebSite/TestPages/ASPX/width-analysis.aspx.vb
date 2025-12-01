Imports System
Imports System.Web.UI

Partial Class WidthAnalysis
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Console Logging for Width Analysis
        System.Diagnostics.Debug.WriteLine("🔧 [WidthAnalysis] Page_Load started - بدء تحليل العرض")
        
        If Not IsPostBack Then
            ' Log page properties
            System.Diagnostics.Debug.WriteLine("📋 [WidthAnalysis] Page properties:")
            System.Diagnostics.Debug.WriteLine("  - IsPostBack: False")
            System.Diagnostics.Debug.WriteLine("  - Request URL: " & Request.Url.ToString())
            System.Diagnostics.Debug.WriteLine("  - User Agent: " & Request.UserAgent)
            
            ' Check for PageContent in the page hierarchy
            Dim pageContent As Control = Master.FindControl("PageContent")
            If pageContent IsNot Nothing Then
                System.Diagnostics.Debug.WriteLine("✅ [WidthAnalysis] PageContent control found in Master page")
            Else
                System.Diagnostics.Debug.WriteLine("⚠️ [WidthAnalysis] PageContent control not found in Master page")
            End If
            
            ' Check for PageContentPlaceHolder
            Dim placeholder As ContentPlaceHolder = CType(Master.FindControl("PageContentPlaceHolder"), ContentPlaceHolder)
            If placeholder IsNot Nothing Then
                System.Diagnostics.Debug.WriteLine("✅ [WidthAnalysis] PageContentPlaceHolder found")
                System.Diagnostics.Debug.WriteLine("  - Placeholder ID: " & placeholder.ID)
            Else
                System.Diagnostics.Debug.WriteLine("⚠️ [WidthAnalysis] PageContentPlaceHolder not found")
            End If
            
            ' Register monitoring script
            RegisterWidthMonitoringScript()
        End If
        
        System.Diagnostics.Debug.WriteLine("✅ [WidthAnalysis] Page_Load completed")
    End Sub

    Private Sub RegisterWidthMonitoringScript()
        System.Diagnostics.Debug.WriteLine("📝 [WidthAnalysis] Registering width monitoring script")
        
        Dim script As String = "<script type='text/javascript'>" & vbCrLf & _
            "console.log('🔧 [WidthAnalysis] Server-side script registered');" & vbCrLf & _
            "console.log('📊 [WidthAnalysis] PageContent width monitoring active');" & vbCrLf & _
            "console.log('💡 [WidthAnalysis] CSS fixes applied:');" & vbCrLf & _
            "console.log('  - AdvancedTheme.css: Full width containers');" & vbCrLf & _
            "console.log('  - Main.master: Critical CSS with !important');" & vbCrLf & _
            "console.log('  - All Telerik controls: Width 100%');" & vbCrLf & _
            "" & vbCrLf & _
            "// Real-time monitoring" & vbCrLf & _
            "setInterval(function() {" & vbCrLf & _
            "    const pageContent = document.getElementById('PageContent');" & vbCrLf & _
            "    if (pageContent) {" & vbCrLf & _
            "        const style = window.getComputedStyle(pageContent);" & vbCrLf & _
            "        if (style.width !== '100%' && !style.width.includes('px')) {" & vbCrLf & _
            "            console.warn('⚠️ [WidthAnalysis] PageContent width not 100%:', style.width);" & vbCrLf & _
            "        }" & vbCrLf & _
            "    }" & vbCrLf & _
            "}, 5000);" & vbCrLf & _
            "</script>"
        
        ClientScript.RegisterStartupScript(Me.GetType(), "WidthMonitoring", script, False)
        System.Diagnostics.Debug.WriteLine("✅ [WidthAnalysis] Width monitoring script registered")
    End Sub
End Class
