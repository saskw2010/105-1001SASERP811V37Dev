<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Member.aspx.vb" Inherits="Pages_Member"  Title="Member" %>
<%@ Register Src="../Controls/MembershipManager.ascx" TagName="MembershipManager"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Member</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow" style="padding-top:15px">
      <uc:MembershipManager ID="control1" runat="server"></uc:MembershipManager></div>
</asp:Content>