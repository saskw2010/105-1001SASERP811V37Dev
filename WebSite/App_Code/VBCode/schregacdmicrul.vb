Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schregacdmicrul
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Regacdmicrul As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Thebranchsgmsgm_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchsgmOpcoOpcoName As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchGenderGender As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchstageShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchschtypschtypDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Acdcode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdAcademicYear As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdGlFinperiodFin_period_info As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdGlFinperiodaccountnumberAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeacdAcademicYear As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeacdGlFinperiodFin_period_info As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeStageShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amount As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amounttype As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amounttypeschpaymenttypenm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AmounttypedebitaccountAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AmounttypedebitaccountClsacc_Acc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AmounttypedebitaccountAcc_BndAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AmounttypecreditaccountAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AmounttypecreditaccountClsacc_Acc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AmounttypecreditaccountAcc_BndAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Instalmmentdutydate As Nullable(Of DateTime)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property regacdmicrul() As Nullable(Of Long)
            Get
                Return m_Regacdmicrul
            End Get
            Set
                m_Regacdmicrul = value
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
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchDesc1() As String
            Get
                Return m_ThebranchDesc1
            End Get
            Set
                m_ThebranchDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Thebranchsgmsgm_Nm() As String
            Get
                Return m_Thebranchsgmsgm_Nm
            End Get
            Set
                m_Thebranchsgmsgm_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchsgmOpcoOpcoName() As String
            Get
                Return m_ThebranchsgmOpcoOpcoName
            End Get
            Set
                m_ThebranchsgmOpcoOpcoName = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchGenderGender() As String
            Get
                Return m_ThebranchGenderGender
            End Get
            Set
                m_ThebranchGenderGender = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchstageShortDesc1() As String
            Get
                Return m_ThebranchstageShortDesc1
            End Get
            Set
                m_ThebranchstageShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchschtypschtypDesc() As String
            Get
                Return m_ThebranchschtypschtypDesc
            End Get
            Set
                m_ThebranchschtypschtypDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property acdcode() As Nullable(Of Long)
            Get
                Return m_Acdcode
            End Get
            Set
                m_Acdcode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property acdAcademicYear() As String
            Get
                Return m_AcdAcademicYear
            End Get
            Set
                m_AcdAcademicYear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property acdGlFinperiodFin_period_info() As String
            Get
                Return m_AcdGlFinperiodFin_period_info
            End Get
            Set
                m_AcdGlFinperiodFin_period_info = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property acdGlFinperiodaccountnumberAcc_Nm() As String
            Get
                Return m_AcdGlFinperiodaccountnumberAcc_Nm
            End Get
            Set
                m_AcdGlFinperiodaccountnumberAcc_Nm = value
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
        Public Property GradeShortDesc1() As String
            Get
                Return m_GradeShortDesc1
            End Get
            Set
                m_GradeShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeacdAcademicYear() As String
            Get
                Return m_GradeacdAcademicYear
            End Get
            Set
                m_GradeacdAcademicYear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeacdGlFinperiodFin_period_info() As String
            Get
                Return m_GradeacdGlFinperiodFin_period_info
            End Get
            Set
                m_GradeacdGlFinperiodFin_period_info = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeStageShortDesc1() As String
            Get
                Return m_GradeStageShortDesc1
            End Get
            Set
                m_GradeStageShortDesc1 = value
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
        Public Property amounttype() As Nullable(Of Long)
            Get
                Return m_Amounttype
            End Get
            Set
                m_Amounttype = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property amounttypeschpaymenttypenm() As String
            Get
                Return m_Amounttypeschpaymenttypenm
            End Get
            Set
                m_Amounttypeschpaymenttypenm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property amounttypedebitaccountAcc_Nm() As String
            Get
                Return m_AmounttypedebitaccountAcc_Nm
            End Get
            Set
                m_AmounttypedebitaccountAcc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property amounttypedebitaccountClsacc_Acc_Nm() As String
            Get
                Return m_AmounttypedebitaccountClsacc_Acc_Nm
            End Get
            Set
                m_AmounttypedebitaccountClsacc_Acc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property amounttypedebitaccountAcc_BndAcc_Nm() As String
            Get
                Return m_AmounttypedebitaccountAcc_BndAcc_Nm
            End Get
            Set
                m_AmounttypedebitaccountAcc_BndAcc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property amounttypecreditaccountAcc_Nm() As String
            Get
                Return m_AmounttypecreditaccountAcc_Nm
            End Get
            Set
                m_AmounttypecreditaccountAcc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property amounttypecreditaccountClsacc_Acc_Nm() As String
            Get
                Return m_AmounttypecreditaccountClsacc_Acc_Nm
            End Get
            Set
                m_AmounttypecreditaccountClsacc_Acc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property amounttypecreditaccountAcc_BndAcc_Nm() As String
            Get
                Return m_AmounttypecreditaccountAcc_BndAcc_Nm
            End Get
            Set
                m_AmounttypecreditaccountAcc_BndAcc_Nm = value
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
        
        Public Overloads Shared Function [Select]( _
                    ByVal regacdmicrul As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal amounttype As Nullable(Of Long),  _
                    ByVal amounttypeschpaymenttypenm As String,  _
                    ByVal amounttypedebitaccountAcc_Nm As String,  _
                    ByVal amounttypedebitaccountClsacc_Acc_Nm As String,  _
                    ByVal amounttypedebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal amounttypecreditaccountAcc_Nm As String,  _
                    ByVal amounttypecreditaccountClsacc_Acc_Nm As String,  _
                    ByVal amounttypecreditaccountAcc_BndAcc_Nm As String,  _
                    ByVal instalmmentdutydate As Nullable(Of DateTime)) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return New schregacdmicrulFactory().Select(regacdmicrul, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, amount, amounttype, amounttypeschpaymenttypenm, amounttypedebitaccountAcc_Nm, amounttypedebitaccountClsacc_Acc_Nm, amounttypedebitaccountAcc_BndAcc_Nm, amounttypecreditaccountAcc_Nm, amounttypecreditaccountClsacc_Acc_Nm, amounttypecreditaccountAcc_BndAcc_Nm, instalmmentdutydate)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schregacdmicrul) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return New schregacdmicrulFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return New schregacdmicrulFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return New schregacdmicrulFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return New schregacdmicrulFactory().Select(filter, sort, schregacdmicrulFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return New schregacdmicrulFactory().Select(filter, sort, schregacdmicrulFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return New schregacdmicrulFactory().Select(filter, Nothing, schregacdmicrulFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return New schregacdmicrulFactory().Select(filter, Nothing, schregacdmicrulFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schregacdmicrul
            Return New schregacdmicrulFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schregacdmicrul
            Return New schregacdmicrulFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal regacdmicrul As Nullable(Of Long)) As eZee.Data.Objects.schregacdmicrul
            Return New schregacdmicrulFactory().SelectSingle(regacdmicrul)
        End Function
        
        Public Function Insert() As Integer
            Return New schregacdmicrulFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New schregacdmicrulFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New schregacdmicrulFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("regacdmicrul: {0}", Me.regacdmicrul)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schregacdmicrulFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schregacdmicrul")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schregacdmicrul")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schregacdmicrul")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schregacdmicrul")
            End Get
        End Property
        
        Public Shared Function Create() As schregacdmicrulFactory
            Return New schregacdmicrulFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal regacdmicrul As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal amounttype As Nullable(Of Long),  _
                    ByVal amounttypeschpaymenttypenm As String,  _
                    ByVal amounttypedebitaccountAcc_Nm As String,  _
                    ByVal amounttypedebitaccountClsacc_Acc_Nm As String,  _
                    ByVal amounttypedebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal amounttypecreditaccountAcc_Nm As String,  _
                    ByVal amounttypecreditaccountClsacc_Acc_Nm As String,  _
                    ByVal amounttypecreditaccountAcc_BndAcc_Nm As String,  _
                    ByVal instalmmentdutydate As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If regacdmicrul.HasValue Then
                filter.Add(("regacdmicrul:=" + regacdmicrul.Value.ToString()))
            End If
            If branch.HasValue Then
                filter.Add(("branch:=" + branch.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(thebranchDesc1)) Then
                filter.Add(("ThebranchDesc1:*" + thebranchDesc1))
            End If
            If Not (String.IsNullOrEmpty(thebranchsgmsgm_Nm)) Then
                filter.Add(("Thebranchsgmsgm_Nm:*" + thebranchsgmsgm_Nm))
            End If
            If Not (String.IsNullOrEmpty(thebranchsgmOpcoOpcoName)) Then
                filter.Add(("ThebranchsgmOpcoOpcoName:*" + thebranchsgmOpcoOpcoName))
            End If
            If Not (String.IsNullOrEmpty(thebranchGenderGender)) Then
                filter.Add(("ThebranchGenderGender:*" + thebranchGenderGender))
            End If
            If Not (String.IsNullOrEmpty(thebranchstageShortDesc1)) Then
                filter.Add(("ThebranchstageShortDesc1:*" + thebranchstageShortDesc1))
            End If
            If Not (String.IsNullOrEmpty(thebranchschtypschtypDesc)) Then
                filter.Add(("ThebranchschtypschtypDesc:*" + thebranchschtypschtypDesc))
            End If
            If acdcode.HasValue Then
                filter.Add(("acdcode:=" + acdcode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(acdAcademicYear)) Then
                filter.Add(("acdAcademicYear:*" + acdAcademicYear))
            End If
            If Not (String.IsNullOrEmpty(acdGlFinperiodFin_period_info)) Then
                filter.Add(("acdGlFinperiodFin_period_info:*" + acdGlFinperiodFin_period_info))
            End If
            If Not (String.IsNullOrEmpty(acdGlFinperiodaccountnumberAcc_Nm)) Then
                filter.Add(("acdGlFinperiodaccountnumberAcc_Nm:*" + acdGlFinperiodaccountnumberAcc_Nm))
            End If
            If gradeCode.HasValue Then
                filter.Add(("GradeCode:=" + gradeCode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(gradeShortDesc1)) Then
                filter.Add(("GradeShortDesc1:*" + gradeShortDesc1))
            End If
            If Not (String.IsNullOrEmpty(gradeacdAcademicYear)) Then
                filter.Add(("GradeacdAcademicYear:*" + gradeacdAcademicYear))
            End If
            If Not (String.IsNullOrEmpty(gradeacdGlFinperiodFin_period_info)) Then
                filter.Add(("GradeacdGlFinperiodFin_period_info:*" + gradeacdGlFinperiodFin_period_info))
            End If
            If Not (String.IsNullOrEmpty(gradeStageShortDesc1)) Then
                filter.Add(("GradeStageShortDesc1:*" + gradeStageShortDesc1))
            End If
            If amount.HasValue Then
                filter.Add(("Amount:=" + amount.Value.ToString()))
            End If
            If amounttype.HasValue Then
                filter.Add(("amounttype:=" + amounttype.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(amounttypeschpaymenttypenm)) Then
                filter.Add(("amounttypeschpaymenttypenm:*" + amounttypeschpaymenttypenm))
            End If
            If Not (String.IsNullOrEmpty(amounttypedebitaccountAcc_Nm)) Then
                filter.Add(("amounttypedebitaccountAcc_Nm:*" + amounttypedebitaccountAcc_Nm))
            End If
            If Not (String.IsNullOrEmpty(amounttypedebitaccountClsacc_Acc_Nm)) Then
                filter.Add(("amounttypedebitaccountClsacc_Acc_Nm:*" + amounttypedebitaccountClsacc_Acc_Nm))
            End If
            If Not (String.IsNullOrEmpty(amounttypedebitaccountAcc_BndAcc_Nm)) Then
                filter.Add(("amounttypedebitaccountAcc_BndAcc_Nm:*" + amounttypedebitaccountAcc_BndAcc_Nm))
            End If
            If Not (String.IsNullOrEmpty(amounttypecreditaccountAcc_Nm)) Then
                filter.Add(("amounttypecreditaccountAcc_Nm:*" + amounttypecreditaccountAcc_Nm))
            End If
            If Not (String.IsNullOrEmpty(amounttypecreditaccountClsacc_Acc_Nm)) Then
                filter.Add(("amounttypecreditaccountClsacc_Acc_Nm:*" + amounttypecreditaccountClsacc_Acc_Nm))
            End If
            If Not (String.IsNullOrEmpty(amounttypecreditaccountAcc_BndAcc_Nm)) Then
                filter.Add(("amounttypecreditaccountAcc_BndAcc_Nm:*" + amounttypecreditaccountAcc_BndAcc_Nm))
            End If
            If instalmmentdutydate.HasValue Then
                filter.Add(("instalmmentdutydate:=" + instalmmentdutydate.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal regacdmicrul As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal amounttype As Nullable(Of Long),  _
                    ByVal amounttypeschpaymenttypenm As String,  _
                    ByVal amounttypedebitaccountAcc_Nm As String,  _
                    ByVal amounttypedebitaccountClsacc_Acc_Nm As String,  _
                    ByVal amounttypedebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal amounttypecreditaccountAcc_Nm As String,  _
                    ByVal amounttypecreditaccountClsacc_Acc_Nm As String,  _
                    ByVal amounttypecreditaccountAcc_BndAcc_Nm As String,  _
                    ByVal instalmmentdutydate As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.schregacdmicrul)
            Dim request As PageRequest = CreateRequest(regacdmicrul, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, amount, amounttype, amounttypeschpaymenttypenm, amounttypedebitaccountAcc_Nm, amounttypedebitaccountClsacc_Acc_Nm, amounttypedebitaccountAcc_BndAcc_Nm, amounttypecreditaccountAcc_Nm, amounttypecreditaccountClsacc_Acc_Nm, amounttypecreditaccountAcc_BndAcc_Nm, instalmmentdutydate, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schregacdmicrul", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schregacdmicrul)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schregacdmicrul) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return [Select](qbe.regacdmicrul, qbe.branch, qbe.ThebranchDesc1, qbe.Thebranchsgmsgm_Nm, qbe.ThebranchsgmOpcoOpcoName, qbe.ThebranchGenderGender, qbe.ThebranchstageShortDesc1, qbe.ThebranchschtypschtypDesc, qbe.acdcode, qbe.acdAcademicYear, qbe.acdGlFinperiodFin_period_info, qbe.acdGlFinperiodaccountnumberAcc_Nm, qbe.GradeCode, qbe.GradeShortDesc1, qbe.GradeacdAcademicYear, qbe.GradeacdGlFinperiodFin_period_info, qbe.GradeStageShortDesc1, qbe.Amount, qbe.amounttype, qbe.amounttypeschpaymenttypenm, qbe.amounttypedebitaccountAcc_Nm, qbe.amounttypedebitaccountClsacc_Acc_Nm, qbe.amounttypedebitaccountAcc_BndAcc_Nm, qbe.amounttypecreditaccountAcc_Nm, qbe.amounttypecreditaccountClsacc_Acc_Nm, qbe.amounttypecreditaccountAcc_BndAcc_Nm, qbe.instalmmentdutydate)
        End Function
        
        Public Function SelectCount( _
                    ByVal regacdmicrul As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal amounttype As Nullable(Of Long),  _
                    ByVal amounttypeschpaymenttypenm As String,  _
                    ByVal amounttypedebitaccountAcc_Nm As String,  _
                    ByVal amounttypedebitaccountClsacc_Acc_Nm As String,  _
                    ByVal amounttypedebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal amounttypecreditaccountAcc_Nm As String,  _
                    ByVal amounttypecreditaccountClsacc_Acc_Nm As String,  _
                    ByVal amounttypecreditaccountAcc_BndAcc_Nm As String,  _
                    ByVal instalmmentdutydate As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(regacdmicrul, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, amount, amounttype, amounttypeschpaymenttypenm, amounttypedebitaccountAcc_Nm, amounttypedebitaccountClsacc_Acc_Nm, amounttypedebitaccountAcc_BndAcc_Nm, amounttypecreditaccountAcc_Nm, amounttypecreditaccountClsacc_Acc_Nm, amounttypecreditaccountAcc_BndAcc_Nm, instalmmentdutydate, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schregacdmicrul", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal regacdmicrul As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal amounttype As Nullable(Of Long),  _
                    ByVal amounttypeschpaymenttypenm As String,  _
                    ByVal amounttypedebitaccountAcc_Nm As String,  _
                    ByVal amounttypedebitaccountClsacc_Acc_Nm As String,  _
                    ByVal amounttypedebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal amounttypecreditaccountAcc_Nm As String,  _
                    ByVal amounttypecreditaccountClsacc_Acc_Nm As String,  _
                    ByVal amounttypecreditaccountAcc_BndAcc_Nm As String,  _
                    ByVal instalmmentdutydate As Nullable(Of DateTime)) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return [Select](regacdmicrul, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, amount, amounttype, amounttypeschpaymenttypenm, amounttypedebitaccountAcc_Nm, amounttypedebitaccountClsacc_Acc_Nm, amounttypedebitaccountAcc_BndAcc_Nm, amounttypecreditaccountAcc_Nm, amounttypecreditaccountClsacc_Acc_Nm, amounttypecreditaccountAcc_BndAcc_Nm, instalmmentdutydate, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal regacdmicrul As Nullable(Of Long)) As eZee.Data.Objects.schregacdmicrul
            Dim list As List(Of eZee.Data.Objects.schregacdmicrul) = [Select](regacdmicrul, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicrul)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schregacdmicrul", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schregacdmicrul)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicrul)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schregacdmicrul
            Dim list As List(Of eZee.Data.Objects.schregacdmicrul) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theschregacdmicrul As eZee.Data.Objects.schregacdmicrul, ByVal original_schregacdmicrul As eZee.Data.Objects.schregacdmicrul) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("regacdmicrul", original_schregacdmicrul.regacdmicrul, theschregacdmicrul.regacdmicrul, true))
            values.Add(New FieldValue("branch", original_schregacdmicrul.branch, theschregacdmicrul.branch))
            values.Add(New FieldValue("ThebranchDesc1", original_schregacdmicrul.ThebranchDesc1, theschregacdmicrul.ThebranchDesc1, true))
            values.Add(New FieldValue("Thebranchsgmsgm_Nm", original_schregacdmicrul.Thebranchsgmsgm_Nm, theschregacdmicrul.Thebranchsgmsgm_Nm, true))
            values.Add(New FieldValue("ThebranchsgmOpcoOpcoName", original_schregacdmicrul.ThebranchsgmOpcoOpcoName, theschregacdmicrul.ThebranchsgmOpcoOpcoName, true))
            values.Add(New FieldValue("ThebranchGenderGender", original_schregacdmicrul.ThebranchGenderGender, theschregacdmicrul.ThebranchGenderGender, true))
            values.Add(New FieldValue("ThebranchstageShortDesc1", original_schregacdmicrul.ThebranchstageShortDesc1, theschregacdmicrul.ThebranchstageShortDesc1, true))
            values.Add(New FieldValue("ThebranchschtypschtypDesc", original_schregacdmicrul.ThebranchschtypschtypDesc, theschregacdmicrul.ThebranchschtypschtypDesc, true))
            values.Add(New FieldValue("acdcode", original_schregacdmicrul.acdcode, theschregacdmicrul.acdcode))
            values.Add(New FieldValue("acdAcademicYear", original_schregacdmicrul.acdAcademicYear, theschregacdmicrul.acdAcademicYear, true))
            values.Add(New FieldValue("acdGlFinperiodFin_period_info", original_schregacdmicrul.acdGlFinperiodFin_period_info, theschregacdmicrul.acdGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("acdGlFinperiodaccountnumberAcc_Nm", original_schregacdmicrul.acdGlFinperiodaccountnumberAcc_Nm, theschregacdmicrul.acdGlFinperiodaccountnumberAcc_Nm, true))
            values.Add(New FieldValue("GradeCode", original_schregacdmicrul.GradeCode, theschregacdmicrul.GradeCode))
            values.Add(New FieldValue("GradeShortDesc1", original_schregacdmicrul.GradeShortDesc1, theschregacdmicrul.GradeShortDesc1, true))
            values.Add(New FieldValue("GradeacdAcademicYear", original_schregacdmicrul.GradeacdAcademicYear, theschregacdmicrul.GradeacdAcademicYear, true))
            values.Add(New FieldValue("GradeacdGlFinperiodFin_period_info", original_schregacdmicrul.GradeacdGlFinperiodFin_period_info, theschregacdmicrul.GradeacdGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("GradeStageShortDesc1", original_schregacdmicrul.GradeStageShortDesc1, theschregacdmicrul.GradeStageShortDesc1, true))
            values.Add(New FieldValue("Amount", original_schregacdmicrul.Amount, theschregacdmicrul.Amount))
            values.Add(New FieldValue("amounttype", original_schregacdmicrul.amounttype, theschregacdmicrul.amounttype))
            values.Add(New FieldValue("amounttypeschpaymenttypenm", original_schregacdmicrul.amounttypeschpaymenttypenm, theschregacdmicrul.amounttypeschpaymenttypenm, true))
            values.Add(New FieldValue("amounttypedebitaccountAcc_Nm", original_schregacdmicrul.amounttypedebitaccountAcc_Nm, theschregacdmicrul.amounttypedebitaccountAcc_Nm, true))
            values.Add(New FieldValue("amounttypedebitaccountClsacc_Acc_Nm", original_schregacdmicrul.amounttypedebitaccountClsacc_Acc_Nm, theschregacdmicrul.amounttypedebitaccountClsacc_Acc_Nm, true))
            values.Add(New FieldValue("amounttypedebitaccountAcc_BndAcc_Nm", original_schregacdmicrul.amounttypedebitaccountAcc_BndAcc_Nm, theschregacdmicrul.amounttypedebitaccountAcc_BndAcc_Nm, true))
            values.Add(New FieldValue("amounttypecreditaccountAcc_Nm", original_schregacdmicrul.amounttypecreditaccountAcc_Nm, theschregacdmicrul.amounttypecreditaccountAcc_Nm, true))
            values.Add(New FieldValue("amounttypecreditaccountClsacc_Acc_Nm", original_schregacdmicrul.amounttypecreditaccountClsacc_Acc_Nm, theschregacdmicrul.amounttypecreditaccountClsacc_Acc_Nm, true))
            values.Add(New FieldValue("amounttypecreditaccountAcc_BndAcc_Nm", original_schregacdmicrul.amounttypecreditaccountAcc_BndAcc_Nm, theschregacdmicrul.amounttypecreditaccountAcc_BndAcc_Nm, true))
            values.Add(New FieldValue("instalmmentdutydate", original_schregacdmicrul.instalmmentdutydate, theschregacdmicrul.instalmmentdutydate))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theschregacdmicrul As eZee.Data.Objects.schregacdmicrul, ByVal original_schregacdmicrul As eZee.Data.Objects.schregacdmicrul, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "schregacdmicrul"
            args.View = dataView
            args.Values = CreateFieldValues(theschregacdmicrul, original_schregacdmicrul)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("schregacdmicrul", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theschregacdmicrul)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theschregacdmicrul As eZee.Data.Objects.schregacdmicrul, ByVal original_schregacdmicrul As eZee.Data.Objects.schregacdmicrul) As Integer
            Return ExecuteAction(theschregacdmicrul, original_schregacdmicrul, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theschregacdmicrul As eZee.Data.Objects.schregacdmicrul) As Integer
            Return Update(theschregacdmicrul, SelectSingle(theschregacdmicrul.regacdmicrul))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theschregacdmicrul As eZee.Data.Objects.schregacdmicrul) As Integer
            Return ExecuteAction(theschregacdmicrul, New schregacdmicrul(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theschregacdmicrul As eZee.Data.Objects.schregacdmicrul) As Integer
            Return ExecuteAction(theschregacdmicrul, theschregacdmicrul, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
