<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Questions_1.aspx.vb" Inherits="Pages_Questions_1"  Title="Questions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Questions</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Questions" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Answers">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Answers" view="grid1" FilterSource="view1Extender" FilterFields="ForQuestionId" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowModalForms="True" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows questions management.</div>
    </div>
  </div>
</asp:Content>