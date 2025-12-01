Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schregacdmicnew
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Regacdmicnew As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Regacdmic As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Acdcode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amounttype As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Instalmmentdutydate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amount As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Regacdmicrul As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Transdate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Approved As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FatherCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Notes1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Notes2 As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property regacdmicnew() As Nullable(Of Long)
            Get
                Return m_Regacdmicnew
            End Get
            Set
                m_Regacdmicnew = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property regacdmic() As Nullable(Of Long)
            Get
                Return m_Regacdmic
            End Get
            Set
                m_Regacdmic = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property branch() As Nullable(Of Long)
            Get
                Return m_Branch
            End Get
            Set
                m_Branch = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property acdcode() As Nullable(Of Long)
            Get
                Return m_Acdcode
            End Get
            Set
                m_Acdcode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeCode() As Nullable(Of Long)
            Get
                Return m_GradeCode
            End Get
            Set
                m_GradeCode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentCode() As Nullable(Of Long)
            Get
                Return m_StudentCode
            End Get
            Set
                m_StudentCode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property amounttype() As Nullable(Of Long)
            Get
                Return m_Amounttype
            End Get
            Set
                m_Amounttype = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property instalmmentdutydate() As Nullable(Of DateTime)
            Get
                Return m_Instalmmentdutydate
            End Get
            Set
                m_Instalmmentdutydate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Amount() As Nullable(Of Decimal)
            Get
                Return m_Amount
            End Get
            Set
                m_Amount = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property regacdmicrul() As Nullable(Of Long)
            Get
                Return m_Regacdmicrul
            End Get
            Set
                m_Regacdmicrul = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property transdate() As Nullable(Of DateTime)
            Get
                Return m_Transdate
            End Get
            Set
                m_Transdate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property approved() As Nullable(Of Integer)
            Get
                Return m_Approved
            End Get
            Set
                m_Approved = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ModifiedBy() As String
            Get
                Return m_ModifiedBy
            End Get
            Set
                m_ModifiedBy = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ModifiedOn() As Nullable(Of DateTime)
            Get
                Return m_ModifiedOn
            End Get
            Set
                m_ModifiedOn = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CreatedBy() As String
            Get
                Return m_CreatedBy
            End Get
            Set
                m_CreatedBy = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CreatedOn() As Nullable(Of DateTime)
            Get
                Return m_CreatedOn
            End Get
            Set
                m_CreatedOn = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property FatherCode() As Nullable(Of Long)
            Get
                Return m_FatherCode
            End Get
            Set
                m_FatherCode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property notes1() As String
            Get
                Return m_Notes1
            End Get
            Set
                m_Notes1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property notes2() As String
            Get
                Return m_Notes2
            End Get
            Set
                m_Notes2 = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select]( _
                    ByVal regacdmicnew As Nullable(Of Long),  _
                    ByVal regacdmic As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal amounttype As Nullable(Of Long),  _
                    ByVal instalmmentdutydate As Nullable(Of DateTime),  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal regacdmicrul As Nullable(Of Long),  _
                    ByVal transdate As Nullable(Of DateTime),  _
                    ByVal approved As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal notes1 As String,  _
                    ByVal notes2 As String) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return New schregacdmicnewFactory().Select(regacdmicnew, regacdmic, branch, acdcode, gradeCode, studentCode, amounttype, instalmmentdutydate, amount, regacdmicrul, transdate, approved, modifiedBy, modifiedOn, createdBy, createdOn, fatherCode, notes1, notes2)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schregacdmicnew) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return New schregacdmicnewFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return New schregacdmicnewFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return New schregacdmicnewFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return New schregacdmicnewFactory().Select(filter, sort, schregacdmicnewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return New schregacdmicnewFactory().Select(filter, sort, schregacdmicnewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return New schregacdmicnewFactory().Select(filter, Nothing, schregacdmicnewFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return New schregacdmicnewFactory().Select(filter, Nothing, schregacdmicnewFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schregacdmicnew
            Return New schregacdmicnewFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schregacdmicnew
            Return New schregacdmicnewFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schregacdmicnewFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schregacdmicnew")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schregacdmicnew")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schregacdmicnew")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schregacdmicnew")
            End Get
        End Property
        
        Public Shared Function Create() As schregacdmicnewFactory
            Return New schregacdmicnewFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal regacdmicnew As Nullable(Of Long),  _
                    ByVal regacdmic As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal amounttype As Nullable(Of Long),  _
                    ByVal instalmmentdutydate As Nullable(Of DateTime),  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal regacdmicrul As Nullable(Of Long),  _
                    ByVal transdate As Nullable(Of DateTime),  _
                    ByVal approved As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal notes1 As String,  _
                    ByVal notes2 As String,  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If regacdmicnew.HasValue Then
                filter.Add(("regacdmicnew:=" + regacdmicnew.Value.ToString()))
            End If
            If regacdmic.HasValue Then
                filter.Add(("regacdmic:=" + regacdmic.Value.ToString()))
            End If
            If branch.HasValue Then
                filter.Add(("branch:=" + branch.Value.ToString()))
            End If
            If acdcode.HasValue Then
                filter.Add(("acdcode:=" + acdcode.Value.ToString()))
            End If
            If gradeCode.HasValue Then
                filter.Add(("GradeCode:=" + gradeCode.Value.ToString()))
            End If
            If studentCode.HasValue Then
                filter.Add(("StudentCode:=" + studentCode.Value.ToString()))
            End If
            If amounttype.HasValue Then
                filter.Add(("amounttype:=" + amounttype.Value.ToString()))
            End If
            If instalmmentdutydate.HasValue Then
                filter.Add(("instalmmentdutydate:=" + instalmmentdutydate.Value.ToString()))
            End If
            If amount.HasValue Then
                filter.Add(("Amount:=" + amount.Value.ToString()))
            End If
            If regacdmicrul.HasValue Then
                filter.Add(("regacdmicrul:=" + regacdmicrul.Value.ToString()))
            End If
            If transdate.HasValue Then
                filter.Add(("transdate:=" + transdate.Value.ToString()))
            End If
            If approved.HasValue Then
                filter.Add(("approved:=" + approved.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(modifiedBy)) Then
                filter.Add(("ModifiedBy:*" + modifiedBy))
            End If
            If modifiedOn.HasValue Then
                filter.Add(("ModifiedOn:=" + modifiedOn.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(createdBy)) Then
                filter.Add(("CreatedBy:*" + createdBy))
            End If
            If createdOn.HasValue Then
                filter.Add(("CreatedOn:=" + createdOn.Value.ToString()))
            End If
            If fatherCode.HasValue Then
                filter.Add(("FatherCode:=" + fatherCode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(notes1)) Then
                filter.Add(("notes1:*" + notes1))
            End If
            If Not (String.IsNullOrEmpty(notes2)) Then
                filter.Add(("notes2:*" + notes2))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal regacdmicnew As Nullable(Of Long),  _
                    ByVal regacdmic As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal amounttype As Nullable(Of Long),  _
                    ByVal instalmmentdutydate As Nullable(Of DateTime),  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal regacdmicrul As Nullable(Of Long),  _
                    ByVal transdate As Nullable(Of DateTime),  _
                    ByVal approved As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal notes1 As String,  _
                    ByVal notes2 As String,  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.schregacdmicnew)
            Dim request As PageRequest = CreateRequest(regacdmicnew, regacdmic, branch, acdcode, gradeCode, studentCode, amounttype, instalmmentdutydate, amount, regacdmicrul, transdate, approved, modifiedBy, modifiedOn, createdBy, createdOn, fatherCode, notes1, notes2, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schregacdmicnew", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schregacdmicnew)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schregacdmicnew) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return [Select](qbe.regacdmicnew, qbe.regacdmic, qbe.branch, qbe.acdcode, qbe.GradeCode, qbe.StudentCode, qbe.amounttype, qbe.instalmmentdutydate, qbe.Amount, qbe.regacdmicrul, qbe.transdate, qbe.approved, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn, qbe.FatherCode, qbe.notes1, qbe.notes2)
        End Function
        
        Public Function SelectCount( _
                    ByVal regacdmicnew As Nullable(Of Long),  _
                    ByVal regacdmic As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal amounttype As Nullable(Of Long),  _
                    ByVal instalmmentdutydate As Nullable(Of DateTime),  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal regacdmicrul As Nullable(Of Long),  _
                    ByVal transdate As Nullable(Of DateTime),  _
                    ByVal approved As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal notes1 As String,  _
                    ByVal notes2 As String,  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(regacdmicnew, regacdmic, branch, acdcode, gradeCode, studentCode, amounttype, instalmmentdutydate, amount, regacdmicrul, transdate, approved, modifiedBy, modifiedOn, createdBy, createdOn, fatherCode, notes1, notes2, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schregacdmicnew", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal regacdmicnew As Nullable(Of Long),  _
                    ByVal regacdmic As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal amounttype As Nullable(Of Long),  _
                    ByVal instalmmentdutydate As Nullable(Of DateTime),  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal regacdmicrul As Nullable(Of Long),  _
                    ByVal transdate As Nullable(Of DateTime),  _
                    ByVal approved As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal notes1 As String,  _
                    ByVal notes2 As String) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return [Select](regacdmicnew, regacdmic, branch, acdcode, gradeCode, studentCode, amounttype, instalmmentdutydate, amount, regacdmicrul, transdate, approved, modifiedBy, modifiedOn, createdBy, createdOn, fatherCode, notes1, notes2, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicnew)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schregacdmicnew", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schregacdmicnew)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicnew)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schregacdmicnew
            Dim list As List(Of eZee.Data.Objects.schregacdmicnew) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
