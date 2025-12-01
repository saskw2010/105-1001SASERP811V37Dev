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
    
    Public Class Category
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Id As String
        
        Private m_Index As Integer
        
        Private m_HeaderText As String
        
        Private m_Description As String
        
        Private m_NewColumn As Boolean
        
        Private m_Tab As String
        
        Private m_Template As String
        
        Private m_Floating As Boolean
        
        Private m_Collapsed As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        
         
        Public Property Id() As String
            Get
                Return Me.m_Id
            End Get
            Set
                Me.m_Id = value
            End Set
        End Property
        
        Public ReadOnly Property Index() As Integer
            Get
                Return m_Index
            End Get
        End Property
        
        Public ReadOnly Property HeaderText() As String
            Get
                Return m_HeaderText
            End Get
        End Property
        
        Public ReadOnly Property Description() As String
            Get
                Return m_Description
            End Get
        End Property
        
        Public Property NewColumn() As Boolean
            Get
                Return m_NewColumn
            End Get
            Set
                m_NewColumn = value
            End Set
        End Property
        
        Public Property Tab() As String
            Get
                Return m_Tab
            End Get
            Set
                m_Tab = value
            End Set
        End Property
        
        Public Property Template() As String
            Get
                Return m_Template
            End Get
            Set
                m_Template = value
            End Set
        End Property
        
        Public Property Floating() As Boolean
            Get
                Return m_Floating
            End Get
            Set
                m_Floating = value
            End Set
        End Property
        
        Public Property Collapsed() As Boolean
            Get
                Return m_Collapsed
            End Get
            Set
                m_Collapsed = value
            End Set
        End Property
    End Class
End Namespace
