Imports eZee.Data
Imports eZee.Security
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Routing

Namespace eZee.Services
    
    Partial Public Class EnterpriseApplicationServices
        Inherits EnterpriseApplicationServicesBase
    End Class
    
    Public Class EnterpriseApplicationServicesBase
        Inherits ApplicationServicesBase
        
        Public Shared AppServicesRegex As Regex = New Regex("/appservices/(?'Controller'.+?)(/|$)", RegexOptions.IgnoreCase)
        
        Public Shared DynamicResourceRegex As Regex = New Regex("(\.js$|^_(invoke|authenticate)$)", RegexOptions.IgnoreCase)
        
        Public Shared DynamicWebResourceRegex As Regex = New Regex("\.(js|css)$", RegexOptions.IgnoreCase)
        
        Public Overrides Sub RegisterServices()
            RegisterREST()
            MyBase.RegisterServices()
        End Sub
        
        Public Overridable Sub RegisterREST()
            Dim routes As RouteCollection = RouteTable.Routes
            routes.RouteExistingFiles = true
            GenericRoute.Map(routes, New RepresentationalStateTransfer(), "appservices/{Controller}/{Segment1}/{Segment2}/{Segment3}/{Segment4}")
            GenericRoute.Map(routes, New RepresentationalStateTransfer(), "appservices/{Controller}/{Segment1}/{Segment2}/{Segment3}")
            GenericRoute.Map(routes, New RepresentationalStateTransfer(), "appservices/{Controller}/{Segment1}/{Segment2}")
            GenericRoute.Map(routes, New RepresentationalStateTransfer(), "appservices/{Controller}/{Segment1}")
            GenericRoute.Map(routes, New RepresentationalStateTransfer(), "appservices/{Controller}")
        End Sub
        
        Public Overrides Function RequiresAuthentication(ByVal request As HttpRequest) As Boolean
            Dim result As Boolean = MyBase.RequiresAuthentication(request)
            If result Then
                Return true
            End If
            Dim m As Match = AppServicesRegex.Match(request.Path)
            If m.Success Then
                Dim config As ControllerConfiguration = Nothing
                Try 
                    Dim controllerName As String = m.Groups("Controller").Value
                    If Not (DynamicResourceRegex.IsMatch(controllerName)) Then
                        config = DataControllerBase.CreateConfigurationInstance([GetType](), controllerName)
                    End If
                    If (controllerName = "_authenticate") Then
                        Return false
                    End If
                Catch __exception As Exception
                End Try
                If (config Is Nothing) Then
                    Return Not (DynamicWebResourceRegex.IsMatch(request.Path))
                End If
                Return RequiresRESTAuthentication(request, config)
            End If
            Return false
        End Function
        
        Public Overridable Function RequiresRESTAuthentication(ByVal request As HttpRequest, ByVal config As ControllerConfiguration) As Boolean
            Return UriRestConfig.RequiresAuthentication(request, config)
        End Function
    End Class
    
   
End Namespace
