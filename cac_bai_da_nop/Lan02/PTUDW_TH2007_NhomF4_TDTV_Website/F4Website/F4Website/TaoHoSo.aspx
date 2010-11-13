<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/F4.Master" CodeBehind="TaoHoSo.aspx.cs" Inherits="F4Website.TaoHoSoPage.TaoHoSo" %>

<%@ Register src="UserControl/SubBody.ascx" tagname="SubBody" tagprefix="uc1" %>

<asp:Content ID="TaoHoSoContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:SubBody ID="SubBody1" runat="server" />
</asp:Content>
