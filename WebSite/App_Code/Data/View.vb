Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Caching
Imports System.Web.Configuration
Imports System.Web.Security
Imports System.Xml
Imports System.Xml.XPath

Namespace eZee.Data
    
    Public Class View
        
        Private m_Id As String
        
        Private m_Label As String
        
        Private m_HeaderText As String
        
        Private m_Type As String
        
        Private m_Group As String
        
        Private m_ShowInSelector As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        

        
        Public Property Id() As String
            Get
                Return m_Id
            End Get
            Set
                m_Id = value
            End Set
        End Property
        
        Public ReadOnly Property Label() As String
            Get
                Return m_Label
            End Get
        End Property
        
        Public ReadOnly Property HeaderText() As String
            Get
                Return m_HeaderText
            End Get
        End Property
        
        Public ReadOnly Property Type() As String
            Get
                Return m_Type
            End Get
        End Property
        
        Public ReadOnly Property Group() As String
            Get
                Return m_Group
            End Get
        End Property
        
        Public ReadOnly Property ShowInSelector() As Boolean
            Get
                Return m_ShowInSelector
            End Get
        End Property
    End Class
End Namespace
