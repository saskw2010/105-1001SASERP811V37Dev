<%@ Control Language="VB" AutoEventWireup="false" CodeFile="MysiteUserControl.ascx.vb" Inherits="Controls_MysiteUserControl" %>
<%--<dxwschs:ASPxScheduler runat="server" AppointmentDataSourceID="SqlDataSource1" ClientIDMode="AutoID" ResourceDataSourceID="SqlDataSource2" Start="2015-03-14" Theme="Office2010Blue">
    <Storage>
        <Appointments AutoRetrieveId="True">
            <Mappings AllDay="AllDay" AppointmentId="UniqueID" Description="Description" End="EndDate" Label="Label" Location="Location" RecurrenceInfo="RecurrenceInfo" ReminderInfo="ReminderInfo" ResourceId="ResourceID" Start="StartDate" Status="Status" Subject="Subject" Type="Type" />
            <CustomFieldMappings>
                <dxwschs:ASPxAppointmentCustomFieldMapping Member="ResourceIDs" Name="ResourceIDs" />
                <dxwschs:ASPxAppointmentCustomFieldMapping Member="CustomField1" Name="CustomField1" />
            </CustomFieldMappings>
        </Appointments>
        <Resources>
            <Mappings Caption="ResourceName" Color="Color" Image="Image" ResourceId="ResourceID" />
        </Resources>
    </Storage>
<Views>
<DayView><TimeRulers>
<cc1:TimeRuler></cc1:TimeRuler>
</TimeRulers>
</DayView>

<WorkWeekView><TimeRulers>
<cc1:TimeRuler></cc1:TimeRuler>
</TimeRulers>
</WorkWeekView>
</Views>
</dxwschs:ASPxScheduler>--%>
<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ezee %>" SelectCommand="SELECT * FROM [Resources]"></asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ezee %>" DeleteCommand="DELETE FROM [Appointments] WHERE [UniqueID] = @UniqueID" InsertCommand="INSERT INTO [Appointments] ([Type], [StartDate], [EndDate], [AllDay], [Subject], [Location], [Description], [Status], [Label], [ResourceID], [ResourceIDs], [ReminderInfo], [RecurrenceInfo], [CustomField1]) VALUES (@Type, @StartDate, @EndDate, @AllDay, @Subject, @Location, @Description, @Status, @Label, @ResourceID, @ResourceIDs, @ReminderInfo, @RecurrenceInfo, @CustomField1)" SelectCommand="SELECT * FROM [Appointments]" UpdateCommand="UPDATE [Appointments] SET [Type] = @Type, [StartDate] = @StartDate, [EndDate] = @EndDate, [AllDay] = @AllDay, [Subject] = @Subject, [Location] = @Location, [Description] = @Description, [Status] = @Status, [Label] = @Label, [ResourceID] = @ResourceID, [ResourceIDs] = @ResourceIDs, [ReminderInfo] = @ReminderInfo, [RecurrenceInfo] = @RecurrenceInfo, [CustomField1] = @CustomField1 WHERE [UniqueID] = @UniqueID">
    <DeleteParameters>
        <asp:Parameter Name="UniqueID" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Type" Type="Int32" />
        <asp:Parameter Name="StartDate" Type="DateTime" />
        <asp:Parameter Name="EndDate" Type="DateTime" />
        <asp:Parameter Name="AllDay" Type="Boolean" />
        <asp:Parameter Name="Subject" Type="String" />
        <asp:Parameter Name="Location" Type="String" />
        <asp:Parameter Name="Description" Type="String" />
        <asp:Parameter Name="Status" Type="Int32" />
        <asp:Parameter Name="Label" Type="Int32" />
        <asp:Parameter Name="ResourceID" Type="Int32" />
        <asp:Parameter Name="ResourceIDs" Type="String" />
        <asp:Parameter Name="ReminderInfo" Type="String" />
        <asp:Parameter Name="RecurrenceInfo" Type="String" />
        <asp:Parameter Name="CustomField1" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Type" Type="Int32" />
        <asp:Parameter Name="StartDate" Type="DateTime" />
        <asp:Parameter Name="EndDate" Type="DateTime" />
        <asp:Parameter Name="AllDay" Type="Boolean" />
        <asp:Parameter Name="Subject" Type="String" />
        <asp:Parameter Name="Location" Type="String" />
        <asp:Parameter Name="Description" Type="String" />
        <asp:Parameter Name="Status" Type="Int32" />
        <asp:Parameter Name="Label" Type="Int32" />
        <asp:Parameter Name="ResourceID" Type="Int32" />
        <asp:Parameter Name="ResourceIDs" Type="String" />
        <asp:Parameter Name="ReminderInfo" Type="String" />
        <asp:Parameter Name="RecurrenceInfo" Type="String" />
        <asp:Parameter Name="CustomField1" Type="String" />
        <asp:Parameter Name="UniqueID" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>

