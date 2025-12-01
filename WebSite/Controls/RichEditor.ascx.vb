Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls


<Global.eZee.Web.AquariumFieldEditor()> _
Partial Public Class Controls_RichEditor
    Inherits Global.System.Web.UI.UserControl
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            Page.ClientScript.RegisterClientScriptBlock([GetType](), "ClientScripts", ""&Global.Microsoft.VisualBasic.ChrW(10)&"                                "&Global.Microsoft.VisualBasic.ChrW(10)&"function FieldEditor_Element() {"&Global.Microsoft.VisualBasic.ChrW(10)&"  var list = d"& _ 
                    "ocument.getElementsByTagName('div');"&Global.Microsoft.VisualBasic.ChrW(10)&"  for (var i = 0; i < list.length; i++) {"&Global.Microsoft.VisualBasic.ChrW(10)&" "& _ 
                    "     var elem = list[i];"&Global.Microsoft.VisualBasic.ChrW(10)&"      if (elem.className && elem.className.match(/ajax_"& _ 
                    "_html_editor_extender_texteditor/))"&Global.Microsoft.VisualBasic.ChrW(10)&"         return elem;"&Global.Microsoft.VisualBasic.ChrW(10)&"  }"&Global.Microsoft.VisualBasic.ChrW(10)&"  return null;"&Global.Microsoft.VisualBasic.ChrW(10)&"}  "& _ 
                    "                               "&Global.Microsoft.VisualBasic.ChrW(10)&"function FieldEditor_GetValue(){return FieldEdit"& _ 
                    "or_Element().innerHTML;}"&Global.Microsoft.VisualBasic.ChrW(10)&"function FieldEditor_SetValue(value) {FieldEditor_Eleme"& _ 
                    "nt().innerHTML=value;}"&Global.Microsoft.VisualBasic.ChrW(10)&"                              ", true)
        End If
    End Sub
End Class
