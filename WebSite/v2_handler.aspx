<%@ Page Language="VB" AutoEventWireup="true" %>
<%@ Import Namespace="System.Web.Script.Serialization" %>
<%@ Import Namespace="eZee.Api" %>
<script runat="server">
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Response.ContentType = "application/json"
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        
        ' Allow CORS if needed (for development)
        Response.AddHeader("Access-Control-Allow-Origin", "*")
        Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, x-api-key")

        Dim controller As String = Request.QueryString("controller")
        Dim limitStr As String = Request.QueryString("limit")
        Dim pageStr As String = Request.QueryString("page")
        
        If String.IsNullOrEmpty(controller) Then
            Response.Write("{""error"": ""Missing controller parameter""}")
            Return
        End If

        Dim limit As Integer = 10
        If Not String.IsNullOrEmpty(limitStr) Then Integer.TryParse(limitStr, limit)

        Dim page As Integer = 0
        If Not String.IsNullOrEmpty(pageStr) Then Integer.TryParse(pageStr, page)

        Dim data As Object = DynamicV2Controller.GetData(controller, limit, page)
        
        Dim serializer As New JavaScriptSerializer()
        serializer.MaxJsonLength = Integer.MaxValue
        
        Dim json As String = serializer.Serialize(data)
        Response.Write(json)
    End Sub
</script>
